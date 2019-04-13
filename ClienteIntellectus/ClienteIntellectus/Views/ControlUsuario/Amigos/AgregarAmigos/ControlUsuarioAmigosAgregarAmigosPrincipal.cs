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

        public void txtBuscarAlumno_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            if (txtBuscarAlumno.Text.Trim() == String.Empty)
                return;
            
            try
            {
                UsuarioServicios.UsuarioServicesClient usuarioServicesClient = new UsuarioServicios.UsuarioServicesClient();

                UsuarioServicios.MultipleRespuestaOfUsuarioAmistadqYdlCAL1 _respuesta = usuarioServicesClient.ConsultarPorBusqueda(ClienteIntellectus.Views.Principal.ID,txtBuscarAlumno.Text);

                if(!_respuesta.Error)
                {
                    foreach(var usuario in _respuesta.Entidades)
                    {
                        ControlUsuarioAmigosTarjetaSolicitud cuats = new ControlUsuarioAmigosTarjetaSolicitud(usuario,this);

                        flowLayoutPanel1.Controls.Add(cuats);
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
