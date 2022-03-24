using System;
using System.Net;
using System.Net.Sockets;
using System.Text;


namespace udpReceive
{
    class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint klientEndPoint = new IPEndPoint(IPAddress.Parse("10.110.212.200"), 0);
            UdpClient client = new UdpClient(12345);
            byte[] inström = client.Receive(ref klientEndPoint);
            string message=Encoding.Unicode.GetString(inström);
            Console.WriteLine(message);
        }
    }
}
