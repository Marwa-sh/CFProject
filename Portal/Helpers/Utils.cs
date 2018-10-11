using Cf.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Xml;

namespace Portal.Helpers
{
    public class Utils
    {
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
                                string resourceName = ResourceServices.GetString(language, module, item.Name.ToString());

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

    }
}