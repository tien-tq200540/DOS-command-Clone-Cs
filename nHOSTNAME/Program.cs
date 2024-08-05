using System.Net;

namespace nHOSTNAME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hostName = Dns.GetHostName();
            Console.WriteLine($"{hostName}");
        }
    }
}
