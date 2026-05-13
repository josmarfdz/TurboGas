using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurboGas
{
    public partial class Sucursales : UserControl
    {
        public Sucursales()
        {
            InitializeComponent();
        }

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
    }
}
