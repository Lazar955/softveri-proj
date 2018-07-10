namespace Klijent
{
    partial class PregledForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePacijent = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvPacijenti = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dtpDatumPregleda = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSomatski = new System.Windows.Forms.TextBox();
            this.txtAnamneza = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvPregledi = new System.Windows.Forms.DataGridView();
            this.cmbLek = new System.Windows.Forms.ComboBox();
            this.cmbDijagnoza = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvRecepti = new System.Windows.Forms.DataGridView();
            this.txtKoriscenje = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDodajRecept = new System.Windows.Forms.Button();
            this.btnSacuvajPregled = new System.Windows.Forms.Button();
            this.btnDodajPacijenta = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPagePacijent.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacijenti)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepti)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 680);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPagePacijent);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(887, 626);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPagePacijent
            // 
            this.tabPagePacijent.Controls.Add(this.button1);
            this.tabPagePacijent.Controls.Add(this.comboBox1);
            this.tabPagePacijent.Controls.Add(this.dateTimePicker1);
            this.tabPagePacijent.Controls.Add(this.label7);
            this.tabPagePacijent.Controls.Add(this.label6);
            this.tabPagePacijent.Controls.Add(this.label5);
            this.tabPagePacijent.Controls.Add(this.label4);
            this.tabPagePacijent.Controls.Add(this.label3);
            this.tabPagePacijent.Controls.Add(this.label2);
            this.tabPagePacijent.Controls.Add(this.textBox7);
            this.tabPagePacijent.Controls.Add(this.textBox5);
            this.tabPagePacijent.Controls.Add(this.textBox3);
            this.tabPagePacijent.Controls.Add(this.textBox2);
            this.tabPagePacijent.Location = new System.Drawing.Point(4, 22);
            this.tabPagePacijent.Name = "tabPagePacijent";
            this.tabPagePacijent.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePacijent.Size = new System.Drawing.Size(879, 600);
            this.tabPagePacijent.TabIndex = 0;
            this.tabPagePacijent.Text = "Pacijent";
            this.tabPagePacijent.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvPregledi);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(879, 600);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pregled";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvPacijenti
            // 
            this.dgvPacijenti.AllowUserToAddRows = false;
            this.dgvPacijenti.AllowUserToDeleteRows = false;
            this.dgvPacijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacijenti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPacijenti.Location = new System.Drawing.Point(0, 0);
            this.dgvPacijenti.Name = "dgvPacijenti";
            this.dgvPacijenti.ReadOnly = true;
            this.dgvPacijenti.Size = new System.Drawing.Size(248, 626);
            this.dgvPacijenti.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPretrazi);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 54);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(166, 19);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(75, 23);
            this.btnPretrazi.TabIndex = 2;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDodajPacijenta);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(248, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(887, 54);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tabControl1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(248, 54);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(887, 626);
            this.panel4.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(129, 23);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(701, 20);
            this.textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(129, 64);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(701, 20);
            this.textBox3.TabIndex = 1;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(129, 105);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(701, 20);
            this.textBox5.TabIndex = 2;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(129, 185);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(701, 20);
            this.textBox7.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Prezime:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Maticni broj:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Pol:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Adresa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Datum rodjenja:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 227);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(701, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Muski",
            "Zenski"});
            this.comboBox1.Location = new System.Drawing.Point(129, 144);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(701, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // dtpDatumPregleda
            // 
            this.dtpDatumPregleda.Location = new System.Drawing.Point(26, 39);
            this.dtpDatumPregleda.Name = "dtpDatumPregleda";
            this.dtpDatumPregleda.Size = new System.Drawing.Size(237, 20);
            this.dtpDatumPregleda.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSacuvajPregled);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtAnamneza);
            this.groupBox1.Controls.Add(this.txtSomatski);
            this.groupBox1.Controls.Add(this.dtpDatumPregleda);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 203);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pregled";
            // 
            // txtSomatski
            // 
            this.txtSomatski.Location = new System.Drawing.Point(307, 39);
            this.txtSomatski.Name = "txtSomatski";
            this.txtSomatski.Size = new System.Drawing.Size(248, 20);
            this.txtSomatski.TabIndex = 1;
            // 
            // txtAnamneza
            // 
            this.txtAnamneza.Location = new System.Drawing.Point(26, 87);
            this.txtAnamneza.Multiline = true;
            this.txtAnamneza.Name = "txtAnamneza";
            this.txtAnamneza.Size = new System.Drawing.Size(529, 57);
            this.txtAnamneza.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Datum pregleda";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(304, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Somatski nalaz";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Anamneza";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDodajRecept);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtKoriscenje);
            this.groupBox2.Controls.Add(this.dgvRecepti);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cmbDijagnoza);
            this.groupBox2.Controls.Add(this.cmbLek);
            this.groupBox2.Location = new System.Drawing.Point(6, 207);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(583, 385);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recept";
            // 
            // dgvPregledi
            // 
            this.dgvPregledi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPregledi.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvPregledi.Location = new System.Drawing.Point(595, 3);
            this.dgvPregledi.Name = "dgvPregledi";
            this.dgvPregledi.Size = new System.Drawing.Size(281, 594);
            this.dgvPregledi.TabIndex = 3;
            // 
            // cmbLek
            // 
            this.cmbLek.FormattingEnabled = true;
            this.cmbLek.Location = new System.Drawing.Point(14, 38);
            this.cmbLek.Name = "cmbLek";
            this.cmbLek.Size = new System.Drawing.Size(249, 21);
            this.cmbLek.TabIndex = 0;
            // 
            // cmbDijagnoza
            // 
            this.cmbDijagnoza.FormattingEnabled = true;
            this.cmbDijagnoza.Location = new System.Drawing.Point(307, 38);
            this.cmbDijagnoza.Name = "cmbDijagnoza";
            this.cmbDijagnoza.Size = new System.Drawing.Size(248, 21);
            this.cmbDijagnoza.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Lek";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(304, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Dijagnoza";
            // 
            // dgvRecepti
            // 
            this.dgvRecepti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecepti.Location = new System.Drawing.Point(15, 203);
            this.dgvRecepti.Name = "dgvRecepti";
            this.dgvRecepti.Size = new System.Drawing.Size(541, 162);
            this.dgvRecepti.TabIndex = 7;
            // 
            // txtKoriscenje
            // 
            this.txtKoriscenje.Location = new System.Drawing.Point(14, 90);
            this.txtKoriscenje.Multiline = true;
            this.txtKoriscenje.Name = "txtKoriscenje";
            this.txtKoriscenje.Size = new System.Drawing.Size(541, 57);
            this.txtKoriscenje.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Koriscenje";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvPacijenti);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 54);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(248, 626);
            this.panel5.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Klijent.Properties.Resources.Actions_document_save_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(688, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sacuvaj pacijenta";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnDodajRecept
            // 
            this.btnDodajRecept.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajRecept.Image = global::Klijent.Properties.Resources.add_icon;
            this.btnDodajRecept.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajRecept.Location = new System.Drawing.Point(413, 152);
            this.btnDodajRecept.Name = "btnDodajRecept";
            this.btnDodajRecept.Size = new System.Drawing.Size(142, 45);
            this.btnDodajRecept.TabIndex = 6;
            this.btnDodajRecept.Text = "Dodaj recept";
            this.btnDodajRecept.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDodajRecept.UseVisualStyleBackColor = true;
            // 
            // btnSacuvajPregled
            // 
            this.btnSacuvajPregled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvajPregled.Image = global::Klijent.Properties.Resources.Actions_document_save_icon;
            this.btnSacuvajPregled.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSacuvajPregled.Location = new System.Drawing.Point(413, 150);
            this.btnSacuvajPregled.Name = "btnSacuvajPregled";
            this.btnSacuvajPregled.Size = new System.Drawing.Size(142, 45);
            this.btnSacuvajPregled.TabIndex = 1;
            this.btnSacuvajPregled.Text = "Sacuvaj pregled";
            this.btnSacuvajPregled.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSacuvajPregled.UseVisualStyleBackColor = true;
            // 
            // btnDodajPacijenta
            // 
            this.btnDodajPacijenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodajPacijenta.Image = global::Klijent.Properties.Resources.Actions_list_add_user_icon;
            this.btnDodajPacijenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDodajPacijenta.Location = new System.Drawing.Point(6, 3);
            this.btnDodajPacijenta.Name = "btnDodajPacijenta";
            this.btnDodajPacijenta.Size = new System.Drawing.Size(139, 45);
            this.btnDodajPacijenta.TabIndex = 0;
            this.btnDodajPacijenta.Text = "Dodaj pacijenta";
            this.btnDodajPacijenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDodajPacijenta.UseVisualStyleBackColor = true;
            this.btnDodajPacijenta.Click += new System.EventHandler(this.btnDodajPacijenta_Click);
            // 
            // PregledForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 680);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "PregledForm";
            this.Text = "Pregled";
            this.Load += new System.EventHandler(this.PregledForm_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPagePacijent.ResumeLayout(false);
            this.tabPagePacijent.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacijenti)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPregledi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepti)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPacijenti;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePacijent;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDodajPacijenta;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAnamneza;
        private System.Windows.Forms.TextBox txtSomatski;
        private System.Windows.Forms.DateTimePicker dtpDatumPregleda;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvPregledi;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtKoriscenje;
        private System.Windows.Forms.DataGridView dgvRecepti;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbDijagnoza;
        private System.Windows.Forms.ComboBox cmbLek;
        private System.Windows.Forms.Button btnDodajRecept;
        private System.Windows.Forms.Button btnSacuvajPregled;
    }
}