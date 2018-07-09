using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Pregled
    {
        public int PregledID { get; set; }
        public Doktor Doktor { get; set; }
        public Pacijent Pacijent { get; set; }
        public DateTime DatumPregleda { get; set; }
        public string Anamneza { get; set; }
        public string SomatskiNalaz { get; set; }
    }
}
