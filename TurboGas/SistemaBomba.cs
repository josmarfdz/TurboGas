using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using MySql.Data.MySqlClient;
using System.IO;

namespace TurboGas
{
    public partial class SistemaBomba : UserControl
    {
        static string bdd = "server=localhost;database=gasolinera2026;port=3306;Uid=root;pwd=SyecMed&c1000";

        public SistemaBomba()
        {
            InitializeComponent();
            ucCRUDTanque.Hide();
        }

        string Tipo, Método, Correo;
        double Cantidad, Precio, Importe;

        public string NumeroBomba
        {
            get { return lblBomba.Text; }
            set { lblBomba.Text = value; }
        }

        private void btnTransacción_Click(object sender, EventArgs e)
        {
            TipoRB();
            TipoPago();
            TipoCantidad();

            // Validar que se haya seleccionado todo
            if (string.IsNullOrEmpty(Tipo) || string.IsNullOrEmpty(Método) || Cantidad <= 0)
                return;

            Correo = tbCorreo.Text;

            GuardarVenta();

            ReciboCompra rc = new ReciboCompra();
            rc.EnviarCorreo(Correo, Método, Tipo, Cantidad);
        }

        private void GuardarVenta()
        {
            try
            {
                // Calcular precio por litro e importe según el tipo
                switch (Tipo)
                {
                    case "Regular": Precio = 23.89; break;
                    case "Premium": Precio = 27.54; break;
                    case "Diesel": Precio = 31.59; break;
                }

                Importe = Math.Round(Cantidad * Precio, 2);

                // Generar folio único
                string folio = "F-" + DateTime.Now.ToString("yyyyMMddHHmmss");

                string query = @"INSERT INTO venta (folio, combustible, litros, precio, importe, metodo_pago) 
                                 VALUES (@Folio, @Combustible, @Litros, @Precio, @Importe, @MetodoPago)";

                using (MySqlConnection con = new MySqlConnection(bdd))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Folio", folio);
                        cmd.Parameters.AddWithValue("@Combustible", Tipo);
                        cmd.Parameters.AddWithValue("@Litros", Cantidad);
                        cmd.Parameters.AddWithValue("@Precio", Precio);
                        cmd.Parameters.AddWithValue("@Importe", Importe);
                        cmd.Parameters.AddWithValue("@MetodoPago", Método);

                        int filasAfectadas = cmd.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                            MessageBox.Show($"Venta registrada\nLitros: {Cantidad}L\nImporte: ${Importe}",
                                            "Venta exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("No se pudo registrar la venta", "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar venta: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCorte_Click(object sender, EventArgs e)
        {
            GenerarCorteCaja();
        }

        private void GenerarCorteCaja()
        {
            try
            {
                string query = @"SELECT folio, combustible, litros, precio, importe, 
                                        metodo_pago, fecha_venta 
                                 FROM venta 
                                 ORDER BY fecha_venta DESC";

                using (MySqlConnection con = new MySqlConnection(bdd))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        using (var wb = new XLWorkbook())
                        {
                            var ws = wb.Worksheets.Add("Corte de Caja");

                            // ── ENCABEZADO PRINCIPAL ──────────────────────────────
                            ws.Cell("A1").Value = "TURBOGAS - CORTE DE CAJA";
                            ws.Range("A1:G1").Merge();
                            ws.Cell("A1").Style
                                .Font.SetBold(true)
                                .Font.SetFontSize(16)
                                .Font.SetFontColor(XLColor.White)
                                .Fill.SetBackgroundColor(XLColor.FromArgb(31, 78, 121))
                                .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                            ws.Cell("A2").Value = $"Fecha de corte: {DateTime.Now:dd/MM/yyyy HH:mm}";
                            ws.Range("A2:G2").Merge();
                            ws.Cell("A2").Style
                                .Font.SetItalic(true)
                                .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                            // ── ENCABEZADOS DE COLUMNAS ───────────────────────────
                            string[] headers = { "Folio", "Combustible", "Litros",
                                                 "Precio/L", "Importe", "Método Pago", "Fecha" };
                            for (int i = 0; i < headers.Length; i++)
                            {
                                var cell = ws.Cell(4, i + 1);
                                cell.Value = headers[i];
                                cell.Style
                                    .Font.SetBold(true)
                                    .Font.SetFontColor(XLColor.White)
                                    .Fill.SetBackgroundColor(XLColor.FromArgb(52, 120, 180))
                                    .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center)
                                    .Border.SetOutsideBorder(XLBorderStyleValues.Thin);
                            }

                            // ── FILAS DE VENTAS ───────────────────────────────────
                            int fila = 5;
                            bool filaPar = false;

                            while (reader.Read())
                            {
                                var color = filaPar
                                    ? XLColor.FromArgb(221, 235, 247)  // azul clarito
                                    : XLColor.White;

                                ws.Cell(fila, 1).Value = reader["folio"].ToString();
                                ws.Cell(fila, 2).Value = reader["combustible"].ToString();
                                ws.Cell(fila, 3).Value = Convert.ToDouble(reader["litros"]);
                                ws.Cell(fila, 4).Value = Convert.ToDouble(reader["precio"]);
                                ws.Cell(fila, 5).Value = Convert.ToDouble(reader["importe"]);
                                ws.Cell(fila, 6).Value = reader["metodo_pago"].ToString();
                                ws.Cell(fila, 7).Value = Convert.ToDateTime(reader["fecha_venta"]).ToString("dd/MM/yyyy HH:mm");

                                // Formato numérico
                                ws.Cell(fila, 3).Style.NumberFormat.Format = "#,##0.000";
                                ws.Cell(fila, 4).Style.NumberFormat.Format = "$#,##0.00";
                                ws.Cell(fila, 5).Style.NumberFormat.Format = "$#,##0.00";

                                // Color de fila alternado
                                ws.Range(fila, 1, fila, 7).Style
                                    .Fill.SetBackgroundColor(color)
                                    .Border.SetOutsideBorder(XLBorderStyleValues.Thin)
                                    .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                                fila++;
                                filaPar = !filaPar;
                            }

                            // ── FILA TOTAL ────────────────────────────────────────
                            int filaTotal = fila + 1;
                            ws.Cell(filaTotal, 4).Value = "TOTAL:";
                            ws.Cell(filaTotal, 5).FormulaA1 = $"=SUM(E5:E{fila - 1})";

                            ws.Range(filaTotal, 4, filaTotal, 5).Style
                                .Font.SetBold(true)
                                .Font.SetFontSize(12)
                                .Font.SetFontColor(XLColor.White)
                                .Fill.SetBackgroundColor(XLColor.FromArgb(31, 78, 121))
                                .NumberFormat.SetFormat("$#,##0.00")
                                .Border.SetOutsideBorder(XLBorderStyleValues.Medium)
                                .Alignment.SetHorizontal(XLAlignmentHorizontalValues.Center);

                            // ── AJUSTAR COLUMNAS ──────────────────────────────────
                            ws.Columns().AdjustToContents();

                            // ── GUARDAR ARCHIVO ───────────────────────────────────
                            string fecha = DateTime.Now.ToString("yyyy-MM-dd_HH-mm");
                            string ruta = Path.Combine(
                                Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                                $"CorteCaja_{fecha}.xlsx"
                            );

                            wb.SaveAs(ruta);

                            MessageBox.Show($"Corte de caja generado exitosamente:\n{ruta}",
                                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Abrir el archivo automáticamente
                            System.Diagnostics.Process.Start(ruta);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar corte de caja: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btConfiguración_Click(object sender, EventArgs e)
        {
            ucCRUDTanque.Show();
        }

        public void TipoRB()
        {
            if (rbRegular.Checked) Tipo = "Regular";
            else if (rbPremium.Checked) Tipo = "Premium";
            else if (rbDiesel.Checked) Tipo = "Diesel";
            else
                MessageBox.Show("Seleccione un tipo de gasolina primero", "Tipo de gasolina no seleccionado",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void TipoPago()
        {
            if (rbEfectivo.Checked) Método = "Efectivo";
            else if (rbTarjeta.Checked) Método = "Tarjeta";
            else if (rbVales.Checked) Método = "Vales";
            else
                MessageBox.Show("Seleccione un método de pago primero", "Método de pago no seleccionado",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void TipoCantidad()
        {
            if (!double.TryParse(tbCantidad.Text, out Cantidad))
            {
                MessageBox.Show("Ingrese una cantidad válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rbPrecio.Checked)
            {
                switch (Tipo)
                {
                    case "Regular":
                        Cantidad = Math.Round(Cantidad / 23.89, 2); 
                        break;
                    case "Premium": 
                        Cantidad = Math.Round(Cantidad / 27.54, 2); 
                        break;
                    case "Diesel": 
                        Cantidad = Math.Round(Cantidad / 31.59, 2); 
                        break;
                    default:
                        MessageBox.Show("Seleccione un tipo de gasolina primero", "Tipo de gasolina no seleccionado",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                }
            }
        }
    }
}