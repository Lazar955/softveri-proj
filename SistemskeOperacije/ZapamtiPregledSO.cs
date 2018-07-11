using Domen;
using Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class ZapamtiPregledSO : OpsteSO
    {
        public override object Izvrsi(IOpstiDomenskiObjekat odo, Broker broker)
        {
            try
            {
                Pregled p = (Pregled)odo;
                int id = Convert.ToInt32(broker.UnesiIVratiID(odo));

                foreach (Recept r in p.Recepti)
                {
                    r.Pregled = p;
                    r.Pregled.PregledID = id;

                    broker.Unesi(r);
                }
                return true;
            }
            catch (Exception e)
            {
                throw e;
                return false;
            }
        }
    }
}
