using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurboGas
{
    public partial class OTPCorreo : UserControl
    {
        public OTPCorreo()
        {
            InitializeComponent();
            tbCorreo.Text = " example@mail.com";
            tbCorreo.ForeColor = Color.Gray;
            tbCorreo.Enter += RemovePlaceholder;
            tbCorreo.Leave += SetPlaceholder;
            ucOTP.Hide();
        }
        string destino;

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbCorreo.Text) || tbCorreo.Text == " example@mail.com")
            {
                MessageBox.Show("El campo no puede quedar vacío", "Información", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                destino = tbCorreo.Text;
                OTP otp = new OTP();
                otp.POTP(destino);
                ucOTP.Show();
            }
        }
    }
}
