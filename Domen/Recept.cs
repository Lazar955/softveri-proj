using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Recept
    {
        public int ReceptID { get; set; }
        public Lek Lek { get; set; }
        public Dijagnoza Dijagnoza { get; set; }
        public Pregled Pregled { get; set; }
        public string Koriscenje { get; set; }
    }
}
