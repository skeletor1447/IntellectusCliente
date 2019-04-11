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
    public partial class Principal : Form
    {
        private Socket ClienteSocket { get; set; }
        UsuarioServicios.Usuario usuario;
        private long ID { get; set; }
        UsuarioServicios.UsuarioServicesClient usuarioClient;
        public Principal(Socket clienteSocket,long ID)
        {
            InitializeComponent();
            this.ClienteSocket = clienteSocket;
            this.ID = ID;

            try
            {
                usuarioClient = new UsuarioServicios.UsuarioServicesClient();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            CargarPerfil();
            
        }


        private void CargarPerfil()
        {
            try
            {
                UsuarioServicios.UnicaRespuestaOfUsuarioqYdlCAL1 resultado = usuarioClient.Consultar(ID);

                if (!resultado.Error)
                {
                    usuario = resultado.Entidad;


                    btnPerfil.Text = usuario.Nick;
                }
                else
                {
                    MessageBox.Show(resultado.Errores["Error"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            controlUsuarioPrincipalPrincipal1.BringToFront();
        }

        private void btnAmigos_Click(object sender, EventArgs e)
        {
            controlUsuarioAmigosPrincipal1.BringToFront();
            controlUsuarioAmigosPrincipal1.controlUsuarioAmigosChatChat1.BringToFront();
        }
    }
}
