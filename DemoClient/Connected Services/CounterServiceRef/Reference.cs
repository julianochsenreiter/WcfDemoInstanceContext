﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoClient.CounterServiceRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CounterServiceRef.ICounterService")]
    public interface ICounterService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICounterService/IncreaseCounter", ReplyAction="http://tempuri.org/ICounterService/IncreaseCounterResponse")]
        void IncreaseCounter(int amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICounterService/IncreaseCounter", ReplyAction="http://tempuri.org/ICounterService/IncreaseCounterResponse")]
        System.Threading.Tasks.Task IncreaseCounterAsync(int amount);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICounterServiceChannel : DemoClient.CounterServiceRef.ICounterService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CounterServiceClient : System.ServiceModel.ClientBase<DemoClient.CounterServiceRef.ICounterService>, DemoClient.CounterServiceRef.ICounterService {
        
        public CounterServiceClient() {
        }
        
        public CounterServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CounterServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CounterServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CounterServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void IncreaseCounter(int amount) {
            base.Channel.IncreaseCounter(amount);
        }
        
        public System.Threading.Tasks.Task IncreaseCounterAsync(int amount) {
            return base.Channel.IncreaseCounterAsync(amount);
        }
    }
}