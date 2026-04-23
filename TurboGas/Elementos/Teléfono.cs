using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurboGas.Elementos
{
    internal class Teléfono : UserControl
    {
        private ComboBox cmbCountry = new ComboBox();
        private TextBox txtPhone = new TextBox();
        private Panel separator = new Panel();

        private int borderRadius = 10;
        private Color borderColor = ColorTranslator.FromHtml("#FF783B");
        private int borderSize = 2;

        public Teléfono()
        {
            this.Size = new Size(320, 45);
            this.BackColor = Color.White;
            this.Padding = new Padding(10);

            this.DoubleBuffered = true;

            InitializeControls();
        }

        private void InitializeControls()
        {
            // ComboBox
            cmbCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCountry.FlatStyle = FlatStyle.Flat;
            cmbCountry.Width = 80;
            cmbCountry.Font = new Font("Poppins", 7.9f);

            cmbCountry.Items.Add("+52"); // 🇲🇽
            cmbCountry.Items.Add("+1");  // 🇺🇸
            cmbCountry.Items.Add("+34"); // 🇪🇸
            cmbCountry.Items.Add("+54"); // 🇦🇷
            cmbCountry.Items.Add("+57"); // 🇨🇴
            cmbCountry.Items.Add("+56"); // 🇨🇱
            cmbCountry.Items.Add("+55"); // 🇧🇷
            cmbCountry.Items.Add("+49"); // 🇩🇪
            cmbCountry.Items.Add("+33"); // 🇫🇷
            cmbCountry.Items.Add("+44"); // 🇬🇧

            cmbCountry.SelectedIndex = 0;

            // TextBox
            txtPhone.BorderStyle = BorderStyle.None;
            txtPhone.Font = new Font("Poppins", 10);
            txtPhone.Dock = DockStyle.Fill;

            // Placeholder
            txtPhone.Text = " 123 456 7890";
            txtPhone.ForeColor = Color.Gray;

            txtPhone.Enter += RemovePlaceholder;
            txtPhone.Leave += SetPlaceholder;

            // Separador
            separator.Width = 1;
            separator.Dock = DockStyle.Left;
            separator.BackColor = Color.LightGray;

            // Docking
            cmbCountry.Dock = DockStyle.Left;

            this.Controls.Add(txtPhone);
            this.Controls.Add(separator);
            this.Controls.Add(cmbCountry);
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (txtPhone.Text == " 123 456 7890")
            {
                txtPhone.Text = "";
                txtPhone.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                txtPhone.Text = " 123 456 7890";
                txtPhone.ForeColor = Color.Gray;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return cmbCountry.Text + " " + txtPhone.Text;
            }
        }

        // Bordes redondeados
        private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float diameter = radius * 2;

            path.StartFigure();

            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);

            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);

            using (GraphicsPath pathSurface = GetRoundedPath(rectSurface, borderRadius))
            using (GraphicsPath pathBorder = GetRoundedPath(rectBorder, borderRadius - borderSize))
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                this.Region = new Region(pathSurface);
                e.Graphics.DrawPath(penBorder, pathBorder);
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // NumTel
            // 
            this.Name = "NumTel";
            this.Load += new System.EventHandler(this.NumTel_Load);
            this.ResumeLayout(false);

        }

        private void NumTel_Load(object sender, EventArgs e)
        {

        }
    }
}
