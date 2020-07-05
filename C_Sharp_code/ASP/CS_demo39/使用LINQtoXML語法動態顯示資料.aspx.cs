using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace CS_demo39
{
    public partial class 使用LINQtoXML語法動態顯示資料 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            XElement xml = XElement.Load(Server.MapPath("emps.xml"));
            IEnumerable<XElement> table = from t in xml.Elements() select t;

            string data = "";

            foreach (XElement t in table)
            {
                XElement element = null;
                XElement elem = t.Element("EmployeeID");
                if (elem != null)
                {
                    element = new XElement("employee");
                    XAttribute attr = new XAttribute("EmployeeID", elem.Value.ToString());
                    element.Add(attr);
                }
                elem = t.Element("FirstName");
                if (elem != null)
                {
                    XAttribute attr = new XAttribute("FirstName", elem.Value.ToString());
                    element.Add(attr);
                }
                elem = t.Element("LastName");
                if (elem != null)
                {
                    XAttribute attr = new XAttribute("LastName", elem.Value.ToString());
                    element.Add(attr);
                }
                elem = t.Element("Title");
                if (elem != null)
                {
                    XAttribute attr = new XAttribute("Title", elem.Value.ToString());
                    element.Add(attr);
                }
                if (element != null)
                {
                    data += element.ToString();
                }
            }

            data = "<employees>" + data + "</employees>";
            
            XmlDataSource1.DataFile = "";
            XmlDataSource1.Data = data;
            GridView1.DataSourceID = XmlDataSource1.ID;
        }
    }
}