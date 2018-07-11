using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Dijagnoza : IOpstiDomenskiObjekat
    {
        public int DijagnozaID { get; set; }
        public string SifraDijagnoze { get; set; }
        public string Opis { get; set; }

        public override string ToString()
        {
            return $"{SifraDijagnoze}, {Opis}";
        }

        public string VratiImeTabele()
        {
            return "Dijagnoza";
        }

        public string VratiKljucniAtribut()
        {
            throw new NotImplementedException();
        }

        public string VratiKoloneZaInsert()
        {
            throw new NotImplementedException();
        }

        public List<IOpstiDomenskiObjekat> VratiListu(OleDbDataReader citac)
        {
            List<IOpstiDomenskiObjekat> dijagnoze = new List<IOpstiDomenskiObjekat>();
            while (citac.Read())
            {
                var d = new Dijagnoza();

                d.DijagnozaID = citac.GetInt32(0);
                d.SifraDijagnoze = citac.GetString(1);
                d.Opis = citac.GetString(2);

                dijagnoze.Add(d);
            }
            return dijagnoze;
        }

        public string VratiNazivKljucnogAtributa()
        {
            throw new NotImplementedException();
        }

        public IOpstiDomenskiObjekat VratiObjekat(OleDbDataReader citac)
        {
            throw new NotImplementedException();
        }

        public string VratiUslovZaObjekat()
        {
            throw new NotImplementedException();
        }

        public string VratiVrednostiZaAzuriranje()
        {
            throw new NotImplementedException();
        }

        public string VratiVrednostiZaInsert()
        {
            throw new NotImplementedException();
        }
    }
}
