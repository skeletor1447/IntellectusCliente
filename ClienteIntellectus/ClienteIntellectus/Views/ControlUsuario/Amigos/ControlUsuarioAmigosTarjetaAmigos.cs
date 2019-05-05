using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ClienteIntellectus.Views.ControlUsuario.Amigos
{
    public partial class ControlUsuarioAmigosTarjetaAmigos : UserControl
    {
        PerfilServicios.PerfilCompuesto perfil;
        public ControlUsuarioAmigosTarjetaAmigos(PerfilServicios.PerfilCompuesto perfil)
        {
            InitializeComponent();
            this.perfil = perfil;

            labelNick.Text = perfil.Usuario.Nick;
            labelDisponible.Text = perfil.Perfil.Disponibilidad;

            using (var ms = new MemoryStream(perfil.Perfil.Avatar))
            {
                pictureAvatar.Image = Image.FromStream(ms);
            }
        }

        private void menuVerPerfil_Click(object sender, EventArgs e)
        {
            Perfil.PerfilPublico perfilPublico = new Perfil.PerfilPublico(perfil);

            perfilPublico.ShowDialog();
        }
        
        private void menuEnviarMensaje_Click(object sender, EventArgs e)
        {
            Control control = this.Parent;
            control = control.Parent;
            control = control.Parent;


            if((control is ControlUsuarioAmigosPrincipal))
            {
                (control as ControlUsuarioAmigosPrincipal).controlUsuarioAmigosChatChat1.flowLayoutPanelConversacionesAbiertas.Controls.Add(new ControlUsuario.Amigos.Chat.ControlUsuarioAmigosChatTarjetaPestana());
                ClienteIntellectus.Views.Principal.flujoChat.Add(perfil.Usuario.ID, new List<Control>());
            }
           

        }
    }
}
