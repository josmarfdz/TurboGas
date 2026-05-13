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
    public partial class CRUD_Usuarios : UserControl
    {
        static string bdd = "server=localhost;database=gasolinera2026;port=3306;Uid=root;pwd=SyecMed&c1000";
        public CRUD_Usuarios()
        {
            InitializeComponent();
            LlenarComboBoxRol();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void CRUD_Usuarios_Load(object sender, EventArgs e)
        {
            lblNombreUser.Text = Sesion.UserNombre;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedValue != null && comboBox1.SelectedValue is int id)
            {
                VisualizacionDeBDD(id);
            }
        }

        private void VisualizacionDeBDD(int idUser)
        {
            string query = "SELECT nombre, correo, telefono, rol FROM usuarios_sistem WHERE id_usuario = @IdUser";
            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();
                    MySqlCommand cmd = new MySqlCommand(query, cnc);
                    cmd.Parameters.AddWithValue("@IdUser", idUser);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblNombre.Text = reader["nombre"].ToString();
                            lblCorreo.Text = reader["correo"].ToString();
                            lblTel.Text = reader["telefono"].ToString();
                            lblRol.Text = reader["rol"].ToString();
                            
                        }
                    } // ← el reader se cierra aquí solo
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void LlenarComboBoxRol()
        {
            string query = "SELECT id_usuario FROM usuarios_sistem";

            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();
                    MySqlCommand cmd = new MySqlCommand(query, cnc);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    comboBox1.DataSource = null;
                    comboBox1.DataSource = dt;
                    comboBox1.DisplayMember = "id_usuario";
                    comboBox1.ValueMember = "id_usuario";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnURol_Click(object sender, EventArgs e)
        {
            string RolDeCanela = comboBox2.Text;
            UpdateRol(RolDeCanela);
        }

        private void UpdateRol(string Rol)
        {
            string query = "UPDATE usuarios_sistem SET rol = @Rol WHERE id_usuario = @Id_u";

            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();
                    MySqlCommand cmd = new MySqlCommand(query, cnc);
                    cmd.Parameters.AddWithValue("@Rol", Rol);
                    cmd.Parameters.AddWithValue("@Id_u", comboBox1.SelectedValue);
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }

            MessageBox.Show("Rol de usuario actualizado con exito");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Control contenedor = this.Parent;
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

        private void btnBombas_Click(object sender, EventArgs e)
        {
            Control contenedor = this.Parent;
            if (contenedor != null)
            {
                contenedor.Controls.Clear();
                CRUD_Bombas CRUDBom = new CRUD_Bombas();
                CRUDBom.Dock = DockStyle.Fill;
                contenedor.Controls.Add(CRUDBom);
            }
            else
            {
                MessageBox.Show("No se encontró contenedor padre.");
            }
        }

        private void btnIslas_Click(object sender, EventArgs e)
        {
            Control contenedor = this.Parent;
            if (contenedor != null)
            {
                contenedor.Controls.Clear();
                CRUD_Islas CRUDIsl = new CRUD_Islas();
                CRUDIsl.Dock = DockStyle.Fill;
                contenedor.Controls.Add(CRUDIsl);
            }
            else
            {
                MessageBox.Show("No se encontró contenedor padre.");
            }
        }
    }
}
