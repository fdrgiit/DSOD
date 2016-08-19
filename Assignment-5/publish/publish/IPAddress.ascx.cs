using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace publish
{
    public partial class IPAddress : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string IP = HttpContext.Current.Request.UserHostAddress;
            if (IP != null)
                ipLabel.Text = IP;
            else
                ipLabel.Text = "The User's IP address not found.";
        }
    }
}