﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo43
{
    public partial class IIS常用驗證機制 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string str = HttpContext.Current.User.Identity.Name;
            Response.Write("//"+str);

        }
    }
}