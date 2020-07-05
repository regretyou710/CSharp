using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo32
{
    public partial class WebForm2_DropDownList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //將表單所選的項目對應送回
            //DropDownList的屬性AutoPostBack改成true
            Response.Write("No:" + DropDownList1.SelectedValue);
            Response.Write("</br>=============================");
        }
    }
}