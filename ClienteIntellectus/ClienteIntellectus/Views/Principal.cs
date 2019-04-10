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
        private long ID { get; set; }
        public Principal(Socket clienteSocket,long ID)
        {
            InitializeComponent();
            this.ClienteSocket = clienteSocket;
            this.ID = ID;
            btnPerfil.Text = "emilio.montielemiliomontielemiliomontiel@hotmail.com";
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
