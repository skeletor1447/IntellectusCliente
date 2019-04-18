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
        public static  long ID { get; set; }
        UsuarioServicios.UsuarioServicesClient usuarioClient;
        public Principal(Socket clienteSocket,long ID)
        {
            InitializeComponent();
            this.ClienteSocket = clienteSocket;
            Principal.ID = ID;

            try
            {
                usuarioClient = new UsuarioServicios.UsuarioServicesClient();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            CargarPerfil();
            controlUsuarioPrincipalPrincipal1.BringToFront();
            
        }


        private void CargarPerfil()
        {
            try
            {
                UsuarioServicios.UnicaRespuestaOfUsuarioqYdlCAL1 resultado = usuarioClient.Consultar(ID);

                if (!resultado.Error)
                {
                    usuario = resultado.Entidad;

                    labelPerfil.Text = usuario.Nick;

                    using (Graphics g = CreateGraphics())
                    {
                        SizeF size = g.MeasureString(labelPerfil.Text, labelPerfil.Font, int.MaxValue);
                        labelPerfil.Width = (int)Math.Ceiling(size.Width);
                        labelPerfil.Text = labelPerfil.Text;
                    }
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

        private void labelPerfil_Click(object sender, EventArgs e)
        {
            Point point = new Point(labelPerfil.Width, labelPerfil.Height);
            contextMenuPerfil.Show(labelPerfil, point, ToolStripDropDownDirection.BelowLeft);
        }

        private void menuPerfilVerPerfil_Click(object sender, EventArgs e)
        {
            controlUsuarioPerfilPrincipal1.BringToFront();
        }
    }
}
