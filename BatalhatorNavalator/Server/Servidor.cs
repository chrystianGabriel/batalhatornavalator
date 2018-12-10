using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BatalhatorNavalator.Server
{
    public class Servidor : SocketConnection
    {
        public Servidor(int port)
            :base(port)
        {

        }

        public bool StartServer()
        {
            try
            {
                Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                listener.Bind(new IPEndPoint(IPAddress.Any, Port));
                listener.Listen(1);
                Console.WriteLine("Aguardando clientes");
                _Socket = listener.Accept();
                Console.WriteLine("Conectado");
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Falha ao contectar");
                return false;
            }
        }

        /*public Socket conexao { get; set; }
        public void CriarConexao()
        {
            Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            listener.Bind(new IPEndPoint(IPAddress.Any, 2112));
            listener.Listen(1);
            // Aguardar Client conectar
            Console.WriteLine("Aguardando cliente");
            conexao = listener.Accept();
            // Cliente foi conectado
            Console.WriteLine("Cliente Conectado");
        }

        public void Conectar(string ip)
        {
            IPHostEntry ipHost = Dns.Resolve(ip);
            IPAddress ipAddress = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 2112);
            Console.WriteLine("Starting: Creating Socket object");
            conexao = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            conexao.Connect(ipEndPoint);
            Console.WriteLine("Successfully connected to {0}", conexao.RemoteEndPoint);
        }*/

    }
}
