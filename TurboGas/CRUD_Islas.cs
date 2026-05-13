using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TurboGas
{
    public partial class CRUD_Islas : UserControl
    {
        static string bdd = "server=localhost;database=gasolinera2026;port=3306;Uid=root;pwd=SyecMed&c1000";

        public CRUD_Islas()
        {
            InitializeComponent();
            LlenarComboBoxCreate();
            LlenarComboBoxSuc();

            cmbDSuc.SelectedIndexChanged += cmbSucursal_SelectedIndexChanged;
            cmbDIsla.SelectedIndexChanged += cmbIslaD_SelectedIndexChanged;
            cmbUIsla.SelectedIndexChanged += cmbIslaU_SelectedIndexChanged;
            cmbUSuc.SelectedIndexChanged += cmbUSucursal_SelectedIndexChanged;
        }

        // ──────────────── CREATE ────────────────

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int sucur = Convert.ToInt32(cmbCSucursal.SelectedValue);
            CrearIsla(sucur);
        }

        private void CrearIsla(int sucursal)
        {
            string query = "INSERT INTO Islas(sucursal_id_sucursal) VALUES(@sucursal)";
            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();
                    MySqlCommand cmd = new MySqlCommand(query, cnc);
                    cmd.Parameters.AddWithValue("@sucursal", sucursal);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
            MessageBox.Show("Isla creada", "Isla creada con éxito", MessageBoxButtons.OK);
        }

        private void LlenarComboBoxCreate()
        {
            string query = "SELECT id_sucursal, nombre FROM sucursales";
            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();
                    MySqlCommand cmd = new MySqlCommand(query, cnc);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    cmbCSucursal.DataSource = null;
                    cmbCSucursal.DataSource = dataTable;
                    cmbCSucursal.DisplayMember = "nombre";
                    cmbCSucursal.ValueMember = "id_sucursal";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // ──────────────── UPDATE ────────────────

        private void btnUpd_Click(object sender, EventArgs e)
        {
            if (cmbUIsla.SelectedValue == null)
            {
                MessageBox.Show("Selecciona una isla.");
                return;
            }

            int nuevaSucursal = Convert.ToInt32(cmbUSuc.SelectedValue);
            ActualizarIsla(nuevaSucursal);
        }

        private void ActualizarIsla(int nuevaSucursal)
        {
            string query = "UPDATE islas SET sucursal_id_sucursal = @Sucursal WHERE id_isla = @IdIsla";
            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();
                    MySqlCommand cmd = new MySqlCommand(query, cnc);
                    cmd.Parameters.AddWithValue("@Sucursal", nuevaSucursal);
                    cmd.Parameters.AddWithValue("@IdIsla", cmbUIsla.SelectedValue);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Isla actualizada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LlenarComboBoxUpdateIsla(int idSucursal)
        {
            string query = "SELECT id_isla FROM islas WHERE sucursal_id_sucursal = @id_suc";
            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();
                    MySqlCommand cmd = new MySqlCommand(query, cnc);
                    cmd.Parameters.AddWithValue("@id_suc", idSucursal);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    cmbUIsla.DataSource = null;
                    cmbUIsla.DataSource = dataTable;
                    cmbUIsla.DisplayMember = "id_isla";
                    cmbUIsla.ValueMember = "id_isla";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cmbIslaU_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Si necesitas cargar datos extra al seleccionar una isla en Update, hazlo aquí
        }

        // ──────────────── DELETE ────────────────

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbDIsla.SelectedValue == null)
            {
                MessageBox.Show("Selecciona una isla.");
                return;
            }

            var confirm = MessageBox.Show("¿Seguro que deseas eliminar esta isla?",
                                           "Confirmar", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                EliminarIsla();
            }
        }

        private void EliminarIsla()
        {
            string query = "DELETE FROM islas WHERE id_isla = @IdIsla";
            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();
                    MySqlCommand cmd = new MySqlCommand(query, cnc);
                    cmd.Parameters.AddWithValue("@IdIsla", cmbDIsla.SelectedValue);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Isla eliminada correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LlenarComboBombaDel(int idSucursal)
        {
            string query = "SELECT id_isla FROM islas WHERE sucursal_id_sucursal = @id_suc";
            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();
                    MySqlCommand cmd = new MySqlCommand(query, cnc);
                    cmd.Parameters.AddWithValue("@id_suc", idSucursal);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    cmbDIsla.DataSource = null;
                    cmbDIsla.DataSource = dataTable;
                    cmbDIsla.DisplayMember = "id_isla";
                    cmbDIsla.ValueMember = "id_isla";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cmbIslaD_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lógica extra al cambiar isla en Delete si se necesita
        }

        // ──────────────── SUCURSAL (filtro compartido) ────────────────

        private void LlenarComboBoxSuc()
        {
            string query = "SELECT id_sucursal, nombre FROM sucursales";
            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();
                    MySqlCommand cmd = new MySqlCommand(query, cnc);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    cmbDSuc.DataSource = null;
                    cmbDSuc.DataSource = dataTable;
                    cmbDSuc.DisplayMember = "nombre";
                    cmbDSuc.ValueMember = "id_sucursal";

                    // También llenar el combo de sucursal del Update
                    cmbUSuc.DataSource = null;
                    cmbUSuc.DataSource = dataTable.Copy();
                    cmbUSuc.DisplayMember = "nombre";
                    cmbUSuc.ValueMember = "id_sucursal";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void cmbUSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUSuc.SelectedValue != null && cmbUSuc.SelectedValue is int idSuc)
            {
                LlenarComboBoxUpdateIsla(idSuc);
            }
        }

        private void cmbSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDSuc.SelectedValue != null && cmbDSuc.SelectedValue is int idSuc)
            {
                LlenarComboBoxUpdateIsla(idSuc);
                LlenarComboBombaDel(idSuc);
            }
        }

        private void cmb(object sender, EventArgs e)
        {
            if (cmbDSuc.SelectedValue != null && cmbDSuc.SelectedValue is int idSuc)
            {
                LlenarComboBoxUpdateIsla(idSuc);
                LlenarComboBombaDel(idSuc);
            }
        }

        // ──────────────── NAVEGACIÓN ────────────────

        private void CRUD_Islas_Load(object sender, EventArgs e)
        {
            lblNombreUser.Text = Sesion.UserNombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Control contenedor = this.Parent;
            if (contenedor != null)
            {
                contenedor.Controls.Clear();
                CRUD_Sucursales CRUDSuc = new CRUD_Sucursales();
                CRUDSuc.Dock = DockStyle.Fill;
                contenedor.Controls.Add(CRUDSuc);
            }
            else
            {
                MessageBox.Show("No se encontró contenedor padre.");
            }
        }

        private void btnBombas_Click(object sender, EventArgs e)
        {
            Control contenedor = this.Parent;
            if (contenedor != null)
            {
                contenedor.Controls.Clear();
                CRUD_Bombas CRUDBomb = new CRUD_Bombas();
                CRUDBomb.Dock = DockStyle.Fill;
                contenedor.Controls.Add(CRUDBomb);
            }
            else
            {
                MessageBox.Show("No se encontró contenedor padre.");
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Control contenedor = this.Parent; // Funciona con cualquier tipo

            if (contenedor != null)
            {
                contenedor.Controls.Clear();
                CRUD_Usuarios CRUDUsr = new CRUD_Usuarios();
                CRUDUsr.Dock = DockStyle.Fill;
                contenedor.Controls.Add(CRUDUsr);
            }
            else
            {
                MessageBox.Show("No se encontró contenedor padre.");
            }
        }
    }
}