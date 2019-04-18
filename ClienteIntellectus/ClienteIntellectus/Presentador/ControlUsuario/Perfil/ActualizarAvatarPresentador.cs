using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteIntellectus.Presentador.ControlUsuario.Perfil
{
    public class ActualizarAvatarPresentador
    {
        Views.ControlUsuario.Perfil.IActualizarAvatar iActualizarAvatar;

        public ActualizarAvatarPresentador(Views.ControlUsuario.Perfil.IActualizarAvatar iActualizarAvatar)
        {
            this.iActualizarAvatar = iActualizarAvatar;
        }

        public void SeleccionarImange()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "images| *.JPG; *.PNG; *.GJF"; // you can add any other image type 
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                iActualizarAvatar.Avatar = Image.FromFile(ofd.FileName);
            }
        }


        public void GuardarCambios()
        {
            try
            {
                PerfilServicios.PerfilServicesClient perfilServicesClient = new PerfilServicios.PerfilServicesClient();

                ImageConverter imageConverter = new ImageConverter();

                ClienteIntellectus.Views.Principal.Perfil.Perfil.Avatar = (byte[])imageConverter.ConvertTo(iActualizarAvatar.Avatar, typeof(byte[]));
                PerfilServicios.ActualizarRespuestaOfPerfilCompuestoqYdlCAL1 resultado = perfilServicesClient.ActualizarPerfilCompuesto(ClienteIntellectus.Views.Principal.Perfil);

                if(!resultado.Error)
                {

                    ClienteIntellectus.Views.Principal.Perfil = resultado.Entidad;

                    using (var ms = new MemoryStream(ClienteIntellectus.Views.Principal.Perfil.Perfil.Avatar))
                    {
                        iActualizarAvatar.Avatar  = Image.FromStream(ms);
                    }
                    
                }
                else
                {
                    iActualizarAvatar.MostrarMensajeUsuarioError(resultado.Errores["Error"]);
                }
            }
            catch(Exception es)
            {
                iActualizarAvatar.MostrarMensajeUsuarioError(es.Message);
            }
        }
    }
}
