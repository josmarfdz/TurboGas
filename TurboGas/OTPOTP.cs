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
    public partial class OTPOTP : UserControl
    {
        public OTPOTP()
        {
            InitializeComponent();
            ucContraseña.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if(tbOTP.Text == tbOTP.Text)
            {
                ucContraseña.Show();
            }

            //VERIFIACIÓN AQUÍ
        }
    }
}
