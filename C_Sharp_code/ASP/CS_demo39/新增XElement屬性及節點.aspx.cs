using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace CS_demo39
{
    public partial class 新增XElement屬性及節點 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string conStr = "Data Source=USER-PC;Initial Catalog=Northwind;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(conStr);
            string sql = "SELECT EmployeeID,FirstName,LastName,Title FROM Employees";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Employees");

            IEnumerable<DataRow> rows = from table in ds.Tables["Employees"].AsEnumerable()
                                        where table.Field<int>("EmployeeID") < 5
                                        select table;
            var xmlObj = from content in rows
                         select new XElement(
                            "Employee", new XAttribute("EmployeeID", content.Field<int>("EmployeeID")),
                            new XAttribute("FirstName", content.Field<string>("FirstName")),
                            new XAttribute("LastName", content.Field<string>("LastName")),
                            new XAttribute("Title", content.Field<string>("Title"))
                            );

            XElement xml = new XElement("Employees", xmlObj);
            XmlDataSource1.DataFile = "";
            XmlDataSource1.Data = xml.ToString();
            GridView1.DataSourceID = XmlDataSource1.ID;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string conStr = "Data Source=USER-PC;Initial Catalog=Northwind;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(conStr);
            string sql = "SELECT EmployeeID,FirstName,LastName,Title FROM Employees";
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Employees");

            IEnumerable<DataRow> rows = from table in ds.Tables["Employees"].AsEnumerable()
                                        where table.Field<int>("EmployeeID") < 5
                                        select table;
            var xmlObj = from content in rows
                         select new XElement(
                           "Employee", new XAttribute("EmployeeID", content.Field<int>("EmployeeID")),
                           new XAttribute("FirstName", content.Field<string>("FirstName")),
                           new XAttribute("LastName", content.Field<string>("LastName")),
                           new XAttribute("Title", content.Field<string>("Title"))
                           );

            XElement xml = new XElement("Employees", xmlObj);
            //Insert
            XElement element = new XElement("Employees",
                           new XAttribute("EmployeeID","E01"),
                           new XAttribute("FirstName", "New FirstName"),
                           new XAttribute("LastName", "New LastName"),
                           new XAttribute("Title", "New Title")
                );
           
            xml.Add(element);
            XmlDataSource1.DataFile = "";
            XmlDataSource1.Data = xml.ToString();
            GridView1.DataSourceID = XmlDataSource1.ID;
        }
    }
}