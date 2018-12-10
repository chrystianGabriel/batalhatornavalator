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
        protected Socket _Socket { get; set; }
        public string Ip { get; set; }
        public int Port { get; set; }
        public static SocketConnection Instance { get; private set; } = null;

        protected SocketConnection(int port)
        {
            Port = port;
            string auxIp = "";
            foreach (IPAddress addr in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                if (addr.AddressFamily == AddressFamily.InterNetwork)
                {
                    auxIp = addr.ToString();
                    break;
                }
            }
            Ip = auxIp;
            Instance = this;
        }
        protected SocketConnection(string ip, int port)
        {
            Ip = ip;
            Port = port;
            Instance = this;
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
