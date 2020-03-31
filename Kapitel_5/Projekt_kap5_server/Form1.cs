using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_kap5_server
{
    public partial class Form1 : Form
    {
        TcpListener lyssnare;
        List<TcpClient> klientlista = new List<TcpClient>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnslut_Click(object sender, EventArgs e)
        {

        }

        private void btnSänd_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSänd.Enabled = false;
            tbxMeddelande.Enabled = false;
            lbxChatrum.Enabled = false;
        }
    }
}
