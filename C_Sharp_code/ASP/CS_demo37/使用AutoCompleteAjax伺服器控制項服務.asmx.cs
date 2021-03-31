using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace CS_demo37
{
    /// <summary>
    ///使用AutoCompleteAjax伺服器控制項服務 的摘要描述
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // 若要允許使用 ASP.NET AJAX 從指令碼呼叫此 Web 服務，請取消註解下列一行。
     [System.Web.Script.Services.ScriptService]
    public class 使用AutoCompleteAjax伺服器控制項服務 : System.Web.Services.WebService
    {

        //取消using註解
        [WebMethod]
        public string[] GetCompany(string prefixText)
        {
            string[] search;
            DataTable tb = GetData();
            int count = 0;
            foreach (DataRow row in tb.Rows)
            {//查詢每列的CompanyName欄的資料字首是否符合
                if (row["CompanyName"].ToString().StartsWith(prefixText))
                    count++;//紀錄符合筆數
            }
            search = new string[count];//初始化陣列空間為符合的筆數

            int index = 0;
            foreach (DataRow row in tb.Rows)
            {//查詢每列的CompanyName欄的資料字首是否符合
                if (row["CompanyName"].ToString().StartsWith(prefixText))
                    search[index++] = row["CompanyName"].ToString();//符合的資料存到陣列
            }

            return search;
        }
        public DataTable GetData()
        {
            SqlConnection conn = new SqlConnection("Data Source=USER-PC;Initial Catalog=Northwind;Integrated Security=true;");
            string sql = "SELECT * FROM Customers";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds.Tables[0];
        }
    }
}
