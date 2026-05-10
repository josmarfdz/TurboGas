namespace TurboGas
{
    partial class CRUD_Islas
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
            this.btnCreate = new TurboGas.Elementos.Botón();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCreSucursal = new System.Windows.Forms.ComboBox();
            this.cmbUpdSuc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpd = new TurboGas.Elementos.Botón();
            this.cmbUpdBomba = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDelBomb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDel = new TurboGas.Elementos.Botón();
            this.roundPanel1 = new TurboGas.Elementos.RoundPanel();
            this.roundPanel2 = new TurboGas.Elementos.RoundPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.roundPanel3 = new TurboGas.Elementos.RoundPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNombreUser = new System.Windows.Forms.Label();
            this.btnVendedores = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnTipos = new System.Windows.Forms.Button();
            this.btnTanques = new System.Windows.Forms.Button();
            this.btnIslas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.roundPanel1.SuspendLayout();
            this.roundPanel2.SuspendLayout();
            this.roundPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(125)))));
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCreate.Location = new System.Drawing.Point(165, 97);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(150, 40);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Crear";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.label1.Location = new System.Drawing.Point(9, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sucursal a la que pertenece";
            // 
            // cmbCreSucursal
            // 
            this.cmbCreSucursal.FormattingEnabled = true;
            this.cmbCreSucursal.Location = new System.Drawing.Point(271, 49);
            this.cmbCreSucursal.Name = "cmbCreSucursal";
            this.cmbCreSucursal.Size = new System.Drawing.Size(121, 28);
            this.cmbCreSucursal.TabIndex = 3;
            // 
            // cmbUpdSuc
            // 
            this.cmbUpdSuc.FormattingEnabled = true;
            this.cmbUpdSuc.Location = new System.Drawing.Point(271, 55);
            this.cmbUpdSuc.Name = "cmbUpdSuc";
            this.cmbUpdSuc.Size = new System.Drawing.Size(121, 28);
            this.cmbUpdSuc.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sucursal a la que pertenece";
            // 
            // btnUpd
            // 
            this.btnUpd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.btnUpd.FlatAppearance.BorderSize = 0;
            this.btnUpd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.btnUpd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(125)))));
            this.btnUpd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnUpd.Location = new System.Drawing.Point(165, 157);
            this.btnUpd.Name = "btnUpd";
            this.btnUpd.Size = new System.Drawing.Size(150, 40);
            this.btnUpd.TabIndex = 4;
            this.btnUpd.Text = "Actualizar";
            this.btnUpd.UseVisualStyleBackColor = false;
            this.btnUpd.Click += new System.EventHandler(this.btnUpd_Click);
            // 
            // cmbUpdBomba
            // 
            this.cmbUpdBomba.FormattingEnabled = true;
            this.cmbUpdBomba.Location = new System.Drawing.Point(271, 13);
            this.cmbUpdBomba.Name = "cmbUpdBomba";
            this.cmbUpdBomba.Size = new System.Drawing.Size(121, 28);
            this.cmbUpdBomba.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bomba";
            // 
            // cmbDelBomb
            // 
            this.cmbDelBomb.FormattingEnabled = true;
            this.cmbDelBomb.Location = new System.Drawing.Point(271, 44);
            this.cmbDelBomb.Name = "cmbDelBomb";
            this.cmbDelBomb.Size = new System.Drawing.Size(121, 28);
            this.cmbDelBomb.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.label4.Location = new System.Drawing.Point(9, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bomba";
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.btnDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(125)))));
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDel.Location = new System.Drawing.Point(165, 88);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(150, 40);
            this.btnDel.TabIndex = 9;
            this.btnDel.Text = "Eliminar";
            this.btnDel.UseVisualStyleBackColor = false;
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.roundPanel1.Controls.Add(this.btnCreate);
            this.roundPanel1.Controls.Add(this.label1);
            this.roundPanel1.Controls.Add(this.cmbCreSucursal);
            this.roundPanel1.Location = new System.Drawing.Point(42, 107);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(415, 175);
            this.roundPanel1.TabIndex = 12;
            // 
            // roundPanel2
            // 
            this.roundPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.roundPanel2.Controls.Add(this.label5);
            this.roundPanel2.Controls.Add(this.comboBox1);
            this.roundPanel2.Controls.Add(this.btnUpd);
            this.roundPanel2.Controls.Add(this.label2);
            this.roundPanel2.Controls.Add(this.cmbUpdSuc);
            this.roundPanel2.Controls.Add(this.label3);
            this.roundPanel2.Controls.Add(this.cmbUpdBomba);
            this.roundPanel2.Location = new System.Drawing.Point(487, 107);
            this.roundPanel2.Name = "roundPanel2";
            this.roundPanel2.Size = new System.Drawing.Size(410, 215);
            this.roundPanel2.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.label5.Location = new System.Drawing.Point(16, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "Activa";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(271, 92);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 10;
            // 
            // roundPanel3
            // 
            this.roundPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.roundPanel3.Controls.Add(this.btnDel);
            this.roundPanel3.Controls.Add(this.label4);
            this.roundPanel3.Controls.Add(this.cmbDelBomb);
            this.roundPanel3.Location = new System.Drawing.Point(487, 345);
            this.roundPanel3.Name = "roundPanel3";
            this.roundPanel3.Size = new System.Drawing.Size(410, 151);
            this.roundPanel3.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.lblNombreUser);
            this.panel1.Controls.Add(this.btnVendedores);
            this.panel1.Controls.Add(this.btnUsers);
            this.panel1.Controls.Add(this.btnTipos);
            this.panel1.Controls.Add(this.btnTanques);
            this.panel1.Controls.Add(this.btnIslas);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 81);
            this.panel1.TabIndex = 22;
            // 
            // lblNombreUser
            // 
            this.lblNombreUser.AutoSize = true;
            this.lblNombreUser.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.lblNombreUser.Location = new System.Drawing.Point(678, 25);
            this.lblNombreUser.Name = "lblNombreUser";
            this.lblNombreUser.Size = new System.Drawing.Size(202, 30);
            this.lblNombreUser.TabIndex = 10;
            this.lblNombreUser.Text = ":nombre_del_usuario:";
            // 
            // btnVendedores
            // 
            this.btnVendedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.btnVendedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendedores.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.btnVendedores.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVendedores.Location = new System.Drawing.Point(544, 0);
            this.btnVendedores.Name = "btnVendedores";
            this.btnVendedores.Size = new System.Drawing.Size(128, 81);
            this.btnVendedores.TabIndex = 5;
            this.btnVendedores.Text = "Vendedores";
            this.btnVendedores.UseVisualStyleBackColor = false;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.btnUsers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUsers.Location = new System.Drawing.Point(415, 0);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(129, 81);
            this.btnUsers.TabIndex = 4;
            this.btnUsers.Text = "Usuarios";
            this.btnUsers.UseVisualStyleBackColor = false;
            // 
            // btnTipos
            // 
            this.btnTipos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.btnTipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipos.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.btnTipos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTipos.Location = new System.Drawing.Point(225, 0);
            this.btnTipos.Name = "btnTipos";
            this.btnTipos.Size = new System.Drawing.Size(85, 81);
            this.btnTipos.TabIndex = 3;
            this.btnTipos.Text = "Tipos";
            this.btnTipos.UseVisualStyleBackColor = false;
            // 
            // btnTanques
            // 
            this.btnTanques.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.btnTanques.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTanques.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.btnTanques.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTanques.Location = new System.Drawing.Point(310, 0);
            this.btnTanques.Name = "btnTanques";
            this.btnTanques.Size = new System.Drawing.Size(105, 81);
            this.btnTanques.TabIndex = 2;
            this.btnTanques.Text = "Tanques";
            this.btnTanques.UseVisualStyleBackColor = false;
            // 
            // btnIslas
            // 
            this.btnIslas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.btnIslas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIslas.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.btnIslas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIslas.Location = new System.Drawing.Point(120, 0);
            this.btnIslas.Name = "btnIslas";
            this.btnIslas.Size = new System.Drawing.Size(105, 81);
            this.btnIslas.TabIndex = 1;
            this.btnIslas.Text = "Islas";
            this.btnIslas.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 81);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sucursales";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CRUD_Islas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.roundPanel3);
            this.Controls.Add(this.roundPanel2);
            this.Controls.Add(this.roundPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CRUD_Islas";
            this.Size = new System.Drawing.Size(900, 625);
            this.Load += new System.EventHandler(this.CRUD_Islas_Load);
            this.roundPanel1.ResumeLayout(false);
            this.roundPanel1.PerformLayout();
            this.roundPanel2.ResumeLayout(false);
            this.roundPanel2.PerformLayout();
            this.roundPanel3.ResumeLayout(false);
            this.roundPanel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Elementos.Botón btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCreSucursal;
        private System.Windows.Forms.ComboBox cmbUpdSuc;
        private System.Windows.Forms.Label label2;
        private Elementos.Botón btnUpd;
        private System.Windows.Forms.ComboBox cmbUpdBomba;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDelBomb;
        private System.Windows.Forms.Label label4;
        private Elementos.Botón btnDel;
        private Elementos.RoundPanel roundPanel1;
        private Elementos.RoundPanel roundPanel2;
        private Elementos.RoundPanel roundPanel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombreUser;
        private System.Windows.Forms.Button btnVendedores;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnTipos;
        private System.Windows.Forms.Button btnTanques;
        private System.Windows.Forms.Button btnIslas;
        private System.Windows.Forms.Button button1;
    }
}
