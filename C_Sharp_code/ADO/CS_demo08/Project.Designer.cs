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
namespace CS_demo08
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
        public ObjectSet<SalesOrderHeader> SalesOrderHeader
        {
            get
            {
                if ((_SalesOrderHeader == null))
                {
                    _SalesOrderHeader = base.CreateObjectSet<SalesOrderHeader>("SalesOrderHeader");
                }
                return _SalesOrderHeader;
            }
        }
        private ObjectSet<SalesOrderHeader> _SalesOrderHeader;

        #endregion

        #region AddTo 方法
    
        /// <summary>
        /// 將新物件加入 SalesOrderHeader EntitySet 的方法已被取代。請考慮改為使用關聯的 ObjectSet&lt;T&gt; 屬性的 .Add 方法。
        /// </summary>
        public void AddToSalesOrderHeader(SalesOrderHeader salesOrderHeader)
        {
            base.AddObject("SalesOrderHeader", salesOrderHeader);
        }

        #endregion

        #region Function Imports
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        /// <param name="territoryID">沒有可用的中繼資料文件。</param>
        public ObjectResult<Nullable<global::System.Int32>> uspCountOrder(Nullable<global::System.Int32> territoryID)
        {
            ObjectParameter territoryIDParameter;
            if (territoryID.HasValue)
            {
                territoryIDParameter = new ObjectParameter("TerritoryID", territoryID);
            }
            else
            {
                territoryIDParameter = new ObjectParameter("TerritoryID", typeof(global::System.Int32));
            }
    
            return base.ExecuteFunction<Nullable<global::System.Int32>>("uspCountOrder", territoryIDParameter);
        }

        #endregion

    }

    #endregion

    #region 實體
    
    /// <summary>
    /// 沒有可用的中繼資料文件。
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="AdventureWorks2012Model", Name="SalesOrderHeader")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class SalesOrderHeader : EntityObject
    {
        #region Factory 方法
    
        /// <summary>
        /// 建立新 SalesOrderHeader 物件。
        /// </summary>
        /// <param name="salesOrderID">SalesOrderID 屬性的初始值。</param>
        /// <param name="revisionNumber">RevisionNumber 屬性的初始值。</param>
        /// <param name="orderDate">OrderDate 屬性的初始值。</param>
        /// <param name="dueDate">DueDate 屬性的初始值。</param>
        /// <param name="status">Status 屬性的初始值。</param>
        /// <param name="onlineOrderFlag">OnlineOrderFlag 屬性的初始值。</param>
        /// <param name="salesOrderNumber">SalesOrderNumber 屬性的初始值。</param>
        /// <param name="customerID">CustomerID 屬性的初始值。</param>
        /// <param name="billToAddressID">BillToAddressID 屬性的初始值。</param>
        /// <param name="shipToAddressID">ShipToAddressID 屬性的初始值。</param>
        /// <param name="shipMethodID">ShipMethodID 屬性的初始值。</param>
        /// <param name="subTotal">SubTotal 屬性的初始值。</param>
        /// <param name="taxAmt">TaxAmt 屬性的初始值。</param>
        /// <param name="freight">Freight 屬性的初始值。</param>
        /// <param name="totalDue">TotalDue 屬性的初始值。</param>
        /// <param name="rowguid">rowguid 屬性的初始值。</param>
        /// <param name="modifiedDate">ModifiedDate 屬性的初始值。</param>
        public static SalesOrderHeader CreateSalesOrderHeader(global::System.Int32 salesOrderID, global::System.Byte revisionNumber, global::System.DateTime orderDate, global::System.DateTime dueDate, global::System.Byte status, global::System.Boolean onlineOrderFlag, global::System.String salesOrderNumber, global::System.Int32 customerID, global::System.Int32 billToAddressID, global::System.Int32 shipToAddressID, global::System.Int32 shipMethodID, global::System.Decimal subTotal, global::System.Decimal taxAmt, global::System.Decimal freight, global::System.Decimal totalDue, global::System.Guid rowguid, global::System.DateTime modifiedDate)
        {
            SalesOrderHeader salesOrderHeader = new SalesOrderHeader();
            salesOrderHeader.SalesOrderID = salesOrderID;
            salesOrderHeader.RevisionNumber = revisionNumber;
            salesOrderHeader.OrderDate = orderDate;
            salesOrderHeader.DueDate = dueDate;
            salesOrderHeader.Status = status;
            salesOrderHeader.OnlineOrderFlag = onlineOrderFlag;
            salesOrderHeader.SalesOrderNumber = salesOrderNumber;
            salesOrderHeader.CustomerID = customerID;
            salesOrderHeader.BillToAddressID = billToAddressID;
            salesOrderHeader.ShipToAddressID = shipToAddressID;
            salesOrderHeader.ShipMethodID = shipMethodID;
            salesOrderHeader.SubTotal = subTotal;
            salesOrderHeader.TaxAmt = taxAmt;
            salesOrderHeader.Freight = freight;
            salesOrderHeader.TotalDue = totalDue;
            salesOrderHeader.rowguid = rowguid;
            salesOrderHeader.ModifiedDate = modifiedDate;
            return salesOrderHeader;
        }

        #endregion

        #region 簡單屬性
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 SalesOrderID
        {
            get
            {
                return _SalesOrderID;
            }
            set
            {
                if (_SalesOrderID != value)
                {
                    OnSalesOrderIDChanging(value);
                    ReportPropertyChanging("SalesOrderID");
                    _SalesOrderID = StructuralObject.SetValidValue(value, "SalesOrderID");
                    ReportPropertyChanged("SalesOrderID");
                    OnSalesOrderIDChanged();
                }
            }
        }
        private global::System.Int32 _SalesOrderID;
        partial void OnSalesOrderIDChanging(global::System.Int32 value);
        partial void OnSalesOrderIDChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Byte RevisionNumber
        {
            get
            {
                return _RevisionNumber;
            }
            set
            {
                OnRevisionNumberChanging(value);
                ReportPropertyChanging("RevisionNumber");
                _RevisionNumber = StructuralObject.SetValidValue(value, "RevisionNumber");
                ReportPropertyChanged("RevisionNumber");
                OnRevisionNumberChanged();
            }
        }
        private global::System.Byte _RevisionNumber;
        partial void OnRevisionNumberChanging(global::System.Byte value);
        partial void OnRevisionNumberChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime OrderDate
        {
            get
            {
                return _OrderDate;
            }
            set
            {
                OnOrderDateChanging(value);
                ReportPropertyChanging("OrderDate");
                _OrderDate = StructuralObject.SetValidValue(value, "OrderDate");
                ReportPropertyChanged("OrderDate");
                OnOrderDateChanged();
            }
        }
        private global::System.DateTime _OrderDate;
        partial void OnOrderDateChanging(global::System.DateTime value);
        partial void OnOrderDateChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime DueDate
        {
            get
            {
                return _DueDate;
            }
            set
            {
                OnDueDateChanging(value);
                ReportPropertyChanging("DueDate");
                _DueDate = StructuralObject.SetValidValue(value, "DueDate");
                ReportPropertyChanged("DueDate");
                OnDueDateChanged();
            }
        }
        private global::System.DateTime _DueDate;
        partial void OnDueDateChanging(global::System.DateTime value);
        partial void OnDueDateChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> ShipDate
        {
            get
            {
                return _ShipDate;
            }
            set
            {
                OnShipDateChanging(value);
                ReportPropertyChanging("ShipDate");
                _ShipDate = StructuralObject.SetValidValue(value, "ShipDate");
                ReportPropertyChanged("ShipDate");
                OnShipDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _ShipDate;
        partial void OnShipDateChanging(Nullable<global::System.DateTime> value);
        partial void OnShipDateChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Byte Status
        {
            get
            {
                return _Status;
            }
            set
            {
                OnStatusChanging(value);
                ReportPropertyChanging("Status");
                _Status = StructuralObject.SetValidValue(value, "Status");
                ReportPropertyChanged("Status");
                OnStatusChanged();
            }
        }
        private global::System.Byte _Status;
        partial void OnStatusChanging(global::System.Byte value);
        partial void OnStatusChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean OnlineOrderFlag
        {
            get
            {
                return _OnlineOrderFlag;
            }
            set
            {
                OnOnlineOrderFlagChanging(value);
                ReportPropertyChanging("OnlineOrderFlag");
                _OnlineOrderFlag = StructuralObject.SetValidValue(value, "OnlineOrderFlag");
                ReportPropertyChanged("OnlineOrderFlag");
                OnOnlineOrderFlagChanged();
            }
        }
        private global::System.Boolean _OnlineOrderFlag;
        partial void OnOnlineOrderFlagChanging(global::System.Boolean value);
        partial void OnOnlineOrderFlagChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String SalesOrderNumber
        {
            get
            {
                return _SalesOrderNumber;
            }
            set
            {
                OnSalesOrderNumberChanging(value);
                ReportPropertyChanging("SalesOrderNumber");
                _SalesOrderNumber = StructuralObject.SetValidValue(value, true, "SalesOrderNumber");
                ReportPropertyChanged("SalesOrderNumber");
                OnSalesOrderNumberChanged();
            }
        }
        private global::System.String _SalesOrderNumber;
        partial void OnSalesOrderNumberChanging(global::System.String value);
        partial void OnSalesOrderNumberChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String PurchaseOrderNumber
        {
            get
            {
                return _PurchaseOrderNumber;
            }
            set
            {
                OnPurchaseOrderNumberChanging(value);
                ReportPropertyChanging("PurchaseOrderNumber");
                _PurchaseOrderNumber = StructuralObject.SetValidValue(value, true, "PurchaseOrderNumber");
                ReportPropertyChanged("PurchaseOrderNumber");
                OnPurchaseOrderNumberChanged();
            }
        }
        private global::System.String _PurchaseOrderNumber;
        partial void OnPurchaseOrderNumberChanging(global::System.String value);
        partial void OnPurchaseOrderNumberChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
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
        public global::System.Int32 CustomerID
        {
            get
            {
                return _CustomerID;
            }
            set
            {
                OnCustomerIDChanging(value);
                ReportPropertyChanging("CustomerID");
                _CustomerID = StructuralObject.SetValidValue(value, "CustomerID");
                ReportPropertyChanged("CustomerID");
                OnCustomerIDChanged();
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
        public global::System.Int32 BillToAddressID
        {
            get
            {
                return _BillToAddressID;
            }
            set
            {
                OnBillToAddressIDChanging(value);
                ReportPropertyChanging("BillToAddressID");
                _BillToAddressID = StructuralObject.SetValidValue(value, "BillToAddressID");
                ReportPropertyChanged("BillToAddressID");
                OnBillToAddressIDChanged();
            }
        }
        private global::System.Int32 _BillToAddressID;
        partial void OnBillToAddressIDChanging(global::System.Int32 value);
        partial void OnBillToAddressIDChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ShipToAddressID
        {
            get
            {
                return _ShipToAddressID;
            }
            set
            {
                OnShipToAddressIDChanging(value);
                ReportPropertyChanging("ShipToAddressID");
                _ShipToAddressID = StructuralObject.SetValidValue(value, "ShipToAddressID");
                ReportPropertyChanged("ShipToAddressID");
                OnShipToAddressIDChanged();
            }
        }
        private global::System.Int32 _ShipToAddressID;
        partial void OnShipToAddressIDChanging(global::System.Int32 value);
        partial void OnShipToAddressIDChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ShipMethodID
        {
            get
            {
                return _ShipMethodID;
            }
            set
            {
                OnShipMethodIDChanging(value);
                ReportPropertyChanging("ShipMethodID");
                _ShipMethodID = StructuralObject.SetValidValue(value, "ShipMethodID");
                ReportPropertyChanged("ShipMethodID");
                OnShipMethodIDChanged();
            }
        }
        private global::System.Int32 _ShipMethodID;
        partial void OnShipMethodIDChanging(global::System.Int32 value);
        partial void OnShipMethodIDChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> CreditCardID
        {
            get
            {
                return _CreditCardID;
            }
            set
            {
                OnCreditCardIDChanging(value);
                ReportPropertyChanging("CreditCardID");
                _CreditCardID = StructuralObject.SetValidValue(value, "CreditCardID");
                ReportPropertyChanged("CreditCardID");
                OnCreditCardIDChanged();
            }
        }
        private Nullable<global::System.Int32> _CreditCardID;
        partial void OnCreditCardIDChanging(Nullable<global::System.Int32> value);
        partial void OnCreditCardIDChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CreditCardApprovalCode
        {
            get
            {
                return _CreditCardApprovalCode;
            }
            set
            {
                OnCreditCardApprovalCodeChanging(value);
                ReportPropertyChanging("CreditCardApprovalCode");
                _CreditCardApprovalCode = StructuralObject.SetValidValue(value, true, "CreditCardApprovalCode");
                ReportPropertyChanged("CreditCardApprovalCode");
                OnCreditCardApprovalCodeChanged();
            }
        }
        private global::System.String _CreditCardApprovalCode;
        partial void OnCreditCardApprovalCodeChanging(global::System.String value);
        partial void OnCreditCardApprovalCodeChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> CurrencyRateID
        {
            get
            {
                return _CurrencyRateID;
            }
            set
            {
                OnCurrencyRateIDChanging(value);
                ReportPropertyChanging("CurrencyRateID");
                _CurrencyRateID = StructuralObject.SetValidValue(value, "CurrencyRateID");
                ReportPropertyChanged("CurrencyRateID");
                OnCurrencyRateIDChanged();
            }
        }
        private Nullable<global::System.Int32> _CurrencyRateID;
        partial void OnCurrencyRateIDChanging(Nullable<global::System.Int32> value);
        partial void OnCurrencyRateIDChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal SubTotal
        {
            get
            {
                return _SubTotal;
            }
            set
            {
                OnSubTotalChanging(value);
                ReportPropertyChanging("SubTotal");
                _SubTotal = StructuralObject.SetValidValue(value, "SubTotal");
                ReportPropertyChanged("SubTotal");
                OnSubTotalChanged();
            }
        }
        private global::System.Decimal _SubTotal;
        partial void OnSubTotalChanging(global::System.Decimal value);
        partial void OnSubTotalChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal TaxAmt
        {
            get
            {
                return _TaxAmt;
            }
            set
            {
                OnTaxAmtChanging(value);
                ReportPropertyChanging("TaxAmt");
                _TaxAmt = StructuralObject.SetValidValue(value, "TaxAmt");
                ReportPropertyChanged("TaxAmt");
                OnTaxAmtChanged();
            }
        }
        private global::System.Decimal _TaxAmt;
        partial void OnTaxAmtChanging(global::System.Decimal value);
        partial void OnTaxAmtChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal Freight
        {
            get
            {
                return _Freight;
            }
            set
            {
                OnFreightChanging(value);
                ReportPropertyChanging("Freight");
                _Freight = StructuralObject.SetValidValue(value, "Freight");
                ReportPropertyChanged("Freight");
                OnFreightChanged();
            }
        }
        private global::System.Decimal _Freight;
        partial void OnFreightChanging(global::System.Decimal value);
        partial void OnFreightChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal TotalDue
        {
            get
            {
                return _TotalDue;
            }
            set
            {
                OnTotalDueChanging(value);
                ReportPropertyChanging("TotalDue");
                _TotalDue = StructuralObject.SetValidValue(value, "TotalDue");
                ReportPropertyChanged("TotalDue");
                OnTotalDueChanged();
            }
        }
        private global::System.Decimal _TotalDue;
        partial void OnTotalDueChanging(global::System.Decimal value);
        partial void OnTotalDueChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Comment
        {
            get
            {
                return _Comment;
            }
            set
            {
                OnCommentChanging(value);
                ReportPropertyChanging("Comment");
                _Comment = StructuralObject.SetValidValue(value, true, "Comment");
                ReportPropertyChanged("Comment");
                OnCommentChanged();
            }
        }
        private global::System.String _Comment;
        partial void OnCommentChanging(global::System.String value);
        partial void OnCommentChanged();
    
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

        #endregion

    }

    #endregion

}