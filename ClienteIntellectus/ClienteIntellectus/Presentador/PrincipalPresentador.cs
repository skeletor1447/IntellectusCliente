using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ClienteIntellectus.Presentador
{
    public class PrincipalPresentador
    {
        Views.IPrincipal iprincipal;
        Views.Principal principal;
       UsuarioServicios.UsuarioServicesClient usuarioServiceClient;

        public PrincipalPresentador(Views.IPrincipal iprincipal, Views.Principal principal)
        {
            this.iprincipal = iprincipal;
            this.principal = principal;
        }

        public void Inicializar(ClienteIntellectus.Views.ControlUsuario.Principal.ControlUsuarioPrincipalPrincipal controlPrincipal)
        {
            try
            {
                usuarioServiceClient = new UsuarioServicios.UsuarioServicesClient();
            }
            catch (Exception ex)
            {
                iprincipal.MostrarMensajeUsuarioError(ex.Message);
            }

            try
            {
                UsuarioServicios.UnicaRespuestaOfUsuarioqYdlCAL1 resultado = usuarioServiceClient.Consultar(iprincipal.IdCliente);

                if (!resultado.Error)
                {
                    iprincipal.Usuario = resultado.Entidad;
                }
                else
                {
                    iprincipal.MostrarMensajeUsuarioError(resultado.Errores["Error"]);
                }
            }
            catch(Exception es)
            {
                iprincipal.MostrarMensajeUsuarioError(es.Message);
            }

            controlPrincipal.BringToFront();
        }
        
        public String GetNick()
        {
            return iprincipal.Usuario.Nick;
        }

        public void AjustarLabelAlTexto(System.Windows.Forms.Label label,String texto)
        {
            label.Text = texto;

            using (Graphics g = principal.CreateGraphics())
            {
                SizeF size = g.MeasureString(label.Text, label.Font, int.MaxValue);
                label.Width = (int)Math.Ceiling(size.Width);
                label.Text = label.Text;
            }
        }
    }
}
