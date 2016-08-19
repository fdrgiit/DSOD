using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Wordfilter.Service1Client client = new Wordfilter.Service1Client();
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
        catch(Exception e1)
        {
            TextBox2.Text = e1.Message.ToString();
        }
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Top10Word.Service1Client client = new Top10Word.Service1Client();
        if (TextBox3.Text == "http://")
        {
            TextBox4.Text = "PLEASE PROVIDE AN INPUT";
            return;
        }
        try
        {
            string[] result = client.Top10Words(TextBox3.Text);
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
}
