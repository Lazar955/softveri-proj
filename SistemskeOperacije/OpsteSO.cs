using Domen;
using Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public abstract class OpsteSO
    {
        List<IOpstiDomenskiObjekat> lista;

        public List<IOpstiDomenskiObjekat> Lista
        {
            get { return lista; }
            set { lista = value; }
        }

        Broker broker;

        public OpsteSO()
        {
            broker = Broker.dajSesiju();
        }


        public object IzvrsiSO(IOpstiDomenskiObjekat odo)
        {
            object rezultat = null;

            broker.otvoriKonekciju();
            broker.zapocniTransakciju();

            try
            {
                rezultat = Izvrsi(odo, broker);
                broker.potvrdiTransakciju();
            }
            catch (Exception ex)
            {
                broker.ponistiTransakciju();
                throw ex;
            }
            finally
            {
                broker.zatvoriKonekciju();
            }

            return rezultat;
        }

        public virtual object Izvrsi(IOpstiDomenskiObjekat odo, Broker broker)
        {
            return null;
        }


    }
}
