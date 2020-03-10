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

namespace Övning_5_3_klient__2_
{
    public partial class FrmKlient : Form
    {
        TcpClient klient = new TcpClient();
        int port = 3500;

        public FrmKlient()
        {
            InitializeComponent();
            klient.NoDelay = true;
        }

        private void btnAnslut_Click(object sender, EventArgs e)
        {
            try
            {
                if (!klient.Connected)
                {
                    StartaAnslutning();
                }
            }
            catch
            {
                MessageBox.Show("Klient already connected");
            }
        }

        private async void btnSänd_Click(object sender, EventArgs e)
        {
            string message = tbxUtkorg.Text;

            try
            {
                byte[] data = Encoding.Unicode.GetBytes(message);
                await klient.GetStream().WriteAsync(data, 0, data.Length);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
                return;
            }
        }

        public async void StartaAnslutning()
        {
            try
            {
                IPAddress IPaddress = IPAddress.Parse(tbxIPaddress.Text);
                await klient.ConnectAsync(IPaddress, port);
                btnAnslut.Enabled = false;
                btnSänd.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
            }
        }
    }
}
