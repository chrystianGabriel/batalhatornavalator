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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatalhatorNavalator.Views
{

    public partial class TelaDeAguardo : Form
    {
        Servidor server;
        public TelaDeAguardo(string IP, string Nome)
        {
            InitializeComponent();

            lblBemVindo.Text += Nome;
            server = new Servidor(2112);
            lblIP.Text += server.Ip;
            // lblPort.Text += teste.Port;
        }

        public void Teste()
        {
            if (server.StartServer() == false)
            {
                // Mostrar popup 'Tentar novamente'
                throw new Exception("Nenhum jogador foi contactado");
            }
        }
    }
}
