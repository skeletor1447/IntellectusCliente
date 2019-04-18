using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClienteIntellectus.PerfilServicios;

namespace ClienteIntellectus.Views.ControlUsuario.Perfil
{
    public partial class ActualizarAvatar : Form, IActualizarAvatar
    {
        public Image Avatar { get; set; }
        
        Presentador.ControlUsuario.Perfil.ActualizarAvatarPresentador ActualizarAvatarPresentador;
        ControlUsuarioPerfilPrincipal padre;
        public ActualizarAvatar(ControlUsuarioPerfilPrincipal padre)
        {
            InitializeComponent();
            this.CenterToScreen();

            this.padre = padre;
            

            ActualizarAvatarPresentador = new Presentador.ControlUsuario.Perfil.ActualizarAvatarPresentador(this);

            using (var ms = new MemoryStream(ClienteIntellectus.Views.Principal.Perfil.Perfil.Avatar))
            {
                Avatar = Image.FromStream(ms);

                pictureAvatar.Image = Avatar;
            }
            
        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            ActualizarAvatarPresentador.SeleccionarImange();
            pictureAvatar.Image = Avatar;
            
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            ActualizarAvatarPresentador.GuardarCambios();

          
            padre.ActualizarInformacion();
        }

        public void MostrarMensajeUsuarioError(string mensaje)
        {
            MessageBox.Show(mensaje);
        }
    }
}
