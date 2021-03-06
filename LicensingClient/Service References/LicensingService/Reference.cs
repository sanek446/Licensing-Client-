﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LicensingClient.LicensingService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LicensingService.LicensingService")]
    public interface LicensingService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LicensingService/WCFLogout", ReplyAction="http://tempuri.org/LicensingService/WCFLogoutResponse")]
        bool WCFLogout(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LicensingService/WCFLogout", ReplyAction="http://tempuri.org/LicensingService/WCFLogoutResponse")]
        System.Threading.Tasks.Task<bool> WCFLogoutAsync(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LicensingService/WCFLogin", ReplyAction="http://tempuri.org/LicensingService/WCFLoginResponse")]
        System.Tuple<bool, bool, bool, int, bool> WCFLogin(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LicensingService/WCFLogin", ReplyAction="http://tempuri.org/LicensingService/WCFLoginResponse")]
        System.Threading.Tasks.Task<System.Tuple<bool, bool, bool, int, bool>> WCFLoginAsync(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LicensingService/WCFChangePassword", ReplyAction="http://tempuri.org/LicensingService/WCFChangePasswordResponse")]
        bool WCFChangePassword(string email, string oldPassword, string newPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LicensingService/WCFChangePassword", ReplyAction="http://tempuri.org/LicensingService/WCFChangePasswordResponse")]
        System.Threading.Tasks.Task<bool> WCFChangePasswordAsync(string email, string oldPassword, string newPassword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LicensingService/WCFChangeEmail", ReplyAction="http://tempuri.org/LicensingService/WCFChangeEmailResponse")]
        bool WCFChangeEmail(string oldEmail, string newEmail, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/LicensingService/WCFChangeEmail", ReplyAction="http://tempuri.org/LicensingService/WCFChangeEmailResponse")]
        System.Threading.Tasks.Task<bool> WCFChangeEmailAsync(string oldEmail, string newEmail, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface LicensingServiceChannel : LicensingClient.LicensingService.LicensingService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LicensingServiceClient : System.ServiceModel.ClientBase<LicensingClient.LicensingService.LicensingService>, LicensingClient.LicensingService.LicensingService {
        
        public LicensingServiceClient() {
        }
        
        public LicensingServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LicensingServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LicensingServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LicensingServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool WCFLogout(string email, string password) {
            return base.Channel.WCFLogout(email, password);
        }
        
        public System.Threading.Tasks.Task<bool> WCFLogoutAsync(string email, string password) {
            return base.Channel.WCFLogoutAsync(email, password);
        }
        
        public System.Tuple<bool, bool, bool, int, bool> WCFLogin(string email, string password) {
            return base.Channel.WCFLogin(email, password);
        }
        
        public System.Threading.Tasks.Task<System.Tuple<bool, bool, bool, int, bool>> WCFLoginAsync(string email, string password) {
            return base.Channel.WCFLoginAsync(email, password);
        }
        
        public bool WCFChangePassword(string email, string oldPassword, string newPassword) {
            return base.Channel.WCFChangePassword(email, oldPassword, newPassword);
        }
        
        public System.Threading.Tasks.Task<bool> WCFChangePasswordAsync(string email, string oldPassword, string newPassword) {
            return base.Channel.WCFChangePasswordAsync(email, oldPassword, newPassword);
        }
        
        public bool WCFChangeEmail(string oldEmail, string newEmail, string password) {
            return base.Channel.WCFChangeEmail(oldEmail, newEmail, password);
        }
        
        public System.Threading.Tasks.Task<bool> WCFChangeEmailAsync(string oldEmail, string newEmail, string password) {
            return base.Channel.WCFChangeEmailAsync(oldEmail, newEmail, password);
        }
    }
}
