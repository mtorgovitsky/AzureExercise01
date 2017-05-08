using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestServiceSVC.ServiceReference1;

namespace TestServiceSVC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
            Service1Client client = new Service1Client();
            Console.WriteLine(client.Multiply(8,10));
            client.Close();
            Console.ReadKey();
        }
    }
}
