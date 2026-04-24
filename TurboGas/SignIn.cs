using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TurboGas
{
    public partial class SignIn : UserControl
    {
        static string bdd = "server=localhost;database=gasolinera2026;port=3306;Uid=root;pwd=SyecMed&c1000";
        public SignIn()
        {
            InitializeComponent();
            tbCorreo.Text = " example@mail.com";
            tbCorreo.ForeColor = Color.Gray;
            tbCorreo.Leave += SetPlaceholder;
            tbCorreo.Enter += RemovePlaceholder;
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (tbCorreo.Text == " example@mail.com")
            {
                tbCorreo.Text = "";
                tbCorreo.ForeColor = Color.Black;
            }
        }
        private void SetPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbCorreo.Text))
            {
                tbCorreo.Text = " example@mail.com";
                tbCorreo.ForeColor = Color.Gray;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (cbPriv.Checked && cbTyC.Checked)
            {
                MessageBox.Show("Registro completo", "Éxito");
                //FUNCIÓN DE REGISTRO
            }
            else if (cbPriv.Checked && cbTyC.Checked != true)
            {
                MessageBox.Show("Lea y acepte los términos y condiciones", "Términos y condiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cbPriv.Checked != true && cbTyC.Checked)
                MessageBox.Show("Lea y acepte el aviso de privacidad", "Aviso de privacidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Lea y acepte el aviso de privacidad y los términos y condiciones", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string nombre = textbox1.Text.Trim();
            string apellidoP = textbox2.Text.Trim();
            string apellidoM = textbox3.Text.Trim();
            string email = tbCorreo.Text.Trim();
            string password = tbContraseñas.Text.Trim();
            string confirm = tbConfirmar.Text.Trim();

            string passHash = Encriptacion.EncriptacionSHA256(password);

            if (string.IsNullOrEmpty(textbox1.Text) || string.IsNullOrEmpty(tbCorreo.Text) || string.IsNullOrEmpty(tbContraseñas.Text))
            {
                MessageBox.Show("Porfavor llena todos los campos", "Llenar campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("Las confirmacion de la contraseña no coincide", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name = $"{nombre} {apellidoP} {apellidoM}";

            InsertarNuevosUsers(name, email, passHash);
            MessageBox.Show("Nuevo usuario registrado", "Se ha registrado correctamente su usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public static void InsertarNuevosUsers(string us, string correo, string pass)
        {
            string query = "INSERT INTO usuarios_sistem(nombre, correo, contraseña) VALUES(@nombre, @correo, @contraseña)";

            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();
                    MySqlCommand cmd = new MySqlCommand(query, cnc);

                    cmd.Parameters.AddWithValue("@nombre", us);
                    cmd.Parameters.AddWithValue("@correo", correo);
                    cmd.Parameters.AddWithValue("@contraseña", pass);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
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
