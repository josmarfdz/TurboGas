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
    public partial class Islas : UserControl
    {
        public Islas()
        {
            InitializeComponent();
            ucSistemaB.Hide();
        }

        public static class Conexion
        {
            public static string Cadena => ConfigurationManager.ConnectionStrings["TurboGasDB"].ConnectionString;

            public static MySqlConnection Obtener()
            {
                return new MySqlConnection(Cadena);
            }
        }

        static string bdd = Conexion.Cadena;

        private void btConfiguración_Click(object sender, EventArgs e)
        {
            //ABRIR EL CRUD DE ISLAS
            string rol = Sistema_de_Roles();
            if (rol == "administrador de base de datos" || rol == "administrador de programa")
            {
                Control contenedor = this.Parent; // Funciona con cualquier tipo

                if (contenedor != null)
                {
                    contenedor.Controls.Clear();
                    CRUD_Islas islas = new CRUD_Islas();
                    islas.Dock = DockStyle.Fill;
                    contenedor.Controls.Add(islas);
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
            string rol ="";

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

        private void btPerfil_Click(object sender, EventArgs e)
        {
            Control contenedor = this.Parent; // Funciona con cualquier tipo

            if (contenedor != null)
            {
                contenedor.Controls.Clear();
                Perfilcs perfil = new Perfilcs();
                perfil.Dock = DockStyle.Fill;
                contenedor.Controls.Add(perfil);
            }
            else
            {
                MessageBox.Show("No se encontró contenedor padre.");
            }
        }

        private void Islas_Load(object sender, EventArgs e)
        {
            lblNombre.Text = Sesion.UserNombre;
        }

        private void btnBomba1_Click(object sender, EventArgs e)
        {
            ucSistemaB.Show();
            ucSistemaB.NumeroBomba = "Bomba #1";
        }

        private void btnBomba2_Click(object sender, EventArgs e)
        {
            ucSistemaB.Show();
            ucSistemaBomba.NumeroBomba = "Bomba #2";
        }

        private void btnBomba3_Click(object sender, EventArgs e)
        {
            ucSistemaB.Show();
            ucSistemaBomba.NumeroBomba = "Bomba #3";
        }

        private void btnBomba4_Click(object sender, EventArgs e)
        {
            ucSistemaB.Show();
            ucSistemaB.NumeroBomba = "Bomba #4";
        }

        private void btnInfo1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bomba 1\n=======================\nRegular: \nPremium: \nDíesel\n\nBomba 2\n=======================\nRegular: \nPremium: \nDíesel");
        }

        private void btnInfo2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bomba 3\n=======================\nRegular: \nPremium: \nDíesel\n\nBomba 4\n=======================\nRegular: \nPremium: \nDíesel");
        }

        private void ucSistemaB_Load(object sender, EventArgs e)
        {

        }
    }
}
