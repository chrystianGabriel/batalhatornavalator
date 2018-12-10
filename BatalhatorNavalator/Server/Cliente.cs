using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace BatalhatorNavalator.Server
{
    public class Cliente : SocketConnection
    {
        public Cliente(string ip, int port)
            :base(ip, port)
        {
            
        }

        public void ConnectToServer()
        {
            IPHostEntry ipHost = Dns.Resolve(Ip);
            IPAddress ipAddress = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, Port);
            _Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _Socket.Connect(ipEndPoint);
        }
    }
}
