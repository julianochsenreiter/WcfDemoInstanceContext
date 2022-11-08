using DemoClient.CounterServiceRef;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CounterServiceClient client = new CounterServiceClient();
            client.Login("Donald");
            client.IncreaseCounter(1);
            client.IncreaseCounter(1);
            client.IncreaseCounter(1);
            client.Logout();
            client.IncreaseCounter(1);
            
            CounterServiceClient client2 = new CounterServiceClient();
            client2.Login("Daisy");
            client2.IncreaseCounter(1);
            client2.IncreaseCounter(1);
            client2.IncreaseCounter(1);
            client2.Logout();
            client2.IncreaseCounter(1);

            client.Close();
            client2.Close();
        }
    }
}
