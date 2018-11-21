using BatalhatorNavalator.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatalhatorNavalator.Views
{
    public partial class TelaCriarPartida : Form
    {
        public int Tamanho { set; get; }
        public string Nome { set; get; }
        public string IP { set; get; }
        public TelaCriarPartida()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
           this.Tamanho = Convert.ToInt32(nudTamanho.Value);
           this.Nome = txtBoxNome.Text;
           string ip = "";

           foreach(IPAddress addr in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                if(addr.AddressFamily == AddressFamily.InterNetwork)
                {
                    ip = addr.ToString();
                }
            }

            this.IP = ip;
            TelaDeAguardo telaDeAguardo = new TelaDeAguardo(this.IP, this.Nome);
            telaDeAguardo.Show();
            this.Close();

            




        }
    }
}
