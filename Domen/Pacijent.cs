using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Pacijent : IOpstiDomenskiObjekat
    {
        [Browsable(false)]
        public int PacijentID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        [Browsable(false)]
        public string MaticniBroj { get; set; }
        [Browsable(false)]
        public bool Pol { get; set; }
        [Browsable(false)]
        public string Adresa { get; set; }
        [Browsable(false)]
        public DateTime DatumRodjenja { get; set; }

        public string VratiImeTabele()
        {
           return "Pacijent";
        }

        public string VratiKljucniAtribut()
        {
            return "PacijentID=" + PacijentID;
        }

        public string VratiKoloneZaInsert()
        {
            return $"(Ime,Prezime,MaticniBroj,[Pol],[Adresa], DatumRodjenja)";
        }

        public List<IOpstiDomenskiObjekat> VratiListu(OleDbDataReader citac)
        {
            List<IOpstiDomenskiObjekat> pacijenti = new List<IOpstiDomenskiObjekat>();
            while (citac.Read())
            {
                var pacijent = new Pacijent();

                pacijent.PacijentID = citac.GetInt32(0);
                pacijent.Ime = citac.GetString(1);
                pacijent.Prezime = citac.GetString(2);
                pacijent.MaticniBroj = citac.GetString(3);
                pacijent.Pol = citac.GetBoolean(4);
                pacijent.Adresa = citac.GetString(5);
                pacijent.DatumRodjenja = citac.GetDateTime(6);

                pacijenti.Add(pacijent);
            }
            return pacijenti;
        }

        public string VratiNazivKljucnogAtributa()
        {
            return "PacijentID";
        }

        public IOpstiDomenskiObjekat VratiObjekat(OleDbDataReader citac)
        {
            var pacijent = new Pacijent();
            if (citac.Read())
            {
                pacijent.PacijentID = citac.GetInt32(0);
                pacijent.Ime = citac.GetString(1);
                pacijent.Prezime = citac.GetString(2);
                pacijent.MaticniBroj = citac.GetString(3);
                pacijent.Pol = citac.GetBoolean(4);
                pacijent.Adresa = citac.GetString(5);
                pacijent.DatumRodjenja = citac.GetDateTime(5);
            }
            return pacijent;
        }

        public string VratiUslovZaObjekat()
        {
            return $" Ime LIKE '%{Ime}%'";
        }

        public string VratiVrednostiZaAzuriranje()
        {
            return $"Ime='{Ime}', Prezime='{Prezime}', MaticniBroj='{MaticniBroj}',Pol={Pol}, Adresa='{Adresa}',DatumRodjenja='{DatumRodjenja.ToShortDateString()}'";
        }

        public string VratiVrednostiZaInsert()
        {
            return $"('{Ime}','{Prezime}','{MaticniBroj}',{Pol}, '{Adresa}','{DatumRodjenja.ToShortDateString()}')";
        }
    }
}
