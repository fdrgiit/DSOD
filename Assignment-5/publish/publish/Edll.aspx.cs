using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dll;
namespace publish
{
    public partial class Edll : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string enc = Class1.Encrypt(TextBox1.Text);
            TextBox2.Text = enc;
            TextBox3.Text = Class1.Decrypt(enc);
        }
    }
}