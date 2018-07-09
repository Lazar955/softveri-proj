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
            ObrisiLek obrisi = new ObrisiLek();
            return Convert.ToInt32(obrisi.IzvrsiSO(lek));
        }
    }
}
