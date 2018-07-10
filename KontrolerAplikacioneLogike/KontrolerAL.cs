using Domen;
using SistemskeOperacije;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KontrolerAplikacioneLogike
{
    public class KontrolerAL
    {
        public Doktor LoginDoktora(Doktor doktor)
        {
            var login = new LoginDoktoraSO();
            var doc = login.IzvrsiSO(doktor) as Doktor;
            return doc;
        }

        public object Unesi(IOpstiDomenskiObjekat odo)
        {
            UnesiSO unesi = new UnesiSO();
            return Convert.ToInt32(unesi.IzvrsiSO(odo));
        }

        public int ObrisiLek(Lek lek)
        {
            ObrisiLekSO obrisi = new ObrisiLekSO();
            return Convert.ToInt32(obrisi.IzvrsiSO(lek));
        }

        public List<Dijagnoza> VratiListuDijagnoza()
        {
            var vratiDijagnoze = new VratiSveSO();

            List<IOpstiDomenskiObjekat> tmp = vratiDijagnoze.IzvrsiSO(new Dijagnoza()) as List<IOpstiDomenskiObjekat>;

            List<Dijagnoza> dijagnoze = new List<Dijagnoza>();

            foreach (Dijagnoza d in tmp)
            {
                dijagnoze.Add(d);
            }

            return dijagnoze;
        }

        public List<Lek> PretraziLekove(string kriterijum)
        {
            var tmpLek = new Lek { Ime = kriterijum };
            var pretraga = new PretragaSO();

            List<IOpstiDomenskiObjekat> tmpList = pretraga.IzvrsiSO(tmpLek) as List<IOpstiDomenskiObjekat>;
            List<Lek> lekovi = new List<Lek>();

            foreach (Lek lek in tmpList)
            {
                lekovi.Add(lek);
            }

            return lekovi;
        }
    }
}
