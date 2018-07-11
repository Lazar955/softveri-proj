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
    public class Pregled : IOpstiDomenskiObjekat
    {
        [Browsable(false)]
        public int PregledID { get; set; }
        [Browsable(false)]
        public Doktor Doktor { get; set; }
        [Browsable(false)]
        public Pacijent Pacijent { get; set; }
        public DateTime DatumPregleda { get; set; }
        public string Anamneza { get; set; }
        public string SomatskiNalaz { get; set; }

        public BindingList<Recept> Recepti { get; set; }

        public string VratiImeTabele()
        {
            return "Pregled";
        }

        public string VratiKljucniAtribut()
        {
            throw new NotImplementedException();
        }

        public string VratiKoloneZaInsert()
        {
            return $"(DoktorID,PacijentID,DatumPregleda,Anamneza,SomatskiNalaz)";
        }

        public List<IOpstiDomenskiObjekat> VratiListu(OleDbDataReader citac)
        {
            List<IOpstiDomenskiObjekat> pregledi = new List<IOpstiDomenskiObjekat>();
            while (citac.Read())
            {
                var pregled = new Pregled();

                pregled.PregledID = citac.GetInt32(0);
                pregled.Doktor = new Doktor
                {
                    DoktorID = citac.GetInt32(1)
                };
                pregled.Pacijent = new Pacijent { PacijentID = citac.GetInt32(2) };
                pregled.DatumPregleda = citac.GetDateTime(3);
                pregled.Anamneza = citac.GetString(4);
                pregled.SomatskiNalaz = citac.GetString(5);

                pregledi.Add(pregled);
            }
            return pregledi;
        }

        public string VratiNazivKljucnogAtributa()
        {
            return "PregledID";
        }

        public IOpstiDomenskiObjekat VratiObjekat(OleDbDataReader citac)
        {
            throw new NotImplementedException();
        }

        public string VratiUslovZaObjekat()
        {
            return $"PacijentID={Pacijent.PacijentID} AND DoktorID={Doktor.DoktorID}";
        }

        public string VratiVrednostiZaAzuriranje()
        {
            throw new NotImplementedException();
        }

        public string VratiVrednostiZaInsert()
        {
            return $"('{Doktor.DoktorID}','{Pacijent.PacijentID}','{DatumPregleda.ToShortDateString()}','{Anamneza}','{SomatskiNalaz}')";
        }
    }
}
