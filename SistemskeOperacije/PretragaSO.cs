using Domen;
using Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class PretragaSO : OpsteSO
    {
        public override object Izvrsi(IOpstiDomenskiObjekat odo, Broker broker)
        {
            return broker.VratiSveObjektePoUslovu(odo);
        }
    }
}
