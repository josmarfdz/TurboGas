namespace TurboGas
{
    partial class OTPCorreo
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
            this.tbCorreo = new TurboGas.Elementos.textbox();
            this.roundPanel1 = new TurboGas.Elementos.RoundPanel();
            this.btnBack = new TurboGas.Elementos.Botón();
            this.btnConfirmar = new TurboGas.Elementos.Botón();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ucOTP = new TurboGas.OTPOTP();
            this.roundPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCorreo
            // 
            this.tbCorreo.BackColor = System.Drawing.Color.White;
            this.tbCorreo.Location = new System.Drawing.Point(96, 115);
            this.tbCorreo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.tbCorreo.Size = new System.Drawing.Size(268, 49);
            this.tbCorreo.TabIndex = 0;
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.roundPanel1.Controls.Add(this.btnBack);
            this.roundPanel1.Controls.Add(this.btnConfirmar);
            this.roundPanel1.Controls.Add(this.lblTitle);
            this.roundPanel1.Controls.Add(this.tbCorreo);
            this.roundPanel1.Location = new System.Drawing.Point(217, 140);
            this.roundPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(470, 298);
            this.roundPanel1.TabIndex = 1;
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
            this.btnBack.Location = new System.Drawing.Point(25, 20);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(34, 41);
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
            this.btnConfirmar.Location = new System.Drawing.Point(145, 188);
            this.btnConfirmar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(169, 49);
            this.btnConfirmar.TabIndex = 2;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Poppins Medium", 10F);
            this.lblTitle.Location = new System.Drawing.Point(3, 65);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(464, 36);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Ingresa tu correo electrónico";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucOTP
            // 
            this.ucOTP.BackColor = System.Drawing.Color.White;
            this.ucOTP.Location = new System.Drawing.Point(3, 4);
            this.ucOTP.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucOTP.Name = "ucOTP";
            this.ucOTP.Size = new System.Drawing.Size(900, 625);
            this.ucOTP.TabIndex = 2;
            this.ucOTP.Load += new System.EventHandler(this.ucOTP_Load);
            // 
            // OTPCorreo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ucOTP);
            this.Controls.Add(this.roundPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OTPCorreo";
            this.Size = new System.Drawing.Size(900, 625);
            this.roundPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Elementos.textbox tbCorreo;
        private Elementos.RoundPanel roundPanel1;
        private System.Windows.Forms.Label lblTitle;
        private Elementos.Botón btnConfirmar;
        private Elementos.Botón btnBack;
        private OTPOTP ucOTP;
    }
}
