using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Xml;
using Dll;

namespace publish
{
    public partial class Register : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label4.Text = "";
        }

        protected void registerBtn_Click(object sender, EventArgs e)
        {
            
            if (Username.Text == "Vinit" || Username.Text == "Abhinav" || Username.Text == "vinit" || Username.Text == "abhinav")
            {
                Label4.Text = "Your username is not allowed!";
            }
            else if (Password.Text == Confirm.Text)
            {
                string user = Username.Text;
                string pass = Password.Text;
                user = Class1.Encrypt(user);
                pass = Class1.Encrypt(pass);

                string fLocation = Path.Combine(Request.PhysicalApplicationPath, @"bin\user.xml");
                XmlDocument xdoc = new XmlDocument();
                xdoc.Load(fLocation);
                XmlDocumentFragment xfrag = xdoc.CreateDocumentFragment();
                xfrag.InnerXml = @"<User><username>" + user + "</username>" + "<password>" + pass + "</password>" + "</User>";
                xdoc.DocumentElement.AppendChild(xfrag);
                xdoc.Save(fLocation);
                Response.Redirect("login.aspx");
            }
            else
                Label4.Text = "Enter correct Password";
        }
    }
}