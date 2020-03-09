using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using System.Net;

namespace Övning_5_4_server
{
    public partial class Form1 : Form
    {
        TcpListener lyssnare;
        TcpClient klient;
        int port = 3500;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lyssnare = new TcpListener(IPAddress.Any, port);
            lyssnare.Start();

            //Väntar på connect i klienten:
            klient = lyssnare.AcceptTcpClient();

            byte[] indata = new byte[256];
            //Väntar på Send i klienten:
            int antalbyte = klient.GetStream().Read(indata, 0, indata.Length);
        }
    }
}
