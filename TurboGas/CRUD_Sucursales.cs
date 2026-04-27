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
    public partial class CRUD_Sucursales : UserControl
    {
        static string bdd = "server=localhost;database=gasolinera2026;port=3306;Uid=root;pwd=SyecMed&c1000";
        public CRUD_Sucursales()
        {
            InitializeComponent();
        }

        private void VerificarPermiso()
        {
            if (lblLvlPermition.Text == "2")
            {

            }
        }

        private void btnRegistrarSucursales_Click(object sender, EventArgs e)
        {
            string name = txtBoxRegName.Text;
            string domicilio = txtRegDomicilio.Text;
            string city = txtRegCiudad.Text;
            string state = txtRegEstado.Text;
            string codepos = txtRegCp.Text;
            string tel = txtRegTelefono.Text;

            InsertarNuevasSucursales(name, domicilio, city, state, codepos, tel);
        }

        public static void InsertarNuevasSucursales(string nombre, string addres, string ciudad, string estado, string cp, string cel)
        {
            string query = "INSERT INTO sucursales(nombre, direccion, ciudad, estado, cp, telefono) VALUES(@nombre, @direccion, @ciudad, @estado, @cp, @telefono)";

            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();
                    MySqlCommand cmd = new MySqlCommand(query, cnc);

                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@direccion", addres);
                    cmd.Parameters.AddWithValue("@ciudad", ciudad);
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.Parameters.AddWithValue("@cp", cp);
                    cmd.Parameters.AddWithValue("@telefono", cel);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
    }
}
