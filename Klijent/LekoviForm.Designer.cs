namespace Klijent
{
    partial class LekoviForm
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
            this.dgvLekovi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPretragaLeka = new System.Windows.Forms.TextBox();
            this.btnPretraga = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtProizvodjac = new System.Windows.Forms.TextBox();
            this.txtINM = new System.Windows.Forms.TextBox();
            this.txtOblik = new System.Windows.Forms.TextBox();
            this.txtDoza = new System.Windows.Forms.TextBox();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnObrisiLek = new System.Windows.Forms.Button();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLekovi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLekovi
            // 
            this.dgvLekovi.AllowUserToAddRows = false;
            this.dgvLekovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLekovi.Location = new System.Drawing.Point(15, 42);
            this.dgvLekovi.Name = "dgvLekovi";
            this.dgvLekovi.ReadOnly = true;
            this.dgvLekovi.Size = new System.Drawing.Size(701, 339);
            this.dgvLekovi.TabIndex = 0;
            this.dgvLekovi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLekovi_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naziv leka:";
            // 
            // txtPretragaLeka
            // 
            this.txtPretragaLeka.Location = new System.Drawing.Point(78, 12);
            this.txtPretragaLeka.Name = "txtPretragaLeka";
            this.txtPretragaLeka.Size = new System.Drawing.Size(113, 20);
            this.txtPretragaLeka.TabIndex = 2;
            // 
            // btnPretraga
            // 
            this.btnPretraga.Location = new System.Drawing.Point(197, 9);
            this.btnPretraga.Name = "btnPretraga";
            this.btnPretraga.Size = new System.Drawing.Size(75, 23);
            this.btnPretraga.TabIndex = 3;
            this.btnPretraga.Text = "Trazi";
            this.btnPretraga.UseVisualStyleBackColor = true;
            this.btnPretraga.Click += new System.EventHandler(this.btnPretraga_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnObrisiLek);
            this.groupBox1.Controls.Add(this.btnSacuvaj);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtOpis);
            this.groupBox1.Controls.Add(this.txtDoza);
            this.groupBox1.Controls.Add(this.txtOblik);
            this.groupBox1.Controls.Add(this.txtINM);
            this.groupBox1.Controls.Add(this.txtProizvodjac);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Location = new System.Drawing.Point(722, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 365);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unos leka";
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(77, 30);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(282, 20);
            this.txtIme.TabIndex = 0;
            // 
            // txtProizvodjac
            // 
            this.txtProizvodjac.Location = new System.Drawing.Point(77, 195);
            this.txtProizvodjac.Name = "txtProizvodjac";
            this.txtProizvodjac.Size = new System.Drawing.Size(282, 20);
            this.txtProizvodjac.TabIndex = 1;
            // 
            // txtINM
            // 
            this.txtINM.Location = new System.Drawing.Point(77, 162);
            this.txtINM.Name = "txtINM";
            this.txtINM.Size = new System.Drawing.Size(282, 20);
            this.txtINM.TabIndex = 2;
            // 
            // txtOblik
            // 
            this.txtOblik.Location = new System.Drawing.Point(77, 129);
            this.txtOblik.Name = "txtOblik";
            this.txtOblik.Size = new System.Drawing.Size(282, 20);
            this.txtOblik.TabIndex = 3;
            // 
            // txtDoza
            // 
            this.txtDoza.Location = new System.Drawing.Point(77, 96);
            this.txtDoza.Name = "txtDoza";
            this.txtDoza.Size = new System.Drawing.Size(282, 20);
            this.txtDoza.TabIndex = 4;
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(77, 63);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(282, 20);
            this.txtOpis.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Opis:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Doza:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Oblik:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "INM:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Proizvodjac:";
            // 
            // btnObrisiLek
            // 
            this.btnObrisiLek.Image = global::Klijent.Properties.Resources.Trash_empty_icon;
            this.btnObrisiLek.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnObrisiLek.Location = new System.Drawing.Point(175, 221);
            this.btnObrisiLek.Name = "btnObrisiLek";
            this.btnObrisiLek.Size = new System.Drawing.Size(89, 42);
            this.btnObrisiLek.TabIndex = 12;
            this.btnObrisiLek.Text = "Obrisi lek";
            this.btnObrisiLek.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnObrisiLek.UseVisualStyleBackColor = true;
            this.btnObrisiLek.Click += new System.EventHandler(this.btnObrisiLek_Click);
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Image = global::Klijent.Properties.Resources.Actions_document_save_icon;
            this.btnSacuvaj.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSacuvaj.Location = new System.Drawing.Point(270, 221);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(89, 42);
            this.btnSacuvaj.TabIndex = 5;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // LekoviForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 407);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPretraga);
            this.Controls.Add(this.txtPretragaLeka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLekovi);
            this.Name = "LekoviForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lekovi";
            this.Load += new System.EventHandler(this.LekoviForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLekovi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLekovi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPretragaLeka;
        private System.Windows.Forms.Button btnPretraga;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.TextBox txtDoza;
        private System.Windows.Forms.TextBox txtOblik;
        private System.Windows.Forms.TextBox txtINM;
        private System.Windows.Forms.TextBox txtProizvodjac;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnObrisiLek;
    }
}