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
        private Socket klijentSoket;

        public Obrada(NetworkStream tok,Socket klijent)
        {
            this.tok = tok;
            formater = new BinaryFormatter();
            kal = new KontrolerAL();
            klijentSoket = klijent;

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
                            klijentSoket.Shutdown(SocketShutdown.Both);
                            klijentSoket.Close();
                            break;
                        case Operacije.Unesi:
                            transfer.TransferObjekat = kal.Unesi(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ObrisiLek:
                            transfer.TransferObjekat = kal.ObrisiLek(transfer.TransferObjekat as Lek);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.VratiSveLekove:
                            transfer.TransferObjekat = kal.VratiListuLekova();
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.VratiSveDijagnoze:
                            transfer.TransferObjekat = kal.VratiListuDijagnoza();
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.VratiSvePacijente:
                            transfer.TransferObjekat = kal.VratiListuPacijenata();
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.PretraziLekove:
                            transfer.TransferObjekat = kal.PretraziLekove(transfer.TransferObjekat as String);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.PretraziPacijente:
                            transfer.TransferObjekat = kal.PretraziPacijente(transfer.TransferObjekat as String);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.ZapamtiPregled:
                            transfer.TransferObjekat = kal.ZapamtiPregled(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.PretraziPregledePacijenta:
                            transfer.TransferObjekat = kal.PretraziPreglede(transfer.TransferObjekat as IOpstiDomenskiObjekat);
                            formater.Serialize(tok, transfer);
                            break;
                        case Operacije.PretraziRecepte:
                            transfer.TransferObjekat = kal.PretraziRecepte(transfer.TransferObjekat as IOpstiDomenskiObjekat);
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