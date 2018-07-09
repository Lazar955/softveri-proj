using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Pacijent
    {
        public int PacijentID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string MaticniBroj { get; set; }
        public bool Pol { get; set; }
        public string Adresa { get; set; }
        public DateTime DatumRodjenja { get; set; }
    }
}
