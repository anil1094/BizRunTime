using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;

namespace IndexerProg.NetworkProgramming
{
    public partial class ClientSide : Form
    {
        TcpClient client = null;
        public ClientSide()
        {
            InitializeComponent();
            client = new TcpClient("127.0.0.1", 888);
            NetworkStream ns = client.GetStream();
            StreamReader sr = new StreamReader(ns);
            textserver.Text= "server >> " + sr.ReadLine();
           
        }

       
    }
}
