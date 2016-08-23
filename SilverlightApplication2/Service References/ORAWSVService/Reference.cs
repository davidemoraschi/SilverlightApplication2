﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 3.0.40818.0
// 
namespace SilverlightApplication2.ORAWSVService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://xmlns.oracle.com/orawsv", ConfigurationName="ORAWSVService.ORAWSVPortType")]
    public interface ORAWSVPortType {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://bertoaldo:8081/orawsv", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.IAsyncResult BeginXMLFromQuery(SilverlightApplication2.ORAWSVService.XMLFromQueryRequest request, System.AsyncCallback callback, object asyncState);
        
        SilverlightApplication2.ORAWSVService.XMLFromQueryResponse EndXMLFromQuery(System.IAsyncResult result);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://xmlns.oracle.com/orawsv")]
    public partial class query : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string[] dDL_textField;
        
        private queryQuery_text query_textField;
        
        private object[] itemsField;
        
        private queryNull_handling null_handlingField;
        
        private bool null_handlingFieldSpecified;
        
        private string max_rowsField;
        
        private string skip_rowsField;
        
        private bool pretty_printField;
        
        private bool pretty_printFieldSpecified;
        
        private string indentation_widthField;
        
        private string rowset_tagField;
        
        private string row_tagField;
        
        private bool item_tags_for_collField;
        
        private bool item_tags_for_collFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DDL_text", Order=0)]
        public string[] DDL_text {
            get {
                return this.dDL_textField;
            }
            set {
                this.dDL_textField = value;
                this.RaisePropertyChanged("DDL_text");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public queryQuery_text query_text {
            get {
                return this.query_textField;
            }
            set {
                this.query_textField = value;
                this.RaisePropertyChanged("query_text");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("bind", typeof(queryBind), Order=2)]
        [System.Xml.Serialization.XmlElementAttribute("bindXML", typeof(System.Xml.Linq.XElement), Order=2)]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
                this.RaisePropertyChanged("Items");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public queryNull_handling null_handling {
            get {
                return this.null_handlingField;
            }
            set {
                this.null_handlingField = value;
                this.RaisePropertyChanged("null_handling");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool null_handlingSpecified {
            get {
                return this.null_handlingFieldSpecified;
            }
            set {
                this.null_handlingFieldSpecified = value;
                this.RaisePropertyChanged("null_handlingSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger", Order=4)]
        public string max_rows {
            get {
                return this.max_rowsField;
            }
            set {
                this.max_rowsField = value;
                this.RaisePropertyChanged("max_rows");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger", Order=5)]
        public string skip_rows {
            get {
                return this.skip_rowsField;
            }
            set {
                this.skip_rowsField = value;
                this.RaisePropertyChanged("skip_rows");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public bool pretty_print {
            get {
                return this.pretty_printField;
            }
            set {
                this.pretty_printField = value;
                this.RaisePropertyChanged("pretty_print");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pretty_printSpecified {
            get {
                return this.pretty_printFieldSpecified;
            }
            set {
                this.pretty_printFieldSpecified = value;
                this.RaisePropertyChanged("pretty_printSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="positiveInteger", Order=7)]
        public string indentation_width {
            get {
                return this.indentation_widthField;
            }
            set {
                this.indentation_widthField = value;
                this.RaisePropertyChanged("indentation_width");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public string rowset_tag {
            get {
                return this.rowset_tagField;
            }
            set {
                this.rowset_tagField = value;
                this.RaisePropertyChanged("rowset_tag");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public string row_tag {
            get {
                return this.row_tagField;
            }
            set {
                this.row_tagField = value;
                this.RaisePropertyChanged("row_tag");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public bool item_tags_for_coll {
            get {
                return this.item_tags_for_collField;
            }
            set {
                this.item_tags_for_collField = value;
                this.RaisePropertyChanged("item_tags_for_coll");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool item_tags_for_collSpecified {
            get {
                return this.item_tags_for_collFieldSpecified;
            }
            set {
                this.item_tags_for_collFieldSpecified = value;
                this.RaisePropertyChanged("item_tags_for_collSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://xmlns.oracle.com/orawsv")]
    public partial class queryQuery_text : object, System.ComponentModel.INotifyPropertyChanged {
        
        private queryQuery_textType typeField;
        
        private bool typeFieldSpecified;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public queryQuery_textType type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
                this.RaisePropertyChanged("type");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified {
            get {
                return this.typeFieldSpecified;
            }
            set {
                this.typeFieldSpecified = value;
                this.RaisePropertyChanged("typeSpecified");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://xmlns.oracle.com/orawsv")]
    public enum queryQuery_textType {
        
        /// <remarks/>
        SQL,
        
        /// <remarks/>
        XQUERY,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://xmlns.oracle.com/orawsv")]
    public partial class queryBind : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string nameField;
        
        private string valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://xmlns.oracle.com/orawsv")]
    public enum queryNull_handling {
        
        /// <remarks/>
        DROP_NULLS,
        
        /// <remarks/>
        NULL_ATTR,
        
        /// <remarks/>
        EMPTY_TAG,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class XMLFromQueryRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xmlns.oracle.com/orawsv", Order=0)]
        public SilverlightApplication2.ORAWSVService.query query;
        
        public XMLFromQueryRequest() {
        }
        
        public XMLFromQueryRequest(SilverlightApplication2.ORAWSVService.query query) {
            this.query = query;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class XMLFromQueryResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://xmlns.oracle.com/orawsv", Order=0)]
        public System.Xml.Linq.XElement queryOut;
        
        public XMLFromQueryResponse() {
        }
        
        public XMLFromQueryResponse(System.Xml.Linq.XElement queryOut) {
            this.queryOut = queryOut;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ORAWSVPortTypeChannel : SilverlightApplication2.ORAWSVService.ORAWSVPortType, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class XMLFromQueryCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public XMLFromQueryCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Xml.Linq.XElement Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Xml.Linq.XElement)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ORAWSVPortTypeClient : System.ServiceModel.ClientBase<SilverlightApplication2.ORAWSVService.ORAWSVPortType>, SilverlightApplication2.ORAWSVService.ORAWSVPortType {
        
        private BeginOperationDelegate onBeginXMLFromQueryDelegate;
        
        private EndOperationDelegate onEndXMLFromQueryDelegate;
        
        private System.Threading.SendOrPostCallback onXMLFromQueryCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public ORAWSVPortTypeClient() {
        }
        
        public ORAWSVPortTypeClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ORAWSVPortTypeClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ORAWSVPortTypeClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ORAWSVPortTypeClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<XMLFromQueryCompletedEventArgs> XMLFromQueryCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult SilverlightApplication2.ORAWSVService.ORAWSVPortType.BeginXMLFromQuery(SilverlightApplication2.ORAWSVService.XMLFromQueryRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginXMLFromQuery(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        private System.IAsyncResult BeginXMLFromQuery(SilverlightApplication2.ORAWSVService.query query, System.AsyncCallback callback, object asyncState) {
            SilverlightApplication2.ORAWSVService.XMLFromQueryRequest inValue = new SilverlightApplication2.ORAWSVService.XMLFromQueryRequest();
            inValue.query = query;
            return ((SilverlightApplication2.ORAWSVService.ORAWSVPortType)(this)).BeginXMLFromQuery(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SilverlightApplication2.ORAWSVService.XMLFromQueryResponse SilverlightApplication2.ORAWSVService.ORAWSVPortType.EndXMLFromQuery(System.IAsyncResult result) {
            return base.Channel.EndXMLFromQuery(result);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        private System.Xml.Linq.XElement EndXMLFromQuery(System.IAsyncResult result) {
            SilverlightApplication2.ORAWSVService.XMLFromQueryResponse retVal = ((SilverlightApplication2.ORAWSVService.ORAWSVPortType)(this)).EndXMLFromQuery(result);
            return retVal.queryOut;
        }
        
        private System.IAsyncResult OnBeginXMLFromQuery(object[] inValues, System.AsyncCallback callback, object asyncState) {
            SilverlightApplication2.ORAWSVService.query query = ((SilverlightApplication2.ORAWSVService.query)(inValues[0]));
            return this.BeginXMLFromQuery(query, callback, asyncState);
        }
        
        private object[] OnEndXMLFromQuery(System.IAsyncResult result) {
            System.Xml.Linq.XElement retVal = this.EndXMLFromQuery(result);
            return new object[] {
                    retVal};
        }
        
        private void OnXMLFromQueryCompleted(object state) {
            if ((this.XMLFromQueryCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.XMLFromQueryCompleted(this, new XMLFromQueryCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void XMLFromQueryAsync(SilverlightApplication2.ORAWSVService.query query) {
            this.XMLFromQueryAsync(query, null);
        }
        
        public void XMLFromQueryAsync(SilverlightApplication2.ORAWSVService.query query, object userState) {
            if ((this.onBeginXMLFromQueryDelegate == null)) {
                this.onBeginXMLFromQueryDelegate = new BeginOperationDelegate(this.OnBeginXMLFromQuery);
            }
            if ((this.onEndXMLFromQueryDelegate == null)) {
                this.onEndXMLFromQueryDelegate = new EndOperationDelegate(this.OnEndXMLFromQuery);
            }
            if ((this.onXMLFromQueryCompletedDelegate == null)) {
                this.onXMLFromQueryCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnXMLFromQueryCompleted);
            }
            base.InvokeAsync(this.onBeginXMLFromQueryDelegate, new object[] {
                        query}, this.onEndXMLFromQueryDelegate, this.onXMLFromQueryCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override SilverlightApplication2.ORAWSVService.ORAWSVPortType CreateChannel() {
            return new ORAWSVPortTypeClientChannel(this);
        }
        
        private class ORAWSVPortTypeClientChannel : ChannelBase<SilverlightApplication2.ORAWSVService.ORAWSVPortType>, SilverlightApplication2.ORAWSVService.ORAWSVPortType {
            
            public ORAWSVPortTypeClientChannel(System.ServiceModel.ClientBase<SilverlightApplication2.ORAWSVService.ORAWSVPortType> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginXMLFromQuery(SilverlightApplication2.ORAWSVService.XMLFromQueryRequest request, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = request;
                System.IAsyncResult _result = base.BeginInvoke("XMLFromQuery", _args, callback, asyncState);
                return _result;
            }
            
            public SilverlightApplication2.ORAWSVService.XMLFromQueryResponse EndXMLFromQuery(System.IAsyncResult result) {
                object[] _args = new object[0];
                SilverlightApplication2.ORAWSVService.XMLFromQueryResponse _result = ((SilverlightApplication2.ORAWSVService.XMLFromQueryResponse)(base.EndInvoke("XMLFromQuery", _args, result)));
                return _result;
            }
        }
    }
}
