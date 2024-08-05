using System.Runtime.Versioning;
using System.Security.Principal;

namespace nWHOAMI
{
    internal class Program
    {
        [SupportedOSPlatform("windows")]
        static void Main(string[] args)
        {

            var inforCurUser = WindowsIdentity.GetCurrent().Name;
            Console.WriteLine(inforCurUser.ToLower());
        }
    }
}
