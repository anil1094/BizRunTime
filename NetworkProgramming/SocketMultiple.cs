using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace IndexerProg.NetworkProgramming
{
    class SocketMultiple
    {
        //server classes for Multiple client
        static void Main(string[] args)
        {
            int port = 8888;
            string IpAddress = "127.0.0.1";
            Socket ServerListner = new Socket(AddressFamily.InterNetwork, SocketType.Stream ,ProtocolType.Tcp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(IpAddress),port);
            ServerListner.Bind(ep);
            ServerListner.Listen(100);
            Console.WriteLine("Server is Listining");
            Socket ClientSocket = default(Socket);
            int counter = 0;
            SocketMultiple p = new SocketMultiple();
            while(true)
            {
                counter++;
                ClientSocket = ServerListner.Accept();
                Console.WriteLine(counter + " Client connected");
                Thread userThread = new Thread(new ThreadStart(() => p.User(ClientSocket)));
            }
        } 
        public void User(Socket client)
        {
            while(true)
            {
                byte[] msg = new byte[1024];
                int size = client.Receive(msg);
                client.Send(msg, 0, size, SocketFlags.None);
            }

        }
    }
}
