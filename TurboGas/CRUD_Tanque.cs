using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TurboGas
{
    public partial class CRUD_Tanque : UserControl
    {

        public static class Conexion
        {
            public static string Cadena => ConfigurationManager.ConnectionStrings["TurboGasDB"].ConnectionString;

            public static MySqlConnection Obtener()
            {
                return new MySqlConnection(Cadena);
            }
        }

        static string bdd = Conexion.Cadena;

        int? idSel = null;          // null = modo crear, valor = modo editar
        DataTable tiposTabla;       // catálogo de combustibles
        string tipoDisplay = "id_type";

        public CRUD_Tanque()
        {
            InitializeComponent();
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            cmbEstado.SelectedIndex = 0;
            CargarTipos();
            CargarSucursales();
            cmbSucursal.SelectedIndexChanged += cmbSucursal_SelectedIndexChanged;
            CargarTanques();
        }

        private void CRUD_Tanque_Load(object sender, EventArgs e)
        {
            lblNombreUser.Text = Sesion.UserNombre;

            // Si se abre desde SistemaBomba (botón de configuración): solo botón de regreso
            bool incrustado = this.Parent is SistemaBomba;
            btnBack.Visible = incrustado;
            btnSucursales.Visible = btnIslas.Visible = btnTipos.Visible =
                btnTanques.Visible = btnUsers.Visible = btnVendedores.Visible = !incrustado;
        }

        // ───────────── CARGA DE DATOS ─────────────

        private void CargarTipos()
        {
            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();
                    MySqlDataAdapter ad = new MySqlDataAdapter("SELECT * FROM tipos_combustible", cnc);
                    tiposTabla = new DataTable();
                    ad.Fill(tiposTabla);
                }

                // No sé cómo se llama la columna del nombre: busco una común o la primera que no sea el id
                string[] candidatas = { "nombre", "tipo", "descripcion", "name", "tipo_combustible", "combustible" };
                tipoDisplay = null;
                foreach (string c in candidatas)
                    if (tiposTabla.Columns.Contains(c)) { tipoDisplay = c; break; }
                if (tipoDisplay == null)
                    foreach (DataColumn col in tiposTabla.Columns)
                        if (col.ColumnName != "id_type") { tipoDisplay = col.ColumnName; break; }
                if (tipoDisplay == null) tipoDisplay = "id_type";

                cmbTipo.DataSource = tiposTabla;
                cmbTipo.DisplayMember = tipoDisplay;
                cmbTipo.ValueMember = "id_type";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tipos de combustible: " + ex.Message);
            }
        }

        private void CargarSucursales()
        {
            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();
                    MySqlDataAdapter ad = new MySqlDataAdapter("SELECT id_sucursal, nombre FROM sucursales", cnc);
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    cmbSucursal.DataSource = dt;
                    cmbSucursal.DisplayMember = "nombre";
                    cmbSucursal.ValueMember = "id_sucursal";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar sucursales: " + ex.Message);
            }
        }

        private int SucursalActual()
        {
            if (cmbSucursal.SelectedValue == null) return -1;
            return Convert.ToInt32(cmbSucursal.SelectedValue);
        }

        private string NombreTipo(object idTipo)
        {
            if (tiposTabla == null) return idTipo.ToString();
            DataRow[] r = tiposTabla.Select("id_type = " + Convert.ToInt32(idTipo));
            return r.Length > 0 ? Convert.ToString(r[0][tipoDisplay]) : idTipo.ToString();
        }

        private void CargarTanques()
        {
            int suc = SucursalActual();
            if (suc < 0) { dgvTanques.DataSource = null; return; }

            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();
                    MySqlCommand cmd = new MySqlCommand(
                        @"SELECT id_tanque, tipo_combustible_id, nombre, capacidad_litros,
                                 nivel_min, nivel_max, litros_actuales, activo
                          FROM tanques WHERE sucursal_id_sucursal = @suc", cnc);
                    cmd.Parameters.AddWithValue("@suc", suc);
                    DataTable dt = new DataTable();
                    new MySqlDataAdapter(cmd).Fill(dt);

                    dt.Columns.Add("Combustible", typeof(string));
                    dt.Columns.Add("Nivel %", typeof(string));
                    dt.Columns.Add("Estado", typeof(string));
                    foreach (DataRow r in dt.Rows)
                    {
                        r["Combustible"] = NombreTipo(r["tipo_combustible_id"]);
                        decimal cap = Convert.ToDecimal(r["capacidad_litros"]);
                        decimal lit = Convert.ToDecimal(r["litros_actuales"]);
                        r["Nivel %"] = cap > 0 ? Math.Round(lit * 100 / cap, 1) + " %" : "-";
                        r["Estado"] = (r["activo"] != DBNull.Value && Convert.ToInt32(r["activo"]) == 1) ? "Activo" : "Inactivo";
                    }

                    dgvTanques.DataSource = dt;
                    dgvTanques.Columns["id_tanque"].Visible = false;
                    dgvTanques.Columns["tipo_combustible_id"].Visible = false;
                    dgvTanques.Columns["activo"].Visible = false;
                    dgvTanques.Columns["nombre"].HeaderText = "Nombre";
                    dgvTanques.Columns["capacidad_litros"].HeaderText = "Capacidad";
                    dgvTanques.Columns["nivel_min"].HeaderText = "Mín";
                    dgvTanques.Columns["nivel_max"].HeaderText = "Máx";
                    dgvTanques.Columns["litros_actuales"].HeaderText = "Litros";

                    // Rojo si está en o debajo del nivel mínimo, gris si está inactivo
                    foreach (DataGridViewRow fila in dgvTanques.Rows)
                    {
                        decimal lit = Convert.ToDecimal(fila.Cells["litros_actuales"].Value);
                        decimal min = Convert.ToDecimal(fila.Cells["nivel_min"].Value);
                        bool activo = Convert.ToString(fila.Cells["Estado"].Value) == "Activo";
                        if (!activo) fila.DefaultCellStyle.BackColor = Color.LightGray;
                        else if (lit <= min) fila.DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                    dgvTanques.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar tanques: " + ex.Message);
            }
            LimpiarFormulario();
        }

        private void cmbSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarTanques();
        }

        // ───────────── SELECCIÓN EN LA TABLA ─────────────

        private void dgvTanques_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTanques.CurrentRow == null || !dgvTanques.CurrentRow.Selected) return;
            DataGridViewRow f = dgvTanques.CurrentRow;

            idSel = Convert.ToInt32(f.Cells["id_tanque"].Value);
            cmbTipo.SelectedValue = Convert.ToInt32(f.Cells["tipo_combustible_id"].Value);
            txtNombre.Text = Convert.ToString(f.Cells["nombre"].Value);
            txtCapacidad.Text = Convert.ToString(f.Cells["capacidad_litros"].Value);
            txtMin.Text = Convert.ToString(f.Cells["nivel_min"].Value);
            txtMax.Text = Convert.ToString(f.Cells["nivel_max"].Value);
            txtLitros.Text = Convert.ToString(f.Cells["litros_actuales"].Value);
            cmbEstado.SelectedIndex = Convert.ToString(f.Cells["Estado"].Value) == "Activo" ? 0 : 1;
            btnGuardar.Text = "Actualizar tanque";

            decimal cap = Convert.ToDecimal(f.Cells["capacidad_litros"].Value);
            decimal lit = Convert.ToDecimal(f.Cells["litros_actuales"].Value);
            int pct = cap > 0 ? (int)Math.Min(100, Math.Max(0, lit * 100 / cap)) : 0;
            pbNivel.Value = pct;
            lblNivel.Text = lit + " L de " + cap + " L (" + pct + " %)";
        }

        private void LimpiarFormulario()
        {
            idSel = null;
            txtNombre.Text = txtCapacidad.Text = txtMin.Text = txtMax.Text = "";
            txtLitros.Text = "0";
            if (cmbTipo.Items.Count > 0) cmbTipo.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;
            btnGuardar.Text = "Crear tanque";
            pbNivel.Value = 0;
            lblNivel.Text = "Selecciona un tanque para ver su nivel";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dgvTanques.ClearSelection();
            LimpiarFormulario();
        }

        // ───────────── CREATE / UPDATE ─────────────

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (SucursalActual() < 0 || cmbTipo.SelectedValue == null)
            {
                MessageBox.Show("Selecciona una sucursal y un tipo de combustible.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Escribe el nombre del tanque.");
                return;
            }

            decimal cap, min, max;
            int litros;
            if (!decimal.TryParse(txtCapacidad.Text, out cap) || !decimal.TryParse(txtMin.Text, out min) ||
                !decimal.TryParse(txtMax.Text, out max) || !int.TryParse(txtLitros.Text, out litros))
            {
                MessageBox.Show("Capacidad, niveles y litros deben ser números válidos (los litros actuales, enteros).");
                return;
            }
            if (cap <= 0 || min < 0 || max <= 0 || litros < 0)
            {
                MessageBox.Show("Los valores deben ser positivos (el nivel mínimo puede ser 0).");
                return;
            }
            if (min > max || max > cap)
            {
                MessageBox.Show("Debe cumplirse: nivel mínimo ≤ nivel máximo ≤ capacidad.");
                return;
            }
            if (litros > cap)
            {
                MessageBox.Show("Los litros actuales no pueden superar la capacidad del tanque.");
                return;
            }

            string query = idSel == null
                ? @"INSERT INTO tanques (sucursal_id_sucursal, tipo_combustible_id, nombre, capacidad_litros,
                                         nivel_min, nivel_max, activo, litros_actuales)
                    VALUES (@suc, @tipo, @nom, @cap, @min, @max, @act, @lit)"
                : @"UPDATE tanques SET tipo_combustible_id = @tipo, nombre = @nom, capacidad_litros = @cap,
                                       nivel_min = @min, nivel_max = @max, activo = @act, litros_actuales = @lit
                    WHERE id_tanque = @id";

            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();
                    MySqlCommand cmd = new MySqlCommand(query, cnc);
                    cmd.Parameters.AddWithValue("@suc", SucursalActual());
                    cmd.Parameters.AddWithValue("@tipo", Convert.ToInt32(cmbTipo.SelectedValue));
                    cmd.Parameters.AddWithValue("@nom", txtNombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@cap", cap);
                    cmd.Parameters.AddWithValue("@min", min);
                    cmd.Parameters.AddWithValue("@max", max);
                    cmd.Parameters.AddWithValue("@act", cmbEstado.SelectedIndex == 0 ? 1 : 0);
                    cmd.Parameters.AddWithValue("@lit", litros);
                    if (idSel != null) cmd.Parameters.AddWithValue("@id", idSel.Value);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show(idSel == null ? "Tanque creado." : "Tanque actualizado.");
                CargarTanques();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // ───────────── ABASTECER ─────────────

        private void btnAbastecer_Click(object sender, EventArgs e)
        {
            if (idSel == null)
            {
                MessageBox.Show("Selecciona un tanque de la tabla.");
                return;
            }

            string texto = PedirDato("Abastecer tanque", "Litros a agregar:");
            if (texto == null) return;

            int litros;
            if (!int.TryParse(texto, out litros) || litros <= 0)
            {
                MessageBox.Show("Ingresa un número entero mayor a 0.");
                return;
            }

            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();
                    MySqlCommand cmd = new MySqlCommand(
                        @"UPDATE tanques SET litros_actuales = litros_actuales + @l
                          WHERE id_tanque = @id AND litros_actuales + @l <= capacidad_litros", cnc);
                    cmd.Parameters.AddWithValue("@l", litros);
                    cmd.Parameters.AddWithValue("@id", idSel.Value);
                    int filas = cmd.ExecuteNonQuery();

                    if (filas == 0) MessageBox.Show("No se puede: superaría la capacidad del tanque.");
                    else MessageBox.Show("Se agregaron " + litros + " L.");
                }
                int idRecordar = idSel.Value;
                CargarTanques();
                foreach (DataGridViewRow f in dgvTanques.Rows)
                    if (Convert.ToInt32(f.Cells["id_tanque"].Value) == idRecordar) { f.Selected = true; dgvTanques.CurrentCell = f.Cells["nombre"]; break; }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private string PedirDato(string titulo, string mensaje)
        {
            using (Form f = new Form())
            {
                f.Text = titulo;
                f.FormBorderStyle = FormBorderStyle.FixedDialog;
                f.StartPosition = FormStartPosition.CenterParent;
                f.MaximizeBox = f.MinimizeBox = false;
                f.ClientSize = new Size(300, 120);

                Label l = new Label { Text = mensaje, Left = 15, Top = 15, AutoSize = true };
                TextBox t = new TextBox { Left = 15, Top = 45, Width = 270 };
                Button ok = new Button { Text = "Aceptar", Left = 120, Top = 80, DialogResult = DialogResult.OK };
                Button cancel = new Button { Text = "Cancelar", Left = 205, Top = 80, DialogResult = DialogResult.Cancel };
                f.Controls.AddRange(new Control[] { l, t, ok, cancel });
                f.AcceptButton = ok;
                f.CancelButton = cancel;

                return f.ShowDialog() == DialogResult.OK ? t.Text : null;
            }
        }

        // ───────────── DELETE ─────────────

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSel == null)
            {
                MessageBox.Show("Selecciona un tanque de la tabla.");
                return;
            }

            var confirm = MessageBox.Show("¿Seguro que deseas eliminar este tanque?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) return;

            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM tanques WHERE id_tanque = @id", cnc);
                    cmd.Parameters.AddWithValue("@id", idSel.Value);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Tanque eliminado correctamente.");
                CargarTanques();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar (si tiene registros ligados, mejor márcalo como Inactivo): " + ex.Message);
            }
        }

        // ───────────── NAVEGACIÓN ─────────────

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Ir(UserControl destino)
        {
            Control contenedor = this.Parent;
            if (contenedor != null)
            {
                contenedor.Controls.Clear();
                destino.Dock = DockStyle.Fill;
                contenedor.Controls.Add(destino);
            }
            else
            {
                MessageBox.Show("No se encontró contenedor padre.");
            }
        }

        private void btnSucursales_Click(object sender, EventArgs e) { Ir(new CRUD_Sucursales()); }
        private void btnIslas_Click(object sender, EventArgs e) { Ir(new CRUD_Islas()); }
        private void btnUsers_Click(object sender, EventArgs e) { Ir(new CRUD_Usuarios()); }

        private void btnTanques_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}