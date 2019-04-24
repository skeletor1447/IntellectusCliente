namespace ClienteIntellectus.Views.ControlUsuario.Amigos
{
    partial class ControlUsuarioAmigosTarjetaAmigos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlUsuarioAmigosTarjetaAmigos));
            this.pictureAvatar = new System.Windows.Forms.PictureBox();
            this.labelNick = new System.Windows.Forms.Label();
            this.labelDisponible = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureAvatar
            // 
            this.pictureAvatar.Image = ((System.Drawing.Image)(resources.GetObject("pictureAvatar.Image")));
            this.pictureAvatar.Location = new System.Drawing.Point(3, 6);
            this.pictureAvatar.Name = "pictureAvatar";
            this.pictureAvatar.Size = new System.Drawing.Size(54, 42);
            this.pictureAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureAvatar.TabIndex = 0;
            this.pictureAvatar.TabStop = false;
            // 
            // labelNick
            // 
            this.labelNick.AutoSize = true;
            this.labelNick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNick.Location = new System.Drawing.Point(64, 6);
            this.labelNick.Name = "labelNick";
            this.labelNick.Size = new System.Drawing.Size(32, 16);
            this.labelNick.TabIndex = 1;
            this.labelNick.Text = "nick";
            // 
            // labelDisponible
            // 
            this.labelDisponible.AutoSize = true;
            this.labelDisponible.Location = new System.Drawing.Point(65, 30);
            this.labelDisponible.Name = "labelDisponible";
            this.labelDisponible.Size = new System.Drawing.Size(56, 13);
            this.labelDisponible.TabIndex = 2;
            this.labelDisponible.Text = "Disponible";
            // 
            // ControlUsuarioAmigosTarjetaAmigos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelDisponible);
            this.Controls.Add(this.labelNick);
            this.Controls.Add(this.pictureAvatar);
            this.Name = "ControlUsuarioAmigosTarjetaAmigos";
            this.Size = new System.Drawing.Size(247, 53);
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureAvatar;
        private System.Windows.Forms.Label labelNick;
        private System.Windows.Forms.Label labelDisponible;
    }
}
