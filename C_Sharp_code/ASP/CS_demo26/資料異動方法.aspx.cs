using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo26
{
    public partial class 資料異動方法 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();//連線建立字串物件
            sb.DataSource = "USER-PC";
            sb.InitialCatalog = "Northwind";
            sb.IntegratedSecurity = true;
            sb.UserID = "sa";
            sb.Password = "sa";
            SqlConnection conn = new SqlConnection(sb.ConnectionString);
            string sql = "SELECT * FROM Categories";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();

            Table tb = new Table();
            TableRow tr = new TableRow();
            TableCell tc1 = new TableCell();
            TableCell tc2 = new TableCell();
            TableCell tc3 = new TableCell();
            TableCell tc4 = new TableCell();
            tb.BorderWidth = 1;
            tc1.BorderWidth = 1;
            tc2.BorderWidth = 1;
            tc3.BorderWidth = 1;
            tc4.BorderWidth = 1;

            SqlDataReader sdr = cmd.ExecuteReader();//返回下達sql語法中每個單元格中的資料

            while (sdr.Read())
            {
                //將找到的資料填入列
                //填入單元格
                //單元格填入資料列
                //資料列填入資料表
                tc1.Text = sdr["CategoryID"].ToString();
                tc2.Text = sdr["CategoryName"].ToString();
                tc3.Text = sdr[2].ToString();
                tc4.Text = sdr[3].ToString();
                tr.Cells.Add(tc1);
                tr.Cells.Add(tc2);
                tr.Cells.Add(tc3);
                tr.Cells.Add(tc4);
                tb.Rows.Add(tr);

                //在找到一筆資料後再產生一空白列準備存放下筆資料
                tr = new TableRow();
                tc1 = new TableCell();
                tc2 = new TableCell();
                tc3 = new TableCell();
                tc4 = new TableCell();
                tb.BorderWidth = 1;
                tc1.BorderWidth = 1;
                tc2.BorderWidth = 1;
                tc3.BorderWidth = 1;
                tc4.BorderWidth = 1;

            }
            //將 PlaceHolder 控制元件用作儲存動態新增到網頁的伺服器控制元件的容器。
            //PlaceHolder 控制元件不產生任何可見輸出並且只能用作網頁上其他控制元件的容器。
            PlaceHolder1.Controls.Add(tb);
            conn.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();//連線建立字串物件
            sb.DataSource = "USER-PC";
            sb.InitialCatalog = "Northwind";
            sb.IntegratedSecurity = true;
            sb.UserID = "sa";
            sb.Password = "sa";
            SqlConnection conn = new SqlConnection(sb.ConnectionString);
            string sql = "SELECT COUNT(*) FROM Categories";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            int rs = (int)cmd.ExecuteScalar();

            Label label = new Label();
            label.Text = "筆數:" + rs;
            PlaceHolder1.Controls.Add(label);
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();//連線建立字串物件
            sb.DataSource = "USER-PC";
            sb.InitialCatalog = "Northwind";
            sb.IntegratedSecurity = true;
            sb.UserID = "sa";
            sb.Password = "sa";
            SqlConnection conn = new SqlConnection(sb.ConnectionString);
            string sql = "SELECT * FROM Categories";

            SqlDataAdapter da = new SqlDataAdapter(sql,conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Categories");//透過連結器將資料表存放到DataSet並取名
            DataTable tb = ds.Tables["Categories"];//將資料表存放到tb變數
            DataRow row = tb.NewRow();//table中新增一空白列
            row["CategoryName"] = "3C 電子產品";
            row[2] = "Made In Taiwan";
            tb.Rows.Add(row);//將資料列加入table

            SqlCommandBuilder cmd = new SqlCommandBuilder(da);
            int rs = da.Update(ds.Tables["Categories"]);// 調配器將Table的異動回寫到DB
            Response.Write("異動筆數:" + rs);
        }
    }
}