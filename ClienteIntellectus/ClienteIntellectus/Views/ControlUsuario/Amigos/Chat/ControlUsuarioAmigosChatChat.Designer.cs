namespace ClienteIntellectus.Views.ControlUsuario.Amigos.Chat
{
    partial class ControlUsuarioAmigosChatChat
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
            this.panelEnviarMensaje = new System.Windows.Forms.Panel();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelConversacionesAbiertas = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelChat = new System.Windows.Forms.FlowLayoutPanel();
            this.panelEnviarMensaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEnviarMensaje
            // 
            this.panelEnviarMensaje.Controls.Add(this.btnEnviar);
            this.panelEnviarMensaje.Controls.Add(this.textBox1);
            this.panelEnviarMensaje.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelEnviarMensaje.Location = new System.Drawing.Point(0, 368);
            this.panelEnviarMensaje.Name = "panelEnviarMensaje";
            this.panelEnviarMensaje.Size = new System.Drawing.Size(569, 37);
            this.panelEnviarMensaje.TabIndex = 1;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEnviar.Location = new System.Drawing.Point(464, 0);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(105, 37);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(455, 20);
            this.textBox1.TabIndex = 0;
            // 
            // flowLayoutPanelConversacionesAbiertas
            // 
            this.flowLayoutPanelConversacionesAbiertas.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelConversacionesAbiertas.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelConversacionesAbiertas.Name = "flowLayoutPanelConversacionesAbiertas";
            this.flowLayoutPanelConversacionesAbiertas.Size = new System.Drawing.Size(569, 42);
            this.flowLayoutPanelConversacionesAbiertas.TabIndex = 2;
            // 
            // flowLayoutPanelChat
            // 
            this.flowLayoutPanelChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelChat.Location = new System.Drawing.Point(0, 42);
            this.flowLayoutPanelChat.Name = "flowLayoutPanelChat";
            this.flowLayoutPanelChat.Size = new System.Drawing.Size(569, 326);
            this.flowLayoutPanelChat.TabIndex = 3;
            // 
            // ControlUsuarioAmigosChatChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanelChat);
            this.Controls.Add(this.flowLayoutPanelConversacionesAbiertas);
            this.Controls.Add(this.panelEnviarMensaje);
            this.Name = "ControlUsuarioAmigosChatChat";
            this.Size = new System.Drawing.Size(569, 405);
            this.panelEnviarMensaje.ResumeLayout(false);
            this.panelEnviarMensaje.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelEnviarMensaje;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelChat;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanelConversacionesAbiertas;
    }
}
