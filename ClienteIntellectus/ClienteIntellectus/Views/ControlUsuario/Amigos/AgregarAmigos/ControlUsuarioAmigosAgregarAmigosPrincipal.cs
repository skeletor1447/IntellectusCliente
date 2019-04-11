using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteIntellectus.Views.ControlUsuario.Amigos.AgregarAmigos
{
    public partial class ControlUsuarioAmigosAgregarAmigosPrincipal : UserControl
    {
        public ControlUsuarioAmigosAgregarAmigosPrincipal()
        {
            InitializeComponent();

            
        }

        private void txtBuscarAlumno_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            if (txtBuscarAlumno.Text.Trim() == String.Empty)
                return;
            
            try
            {
                UsuarioServicios.UsuarioServicesClient usuarioServices = new UsuarioServicios.UsuarioServicesClient();

                UsuarioServicios.MultipleRespuestaOfUsuarioqYdlCAL1 respuesta = usuarioServices.ConsultarPorBusqueda(txtBuscarAlumno.Text);

                if(!respuesta.Error)
                {
                    try
                    {
                        AmigosServicios.AmigosServicesClient amigosServicesClient = new AmigosServicios.AmigosServicesClient();
                        AmigosServicios.MultipleRespuestaOfSolicitudAmistadqYdlCAL1 resultadoSolicitud = amigosServicesClient.ConsultarSolicitudesEnviadas((int)ClienteIntellectus.Views.Principal.ID);

                        if (!resultadoSolicitud.Error)
                        {

                            List<UsuarioServicios.Usuario> listaBusqueda = respuesta.Entidades.Where(x => x.ID != ClienteIntellectus.Views.Principal.ID).ToList();
                            List<AmigosServicios.SolicitudAmistad> solicitudAmistadEnviadas = resultadoSolicitud.Entidades.ToList();

                            List<UsuarioServicios.Usuario> listaMatch = listaBusqueda.Where(x => solicitudAmistadEnviadas.Exists(y => y.IdSolicitado == x.ID)).ToList();

                            

                            foreach (var usuario in listaBusqueda)
                            {
                                ControlUsuarioAmigosTarjetaSolicitud cuats = new ControlUsuarioAmigosTarjetaSolicitud(usuario.Nick, usuario.ID);

                                foreach(var match in listaMatch)
                                {
                                    if(cuats.IDAlumno == match.ID)
                                    {
                                        cuats.Pendiente = true;
                                        cuats.btnAgregar.Text = "Cancelar solicitud";
                                        listaMatch.Remove(match);
                                        break;
                                    }
                                }

                                flowLayoutPanel1.Controls.Add(cuats);
                            }

                            
                        }
                        else
                        {
                            MessageBox.Show(resultadoSolicitud.Errores["Error"]);
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
