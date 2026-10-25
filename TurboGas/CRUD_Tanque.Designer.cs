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
            this.btnBack = new TurboGas.Elementos.Botón();
            this.lblNombreUser = new System.Windows.Forms.Label();
            this.btnVendedores = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnTanques = new System.Windows.Forms.Button();
            this.btnTipos = new System.Windows.Forms.Button();
            this.btnIslas = new System.Windows.Forms.Button();
            this.btnSucursales = new System.Windows.Forms.Button();
            this.rndForm = new TurboGas.Elementos.RoundPanel();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.txtNombre = new TurboGas.Elementos.textbox();
            this.txtCapacidad = new TurboGas.Elementos.textbox();
            this.txtMin = new TurboGas.Elementos.textbox();
            this.txtMax = new TurboGas.Elementos.textbox();
            this.txtLitros = new TurboGas.Elementos.textbox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new TurboGas.Elementos.Botón();
            this.btnNuevo = new TurboGas.Elementos.Botón();
            this.btnAbastecer = new TurboGas.Elementos.Botón();
            this.btnEliminar = new TurboGas.Elementos.Botón();
            this.lblSuc = new System.Windows.Forms.Label();
            this.cmbSucursal = new System.Windows.Forms.ComboBox();
            this.dgvTanques = new System.Windows.Forms.DataGridView();
            this.pbNivel = new System.Windows.Forms.ProgressBar();
            this.lblNivel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.rndForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTanques)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.lblNombreUser);
            this.panel1.Controls.Add(this.btnVendedores);
            this.panel1.Controls.Add(this.btnUsers);
            this.panel1.Controls.Add(this.btnTanques);
            this.panel1.Controls.Add(this.btnTipos);
            this.panel1.Controls.Add(this.btnIslas);
            this.panel1.Controls.Add(this.btnSucursales);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 81);
            this.panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(20, 20);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            // btnVendedores
            // 
            this.btnVendedores.Location = new System.Drawing.Point(135, 3);
            this.btnVendedores.Name = "btnVendedores";
            this.btnVendedores.Size = new System.Drawing.Size(75, 23);
            this.btnVendedores.TabIndex = 9;
            // 
            // btnUsers
            // 
            this.btnUsers.Location = new System.Drawing.Point(66, 27);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(75, 23);
            this.btnUsers.TabIndex = 10;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnTanques
            // 
            this.btnTanques.Location = new System.Drawing.Point(135, 29);
            this.btnTanques.Name = "btnTanques";
            this.btnTanques.Size = new System.Drawing.Size(75, 23);
            this.btnTanques.TabIndex = 11;
            this.btnTanques.Click += new System.EventHandler(this.btnTanques_Click);
            // 
            // btnTipos
            // 
            this.btnTipos.Location = new System.Drawing.Point(460, 20);
            this.btnTipos.Name = "btnTipos";
            this.btnTipos.Size = new System.Drawing.Size(75, 23);
            this.btnTipos.TabIndex = 12;
            // 
            // btnIslas
            // 
            this.btnIslas.Location = new System.Drawing.Point(66, 3);
            this.btnIslas.Name = "btnIslas";
            this.btnIslas.Size = new System.Drawing.Size(75, 23);
            this.btnIslas.TabIndex = 13;
            this.btnIslas.Click += new System.EventHandler(this.btnIslas_Click);
            // 
            // btnSucursales
            // 
            this.btnSucursales.Location = new System.Drawing.Point(541, 25);
            this.btnSucursales.Name = "btnSucursales";
            this.btnSucursales.Size = new System.Drawing.Size(75, 23);
            this.btnSucursales.TabIndex = 14;
            this.btnSucursales.Click += new System.EventHandler(this.btnSucursales_Click);
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
            this.rndForm.Location = new System.Drawing.Point(10, 100);
            this.rndForm.Name = "rndForm";
            this.rndForm.Size = new System.Drawing.Size(400, 500);
            this.rndForm.TabIndex = 1;
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(190, 14);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(200, 28);
            this.cmbTipo.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.White;
            this.txtNombre.Location = new System.Drawing.Point(190, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Padding = new System.Windows.Forms.Padding(10);
            this.txtNombre.Size = new System.Drawing.Size(200, 40);
            this.txtNombre.TabIndex = 1;
            // 
            // txtCapacidad
            // 
            this.txtCapacidad.BackColor = System.Drawing.Color.White;
            this.txtCapacidad.Location = new System.Drawing.Point(190, 114);
            this.txtCapacidad.Name = "txtCapacidad";
            this.txtCapacidad.Padding = new System.Windows.Forms.Padding(10);
            this.txtCapacidad.Size = new System.Drawing.Size(200, 40);
            this.txtCapacidad.TabIndex = 2;
            // 
            // txtMin
            // 
            this.txtMin.BackColor = System.Drawing.Color.White;
            this.txtMin.Location = new System.Drawing.Point(190, 170);
            this.txtMin.Name = "txtMin";
            this.txtMin.Padding = new System.Windows.Forms.Padding(10);
            this.txtMin.Size = new System.Drawing.Size(200, 40);
            this.txtMin.TabIndex = 3;
            // 
            // txtMax
            // 
            this.txtMax.BackColor = System.Drawing.Color.White;
            this.txtMax.Location = new System.Drawing.Point(190, 225);
            this.txtMax.Name = "txtMax";
            this.txtMax.Padding = new System.Windows.Forms.Padding(10);
            this.txtMax.Size = new System.Drawing.Size(200, 40);
            this.txtMax.TabIndex = 4;
            // 
            // txtLitros
            // 
            this.txtLitros.BackColor = System.Drawing.Color.White;
            this.txtLitros.Location = new System.Drawing.Point(190, 353);
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
            this.cmbEstado.Location = new System.Drawing.Point(190, 284);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(200, 28);
            this.cmbEstado.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGuardar.Location = new System.Drawing.Point(10, 435);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(111, 40);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Crear";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnNuevo.Location = new System.Drawing.Point(304, 38);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(150, 40);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Borrar";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnAbastecer
            // 
            this.btnAbastecer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.btnAbastecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbastecer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAbastecer.Location = new System.Drawing.Point(131, 435);
            this.btnAbastecer.Name = "btnAbastecer";
            this.btnAbastecer.Size = new System.Drawing.Size(123, 40);
            this.btnAbastecer.TabIndex = 9;
            this.btnAbastecer.Text = "Rellenar";
            this.btnAbastecer.UseVisualStyleBackColor = false;
            this.btnAbastecer.Click += new System.EventHandler(this.btnAbastecer_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEliminar.Location = new System.Drawing.Point(264, 435);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(126, 40);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Borrar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tipo de combustible";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre de la bomba";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Capacidad (L)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Cantidad minima (L)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cantidad maxima (L)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cantidad maxima (L)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "LITROS ACTUALES";
            // 
            // CRUD_Tanque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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
            this.rndForm.ResumeLayout(false);
            this.rndForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTanques)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNombreUser;
        private System.Windows.Forms.Button btnSucursales;
        private System.Windows.Forms.Button btnIslas;
        private System.Windows.Forms.Button btnTipos;
        private System.Windows.Forms.Button btnTanques;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnVendedores;
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
        private Elementos.Botón btnNuevo;
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
    }
}