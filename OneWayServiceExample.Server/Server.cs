using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace OneWayServiceExample.Server
{
    class Server
    {
        static void Main(string[] args)
        {
            ServiceHost serviceHost = new ServiceHost(typeof(ExampleService));

            serviceHost.Open();

            Console.WriteLine("Press Enter to shutdown and exit.");
            Console.ReadLine();
        }
    }
}
