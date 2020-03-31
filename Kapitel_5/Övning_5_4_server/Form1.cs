using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using System.Net;

namespace Övning_5_4_server
{
    public partial class Form1 : Form
    {
        //Skapar en lyssnare respektive en klient som kan lyssna för inkommande connections och som kan connecta
        TcpListener lyssnare;
        TcpClient klient;
        int port = 3500;

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //Sätter lyssnaren till att ta emot vilken ip-adress som helst, samt startar lyssnaren
                lyssnare = new TcpListener(IPAddress.Any, port);
                lyssnare.Start();

                //Väntar på connect i klienten:
                klient = await lyssnare.AcceptTcpClientAsync();
                StartaLäsning(klient);
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private async void StartaLäsning(TcpClient k)
        {
            try
            {
                //Skapar en array som ska lagra meddelandet
                byte[] indata = new byte[256];

                //Väntar på Send i klienten, därefter hämtas meddelandet från klienten:
                int antalbyte = await klient.GetStream().ReadAsync(indata, 0, indata.Length);

                //Hämtar meddelandet ur indata och flyttar bilden
                string meddelande = Encoding.Unicode.GetString(indata, 0, antalbyte);
                MovePicture(meddelande);

                //Rensar indata
                Array.Clear(indata, 0, indata.Length);

                //Kör om hela funktionen om något mer ska skickas
                StartaLäsning(k);
            }
            catch
            {
                MessageBox.Show("Error!");
            }
        }

        private void MovePicture(string meddelande)
        {
            int movement = 5;
            int Xlocation = pbxCar.Location.X;
            int Ylocation = pbxCar.Location.Y;

            if (meddelande.Equals("Up"))
            {
                pbxCar.Location = new Point(Xlocation, Ylocation - movement);
            }
            else if (meddelande.Equals("Down"))
            {
                pbxCar.Location = new Point(Xlocation, Ylocation + movement);
            }
            else if (meddelande.Equals("Left"))
            {
                pbxCar.Location = new Point(Xlocation - movement, Ylocation);
            }
            else if (meddelande.Equals("Right"))
            {
                pbxCar.Location = new Point(Xlocation + movement, Ylocation);
            }
            else
            {
                MessageBox.Show("Error!");
            }
        }
    }
}
