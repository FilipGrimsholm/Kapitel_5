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

namespace ovning5_1_server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTagEmot_Click(object sender, EventArgs e)
        {
            int port = int.Parse(tbxServerPortnr.Text);
            IPEndPoint klientEndPoint = new IPEndPoint(IPAddress.Any, 0);
            UdpClient client = new UdpClient(port);
            byte[] inström = client.Receive(ref klientEndPoint);
            tbxInkorg.Text = Encoding.Unicode.GetString(inström);
        }
    }
}                      
