using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BatalhatorNavalator.Server
{
    class Cliente
    {
        private Socket conexao;

        public void Conectar(string ip)
        {
            IPHostEntry ipHost = Dns.Resolve("192.168.51.136");
            IPAddress ipAddress = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 2112);
            Console.WriteLine("Starting: Creating Socket object");
            conexao = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            conexao.Connect(ipEndPoint);
            Console.WriteLine("Successfully connected to {0}", conexao.RemoteEndPoint);
        }
    }
}
