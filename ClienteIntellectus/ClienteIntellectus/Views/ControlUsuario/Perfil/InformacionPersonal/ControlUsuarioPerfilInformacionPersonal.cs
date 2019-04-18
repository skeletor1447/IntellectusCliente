using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteIntellectus.Views.ControlUsuario.Perfil.InformacionPersonal
{
    public partial class ControlUsuarioPerfilInformacionPersonal : UserControl, IInformacionPersonal
    {

        public string Correo { get; set; }
        public string Nick { get; set; }
        public string NombreReal { get; set; }
        public string Descripcion { get; set; }
        public ControlUsuarioPerfilInformacionPersonal()
        {
            InitializeComponent();

          
        }


        public void ActualizarInformacion()
        {
            txtNick.Text = ClienteIntellectus.Views.Principal.Perfil.Usuario.Nick;
            txtCorreo.Text = ClienteIntellectus.Views.Principal.Perfil.Usuario.Correo;
            txtDescripcion.Text = ClienteIntellectus.Views.Principal.Perfil.Perfil.Descripcion;
            txtNombreReal.Text = ClienteIntellectus.Views.Principal.Perfil.Perfil.NombreReal;
        }
    }
}
