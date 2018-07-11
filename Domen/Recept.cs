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
    public class Recept:IOpstiDomenskiObjekat
    {
        [Browsable(false)]
        public int ReceptID { get; set; }
        
        public Lek Lek { get; set; }
     
        public Dijagnoza Dijagnoza { get; set; }
        [Browsable(false)]
        public Pregled Pregled { get; set; }
        public string Koriscenje { get; set; }

        public string VratiImeTabele()
        {
            return "Recept";
        }

        public string VratiKljucniAtribut()
        {
            return $"ReceptID={ReceptID}";
        }

        public string VratiKoloneZaInsert()
        {
            return $"(LekID,DijagnozaID,PregledID,Koriscenje)";
        }

        public List<IOpstiDomenskiObjekat> VratiListu(OleDbDataReader citac)
        {
            List<IOpstiDomenskiObjekat> recepti = new List<IOpstiDomenskiObjekat>();
            while (citac.Read())
            {
                var r = new Recept();

                r.ReceptID = citac.GetInt32(0);
                r.Lek = new Lek { LekID = citac.GetInt32(1) };
                r.Dijagnoza = new Dijagnoza { DijagnozaID = citac.GetInt32(2) };
                r.Pregled = new Pregled { PregledID = citac.GetInt32(3) };
                r.Koriscenje = citac.GetString(4);

                recepti.Add(r);
            }
            return recepti;
        }

        public string VratiNazivKljucnogAtributa()
        {
            return "ReceptID";
        }

        public IOpstiDomenskiObjekat VratiObjekat(OleDbDataReader citac)
        {
            throw new NotImplementedException();
        }

        public string VratiUslovZaObjekat()
        {
            return $"PregledID={Pregled.PregledID}";
        }

        public string VratiVrednostiZaAzuriranje()
        {
            throw new NotImplementedException();
        }

        public string VratiVrednostiZaInsert()
        {
            return $"('{Lek.LekID}','{Dijagnoza.DijagnozaID}','{Pregled.PregledID}','{Koriscenje}')";
        }
    }
}
