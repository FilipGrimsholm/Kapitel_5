using System;
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

namespace Övning_5_2_
{
    public partial class Form1 : Form
    {
        TcpClient klient;
        int port = 3500;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (klient.Connected)
            {
                byte[] utdata = Encoding.Unicode.GetBytes("Hej!");
                klient.GetStream().Write(utdata, 0, utdata.Length);
                klient.Close(),
            }
        }

        private void btnAnslut_Click(object sender, EventArgs e)
        {
            IPAddress adress = IPAddress.Parse(tbxIPaddress.Text);

            klient = new TcpClient();
            klient.NoDelay = true;
            klient.Connect(adress, port);

            btnAnslut.Enabled = false;
        }
    }
}
