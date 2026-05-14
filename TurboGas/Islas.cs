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
    public partial class Islas : UserControl
    {
        public Islas()
        {
            InitializeComponent();
            ucSistemaB.Hide();
        }

        private void btConfiguración_Click(object sender, EventArgs e)
        {
            //ABRIR EL CRUD DE ISLAS
        }

        private void btPerfil_Click(object sender, EventArgs e)
        {

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
    }
}
