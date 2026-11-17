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
    public partial class Sucursales : UserControl
    {
        public Sucursales()
        {
            InitializeComponent();
        }

        public static class Conexion
        {
            public static string Cadena => ConfigurationManager.ConnectionStrings["TurboGasDB"].ConnectionString ?? string.Empty;

            public static MySqlConnection Obtener()
            {
                return new MySqlConnection(Cadena);
            }
        }

        static string bdd => Conexion.Cadena;

        private void btOff_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void botón1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void botón2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void botón3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void botón4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            string rol = Sistema_de_Roles();
            if (rol == "administrador de base de datos" || rol == "administrador de programa")
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
            else
            {
                MessageBox.Show("NO tienes permisos para aceeder a esta seccion del programa");
            }
        }

        private string Sistema_de_Roles()
        {
            string query = "SELECT rol FROM usuarios_sistem WHERE nombre = @nombre";
            string rol = "";

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
                                rol = reader["rol"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No se encontro el usuario.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }

            return rol;
        }

        private void Sucursales_Load(object sender, EventArgs e)
        {
            Consulta_Sucursal();
        }

        private void Consulta_Sucursal()
        {
            string query = "SELECT nombre, direccion FROM sucursales";

            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, cnc))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblNombreSucursal.Text = reader["nombre"].ToString();
                                lblDirecciónSucursal.Text = reader["direccion"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No hay sucursales registradas.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
