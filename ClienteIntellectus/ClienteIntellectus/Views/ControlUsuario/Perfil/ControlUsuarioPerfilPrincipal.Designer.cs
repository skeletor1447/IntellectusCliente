namespace ClienteIntellectus.Views.ControlUsuario.Perfil
{
    partial class ControlUsuarioPerfilPrincipal
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
            this.panelInformacionCorta = new System.Windows.Forms.Panel();
            this.picturePerfil = new System.Windows.Forms.PictureBox();
            this.labelNick = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelPerfilLibre = new System.Windows.Forms.Panel();
            this.pictureInstitucion = new System.Windows.Forms.PictureBox();
            this.labelInstitucion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panelInformacionCorta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePerfil)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInstitucion)).BeginInit();
            this.SuspendLayout();
            // 
            // panelInformacionCorta
            // 
            this.panelInformacionCorta.Controls.Add(this.labelInstitucion);
            this.panelInformacionCorta.Controls.Add(this.pictureInstitucion);
            this.panelInformacionCorta.Controls.Add(this.labelDescripcion);
            this.panelInformacionCorta.Controls.Add(this.labelNick);
            this.panelInformacionCorta.Controls.Add(this.picturePerfil);
            this.panelInformacionCorta.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInformacionCorta.Location = new System.Drawing.Point(0, 0);
            this.panelInformacionCorta.Name = "panelInformacionCorta";
            this.panelInformacionCorta.Size = new System.Drawing.Size(602, 140);
            this.panelInformacionCorta.TabIndex = 0;
            // 
            // picturePerfil
            // 
            this.picturePerfil.Location = new System.Drawing.Point(55, 13);
            this.picturePerfil.Name = "picturePerfil";
            this.picturePerfil.Size = new System.Drawing.Size(100, 107);
            this.picturePerfil.TabIndex = 0;
            this.picturePerfil.TabStop = false;
            // 
            // labelNick
            // 
            this.labelNick.AutoSize = true;
            this.labelNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNick.Location = new System.Drawing.Point(173, 20);
            this.labelNick.Name = "labelNick";
            this.labelNick.Size = new System.Drawing.Size(47, 24);
            this.labelNick.TabIndex = 1;
            this.labelNick.Text = "Nick";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(175, 85);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(63, 13);
            this.labelDescripcion.TabIndex = 2;
            this.labelDescripcion.Text = "Descripcion";
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.button5);
            this.panelMenu.Controls.Add(this.button4);
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.button2);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 140);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(602, 30);
            this.panelMenu.TabIndex = 1;
            // 
            // panelPerfilLibre
            // 
            this.panelPerfilLibre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPerfilLibre.Location = new System.Drawing.Point(0, 170);
            this.panelPerfilLibre.Name = "panelPerfilLibre";
            this.panelPerfilLibre.Size = new System.Drawing.Size(602, 230);
            this.panelPerfilLibre.TabIndex = 2;
            // 
            // pictureInstitucion
            // 
            this.pictureInstitucion.Location = new System.Drawing.Point(178, 43);
            this.pictureInstitucion.Name = "pictureInstitucion";
            this.pictureInstitucion.Size = new System.Drawing.Size(19, 15);
            this.pictureInstitucion.TabIndex = 3;
            this.pictureInstitucion.TabStop = false;
            // 
            // labelInstitucion
            // 
            this.labelInstitucion.AutoSize = true;
            this.labelInstitucion.Location = new System.Drawing.Point(202, 44);
            this.labelInstitucion.Name = "labelInstitucion";
            this.labelInstitucion.Size = new System.Drawing.Size(55, 13);
            this.labelInstitucion.TabIndex = 4;
            this.labelInstitucion.Text = "Institucion";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Información personal";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.Location = new System.Drawing.Point(141, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(151, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Información de mi institución";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.Location = new System.Drawing.Point(292, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "Historial academico";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Left;
            this.button4.Location = new System.Drawing.Point(426, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 30);
            this.button4.TabIndex = 3;
            this.button4.Text = "Insignias";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Left;
            this.button5.Location = new System.Drawing.Point(487, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 30);
            this.button5.TabIndex = 4;
            this.button5.Text = "Comentarios";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // ControlUsuarioPerfilPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelPerfilLibre);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelInformacionCorta);
            this.Name = "ControlUsuarioPerfilPrincipal";
            this.Size = new System.Drawing.Size(602, 400);
            this.panelInformacionCorta.ResumeLayout(false);
            this.panelInformacionCorta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePerfil)).EndInit();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureInstitucion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelInformacionCorta;
        private System.Windows.Forms.Label labelInstitucion;
        private System.Windows.Forms.PictureBox pictureInstitucion;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.Label labelNick;
        private System.Windows.Forms.PictureBox picturePerfil;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelPerfilLibre;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}
