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
    public partial class CambiarInformación : UserControl
    {
        public CambiarInformación()
        {
            InitializeComponent();
            ucCambiarContraseña.Hide();
        }

        private void btnContraseña_Click(object sender, EventArgs e)
        {
            ucCambiarContraseña.Show();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            //CAMBIAR INFORMACiÓN
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
