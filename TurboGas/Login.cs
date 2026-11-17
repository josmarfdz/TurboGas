using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BCrypt.Net;

namespace TurboGas
{
    public partial class Login : UserControl
    {

        public static class Conexion
        {
            public static string Cadena => ConfigurationManager.ConnectionStrings["TurboGasDB"].ConnectionString ?? string.Empty;

            public static MySqlConnection Obtener()
            {
                return new MySqlConnection(Cadena);
            }
        }

        static string bdd => Conexion.Cadena;

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

            Consulta(mail, contra);
        }

        private void Consulta(string correo, string pass)
        {
            string consulta = "SELECT nombre, CONTRASEÑA FROM usuarios_sistem WHERE correo = @Correo";
            try
            {
                using (MySqlConnection con = new MySqlConnection(bdd))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(consulta, con))
                    {
                        cmd.Parameters.AddWithValue("@Correo", correo);

                        using (MySqlDataReader lectura = cmd.ExecuteReader())
                        {
                            if (lectura.Read())
                            {
                                string hashAlmacenado = lectura["CONTRASEÑA"].ToString();

                                // ✅ Verificamos con bcrypt (compara el hash guardado contra la pass)
                                if (Encriptacion.Verificar(pass, hashAlmacenado))
                                {
                                    Sesion.UserNombre = lectura["nombre"].ToString();
                                    MessageBox.Show($"Bienvenido/a {Sesion.UserNombre}");
                                    ucSucursales.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Usuario o contraseña incorrecta");
                                }
                            }
                            else
                            {
                                // Mismo mensaje que arriba: no reveles si el correo existe o no
                                MessageBox.Show("Usuario o contraseña incorrecta");
                            }
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
            // Factor de coste. 11-12 es un buen balance hoy en día.
            // Cada +1 duplica el tiempo de hasheo.
            private const int WorkFactor = 12;

            /// <summary>
            /// Hashea una contraseña usando bcrypt (con salt aleatorio incorporado).
            /// El resultado es distinto cada vez que llamas a este método,
            /// incluso con la misma contraseña.
            /// </summary>
            public static string Encriptar(string password)
            {
                return BCrypt.Net.BCrypt.HashPassword(password, WorkFactor);
            }

            /// <summary>
            /// Verifica si una contraseña en texto plano corresponde al hash almacenado.
            /// ESTE es el método que debes usar para el login,
            /// NO compares strings con == porque los hashes son aleatorios.
            /// </summary>
            public static bool Verificar(string password, string hashAlmacenado)
            {
                if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(hashAlmacenado))
                    return false;

                try
                {
                    return BCrypt.Net.BCrypt.Verify(password, hashAlmacenado);
                }
                catch (BCrypt.Net.SaltParseException)
                {
                    // El hash almacenado no tiene formato bcrypt válido
                    // (por ejemplo, si todavía tienes hashes viejos SHA-256 en la BD).
                    return false;
                }
            }
        }

        private void ucSucursales_Load(object sender, EventArgs e)
        {

        }
    }
}
