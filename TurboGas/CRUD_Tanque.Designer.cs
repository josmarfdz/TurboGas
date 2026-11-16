namespace TurboGas
{
    partial class CRUD_Tanque
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        private void Nav(System.Windows.Forms.Button b, string name, string text, int x, int w, int tab)
        {
            b.BackColor = System.Drawing.Color.FromArgb(225, 120, 59);
            b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b.FlatAppearance.BorderSize = 0;
            b.Font = new System.Drawing.Font("Poppins", 8.25F);
            b.ForeColor = System.Drawing.Color.White;
            b.Location = new System.Drawing.Point(x, 0);
            b.Name = name;
            b.Size = new System.Drawing.Size(w, 81);
            b.TabIndex = tab;
            b.Text = text;
            b.UseVisualStyleBackColor = false;
            b.Dock = System.Windows.Forms.DockStyle.None;
            b.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            b.Visible = true;
        }

        private System.Windows.Forms.Label Lbl(string text, int x, int y)
        {
            var l = new System.Windows.Forms.Label();
            l.AutoSize = true;
            l.Font = new System.Drawing.Font("Poppins", 8.25F);
            l.Location = new System.Drawing.Point(x, y);
            l.Text = text;
            l.BackColor = System.Drawing.Color.Transparent;
            l.ForeColor = System.Drawing.Color.Black;
            return l;
        }

        private void Btn(TurboGas.Elementos.Botón b, string name, string text, int x, int y)
        {
            b.BackColor = System.Drawing.Color.FromArgb(255, 120, 59);
            b.FlatAppearance.BorderSize = 0;
            b.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(250, 77, 0);
            b.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 165, 125);
            b.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            b.ForeColor = System.Drawing.Color.White;
            b.Location = new System.Drawing.Point(x, y);
            b.Name = name;
            b.Size = new System.Drawing.Size(170, 40);
            b.Text = text;
            b.UseVisualStyleBackColor = false;
            b.Dock = System.Windows.Forms.DockStyle.None;
            b.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            b.Visible = true;
        }

        private void Txt(TurboGas.Elementos.textbox t, string name, int y, int tab)
        {
            t.BackColor = System.Drawing.Color.White;
            t.Location = new System.Drawing.Point(190, y);
            t.Name = name;
            t.Padding = new System.Windows.Forms.Padding(10);
            t.Size = new System.Drawing.Size(200, 49);
            t.TabIndex = tab;
            t.Dock = System.Windows.Forms.DockStyle.None;
            t.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            t.Visible = true;
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNombreUser = new System.Windows.Forms.Label();
            this.lblSuc = new System.Windows.Forms.Label();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.dgvTanques = new System.Windows.Forms.DataGridView();
            this.pbNivel = new System.Windows.Forms.ProgressBar();
            this.lblNivel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnVendedores = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnTipos = new System.Windows.Forms.Button();
            this.btnTanques = new System.Windows.Forms.Button();
            this.btnIslas = new System.Windows.Forms.Button();
            this.btnSucursales = new System.Windows.Forms.Button();
            this.rdDelete = new System.Windows.Forms.RadioButton();
            this.rdCreate = new System.Windows.Forms.RadioButton();
            this.btnBack = new TurboGas.Elementos.Botón();
            this.rndForm = new TurboGas.Elementos.RoundPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtNombre = new TurboGas.Elementos.textbox();
            this.txtCapacidad = new TurboGas.Elementos.textbox();
            this.txtMin = new TurboGas.Elementos.textbox();
            this.txtMax = new TurboGas.Elementos.textbox();
            this.txtLitros = new TurboGas.Elementos.textbox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new TurboGas.Elementos.Botón();
            this.btnAbastecer = new TurboGas.Elementos.Botón();
            this.btnEliminar = new TurboGas.Elementos.Botón();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTanques)).BeginInit();
            this.panel2.SuspendLayout();
            this.rndForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.rdDelete);
            this.panel1.Controls.Add(this.lblNombreUser);
            this.panel1.Controls.Add(this.rdCreate);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 81);
            this.panel1.TabIndex = 0;
            // 
            // lblNombreUser
            // 
            this.lblNombreUser.AutoSize = true;
            this.lblNombreUser.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.lblNombreUser.Location = new System.Drawing.Point(678, 25);
            this.lblNombreUser.Name = "lblNombreUser";
            this.lblNombreUser.Size = new System.Drawing.Size(202, 30);
            this.lblNombreUser.TabIndex = 8;
            this.lblNombreUser.Text = ":nombre_del_usuario:";
            // 
            // lblSuc
            // 
            this.lblSuc.AutoSize = true;
            this.lblSuc.Font = new System.Drawing.Font("Poppins", 10.75F);
            this.lblSuc.Location = new System.Drawing.Point(430, 103);
            this.lblSuc.Name = "lblSuc";
            this.lblSuc.Size = new System.Drawing.Size(264, 39);
            this.lblSuc.TabIndex = 5;
            this.lblSuc.Text = "Sucursal seleccionada";
            // 
            // cmbSucursal
            // 
            this.cmbSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursal.FormattingEnabled = true;
            this.cmbSucursal.Location = new System.Drawing.Point(700, 105);
            this.cmbSucursal.Name = "cmbSucursal";
            this.cmbSucursal.Size = new System.Drawing.Size(190, 28);
            this.cmbSucursal.TabIndex = 2;
            // 
            // dgvTanques
            // 
            this.dgvTanques.AllowUserToAddRows = false;
            this.dgvTanques.AllowUserToDeleteRows = false;
            this.dgvTanques.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTanques.BackgroundColor = System.Drawing.Color.White;
            this.dgvTanques.ColumnHeadersHeight = 34;
            this.dgvTanques.Location = new System.Drawing.Point(430, 150);
            this.dgvTanques.MultiSelect = false;
            this.dgvTanques.Name = "dgvTanques";
            this.dgvTanques.ReadOnly = true;
            this.dgvTanques.RowHeadersVisible = false;
            this.dgvTanques.RowHeadersWidth = 62;
            this.dgvTanques.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTanques.Size = new System.Drawing.Size(460, 330);
            this.dgvTanques.TabIndex = 3;
            this.dgvTanques.SelectionChanged += new System.EventHandler(this.dgvTanques_SelectionChanged);
            // 
            // pbNivel
            // 
            this.pbNivel.Location = new System.Drawing.Point(430, 500);
            this.pbNivel.Name = "pbNivel";
            this.pbNivel.Size = new System.Drawing.Size(460, 24);
            this.pbNivel.TabIndex = 4;
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.lblNivel.Location = new System.Drawing.Point(430, 535);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(345, 30);
            this.lblNivel.TabIndex = 0;
            this.lblNivel.Text = "Selecciona un tanque para ver su nivel";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.btnVendedores);
            this.panel2.Controls.Add(this.btnUsers);
            this.panel2.Controls.Add(this.btnTipos);
            this.panel2.Controls.Add(this.btnTanques);
            this.panel2.Controls.Add(this.btnIslas);
            this.panel2.Controls.Add(this.btnSucursales);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 81);
            this.panel2.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.label8.Location = new System.Drawing.Point(678, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(202, 30);
            this.label8.TabIndex = 10;
            this.label8.Text = ":nombre_del_usuario:";
            // 
            // btnVendedores
            // 
            this.btnVendedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.btnVendedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendedores.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.btnVendedores.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVendedores.Location = new System.Drawing.Point(544, 0);
            this.btnVendedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVendedores.Name = "btnVendedores";
            this.btnVendedores.Size = new System.Drawing.Size(128, 81);
            this.btnVendedores.TabIndex = 5;
            this.btnVendedores.Text = "Vendedores";
            this.btnVendedores.UseVisualStyleBackColor = false;
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.btnUsers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUsers.Location = new System.Drawing.Point(415, 0);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(129, 81);
            this.btnUsers.TabIndex = 4;
            this.btnUsers.Text = "Usuarios";
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click_1);
            // 
            // btnTipos
            // 
            this.btnTipos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.btnTipos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTipos.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.btnTipos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTipos.Location = new System.Drawing.Point(225, 0);
            this.btnTipos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTipos.Name = "btnTipos";
            this.btnTipos.Size = new System.Drawing.Size(86, 81);
            this.btnTipos.TabIndex = 3;
            this.btnTipos.Text = "Tipos";
            this.btnTipos.UseVisualStyleBackColor = false;
            this.btnTipos.Click += new System.EventHandler(this.btnTipos_Click);
            // 
            // btnTanques
            // 
            this.btnTanques.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.btnTanques.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTanques.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.btnTanques.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTanques.Location = new System.Drawing.Point(310, 0);
            this.btnTanques.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTanques.Name = "btnTanques";
            this.btnTanques.Size = new System.Drawing.Size(105, 81);
            this.btnTanques.TabIndex = 2;
            this.btnTanques.Text = "Bombas";
            this.btnTanques.UseVisualStyleBackColor = false;
            this.btnTanques.Click += new System.EventHandler(this.btnTanques_Click_1);
            // 
            // btnIslas
            // 
            this.btnIslas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.btnIslas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIslas.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.btnIslas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIslas.Location = new System.Drawing.Point(120, 0);
            this.btnIslas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIslas.Name = "btnIslas";
            this.btnIslas.Size = new System.Drawing.Size(105, 81);
            this.btnIslas.TabIndex = 1;
            this.btnIslas.Text = "Islas";
            this.btnIslas.UseVisualStyleBackColor = false;
            this.btnIslas.Click += new System.EventHandler(this.btnIslas_Click_1);
            // 
            // btnSucursales
            // 
            this.btnSucursales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.btnSucursales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSucursales.Font = new System.Drawing.Font("Poppins", 8.25F);
            this.btnSucursales.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSucursales.Location = new System.Drawing.Point(0, 0);
            this.btnSucursales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSucursales.Name = "btnSucursales";
            this.btnSucursales.Size = new System.Drawing.Size(120, 81);
            this.btnSucursales.TabIndex = 0;
            this.btnSucursales.Text = "Sucursales";
            this.btnSucursales.UseVisualStyleBackColor = false;
            this.btnSucursales.Click += new System.EventHandler(this.btnSucursales_Click_1);
            // 
            // rdDelete
            // 
            this.rdDelete.AutoSize = true;
            this.rdDelete.Location = new System.Drawing.Point(611, 86);
            this.rdDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdDelete.Name = "rdDelete";
            this.rdDelete.Size = new System.Drawing.Size(91, 24);
            this.rdDelete.TabIndex = 23;
            this.rdDelete.TabStop = true;
            this.rdDelete.Text = "Borrado";
            this.rdDelete.UseVisualStyleBackColor = true;
            // 
            // rdCreate
            // 
            this.rdCreate.AutoSize = true;
            this.rdCreate.Location = new System.Drawing.Point(166, 84);
            this.rdCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdCreate.Name = "rdCreate";
            this.rdCreate.Size = new System.Drawing.Size(97, 24);
            this.rdCreate.TabIndex = 22;
            this.rdCreate.TabStop = true;
            this.rdCreate.Text = "Creacion";
            this.rdCreate.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(19, 90);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Visible = false;
            // 
            // rndForm
            // 
            this.rndForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rndForm.Controls.Add(this.label7);
            this.rndForm.Controls.Add(this.label6);
            this.rndForm.Controls.Add(this.label5);
            this.rndForm.Controls.Add(this.label4);
            this.rndForm.Controls.Add(this.label3);
            this.rndForm.Controls.Add(this.label2);
            this.rndForm.Controls.Add(this.label1);
            this.rndForm.Controls.Add(this.cmbTipo);
            this.rndForm.Controls.Add(this.txtNombre);
            this.rndForm.Controls.Add(this.txtCapacidad);
            this.rndForm.Controls.Add(this.txtMin);
            this.rndForm.Controls.Add(this.txtMax);
            this.rndForm.Controls.Add(this.txtLitros);
            this.rndForm.Controls.Add(this.cmbEstado);
            this.rndForm.Controls.Add(this.btnGuardar);
            this.rndForm.Controls.Add(this.btnAbastecer);
            this.rndForm.Controls.Add(this.btnEliminar);
            this.rndForm.Location = new System.Drawing.Point(10, 142);
            this.rndForm.Name = "rndForm";
            this.rndForm.Size = new System.Drawing.Size(400, 458);
            this.rndForm.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "LITROS ACTUALES";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cantidad maxima (L)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cantidad minima (L)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Capacidad (L)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre del tanque";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tipo de combustible";
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(186, 15);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(200, 28);
            this.cmbTipo.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(186, 59);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(10);
            this.txtNombre.Size = new System.Drawing.Size(200, 40);
            this.txtNombre.TabIndex = 1;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.BackColor = System.Drawing.Color.White;
            this.txtCapacidad.Location = new System.Drawing.Point(186, 115);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Padding = new System.Windows.Forms.Padding(10);
            this.txtCapacidad.Size = new System.Drawing.Size(200, 40);
            this.txtCapacidad.TabIndex = 2;
            // 
            // txtMin
            // 
            this.txtMin.BackColor = System.Drawing.Color.White;
            this.txtMin.Location = new System.Drawing.Point(186, 171);
            this.txtMin.Name = "txtMin";
            this.txtMin.Padding = new System.Windows.Forms.Padding(10);
            this.txtMin.Size = new System.Drawing.Size(200, 40);
            this.txtMin.TabIndex = 3;
            // 
            // txtMax
            // 
            this.txtMax.BackColor = System.Drawing.Color.White;
            this.txtMax.Location = new System.Drawing.Point(186, 226);
            this.txtMax.Name = "txtMax";
            this.txtMax.Padding = new System.Windows.Forms.Padding(10);
            this.txtMax.Size = new System.Drawing.Size(200, 40);
            this.txtMax.TabIndex = 4;
            // 
            // txtLitros
            // 
            this.txtLitros.BackColor = System.Drawing.Color.White;
            this.txtLitros.Location = new System.Drawing.Point(186, 334);
            this.txtLitros.Name = "txtLitros";
            this.txtLitros.Padding = new System.Windows.Forms.Padding(10);
            this.txtLitros.Size = new System.Drawing.Size(200, 40);
            this.txtLitros.TabIndex = 5;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Activa",
            "Inactiva",
            "En reparacion"});
            this.cmbEstado.Location = new System.Drawing.Point(186, 285);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(200, 28);
            this.cmbEstado.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGuardar.Location = new System.Drawing.Point(9, 403);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(111, 40);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Crear";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAbastecer
            // 
            this.btnAbastecer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.btnAbastecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbastecer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAbastecer.Location = new System.Drawing.Point(130, 403);
            this.btnAbastecer.Name = "btnAbastecer";
            this.btnAbastecer.Size = new System.Drawing.Size(123, 40);
            this.btnAbastecer.TabIndex = 9;
            this.btnAbastecer.Text = "Rellenar";
            this.btnAbastecer.UseVisualStyleBackColor = false;
            this.btnAbastecer.Click += new System.EventHandler(this.btnAbastecer_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(212)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEliminar.Location = new System.Drawing.Point(263, 403);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(126, 40);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Borrar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // CRUD_Tanque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblNivel);
            this.Controls.Add(this.pbNivel);
            this.Controls.Add(this.dgvTanques);
            this.Controls.Add(this.cmbSucursal);
            this.Controls.Add(this.lblSuc);
            this.Controls.Add(this.rndForm);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CRUD_Tanque";
            this.Size = new System.Drawing.Size(900, 625);
            this.Load += new System.EventHandler(this.CRUD_Tanque_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTanques)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.rndForm.ResumeLayout(false);
            this.rndForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombreUser;
        private Elementos.Botón btnBack;
        private Elementos.RoundPanel rndForm;
        private System.Windows.Forms.ComboBox cmbTipo;
        private Elementos.textbox txtNombre;
        private Elementos.textbox txtCapacidad;
        private Elementos.textbox txtMin;
        private Elementos.textbox txtMax;
        private Elementos.textbox txtLitros;
        private System.Windows.Forms.ComboBox cmbEstado;
        private Elementos.Botón btnGuardar;
        private Elementos.Botón btnAbastecer;
        private Elementos.Botón btnEliminar;
        private System.Windows.Forms.Label lblSuc;
        private System.Windows.Forms.ComboBox cmbSucursal;
        private System.Windows.Forms.DataGridView dgvTanques;
        private System.Windows.Forms.ProgressBar pbNivel;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnVendedores;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnTipos;
        private System.Windows.Forms.Button btnTanques;
        private System.Windows.Forms.Button btnIslas;
        private System.Windows.Forms.Button btnSucursales;
        private System.Windows.Forms.RadioButton rdDelete;
        private System.Windows.Forms.RadioButton rdCreate;
    }
}