using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TurboGas
{
    public partial class Perfilcs : UserControl
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

        public Perfilcs()
        {
            InitializeComponent();
        }

        private void botón1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
        }

        private void Perfilcs_Load(object sender, EventArgs e)
        {
            string nombre_user = Sesion.UserNombre;
            Consulta_BDD();
        }

        private void Consulta_BDD()
        {
            string query = "SELECT id_usuario, nombre, correo, telefono FROM usuarios_sistem WHERE nombre = @nombre";

            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, cnc))
                    {
                        cmd.Parameters.AddWithValue("@nombre", Sesion.UserNombre);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblId.Text = reader["id_usuario"].ToString();
                                lblNombre.Text = reader["nombre"].ToString();
                                lblCorreo.Text = reader["correo"].ToString();
                                lblTeléfono.Text = reader["Telefono"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No se encontró el usuario.");
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
    }
}
