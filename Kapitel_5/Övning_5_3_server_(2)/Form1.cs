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

namespace Övning_5_3_server__2_
{
    public partial class FrmServer : Form
    {
        TcpListener lyssnare;
        TcpClient klient;
        int port = 3500;
            
        public FrmServer()
        {
            InitializeComponent();
        }

        private void FrmServer_Load(object sender, EventArgs e)
        {
            try
            {
                lyssnare = new TcpListener(IPAddress.Any, port);
                lyssnare.Start();
                StartaMottagning();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
                return;
            }
        }

        public async void StartaMottagning()
        {
            try
            {
                klient = await lyssnare.AcceptTcpClientAsync();
                StartaLäsning(klient);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
                return;
            }
        }

        public async void StartaLäsning(TcpClient k )
        {
            try
            {
                byte[] data = new byte[1024];

                int n = 0;
                n = await k.GetStream().ReadAsync(data, 0, data.Length);
                tbxInkorg.AppendText(Encoding.Unicode.GetString(data, 0, n));
                StartaLäsning(k);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
                return;
            }
        }

        private void tbxInkorg_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
