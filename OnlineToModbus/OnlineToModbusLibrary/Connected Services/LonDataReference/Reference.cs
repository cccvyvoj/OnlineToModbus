﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Tento kód byl generován nástrojem.
//     Verze modulu runtime:4.0.30319.42000
//
//     Změny tohoto souboru mohou způsobit nesprávné chování a budou ztraceny,
//     dojde-li k novému generování kódu.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineToModbusLibrary.LonDataReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://LonData.Monitor", ConfigurationName="LonDataReference.ILonData")]
    public interface ILonData {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://LonData.Monitor/ILonData/GetReady", ReplyAction="http://LonData.Monitor/ILonData/GetReadyResponse")]
        bool GetReady();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://LonData.Monitor/ILonData/GetValue", ReplyAction="http://LonData.Monitor/ILonData/GetValueResponse")]
        string GetValue(string node, string var, string subvar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://LonData.Monitor/ILonData/GetValueCP", ReplyAction="http://LonData.Monitor/ILonData/GetValueCPResponse")]
        string GetValueCP(string node, string var, string subvar);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://LonData.Monitor/ILonData/GetValueCPI", ReplyAction="http://LonData.Monitor/ILonData/GetValueCPIResponse")]
        string GetValueCPI(string node, string var, string subvar, int index);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://LonData.Monitor/ILonData/SetValue", ReplyAction="http://LonData.Monitor/ILonData/SetValueResponse")]
        string SetValue(string node, string var, string subvar, string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://LonData.Monitor/ILonData/SetValueCP", ReplyAction="http://LonData.Monitor/ILonData/SetValueCPResponse")]
        string SetValueCP(string node, string var, string subvar, string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://LonData.Monitor/ILonData/SetValueCPI", ReplyAction="http://LonData.Monitor/ILonData/SetValueCPIResponse")]
        string SetValueCPI(string node, string var, string subvar, int index, string value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://LonData.Monitor/ILonData/GetAlarmValues", ReplyAction="http://LonData.Monitor/ILonData/GetAlarmValuesResponse")]
        string GetAlarmValues(string TableName, string DateFormat);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://LonData.Monitor/ILonData/GetAlarm2", ReplyAction="http://LonData.Monitor/ILonData/GetAlarm2Response")]
        string GetAlarm2(string level, string type, string format);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://LonData.Monitor/ILonData/GetPointsInManual", ReplyAction="http://LonData.Monitor/ILonData/GetPointsInManualResponse")]
        string[] GetPointsInManual();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://LonData.Monitor/ILonData/GetPointsInManualLastCheck", ReplyAction="http://LonData.Monitor/ILonData/GetPointsInManualLastCheckResponse")]
        System.DateTime GetPointsInManualLastCheck();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://LonData.Monitor/ILonData/ClearAlarm", ReplyAction="http://LonData.Monitor/ILonData/ClearAlarmResponse")]
        bool ClearAlarm(string DefIn, string DefOut);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://LonData.Monitor/ILonData/GetCP", ReplyAction="http://LonData.Monitor/ILonData/GetCPResponse")]
        string GetCP(string connectionString, string node, string var);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://LonData.Monitor/ILonData/StartPause", ReplyAction="http://LonData.Monitor/ILonData/StartPauseResponse")]
        bool StartPause();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://LonData.Monitor/ILonData/StopPause", ReplyAction="http://LonData.Monitor/ILonData/StopPauseResponse")]
        bool StopPause();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://LonData.Monitor/ILonData/GetVersion", ReplyAction="http://LonData.Monitor/ILonData/GetVersionResponse")]
        string GetVersion();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILonDataChannel : OnlineToModbusLibrary.LonDataReference.ILonData, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LonDataClient : System.ServiceModel.ClientBase<OnlineToModbusLibrary.LonDataReference.ILonData>, OnlineToModbusLibrary.LonDataReference.ILonData {
        
        public LonDataClient() {
        }
        
        public LonDataClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LonDataClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LonDataClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LonDataClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool GetReady() {
            return base.Channel.GetReady();
        }
        
        public string GetValue(string node, string var, string subvar) {
            return base.Channel.GetValue(node, var, subvar);
        }
        
        public string GetValueCP(string node, string var, string subvar) {
            return base.Channel.GetValueCP(node, var, subvar);
        }
        
        public string GetValueCPI(string node, string var, string subvar, int index) {
            return base.Channel.GetValueCPI(node, var, subvar, index);
        }
        
        public string SetValue(string node, string var, string subvar, string value) {
            return base.Channel.SetValue(node, var, subvar, value);
        }
        
        public string SetValueCP(string node, string var, string subvar, string value) {
            return base.Channel.SetValueCP(node, var, subvar, value);
        }
        
        public string SetValueCPI(string node, string var, string subvar, int index, string value) {
            return base.Channel.SetValueCPI(node, var, subvar, index, value);
        }
        
        public string GetAlarmValues(string TableName, string DateFormat) {
            return base.Channel.GetAlarmValues(TableName, DateFormat);
        }
        
        public string GetAlarm2(string level, string type, string format) {
            return base.Channel.GetAlarm2(level, type, format);
        }
        
        public string[] GetPointsInManual() {
            return base.Channel.GetPointsInManual();
        }
        
        public System.DateTime GetPointsInManualLastCheck() {
            return base.Channel.GetPointsInManualLastCheck();
        }
        
        public bool ClearAlarm(string DefIn, string DefOut) {
            return base.Channel.ClearAlarm(DefIn, DefOut);
        }
        
        public string GetCP(string connectionString, string node, string var) {
            return base.Channel.GetCP(connectionString, node, var);
        }
        
        public bool StartPause() {
            return base.Channel.StartPause();
        }
        
        public bool StopPause() {
            return base.Channel.StopPause();
        }
        
        public string GetVersion() {
            return base.Channel.GetVersion();
        }
    }
}
