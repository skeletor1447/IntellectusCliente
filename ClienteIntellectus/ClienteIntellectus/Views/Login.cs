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
    public partial class Login : Form, ILogin
    {
        public string Correo { get; set; }
        public string Password { get; set; }
        public long ID { get; set; }
        public Socket ClienteSocket { get; set; }

        public Login()
        {
            InitializeComponent();
            this.CenterToScreen();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            btnEntrar.Enabled = false;
            Correo = txtCorreo.Text;
            Password = txtPassword.Text;

            Presentador.LoginPresentador loginPresentador = new Presentador.LoginPresentador(this);

            if(loginPresentador.ValidarUsuario())
            {

                if (loginPresentador.ConectarseAlServidor())
                {
                    Principal principal = new Principal(ClienteSocket,ID);
                    this.Hide();
                    principal.Show();
                }
            }

            btnEntrar.Enabled = true;
        }

        public void MostrarMensajeUsuarioError(string mensaje)
        {
            MessageBox.Show(mensaje);
        }
    }
}
