using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Enums;
using TestClientApp.SourceServiceProxy;

namespace TestClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running...");
            var client = new SourceServiceProxy.SourceServiceClient();
            client.GetDataViaEndpoint(new SourceTestRequest()
            {
                AttemptsNumber = 10,
                TestingStrategy = TestingStrategy.LargePackage,
                EndpointName = EndpointName.BasicHttpEndpoint
            });

            Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }
    }
}
