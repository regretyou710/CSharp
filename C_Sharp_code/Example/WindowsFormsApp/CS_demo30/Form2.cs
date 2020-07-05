using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CS_demo30
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        const string conString = @"Data Source=USER-PC;Initial Catalog=School;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            //ExecuteScalar用於查詢,返回結果節第一列第一行的資料
            //加入using System.Data.SqlClient;            
            SqlConnection conn = new SqlConnection(conString);
            string sql = "SELECT COUNT(*) FROM Student";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            int rows = (int)cmd.ExecuteScalar();
            MessageBox.Show("Rows:" + rows);
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ExecuteReader用於查詢            
            SqlConnection conn = new SqlConnection(conString);
            string sql = "SELECT * FROM Student";
            SqlCommand cmd = new SqlCommand(sql, conn);
			conn.Open();
            SqlDataReader sdr = cmd.ExecuteReader();//返回下達sql語法中每個單元格中的資料
            while (sdr.Read())
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", sdr[0], sdr[1], sdr["Age"], sdr["Major"]);
            }
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //ExecuteNonQuery用於資料增刪修            
            SqlConnection conn = new SqlConnection(conString);
            string sql = "INSERT INTO Student (Name,Age,Major) VALUES ('Jacky',21,'English'),('Rose',20,'English'),('Tom',20,'Math')";
            //string sql = "UPDATE Student SET Major='Math' WHERE No=4";
            //string sql = "DELETE FROM Student WHERE No in(5,6,7,8)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            //回傳筆數
            int rows = (int)cmd.ExecuteNonQuery();
            MessageBox.Show("Rows:" + rows);
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //將資料查詢結果寫出成XML檔案
            SqlConnection conn = new SqlConnection(conString);
            string sql = "SELECT * FROM Student;SELECT Name FROM Student;";
            //建立DataAdapter
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            //建立DataSet
            DataSet ds = new DataSet();
            //將資料來源藉由DataAdapter填入DataSet
            sda.Fill(ds);
            ds.WriteXml("Student.xml");
            Console.WriteLine("寫出完畢");
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //將XML檔案讀取進DataSet
            DataSet ds = new DataSet();
            ds.ReadXml("Student.xml");
            //將DataSet結果集 index=0 顯示在DataGrid
            dataGridView1.DataSource = ds.Tables[0];
            //將DataSet結果集 index=1 顯示在DataGrid
            dataGridView2.DataSource = ds.Tables[1];
        }
    }
}
