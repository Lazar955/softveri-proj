using Domen;
using KontrolerAplikacioneLogike;
using System;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace ServerForma
{
    public class Obrada
    {
        private NetworkStream tok;
        BinaryFormatter formater;
        KontrolerAL kal;

        public Obrada(NetworkStream tok)
        {
            this.tok = tok;
            formater = new BinaryFormatter();
            kal = new KontrolerAL();

            ThreadStart ts = obradi;
            Thread nit = new Thread(ts);
            nit.Start();
        }

        private void obradi()
        {
            int operacija = 0; try
            {
                while (operacija != (int)Operacije.kraj)
                {
                    TransferKlasa transfer = formater.Deserialize(tok) as TransferKlasa;
                    switch (transfer.Operacija)
                    {

                        case Operacije.LoginDoktora:
                            transfer.TransferObjekat = kal.LoginDoktora(transfer.TransferObjekat as Doktor);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.kraj:
                            operacija = 1;
                            break;
                        case Operacije.Unesi:
                            transfer.TransferObjekat = kal.Unesi(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception e)
            {

                throw e;
            }

        }
    }
}