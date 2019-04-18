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
        public PerfilCompuesto Perfil { get; set; }
        public Image ImagenInstitucion { get; set; }

        private void btnInformacionPersonal_Click(object sender, EventArgs e)
        {
            controlUsuarioPerfilInformacionPersonal1.BringToFront();
            ActualizarInformacion();
        }

        public void ActualizarInformacion()
        {
            picturePerfil.Image = Avatar;
            pictureInstitucion.Image = ImagenInstitucion;
            labelNick.Text = Perfil.Usuario.Nick;
            labelInstitucion.Text = "";
            labelDescripcion.Text = Perfil.Perfil.Descripcion;
        }
    }
}
