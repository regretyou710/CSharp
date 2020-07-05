using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
using System.Data.Linq;
using CS_demo35.tw.com.entity;

namespace CS_demo35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //一維陣列會執行IEnumerable<T>泛型介面
            //系統會在執行時間提供這些實作為陣列，因此泛型介面不會出現在 Array 類別的宣告語法中
            //物件初始設定式可讓您在建立期間將值指派給物件的任何可存取欄位或屬性，而不用叫用後面接著幾行指派陳述式的建構函式。
            IEnumerable<Customer> customer = new Customer[] {
            new Customer() { FirstName="A",LastName ="A1",Age=20 },
            new Customer(){FirstName="B" ,LastName="B1",Age=22},
            new Customer(){FirstName="C",LastName="C1",Age=25}
            };


            //取出LastName,傳統方式
            List<string> list = new List<string>();
            foreach (Customer t in customer)
                list.Add(t.LastName);
            foreach (string t in list)
                Console.WriteLine(t);

            //LINQ
            //Select 運算子用於根據資料來源序列中的項目，建立相對應的輸出序列。
            //輸出序列之項目型別可以和原始序列之項目型別相同，也可以不同，這個行為又稱之為「投影」（Projecting）
            //where:用於過濾條件,最後返回資料結構中的元素



            //Query Expression(查詢表達式)
            var rs = from obj in customer select obj.LastName;
            //Fluent Syntax(方法語句)
            //IEnumerable<string> list2 = customer.Select(t => t.LastName);

            foreach (string t in rs)
                Console.WriteLine(t);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] word = { "Apple", "aPPLE", "Banana", "bANANA", "Mamgo", "mAMGO", "x", "y", "z", "X", "Y", "Z" };

            // var rs = word.OrderByDescending(a => a,new MyComparer()).Select(a => a);//使用自訂排序
            var rs = word.OrderByDescending(a => a).Select(a => a);
            foreach (string t in rs)
                Console.Write(t + "\t");
            Console.WriteLine();

        }
        class MyComparer : IComparer<string>
        {
            int IComparer<string>.Compare(string x, string y)
            {
                //return string.CompareOrdinal(x,y);
                return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
                //OrdinalIgnoreCase:忽略大小寫比較,兩者相比為等於,會按照原來的順序排序
                //x>y回傳正,x<y回傳負,x=y回傳0
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IEnumerable<Customer> customer = new Customer[] {
            new Customer() { FirstName="A",LastName ="A1",Age=20 },
            new Customer(){FirstName="B" ,LastName="B1",Age=22},
            new Customer(){FirstName="C",LastName="C1",Age=25}
            };

            //將識別屬性重新命名(使用匿名型別)
            //將集合中的元素依三個屬性列出,按年紀大於18條件篩選,且姓名最後一個字由大到小排序
            var rs = customer.Where(c => c.Age > 18)
                .OrderByDescending(c => c.LastName)
            .Select(c => new { 第一個字 = c.FirstName, 最後一個字 = c.LastName, 年齡 = c.Age });
            //.Select(c => c);


            foreach (var t in rs)
                Console.WriteLine("{0}\t{1}\t{2}", t.第一個字, t.最後一個字, t.年齡);
            //Console.WriteLine("{0}\t{1}\t{2}", t.FirstName, t.LastName, t.Age);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IEnumerable<Customer> customer = new Customer[] {
            new Customer() { FirstName="A",LastName ="A1",Age=20},
            new Customer(){FirstName="D" ,LastName="D1",Age=22},
            new Customer(){FirstName="B" ,LastName="B1",Age=22},
            new Customer(){FirstName="E" ,LastName="E1",Age=24},
            new Customer(){FirstName="C",LastName="C1",Age=25}
            };
            Console.WriteLine("資料筆數:{0}\r\n年齡平均:{1}\r\n最大年齡{2}\r\n最小年齡{3}"
                , customer.Count(), customer.Average(c => c.Age), customer.Max(c => c.Age), customer.Min(c => c.Age));
            Console.WriteLine("移除年齡相同後剩餘筆數:{0}", customer.Select(c => c.Age).Distinct().Count());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //ex:
            //說明：from p in db.Products 表示從表中將產品物件取出來。
            //group p by p.CategoryID into g 表示對p按CategoryID欄位歸類。
            //其結果命名為g，一旦重新命名，p的作用域就結束了，所以，最後select時，只能select g。


            string[] words = { "cherry", "cococnut", "apple", "blueberry", "banana", "almond" };
            //group 資料(w) by 群組依據(資料的第一個字元)
            var rs = from w in words
                     group w by w[0] into grp
                     select
            new { key = grp.Key, index = grp.ElementAt(0), index1 = grp.ElementAt(1) };
            Console.WriteLine("首字分組\t第一筆\t\t第二筆");
            foreach (var t in rs)
                Console.WriteLine("\t{0}\t\t{1}\t\t{2}", t.key, t.index, t.index1);

        }

        private void button6_Click(object sender, EventArgs ev)
        {
            IEnumerable<Employee> emp = new Employee[] {
            new Employee(){FirstName="A",LastName="A1",Age=22,Company="1stcomp"},
            new Employee(){FirstName="B",LastName="B1",Age=25,Company="2ndcomp"},
            new Employee(){FirstName="D",LastName="D1",Age=25,Company="3rdcomp"},
            new Employee(){FirstName="C",LastName="C1",Age=23,Company="2ndcomp"},
            new Employee(){FirstName="E",LastName="E1",Age=20,Company="1stcomp"}
            };

            IEnumerable<Company> comp = new Company[]
            {
                new Company(){CompanyName="1stcomp",Country="HK"},
                new Company(){CompanyName="2ndcomp",Country="TW"},
                new Company(){CompanyName="3rdcomp",Country="US"}
            };

            var rs = emp.Join(comp, e => e.Company, c => c.CompanyName
            , (e, c) => new { e.FirstName, e.LastName, c.Country });


            foreach (var t in rs)
                Console.WriteLine("{0}\t{1}\t{2}", t.FirstName, t.LastName, t.Country);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var list = new List<int>() { 1, 2, 3, 4, 5 };
            var query = list.Select(x =>
            {
                Console.WriteLine($"{x} ");
                return x;
            });
            // 該查詢包含對 Console.Write 的呼叫，但沒有輸出到控制檯。
            //這是因為查詢尚未執行，因此傳遞給 Select 的函式從未被評估過。
            //這稱為延遲執行 - 查詢的執行會延遲到稍後的某個時間點。


            //其他 LINQ 方法強制立即執行查詢; 這些方法執行查詢並生成其值
            var newList = query.ToList();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            IEnumerable<Employee> emp = new Employee[] {
            new Employee(){FirstName="A",LastName="A1",Age=22,Company="1stcomp"},
            new Employee(){FirstName="B",LastName="B1",Age=25,Company="2ndcomp"},
            new Employee(){FirstName="D",LastName="D1",Age=25,Company="3rdcomp"},
            new Employee(){FirstName="C",LastName="C1",Age=23,Company="2ndcomp"},
            new Employee(){FirstName="E",LastName="E1",Age=20,Company="1stcomp"}
            };

            var r = from em in emp select em;
            //以上查詢尚未執行
            var rs = r.ToList<Employee>();//強制立即執行查詢
            foreach (Employee t in rs)
                Console.WriteLine("{0}\t{1}\t{2}", t.FirstName, t.LastName, t.Company);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            IEnumerable<Employee> emp = new Employee[] {
            new Employee(){FirstName="A",LastName="A1",Age=22,Company="1stcomp"},
            new Employee(){FirstName="B",LastName="B1",Age=25,Company="2ndcomp"},
            new Employee(){FirstName="D",LastName="D1",Age=25,Company="3rdcomp"},
            new Employee(){FirstName="C",LastName="C1",Age=23,Company="2ndcomp"},
            new Employee(){FirstName="E",LastName="E1",Age=20,Company="1stcomp"}
            };

            var r = from em in emp select em;
            //以上查詢尚未執行
            var rs = r.ToArray<Employee>();//強制立即執行查詢
            foreach (Employee t in rs)
                Console.WriteLine("{0}\t{1}\t{2}", t.FirstName, t.LastName, t.Company);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //要載入的檔案要放在bin/Debug底下
            XElement xmlfile = XElement.Load("Student.xml");

            var rs = from stu in xmlfile.Elements("student")
                     select new
                     {
                         學號 = (string)stu.Element("no"),
                         姓名 = (string)stu.Element("name"),
                         電話 = (string)stu.Element("tel")
                     };
            var rs1 = from stu in xmlfile.Elements("score")
                      select new
                      {
                          no = (string)stu.Element("no"),
                          math = (string)stu.Element("math"),
                          chinese = (string)stu.Element("chinese")
                      };


            foreach (var t in rs)
                Console.WriteLine("{0}\t{1}\t{2}", t.學號, t.姓名, t.電話);
            foreach (var t in rs1)
                Console.WriteLine("{0}\t{1}\t{2}", t.no, t.math, t.chinese);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            string conString = "Data Source=USER-PC;Initial Catalog=Northwind;Integrated Security=true;";
            DataContext db = new DataContext(conString);
            //從db中取得對應MyCustomer的資料
            Table<MyCustomer> custTable = db.GetTable<MyCustomer>();

            //var rs = from cust in custTable select cust;
            IEnumerable<MyCustomer> rs = custTable.Select(cust => cust);

            foreach (MyCustomer t in rs)
                Console.WriteLine("{0}\t{1}", t.Id, t.ContactName);
            Console.WriteLine("筆數共:" + rs.Count());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //自行建立DataSet資料內容
            DataSet ds = new DataSet();
            //創建table物件
            DataTable table = ds.Tables.Add("Product");
            //創建column物件
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Price", typeof(decimal));

            //創建row物件
            DataRow dr = ds.Tables["Product"].NewRow();

            //Add方式一:
            dr["Name"] = "Apple";
            dr["Price"] = 10.5;
            ds.Tables["Product"].Rows.Add(dr);
            //Add方式二:
            Object[] obj = { "Mengo", 22.5 };
            ds.Tables["Product"].Rows.Add(obj);
            //Add方式三:
            ds.Tables["Product"].Rows.Add("BlueBerry", 32.4);
            ds.Tables["Product"].Rows.Add("Lemon", 18.3);

            //AsEnumerable:返回table每筆資料(放到定義的p)
            var rs = from p in table.AsEnumerable()
                     where p.Field<decimal>("Price") > 20
                     orderby p.Field<decimal>("Price") ascending
                     select new { name = p.Field<string>("Name"), price = p.Field<decimal>("Price") };
            foreach (var t in rs)
                Console.WriteLine("{0}\t{1:C}", t.name, t.price);
        }
    }
}
