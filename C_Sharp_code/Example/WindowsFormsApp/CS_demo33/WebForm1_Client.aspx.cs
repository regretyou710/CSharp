using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo33
{
    public partial class WebForm1_Client : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            localWS_CS.WebService1 ws = new localWS_CS.WebService1();
            DataSet ds = new DataSet();
            ds = ws.getStudent();
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }
    }
}