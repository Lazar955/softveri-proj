namespace Klijent
{
    partial class ReceptiForm
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
            this.dgvRecepti = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepti)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRecepti
            // 
            this.dgvRecepti.AllowUserToAddRows = false;
            this.dgvRecepti.AllowUserToDeleteRows = false;
            this.dgvRecepti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecepti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRecepti.Location = new System.Drawing.Point(0, 0);
            this.dgvRecepti.Name = "dgvRecepti";
            this.dgvRecepti.ReadOnly = true;
            this.dgvRecepti.Size = new System.Drawing.Size(435, 303);
            this.dgvRecepti.TabIndex = 0;
            // 
            // Recepti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 303);
            this.Controls.Add(this.dgvRecepti);
            this.Name = "Recepti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recepti";
            this.Load += new System.EventHandler(this.Recepti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecepti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRecepti;
    }
}