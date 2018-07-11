using Domen;
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
    public partial class PregledForm : Form
    {
        KKInterfejs kki;
        BindingList<Recept> recepti = new BindingList<Recept>();
        public PregledForm(KKInterfejs kontroler)
        {
            InitializeComponent();
            kki = kontroler;
            popuniPolja();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDodajPacijenta_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
            txtAdresaPacijenta.Text = String.Empty;
            txtPrezimePacijenta.Text = String.Empty;
            txtImePacijenta.Text = String.Empty;
            txtMaticniBrojPacijenta.Text = String.Empty;
            dtpDatumRodjenjaPacijenta.Value = DateTime.Now;

            txtAdresaPacijenta.Enabled = true;
            txtPrezimePacijenta.Enabled = true;
            txtImePacijenta.Enabled = true;
            txtMaticniBrojPacijenta.Enabled = true;
            dtpDatumRodjenjaPacijenta.Enabled = true;
            cmbPol.Enabled = true;
            btnSacuvajPacijenta.Enabled = true;
        }

        private void PregledForm_Load(object sender, EventArgs e)
        {
            shouldEnableControlsInTab(false);
            txtAdresaPacijenta.Enabled = false;
            txtPrezimePacijenta.Enabled = false;
            txtImePacijenta.Enabled = false;
            txtMaticniBrojPacijenta.Enabled = false;
            dtpDatumRodjenjaPacijenta.Enabled = false;
            cmbPol.Enabled = false;
            btnSacuvajPacijenta.Enabled = false;
            cmbPol.SelectedIndex = 0;



        }

        private void shouldEnableControlsInTab(bool shouldEnable)
        {

        }

        private void popuniPolja()
        {
            kki.VratiListuLekova(cmbLek);
            kki.VratiListuDijagnoza(cmbDijagnoza);
            kki.vratiListuPacijenata(dgvPacijenti);
            dgvRecepti.DataSource = recepti;
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            kki.PretraziPacijente(txtPretraga, dgvPacijenti);
        }

        private void btnSacuvajPacijenta_Click(object sender, EventArgs e)
        {
            int rezultat = kki.ZapamtiPacijenta(txtImePacijenta, txtPrezimePacijenta,txtMaticniBrojPacijenta,txtAdresaPacijenta,cmbPol,dtpDatumRodjenjaPacijenta);
            kki.vratiListuPacijenata(dgvPacijenti);
        }

        private void btnDodajRecept_Click(object sender, EventArgs e)
        {
            kki.DodajRecept(recepti, cmbLek, cmbDijagnoza, txtKoriscenje);
        }

        private void btnSacuvajPregled_Click(object sender, EventArgs e)
        {
            kki.SacuvajPregled(recepti, dtpDatumPregleda, txtSomatski, txtAnamneza,dgvPacijenti);
            kki.PretraziPregledePacijenta(dgvPacijenti, dgvPregledi);
        }

        private void dgvPacijenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            kki.popuniPoljaPacijenta(dgvPacijenti, txtImePacijenta, txtPrezimePacijenta, txtMaticniBrojPacijenta, txtAdresaPacijenta, cmbPol, dtpDatumRodjenjaPacijenta);
        }

        private void dgvPacijenti_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvPacijenti.SelectedRows.Count > 0)
            {
                kki.popuniPoljaPacijenta(dgvPacijenti, txtImePacijenta, txtPrezimePacijenta, txtMaticniBrojPacijenta, txtAdresaPacijenta, cmbPol, dtpDatumRodjenjaPacijenta);
                kki.PretraziPregledePacijenta(dgvPacijenti,dgvPregledi);

            }
        }

        private void refreshFields()
        {

        }

        private void btnObrisiRecept_Click(object sender, EventArgs e)
        {
            if (dgvRecepti.SelectedRows.Count > 0)
            {
                var r = dgvRecepti.CurrentRow.DataBoundItem as Recept;
                recepti.Remove(r);
            }
        }

        private void btnPrikaziRecepte_Click(object sender, EventArgs e)
        {
            if (dgvPregledi.SelectedRows.Count == 1)
            {
                var p = dgvPregledi.CurrentRow.DataBoundItem as Pregled;
                new ReceptiForm(kki, p).ShowDialog();
            }
            else
            {
                MessageBox.Show("Potrebno je selektovati pregled", "Greska");
            }
        }
    }
}
