using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tripper.Services.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            string uri = "http://localhost:8080/";

            using (WebApp.Start<Startup>(uri))
            {
                Console.WriteLine("Started");
                Console.ReadKey();
                Console.WriteLine("Stopping");
            }
        }
    }
}
