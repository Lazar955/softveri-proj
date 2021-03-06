﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ServerForma
{
    public class Server
    {
        Socket soket;

        public bool pokreniServer()
        {
            try
            {
                soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ep = new IPEndPoint(IPAddress.Any, 50000);
                soket.Bind(ep);

                ThreadStart ts = osluskuj;
                Thread nit = new Thread(ts);
                nit.Start();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        void osluskuj()
        {
            try
            {
                soket.Listen(1);
                while (true)
                {
                    Socket klijent = soket.Accept();
                    NetworkStream tok = new NetworkStream(klijent);
                    new Obrada(tok,klijent);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
