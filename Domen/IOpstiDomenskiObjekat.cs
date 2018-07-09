using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public interface IOpstiDomenskiObjekat
    {
        string VratiImeTabele();
        string VratiVrednostiZaInsert();
        string VratiKoloneZaInsert();
        string VratiVrednostiZaAzuriranje();
        string VratiKljucniAtribut();
        string VratiNazivKljucnogAtributa();
        string VratiUslovZaObjekat();
        IOpstiDomenskiObjekat VratiObjekat(OleDbDataReader citac);
        List<IOpstiDomenskiObjekat> VratiListu(OleDbDataReader citac);
    }
}
