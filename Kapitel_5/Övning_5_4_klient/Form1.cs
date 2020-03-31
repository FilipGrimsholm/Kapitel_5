using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Övning_5_4_klient
{
    public partial class Form1 : Form
    {
        TcpClient klient = new TcpClient();
        int port = 3500;

        public Form1()
        {
            InitializeComponent();
            klient.NoDelay = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbxIPadress.Text = "127.0.0.1";
        }

        private async void btnAnslut_Click(object sender, EventArgs e)
        {
            try
            {
                if (!klient.Connected)
                {
                    IPAddress address = IPAddress.Parse(tbxIPadress.Text);
                    await klient.ConnectAsync(address, port);

                    btnAnslut.Enabled = false;
                    btnUpp.Enabled = true;
                    btnNer.Enabled = true;
                    btnVänster.Enabled = true;
                    btnHöger.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void btnUpp_Click(object sender, EventArgs e)
        {
            SendMessage("Up");
        }

        private void btnHöger_Click(object sender, EventArgs e)
        {
            SendMessage("Right");
        }

        private void btnNer_Click(object sender, EventArgs e)
        {
            SendMessage("Down");
        }

        private void btnVänster_Click(object sender, EventArgs e)
        {
            SendMessage("Left");
        }

        private async void SendMessage(string msg)
        {
            try
            {
                byte[] utdata = Encoding.Unicode.GetBytes(msg);
                await klient.GetStream().WriteAsync(utdata, 0, utdata.Length);
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
