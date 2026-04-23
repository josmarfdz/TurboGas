namespace TurboGas
{
    partial class Islas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Islas));
            this.roundPanel1 = new TurboGas.Elementos.RoundPanel();
            this.Header = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.roundPanel2 = new TurboGas.Elementos.RoundPanel();
            this.btConfiguración = new TurboGas.Elementos.Botón();
            this.btPerfil = new TurboGas.Elementos.Botón();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.roundPanel1.Location = new System.Drawing.Point(157, 111);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(456, 124);
            this.roundPanel1.TabIndex = 0;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.Header.Controls.Add(this.pictureBox1);
            this.Header.Controls.Add(this.btPerfil);
            this.Header.Controls.Add(this.lblNombre);
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(800, 67);
            this.Header.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Poppins SemiBold", 10F);
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(604, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(179, 30);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre de usuario";
            // 
            // roundPanel2
            // 
            this.roundPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.roundPanel2.Location = new System.Drawing.Point(157, 302);
            this.roundPanel2.Name = "roundPanel2";
            this.roundPanel2.Size = new System.Drawing.Size(456, 124);
            this.roundPanel2.TabIndex = 1;
            // 
            // btConfiguración
            // 
            this.btConfiguración.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.btConfiguración.FlatAppearance.BorderSize = 0;
            this.btConfiguración.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.btConfiguración.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(125)))));
            this.btConfiguración.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfiguración.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btConfiguración.Image = ((System.Drawing.Image)(resources.GetObject("btConfiguración.Image")));
            this.btConfiguración.Location = new System.Drawing.Point(732, 83);
            this.btConfiguración.Name = "btConfiguración";
            this.btConfiguración.Size = new System.Drawing.Size(40, 40);
            this.btConfiguración.TabIndex = 2;
            this.btConfiguración.UseVisualStyleBackColor = false;
            this.btConfiguración.Click += new System.EventHandler(this.btConfiguración_Click);
            // 
            // btPerfil
            // 
            this.btPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.btPerfil.FlatAppearance.BorderSize = 0;
            this.btPerfil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.btPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(125)))));
            this.btPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPerfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btPerfil.Image = ((System.Drawing.Image)(resources.GetObject("btPerfil.Image")));
            this.btPerfil.Location = new System.Drawing.Point(555, 12);
            this.btPerfil.Name = "btPerfil";
            this.btPerfil.Size = new System.Drawing.Size(43, 40);
            this.btPerfil.TabIndex = 1;
            this.btPerfil.UseVisualStyleBackColor = false;
            this.btPerfil.Click += new System.EventHandler(this.btPerfil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Islas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btConfiguración);
            this.Controls.Add(this.roundPanel2);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.roundPanel1);
            this.Name = "Islas";
            this.Size = new System.Drawing.Size(800, 500);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Elementos.RoundPanel roundPanel1;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Label lblNombre;
        private Elementos.RoundPanel roundPanel2;
        private Elementos.Botón btConfiguración;
        private Elementos.Botón btPerfil;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
