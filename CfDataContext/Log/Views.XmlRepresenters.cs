using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Cf.Data
{
    #region AvailabilityVwXmlRepresenter
    public class AvailabilityVwXmlRepresenter : XmlRepresenterBase
    {
        public AvailabilityVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "Availability";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public AvailabilityVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("Availability", "Id")),
				 new XslParameter("Name", "Params", GetDescription("Availability", "Name")),
				 new XslParameter("MinSeniority", "Params", GetDescription("Availability", "MinSeniority")),
				 new XslParameter("MinReusePeriod", "Params", GetDescription("Availability", "MinReusePeriod"))
            };
        }
    }
    #endregion

    #region AvailabilityCeilingVwXmlRepresenter
    public class AvailabilityCeilingVwXmlRepresenter : XmlRepresenterBase
    {
        public AvailabilityCeilingVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "AvailabilityCeiling";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public AvailabilityCeilingVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("AvailabilityCeiling", "Id")),
				 new XslParameter("AvailabilityId", "Params", GetDescription("Availability", "Id")),
				 new XslParameter("AvailabilityName", "Params", GetDescription("Availability", "Name")),
				 new XslParameter("AvailabilityMinSeniority", "Params", GetDescription("Availability", "MinSeniority")),
				 new XslParameter("AvailabilityMinReusePeriod", "Params", GetDescription("Availability", "MinReusePeriod")),
				 new XslParameter("FromYear", "Params", GetDescription("AvailabilityCeiling", "FromYear")),
				 new XslParameter("MaxAmount", "Params", GetDescription("AvailabilityCeiling", "MaxAmount"))
            };
        }
    }
    #endregion

    #region BypassStatusVwXmlRepresenter
    public class BypassStatusVwXmlRepresenter : XmlRepresenterBase
    {
        public BypassStatusVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "BypassStatus";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public BypassStatusVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("BypassStatus", "Id")),
				 new XslParameter("Name", "Params", GetDescription("BypassStatus", "Name"))
            };
        }
    }
    #endregion

    #region CashPaymentVwXmlRepresenter
    public class CashPaymentVwXmlRepresenter : XmlRepresenterBase
    {
        public CashPaymentVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "CashPayment";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public CashPaymentVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("PaymentId", "Params", GetDescription("Payment", "Id")),
				 new XslParameter("PaymentEmployeeId", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("PaymentEmployeeFullName", "Params", GetDescription("Employee", "PaymentEmployeeFullName")),
				 new XslParameter("PaymentEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name")),
				 new XslParameter("PaymentEmployeeCategoryName", "Params", GetDescription("Category", "Name")),
				 new XslParameter("PaymentDate", "Params", GetDescription("Payment", "Date")),
				 new XslParameter("PaymentPaymentGroupName", "Params", GetDescription("PaymentGroup", "Name")),
				 new XslParameter("PaymentAmount", "Params", GetDescription("Payment", "Amount")),
				 new XslParameter("PaymentPaymentStatusName", "Params", GetDescription("PaymentStatus", "Name"))
            };
        }
    }
    #endregion

    #region CategoryVwXmlRepresenter
    public class CategoryVwXmlRepresenter : XmlRepresenterBase
    {
        public CategoryVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "Category";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public CategoryVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("Category", "Id")),
				 new XslParameter("Name", "Params", GetDescription("Category", "Name"))
            };
        }
    }
    #endregion

    #region CollectOrderVwXmlRepresenter
    public class CollectOrderVwXmlRepresenter : XmlRepresenterBase
    {
        public CollectOrderVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "CollectOrder";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public CollectOrderVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("CollectOrder", "Id")),
				 new XslParameter("Number", "Params", GetDescription("CollectOrder", "Number")),
				 new XslParameter("Date", "Params", GetDescription("CollectOrder", "Date"))
            };
        }
    }
    #endregion

    #region DebtVwXmlRepresenter
    public class DebtVwXmlRepresenter : XmlRepresenterBase
    {
        public DebtVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "Debt";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public DebtVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("Debt", "Id")),
				 new XslParameter("EmployeeId", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("EmployeeFullName", "Params", GetDescription("Employee", "EmployeeFullName")),
				 new XslParameter("EmployeeEmployeeStatusName", "Params", GetDescription("EmployeeStatus", "Name")),
				 new XslParameter("EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name")),
				 new XslParameter("EmployeeCategoryName", "Params", GetDescription("Category", "Name")),
				 new XslParameter("Amount", "Params", GetDescription("Debt", "Amount")),
				 new XslParameter("IssuerName", "Params", GetDescription("Issuer", "Name")),
				 new XslParameter("Date", "Params", GetDescription("Debt", "Date")),
				 new XslParameter("PeriodInMonths", "Params", GetDescription("Debt", "PeriodInMonths")),
				 new XslParameter("ExceptionalPayment", "Params", GetDescription("Debt", "ExceptionalPayment")),
				 new XslParameter("Installment", "Params", GetDescription("Debt", "Installment"))
            };
        }
    }
    #endregion

    #region DepartmentVwXmlRepresenter
    public class DepartmentVwXmlRepresenter : XmlRepresenterBase
    {
        public DepartmentVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "Department";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public DepartmentVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("Department", "Id")),
				 new XslParameter("Name", "Params", GetDescription("Department", "Name")),
				 new XslParameter("SalaryWorkPlaceName", "Params", GetDescription("SalaryWorkPlace", "Name")),
				 new XslParameter("SalaryWorkPlaceMainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name"))
            };
        }
    }
    #endregion

    #region DownPaymentVwXmlRepresenter
    public class DownPaymentVwXmlRepresenter : XmlRepresenterBase
    {
        public DownPaymentVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "DownPayment";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public DownPaymentVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("PaymentId", "Params", GetDescription("Payment", "Id")),
				 new XslParameter("PaymentEmployeeId", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("PaymentEmployeeFullName", "Params", GetDescription("Employee", "PaymentEmployeeFullName")),
				 new XslParameter("PaymentEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name")),
				 new XslParameter("PaymentEmployeeCategoryName", "Params", GetDescription("Category", "Name")),
				 new XslParameter("PaymentDate", "Params", GetDescription("Payment", "Date")),
				 new XslParameter("PaymentAmount", "Params", GetDescription("Payment", "Amount")),
				 new XslParameter("RequestProductProductTypeName", "Params", GetDescription("ProductType", "Name")),
				 new XslParameter("RequestProductAmount", "Params", GetDescription("Product", "Amount")),
				 new XslParameter("RequestDate", "Params", GetDescription("Request", "Date")),
				 new XslParameter("RequestRequestStatusName", "Params", GetDescription("RequestStatus", "Name"))
            };
        }
    }
    #endregion

    #region EmployeeVwXmlRepresenter
    public class EmployeeVwXmlRepresenter : XmlRepresenterBase
    {
        public EmployeeVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "Employee";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public EmployeeVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("FatherName", "Params", GetDescription("Employee", "FatherName")),
				 new XslParameter("EmployeeStatusName", "Params", GetDescription("EmployeeStatus", "Name")),
				 new XslParameter("DepartmentName", "Params", GetDescription("Department", "Name")),
				 new XslParameter("DepartmentSalaryWorkPlaceMainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name")),
				 new XslParameter("CategoryName", "Params", GetDescription("Category", "Name"))
            };
        }
    }
    #endregion

    #region EmployeeSeniorityVwXmlRepresenter
    public class EmployeeSeniorityVwXmlRepresenter : XmlRepresenterBase
    {
        public EmployeeSeniorityVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "EmployeeSeniority";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public EmployeeSeniorityVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("EmployeeId", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("EmployeeFullName", "Params", GetDescription("Employee", "EmployeeFullName")),
				 new XslParameter("EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name")),
				 new XslParameter("EmployeeCategoryName", "Params", GetDescription("Category", "Name")),
				 new XslParameter("ServiceInDays", "Params", GetDescription("EmployeeSeniority", "ServiceInDays"))
            };
        }
    }
    #endregion

    #region EmployeeStatusVwXmlRepresenter
    public class EmployeeStatusVwXmlRepresenter : XmlRepresenterBase
    {
        public EmployeeStatusVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "EmployeeStatus";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public EmployeeStatusVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("EmployeeStatus", "Id")),
				 new XslParameter("Name", "Params", GetDescription("EmployeeStatus", "Name")),
				 new XslParameter("IsActive", "Params", GetDescription("EmployeeStatus", "IsActive"))
            };
        }
    }
    #endregion

    #region EndWorkGrantBracketVwXmlRepresenter
    public class EndWorkGrantBracketVwXmlRepresenter : XmlRepresenterBase
    {
        public EndWorkGrantBracketVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "EndWorkGrantBracket";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public EndWorkGrantBracketVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("FromYear", "Params", GetDescription("EndWorkGrantBracket", "FromYear")),
				 new XslParameter("Percentage", "Params", GetDescription("EndWorkGrantBracket", "Percentage"))
            };
        }
    }
    #endregion

    #region ErrorDefinitionVwXmlRepresenter
    public class ErrorDefinitionVwXmlRepresenter : XmlRepresenterBase
    {
        public ErrorDefinitionVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "ErrorDefinition";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public ErrorDefinitionVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("ErrorDefinition", "Id")),
				 new XslParameter("Message", "Params", GetDescription("ErrorDefinition", "Message")),
				 new XslParameter("LocalizedMessage", "Params", GetDescription("ErrorDefinition", "LocalizedMessage")),
				 new XslParameter("LikeExpression", "Params", GetDescription("ErrorDefinition", "LikeExpression"))
            };
        }
    }
    #endregion

    #region EventCategoryVwXmlRepresenter
    public class EventCategoryVwXmlRepresenter : XmlRepresenterBase
    {
        public EventCategoryVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "EventCategory";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public EventCategoryVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("EventCategory", "Id")),
				 new XslParameter("Name", "Params", GetDescription("EventCategory", "Name"))
            };
        }
    }
    #endregion

    #region EventLogVwXmlRepresenter
    public class EventLogVwXmlRepresenter : XmlRepresenterBase
    {
        public EventLogVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "EventLog";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public EventLogVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("EventLog", "Id")),
				 new XslParameter("EventSourceName", "Params", GetDescription("EventSource", "Name")),
				 new XslParameter("EventCategoryName", "Params", GetDescription("EventCategory", "Name")),
				 new XslParameter("EventStatusName", "Params", GetDescription("EventStatus", "Name")),
				 new XslParameter("Parameters", "Params", GetDescription("EventLog", "Parameters")),
				 new XslParameter("Date", "Params", GetDescription("EventLog", "Date")),
				 new XslParameter("User", "Params", GetDescription("EventLog", "User"))
            };
        }
    }
    #endregion

    #region EventLogErrorVwXmlRepresenter
    public class EventLogErrorVwXmlRepresenter : XmlRepresenterBase
    {
        public EventLogErrorVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "EventLogError";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public EventLogErrorVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("EventLogId", "Params", GetDescription("EventLog", "Id")),
				 new XslParameter("EventLogEventSourceName", "Params", GetDescription("EventSource", "Name")),
				 new XslParameter("EventLogEventCategoryName", "Params", GetDescription("EventCategory", "Name")),
				 new XslParameter("EventLogEventStatusName", "Params", GetDescription("EventStatus", "Name")),
				 new XslParameter("EventLogParameters", "Params", GetDescription("EventLog", "Parameters")),
				 new XslParameter("EventLogDate", "Params", GetDescription("EventLog", "Date")),
				 new XslParameter("EventLogUser", "Params", GetDescription("EventLog", "User")),
				 new XslParameter("Number", "Params", GetDescription("EventLogError", "Number")),
				 new XslParameter("Message", "Params", GetDescription("EventLogError", "Message"))
            };
        }
    }
    #endregion

    #region EventSourceVwXmlRepresenter
    public class EventSourceVwXmlRepresenter : XmlRepresenterBase
    {
        public EventSourceVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "EventSource";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public EventSourceVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("EventSource", "Id")),
				 new XslParameter("Name", "Params", GetDescription("EventSource", "Name"))
            };
        }
    }
    #endregion

    #region EventStatusVwXmlRepresenter
    public class EventStatusVwXmlRepresenter : XmlRepresenterBase
    {
        public EventStatusVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "EventStatus";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public EventStatusVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("EventStatus", "Id")),
				 new XslParameter("Name", "Params", GetDescription("EventStatus", "Name"))
            };
        }
    }
    #endregion

    #region ExceptionalAmountVwXmlRepresenter
    public class ExceptionalAmountVwXmlRepresenter : XmlRepresenterBase
    {
        public ExceptionalAmountVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "ExceptionalAmount";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public ExceptionalAmountVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("ExceptionalAmount", "Id")),
				 new XslParameter("LoanRequestRequestProductEmployeeId", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("LoanRequestRequestProductEmployeeFullName", "Params", GetDescription("Employee", "LoanRequestRequestProductEmployeeFullName")),
				 new XslParameter("LoanRequestRequestProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name")),
				 new XslParameter("LoanRequestRequestProductEmployeeCategoryName", "Params", GetDescription("Category", "Name")),
				 new XslParameter("LoanRequestRequestProductProductTypeName", "Params", GetDescription("ProductType", "Name")),
				 new XslParameter("SubNumber", "Params", GetDescription("ExceptionalAmount", "SubNumber")),
				 new XslParameter("Amount", "Params", GetDescription("ExceptionalAmount", "Amount")),
				 new XslParameter("ExceptionalAmountTypeName", "Params", GetDescription("ExceptionalAmountType", "Name")),
				 new XslParameter("ExceptionalAmountTypeIsIncome", "Params", GetDescription("ExceptionalAmountType", "IsIncome"))
            };
        }
    }
    #endregion

    #region ExceptionalAmountTypeVwXmlRepresenter
    public class ExceptionalAmountTypeVwXmlRepresenter : XmlRepresenterBase
    {
        public ExceptionalAmountTypeVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "ExceptionalAmountType";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public ExceptionalAmountTypeVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("ExceptionalAmountType", "Id")),
				 new XslParameter("Name", "Params", GetDescription("ExceptionalAmountType", "Name")),
				 new XslParameter("IsIncome", "Params", GetDescription("ExceptionalAmountType", "IsIncome"))
            };
        }
    }
    #endregion

    #region ExternalGrantVwXmlRepresenter
    public class ExternalGrantVwXmlRepresenter : XmlRepresenterBase
    {
        public ExternalGrantVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "ExternalGrant";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public ExternalGrantVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("ExternalGrant", "Id")),
				 new XslParameter("EmployeeId", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("EmployeeFullName", "Params", GetDescription("Employee", "EmployeeFullName")),
				 new XslParameter("EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name")),
				 new XslParameter("EmployeeCategoryName", "Params", GetDescription("Category", "Name")),
				 new XslParameter("RequestDate", "Params", GetDescription("ExternalGrant", "RequestDate")),
				 new XslParameter("GrantTypeName", "Params", GetDescription("GrantType", "Name")),
				 new XslParameter("GrantTypeAmount", "Params", GetDescription("GrantType", "Amount")),
				 new XslParameter("Amount", "Params", GetDescription("ExternalGrant", "Amount"))
            };
        }
    }
    #endregion

    #region GrantVwXmlRepresenter
    public class GrantVwXmlRepresenter : XmlRepresenterBase
    {
        public GrantVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "Grant";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public GrantVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("ProductId", "Params", GetDescription("Product", "Id")),
				 new XslParameter("ProductEmployeeId", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("ProductEmployeeFullName", "Params", GetDescription("Employee", "ProductEmployeeFullName")),
				 new XslParameter("ProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name")),
				 new XslParameter("ProductEmployeeCategoryName", "Params", GetDescription("Category", "Name")),
				 new XslParameter("ProductProductTypeName", "Params", GetDescription("ProductType", "Name")),
				 new XslParameter("GrantDecisionNumber", "Params", GetDescription("GrantDecision", "Number")),
				 new XslParameter("GrantDecisionYear", "Params", GetDescription("GrantDecision", "Year")),
				 new XslParameter("GrantDecisionDate", "Params", GetDescription("GrantDecision", "Date")),
				 new XslParameter("Amount", "Params", GetDescription("Grant", "Amount"))
            };
        }
    }
    #endregion

    #region GrantDecisionVwXmlRepresenter
    public class GrantDecisionVwXmlRepresenter : XmlRepresenterBase
    {
        public GrantDecisionVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "GrantDecision";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public GrantDecisionVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("GrantDecision", "Id")),
				 new XslParameter("Number", "Params", GetDescription("GrantDecision", "Number")),
				 new XslParameter("Year", "Params", GetDescription("GrantDecision", "Year")),
				 new XslParameter("GrantTypeGroupName", "Params", GetDescription("GrantTypeGroup", "Name")),
				 new XslParameter("Date", "Params", GetDescription("GrantDecision", "Date")),
				 new XslParameter("Notes", "Params", GetDescription("GrantDecision", "Notes"))
            };
        }
    }
    #endregion

    #region GrantDeductionVwXmlRepresenter
    public class GrantDeductionVwXmlRepresenter : XmlRepresenterBase
    {
        public GrantDeductionVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "GrantDeduction";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public GrantDeductionVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("GrantProductId", "Params", GetDescription("Product", "Id")),
				 new XslParameter("GrantProductEmployeeId", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("GrantProductEmployeeFullName", "Params", GetDescription("Employee", "GrantProductEmployeeFullName")),
				 new XslParameter("GrantProductEmployeeCategoryName", "Params", GetDescription("Category", "Name")),
				 new XslParameter("GrantProductProductTypeName", "Params", GetDescription("ProductType", "Name")),
				 new XslParameter("GrantGrantDecisionNumber", "Params", GetDescription("GrantDecision", "Number")),
				 new XslParameter("GrantGrantDecisionDate", "Params", GetDescription("GrantDecision", "Date")),
				 new XslParameter("Amount", "Params", GetDescription("GrantDeduction", "Amount"))
            };
        }
    }
    #endregion

    #region GrantPaymentVwXmlRepresenter
    public class GrantPaymentVwXmlRepresenter : XmlRepresenterBase
    {
        public GrantPaymentVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "GrantPayment";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public GrantPaymentVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("GrantPayment", "Id")),
				 new XslParameter("GrantPaymentOrderNumber", "Params", GetDescription("GrantPaymentOrder", "Number")),
				 new XslParameter("GrantPaymentOrderDate", "Params", GetDescription("GrantPaymentOrder", "Date")),
				 new XslParameter("SubNumber", "Params", GetDescription("GrantPayment", "SubNumber")),
				 new XslParameter("GrantProductEmployeeId", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("GrantProductEmployeeFullName", "Params", GetDescription("Employee", "GrantProductEmployeeFullName")),
				 new XslParameter("GrantProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name")),
				 new XslParameter("GrantProductEmployeeCategoryName", "Params", GetDescription("Category", "Name")),
				 new XslParameter("GrantProductProductTypeName", "Params", GetDescription("ProductType", "Name")),
				 new XslParameter("GrantAmount", "Params", GetDescription("Grant", "Amount")),
				 new XslParameter("Amount", "Params", GetDescription("GrantPayment", "Amount")),
				 new XslParameter("Notes", "Params", GetDescription("GrantPayment", "Notes"))
            };
        }
    }
    #endregion

    #region GrantPaymentOrderVwXmlRepresenter
    public class GrantPaymentOrderVwXmlRepresenter : XmlRepresenterBase
    {
        public GrantPaymentOrderVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "GrantPaymentOrder";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public GrantPaymentOrderVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("GrantPaymentOrder", "Id")),
				 new XslParameter("Number", "Params", GetDescription("GrantPaymentOrder", "Number")),
				 new XslParameter("Year", "Params", GetDescription("GrantPaymentOrder", "Year")),
				 new XslParameter("Date", "Params", GetDescription("GrantPaymentOrder", "Date")),
				 new XslParameter("Notes", "Params", GetDescription("GrantPaymentOrder", "Notes"))
            };
        }
    }
    #endregion

    #region GrantRequestVwXmlRepresenter
    public class GrantRequestVwXmlRepresenter : XmlRepresenterBase
    {
        public GrantRequestVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "GrantRequest";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public GrantRequestVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("RequestProductId", "Params", GetDescription("Product", "Id")),
				 new XslParameter("RequestProductEmployeeId", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("RequestProductEmployeeFullName", "Params", GetDescription("Employee", "RequestProductEmployeeFullName")),
				 new XslParameter("RequestProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name")),
				 new XslParameter("RequestProductEmployeeCategoryName", "Params", GetDescription("Category", "Name")),
				 new XslParameter("RequestProductProductTypeName", "Params", GetDescription("ProductType", "Name")),
				 new XslParameter("RequestDate", "Params", GetDescription("Request", "Date")),
				 new XslParameter("GrantType", "Params", GetDescription("GrantRequest", "GrantType")),
				 new XslParameter("Amount", "Params", GetDescription("GrantRequest", "Amount")),
				 new XslParameter("Notes", "Params", GetDescription("GrantRequest", "Notes"))
            };
        }
    }
    #endregion

    #region GrantTypeVwXmlRepresenter
    public class GrantTypeVwXmlRepresenter : XmlRepresenterBase
    {
        public GrantTypeVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "GrantType";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public GrantTypeVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("GrantType", "Id")),
				 new XslParameter("Name", "Params", GetDescription("GrantType", "Name")),
				 new XslParameter("Amount", "Params", GetDescription("GrantType", "Amount")),
				 new XslParameter("GrantTypeGroupName", "Params", GetDescription("GrantTypeGroup", "Name"))
            };
        }
    }
    #endregion

    #region GrantTypeGroupVwXmlRepresenter
    public class GrantTypeGroupVwXmlRepresenter : XmlRepresenterBase
    {
        public GrantTypeGroupVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "GrantTypeGroup";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public GrantTypeGroupVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("GrantTypeGroup", "Id")),
				 new XslParameter("Name", "Params", GetDescription("GrantTypeGroup", "Name"))
            };
        }
    }
    #endregion

    #region GuarantorVwXmlRepresenter
    public class GuarantorVwXmlRepresenter : XmlRepresenterBase
    {
        public GuarantorVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "Guarantor";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public GuarantorVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("Guarantor", "Id")),
				 new XslParameter("RefundableProductProductEmployeeId", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("RefundableProductProductEmployeeFullName", "Params", GetDescription("Employee", "RefundableProductProductEmployeeFullName")),
				 new XslParameter("RefundableProductProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name")),
				 new XslParameter("RefundableProductProductEmployeeCategoryName", "Params", GetDescription("Category", "Name")),
				 new XslParameter("RefundableProductProductProductTypeName", "Params", GetDescription("ProductType", "Name")),
				 new XslParameter("RefundableProductProductAmount", "Params", GetDescription("Product", "Amount")),
				 new XslParameter("SubNumber", "Params", GetDescription("Guarantor", "SubNumber")),
				 new XslParameter("EmployeeId", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("EmployeeFullName", "Params", GetDescription("Employee", "EmployeeFullName")),
				 new XslParameter("EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name")),
				 new XslParameter("EmployeeCategoryName", "Params", GetDescription("Category", "Name")),
				 new XslParameter("GuarantorStatusName", "Params", GetDescription("GuarantorStatus", "Name"))
            };
        }
    }
    #endregion

    #region GuarantorStatementVwXmlRepresenter
    public class GuarantorStatementVwXmlRepresenter : XmlRepresenterBase
    {
        public GuarantorStatementVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "GuarantorStatement";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public GuarantorStatementVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("GuarantorId", "Params", GetDescription("Guarantor", "Id")),
				 new XslParameter("GuarantorRefundableProductProductEmployeeId", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("GuarantorRefundableProductProductEmployeeFullName", "Params", GetDescription("Employee", "GuarantorRefundableProductProductEmployeeFullName")),
				 new XslParameter("GuarantorRefundableProductProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name")),
				 new XslParameter("GuarantorRefundableProductProductEmployeeCategoryName", "Params", GetDescription("Category", "Name")),
				 new XslParameter("GuarantorRefundableProductProductProductTypeName", "Params", GetDescription("ProductType", "Name")),
				 new XslParameter("GuarantorSubNumber", "Params", GetDescription("Guarantor", "SubNumber")),
				 new XslParameter("GuarantorEmployeeId", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("GuarantorEmployeeFullName", "Params", GetDescription("Employee", "GuarantorEmployeeFullName")),
				 new XslParameter("GuarantorEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name")),
				 new XslParameter("GuarantorEmployeeCategoryName", "Params", GetDescription("Category", "Name")),
				 new XslParameter("GuarantorGuarantorStatusName", "Params", GetDescription("GuarantorStatus", "Name")),
				 new XslParameter("GrossSalary", "Params", GetDescription("GuarantorStatement", "GrossSalary")),
				 new XslParameter("DeductionsAmount", "Params", GetDescription("GuarantorStatement", "DeductionsAmount")),
				 new XslParameter("NetSalary", "Params", GetDescription("GuarantorStatement", "NetSalary")),
				 new XslParameter("ExceptionalIncome", "Params", GetDescription("GuarantorStatement", "ExceptionalIncome"))
            };
        }
    }
    #endregion

    #region GuarantorStatusVwXmlRepresenter
    public class GuarantorStatusVwXmlRepresenter : XmlRepresenterBase
    {
        public GuarantorStatusVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "GuarantorStatus";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public GuarantorStatusVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("GuarantorStatus", "Id")),
				 new XslParameter("Name", "Params", GetDescription("GuarantorStatus", "Name"))
            };
        }
    }
    #endregion

    #region HealthLoanDecisionVwXmlRepresenter
    public class HealthLoanDecisionVwXmlRepresenter : XmlRepresenterBase
    {
        public HealthLoanDecisionVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "HealthLoanDecision";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public HealthLoanDecisionVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("HealthLoanDecision", "Id")),
				 new XslParameter("Number", "Params", GetDescription("HealthLoanDecision", "Number")),
				 new XslParameter("Date", "Params", GetDescription("HealthLoanDecision", "Date")),
				 new XslParameter("CersNumber", "Params", GetDescription("HealthLoanDecision", "CersNumber")),
				 new XslParameter("CersDate", "Params", GetDescription("HealthLoanDecision", "CersDate"))
            };
        }
    }
    #endregion

    #region HealthLoanDecisionFirstPaymentVwXmlRepresenter
    public class HealthLoanDecisionFirstPaymentVwXmlRepresenter : XmlRepresenterBase
    {
        public HealthLoanDecisionFirstPaymentVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "HealthLoanDecisionFirstPayment";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public HealthLoanDecisionFirstPaymentVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("HealthLoanDecisionFirstPayment", "Id")),
				 new XslParameter("EmployeeId", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("EmployeeFullName", "Params", GetDescription("Employee", "EmployeeFullName")),
				 new XslParameter("EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name")),
				 new XslParameter("EmployeeCategoryName", "Params", GetDescription("Category", "Name")),
				 new XslParameter("PaymentDate", "Params", GetDescription("HealthLoanDecisionFirstPayment", "PaymentDate")),
				 new XslParameter("PaymentAmount", "Params", GetDescription("HealthLoanDecisionFirstPayment", "PaymentAmount")),
				 new XslParameter("HealthLoanDecisionNumber", "Params", GetDescription("HealthLoanDecision", "Number")),
				 new XslParameter("HealthLoanDecisionDate", "Params", GetDescription("HealthLoanDecision", "Date"))
            };
        }
    }
    #endregion

    #region IncomingLoanVwXmlRepresenter
    public class IncomingLoanVwXmlRepresenter : XmlRepresenterBase
    {
        public IncomingLoanVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "IncomingLoan";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public IncomingLoanVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("LoanProductId", "Params", GetDescription("Product", "Id")),
				 new XslParameter("LoanProductEmployeeId", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("LoanProductEmployeeFullName", "Params", GetDescription("Employee", "LoanProductEmployeeFullName")),
				 new XslParameter("LoanProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name")),
				 new XslParameter("LoanProductEmployeeCategoryName", "Params", GetDescription("Category", "Name")),
				 new XslParameter("LoanProductProductTypeName", "Params", GetDescription("ProductType", "Name")),
				 new XslParameter("LoanProductAmount", "Params", GetDescription("Product", "Amount")),
				 new XslParameter("LoanLoanDecisionNumber", "Params", GetDescription("LoanDecision", "Number")),
				 new XslParameter("LoanLoanDecisionDate", "Params", GetDescription("LoanDecision", "Date")),
				 new XslParameter("LoanLoanDecisionLoanDecisionTypeName", "Params", GetDescription("LoanDecisionType", "Name")),
				 new XslParameter("LoanLoanStatusName", "Params", GetDescription("LoanStatus", "Name"))
            };
        }
    }
    #endregion

    #region InstallmentVwXmlRepresenter
    public class InstallmentVwXmlRepresenter : XmlRepresenterBase
    {
        public InstallmentVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "Installment";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public InstallmentVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("Installment", "Id")),
				 new XslParameter("RefundableProductProductEmployeeId", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("RefundableProductProductEmployeeFullName", "Params", GetDescription("Employee", "RefundableProductProductEmployeeFullName")),
				 new XslParameter("RefundableProductProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name")),
				 new XslParameter("RefundableProductProductEmployeeCategoryName", "Params", GetDescription("Category", "Name")),
				 new XslParameter("RefundableProductProductProductTypeName", "Params", GetDescription("ProductType", "Name")),
				 new XslParameter("RefundableProductInstallment", "Params", GetDescription("RefundableProduct", "Installment")),
				 new XslParameter("SubNumber", "Params", GetDescription("Installment", "SubNumber")),
				 new XslParameter("DueDate", "Params", GetDescription("Installment", "DueDate")),
				 new XslParameter("DueCapital", "Params", GetDescription("Installment", "DueCapital")),
				 new XslParameter("DueProfit", "Params", GetDescription("Installment", "DueProfit"))
            };
        }
    }
    #endregion

    #region InstallmentDecreaseVwXmlRepresenter
    public class InstallmentDecreaseVwXmlRepresenter : XmlRepresenterBase
    {
        public InstallmentDecreaseVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "InstallmentDecrease";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public InstallmentDecreaseVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("InstallmentDecrease", "Id")),
				 new XslParameter("InstallmentDecreaseOrderMonth", "Params", GetDescription("InstallmentDecreaseOrder", "Month")),
				 new XslParameter("InstallmentDecreaseOrderCersNumber", "Params", GetDescription("InstallmentDecreaseOrder", "CersNumber")),
				 new XslParameter("InstallmentDecreaseOrderCersDate", "Params", GetDescription("InstallmentDecreaseOrder", "CersDate")),
				 new XslParameter("EmployeeId", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("EmployeeFullName", "Params", GetDescription("Employee", "EmployeeFullName")),
				 new XslParameter("EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name")),
				 new XslParameter("EmployeeCategoryName", "Params", GetDescription("Category", "Name")),
				 new XslParameter("DepartmentName", "Params", GetDescription("Department", "Name")),
				 new XslParameter("DecreaseAmount", "Params", GetDescription("InstallmentDecrease", "DecreaseAmount")),
				 new XslParameter("NewInstallmentAmount", "Params", GetDescription("InstallmentDecrease", "NewInstallmentAmount"))
            };
        }
    }
    #endregion

    #region InstallmentDecreaseOrderVwXmlRepresenter
    public class InstallmentDecreaseOrderVwXmlRepresenter : XmlRepresenterBase
    {
        public InstallmentDecreaseOrderVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "InstallmentDecreaseOrder";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public InstallmentDecreaseOrderVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("InstallmentDecreaseOrder", "Id")),
				 new XslParameter("Month", "Params", GetDescription("InstallmentDecreaseOrder", "Month")),
				 new XslParameter("CersNumber", "Params", GetDescription("InstallmentDecreaseOrder", "CersNumber")),
				 new XslParameter("CersDate", "Params", GetDescription("InstallmentDecreaseOrder", "CersDate"))
            };
        }
    }
    #endregion

    #region InsuranceTypeVwXmlRepresenter
    public class InsuranceTypeVwXmlRepresenter : XmlRepresenterBase
    {
        public InsuranceTypeVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "InsuranceType";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public InsuranceTypeVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("InsuranceType", "Id")),
				 new XslParameter("Name", "Params", GetDescription("InsuranceType", "Name"))
            };
        }
    }
    #endregion

    #region IssuerVwXmlRepresenter
    public class IssuerVwXmlRepresenter : XmlRepresenterBase
    {
        public IssuerVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "Issuer";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public IssuerVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("Issuer", "Id")),
				 new XslParameter("Name", "Params", GetDescription("Issuer", "Name"))
            };
        }
    }
    #endregion

    #region LoanVwXmlRepresenter
    public class LoanVwXmlRepresenter : XmlRepresenterBase
    {
        public LoanVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "Loan";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public LoanVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("ProductId", "Params", GetDescription("Product", "Id")),
				 new XslParameter("ProductEmployeeId", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("ProductEmployeeFullName", "Params", GetDescription("Employee", "ProductEmployeeFullName")),
				 new XslParameter("ProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name")),
				 new XslParameter("ProductEmployeeCategoryName", "Params", GetDescription("Category", "Name")),
				 new XslParameter("ProductProductTypeName", "Params", GetDescription("ProductType", "Name")),
				 new XslParameter("ProductProductTypeRate", "Params", GetDescription("ProductType", "Rate")),
				 new XslParameter("ProductAmount", "Params", GetDescription("Product", "Amount")),
				 new XslParameter("LoanDecisionNumber", "Params", GetDescription("LoanDecision", "Number")),
				 new XslParameter("LoanDecisionDate", "Params", GetDescription("LoanDecision", "Date")),
				 new XslParameter("LoanStatusName", "Params", GetDescription("LoanStatus", "Name"))
            };
        }
    }
    #endregion

    #region LoanChangeVwXmlRepresenter
    public class LoanChangeVwXmlRepresenter : XmlRepresenterBase
    {
        public LoanChangeVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "LoanChange";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public LoanChangeVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("LoanProductId", "Params", GetDescription("Product", "Id")),
				 new XslParameter("LoanProductEmployeeId", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("LoanProductEmployeeFullName", "Params", GetDescription("Employee", "LoanProductEmployeeFullName")),
				 new XslParameter("LoanProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name")),
				 new XslParameter("LoanProductEmployeeCategoryName", "Params", GetDescription("Category", "Name")),
				 new XslParameter("LoanProductProductTypeName", "Params", GetDescription("ProductType", "Name")),
				 new XslParameter("LoanProductAmount", "Params", GetDescription("Product", "Amount")),
				 new XslParameter("LoanLoanDecisionDate", "Params", GetDescription("LoanDecision", "Date")),
				 new XslParameter("LoanLoanType", "Params", GetDescription("Loan", "LoanType")),
				 new XslParameter("FromLoanProductEmployeeId", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("FromLoanProductEmployeeFullName", "Params", GetDescription("Employee", "FromLoanProductEmployeeFullName")),
				 new XslParameter("FromLoanLoanType", "Params", GetDescription("Loan", "LoanType"))
            };
        }
    }
    #endregion

    #region LoanDecisionVwXmlRepresenter
    public class LoanDecisionVwXmlRepresenter : XmlRepresenterBase
    {
        public LoanDecisionVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "LoanDecision";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public LoanDecisionVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("LoanDecision", "Id")),
				 new XslParameter("Number", "Params", GetDescription("LoanDecision", "Number")),
				 new XslParameter("Date", "Params", GetDescription("LoanDecision", "Date")),
				 new XslParameter("DeductionStartDate", "Params", GetDescription("LoanDecision", "DeductionStartDate")),
				 new XslParameter("LoanDecisionTypeName", "Params", GetDescription("LoanDecisionType", "Name")),
				 new XslParameter("IsPaidFromSalary", "Params", GetDescription("LoanDecision", "IsPaidFromSalary")),
				 new XslParameter("Reason", "Params", GetDescription("LoanDecision", "Reason"))
            };
        }
    }
    #endregion

    #region LoanDecisionTypeVwXmlRepresenter
    public class LoanDecisionTypeVwXmlRepresenter : XmlRepresenterBase
    {
        public LoanDecisionTypeVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "LoanDecisionType";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public LoanDecisionTypeVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("LoanDecisionType", "Id")),
				 new XslParameter("Name", "Params", GetDescription("LoanDecisionType", "Name"))
            };
        }
    }
    #endregion

    #region LoanGenerationStatusVwXmlRepresenter
    public class LoanGenerationStatusVwXmlRepresenter : XmlRepresenterBase
    {
        public LoanGenerationStatusVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "LoanGenerationStatus";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public LoanGenerationStatusVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("LoanGenerationStatus", "Id")),
				 new XslParameter("Name", "Params", GetDescription("LoanGenerationStatus", "Name"))
            };
        }
    }
    #endregion

    #region LoanRequestVwXmlRepresenter
    public class LoanRequestVwXmlRepresenter : XmlRepresenterBase
    {
        public LoanRequestVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "LoanRequest";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public LoanRequestVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("RequestProductId", "Params", GetDescription("Product", "Id")),
				 new XslParameter("RequestProductEmployeeId", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("RequestProductEmployeeFullName", "Params", GetDescription("Employee", "RequestProductEmployeeFullName")),
				 new XslParameter("RequestProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name")),
				 new XslParameter("RequestProductEmployeeCategoryName", "Params", GetDescription("Category", "Name")),
				 new XslParameter("RequestProductProductTypeName", "Params", GetDescription("ProductType", "Name")),
				 new XslParameter("RequestDate", "Params", GetDescription("Request", "Date")),
				 new XslParameter("RequestAmount", "Params", GetDescription("Request", "Amount")),
				 new XslParameter("RequestRequestStatusName", "Params", GetDescription("RequestStatus", "Name"))
            };
        }
    }
    #endregion

    #region LoanStatusVwXmlRepresenter
    public class LoanStatusVwXmlRepresenter : XmlRepresenterBase
    {
        public LoanStatusVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "LoanStatus";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public LoanStatusVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("LoanStatus", "Id")),
				 new XslParameter("Name", "Params", GetDescription("LoanStatus", "Name"))
            };
        }
    }
    #endregion

    #region LoanTypeVwXmlRepresenter
    public class LoanTypeVwXmlRepresenter : XmlRepresenterBase
    {
        public LoanTypeVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "LoanType";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public LoanTypeVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("ProductTypeId", "Params", GetDescription("ProductType", "Id")),
				 new XslParameter("ProductTypeName", "Params", GetDescription("ProductType", "Name")),
				 new XslParameter("ProductTypeRate", "Params", GetDescription("ProductType", "Rate")),
				 new XslParameter("ProductTypeGuarantorsCount", "Params", GetDescription("ProductType", "GuarantorsCount")),
				 new XslParameter("ProductTypeProfitStrategyName", "Params", GetDescription("ProfitStrategy", "Name")),
				 new XslParameter("ProductTypePaymentGroupName", "Params", GetDescription("PaymentGroup", "Name")),
				 new XslParameter("ProductTypeIsActive", "Params", GetDescription("ProductType", "IsActive"))
            };
        }
    }
    #endregion

    #region LoanTypeClosureVwXmlRepresenter
    public class LoanTypeClosureVwXmlRepresenter : XmlRepresenterBase
    {
        public LoanTypeClosureVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "LoanTypeClosure";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public LoanTypeClosureVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("LoanTypeClosure", "Id")),
				 new XslParameter("LoanTypeProductTypeName", "Params", GetDescription("ProductType", "Name")),
				 new XslParameter("LoanTypeProductTypeRate", "Params", GetDescription("ProductType", "Rate")),
				 new XslParameter("LoanTypeProductTypeGuarantorsCount", "Params", GetDescription("ProductType", "GuarantorsCount")),
				 new XslParameter("LoanTypeProductTypePaymentGroupName", "Params", GetDescription("PaymentGroup", "Name")),
				 new XslParameter("LoanTypeProductTypeIsActive", "Params", GetDescription("ProductType", "IsActive")),
				 new XslParameter("ClosingLoanTypeProductTypeName", "Params", GetDescription("ProductType", "Name")),
				 new XslParameter("ClosingLoanTypeProductTypeGuarantorsCount", "Params", GetDescription("ProductType", "GuarantorsCount")),
				 new XslParameter("ClosingLoanTypeProductTypePaymentGroupName", "Params", GetDescription("PaymentGroup", "Name")),
				 new XslParameter("ClosingLoanTypeProductTypeIsActive", "Params", GetDescription("ProductType", "IsActive"))
            };
        }
    }
    #endregion

    #region MainWorkPlaceVwXmlRepresenter
    public class MainWorkPlaceVwXmlRepresenter : XmlRepresenterBase
    {
        public MainWorkPlaceVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "MainWorkPlace";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public MainWorkPlaceVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("MainWorkPlace", "Id")),
				 new XslParameter("Name", "Params", GetDescription("MainWorkPlace", "Name"))
            };
        }
    }
    #endregion

    #region MissingInstallmentDecreaseVwXmlRepresenter
    public class MissingInstallmentDecreaseVwXmlRepresenter : XmlRepresenterBase
    {
        public MissingInstallmentDecreaseVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "MissingInstallmentDecrease";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public MissingInstallmentDecreaseVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("EmployeeId", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("EmployeeFullName", "Params", GetDescription("Employee", "EmployeeFullName")),
				 new XslParameter("EmployeeDepartmentSalaryWorkPlaceName", "Params", GetDescription("SalaryWorkPlace", "Name")),
				 new XslParameter("EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name")),
				 new XslParameter("EmployeeCategoryName", "Params", GetDescription("Category", "Name")),
				 new XslParameter("SalaryAmount", "Params", GetDescription("MissingInstallmentDecrease", "SalaryAmount")),
				 new XslParameter("TransferMonth", "Params", GetDescription("MissingInstallmentDecrease", "TransferMonth")),
				 new XslParameter("FinishedInstallmentsAmount", "Params", GetDescription("MissingInstallmentDecrease", "FinishedInstallmentsAmount")),
				 new XslParameter("RemainingInstallmentsAmount", "Params", GetDescription("MissingInstallmentDecrease", "RemainingInstallmentsAmount"))
            };
        }
    }
    #endregion

    #region MonthlyBalanceVwXmlRepresenter
    public class MonthlyBalanceVwXmlRepresenter : XmlRepresenterBase
    {
        public MonthlyBalanceVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "MonthlyBalance";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public MonthlyBalanceVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("MonthlyBalance", "Id")),
				 new XslParameter("EmployeeId", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("EmployeeFullName", "Params", GetDescription("Employee", "EmployeeFullName")),
				 new XslParameter("EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name")),
				 new XslParameter("EmployeeCategoryName", "Params", GetDescription("Category", "Name")),
				 new XslParameter("PaymentGroupName", "Params", GetDescription("PaymentGroup", "Name")),
				 new XslParameter("Month", "Params", GetDescription("MonthlyBalance", "Month")),
				 new XslParameter("Opening", "Params", GetDescription("MonthlyBalance", "Opening")),
				 new XslParameter("NormalLoans", "Params", GetDescription("MonthlyBalance", "NormalLoans")),
				 new XslParameter("IncomingLoans", "Params", GetDescription("MonthlyBalance", "IncomingLoans")),
				 new XslParameter("Restitution", "Params", GetDescription("MonthlyBalance", "Restitution")),
				 new XslParameter("OutgoingLoans", "Params", GetDescription("MonthlyBalance", "OutgoingLoans")),
				 new XslParameter("SalaryPayment", "Params", GetDescription("MonthlyBalance", "SalaryPayment")),
				 new XslParameter("CashPayment", "Params", GetDescription("MonthlyBalance", "CashPayment"))
            };
        }
    }
    #endregion

    #region OutgoingLoanVwXmlRepresenter
    public class OutgoingLoanVwXmlRepresenter : XmlRepresenterBase
    {
        public OutgoingLoanVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "OutgoingLoan";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public OutgoingLoanVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("LoanProductId", "Params", GetDescription("Product", "Id")),
				 new XslParameter("LoanProductEmployeeId", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("LoanProductEmployeeFullName", "Params", GetDescription("Employee", "LoanProductEmployeeFullName")),
				 new XslParameter("LoanProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name")),
				 new XslParameter("LoanProductProductTypeName", "Params", GetDescription("ProductType", "Name")),
				 new XslParameter("LoanProductAmount", "Params", GetDescription("Product", "Amount")),
				 new XslParameter("LoanDecisionNumber", "Params", GetDescription("LoanDecision", "Number")),
				 new XslParameter("LoanDecisionDate", "Params", GetDescription("LoanDecision", "Date")),
				 new XslParameter("MainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name")),
				 new XslParameter("ApprovedAmount", "Params", GetDescription("OutgoingLoan", "ApprovedAmount")),
				 new XslParameter("NetAmount", "Params", GetDescription("OutgoingLoan", "NetAmount")),
				 new XslParameter("ProfitAmount", "Params", GetDescription("OutgoingLoan", "ProfitAmount"))
            };
        }
    }
    #endregion

    #region PaymentVwXmlRepresenter
    public class PaymentVwXmlRepresenter : XmlRepresenterBase
    {
        public PaymentVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "Payment";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public PaymentVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("Payment", "Id")),
				 new XslParameter("EmployeeId", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("EmployeeFullName", "Params", GetDescription("Employee", "EmployeeFullName")),
				 new XslParameter("EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name")),
				 new XslParameter("EmployeeCategoryName", "Params", GetDescription("Category", "Name")),
				 new XslParameter("PaymentGroupName", "Params", GetDescription("PaymentGroup", "Name")),
				 new XslParameter("Amount", "Params", GetDescription("Payment", "Amount")),
				 new XslParameter("PaymentStatusName", "Params", GetDescription("PaymentStatus", "Name"))
            };
        }
    }
    #endregion

    #region PaymentGroupVwXmlRepresenter
    public class PaymentGroupVwXmlRepresenter : XmlRepresenterBase
    {
        public PaymentGroupVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "PaymentGroup";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public PaymentGroupVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("PaymentGroup", "Id")),
				 new XslParameter("Name", "Params", GetDescription("PaymentGroup", "Name"))
            };
        }
    }
    #endregion

    #region PaymentStatusVwXmlRepresenter
    public class PaymentStatusVwXmlRepresenter : XmlRepresenterBase
    {
        public PaymentStatusVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "PaymentStatus";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public PaymentStatusVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("PaymentStatus", "Id")),
				 new XslParameter("Name", "Params", GetDescription("PaymentStatus", "Name"))
            };
        }
    }
    #endregion

    #region PayOrderVwXmlRepresenter
    public class PayOrderVwXmlRepresenter : XmlRepresenterBase
    {
        public PayOrderVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "PayOrder";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public PayOrderVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("PayOrder", "Id")),
				 new XslParameter("EmployeeId", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("EmployeeFullName", "Params", GetDescription("Employee", "EmployeeFullName")),
				 new XslParameter("EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name")),
				 new XslParameter("EmployeeCategoryName", "Params", GetDescription("Category", "Name")),
				 new XslParameter("Number", "Params", GetDescription("PayOrder", "Number")),
				 new XslParameter("Date", "Params", GetDescription("PayOrder", "Date")),
				 new XslParameter("PaymentGroupName", "Params", GetDescription("PaymentGroup", "Name")),
				 new XslParameter("PaidAmount", "Params", GetDescription("PayOrder", "PaidAmount")),
				 new XslParameter("IsProfit", "Params", GetDescription("PayOrder", "IsProfit")),
				 new XslParameter("IsFixed", "Params", GetDescription("PayOrder", "IsFixed"))
            };
        }
    }
    #endregion

    #region ProductVwXmlRepresenter
    public class ProductVwXmlRepresenter : XmlRepresenterBase
    {
        public ProductVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "Product";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public ProductVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("Product", "Id")),
				 new XslParameter("EmployeeId", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("EmployeeFullName", "Params", GetDescription("Employee", "EmployeeFullName")),
				 new XslParameter("EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name")),
				 new XslParameter("EmployeeCategoryName", "Params", GetDescription("Category", "Name")),
				 new XslParameter("ProductTypeName", "Params", GetDescription("ProductType", "Name")),
				 new XslParameter("Amount", "Params", GetDescription("Product", "Amount"))
            };
        }
    }
    #endregion

    #region ProductTypeVwXmlRepresenter
    public class ProductTypeVwXmlRepresenter : XmlRepresenterBase
    {
        public ProductTypeVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "ProductType";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public ProductTypeVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("ProductType", "Id")),
				 new XslParameter("Name", "Params", GetDescription("ProductType", "Name")),
				 new XslParameter("Rate", "Params", GetDescription("ProductType", "Rate")),
				 new XslParameter("GuarantorsCount", "Params", GetDescription("ProductType", "GuarantorsCount")),
				 new XslParameter("ProfitStrategyName", "Params", GetDescription("ProfitStrategy", "Name")),
				 new XslParameter("PaymentGroupName", "Params", GetDescription("PaymentGroup", "Name")),
				 new XslParameter("IsActive", "Params", GetDescription("ProductType", "IsActive"))
            };
        }
    }
    #endregion

    #region ProductTypeAvailabilityVwXmlRepresenter
    public class ProductTypeAvailabilityVwXmlRepresenter : XmlRepresenterBase
    {
        public ProductTypeAvailabilityVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "ProductTypeAvailability";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public ProductTypeAvailabilityVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("ProductTypeAvailability", "Id")),
				 new XslParameter("ProductTypeName", "Params", GetDescription("ProductType", "Name")),
				 new XslParameter("ProductTypeRate", "Params", GetDescription("ProductType", "Rate")),
				 new XslParameter("ProductTypeGuarantorsCount", "Params", GetDescription("ProductType", "GuarantorsCount")),
				 new XslParameter("ProductTypePaymentGroupName", "Params", GetDescription("PaymentGroup", "Name")),
				 new XslParameter("ProductTypeIsActive", "Params", GetDescription("ProductType", "IsActive")),
				 new XslParameter("AvailabilityName", "Params", GetDescription("Availability", "Name")),
				 new XslParameter("AvailabilityMinSeniority", "Params", GetDescription("Availability", "MinSeniority")),
				 new XslParameter("AvailabilityMinReusePeriod", "Params", GetDescription("Availability", "MinReusePeriod"))
            };
        }
    }
    #endregion

    #region ProfileVwXmlRepresenter
    public class ProfileVwXmlRepresenter : XmlRepresenterBase
    {
        public ProfileVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "Profile";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public ProfileVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("EmployeeId", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name")),
				 new XslParameter("EmployeeCategoryName", "Params", GetDescription("Category", "Name")),
				 new XslParameter("Extension", "Params", GetDescription("Profile", "Extension")),
				 new XslParameter("HomePhone", "Params", GetDescription("Profile", "HomePhone")),
				 new XslParameter("MobilePhone", "Params", GetDescription("Profile", "MobilePhone"))
            };
        }
    }
    #endregion

    #region ProfitStrategyVwXmlRepresenter
    public class ProfitStrategyVwXmlRepresenter : XmlRepresenterBase
    {
        public ProfitStrategyVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "ProfitStrategy";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public ProfitStrategyVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("ProfitStrategy", "Id")),
				 new XslParameter("Name", "Params", GetDescription("ProfitStrategy", "Name"))
            };
        }
    }
    #endregion

    #region RefundableProductVwXmlRepresenter
    public class RefundableProductVwXmlRepresenter : XmlRepresenterBase
    {
        public RefundableProductVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "RefundableProduct";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public RefundableProductVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("ProductId", "Params", GetDescription("Product", "Id")),
				 new XslParameter("ProductEmployeeId", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("ProductEmployeeFullName", "Params", GetDescription("Employee", "ProductEmployeeFullName")),
				 new XslParameter("ProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name")),
				 new XslParameter("ProductEmployeeCategoryName", "Params", GetDescription("Category", "Name")),
				 new XslParameter("ProductProductTypeName", "Params", GetDescription("ProductType", "Name")),
				 new XslParameter("ProductProductTypePaymentGroupName", "Params", GetDescription("PaymentGroup", "Name")),
				 new XslParameter("ProductAmount", "Params", GetDescription("Product", "Amount")),
				 new XslParameter("Installment", "Params", GetDescription("RefundableProduct", "Installment"))
            };
        }
    }
    #endregion

    #region RequestVwXmlRepresenter
    public class RequestVwXmlRepresenter : XmlRepresenterBase
    {
        public RequestVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "Request";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public RequestVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("ProductId", "Params", GetDescription("Product", "Id")),
				 new XslParameter("ProductEmployeeId", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("ProductEmployeeFullName", "Params", GetDescription("Employee", "ProductEmployeeFullName")),
				 new XslParameter("ProductEmployeeDepartmentName", "Params", GetDescription("Department", "Name")),
				 new XslParameter("ProductEmployeeCategoryName", "Params", GetDescription("Category", "Name")),
				 new XslParameter("ProductProductTypeName", "Params", GetDescription("ProductType", "Name")),
				 new XslParameter("Date", "Params", GetDescription("Request", "Date")),
				 new XslParameter("Amount", "Params", GetDescription("Request", "Amount")),
				 new XslParameter("RequestStatusName", "Params", GetDescription("RequestStatus", "Name"))
            };
        }
    }
    #endregion

    #region RequestStatusVwXmlRepresenter
    public class RequestStatusVwXmlRepresenter : XmlRepresenterBase
    {
        public RequestStatusVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "RequestStatus";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public RequestStatusVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("RequestStatus", "Id")),
				 new XslParameter("Name", "Params", GetDescription("RequestStatus", "Name"))
            };
        }
    }
    #endregion

    #region ResourceVwXmlRepresenter
    public class ResourceVwXmlRepresenter : XmlRepresenterBase
    {
        public ResourceVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "Resource";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public ResourceVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("Resource", "Id")),
				 new XslParameter("Language", "Params", GetDescription("Resource", "Language")),
				 new XslParameter("Module", "Params", GetDescription("Resource", "Module")),
				 new XslParameter("Key", "Params", GetDescription("Resource", "Key")),
				 new XslParameter("Value", "Params", GetDescription("Resource", "Value"))
            };
        }
    }
    #endregion

    #region SalaryPaymentVwXmlRepresenter
    public class SalaryPaymentVwXmlRepresenter : XmlRepresenterBase
    {
        public SalaryPaymentVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "SalaryPayment";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public SalaryPaymentVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("PaymentId", "Params", GetDescription("Payment", "Id")),
				 new XslParameter("PaymentEmployeeId", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("PaymentEmployeeFullName", "Params", GetDescription("Employee", "PaymentEmployeeFullName")),
				 new XslParameter("PaymentEmployeeDepartmentSalaryWorkPlaceName", "Params", GetDescription("SalaryWorkPlace", "Name")),
				 new XslParameter("PaymentDate", "Params", GetDescription("Payment", "Date")),
				 new XslParameter("PaymentPaymentGroupName", "Params", GetDescription("PaymentGroup", "Name")),
				 new XslParameter("PaymentAmount", "Params", GetDescription("Payment", "Amount")),
				 new XslParameter("PaymentPaymentStatusName", "Params", GetDescription("PaymentStatus", "Name")),
				 new XslParameter("Balance", "Params", GetDescription("SalaryPayment", "Balance"))
            };
        }
    }
    #endregion

    #region SalaryWorkPlaceVwXmlRepresenter
    public class SalaryWorkPlaceVwXmlRepresenter : XmlRepresenterBase
    {
        public SalaryWorkPlaceVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "SalaryWorkPlace";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public SalaryWorkPlaceVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("SalaryWorkPlace", "Id")),
				 new XslParameter("Name", "Params", GetDescription("SalaryWorkPlace", "Name")),
				 new XslParameter("MainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name"))
            };
        }
    }
    #endregion

    #region ServiceEndGrantRequestVwXmlRepresenter
    public class ServiceEndGrantRequestVwXmlRepresenter : XmlRepresenterBase
    {
        public ServiceEndGrantRequestVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "ServiceEndGrantRequest";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public ServiceEndGrantRequestVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("GrantRequestRequestProductEmployeeId", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("GrantRequestRequestProductEmployeeFullName", "Params", GetDescription("Employee", "GrantRequestRequestProductEmployeeFullName")),
				 new XslParameter("GrantRequestRequestProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name")),
				 new XslParameter("GrantRequestRequestProductEmployeeCategoryName", "Params", GetDescription("Category", "Name")),
				 new XslParameter("GrantRequestRequestProductProductTypeName", "Params", GetDescription("ProductType", "Name")),
				 new XslParameter("GrantRequestAmount", "Params", GetDescription("GrantRequest", "Amount")),
				 new XslParameter("ServiceInMonthes", "Params", GetDescription("ServiceEndGrantRequest", "ServiceInMonthes"))
            };
        }
    }
    #endregion

    #region SettlementVwXmlRepresenter
    public class SettlementVwXmlRepresenter : XmlRepresenterBase
    {
        public SettlementVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "Settlement";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public SettlementVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("Settlement", "Id")),
				 new XslParameter("InstallmentRefundableProductProductId", "Params", GetDescription("Product", "Id")),
				 new XslParameter("InstallmentRefundableProductProductEmployeeId", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("InstallmentRefundableProductProductEmployeeFullName", "Params", GetDescription("Employee", "InstallmentRefundableProductProductEmployeeFullName")),
				 new XslParameter("InstallmentRefundableProductProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name")),
				 new XslParameter("InstallmentRefundableProductProductEmployeeCategoryName", "Params", GetDescription("Category", "Name")),
				 new XslParameter("InstallmentRefundableProductProductProductTypeName", "Params", GetDescription("ProductType", "Name")),
				 new XslParameter("InstallmentSubNumber", "Params", GetDescription("Installment", "SubNumber")),
				 new XslParameter("InstallmentDueDate", "Params", GetDescription("Installment", "DueDate")),
				 new XslParameter("InstallmentDueCapital", "Params", GetDescription("Installment", "DueCapital")),
				 new XslParameter("InstallmentDueProfit", "Params", GetDescription("Installment", "DueProfit")),
				 new XslParameter("PaymentDate", "Params", GetDescription("Payment", "Date")),
				 new XslParameter("Amount", "Params", GetDescription("Settlement", "Amount"))
            };
        }
    }
    #endregion

    #region SpecialCaseLoanVwXmlRepresenter
    public class SpecialCaseLoanVwXmlRepresenter : XmlRepresenterBase
    {
        public SpecialCaseLoanVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "SpecialCaseLoan";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public SpecialCaseLoanVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("SpecialCaseLoan", "Id")),
				 new XslParameter("EmployeeId", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("EmployeeFullName", "Params", GetDescription("Employee", "EmployeeFullName")),
				 new XslParameter("EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name")),
				 new XslParameter("EmployeeCategoryName", "Params", GetDescription("Category", "Name")),
				 new XslParameter("Date", "Params", GetDescription("SpecialCaseLoan", "Date")),
				 new XslParameter("LoanTypeProductTypeName", "Params", GetDescription("ProductType", "Name")),
				 new XslParameter("Amount", "Params", GetDescription("SpecialCaseLoan", "Amount"))
            };
        }
    }
    #endregion

    #region SubscriptionVwXmlRepresenter
    public class SubscriptionVwXmlRepresenter : XmlRepresenterBase
    {
        public SubscriptionVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "Subscription";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public SubscriptionVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("Subscription", "Id")),
				 new XslParameter("EmployeeId", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("EmployeeFullName", "Params", GetDescription("Employee", "EmployeeFullName")),
				 new XslParameter("EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name")),
				 new XslParameter("EmployeeCategoryName", "Params", GetDescription("Category", "Name")),
				 new XslParameter("Month", "Params", GetDescription("Subscription", "Month")),
				 new XslParameter("DepartmentSalaryWorkPlaceMainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name")),
				 new XslParameter("SubscriptionTypeName", "Params", GetDescription("SubscriptionType", "Name")),
				 new XslParameter("Amount", "Params", GetDescription("Subscription", "Amount")),
				 new XslParameter("IsFixed", "Params", GetDescription("Subscription", "IsFixed"))
            };
        }
    }
    #endregion

    #region SubscriptionTypeVwXmlRepresenter
    public class SubscriptionTypeVwXmlRepresenter : XmlRepresenterBase
    {
        public SubscriptionTypeVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "SubscriptionType";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public SubscriptionTypeVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("SubscriptionType", "Id")),
				 new XslParameter("Name", "Params", GetDescription("SubscriptionType", "Name"))
            };
        }
    }
    #endregion

    #region TransitoryIncomingLoanVwXmlRepresenter
    public class TransitoryIncomingLoanVwXmlRepresenter : XmlRepresenterBase
    {
        public TransitoryIncomingLoanVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "TransitoryIncomingLoan";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public TransitoryIncomingLoanVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("EmployeeId", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("EmployeeFullName", "Params", GetDescription("Employee", "EmployeeFullName")),
				 new XslParameter("EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name")),
				 new XslParameter("EmployeeCategoryName", "Params", GetDescription("Category", "Name")),
				 new XslParameter("MainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name")),
				 new XslParameter("ApprovedAmount", "Params", GetDescription("TransitoryIncomingLoan", "ApprovedAmount")),
				 new XslParameter("Installment", "Params", GetDescription("TransitoryIncomingLoan", "Installment"))
            };
        }
    }
    #endregion

    #region WarrantVwXmlRepresenter
    public class WarrantVwXmlRepresenter : XmlRepresenterBase
    {
        public WarrantVwXmlRepresenter(string xml, string culture)
        {
            this.parameters = GetParameters();
            this.module = "Warrant";
            this.culture = culture;
            this.xsl = GetXsl();
            this.html = GetHtml(xsl, xml);
        }
        public WarrantVwXmlRepresenter(string xml) : this(xml, "ar")
        {
        }
        protected override XslParameter [] GetParameters()
        {
            return new XslParameter []
            {
				 new XslParameter("Id", "Params", GetDescription("Warrant", "Id")),
				 new XslParameter("DebtEmployeeId", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("DebtEmployeeFullName", "Params", GetDescription("Employee", "DebtEmployeeFullName")),
				 new XslParameter("DebtEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name")),
				 new XslParameter("DebtEmployeeCategoryName", "Params", GetDescription("Category", "Name")),
				 new XslParameter("DebtAmount", "Params", GetDescription("Debt", "Amount")),
				 new XslParameter("DebtIssuerName", "Params", GetDescription("Issuer", "Name")),
				 new XslParameter("DebtDate", "Params", GetDescription("Debt", "Date")),
				 new XslParameter("DebtPeriodInMonths", "Params", GetDescription("Debt", "PeriodInMonths")),
				 new XslParameter("DebtInstallment", "Params", GetDescription("Debt", "Installment")),
				 new XslParameter("EmployeeId", "Params", GetDescription("Employee", "Id")),
				 new XslParameter("EmployeeFullName", "Params", GetDescription("Employee", "EmployeeFullName")),
				 new XslParameter("EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName", "Params", GetDescription("MainWorkPlace", "Name")),
				 new XslParameter("EmployeeCategoryName", "Params", GetDescription("Category", "Name")),
				 new XslParameter("IsActive", "Params", GetDescription("Warrant", "IsActive"))
            };
        }
    }
    #endregion
}
