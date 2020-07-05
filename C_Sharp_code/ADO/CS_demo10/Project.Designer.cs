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
namespace CS_demo10
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
        public ObjectSet<Person> Person
        {
            get
            {
                if ((_Person == null))
                {
                    _Person = base.CreateObjectSet<Person>("Person");
                }
                return _Person;
            }
        }
        private ObjectSet<Person> _Person;

        #endregion

        #region AddTo 方法
    
        /// <summary>
        /// 將新物件加入 Person EntitySet 的方法已被取代。請考慮改為使用關聯的 ObjectSet&lt;T&gt; 屬性的 .Add 方法。
        /// </summary>
        public void AddToPerson(Person person)
        {
            base.AddObject("Person", person);
        }

        #endregion

    }

    #endregion

    #region 實體
    
    /// <summary>
    /// 沒有可用的中繼資料文件。
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="AdventureWorks2012Model", Name="Person")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Person : EntityObject
    {
        #region Factory 方法
    
        /// <summary>
        /// 建立新 Person 物件。
        /// </summary>
        /// <param name="businessEntityID">BusinessEntityID 屬性的初始值。</param>
        /// <param name="personType">PersonType 屬性的初始值。</param>
        /// <param name="nameStyle">NameStyle 屬性的初始值。</param>
        /// <param name="firstName">FirstName 屬性的初始值。</param>
        /// <param name="lastName">LastName 屬性的初始值。</param>
        /// <param name="emailPromotion">EmailPromotion 屬性的初始值。</param>
        /// <param name="rowguid">rowguid 屬性的初始值。</param>
        /// <param name="modifiedDate">ModifiedDate 屬性的初始值。</param>
        public static Person CreatePerson(global::System.Int32 businessEntityID, global::System.String personType, global::System.Boolean nameStyle, global::System.String firstName, global::System.String lastName, global::System.Int32 emailPromotion, global::System.Guid rowguid, global::System.DateTime modifiedDate)
        {
            Person person = new Person();
            person.BusinessEntityID = businessEntityID;
            person.PersonType = personType;
            person.NameStyle = nameStyle;
            person.FirstName = firstName;
            person.LastName = lastName;
            person.EmailPromotion = emailPromotion;
            person.rowguid = rowguid;
            person.ModifiedDate = modifiedDate;
            return person;
        }

        #endregion

        #region 簡單屬性
    
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
        public global::System.String PersonType
        {
            get
            {
                return _PersonType;
            }
            set
            {
                OnPersonTypeChanging(value);
                ReportPropertyChanging("PersonType");
                _PersonType = StructuralObject.SetValidValue(value, false, "PersonType");
                ReportPropertyChanged("PersonType");
                OnPersonTypeChanged();
            }
        }
        private global::System.String _PersonType;
        partial void OnPersonTypeChanging(global::System.String value);
        partial void OnPersonTypeChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean NameStyle
        {
            get
            {
                return _NameStyle;
            }
            set
            {
                OnNameStyleChanging(value);
                ReportPropertyChanging("NameStyle");
                _NameStyle = StructuralObject.SetValidValue(value, "NameStyle");
                ReportPropertyChanged("NameStyle");
                OnNameStyleChanged();
            }
        }
        private global::System.Boolean _NameStyle;
        partial void OnNameStyleChanging(global::System.Boolean value);
        partial void OnNameStyleChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Title
        {
            get
            {
                return _Title;
            }
            set
            {
                OnTitleChanging(value);
                ReportPropertyChanging("Title");
                _Title = StructuralObject.SetValidValue(value, true, "Title");
                ReportPropertyChanged("Title");
                OnTitleChanged();
            }
        }
        private global::System.String _Title;
        partial void OnTitleChanging(global::System.String value);
        partial void OnTitleChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, false, "FirstName");
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String MiddleName
        {
            get
            {
                return _MiddleName;
            }
            set
            {
                OnMiddleNameChanging(value);
                ReportPropertyChanging("MiddleName");
                _MiddleName = StructuralObject.SetValidValue(value, true, "MiddleName");
                ReportPropertyChanged("MiddleName");
                OnMiddleNameChanged();
            }
        }
        private global::System.String _MiddleName;
        partial void OnMiddleNameChanging(global::System.String value);
        partial void OnMiddleNameChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, false, "LastName");
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Suffix
        {
            get
            {
                return _Suffix;
            }
            set
            {
                OnSuffixChanging(value);
                ReportPropertyChanging("Suffix");
                _Suffix = StructuralObject.SetValidValue(value, true, "Suffix");
                ReportPropertyChanged("Suffix");
                OnSuffixChanged();
            }
        }
        private global::System.String _Suffix;
        partial void OnSuffixChanging(global::System.String value);
        partial void OnSuffixChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 EmailPromotion
        {
            get
            {
                return _EmailPromotion;
            }
            set
            {
                OnEmailPromotionChanging(value);
                ReportPropertyChanging("EmailPromotion");
                _EmailPromotion = StructuralObject.SetValidValue(value, "EmailPromotion");
                ReportPropertyChanged("EmailPromotion");
                OnEmailPromotionChanged();
            }
        }
        private global::System.Int32 _EmailPromotion;
        partial void OnEmailPromotionChanging(global::System.Int32 value);
        partial void OnEmailPromotionChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String AdditionalContactInfo
        {
            get
            {
                return _AdditionalContactInfo;
            }
            set
            {
                OnAdditionalContactInfoChanging(value);
                ReportPropertyChanging("AdditionalContactInfo");
                _AdditionalContactInfo = StructuralObject.SetValidValue(value, true, "AdditionalContactInfo");
                ReportPropertyChanged("AdditionalContactInfo");
                OnAdditionalContactInfoChanged();
            }
        }
        private global::System.String _AdditionalContactInfo;
        partial void OnAdditionalContactInfoChanging(global::System.String value);
        partial void OnAdditionalContactInfoChanged();
    
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
