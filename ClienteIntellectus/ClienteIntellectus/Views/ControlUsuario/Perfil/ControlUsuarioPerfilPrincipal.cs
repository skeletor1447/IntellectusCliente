using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClienteIntellectus.PerfilServicios;
using System.IO;

namespace ClienteIntellectus.Views.ControlUsuario.Perfil
{
    public partial class ControlUsuarioPerfilPrincipal : UserControl, IPerfilPrincipal
    {
        public ControlUsuarioPerfilPrincipal()
        {
            InitializeComponent();
            controlUsuarioPerfilInformacionPersonal1.BringToFront();
        }

        public Image Avatar { get; set; }
        public string Nick { get; set; }
        public string Institucion { get; set; }
        public string Descripcion { get; set; }
        
        public Image ImagenInstitucion { get; set; }

        private void btnInformacionPersonal_Click(object sender, EventArgs e)
        {
            controlUsuarioPerfilInformacionPersonal1.BringToFront();
            ActualizarInformacion();
            controlUsuarioPerfilInformacionPersonal1.ActualizarInformacion();
        }

        public void ActualizarInformacion()
        {
            using (var ms = new MemoryStream(ClienteIntellectus.Views.Principal.Perfil.Perfil.Avatar))
            {
                Avatar = Image.FromStream(ms);

                picturePerfil.Image = Avatar;
            }
            
            pictureInstitucion.Image = ImagenInstitucion;
            labelNick.Text = ClienteIntellectus.Views.Principal.Perfil.Usuario.Nick;
            labelInstitucion.Text = "";
            labelDescripcion.Text = ClienteIntellectus.Views.Principal.Perfil.Perfil.Descripcion;


            controlUsuarioPerfilInformacionPersonal1.ActualizarInformacion();
        }

        private void btnCambiarAvatar_Click(object sender, EventArgs e)
        {
            ActualizarAvatar actualizarAvatar = new ActualizarAvatar(this);
            actualizarAvatar.ShowDialog();
        }

        public void MostrarMensajeUsuarioError(string mensaje)
        {
            MessageBox.Show(mensaje);
        }
    }
}
