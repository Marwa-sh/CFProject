using System;
using System.Configuration;
using System.Xml.Linq;

namespace Cf.Data
{
    #region XmlFormatterBase
    public abstract class XmlFormatterBase
    {
        protected string strParameters;
        protected string parametersFormat;
        public string [] Parameters;
        public string ParametersFormat
        {
            get
            {
                return parametersFormat;
            }
        }
        public static string DateFormat
        {
            get
            {
                try
                {
                    return ConfigurationManager.AppSettings["DateFormat"].ToString();
                }
                catch
                {
                    return "dd/MM/yyyy";
                }
            }
        }

        public static string TimeFormat
        {
            get
            {
                try
                {
                    return ConfigurationManager.AppSettings["TimeFormat"].ToString();
                }
                catch
                {
                    return "hh:mm:ss";
                }
            }
        }

        public static string MoneyFormat
        {
            get
            {
                try
                {
                    return ConfigurationManager.AppSettings["MoneyFormat"].ToString();
                }
                catch
                {
                    return "#,##0.00";
                }
            }
        }

        /// <summary>
        /// Build an XML string by mixing the xml string format with the parameters
        /// </summary>
        /// <param name="xmlStringFormat">The xml format string</param>
        /// <param name="parameters">The parameters to put into the xml string format</param>
        /// <returns>Returns a formatted string full of the parameters into the _xmlStringFormat template</returns>
        protected static string XmlFormat(string xmlStringFormat, params string[] parameters)
        {
            for (int i = 0; i < parameters.Length; i++)
            {
                XElement e = new XElement("root", parameters[i]);
                // escape xml string
                parameters[i] = e.Value;
                // end escape xml string
            }
            string str = String.Format(xmlStringFormat, parameters);

            return str;
        }
        public override string ToString()
        {
            return strParameters;
        }
    }
    #endregion

    #region UncategorizedXmlFormatter
    public class UncategorizedXmlFormatter : XmlFormatterBase
    {
        public UncategorizedXmlFormatter(string eventCategoryName, string [] parameters)
        {
            this.EventCategoryName = eventCategoryName;
            this.Parameters = parameters;
            string p = "<Params>";
            p += "\n\t<Category>{0}</Category>";
            p += "\n\t<Param>{1}</Param>";
            p += "\n</Params>";
            this.parametersFormat = p;
            strParameters = XmlFormat(parametersFormat, eventCategoryName, string.Join(", ", parameters));
        }

        public string EventCategoryName { get; set; }
    }
    #endregion
}
