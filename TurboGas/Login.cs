using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TurboGas
{
    public partial class Login : UserControl
    {
        static string bdd = "server=localhost;database=gasolinera2026;port=3306;Uid=root;pwd=SyecMed&c1000";
        public Login()
        {
            InitializeComponent();
            ucOTP.Hide();
            ucRegistro.Hide();
            ucSucursales.Hide();
        }

        private void linkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ucRegistro.Show();
        }

        private void linkFMP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ucOTP.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string mail = tbCorreo.Text;
            string contra = tbContraseña.Text;
            string hash = Encriptacion.EncriptacionSHA256(contra);

            Consulta(mail, hash);
        }

        private void Consulta(string usuario, string pass)
        {
            string consulta = "SELECT nombre FROM Visualizacion_Usuarios where correo = @Nombre AND CONTRASEÑA = @Contraseña";
            try
            {
                using (MySqlConnection con = new MySqlConnection(bdd))
                {
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand(consulta, con);
                    cmd.Parameters.AddWithValue("@Nombre", usuario);
                    cmd.Parameters.AddWithValue("@Contraseña", pass);


                    using (MySqlDataReader lectura = cmd.ExecuteReader())
                    {
                        if (lectura.HasRows == true)
                        {
                            lectura.Read();
                            Sesion.UserNombre = lectura["nombre"].ToString();
                            MessageBox.Show($"Bienvenido/a {Sesion.UserNombre}");

                            ucSucursales.Show();
                        }

                        else
                        {
                            MessageBox.Show($"Usuario o contraseña incorrecta");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static class Encriptacion
        {
            public static string EncriptacionSHA256(string con)
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(con);
                    byte[] hash = sha256.ComputeHash(bytes);

                    StringBuilder resultado = new StringBuilder();
                    foreach (byte b in hash)
                    {
                        resultado.Append(b.ToString("X2"));
                    }
                    return resultado.ToString();
                }
            }
        }
    }
}
