﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestServiceSVC.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DoWork", ReplyAction="http://tempuri.org/IService1/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DoWork", ReplyAction="http://tempuri.org/IService1/DoWorkResponse")]
        System.Threading.Tasks.Task DoWorkAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Multiply", ReplyAction="http://tempuri.org/IService1/MultiplyResponse")]
        int Multiply(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Multiply", ReplyAction="http://tempuri.org/IService1/MultiplyResponse")]
        System.Threading.Tasks.Task<int> MultiplyAsync(int x, int y);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : TestServiceSVC.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<TestServiceSVC.ServiceReference1.IService1>, TestServiceSVC.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public System.Threading.Tasks.Task DoWorkAsync() {
            return base.Channel.DoWorkAsync();
        }
        
        public int Multiply(int x, int y) {
            return base.Channel.Multiply(x, y);
        }
        
        public System.Threading.Tasks.Task<int> MultiplyAsync(int x, int y) {
            return base.Channel.MultiplyAsync(x, y);
        }
    }
}
