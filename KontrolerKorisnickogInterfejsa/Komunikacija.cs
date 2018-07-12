using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using Domen;

namespace KontrolerKorisnickogInterfejsa
{
    public class Komunikacija
    {
        TcpClient klijent;
        NetworkStream tok;
        BinaryFormatter formater;

        public bool PoveziSeSaServerom()
        {
            try
            {
                klijent = new TcpClient("127.0.0.1", 50000);
                tok = klijent.GetStream();
                formater = new BinaryFormatter();

                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }

        public int Unesi(IOpstiDomenskiObjekat odo)
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.TransferObjekat = odo;
                transfer.Operacija = Operacije.Unesi;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                return (int)transfer.TransferObjekat;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int ZapamtiPregled(IOpstiDomenskiObjekat odo)
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.TransferObjekat = odo;
                transfer.Operacija = Operacije.ZapamtiPregled;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                return (int)transfer.TransferObjekat;
            }
            catch (Exception)
            {

                throw;
            }
        }

        

        public Doktor ZapamtiDoktora(Doktor doc)
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.TransferObjekat = doc;
                transfer.Operacija = Operacije.LoginDoktora;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                return transfer.TransferObjekat as Doktor;
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal void prekiniKonekciju()
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.TransferObjekat = null;
                transfer.Operacija = Operacije.kraj;
                formater.Serialize(tok, transfer);

                //transfer = formater.Deserialize(tok) as TransferKlasa;
                //return transfer.TransferObjekat as List<Recept>;
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal List<Recept> PretraziRecepte(Recept r)
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.TransferObjekat = r;
                transfer.Operacija = Operacije.PretraziRecepte;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                return transfer.TransferObjekat as List<Recept>;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int ObrisiLek(Lek lek)
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.TransferObjekat = lek;
                transfer.Operacija = Operacije.ObrisiLek;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                return (int)transfer.TransferObjekat;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int AzurirajPacijenta(Pacijent pacijent)
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.TransferObjekat = pacijent;
                transfer.Operacija = Operacije.AzurirajPacijenta;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                return (int)transfer.TransferObjekat;
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal List<Pacijent> PretraziPacijente(string kriterijum)
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.TransferObjekat = kriterijum;
                transfer.Operacija = Operacije.PretraziPacijente;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                return transfer.TransferObjekat as List<Pacijent>;
            }
            catch (Exception)
            {
                throw;
            }
        }

        internal List<Pacijent> VratiSvePacijente()
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.Operacija = Operacije.VratiSvePacijente;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                return transfer.TransferObjekat as List<Pacijent>;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Lek> PretraziLekove(String kriterijum)
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.TransferObjekat = kriterijum;
                transfer.Operacija = Operacije.PretraziLekove;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                return transfer.TransferObjekat as List<Lek>;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public List<Lek> VratiSveLekove()
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.Operacija = Operacije.VratiSveLekove;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                return transfer.TransferObjekat as List<Lek>;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Pregled> PretraziPregledePacijnta(Pregled pregled)
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.TransferObjekat = pregled;
                transfer.Operacija = Operacije.PretraziPregledePacijenta;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                return transfer.TransferObjekat as List<Pregled>;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Dijagnoza> VratiSveDijagnoze()
        {
            try
            {
                TransferKlasa transfer = new TransferKlasa();
                transfer.Operacija = Operacije.VratiSveDijagnoze;
                formater.Serialize(tok, transfer);

                transfer = formater.Deserialize(tok) as TransferKlasa;
                return transfer.TransferObjekat as List<Dijagnoza>;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}