using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CS_demo35.tw.com.entity
{
    /// <summary>    
    /// System.Data.Linq.Mapping 命名空間包含用來產生 LINQ to SQL 物件模型的類別，
    /// 這個物件模型表示關聯式資料庫的結構和內容。
    /// 將System.Data.Linq加入參考->架構
    /// </summary>
    [Table(Name = "dbo.Customers")]
    public class MyCustomer
    {
        private string _id;
        private string _contactName;
        [Column(Name = "CustomerID",Storage ="_id",IsPrimaryKey =true, IsDbGenerated =false)]
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [Column(Name = "[ContactName]", Storage = "_contactName")]
        public string ContactName
        {
            get { return _contactName; }
            set { _contactName = value; }
        }
    }
}
