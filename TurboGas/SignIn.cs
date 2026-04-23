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
    public partial class SignIn : UserControl
    {
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
            if (cbPriv.Checked && cbTyC.Checked)
            {
                MessageBox.Show("Registro completo", "Éxito");
                //FUNCIÓN DE REGISTRO
            }
            else if (cbPriv.Checked && cbTyC.Checked != true)
            {
                MessageBox.Show("Lea y acepte los términos y condiciones", "Términos y condiciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cbPriv.Checked != true && cbTyC.Checked)
                MessageBox.Show("Lea y acepte el aviso de privacidad", "Aviso de privacidad", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Lea y acepte el aviso de privacidad y los términos y condiciones", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
