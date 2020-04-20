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

namespace Projekt_kap5_server
{
    public partial class Form1 : Form
    {
        TcpClient klient;
        TcpListener lyssnare;
        int port = 3500;

        public Form1()
        {
            InitializeComponent();
            klient.NoDelay = true;
        }

        private void btnAnslut_Click(object sender, EventArgs e)
        {
            if (! klient.Connected)
            {
                StartaAnslutning();
            }
        }

        private void btnSänd_Click(object sender, EventArgs e)
        {
            string meddelande = tbxMeddelande.Text;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSänd.Enabled = false;
            tbxMeddelande.Enabled = false;
            lbxChatrum.Enabled = false;
        }

        private async void StartaAnslutning()
        {
            try
            {
                IPAddress adress = IPAddress.Parse(tbxIPaddress.Text);
                await klient.ConnectAsync(adress, port);

                btnAnslut.Enabled = false;
                btnSänd.Enabled = true;
                tbxMeddelande.Enabled = true;
                lbxChatrum.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
                return;
            }
        }
    }
}
