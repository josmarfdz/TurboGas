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
    public partial class CRUD_Bombas : UserControl
    {
        public CRUD_Bombas()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }



        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void CRUD_Bombas_Load(object sender, EventArgs e)
        {
            lblNombreUser.Text = Sesion.UserNombre;
        }
    }
}
