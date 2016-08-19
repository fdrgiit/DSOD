using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.IO;
using System.Net;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        //Top10ContentWords.Service1Client client = new Top10ContentWords.Service1Client();
        if (TextBox3.Text == "")
        {
            TextBox3.Text = "PLEASE PROVIDE AN INPUT";
            return;
        }
        try
        {
            string firstPath = "http://localhost:11598/Service1.svc/perm?input=";
            string path = firstPath + TextBox3.Text;

            WebClient permu = new WebClient();

            String final = permu.DownloadString(path);

            XmlDocument xml = new XmlDocument();
            xml.LoadXml(final);

            string result = "";
            string output = "";
            XmlNodeList node = xml.GetElementsByTagName("string");
            for (int i = 0; i < node.Count; i++)
            {
                result = node[i].InnerText;
                output = output + (i + 1).ToString() + ": " + result + " ";
            }
            TextBox7.Text = output;
        }
        catch (Exception ec)
        {
            TextBox7.Text = ec.Message.ToString();
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Top10ContentWords.Service1Client client = new Top10ContentWords.Service1Client();
        if (TextBox5.Text == "http://")
        {
            TextBox5.Text = "PLEASE PROVIDE AN INPUT";
            return;
        }
        try
        {
            string[] result = client.getTopTen(TextBox5.Text);
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
    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }
}
