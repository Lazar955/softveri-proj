using Domen;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace Sesija
{
    public class Broker
    {
        OleDbCommand komanda;
        OleDbConnection konekcija;
        OleDbTransaction transakcija;

        void konektujSe()
        {
            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\lazar\source\repos\Softveri\Baza.accdb";
            konekcija = new OleDbConnection(@connString);
            komanda = konekcija.CreateCommand();
        }

        Broker()
        {
            konektujSe();
        }

        public void otvoriKonekciju()
        {
            try
            {
                konekcija.Open();
            }
            catch (Exception)
            {
                throw new Exception("Greska pri otvarnaju baze!");
            }
        }

        public void zatvoriKonekciju()
        {
            try
            {
                konekcija.Close();
            }
            catch (Exception)
            {
                throw new Exception("Greska pri zatvaranju konekcije!");
            }
        }

        public void zapocniTransakciju()
        {
            try
            {
                transakcija = konekcija.BeginTransaction();
            }
            catch (Exception)
            {
                throw new Exception("Greska pri zatvaranju konekcije!");
            }
        }

        public void potvrdiTransakciju()
        {
            try
            {
                transakcija.Commit();
            }
            catch (Exception)
            {
                throw new Exception("Greska pri zatvaranju konekcije!");
            }
        }

        public void ponistiTransakciju()
        {
            try
            {
                transakcija.Rollback();
            }
            catch (Exception)
            {
                throw new Exception("Greska pri zatvaranju konekcije!");
            }
        }


        public static Broker instanca;
        public static Broker dajSesiju()
        {
            if (instanca == null) instanca = new Broker();
            return instanca;
        }


        public bool Unesi(IOpstiDomenskiObjekat odo)
        {
            try
            {
                // string upit = "INSERT INTO " + odo.VratiImeTabele() + " VALUES " + odo.VratiVrednostiZaInsert();
                string upit = $"Insert into {odo.VratiImeTabele()} {odo.VratiKoloneZaInsert()} values {odo.VratiVrednostiZaInsert()}";
                komanda = new OleDbCommand(upit, konekcija, transakcija);
                komanda.ExecuteNonQuery();
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }

        public object UnesiIVratiID(IOpstiDomenskiObjekat odo)
        {
            string upit = $"Insert into {odo.VratiImeTabele()} {odo.VratiKoloneZaInsert()} values {odo.VratiVrednostiZaInsert()}";
            komanda = new OleDbCommand(upit, konekcija, transakcija);

            int rezultat = komanda.ExecuteNonQuery();
            if (rezultat == 1)
            {
                komanda.CommandText = "SELECT @@IDENTITY";
                object id = komanda.ExecuteScalar();
                return id;
            }
            else
            {
                throw new Exception();
            }
        }


        public List<IOpstiDomenskiObjekat> VratiSveObjekte(IOpstiDomenskiObjekat odo)
        {
            try
            {
                string upit = "SELECT * FROM " + odo.VratiImeTabele();
                komanda = new OleDbCommand(upit, konekcija, transakcija);
                OleDbDataReader citac = komanda.ExecuteReader();

                return odo.VratiListu(citac);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int vratiMaxID(IOpstiDomenskiObjekat odo)
        {
            try
            {
                string upit = "Select Max(" + odo.VratiNazivKljucnogAtributa() + ") as MaxBroj from " + odo.VratiImeTabele();
                komanda = new OleDbCommand(upit, konekcija, transakcija);
                OleDbDataReader citac = komanda.ExecuteReader();

                if (citac.Read())
                {
                    try
                    {
                        int rezultat = Convert.ToInt32(citac["MaxBroj"]);
                        return rezultat + 1;
                    }
                    catch
                    {
                    }
                }
                return 1;
            }
            catch (Exception ex)
            {
                throw ex;
                // return 1;
            }
        }

        public IOpstiDomenskiObjekat VratiObjekatPoUslovu(IOpstiDomenskiObjekat odo)
        {
            try
            {
                string upit = "SELECT * FROM " + odo.VratiImeTabele() + " WHERE " + odo.VratiUslovZaObjekat();
                komanda = new OleDbCommand(upit, konekcija, transakcija);
                OleDbDataReader citac = komanda.ExecuteReader();

                return odo.VratiObjekat(citac);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<IOpstiDomenskiObjekat> VratiSveObjektePoUslovu(IOpstiDomenskiObjekat odo)
        {
            try
            {
                string upit = "SELECT * FROM " + odo.VratiImeTabele() + " WHERE " + odo.VratiUslovZaObjekat();
                komanda = new OleDbCommand(upit, konekcija, transakcija);
                OleDbDataReader citac = komanda.ExecuteReader();

                return odo.VratiListu(citac);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool Obrisi(IOpstiDomenskiObjekat odo)
        {
            try
            {

                string upit = "DELETE FROM " + odo.VratiImeTabele() + " WHERE " + odo.VratiKljucniAtribut();
                komanda = new OleDbCommand(upit, konekcija, transakcija);
                komanda.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool Azuriraj(IOpstiDomenskiObjekat odo)
        {
            try
            {
                string upit = "UPDATE " + odo.VratiImeTabele() + " SET " + odo.VratiVrednostiZaAzuriranje() + " WHERE " + odo.VratiKljucniAtribut();
                OleDbCommand komanda = new OleDbCommand(upit, konekcija, transakcija);
                komanda.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }


    }
}
