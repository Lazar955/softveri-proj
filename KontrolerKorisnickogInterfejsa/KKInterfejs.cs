using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KontrolerKorisnickogInterfejsa
{
    public class KKInterfejs
    {
        Doktor tekuciDoktor;
        Komunikacija komunikacija;

        public List<Dijagnoza> dijagnoze { get; set; }
        public List<Lek> lekovi { get; set; }

        public Doktor TekuciDoktor
        {
            get { return tekuciDoktor; }
            set { tekuciDoktor = value; }
        }

        public KKInterfejs()
        {
            komunikacija = new Komunikacija();
            komunikacija.PoveziSeSaServerom();
            dijagnoze = new List<Dijagnoza>();
            lekovi = new List<Lek>();
        }

        public int ZapamtiLek(TextBox txtIme, TextBox txtDoza, TextBox txtINM, TextBox txtOblik, TextBox txtOpis, TextBox txtProizvodjac)
        {
            var ime = txtIme.Text;
            var doza = txtDoza.Text;
            var INM = txtINM.Text;
            var oblik = txtOblik.Text;
            var opis = txtOpis.Text;
            var proizvodjac = txtProizvodjac.Text;

            if (!fieldsAreValid(new List<TextBox> { txtIme, txtDoza, txtINM, txtOblik, txtOpis, txtProizvodjac }))
            {
                MessageBox.Show("Niste uneli sve potrebne podatke", "Greska!");
                return 0;
            }
            else
            {
                int rez = komunikacija.Unesi(new Lek { Ime = ime, Doza = doza, INM = INM, Oblik = oblik, Opis = opis, Proizvodjac = proizvodjac });

                if (rez > 0)
                {
                    MessageBox.Show("Sistem je uspesno zapamtio lek!");
                    return 1;
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da zapamti lek", "Greska!");
                    return 0;
                }
            }

        }

        public void prekiniKonekciju()
        {

            komunikacija.prekiniKonekciju();
        }

        public void PretraziRecepte(DataGridView dgvRecepti, Pregled pregled)
        {
            var r = new Recept { Pregled = pregled };

            List<Recept> recepti = komunikacija.PretraziRecepte(r);

            if (recepti.Count > 0)
            {
                for (int i = 0; i < recepti.Count; i++)
                {
                    foreach (var d in dijagnoze)
                    {
                        if (d.DijagnozaID == recepti[i].Dijagnoza.DijagnozaID)
                        {
                            recepti[i].Dijagnoza = d;
                        }
                    }

                    foreach (var l in lekovi)
                    {
                        if (recepti[i].Lek.LekID == l.LekID)
                        {
                            recepti[i].Lek = l;
                            break;
                        }
                    }
                }

                dgvRecepti.DataSource = recepti;
            }
        }

        public void DodajRecept(BindingList<Recept> recepti, ComboBox cmbLek, ComboBox cmbDijagnoza, TextBox txtKoriscenje)
        {

            if (!cmbFieldsAreValid(new List<ComboBox> { cmbDijagnoza, cmbLek }))
            {
                MessageBox.Show("Niste izabrali sve potrebne podatke", "Greska!");
                return;
            }

            if (!fieldsAreValid(new List<TextBox> { txtKoriscenje }))
            {
                MessageBox.Show("Niste uneli sve potrebne podatke", "Greska!");
                return;
            }

            var lek = cmbLek.SelectedItem as Lek;
            var dijagnoza = cmbDijagnoza.SelectedItem as Dijagnoza;
            var koriscenje = txtKoriscenje.Text;

            recepti.Add(new Recept { Dijagnoza = dijagnoza, Koriscenje = koriscenje, Lek = lek });
        }

        public void popuniPoljaPacijenta(DataGridView dgvPacijenti, TextBox txtImePacijenta, TextBox txtPrezimePacijenta, TextBox txtMaticniBrojPacijenta, TextBox txtAdresaPacijenta, ComboBox cmbPol, DateTimePicker dtpDatumRodjenjaPacijenta)
        {
            var selected = dgvPacijenti.CurrentRow.DataBoundItem as Pacijent;

            txtAdresaPacijenta.Text = selected.Adresa;
            txtPrezimePacijenta.Text = selected.Prezime;
            txtImePacijenta.Text = selected.Ime;
            txtMaticniBrojPacijenta.Text = selected.MaticniBroj;
            dtpDatumRodjenjaPacijenta.Value = selected.DatumRodjenja;
            cmbPol.SelectedIndex = selected.Pol ? 0 : 1;

        }

        public void SacuvajPregled(BindingList<Recept> recepti, DateTimePicker dtpDatumPregleda, TextBox txtSomatski, TextBox txtAnamneza, DataGridView pacijenti)
        {
            if (!fieldsAreValid(new List<TextBox> { txtSomatski, txtAnamneza }))
            {
                MessageBox.Show("Niste uneli sve potrebne podatke", "Greska!");
                return;
            }

            var somatski = txtSomatski.Text;
            var anamneza = txtAnamneza.Text;
            //TODO
            var d = TekuciDoktor;
            var p = pacijenti.CurrentRow.DataBoundItem as Pacijent;

            if (pacijenti.SelectedRows.Count != 1)
            {
                MessageBox.Show("Potrebno je selektovati pacijenta", "Greska!");
                return;
            }

            var pregled = new Pregled { Anamneza = anamneza, SomatskiNalaz = somatski, DatumPregleda = dtpDatumPregleda.Value.Date, Doktor = d, Pacijent = p, Recepti = recepti };

            int rez = komunikacija.ZapamtiPregled(pregled);

            if (rez > 0)
            {
                MessageBox.Show("Sistem je sacuvao pregled i recepte!");
            }
            else
            {
                MessageBox.Show("Sistem nije sacuvao pregled  i recepte", "Greska!");
            }

        }

        public void PretraziPregledePacijenta(DataGridView dgvPacijenti, DataGridView dgvPregledi)
        {

            if (dgvPacijenti.SelectedRows.Count != 1)
            {
                MessageBox.Show("Potrebno je selektovati pacijenta", "Greska!");
                return;
            }

            var p = dgvPacijenti.CurrentRow.DataBoundItem as Pacijent;


            List<Pregled> pregledi = komunikacija.PretraziPregledePacijnta(new Pregled { Doktor = TekuciDoktor, Pacijent = p });
            dgvPregledi.DataSource = pregledi;

        }

        public int ZapamtiPacijenta(TextBox txtImePacijenta, TextBox txtPrezimePacijenta, TextBox txtMaticniBrojPacijenta, TextBox txtAdresaPacijenta, ComboBox cmbPol, DateTimePicker dtpDatumRodjenjaPacijenta)
        {
            var ime = txtImePacijenta.Text;
            var prezime = txtPrezimePacijenta.Text;
            var maticni = txtMaticniBrojPacijenta.Text;
            var adresa = txtAdresaPacijenta.Text;
            var pol = cmbPol.SelectedItem;
            var datumRodjenja = dtpDatumRodjenjaPacijenta.Value.Date;

            if (!fieldsAreValid(new List<TextBox> { txtImePacijenta, txtPrezimePacijenta, txtMaticniBrojPacijenta, txtAdresaPacijenta }))
            {
                MessageBox.Show("Niste uneli sve potrebne podatke", "Greska!");
                return 0;
            }
            else
            {
                bool p = pol.ToString().ToLower() == "muski" ? true : false;

                int rez = komunikacija.Unesi(new Pacijent { Ime = ime, Prezime = prezime, MaticniBroj = maticni, Adresa = adresa, DatumRodjenja = datumRodjenja, Pol = p });

                if (rez > 0)
                {
                    MessageBox.Show("Sistem je sacuvao pacijenta!");
                   
                    return 1;
                }
                else
                {
                    MessageBox.Show("Sistem nije sacuvao pacijenta", "Greska!");
                    return 0;
                }
            }
        }

        public void PretraziPacijente(TextBox txtPretraga, DataGridView dgvPacijenti)
        {
            string txt = txtPretraga.Text;

            List<Pacijent> pacijenti = komunikacija.PretraziPacijente(txt);

            if (pacijenti.Count > 0)
            {
                dgvPacijenti.DataSource = pacijenti;
            }
        }

        public void vratiListuPacijenata(DataGridView dgvPacijenti)
        {
            List<Pacijent> pacijenti = komunikacija.VratiSvePacijente();

            dgvPacijenti.DataSource = pacijenti;
        }

        public void VratiListuDijagnoza(ComboBox cmbDijagnoza)
        {
           dijagnoze = komunikacija.VratiSveDijagnoze();
           cmbDijagnoza.DataSource = dijagnoze;
           
        }

        public void VratiListuLekova(ComboBox cmbLek)
        {
            lekovi = komunikacija.VratiSveLekove();
            cmbLek.DataSource = lekovi;
        }

        public void PretraziLekove(TextBox txtPretragaLeka, DataGridView dgvLekovi)
        {
            string txt = txtPretragaLeka.Text;

            List<Lek> lekovi = komunikacija.PretraziLekove(txt);

            if (lekovi.Count > 0)
            {
                dgvLekovi.DataSource = lekovi;
            }

        }

        public int ZapamtiDoktora(TextBox txtIme, TextBox txtPrezime, TextBox txtEmail, TextBox txtPassword, DateTimePicker dtpDatumRodjenja)
        {
            var email = txtEmail.Text;
            var pwd = txtPassword.Text;
            var ime = txtIme.Text;
            var prezime = txtPrezime.Text;
            var datumRodj = dtpDatumRodjenja.Value.Date;

            if (String.IsNullOrEmpty(email) || String.IsNullOrEmpty(pwd) || String.IsNullOrEmpty(ime) || String.IsNullOrEmpty(prezime))
            {
                MessageBox.Show("Niste uneli sve potrebne podatke", "Greska!");
                return 0;
            }
            else
            {
                int rez = komunikacija.Unesi(new Doktor { Email = email, Password = pwd, Ime = ime, Prezime = prezime, DatumRodjenja = datumRodj });

                if (rez > 0)
                {
                    MessageBox.Show("Sistem je uspesno zapamtio vas podatke!");
                    return 1;
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da zapamti doktora", "Greska!");
                    return 0;
                }
            }

        }

        public int LoginDoktora(TextBox txtEmail, TextBox txtPassword)
        {
            var email = txtEmail.Text;
            var pwd = txtPassword.Text;



            if (String.IsNullOrEmpty(email) || String.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Niste uneli sve potrebne podatke", "Greska!");
                return 0;
            }
            else
            {
                Doktor doc = komunikacija.ZapamtiDoktora(new Doktor { Email = email, Password = pwd });

                if (doc != null)
                {
                    MessageBox.Show("Uspesno ste se prijavili na sistem.");
                    tekuciDoktor = doc;
                    return 1;
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da pronadje zaposlenog na osnovu unetih vrednosti", "Greska!");
                    return 0;
                }
            }


        }

        //public void ObrisiLek(DataGridView dgvRezultati, TextBox kriterijum)
        public void ObrisiLek(TextBox pretraga, DataGridView dgvLekovi)
        {
            DialogResult dr = MessageBox.Show("Da li ste sigurni da zelite da obrisete lek?", "Alert!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

                Lek lek = dgvLekovi.CurrentRow.DataBoundItem as Lek;

                int rezultat = komunikacija.ObrisiLek(lek);
                if (rezultat > 0)
                {

                    MessageBox.Show("Sistem je obrisao lek");
                    PretraziLekove(pretraga, dgvLekovi);
                }
                else
                {
                    MessageBox.Show("Sistem ne moze da obrise automobil");
                }
            }
            else if (dr == DialogResult.Cancel) { }
        }

        public bool fieldsAreValid(List<TextBox> args)
        {
            foreach (var a in args)
            {
                if (String.IsNullOrEmpty(a.Text))
                {
                    return false;
                }
            }

            return true;
        }

        public bool cmbFieldsAreValid(List<ComboBox> args)
        {
            foreach (var a in args)
            {
                if (a.SelectedIndex == -1)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
