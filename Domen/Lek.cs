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
    public class Lek : IOpstiDomenskiObjekat
    {
        [Browsable(false)]
        public int LekID { get; set; }
        public string Ime { get; set; }
        public string Opis { get; set; }
        public string Doza { get; set; }
        public string Oblik { get; set; }
        public string INM { get; set; }
        public string Proizvodjac { get; set; }


        public override string ToString()
        {
            return $"{Ime}, {Doza}, {Oblik}";
        }

        public string VratiImeTabele()
        {
            return "Lek" ;
        }

        public string VratiKljucniAtribut()
        {
            return "LekID="+ LekID;
        }

        public string VratiKoloneZaInsert()
        {
            return $"(Ime,Opis,Oblik,[Doza],[INM], Proizvodjac)";
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
            var lek = new Lek();
            if (citac.Read())
            {
                lek.LekID = citac.GetInt32(0);
                lek.Ime = citac.GetString(1);
                lek.Opis = citac.GetString(2);
                lek.Doza = citac.GetString(3);
                lek.Oblik = citac.GetString(4);
                lek.INM = citac.GetString(5);
                lek.Proizvodjac = citac.GetString(5);
            }
            return lek;
        }

        public string VratiUslovZaObjekat()
        {
            //return $"((Lek.Ime='{Ime}')";
            return $" Ime LIKE '%{Ime}%'";
        }

        public string VratiVrednostiZaAzuriranje()
        {
            throw new NotImplementedException();
        }

        public string VratiVrednostiZaInsert()
        {
            return $"('{Ime}','{Opis}','{Oblik}','{Doza}','{INM}','{Proizvodjac}')";
        }
    }
}
