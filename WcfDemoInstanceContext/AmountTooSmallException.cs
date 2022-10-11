using System.Runtime.Serialization;

namespace WcfDemoInstanceContext
{
    [DataContract]
    internal class AmountTooSmallException
    {
        [DataMember]
        public string ErrorMessage { get; set; } = "Amount is to small";
    }
}