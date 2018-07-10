namespace Klijent
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPregled = new System.Windows.Forms.Button();
            this.btnLekovi = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPregled);
            this.panel1.Controls.Add(this.btnLekovi);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 485);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Klijent.Properties.Resources._132;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(156, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 485);
            this.panel2.TabIndex = 2;
            // 
            // btnPregled
            // 
            this.btnPregled.Image = global::Klijent.Properties.Resources.Stethoscope_Icon_32;
            this.btnPregled.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPregled.Location = new System.Drawing.Point(5, 12);
            this.btnPregled.Name = "btnPregled";
            this.btnPregled.Size = new System.Drawing.Size(145, 41);
            this.btnPregled.TabIndex = 1;
            this.btnPregled.Text = "Pregled";
            this.btnPregled.UseVisualStyleBackColor = true;
            this.btnPregled.Click += new System.EventHandler(this.btnPregled_Click);
            // 
            // btnLekovi
            // 
            this.btnLekovi.Image = global::Klijent.Properties.Resources.pill_2_icon__1_;
            this.btnLekovi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLekovi.Location = new System.Drawing.Point(5, 59);
            this.btnLekovi.Name = "btnLekovi";
            this.btnLekovi.Size = new System.Drawing.Size(145, 41);
            this.btnLekovi.TabIndex = 0;
            this.btnLekovi.Text = "Lekovi";
            this.btnLekovi.UseVisualStyleBackColor = true;
            this.btnLekovi.Click += new System.EventHandler(this.btnLekovi_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 485);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Ordinacija";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLekovi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPregled;
    }
}