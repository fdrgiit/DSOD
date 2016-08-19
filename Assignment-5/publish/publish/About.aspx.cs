using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dll;

namespace publish
{
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie myCookies = Request.Cookies["myKeyie"];
            if (myCookies != null)
            {
                Session["Username"] = myCookies["Username"];
            }
            if ((string)Session["Username"] == "Vinit" || (string)Session["Username"] == "vinit")
            { }
            else
            {
                Session.Clear();
                Response.Redirect("login.aspx");
            }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {

            HttpCookie myCookies = Request.Cookies["myKeyie"];
            if (myCookies != null)
            {
                myCookies.Expires = DateTime.Now.AddDays(-1d);
                Response.Cookies.Add(myCookies);
            }
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Session.Clear();
            HttpCookie myCookies = Request.Cookies["myKeyie"];
            if (myCookies != null)
            {
                myCookies.Expires = DateTime.Now.AddDays(-1d);
                Response.Cookies.Add(myCookies);
            }
            Response.Redirect("home.aspx");
        }

        protected void stemming(object sender, EventArgs e)
        {
            AllServices.Service1Client client = new AllServices.Service1Client();
            try
            {
                output.Text = "<b>" + client.Stemming(TextBox4.Text) + "</b>";
            }
            catch (Exception ec) { output.Text = ec.Message.ToString(); }

        }

        protected void msort(object sender, EventArgs e)
        {
            AllServices.Service1Client client = new AllServices.Service1Client();
            if (str.Text == "")
            {
                TextBox1.Text = "Empty input is not allowed!";
                return;
            }
            try
            {
                string output = client.Sort(str.Text);
                TextBox1.Text = output;
            }
            catch (Exception ec)
            {
                TextBox1.Text = ec.Message.ToString();
            }
        }

        protected void longestpalindrome(object sender, EventArgs e)
        {
            AllServices.Service1Client client = new AllServices.Service1Client();
            if (str.Text == "")
            {
                TextBox3.Text = "Empty input is not allowed!";
                return;
            }
            try
            {
                int output = client.palindrome(TextBox2.Text);
                TextBox3.Text = output.ToString();
            }
            catch (Exception ec)
            {
                TextBox3.Text = ec.Message.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            webtostring.ServiceClient sc = new webtostring.ServiceClient();
            string url = TextBox5.Text;
            TextBox6.Text = sc.GetWebContent(url);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox6.Text = "";
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            string encrypt = Class1.Encrypt(TextBox7.Text);
            TextBox8.Text = encrypt;
            TextBox9.Text = Class1.Decrypt(encrypt);
        }

        protected void deletechar(object sender, EventArgs e)
        {
            AllServices.Service1Client client = new AllServices.Service1Client();

            if (str1.Text == "" || str2.Text == "")
            {
                result.Text = "Empty input is not allowed!"; return;
            }
            try
            {
                string res = client.deleteChar(str1.Text, str2.Text);
                result.Text = res;
            }
            catch (Exception ec)
            {
                result.Text = ec.Message.ToString();
            }
        }
    }
}
