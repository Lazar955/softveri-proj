using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Lek
    {
        public int LekID { get; set; }
        public string Ime { get; set; }
        public string Opis { get; set; }
        public string Doza { get; set; }
        public string Oblik { get; set; }
        public string INM { get; set; }
        public string Proizvodjac { get; set; }
    }
}
