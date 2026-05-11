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
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int sucur = Convert.ToInt16(cmbCreSucursal.SelectedValue);
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
                MessageBox.Show("Error" + ex.Message);
            }
            MessageBox.Show("Bomba creada", "Bomba creada con exito", MessageBoxButtons.OK);
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

                    cmbCreSucursal.DataSource = null;
                    cmbCreSucursal.DataSource = dataTable;
                    cmbCreSucursal.DisplayMember = "nombre";
                    cmbCreSucursal.ValueMember = "id_sucursal";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {

        }

        private void CRUD_Islas_Load(object sender, EventArgs e)
        {
            lblNombreUser.Text = Sesion.UserNombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Control contenedor = this.Parent; // Funciona con cualquier tipo

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
    }
}
