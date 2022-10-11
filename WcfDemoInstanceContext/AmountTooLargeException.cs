using System.Runtime.Serialization;

namespace WcfDemoInstanceContext
{
    [DataContract]
    internal class AmountTooLargeException
    {
        [DataMember]
        public string ErrorMessage { get; set; } = "Amount is to high";
    }
}