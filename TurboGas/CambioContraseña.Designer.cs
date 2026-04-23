namespace TurboGas
{
    partial class CambioContraseña
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
            this.botón1 = new TurboGas.Elementos.Botón();
            this.btConfirmar = new TurboGas.Elementos.Botón();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tbNueva = new TurboGas.Elementos.Contraseñas();
            this.tbConfirmar = new TurboGas.Elementos.Contraseñas();
            this.roundPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.roundPanel1.Controls.Add(this.botón1);
            this.roundPanel1.Controls.Add(this.btConfirmar);
            this.roundPanel1.Controls.Add(this.label3);
            this.roundPanel1.Controls.Add(this.label1);
            this.roundPanel1.Controls.Add(this.label2);
            this.roundPanel1.Controls.Add(this.lbTitle);
            this.roundPanel1.Controls.Add(this.tbNueva);
            this.roundPanel1.Controls.Add(this.tbConfirmar);
            this.roundPanel1.Location = new System.Drawing.Point(93, 61);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(583, 363);
            this.roundPanel1.TabIndex = 0;
            // 
            // botón1
            // 
            this.botón1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.botón1.FlatAppearance.BorderSize = 0;
            this.botón1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.botón1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(125)))));
            this.botón1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botón1.Font = new System.Drawing.Font("Poppins SemiBold", 10F);
            this.botón1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.botón1.Location = new System.Drawing.Point(19, 18);
            this.botón1.Name = "botón1";
            this.botón1.Size = new System.Drawing.Size(44, 40);
            this.botón1.TabIndex = 8;
            this.botón1.Text = " <";
            this.botón1.UseVisualStyleBackColor = false;
            this.botón1.Click += new System.EventHandler(this.botón1_Click);
            // 
            // btConfirmar
            // 
            this.btConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.btConfirmar.FlatAppearance.BorderSize = 0;
            this.btConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.btConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(125)))));
            this.btConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfirmar.Font = new System.Drawing.Font("Poppins Medium", 8.25F);
            this.btConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btConfirmar.Location = new System.Drawing.Point(212, 215);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(150, 40);
            this.btConfirmar.TabIndex = 7;
            this.btConfirmar.Text = "Confirmar";
            this.btConfirmar.UseVisualStyleBackColor = false;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.label3.Location = new System.Drawing.Point(3, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(577, 81);
            this.label3.TabIndex = 6;
            this.label3.Text = "La contraseña requiere mínimo 8 caracteres: mínimo una letra \r\nmayúscula y minúsc" +
    "ula, un número y un carácter especial\r\n(! \\\" # $ % & _ )\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9F);
            this.label1.Location = new System.Drawing.Point(35, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Confirmar contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F);
            this.label2.Location = new System.Drawing.Point(65, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nueva contraseña:";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Poppins Medium", 12F);
            this.lbTitle.Location = new System.Drawing.Point(164, 22);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(250, 36);
            this.lbTitle.TabIndex = 3;
            this.lbTitle.Text = "Cambio de contraseña";
            // 
            // tbNueva
            // 
            this.tbNueva.BackColor = System.Drawing.Color.White;
            this.tbNueva.Location = new System.Drawing.Point(239, 83);
            this.tbNueva.Name = "tbNueva";
            this.tbNueva.Padding = new System.Windows.Forms.Padding(10);
            this.tbNueva.Size = new System.Drawing.Size(284, 40);
            this.tbNueva.TabIndex = 2;
            // 
            // tbConfirmar
            // 
            this.tbConfirmar.BackColor = System.Drawing.Color.White;
            this.tbConfirmar.Location = new System.Drawing.Point(239, 149);
            this.tbConfirmar.Name = "tbConfirmar";
            this.tbConfirmar.Padding = new System.Windows.Forms.Padding(10);
            this.tbConfirmar.Size = new System.Drawing.Size(284, 40);
            this.tbConfirmar.TabIndex = 1;
            // 
            // CambioContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.roundPanel1);
            this.Name = "CambioContraseña";
            this.Size = new System.Drawing.Size(800, 500);
            this.roundPanel1.ResumeLayout(false);
            this.roundPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Elementos.RoundPanel roundPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTitle;
        private Elementos.Contraseñas tbNueva;
        private Elementos.Contraseñas tbConfirmar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Elementos.Botón btConfirmar;
        private Elementos.Botón botón1;
    }
}
