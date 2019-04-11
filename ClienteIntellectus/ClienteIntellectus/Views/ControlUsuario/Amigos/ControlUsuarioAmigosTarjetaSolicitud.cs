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
        public long IDAlumno;
        public bool Pendiente { get; set; }
        public ControlUsuarioAmigosTarjetaSolicitud(String nick,long IDAlumno)
        {
            InitializeComponent();
            this.labelNick.Text = nick;
            this.IDAlumno = IDAlumno;
            this.Pendiente = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            btnAgregar.Enabled = false;
            if (!Pendiente)//no tiene una solicitud enviada
            {
                try
                {
                    AmigosServicios.AmigosServicesClient amigosServicesClient = new AmigosServicios.AmigosServicesClient();

                    AmigosServicios.InsertarRespuesta respuesta = amigosServicesClient.SolicitudDeAmistad((int)ClienteIntellectus.Views.Principal.ID, (int)IDAlumno);

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
