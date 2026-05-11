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
    public partial class SistemaBomba : UserControl
    {
        public SistemaBomba()
        {
            InitializeComponent();
        }

        string Tipo, Método, Correo;
        double Cantidad;

        private void btnTransacción_Click(object sender, EventArgs e)
        {
            TipoRB();
            TipoPago();
            TipoCantidad();
            Correo = tbCorreo.Text;
            ReciboCompra rc = new ReciboCompra();
            rc.EnviarCorreo(Correo, Método, Tipo, Cantidad);
        }

        public void TipoRB()
        {
            if (rbRegular.Checked)
                Tipo = "Regular";
            else if (rbPremium.Checked)
                Tipo = "Premium";
            else if (rbDiesel.Checked)
                Tipo = "Diesel";
            else
                MessageBox.Show("Seleccione un tipo de gasolina primero", "Tipo de gasolina no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void TipoPago()
        {
            if (rbEfectivo.Checked)
                Método = "Efectivo";
            else if (rbTarjeta.Checked)
                Método = "Tarjeta";
            else if (rbVales.Checked)
                Método = "Vales";
            else
                MessageBox.Show("Seleccione un método de pago primero", "Método de pago no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void TipoCantidad()
        {
            if (rbLitros.Checked)
                Cantidad = double.Parse(tbCantidad.Text);
            if(rbPrecio.Checked)
            {
                if (Tipo == "Regular")
                    Cantidad = Math.Round(Cantidad / 23.89, 2);
                else if (Tipo == "Premium")
                    Cantidad = Math.Round(Cantidad / 27.54, 2);
                else if (Tipo == "Diesel")
                    Cantidad = Math.Round(Cantidad / 31.59, 2);
                else
                    MessageBox.Show("Seleccione un tipo de gasolina primero", "Tipo de gasolina no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
