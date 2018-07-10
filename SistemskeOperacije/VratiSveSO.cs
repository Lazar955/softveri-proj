using Domen;
using Sesija;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemskeOperacije
{
    public class VratiSveSO : OpsteSO
    {
        public override object Izvrsi(IOpstiDomenskiObjekat odo, Broker broker)
        {
            return broker.VratiSveObjekte(odo);
        }
    }
}
