using System;
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
    }
}