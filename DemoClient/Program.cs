﻿using DemoClient.CounterServiceRef;
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
            client.IncreaseCounter(1);
            client.IncreaseCounter(1);
            client.IncreaseCounter(1);
            client.IncreaseCounter(1);
            
            CounterServiceClient client2 = new CounterServiceClient();
            client2.IncreaseCounter(1);
            client2.IncreaseCounter(1);
            client2.IncreaseCounter(1);
            client2.IncreaseCounter(1);

            client.Close();
            client2.Close();
        }
    }
}
