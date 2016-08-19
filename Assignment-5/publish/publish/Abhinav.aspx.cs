using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace publish
{
    public partial class Abhinav : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie myCookies = Request.Cookies["myKeyie"];
            if (myCookies != null)
            {
                Session["Username"] = myCookies["Username"];
            }
            if ((string)Session["Username"] == "Abhinav" || (string)Session["Username"] == "abhinav")
            { }
            else
            {
                Session.Clear();
                Response.Redirect("login.aspx");
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            HttpCookie myCookies = Request.Cookies["myKeyie"];
            if (myCookies != null)
            {
                myCookies.Expires = DateTime.Now.AddDays(-1d);
                Response.Cookies.Add(myCookies);
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            AllServices.Service1Client client = new AllServices.Service1Client();
            if (TextBox3.Text == "")
            {
                TextBox3.Text = "PLEASE PROVIDE AN INPUT";
                return;
            }
            try
            {
                string[] result = client.Permutation(TextBox3.Text);
                string output = "";

                for (int i = 0; i < result.Length; i++)
                {
                    output = output + (i + 1).ToString() + ": " + result[i] + "\n";
                }

                TextBox7.Text = output;
            }
            catch (Exception ec)
            {
                TextBox7.Text = ec.Message.ToString();
            }
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}