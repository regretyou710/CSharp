﻿//------------------------------------------------------------------------------
// <auto-generated>
//    這個程式碼是由範本產生。
//
//    對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//    如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace CS_demo04
{
    #region 內容
    
    /// <summary>
    /// 沒有可用的中繼資料文件。
    /// </summary>
    public partial class AdventureWorks2012Entities : ObjectContext
    {
        #region 建構函式
    
        /// <summary>
        /// 使用在應用程式組態檔的 'AdventureWorks2012Entities' 區段中找到的連接字串，初始化新的 AdventureWorks2012Entities 物件。
        /// </summary>
        public AdventureWorks2012Entities() : base("name=AdventureWorks2012Entities", "AdventureWorks2012Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// 初始化新的 AdventureWorks2012Entities 物件。
        /// </summary>
        public AdventureWorks2012Entities(string connectionString) : base(connectionString, "AdventureWorks2012Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// 初始化新的 AdventureWorks2012Entities 物件。
        /// </summary>
        public AdventureWorks2012Entities(EntityConnection connection) : base(connection, "AdventureWorks2012Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region 部分方法
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet 屬性
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        public ObjectSet<Customer> Customer
        {
            get
            {
                if ((_Customer == null))
                {
                    _Customer = base.CreateObjectSet<Customer>("Customer");
                }
                return _Customer;
            }
        }
        private ObjectSet<Customer> _Customer;

        #endregion

        #region AddTo 方法
    
        /// <summary>
        /// 將新物件加入 Customer EntitySet 的方法已被取代。請考慮改為使用關聯的 ObjectSet&lt;T&gt; 屬性的 .Add 方法。
        /// </summary>
        public void AddToCustomer(Customer customer)
        {
            base.AddObject("Customer", customer);
        }

        #endregion

    }

    #endregion

    #region 實體
    
    /// <summary>
    /// 沒有可用的中繼資料文件。
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="AdventureWorks2012Model", Name="Customer")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Customer : EntityObject
    {
        #region Factory 方法
    
        /// <summary>
        /// 建立新 Customer 物件。
        /// </summary>
        /// <param name="customerID">CustomerID 屬性的初始值。</param>
        /// <param name="accountNumber">AccountNumber 屬性的初始值。</param>
        /// <param name="rowguid">rowguid 屬性的初始值。</param>
        /// <param name="modifiedDate">ModifiedDate 屬性的初始值。</param>
        /// <param name="businessEntityID">BusinessEntityID 屬性的初始值。</param>
        /// <param name="name">Name 屬性的初始值。</param>
        public static Customer CreateCustomer(global::System.Int32 customerID, global::System.String accountNumber, global::System.Guid rowguid, global::System.DateTime modifiedDate, global::System.Int32 businessEntityID, global::System.String name)
        {
            Customer customer = new Customer();
            customer.CustomerID = customerID;
            customer.AccountNumber = accountNumber;
            customer.rowguid = rowguid;
            customer.ModifiedDate = modifiedDate;
            customer.BusinessEntityID = businessEntityID;
            customer.Name = name;
            return customer;
        }

        #endregion

        #region 簡單屬性
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 CustomerID
        {
            get
            {
                return _CustomerID;
            }
            set
            {
                if (_CustomerID != value)
                {
                    OnCustomerIDChanging(value);
                    ReportPropertyChanging("CustomerID");
                    _CustomerID = StructuralObject.SetValidValue(value, "CustomerID");
                    ReportPropertyChanged("CustomerID");
                    OnCustomerIDChanged();
                }
            }
        }
        private global::System.Int32 _CustomerID;
        partial void OnCustomerIDChanging(global::System.Int32 value);
        partial void OnCustomerIDChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> PersonID
        {
            get
            {
                return _PersonID;
            }
            set
            {
                OnPersonIDChanging(value);
                ReportPropertyChanging("PersonID");
                _PersonID = StructuralObject.SetValidValue(value, "PersonID");
                ReportPropertyChanged("PersonID");
                OnPersonIDChanged();
            }
        }
        private Nullable<global::System.Int32> _PersonID;
        partial void OnPersonIDChanging(Nullable<global::System.Int32> value);
        partial void OnPersonIDChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> StoreID
        {
            get
            {
                return _StoreID;
            }
            set
            {
                OnStoreIDChanging(value);
                ReportPropertyChanging("StoreID");
                _StoreID = StructuralObject.SetValidValue(value, "StoreID");
                ReportPropertyChanged("StoreID");
                OnStoreIDChanged();
            }
        }
        private Nullable<global::System.Int32> _StoreID;
        partial void OnStoreIDChanging(Nullable<global::System.Int32> value);
        partial void OnStoreIDChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> TerritoryID
        {
            get
            {
                return _TerritoryID;
            }
            set
            {
                OnTerritoryIDChanging(value);
                ReportPropertyChanging("TerritoryID");
                _TerritoryID = StructuralObject.SetValidValue(value, "TerritoryID");
                ReportPropertyChanged("TerritoryID");
                OnTerritoryIDChanged();
            }
        }
        private Nullable<global::System.Int32> _TerritoryID;
        partial void OnTerritoryIDChanging(Nullable<global::System.Int32> value);
        partial void OnTerritoryIDChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String AccountNumber
        {
            get
            {
                return _AccountNumber;
            }
            set
            {
                OnAccountNumberChanging(value);
                ReportPropertyChanging("AccountNumber");
                _AccountNumber = StructuralObject.SetValidValue(value, true, "AccountNumber");
                ReportPropertyChanged("AccountNumber");
                OnAccountNumberChanged();
            }
        }
        private global::System.String _AccountNumber;
        partial void OnAccountNumberChanging(global::System.String value);
        partial void OnAccountNumberChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Guid rowguid
        {
            get
            {
                return _rowguid;
            }
            set
            {
                OnrowguidChanging(value);
                ReportPropertyChanging("rowguid");
                _rowguid = StructuralObject.SetValidValue(value, "rowguid");
                ReportPropertyChanged("rowguid");
                OnrowguidChanged();
            }
        }
        private global::System.Guid _rowguid;
        partial void OnrowguidChanging(global::System.Guid value);
        partial void OnrowguidChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime ModifiedDate
        {
            get
            {
                return _ModifiedDate;
            }
            set
            {
                OnModifiedDateChanging(value);
                ReportPropertyChanging("ModifiedDate");
                _ModifiedDate = StructuralObject.SetValidValue(value, "ModifiedDate");
                ReportPropertyChanged("ModifiedDate");
                OnModifiedDateChanged();
            }
        }
        private global::System.DateTime _ModifiedDate;
        partial void OnModifiedDateChanging(global::System.DateTime value);
        partial void OnModifiedDateChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 BusinessEntityID
        {
            get
            {
                return _BusinessEntityID;
            }
            set
            {
                if (_BusinessEntityID != value)
                {
                    OnBusinessEntityIDChanging(value);
                    ReportPropertyChanging("BusinessEntityID");
                    _BusinessEntityID = StructuralObject.SetValidValue(value, "BusinessEntityID");
                    ReportPropertyChanged("BusinessEntityID");
                    OnBusinessEntityIDChanged();
                }
            }
        }
        private global::System.Int32 _BusinessEntityID;
        partial void OnBusinessEntityIDChanging(global::System.Int32 value);
        partial void OnBusinessEntityIDChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false, "Name");
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> SalesPersonID
        {
            get
            {
                return _SalesPersonID;
            }
            set
            {
                OnSalesPersonIDChanging(value);
                ReportPropertyChanging("SalesPersonID");
                _SalesPersonID = StructuralObject.SetValidValue(value, "SalesPersonID");
                ReportPropertyChanged("SalesPersonID");
                OnSalesPersonIDChanged();
            }
        }
        private Nullable<global::System.Int32> _SalesPersonID;
        partial void OnSalesPersonIDChanging(Nullable<global::System.Int32> value);
        partial void OnSalesPersonIDChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Demographics
        {
            get
            {
                return _Demographics;
            }
            set
            {
                OnDemographicsChanging(value);
                ReportPropertyChanging("Demographics");
                _Demographics = StructuralObject.SetValidValue(value, true, "Demographics");
                ReportPropertyChanged("Demographics");
                OnDemographicsChanged();
            }
        }
        private global::System.String _Demographics;
        partial void OnDemographicsChanging(global::System.String value);
        partial void OnDemographicsChanged();

        #endregion

    }

    #endregion

}
