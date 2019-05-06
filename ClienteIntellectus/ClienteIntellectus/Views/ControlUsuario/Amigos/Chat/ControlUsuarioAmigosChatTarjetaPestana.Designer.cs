namespace ClienteIntellectus.Views.ControlUsuario.Amigos.Chat
{
    partial class ControlUsuarioAmigosChatTarjetaPestana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlUsuarioAmigosChatTarjetaPestana));
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pictureAvatar = new System.Windows.Forms.PictureBox();
            this.labelNick = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrar
            // 
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(118, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(15, 13);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.TabStop = false;
            // 
            // pictureAvatar
            // 
            this.pictureAvatar.Location = new System.Drawing.Point(4, 4);
            this.pictureAvatar.Name = "pictureAvatar";
            this.pictureAvatar.Size = new System.Drawing.Size(32, 33);
            this.pictureAvatar.TabIndex = 0;
            this.pictureAvatar.TabStop = false;
            // 
            // labelNick
            // 
            this.labelNick.AutoSize = true;
            this.labelNick.Location = new System.Drawing.Point(42, 14);
            this.labelNick.Name = "labelNick";
            this.labelNick.Size = new System.Drawing.Size(29, 13);
            this.labelNick.TabIndex = 2;
            this.labelNick.Text = "Nick";
            // 
            // ControlUsuarioAmigosChatTarjetaPestana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelNick);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.pictureAvatar);
            this.Name = "ControlUsuarioAmigosChatTarjetaPestana";
            this.Size = new System.Drawing.Size(136, 40);
            this.Click += new System.EventHandler(this.ControlUsuarioAmigosChatTarjetaPestana_Click);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureAvatar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Label labelNick;
    }
}
