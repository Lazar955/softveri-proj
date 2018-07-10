using KontrolerKorisnickogInterfejsa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klijent
{
    public partial class LekoviForm : Form
    {
        KKInterfejs kki;
        public LekoviForm(KKInterfejs kontroler)
        {
            InitializeComponent();
            kki = kontroler;
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            int rezultat = kki.ZapamtiLek(txtIme,txtDoza,txtINM,txtOblik,txtOpis,txtProizvodjac);

            if(rezultat == 1)
            {

                foreach (Control gb in this.Controls)
                {
                    if (gb is GroupBox)
                    {
                        foreach (Control tb in gb.Controls)
                        {
                            if (tb is TextBox)
                            {
                                tb.Text = String.Empty;
                            }
                        }
                    }
                }
                kki.PretraziLekove(txtPretragaLeka, dgvLekovi);
            }

        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            kki.PretraziLekove(txtPretragaLeka, dgvLekovi);
        }

        private void LekoviForm_Load(object sender, EventArgs e)
        {
            kki.PretraziLekove(txtPretragaLeka, dgvLekovi);
        }

        private void dgvLekovi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnObrisiLek_Click(object sender, EventArgs e)
        {
            kki.ObrisiLek(txtPretragaLeka, dgvLekovi);
        }
    }
}
