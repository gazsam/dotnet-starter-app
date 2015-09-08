using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceTestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating proxy");
            var client = new WorkerClient();
            Console.WriteLine("Calling method on proxy");
            client.DoWork();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
