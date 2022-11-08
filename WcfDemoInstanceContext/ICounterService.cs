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
    [ServiceContract(SessionMode = SessionMode.Required)]
    public interface ICounterService
    {
        [OperationContract(IsInitiating = true, IsTerminating = false)]
        void Login(string username);

        [OperationContract(IsInitiating = false, IsTerminating = false)]
        [FaultContract(typeof(AmountTooSmallException))]
        [FaultContract(typeof(AmountTooLargeException))]
        Task<CounterInfo> IncreaseCounter(int amount);

        [OperationContract(IsOneWay = true, IsInitiating = false, IsTerminating = true)]
        void Logout();
    }
}
