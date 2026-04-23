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
    public partial class CambioContraseña : UserControl
    {
        public CambioContraseña()
        {
            InitializeComponent();
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            if(tbNueva.Text == tbConfirmar.Text)
            {
                MessageBox.Show("Cambio de contraseña exitoso", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if(tbNueva.Text != tbConfirmar.Text)
            {
                MessageBox.Show("Las contraseñas no coindicen, revíselas e inténtelo de nuevo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void botón1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
