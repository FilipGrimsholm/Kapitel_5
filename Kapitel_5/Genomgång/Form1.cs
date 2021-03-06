﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Genomgång
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            byte[] message = Encoding.Unicode.GetBytes(tbxUtkorg.Text);
            int port = int.Parse(tbxPort.Text);

            IPAddress serverIP = IPAddress.Parse(tbxIPaddress.Text);
            IPEndPoint destination = new IPEndPoint(serverIP, port);

            UdpClient klient = new UdpClient();
            klient.Send(message, message.Length, destination);
        }
    }
}
