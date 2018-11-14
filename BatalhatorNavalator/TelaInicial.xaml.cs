using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BatalhatorNavalator
{
    /// <summary>
    /// Interaction logic for TelaInicial.xaml
    /// </summary>
    public partial class TelaInicial : Window
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        protected Socket conexao;

        private void BtnIniciarPartida_Click(object sender, RoutedEventArgs e)
        {
            // Cria uma conexão TCP
            Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            listener.Bind(new IPEndPoint(IPAddress.Any, 2112));
            listener.Listen(1);
            // Aguardar Client conectar
            Console.WriteLine("Waiting for Client");
            conexao = listener.Accept();
            // Cliente foi conectado
            Console.WriteLine("Client connected");
            while (true)
            {
                if (conexao.Poll(1000, SelectMode.SelectRead) && (conexao.Available == 0 || !conexao.Connected))
                {
                    Console.WriteLine("Desconectado");
                }
                Console.WriteLine("Conectado");
                Thread.Sleep(1000);
            }

            /*conexao.Shutdown(SocketShutdown.Both);
            conexao.Close();
            Console.WriteLine("");*/

            /*Console.WriteLine("Starting: Creating Socket object");
            Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            listener.Bind(new IPEndPoint(IPAddress.Any, 2112));
            listener.Listen(1);
            Console.WriteLine("Waiting for Client");

            Socket socket = listener.Accept();

            byte[] receivedBytes = new byte[socket.ReceiveBufferSize];
            int numBytes = socket.Receive(receivedBytes);
            string receivedValue = Encoding.ASCII.GetString(receivedBytes);
            Console.WriteLine("Received value: {0}", receivedValue);

            Console.WriteLine("Send message back:");
            string replyValue = Console.ReadLine();
            byte[] replyMessage = Encoding.ASCII.GetBytes(replyValue);
            socket.Send(replyMessage);
            socket.Shutdown(SocketShutdown.Both);
            socket.Close();*/
        }

        private void BtnEntrarPartida_Click(object sender, RoutedEventArgs e)
        {
            // Mostrar tela pedindo o ip do servidor
            // Receber o ip do servidor
            // Conectar com o servidor
            IPHostEntry ipHost = Dns.Resolve("192.168.51.136");
            IPAddress ipAddress = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 2112);
            Console.WriteLine("Starting: Creating Socket object");
            conexao = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            conexao.Connect(ipEndPoint);
            Console.WriteLine("Successfully connected to {0}", conexao.RemoteEndPoint);

            
            
            
            // Mostrar tela do jogo

            /*byte[] receivedBytes = new byte[2048];
            IPHostEntry ipHost = Dns.Resolve("192.168.51.136");
            IPAddress ipAddress = ipHost.AddressList[0];
            IPEndPoint ipEndPoint = new IPEndPoint(ipAddress, 2112);
            Console.WriteLine("Starting: Creating Socket object");
            Socket sender = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            sender.Connect(ipEndPoint);
            Console.WriteLine("Successfully connected to {0}", sender.RemoteEndPoint);

            Console.WriteLine("Enter Client Message :");
            string sendingMessage = Console.ReadLine();
            byte[] forwardMessage = Encoding.ASCII.GetBytes(sendingMessage);
            sender.Send(forwardMessage);

            int totalBytesReceived = sender.Receive(receivedBytes);
            Console.WriteLine("Message provided from server: {0}", Encoding.ASCII.GetString(receivedBytes, 0, totalBytesReceived));
            sender.Shutdown(SocketShutdown.Both);
            sender.Close();
            Console.ReadLine();*/
        }

        
    }
}
