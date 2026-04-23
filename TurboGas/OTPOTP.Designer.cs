namespace TurboGas
{
    partial class OTPOTP
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
            this.roundPanel1 = new TurboGas.Elementos.RoundPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new TurboGas.Elementos.Botón();
            this.btnConfirmar = new TurboGas.Elementos.Botón();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbOTP = new TurboGas.Elementos.textbox();
            this.ucContraseña = new TurboGas.CambioContraseña();
            this.roundPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.roundPanel1.Controls.Add(this.label1);
            this.roundPanel1.Controls.Add(this.btnBack);
            this.roundPanel1.Controls.Add(this.btnConfirmar);
            this.roundPanel1.Controls.Add(this.lblTitle);
            this.roundPanel1.Controls.Add(this.tbOTP);
            this.roundPanel1.Location = new System.Drawing.Point(191, 131);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(418, 238);
            this.roundPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 7F);
            this.label1.Location = new System.Drawing.Point(54, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 44);
            this.label1.TabIndex = 4;
            this.label1.Text = "Te hemos enviado una OTP a tu correo electrónico,\r\nsi no la encuntras revisa la c" +
    "arpeta de spam.\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(125)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Poppins SemiBold", 10F);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBack.Location = new System.Drawing.Point(22, 16);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(30, 33);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.btnConfirmar.FlatAppearance.BorderSize = 0;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(125)))));
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnConfirmar.Location = new System.Drawing.Point(129, 132);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(150, 39);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Poppins Medium", 10F);
            this.lblTitle.Location = new System.Drawing.Point(3, 34);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(412, 29);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Ingresa la OTP";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbOTP
            // 
            this.tbOTP.BackColor = System.Drawing.Color.White;
            this.tbOTP.Location = new System.Drawing.Point(85, 74);
            this.tbOTP.Name = "tbOTP";
            this.tbOTP.Padding = new System.Windows.Forms.Padding(10);
            this.tbOTP.Size = new System.Drawing.Size(238, 39);
            this.tbOTP.TabIndex = 0;
            // 
            // ucContraseña
            // 
            this.ucContraseña.BackColor = System.Drawing.Color.White;
            this.ucContraseña.Location = new System.Drawing.Point(3, 3);
            this.ucContraseña.Name = "ucContraseña";
            this.ucContraseña.Size = new System.Drawing.Size(800, 500);
            this.ucContraseña.TabIndex = 3;
            // 
            // OTPOTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ucContraseña);
            this.Controls.Add(this.roundPanel1);
            this.Name = "OTPOTP";
            this.Size = new System.Drawing.Size(800, 500);
            this.roundPanel1.ResumeLayout(false);
            this.roundPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Elementos.RoundPanel roundPanel1;
        private Elementos.Botón btnBack;
        private Elementos.Botón btnConfirmar;
        private System.Windows.Forms.Label lblTitle;
        private Elementos.textbox tbOTP;
        private System.Windows.Forms.Label label1;
        private CambioContraseña ucContraseña;
    }
}
