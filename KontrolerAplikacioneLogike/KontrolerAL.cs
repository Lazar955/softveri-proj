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

        public object ZapamtiPregled(IOpstiDomenskiObjekat odo)
        {
            ZapamtiPregledSO unesi = new ZapamtiPregledSO();
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

        public List<Pacijent> VratiListuPacijenata()
        {
            var vratiPacijente = new VratiSveSO();

            List<IOpstiDomenskiObjekat> tmp = vratiPacijente.IzvrsiSO(new Pacijent()) as List<IOpstiDomenskiObjekat>;

            List<Pacijent> pacijenti = new List<Pacijent>();

            foreach (Pacijent d in tmp)
            {
                pacijenti.Add(d);
            }

            return pacijenti;
        }


        public List<Lek> VratiListuLekova()
        {
            var vratiLekove = new VratiSveSO();

            List<IOpstiDomenskiObjekat> tmp = vratiLekove.IzvrsiSO(new Lek()) as List<IOpstiDomenskiObjekat>;

            List<Lek> lekovi = new List<Lek>();

            foreach (Lek d in tmp)
            {
                lekovi.Add(d);
            }

            return lekovi;
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

        public List<Pacijent> PretraziPacijente(string kriterijum)
        {
            var tmpPacijent = new Pacijent { Ime = kriterijum };
            var pretraga = new PretragaSO();

            List<IOpstiDomenskiObjekat> tmpList = pretraga.IzvrsiSO(tmpPacijent) as List<IOpstiDomenskiObjekat>;
            List<Pacijent> pacijenti = new List<Pacijent>();

            foreach (Pacijent p in tmpList)
            {
                pacijenti.Add(p);
            }

            return pacijenti;
        }

        public List<Pregled> PretraziPreglede(IOpstiDomenskiObjekat opstiDomenskiObjekat)
        {
            var tmpPregled = (Pregled)opstiDomenskiObjekat;
            var pretraga = new PretragaSO();

            List<IOpstiDomenskiObjekat> tmpList = pretraga.IzvrsiSO(tmpPregled) as List<IOpstiDomenskiObjekat>;
            List<Pregled> pregledi = new List<Pregled>();

            foreach (Pregled p in tmpList)
            {
                pregledi.Add(p);
            }

            return pregledi;
        }

        public List<Recept> PretraziRecepte(IOpstiDomenskiObjekat opstiDomenskiObjekat)
        {
            var tmpRecept = (Recept)opstiDomenskiObjekat;
            var pretraga = new PretragaSO();

            List<IOpstiDomenskiObjekat> tmpList = pretraga.IzvrsiSO(tmpRecept) as List<IOpstiDomenskiObjekat>;
            List<Recept> recepti = new List<Recept>();

            foreach (Recept r in tmpList)
            {
                recepti.Add(r);
            }

            return recepti;
        }
    }
}
