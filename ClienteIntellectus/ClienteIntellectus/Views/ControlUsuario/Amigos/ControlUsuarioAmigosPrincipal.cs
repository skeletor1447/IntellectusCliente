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
    public partial class ControlUsuarioAmigosPrincipal : UserControl
    {
        public ControlUsuarioAmigosPrincipal()
        {
            InitializeComponent();
        }

        private void btnAgregarAmigos_Click(object sender, EventArgs e)
        {
            controlUsuarioAmigosAgregarAmigosPrincipal1.BringToFront();
            ActualizarListaAmigos();
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            controlUsuarioAmigosChatChat1.BringToFront();
            ActualizarListaAmigos();
        }

        public void btnSolicitudPendiente_Click(object sender, EventArgs e)
        {
            ActualizarListaAmigos();
            controlUsuarioAmigosSolicitudPendientePrincipal1.BringToFront();
            controlUsuarioAmigosSolicitudPendientePrincipal1.flowLayoutPanelEnviadas.Controls.Clear();
            controlUsuarioAmigosSolicitudPendientePrincipal1.flowLayoutPanelPendientes.Controls.Clear();
            try
            {
                UsuarioServicios.UsuarioServicesClient usuarioServicesClient = new UsuarioServicios.UsuarioServicesClient();

                UsuarioServicios.MultipleRespuestaOfUsuarioAmistadqYdlCAL1 _respuesta = usuarioServicesClient.ConsultarSolicitudesPorCliente((int)ClienteIntellectus.Views.Principal.ID);

                if(!_respuesta.Error)
                {
                    foreach( var pendiente in _respuesta.Entidades.Where(x => x.EsSolicitante == true && x.SolicitudAmistad.Estado != "Amigos").ToList())
                    {
                        ControlUsuarioAmigosTarjetaSolicitud cuats = new ControlUsuarioAmigosTarjetaSolicitud(pendiente, this);
                        controlUsuarioAmigosSolicitudPendientePrincipal1.flowLayoutPanelEnviadas.Controls.Add(cuats);
                    }

                   foreach (var recibida in _respuesta.Entidades.Where(x => x.EsSolicitante == false && x.SolicitudAmistad.Estado != "Amigos").ToList())
                   {
                        ControlUsuarioAmigosTarjetaSolicitud cuats = new ControlUsuarioAmigosTarjetaSolicitud(recibida, this);
                        controlUsuarioAmigosSolicitudPendientePrincipal1.flowLayoutPanelPendientes.Controls.Add(cuats);
                   }
                }
                else
                {
                    Console.WriteLine("Hubo error en el servidor");
                    MessageBox.Show(_respuesta.Errores["Error"]);
                }
            }
            catch(Exception ex)
            {
               MessageBox.Show(ex.Message + " " + ex.InnerException);
            }
        }

        public void ActualizarListaAmigos()
        {
            try
            {
                PerfilServicios.PerfilServicesClient perfilServicesClient = new PerfilServicios.PerfilServicesClient();

                PerfilServicios.MultipleRespuestaOfPerfilCompuestoqYdlCAL1 resultado = perfilServicesClient.ObtenerListaAmigosPerfilCompuesto(ClienteIntellectus.Views.Principal.ID);



                if(!resultado.Error)
                {

                    flowLayoutPanelAmigosConectados.Controls.Clear();
                    flowLayoutPanelAmigosDesconectados.Controls.Clear();
                    foreach (var cliente in resultado.Entidades)
                    {
                        ControlUsuarioAmigosTarjetaAmigos cuata = new ControlUsuarioAmigosTarjetaAmigos(cliente);
                        if(cliente.Perfil.Online)
                        {
                            flowLayoutPanelAmigosConectados.Controls.Add(cuata);
                        }
                        else
                        {
                            flowLayoutPanelAmigosDesconectados.Controls.Add(cuata);
                        }
                    }

                    labelAmigosConectados.Text = "Amigos conectados(" + flowLayoutPanelAmigosConectados.Controls.Count + ")";
                    labelAmigosDesconectados.Text = "Amigos conectados(" + flowLayoutPanelAmigosDesconectados.Controls.Count + ")";

                }
                else
                {
                    MessageBox.Show(resultado.Errores["Error"]);
                }
            }
            catch(Exception es)
            {
                MessageBox.Show(es.Message+ " " + es.InnerException);
            }
        }

        bool ExpandidoConectado = true;
        private void btnConectadosExpandir_Click(object sender, EventArgs e)
        {
            if (ExpandidoConectado)
            {
                btnConectadosExpandir.Image = Properties.Resources.mas;

                flowLayoutPanelAmigosConectados.Hide();
                ExpandidoConectado = false;
            }
            else
            {
                btnConectadosExpandir.Image = Properties.Resources.menos;
                flowLayoutPanelAmigosConectados.Show();
                ExpandidoConectado = true;
            }
        }
        bool ExpandidoDesconectado = true;
        private void btnDesconectadosExpandir_Click(object sender, EventArgs e)
        {
            if (ExpandidoDesconectado)
            {
                btnDesconectadosExpandir.Image = Properties.Resources.mas;

                flowLayoutPanelAmigosDesconectados.Hide();
                ExpandidoDesconectado = false;
            }
            else
            {
                btnDesconectadosExpandir.Image = Properties.Resources.menos;
                flowLayoutPanelAmigosDesconectados.Show();
                ExpandidoDesconectado = true;
            }
        }
    }
}
