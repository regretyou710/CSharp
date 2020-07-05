using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS_demo32
{
    public partial class WebForm3_Calendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            SelectedDatesCollection dts =  Calendar1.SelectedDates;
            foreach (DateTime dt in dts)
                Response.Write(dt+"</br>");
            Response.Write("所選日期:"+Calendar1.SelectedDate);
            Response.Write("</br>------------------------");           
        }
    }
}