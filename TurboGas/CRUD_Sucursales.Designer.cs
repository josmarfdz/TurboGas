namespace TurboGas
{
    partial class CRUD_Sucursales
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
            this.txtBoxRegName = new TurboGas.Elementos.textbox();
            this.btnRegistrarSucursales = new TurboGas.Elementos.Botón();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegDomicilio = new TurboGas.Elementos.textbox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRegCiudad = new TurboGas.Elementos.textbox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRegEstado = new TurboGas.Elementos.textbox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRegCp = new TurboGas.Elementos.textbox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRegTelefono = new TurboGas.Elementos.textbox();
            this.rndCreation = new TurboGas.Elementos.RoundPanel();
            this.rdCreate = new System.Windows.Forms.RadioButton();
            this.rndPanelAct = new TurboGas.Elementos.RoundPanel();
            this.rdAct = new System.Windows.Forms.RadioButton();
            this.btnActSucursales = new TurboGas.Elementos.Botón();
            this.cmbSucId1 = new System.Windows.Forms.ComboBox();
            this.txtSucUpd = new TurboGas.Elementos.textbox();
            this.txtAddressSucUpd = new TurboGas.Elementos.textbox();
            this.txtTelSucUpd = new TurboGas.Elementos.textbox();
            this.txtCitSucUpd = new TurboGas.Elementos.textbox();
            this.txtCpSucUpd = new TurboGas.Elementos.textbox();
            this.txtStaSucUpd = new TurboGas.Elementos.textbox();
            this.rndDel = new TurboGas.Elementos.RoundPanel();
            this.btnBorrarSucursales = new TurboGas.Elementos.Botón();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbSucId2 = new System.Windows.Forms.ComboBox();
            this.rdDelete = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblPermisos = new System.Windows.Forms.Label();
            this.rndCreation.SuspendLayout();
            this.rndPanelAct.SuspendLayout();
            this.rndDel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxRegName
            // 
            this.txtBoxRegName.BackColor = System.Drawing.Color.White;
            this.txtBoxRegName.Location = new System.Drawing.Point(126, 14);
            this.txtBoxRegName.Name = "txtBoxRegName";
            this.txtBoxRegName.Padding = new System.Windows.Forms.Padding(10);
            this.txtBoxRegName.Size = new System.Drawing.Size(150, 42);
            this.txtBoxRegName.TabIndex = 0;
            // 
            // btnRegistrarSucursales
            // 
            this.btnRegistrarSucursales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.btnRegistrarSucursales.FlatAppearance.BorderSize = 0;
            this.btnRegistrarSucursales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.btnRegistrarSucursales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(125)))));
            this.btnRegistrarSucursales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarSucursales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnRegistrarSucursales.Location = new System.Drawing.Point(105, 443);
            this.btnRegistrarSucursales.Name = "btnRegistrarSucursales";
            this.btnRegistrarSucursales.Size = new System.Drawing.Size(86, 42);
            this.btnRegistrarSucursales.TabIndex = 1;
            this.btnRegistrarSucursales.Text = "Registrar";
            this.btnRegistrarSucursales.UseVisualStyleBackColor = false;
            this.btnRegistrarSucursales.Click += new System.EventHandler(this.btnRegistrarSucursales_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.label2.Location = new System.Drawing.Point(23, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Direccion";
            // 
            // txtRegDomicilio
            // 
            this.txtRegDomicilio.BackColor = System.Drawing.Color.White;
            this.txtRegDomicilio.Location = new System.Drawing.Point(126, 86);
            this.txtRegDomicilio.Name = "txtRegDomicilio";
            this.txtRegDomicilio.Padding = new System.Windows.Forms.Padding(10);
            this.txtRegDomicilio.Size = new System.Drawing.Size(150, 42);
            this.txtRegDomicilio.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.label3.Location = new System.Drawing.Point(23, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ciudad";
            // 
            // txtRegCiudad
            // 
            this.txtRegCiudad.BackColor = System.Drawing.Color.White;
            this.txtRegCiudad.Location = new System.Drawing.Point(126, 163);
            this.txtRegCiudad.Name = "txtRegCiudad";
            this.txtRegCiudad.Padding = new System.Windows.Forms.Padding(10);
            this.txtRegCiudad.Size = new System.Drawing.Size(150, 42);
            this.txtRegCiudad.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.label4.Location = new System.Drawing.Point(23, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Estado";
            // 
            // txtRegEstado
            // 
            this.txtRegEstado.BackColor = System.Drawing.Color.White;
            this.txtRegEstado.Location = new System.Drawing.Point(126, 237);
            this.txtRegEstado.Name = "txtRegEstado";
            this.txtRegEstado.Padding = new System.Windows.Forms.Padding(10);
            this.txtRegEstado.Size = new System.Drawing.Size(150, 42);
            this.txtRegEstado.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.label5.Location = new System.Drawing.Point(23, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Codigo";
            // 
            // txtRegCp
            // 
            this.txtRegCp.BackColor = System.Drawing.Color.White;
            this.txtRegCp.Location = new System.Drawing.Point(126, 310);
            this.txtRegCp.Name = "txtRegCp";
            this.txtRegCp.Padding = new System.Windows.Forms.Padding(10);
            this.txtRegCp.Size = new System.Drawing.Size(150, 42);
            this.txtRegCp.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.label6.Location = new System.Drawing.Point(23, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 30);
            this.label6.TabIndex = 12;
            this.label6.Text = "Telefono";
            // 
            // txtRegTelefono
            // 
            this.txtRegTelefono.BackColor = System.Drawing.Color.White;
            this.txtRegTelefono.Location = new System.Drawing.Point(126, 381);
            this.txtRegTelefono.Name = "txtRegTelefono";
            this.txtRegTelefono.Padding = new System.Windows.Forms.Padding(10);
            this.txtRegTelefono.Size = new System.Drawing.Size(150, 42);
            this.txtRegTelefono.TabIndex = 11;
            // 
            // rndCreation
            // 
            this.rndCreation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rndCreation.Controls.Add(this.label5);
            this.rndCreation.Controls.Add(this.txtBoxRegName);
            this.rndCreation.Controls.Add(this.label1);
            this.rndCreation.Controls.Add(this.btnRegistrarSucursales);
            this.rndCreation.Controls.Add(this.label6);
            this.rndCreation.Controls.Add(this.txtRegDomicilio);
            this.rndCreation.Controls.Add(this.txtRegTelefono);
            this.rndCreation.Controls.Add(this.label2);
            this.rndCreation.Controls.Add(this.txtRegCiudad);
            this.rndCreation.Controls.Add(this.txtRegCp);
            this.rndCreation.Controls.Add(this.label3);
            this.rndCreation.Controls.Add(this.label4);
            this.rndCreation.Controls.Add(this.txtRegEstado);
            this.rndCreation.Location = new System.Drawing.Point(18, 53);
            this.rndCreation.Name = "rndCreation";
            this.rndCreation.Size = new System.Drawing.Size(302, 505);
            this.rndCreation.TabIndex = 27;
            // 
            // rdCreate
            // 
            this.rdCreate.AutoSize = true;
            this.rdCreate.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.rdCreate.Location = new System.Drawing.Point(76, 13);
            this.rdCreate.Name = "rdCreate";
            this.rdCreate.Size = new System.Drawing.Size(191, 34);
            this.rdCreate.TabIndex = 29;
            this.rdCreate.TabStop = true;
            this.rdCreate.Text = "Creacion/Registro";
            this.rdCreate.UseVisualStyleBackColor = true;
            // 
            // rndPanelAct
            // 
            this.rndPanelAct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rndPanelAct.Controls.Add(this.label7);
            this.rndPanelAct.Controls.Add(this.btnActSucursales);
            this.rndPanelAct.Controls.Add(this.label8);
            this.rndPanelAct.Controls.Add(this.cmbSucId1);
            this.rndPanelAct.Controls.Add(this.label9);
            this.rndPanelAct.Controls.Add(this.txtSucUpd);
            this.rndPanelAct.Controls.Add(this.label10);
            this.rndPanelAct.Controls.Add(this.txtAddressSucUpd);
            this.rndPanelAct.Controls.Add(this.label11);
            this.rndPanelAct.Controls.Add(this.label12);
            this.rndPanelAct.Controls.Add(this.txtTelSucUpd);
            this.rndPanelAct.Controls.Add(this.txtCitSucUpd);
            this.rndPanelAct.Controls.Add(this.txtCpSucUpd);
            this.rndPanelAct.Controls.Add(this.txtStaSucUpd);
            this.rndPanelAct.Location = new System.Drawing.Point(326, 53);
            this.rndPanelAct.Name = "rndPanelAct";
            this.rndPanelAct.Size = new System.Drawing.Size(271, 553);
            this.rndPanelAct.TabIndex = 29;
            // 
            // rdAct
            // 
            this.rdAct.AutoSize = true;
            this.rdAct.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.rdAct.Location = new System.Drawing.Point(381, 13);
            this.rdAct.Name = "rdAct";
            this.rdAct.Size = new System.Drawing.Size(150, 34);
            this.rdAct.TabIndex = 31;
            this.rdAct.TabStop = true;
            this.rdAct.Text = "Actualizacion";
            this.rdAct.UseVisualStyleBackColor = true;
            // 
            // btnActSucursales
            // 
            this.btnActSucursales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.btnActSucursales.FlatAppearance.BorderSize = 0;
            this.btnActSucursales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.btnActSucursales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(125)))));
            this.btnActSucursales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActSucursales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnActSucursales.Location = new System.Drawing.Point(55, 493);
            this.btnActSucursales.Name = "btnActSucursales";
            this.btnActSucursales.Size = new System.Drawing.Size(150, 40);
            this.btnActSucursales.TabIndex = 29;
            this.btnActSucursales.Text = "Actualizar";
            this.btnActSucursales.UseVisualStyleBackColor = false;
            this.btnActSucursales.Click += new System.EventHandler(this.btnActSucursales_Click);
            // 
            // cmbSucId1
            // 
            this.cmbSucId1.FormattingEnabled = true;
            this.cmbSucId1.Location = new System.Drawing.Point(37, 11);
            this.cmbSucId1.Name = "cmbSucId1";
            this.cmbSucId1.Size = new System.Drawing.Size(200, 28);
            this.cmbSucId1.TabIndex = 29;
            // 
            // txtSucUpd
            // 
            this.txtSucUpd.BackColor = System.Drawing.Color.White;
            this.txtSucUpd.Location = new System.Drawing.Point(109, 65);
            this.txtSucUpd.Name = "txtSucUpd";
            this.txtSucUpd.Padding = new System.Windows.Forms.Padding(10);
            this.txtSucUpd.Size = new System.Drawing.Size(150, 42);
            this.txtSucUpd.TabIndex = 0;
            // 
            // txtAddressSucUpd
            // 
            this.txtAddressSucUpd.BackColor = System.Drawing.Color.White;
            this.txtAddressSucUpd.Location = new System.Drawing.Point(109, 135);
            this.txtAddressSucUpd.Name = "txtAddressSucUpd";
            this.txtAddressSucUpd.Padding = new System.Windows.Forms.Padding(10);
            this.txtAddressSucUpd.Size = new System.Drawing.Size(150, 42);
            this.txtAddressSucUpd.TabIndex = 3;
            // 
            // txtTelSucUpd
            // 
            this.txtTelSucUpd.BackColor = System.Drawing.Color.White;
            this.txtTelSucUpd.Location = new System.Drawing.Point(109, 430);
            this.txtTelSucUpd.Name = "txtTelSucUpd";
            this.txtTelSucUpd.Padding = new System.Windows.Forms.Padding(10);
            this.txtTelSucUpd.Size = new System.Drawing.Size(150, 42);
            this.txtTelSucUpd.TabIndex = 11;
            // 
            // txtCitSucUpd
            // 
            this.txtCitSucUpd.BackColor = System.Drawing.Color.White;
            this.txtCitSucUpd.Location = new System.Drawing.Point(109, 212);
            this.txtCitSucUpd.Name = "txtCitSucUpd";
            this.txtCitSucUpd.Padding = new System.Windows.Forms.Padding(10);
            this.txtCitSucUpd.Size = new System.Drawing.Size(150, 42);
            this.txtCitSucUpd.TabIndex = 5;
            // 
            // txtCpSucUpd
            // 
            this.txtCpSucUpd.BackColor = System.Drawing.Color.White;
            this.txtCpSucUpd.Location = new System.Drawing.Point(109, 359);
            this.txtCpSucUpd.Name = "txtCpSucUpd";
            this.txtCpSucUpd.Padding = new System.Windows.Forms.Padding(10);
            this.txtCpSucUpd.Size = new System.Drawing.Size(150, 42);
            this.txtCpSucUpd.TabIndex = 9;
            // 
            // txtStaSucUpd
            // 
            this.txtStaSucUpd.BackColor = System.Drawing.Color.White;
            this.txtStaSucUpd.Location = new System.Drawing.Point(109, 286);
            this.txtStaSucUpd.Name = "txtStaSucUpd";
            this.txtStaSucUpd.Padding = new System.Windows.Forms.Padding(10);
            this.txtStaSucUpd.Size = new System.Drawing.Size(150, 42);
            this.txtStaSucUpd.TabIndex = 7;
            // 
            // rndDel
            // 
            this.rndDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.rndDel.Controls.Add(this.btnBorrarSucursales);
            this.rndDel.Controls.Add(this.label18);
            this.rndDel.Controls.Add(this.cmbSucId2);
            this.rndDel.Location = new System.Drawing.Point(603, 55);
            this.rndDel.Name = "rndDel";
            this.rndDel.Size = new System.Drawing.Size(209, 182);
            this.rndDel.TabIndex = 30;
            // 
            // btnBorrarSucursales
            // 
            this.btnBorrarSucursales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.btnBorrarSucursales.FlatAppearance.BorderSize = 0;
            this.btnBorrarSucursales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.btnBorrarSucursales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(125)))));
            this.btnBorrarSucursales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarSucursales.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBorrarSucursales.Location = new System.Drawing.Point(28, 117);
            this.btnBorrarSucursales.Name = "btnBorrarSucursales";
            this.btnBorrarSucursales.Size = new System.Drawing.Size(150, 40);
            this.btnBorrarSucursales.TabIndex = 31;
            this.btnBorrarSucursales.Text = "Borrar";
            this.btnBorrarSucursales.UseVisualStyleBackColor = false;
            this.btnBorrarSucursales.Click += new System.EventHandler(this.btnBorrarSucursales_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.label18.Location = new System.Drawing.Point(62, 24);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 30);
            this.label18.TabIndex = 32;
            this.label18.Text = "Sucursal";
            // 
            // cmbSucId2
            // 
            this.cmbSucId2.FormattingEnabled = true;
            this.cmbSucId2.Location = new System.Drawing.Point(43, 60);
            this.cmbSucId2.Name = "cmbSucId2";
            this.cmbSucId2.Size = new System.Drawing.Size(121, 28);
            this.cmbSucId2.TabIndex = 31;
            // 
            // rdDelete
            // 
            this.rdDelete.AutoSize = true;
            this.rdDelete.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.rdDelete.Location = new System.Drawing.Point(663, 13);
            this.rdDelete.Name = "rdDelete";
            this.rdDelete.Size = new System.Drawing.Size(104, 34);
            this.rdDelete.TabIndex = 32;
            this.rdDelete.TabStop = true;
            this.rdDelete.Text = "Borrado";
            this.rdDelete.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.label7.Location = new System.Drawing.Point(16, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 30);
            this.label7.TabIndex = 17;
            this.label7.Text = "Codigo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.label8.Location = new System.Drawing.Point(16, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 30);
            this.label8.TabIndex = 13;
            this.label8.Text = "Nombre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.label9.Location = new System.Drawing.Point(16, 442);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 30);
            this.label9.TabIndex = 18;
            this.label9.Text = "Telefono";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.label10.Location = new System.Drawing.Point(16, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 30);
            this.label10.TabIndex = 14;
            this.label10.Text = "Direccion";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.label11.Location = new System.Drawing.Point(16, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 30);
            this.label11.TabIndex = 15;
            this.label11.Text = "Ciudad";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.label12.Location = new System.Drawing.Point(16, 298);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 30);
            this.label12.TabIndex = 16;
            this.label12.Text = "Estado";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(631, 277);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lblNombre.TabIndex = 33;
            this.lblNombre.Text = "Nombre";
            // 
            // lblPermisos
            // 
            this.lblPermisos.AutoSize = true;
            this.lblPermisos.Location = new System.Drawing.Point(635, 317);
            this.lblPermisos.Name = "lblPermisos";
            this.lblPermisos.Size = new System.Drawing.Size(74, 20);
            this.lblPermisos.TabIndex = 34;
            this.lblPermisos.Text = "Permisos";
            // 
            // CRUD_Sucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPermisos);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.rdDelete);
            this.Controls.Add(this.rdCreate);
            this.Controls.Add(this.rdAct);
            this.Controls.Add(this.rndDel);
            this.Controls.Add(this.rndPanelAct);
            this.Controls.Add(this.rndCreation);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CRUD_Sucursales";
            this.Size = new System.Drawing.Size(962, 707);
            this.Load += new System.EventHandler(this.CRUD_Sucursales_Load);
            this.rndCreation.ResumeLayout(false);
            this.rndCreation.PerformLayout();
            this.rndPanelAct.ResumeLayout(false);
            this.rndPanelAct.PerformLayout();
            this.rndDel.ResumeLayout(false);
            this.rndDel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Elementos.textbox txtBoxRegName;
        private Elementos.Botón btnRegistrarSucursales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Elementos.textbox txtRegDomicilio;
        private System.Windows.Forms.Label label3;
        private Elementos.textbox txtRegCiudad;
        private System.Windows.Forms.Label label4;
        private Elementos.textbox txtRegEstado;
        private System.Windows.Forms.Label label5;
        private Elementos.textbox txtRegCp;
        private System.Windows.Forms.Label label6;
        private Elementos.textbox txtRegTelefono;
        private Elementos.RoundPanel rndCreation;
        private Elementos.RoundPanel rndPanelAct;
        private Elementos.textbox txtSucUpd;
        private Elementos.textbox txtAddressSucUpd;
        private Elementos.textbox txtTelSucUpd;
        private Elementos.textbox txtCitSucUpd;
        private Elementos.textbox txtCpSucUpd;
        private Elementos.textbox txtStaSucUpd;
        private Elementos.Botón btnActSucursales;
        private System.Windows.Forms.ComboBox cmbSucId1;
        private Elementos.RoundPanel rndDel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox cmbSucId2;
        private Elementos.Botón btnBorrarSucursales;
        private System.Windows.Forms.RadioButton rdCreate;
        private System.Windows.Forms.RadioButton rdAct;
        private System.Windows.Forms.RadioButton rdDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPermisos;
    }
}
