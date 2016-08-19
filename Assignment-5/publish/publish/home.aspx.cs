using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace publish
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie myCookies = Request.Cookies["myKeyie"];
            if ((myCookies != null) && (myCookies["Username"] != ""))
            {
                Label4.Text = myCookies["Username"];

            }
            else
            {
                Label4.Text = "No Current User";
            }
            totalLabel.Text = " " + ((int)Application["accesses"]) / 2;
            currentLabel.Text = " " + (int)Application["users"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Clear();
            HttpCookie myCookies = Request.Cookies["myKeyie"];
            if (myCookies != null)
            {
                myCookies.Expires = DateTime.Now.AddDays(-1d);
                Response.Cookies.Add(myCookies);
            }
        }
    }
}