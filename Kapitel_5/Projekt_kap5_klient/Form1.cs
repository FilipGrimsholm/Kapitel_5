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

namespace Projekt_kap5_klient
{
    public partial class Form1 : Form
    {
        List<TcpClient> klientlista = new List<TcpClient>();
        TcpListener lyssnare;
        int port = 3500;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                lyssnare = new TcpListener(IPAddress.Any, port);
                lyssnare.Start();
                StartaMottagning();
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, Text);
                return;
            }
        }

        private async void StartaMottagning()
        {
            try
            {
                TcpClient k = await lyssnare.AcceptTcpClientAsync();
                klientlista.Add(k);

                StartaLäsning(k);
                StartaMottagning();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
                return;
            }
        }

        private async void StartaLäsning(TcpClient k)
        {
            try
            {
                byte[] buffert = new byte[1024];
                int n = 0;
                n = await k.GetStream().ReadAsync(buffert, 0, buffert.Length);
                string message = (Encoding.Unicode.GetString(buffert, 0, n));

                SendMessage(message);
                Array.Clear(buffert, 0, buffert.Length);

                StartaLäsning(k);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
                return;
            }
        }

        private async void SendMessage(string message)
        {
            try
            {
                byte[] utData = Encoding.Unicode.GetBytes(message);
                
                foreach(TcpClient k in klientlista)
                {
                    await k.GetStream().WriteAsync(utData, 0, utData.Length);
                }

                Array.Clear(utData, 0, utData.Length);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, Text);
                return;
            }
        }
    }
}
