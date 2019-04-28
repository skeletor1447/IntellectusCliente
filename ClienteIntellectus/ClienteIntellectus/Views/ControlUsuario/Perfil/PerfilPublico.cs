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

namespace ClienteIntellectus.Views.ControlUsuario.Perfil
{
    public partial class PerfilPublico : Form
    {
        PerfilServicios.PerfilCompuesto perfilCompuesto;
        public PerfilPublico(PerfilServicios.PerfilCompuesto perfilCompuesto)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.perfilCompuesto = perfilCompuesto;
            ActualizarResumen();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
            ActualizarResumen();
        }


        public void ActualizarResumen()
        {
            using (var ms = new MemoryStream(perfilCompuesto.Perfil.Avatar))
            {
                controlUsuarioPerfilPerfilPublicoResumen1.pictureAvatar.Image = Image.FromStream(ms);
            }

            controlUsuarioPerfilPerfilPublicoResumen1.labelNick.Text = perfilCompuesto.Usuario.Nick;
            controlUsuarioPerfilPerfilPublicoResumen1.labelDescripcion.Text = perfilCompuesto.Perfil.Descripcion;
            controlUsuarioPerfilPerfilPublicoResumen1.labelNombreReal.Text = perfilCompuesto.Perfil.NombreReal;
        }
    }
}
