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
    public class Contraseñas : UserControl
    {
        private TextBox textBox = new TextBox();
        //sam aqui iba tu ojito 
        private Label eyeIcon = new Label();

        private bool mostrarPassword = false;

        private int borderSize = 2;
        private int borderRadius = 10;
        private Color borderColor = ColorTranslator.FromHtml("#FF783B"); //Contorno

        public Contraseñas()
        {
            this.Padding = new Padding(10);
            this.Size = new Size(200, 40);
            this.BackColor = Color.White;

            // TEXTBOX
            textBox.BorderStyle = BorderStyle.None;
            textBox.Dock = DockStyle.Fill;
            textBox.Font = new Font("Poppins", 10);
            textBox.UseSystemPasswordChar = true;

            // aqui ya no va el icono dle ojo xd sino el label que es el que va a tener la palabara del ojo
            eyeIcon.Size = new Size(55, 20);                     
            eyeIcon.Dock = DockStyle.Right;                      
            eyeIcon.TextAlign = ContentAlignment.MiddleCenter;   
            eyeIcon.Cursor = Cursors.Hand;                       
            eyeIcon.Font = new Font("Poppins", 8);              
            eyeIcon.ForeColor = borderColor;                    
            eyeIcon.Text = "Ver";                                
          

            eyeIcon.Click += TogglePassword;

            this.Controls.Add(textBox);
            this.Controls.Add(eyeIcon);
        }

        private void TogglePassword(object sender, EventArgs e)
        {
            mostrarPassword = !mostrarPassword;

            textBox.UseSystemPasswordChar = !mostrarPassword;

            if (mostrarPassword)         
                eyeIcon.Text = "ver";
            else                          
                eyeIcon.Text = "ocultar";   
        }

        public override string Text
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
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

            if (borderRadius > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(pathSurface);
                    e.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else
            {
                this.Region = new Region(rectSurface);
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    e.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                }
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Contraseñas
            // 
            this.Name = "Contraseñas";
            this.Load += new System.EventHandler(this.Contraseñas_Load);
            this.ResumeLayout(false);

        }

        private void Contraseñas_Load(object sender, EventArgs e)
        {

        }
    }
}
