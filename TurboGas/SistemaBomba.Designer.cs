namespace TurboGas
{
    partial class SistemaBomba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SistemaBomba));
            this.roundPanel1 = new TurboGas.Elementos.RoundPanel();
            this.rbDiesel = new System.Windows.Forms.RadioButton();
            this.rbPremium = new System.Windows.Forms.RadioButton();
            this.rbRegular = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.roundPanel2 = new TurboGas.Elementos.RoundPanel();
            this.rbVales = new System.Windows.Forms.RadioButton();
            this.rbTarjeta = new System.Windows.Forms.RadioButton();
            this.rbEfectivo = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.roundPanel3 = new TurboGas.Elementos.RoundPanel();
            this.rbPrecio = new System.Windows.Forms.RadioButton();
            this.rbLitros = new System.Windows.Forms.RadioButton();
            this.tbCantidad = new TurboGas.Elementos.textbox();
            this.label4 = new System.Windows.Forms.Label();
            this.roundPanel4 = new TurboGas.Elementos.RoundPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.roundPanel5 = new TurboGas.Elementos.RoundPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTransacción = new TurboGas.Elementos.Botón();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBomba = new System.Windows.Forms.Label();
            this.roundPanel6 = new TurboGas.Elementos.RoundPanel();
            this.tbCorreo = new TurboGas.Elementos.textbox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBack = new TurboGas.Elementos.Botón();
            this.btConfiguración = new TurboGas.Elementos.Botón();
            this.ucCRUDTanques = new TurboGas.CRUD_Tanque();
            this.roundPanel1.SuspendLayout();
            this.roundPanel2.SuspendLayout();
            this.roundPanel3.SuspendLayout();
            this.roundPanel4.SuspendLayout();
            this.roundPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.roundPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // roundPanel1
            // 
            this.roundPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.roundPanel1.Controls.Add(this.rbDiesel);
            this.roundPanel1.Controls.Add(this.rbPremium);
            this.roundPanel1.Controls.Add(this.rbRegular);
            this.roundPanel1.Controls.Add(this.label1);
            this.roundPanel1.Location = new System.Drawing.Point(61, 78);
            this.roundPanel1.Name = "roundPanel1";
            this.roundPanel1.Size = new System.Drawing.Size(154, 203);
            this.roundPanel1.TabIndex = 0;
            // 
            // rbDiesel
            // 
            this.rbDiesel.AutoSize = true;
            this.rbDiesel.Font = new System.Drawing.Font("Poppins SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.rbDiesel.Location = new System.Drawing.Point(21, 151);
            this.rbDiesel.Name = "rbDiesel";
            this.rbDiesel.Size = new System.Drawing.Size(77, 29);
            this.rbDiesel.TabIndex = 2;
            this.rbDiesel.TabStop = true;
            this.rbDiesel.Text = "Diésel";
            this.rbDiesel.UseVisualStyleBackColor = true;
            // 
            // rbPremium
            // 
            this.rbPremium.AutoSize = true;
            this.rbPremium.Font = new System.Drawing.Font("Poppins SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.rbPremium.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.rbPremium.Location = new System.Drawing.Point(21, 103);
            this.rbPremium.Name = "rbPremium";
            this.rbPremium.Size = new System.Drawing.Size(100, 29);
            this.rbPremium.TabIndex = 1;
            this.rbPremium.TabStop = true;
            this.rbPremium.Text = "Premium";
            this.rbPremium.UseVisualStyleBackColor = true;
            // 
            // rbRegular
            // 
            this.rbRegular.AutoSize = true;
            this.rbRegular.Font = new System.Drawing.Font("Poppins SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.rbRegular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.rbRegular.Location = new System.Drawing.Point(21, 51);
            this.rbRegular.Name = "rbRegular";
            this.rbRegular.Size = new System.Drawing.Size(88, 29);
            this.rbRegular.TabIndex = 1;
            this.rbRegular.TabStop = true;
            this.rbRegular.Text = "Regular";
            this.rbRegular.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(179, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "$31.59";
            // 
            // roundPanel2
            // 
            this.roundPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.roundPanel2.Controls.Add(this.rbVales);
            this.roundPanel2.Controls.Add(this.rbTarjeta);
            this.roundPanel2.Controls.Add(this.rbEfectivo);
            this.roundPanel2.Controls.Add(this.label3);
            this.roundPanel2.Location = new System.Drawing.Point(238, 78);
            this.roundPanel2.Name = "roundPanel2";
            this.roundPanel2.Size = new System.Drawing.Size(186, 203);
            this.roundPanel2.TabIndex = 3;
            // 
            // rbVales
            // 
            this.rbVales.AutoSize = true;
            this.rbVales.Font = new System.Drawing.Font("Poppins SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.rbVales.Location = new System.Drawing.Point(21, 151);
            this.rbVales.Name = "rbVales";
            this.rbVales.Size = new System.Drawing.Size(73, 29);
            this.rbVales.TabIndex = 2;
            this.rbVales.TabStop = true;
            this.rbVales.Text = "Vales";
            this.rbVales.UseVisualStyleBackColor = true;
            // 
            // rbTarjeta
            // 
            this.rbTarjeta.AutoSize = true;
            this.rbTarjeta.Font = new System.Drawing.Font("Poppins SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.rbTarjeta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.rbTarjeta.Location = new System.Drawing.Point(21, 103);
            this.rbTarjeta.Name = "rbTarjeta";
            this.rbTarjeta.Size = new System.Drawing.Size(83, 29);
            this.rbTarjeta.TabIndex = 1;
            this.rbTarjeta.TabStop = true;
            this.rbTarjeta.Text = "Tarjeta";
            this.rbTarjeta.UseVisualStyleBackColor = true;
            // 
            // rbEfectivo
            // 
            this.rbEfectivo.AutoSize = true;
            this.rbEfectivo.Font = new System.Drawing.Font("Poppins SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.rbEfectivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.rbEfectivo.Location = new System.Drawing.Point(21, 51);
            this.rbEfectivo.Name = "rbEfectivo";
            this.rbEfectivo.Size = new System.Drawing.Size(88, 29);
            this.rbEfectivo.TabIndex = 1;
            this.rbEfectivo.TabStop = true;
            this.rbEfectivo.Text = "Efectivo";
            this.rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(0, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Método de pago";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundPanel3
            // 
            this.roundPanel3.BackColor = System.Drawing.SystemColors.Control;
            this.roundPanel3.Controls.Add(this.rbPrecio);
            this.roundPanel3.Controls.Add(this.rbLitros);
            this.roundPanel3.Controls.Add(this.tbCantidad);
            this.roundPanel3.Controls.Add(this.label4);
            this.roundPanel3.Location = new System.Drawing.Point(454, 78);
            this.roundPanel3.Name = "roundPanel3";
            this.roundPanel3.Size = new System.Drawing.Size(271, 104);
            this.roundPanel3.TabIndex = 3;
            // 
            // rbPrecio
            // 
            this.rbPrecio.AutoSize = true;
            this.rbPrecio.Font = new System.Drawing.Font("Poppins SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.rbPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.rbPrecio.Location = new System.Drawing.Point(173, 68);
            this.rbPrecio.Name = "rbPrecio";
            this.rbPrecio.Size = new System.Drawing.Size(78, 29);
            this.rbPrecio.TabIndex = 3;
            this.rbPrecio.TabStop = true;
            this.rbPrecio.Text = "Precio";
            this.rbPrecio.UseVisualStyleBackColor = true;
            // 
            // rbLitros
            // 
            this.rbLitros.AutoSize = true;
            this.rbLitros.Font = new System.Drawing.Font("Poppins SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.rbLitros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.rbLitros.Location = new System.Drawing.Point(173, 35);
            this.rbLitros.Name = "rbLitros";
            this.rbLitros.Size = new System.Drawing.Size(71, 29);
            this.rbLitros.TabIndex = 4;
            this.rbLitros.TabStop = true;
            this.rbLitros.Text = "Litros";
            this.rbLitros.UseVisualStyleBackColor = true;
            // 
            // tbCantidad
            // 
            this.tbCantidad.BackColor = System.Drawing.Color.White;
            this.tbCantidad.Location = new System.Drawing.Point(24, 47);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Padding = new System.Windows.Forms.Padding(10);
            this.tbCantidad.Size = new System.Drawing.Size(143, 40);
            this.tbCantidad.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(0, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cantidad";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundPanel4
            // 
            this.roundPanel4.BackColor = System.Drawing.SystemColors.Control;
            this.roundPanel4.Controls.Add(this.label7);
            this.roundPanel4.Controls.Add(this.label6);
            this.roundPanel4.Controls.Add(this.label5);
            this.roundPanel4.Controls.Add(this.label2);
            this.roundPanel4.Location = new System.Drawing.Point(454, 199);
            this.roundPanel4.Name = "roundPanel4";
            this.roundPanel4.Size = new System.Drawing.Size(271, 82);
            this.roundPanel4.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.label7.Location = new System.Drawing.Point(108, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "$27.54";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins SemiBold", 8F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.label6.Location = new System.Drawing.Point(37, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "$23.89";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(0, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Precios ($/L)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // roundPanel5
            // 
            this.roundPanel5.BackColor = System.Drawing.SystemColors.Control;
            this.roundPanel5.Controls.Add(this.dataGridView1);
            this.roundPanel5.Controls.Add(this.label8);
            this.roundPanel5.Location = new System.Drawing.Point(61, 294);
            this.roundPanel5.Name = "roundPanel5";
            this.roundPanel5.Size = new System.Drawing.Size(664, 103);
            this.roundPanel5.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(623, 54);
            this.dataGridView1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(16, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(255, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "Historial de transacciones";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTransacción
            // 
            this.btnTransacción.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.btnTransacción.FlatAppearance.BorderSize = 0;
            this.btnTransacción.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.btnTransacción.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(125)))));
            this.btnTransacción.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransacción.Font = new System.Drawing.Font("Poppins SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransacción.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnTransacción.Location = new System.Drawing.Point(61, 471);
            this.btnTransacción.Name = "btnTransacción";
            this.btnTransacción.Size = new System.Drawing.Size(664, 40);
            this.btnTransacción.TabIndex = 6;
            this.btnTransacción.Text = "Realizar transacción";
            this.btnTransacción.UseVisualStyleBackColor = false;
            this.btnTransacción.Click += new System.EventHandler(this.btnTransacción_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.panel1.Controls.Add(this.btConfiguración);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.lblBomba);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 59);
            this.panel1.TabIndex = 7;
            // 
            // lblBomba
            // 
            this.lblBomba.AutoSize = true;
            this.lblBomba.Font = new System.Drawing.Font("Poppins SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBomba.Location = new System.Drawing.Point(614, 17);
            this.lblBomba.Name = "lblBomba";
            this.lblBomba.Size = new System.Drawing.Size(111, 30);
            this.lblBomba.TabIndex = 0;
            this.lblBomba.Text = "Bomba ##";
            // 
            // roundPanel6
            // 
            this.roundPanel6.BackColor = System.Drawing.SystemColors.Control;
            this.roundPanel6.Controls.Add(this.tbCorreo);
            this.roundPanel6.Controls.Add(this.label9);
            this.roundPanel6.Location = new System.Drawing.Point(61, 409);
            this.roundPanel6.Name = "roundPanel6";
            this.roundPanel6.Size = new System.Drawing.Size(664, 46);
            this.roundPanel6.TabIndex = 5;
            // 
            // tbCorreo
            // 
            this.tbCorreo.BackColor = System.Drawing.Color.White;
            this.tbCorreo.Location = new System.Drawing.Point(269, 6);
            this.tbCorreo.Name = "tbCorreo";
            this.tbCorreo.Padding = new System.Windows.Forms.Padding(10);
            this.tbCorreo.Size = new System.Drawing.Size(368, 33);
            this.tbCorreo.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Poppins SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(16, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(255, 23);
            this.label9.TabIndex = 0;
            this.label9.Text = "Enviar recibo de compra a:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(125)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(59)))));
            this.btnBack.Location = new System.Drawing.Point(25, 6);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btConfiguración
            // 
            this.btConfiguración.BackColor = System.Drawing.Color.White;
            this.btConfiguración.FlatAppearance.BorderSize = 0;
            this.btConfiguración.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(77)))), ((int)(((byte)(0)))));
            this.btConfiguración.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(165)))), ((int)(((byte)(125)))));
            this.btConfiguración.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btConfiguración.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btConfiguración.Image = ((System.Drawing.Image)(resources.GetObject("btConfiguración.Image")));
            this.btConfiguración.Location = new System.Drawing.Point(82, 6);
            this.btConfiguración.Name = "btConfiguración";
            this.btConfiguración.Size = new System.Drawing.Size(40, 40);
            this.btConfiguración.TabIndex = 3;
            this.btConfiguración.UseVisualStyleBackColor = false;
            this.btConfiguración.Click += new System.EventHandler(this.btConfiguración_Click);
            // 
            // ucCRUDTanques
            // 
            this.ucCRUDTanques.BackColor = System.Drawing.Color.White;
            this.ucCRUDTanques.Location = new System.Drawing.Point(0, 0);
            this.ucCRUDTanques.Name = "ucCRUDTanques";
            this.ucCRUDTanques.Size = new System.Drawing.Size(800, 525);
            this.ucCRUDTanques.TabIndex = 8;
            // 
            // SistemaBomba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ucCRUDTanques);
            this.Controls.Add(this.roundPanel6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnTransacción);
            this.Controls.Add(this.roundPanel5);
            this.Controls.Add(this.roundPanel4);
            this.Controls.Add(this.roundPanel3);
            this.Controls.Add(this.roundPanel2);
            this.Controls.Add(this.roundPanel1);
            this.Name = "SistemaBomba";
            this.Size = new System.Drawing.Size(800, 525);
            this.roundPanel1.ResumeLayout(false);
            this.roundPanel1.PerformLayout();
            this.roundPanel2.ResumeLayout(false);
            this.roundPanel2.PerformLayout();
            this.roundPanel3.ResumeLayout(false);
            this.roundPanel3.PerformLayout();
            this.roundPanel4.ResumeLayout(false);
            this.roundPanel4.PerformLayout();
            this.roundPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.roundPanel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Elementos.RoundPanel roundPanel1;
        private System.Windows.Forms.RadioButton rbRegular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbDiesel;
        private System.Windows.Forms.RadioButton rbPremium;
        private Elementos.RoundPanel roundPanel2;
        private System.Windows.Forms.RadioButton rbVales;
        private System.Windows.Forms.RadioButton rbTarjeta;
        private System.Windows.Forms.RadioButton rbEfectivo;
        private System.Windows.Forms.Label label3;
        private Elementos.RoundPanel roundPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbPrecio;
        private System.Windows.Forms.RadioButton rbLitros;
        private Elementos.textbox tbCantidad;
        private Elementos.RoundPanel roundPanel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private Elementos.RoundPanel roundPanel5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Elementos.Botón btnTransacción;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBomba;
        private Elementos.RoundPanel roundPanel6;
        private Elementos.textbox tbCorreo;
        private System.Windows.Forms.Label label9;
        private Elementos.Botón btnBack;
        private Elementos.Botón btConfiguración;
        private CRUD_Tanque ucCRUDTanques;
    }
}
