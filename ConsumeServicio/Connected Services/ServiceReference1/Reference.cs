﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsumeServicio.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebServiceEjemploSoap")]
    public interface WebServiceEjemploSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/numeroAleatorio", ReplyAction="*")]
        int numeroAleatorio();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/numeroAleatorio", ReplyAction="*")]
        System.Threading.Tasks.Task<int> numeroAleatorioAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/suma", ReplyAction="*")]
        int suma(int val1, int val2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/suma", ReplyAction="*")]
        System.Threading.Tasks.Task<int> sumaAsync(int val1, int val2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/convertirFtoC", ReplyAction="*")]
        double convertirFtoC(double temperatura);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/convertirFtoC", ReplyAction="*")]
        System.Threading.Tasks.Task<double> convertirFtoCAsync(double temperatura);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/convertirCtoF", ReplyAction="*")]
        double convertirCtoF(double temperatura);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/convertirCtoF", ReplyAction="*")]
        System.Threading.Tasks.Task<double> convertirCtoFAsync(double temperatura);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceEjemploSoapChannel : ConsumeServicio.ServiceReference1.WebServiceEjemploSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceEjemploSoapClient : System.ServiceModel.ClientBase<ConsumeServicio.ServiceReference1.WebServiceEjemploSoap>, ConsumeServicio.ServiceReference1.WebServiceEjemploSoap {
        
        public WebServiceEjemploSoapClient() {
        }
        
        public WebServiceEjemploSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceEjemploSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceEjemploSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceEjemploSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int numeroAleatorio() {
            return base.Channel.numeroAleatorio();
        }
        
        public System.Threading.Tasks.Task<int> numeroAleatorioAsync() {
            return base.Channel.numeroAleatorioAsync();
        }
        
        public int suma(int val1, int val2) {
            return base.Channel.suma(val1, val2);
        }
        
        public System.Threading.Tasks.Task<int> sumaAsync(int val1, int val2) {
            return base.Channel.sumaAsync(val1, val2);
        }
        
        public double convertirFtoC(double temperatura) {
            return base.Channel.convertirFtoC(temperatura);
        }
        
        public System.Threading.Tasks.Task<double> convertirFtoCAsync(double temperatura) {
            return base.Channel.convertirFtoCAsync(temperatura);
        }
        
        public double convertirCtoF(double temperatura) {
            return base.Channel.convertirCtoF(temperatura);
        }
        
        public System.Threading.Tasks.Task<double> convertirCtoFAsync(double temperatura) {
            return base.Channel.convertirCtoFAsync(temperatura);
        }
    }
}
