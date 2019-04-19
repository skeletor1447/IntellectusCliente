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

        Presentador.ControlUsuario.Perfil.InformacionPersonal.InformacionPersonalPresentador InformacionPersonalPresentador;
        public ControlUsuarioPerfilInformacionPersonal()
        {
            InitializeComponent();
            InformacionPersonalPresentador = new Presentador.ControlUsuario.Perfil.InformacionPersonal.InformacionPersonalPresentador(this);
        }


        public void ActualizarInformacion()
        {
            txtNick.Text = ClienteIntellectus.Views.Principal.Perfil.Usuario.Nick;
            txtCorreo.Text = ClienteIntellectus.Views.Principal.Perfil.Usuario.Correo;
            txtDescripcion.Text = ClienteIntellectus.Views.Principal.Perfil.Perfil.Descripcion;
            txtNombreReal.Text = ClienteIntellectus.Views.Principal.Perfil.Perfil.NombreReal;
        }

        public void MostrarMensajeUsuarioError(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        

        private void btnGurdarCambios_Click(object sender, EventArgs e)
        {
            Correo = txtCorreo.Text;
            Nick = txtNick.Text;
            NombreReal = txtNombreReal.Text;
            Descripcion = txtDescripcion.Text;

            InformacionPersonalPresentador.GuardarCambios();
            ActualizarInformacion();

           
            Control control = this.Parent; //panelLibre
            control = control.Parent; //ControlUsuarioPerfilPrincipal

            if (control is ControlUsuarioPerfilPrincipal)
                (control as ControlUsuarioPerfilPrincipal).ActualizarInformacion();
        }
    }
}
