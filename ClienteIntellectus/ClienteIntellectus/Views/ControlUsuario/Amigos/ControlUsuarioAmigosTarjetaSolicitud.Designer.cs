namespace ClienteIntellectus.Views.ControlUsuario.Amigos
{
    partial class ControlUsuarioAmigosTarjetaSolicitud
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlUsuarioAmigosTarjetaSolicitud));
            this.picturePerfil = new System.Windows.Forms.PictureBox();
            this.labelNick = new System.Windows.Forms.Label();
            this.labelInstitucion = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pictureOnline = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picturePerfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOnline)).BeginInit();
            this.SuspendLayout();
            // 
            // picturePerfil
            // 
            this.picturePerfil.Image = ((System.Drawing.Image)(resources.GetObject("picturePerfil.Image")));
            this.picturePerfil.Location = new System.Drawing.Point(13, 11);
            this.picturePerfil.Name = "picturePerfil";
            this.picturePerfil.Size = new System.Drawing.Size(60, 50);
            this.picturePerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picturePerfil.TabIndex = 0;
            this.picturePerfil.TabStop = false;
            // 
            // labelNick
            // 
            this.labelNick.AutoSize = true;
            this.labelNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNick.Location = new System.Drawing.Point(84, 12);
            this.labelNick.Name = "labelNick";
            this.labelNick.Size = new System.Drawing.Size(127, 24);
            this.labelNick.TabIndex = 1;
            this.labelNick.Text = "skeletor1447";
            // 
            // labelInstitucion
            // 
            this.labelInstitucion.AutoSize = true;
            this.labelInstitucion.Location = new System.Drawing.Point(87, 49);
            this.labelInstitucion.Name = "labelInstitucion";
            this.labelInstitucion.Size = new System.Drawing.Size(191, 13);
            this.labelInstitucion.TabIndex = 2;
            this.labelInstitucion.Text = "Universidad Veracruzana 6to Semestre";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(229, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 23);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Enviar solicitud";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pictureOnline
            // 
            this.pictureOnline.Image = ((System.Drawing.Image)(resources.GetObject("pictureOnline.Image")));
            this.pictureOnline.Location = new System.Drawing.Point(300, 44);
            this.pictureOnline.Name = "pictureOnline";
            this.pictureOnline.Size = new System.Drawing.Size(24, 16);
            this.pictureOnline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureOnline.TabIndex = 4;
            this.pictureOnline.TabStop = false;
            // 
            // ControlUsuarioAmigosTarjetaSolicitud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureOnline);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.labelInstitucion);
            this.Controls.Add(this.labelNick);
            this.Controls.Add(this.picturePerfil);
            this.Name = "ControlUsuarioAmigosTarjetaSolicitud";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(335, 70);
            ((System.ComponentModel.ISupportInitialize)(this.picturePerfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOnline)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelInstitucion;
        public System.Windows.Forms.Button btnAgregar;
        public System.Windows.Forms.PictureBox picturePerfil;
        public System.Windows.Forms.Label labelNick;
        public System.Windows.Forms.PictureBox pictureOnline;
    }
}
