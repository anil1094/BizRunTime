using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace MultipleTypeClient
{
    class Program
    {
        static void Main(string[] args)
        {
            //multiple client
            int port = 1300;
            string IpAdress = "127.0.0.1";
            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(IpAdress), port);
            clientSocket.Connect(ep);
            Console.WriteLine("client connected");
            while(true)
            {
                string MessageFromClient = null;
                Console.WriteLine("enter the message");
                MessageFromClient = Console.ReadLine();
                clientSocket.Send(System.Text.Encoding.ASCII.GetBytes(MessageFromClient), 0, MessageFromClient.Length, SocketFlags.None);

                byte[] MsgFromServer = new byte[1024];
                int size = clientSocket.Receive(MsgFromServer);
                Console.WriteLine("server " + System.Text.Encoding.ASCII.GetString(MsgFromServer, 0, size));
            }
        }
    }
}
