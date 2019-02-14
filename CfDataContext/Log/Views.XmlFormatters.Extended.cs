using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Cf.Data
{
    #region GarantorsXmlFormatter
    public class GarantorsXmlFormatter : XmlFormatterBase
    {
        public GarantorsXmlFormatter(AvailabilityVw availabilityVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(availabilityVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public GarantorsXmlFormatter(Availability availability)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(availability);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<EmployeeFullName>{0}</EmployeeFullName>";
            parametersFormat += "\n\t<EmployeeId>{1}</EmployeeId>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(AvailabilityVw availabilityVw)
        {
            return new string []
            {
				availabilityVw.Id.ToString(),
				availabilityVw.Name,
				availabilityVw.MinSeniority.ToString(),
				availabilityVw.MinReusePeriod.ToString()
            };
        }
        
        private string [] GetParameters(Availability availability)
        {
            AvailabilityVw availabilityVw = new AvailabilityVw();
            availabilityVw.Id = availability.Id;
            availabilityVw.Name = availability.Name;
            availabilityVw.MinSeniority = availability.MinSeniority;
            availabilityVw.MinReusePeriod = availability.MinReusePeriod;
            return GetParameters(availabilityVw);
        }
    }
    #endregion
   }
