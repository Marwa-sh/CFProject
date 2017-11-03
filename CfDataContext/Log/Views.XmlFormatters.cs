using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Cf.Data
{
    #region AvailabilityVwXmlFormatter
    public class AvailabilityVwXmlFormatter : XmlFormatterBase
    {
        public AvailabilityVwXmlFormatter(AvailabilityVw availabilityVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(availabilityVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public AvailabilityVwXmlFormatter(Availability availability)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(availability);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<Name>{1}</Name>";
            parametersFormat += "\n\t<MinSeniority>{2}</MinSeniority>";
            parametersFormat += "\n\t<MinReusePeriod>{3}</MinReusePeriod>";
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

    #region AvailabilityCeilingVwXmlFormatter
    public class AvailabilityCeilingVwXmlFormatter : XmlFormatterBase
    {
        public AvailabilityCeilingVwXmlFormatter(AvailabilityCeilingVw availabilityCeilingVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(availabilityCeilingVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public AvailabilityCeilingVwXmlFormatter(AvailabilityCeiling availabilityCeiling)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(availabilityCeiling);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<AvailabilityId>{1}</AvailabilityId>";
            parametersFormat += "\n\t<AvailabilityName>{2}</AvailabilityName>";
            parametersFormat += "\n\t<AvailabilityMinSeniority>{3}</AvailabilityMinSeniority>";
            parametersFormat += "\n\t<AvailabilityMinReusePeriod>{4}</AvailabilityMinReusePeriod>";
            parametersFormat += "\n\t<FromYear>{5}</FromYear>";
            parametersFormat += "\n\t<MaxAmount>{6}</MaxAmount>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(AvailabilityCeilingVw availabilityCeilingVw)
        {
            return new string []
            {
				availabilityCeilingVw.Id.ToString(),
				availabilityCeilingVw.AvailabilityId.ToString(),
				availabilityCeilingVw.AvailabilityName,
				availabilityCeilingVw.AvailabilityMinSeniority.ToString(),
				availabilityCeilingVw.AvailabilityMinReusePeriod.ToString(),
				availabilityCeilingVw.FromYear.ToString(),
				availabilityCeilingVw.MaxAmount.ToString(MoneyFormat)
            };
        }
        
        private string [] GetParameters(AvailabilityCeiling availabilityCeiling)
        {
            AvailabilityCeilingVw availabilityCeilingVw = new AvailabilityCeilingVw();
            availabilityCeilingVw.Id = availabilityCeiling.Id;
            availabilityCeilingVw.AvailabilityId = availabilityCeiling.Availability;
            availabilityCeilingVw.FromYear = availabilityCeiling.FromYear;
            availabilityCeilingVw.MaxAmount = availabilityCeiling.MaxAmount;
            return GetParameters(availabilityCeilingVw);
        }
    }
    #endregion

    #region BypassStatusVwXmlFormatter
    public class BypassStatusVwXmlFormatter : XmlFormatterBase
    {
        public BypassStatusVwXmlFormatter(BypassStatusVw bypassStatusVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(bypassStatusVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public BypassStatusVwXmlFormatter(BypassStatus bypassStatus)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(bypassStatus);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<Name>{1}</Name>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(BypassStatusVw bypassStatusVw)
        {
            return new string []
            {
				bypassStatusVw.Id.ToString(),
				bypassStatusVw.Name
            };
        }
        
        private string [] GetParameters(BypassStatus bypassStatus)
        {
            BypassStatusVw bypassStatusVw = new BypassStatusVw();
            bypassStatusVw.Id = bypassStatus.Id;
            bypassStatusVw.Name = bypassStatus.Name;
            return GetParameters(bypassStatusVw);
        }
    }
    #endregion

    #region CashPaymentVwXmlFormatter
    public class CashPaymentVwXmlFormatter : XmlFormatterBase
    {
        public CashPaymentVwXmlFormatter(CashPaymentVw cashPaymentVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(cashPaymentVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public CashPaymentVwXmlFormatter(CashPayment cashPayment)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(cashPayment);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<PaymentId>{0}</PaymentId>";
            parametersFormat += "\n\t<PaymentEmployeeId>{1}</PaymentEmployeeId>";
            parametersFormat += "\n\t<PaymentEmployeeFullName>{2}</PaymentEmployeeFullName>";
            parametersFormat += "\n\t<PaymentEmployeeEmployeeStatusName>{3}</PaymentEmployeeEmployeeStatusName>";
            parametersFormat += "\n\t<PaymentEmployeeDepartmentName>{4}</PaymentEmployeeDepartmentName>";
            parametersFormat += "\n\t<PaymentEmployeeDepartmentSalaryWorkPlaceName>{5}</PaymentEmployeeDepartmentSalaryWorkPlaceName>";
            parametersFormat += "\n\t<PaymentEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>{6}</PaymentEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<PaymentEmployeeCategoryName>{7}</PaymentEmployeeCategoryName>";
            parametersFormat += "\n\t<PaymentDate>{8}</PaymentDate>";
            parametersFormat += "\n\t<PaymentPaymentGroupName>{9}</PaymentPaymentGroupName>";
            parametersFormat += "\n\t<PaymentAmount>{10}</PaymentAmount>";
            parametersFormat += "\n\t<PaymentNotes>{11}</PaymentNotes>";
            parametersFormat += "\n\t<PaymentPaymentStatusName>{12}</PaymentPaymentStatusName>";
            parametersFormat += "\n\t<PaymentCollectOrderNumber>{13}</PaymentCollectOrderNumber>";
            parametersFormat += "\n\t<PaymentCollectOrderDate>{14}</PaymentCollectOrderDate>";
            parametersFormat += "\n\t<Number>{15}</Number>";
            parametersFormat += "\n\t<ReceiptNumber>{16}</ReceiptNumber>";
            parametersFormat += "\n\t<ReceiptDate>{17}</ReceiptDate>";
            parametersFormat += "\n\t<FeeAmount>{18}</FeeAmount>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(CashPaymentVw cashPaymentVw)
        {
            return new string []
            {
				cashPaymentVw.PaymentId.ToString(),
				cashPaymentVw.PaymentEmployeeId.ToString(),
				cashPaymentVw.PaymentEmployeeFullName,
				cashPaymentVw.PaymentEmployeeEmployeeStatusName,
				cashPaymentVw.PaymentEmployeeDepartmentName,
				cashPaymentVw.PaymentEmployeeDepartmentSalaryWorkPlaceName,
				cashPaymentVw.PaymentEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName,
				cashPaymentVw.PaymentEmployeeCategoryName,
				cashPaymentVw.PaymentDate.ToString(DateFormat),
				cashPaymentVw.PaymentPaymentGroupName,
				cashPaymentVw.PaymentAmount == null ? string.Empty : cashPaymentVw.PaymentAmount.Value.ToString(MoneyFormat),
				cashPaymentVw.PaymentNotes == null ? string.Empty : cashPaymentVw.PaymentNotes,
				cashPaymentVw.PaymentPaymentStatusName == null ? string.Empty : cashPaymentVw.PaymentPaymentStatusName,
				cashPaymentVw.PaymentCollectOrderNumber == null ? string.Empty : cashPaymentVw.PaymentCollectOrderNumber.Value.ToString(),
				cashPaymentVw.PaymentCollectOrderDate == null ? string.Empty : cashPaymentVw.PaymentCollectOrderDate.Value.ToString(DateFormat),
				cashPaymentVw.Number.ToString(),
				cashPaymentVw.ReceiptNumber == null ? string.Empty : cashPaymentVw.ReceiptNumber.Value.ToString(),
				cashPaymentVw.ReceiptDate == null ? string.Empty : cashPaymentVw.ReceiptDate.Value.ToString(DateFormat),
				cashPaymentVw.FeeAmount.ToString(MoneyFormat)
            };
        }
        
        private string [] GetParameters(CashPayment cashPayment)
        {
            CashPaymentVw cashPaymentVw = new CashPaymentVw();
            cashPaymentVw.PaymentId = cashPayment.Payment;
            cashPaymentVw.Number = cashPayment.Number;
            cashPaymentVw.ReceiptNumber = cashPayment.ReceiptNumber;
            cashPaymentVw.ReceiptDate = cashPayment.ReceiptDate;
            cashPaymentVw.FeeAmount = cashPayment.FeeAmount;
            return GetParameters(cashPaymentVw);
        }
    }
    #endregion

    #region CategoryVwXmlFormatter
    public class CategoryVwXmlFormatter : XmlFormatterBase
    {
        public CategoryVwXmlFormatter(CategoryVw categoryVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(categoryVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public CategoryVwXmlFormatter(Category category)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(category);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<Name>{1}</Name>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(CategoryVw categoryVw)
        {
            return new string []
            {
				categoryVw.Id.ToString(),
				categoryVw.Name
            };
        }
        
        private string [] GetParameters(Category category)
        {
            CategoryVw categoryVw = new CategoryVw();
            categoryVw.Id = category.Id;
            categoryVw.Name = category.Name;
            return GetParameters(categoryVw);
        }
    }
    #endregion

    #region CollectOrderVwXmlFormatter
    public class CollectOrderVwXmlFormatter : XmlFormatterBase
    {
        public CollectOrderVwXmlFormatter(CollectOrderVw collectOrderVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(collectOrderVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public CollectOrderVwXmlFormatter(CollectOrder collectOrder)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(collectOrder);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<Number>{1}</Number>";
            parametersFormat += "\n\t<Date>{2}</Date>";
            parametersFormat += "\n\t<AccountingDocumentNumber>{3}</AccountingDocumentNumber>";
            parametersFormat += "\n\t<AccountingDocumentDate>{4}</AccountingDocumentDate>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(CollectOrderVw collectOrderVw)
        {
            return new string []
            {
				collectOrderVw.Id.ToString(),
				collectOrderVw.Number == null ? string.Empty : collectOrderVw.Number.Value.ToString(),
				collectOrderVw.Date == null ? string.Empty : collectOrderVw.Date.Value.ToString(DateFormat),
				collectOrderVw.AccountingDocumentNumber == null ? string.Empty : collectOrderVw.AccountingDocumentNumber.Value.ToString(),
				collectOrderVw.AccountingDocumentDate == null ? string.Empty : collectOrderVw.AccountingDocumentDate.Value.ToString(DateFormat)
            };
        }
        
        private string [] GetParameters(CollectOrder collectOrder)
        {
            CollectOrderVw collectOrderVw = new CollectOrderVw();
            collectOrderVw.Id = collectOrder.Id;
            collectOrderVw.Number = collectOrder.Number;
            collectOrderVw.Date = collectOrder.Date;
            collectOrderVw.AccountingDocumentNumber = collectOrder.AccountingDocumentNumber;
            collectOrderVw.AccountingDocumentDate = collectOrder.AccountingDocumentDate;
            return GetParameters(collectOrderVw);
        }
    }
    #endregion

    #region DebtVwXmlFormatter
    public class DebtVwXmlFormatter : XmlFormatterBase
    {
        public DebtVwXmlFormatter(DebtVw debtVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(debtVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public DebtVwXmlFormatter(Debt debt)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(debt);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<EmployeeId>{1}</EmployeeId>";
            parametersFormat += "\n\t<EmployeeFullName>{2}</EmployeeFullName>";
            parametersFormat += "\n\t<EmployeeEmployeeStatusName>{3}</EmployeeEmployeeStatusName>";
            parametersFormat += "\n\t<EmployeeDepartmentName>{4}</EmployeeDepartmentName>";
            parametersFormat += "\n\t<EmployeeDepartmentSalaryWorkPlaceName>{5}</EmployeeDepartmentSalaryWorkPlaceName>";
            parametersFormat += "\n\t<EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>{6}</EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<EmployeeCategoryName>{7}</EmployeeCategoryName>";
            parametersFormat += "\n\t<Amount>{8}</Amount>";
            parametersFormat += "\n\t<IssuerName>{9}</IssuerName>";
            parametersFormat += "\n\t<ReferenceNumber>{10}</ReferenceNumber>";
            parametersFormat += "\n\t<Date>{11}</Date>";
            parametersFormat += "\n\t<PeriodInMonths>{12}</PeriodInMonths>";
            parametersFormat += "\n\t<ExceptionalPayment>{13}</ExceptionalPayment>";
            parametersFormat += "\n\t<IsActive>{14}</IsActive>";
            parametersFormat += "\n\t<Notes>{15}</Notes>";
            parametersFormat += "\n\t<IssueDescription>{16}</IssueDescription>";
            parametersFormat += "\n\t<Installment>{17}</Installment>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(DebtVw debtVw)
        {
            return new string []
            {
				debtVw.Id.ToString(),
				debtVw.EmployeeId.ToString(),
				debtVw.EmployeeFullName,
				debtVw.EmployeeEmployeeStatusName,
				debtVw.EmployeeDepartmentName,
				debtVw.EmployeeDepartmentSalaryWorkPlaceName,
				debtVw.EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName,
				debtVw.EmployeeCategoryName,
				debtVw.Amount.ToString(MoneyFormat),
				debtVw.IssuerName,
				debtVw.ReferenceNumber == null ? string.Empty : debtVw.ReferenceNumber,
				debtVw.Date == null ? string.Empty : debtVw.Date.Value.ToString(DateFormat),
				debtVw.PeriodInMonths == null ? string.Empty : debtVw.PeriodInMonths.Value.ToString(),
				debtVw.ExceptionalPayment.ToString(MoneyFormat),
				debtVw.IsActive.ToString(),
				debtVw.Notes == null ? string.Empty : debtVw.Notes,
				debtVw.IssueDescription == null ? string.Empty : debtVw.IssueDescription,
				debtVw.Installment.ToString(MoneyFormat)
            };
        }
        
        private string [] GetParameters(Debt debt)
        {
            DebtVw debtVw = new DebtVw();
            debtVw.Id = debt.Id;
            debtVw.EmployeeId = debt.Employee;
            debtVw.Amount = debt.Amount;
            debtVw.ReferenceNumber = debt.ReferenceNumber;
            debtVw.Date = debt.Date;
            debtVw.PeriodInMonths = debt.PeriodInMonths;
            debtVw.ExceptionalPayment = debt.ExceptionalPayment;
            debtVw.IsActive = debt.IsActive;
            debtVw.Notes = debt.Notes;
            debtVw.IssueDescription = debt.IssueDescription;
            debtVw.Installment = debt.Installment;
            return GetParameters(debtVw);
        }
    }
    #endregion

    #region DepartmentVwXmlFormatter
    public class DepartmentVwXmlFormatter : XmlFormatterBase
    {
        public DepartmentVwXmlFormatter(DepartmentVw departmentVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(departmentVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public DepartmentVwXmlFormatter(Department department)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(department);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<Name>{1}</Name>";
            parametersFormat += "\n\t<SalaryWorkPlaceId>{2}</SalaryWorkPlaceId>";
            parametersFormat += "\n\t<SalaryWorkPlaceName>{3}</SalaryWorkPlaceName>";
            parametersFormat += "\n\t<SalaryWorkPlaceMainWorkPlaceId>{4}</SalaryWorkPlaceMainWorkPlaceId>";
            parametersFormat += "\n\t<SalaryWorkPlaceMainWorkPlaceName>{5}</SalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(DepartmentVw departmentVw)
        {
            return new string []
            {
				departmentVw.Id.ToString(),
				departmentVw.Name,
				departmentVw.SalaryWorkPlaceId.ToString(),
				departmentVw.SalaryWorkPlaceName,
				departmentVw.SalaryWorkPlaceMainWorkPlaceId.ToString(),
				departmentVw.SalaryWorkPlaceMainWorkPlaceName
            };
        }
        
        private string [] GetParameters(Department department)
        {
            DepartmentVw departmentVw = new DepartmentVw();
            departmentVw.Id = department.Id;
            departmentVw.Name = department.Name;
            departmentVw.SalaryWorkPlaceId = department.SalaryWorkPlace;
            return GetParameters(departmentVw);
        }
    }
    #endregion

    #region DownPaymentVwXmlFormatter
    public class DownPaymentVwXmlFormatter : XmlFormatterBase
    {
        public DownPaymentVwXmlFormatter(DownPaymentVw downPaymentVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(downPaymentVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public DownPaymentVwXmlFormatter(DownPayment downPayment)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(downPayment);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<PaymentId>{0}</PaymentId>";
            parametersFormat += "\n\t<PaymentEmployeeId>{1}</PaymentEmployeeId>";
            parametersFormat += "\n\t<PaymentEmployeeFullName>{2}</PaymentEmployeeFullName>";
            parametersFormat += "\n\t<PaymentEmployeeDepartmentName>{3}</PaymentEmployeeDepartmentName>";
            parametersFormat += "\n\t<PaymentEmployeeDepartmentSalaryWorkPlaceName>{4}</PaymentEmployeeDepartmentSalaryWorkPlaceName>";
            parametersFormat += "\n\t<PaymentEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>{5}</PaymentEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<PaymentEmployeeCategoryName>{6}</PaymentEmployeeCategoryName>";
            parametersFormat += "\n\t<PaymentDate>{7}</PaymentDate>";
            parametersFormat += "\n\t<PaymentPaymentGroupName>{8}</PaymentPaymentGroupName>";
            parametersFormat += "\n\t<PaymentAmount>{9}</PaymentAmount>";
            parametersFormat += "\n\t<PaymentNotes>{10}</PaymentNotes>";
            parametersFormat += "\n\t<PaymentPaymentStatusName>{11}</PaymentPaymentStatusName>";
            parametersFormat += "\n\t<RequestProductId>{12}</RequestProductId>";
            parametersFormat += "\n\t<RequestProductProductTypeName>{13}</RequestProductProductTypeName>";
            parametersFormat += "\n\t<RequestProductProductTypeRate>{14}</RequestProductProductTypeRate>";
            parametersFormat += "\n\t<RequestProductProductTypeGuarantorsCount>{15}</RequestProductProductTypeGuarantorsCount>";
            parametersFormat += "\n\t<RequestProductAmount>{16}</RequestProductAmount>";
            parametersFormat += "\n\t<RequestProductNotes>{17}</RequestProductNotes>";
            parametersFormat += "\n\t<RequestDate>{18}</RequestDate>";
            parametersFormat += "\n\t<RequestAmount>{19}</RequestAmount>";
            parametersFormat += "\n\t<RequestRequestStatusId>{20}</RequestRequestStatusId>";
            parametersFormat += "\n\t<RequestRequestStatusName>{21}</RequestRequestStatusName>";
            parametersFormat += "\n\t<RequestNotes>{22}</RequestNotes>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(DownPaymentVw downPaymentVw)
        {
            return new string []
            {
				downPaymentVw.PaymentId.ToString(),
				downPaymentVw.PaymentEmployeeId.ToString(),
				downPaymentVw.PaymentEmployeeFullName,
				downPaymentVw.PaymentEmployeeDepartmentName,
				downPaymentVw.PaymentEmployeeDepartmentSalaryWorkPlaceName,
				downPaymentVw.PaymentEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName,
				downPaymentVw.PaymentEmployeeCategoryName,
				downPaymentVw.PaymentDate.ToString(DateFormat),
				downPaymentVw.PaymentPaymentGroupName,
				downPaymentVw.PaymentAmount == null ? string.Empty : downPaymentVw.PaymentAmount.Value.ToString(MoneyFormat),
				downPaymentVw.PaymentNotes == null ? string.Empty : downPaymentVw.PaymentNotes,
				downPaymentVw.PaymentPaymentStatusName == null ? string.Empty : downPaymentVw.PaymentPaymentStatusName,
				downPaymentVw.RequestProductId.ToString(),
				downPaymentVw.RequestProductProductTypeName == null ? string.Empty : downPaymentVw.RequestProductProductTypeName,
				downPaymentVw.RequestProductProductTypeRate == null ? string.Empty : downPaymentVw.RequestProductProductTypeRate.Value.ToString(MoneyFormat),
				downPaymentVw.RequestProductProductTypeGuarantorsCount.ToString(),
				downPaymentVw.RequestProductAmount.ToString(MoneyFormat),
				downPaymentVw.RequestProductNotes == null ? string.Empty : downPaymentVw.RequestProductNotes,
				downPaymentVw.RequestDate.ToString(DateFormat),
				downPaymentVw.RequestAmount.ToString(MoneyFormat),
				downPaymentVw.RequestRequestStatusId == null ? string.Empty : downPaymentVw.RequestRequestStatusId.Value.ToString(),
				downPaymentVw.RequestRequestStatusName == null ? string.Empty : downPaymentVw.RequestRequestStatusName,
				downPaymentVw.RequestNotes == null ? string.Empty : downPaymentVw.RequestNotes
            };
        }
        
        private string [] GetParameters(DownPayment downPayment)
        {
            DownPaymentVw downPaymentVw = new DownPaymentVw();
            downPaymentVw.PaymentId = downPayment.Payment;
            downPaymentVw.RequestProductId = downPayment.Request;
            return GetParameters(downPaymentVw);
        }
    }
    #endregion

    #region EmployeeVwXmlFormatter
    public class EmployeeVwXmlFormatter : XmlFormatterBase
    {
        public EmployeeVwXmlFormatter(EmployeeVw employeeVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(employeeVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public EmployeeVwXmlFormatter(Employee employee)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(employee);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<FirstName>{1}</FirstName>";
            parametersFormat += "\n\t<LastName>{2}</LastName>";
            parametersFormat += "\n\t<FatherName>{3}</FatherName>";
            parametersFormat += "\n\t<MotherName>{4}</MotherName>";
            parametersFormat += "\n\t<BirthDate>{5}</BirthDate>";
            parametersFormat += "\n\t<ExpectedEndDate>{6}</ExpectedEndDate>";
            parametersFormat += "\n\t<CersStartDate>{7}</CersStartDate>";
            parametersFormat += "\n\t<CfStartDate>{8}</CfStartDate>";
            parametersFormat += "\n\t<LeaveDate>{9}</LeaveDate>";
            parametersFormat += "\n\t<LeaveReason>{10}</LeaveReason>";
            parametersFormat += "\n\t<EmployeeStatusId>{11}</EmployeeStatusId>";
            parametersFormat += "\n\t<EmployeeStatusName>{12}</EmployeeStatusName>";
            parametersFormat += "\n\t<DepartmentId>{13}</DepartmentId>";
            parametersFormat += "\n\t<DepartmentName>{14}</DepartmentName>";
            parametersFormat += "\n\t<DepartmentSalaryWorkPlaceId>{15}</DepartmentSalaryWorkPlaceId>";
            parametersFormat += "\n\t<DepartmentSalaryWorkPlaceName>{16}</DepartmentSalaryWorkPlaceName>";
            parametersFormat += "\n\t<DepartmentSalaryWorkPlaceMainWorkPlaceId>{17}</DepartmentSalaryWorkPlaceMainWorkPlaceId>";
            parametersFormat += "\n\t<DepartmentSalaryWorkPlaceMainWorkPlaceName>{18}</DepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<Notes>{19}</Notes>";
            parametersFormat += "\n\t<CategoryId>{20}</CategoryId>";
            parametersFormat += "\n\t<CategoryName>{21}</CategoryName>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(EmployeeVw employeeVw)
        {
            return new string []
            {
				employeeVw.Id.ToString(),
				employeeVw.FirstName,
				employeeVw.LastName,
				employeeVw.FatherName == null ? string.Empty : employeeVw.FatherName,
				employeeVw.MotherName == null ? string.Empty : employeeVw.MotherName,
				employeeVw.BirthDate == null ? string.Empty : employeeVw.BirthDate.Value.ToString(DateFormat),
				employeeVw.ExpectedEndDate == null ? string.Empty : employeeVw.ExpectedEndDate.Value.ToString(DateFormat),
				employeeVw.CersStartDate == null ? string.Empty : employeeVw.CersStartDate.Value.ToString(DateFormat),
				employeeVw.CfStartDate == null ? string.Empty : employeeVw.CfStartDate.Value.ToString(DateFormat),
				employeeVw.LeaveDate == null ? string.Empty : employeeVw.LeaveDate.Value.ToString(DateFormat),
				employeeVw.LeaveReason == null ? string.Empty : employeeVw.LeaveReason,
				employeeVw.EmployeeStatusId.ToString(),
				employeeVw.EmployeeStatusName,
				employeeVw.DepartmentId.ToString(),
				employeeVw.DepartmentName,
				employeeVw.DepartmentSalaryWorkPlaceId.ToString(),
				employeeVw.DepartmentSalaryWorkPlaceName,
				employeeVw.DepartmentSalaryWorkPlaceMainWorkPlaceId.ToString(),
				employeeVw.DepartmentSalaryWorkPlaceMainWorkPlaceName,
				employeeVw.Notes == null ? string.Empty : employeeVw.Notes,
				employeeVw.CategoryId.ToString(),
				employeeVw.CategoryName
            };
        }
        
        private string [] GetParameters(Employee employee)
        {
            EmployeeVw employeeVw = new EmployeeVw();
            employeeVw.Id = employee.Id;
            employeeVw.FirstName = employee.FirstName;
            employeeVw.LastName = employee.LastName;
            employeeVw.FatherName = employee.FatherName;
            employeeVw.MotherName = employee.MotherName;
            employeeVw.BirthDate = employee.BirthDate;
            employeeVw.ExpectedEndDate = employee.ExpectedEndDate;
            employeeVw.CersStartDate = employee.CersStartDate;
            employeeVw.CfStartDate = employee.CfStartDate;
            employeeVw.LeaveDate = employee.LeaveDate;
            employeeVw.LeaveReason = employee.LeaveReason;
            employeeVw.EmployeeStatusId = employee.EmployeeStatus;
            employeeVw.DepartmentId = employee.Department;
            employeeVw.Notes = employee.Notes;
            employeeVw.CategoryId = employee.Category;
            return GetParameters(employeeVw);
        }
    }
    #endregion

    #region EmployeeSeniorityVwXmlFormatter
    public class EmployeeSeniorityVwXmlFormatter : XmlFormatterBase
    {
        public EmployeeSeniorityVwXmlFormatter(EmployeeSeniorityVw employeeSeniorityVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(employeeSeniorityVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public EmployeeSeniorityVwXmlFormatter(EmployeeSeniority employeeSeniority)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(employeeSeniority);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<EmployeeId>{0}</EmployeeId>";
            parametersFormat += "\n\t<EmployeeFullName>{1}</EmployeeFullName>";
            parametersFormat += "\n\t<EmployeeDepartmentName>{2}</EmployeeDepartmentName>";
            parametersFormat += "\n\t<EmployeeDepartmentSalaryWorkPlaceName>{3}</EmployeeDepartmentSalaryWorkPlaceName>";
            parametersFormat += "\n\t<EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>{4}</EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<EmployeeCategoryName>{5}</EmployeeCategoryName>";
            parametersFormat += "\n\t<ServiceInDays>{6}</ServiceInDays>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(EmployeeSeniorityVw employeeSeniorityVw)
        {
            return new string []
            {
				employeeSeniorityVw.EmployeeId.ToString(),
				employeeSeniorityVw.EmployeeFullName,
				employeeSeniorityVw.EmployeeDepartmentName,
				employeeSeniorityVw.EmployeeDepartmentSalaryWorkPlaceName,
				employeeSeniorityVw.EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName,
				employeeSeniorityVw.EmployeeCategoryName,
				employeeSeniorityVw.ServiceInDays.ToString()
            };
        }
        
        private string [] GetParameters(EmployeeSeniority employeeSeniority)
        {
            EmployeeSeniorityVw employeeSeniorityVw = new EmployeeSeniorityVw();
            employeeSeniorityVw.EmployeeId = employeeSeniority.Employee;
            employeeSeniorityVw.ServiceInDays = employeeSeniority.ServiceInDays;
            return GetParameters(employeeSeniorityVw);
        }
    }
    #endregion

    #region EmployeeStatusVwXmlFormatter
    public class EmployeeStatusVwXmlFormatter : XmlFormatterBase
    {
        public EmployeeStatusVwXmlFormatter(EmployeeStatusVw employeeStatusVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(employeeStatusVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public EmployeeStatusVwXmlFormatter(EmployeeStatus employeeStatus)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(employeeStatus);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<Name>{1}</Name>";
            parametersFormat += "\n\t<IsActive>{2}</IsActive>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(EmployeeStatusVw employeeStatusVw)
        {
            return new string []
            {
				employeeStatusVw.Id.ToString(),
				employeeStatusVw.Name,
				employeeStatusVw.IsActive.ToString()
            };
        }
        
        private string [] GetParameters(EmployeeStatus employeeStatus)
        {
            EmployeeStatusVw employeeStatusVw = new EmployeeStatusVw();
            employeeStatusVw.Id = employeeStatus.Id;
            employeeStatusVw.Name = employeeStatus.Name;
            employeeStatusVw.IsActive = employeeStatus.IsActive;
            return GetParameters(employeeStatusVw);
        }
    }
    #endregion

    #region EndWorkGrantBracketVwXmlFormatter
    public class EndWorkGrantBracketVwXmlFormatter : XmlFormatterBase
    {
        public EndWorkGrantBracketVwXmlFormatter(EndWorkGrantBracketVw endWorkGrantBracketVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(endWorkGrantBracketVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public EndWorkGrantBracketVwXmlFormatter(EndWorkGrantBracket endWorkGrantBracket)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(endWorkGrantBracket);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<FromYear>{0}</FromYear>";
            parametersFormat += "\n\t<Percentage>{1}</Percentage>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(EndWorkGrantBracketVw endWorkGrantBracketVw)
        {
            return new string []
            {
				endWorkGrantBracketVw.FromYear.ToString(),
				endWorkGrantBracketVw.Percentage.ToString()
            };
        }
        
        private string [] GetParameters(EndWorkGrantBracket endWorkGrantBracket)
        {
            EndWorkGrantBracketVw endWorkGrantBracketVw = new EndWorkGrantBracketVw();
            endWorkGrantBracketVw.FromYear = endWorkGrantBracket.FromYear;
            endWorkGrantBracketVw.Percentage = endWorkGrantBracket.Percentage;
            return GetParameters(endWorkGrantBracketVw);
        }
    }
    #endregion

    #region ErrorDefinitionVwXmlFormatter
    public class ErrorDefinitionVwXmlFormatter : XmlFormatterBase
    {
        public ErrorDefinitionVwXmlFormatter(ErrorDefinitionVw errorDefinitionVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(errorDefinitionVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public ErrorDefinitionVwXmlFormatter(ErrorDefinition errorDefinition)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(errorDefinition);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<Message>{1}</Message>";
            parametersFormat += "\n\t<LocalizedMessage>{2}</LocalizedMessage>";
            parametersFormat += "\n\t<LikeExpression>{3}</LikeExpression>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(ErrorDefinitionVw errorDefinitionVw)
        {
            return new string []
            {
				errorDefinitionVw.Id.ToString(),
				errorDefinitionVw.Message,
				errorDefinitionVw.LocalizedMessage,
				errorDefinitionVw.LikeExpression == null ? string.Empty : errorDefinitionVw.LikeExpression
            };
        }
        
        private string [] GetParameters(ErrorDefinition errorDefinition)
        {
            ErrorDefinitionVw errorDefinitionVw = new ErrorDefinitionVw();
            errorDefinitionVw.Id = errorDefinition.Id;
            errorDefinitionVw.Message = errorDefinition.Message;
            errorDefinitionVw.LocalizedMessage = errorDefinition.LocalizedMessage;
            errorDefinitionVw.LikeExpression = errorDefinition.LikeExpression;
            return GetParameters(errorDefinitionVw);
        }
    }
    #endregion

    #region EventCategoryVwXmlFormatter
    public class EventCategoryVwXmlFormatter : XmlFormatterBase
    {
        public EventCategoryVwXmlFormatter(EventCategoryVw eventCategoryVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(eventCategoryVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public EventCategoryVwXmlFormatter(EventCategory eventCategory)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(eventCategory);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<Name>{1}</Name>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(EventCategoryVw eventCategoryVw)
        {
            return new string []
            {
				eventCategoryVw.Id.ToString(),
				eventCategoryVw.Name
            };
        }
        
        private string [] GetParameters(EventCategory eventCategory)
        {
            EventCategoryVw eventCategoryVw = new EventCategoryVw();
            eventCategoryVw.Id = eventCategory.Id;
            eventCategoryVw.Name = eventCategory.Name;
            return GetParameters(eventCategoryVw);
        }
    }
    #endregion

    #region EventLogVwXmlFormatter
    public class EventLogVwXmlFormatter : XmlFormatterBase
    {
        public EventLogVwXmlFormatter(EventLogVw eventLogVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(eventLogVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public EventLogVwXmlFormatter(EventLog eventLog)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(eventLog);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<EventSourceId>{1}</EventSourceId>";
            parametersFormat += "\n\t<EventSourceName>{2}</EventSourceName>";
            parametersFormat += "\n\t<EventCategoryId>{3}</EventCategoryId>";
            parametersFormat += "\n\t<EventCategoryName>{4}</EventCategoryName>";
            parametersFormat += "\n\t<EventStatusId>{5}</EventStatusId>";
            parametersFormat += "\n\t<EventStatusName>{6}</EventStatusName>";
            parametersFormat += "\n\t<Date>{7}</Date>";
            parametersFormat += "\n\t<User>{8}</User>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(EventLogVw eventLogVw)
        {
            return new string []
            {
				eventLogVw.Id.ToString(),
				eventLogVw.EventSourceId.ToString(),
				eventLogVw.EventSourceName,
				eventLogVw.EventCategoryId.ToString(),
				eventLogVw.EventCategoryName,
				eventLogVw.EventStatusId.ToString(),
				eventLogVw.EventStatusName,
				eventLogVw.Date.ToString(DateFormat),
				eventLogVw.User.ToString()
            };
        }
        
        private string [] GetParameters(EventLog eventLog)
        {
            EventLogVw eventLogVw = new EventLogVw();
            eventLogVw.Id = eventLog.Id;
            eventLogVw.EventSourceId = eventLog.EventSource;
            eventLogVw.EventCategoryId = eventLog.EventCategory;
            eventLogVw.EventStatusId = eventLog.EventStatus;
            eventLogVw.Parameters = eventLog.Parameters;
            eventLogVw.Date = eventLog.Date;
            eventLogVw.User = eventLog.User;
            return GetParameters(eventLogVw);
        }
    }
    #endregion

    #region EventLogErrorVwXmlFormatter
    public class EventLogErrorVwXmlFormatter : XmlFormatterBase
    {
        public EventLogErrorVwXmlFormatter(EventLogErrorVw eventLogErrorVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(eventLogErrorVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public EventLogErrorVwXmlFormatter(EventLogError eventLogError)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(eventLogError);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<EventLogId>{0}</EventLogId>";
            parametersFormat += "\n\t<EventLogEventSourceId>{1}</EventLogEventSourceId>";
            parametersFormat += "\n\t<EventLogEventSourceName>{2}</EventLogEventSourceName>";
            parametersFormat += "\n\t<EventLogEventCategoryId>{3}</EventLogEventCategoryId>";
            parametersFormat += "\n\t<EventLogEventCategoryName>{4}</EventLogEventCategoryName>";
            parametersFormat += "\n\t<EventLogEventStatusId>{5}</EventLogEventStatusId>";
            parametersFormat += "\n\t<EventLogEventStatusName>{6}</EventLogEventStatusName>";
            parametersFormat += "\n\t<EventLogDate>{7}</EventLogDate>";
            parametersFormat += "\n\t<EventLogUser>{8}</EventLogUser>";
            parametersFormat += "\n\t<Number>{9}</Number>";
            parametersFormat += "\n\t<Message>{10}</Message>";
            parametersFormat += "\n\t<StackTrace>{11}</StackTrace>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(EventLogErrorVw eventLogErrorVw)
        {
            return new string []
            {
				eventLogErrorVw.EventLogId.ToString(),
				eventLogErrorVw.EventLogEventSourceId.ToString(),
				eventLogErrorVw.EventLogEventSourceName,
				eventLogErrorVw.EventLogEventCategoryId.ToString(),
				eventLogErrorVw.EventLogEventCategoryName,
				eventLogErrorVw.EventLogEventStatusId.ToString(),
				eventLogErrorVw.EventLogEventStatusName,
				eventLogErrorVw.EventLogDate.ToString(DateFormat),
				eventLogErrorVw.EventLogUser.ToString(),
				eventLogErrorVw.Number.ToString(),
				eventLogErrorVw.Message,
				eventLogErrorVw.StackTrace
            };
        }
        
        private string [] GetParameters(EventLogError eventLogError)
        {
            EventLogErrorVw eventLogErrorVw = new EventLogErrorVw();
            eventLogErrorVw.EventLogId = eventLogError.EventLog;
            eventLogErrorVw.Number = eventLogError.Number;
            eventLogErrorVw.Message = eventLogError.Message;
            eventLogErrorVw.StackTrace = eventLogError.StackTrace;
            return GetParameters(eventLogErrorVw);
        }
    }
    #endregion

    #region EventSourceVwXmlFormatter
    public class EventSourceVwXmlFormatter : XmlFormatterBase
    {
        public EventSourceVwXmlFormatter(EventSourceVw eventSourceVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(eventSourceVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public EventSourceVwXmlFormatter(EventSource eventSource)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(eventSource);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<Name>{1}</Name>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(EventSourceVw eventSourceVw)
        {
            return new string []
            {
				eventSourceVw.Id.ToString(),
				eventSourceVw.Name
            };
        }
        
        private string [] GetParameters(EventSource eventSource)
        {
            EventSourceVw eventSourceVw = new EventSourceVw();
            eventSourceVw.Id = eventSource.Id;
            eventSourceVw.Name = eventSource.Name;
            return GetParameters(eventSourceVw);
        }
    }
    #endregion

    #region EventStatusVwXmlFormatter
    public class EventStatusVwXmlFormatter : XmlFormatterBase
    {
        public EventStatusVwXmlFormatter(EventStatusVw eventStatusVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(eventStatusVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public EventStatusVwXmlFormatter(EventStatus eventStatus)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(eventStatus);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<Name>{1}</Name>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(EventStatusVw eventStatusVw)
        {
            return new string []
            {
				eventStatusVw.Id.ToString(),
				eventStatusVw.Name
            };
        }
        
        private string [] GetParameters(EventStatus eventStatus)
        {
            EventStatusVw eventStatusVw = new EventStatusVw();
            eventStatusVw.Id = eventStatus.Id;
            eventStatusVw.Name = eventStatus.Name;
            return GetParameters(eventStatusVw);
        }
    }
    #endregion

    #region ExceptionalAmountVwXmlFormatter
    public class ExceptionalAmountVwXmlFormatter : XmlFormatterBase
    {
        public ExceptionalAmountVwXmlFormatter(ExceptionalAmountVw exceptionalAmountVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(exceptionalAmountVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public ExceptionalAmountVwXmlFormatter(ExceptionalAmount exceptionalAmount)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(exceptionalAmount);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<LoanRequestRequestProductId>{1}</LoanRequestRequestProductId>";
            parametersFormat += "\n\t<LoanRequestRequestProductEmployeeId>{2}</LoanRequestRequestProductEmployeeId>";
            parametersFormat += "\n\t<LoanRequestRequestProductEmployeeFullName>{3}</LoanRequestRequestProductEmployeeFullName>";
            parametersFormat += "\n\t<LoanRequestRequestProductEmployeeDepartmentName>{4}</LoanRequestRequestProductEmployeeDepartmentName>";
            parametersFormat += "\n\t<LoanRequestRequestProductEmployeeDepartmentSalaryWorkPlaceName>{5}</LoanRequestRequestProductEmployeeDepartmentSalaryWorkPlaceName>";
            parametersFormat += "\n\t<LoanRequestRequestProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>{6}</LoanRequestRequestProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<LoanRequestRequestProductEmployeeCategoryName>{7}</LoanRequestRequestProductEmployeeCategoryName>";
            parametersFormat += "\n\t<LoanRequestRequestProductProductTypeName>{8}</LoanRequestRequestProductProductTypeName>";
            parametersFormat += "\n\t<LoanRequestRequestProductProductTypeRate>{9}</LoanRequestRequestProductProductTypeRate>";
            parametersFormat += "\n\t<SubNumber>{10}</SubNumber>";
            parametersFormat += "\n\t<Amount>{11}</Amount>";
            parametersFormat += "\n\t<Notes>{12}</Notes>";
            parametersFormat += "\n\t<ExceptionalAmountTypeName>{13}</ExceptionalAmountTypeName>";
            parametersFormat += "\n\t<ExceptionalAmountTypeIsIncome>{14}</ExceptionalAmountTypeIsIncome>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(ExceptionalAmountVw exceptionalAmountVw)
        {
            return new string []
            {
				exceptionalAmountVw.Id.ToString(),
				exceptionalAmountVw.LoanRequestRequestProductId.ToString(),
				exceptionalAmountVw.LoanRequestRequestProductEmployeeId.ToString(),
				exceptionalAmountVw.LoanRequestRequestProductEmployeeFullName,
				exceptionalAmountVw.LoanRequestRequestProductEmployeeDepartmentName,
				exceptionalAmountVw.LoanRequestRequestProductEmployeeDepartmentSalaryWorkPlaceName,
				exceptionalAmountVw.LoanRequestRequestProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName,
				exceptionalAmountVw.LoanRequestRequestProductEmployeeCategoryName,
				exceptionalAmountVw.LoanRequestRequestProductProductTypeName == null ? string.Empty : exceptionalAmountVw.LoanRequestRequestProductProductTypeName,
				exceptionalAmountVw.LoanRequestRequestProductProductTypeRate == null ? string.Empty : exceptionalAmountVw.LoanRequestRequestProductProductTypeRate.Value.ToString(MoneyFormat),
				exceptionalAmountVw.SubNumber.ToString(),
				exceptionalAmountVw.Amount.ToString(),
				exceptionalAmountVw.Notes == null ? string.Empty : exceptionalAmountVw.Notes,
				exceptionalAmountVw.ExceptionalAmountTypeName,
				exceptionalAmountVw.ExceptionalAmountTypeIsIncome.ToString()
            };
        }
        
        private string [] GetParameters(ExceptionalAmount exceptionalAmount)
        {
            ExceptionalAmountVw exceptionalAmountVw = new ExceptionalAmountVw();
            exceptionalAmountVw.Id = exceptionalAmount.Id;
            exceptionalAmountVw.LoanRequestRequestProductId = exceptionalAmount.LoanRequest;
            exceptionalAmountVw.SubNumber = exceptionalAmount.SubNumber;
            exceptionalAmountVw.Amount = exceptionalAmount.Amount;
            exceptionalAmountVw.Notes = exceptionalAmount.Notes;
            return GetParameters(exceptionalAmountVw);
        }
    }
    #endregion

    #region ExceptionalAmountTypeVwXmlFormatter
    public class ExceptionalAmountTypeVwXmlFormatter : XmlFormatterBase
    {
        public ExceptionalAmountTypeVwXmlFormatter(ExceptionalAmountTypeVw exceptionalAmountTypeVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(exceptionalAmountTypeVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public ExceptionalAmountTypeVwXmlFormatter(ExceptionalAmountType exceptionalAmountType)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(exceptionalAmountType);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<Name>{1}</Name>";
            parametersFormat += "\n\t<IsIncome>{2}</IsIncome>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(ExceptionalAmountTypeVw exceptionalAmountTypeVw)
        {
            return new string []
            {
				exceptionalAmountTypeVw.Id.ToString(),
				exceptionalAmountTypeVw.Name,
				exceptionalAmountTypeVw.IsIncome.ToString()
            };
        }
        
        private string [] GetParameters(ExceptionalAmountType exceptionalAmountType)
        {
            ExceptionalAmountTypeVw exceptionalAmountTypeVw = new ExceptionalAmountTypeVw();
            exceptionalAmountTypeVw.Id = exceptionalAmountType.Id;
            exceptionalAmountTypeVw.Name = exceptionalAmountType.Name;
            exceptionalAmountTypeVw.IsIncome = exceptionalAmountType.IsIncome;
            return GetParameters(exceptionalAmountTypeVw);
        }
    }
    #endregion

    #region ExternalGrantVwXmlFormatter
    public class ExternalGrantVwXmlFormatter : XmlFormatterBase
    {
        public ExternalGrantVwXmlFormatter(ExternalGrantVw externalGrantVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(externalGrantVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public ExternalGrantVwXmlFormatter(ExternalGrant externalGrant)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(externalGrant);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<EmployeeId>{1}</EmployeeId>";
            parametersFormat += "\n\t<EmployeeFullName>{2}</EmployeeFullName>";
            parametersFormat += "\n\t<EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>{3}</EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<EmployeeCategoryName>{4}</EmployeeCategoryName>";
            parametersFormat += "\n\t<RequestDate>{5}</RequestDate>";
            parametersFormat += "\n\t<GrantTypeName>{6}</GrantTypeName>";
            parametersFormat += "\n\t<GrantTypeAmount>{7}</GrantTypeAmount>";
            parametersFormat += "\n\t<GrantTypeGrantTypeGroupName>{8}</GrantTypeGrantTypeGroupName>";
            parametersFormat += "\n\t<Description>{9}</Description>";
            parametersFormat += "\n\t<Amount>{10}</Amount>";
            parametersFormat += "\n\t<CersNumber>{11}</CersNumber>";
            parametersFormat += "\n\t<CersDate>{12}</CersDate>";
            parametersFormat += "\n\t<PaymentNumber>{13}</PaymentNumber>";
            parametersFormat += "\n\t<PaymentDate>{14}</PaymentDate>";
            parametersFormat += "\n\t<Notes>{15}</Notes>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(ExternalGrantVw externalGrantVw)
        {
            return new string []
            {
				externalGrantVw.Id.ToString(),
				externalGrantVw.EmployeeId.ToString(),
				externalGrantVw.EmployeeFullName,
				externalGrantVw.EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName,
				externalGrantVw.EmployeeCategoryName,
				externalGrantVw.RequestDate == null ? string.Empty : externalGrantVw.RequestDate.Value.ToString(DateFormat),
				externalGrantVw.GrantTypeName,
				externalGrantVw.GrantTypeAmount == null ? string.Empty : externalGrantVw.GrantTypeAmount.Value.ToString(MoneyFormat),
				externalGrantVw.GrantTypeGrantTypeGroupName,
				externalGrantVw.Description == null ? string.Empty : externalGrantVw.Description,
				externalGrantVw.Amount.ToString(MoneyFormat),
				externalGrantVw.CersNumber == null ? string.Empty : externalGrantVw.CersNumber,
				externalGrantVw.CersDate == null ? string.Empty : externalGrantVw.CersDate.Value.ToString(DateFormat),
				externalGrantVw.PaymentNumber == null ? string.Empty : externalGrantVw.PaymentNumber.Value.ToString(),
				externalGrantVw.PaymentDate == null ? string.Empty : externalGrantVw.PaymentDate.Value.ToString(DateFormat),
				externalGrantVw.Notes == null ? string.Empty : externalGrantVw.Notes
            };
        }
        
        private string [] GetParameters(ExternalGrant externalGrant)
        {
            ExternalGrantVw externalGrantVw = new ExternalGrantVw();
            externalGrantVw.Id = externalGrant.Id;
            externalGrantVw.EmployeeId = externalGrant.Employee;
            externalGrantVw.RequestDate = externalGrant.RequestDate;
            externalGrantVw.Description = externalGrant.Description;
            externalGrantVw.Amount = externalGrant.Amount;
            externalGrantVw.CersNumber = externalGrant.CersNumber;
            externalGrantVw.CersDate = externalGrant.CersDate;
            externalGrantVw.PaymentNumber = externalGrant.PaymentNumber;
            externalGrantVw.PaymentDate = externalGrant.PaymentDate;
            externalGrantVw.Notes = externalGrant.Notes;
            return GetParameters(externalGrantVw);
        }
    }
    #endregion

    #region GrantVwXmlFormatter
    public class GrantVwXmlFormatter : XmlFormatterBase
    {
        public GrantVwXmlFormatter(GrantVw grantVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(grantVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public GrantVwXmlFormatter(Grant grant)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(grant);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<ProductId>{0}</ProductId>";
            parametersFormat += "\n\t<ProductEmployeeId>{1}</ProductEmployeeId>";
            parametersFormat += "\n\t<ProductEmployeeFullName>{2}</ProductEmployeeFullName>";
            parametersFormat += "\n\t<ProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>{3}</ProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<ProductEmployeeCategoryName>{4}</ProductEmployeeCategoryName>";
            parametersFormat += "\n\t<ProductProductTypeName>{5}</ProductProductTypeName>";
            parametersFormat += "\n\t<GrantDecisionNumber>{6}</GrantDecisionNumber>";
            parametersFormat += "\n\t<GrantDecisionYear>{7}</GrantDecisionYear>";
            parametersFormat += "\n\t<GrantDecisionDate>{8}</GrantDecisionDate>";
            parametersFormat += "\n\t<Amount>{9}</Amount>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(GrantVw grantVw)
        {
            return new string []
            {
				grantVw.ProductId.ToString(),
				grantVw.ProductEmployeeId.ToString(),
				grantVw.ProductEmployeeFullName,
				grantVw.ProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName,
				grantVw.ProductEmployeeCategoryName,
				grantVw.ProductProductTypeName == null ? string.Empty : grantVw.ProductProductTypeName,
				grantVw.GrantDecisionNumber.ToString(),
				grantVw.GrantDecisionYear.ToString(),
				grantVw.GrantDecisionDate.ToString(DateFormat),
				grantVw.Amount.ToString(MoneyFormat)
            };
        }
        
        private string [] GetParameters(Grant grant)
        {
            GrantVw grantVw = new GrantVw();
            grantVw.ProductId = grant.Product;
            grantVw.Amount = grant.Amount;
            return GetParameters(grantVw);
        }
    }
    #endregion

    #region GrantDecisionVwXmlFormatter
    public class GrantDecisionVwXmlFormatter : XmlFormatterBase
    {
        public GrantDecisionVwXmlFormatter(GrantDecisionVw grantDecisionVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(grantDecisionVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public GrantDecisionVwXmlFormatter(GrantDecision grantDecision)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(grantDecision);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<Number>{1}</Number>";
            parametersFormat += "\n\t<Year>{2}</Year>";
            parametersFormat += "\n\t<GrantTypeGroupName>{3}</GrantTypeGroupName>";
            parametersFormat += "\n\t<Date>{4}</Date>";
            parametersFormat += "\n\t<CersNumber>{5}</CersNumber>";
            parametersFormat += "\n\t<CersDate>{6}</CersDate>";
            parametersFormat += "\n\t<PaymentNumber>{7}</PaymentNumber>";
            parametersFormat += "\n\t<PaymentDate>{8}</PaymentDate>";
            parametersFormat += "\n\t<Notes>{9}</Notes>";
            parametersFormat += "\n\t<TableNumber>{10}</TableNumber>";
            parametersFormat += "\n\t<TableDate>{11}</TableDate>";
            parametersFormat += "\n\t<BaseNumber>{12}</BaseNumber>";
            parametersFormat += "\n\t<BaseDate>{13}</BaseDate>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(GrantDecisionVw grantDecisionVw)
        {
            return new string []
            {
				grantDecisionVw.Id.ToString(),
				grantDecisionVw.Number.ToString(),
				grantDecisionVw.Year.ToString(),
				grantDecisionVw.GrantTypeGroupName,
				grantDecisionVw.Date.ToString(DateFormat),
				grantDecisionVw.CersNumber == null ? string.Empty : grantDecisionVw.CersNumber,
				grantDecisionVw.CersDate == null ? string.Empty : grantDecisionVw.CersDate.Value.ToString(DateFormat),
				grantDecisionVw.PaymentNumber == null ? string.Empty : grantDecisionVw.PaymentNumber,
				grantDecisionVw.PaymentDate == null ? string.Empty : grantDecisionVw.PaymentDate.Value.ToString(DateFormat),
				grantDecisionVw.Notes == null ? string.Empty : grantDecisionVw.Notes,
				grantDecisionVw.TableNumber == null ? string.Empty : grantDecisionVw.TableNumber,
				grantDecisionVw.TableDate == null ? string.Empty : grantDecisionVw.TableDate.Value.ToString(DateFormat),
				grantDecisionVw.BaseNumber == null ? string.Empty : grantDecisionVw.BaseNumber,
				grantDecisionVw.BaseDate == null ? string.Empty : grantDecisionVw.BaseDate.Value.ToString(DateFormat)
            };
        }
        
        private string [] GetParameters(GrantDecision grantDecision)
        {
            GrantDecisionVw grantDecisionVw = new GrantDecisionVw();
            grantDecisionVw.Id = grantDecision.Id;
            grantDecisionVw.Number = grantDecision.Number;
            grantDecisionVw.Year = grantDecision.Year;
            grantDecisionVw.Date = grantDecision.Date;
            grantDecisionVw.CersNumber = grantDecision.CersNumber;
            grantDecisionVw.CersDate = grantDecision.CersDate;
            grantDecisionVw.PaymentNumber = grantDecision.PaymentNumber;
            grantDecisionVw.PaymentDate = grantDecision.PaymentDate;
            grantDecisionVw.Notes = grantDecision.Notes;
            grantDecisionVw.TableNumber = grantDecision.TableNumber;
            grantDecisionVw.TableDate = grantDecision.TableDate;
            grantDecisionVw.BaseNumber = grantDecision.BaseNumber;
            grantDecisionVw.BaseDate = grantDecision.BaseDate;
            return GetParameters(grantDecisionVw);
        }
    }
    #endregion

    #region GrantDeductionVwXmlFormatter
    public class GrantDeductionVwXmlFormatter : XmlFormatterBase
    {
        public GrantDeductionVwXmlFormatter(GrantDeductionVw grantDeductionVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(grantDeductionVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public GrantDeductionVwXmlFormatter(GrantDeduction grantDeduction)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(grantDeduction);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<GrantProductId>{0}</GrantProductId>";
            parametersFormat += "\n\t<GrantProductEmployeeId>{1}</GrantProductEmployeeId>";
            parametersFormat += "\n\t<GrantProductEmployeeFullName>{2}</GrantProductEmployeeFullName>";
            parametersFormat += "\n\t<GrantProductEmployeeCategoryName>{3}</GrantProductEmployeeCategoryName>";
            parametersFormat += "\n\t<GrantProductProductTypeName>{4}</GrantProductProductTypeName>";
            parametersFormat += "\n\t<GrantProductProductTypeRate>{5}</GrantProductProductTypeRate>";
            parametersFormat += "\n\t<GrantGrantDecisionNumber>{6}</GrantGrantDecisionNumber>";
            parametersFormat += "\n\t<GrantGrantDecisionGrantTypeGroupName>{7}</GrantGrantDecisionGrantTypeGroupName>";
            parametersFormat += "\n\t<GrantGrantDecisionDate>{8}</GrantGrantDecisionDate>";
            parametersFormat += "\n\t<GrantAmount>{9}</GrantAmount>";
            parametersFormat += "\n\t<Amount>{10}</Amount>";
            parametersFormat += "\n\t<Description>{11}</Description>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(GrantDeductionVw grantDeductionVw)
        {
            return new string []
            {
				grantDeductionVw.GrantProductId.ToString(),
				grantDeductionVw.GrantProductEmployeeId.ToString(),
				grantDeductionVw.GrantProductEmployeeFullName,
				grantDeductionVw.GrantProductEmployeeCategoryName,
				grantDeductionVw.GrantProductProductTypeName == null ? string.Empty : grantDeductionVw.GrantProductProductTypeName,
				grantDeductionVw.GrantProductProductTypeRate == null ? string.Empty : grantDeductionVw.GrantProductProductTypeRate.Value.ToString(MoneyFormat),
				grantDeductionVw.GrantGrantDecisionNumber.ToString(),
				grantDeductionVw.GrantGrantDecisionGrantTypeGroupName,
				grantDeductionVw.GrantGrantDecisionDate.ToString(DateFormat),
				grantDeductionVw.GrantAmount.ToString(MoneyFormat),
				grantDeductionVw.Amount.ToString(MoneyFormat),
				grantDeductionVw.Description == null ? string.Empty : grantDeductionVw.Description
            };
        }
        
        private string [] GetParameters(GrantDeduction grantDeduction)
        {
            GrantDeductionVw grantDeductionVw = new GrantDeductionVw();
            grantDeductionVw.GrantProductId = grantDeduction.Grant;
            grantDeductionVw.Amount = grantDeduction.Amount;
            grantDeductionVw.Description = grantDeduction.Description;
            return GetParameters(grantDeductionVw);
        }
    }
    #endregion

    #region GrantPaymentVwXmlFormatter
    public class GrantPaymentVwXmlFormatter : XmlFormatterBase
    {
        public GrantPaymentVwXmlFormatter(GrantPaymentVw grantPaymentVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(grantPaymentVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public GrantPaymentVwXmlFormatter(GrantPayment grantPayment)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(grantPayment);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<GrantPaymentOrderNumber>{1}</GrantPaymentOrderNumber>";
            parametersFormat += "\n\t<GrantPaymentOrderDate>{2}</GrantPaymentOrderDate>";
            parametersFormat += "\n\t<SubNumber>{3}</SubNumber>";
            parametersFormat += "\n\t<GrantProductEmployeeId>{4}</GrantProductEmployeeId>";
            parametersFormat += "\n\t<GrantProductEmployeeFullName>{5}</GrantProductEmployeeFullName>";
            parametersFormat += "\n\t<GrantProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>{6}</GrantProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<GrantProductEmployeeCategoryName>{7}</GrantProductEmployeeCategoryName>";
            parametersFormat += "\n\t<GrantProductProductTypeName>{8}</GrantProductProductTypeName>";
            parametersFormat += "\n\t<GrantAmount>{9}</GrantAmount>";
            parametersFormat += "\n\t<Amount>{10}</Amount>";
            parametersFormat += "\n\t<Notes>{11}</Notes>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(GrantPaymentVw grantPaymentVw)
        {
            return new string []
            {
				grantPaymentVw.Id.ToString(),
				grantPaymentVw.GrantPaymentOrderNumber.ToString(),
				grantPaymentVw.GrantPaymentOrderDate.ToString(DateFormat),
				grantPaymentVw.SubNumber.ToString(),
				grantPaymentVw.GrantProductEmployeeId.ToString(),
				grantPaymentVw.GrantProductEmployeeFullName,
				grantPaymentVw.GrantProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName,
				grantPaymentVw.GrantProductEmployeeCategoryName,
				grantPaymentVw.GrantProductProductTypeName == null ? string.Empty : grantPaymentVw.GrantProductProductTypeName,
				grantPaymentVw.GrantAmount.ToString(MoneyFormat),
				grantPaymentVw.Amount.ToString(MoneyFormat),
				grantPaymentVw.Notes == null ? string.Empty : grantPaymentVw.Notes
            };
        }
        
        private string [] GetParameters(GrantPayment grantPayment)
        {
            GrantPaymentVw grantPaymentVw = new GrantPaymentVw();
            grantPaymentVw.Id = grantPayment.Id;
            grantPaymentVw.SubNumber = grantPayment.SubNumber;
            grantPaymentVw.Amount = grantPayment.Amount;
            grantPaymentVw.Notes = grantPayment.Notes;
            return GetParameters(grantPaymentVw);
        }
    }
    #endregion

    #region GrantPaymentOrderVwXmlFormatter
    public class GrantPaymentOrderVwXmlFormatter : XmlFormatterBase
    {
        public GrantPaymentOrderVwXmlFormatter(GrantPaymentOrderVw grantPaymentOrderVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(grantPaymentOrderVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public GrantPaymentOrderVwXmlFormatter(GrantPaymentOrder grantPaymentOrder)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(grantPaymentOrder);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<Number>{1}</Number>";
            parametersFormat += "\n\t<Year>{2}</Year>";
            parametersFormat += "\n\t<Date>{3}</Date>";
            parametersFormat += "\n\t<Notes>{4}</Notes>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(GrantPaymentOrderVw grantPaymentOrderVw)
        {
            return new string []
            {
				grantPaymentOrderVw.Id.ToString(),
				grantPaymentOrderVw.Number.ToString(),
				grantPaymentOrderVw.Year.ToString(),
				grantPaymentOrderVw.Date.ToString(DateFormat),
				grantPaymentOrderVw.Notes == null ? string.Empty : grantPaymentOrderVw.Notes
            };
        }
        
        private string [] GetParameters(GrantPaymentOrder grantPaymentOrder)
        {
            GrantPaymentOrderVw grantPaymentOrderVw = new GrantPaymentOrderVw();
            grantPaymentOrderVw.Id = grantPaymentOrder.Id;
            grantPaymentOrderVw.Number = grantPaymentOrder.Number;
            grantPaymentOrderVw.Year = grantPaymentOrder.Year;
            grantPaymentOrderVw.Date = grantPaymentOrder.Date;
            grantPaymentOrderVw.Notes = grantPaymentOrder.Notes;
            return GetParameters(grantPaymentOrderVw);
        }
    }
    #endregion

    #region GrantRequestVwXmlFormatter
    public class GrantRequestVwXmlFormatter : XmlFormatterBase
    {
        public GrantRequestVwXmlFormatter(GrantRequestVw grantRequestVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(grantRequestVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public GrantRequestVwXmlFormatter(GrantRequest grantRequest)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(grantRequest);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<RequestProductId>{0}</RequestProductId>";
            parametersFormat += "\n\t<RequestProductEmployeeId>{1}</RequestProductEmployeeId>";
            parametersFormat += "\n\t<RequestProductEmployeeFullName>{2}</RequestProductEmployeeFullName>";
            parametersFormat += "\n\t<RequestProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>{3}</RequestProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<RequestProductEmployeeCategoryName>{4}</RequestProductEmployeeCategoryName>";
            parametersFormat += "\n\t<RequestProductProductTypeName>{5}</RequestProductProductTypeName>";
            parametersFormat += "\n\t<RequestProductProductTypeRate>{6}</RequestProductProductTypeRate>";
            parametersFormat += "\n\t<RequestDate>{7}</RequestDate>";
            parametersFormat += "\n\t<GrantType>{8}</GrantType>";
            parametersFormat += "\n\t<Amount>{9}</Amount>";
            parametersFormat += "\n\t<Notes>{10}</Notes>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(GrantRequestVw grantRequestVw)
        {
            return new string []
            {
				grantRequestVw.RequestProductId.ToString(),
				grantRequestVw.RequestProductEmployeeId.ToString(),
				grantRequestVw.RequestProductEmployeeFullName,
				grantRequestVw.RequestProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName,
				grantRequestVw.RequestProductEmployeeCategoryName,
				grantRequestVw.RequestProductProductTypeName == null ? string.Empty : grantRequestVw.RequestProductProductTypeName,
				grantRequestVw.RequestProductProductTypeRate == null ? string.Empty : grantRequestVw.RequestProductProductTypeRate.Value.ToString(MoneyFormat),
				grantRequestVw.RequestDate.ToString(DateFormat),
				grantRequestVw.GrantType.ToString(),
				grantRequestVw.Amount.ToString(MoneyFormat),
				grantRequestVw.Notes == null ? string.Empty : grantRequestVw.Notes
            };
        }
        
        private string [] GetParameters(GrantRequest grantRequest)
        {
            GrantRequestVw grantRequestVw = new GrantRequestVw();
            grantRequestVw.RequestProductId = grantRequest.Request;
            grantRequestVw.GrantType = grantRequest.GrantType;
            grantRequestVw.Amount = grantRequest.Amount;
            grantRequestVw.Notes = grantRequest.Notes;
            return GetParameters(grantRequestVw);
        }
    }
    #endregion

    #region GrantTypeVwXmlFormatter
    public class GrantTypeVwXmlFormatter : XmlFormatterBase
    {
        public GrantTypeVwXmlFormatter(GrantTypeVw grantTypeVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(grantTypeVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public GrantTypeVwXmlFormatter(GrantType grantType)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(grantType);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<Name>{1}</Name>";
            parametersFormat += "\n\t<Amount>{2}</Amount>";
            parametersFormat += "\n\t<GrantTypeGroupName>{3}</GrantTypeGroupName>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(GrantTypeVw grantTypeVw)
        {
            return new string []
            {
				grantTypeVw.Id.ToString(),
				grantTypeVw.Name,
				grantTypeVw.Amount == null ? string.Empty : grantTypeVw.Amount.Value.ToString(MoneyFormat),
				grantTypeVw.GrantTypeGroupName
            };
        }
        
        private string [] GetParameters(GrantType grantType)
        {
            GrantTypeVw grantTypeVw = new GrantTypeVw();
            grantTypeVw.Id = grantType.Id;
            grantTypeVw.Name = grantType.Name;
            grantTypeVw.Amount = grantType.Amount;
            return GetParameters(grantTypeVw);
        }
    }
    #endregion

    #region GrantTypeGroupVwXmlFormatter
    public class GrantTypeGroupVwXmlFormatter : XmlFormatterBase
    {
        public GrantTypeGroupVwXmlFormatter(GrantTypeGroupVw grantTypeGroupVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(grantTypeGroupVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public GrantTypeGroupVwXmlFormatter(GrantTypeGroup grantTypeGroup)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(grantTypeGroup);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<Name>{1}</Name>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(GrantTypeGroupVw grantTypeGroupVw)
        {
            return new string []
            {
				grantTypeGroupVw.Id.ToString(),
				grantTypeGroupVw.Name
            };
        }
        
        private string [] GetParameters(GrantTypeGroup grantTypeGroup)
        {
            GrantTypeGroupVw grantTypeGroupVw = new GrantTypeGroupVw();
            grantTypeGroupVw.Id = grantTypeGroup.Id;
            grantTypeGroupVw.Name = grantTypeGroup.Name;
            return GetParameters(grantTypeGroupVw);
        }
    }
    #endregion

    #region GuarantorVwXmlFormatter
    public class GuarantorVwXmlFormatter : XmlFormatterBase
    {
        public GuarantorVwXmlFormatter(GuarantorVw guarantorVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(guarantorVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public GuarantorVwXmlFormatter(Guarantor guarantor)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(guarantor);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<RefundableProductProductEmployeeId>{1}</RefundableProductProductEmployeeId>";
            parametersFormat += "\n\t<RefundableProductProductEmployeeFullName>{2}</RefundableProductProductEmployeeFullName>";
            parametersFormat += "\n\t<RefundableProductProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>{3}</RefundableProductProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<RefundableProductProductEmployeeCategoryName>{4}</RefundableProductProductEmployeeCategoryName>";
            parametersFormat += "\n\t<RefundableProductProductProductTypeName>{5}</RefundableProductProductProductTypeName>";
            parametersFormat += "\n\t<RefundableProductProductProductTypeRate>{6}</RefundableProductProductProductTypeRate>";
            parametersFormat += "\n\t<RefundableProductProductAmount>{7}</RefundableProductProductAmount>";
            parametersFormat += "\n\t<RefundableProductInstallment>{8}</RefundableProductInstallment>";
            parametersFormat += "\n\t<RefundableProductNetAmount>{9}</RefundableProductNetAmount>";
            parametersFormat += "\n\t<RefundableProductProfitAmount>{10}</RefundableProductProfitAmount>";
            parametersFormat += "\n\t<SubNumber>{11}</SubNumber>";
            parametersFormat += "\n\t<EmployeeId>{12}</EmployeeId>";
            parametersFormat += "\n\t<EmployeeFullName>{13}</EmployeeFullName>";
            parametersFormat += "\n\t<EmployeeDepartmentName>{14}</EmployeeDepartmentName>";
            parametersFormat += "\n\t<EmployeeDepartmentSalaryWorkPlaceName>{15}</EmployeeDepartmentSalaryWorkPlaceName>";
            parametersFormat += "\n\t<EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>{16}</EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<EmployeeCategoryName>{17}</EmployeeCategoryName>";
            parametersFormat += "\n\t<GuarantorStatusName>{18}</GuarantorStatusName>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(GuarantorVw guarantorVw)
        {
            return new string []
            {
				guarantorVw.Id.ToString(),
				guarantorVw.RefundableProductProductEmployeeId.ToString(),
				guarantorVw.RefundableProductProductEmployeeFullName,
				guarantorVw.RefundableProductProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName,
				guarantorVw.RefundableProductProductEmployeeCategoryName,
				guarantorVw.RefundableProductProductProductTypeName == null ? string.Empty : guarantorVw.RefundableProductProductProductTypeName,
				guarantorVw.RefundableProductProductProductTypeRate == null ? string.Empty : guarantorVw.RefundableProductProductProductTypeRate.Value.ToString(MoneyFormat),
				guarantorVw.RefundableProductProductAmount.ToString(MoneyFormat),
				guarantorVw.RefundableProductInstallment.ToString(MoneyFormat),
				guarantorVw.RefundableProductNetAmount.ToString(MoneyFormat),
				guarantorVw.RefundableProductProfitAmount.ToString(MoneyFormat),
				guarantorVw.SubNumber.ToString(),
				guarantorVw.EmployeeId.ToString(),
				guarantorVw.EmployeeFullName,
				guarantorVw.EmployeeDepartmentName,
				guarantorVw.EmployeeDepartmentSalaryWorkPlaceName,
				guarantorVw.EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName,
				guarantorVw.EmployeeCategoryName,
				guarantorVw.GuarantorStatusName
            };
        }
        
        private string [] GetParameters(Guarantor guarantor)
        {
            GuarantorVw guarantorVw = new GuarantorVw();
            guarantorVw.Id = guarantor.Id;
            guarantorVw.SubNumber = guarantor.SubNumber;
            guarantorVw.EmployeeId = guarantor.Employee;
            return GetParameters(guarantorVw);
        }
    }
    #endregion

    #region GuarantorStatementVwXmlFormatter
    public class GuarantorStatementVwXmlFormatter : XmlFormatterBase
    {
        public GuarantorStatementVwXmlFormatter(GuarantorStatementVw guarantorStatementVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(guarantorStatementVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public GuarantorStatementVwXmlFormatter(GuarantorStatement guarantorStatement)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(guarantorStatement);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<GuarantorId>{0}</GuarantorId>";
            parametersFormat += "\n\t<GuarantorRefundableProductProductEmployeeId>{1}</GuarantorRefundableProductProductEmployeeId>";
            parametersFormat += "\n\t<GuarantorRefundableProductProductEmployeeFullName>{2}</GuarantorRefundableProductProductEmployeeFullName>";
            parametersFormat += "\n\t<GuarantorRefundableProductProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>{3}</GuarantorRefundableProductProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<GuarantorRefundableProductProductEmployeeCategoryName>{4}</GuarantorRefundableProductProductEmployeeCategoryName>";
            parametersFormat += "\n\t<GuarantorRefundableProductProductProductTypeName>{5}</GuarantorRefundableProductProductProductTypeName>";
            parametersFormat += "\n\t<GuarantorSubNumber>{6}</GuarantorSubNumber>";
            parametersFormat += "\n\t<GuarantorEmployeeId>{7}</GuarantorEmployeeId>";
            parametersFormat += "\n\t<GuarantorEmployeeFullName>{8}</GuarantorEmployeeFullName>";
            parametersFormat += "\n\t<GuarantorEmployeeDepartmentName>{9}</GuarantorEmployeeDepartmentName>";
            parametersFormat += "\n\t<GuarantorEmployeeDepartmentSalaryWorkPlaceName>{10}</GuarantorEmployeeDepartmentSalaryWorkPlaceName>";
            parametersFormat += "\n\t<GuarantorEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>{11}</GuarantorEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<GuarantorEmployeeCategoryName>{12}</GuarantorEmployeeCategoryName>";
            parametersFormat += "\n\t<GuarantorGuarantorStatusName>{13}</GuarantorGuarantorStatusName>";
            parametersFormat += "\n\t<GuarantorNotes>{14}</GuarantorNotes>";
            parametersFormat += "\n\t<GrossSalary>{15}</GrossSalary>";
            parametersFormat += "\n\t<DeductionsAmount>{16}</DeductionsAmount>";
            parametersFormat += "\n\t<NetSalary>{17}</NetSalary>";
            parametersFormat += "\n\t<ExceptionalIncome>{18}</ExceptionalIncome>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(GuarantorStatementVw guarantorStatementVw)
        {
            return new string []
            {
				guarantorStatementVw.GuarantorId.ToString(),
				guarantorStatementVw.GuarantorRefundableProductProductEmployeeId.ToString(),
				guarantorStatementVw.GuarantorRefundableProductProductEmployeeFullName,
				guarantorStatementVw.GuarantorRefundableProductProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName,
				guarantorStatementVw.GuarantorRefundableProductProductEmployeeCategoryName,
				guarantorStatementVw.GuarantorRefundableProductProductProductTypeName == null ? string.Empty : guarantorStatementVw.GuarantorRefundableProductProductProductTypeName,
				guarantorStatementVw.GuarantorSubNumber.ToString(),
				guarantorStatementVw.GuarantorEmployeeId.ToString(),
				guarantorStatementVw.GuarantorEmployeeFullName,
				guarantorStatementVw.GuarantorEmployeeDepartmentName,
				guarantorStatementVw.GuarantorEmployeeDepartmentSalaryWorkPlaceName,
				guarantorStatementVw.GuarantorEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName,
				guarantorStatementVw.GuarantorEmployeeCategoryName,
				guarantorStatementVw.GuarantorGuarantorStatusName,
				guarantorStatementVw.GuarantorNotes == null ? string.Empty : guarantorStatementVw.GuarantorNotes,
				guarantorStatementVw.GrossSalary == null ? string.Empty : guarantorStatementVw.GrossSalary.Value.ToString(MoneyFormat),
				guarantorStatementVw.DeductionsAmount == null ? string.Empty : guarantorStatementVw.DeductionsAmount.Value.ToString(MoneyFormat),
				guarantorStatementVw.NetSalary == null ? string.Empty : guarantorStatementVw.NetSalary.Value.ToString(MoneyFormat),
				guarantorStatementVw.ExceptionalIncome == null ? string.Empty : guarantorStatementVw.ExceptionalIncome.Value.ToString(MoneyFormat)
            };
        }
        
        private string [] GetParameters(GuarantorStatement guarantorStatement)
        {
            GuarantorStatementVw guarantorStatementVw = new GuarantorStatementVw();
            guarantorStatementVw.GuarantorId = guarantorStatement.Guarantor;
            guarantorStatementVw.GrossSalary = guarantorStatement.GrossSalary;
            guarantorStatementVw.DeductionsAmount = guarantorStatement.DeductionsAmount;
            guarantorStatementVw.NetSalary = guarantorStatement.NetSalary;
            guarantorStatementVw.ExceptionalIncome = guarantorStatement.ExceptionalIncome;
            return GetParameters(guarantorStatementVw);
        }
    }
    #endregion

    #region GuarantorStatusVwXmlFormatter
    public class GuarantorStatusVwXmlFormatter : XmlFormatterBase
    {
        public GuarantorStatusVwXmlFormatter(GuarantorStatusVw guarantorStatusVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(guarantorStatusVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public GuarantorStatusVwXmlFormatter(GuarantorStatus guarantorStatus)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(guarantorStatus);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<Name>{1}</Name>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(GuarantorStatusVw guarantorStatusVw)
        {
            return new string []
            {
				guarantorStatusVw.Id.ToString(),
				guarantorStatusVw.Name
            };
        }
        
        private string [] GetParameters(GuarantorStatus guarantorStatus)
        {
            GuarantorStatusVw guarantorStatusVw = new GuarantorStatusVw();
            guarantorStatusVw.Id = guarantorStatus.Id;
            guarantorStatusVw.Name = guarantorStatus.Name;
            return GetParameters(guarantorStatusVw);
        }
    }
    #endregion

    #region HealthLoanDecisionVwXmlFormatter
    public class HealthLoanDecisionVwXmlFormatter : XmlFormatterBase
    {
        public HealthLoanDecisionVwXmlFormatter(HealthLoanDecisionVw healthLoanDecisionVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(healthLoanDecisionVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public HealthLoanDecisionVwXmlFormatter(HealthLoanDecision healthLoanDecision)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(healthLoanDecision);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<Number>{1}</Number>";
            parametersFormat += "\n\t<Year>{2}</Year>";
            parametersFormat += "\n\t<Date>{3}</Date>";
            parametersFormat += "\n\t<CersNumber>{4}</CersNumber>";
            parametersFormat += "\n\t<CersDate>{5}</CersDate>";
            parametersFormat += "\n\t<PaymentNumber>{6}</PaymentNumber>";
            parametersFormat += "\n\t<PaymentDate>{7}</PaymentDate>";
            parametersFormat += "\n\t<Notes>{8}</Notes>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(HealthLoanDecisionVw healthLoanDecisionVw)
        {
            return new string []
            {
				healthLoanDecisionVw.Id.ToString(),
				healthLoanDecisionVw.Number.ToString(),
				healthLoanDecisionVw.Year.ToString(),
				healthLoanDecisionVw.Date == null ? string.Empty : healthLoanDecisionVw.Date.Value.ToString(DateFormat),
				healthLoanDecisionVw.CersNumber == null ? string.Empty : healthLoanDecisionVw.CersNumber,
				healthLoanDecisionVw.CersDate == null ? string.Empty : healthLoanDecisionVw.CersDate.Value.ToString(DateFormat),
				healthLoanDecisionVw.PaymentNumber == null ? string.Empty : healthLoanDecisionVw.PaymentNumber,
				healthLoanDecisionVw.PaymentDate == null ? string.Empty : healthLoanDecisionVw.PaymentDate.Value.ToString(DateFormat),
				healthLoanDecisionVw.Notes == null ? string.Empty : healthLoanDecisionVw.Notes
            };
        }
        
        private string [] GetParameters(HealthLoanDecision healthLoanDecision)
        {
            HealthLoanDecisionVw healthLoanDecisionVw = new HealthLoanDecisionVw();
            healthLoanDecisionVw.Id = healthLoanDecision.Id;
            healthLoanDecisionVw.Number = healthLoanDecision.Number;
            healthLoanDecisionVw.Year = healthLoanDecision.Year;
            healthLoanDecisionVw.Date = healthLoanDecision.Date;
            healthLoanDecisionVw.CersNumber = healthLoanDecision.CersNumber;
            healthLoanDecisionVw.CersDate = healthLoanDecision.CersDate;
            healthLoanDecisionVw.PaymentNumber = healthLoanDecision.PaymentNumber;
            healthLoanDecisionVw.PaymentDate = healthLoanDecision.PaymentDate;
            healthLoanDecisionVw.Notes = healthLoanDecision.Notes;
            return GetParameters(healthLoanDecisionVw);
        }
    }
    #endregion

    #region HealthLoanDecisionFirstPaymentVwXmlFormatter
    public class HealthLoanDecisionFirstPaymentVwXmlFormatter : XmlFormatterBase
    {
        public HealthLoanDecisionFirstPaymentVwXmlFormatter(HealthLoanDecisionFirstPaymentVw healthLoanDecisionFirstPaymentVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(healthLoanDecisionFirstPaymentVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public HealthLoanDecisionFirstPaymentVwXmlFormatter(HealthLoanDecisionFirstPayment healthLoanDecisionFirstPayment)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(healthLoanDecisionFirstPayment);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<EmployeeId>{1}</EmployeeId>";
            parametersFormat += "\n\t<EmployeeFullName>{2}</EmployeeFullName>";
            parametersFormat += "\n\t<EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>{3}</EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<EmployeeCategoryName>{4}</EmployeeCategoryName>";
            parametersFormat += "\n\t<PaymentDate>{5}</PaymentDate>";
            parametersFormat += "\n\t<PaymentAmount>{6}</PaymentAmount>";
            parametersFormat += "\n\t<InvoiceDate>{7}</InvoiceDate>";
            parametersFormat += "\n\t<InvoiceAmount>{8}</InvoiceAmount>";
            parametersFormat += "\n\t<InvoiceNotes>{9}</InvoiceNotes>";
            parametersFormat += "\n\t<InsuranceDate>{10}</InsuranceDate>";
            parametersFormat += "\n\t<InsuranceAmount>{11}</InsuranceAmount>";
            parametersFormat += "\n\t<InsuranceTypeName>{12}</InsuranceTypeName>";
            parametersFormat += "\n\t<InsuranceNotes>{13}</InsuranceNotes>";
            parametersFormat += "\n\t<PaymentStatus>{14}</PaymentStatus>";
            parametersFormat += "\n\t<Notes>{15}</Notes>";
            parametersFormat += "\n\t<HealthLoanDecisionNumber>{16}</HealthLoanDecisionNumber>";
            parametersFormat += "\n\t<HealthLoanDecisionDate>{17}</HealthLoanDecisionDate>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(HealthLoanDecisionFirstPaymentVw healthLoanDecisionFirstPaymentVw)
        {
            return new string []
            {
				healthLoanDecisionFirstPaymentVw.Id.ToString(),
				healthLoanDecisionFirstPaymentVw.EmployeeId.ToString(),
				healthLoanDecisionFirstPaymentVw.EmployeeFullName,
				healthLoanDecisionFirstPaymentVw.EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName,
				healthLoanDecisionFirstPaymentVw.EmployeeCategoryName,
				healthLoanDecisionFirstPaymentVw.PaymentDate.ToString(DateFormat),
				healthLoanDecisionFirstPaymentVw.PaymentAmount == null ? string.Empty : healthLoanDecisionFirstPaymentVw.PaymentAmount.Value.ToString(MoneyFormat),
				healthLoanDecisionFirstPaymentVw.InvoiceDate == null ? string.Empty : healthLoanDecisionFirstPaymentVw.InvoiceDate.Value.ToString(DateFormat),
				healthLoanDecisionFirstPaymentVw.InvoiceAmount == null ? string.Empty : healthLoanDecisionFirstPaymentVw.InvoiceAmount.Value.ToString(MoneyFormat),
				healthLoanDecisionFirstPaymentVw.InvoiceNotes == null ? string.Empty : healthLoanDecisionFirstPaymentVw.InvoiceNotes,
				healthLoanDecisionFirstPaymentVw.InsuranceDate == null ? string.Empty : healthLoanDecisionFirstPaymentVw.InsuranceDate.Value.ToString(DateFormat),
				healthLoanDecisionFirstPaymentVw.InsuranceAmount == null ? string.Empty : healthLoanDecisionFirstPaymentVw.InsuranceAmount.Value.ToString(MoneyFormat),
				healthLoanDecisionFirstPaymentVw.InsuranceTypeName == null ? string.Empty : healthLoanDecisionFirstPaymentVw.InsuranceTypeName,
				healthLoanDecisionFirstPaymentVw.InsuranceNotes == null ? string.Empty : healthLoanDecisionFirstPaymentVw.InsuranceNotes,
				healthLoanDecisionFirstPaymentVw.PaymentStatus == null ? string.Empty : healthLoanDecisionFirstPaymentVw.PaymentStatus.Value.ToString(),
				healthLoanDecisionFirstPaymentVw.Notes == null ? string.Empty : healthLoanDecisionFirstPaymentVw.Notes,
				healthLoanDecisionFirstPaymentVw.HealthLoanDecisionNumber == null ? string.Empty : healthLoanDecisionFirstPaymentVw.HealthLoanDecisionNumber.Value.ToString(),
				healthLoanDecisionFirstPaymentVw.HealthLoanDecisionDate == null ? string.Empty : healthLoanDecisionFirstPaymentVw.HealthLoanDecisionDate.Value.ToString(DateFormat)
            };
        }
        
        private string [] GetParameters(HealthLoanDecisionFirstPayment healthLoanDecisionFirstPayment)
        {
            HealthLoanDecisionFirstPaymentVw healthLoanDecisionFirstPaymentVw = new HealthLoanDecisionFirstPaymentVw();
            healthLoanDecisionFirstPaymentVw.Id = healthLoanDecisionFirstPayment.Id;
            healthLoanDecisionFirstPaymentVw.EmployeeId = healthLoanDecisionFirstPayment.Employee;
            healthLoanDecisionFirstPaymentVw.PaymentDate = healthLoanDecisionFirstPayment.PaymentDate;
            healthLoanDecisionFirstPaymentVw.PaymentAmount = healthLoanDecisionFirstPayment.PaymentAmount;
            healthLoanDecisionFirstPaymentVw.InvoiceDate = healthLoanDecisionFirstPayment.InvoiceDate;
            healthLoanDecisionFirstPaymentVw.InvoiceAmount = healthLoanDecisionFirstPayment.InvoiceAmount;
            healthLoanDecisionFirstPaymentVw.InvoiceNotes = healthLoanDecisionFirstPayment.InvoiceNotes;
            healthLoanDecisionFirstPaymentVw.InsuranceDate = healthLoanDecisionFirstPayment.InsuranceDate;
            healthLoanDecisionFirstPaymentVw.InsuranceAmount = healthLoanDecisionFirstPayment.InsuranceAmount;
            healthLoanDecisionFirstPaymentVw.InsuranceNotes = healthLoanDecisionFirstPayment.InsuranceNotes;
            healthLoanDecisionFirstPaymentVw.PaymentStatus = healthLoanDecisionFirstPayment.PaymentStatus;
            healthLoanDecisionFirstPaymentVw.Notes = healthLoanDecisionFirstPayment.Notes;
            return GetParameters(healthLoanDecisionFirstPaymentVw);
        }
    }
    #endregion

    #region IncomingLoanVwXmlFormatter
    public class IncomingLoanVwXmlFormatter : XmlFormatterBase
    {
        public IncomingLoanVwXmlFormatter(IncomingLoanVw incomingLoanVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(incomingLoanVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public IncomingLoanVwXmlFormatter(IncomingLoan incomingLoan)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(incomingLoan);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<LoanProductId>{0}</LoanProductId>";
            parametersFormat += "\n\t<LoanProductEmployeeId>{1}</LoanProductEmployeeId>";
            parametersFormat += "\n\t<LoanProductEmployeeFullName>{2}</LoanProductEmployeeFullName>";
            parametersFormat += "\n\t<LoanProductEmployeeDepartmentName>{3}</LoanProductEmployeeDepartmentName>";
            parametersFormat += "\n\t<LoanProductEmployeeDepartmentSalaryWorkPlaceName>{4}</LoanProductEmployeeDepartmentSalaryWorkPlaceName>";
            parametersFormat += "\n\t<LoanProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>{5}</LoanProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<LoanProductEmployeeCategoryName>{6}</LoanProductEmployeeCategoryName>";
            parametersFormat += "\n\t<LoanProductProductTypeName>{7}</LoanProductProductTypeName>";
            parametersFormat += "\n\t<LoanProductProductTypeRate>{8}</LoanProductProductTypeRate>";
            parametersFormat += "\n\t<LoanProductAmount>{9}</LoanProductAmount>";
            parametersFormat += "\n\t<LoanLoanDecisionNumber>{10}</LoanLoanDecisionNumber>";
            parametersFormat += "\n\t<LoanLoanDecisionDate>{11}</LoanLoanDecisionDate>";
            parametersFormat += "\n\t<LoanLoanDecisionLoanDecisionTypeName>{12}</LoanLoanDecisionLoanDecisionTypeName>";
            parametersFormat += "\n\t<LoanLoanDecisionIsPaidFromSalary>{13}</LoanLoanDecisionIsPaidFromSalary>";
            parametersFormat += "\n\t<LoanLoanGenerationStatusName>{14}</LoanLoanGenerationStatusName>";
            parametersFormat += "\n\t<LoanLoanStatusName>{15}</LoanLoanStatusName>";
            parametersFormat += "\n\t<MainWorkPlaceName>{16}</MainWorkPlaceName>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(IncomingLoanVw incomingLoanVw)
        {
            return new string []
            {
				incomingLoanVw.LoanProductId.ToString(),
				incomingLoanVw.LoanProductEmployeeId.ToString(),
				incomingLoanVw.LoanProductEmployeeFullName,
				incomingLoanVw.LoanProductEmployeeDepartmentName,
				incomingLoanVw.LoanProductEmployeeDepartmentSalaryWorkPlaceName,
				incomingLoanVw.LoanProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName,
				incomingLoanVw.LoanProductEmployeeCategoryName,
				incomingLoanVw.LoanProductProductTypeName == null ? string.Empty : incomingLoanVw.LoanProductProductTypeName,
				incomingLoanVw.LoanProductProductTypeRate == null ? string.Empty : incomingLoanVw.LoanProductProductTypeRate.Value.ToString(MoneyFormat),
				incomingLoanVw.LoanProductAmount.ToString(MoneyFormat),
				incomingLoanVw.LoanLoanDecisionNumber.ToString(),
				incomingLoanVw.LoanLoanDecisionDate.ToString(DateFormat),
				incomingLoanVw.LoanLoanDecisionLoanDecisionTypeName,
				incomingLoanVw.LoanLoanDecisionIsPaidFromSalary == null ? string.Empty : incomingLoanVw.LoanLoanDecisionIsPaidFromSalary.Value.ToString(),
				incomingLoanVw.LoanLoanGenerationStatusName,
				incomingLoanVw.LoanLoanStatusName,
				incomingLoanVw.MainWorkPlaceName
            };
        }
        
        private string [] GetParameters(IncomingLoan incomingLoan)
        {
            IncomingLoanVw incomingLoanVw = new IncomingLoanVw();
            incomingLoanVw.LoanProductId = incomingLoan.Loan;
            return GetParameters(incomingLoanVw);
        }
    }
    #endregion

    #region InstallmentVwXmlFormatter
    public class InstallmentVwXmlFormatter : XmlFormatterBase
    {
        public InstallmentVwXmlFormatter(InstallmentVw installmentVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(installmentVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public InstallmentVwXmlFormatter(Installment installment)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(installment);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<RefundableProductProductEmployeeId>{1}</RefundableProductProductEmployeeId>";
            parametersFormat += "\n\t<RefundableProductProductEmployeeFullName>{2}</RefundableProductProductEmployeeFullName>";
            parametersFormat += "\n\t<RefundableProductProductEmployeeDepartmentName>{3}</RefundableProductProductEmployeeDepartmentName>";
            parametersFormat += "\n\t<RefundableProductProductEmployeeDepartmentSalaryWorkPlaceName>{4}</RefundableProductProductEmployeeDepartmentSalaryWorkPlaceName>";
            parametersFormat += "\n\t<RefundableProductProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>{5}</RefundableProductProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<RefundableProductProductEmployeeCategoryName>{6}</RefundableProductProductEmployeeCategoryName>";
            parametersFormat += "\n\t<RefundableProductProductProductTypeName>{7}</RefundableProductProductProductTypeName>";
            parametersFormat += "\n\t<RefundableProductProductProductTypeRate>{8}</RefundableProductProductProductTypeRate>";
            parametersFormat += "\n\t<RefundableProductProductProductTypeGuarantorsCount>{9}</RefundableProductProductProductTypeGuarantorsCount>";
            parametersFormat += "\n\t<RefundableProductInstallment>{10}</RefundableProductInstallment>";
            parametersFormat += "\n\t<RefundableProductNetAmount>{11}</RefundableProductNetAmount>";
            parametersFormat += "\n\t<RefundableProductProfitAmount>{12}</RefundableProductProfitAmount>";
            parametersFormat += "\n\t<SubNumber>{13}</SubNumber>";
            parametersFormat += "\n\t<DueDate>{14}</DueDate>";
            parametersFormat += "\n\t<DueCapital>{15}</DueCapital>";
            parametersFormat += "\n\t<DueProfit>{16}</DueProfit>";
            parametersFormat += "\n\t<Notes>{17}</Notes>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(InstallmentVw installmentVw)
        {
            return new string []
            {
				installmentVw.Id.ToString(),
				installmentVw.RefundableProductProductEmployeeId.ToString(),
				installmentVw.RefundableProductProductEmployeeFullName,
				installmentVw.RefundableProductProductEmployeeDepartmentName,
				installmentVw.RefundableProductProductEmployeeDepartmentSalaryWorkPlaceName,
				installmentVw.RefundableProductProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName,
				installmentVw.RefundableProductProductEmployeeCategoryName,
				installmentVw.RefundableProductProductProductTypeName == null ? string.Empty : installmentVw.RefundableProductProductProductTypeName,
				installmentVw.RefundableProductProductProductTypeRate == null ? string.Empty : installmentVw.RefundableProductProductProductTypeRate.Value.ToString(MoneyFormat),
				installmentVw.RefundableProductProductProductTypeGuarantorsCount.ToString(),
				installmentVw.RefundableProductInstallment.ToString(MoneyFormat),
				installmentVw.RefundableProductNetAmount.ToString(MoneyFormat),
				installmentVw.RefundableProductProfitAmount.ToString(MoneyFormat),
				installmentVw.SubNumber.ToString(),
				installmentVw.DueDate.ToString(DateFormat),
				installmentVw.DueCapital.ToString(MoneyFormat),
				installmentVw.DueProfit.ToString(MoneyFormat),
				installmentVw.Notes == null ? string.Empty : installmentVw.Notes
            };
        }
        
        private string [] GetParameters(Installment installment)
        {
            InstallmentVw installmentVw = new InstallmentVw();
            installmentVw.Id = installment.Id;
            installmentVw.SubNumber = installment.SubNumber;
            installmentVw.DueDate = installment.DueDate;
            installmentVw.DueCapital = installment.DueCapital;
            installmentVw.DueProfit = installment.DueProfit;
            installmentVw.Notes = installment.Notes;
            return GetParameters(installmentVw);
        }
    }
    #endregion

    #region InstallmentDecreaseVwXmlFormatter
    public class InstallmentDecreaseVwXmlFormatter : XmlFormatterBase
    {
        public InstallmentDecreaseVwXmlFormatter(InstallmentDecreaseVw installmentDecreaseVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(installmentDecreaseVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public InstallmentDecreaseVwXmlFormatter(InstallmentDecrease installmentDecrease)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(installmentDecrease);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<InstallmentDecreaseOrderMonth>{1}</InstallmentDecreaseOrderMonth>";
            parametersFormat += "\n\t<InstallmentDecreaseOrderCersNumber>{2}</InstallmentDecreaseOrderCersNumber>";
            parametersFormat += "\n\t<InstallmentDecreaseOrderCersDate>{3}</InstallmentDecreaseOrderCersDate>";
            parametersFormat += "\n\t<EmployeeId>{4}</EmployeeId>";
            parametersFormat += "\n\t<EmployeeFullName>{5}</EmployeeFullName>";
            parametersFormat += "\n\t<EmployeeDepartmentName>{6}</EmployeeDepartmentName>";
            parametersFormat += "\n\t<EmployeeDepartmentSalaryWorkPlaceName>{7}</EmployeeDepartmentSalaryWorkPlaceName>";
            parametersFormat += "\n\t<EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>{8}</EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<EmployeeCategoryName>{9}</EmployeeCategoryName>";
            parametersFormat += "\n\t<DepartmentName>{10}</DepartmentName>";
            parametersFormat += "\n\t<DepartmentSalaryWorkPlaceName>{11}</DepartmentSalaryWorkPlaceName>";
            parametersFormat += "\n\t<DepartmentSalaryWorkPlaceMainWorkPlaceName>{12}</DepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<DecreaseAmount>{13}</DecreaseAmount>";
            parametersFormat += "\n\t<NewInstallmentAmount>{14}</NewInstallmentAmount>";
            parametersFormat += "\n\t<Notes>{15}</Notes>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(InstallmentDecreaseVw installmentDecreaseVw)
        {
            return new string []
            {
				installmentDecreaseVw.Id.ToString(),
				installmentDecreaseVw.InstallmentDecreaseOrderMonth.ToString(DateFormat),
				installmentDecreaseVw.InstallmentDecreaseOrderCersNumber == null ? string.Empty : installmentDecreaseVw.InstallmentDecreaseOrderCersNumber,
				installmentDecreaseVw.InstallmentDecreaseOrderCersDate == null ? string.Empty : installmentDecreaseVw.InstallmentDecreaseOrderCersDate.Value.ToString(DateFormat),
				installmentDecreaseVw.EmployeeId.ToString(),
				installmentDecreaseVw.EmployeeFullName,
				installmentDecreaseVw.EmployeeDepartmentName,
				installmentDecreaseVw.EmployeeDepartmentSalaryWorkPlaceName,
				installmentDecreaseVw.EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName,
				installmentDecreaseVw.EmployeeCategoryName,
				installmentDecreaseVw.DepartmentName == null ? string.Empty : installmentDecreaseVw.DepartmentName,
				installmentDecreaseVw.DepartmentSalaryWorkPlaceName == null ? string.Empty : installmentDecreaseVw.DepartmentSalaryWorkPlaceName,
				installmentDecreaseVw.DepartmentSalaryWorkPlaceMainWorkPlaceName == null ? string.Empty : installmentDecreaseVw.DepartmentSalaryWorkPlaceMainWorkPlaceName,
				installmentDecreaseVw.DecreaseAmount.ToString(MoneyFormat),
				installmentDecreaseVw.NewInstallmentAmount.ToString(MoneyFormat),
				installmentDecreaseVw.Notes == null ? string.Empty : installmentDecreaseVw.Notes
            };
        }
        
        private string [] GetParameters(InstallmentDecrease installmentDecrease)
        {
            InstallmentDecreaseVw installmentDecreaseVw = new InstallmentDecreaseVw();
            installmentDecreaseVw.Id = installmentDecrease.Id;
            installmentDecreaseVw.EmployeeId = installmentDecrease.Employee;
            installmentDecreaseVw.DecreaseAmount = installmentDecrease.DecreaseAmount;
            installmentDecreaseVw.NewInstallmentAmount = installmentDecrease.NewInstallmentAmount;
            installmentDecreaseVw.Notes = installmentDecrease.Notes;
            return GetParameters(installmentDecreaseVw);
        }
    }
    #endregion

    #region InstallmentDecreaseOrderVwXmlFormatter
    public class InstallmentDecreaseOrderVwXmlFormatter : XmlFormatterBase
    {
        public InstallmentDecreaseOrderVwXmlFormatter(InstallmentDecreaseOrderVw installmentDecreaseOrderVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(installmentDecreaseOrderVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public InstallmentDecreaseOrderVwXmlFormatter(InstallmentDecreaseOrder installmentDecreaseOrder)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(installmentDecreaseOrder);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<Month>{1}</Month>";
            parametersFormat += "\n\t<CersNumber>{2}</CersNumber>";
            parametersFormat += "\n\t<CersDate>{3}</CersDate>";
            parametersFormat += "\n\t<Notes>{4}</Notes>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(InstallmentDecreaseOrderVw installmentDecreaseOrderVw)
        {
            return new string []
            {
				installmentDecreaseOrderVw.Id.ToString(),
				installmentDecreaseOrderVw.Month.ToString(DateFormat),
				installmentDecreaseOrderVw.CersNumber == null ? string.Empty : installmentDecreaseOrderVw.CersNumber,
				installmentDecreaseOrderVw.CersDate == null ? string.Empty : installmentDecreaseOrderVw.CersDate.Value.ToString(DateFormat),
				installmentDecreaseOrderVw.Notes == null ? string.Empty : installmentDecreaseOrderVw.Notes
            };
        }
        
        private string [] GetParameters(InstallmentDecreaseOrder installmentDecreaseOrder)
        {
            InstallmentDecreaseOrderVw installmentDecreaseOrderVw = new InstallmentDecreaseOrderVw();
            installmentDecreaseOrderVw.Id = installmentDecreaseOrder.Id;
            installmentDecreaseOrderVw.Month = installmentDecreaseOrder.Month;
            installmentDecreaseOrderVw.CersNumber = installmentDecreaseOrder.CersNumber;
            installmentDecreaseOrderVw.CersDate = installmentDecreaseOrder.CersDate;
            installmentDecreaseOrderVw.Notes = installmentDecreaseOrder.Notes;
            return GetParameters(installmentDecreaseOrderVw);
        }
    }
    #endregion

    #region InsuranceTypeVwXmlFormatter
    public class InsuranceTypeVwXmlFormatter : XmlFormatterBase
    {
        public InsuranceTypeVwXmlFormatter(InsuranceTypeVw insuranceTypeVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(insuranceTypeVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public InsuranceTypeVwXmlFormatter(InsuranceType insuranceType)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(insuranceType);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<Name>{1}</Name>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(InsuranceTypeVw insuranceTypeVw)
        {
            return new string []
            {
				insuranceTypeVw.Id.ToString(),
				insuranceTypeVw.Name
            };
        }
        
        private string [] GetParameters(InsuranceType insuranceType)
        {
            InsuranceTypeVw insuranceTypeVw = new InsuranceTypeVw();
            insuranceTypeVw.Id = insuranceType.Id;
            insuranceTypeVw.Name = insuranceType.Name;
            return GetParameters(insuranceTypeVw);
        }
    }
    #endregion

    #region IssuerVwXmlFormatter
    public class IssuerVwXmlFormatter : XmlFormatterBase
    {
        public IssuerVwXmlFormatter(IssuerVw issuerVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(issuerVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public IssuerVwXmlFormatter(Issuer issuer)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(issuer);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<Name>{1}</Name>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(IssuerVw issuerVw)
        {
            return new string []
            {
				issuerVw.Id.ToString(),
				issuerVw.Name
            };
        }
        
        private string [] GetParameters(Issuer issuer)
        {
            IssuerVw issuerVw = new IssuerVw();
            issuerVw.Id = issuer.Id;
            issuerVw.Name = issuer.Name;
            return GetParameters(issuerVw);
        }
    }
    #endregion

    #region LoanVwXmlFormatter
    public class LoanVwXmlFormatter : XmlFormatterBase
    {
        public LoanVwXmlFormatter(LoanVw loanVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(loanVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public LoanVwXmlFormatter(Loan loan)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(loan);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<ProductId>{0}</ProductId>";
            parametersFormat += "\n\t<ProductEmployeeId>{1}</ProductEmployeeId>";
            parametersFormat += "\n\t<ProductEmployeeFullName>{2}</ProductEmployeeFullName>";
            parametersFormat += "\n\t<ProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>{3}</ProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<ProductEmployeeCategoryName>{4}</ProductEmployeeCategoryName>";
            parametersFormat += "\n\t<ProductProductTypeName>{5}</ProductProductTypeName>";
            parametersFormat += "\n\t<ProductProductTypeRate>{6}</ProductProductTypeRate>";
            parametersFormat += "\n\t<ProductAmount>{7}</ProductAmount>";
            parametersFormat += "\n\t<LoanDecisionNumber>{8}</LoanDecisionNumber>";
            parametersFormat += "\n\t<LoanDecisionDate>{9}</LoanDecisionDate>";
            parametersFormat += "\n\t<LoanDecisionNotes>{10}</LoanDecisionNotes>";
            parametersFormat += "\n\t<LoanDecisionLoanDecisionTypeName>{11}</LoanDecisionLoanDecisionTypeName>";
            parametersFormat += "\n\t<LoanDecisionIsPaidFromSalary>{12}</LoanDecisionIsPaidFromSalary>";
            parametersFormat += "\n\t<LoanDecisionReason>{13}</LoanDecisionReason>";
            parametersFormat += "\n\t<LoanType>{14}</LoanType>";
            parametersFormat += "\n\t<LoanGenerationStatusName>{15}</LoanGenerationStatusName>";
            parametersFormat += "\n\t<LoanStatusName>{16}</LoanStatusName>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(LoanVw loanVw)
        {
            return new string []
            {
				loanVw.ProductId.ToString(),
				loanVw.ProductEmployeeId.ToString(),
				loanVw.ProductEmployeeFullName,
				loanVw.ProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName,
				loanVw.ProductEmployeeCategoryName,
				loanVw.ProductProductTypeName == null ? string.Empty : loanVw.ProductProductTypeName,
				loanVw.ProductProductTypeRate == null ? string.Empty : loanVw.ProductProductTypeRate.Value.ToString(MoneyFormat),
				loanVw.ProductAmount.ToString(MoneyFormat),
				loanVw.LoanDecisionNumber.ToString(),
				loanVw.LoanDecisionDate.ToString(DateFormat),
				loanVw.LoanDecisionNotes == null ? string.Empty : loanVw.LoanDecisionNotes,
				loanVw.LoanDecisionLoanDecisionTypeName,
				loanVw.LoanDecisionIsPaidFromSalary == null ? string.Empty : loanVw.LoanDecisionIsPaidFromSalary.Value.ToString(),
				loanVw.LoanDecisionReason == null ? string.Empty : loanVw.LoanDecisionReason,
				loanVw.LoanType.ToString(),
				loanVw.LoanGenerationStatusName,
				loanVw.LoanStatusName
            };
        }
        
        private string [] GetParameters(Loan loan)
        {
            LoanVw loanVw = new LoanVw();
            loanVw.ProductId = loan.Product;
            loanVw.LoanType = loan.LoanType;
            return GetParameters(loanVw);
        }
    }
    #endregion

    #region LoanChangeVwXmlFormatter
    public class LoanChangeVwXmlFormatter : XmlFormatterBase
    {
        public LoanChangeVwXmlFormatter(LoanChangeVw loanChangeVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(loanChangeVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public LoanChangeVwXmlFormatter(LoanChange loanChange)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(loanChange);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<LoanProductId>{0}</LoanProductId>";
            parametersFormat += "\n\t<LoanProductEmployeeId>{1}</LoanProductEmployeeId>";
            parametersFormat += "\n\t<LoanProductEmployeeFullName>{2}</LoanProductEmployeeFullName>";
            parametersFormat += "\n\t<LoanProductEmployeeDepartmentName>{3}</LoanProductEmployeeDepartmentName>";
            parametersFormat += "\n\t<LoanProductEmployeeDepartmentSalaryWorkPlaceName>{4}</LoanProductEmployeeDepartmentSalaryWorkPlaceName>";
            parametersFormat += "\n\t<LoanProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>{5}</LoanProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<LoanProductEmployeeCategoryName>{6}</LoanProductEmployeeCategoryName>";
            parametersFormat += "\n\t<LoanProductProductTypeName>{7}</LoanProductProductTypeName>";
            parametersFormat += "\n\t<LoanProductProductTypeRate>{8}</LoanProductProductTypeRate>";
            parametersFormat += "\n\t<LoanProductProductTypeGuarantorsCount>{9}</LoanProductProductTypeGuarantorsCount>";
            parametersFormat += "\n\t<LoanProductProductTypePaymentGroupName>{10}</LoanProductProductTypePaymentGroupName>";
            parametersFormat += "\n\t<LoanProductAmount>{11}</LoanProductAmount>";
            parametersFormat += "\n\t<LoanLoanDecisionNumber>{12}</LoanLoanDecisionNumber>";
            parametersFormat += "\n\t<LoanLoanDecisionYear>{13}</LoanLoanDecisionYear>";
            parametersFormat += "\n\t<LoanLoanDecisionDate>{14}</LoanLoanDecisionDate>";
            parametersFormat += "\n\t<LoanLoanDecisionDeductionStartDate>{15}</LoanLoanDecisionDeductionStartDate>";
            parametersFormat += "\n\t<LoanLoanDecisionCersNumber>{16}</LoanLoanDecisionCersNumber>";
            parametersFormat += "\n\t<LoanLoanDecisionCersDate>{17}</LoanLoanDecisionCersDate>";
            parametersFormat += "\n\t<LoanLoanDecisionNotes>{18}</LoanLoanDecisionNotes>";
            parametersFormat += "\n\t<LoanLoanDecisionLoanDecisionTypeName>{19}</LoanLoanDecisionLoanDecisionTypeName>";
            parametersFormat += "\n\t<LoanLoanType>{20}</LoanLoanType>";
            parametersFormat += "\n\t<LoanLoanGenerationStatusName>{21}</LoanLoanGenerationStatusName>";
            parametersFormat += "\n\t<FromLoanProductEmployeeId>{22}</FromLoanProductEmployeeId>";
            parametersFormat += "\n\t<FromLoanProductEmployeeFullName>{23}</FromLoanProductEmployeeFullName>";
            parametersFormat += "\n\t<FromLoanLoanType>{24}</FromLoanLoanType>";
            parametersFormat += "\n\t<FromLoanLoanGenerationStatusName>{25}</FromLoanLoanGenerationStatusName>";
            parametersFormat += "\n\t<FromLoanLoanStatusName>{26}</FromLoanLoanStatusName>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(LoanChangeVw loanChangeVw)
        {
            return new string []
            {
				loanChangeVw.LoanProductId.ToString(),
				loanChangeVw.LoanProductEmployeeId.ToString(),
				loanChangeVw.LoanProductEmployeeFullName,
				loanChangeVw.LoanProductEmployeeDepartmentName,
				loanChangeVw.LoanProductEmployeeDepartmentSalaryWorkPlaceName,
				loanChangeVw.LoanProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName,
				loanChangeVw.LoanProductEmployeeCategoryName,
				loanChangeVw.LoanProductProductTypeName == null ? string.Empty : loanChangeVw.LoanProductProductTypeName,
				loanChangeVw.LoanProductProductTypeRate == null ? string.Empty : loanChangeVw.LoanProductProductTypeRate.Value.ToString(MoneyFormat),
				loanChangeVw.LoanProductProductTypeGuarantorsCount.ToString(),
				loanChangeVw.LoanProductProductTypePaymentGroupName == null ? string.Empty : loanChangeVw.LoanProductProductTypePaymentGroupName,
				loanChangeVw.LoanProductAmount.ToString(MoneyFormat),
				loanChangeVw.LoanLoanDecisionNumber.ToString(),
				loanChangeVw.LoanLoanDecisionYear.ToString(),
				loanChangeVw.LoanLoanDecisionDate.ToString(DateFormat),
				loanChangeVw.LoanLoanDecisionDeductionStartDate.ToString(DateFormat),
				loanChangeVw.LoanLoanDecisionCersNumber == null ? string.Empty : loanChangeVw.LoanLoanDecisionCersNumber,
				loanChangeVw.LoanLoanDecisionCersDate == null ? string.Empty : loanChangeVw.LoanLoanDecisionCersDate.Value.ToString(DateFormat),
				loanChangeVw.LoanLoanDecisionNotes == null ? string.Empty : loanChangeVw.LoanLoanDecisionNotes,
				loanChangeVw.LoanLoanDecisionLoanDecisionTypeName,
				loanChangeVw.LoanLoanType.ToString(),
				loanChangeVw.LoanLoanGenerationStatusName,
				loanChangeVw.FromLoanProductEmployeeId.ToString(),
				loanChangeVw.FromLoanProductEmployeeFullName,
				loanChangeVw.FromLoanLoanType.ToString(),
				loanChangeVw.FromLoanLoanGenerationStatusName,
				loanChangeVw.FromLoanLoanStatusName
            };
        }
        
        private string [] GetParameters(LoanChange loanChange)
        {
            LoanChangeVw loanChangeVw = new LoanChangeVw();
            loanChangeVw.LoanProductId = loanChange.Loan;
            return GetParameters(loanChangeVw);
        }
    }
    #endregion

    #region LoanDecisionVwXmlFormatter
    public class LoanDecisionVwXmlFormatter : XmlFormatterBase
    {
        public LoanDecisionVwXmlFormatter(LoanDecisionVw loanDecisionVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(loanDecisionVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public LoanDecisionVwXmlFormatter(LoanDecision loanDecision)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(loanDecision);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<Number>{1}</Number>";
            parametersFormat += "\n\t<Year>{2}</Year>";
            parametersFormat += "\n\t<Date>{3}</Date>";
            parametersFormat += "\n\t<DeductionStartDate>{4}</DeductionStartDate>";
            parametersFormat += "\n\t<CersNumber>{5}</CersNumber>";
            parametersFormat += "\n\t<CersDate>{6}</CersDate>";
            parametersFormat += "\n\t<Notes>{7}</Notes>";
            parametersFormat += "\n\t<LoanDecisionTypeName>{8}</LoanDecisionTypeName>";
            parametersFormat += "\n\t<PaymentNumber>{9}</PaymentNumber>";
            parametersFormat += "\n\t<PaymentDate>{10}</PaymentDate>";
            parametersFormat += "\n\t<IsPaidFromSalary>{11}</IsPaidFromSalary>";
            parametersFormat += "\n\t<Reason>{12}</Reason>";
            parametersFormat += "\n\t<AdditionalClause>{13}</AdditionalClause>";
            parametersFormat += "\n\t<AdditionalIntroduction>{14}</AdditionalIntroduction>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(LoanDecisionVw loanDecisionVw)
        {
            return new string []
            {
				loanDecisionVw.Id.ToString(),
				loanDecisionVw.Number.ToString(),
				loanDecisionVw.Year.ToString(),
				loanDecisionVw.Date.ToString(DateFormat),
				loanDecisionVw.DeductionStartDate.ToString(DateFormat),
				loanDecisionVw.CersNumber == null ? string.Empty : loanDecisionVw.CersNumber,
				loanDecisionVw.CersDate == null ? string.Empty : loanDecisionVw.CersDate.Value.ToString(DateFormat),
				loanDecisionVw.Notes == null ? string.Empty : loanDecisionVw.Notes,
				loanDecisionVw.LoanDecisionTypeName,
				loanDecisionVw.PaymentNumber == null ? string.Empty : loanDecisionVw.PaymentNumber,
				loanDecisionVw.PaymentDate == null ? string.Empty : loanDecisionVw.PaymentDate.Value.ToString(DateFormat),
				loanDecisionVw.IsPaidFromSalary == null ? string.Empty : loanDecisionVw.IsPaidFromSalary.Value.ToString(),
				loanDecisionVw.Reason == null ? string.Empty : loanDecisionVw.Reason,
				loanDecisionVw.AdditionalClause == null ? string.Empty : loanDecisionVw.AdditionalClause,
				loanDecisionVw.AdditionalIntroduction == null ? string.Empty : loanDecisionVw.AdditionalIntroduction
            };
        }
        
        private string [] GetParameters(LoanDecision loanDecision)
        {
            LoanDecisionVw loanDecisionVw = new LoanDecisionVw();
            loanDecisionVw.Id = loanDecision.Id;
            loanDecisionVw.Number = loanDecision.Number;
            loanDecisionVw.Year = loanDecision.Year;
            loanDecisionVw.Date = loanDecision.Date;
            loanDecisionVw.DeductionStartDate = loanDecision.DeductionStartDate;
            loanDecisionVw.CersNumber = loanDecision.CersNumber;
            loanDecisionVw.CersDate = loanDecision.CersDate;
            loanDecisionVw.Notes = loanDecision.Notes;
            loanDecisionVw.PaymentNumber = loanDecision.PaymentNumber;
            loanDecisionVw.PaymentDate = loanDecision.PaymentDate;
            loanDecisionVw.IsPaidFromSalary = loanDecision.IsPaidFromSalary;
            loanDecisionVw.Reason = loanDecision.Reason;
            loanDecisionVw.AdditionalClause = loanDecision.AdditionalClause;
            loanDecisionVw.AdditionalIntroduction = loanDecision.AdditionalIntroduction;
            return GetParameters(loanDecisionVw);
        }
    }
    #endregion

    #region LoanDecisionTypeVwXmlFormatter
    public class LoanDecisionTypeVwXmlFormatter : XmlFormatterBase
    {
        public LoanDecisionTypeVwXmlFormatter(LoanDecisionTypeVw loanDecisionTypeVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(loanDecisionTypeVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public LoanDecisionTypeVwXmlFormatter(LoanDecisionType loanDecisionType)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(loanDecisionType);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<Name>{1}</Name>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(LoanDecisionTypeVw loanDecisionTypeVw)
        {
            return new string []
            {
				loanDecisionTypeVw.Id.ToString(),
				loanDecisionTypeVw.Name
            };
        }
        
        private string [] GetParameters(LoanDecisionType loanDecisionType)
        {
            LoanDecisionTypeVw loanDecisionTypeVw = new LoanDecisionTypeVw();
            loanDecisionTypeVw.Id = loanDecisionType.Id;
            loanDecisionTypeVw.Name = loanDecisionType.Name;
            return GetParameters(loanDecisionTypeVw);
        }
    }
    #endregion

    #region LoanGenerationStatusVwXmlFormatter
    public class LoanGenerationStatusVwXmlFormatter : XmlFormatterBase
    {
        public LoanGenerationStatusVwXmlFormatter(LoanGenerationStatusVw loanGenerationStatusVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(loanGenerationStatusVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public LoanGenerationStatusVwXmlFormatter(LoanGenerationStatus loanGenerationStatus)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(loanGenerationStatus);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<Name>{1}</Name>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(LoanGenerationStatusVw loanGenerationStatusVw)
        {
            return new string []
            {
				loanGenerationStatusVw.Id.ToString(),
				loanGenerationStatusVw.Name
            };
        }
        
        private string [] GetParameters(LoanGenerationStatus loanGenerationStatus)
        {
            LoanGenerationStatusVw loanGenerationStatusVw = new LoanGenerationStatusVw();
            loanGenerationStatusVw.Id = loanGenerationStatus.Id;
            loanGenerationStatusVw.Name = loanGenerationStatus.Name;
            return GetParameters(loanGenerationStatusVw);
        }
    }
    #endregion

    #region LoanRequestVwXmlFormatter
    public class LoanRequestVwXmlFormatter : XmlFormatterBase
    {
        public LoanRequestVwXmlFormatter(LoanRequestVw loanRequestVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(loanRequestVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public LoanRequestVwXmlFormatter(LoanRequest loanRequest)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(loanRequest);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<RequestProductId>{0}</RequestProductId>";
            parametersFormat += "\n\t<RequestProductEmployeeId>{1}</RequestProductEmployeeId>";
            parametersFormat += "\n\t<RequestProductEmployeeFullName>{2}</RequestProductEmployeeFullName>";
            parametersFormat += "\n\t<RequestProductEmployeeDepartmentName>{3}</RequestProductEmployeeDepartmentName>";
            parametersFormat += "\n\t<RequestProductEmployeeDepartmentSalaryWorkPlaceName>{4}</RequestProductEmployeeDepartmentSalaryWorkPlaceName>";
            parametersFormat += "\n\t<RequestProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>{5}</RequestProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<RequestProductEmployeeCategoryName>{6}</RequestProductEmployeeCategoryName>";
            parametersFormat += "\n\t<RequestProductProductTypeName>{7}</RequestProductProductTypeName>";
            parametersFormat += "\n\t<RequestProductProductTypeRate>{8}</RequestProductProductTypeRate>";
            parametersFormat += "\n\t<RequestProductProductTypeGuarantorsCount>{9}</RequestProductProductTypeGuarantorsCount>";
            parametersFormat += "\n\t<RequestProductProductTypePaymentGroupName>{10}</RequestProductProductTypePaymentGroupName>";
            parametersFormat += "\n\t<RequestDate>{11}</RequestDate>";
            parametersFormat += "\n\t<RequestAmount>{12}</RequestAmount>";
            parametersFormat += "\n\t<RequestRequestStatusName>{13}</RequestRequestStatusName>";
            parametersFormat += "\n\t<RequestNotes>{14}</RequestNotes>";
            parametersFormat += "\n\t<NetIncome>{15}</NetIncome>";
            parametersFormat += "\n\t<TotalDeduction>{16}</TotalDeduction>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(LoanRequestVw loanRequestVw)
        {
            return new string []
            {
				loanRequestVw.RequestProductId.ToString(),
				loanRequestVw.RequestProductEmployeeId.ToString(),
				loanRequestVw.RequestProductEmployeeFullName,
				loanRequestVw.RequestProductEmployeeDepartmentName,
				loanRequestVw.RequestProductEmployeeDepartmentSalaryWorkPlaceName,
				loanRequestVw.RequestProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName,
				loanRequestVw.RequestProductEmployeeCategoryName,
				loanRequestVw.RequestProductProductTypeName == null ? string.Empty : loanRequestVw.RequestProductProductTypeName,
				loanRequestVw.RequestProductProductTypeRate == null ? string.Empty : loanRequestVw.RequestProductProductTypeRate.Value.ToString(MoneyFormat),
				loanRequestVw.RequestProductProductTypeGuarantorsCount.ToString(),
				loanRequestVw.RequestProductProductTypePaymentGroupName == null ? string.Empty : loanRequestVw.RequestProductProductTypePaymentGroupName,
				loanRequestVw.RequestDate.ToString(DateFormat),
				loanRequestVw.RequestAmount.ToString(MoneyFormat),
				loanRequestVw.RequestRequestStatusName == null ? string.Empty : loanRequestVw.RequestRequestStatusName,
				loanRequestVw.RequestNotes == null ? string.Empty : loanRequestVw.RequestNotes,
				loanRequestVw.NetIncome.ToString(MoneyFormat),
				loanRequestVw.TotalDeduction.ToString(MoneyFormat)
            };
        }
        
        private string [] GetParameters(LoanRequest loanRequest)
        {
            LoanRequestVw loanRequestVw = new LoanRequestVw();
            loanRequestVw.RequestProductId = loanRequest.Request;
            loanRequestVw.NetIncome = loanRequest.NetIncome;
            loanRequestVw.TotalDeduction = loanRequest.TotalDeduction;
            return GetParameters(loanRequestVw);
        }
    }
    #endregion

    #region LoanStatusVwXmlFormatter
    public class LoanStatusVwXmlFormatter : XmlFormatterBase
    {
        public LoanStatusVwXmlFormatter(LoanStatusVw loanStatusVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(loanStatusVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public LoanStatusVwXmlFormatter(LoanStatus loanStatus)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(loanStatus);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<Name>{1}</Name>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(LoanStatusVw loanStatusVw)
        {
            return new string []
            {
				loanStatusVw.Id.ToString(),
				loanStatusVw.Name
            };
        }
        
        private string [] GetParameters(LoanStatus loanStatus)
        {
            LoanStatusVw loanStatusVw = new LoanStatusVw();
            loanStatusVw.Id = loanStatus.Id;
            loanStatusVw.Name = loanStatus.Name;
            return GetParameters(loanStatusVw);
        }
    }
    #endregion

    #region LoanTypeVwXmlFormatter
    public class LoanTypeVwXmlFormatter : XmlFormatterBase
    {
        public LoanTypeVwXmlFormatter(LoanTypeVw loanTypeVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(loanTypeVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public LoanTypeVwXmlFormatter(LoanType loanType)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(loanType);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<ProductTypeId>{0}</ProductTypeId>";
            parametersFormat += "\n\t<ProductTypeName>{1}</ProductTypeName>";
            parametersFormat += "\n\t<ProductTypeRate>{2}</ProductTypeRate>";
            parametersFormat += "\n\t<ProductTypeGuarantorsCount>{3}</ProductTypeGuarantorsCount>";
            parametersFormat += "\n\t<ProductTypePrintLabel>{4}</ProductTypePrintLabel>";
            parametersFormat += "\n\t<ProductTypeProfitStrategyName>{5}</ProductTypeProfitStrategyName>";
            parametersFormat += "\n\t<ProductTypePaymentGroupName>{6}</ProductTypePaymentGroupName>";
            parametersFormat += "\n\t<ProductTypeIsActive>{7}</ProductTypeIsActive>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(LoanTypeVw loanTypeVw)
        {
            return new string []
            {
				loanTypeVw.ProductTypeId.ToString(),
				loanTypeVw.ProductTypeName == null ? string.Empty : loanTypeVw.ProductTypeName,
				loanTypeVw.ProductTypeRate == null ? string.Empty : loanTypeVw.ProductTypeRate.Value.ToString(MoneyFormat),
				loanTypeVw.ProductTypeGuarantorsCount.ToString(),
				loanTypeVw.ProductTypePrintLabel == null ? string.Empty : loanTypeVw.ProductTypePrintLabel,
				loanTypeVw.ProductTypeProfitStrategyName == null ? string.Empty : loanTypeVw.ProductTypeProfitStrategyName,
				loanTypeVw.ProductTypePaymentGroupName == null ? string.Empty : loanTypeVw.ProductTypePaymentGroupName,
				loanTypeVw.ProductTypeIsActive == null ? string.Empty : loanTypeVw.ProductTypeIsActive.Value.ToString()
            };
        }
        
        private string [] GetParameters(LoanType loanType)
        {
            LoanTypeVw loanTypeVw = new LoanTypeVw();
            loanTypeVw.ProductTypeId = loanType.ProductType;
            return GetParameters(loanTypeVw);
        }
    }
    #endregion

    #region LoanTypeClosureVwXmlFormatter
    public class LoanTypeClosureVwXmlFormatter : XmlFormatterBase
    {
        public LoanTypeClosureVwXmlFormatter(LoanTypeClosureVw loanTypeClosureVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(loanTypeClosureVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public LoanTypeClosureVwXmlFormatter(LoanTypeClosure loanTypeClosure)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(loanTypeClosure);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<LoanTypeProductTypeName>{1}</LoanTypeProductTypeName>";
            parametersFormat += "\n\t<LoanTypeProductTypeRate>{2}</LoanTypeProductTypeRate>";
            parametersFormat += "\n\t<LoanTypeProductTypeGuarantorsCount>{3}</LoanTypeProductTypeGuarantorsCount>";
            parametersFormat += "\n\t<LoanTypeProductTypePaymentGroupName>{4}</LoanTypeProductTypePaymentGroupName>";
            parametersFormat += "\n\t<LoanTypeProductTypeIsActive>{5}</LoanTypeProductTypeIsActive>";
            parametersFormat += "\n\t<ClosingLoanTypeProductTypeName>{6}</ClosingLoanTypeProductTypeName>";
            parametersFormat += "\n\t<ClosingLoanTypeProductTypeRate>{7}</ClosingLoanTypeProductTypeRate>";
            parametersFormat += "\n\t<ClosingLoanTypeProductTypeGuarantorsCount>{8}</ClosingLoanTypeProductTypeGuarantorsCount>";
            parametersFormat += "\n\t<ClosingLoanTypeProductTypePaymentGroupName>{9}</ClosingLoanTypeProductTypePaymentGroupName>";
            parametersFormat += "\n\t<ClosingLoanTypeProductTypeIsActive>{10}</ClosingLoanTypeProductTypeIsActive>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(LoanTypeClosureVw loanTypeClosureVw)
        {
            return new string []
            {
				loanTypeClosureVw.Id.ToString(),
				loanTypeClosureVw.LoanTypeProductTypeName == null ? string.Empty : loanTypeClosureVw.LoanTypeProductTypeName,
				loanTypeClosureVw.LoanTypeProductTypeRate == null ? string.Empty : loanTypeClosureVw.LoanTypeProductTypeRate.Value.ToString(MoneyFormat),
				loanTypeClosureVw.LoanTypeProductTypeGuarantorsCount.ToString(),
				loanTypeClosureVw.LoanTypeProductTypePaymentGroupName == null ? string.Empty : loanTypeClosureVw.LoanTypeProductTypePaymentGroupName,
				loanTypeClosureVw.LoanTypeProductTypeIsActive == null ? string.Empty : loanTypeClosureVw.LoanTypeProductTypeIsActive.Value.ToString(),
				loanTypeClosureVw.ClosingLoanTypeProductTypeName == null ? string.Empty : loanTypeClosureVw.ClosingLoanTypeProductTypeName,
				loanTypeClosureVw.ClosingLoanTypeProductTypeRate == null ? string.Empty : loanTypeClosureVw.ClosingLoanTypeProductTypeRate.Value.ToString(MoneyFormat),
				loanTypeClosureVw.ClosingLoanTypeProductTypeGuarantorsCount.ToString(),
				loanTypeClosureVw.ClosingLoanTypeProductTypePaymentGroupName == null ? string.Empty : loanTypeClosureVw.ClosingLoanTypeProductTypePaymentGroupName,
				loanTypeClosureVw.ClosingLoanTypeProductTypeIsActive == null ? string.Empty : loanTypeClosureVw.ClosingLoanTypeProductTypeIsActive.Value.ToString()
            };
        }
        
        private string [] GetParameters(LoanTypeClosure loanTypeClosure)
        {
            LoanTypeClosureVw loanTypeClosureVw = new LoanTypeClosureVw();
            loanTypeClosureVw.Id = loanTypeClosure.Id;
            return GetParameters(loanTypeClosureVw);
        }
    }
    #endregion

    #region MainWorkPlaceVwXmlFormatter
    public class MainWorkPlaceVwXmlFormatter : XmlFormatterBase
    {
        public MainWorkPlaceVwXmlFormatter(MainWorkPlaceVw mainWorkPlaceVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(mainWorkPlaceVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public MainWorkPlaceVwXmlFormatter(MainWorkPlace mainWorkPlace)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(mainWorkPlace);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<Name>{1}</Name>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(MainWorkPlaceVw mainWorkPlaceVw)
        {
            return new string []
            {
				mainWorkPlaceVw.Id.ToString(),
				mainWorkPlaceVw.Name
            };
        }
        
        private string [] GetParameters(MainWorkPlace mainWorkPlace)
        {
            MainWorkPlaceVw mainWorkPlaceVw = new MainWorkPlaceVw();
            mainWorkPlaceVw.Id = mainWorkPlace.Id;
            mainWorkPlaceVw.Name = mainWorkPlace.Name;
            return GetParameters(mainWorkPlaceVw);
        }
    }
    #endregion

    #region MissingInstallmentDecreaseVwXmlFormatter
    public class MissingInstallmentDecreaseVwXmlFormatter : XmlFormatterBase
    {
        public MissingInstallmentDecreaseVwXmlFormatter(MissingInstallmentDecreaseVw missingInstallmentDecreaseVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(missingInstallmentDecreaseVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public MissingInstallmentDecreaseVwXmlFormatter(MissingInstallmentDecrease missingInstallmentDecrease)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(missingInstallmentDecrease);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<EmployeeId>{0}</EmployeeId>";
            parametersFormat += "\n\t<EmployeeFullName>{1}</EmployeeFullName>";
            parametersFormat += "\n\t<EmployeeDepartmentName>{2}</EmployeeDepartmentName>";
            parametersFormat += "\n\t<EmployeeDepartmentSalaryWorkPlaceName>{3}</EmployeeDepartmentSalaryWorkPlaceName>";
            parametersFormat += "\n\t<EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>{4}</EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<EmployeeCategoryName>{5}</EmployeeCategoryName>";
            parametersFormat += "\n\t<SalaryAmount>{6}</SalaryAmount>";
            parametersFormat += "\n\t<TransferMonth>{7}</TransferMonth>";
            parametersFormat += "\n\t<FinishedInstallmentsAmount>{8}</FinishedInstallmentsAmount>";
            parametersFormat += "\n\t<RemainingInstallmentsAmount>{9}</RemainingInstallmentsAmount>";
            parametersFormat += "\n\t<Notes>{10}</Notes>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(MissingInstallmentDecreaseVw missingInstallmentDecreaseVw)
        {
            return new string []
            {
				missingInstallmentDecreaseVw.EmployeeId.ToString(),
				missingInstallmentDecreaseVw.EmployeeFullName,
				missingInstallmentDecreaseVw.EmployeeDepartmentName,
				missingInstallmentDecreaseVw.EmployeeDepartmentSalaryWorkPlaceName,
				missingInstallmentDecreaseVw.EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName,
				missingInstallmentDecreaseVw.EmployeeCategoryName,
				missingInstallmentDecreaseVw.SalaryAmount.ToString(MoneyFormat),
				missingInstallmentDecreaseVw.TransferMonth.ToString(DateFormat),
				missingInstallmentDecreaseVw.FinishedInstallmentsAmount.ToString(MoneyFormat),
				missingInstallmentDecreaseVw.RemainingInstallmentsAmount.ToString(MoneyFormat),
				missingInstallmentDecreaseVw.Notes == null ? string.Empty : missingInstallmentDecreaseVw.Notes
            };
        }
        
        private string [] GetParameters(MissingInstallmentDecrease missingInstallmentDecrease)
        {
            MissingInstallmentDecreaseVw missingInstallmentDecreaseVw = new MissingInstallmentDecreaseVw();
            missingInstallmentDecreaseVw.EmployeeId = missingInstallmentDecrease.Employee;
            missingInstallmentDecreaseVw.SalaryAmount = missingInstallmentDecrease.SalaryAmount;
            missingInstallmentDecreaseVw.TransferMonth = missingInstallmentDecrease.TransferMonth;
            missingInstallmentDecreaseVw.FinishedInstallmentsAmount = missingInstallmentDecrease.FinishedInstallmentsAmount;
            missingInstallmentDecreaseVw.RemainingInstallmentsAmount = missingInstallmentDecrease.RemainingInstallmentsAmount;
            missingInstallmentDecreaseVw.Notes = missingInstallmentDecrease.Notes;
            return GetParameters(missingInstallmentDecreaseVw);
        }
    }
    #endregion

    #region MonthlyBalanceVwXmlFormatter
    public class MonthlyBalanceVwXmlFormatter : XmlFormatterBase
    {
        public MonthlyBalanceVwXmlFormatter(MonthlyBalanceVw monthlyBalanceVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(monthlyBalanceVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public MonthlyBalanceVwXmlFormatter(MonthlyBalance monthlyBalance)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(monthlyBalance);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<EmployeeId>{1}</EmployeeId>";
            parametersFormat += "\n\t<EmployeeFullName>{2}</EmployeeFullName>";
            parametersFormat += "\n\t<EmployeeDepartmentName>{3}</EmployeeDepartmentName>";
            parametersFormat += "\n\t<EmployeeDepartmentSalaryWorkPlaceName>{4}</EmployeeDepartmentSalaryWorkPlaceName>";
            parametersFormat += "\n\t<EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>{5}</EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<EmployeeCategoryName>{6}</EmployeeCategoryName>";
            parametersFormat += "\n\t<PaymentGroupName>{7}</PaymentGroupName>";
            parametersFormat += "\n\t<Month>{8}</Month>";
            parametersFormat += "\n\t<Opening>{9}</Opening>";
            parametersFormat += "\n\t<NormalLoans>{10}</NormalLoans>";
            parametersFormat += "\n\t<IncomingLoans>{11}</IncomingLoans>";
            parametersFormat += "\n\t<Restitution>{12}</Restitution>";
            parametersFormat += "\n\t<OutgoingLoans>{13}</OutgoingLoans>";
            parametersFormat += "\n\t<SalaryPayment>{14}</SalaryPayment>";
            parametersFormat += "\n\t<CashPayment>{15}</CashPayment>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(MonthlyBalanceVw monthlyBalanceVw)
        {
            return new string []
            {
				monthlyBalanceVw.Id.ToString(),
				monthlyBalanceVw.EmployeeId.ToString(),
				monthlyBalanceVw.EmployeeFullName,
				monthlyBalanceVw.EmployeeDepartmentName,
				monthlyBalanceVw.EmployeeDepartmentSalaryWorkPlaceName,
				monthlyBalanceVw.EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName,
				monthlyBalanceVw.EmployeeCategoryName,
				monthlyBalanceVw.PaymentGroupName,
				monthlyBalanceVw.Month.ToString(DateFormat),
				monthlyBalanceVw.Opening.ToString(MoneyFormat),
				monthlyBalanceVw.NormalLoans.ToString(MoneyFormat),
				monthlyBalanceVw.IncomingLoans.ToString(MoneyFormat),
				monthlyBalanceVw.Restitution.ToString(MoneyFormat),
				monthlyBalanceVw.OutgoingLoans.ToString(MoneyFormat),
				monthlyBalanceVw.SalaryPayment.ToString(MoneyFormat),
				monthlyBalanceVw.CashPayment.ToString(MoneyFormat)
            };
        }
        
        private string [] GetParameters(MonthlyBalance monthlyBalance)
        {
            MonthlyBalanceVw monthlyBalanceVw = new MonthlyBalanceVw();
            monthlyBalanceVw.Id = monthlyBalance.Id;
            monthlyBalanceVw.EmployeeId = monthlyBalance.Employee;
            monthlyBalanceVw.Month = monthlyBalance.Month;
            monthlyBalanceVw.Opening = monthlyBalance.Opening;
            monthlyBalanceVw.NormalLoans = monthlyBalance.NormalLoans;
            monthlyBalanceVw.IncomingLoans = monthlyBalance.IncomingLoans;
            monthlyBalanceVw.Restitution = monthlyBalance.Restitution;
            monthlyBalanceVw.OutgoingLoans = monthlyBalance.OutgoingLoans;
            monthlyBalanceVw.SalaryPayment = monthlyBalance.SalaryPayment;
            monthlyBalanceVw.CashPayment = monthlyBalance.CashPayment;
            return GetParameters(monthlyBalanceVw);
        }
    }
    #endregion

    #region OutgoingLoanVwXmlFormatter
    public class OutgoingLoanVwXmlFormatter : XmlFormatterBase
    {
        public OutgoingLoanVwXmlFormatter(OutgoingLoanVw outgoingLoanVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(outgoingLoanVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public OutgoingLoanVwXmlFormatter(OutgoingLoan outgoingLoan)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(outgoingLoan);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<LoanProductId>{0}</LoanProductId>";
            parametersFormat += "\n\t<LoanProductEmployeeId>{1}</LoanProductEmployeeId>";
            parametersFormat += "\n\t<LoanProductEmployeeFullName>{2}</LoanProductEmployeeFullName>";
            parametersFormat += "\n\t<LoanProductEmployeeDepartmentName>{3}</LoanProductEmployeeDepartmentName>";
            parametersFormat += "\n\t<LoanProductEmployeeDepartmentSalaryWorkPlaceName>{4}</LoanProductEmployeeDepartmentSalaryWorkPlaceName>";
            parametersFormat += "\n\t<LoanProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>{5}</LoanProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<LoanProductEmployeeCategoryName>{6}</LoanProductEmployeeCategoryName>";
            parametersFormat += "\n\t<LoanProductProductTypeName>{7}</LoanProductProductTypeName>";
            parametersFormat += "\n\t<LoanProductProductTypeRate>{8}</LoanProductProductTypeRate>";
            parametersFormat += "\n\t<LoanProductAmount>{9}</LoanProductAmount>";
            parametersFormat += "\n\t<LoanProductNotes>{10}</LoanProductNotes>";
            parametersFormat += "\n\t<LoanLoanDecisionNumber>{11}</LoanLoanDecisionNumber>";
            parametersFormat += "\n\t<LoanLoanDecisionYear>{12}</LoanLoanDecisionYear>";
            parametersFormat += "\n\t<LoanLoanDecisionDate>{13}</LoanLoanDecisionDate>";
            parametersFormat += "\n\t<LoanLoanDecisionLoanDecisionTypeName>{14}</LoanLoanDecisionLoanDecisionTypeName>";
            parametersFormat += "\n\t<LoanLoanDecisionIsPaidFromSalary>{15}</LoanLoanDecisionIsPaidFromSalary>";
            parametersFormat += "\n\t<LoanLoanDecisionReason>{16}</LoanLoanDecisionReason>";
            parametersFormat += "\n\t<LoanLoanGenerationStatusName>{17}</LoanLoanGenerationStatusName>";
            parametersFormat += "\n\t<LoanLoanStatusName>{18}</LoanLoanStatusName>";
            parametersFormat += "\n\t<LoanDecisionNumber>{19}</LoanDecisionNumber>";
            parametersFormat += "\n\t<LoanDecisionYear>{20}</LoanDecisionYear>";
            parametersFormat += "\n\t<LoanDecisionDate>{21}</LoanDecisionDate>";
            parametersFormat += "\n\t<LoanDecisionNotes>{22}</LoanDecisionNotes>";
            parametersFormat += "\n\t<LoanDecisionIsPaidFromSalary>{23}</LoanDecisionIsPaidFromSalary>";
            parametersFormat += "\n\t<MainWorkPlaceName>{24}</MainWorkPlaceName>";
            parametersFormat += "\n\t<ApprovedAmount>{25}</ApprovedAmount>";
            parametersFormat += "\n\t<NetAmount>{26}</NetAmount>";
            parametersFormat += "\n\t<ProfitAmount>{27}</ProfitAmount>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(OutgoingLoanVw outgoingLoanVw)
        {
            return new string []
            {
				outgoingLoanVw.LoanProductId.ToString(),
				outgoingLoanVw.LoanProductEmployeeId.ToString(),
				outgoingLoanVw.LoanProductEmployeeFullName,
				outgoingLoanVw.LoanProductEmployeeDepartmentName,
				outgoingLoanVw.LoanProductEmployeeDepartmentSalaryWorkPlaceName,
				outgoingLoanVw.LoanProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName,
				outgoingLoanVw.LoanProductEmployeeCategoryName,
				outgoingLoanVw.LoanProductProductTypeName == null ? string.Empty : outgoingLoanVw.LoanProductProductTypeName,
				outgoingLoanVw.LoanProductProductTypeRate == null ? string.Empty : outgoingLoanVw.LoanProductProductTypeRate.Value.ToString(MoneyFormat),
				outgoingLoanVw.LoanProductAmount.ToString(MoneyFormat),
				outgoingLoanVw.LoanProductNotes == null ? string.Empty : outgoingLoanVw.LoanProductNotes,
				outgoingLoanVw.LoanLoanDecisionNumber.ToString(),
				outgoingLoanVw.LoanLoanDecisionYear.ToString(),
				outgoingLoanVw.LoanLoanDecisionDate.ToString(DateFormat),
				outgoingLoanVw.LoanLoanDecisionLoanDecisionTypeName,
				outgoingLoanVw.LoanLoanDecisionIsPaidFromSalary == null ? string.Empty : outgoingLoanVw.LoanLoanDecisionIsPaidFromSalary.Value.ToString(),
				outgoingLoanVw.LoanLoanDecisionReason == null ? string.Empty : outgoingLoanVw.LoanLoanDecisionReason,
				outgoingLoanVw.LoanLoanGenerationStatusName,
				outgoingLoanVw.LoanLoanStatusName,
				outgoingLoanVw.LoanDecisionNumber.ToString(),
				outgoingLoanVw.LoanDecisionYear.ToString(),
				outgoingLoanVw.LoanDecisionDate.ToString(DateFormat),
				outgoingLoanVw.LoanDecisionNotes == null ? string.Empty : outgoingLoanVw.LoanDecisionNotes,
				outgoingLoanVw.LoanDecisionIsPaidFromSalary == null ? string.Empty : outgoingLoanVw.LoanDecisionIsPaidFromSalary.Value.ToString(),
				outgoingLoanVw.MainWorkPlaceName,
				outgoingLoanVw.ApprovedAmount.ToString(MoneyFormat),
				outgoingLoanVw.NetAmount.ToString(MoneyFormat),
				outgoingLoanVw.ProfitAmount.ToString(MoneyFormat)
            };
        }
        
        private string [] GetParameters(OutgoingLoan outgoingLoan)
        {
            OutgoingLoanVw outgoingLoanVw = new OutgoingLoanVw();
            outgoingLoanVw.LoanProductId = outgoingLoan.Loan;
            outgoingLoanVw.ApprovedAmount = outgoingLoan.ApprovedAmount;
            outgoingLoanVw.NetAmount = outgoingLoan.NetAmount;
            outgoingLoanVw.ProfitAmount = outgoingLoan.ProfitAmount;
            return GetParameters(outgoingLoanVw);
        }
    }
    #endregion

    #region PaymentVwXmlFormatter
    public class PaymentVwXmlFormatter : XmlFormatterBase
    {
        public PaymentVwXmlFormatter(PaymentVw paymentVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(paymentVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public PaymentVwXmlFormatter(Payment payment)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(payment);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<EmployeeId>{1}</EmployeeId>";
            parametersFormat += "\n\t<EmployeeFullName>{2}</EmployeeFullName>";
            parametersFormat += "\n\t<EmployeeDepartmentName>{3}</EmployeeDepartmentName>";
            parametersFormat += "\n\t<EmployeeDepartmentSalaryWorkPlaceName>{4}</EmployeeDepartmentSalaryWorkPlaceName>";
            parametersFormat += "\n\t<EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>{5}</EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<EmployeeCategoryName>{6}</EmployeeCategoryName>";
            parametersFormat += "\n\t<Date>{7}</Date>";
            parametersFormat += "\n\t<PaymentGroupName>{8}</PaymentGroupName>";
            parametersFormat += "\n\t<Amount>{9}</Amount>";
            parametersFormat += "\n\t<PaymentStatusName>{10}</PaymentStatusName>";
            parametersFormat += "\n\t<CollectOrderNumber>{11}</CollectOrderNumber>";
            parametersFormat += "\n\t<CollectOrderDate>{12}</CollectOrderDate>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(PaymentVw paymentVw)
        {
            return new string []
            {
				paymentVw.Id.ToString(),
				paymentVw.EmployeeId.ToString(),
				paymentVw.EmployeeFullName,
				paymentVw.EmployeeDepartmentName,
				paymentVw.EmployeeDepartmentSalaryWorkPlaceName,
				paymentVw.EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName,
				paymentVw.EmployeeCategoryName,
				paymentVw.Date.ToString(DateFormat),
				paymentVw.PaymentGroupName,
				paymentVw.Amount == null ? string.Empty : paymentVw.Amount.Value.ToString(MoneyFormat),
				paymentVw.PaymentStatusName == null ? string.Empty : paymentVw.PaymentStatusName,
				paymentVw.CollectOrderNumber == null ? string.Empty : paymentVw.CollectOrderNumber.Value.ToString(),
				paymentVw.CollectOrderDate == null ? string.Empty : paymentVw.CollectOrderDate.Value.ToString(DateFormat)
            };
        }
        
        private string [] GetParameters(Payment payment)
        {
            PaymentVw paymentVw = new PaymentVw();
            paymentVw.Id = payment.Id;
            paymentVw.EmployeeId = payment.Employee;
            paymentVw.Date = payment.Date;
            paymentVw.Amount = payment.Amount;
            return GetParameters(paymentVw);
        }
    }
    #endregion

    #region PaymentGroupVwXmlFormatter
    public class PaymentGroupVwXmlFormatter : XmlFormatterBase
    {
        public PaymentGroupVwXmlFormatter(PaymentGroupVw paymentGroupVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(paymentGroupVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public PaymentGroupVwXmlFormatter(PaymentGroup paymentGroup)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(paymentGroup);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<Name>{1}</Name>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(PaymentGroupVw paymentGroupVw)
        {
            return new string []
            {
				paymentGroupVw.Id.ToString(),
				paymentGroupVw.Name
            };
        }
        
        private string [] GetParameters(PaymentGroup paymentGroup)
        {
            PaymentGroupVw paymentGroupVw = new PaymentGroupVw();
            paymentGroupVw.Id = paymentGroup.Id;
            paymentGroupVw.Name = paymentGroup.Name;
            return GetParameters(paymentGroupVw);
        }
    }
    #endregion

    #region PaymentStatusVwXmlFormatter
    public class PaymentStatusVwXmlFormatter : XmlFormatterBase
    {
        public PaymentStatusVwXmlFormatter(PaymentStatusVw paymentStatusVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(paymentStatusVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public PaymentStatusVwXmlFormatter(PaymentStatus paymentStatus)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(paymentStatus);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<Name>{1}</Name>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(PaymentStatusVw paymentStatusVw)
        {
            return new string []
            {
				paymentStatusVw.Id.ToString(),
				paymentStatusVw.Name
            };
        }
        
        private string [] GetParameters(PaymentStatus paymentStatus)
        {
            PaymentStatusVw paymentStatusVw = new PaymentStatusVw();
            paymentStatusVw.Id = paymentStatus.Id;
            paymentStatusVw.Name = paymentStatus.Name;
            return GetParameters(paymentStatusVw);
        }
    }
    #endregion

    #region PayOrderVwXmlFormatter
    public class PayOrderVwXmlFormatter : XmlFormatterBase
    {
        public PayOrderVwXmlFormatter(PayOrderVw payOrderVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(payOrderVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public PayOrderVwXmlFormatter(PayOrder payOrder)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(payOrder);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<EmployeeId>{1}</EmployeeId>";
            parametersFormat += "\n\t<EmployeeFullName>{2}</EmployeeFullName>";
            parametersFormat += "\n\t<EmployeeDepartmentName>{3}</EmployeeDepartmentName>";
            parametersFormat += "\n\t<EmployeeDepartmentSalaryWorkPlaceName>{4}</EmployeeDepartmentSalaryWorkPlaceName>";
            parametersFormat += "\n\t<EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>{5}</EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<EmployeeCategoryName>{6}</EmployeeCategoryName>";
            parametersFormat += "\n\t<Number>{7}</Number>";
            parametersFormat += "\n\t<Date>{8}</Date>";
            parametersFormat += "\n\t<PaymentGroupName>{9}</PaymentGroupName>";
            parametersFormat += "\n\t<PaidAmount>{10}</PaidAmount>";
            parametersFormat += "\n\t<IsProfit>{11}</IsProfit>";
            parametersFormat += "\n\t<IsFixed>{12}</IsFixed>";
            parametersFormat += "\n\t<Notes>{13}</Notes>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(PayOrderVw payOrderVw)
        {
            return new string []
            {
				payOrderVw.Id.ToString(),
				payOrderVw.EmployeeId.ToString(),
				payOrderVw.EmployeeFullName,
				payOrderVw.EmployeeDepartmentName,
				payOrderVw.EmployeeDepartmentSalaryWorkPlaceName,
				payOrderVw.EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName,
				payOrderVw.EmployeeCategoryName,
				payOrderVw.Number.ToString(),
				payOrderVw.Date.ToString(DateFormat),
				payOrderVw.PaymentGroupName,
				payOrderVw.PaidAmount.ToString(MoneyFormat),
				payOrderVw.IsProfit.ToString(),
				payOrderVw.IsFixed.ToString(),
				payOrderVw.Notes == null ? string.Empty : payOrderVw.Notes
            };
        }
        
        private string [] GetParameters(PayOrder payOrder)
        {
            PayOrderVw payOrderVw = new PayOrderVw();
            payOrderVw.Id = payOrder.Id;
            payOrderVw.EmployeeId = payOrder.Employee;
            payOrderVw.Number = payOrder.Number;
            payOrderVw.Date = payOrder.Date;
            payOrderVw.PaidAmount = payOrder.PaidAmount;
            payOrderVw.IsProfit = payOrder.IsProfit;
            payOrderVw.IsFixed = payOrder.IsFixed;
            payOrderVw.Notes = payOrder.Notes;
            return GetParameters(payOrderVw);
        }
    }
    #endregion

    #region ProductVwXmlFormatter
    public class ProductVwXmlFormatter : XmlFormatterBase
    {
        public ProductVwXmlFormatter(ProductVw productVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(productVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public ProductVwXmlFormatter(Product product)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(product);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<EmployeeId>{1}</EmployeeId>";
            parametersFormat += "\n\t<EmployeeFullName>{2}</EmployeeFullName>";
            parametersFormat += "\n\t<EmployeeDepartmentName>{3}</EmployeeDepartmentName>";
            parametersFormat += "\n\t<EmployeeDepartmentSalaryWorkPlaceName>{4}</EmployeeDepartmentSalaryWorkPlaceName>";
            parametersFormat += "\n\t<EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>{5}</EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<EmployeeCategoryName>{6}</EmployeeCategoryName>";
            parametersFormat += "\n\t<ProductTypeName>{7}</ProductTypeName>";
            parametersFormat += "\n\t<ProductTypeRate>{8}</ProductTypeRate>";
            parametersFormat += "\n\t<ProductTypeGuarantorsCount>{9}</ProductTypeGuarantorsCount>";
            parametersFormat += "\n\t<ProductTypeProfitStrategyName>{10}</ProductTypeProfitStrategyName>";
            parametersFormat += "\n\t<ProductTypePaymentGroupName>{11}</ProductTypePaymentGroupName>";
            parametersFormat += "\n\t<ProductTypeIsActive>{12}</ProductTypeIsActive>";
            parametersFormat += "\n\t<Amount>{13}</Amount>";
            parametersFormat += "\n\t<Notes>{14}</Notes>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(ProductVw productVw)
        {
            return new string []
            {
				productVw.Id.ToString(),
				productVw.EmployeeId.ToString(),
				productVw.EmployeeFullName,
				productVw.EmployeeDepartmentName,
				productVw.EmployeeDepartmentSalaryWorkPlaceName,
				productVw.EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName,
				productVw.EmployeeCategoryName,
				productVw.ProductTypeName == null ? string.Empty : productVw.ProductTypeName,
				productVw.ProductTypeRate == null ? string.Empty : productVw.ProductTypeRate.Value.ToString(MoneyFormat),
				productVw.ProductTypeGuarantorsCount.ToString(),
				productVw.ProductTypeProfitStrategyName == null ? string.Empty : productVw.ProductTypeProfitStrategyName,
				productVw.ProductTypePaymentGroupName == null ? string.Empty : productVw.ProductTypePaymentGroupName,
				productVw.ProductTypeIsActive == null ? string.Empty : productVw.ProductTypeIsActive.Value.ToString(),
				productVw.Amount.ToString(MoneyFormat),
				productVw.Notes == null ? string.Empty : productVw.Notes
            };
        }
        
        private string [] GetParameters(Product product)
        {
            ProductVw productVw = new ProductVw();
            productVw.Id = product.Id;
            productVw.EmployeeId = product.Employee;
            productVw.Amount = product.Amount;
            productVw.Notes = product.Notes;
            return GetParameters(productVw);
        }
    }
    #endregion

    #region ProductTypeVwXmlFormatter
    public class ProductTypeVwXmlFormatter : XmlFormatterBase
    {
        public ProductTypeVwXmlFormatter(ProductTypeVw productTypeVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(productTypeVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public ProductTypeVwXmlFormatter(ProductType productType)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(productType);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<Name>{1}</Name>";
            parametersFormat += "\n\t<Rate>{2}</Rate>";
            parametersFormat += "\n\t<GuarantorsCount>{3}</GuarantorsCount>";
            parametersFormat += "\n\t<PrintLabel>{4}</PrintLabel>";
            parametersFormat += "\n\t<ProfitStrategyName>{5}</ProfitStrategyName>";
            parametersFormat += "\n\t<PaymentGroupName>{6}</PaymentGroupName>";
            parametersFormat += "\n\t<IsActive>{7}</IsActive>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(ProductTypeVw productTypeVw)
        {
            return new string []
            {
				productTypeVw.Id.ToString(),
				productTypeVw.Name == null ? string.Empty : productTypeVw.Name,
				productTypeVw.Rate == null ? string.Empty : productTypeVw.Rate.Value.ToString(MoneyFormat),
				productTypeVw.GuarantorsCount.ToString(),
				productTypeVw.PrintLabel == null ? string.Empty : productTypeVw.PrintLabel,
				productTypeVw.ProfitStrategyName == null ? string.Empty : productTypeVw.ProfitStrategyName,
				productTypeVw.PaymentGroupName == null ? string.Empty : productTypeVw.PaymentGroupName,
				productTypeVw.IsActive == null ? string.Empty : productTypeVw.IsActive.Value.ToString()
            };
        }
        
        private string [] GetParameters(ProductType productType)
        {
            ProductTypeVw productTypeVw = new ProductTypeVw();
            productTypeVw.Id = productType.Id;
            productTypeVw.Name = productType.Name;
            productTypeVw.Rate = productType.Rate;
            productTypeVw.GuarantorsCount = productType.GuarantorsCount;
            productTypeVw.PrintLabel = productType.PrintLabel;
            productTypeVw.IsActive = productType.IsActive;
            return GetParameters(productTypeVw);
        }
    }
    #endregion

    #region ProductTypeAvailabilityVwXmlFormatter
    public class ProductTypeAvailabilityVwXmlFormatter : XmlFormatterBase
    {
        public ProductTypeAvailabilityVwXmlFormatter(ProductTypeAvailabilityVw productTypeAvailabilityVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(productTypeAvailabilityVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public ProductTypeAvailabilityVwXmlFormatter(ProductTypeAvailability productTypeAvailability)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(productTypeAvailability);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<ProductTypeName>{1}</ProductTypeName>";
            parametersFormat += "\n\t<ProductTypeRate>{2}</ProductTypeRate>";
            parametersFormat += "\n\t<ProductTypeGuarantorsCount>{3}</ProductTypeGuarantorsCount>";
            parametersFormat += "\n\t<ProductTypePaymentGroupName>{4}</ProductTypePaymentGroupName>";
            parametersFormat += "\n\t<ProductTypeIsActive>{5}</ProductTypeIsActive>";
            parametersFormat += "\n\t<AvailabilityName>{6}</AvailabilityName>";
            parametersFormat += "\n\t<AvailabilityMinSeniority>{7}</AvailabilityMinSeniority>";
            parametersFormat += "\n\t<AvailabilityMinReusePeriod>{8}</AvailabilityMinReusePeriod>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(ProductTypeAvailabilityVw productTypeAvailabilityVw)
        {
            return new string []
            {
				productTypeAvailabilityVw.Id.ToString(),
				productTypeAvailabilityVw.ProductTypeName == null ? string.Empty : productTypeAvailabilityVw.ProductTypeName,
				productTypeAvailabilityVw.ProductTypeRate == null ? string.Empty : productTypeAvailabilityVw.ProductTypeRate.Value.ToString(MoneyFormat),
				productTypeAvailabilityVw.ProductTypeGuarantorsCount.ToString(),
				productTypeAvailabilityVw.ProductTypePaymentGroupName == null ? string.Empty : productTypeAvailabilityVw.ProductTypePaymentGroupName,
				productTypeAvailabilityVw.ProductTypeIsActive == null ? string.Empty : productTypeAvailabilityVw.ProductTypeIsActive.Value.ToString(),
				productTypeAvailabilityVw.AvailabilityName,
				productTypeAvailabilityVw.AvailabilityMinSeniority.ToString(),
				productTypeAvailabilityVw.AvailabilityMinReusePeriod.ToString()
            };
        }
        
        private string [] GetParameters(ProductTypeAvailability productTypeAvailability)
        {
            ProductTypeAvailabilityVw productTypeAvailabilityVw = new ProductTypeAvailabilityVw();
            productTypeAvailabilityVw.Id = productTypeAvailability.Id;
            return GetParameters(productTypeAvailabilityVw);
        }
    }
    #endregion

    #region ProfileVwXmlFormatter
    public class ProfileVwXmlFormatter : XmlFormatterBase
    {
        public ProfileVwXmlFormatter(ProfileVw profileVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(profileVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public ProfileVwXmlFormatter(Profile profile)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(profile);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<EmployeeId>{0}</EmployeeId>";
            parametersFormat += "\n\t<EmployeeFirstName>{1}</EmployeeFirstName>";
            parametersFormat += "\n\t<EmployeeLastName>{2}</EmployeeLastName>";
            parametersFormat += "\n\t<EmployeeEmployeeStatusName>{3}</EmployeeEmployeeStatusName>";
            parametersFormat += "\n\t<EmployeeEmployeeStatusIsActive>{4}</EmployeeEmployeeStatusIsActive>";
            parametersFormat += "\n\t<EmployeeDepartmentName>{5}</EmployeeDepartmentName>";
            parametersFormat += "\n\t<EmployeeDepartmentSalaryWorkPlaceName>{6}</EmployeeDepartmentSalaryWorkPlaceName>";
            parametersFormat += "\n\t<EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>{7}</EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<EmployeeNotes>{8}</EmployeeNotes>";
            parametersFormat += "\n\t<EmployeeCategoryName>{9}</EmployeeCategoryName>";
            parametersFormat += "\n\t<Extension>{10}</Extension>";
            parametersFormat += "\n\t<HomePhone>{11}</HomePhone>";
            parametersFormat += "\n\t<MobilePhone>{12}</MobilePhone>";
            parametersFormat += "\n\t<Address>{13}</Address>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(ProfileVw profileVw)
        {
            return new string []
            {
				profileVw.EmployeeId.ToString(),
				profileVw.EmployeeFirstName,
				profileVw.EmployeeLastName,
				profileVw.EmployeeEmployeeStatusName,
				profileVw.EmployeeEmployeeStatusIsActive.ToString(),
				profileVw.EmployeeDepartmentName,
				profileVw.EmployeeDepartmentSalaryWorkPlaceName,
				profileVw.EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName,
				profileVw.EmployeeNotes == null ? string.Empty : profileVw.EmployeeNotes,
				profileVw.EmployeeCategoryName,
				profileVw.Extension == null ? string.Empty : profileVw.Extension,
				profileVw.HomePhone == null ? string.Empty : profileVw.HomePhone,
				profileVw.MobilePhone == null ? string.Empty : profileVw.MobilePhone,
				profileVw.Address == null ? string.Empty : profileVw.Address
            };
        }
        
        private string [] GetParameters(Profile profile)
        {
            ProfileVw profileVw = new ProfileVw();
            profileVw.EmployeeId = profile.Employee;
            profileVw.Extension = profile.Extension;
            profileVw.HomePhone = profile.HomePhone;
            profileVw.MobilePhone = profile.MobilePhone;
            profileVw.Address = profile.Address;
            return GetParameters(profileVw);
        }
    }
    #endregion

    #region ProfitStrategyVwXmlFormatter
    public class ProfitStrategyVwXmlFormatter : XmlFormatterBase
    {
        public ProfitStrategyVwXmlFormatter(ProfitStrategyVw profitStrategyVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(profitStrategyVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public ProfitStrategyVwXmlFormatter(ProfitStrategy profitStrategy)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(profitStrategy);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<Name>{1}</Name>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(ProfitStrategyVw profitStrategyVw)
        {
            return new string []
            {
				profitStrategyVw.Id.ToString(),
				profitStrategyVw.Name
            };
        }
        
        private string [] GetParameters(ProfitStrategy profitStrategy)
        {
            ProfitStrategyVw profitStrategyVw = new ProfitStrategyVw();
            profitStrategyVw.Id = profitStrategy.Id;
            profitStrategyVw.Name = profitStrategy.Name;
            return GetParameters(profitStrategyVw);
        }
    }
    #endregion

    #region RefundableProductVwXmlFormatter
    public class RefundableProductVwXmlFormatter : XmlFormatterBase
    {
        public RefundableProductVwXmlFormatter(RefundableProductVw refundableProductVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(refundableProductVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public RefundableProductVwXmlFormatter(RefundableProduct refundableProduct)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(refundableProduct);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<ProductId>{0}</ProductId>";
            parametersFormat += "\n\t<ProductEmployeeId>{1}</ProductEmployeeId>";
            parametersFormat += "\n\t<ProductEmployeeFullName>{2}</ProductEmployeeFullName>";
            parametersFormat += "\n\t<ProductEmployeeEmployeeStatusName>{3}</ProductEmployeeEmployeeStatusName>";
            parametersFormat += "\n\t<ProductEmployeeDepartmentName>{4}</ProductEmployeeDepartmentName>";
            parametersFormat += "\n\t<ProductEmployeeDepartmentSalaryWorkPlaceName>{5}</ProductEmployeeDepartmentSalaryWorkPlaceName>";
            parametersFormat += "\n\t<ProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>{6}</ProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<ProductEmployeeCategoryName>{7}</ProductEmployeeCategoryName>";
            parametersFormat += "\n\t<ProductProductTypeName>{8}</ProductProductTypeName>";
            parametersFormat += "\n\t<ProductProductTypeRate>{9}</ProductProductTypeRate>";
            parametersFormat += "\n\t<ProductProductTypeGuarantorsCount>{10}</ProductProductTypeGuarantorsCount>";
            parametersFormat += "\n\t<ProductProductTypePaymentGroupName>{11}</ProductProductTypePaymentGroupName>";
            parametersFormat += "\n\t<ProductAmount>{12}</ProductAmount>";
            parametersFormat += "\n\t<PaymentPeriod>{13}</PaymentPeriod>";
            parametersFormat += "\n\t<Installment>{14}</Installment>";
            parametersFormat += "\n\t<NetAmount>{15}</NetAmount>";
            parametersFormat += "\n\t<ProfitAmount>{16}</ProfitAmount>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(RefundableProductVw refundableProductVw)
        {
            return new string []
            {
				refundableProductVw.ProductId.ToString(),
				refundableProductVw.ProductEmployeeId.ToString(),
				refundableProductVw.ProductEmployeeFullName,
				refundableProductVw.ProductEmployeeEmployeeStatusName,
				refundableProductVw.ProductEmployeeDepartmentName,
				refundableProductVw.ProductEmployeeDepartmentSalaryWorkPlaceName,
				refundableProductVw.ProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName,
				refundableProductVw.ProductEmployeeCategoryName,
				refundableProductVw.ProductProductTypeName == null ? string.Empty : refundableProductVw.ProductProductTypeName,
				refundableProductVw.ProductProductTypeRate == null ? string.Empty : refundableProductVw.ProductProductTypeRate.Value.ToString(MoneyFormat),
				refundableProductVw.ProductProductTypeGuarantorsCount.ToString(),
				refundableProductVw.ProductProductTypePaymentGroupName == null ? string.Empty : refundableProductVw.ProductProductTypePaymentGroupName,
				refundableProductVw.ProductAmount.ToString(MoneyFormat),
				refundableProductVw.PaymentPeriod.ToString(),
				refundableProductVw.Installment.ToString(MoneyFormat),
				refundableProductVw.NetAmount.ToString(MoneyFormat),
				refundableProductVw.ProfitAmount.ToString(MoneyFormat)
            };
        }
        
        private string [] GetParameters(RefundableProduct refundableProduct)
        {
            RefundableProductVw refundableProductVw = new RefundableProductVw();
            refundableProductVw.ProductId = refundableProduct.Product;
            refundableProductVw.PaymentPeriod = refundableProduct.PaymentPeriod;
            refundableProductVw.Installment = refundableProduct.Installment;
            refundableProductVw.NetAmount = refundableProduct.NetAmount;
            refundableProductVw.ProfitAmount = refundableProduct.ProfitAmount;
            return GetParameters(refundableProductVw);
        }
    }
    #endregion

    #region RequestVwXmlFormatter
    public class RequestVwXmlFormatter : XmlFormatterBase
    {
        public RequestVwXmlFormatter(RequestVw requestVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(requestVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public RequestVwXmlFormatter(Request request)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(request);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<ProductId>{0}</ProductId>";
            parametersFormat += "\n\t<ProductEmployeeId>{1}</ProductEmployeeId>";
            parametersFormat += "\n\t<ProductEmployeeFullName>{2}</ProductEmployeeFullName>";
            parametersFormat += "\n\t<ProductEmployeeDepartmentName>{3}</ProductEmployeeDepartmentName>";
            parametersFormat += "\n\t<ProductEmployeeDepartmentSalaryWorkPlaceName>{4}</ProductEmployeeDepartmentSalaryWorkPlaceName>";
            parametersFormat += "\n\t<ProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>{5}</ProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<ProductEmployeeCategoryName>{6}</ProductEmployeeCategoryName>";
            parametersFormat += "\n\t<ProductProductTypeName>{7}</ProductProductTypeName>";
            parametersFormat += "\n\t<ProductProductTypeRate>{8}</ProductProductTypeRate>";
            parametersFormat += "\n\t<ProductProductTypeGuarantorsCount>{9}</ProductProductTypeGuarantorsCount>";
            parametersFormat += "\n\t<Date>{10}</Date>";
            parametersFormat += "\n\t<Amount>{11}</Amount>";
            parametersFormat += "\n\t<RequestStatusName>{12}</RequestStatusName>";
            parametersFormat += "\n\t<Notes>{13}</Notes>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(RequestVw requestVw)
        {
            return new string []
            {
				requestVw.ProductId.ToString(),
				requestVw.ProductEmployeeId.ToString(),
				requestVw.ProductEmployeeFullName,
				requestVw.ProductEmployeeDepartmentName,
				requestVw.ProductEmployeeDepartmentSalaryWorkPlaceName,
				requestVw.ProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName,
				requestVw.ProductEmployeeCategoryName,
				requestVw.ProductProductTypeName == null ? string.Empty : requestVw.ProductProductTypeName,
				requestVw.ProductProductTypeRate == null ? string.Empty : requestVw.ProductProductTypeRate.Value.ToString(MoneyFormat),
				requestVw.ProductProductTypeGuarantorsCount.ToString(),
				requestVw.Date.ToString(DateFormat),
				requestVw.Amount.ToString(MoneyFormat),
				requestVw.RequestStatusName == null ? string.Empty : requestVw.RequestStatusName,
				requestVw.Notes == null ? string.Empty : requestVw.Notes
            };
        }
        
        private string [] GetParameters(Request request)
        {
            RequestVw requestVw = new RequestVw();
            requestVw.ProductId = request.Product;
            requestVw.Date = request.Date;
            requestVw.Amount = request.Amount;
            requestVw.Notes = request.Notes;
            return GetParameters(requestVw);
        }
    }
    #endregion

    #region RequestStatusVwXmlFormatter
    public class RequestStatusVwXmlFormatter : XmlFormatterBase
    {
        public RequestStatusVwXmlFormatter(RequestStatusVw requestStatusVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(requestStatusVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public RequestStatusVwXmlFormatter(RequestStatus requestStatus)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(requestStatus);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<Name>{1}</Name>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(RequestStatusVw requestStatusVw)
        {
            return new string []
            {
				requestStatusVw.Id.ToString(),
				requestStatusVw.Name
            };
        }
        
        private string [] GetParameters(RequestStatus requestStatus)
        {
            RequestStatusVw requestStatusVw = new RequestStatusVw();
            requestStatusVw.Id = requestStatus.Id;
            requestStatusVw.Name = requestStatus.Name;
            return GetParameters(requestStatusVw);
        }
    }
    #endregion

    #region ResourceVwXmlFormatter
    public class ResourceVwXmlFormatter : XmlFormatterBase
    {
        public ResourceVwXmlFormatter(ResourceVw resourceVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(resourceVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public ResourceVwXmlFormatter(Resource resource)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(resource);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<Language>{1}</Language>";
            parametersFormat += "\n\t<Module>{2}</Module>";
            parametersFormat += "\n\t<Key>{3}</Key>";
            parametersFormat += "\n\t<Value>{4}</Value>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(ResourceVw resourceVw)
        {
            return new string []
            {
				resourceVw.Id.ToString(),
				resourceVw.Language,
				resourceVw.Module,
				resourceVw.Key,
				resourceVw.Value
            };
        }
        
        private string [] GetParameters(Resource resource)
        {
            ResourceVw resourceVw = new ResourceVw();
            resourceVw.Id = resource.Id;
            resourceVw.Language = resource.Language;
            resourceVw.Module = resource.Module;
            resourceVw.Key = resource.Key;
            resourceVw.Value = resource.Value;
            return GetParameters(resourceVw);
        }
    }
    #endregion

    #region SalaryPaymentVwXmlFormatter
    public class SalaryPaymentVwXmlFormatter : XmlFormatterBase
    {
        public SalaryPaymentVwXmlFormatter(SalaryPaymentVw salaryPaymentVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(salaryPaymentVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public SalaryPaymentVwXmlFormatter(SalaryPayment salaryPayment)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(salaryPayment);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<PaymentId>{0}</PaymentId>";
            parametersFormat += "\n\t<PaymentEmployeeId>{1}</PaymentEmployeeId>";
            parametersFormat += "\n\t<PaymentEmployeeFullName>{2}</PaymentEmployeeFullName>";
            parametersFormat += "\n\t<PaymentEmployeeDepartmentSalaryWorkPlaceName>{3}</PaymentEmployeeDepartmentSalaryWorkPlaceName>";
            parametersFormat += "\n\t<PaymentEmployeeCategoryName>{4}</PaymentEmployeeCategoryName>";
            parametersFormat += "\n\t<PaymentDate>{5}</PaymentDate>";
            parametersFormat += "\n\t<PaymentPaymentGroupName>{6}</PaymentPaymentGroupName>";
            parametersFormat += "\n\t<PaymentAmount>{7}</PaymentAmount>";
            parametersFormat += "\n\t<PaymentNotes>{8}</PaymentNotes>";
            parametersFormat += "\n\t<PaymentPaymentStatusName>{9}</PaymentPaymentStatusName>";
            parametersFormat += "\n\t<DepartmentName>{10}</DepartmentName>";
            parametersFormat += "\n\t<DepartmentSalaryWorkPlaceName>{11}</DepartmentSalaryWorkPlaceName>";
            parametersFormat += "\n\t<DepartmentSalaryWorkPlaceMainWorkPlaceName>{12}</DepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<Balance>{13}</Balance>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(SalaryPaymentVw salaryPaymentVw)
        {
            return new string []
            {
				salaryPaymentVw.PaymentId.ToString(),
				salaryPaymentVw.PaymentEmployeeId.ToString(),
				salaryPaymentVw.PaymentEmployeeFullName,
				salaryPaymentVw.PaymentEmployeeDepartmentSalaryWorkPlaceName,
				salaryPaymentVw.PaymentEmployeeCategoryName,
				salaryPaymentVw.PaymentDate.ToString(DateFormat),
				salaryPaymentVw.PaymentPaymentGroupName,
				salaryPaymentVw.PaymentAmount == null ? string.Empty : salaryPaymentVw.PaymentAmount.Value.ToString(MoneyFormat),
				salaryPaymentVw.PaymentNotes == null ? string.Empty : salaryPaymentVw.PaymentNotes,
				salaryPaymentVw.PaymentPaymentStatusName == null ? string.Empty : salaryPaymentVw.PaymentPaymentStatusName,
				salaryPaymentVw.DepartmentName,
				salaryPaymentVw.DepartmentSalaryWorkPlaceName,
				salaryPaymentVw.DepartmentSalaryWorkPlaceMainWorkPlaceName,
				salaryPaymentVw.Balance == null ? string.Empty : salaryPaymentVw.Balance.Value.ToString(MoneyFormat)
            };
        }
        
        private string [] GetParameters(SalaryPayment salaryPayment)
        {
            SalaryPaymentVw salaryPaymentVw = new SalaryPaymentVw();
            salaryPaymentVw.PaymentId = salaryPayment.Payment;
            salaryPaymentVw.Balance = salaryPayment.Balance;
            return GetParameters(salaryPaymentVw);
        }
    }
    #endregion

    #region SalaryWorkPlaceVwXmlFormatter
    public class SalaryWorkPlaceVwXmlFormatter : XmlFormatterBase
    {
        public SalaryWorkPlaceVwXmlFormatter(SalaryWorkPlaceVw salaryWorkPlaceVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(salaryWorkPlaceVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public SalaryWorkPlaceVwXmlFormatter(SalaryWorkPlace salaryWorkPlace)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(salaryWorkPlace);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<Name>{1}</Name>";
            parametersFormat += "\n\t<MainWorkPlaceName>{2}</MainWorkPlaceName>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(SalaryWorkPlaceVw salaryWorkPlaceVw)
        {
            return new string []
            {
				salaryWorkPlaceVw.Id.ToString(),
				salaryWorkPlaceVw.Name,
				salaryWorkPlaceVw.MainWorkPlaceName
            };
        }
        
        private string [] GetParameters(SalaryWorkPlace salaryWorkPlace)
        {
            SalaryWorkPlaceVw salaryWorkPlaceVw = new SalaryWorkPlaceVw();
            salaryWorkPlaceVw.Id = salaryWorkPlace.Id;
            salaryWorkPlaceVw.Name = salaryWorkPlace.Name;
            return GetParameters(salaryWorkPlaceVw);
        }
    }
    #endregion

    #region ServiceEndGrantRequestVwXmlFormatter
    public class ServiceEndGrantRequestVwXmlFormatter : XmlFormatterBase
    {
        public ServiceEndGrantRequestVwXmlFormatter(ServiceEndGrantRequestVw serviceEndGrantRequestVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(serviceEndGrantRequestVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public ServiceEndGrantRequestVwXmlFormatter(ServiceEndGrantRequest serviceEndGrantRequest)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(serviceEndGrantRequest);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<GrantRequestRequestProductId>{0}</GrantRequestRequestProductId>";
            parametersFormat += "\n\t<GrantRequestRequestProductEmployeeId>{1}</GrantRequestRequestProductEmployeeId>";
            parametersFormat += "\n\t<GrantRequestRequestProductEmployeeFullName>{2}</GrantRequestRequestProductEmployeeFullName>";
            parametersFormat += "\n\t<GrantRequestRequestProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>{3}</GrantRequestRequestProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<GrantRequestRequestProductEmployeeCategoryName>{4}</GrantRequestRequestProductEmployeeCategoryName>";
            parametersFormat += "\n\t<GrantRequestRequestProductProductTypeName>{5}</GrantRequestRequestProductProductTypeName>";
            parametersFormat += "\n\t<GrantRequestRequestProductProductTypeRate>{6}</GrantRequestRequestProductProductTypeRate>";
            parametersFormat += "\n\t<GrantRequestRequestProductProductTypeGuarantorsCount>{7}</GrantRequestRequestProductProductTypeGuarantorsCount>";
            parametersFormat += "\n\t<GrantRequestRequestDate>{8}</GrantRequestRequestDate>";
            parametersFormat += "\n\t<GrantRequestRequestRequestStatusName>{9}</GrantRequestRequestRequestStatusName>";
            parametersFormat += "\n\t<GrantRequestAmount>{10}</GrantRequestAmount>";
            parametersFormat += "\n\t<GrantRequestNotes>{11}</GrantRequestNotes>";
            parametersFormat += "\n\t<AverageIncome>{12}</AverageIncome>";
            parametersFormat += "\n\t<GrantPercentage>{13}</GrantPercentage>";
            parametersFormat += "\n\t<ServiceInMonthes>{14}</ServiceInMonthes>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(ServiceEndGrantRequestVw serviceEndGrantRequestVw)
        {
            return new string []
            {
				serviceEndGrantRequestVw.GrantRequestRequestProductId.ToString(),
				serviceEndGrantRequestVw.GrantRequestRequestProductEmployeeId.ToString(),
				serviceEndGrantRequestVw.GrantRequestRequestProductEmployeeFullName,
				serviceEndGrantRequestVw.GrantRequestRequestProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName,
				serviceEndGrantRequestVw.GrantRequestRequestProductEmployeeCategoryName,
				serviceEndGrantRequestVw.GrantRequestRequestProductProductTypeName == null ? string.Empty : serviceEndGrantRequestVw.GrantRequestRequestProductProductTypeName,
				serviceEndGrantRequestVw.GrantRequestRequestProductProductTypeRate == null ? string.Empty : serviceEndGrantRequestVw.GrantRequestRequestProductProductTypeRate.Value.ToString(MoneyFormat),
				serviceEndGrantRequestVw.GrantRequestRequestProductProductTypeGuarantorsCount.ToString(),
				serviceEndGrantRequestVw.GrantRequestRequestDate.ToString(DateFormat),
				serviceEndGrantRequestVw.GrantRequestRequestRequestStatusName == null ? string.Empty : serviceEndGrantRequestVw.GrantRequestRequestRequestStatusName,
				serviceEndGrantRequestVw.GrantRequestAmount.ToString(MoneyFormat),
				serviceEndGrantRequestVw.GrantRequestNotes == null ? string.Empty : serviceEndGrantRequestVw.GrantRequestNotes,
				serviceEndGrantRequestVw.AverageIncome.ToString(MoneyFormat),
				serviceEndGrantRequestVw.GrantPercentage.ToString(),
				serviceEndGrantRequestVw.ServiceInMonthes.ToString()
            };
        }
        
        private string [] GetParameters(ServiceEndGrantRequest serviceEndGrantRequest)
        {
            ServiceEndGrantRequestVw serviceEndGrantRequestVw = new ServiceEndGrantRequestVw();
            serviceEndGrantRequestVw.GrantRequestRequestProductId = serviceEndGrantRequest.GrantRequest;
            serviceEndGrantRequestVw.AverageIncome = serviceEndGrantRequest.AverageIncome;
            serviceEndGrantRequestVw.GrantPercentage = serviceEndGrantRequest.GrantPercentage;
            serviceEndGrantRequestVw.ServiceInMonthes = serviceEndGrantRequest.ServiceInMonthes;
            return GetParameters(serviceEndGrantRequestVw);
        }
    }
    #endregion

    #region SettlementVwXmlFormatter
    public class SettlementVwXmlFormatter : XmlFormatterBase
    {
        public SettlementVwXmlFormatter(SettlementVw settlementVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(settlementVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public SettlementVwXmlFormatter(Settlement settlement)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(settlement);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<InstallmentRefundableProductProductId>{1}</InstallmentRefundableProductProductId>";
            parametersFormat += "\n\t<InstallmentRefundableProductProductEmployeeId>{2}</InstallmentRefundableProductProductEmployeeId>";
            parametersFormat += "\n\t<InstallmentRefundableProductProductEmployeeFullName>{3}</InstallmentRefundableProductProductEmployeeFullName>";
            parametersFormat += "\n\t<InstallmentRefundableProductProductEmployeeDepartmentName>{4}</InstallmentRefundableProductProductEmployeeDepartmentName>";
            parametersFormat += "\n\t<InstallmentRefundableProductProductEmployeeDepartmentSalaryWorkPlaceName>{5}</InstallmentRefundableProductProductEmployeeDepartmentSalaryWorkPlaceName>";
            parametersFormat += "\n\t<InstallmentRefundableProductProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>{6}</InstallmentRefundableProductProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<InstallmentRefundableProductProductEmployeeCategoryName>{7}</InstallmentRefundableProductProductEmployeeCategoryName>";
            parametersFormat += "\n\t<InstallmentRefundableProductProductProductTypeName>{8}</InstallmentRefundableProductProductProductTypeName>";
            parametersFormat += "\n\t<InstallmentSubNumber>{9}</InstallmentSubNumber>";
            parametersFormat += "\n\t<InstallmentDueDate>{10}</InstallmentDueDate>";
            parametersFormat += "\n\t<InstallmentDueCapital>{11}</InstallmentDueCapital>";
            parametersFormat += "\n\t<InstallmentDueProfit>{12}</InstallmentDueProfit>";
            parametersFormat += "\n\t<InstallmentNotes>{13}</InstallmentNotes>";
            parametersFormat += "\n\t<PaymentEmployeeDepartmentName>{14}</PaymentEmployeeDepartmentName>";
            parametersFormat += "\n\t<PaymentEmployeeDepartmentSalaryWorkPlaceName>{15}</PaymentEmployeeDepartmentSalaryWorkPlaceName>";
            parametersFormat += "\n\t<PaymentEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>{16}</PaymentEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<PaymentDate>{17}</PaymentDate>";
            parametersFormat += "\n\t<PaymentNotes>{18}</PaymentNotes>";
            parametersFormat += "\n\t<PaymentPaymentStatusName>{19}</PaymentPaymentStatusName>";
            parametersFormat += "\n\t<Amount>{20}</Amount>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(SettlementVw settlementVw)
        {
            return new string []
            {
				settlementVw.Id.ToString(),
				settlementVw.InstallmentRefundableProductProductId.ToString(),
				settlementVw.InstallmentRefundableProductProductEmployeeId.ToString(),
				settlementVw.InstallmentRefundableProductProductEmployeeFullName,
				settlementVw.InstallmentRefundableProductProductEmployeeDepartmentName,
				settlementVw.InstallmentRefundableProductProductEmployeeDepartmentSalaryWorkPlaceName,
				settlementVw.InstallmentRefundableProductProductEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName,
				settlementVw.InstallmentRefundableProductProductEmployeeCategoryName,
				settlementVw.InstallmentRefundableProductProductProductTypeName == null ? string.Empty : settlementVw.InstallmentRefundableProductProductProductTypeName,
				settlementVw.InstallmentSubNumber.ToString(),
				settlementVw.InstallmentDueDate.ToString(DateFormat),
				settlementVw.InstallmentDueCapital.ToString(MoneyFormat),
				settlementVw.InstallmentDueProfit.ToString(MoneyFormat),
				settlementVw.InstallmentNotes == null ? string.Empty : settlementVw.InstallmentNotes,
				settlementVw.PaymentEmployeeDepartmentName,
				settlementVw.PaymentEmployeeDepartmentSalaryWorkPlaceName,
				settlementVw.PaymentEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName,
				settlementVw.PaymentDate.ToString(DateFormat),
				settlementVw.PaymentNotes == null ? string.Empty : settlementVw.PaymentNotes,
				settlementVw.PaymentPaymentStatusName == null ? string.Empty : settlementVw.PaymentPaymentStatusName,
				settlementVw.Amount.ToString(MoneyFormat)
            };
        }
        
        private string [] GetParameters(Settlement settlement)
        {
            SettlementVw settlementVw = new SettlementVw();
            settlementVw.Id = settlement.Id;
            settlementVw.Amount = settlement.Amount;
            return GetParameters(settlementVw);
        }
    }
    #endregion

    #region SpecialCaseLoanVwXmlFormatter
    public class SpecialCaseLoanVwXmlFormatter : XmlFormatterBase
    {
        public SpecialCaseLoanVwXmlFormatter(SpecialCaseLoanVw specialCaseLoanVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(specialCaseLoanVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public SpecialCaseLoanVwXmlFormatter(SpecialCaseLoan specialCaseLoan)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(specialCaseLoan);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<EmployeeId>{1}</EmployeeId>";
            parametersFormat += "\n\t<EmployeeFullName>{2}</EmployeeFullName>";
            parametersFormat += "\n\t<EmployeeDepartmentName>{3}</EmployeeDepartmentName>";
            parametersFormat += "\n\t<EmployeeDepartmentSalaryWorkPlaceName>{4}</EmployeeDepartmentSalaryWorkPlaceName>";
            parametersFormat += "\n\t<EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>{5}</EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<EmployeeCategoryName>{6}</EmployeeCategoryName>";
            parametersFormat += "\n\t<Date>{7}</Date>";
            parametersFormat += "\n\t<LoanTypeProductTypeName>{8}</LoanTypeProductTypeName>";
            parametersFormat += "\n\t<LoanTypeProductTypeRate>{9}</LoanTypeProductTypeRate>";
            parametersFormat += "\n\t<LoanTypeProductTypePaymentGroupName>{10}</LoanTypeProductTypePaymentGroupName>";
            parametersFormat += "\n\t<LoanTypeProductTypeIsActive>{11}</LoanTypeProductTypeIsActive>";
            parametersFormat += "\n\t<Amount>{12}</Amount>";
            parametersFormat += "\n\t<Notes>{13}</Notes>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(SpecialCaseLoanVw specialCaseLoanVw)
        {
            return new string []
            {
				specialCaseLoanVw.Id.ToString(),
				specialCaseLoanVw.EmployeeId.ToString(),
				specialCaseLoanVw.EmployeeFullName,
				specialCaseLoanVw.EmployeeDepartmentName,
				specialCaseLoanVw.EmployeeDepartmentSalaryWorkPlaceName,
				specialCaseLoanVw.EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName,
				specialCaseLoanVw.EmployeeCategoryName,
				specialCaseLoanVw.Date.ToString(DateFormat),
				specialCaseLoanVw.LoanTypeProductTypeName == null ? string.Empty : specialCaseLoanVw.LoanTypeProductTypeName,
				specialCaseLoanVw.LoanTypeProductTypeRate == null ? string.Empty : specialCaseLoanVw.LoanTypeProductTypeRate.Value.ToString(MoneyFormat),
				specialCaseLoanVw.LoanTypeProductTypePaymentGroupName == null ? string.Empty : specialCaseLoanVw.LoanTypeProductTypePaymentGroupName,
				specialCaseLoanVw.LoanTypeProductTypeIsActive == null ? string.Empty : specialCaseLoanVw.LoanTypeProductTypeIsActive.Value.ToString(),
				specialCaseLoanVw.Amount.ToString(MoneyFormat),
				specialCaseLoanVw.Notes == null ? string.Empty : specialCaseLoanVw.Notes
            };
        }
        
        private string [] GetParameters(SpecialCaseLoan specialCaseLoan)
        {
            SpecialCaseLoanVw specialCaseLoanVw = new SpecialCaseLoanVw();
            specialCaseLoanVw.Id = specialCaseLoan.Id;
            specialCaseLoanVw.EmployeeId = specialCaseLoan.Employee;
            specialCaseLoanVw.Date = specialCaseLoan.Date;
            specialCaseLoanVw.Amount = specialCaseLoan.Amount;
            specialCaseLoanVw.Notes = specialCaseLoan.Notes;
            return GetParameters(specialCaseLoanVw);
        }
    }
    #endregion

    #region SubscriptionVwXmlFormatter
    public class SubscriptionVwXmlFormatter : XmlFormatterBase
    {
        public SubscriptionVwXmlFormatter(SubscriptionVw subscriptionVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(subscriptionVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public SubscriptionVwXmlFormatter(Subscription subscription)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(subscription);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<EmployeeId>{1}</EmployeeId>";
            parametersFormat += "\n\t<EmployeeFullName>{2}</EmployeeFullName>";
            parametersFormat += "\n\t<EmployeeDepartmentName>{3}</EmployeeDepartmentName>";
            parametersFormat += "\n\t<EmployeeDepartmentSalaryWorkPlaceName>{4}</EmployeeDepartmentSalaryWorkPlaceName>";
            parametersFormat += "\n\t<EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>{5}</EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<EmployeeCategoryName>{6}</EmployeeCategoryName>";
            parametersFormat += "\n\t<Month>{7}</Month>";
            parametersFormat += "\n\t<DepartmentName>{8}</DepartmentName>";
            parametersFormat += "\n\t<DepartmentSalaryWorkPlaceName>{9}</DepartmentSalaryWorkPlaceName>";
            parametersFormat += "\n\t<DepartmentSalaryWorkPlaceMainWorkPlaceName>{10}</DepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<SubscriptionTypeName>{11}</SubscriptionTypeName>";
            parametersFormat += "\n\t<Amount>{12}</Amount>";
            parametersFormat += "\n\t<Notes>{13}</Notes>";
            parametersFormat += "\n\t<IsFixed>{14}</IsFixed>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(SubscriptionVw subscriptionVw)
        {
            return new string []
            {
				subscriptionVw.Id.ToString(),
				subscriptionVw.EmployeeId.ToString(),
				subscriptionVw.EmployeeFullName,
				subscriptionVw.EmployeeDepartmentName,
				subscriptionVw.EmployeeDepartmentSalaryWorkPlaceName,
				subscriptionVw.EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName,
				subscriptionVw.EmployeeCategoryName,
				subscriptionVw.Month.ToString(DateFormat),
				subscriptionVw.DepartmentName,
				subscriptionVw.DepartmentSalaryWorkPlaceName,
				subscriptionVw.DepartmentSalaryWorkPlaceMainWorkPlaceName,
				subscriptionVw.SubscriptionTypeName,
				subscriptionVw.Amount.ToString(MoneyFormat),
				subscriptionVw.Notes == null ? string.Empty : subscriptionVw.Notes,
				subscriptionVw.IsFixed.ToString()
            };
        }
        
        private string [] GetParameters(Subscription subscription)
        {
            SubscriptionVw subscriptionVw = new SubscriptionVw();
            subscriptionVw.Id = subscription.Id;
            subscriptionVw.EmployeeId = subscription.Employee;
            subscriptionVw.Month = subscription.Month;
            subscriptionVw.Amount = subscription.Amount;
            subscriptionVw.Notes = subscription.Notes;
            subscriptionVw.IsFixed = subscription.IsFixed;
            return GetParameters(subscriptionVw);
        }
    }
    #endregion

    #region SubscriptionTypeVwXmlFormatter
    public class SubscriptionTypeVwXmlFormatter : XmlFormatterBase
    {
        public SubscriptionTypeVwXmlFormatter(SubscriptionTypeVw subscriptionTypeVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(subscriptionTypeVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public SubscriptionTypeVwXmlFormatter(SubscriptionType subscriptionType)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(subscriptionType);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<Name>{1}</Name>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(SubscriptionTypeVw subscriptionTypeVw)
        {
            return new string []
            {
				subscriptionTypeVw.Id.ToString(),
				subscriptionTypeVw.Name
            };
        }
        
        private string [] GetParameters(SubscriptionType subscriptionType)
        {
            SubscriptionTypeVw subscriptionTypeVw = new SubscriptionTypeVw();
            subscriptionTypeVw.Id = subscriptionType.Id;
            subscriptionTypeVw.Name = subscriptionType.Name;
            return GetParameters(subscriptionTypeVw);
        }
    }
    #endregion

    #region TransitoryIncomingLoanVwXmlFormatter
    public class TransitoryIncomingLoanVwXmlFormatter : XmlFormatterBase
    {
        public TransitoryIncomingLoanVwXmlFormatter(TransitoryIncomingLoanVw transitoryIncomingLoanVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(transitoryIncomingLoanVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public TransitoryIncomingLoanVwXmlFormatter(TransitoryIncomingLoan transitoryIncomingLoan)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(transitoryIncomingLoan);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<EmployeeId>{0}</EmployeeId>";
            parametersFormat += "\n\t<EmployeeFullName>{1}</EmployeeFullName>";
            parametersFormat += "\n\t<EmployeeDepartmentName>{2}</EmployeeDepartmentName>";
            parametersFormat += "\n\t<EmployeeDepartmentSalaryWorkPlaceName>{3}</EmployeeDepartmentSalaryWorkPlaceName>";
            parametersFormat += "\n\t<EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>{4}</EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<EmployeeCategoryName>{5}</EmployeeCategoryName>";
            parametersFormat += "\n\t<MainWorkPlaceName>{6}</MainWorkPlaceName>";
            parametersFormat += "\n\t<ApprovedAmount>{7}</ApprovedAmount>";
            parametersFormat += "\n\t<Installment>{8}</Installment>";
            parametersFormat += "\n\t<Notes>{9}</Notes>";
            parametersFormat += "\n\t<IsVerified>{10}</IsVerified>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(TransitoryIncomingLoanVw transitoryIncomingLoanVw)
        {
            return new string []
            {
				transitoryIncomingLoanVw.EmployeeId.ToString(),
				transitoryIncomingLoanVw.EmployeeFullName,
				transitoryIncomingLoanVw.EmployeeDepartmentName,
				transitoryIncomingLoanVw.EmployeeDepartmentSalaryWorkPlaceName,
				transitoryIncomingLoanVw.EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName,
				transitoryIncomingLoanVw.EmployeeCategoryName,
				transitoryIncomingLoanVw.MainWorkPlaceName,
				transitoryIncomingLoanVw.ApprovedAmount.ToString(MoneyFormat),
				transitoryIncomingLoanVw.Installment.ToString(MoneyFormat),
				transitoryIncomingLoanVw.Notes == null ? string.Empty : transitoryIncomingLoanVw.Notes,
				transitoryIncomingLoanVw.IsVerified.ToString()
            };
        }
        
        private string [] GetParameters(TransitoryIncomingLoan transitoryIncomingLoan)
        {
            TransitoryIncomingLoanVw transitoryIncomingLoanVw = new TransitoryIncomingLoanVw();
            transitoryIncomingLoanVw.EmployeeId = transitoryIncomingLoan.Employee;
            transitoryIncomingLoanVw.ApprovedAmount = transitoryIncomingLoan.ApprovedAmount;
            transitoryIncomingLoanVw.Installment = transitoryIncomingLoan.Installment;
            transitoryIncomingLoanVw.Notes = transitoryIncomingLoan.Notes;
            transitoryIncomingLoanVw.IsVerified = transitoryIncomingLoan.IsVerified;
            return GetParameters(transitoryIncomingLoanVw);
        }
    }
    #endregion

    #region WarrantVwXmlFormatter
    public class WarrantVwXmlFormatter : XmlFormatterBase
    {
        public WarrantVwXmlFormatter(WarrantVw warrantVw)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(warrantVw);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        public WarrantVwXmlFormatter(Warrant warrant)
        {
            parametersFormat = GetParametersFormat();
            this.Parameters = GetParameters(warrant);
            this.strParameters = XmlFormat(parametersFormat, Parameters);
        }

        private string GetParametersFormat()
        {
            string parametersFormat = "<Params>";
            parametersFormat += "\n\t<Id>{0}</Id>";
            parametersFormat += "\n\t<DebtEmployeeId>{1}</DebtEmployeeId>";
            parametersFormat += "\n\t<DebtEmployeeFullName>{2}</DebtEmployeeFullName>";
            parametersFormat += "\n\t<DebtEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>{3}</DebtEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<DebtEmployeeCategoryName>{4}</DebtEmployeeCategoryName>";
            parametersFormat += "\n\t<DebtAmount>{5}</DebtAmount>";
            parametersFormat += "\n\t<DebtIssuerName>{6}</DebtIssuerName>";
            parametersFormat += "\n\t<DebtDate>{7}</DebtDate>";
            parametersFormat += "\n\t<DebtPeriodInMonths>{8}</DebtPeriodInMonths>";
            parametersFormat += "\n\t<DebtInstallment>{9}</DebtInstallment>";
            parametersFormat += "\n\t<EmployeeId>{10}</EmployeeId>";
            parametersFormat += "\n\t<EmployeeFullName>{11}</EmployeeFullName>";
            parametersFormat += "\n\t<EmployeeDepartmentName>{12}</EmployeeDepartmentName>";
            parametersFormat += "\n\t<EmployeeDepartmentSalaryWorkPlaceName>{13}</EmployeeDepartmentSalaryWorkPlaceName>";
            parametersFormat += "\n\t<EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>{14}</EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName>";
            parametersFormat += "\n\t<EmployeeCategoryName>{15}</EmployeeCategoryName>";
            parametersFormat += "\n\t<IsActive>{16}</IsActive>";
            parametersFormat += "\n\t<Notes>{17}</Notes>";
            parametersFormat += "\n</Params>";
            return parametersFormat;
        }
        
        private string [] GetParameters(WarrantVw warrantVw)
        {
            return new string []
            {
				warrantVw.Id.ToString(),
				warrantVw.DebtEmployeeId.ToString(),
				warrantVw.DebtEmployeeFullName,
				warrantVw.DebtEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName,
				warrantVw.DebtEmployeeCategoryName,
				warrantVw.DebtAmount.ToString(MoneyFormat),
				warrantVw.DebtIssuerName,
				warrantVw.DebtDate == null ? string.Empty : warrantVw.DebtDate.Value.ToString(DateFormat),
				warrantVw.DebtPeriodInMonths == null ? string.Empty : warrantVw.DebtPeriodInMonths.Value.ToString(),
				warrantVw.DebtInstallment.ToString(MoneyFormat),
				warrantVw.EmployeeId.ToString(),
				warrantVw.EmployeeFullName,
				warrantVw.EmployeeDepartmentName,
				warrantVw.EmployeeDepartmentSalaryWorkPlaceName,
				warrantVw.EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName,
				warrantVw.EmployeeCategoryName,
				warrantVw.IsActive.ToString(),
				warrantVw.Notes == null ? string.Empty : warrantVw.Notes
            };
        }
        
        private string [] GetParameters(Warrant warrant)
        {
            WarrantVw warrantVw = new WarrantVw();
            warrantVw.Id = warrant.Id;
            warrantVw.EmployeeId = warrant.Employee;
            warrantVw.IsActive = warrant.IsActive;
            warrantVw.Notes = warrant.Notes;
            return GetParameters(warrantVw);
        }
    }
    #endregion
}
