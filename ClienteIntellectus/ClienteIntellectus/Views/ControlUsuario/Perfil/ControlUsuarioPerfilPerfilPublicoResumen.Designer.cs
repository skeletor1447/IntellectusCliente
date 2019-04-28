namespace ClienteIntellectus.Views.ControlUsuario.Perfil
{
    partial class ControlUsuarioPerfilPerfilPublicoResumen
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
            this.pictureAvatar = new System.Windows.Forms.PictureBox();
            this.labelNick = new System.Windows.Forms.Label();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.labelInstitucion = new System.Windows.Forms.Label();
            this.labelNombreReal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureAvatar
            // 
            this.pictureAvatar.Location = new System.Drawing.Point(27, 19);
            this.pictureAvatar.Name = "pictureAvatar";
            this.pictureAvatar.Size = new System.Drawing.Size(146, 133);
            this.pictureAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureAvatar.TabIndex = 0;
            this.pictureAvatar.TabStop = false;
            // 
            // labelNick
            // 
            this.labelNick.AutoSize = true;
            this.labelNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNick.Location = new System.Drawing.Point(180, 19);
            this.labelNick.Name = "labelNick";
            this.labelNick.Size = new System.Drawing.Size(70, 25);
            this.labelNick.TabIndex = 1;
            this.labelNick.Text = "label1";
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Location = new System.Drawing.Point(185, 71);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(63, 13);
            this.labelDescripcion.TabIndex = 2;
            this.labelDescripcion.Text = "Descripción";
            // 
            // labelInstitucion
            // 
            this.labelInstitucion.AutoSize = true;
            this.labelInstitucion.Location = new System.Drawing.Point(185, 113);
            this.labelInstitucion.Name = "labelInstitucion";
            this.labelInstitucion.Size = new System.Drawing.Size(55, 13);
            this.labelInstitucion.TabIndex = 3;
            this.labelInstitucion.Text = "Institución";
            // 
            // labelNombreReal
            // 
            this.labelNombreReal.AutoSize = true;
            this.labelNombreReal.Location = new System.Drawing.Point(28, 193);
            this.labelNombreReal.Name = "labelNombreReal";
            this.labelNombreReal.Size = new System.Drawing.Size(67, 13);
            this.labelNombreReal.TabIndex = 4;
            this.labelNombreReal.Text = "Nombre real:";
            // 
            // ControlUsuarioPerfilPerfilPublicoResumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelNombreReal);
            this.Controls.Add(this.labelInstitucion);
            this.Controls.Add(this.labelDescripcion);
            this.Controls.Add(this.labelNick);
            this.Controls.Add(this.pictureAvatar);
            this.Name = "ControlUsuarioPerfilPerfilPublicoResumen";
            this.Size = new System.Drawing.Size(560, 540);
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureAvatar;
        public System.Windows.Forms.Label labelNick;
        public System.Windows.Forms.Label labelDescripcion;
        public System.Windows.Forms.Label labelInstitucion;
        public System.Windows.Forms.Label labelNombreReal;
    }
}
