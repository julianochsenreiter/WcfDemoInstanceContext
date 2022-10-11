using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfDemoInstanceContext
{
    // HINWEIS: Mit dem Befehl "Umbenennen" im Menü "Umgestalten" können Sie den Schnittstellennamen "ICounterService" sowohl im Code als auch in der Konfigurationsdatei ändern.
    [ServiceContract]
    public interface ICounterService
    {
        [OperationContract]
        void IncreaseCounter(int amount);
    }
}
