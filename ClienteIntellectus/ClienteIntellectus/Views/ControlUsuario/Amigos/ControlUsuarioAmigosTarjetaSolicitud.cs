using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteIntellectus.Views.ControlUsuario.Amigos
{
    public partial class ControlUsuarioAmigosTarjetaSolicitud : UserControl
    {
        UsuarioServicios.UsuarioAmistad UsuarioAmistad { get; set; }
        public ControlUsuarioAmigosTarjetaSolicitud(UsuarioServicios.UsuarioAmistad usuarioAmistad)
        {
            InitializeComponent();
            this.UsuarioAmistad = usuarioAmistad;
            this.labelNick.Text = usuarioAmistad.Usuario.Nick;

            if(usuarioAmistad.SolicitudAmistad != null)
            {
                if(usuarioAmistad.EsSolicitante == true)
                {
                    if (usuarioAmistad.SolicitudAmistad.Estado == "Amigos")
                        btnAgregar.Text = "Eliminar amigo";
                    else
                        btnAgregar.Text = "Cancelar solicitud";
                }
                else if(usuarioAmistad.EsSolicitante == false)
                {
                    btnAgregar.Text = "Aceptar solicitud";
                }
            }
            else
            {
                if(usuarioAmistad.Usuario.ID == ClienteIntellectus.Views.Principal.ID)
                {
                    btnAgregar.Text = "Tú";
                    btnAgregar.Enabled = false;
                }
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            btnAgregar.Enabled = false;
            if (UsuarioAmistad.SolicitudAmistad == null)//no tiene una solicitud enviada
            {
                try
                {
                    AmigosServicios.AmigosServicesClient amigosServicesClient = new AmigosServicios.AmigosServicesClient();

                    AmigosServicios.InsertarRespuesta respuesta = amigosServicesClient.SolicitudDeAmistad((int)ClienteIntellectus.Views.Principal.ID, (int)UsuarioAmistad.Usuario.ID);

                    if (!respuesta.Error)
                    {
                        btnAgregar.Text = "Cancelar solicitud";
                        
                    }
                    else
                    {
                        MessageBox.Show(respuesta.Errores["Error"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else// tiene una solicitud enviada, el boton tiene como texto Cancelar solicitud
            {

            }
            btnAgregar.Enabled = true;
        }
    }
}
