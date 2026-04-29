using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using MySql.Data.MySqlClient;

namespace TurboGas
{
    public partial class CRUD_Sucursales : UserControl
    {
        static string bdd = "server=localhost;database=gasolinera2026;port=3306;Uid=root;pwd=SyecMed&c1000";
        public CRUD_Sucursales()
        {
            InitializeComponent();
            LlenarComboBoxAct();
            LlenarComboBoxDel();
            rdCreate.CheckedChanged += RdCreate_CheckedChanged;
            rdAct.CheckedChanged += RdAct_CheckedChanged;
            rdDelete.CheckedChanged += RdDel_CheckedChanged;
            cmbSucId1.SelectedIndexChanged += cmbSucId1_SelectedIndexChanged;

            rndCreation.Enabled = false;
            rndDel.Enabled = false;
            rndPanelAct.Enabled = false;

            VerificarPermiso();
        }


        private void VerificarPermiso()
        {
            if(lblPermisos.Text == "usuario")
            {
                rndPanelAct.Hide();
                rndDel.Hide();
            }
            else if (lblPermisos.Text == "Administrador del sistema")
            {
                rndDel.Hide();
            }
        }

        private void btnRegistrarSucursales_Click(object sender, EventArgs e)
        {
            string name = txtBoxRegName.Text;
            string domicilio = txtRegDomicilio.Text;
            string city = txtRegCiudad.Text;
            string state = txtRegEstado.Text;
            string codepos = txtRegCp.Text;
            string tel = txtRegTelefono.Text;

            InsertarNuevasSucursales(name, domicilio, city, state, codepos, tel);

            LlenarComboBoxAct();
            LlenarComboBoxDel();
            VaciarTxtBoxs();
        }

        public static void InsertarNuevasSucursales(string nombre, string addres, string ciudad, string estado, string cp, string cel)
        {
            string query = "INSERT INTO sucursales(nombre, direccion, ciudad, estado, cp, telefono) VALUES(@nombre, @direccion, @ciudad, @estado, @cp, @telefono)";

            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();
                    MySqlCommand cmd = new MySqlCommand(query, cnc);

                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@direccion", addres);
                    cmd.Parameters.AddWithValue("@ciudad", ciudad);
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.Parameters.AddWithValue("@cp", cp);
                    cmd.Parameters.AddWithValue("@telefono", cel);

                    cmd.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }

            MessageBox.Show("Sucursal Creada", "Sucursal creada con exito", MessageBoxButtons.OK);
        }

        private void LlenarComboBoxAct()
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

                    cmbSucId1.DataSource = null;
                    cmbSucId1.DataSource = dataTable;
                    cmbSucId1.DisplayMember = "nombre";
                    cmbSucId1.ValueMember = "id_sucursal";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void CargarDatosSucursal(int idSucursal)
        {
            string query = "SELECT nombre, direccion, ciudad, estado, cp, telefono FROM sucursales WHERE id_sucursal = @id_suc";

            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();
                    MySqlCommand cmd = new MySqlCommand(query, cnc);
                    cmd.Parameters.AddWithValue("@id_suc", idSucursal);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtSucUpd.Text = reader["nombre"].ToString();
                        txtAddressSucUpd.Text = reader["direccion"].ToString();
                        txtCitSucUpd.Text = reader["ciudad"].ToString();
                        txtStaSucUpd.Text = reader["estado"].ToString();
                        txtCpSucUpd.Text = reader["cp"].ToString();
                        txtTelSucUpd.Text = reader["telefono"].ToString();
                    }  
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cmbSucId1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbSucId1.SelectedValue != null && cmbSucId1.SelectedValue is int idSucursal)
            {
                CargarDatosSucursal(idSucursal);
            }
        }

        private void LlenarComboBoxDel()
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

                    cmbSucId2.DataSource = null;
                    cmbSucId2.DataSource = dataTable;
                    cmbSucId2.DisplayMember = "nombre";
                    cmbSucId2.ValueMember = "id_sucursal";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void RdCreate_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdCreate.Checked) return; // Solo actuar cuando se activa
            rndCreation.Enabled = true;
            rndDel.Enabled = false;
            rndPanelAct.Enabled = false;
        }

        private void RdAct_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdAct.Checked) return; // Solo actuar cuando se activa
            rndCreation.Enabled = false;
            rndPanelAct.Enabled = true;
            rndDel.Enabled = false;
        }

        private void RdDel_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdDelete.Checked) return; // Solo actuar cuando se activa
            rndCreation.Enabled = false;
            rndDel.Enabled = true;
            rndPanelAct.Enabled = false;
        }

        private void btnActSucursales_Click(object sender, EventArgs e)
        {
            string name = txtSucUpd.Text;
            string domi = txtAddressSucUpd.Text;
            string ciu = txtCitSucUpd.Text;
            string stat = txtStaSucUpd.Text;
            string postal = txtCpSucUpd.Text;
            string cel = txtTelSucUpd.Text;

            ActulizacionSucursal(name, domi, ciu, stat, postal, cel);
            VaciarTxtBoxs();
        }

        private void ActulizacionSucursal(string nombre, string addres, string ciudad, string estado, string cp, string cel)
        {
            string Upd = "UPDATE sucursales SET nombre = @Nombre, direccion = @Add, ciudad = @city, estado = @State, cp = @Cp, telefono = @Tel WHERE id_sucursal = @Id_Suc";

            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();
                    MySqlCommand cmd = new MySqlCommand(Upd,cnc);

                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Add", addres);
                    cmd.Parameters.AddWithValue("@City", ciudad);
                    cmd.Parameters.AddWithValue("@State", estado);
                    cmd.Parameters.AddWithValue("@Cp", cp);
                    cmd.Parameters.AddWithValue("@Tel", cel);

                    cmd.Parameters.AddWithValue("@Id_Suc", cmbSucId1.SelectedValue);

                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            MessageBox.Show("Sucursal Modificada", "Sucursal modificada con exito", MessageBoxButtons.OK);
        }

        private void BorrarSucursal()
        {
            string Delete = "DELETE FROM sucursales WHERE id_sucursal = @id_suc";

            try
            {
                using (MySqlConnection cnc = new MySqlConnection(bdd))
                {
                    cnc.Open();

                    MySqlCommand cmd = new MySqlCommand(Delete, cnc);
                    cmd.Parameters.AddWithValue("@id_suc", cmbSucId2.SelectedValue);

                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CRUD_Sucursales_Load(object sender, EventArgs e)
        {

        }

        private void btnBorrarSucursales_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("ESTAS A PUNTO DE BORRAR UNA SUCURSAL, ESTAS SEGURO?", "BORRADO DE SUCURSAL", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                BorrarSucursal();
            }
            else
            {
                return;
            }

        }

        private void VaciarTxtBoxs()
        {
            //Para registros

            txtBoxRegName.Text = null;
            txtRegDomicilio.Text = null;
            txtRegCiudad.Text = null;
            txtRegEstado.Text = null;
            txtRegCp.Text = null;
            txtRegTelefono.Text = null;
        
            //Para updates

            txtSucUpd.Text = null;
            txtAddressSucUpd.Text = null;
            txtCitSucUpd.Text = null;
            txtStaSucUpd.Text = null;
            txtCpSucUpd.Text = null;
            txtTelSucUpd.Text = null;
        }
    }
}
