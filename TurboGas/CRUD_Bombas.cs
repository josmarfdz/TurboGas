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
using Mysqlx.Connection;

namespace TurboGas
{
    public partial class CRUD_Bombas : UserControl
    {
        static string bdd = "server=localhost;database=gasolinera2026;port=3306;Uid=root;pwd=SyecMed&c1000";

        public CRUD_Bombas()
        {
            InitializeComponent();
            LlenarComboBoxCreateBomba();
            LlenarComboBoxSuc();

            cmbSucursal.SelectedIndexChanged += cmbSucursal_SelectedIndexChanged;
            cmbUIsla.SelectedIndexChanged += cmbIslaU_SelectedIndexChanged;
            cmbDIsla.SelectedIndexChanged += cmbIslaD_SelectedIndexChanged;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int isla = Convert.ToInt32(cmbCIsla.Text);
            int NBomba = Convert.ToInt32(txtCNum.Text);

            CrearBomba(isla, NBomba);
        }

        private void CrearBomba(int isla, int numero)
        {
            string query = "INSERT INTO Bombas(isla_id, numero) VALUES(@Isla_id, @Numero)";

            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();
                    MySqlCommand cmd = new MySqlCommand(query, cnc);
                    cmd.Parameters.AddWithValue("@Isla_id", isla);
                    cmd.Parameters.AddWithValue("@Numero", numero);

                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            MessageBox.Show("Bomba creada", "Bomba creada con exito", MessageBoxButtons.OK);
        }

        private void LlenarComboBoxCreateBomba()
        {
            string query = "SELECT id_isla FROM islas";
            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, cnc)) // ← using agregado
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        cmbCIsla.DataSource = null;
                        cmbCIsla.DataSource = dataTable;
                        cmbCIsla.DisplayMember = "id_isla";
                        cmbCIsla.ValueMember = "id_isla";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cmbDBomba.SelectedValue == null)
            {
                MessageBox.Show("Selecciona una bomba.");
                return;
            }

            // Confirmación antes de borrar
            var confirm = MessageBox.Show("¿Seguro que deseas eliminar esta bomba?",
                                           "Confirmar", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                EliminarBomba();
            }
        }

        private void EliminarBomba()
        {
            string query = "DELETE FROM bombas WHERE id_bomba = @IdBomba";
            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();
                    MySqlCommand cmd = new MySqlCommand(query, cnc);
                    cmd.Parameters.AddWithValue("@IdBomba", cmbDBomba.SelectedValue);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bomba eliminada correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LlenarComboBombaDel(int idIsla)
        {
            string query = "SELECT id_bomba FROM bombas WHERE isla_id = @id_isla";
            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();
                    MySqlCommand cmd = new MySqlCommand(query, cnc);
                    cmd.Parameters.AddWithValue("@id_isla", idIsla);
                    MySqlDataAdapter adapatar = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    adapatar.Fill(dataTable);

                    cmbDBomba.DataSource = null;
                    cmbDBomba.DataSource = dataTable;
                    cmbDBomba.DisplayMember = "id_bomba";
                    cmbDBomba.ValueMember = "id_bomba";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void cmbIslaD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDIsla.SelectedValue != null && cmbDIsla.SelectedValue is int id_Isla)
            {
                LlenarComboBombaDel(id_Isla);
            }
        }

        private void CRUD_Bombas_Load(object sender, EventArgs e)
        {
            lblNombreUser.Text = Sesion.UserNombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Control contenedor = this.Parent; // Funciona con cualquier tipo

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

        private void btnIslas_Click(object sender, EventArgs e)
        {
            Control contenedor = this.Parent; // Funciona con cualquier tipo

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string bomb = cmbUBomba.Text;
            string isl = cmbUIsla.Text;
            string numero = txtUNum.Text;
            int activ = 0;


            // Activa
            //Inactiva
            //En reparacion

            if (cmbUAct.Text == "Activa")
            {
                activ = 1;
            }
            else if (cmbUAct.Text == "Inactiva")
            {
                activ = 0;
            }
            else if (cmbUAct.Text == "En reparacion")
            {
                activ = 2;
            }


            ActualizarBomba(numero, activ);

        }

        private void ActualizarBomba(string nume, int act)
        {
            string query = "UPDATE bombas SET numero = @Num, activa = @Act WHERE id_bomba = @IdBomba";
            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();
                    MySqlCommand cmd = new MySqlCommand(query, cnc);
                    cmd.Parameters.AddWithValue("@Num", nume);
                    cmd.Parameters.AddWithValue("@Act", act);
                    cmd.Parameters.AddWithValue("@IdBomba", cmbUBomba.SelectedValue);                    
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LlenarComboBoxUpdateBomba(int isla)
        {
            string query = "SELECT id_bomba FROM bombas WHERE isla_id = @id_isla";
            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();
                    MySqlCommand cmd = new MySqlCommand(query, cnc);
                    cmd.Parameters.AddWithValue("@id_isla", isla);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    cmbUBomba.DataSource = null;
                    cmbUBomba.DataSource = dataTable;
                    cmbUBomba.DisplayMember = "id_bomba";
                    cmbUBomba.ValueMember = "id_bomba";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void cmbIslaU_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbUIsla.SelectedValue != null && cmbUIsla.SelectedValue is int idIsla)
            {
                LlenarComboBoxUpdateBomba(idIsla);
            }
        }

        private void LlenarComboBoxSuc()
        {
            string query = "SELECT id_sucursal, nombre FROM sucursales";

            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();
                    MySqlCommand cmd = new MySqlCommand(query, cnc);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);
                    cmbSucursal.DataSource = null;
                    cmbSucursal.DataSource = dataTable;
                    cmbSucursal.DisplayMember = "nombre";
                    cmbSucursal.ValueMember = "id_sucursal";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void cmbSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSucursal.SelectedValue != null && cmbSucursal.SelectedValue is int IdSuc)
            {
                CargarDatosIslas(IdSuc);
            }
        }

        private void CargarDatosIslas(int id_Suc)
        {
            string query = "SELECT id_isla FROM islas WHERE sucursal_id_sucursal = @id_suc";
            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, cnc))
                    {
                        cmd.Parameters.AddWithValue("@id_suc", id_Suc);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);


                        // Cargar cmbUIsla (sección Update) — esto SÍ dispara SelectedIndexChanged
                        cmbUIsla.DataSource = null;
                        cmbUIsla.DataSource = new DataTable(); // reset
                        cmbUIsla.DataSource = dataTable.Copy();
                        cmbUIsla.DisplayMember = "id_isla";
                        cmbUIsla.ValueMember = "id_isla";

                        cmbDIsla.DataSource = null;
                        cmbDIsla.DataSource = new DataTable(); // reset
                        cmbDIsla.DataSource = dataTable.Copy();
                        cmbDIsla.DisplayMember = "id_isla";
                        cmbDIsla.ValueMember = "id_isla";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Control contenedor = this.Parent; // Funciona con cualquier tipo

            if (contenedor != null)
            {
                contenedor.Controls.Clear();
                CRUD_Usuarios CRUDUsr = new CRUD_Usuarios();
                CRUDUsr.Dock = DockStyle.Fill;
                contenedor.Controls.Add(CRUDUsr);
            }
            else
            {
                MessageBox.Show("No se encontró contenedor padre.");
            }
        }
    }
}
