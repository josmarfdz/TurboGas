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
            this.Header = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.ucSistemaB = new TurboGas.SistemaBomba();
            this.btnInfo2 = new TurboGas.Elementos.Botón();
            this.btnInfo1 = new TurboGas.Elementos.Botón();
            this.btConfiguración = new TurboGas.Elementos.Botón();
            this.roundPanel2 = new TurboGas.Elementos.RoundPanel();
            this.btnBomba4 = new TurboGas.Elementos.Botón();
            this.btnBomba3 = new TurboGas.Elementos.Botón();
            this.btPerfil = new TurboGas.Elementos.Botón();
            this.roundPanel1 = new TurboGas.Elementos.RoundPanel();
            this.btnBomba2 = new TurboGas.Elementos.Botón();
            this.btnBomba1 = new TurboGas.Elementos.Botón();
            this.ucSistemaBomba = new TurboGas.SistemaBomba();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.roundPanel2.SuspendLayout();
            this.roundPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.Header.Controls.Add(this.pictureBox1);
            this.Header.Controls.Add(this.btPerfil);
            this.Header.Controls.Add(this.lblNombre);
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(900, 84);
            this.Header.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Poppins SemiBold", 10F);
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(680, 28);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(212, 36);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre de usuario";
            // 
            // ucSistemaB
            // 
            this.ucSistemaB.BackColor = System.Drawing.Color.White;
            this.ucSistemaB.Location = new System.Drawing.Point(0, 0);
            this.ucSistemaB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucSistemaB.Name = "ucSistemaB";
            this.ucSistemaB.NumeroBomba = "Bomba ##";
            this.ucSistemaB.Size = new System.Drawing.Size(900, 656);
            this.ucSistemaB.TabIndex = 5;
            // 
            // btnInfo2
            // 
            this.btnInfo2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.btnInfo2.FlatAppearance.BorderSize = 0;
            this.btnInfo2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.btnInfo2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(125)))));
            this.btnInfo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnInfo2.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo2.Image")));
            this.btnInfo2.Location = new System.Drawing.Point(667, 431);
            this.btnInfo2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInfo2.Name = "btnInfo2";
            this.btnInfo2.Size = new System.Drawing.Size(45, 50);
            this.btnInfo2.TabIndex = 4;
            this.btnInfo2.UseVisualStyleBackColor = false;
            this.btnInfo2.Click += new System.EventHandler(this.btnInfo2_Click);
            // 
            // btnInfo1
            // 
            this.btnInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.btnInfo1.FlatAppearance.BorderSize = 0;
            this.btnInfo1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.btnInfo1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(125)))));
            this.btnInfo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnInfo1.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo1.Image")));
            this.btnInfo1.Location = new System.Drawing.Point(667, 190);
            this.btnInfo1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInfo1.Name = "btnInfo1";
            this.btnInfo1.Size = new System.Drawing.Size(45, 50);
            this.btnInfo1.TabIndex = 3;
            this.btnInfo1.UseVisualStyleBackColor = false;
            this.btnInfo1.Click += new System.EventHandler(this.btnInfo1_Click);
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
            this.btConfiguración.Location = new System.Drawing.Point(824, 104);
            this.btConfiguración.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btConfiguración.Name = "btConfiguración";
            this.btConfiguración.Size = new System.Drawing.Size(45, 50);
            this.btConfiguración.TabIndex = 2;
            this.btConfiguración.UseVisualStyleBackColor = false;
            this.btConfiguración.Click += new System.EventHandler(this.btConfiguración_Click);
            // 
            // roundPanel2
            // 
            this.roundPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.roundPanel2.Controls.Add(this.btnBomba4);
            this.roundPanel2.Controls.Add(this.btnBomba3);
            this.roundPanel2.Location = new System.Drawing.Point(177, 378);
            this.roundPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roundPanel2.Name = "roundPanel2";
            this.roundPanel2.Size = new System.Drawing.Size(513, 155);
            this.roundPanel2.TabIndex = 1;
            // 
            // btnBomba4
            // 
            this.btnBomba4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.btnBomba4.FlatAppearance.BorderSize = 0;
            this.btnBomba4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.btnBomba4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(125)))));
            this.btnBomba4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBomba4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBomba4.Image = ((System.Drawing.Image)(resources.GetObject("btnBomba4.Image")));
            this.btnBomba4.Location = new System.Drawing.Point(331, 54);
            this.btnBomba4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBomba4.Name = "btnBomba4";
            this.btnBomba4.Size = new System.Drawing.Size(45, 50);
            this.btnBomba4.TabIndex = 8;
            this.btnBomba4.UseVisualStyleBackColor = false;
            this.btnBomba4.Click += new System.EventHandler(this.btnBomba4_Click);
            // 
            // btnBomba3
            // 
            this.btnBomba3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.btnBomba3.FlatAppearance.BorderSize = 0;
            this.btnBomba3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.btnBomba3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(125)))));
            this.btnBomba3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBomba3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBomba3.Image = ((System.Drawing.Image)(resources.GetObject("btnBomba3.Image")));
            this.btnBomba3.Location = new System.Drawing.Point(137, 54);
            this.btnBomba3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBomba3.Name = "btnBomba3";
            this.btnBomba3.Size = new System.Drawing.Size(45, 50);
            this.btnBomba3.TabIndex = 7;
            this.btnBomba3.UseVisualStyleBackColor = false;
            this.btnBomba3.Click += new System.EventHandler(this.btnBomba3_Click);
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
            this.btPerfil.Location = new System.Drawing.Point(624, 15);
            this.btPerfil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btPerfil.Name = "btPerfil";
            this.btPerfil.Size = new System.Drawing.Size(48, 50);
            this.btPerfil.TabIndex = 1;
            this.btPerfil.UseVisualStyleBackColor = false;
            this.btPerfil.Click += new System.EventHandler(this.btPerfil_Click);
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.roundPanel1.Controls.Add(this.btnBomba2);
            this.roundPanel1.Controls.Add(this.btnBomba1);
            this.roundPanel1.Location = new System.Drawing.Point(177, 139);
            this.roundPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(513, 155);
            this.roundPanel1.TabIndex = 0;
            // 
            // btnBomba2
            // 
            this.btnBomba2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.btnBomba2.FlatAppearance.BorderSize = 0;
            this.btnBomba2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.btnBomba2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(125)))));
            this.btnBomba2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBomba2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBomba2.Image = ((System.Drawing.Image)(resources.GetObject("btnBomba2.Image")));
            this.btnBomba2.Location = new System.Drawing.Point(331, 51);
            this.btnBomba2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBomba2.Name = "btnBomba2";
            this.btnBomba2.Size = new System.Drawing.Size(45, 50);
            this.btnBomba2.TabIndex = 5;
            this.btnBomba2.UseVisualStyleBackColor = false;
            this.btnBomba2.Click += new System.EventHandler(this.btnBomba2_Click);
            // 
            // btnBomba1
            // 
            this.btnBomba1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.btnBomba1.FlatAppearance.BorderSize = 0;
            this.btnBomba1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.btnBomba1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(125)))));
            this.btnBomba1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBomba1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBomba1.Image = ((System.Drawing.Image)(resources.GetObject("btnBomba1.Image")));
            this.btnBomba1.Location = new System.Drawing.Point(137, 51);
            this.btnBomba1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBomba1.Name = "btnBomba1";
            this.btnBomba1.Size = new System.Drawing.Size(45, 50);
            this.btnBomba1.TabIndex = 6;
            this.btnBomba1.UseVisualStyleBackColor = false;
            this.btnBomba1.Click += new System.EventHandler(this.btnBomba1_Click);
            // 
            // ucSistemaBomba
            // 
            this.ucSistemaBomba.BackColor = System.Drawing.Color.White;
            this.ucSistemaBomba.Location = new System.Drawing.Point(0, 0);
            this.ucSistemaBomba.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucSistemaBomba.Name = "ucSistemaBomba";
            this.ucSistemaBomba.NumeroBomba = "Bomba ##";
            this.ucSistemaBomba.Size = new System.Drawing.Size(900, 656);
            this.ucSistemaBomba.TabIndex = 5;
            // 
            // Islas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ucSistemaB);
            this.Controls.Add(this.btnInfo2);
            this.Controls.Add(this.btnInfo1);
            this.Controls.Add(this.btConfiguración);
            this.Controls.Add(this.roundPanel2);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.roundPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Islas";
            this.Size = new System.Drawing.Size(900, 672);
            this.Load += new System.EventHandler(this.Islas_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.roundPanel2.ResumeLayout(false);
            this.roundPanel1.ResumeLayout(false);
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
        private Elementos.Botón btnInfo1;
        private Elementos.Botón btnInfo2;
        private Elementos.Botón btnBomba2;
        private Elementos.Botón btnBomba1;
        private Elementos.Botón btnBomba4;
        private Elementos.Botón btnBomba3;
        private SistemaBomba ucSistemaBomba;
        private SistemaBomba ucSistemaB;
    }
}
