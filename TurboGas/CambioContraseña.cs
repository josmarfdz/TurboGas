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
using System.Security.Cryptography;

namespace TurboGas
{
    public partial class CambioContraseña : UserControl
    {
        static string bdd = "server=localhost;database=gasolinera2026;port=3306;Uid=root;pwd=SyecMed&c1000";

        public CambioContraseña()
        {
            InitializeComponent();
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrEmpty(tbNueva.Text) || string.IsNullOrEmpty(tbConfirmar.Text))
            {
                MessageBox.Show("Los campos no pueden estar vacíos", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tbNueva.Text != tbConfirmar.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden, revíselas e inténtelo de nuevo", "Advertencia",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Si coinciden, encriptar y actualizar
            UpdateContraseña(tbNueva.Text);
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

        private void UpdateContraseña(string nuevaContra)
        {
            try
            {
                string contraEncriptada = Encriptacion.EncriptacionSHA256(nuevaContra);

                string query = "UPDATE usuarios_sistem SET contraseña = @Contra WHERE correo = @Correo";

                using (MySqlConnection con = new MySqlConnection(bdd))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Contra", contraEncriptada);
                        cmd.Parameters.AddWithValue("@Correo", Cuenta.Correo); // <-- clase Cuenta

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Cambio de contraseña exitoso", "Éxito",
                                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el usuario", "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void botón1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}