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
    public partial class CRUD_Bombas : UserControl
    {
        static string bdd = "server=localhost;database=gasolinera2026;port=3306;Uid=root;pwd=SyecMed&c1000";

        public CRUD_Bombas()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string isla = cmbCIsla.Text;
            string NBomba = txtCNum.Text; 
        }

        private void CrearBomba(int isla, int numero)
        {
            string query = "INSERT INTO Bombas(isla_id, numero) VALUES(@Isla_id, @Numero)";

            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();
                    MySqlCommand cmd = new MySqlCommand(query, cnc);
                    cmd.Parameters.AddWithValue("@Isla_id", isla);
                    cmd.Parameters.AddWithValue("@Numero", numero);

                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            MessageBox.Show("Bomba creada", "Bomba creada con exito", MessageBoxButtons.OK);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void CRUD_Bombas_Load(object sender, EventArgs e)
        {
            lblNombreUser.Text = Sesion.UserNombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Control contenedor = this.Parent; // Funciona con cualquier tipo

            if (contenedor != null)
            {
                contenedor.Controls.Clear();
                CRUD_Islas CRUDIsl = new CRUD_Islas();
                CRUDIsl.Dock = DockStyle.Fill;
                contenedor.Controls.Add(CRUDIsl);
            }
            else
            {
                MessageBox.Show("No se encontró contenedor padre.");
            }
        }

        private void btnIslas_Click(object sender, EventArgs e)
        {
            Control contenedor = this.Parent; // Funciona con cualquier tipo

            if (contenedor != null)
            {
                contenedor.Controls.Clear();
                CRUD_Islas CRUDIsl = new CRUD_Islas();
                CRUDIsl.Dock = DockStyle.Fill;
                contenedor.Controls.Add(CRUDIsl);
            }
            else
            {
                MessageBox.Show("No se encontró contenedor padre.");
            }
        }
    }
}
