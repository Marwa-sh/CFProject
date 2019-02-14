using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Cf.Data
{
    #region GarantorsXmlRepresenter
    public class GarantorsXmlRepresenter : XmlRepresenterBase
    {
        public GarantorsXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "Garantors";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public GarantorsXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("EmployeeFullName", "Params", GetDescription("Employee", "FirstName")),
				 new XslParameter("EmployeeId", "Params", GetDescription("Employee", "Id"))
            };
        }
    }
    #endregion
   }
