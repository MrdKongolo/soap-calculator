﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceWebDemo.MonServiceWeb {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MonServiceWeb.CalcServiceSoap")]
    public interface CalcServiceSoap {
        
        // CODEGEN: Generating message contract since element name MessageResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Message", ReplyAction="*")]
        ServiceWebDemo.MonServiceWeb.MessageResponse Message(ServiceWebDemo.MonServiceWeb.MessageRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Message", ReplyAction="*")]
        System.Threading.Tasks.Task<ServiceWebDemo.MonServiceWeb.MessageResponse> MessageAsync(ServiceWebDemo.MonServiceWeb.MessageRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Plus", ReplyAction="*")]
        decimal Plus(decimal a, decimal b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Plus", ReplyAction="*")]
        System.Threading.Tasks.Task<decimal> PlusAsync(decimal a, decimal b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Moins", ReplyAction="*")]
        decimal Moins(decimal a, decimal b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Moins", ReplyAction="*")]
        System.Threading.Tasks.Task<decimal> MoinsAsync(decimal a, decimal b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Multiplier", ReplyAction="*")]
        decimal Multiplier(decimal a, decimal b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Multiplier", ReplyAction="*")]
        System.Threading.Tasks.Task<decimal> MultiplierAsync(decimal a, decimal b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Diviser", ReplyAction="*")]
        decimal Diviser(decimal a, decimal b);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Diviser", ReplyAction="*")]
        System.Threading.Tasks.Task<decimal> DiviserAsync(decimal a, decimal b);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MessageRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Message", Namespace="http://tempuri.org/", Order=0)]
        public ServiceWebDemo.MonServiceWeb.MessageRequestBody Body;
        
        public MessageRequest() {
        }
        
        public MessageRequest(ServiceWebDemo.MonServiceWeb.MessageRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class MessageRequestBody {
        
        public MessageRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class MessageResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="MessageResponse", Namespace="http://tempuri.org/", Order=0)]
        public ServiceWebDemo.MonServiceWeb.MessageResponseBody Body;
        
        public MessageResponse() {
        }
        
        public MessageResponse(ServiceWebDemo.MonServiceWeb.MessageResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class MessageResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string MessageResult;
        
        public MessageResponseBody() {
        }
        
        public MessageResponseBody(string MessageResult) {
            this.MessageResult = MessageResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CalcServiceSoapChannel : ServiceWebDemo.MonServiceWeb.CalcServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalcServiceSoapClient : System.ServiceModel.ClientBase<ServiceWebDemo.MonServiceWeb.CalcServiceSoap>, ServiceWebDemo.MonServiceWeb.CalcServiceSoap {
        
        public CalcServiceSoapClient() {
        }
        
        public CalcServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalcServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalcServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalcServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ServiceWebDemo.MonServiceWeb.MessageResponse ServiceWebDemo.MonServiceWeb.CalcServiceSoap.Message(ServiceWebDemo.MonServiceWeb.MessageRequest request) {
            return base.Channel.Message(request);
        }
        
        public string Message() {
            ServiceWebDemo.MonServiceWeb.MessageRequest inValue = new ServiceWebDemo.MonServiceWeb.MessageRequest();
            inValue.Body = new ServiceWebDemo.MonServiceWeb.MessageRequestBody();
            ServiceWebDemo.MonServiceWeb.MessageResponse retVal = ((ServiceWebDemo.MonServiceWeb.CalcServiceSoap)(this)).Message(inValue);
            return retVal.Body.MessageResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ServiceWebDemo.MonServiceWeb.MessageResponse> ServiceWebDemo.MonServiceWeb.CalcServiceSoap.MessageAsync(ServiceWebDemo.MonServiceWeb.MessageRequest request) {
            return base.Channel.MessageAsync(request);
        }
        
        public System.Threading.Tasks.Task<ServiceWebDemo.MonServiceWeb.MessageResponse> MessageAsync() {
            ServiceWebDemo.MonServiceWeb.MessageRequest inValue = new ServiceWebDemo.MonServiceWeb.MessageRequest();
            inValue.Body = new ServiceWebDemo.MonServiceWeb.MessageRequestBody();
            return ((ServiceWebDemo.MonServiceWeb.CalcServiceSoap)(this)).MessageAsync(inValue);
        }
        
        public decimal Plus(decimal a, decimal b) {
            return base.Channel.Plus(a, b);
        }
        
        public System.Threading.Tasks.Task<decimal> PlusAsync(decimal a, decimal b) {
            return base.Channel.PlusAsync(a, b);
        }
        
        public decimal Moins(decimal a, decimal b) {
            return base.Channel.Moins(a, b);
        }
        
        public System.Threading.Tasks.Task<decimal> MoinsAsync(decimal a, decimal b) {
            return base.Channel.MoinsAsync(a, b);
        }
        
        public decimal Multiplier(decimal a, decimal b) {
            return base.Channel.Multiplier(a, b);
        }
        
        public System.Threading.Tasks.Task<decimal> MultiplierAsync(decimal a, decimal b) {
            return base.Channel.MultiplierAsync(a, b);
        }
        
        public decimal Diviser(decimal a, decimal b) {
            return base.Channel.Diviser(a, b);
        }
        
        public System.Threading.Tasks.Task<decimal> DiviserAsync(decimal a, decimal b) {
            return base.Channel.DiviserAsync(a, b);
        }
    }
}