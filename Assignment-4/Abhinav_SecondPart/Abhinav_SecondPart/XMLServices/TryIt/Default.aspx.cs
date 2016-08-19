using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using XMLServices.xmlService;

namespace XMLServices
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void testValidationService(object sender, EventArgs e)
        {
            Service1Client client = new Service1Client();
             
            if (TextBox4.Text != "" && TextBox5.Text != "")
            {
                string resultOfValidation = client.verificationService(TextBox4.Text, TextBox5.Text);
                TextBox6.Text = resultOfValidation;
            }
            else
            {
                TextBox6.Text = "PLEASE ENTER THE URL";
            }
        }

        protected void testXMLTransformationService(object sender, EventArgs e)
        {
            Service1Client client = new Service1Client();
            if (TextBox1.Text != "")
            {
                string resultOfTransformation = client.xmlToHtmlTransform(TextBox1.Text,TextBox2.Text);
                TextBox3.Text = resultOfTransformation;
            }
            else
            {
                TextBox3.Text = "PLEASE ENTER THE URL";
            }
        }
    }
}
