using System;
using System.Configuration;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using BCrypt.Net;
using MySql.Data.MySqlClient;

namespace TurboGas
{
    public partial class SignIn : UserControl
    {
        public static class Conexion
        {
            public static string Cadena
            {
                get
                {
                    return ConfigurationManager.ConnectionStrings["TurboGasDB"].ConnectionString ?? string.Empty;
                }
            }

            public static MySqlConnection Obtener()
            {
                return new MySqlConnection(Cadena);
            }
        }

        private static string bdd
        {
            get { return Conexion.Cadena; }
        }

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
            // ── 1) Checkboxes: cada fallo corta el flujo ────────────────────
            if (!cbPriv.Checked && !cbTyC.Checked)
            {
                MessageBox.Show("Lea y acepte el aviso de privacidad y los términos y condiciones",
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!cbTyC.Checked)
            {
                MessageBox.Show("Lea y acepte los términos y condiciones",
                    "Términos y condiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!cbPriv.Checked)
            {
                MessageBox.Show("Lea y acepte el aviso de privacidad",
                    "Aviso de privacidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // ── 2) Leer campos (sin Trim en password) ───────────────────────
            string nombre = textbox1.Text.Trim();
            string apellidoP = textbox2.Text.Trim();
            string apellidoM = textbox3.Text.Trim();
            string email = tbCorreo.Text.Trim();
            string celular = tbTeléfono.Text.Trim();
            string password = tbContraseñas.Text;   // sin Trim
            string confirm = tbConfirmar.Text;

            // ── 3) Validaciones de contenido ────────────────────────────────
            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(email) ||
                email == "example@mail.com" ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Por favor llena todos los campos",
                    "Llenar campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("La confirmación de la contraseña no coincide",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Encriptacion.CabeEnBcrypt(password))
            {
                MessageBox.Show("La contraseña es demasiado larga (máx. 72 bytes en UTF-8)",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ── 4) Hashear con bcrypt y guardar ─────────────────────────────
            string passHash = Encriptacion.Encriptar(password);
            string name = (nombre + " " + apellidoP + " " + apellidoM).Trim();

            if (InsertarNuevosUsers(name, email, passHash, celular))
            {
                MessageBox.Show("Nuevo usuario registrado",
                    "Se ha registrado correctamente su usuario",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // ✅ UNA SOLA versión del método — devuelve bool
        public static bool InsertarNuevosUsers(string us, string correo, string pass, string tel)
        {
            const string query = @"
                INSERT INTO usuarios_sistem (nombre, correo, contraseña, telefono)
                VALUES (@nombre, @correo, @pass, @tel)";

            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, cnc))
                    {
                        cmd.Parameters.AddWithValue("@nombre", us);
                        cmd.Parameters.AddWithValue("@correo", correo);
                        cmd.Parameters.AddWithValue("@pass", pass);
                        cmd.Parameters.AddWithValue("@tel", tel);
                        cmd.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                {
                    MessageBox.Show("Ese correo ya está registrado",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                MessageBox.Show("Error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }

    // ════════════════════════════════════════════════════════════════════════
    //  Encriptacion: clase compartida (top-level en TurboGas), sin anidar.
    //  Compatible con C# 7.3 / .NET Framework 4.x:
    //   - Sin `using var`
    //   - Sin `Convert.ToHexString`
    // ════════════════════════════════════════════════════════════════════════
    public static class Encriptacion
    {
        private const int WorkFactor = 12;

        private static readonly Regex LegacyHashRegex =
            new Regex("^[a-f0-9]{64}$", RegexOptions.IgnoreCase | RegexOptions.Compiled);

        // ── Helpers ────────────────────────────────────────────────────────
        private static string ToHexLower(byte[] bytes)
        {
            StringBuilder sb = new StringBuilder(bytes.Length * 2);
            for (int i = 0; i < bytes.Length; i++)
            {
                sb.Append(bytes[i].ToString("x2"));
            }
            return sb.ToString();
        }

        // ── bcrypt ─────────────────────────────────────────────────────────
        public static string Encriptar(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password, WorkFactor);
        }

        public static bool Verificar(string password, string hashAlmacenado)
        {
            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(hashAlmacenado))
                return false;
            try
            {
                return BCrypt.Net.BCrypt.Verify(password, hashAlmacenado);
            }
            catch (SaltParseException)
            {
                return false;
            }
        }

        public static bool CabeEnBcrypt(string password)
        {
            return Encoding.UTF8.GetByteCount(password) <= 72;
        }

        // ── SHA-256 hex minúsculas (legacy + refresh tokens) ────────────────
        public static string Sha256Hex(string texto)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(texto));
                return ToHexLower(bytes);
            }
        }

        public static bool EsHashLegacy(string hash)
        {
            return !string.IsNullOrEmpty(hash) && LegacyHashRegex.IsMatch(hash);
        }

        // ── Refresh token (32 bytes → 64 hex) ───────────────────────────────
        public static string GenerarRefreshToken()
        {
            byte[] bytes = new byte[32];
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(bytes);
            }
            return ToHexLower(bytes);
        }
    }
}