﻿using System;
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
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            controlUsuarioAmigosChatChat1.BringToFront();
        }

        public void btnSolicitudPendiente_Click(object sender, EventArgs e)
        {
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
                    MessageBox.Show(_respuesta.Errores["Error"]);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
