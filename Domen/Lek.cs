using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Lek : IOpstiDomenskiObjekat
    {
        public int LekID { get; set; }
        public string Ime { get; set; }
        public string Opis { get; set; }
        public string Doza { get; set; }
        public string Oblik { get; set; }
        public string INM { get; set; }
        public string Proizvodjac { get; set; }

        public string VratiImeTabele()
        {
            return "lek" ;
        }

        public string VratiKljucniAtribut()
        {
            return "LekID="+ LekID;
        }

        public string VratiKoloneZaInsert()
        {
            throw new NotImplementedException();
        }

        public List<IOpstiDomenskiObjekat> VratiListu(OleDbDataReader citac)
        {
            List<IOpstiDomenskiObjekat> lekovi = new List<IOpstiDomenskiObjekat>();
            while (citac.Read())
            {
                var lek = new Lek();

                lek.LekID = citac.GetInt32(0);
                lek.Ime = citac.GetString(1);
                lek.Opis = citac.GetString(2);
                lek.Doza = citac.GetString(3);
                lek.Oblik = citac.GetString(4);
                lek.INM = citac.GetString(5);
                lek.Proizvodjac = citac.GetString(5);

                lekovi.Add(lek);
            }
            return lekovi;
        }

        public string VratiNazivKljucnogAtributa()
        {
            return "LekID";
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
