using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfDemoInstanceContext
{
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Klassennamen "CounterService" sowohl im Code als auch in der Konfigurationsdatei ändern.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class CounterService : ICounterService
    {
        private int counter = 0;

        public void IncreaseCounter(int amount)
        {
            counter += amount;
            Console.WriteLine("Counter: {0}", counter);
        }
    }
}
