﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClienteIntellectus.PerfilServicios;
using ClienteIntellectus.UsuarioServicios;

namespace ClienteIntellectus.Views
{
    public partial class Principal : Form, IPrincipal
    {
        
        public static  long ID { get; set; }
        public Socket ClienteSocket { get; set; }
        
        public long IdCliente { get; set; }
        static public PerfilCompuesto Perfil { get; set ; }

        public static Dictionary<long, List<Control>> flujoChat = new Dictionary<long, List<Control>>();

        Presentador.PrincipalPresentador PrincipalPresentador;

        public Principal(Socket clienteSocket,long ID)
        {
            InitializeComponent();
            this.ClienteSocket = clienteSocket;
            Principal.ID = ID;
            IdCliente = ID;

            PrincipalPresentador = new Presentador.PrincipalPresentador(this, this);


            PrincipalPresentador.Inicializar(controlUsuarioPrincipalPrincipal1);
            PrincipalPresentador.AjustarLabelAlTexto(labelPerfil, PrincipalPresentador.GetNick());


            //se asigna a los control de usuario principales el perfil del usuario
           
            controlUsuarioPerfilPrincipal1.ActualizarInformacion();
            
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
            controlUsuarioAmigosPrincipal1.ActualizarListaAmigos();
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

        public void MostrarMensajeUsuarioError(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        private void menuPerfilCerrarSesion_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void menuPerfilSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAplicaciones_Click(object sender, EventArgs e)
        {
            controlUsuarioAplicacionesPrincipal1.BringToFront();
        }
    }
}
