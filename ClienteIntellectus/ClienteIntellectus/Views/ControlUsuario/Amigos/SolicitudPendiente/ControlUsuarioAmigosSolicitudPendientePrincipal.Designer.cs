namespace ClienteIntellectus.Views.ControlUsuario.Amigos.SolicitudPendiente
{
    partial class ControlUsuarioAmigosSolicitudPendientePrincipal
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelPendientes = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanelEnviadas = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 51);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Solicitudes pendientes";
            // 
            // flowLayoutPanelPendientes
            // 
            this.flowLayoutPanelPendientes.AutoScroll = true;
            this.flowLayoutPanelPendientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanelPendientes.Location = new System.Drawing.Point(0, 51);
            this.flowLayoutPanelPendientes.Name = "flowLayoutPanelPendientes";
            this.flowLayoutPanelPendientes.Size = new System.Drawing.Size(714, 194);
            this.flowLayoutPanelPendientes.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 245);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 60);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Solicitudes enviadas";
            // 
            // flowLayoutPanelEnviadas
            // 
            this.flowLayoutPanelEnviadas.AutoScroll = true;
            this.flowLayoutPanelEnviadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelEnviadas.Location = new System.Drawing.Point(0, 305);
            this.flowLayoutPanelEnviadas.Name = "flowLayoutPanelEnviadas";
            this.flowLayoutPanelEnviadas.Size = new System.Drawing.Size(714, 204);
            this.flowLayoutPanelEnviadas.TabIndex = 3;
            // 
            // ControlUsuarioAmigosSolicitudPendientePrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanelEnviadas);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanelPendientes);
            this.Controls.Add(this.panel1);
            this.Name = "ControlUsuarioAmigosSolicitudPendientePrincipal";
            this.Size = new System.Drawing.Size(714, 509);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanelPendientes;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanelEnviadas;
    }
}
