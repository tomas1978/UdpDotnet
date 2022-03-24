using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace udpSend
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] message=Encoding.Unicode.GetBytes("Hej");
            IPAddress ip = IPAddress.Parse("10.110.212.200");
            IPEndPoint destination = new IPEndPoint(ip,12345);
            UdpClient klient = new UdpClient();
            klient.Send(message, message.Length, destination);
        }
    }
}
