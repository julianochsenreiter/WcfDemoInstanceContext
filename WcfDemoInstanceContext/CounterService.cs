using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfDemoInstanceContext
{
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Klassennamen "CounterService" sowohl im Code als auch in der Konfigurationsdatei ändern.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class CounterService : ICounterService
    {
        private int counter = 0;
        CounterInfo info = new CounterInfo("Counter1");

        public async Task<CounterInfo> IncreaseCounter(int amount)
        {
            if (amount <= 0)
            {
                throw new FaultException<AmountTooSmallException>(new AmountTooSmallException());
            }
            if (amount >= 1000)
            {
                throw new FaultException<AmountTooLargeException>(new AmountTooLargeException());
            }
            counter += amount;
            await Task.Delay(1000);
            Console.WriteLine("Counter: {0}", counter);
            return info;
        }
    }
}
