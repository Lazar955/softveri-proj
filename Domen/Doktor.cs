using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Doktor : IOpstiDomenskiObjekat
    {
        public int DoktorID { get; set; }
        public string Ime { get; set; }
        public string Email { get; set; }
        public string Prezime { get; set; }
        public string Password { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public bool Ulogovan { get; set; }

        public string VratiImeTabele()
        {
            return "Doktor";
        }

        public string VratiKljucniAtribut()
        {
            throw new NotImplementedException("1");
        }

        public string VratiKoloneZaInsert()
        {
            return $"(Ime,Prezime,[Email],[Password], DatumRodjenja)";

        }

        public List<IOpstiDomenskiObjekat> VratiListu(OleDbDataReader citac)
        {
            throw new NotImplementedException("12");
        }

        public string VratiNazivKljucnogAtributa()
        {
            throw new NotImplementedException("13");
        }

        public IOpstiDomenskiObjekat VratiObjekat(OleDbDataReader citac)
        {
            Doktor doc = null;
            if (citac.Read())
            {
                doc = new Doktor();
                doc.DoktorID = citac.GetInt32(0);
                doc.Ime = citac.GetString(1);
                doc.Prezime = citac.GetString(2);
                doc.Email = citac.GetString(3);
                doc.Password = citac.GetString(4);
                doc.DatumRodjenja = citac.GetDateTime(5);
            }
            return doc;
        }

        public string VratiUslovZaObjekat()
        {
            if (DoktorID !=0)
            {
                return $"DoktorID= '{DoktorID}'";
            }

            return $"Email='{Email}' AND Password='{Password}'";
        }

        public string VratiVrednostiZaAzuriranje()
        {
            throw new NotImplementedException("153");
        }

        public string VratiVrednostiZaInsert()
        {
            //return $"('{Ime}','{Prezime}','{Email}','{Password}')";
            return $"('{Ime}','{Prezime}','{Email}','{Password}','{DatumRodjenja.ToShortDateString()}')";
        }
    }
}
