using Domen;
using System;
using System.Collections.Generic;
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
        List<Doktor> ulogovaniDoktori;

        public Doktor TekuciDoktor
        {
            get { return tekuciDoktor; }
            set { tekuciDoktor = value; }
        }

        public KKInterfejs()
        {
            komunikacija = new Komunikacija();
            komunikacija.PoveziSeSaServerom();
            ulogovaniDoktori = new List<Doktor>();
        }

        public int ZapamtiLek(TextBox txtIme, TextBox txtDoza, TextBox txtINM, TextBox txtOblik, TextBox txtOpis, TextBox txtProizvodjac)
        {
            var ime = txtIme.Text;
            var doza = txtDoza.Text;
            var INM = txtINM.Text;
            var oblik = txtOblik.Text;
            var opis = txtOpis.Text;
            var proizvodjac = txtProizvodjac.Text;

            if(!fieldsAreValid(new List<TextBox> { txtIme,txtDoza,txtINM, txtOblik, txtOpis, txtProizvodjac }))
            {
                MessageBox.Show("Niste uneli sve potrebne podatke", "Greska!");
                return 0;
            }
            else
            {
                int rez = komunikacija.Unesi(new Lek { Ime = ime, Doza = doza, INM = INM, Oblik = oblik, Opis = opis, Proizvodjac = proizvodjac});

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

    

        public void PretraziLekove(TextBox txtPretragaLeka, DataGridView dgvLekovi)
        {
            string txt = txtPretragaLeka.Text;

            List<Lek> lekovi = komunikacija.PretraziLekove(txt);

            if (lekovi.Count > 0 )
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



            if ( String.IsNullOrEmpty(email) || String.IsNullOrEmpty(pwd))
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
                    ulogovaniDoktori.Add(doc);
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
        public void ObrisiLek(TextBox pretraga,DataGridView dgvLekovi)
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
    }
}
