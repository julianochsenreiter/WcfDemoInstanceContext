using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfDemoInstanceContext
{
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Schnittstellennamen "ICounterService" sowohl im Code als auch in der Konfigurationsdatei ändern.
    [ServiceContract]
    public interface ICounterService
    {
        [OperationContract]
        [FaultContract(typeof(AmountTooSmallException))]
        [FaultContract(typeof(AmountTooLargeException))]
        Task<CounterInfo> IncreaseCounter(int amount);
    }
}
