namespace ClienteIntellectus.Views.ControlUsuario.Amigos
{
    partial class ControlUsuarioAmigosPrincipal
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelAmigosListaAmigos = new System.Windows.Forms.Panel();
            this.panelAmigosListaAmigosMenu = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panelAmigosPrincipalMenu = new System.Windows.Forms.Panel();
            this.btnSolicitudPendiente = new System.Windows.Forms.Button();
            this.btnAgregarAmigos = new System.Windows.Forms.Button();
            this.btnChat = new System.Windows.Forms.Button();
            this.panelAmigosLibre = new System.Windows.Forms.Panel();
            this.controlUsuarioAmigosAgregarAmigosPrincipal1 = new ClienteIntellectus.Views.ControlUsuario.Amigos.AgregarAmigos.ControlUsuarioAmigosAgregarAmigosPrincipal();
            this.controlUsuarioAmigosChatChat1 = new ClienteIntellectus.Views.ControlUsuario.Amigos.Chat.ControlUsuarioAmigosChatChat();
            this.controlUsuarioAmigosSolicitudPendientePrincipal1 = new ClienteIntellectus.Views.ControlUsuario.Amigos.SolicitudPendiente.ControlUsuarioAmigosSolicitudPendientePrincipal();
            this.panelAmigosListaAmigos.SuspendLayout();
            this.panelAmigosListaAmigosMenu.SuspendLayout();
            this.panelAmigosPrincipalMenu.SuspendLayout();
            this.panelAmigosLibre.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAmigosListaAmigos
            // 
            this.panelAmigosListaAmigos.Controls.Add(this.panelAmigosListaAmigosMenu);
            this.panelAmigosListaAmigos.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAmigosListaAmigos.Location = new System.Drawing.Point(565, 0);
            this.panelAmigosListaAmigos.Name = "panelAmigosListaAmigos";
            this.panelAmigosListaAmigos.Size = new System.Drawing.Size(221, 472);
            this.panelAmigosListaAmigos.TabIndex = 0;
            // 
            // panelAmigosListaAmigosMenu
            // 
            this.panelAmigosListaAmigosMenu.Controls.Add(this.button4);
            this.panelAmigosListaAmigosMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAmigosListaAmigosMenu.Location = new System.Drawing.Point(0, 0);
            this.panelAmigosListaAmigosMenu.Name = "panelAmigosListaAmigosMenu";
            this.panelAmigosListaAmigosMenu.Size = new System.Drawing.Size(221, 62);
            this.panelAmigosListaAmigosMenu.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(39, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 32);
            this.button4.TabIndex = 0;
            this.button4.Text = "Nick";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panelAmigosPrincipalMenu
            // 
            this.panelAmigosPrincipalMenu.Controls.Add(this.btnSolicitudPendiente);
            this.panelAmigosPrincipalMenu.Controls.Add(this.btnAgregarAmigos);
            this.panelAmigosPrincipalMenu.Controls.Add(this.btnChat);
            this.panelAmigosPrincipalMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAmigosPrincipalMenu.Location = new System.Drawing.Point(0, 0);
            this.panelAmigosPrincipalMenu.Name = "panelAmigosPrincipalMenu";
            this.panelAmigosPrincipalMenu.Size = new System.Drawing.Size(565, 62);
            this.panelAmigosPrincipalMenu.TabIndex = 1;
            // 
            // btnSolicitudPendiente
            // 
            this.btnSolicitudPendiente.Location = new System.Drawing.Point(264, 14);
            this.btnSolicitudPendiente.Name = "btnSolicitudPendiente";
            this.btnSolicitudPendiente.Size = new System.Drawing.Size(128, 33);
            this.btnSolicitudPendiente.TabIndex = 2;
            this.btnSolicitudPendiente.Text = "Solicitudes pendientes";
            this.btnSolicitudPendiente.UseVisualStyleBackColor = true;
            this.btnSolicitudPendiente.Click += new System.EventHandler(this.btnSolicitudPendiente_Click);
            // 
            // btnAgregarAmigos
            // 
            this.btnAgregarAmigos.Location = new System.Drawing.Point(151, 14);
            this.btnAgregarAmigos.Name = "btnAgregarAmigos";
            this.btnAgregarAmigos.Size = new System.Drawing.Size(107, 33);
            this.btnAgregarAmigos.TabIndex = 1;
            this.btnAgregarAmigos.Text = "AgregarAmigos";
            this.btnAgregarAmigos.UseVisualStyleBackColor = true;
            this.btnAgregarAmigos.Click += new System.EventHandler(this.btnAgregarAmigos_Click);
            // 
            // btnChat
            // 
            this.btnChat.Location = new System.Drawing.Point(39, 14);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(106, 33);
            this.btnChat.TabIndex = 0;
            this.btnChat.Text = "Chat";
            this.btnChat.UseVisualStyleBackColor = true;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // panelAmigosLibre
            // 
            this.panelAmigosLibre.Controls.Add(this.controlUsuarioAmigosSolicitudPendientePrincipal1);
            this.panelAmigosLibre.Controls.Add(this.controlUsuarioAmigosAgregarAmigosPrincipal1);
            this.panelAmigosLibre.Controls.Add(this.controlUsuarioAmigosChatChat1);
            this.panelAmigosLibre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAmigosLibre.Location = new System.Drawing.Point(0, 62);
            this.panelAmigosLibre.Name = "panelAmigosLibre";
            this.panelAmigosLibre.Size = new System.Drawing.Size(565, 410);
            this.panelAmigosLibre.TabIndex = 2;
            // 
            // controlUsuarioAmigosAgregarAmigosPrincipal1
            // 
            this.controlUsuarioAmigosAgregarAmigosPrincipal1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlUsuarioAmigosAgregarAmigosPrincipal1.Location = new System.Drawing.Point(0, 0);
            this.controlUsuarioAmigosAgregarAmigosPrincipal1.Name = "controlUsuarioAmigosAgregarAmigosPrincipal1";
            this.controlUsuarioAmigosAgregarAmigosPrincipal1.Size = new System.Drawing.Size(565, 410);
            this.controlUsuarioAmigosAgregarAmigosPrincipal1.TabIndex = 1;
            // 
            // controlUsuarioAmigosChatChat1
            // 
            this.controlUsuarioAmigosChatChat1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlUsuarioAmigosChatChat1.Location = new System.Drawing.Point(0, 0);
            this.controlUsuarioAmigosChatChat1.Name = "controlUsuarioAmigosChatChat1";
            this.controlUsuarioAmigosChatChat1.Size = new System.Drawing.Size(565, 410);
            this.controlUsuarioAmigosChatChat1.TabIndex = 0;
            // 
            // controlUsuarioAmigosSolicitudPendientePrincipal1
            // 
            this.controlUsuarioAmigosSolicitudPendientePrincipal1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlUsuarioAmigosSolicitudPendientePrincipal1.Location = new System.Drawing.Point(0, 0);
            this.controlUsuarioAmigosSolicitudPendientePrincipal1.Name = "controlUsuarioAmigosSolicitudPendientePrincipal1";
            this.controlUsuarioAmigosSolicitudPendientePrincipal1.Size = new System.Drawing.Size(565, 410);
            this.controlUsuarioAmigosSolicitudPendientePrincipal1.TabIndex = 2;
            // 
            // ControlUsuarioAmigosPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelAmigosLibre);
            this.Controls.Add(this.panelAmigosPrincipalMenu);
            this.Controls.Add(this.panelAmigosListaAmigos);
            this.Name = "ControlUsuarioAmigosPrincipal";
            this.Size = new System.Drawing.Size(786, 472);
            this.panelAmigosListaAmigos.ResumeLayout(false);
            this.panelAmigosListaAmigosMenu.ResumeLayout(false);
            this.panelAmigosPrincipalMenu.ResumeLayout(false);
            this.panelAmigosLibre.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAmigosListaAmigos;
        private System.Windows.Forms.Panel panelAmigosListaAmigosMenu;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panelAmigosPrincipalMenu;
        private System.Windows.Forms.Button btnSolicitudPendiente;
        private System.Windows.Forms.Button btnAgregarAmigos;
        private System.Windows.Forms.Button btnChat;
        private System.Windows.Forms.Panel panelAmigosLibre;
        public Chat.ControlUsuarioAmigosChatChat controlUsuarioAmigosChatChat1;
        private AgregarAmigos.ControlUsuarioAmigosAgregarAmigosPrincipal controlUsuarioAmigosAgregarAmigosPrincipal1;
        private SolicitudPendiente.ControlUsuarioAmigosSolicitudPendientePrincipal controlUsuarioAmigosSolicitudPendientePrincipal1;
    }
}
