using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_demo10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ADO.NET 實體資料模型工具會產生從 ObjectContext (代表概念模型中所定義的實體容器) 衍生而來的類別。
            // ObjectContext 類別支援針對將實體當成物件傳回之概念模型進行查詢，也支援建立、更新和刪除實體物件。
            //ObjectContext實體與概念之間的媒介


            AdventureWorks2012Entities adv = new AdventureWorks2012Entities();
            //查詢實體資料模型中資料
            ObjectQuery<Person> person = adv.Person;
           
            foreach (var t in person)
                Console.WriteLine("{0}\t{1}", t.BusinessEntityID,t.FirstName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdventureWorks2012Entities adv = new AdventureWorks2012Entities();
            ObjectQuery<Person> person = adv.Person;
            // ObjectQuery<T> 實作IEnumerable<T>, 便可使用Linq作條件篩選
            IQueryable<Person> rs = from obj in person where obj.PersonType == "EM" select obj;
            foreach (var t in rs)
                Console.WriteLine("{0}\t{1}", t.BusinessEntityID, t.FirstName);
        }
    }
}
