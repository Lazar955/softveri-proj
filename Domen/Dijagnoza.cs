using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Dijagnoza 
    {
        public int DijagnozaID { get; set; }
        public string SifraDijagnoze { get; set; }
        public string Opis { get; set; }
    }
}
