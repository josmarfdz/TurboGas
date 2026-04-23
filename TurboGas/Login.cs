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
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
            ucOTP.Hide();
            ucRegistro.Hide();
        }

        private void linkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ucRegistro.Show();
        }

        private void linkFMP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ucOTP.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            tbCorreo.Text="";
            tbContraseña.Text="";
        }
    }
}
