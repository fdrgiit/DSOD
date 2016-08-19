using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace publish
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie myCookies = Request.Cookies["myKeyie"];
            if (myCookies != null)
            {
                Session["Username"] = myCookies["Username"];
            }
            if (Session.Count == 0 || myCookies["Username"] == "Vinit" || myCookies["Username"] == "Abhinav" || myCookies["Username"] == "vinit" || myCookies["Username"] == "abhinav")
            {
                Session.Clear();
                Response.Redirect("login.aspx");
            }
            else
                Label1.Text = (string)Session["Username"];
        }

        protected void Button10_Click(object sender, EventArgs e)
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

        protected void Button1_Click(object sender, EventArgs e)
        {
            AllServices.Service1Client client = new AllServices.Service1Client();
            if (TextBox1.Text == "")
            {
                TextBox2.Text = "PLEASE PROVIDE AN INPUT";
                return;
            }
            try
            {
                string output = client.WordFilter(TextBox1.Text);
                TextBox2.Text = output;
            }
            catch (Exception e1)
            {
                TextBox2.Text = e1.Message.ToString();
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            AllServices.Service1Client client = new AllServices.Service1Client();
            if (TextBox8.Text == "http://")
            {
                TextBox4.Text = "PLEASE PROVIDE AN INPUT";
                return;
            }
            try
            {
                string[] result = client.Top10Words(TextBox8.Text);
                string output = "";
                for (int i = 0; i < result.Length; i++)
                {
                    output = output + (i + 1).ToString() + ": " + result[i] + " ";
                }
                TextBox4.Text = output;
            }
            catch (Exception ec)
            {
                TextBox4.Text = ec.Message.ToString();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            AllServices.Service1Client client = new AllServices.Service1Client();
            if (TextBox5.Text == "http://")
            {
                TextBox5.Text = "PLEASE PROVIDE AN INPUT";
                return;
            }
            try
            {
                string[] result = client.Top10ContentWords(TextBox5.Text);
                string output = "";
                for (int i = 0; i < result.Length; i++)
                {
                    output = output + (i + 1).ToString() + ": " + result[i] + " ";
                }
                TextBox6.Text = output;
            }
            catch (Exception ec)
            {
                TextBox6.Text = ec.Message.ToString();
            }
        }

        protected void stemming(object sender, EventArgs e)
        {
            AllServices.Service1Client client = new AllServices.Service1Client();
            try
            {
                output.Text = "<b>" + client.Stemming(TextBox9.Text) + "</b>";
            }
            catch (Exception ec) { output.Text = ec.Message.ToString(); }
        }

        protected void msort(object sender, EventArgs e)
        {
            AllServices.Service1Client client = new AllServices.Service1Client();
            if (str.Text == "")
            {
                TextBox10.Text = "Empty input is not allowed!";
                return;
            }
            try
            {
                string output = client.Sort(str.Text);
                TextBox10.Text = output;
            }
            catch (Exception ec)
            {
                TextBox10.Text = ec.Message.ToString();
            }
        }

        protected void longestpalindrome(object sender, EventArgs e)
        {
            AllServices.Service1Client client = new AllServices.Service1Client();
            if (TextBox11.Text == "")
            {
                TextBox3.Text = "Empty input is not allowed!";
                return;
            }
            try
            {
                int output = client.palindrome(TextBox11.Text);
                TextBox3.Text = output.ToString();
            }
            catch (Exception ec)
            {
                TextBox3.Text = ec.Message.ToString();
            }
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            webtostring.ServiceClient sc = new webtostring.ServiceClient();
            string url = TextBox12.Text;
            TextBox13.Text = sc.GetWebContent(url);
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            TextBox13.Text = "";
        }
    }
}
