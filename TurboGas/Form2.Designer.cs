namespace TurboGas
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.islas1 = new TurboGas.Islas();
            this.SuspendLayout();
            // 
            // islas1
            // 
            this.islas1.BackColor = System.Drawing.Color.White;
            this.islas1.Location = new System.Drawing.Point(-1, 0);
            this.islas1.Name = "islas1";
            this.islas1.Size = new System.Drawing.Size(800, 538);
            this.islas1.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 528);
            this.Controls.Add(this.islas1);
            this.Name = "Form2";
            this.Text = "Sucursal";
            this.ResumeLayout(false);

        }

        #endregion

        private Islas islas1;
    }
}