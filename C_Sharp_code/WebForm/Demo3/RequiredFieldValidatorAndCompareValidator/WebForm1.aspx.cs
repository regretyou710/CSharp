using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RequiredFieldValidatorAndCompareValidator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = Request.Form["txtName"];
            string age = Request.Form["txtAge"];
            //Response.Write("姓名:"+txtName.Text+"</br>");
           // Response.Write("年齡:"+txtAge.Text);
            Response.Write("姓名:" + name + "</br>");
            Response.Write("年齡:" + age);
        }
    }
}