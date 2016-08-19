using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dll2;

namespace publish
{
    public partial class DllService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            String result = Class1.determine(TextBox8.Text, TextBox9.Text);
            Label6.Text = result;
        }
    }
}