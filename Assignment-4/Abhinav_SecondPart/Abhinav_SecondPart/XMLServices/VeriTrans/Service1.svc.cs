using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;
using System.Xml.Xsl;
using System.IO;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {
        private static Boolean fault = true;
        private static string notification;

        public string verificationService(string xmlURL, string xsdURL)
        {
            notification = "";

            XmlSchemaSet sc = new XmlSchemaSet();
            sc.Add(null, xsdURL);

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.ValidationType = ValidationType.Schema;
            settings.Schemas = sc;

            settings.ValidationEventHandler += new ValidationEventHandler(vCB);
            XmlReader reader = XmlReader.Create(xmlURL, settings);
            fault = true;
            while (reader.Read()) ;
            if (fault == true)
            {
                return ("NO ERROR");
            }
            return notification;
        }

        private static void vCB(object sender, ValidationEventArgs e)
        {
            fault = false;
            notification += "There is an error in validation:" + e.Message + "\n";
        }

        public string xmlToHtmlTransform(string xmlURL, string xslURL)
        {
            string result = "";
            try
            {
                XPathDocument doc = new XPathDocument(xmlURL);
                XslCompiledTransform xt = new XslCompiledTransform();
                xt.Load(xslURL);

                StringWriter html = new StringWriter();

                xt.Transform(doc, null, html);

                result = html.ToString();
            }
            catch (Exception e)
            {
                return e.Message;
            }
            return result;
        }
    }
}
