namespace TurboGas
{
    partial class Login
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
            this.ucOTP = new TurboGas.OTPCorreo();
            this.linkFMP = new System.Windows.Forms.LinkLabel();
            this.linkRegistro = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new TurboGas.Elementos.Botón();
            this.tbCorreo = new TurboGas.Elementos.textbox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.tbContraseña = new TurboGas.Elementos.Contraseñas();
            this.lblTitle = new System.Windows.Forms.Label();
            this.ucRegistro = new TurboGas.SignIn();
            this.ucSucursales = new TurboGas.Sucursales();
            this.roundPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.roundPanel1.Controls.Add(this.ucOTP);
            this.roundPanel1.Controls.Add(this.linkFMP);
            this.roundPanel1.Controls.Add(this.linkRegistro);
            this.roundPanel1.Controls.Add(this.btnLogin);
            this.roundPanel1.Controls.Add(this.tbCorreo);
            this.roundPanel1.Controls.Add(this.lblContraseña);
            this.roundPanel1.Controls.Add(this.lblUsuario);
            this.roundPanel1.Controls.Add(this.tbContraseña);
            this.roundPanel1.Controls.Add(this.lblTitle);
            this.roundPanel1.Location = new System.Drawing.Point(144, 78);
            this.roundPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(612, 439);
            this.roundPanel1.TabIndex = 1;
            // 
            // ucOTP
            // 
            this.ucOTP.BackColor = System.Drawing.Color.White;
            this.ucOTP.Location = new System.Drawing.Point(-144, -78);
            this.ucOTP.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucOTP.Name = "ucOTP";
            this.ucOTP.Size = new System.Drawing.Size(900, 625);
            this.ucOTP.TabIndex = 8;
            // 
            // linkFMP
            // 
            this.linkFMP.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.linkFMP.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.linkFMP.Location = new System.Drawing.Point(3, 376);
            this.linkFMP.Name = "linkFMP";
            this.linkFMP.Size = new System.Drawing.Size(605, 29);
            this.linkFMP.TabIndex = 7;
            this.linkFMP.TabStop = true;
            this.linkFMP.Text = "Olvidé mi contraseña";
            this.linkFMP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkFMP.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.linkFMP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFMP_LinkClicked);
            // 
            // linkRegistro
            // 
            this.linkRegistro.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.linkRegistro.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.linkRegistro.Location = new System.Drawing.Point(3, 344);
            this.linkRegistro.Name = "linkRegistro";
            this.linkRegistro.Size = new System.Drawing.Size(605, 29);
            this.linkRegistro.TabIndex = 6;
            this.linkRegistro.TabStop = true;
            this.linkRegistro.Text = "¿Aún no te registras?";
            this.linkRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkRegistro.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.linkRegistro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegistro_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(125)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLogin.Location = new System.Drawing.Point(223, 274);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(169, 50);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Iniciar sesión";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbCorreo
            // 
            this.tbCorreo.BackColor = System.Drawing.Color.White;
            this.tbCorreo.Location = new System.Drawing.Point(213, 122);
            this.tbCorreo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.tbCorreo.Size = new System.Drawing.Size(310, 50);
            this.tbCorreo.TabIndex = 4;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Poppins", 9F);
            this.lblContraseña.Location = new System.Drawing.Point(70, 201);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(126, 31);
            this.lblContraseña.TabIndex = 3;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Poppins", 9F);
            this.lblUsuario.Location = new System.Drawing.Point(111, 131);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(81, 31);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Correo:";
            // 
            // tbContraseña
            // 
            this.tbContraseña.BackColor = System.Drawing.Color.White;
            this.tbContraseña.Location = new System.Drawing.Point(213, 190);
            this.tbContraseña.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Padding = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.tbContraseña.Size = new System.Drawing.Size(310, 50);
            this.tbContraseña.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Poppins Medium", 12F);
            this.lblTitle.Location = new System.Drawing.Point(3, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(605, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Inicio de sesión";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucRegistro
            // 
            this.ucRegistro.BackColor = System.Drawing.Color.White;
            this.ucRegistro.Location = new System.Drawing.Point(0, 0);
            this.ucRegistro.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucRegistro.Name = "ucRegistro";
            this.ucRegistro.Size = new System.Drawing.Size(900, 625);
            this.ucRegistro.TabIndex = 9;
            // 
            // ucSucursales
            // 
            this.ucSucursales.BackColor = System.Drawing.Color.White;
            this.ucSucursales.Location = new System.Drawing.Point(0, 0);
            this.ucSucursales.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ucSucursales.Name = "ucSucursales";
            this.ucSucursales.Size = new System.Drawing.Size(900, 625);
            this.ucSucursales.TabIndex = 10;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ucSucursales);
            this.Controls.Add(this.ucRegistro);
            this.Controls.Add(this.roundPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(900, 625);
            this.roundPanel1.ResumeLayout(false);
            this.roundPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private Elementos.RoundPanel roundPanel1;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private Elementos.Contraseñas tbContraseña;
        private Elementos.Botón btnLogin;
        private Elementos.textbox tbCorreo;
        private System.Windows.Forms.LinkLabel linkFMP;
        private System.Windows.Forms.LinkLabel linkRegistro;
        private OTPCorreo ucOTP;
        private SignIn ucRegistro;
        private Sucursales ucSucursales;
    }
}
