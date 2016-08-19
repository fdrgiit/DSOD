using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Xml;
using System.Web.Security;
using Dll;

namespace publish
{
    public partial class login : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie myCookies = Request.Cookies["myKeyie"];
            if (myCookies != null)
            {
                Session["Username"] = myCookies["Username"];
                Session["Password"] = myCookies["Password"];
            }
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            HttpCookie myCookies = new HttpCookie("myKeyie");
            if (DropDownList1.SelectedValue == "Customer")
            {
                string user = Username.Text;
                string pass = Password.Text;
                user = Class1.Encrypt(user);
                pass = Class1.Encrypt(pass);

                string fLocation1 = Path.Combine(Request.PhysicalApplicationPath, @"bin\user.xml");
                bool redirect = false;

                if (File.Exists(fLocation1))
                {
                    FileStream fS = new FileStream(fLocation1, FileMode.Open, FileAccess.Read, FileShare.Read);
                    XmlDocument xd = new XmlDocument();
                    xd.Load(fS);
                    XmlNode node = xd;
                    XmlNodeList children = node.ChildNodes;
                    foreach (XmlNode child in children.Item(1))
                    {
                        if (user == child.FirstChild.InnerText)
                        {
                            if (pass == child.LastChild.InnerText)
                            {
                                Session["Username"] = Username.Text;
                                Session["Password"] = Password.Text;
                                myCookies["Username"] = Username.Text;
                                myCookies["Password"] = Password.Text;
                                myCookies.Expires = DateTime.Now.AddMinutes(30);
                                Response.Cookies.Add(myCookies);
                                Response.Redirect("default.aspx");
                                redirect = true;
                            }
                        }
                    }
                    fS.Close();
                }
                if (!redirect)
                    Label3.Text = "YOUR USERNAME OR PASSWORD IS INCORRECT!";
            }

            else if (DropDownList1.SelectedValue == "Staff")
            {
                string user = Username.Text;
                string pass = Password.Text;
                user = Class1.Encrypt(user);
                pass = Class1.Encrypt(pass);

                string fLocation1 = Path.Combine(Request.PhysicalApplicationPath, @"bin\staff.xml");
                bool redirect = false;

                if (File.Exists(fLocation1))
                {
                    FileStream fS = new FileStream(fLocation1, FileMode.Open, FileAccess.Read, FileShare.Read);
                    XmlDocument xd = new XmlDocument();
                    xd.Load(fS);
                    XmlNode node = xd;
                    XmlNodeList children = node.ChildNodes;
                    foreach (XmlNode child in children.Item(1))
                    {
                        if (user == child.FirstChild.InnerText)
                        {
                            if (pass == child.LastChild.InnerText)
                            {
                                Session["Username"] = Username.Text;
                                Session["Password"] = Password.Text;
                                myCookies["Username"] = Username.Text;
                                myCookies["Password"] = Password.Text;
                                myCookies.Expires = DateTime.Now.AddMinutes(30);
                                Response.Cookies.Add(myCookies);
                                if (Username.Text == "Vinit")
                                {
                                    Response.Redirect("About.aspx");
                                    redirect = true;
                                }
                                else if (Username.Text == "Abhinav")
                                {
                                    Response.Redirect("Abhinav.aspx");
                                    redirect = true;
                                }
                            }
                        }
                    }
                    fS.Close();
                }
                if (!redirect)
                    Label3.Text = "Your username or password is incorrect!";
            }
            else
            {
                Label3.Text = "Please enter your credentials!";
            }
        }

        protected void returnBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }
    }
}