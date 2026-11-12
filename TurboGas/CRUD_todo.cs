using System;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using static ClosedXML.Excel.XLPredefinedFormat;

namespace TurboGas
{

    public partial class CRUD_todo : UserControl
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

        public CRUD_todo()
        {
            InitializeComponent();
            LlenarComboBox();
        }

        private void LlenarComboBox()
        {
            string query = "SELECT id_type FROM tipos_combustible";
            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();
                    MySqlCommand cmd = new MySqlCommand(query, cnc);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    cmbAct.DataSource = null;
                    cmbAct.DataSource = dataTable;
                    cmbAct.DisplayMember = "id_type";
                    cmbAct.ValueMember = "id_type";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string name = txtActName.Text;
            string clave = txtClave.Text;
            string desc = txtDesc.Text;

            InsertarNuevosTipos(name, clave, desc);
        }

        public static void InsertarNuevosTipos(string nombre, string clave, string desc)
        {
            string query = "INSERT INTO tipos_combustible(nombre, clave, descripcion) VALUES(@nombre, @clave, @desc)";
            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();
                    MySqlCommand cmd = new MySqlCommand(query, cnc);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@clave", clave);
                    cmd.Parameters.AddWithValue("@desc", desc);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            MessageBox.Show("Tipo creado", "Tipo creado con exito");
        }

        private void btnAct_Click(object sender, EventArgs e)
        {
            string name = txtActName.Text;
            string clave = txtActClave.Text;
            string desc = txtActDesc.Text;
            ActualizarTipo(name, clave, desc);
        }

        public void ActualizarTipo(string name, string clave, string desc)
        {
            string query = "UPDATE tipos_combustible SET nombre = @name, clave = @clave, descripcion = @desc WHERE id_type = @Id_type";
            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();
                    MySqlCommand cmd = new MySqlCommand(query, cnc);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@clave", clave);
                    cmd.Parameters.AddWithValue("@desc", desc);

                    cmd.Parameters.AddWithValue("@Id_type", cmbAct.SelectedValue);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            MessageBox.Show("Tipo actualizado", "Tipo actualizado con exito");
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnIslas_Click(object sender, EventArgs e)
        {

        }

        private void btnTipos_Click(object sender, EventArgs e)
        {

        }

        private void btnTanques_Click(object sender, EventArgs e)
        {

        }

        private void btnUsers_Click(object sender, EventArgs e)
        {

        }

        private void btnVendedores_Click(object sender, EventArgs e)
        {

        }
    }
}
