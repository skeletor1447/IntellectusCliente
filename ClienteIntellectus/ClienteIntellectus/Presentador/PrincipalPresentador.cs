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

        PerfilServicios.PerfilServicesClient PerfilServicesClient;

        public PrincipalPresentador(Views.IPrincipal iprincipal, Views.Principal principal)
        {
            this.iprincipal = iprincipal;
            this.principal = principal;
        }

        public void Inicializar(ClienteIntellectus.Views.ControlUsuario.Principal.ControlUsuarioPrincipalPrincipal controlPrincipal)
        {
            try
            {
                PerfilServicesClient = new PerfilServicios.PerfilServicesClient();
            }
            catch (Exception ex)
            {
                iprincipal.MostrarMensajeUsuarioError(ex.Message);
            }

            try
            {
                PerfilServicios.UnicaRespuestaOfPerfilCompuestoqYdlCAL1 resultado = PerfilServicesClient.ConsultarPerfilCompuesto(iprincipal.IdCliente);

                if (!resultado.Error)
                {
                    iprincipal.Perfil = resultado.Entidad;
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
            return iprincipal.Perfil.Usuario.Nick;
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
