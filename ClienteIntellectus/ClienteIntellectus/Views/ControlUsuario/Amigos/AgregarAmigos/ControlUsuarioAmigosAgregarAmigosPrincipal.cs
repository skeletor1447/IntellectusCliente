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
                    foreach (var usuario in respuesta.Entidades)
                    {
                        ControlUsuarioAmigosTarjetaSolicitud cuats = new ControlUsuarioAmigosTarjetaSolicitud(usuario.Nick,usuario.ID);
                        
                        
                        flowLayoutPanel1.Controls.Add(cuats);
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
