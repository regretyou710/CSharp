using CS_demo08;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_demo09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //查詢實體資料模型中資料
            AdventureWorks2012Entities adv = new AdventureWorks2012Entities();
            var entity = adv.SalesOrderHeader;
            foreach (var t in entity)
                Console.WriteLine("{0}\t{1}",t.SalesOrderID,t.SalesOrderNumber);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //使用預儲程序
            AdventureWorks2012Entities adv = new AdventureWorks2012Entities();
            var procedure = adv.uspCountOrder(5);
            foreach (var t in procedure)
                Console.WriteLine("{0}", t.Value);
        }
    }
}
