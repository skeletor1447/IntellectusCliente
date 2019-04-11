using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteIntellectus.Views
{
    public partial class Registro : Form, IRegistro
    {
        public Login padre;

        public string Correo { get; set ; }
        public string Nick { get; set; }
        public string Password { get; set; }
        public string ConfirmarPassword { get; set; }

        public Registro(Login padre)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.padre = padre;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        

        public void MostrarMensajeUsuarioError(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            btnRegistrarse.Enabled = false;

            Correo = txtCorreo.Text;
            Nick = txtNick.Text;
            Password = txtPassword.Text;
            ConfirmarPassword = txtConfirmarPassword.Text;


            Presentador.RegistroPresentador registroPresentador = new Presentador.RegistroPresentador(this);

            if(registroPresentador.ValidarRegistro())
            {
                registroPresentador.RegistrarUsuario();
            }

            btnRegistrarse.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            padre.Show();
        }
    }
}
