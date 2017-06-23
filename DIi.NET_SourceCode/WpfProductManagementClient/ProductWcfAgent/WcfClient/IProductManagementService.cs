﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Runtime.Serialization.ContractNamespaceAttribute("urn:ploeh:productMgtSrvc", ClrNamespace="Ploeh.Samples.ProductManagement.WcfAgent.WcfClient")]

namespace Ploeh.Samples.ProductManagement.WcfAgent.WcfClient
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProductContract", Namespace="urn:ploeh:productMgtSrvc")]
    public partial class ProductContract : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int IdField;
        
        private string NameField;
        
        private Ploeh.Samples.ProductManagement.WcfAgent.WcfClient.MoneyContract UnitPriceField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Ploeh.Samples.ProductManagement.WcfAgent.WcfClient.MoneyContract UnitPrice
        {
            get
            {
                return this.UnitPriceField;
            }
            set
            {
                this.UnitPriceField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MoneyContract", Namespace="urn:ploeh:productMgtSrvc")]
    public partial class MoneyContract : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private decimal AmountField;
        
        private string CurrencyCodeField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal Amount
        {
            get
            {
                return this.AmountField;
            }
            set
            {
                this.AmountField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CurrencyCode
        {
            get
            {
                return this.CurrencyCodeField;
            }
            set
            {
                this.CurrencyCodeField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="urn:ploeh:productMgtSrvc", ConfigurationName="Ploeh.Samples.ProductManagement.WcfAgent.WcfClient.IProductManagementService")]
    public interface IProductManagementService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ploeh:productMgtSrvc/IProductManagementService/DeleteProduct", ReplyAction="urn:ploeh:productMgtSrvc/IProductManagementService/DeleteProductResponse")]
        void DeleteProduct(int productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ploeh:productMgtSrvc/IProductManagementService/InsertProduct", ReplyAction="urn:ploeh:productMgtSrvc/IProductManagementService/InsertProductResponse")]
        void InsertProduct(Ploeh.Samples.ProductManagement.WcfAgent.WcfClient.ProductContract product);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ploeh:productMgtSrvc/IProductManagementService/SelectProduct", ReplyAction="urn:ploeh:productMgtSrvc/IProductManagementService/SelectProductResponse")]
        Ploeh.Samples.ProductManagement.WcfAgent.WcfClient.ProductContract SelectProduct(int productId);
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ploeh:productMgtSrvc/IProductManagementService/SelectAllProducts", ReplyAction="urn:ploeh:productMgtSrvc/IProductManagementService/SelectAllProductsResponse")]
        Ploeh.Samples.ProductManagement.WcfAgent.WcfClient.ProductContract[] SelectAllProducts();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:ploeh:productMgtSrvc/IProductManagementService/UpdateProduct", ReplyAction="urn:ploeh:productMgtSrvc/IProductManagementService/UpdateProductResponse")]
        void UpdateProduct(Ploeh.Samples.ProductManagement.WcfAgent.WcfClient.ProductContract product);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface IProductManagementServiceChannel : Ploeh.Samples.ProductManagement.WcfAgent.WcfClient.IProductManagementService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class ProductManagementServiceClient : System.ServiceModel.ClientBase<Ploeh.Samples.ProductManagement.WcfAgent.WcfClient.IProductManagementService>, Ploeh.Samples.ProductManagement.WcfAgent.WcfClient.IProductManagementService
    {
        
        public ProductManagementServiceClient()
        {
        }
        
        public ProductManagementServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        
        public ProductManagementServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ProductManagementServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        
        public ProductManagementServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public void DeleteProduct(int productId)
        {
            base.Channel.DeleteProduct(productId);
        }
        
        public void InsertProduct(Ploeh.Samples.ProductManagement.WcfAgent.WcfClient.ProductContract product)
        {
            base.Channel.InsertProduct(product);
        }
        
        public Ploeh.Samples.ProductManagement.WcfAgent.WcfClient.ProductContract SelectProduct(int productId)
        {
            return base.Channel.SelectProduct(productId);
        }
        
        public Ploeh.Samples.ProductManagement.WcfAgent.WcfClient.ProductContract[] SelectAllProducts()
        {
            return base.Channel.SelectAllProducts();
        }
        
        public void UpdateProduct(Ploeh.Samples.ProductManagement.WcfAgent.WcfClient.ProductContract product)
        {
            base.Channel.UpdateProduct(product);
        }
    }
}
