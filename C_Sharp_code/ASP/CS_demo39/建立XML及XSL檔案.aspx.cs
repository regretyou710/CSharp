using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Xsl;

namespace CS_demo39
{
    public partial class 建立XML及XSL檔案 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string conStr = "Data Source=USER-PC;Initial Catalog=Northwind;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(conStr);
            string sql = "SELECT EmployeeID,FirstName,LastName,Title FROM Employees";
            SqlDataAdapter da = new SqlDataAdapter(sql,conn);
            DataSet ds = new DataSet();
            da.Fill(ds,"Employees");
            ds.WriteXml(Server.MapPath(".")+"\\emps.xml");
            
            Response.Write("Work Done..");
        }
    }
}