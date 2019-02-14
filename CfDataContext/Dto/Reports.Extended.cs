using System;
using System.Reflection;
using System.Text;
using System.Xml;

namespace Cf.Data
{

    public partial class ReportEmployeeLoansBetweenTwoDatesResult
    {
        public static string ConvertXmlToHtmlRaw(string xml, string language, string module)
        {
            StringBuilder html = new StringBuilder("");
            try
            {
                XmlDocument document = new XmlDocument();
                document.LoadXml("<root>" + xml + "</root>");
                XmlNodeList nodes = document.DocumentElement.ChildNodes;
                Console.WriteLine("node = " + nodes.Count);
                int count = 0;
                html.Append("<tr> <td> الكفلاء </td>");
                foreach (XmlNode n in nodes)
                {
                    count++;
                    html.Append("<td>");
                    foreach (dynamic ele in n.Attributes)
                    {
                        if (ele != null)
                        {
                            html.Append(ele.Value + "  " );
                        }
                        else
                        {
                            html.Append("");
                        }
                    }
                    html.Append("</td>");
                }
                html.Append("</tr>");
               
            }

            catch (Exception e)
            {
                return xml;
                // Returning the original string incase of error.
            }
            return html.ToString();
        }
        public static string ConvertXmlToHtmlTable(string xml, string language, string module)
        {
            StringBuilder html = new StringBuilder("<table align='center' class='xmlTable'>\r\n");
            try
            {
                XmlDocument document = new XmlDocument();
                document.LoadXml("<root>" + xml + "</root>");
                XmlNodeList nodes = document.DocumentElement.ChildNodes;
                Console.WriteLine("node = " + nodes.Count);
                int count = 0;
                foreach (XmlNode n in nodes)
                {
                    if (count == 0)
                    {
                        html.Append("<tr>");
                        foreach (dynamic item in n.Attributes)
                        {
                            if (item != null)
                            {
                                string resourceName = item.Name.ToString();// ResourceServices.GetString(language, module, item.Name.ToString());
                                html.Append("<td>" + resourceName + "</td>");
                            }
                        }
                        html.Append("</tr>");
                    }
                    count++;
                    html.Append("<tr>");
                    foreach (dynamic ele in n.Attributes)
                    {
                        if (ele != null)
                        {
                            html.Append("<td>" + ele.Value + "</td>");
                        }
                        else
                        {
                            html.Append("<td></td>");
                        }
                    }
                    html.Append("</tr>");
                }
                html.Append("</table>");
            }

            catch (Exception e)
            {
                return xml;
                // Returning the original string incase of error.
            }
            return html.ToString();
        }
        public string HtmlGarantors
        {
            get
            {
                // return GetHtml(EventCategoryId, Parameters);
                try
                {
                    GarantorsXmlRepresenter representer = new GarantorsXmlRepresenter("<params>"+Guarantors +"</params>", System.Globalization.CultureInfo.CurrentCulture.ToString());
                    //return representer.ToString();
                    return ConvertXmlToHtmlRaw(Guarantors, System.Globalization.CultureInfo.CurrentCulture.ToString(), "Employee");

                   // return a.CreateInstance("Cf.Data." + "GarantorsXmlRepresenter", false, BindingFlags.CreateInstance, null, new string[1] { Guarantors }, System.Globalization.CultureInfo.CurrentCulture, null).ToString();
                }
                catch
                {
                    return String.Empty;
                }
            }
            set
            {
            }
        }
       }
    
}
