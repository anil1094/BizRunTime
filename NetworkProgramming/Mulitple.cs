using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Multiple1
{
    class Program
    {
        static void Main(string[] args)
        {
            //server from multiple client
            int port = 1300;
            string IpAdress = "127.0.0.1";
            Socket ServerListner = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(IpAdress), port);
            ServerListner.Bind(ep);
            ServerListner.Listen(100);
            Console.WriteLine("Server is listining");
            Socket clientSocket = default(Socket);
            int counter = 0;
            Program p = new Program();
            while(true)

            {
                counter++;
                clientSocket = ServerListner.Accept();
                Console.WriteLine(counter + " client connected");
                Thread UserThread = new Thread(new ThreadStart(() => p.User(clientSocket)));
                UserThread.Start();
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
