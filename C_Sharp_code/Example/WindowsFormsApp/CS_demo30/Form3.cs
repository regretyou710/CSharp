using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_demo30
{
    public partial class Form3 : Form
    {
        const string conString = @"Data Source=USER-PC;Initial Catalog=School;Integrated Security=True;";
        DataSet ds = new DataSet();
        public Form3()
        {
            InitializeComponent();

        }


        private void Form3_Load(object sender, EventArgs e)
        {
            //建立連線物件
            SqlConnection conn = new SqlConnection(conString);
            string sql = "SELECT * FROM Student;SELECT * FROM Score;";


            //建立調配器將連線物件和sql與法傳入
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);


            //將DataSet以屬性宣告,透過調配器將資料表填至DataSet
            //sda.Fill(ds);           
            sda.Fill(ds, "Student");

            //DataSet中的表單結果集呈現DataGrid
            dataGridView1.DataSource = ds.Tables[0];
            //另一種表達方式,指定名為Student的表單
            //dataGridView1.DataSource = ds.Tables["Student"];

            //DataSet中的rows集合的第一列
            //DataRow rows = ds.Tables[0].Rows[0];
            ////將第一筆資料顯示在textbox
            //textBox1.Text = rows[0].ToString();
            //textBox2.Text = rows[1].ToString();
            //textBox3.Text = rows[2].ToString();
            //textBox4.Text = rows[3].ToString();



        }
        private void button1_Click(object sender, EventArgs e)
        {
            //清空顯示
            dataGridView1.DataSource = null;
            //在DataSet中的Student Table新增一個空列
            DataRow row = ds.Tables["Student"].NewRow();
            //將textbox的信息填入空列
            //row[0] = textBox1.Text;
            row[1] = textBox2.Text;
            row["Age"] = textBox3.Text;
            row["Major"] = textBox4.Text;
            //將產生的列加入DataSet的集合
            ds.Tables["Student"].Rows.Add(row);
            //顯示
            dataGridView1.DataSource = ds.Tables["Student"];
        }

        private void button5_Click(object sender, EventArgs e)
        {   //建立連線物件
            SqlConnection conn = new SqlConnection(conString);
            string sql = "SELECT * FROM Student;SELECT * FROM Score;";

            //建立調配器將連線物件和sql與法傳入
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            //DataAdapter有CRUD 4種command而.NET有提供commandBulider整合4個方法不用各別呼叫使用
            //把DataAdapter當作CommandBulder建構子參數傳遞,CommandBulder會根據DataAdapter的
            //sql的select語法產生另外3個對應sqlcommand
            SqlCommandBuilder cmd = new SqlCommandBuilder(sda);
            int rs = sda.Update(ds.Tables["Student"]);//調配器將Table的異動回寫到DB
            MessageBox.Show("異動" + rs + "筆資料");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //透過textbox對DataGridView做異動
            DataRow row = ds.Tables["Student"].Rows[0];
            //row[0] = textBox1.Text;
            row[1] = textBox2.Text;
            row["Age"] = textBox3.Text;
            row["Major"] = textBox4.Text;
            dataGridView1.DataSource = ds.Tables["Student"];
        }

        private void button4_Click(object sender, EventArgs e)
        {   //取得未回寫資料庫前的異動情況
            DataTable change = ds.Tables["Student"].GetChanges();
            dataGridView1.DataSource = change;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //刪除資料
            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
                if (!r.IsNewRow)
                {
                    dataGridView1.Rows.Remove(r);
                }
            }
            //ds.Tables["Student"].Rows[0].Delete();//指定某列刪除
            dataGridView1.DataSource = ds.Tables["Student"];
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
                textBox1.Text = r.Cells[0].Value.ToString();
                textBox2.Text = r.Cells[1].Value.ToString();
                textBox3.Text = r.Cells[2].Value.ToString();
                textBox4.Text = r.Cells[3].Value.ToString();
            }
        }
    }
}
