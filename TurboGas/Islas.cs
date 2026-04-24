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
        }

        private void btConfiguración_Click(object sender, EventArgs e)
        {
            //LO QUE VAYA A HACER LA CONFIGURACIÓN
        }

        private void btPerfil_Click(object sender, EventArgs e)
        {

        }

        private void Islas_Load(object sender, EventArgs e)
        {
            lblNombre.Text = Sesion.UserNombre;
        }
    }
}
