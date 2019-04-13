using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClienteIntellectus.Views.ControlUsuario.Amigos.AgregarAmigos;

namespace ClienteIntellectus.Views.ControlUsuario.Amigos
{
    public partial class ControlUsuarioAmigosTarjetaSolicitud : UserControl
    {
        UsuarioServicios.UsuarioAmistad UsuarioAmistad { get; set; }
        UserControl padre;
        public ControlUsuarioAmigosTarjetaSolicitud(UsuarioServicios.UsuarioAmistad usuarioAmistad, UserControl padre)
        {
            InitializeComponent();
            this.UsuarioAmistad = usuarioAmistad;
            this.labelNick.Text = usuarioAmistad.Usuario.Nick;
            this.padre = padre;

            if(usuarioAmistad.SolicitudAmistad != null)
            {
                if(usuarioAmistad.EsSolicitante == true)
                {
                    if (usuarioAmistad.SolicitudAmistad.Estado == "Amigos")
                    {
                        btnAgregar.Text = "Eliminar amigo";
                        btnCancelar.Visible = false;
                    }
                    else
                    {
                        btnAgregar.Text = "Cancelar solicitud";
                        btnCancelar.Visible = false;
                    }
                }
                else if(usuarioAmistad.EsSolicitante == false)
                {
                    if (usuarioAmistad.SolicitudAmistad.Estado == "Amigos")
                    {
                        btnAgregar.Text = "Eliminar amigo";
                        btnCancelar.Visible = false;
                    }
                    else
                    {
                        btnAgregar.Text = "Aceptar solicitud";
                        btnCancelar.Visible = true;
                        btnCancelar.Text = "Rechazar solicitud";
                    }
                }
                else
                {
                    btnAgregar.Text = "Eliminar amigo";
                    btnCancelar.Visible = false;
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
            switch(btnAgregar.Text)
            {
                case "Enviar solicitud":
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
                    break;

                case "Aceptar solicitud":
                    try
                    {
                        AmigosServicios.AmigosServicesClient amigosServicesClient = new AmigosServicios.AmigosServicesClient();

                        AmigosServicios.ActualizarRespuestaOfSolicitudAmistadqYdlCAL1 respuesta = amigosServicesClient.AceptarSolicitud((int)UsuarioAmistad.SolicitudAmistad.IdSolicitudAmistad);

                        if (!respuesta.Error)
                        {
                            btnAgregar.Text = "Eliminar amigo";

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
                    break;
                case "Eliminar amigo":
                    try
                    {
                        AmigosServicios.AmigosServicesClient amigosServicesClient = new AmigosServicios.AmigosServicesClient();

                        AmigosServicios.EliminarRespuestaOfSolicitudAmistadqYdlCAL1 respuesta = amigosServicesClient.EliminarSolicitud((int)UsuarioAmistad.SolicitudAmistad.IdSolicitudAmistad);

                        if (!respuesta.Error)
                        {
                            btnAgregar.Text = "Enviar solicitud";

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
                    break;

                case "Cancelar solicitud":
                case "Rechazar solicitud":
                    try
                    {
                        AmigosServicios.AmigosServicesClient amigosServicesClient = new AmigosServicios.AmigosServicesClient();

                        AmigosServicios.EliminarRespuestaOfSolicitudAmistadqYdlCAL1 respuesta = amigosServicesClient.EliminarSolicitud((int)UsuarioAmistad.SolicitudAmistad.IdSolicitudAmistad);

                        if (!respuesta.Error)
                        {
                            btnAgregar.Text = "Enviar solicitud";

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
                    break;
            }
            btnAgregar.Enabled = true;

            if (padre is ControlUsuarioAmigosAgregarAmigosPrincipal)
            {
                (padre as ControlUsuarioAmigosAgregarAmigosPrincipal).txtBuscarAlumno_TextChanged(null, null);
            }
            else if(padre is ControlUsuarioAmigosPrincipal)
            {
                (padre as ControlUsuarioAmigosPrincipal).btnSolicitudPendiente_Click(null,null);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            try
            {
                AmigosServicios.AmigosServicesClient amigosServicesClient = new AmigosServicios.AmigosServicesClient();

                AmigosServicios.EliminarRespuestaOfSolicitudAmistadqYdlCAL1 respuesta = amigosServicesClient.EliminarSolicitud((int)UsuarioAmistad.SolicitudAmistad.IdSolicitudAmistad);

                if (!respuesta.Error)
                {
                    btnAgregar.Text = "Enviar solicitud";
                    btnCancelar.Visible = false;
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
            btnCancelar.Enabled = true;

            if (padre is ControlUsuarioAmigosAgregarAmigosPrincipal)
            {
                (padre as ControlUsuarioAmigosAgregarAmigosPrincipal).txtBuscarAlumno_TextChanged(null, null);
            }
            else if (padre is ControlUsuarioAmigosPrincipal)
            {
                (padre as ControlUsuarioAmigosPrincipal).btnSolicitudPendiente_Click(null, null);
            }
        }
    }
}
