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

            flowLayoutPanel1.Controls.Add(new ControlUsuarioAmigosTarjetaSolicitud());
            flowLayoutPanel1.Controls.Add(new ControlUsuarioAmigosTarjetaSolicitud());
            flowLayoutPanel1.Controls.Add(new ControlUsuarioAmigosTarjetaSolicitud());
            flowLayoutPanel1.Controls.Add(new ControlUsuarioAmigosTarjetaSolicitud());
            flowLayoutPanel1.Controls.Add(new ControlUsuarioAmigosTarjetaSolicitud());
            flowLayoutPanel1.Controls.Add(new ControlUsuarioAmigosTarjetaSolicitud());
            flowLayoutPanel1.Controls.Add(new ControlUsuarioAmigosTarjetaSolicitud());
            flowLayoutPanel1.Controls.Add(new ControlUsuarioAmigosTarjetaSolicitud());
        }

    }
}
