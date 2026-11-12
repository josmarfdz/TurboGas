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
                    cmbDel.DisplayMember = "id_type";
                    cmbDel.ValueMember = "id_type";
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

            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("Ingresa un precio válido.");
                return;
            }

            if (precio <= 0)
            {
                MessageBox.Show("El precio debe ser mayor a 0.");
                return;
            }

            InsertarNuevosTipos(name, clave, desc, precio);

            LlenarComboBox();
        }

        public static void InsertarNuevosTipos(string nombre, string clave, string desc, decimal precio)
        {
            string query = "INSERT INTO tipos_combustible(nombre, clave, descripcion, precio) VALUES(@nombre, @clave, @desc, @precio)";
            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();
                    MySqlCommand cmd = new MySqlCommand(query, cnc);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@clave", clave);
                    cmd.Parameters.AddWithValue("@desc", desc);
                    cmd.Parameters.AddWithValue("@precio", precio);

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
            if (!decimal.TryParse(txtPrecio.Text, out decimal precio))
            {
                MessageBox.Show("Ingresa un precio válido.");
                return;
            }

            if (precio <= 0)
            {
                MessageBox.Show("El precio debe ser mayor a 0.");
                return;
            }
            ActualizarTipo(name, clave, desc, precio);
        }

        public void ActualizarTipo(string name, string clave, string desc, decimal precio)
        {
            string query = "UPDATE tipos_combustible SET nombre = @name, clave = @clave, descripcion = @desc, precio = @precio WHERE id_type = @Id_type";
            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();
                    MySqlCommand cmd = new MySqlCommand(query, cnc);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@clave", clave);
                    cmd.Parameters.AddWithValue("@desc", desc);
                    cmd.Parameters.AddWithValue("@precio", precio);


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
            if(cmbAct.SelectedValue == null)
            {
                MessageBox.Show("Selecciona un tipo");
                return;
            }

            var confirm = MessageBox.Show("Seguro que quieres borrar este tipo de combustible?", "Confirmar", MessageBoxButtons.YesNo);

            if(confirm == DialogResult.Yes)
            {
                BorrarTipo();
            }
        }

        private void BorrarTipo()
        {
            string query = "DELETE FROM tipos_combustible WHERE id_type = @id_tipo";
            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();
                    MySqlCommand cmd = new MySqlCommand( query, cnc);
                    cmd.Parameters.AddWithValue("@id_tipo", cmbAct.SelectedValue);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tipo eliminada correctamente", "Tipo eliminada correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
