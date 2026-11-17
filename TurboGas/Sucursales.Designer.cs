namespace TurboGas
{
    partial class Sucursales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sucursales));
            this.roundPanel1 = new TurboGas.Elementos.RoundPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.botón1 = new TurboGas.Elementos.Botón();
            this.roundPanel5 = new TurboGas.Elementos.RoundPanel();
            this.lblDirecciónSucursal = new System.Windows.Forms.Label();
            this.lblNombreSucursal = new System.Windows.Forms.Label();
            this.btOff = new TurboGas.Elementos.Botón();
            this.lblSOff = new System.Windows.Forms.Label();
            this.btnSettings = new TurboGas.Elementos.Botón();
            this.roundPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.roundPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.roundPanel1.Controls.Add(this.pictureBox1);
            this.roundPanel1.Controls.Add(this.botón1);
            this.roundPanel1.Controls.Add(this.roundPanel5);
            this.roundPanel1.Location = new System.Drawing.Point(61, 74);
            this.roundPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(327, 198);
            this.roundPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(19, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 89);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // botón1
            // 
            this.botón1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.botón1.FlatAppearance.BorderSize = 0;
            this.botón1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.botón1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(125)))));
            this.botón1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botón1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.botón1.Location = new System.Drawing.Point(210, 20);
            this.botón1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.botón1.Name = "botón1";
            this.botón1.Size = new System.Drawing.Size(97, 89);
            this.botón1.TabIndex = 1;
            this.botón1.Text = "Entrar";
            this.botón1.UseVisualStyleBackColor = false;
            this.botón1.Click += new System.EventHandler(this.botón1_Click);
            // 
            // roundPanel5
            // 
            this.roundPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.roundPanel5.Controls.Add(this.lblDirecciónSucursal);
            this.roundPanel5.Controls.Add(this.lblNombreSucursal);
            this.roundPanel5.Location = new System.Drawing.Point(19, 116);
            this.roundPanel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roundPanel5.Name = "roundPanel5";
            this.roundPanel5.Size = new System.Drawing.Size(288, 74);
            this.roundPanel5.TabIndex = 0;
            // 
            // lblDirecciónSucursal
            // 
            this.lblDirecciónSucursal.AutoSize = true;
            this.lblDirecciónSucursal.Font = new System.Drawing.Font("Poppins", 7F);
            this.lblDirecciónSucursal.Location = new System.Drawing.Point(10, 42);
            this.lblDirecciónSucursal.Name = "lblDirecciónSucursal";
            this.lblDirecciónSucursal.Size = new System.Drawing.Size(152, 25);
            this.lblDirecciónSucursal.TabIndex = 1;
            this.lblDirecciónSucursal.Text = "lblDirecciónSucursal";
            // 
            // lblNombreSucursal
            // 
            this.lblNombreSucursal.AutoSize = true;
            this.lblNombreSucursal.Font = new System.Drawing.Font("Poppins", 7F);
            this.lblNombreSucursal.Location = new System.Drawing.Point(10, 8);
            this.lblNombreSucursal.Name = "lblNombreSucursal";
            this.lblNombreSucursal.Size = new System.Drawing.Size(142, 25);
            this.lblNombreSucursal.TabIndex = 0;
            this.lblNombreSucursal.Text = "lblNombreSucursal";
            // 
            // btOff
            // 
            this.btOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btOff.FlatAppearance.BorderSize = 0;
            this.btOff.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.btOff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(125)))));
            this.btOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOff.ForeColor = System.Drawing.Color.Black;
            this.btOff.Image = ((System.Drawing.Image)(resources.GetObject("btOff.Image")));
            this.btOff.Location = new System.Drawing.Point(831, 16);
            this.btOff.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btOff.Name = "btOff";
            this.btOff.Size = new System.Drawing.Size(48, 50);
            this.btOff.TabIndex = 4;
            this.btOff.UseVisualStyleBackColor = false;
            this.btOff.Click += new System.EventHandler(this.btOff_Click);
            // 
            // lblSOff
            // 
            this.lblSOff.AutoSize = true;
            this.lblSOff.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.lblSOff.Location = new System.Drawing.Point(705, 28);
            this.lblSOff.Name = "lblSOff";
            this.lblSOff.Size = new System.Drawing.Size(130, 30);
            this.lblSOff.TabIndex = 5;
            this.lblSOff.Text = "Cerrar sesión:";
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(125)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.Black;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(831, 560);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(48, 50);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // Sucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.lblSOff);
            this.Controls.Add(this.btOff);
            this.Controls.Add(this.roundPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Sucursales";
            this.Size = new System.Drawing.Size(900, 625);
            this.Load += new System.EventHandler(this.Sucursales_Load);
            this.roundPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.roundPanel5.ResumeLayout(false);
            this.roundPanel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Elementos.RoundPanel roundPanel1;
        private Elementos.RoundPanel roundPanel5;
        private System.Windows.Forms.Label lblDirecciónSucursal;
        private System.Windows.Forms.Label lblNombreSucursal;
        private Elementos.Botón botón1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Elementos.Botón btOff;
        private System.Windows.Forms.Label lblSOff;
        private Elementos.Botón btnSettings;
    }
}
