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
        long IDAlumno;
        public ControlUsuarioAmigosTarjetaSolicitud(String nick,long IDAlumno)
        {
            InitializeComponent();
            this.labelNick.Text = nick;
            this.IDAlumno = IDAlumno;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false;
            try
            {
                AmigosServicios.AmigosServicesClient amigosServicesClient = new AmigosServicios.AmigosServicesClient();

                AmigosServicios.InsertarRespuesta respuesta = amigosServicesClient.SolicitudDeAmistad((int)ClienteIntellectus.Views.Principal.ID, (int)IDAlumno);

                if(!respuesta.Error)
                {
                    btnAgregar.Text = "Pendiente";
                    return;
                }
                else
                {
                    MessageBox.Show(respuesta.Errores["Error"]);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btnAgregar.Enabled = false;
        }
    }
}
