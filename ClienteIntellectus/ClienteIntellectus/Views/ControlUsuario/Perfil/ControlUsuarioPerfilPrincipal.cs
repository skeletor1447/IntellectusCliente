using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteIntellectus.Views.ControlUsuario.Perfil
{
    public partial class ControlUsuarioPerfilPrincipal : UserControl
    {
        public ControlUsuarioPerfilPrincipal()
        {
            InitializeComponent();
            controlUsuarioPerfilInformacionPersonal1.BringToFront();
        }

        private void btnInformacionPersonal_Click(object sender, EventArgs e)
        {
            controlUsuarioPerfilInformacionPersonal1.BringToFront();
        }
    }
}
