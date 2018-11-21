using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BatalhatorNavalator
{
    public class SocketConnection
    {
        private Socket _Socket { get; set; }
        public string Ip { get; set; }
        public int Port { get; set; }

        public SocketConnection(int port)
        {
            Port = port;
        }

        public SocketConnection(string ip, int port)
        {
            Ip = ip;
            Port = port;
        }

        public void StartServer()
        {
            Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            listener.Bind(new IPEndPoint(IPAddress.Any, Port));
            listener.Listen(1);
            _Socket = listener.Accept();
        }

        public void ConnectToServer()
        {
            IPHostEntry ipHost = Dns.Resolve(Ip);
            IPAddress ipAddress = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, Port);
            _Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _Socket.Connect(ipEndPoint);
        }

        public string GetMessage()
        {
            byte[] receivedBytes = new byte[_Socket.ReceiveBufferSize];
            int totalBytesReceived = _Socket.Receive(receivedBytes);
            string receivedValue = Encoding.ASCII.GetString(receivedBytes, 0, totalBytesReceived);
            return receivedValue;
        }

        public void SendMessage(string message)
        {
            byte[] replyMessage = Encoding.ASCII.GetBytes(message);

            for(int i=1; i <= 5; i++)
            {
                try
                {
                    _Socket.Send(replyMessage);
                    break;
                }
                catch (SocketException ex)
                {
                    Console.WriteLine($"Erro ao enviar mensagem. Tentativa {i}");
                    Console.WriteLine($"Detalhes: {ex.Message}");
                }
            }            
        }
    }
}
