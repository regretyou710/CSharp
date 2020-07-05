using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CheckBoxAndRadioController
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string s1 = "", s2 = "";
            if (Page.IsPostBack)
            {
                foreach (ListItem i in CheckBoxList1.Items)
                {
                    if (i.Selected)
                    {
                        s1 += i.Text + ":" + i.Value + "</br>";
                    }
                }
                foreach (ListItem i in RadioButtonList1.Items)
                {
                    if (i.Selected)
                    {
                        s2 += i.Text + ":" + i.Value + "</br>";
                    }
                }
                Response.Write(s1);
                Response.Write("---------------</br>");
                Response.Write(s2);
            }
        }
    }
}