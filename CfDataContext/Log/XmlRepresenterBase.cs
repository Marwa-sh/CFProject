using System;
using System.Xml;
using System.Xml.Xsl;
using System.IO;
using Cf.Data.Resources;

namespace Cf.Data
{
    #region XmlRepresenterBase
    public abstract partial class XmlRepresenterBase
    {
        protected string html;
        protected XslParameter [] parameters;
        protected string xsl;
        protected string module;
        protected string culture = "ar";

        protected abstract XslParameter[] GetParameters();

        #region Convert Xml to HTML
        /// <summary>
        /// Transform xml to html by XslTransforer.
        /// </summary>
        /// <param name="xsl">xsl</param>
        /// <param name="xml">xml</param>
        /// <returns>html</returns>
        public static string GetHtml(string xsl, string xml)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(xml);
                XmlDocument xslDoc = new XmlDocument();
                xslDoc.LoadXml(xsl);
                XslCompiledTransform tran = new XslCompiledTransform();
                tran.Load(xslDoc);
                MemoryStream mem = new MemoryStream();
                StreamWriter writter = new StreamWriter(mem);
                tran.Transform(xmlDoc, null, writter);
                mem.Seek(0, SeekOrigin.Begin);
                StreamReader reader = new StreamReader(mem);
                string html = reader.ReadToEnd();
                reader.Close();
                writter.Close();
                mem.Close();
                return XmlConvert.DecodeName(html);
            }
            catch (Exception)
            {
                return "-";
            }
        }
        #endregion
        public string Xsl
        {
            get
            {
                return xsl;
            }
        }
        
        protected string GetXsl()
        {
            string xsl ="<xsl:stylesheet xmlns:xsl=\"http://www.w3.org/1999/XSL/Transform\" version=\"1.0\">";
            xsl += "\t<xsl:output method=\"html\" />";
            xsl += "\n\t<xsl:template match=\"/\">";
            // xsl += "\n\t\t<table width=\"500\" class=\"eventCategoryParams table-bordered mb-0\" id=\"" + module + "\">";
			xsl += "\n\t\t<table width=\"100%\" class=\"eventCategoryParams table-bordered mb-0\" id=\"" + module + "\">";
			foreach (XslParameter p in parameters)
            {
				xsl += "\n\t\t\t<tr>";
				xsl += p.ToString();
                xsl += "\n\t\t\t</tr>";
            }
            xsl += "\n\t\t</table>";
            xsl += "\n\t</xsl:template>";
            xsl += "</xsl:stylesheet>";
            return xsl;
        }
        
        public override string ToString()
        {
            return html;
        }
        protected virtual string GetDescription(string module, string name)
        {
            return ResourcesCollection.GetString(culture, module, name);
            // return string.Empty;
        }
    }
    #endregion
    
    #region XslParameter class definition
    public class XslParameter
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Description { get; set; }
        
        public XslParameter(string name, string path, string description)
        {
            this.Name = name;
            this.Path = path;
            this.Description = description;
        }
        
        public XslParameter(string name, string path) : this(name, path, name)
        {
        }
        
        public XslParameter(string name) : this(name, "Params", name)
        {
        }
        
        public static implicit operator XslParameter(string name)
        {
            return new XslParameter(name, name);
        }
        
        public override string ToString()
        {
            string xsl = "\n\t\t\t\t<td width=\"50%\">" + Description + "</td>";
            xsl += "\n\t\t\t\t<td width=\"50%\">";
            xsl += "\n\t\t\t\t\t<xsl:value-of select=\"/" + Path + "/" + Name + "\" />";
            xsl += "\n\t\t\t\t</td>";
            return xsl;
       }
    }
    #endregion

    #region UncategorizedXmlRepresenter
    public class UncategorizedXmlRepresenter : XmlRepresenterBase
    {
        public UncategorizedXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "Uncategorized";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public UncategorizedXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				new XslParameter("Category"),
				new XslParameter("Param")
            };
        }
    }
    #endregion
}
