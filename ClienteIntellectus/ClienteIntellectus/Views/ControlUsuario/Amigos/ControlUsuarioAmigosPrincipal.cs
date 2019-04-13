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
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            controlUsuarioAmigosChatChat1.BringToFront();
        }

        private void btnSolicitudPendiente_Click(object sender, EventArgs e)
        {
            controlUsuarioAmigosSolicitudPendientePrincipal1.BringToFront();
        }
    }
}
