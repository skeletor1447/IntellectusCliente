namespace ClienteIntellectus.Views.ControlUsuario.Perfil
{
    partial class PerfilPublico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerfilPublico));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnResumen = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.controlUsuarioPerfilPerfilPublicoResumen1 = new ClienteIntellectus.Views.ControlUsuario.Perfil.ControlUsuarioPerfilPerfilPublicoResumen();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.btnResumen);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 43);
            this.panel1.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(605, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(44, 43);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnResumen
            // 
            this.btnResumen.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnResumen.Location = new System.Drawing.Point(0, 0);
            this.btnResumen.Name = "btnResumen";
            this.btnResumen.Size = new System.Drawing.Size(148, 43);
            this.btnResumen.TabIndex = 0;
            this.btnResumen.Text = "Resumen";
            this.btnResumen.UseVisualStyleBackColor = true;
            this.btnResumen.Click += new System.EventHandler(this.btnResumen_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.controlUsuarioPerfilPerfilPublicoResumen1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(649, 497);
            this.panel2.TabIndex = 1;
            // 
            // controlUsuarioPerfilPerfilPublicoResumen1
            // 
            this.controlUsuarioPerfilPerfilPublicoResumen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlUsuarioPerfilPerfilPublicoResumen1.Location = new System.Drawing.Point(0, 0);
            this.controlUsuarioPerfilPerfilPublicoResumen1.Name = "controlUsuarioPerfilPerfilPublicoResumen1";
            this.controlUsuarioPerfilPerfilPublicoResumen1.Size = new System.Drawing.Size(649, 497);
            this.controlUsuarioPerfilPerfilPublicoResumen1.TabIndex = 0;
            // 
            // PerfilPublico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 540);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PerfilPublico";
            this.Text = "PerfilPublico";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnResumen;
        private System.Windows.Forms.PictureBox btnCerrar;
        private ControlUsuarioPerfilPerfilPublicoResumen controlUsuarioPerfilPerfilPublicoResumen1;
    }
}