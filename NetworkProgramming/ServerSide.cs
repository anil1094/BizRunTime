using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.IO;


namespace IndexerProg.NetworkProgramming
{
    class ServerSide
    {
        static void Main(string[] args)
        {
            //Send Message to the client
            TcpListener server = new TcpListener(88);
            server.Start();
            Console.WriteLine("server started and waiting for client");
            Socket SocketForClient = server.AcceptSocket();
            if(SocketForClient.Connected)

            {
                NetworkStream ns = new NetworkStream(SocketForClient);
                StreamWriter sw = new StreamWriter(ns);
                Console.WriteLine("Server--> Welcome client");
                sw.WriteLine("welcome client");
                sw.Flush();

                //Get MEssage from the client
                StreamReader sr = new StreamReader(ns);
                Console.WriteLine("client >> " + sr.ReadLine());
                sw.Close();
                ns.Close();
            }
            SocketForClient.Close();
            Console.ReadLine();
       }
    }
}
