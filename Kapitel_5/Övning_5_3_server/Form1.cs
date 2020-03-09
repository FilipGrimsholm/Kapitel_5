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

namespace Övning_5_3_server
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

        private void btnStartaServer_Click(object sender, EventArgs e)
        {
            try
            {
                lyssnare = new TcpListener(IPAddress.Any, port);
                lyssnare.Start();

                btnStartaServer.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void btnTaEmot_Click(object sender, EventArgs e)
        {
            try
            {
                //Väntar på Connect i klienten:
                klient = lyssnare.AcceptTcpClient();
                byte[] inData = new byte[256];

                //Väntar på Send i klienten:
                int antalbyte = klient.GetStream().Read(inData, 0, inData.Length);
                tbxInkorg.Text = Encoding.Unicode.GetString(inData, 0, antalbyte);
                klient.Close();
                lyssnare.Stop();
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
