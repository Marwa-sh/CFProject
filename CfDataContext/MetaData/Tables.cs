using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace Cf.Data
{
	#region Availability meta data class definition
    /// <summary>
    /// Metadata for Availability class
    /// </summary>
	public class AvailabilityMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for Availability.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.Availability))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.Availability))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public short Id { get; set; }
		
        /// <summary>
        /// Metadata for Availability.Name property
        /// </summary>
		[Display(
			Name = "Name",
			ResourceType = typeof(Cf.Data.Resources.Availability))
		]
		[Tooltip("NameTooltip", typeof(Cf.Data.Resources.Availability))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			128,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Name { get; set; }
		
        /// <summary>
        /// Metadata for Availability.MinSeniority property
        /// </summary>
		[Display(
			Name = "MinSeniority",
			ResourceType = typeof(Cf.Data.Resources.Availability))
		]
		[Tooltip("MinSeniorityTooltip", typeof(Cf.Data.Resources.Availability))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte MinSeniority { get; set; }
		
        /// <summary>
        /// Metadata for Availability.MinReusePeriod property
        /// </summary>
		[Display(
			Name = "MinReusePeriod",
			ResourceType = typeof(Cf.Data.Resources.Availability))
		]
		[Tooltip("MinReusePeriodTooltip", typeof(Cf.Data.Resources.Availability))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte MinReusePeriod { get; set; }
		#endregion
	}
	#endregion

	#region AvailabilityCeiling meta data class definition
    /// <summary>
    /// Metadata for AvailabilityCeiling class
    /// </summary>
	public class AvailabilityCeilingMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for AvailabilityCeiling.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.AvailabilityCeiling))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.AvailabilityCeiling))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public short Id { get; set; }
		
        /// <summary>
        /// Metadata for AvailabilityCeiling.Availability property
        /// </summary>
		[Display(
			Name = "Availability",
			ResourceType = typeof(Cf.Data.Resources.AvailabilityCeiling))
		]
		[Tooltip("AvailabilityTooltip", typeof(Cf.Data.Resources.AvailabilityCeiling))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public short Availability { get; set; }
		
        /// <summary>
        /// Metadata for AvailabilityCeiling.FromYear property
        /// </summary>
		[Display(
			Name = "FromYear",
			ResourceType = typeof(Cf.Data.Resources.AvailabilityCeiling))
		]
		[Tooltip("FromYearTooltip", typeof(Cf.Data.Resources.AvailabilityCeiling))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public short FromYear { get; set; }
		
        /// <summary>
        /// Metadata for AvailabilityCeiling.MaxAmount property
        /// </summary>
		[Display(
			Name = "MaxAmount",
			ResourceType = typeof(Cf.Data.Resources.AvailabilityCeiling))
		]
		[Tooltip("MaxAmountTooltip", typeof(Cf.Data.Resources.AvailabilityCeiling))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal MaxAmount { get; set; }
		#endregion
	}
	#endregion

	#region BypassStatus meta data class definition
    /// <summary>
    /// Metadata for BypassStatus class
    /// </summary>
	public class BypassStatusMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for BypassStatus.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.BypassStatus))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.BypassStatus))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Id { get; set; }
		
        /// <summary>
        /// Metadata for BypassStatus.Name property
        /// </summary>
		[Display(
			Name = "Name",
			ResourceType = typeof(Cf.Data.Resources.BypassStatus))
		]
		[Tooltip("NameTooltip", typeof(Cf.Data.Resources.BypassStatus))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			128,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Name { get; set; }
		#endregion
	}
	#endregion

	#region CashPayment meta data class definition
    /// <summary>
    /// Metadata for CashPayment class
    /// </summary>
	public class CashPaymentMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for CashPayment.Payment property
        /// </summary>
		[Display(
			Name = "Payment",
			ResourceType = typeof(Cf.Data.Resources.CashPayment))
		]
		[Tooltip("PaymentTooltip", typeof(Cf.Data.Resources.CashPayment))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Payment { get; set; }
		
        /// <summary>
        /// Metadata for CashPayment.Number property
        /// </summary>
		[Display(
			Name = "Number",
			ResourceType = typeof(Cf.Data.Resources.CashPayment))
		]
		[Tooltip("NumberTooltip", typeof(Cf.Data.Resources.CashPayment))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public short Number { get; set; }
		
        /// <summary>
        /// Metadata for CashPayment.ReceiptNumber property
        /// </summary>
		[Display(
			Name = "ReceiptNumber",
			ResourceType = typeof(Cf.Data.Resources.CashPayment))
		]
		[Tooltip("ReceiptNumberTooltip", typeof(Cf.Data.Resources.CashPayment))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> ReceiptNumber { get; set; }
		
        /// <summary>
        /// Metadata for CashPayment.ReceiptDate property
        /// </summary>
		[Display(
			Name = "ReceiptDate",
			ResourceType = typeof(Cf.Data.Resources.CashPayment))
		]
		[Tooltip("ReceiptDateTooltip", typeof(Cf.Data.Resources.CashPayment))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> ReceiptDate { get; set; }
		
        /// <summary>
        /// Metadata for CashPayment.FeeAmount property
        /// </summary>
		[Display(
			Name = "FeeAmount",
			ResourceType = typeof(Cf.Data.Resources.CashPayment))
		]
		[Tooltip("FeeAmountTooltip", typeof(Cf.Data.Resources.CashPayment))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal FeeAmount { get; set; }
		#endregion
	}
	#endregion

	#region Category meta data class definition
    /// <summary>
    /// Metadata for Category class
    /// </summary>
	public class CategoryMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for Category.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.Category))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.Category))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte Id { get; set; }
		
        /// <summary>
        /// Metadata for Category.Name property
        /// </summary>
		[Display(
			Name = "Name",
			ResourceType = typeof(Cf.Data.Resources.Category))
		]
		[Tooltip("NameTooltip", typeof(Cf.Data.Resources.Category))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Name { get; set; }
		#endregion
	}
	#endregion

	#region CollectOrder meta data class definition
    /// <summary>
    /// Metadata for CollectOrder class
    /// </summary>
	public class CollectOrderMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for CollectOrder.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.CollectOrder))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.CollectOrder))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Id { get; set; }
		
        /// <summary>
        /// Metadata for CollectOrder.Number property
        /// </summary>
		[Display(
			Name = "Number",
			ResourceType = typeof(Cf.Data.Resources.CollectOrder))
		]
		[Tooltip("NumberTooltip", typeof(Cf.Data.Resources.CollectOrder))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<short> Number { get; set; }
		
        /// <summary>
        /// Metadata for CollectOrder.Date property
        /// </summary>
		[Display(
			Name = "Date",
			ResourceType = typeof(Cf.Data.Resources.CollectOrder))
		]
		[Tooltip("DateTooltip", typeof(Cf.Data.Resources.CollectOrder))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> Date { get; set; }
		
        /// <summary>
        /// Metadata for CollectOrder.AccountingDocumentNumber property
        /// </summary>
		[Display(
			Name = "AccountingDocumentNumber",
			ResourceType = typeof(Cf.Data.Resources.CollectOrder))
		]
		[Tooltip("AccountingDocumentNumberTooltip", typeof(Cf.Data.Resources.CollectOrder))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<short> AccountingDocumentNumber { get; set; }
		
        /// <summary>
        /// Metadata for CollectOrder.AccountingDocumentDate property
        /// </summary>
		[Display(
			Name = "AccountingDocumentDate",
			ResourceType = typeof(Cf.Data.Resources.CollectOrder))
		]
		[Tooltip("AccountingDocumentDateTooltip", typeof(Cf.Data.Resources.CollectOrder))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> AccountingDocumentDate { get; set; }
		#endregion
	}
	#endregion

	#region Debt meta data class definition
    /// <summary>
    /// Metadata for Debt class
    /// </summary>
	public class DebtMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for Debt.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.Debt))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.Debt))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Id { get; set; }
		
        /// <summary>
        /// Metadata for Debt.Employee property
        /// </summary>
		[Display(
			Name = "Employee",
			ResourceType = typeof(Cf.Data.Resources.Debt))
		]
		[Tooltip("EmployeeTooltip", typeof(Cf.Data.Resources.Debt))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Employee { get; set; }
		
        /// <summary>
        /// Metadata for Debt.Amount property
        /// </summary>
		[Display(
			Name = "Amount",
			ResourceType = typeof(Cf.Data.Resources.Debt))
		]
		[Tooltip("AmountTooltip", typeof(Cf.Data.Resources.Debt))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal Amount { get; set; }
		
        /// <summary>
        /// Metadata for Debt.Issuer property
        /// </summary>
		[Display(
			Name = "Issuer",
			ResourceType = typeof(Cf.Data.Resources.Debt))
		]
		[Tooltip("IssuerTooltip", typeof(Cf.Data.Resources.Debt))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte Issuer { get; set; }
		
        /// <summary>
        /// Metadata for Debt.ReferenceNumber property
        /// </summary>
		[Display(
			Name = "ReferenceNumber",
			ResourceType = typeof(Cf.Data.Resources.Debt))
		]
		[Tooltip("ReferenceNumberTooltip", typeof(Cf.Data.Resources.Debt))]
		[StringLength(
			20,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string ReferenceNumber { get; set; }
		
        /// <summary>
        /// Metadata for Debt.Date property
        /// </summary>
		[Display(
			Name = "Date",
			ResourceType = typeof(Cf.Data.Resources.Debt))
		]
		[Tooltip("DateTooltip", typeof(Cf.Data.Resources.Debt))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> Date { get; set; }
		
        /// <summary>
        /// Metadata for Debt.PeriodInMonths property
        /// </summary>
		[Display(
			Name = "PeriodInMonths",
			ResourceType = typeof(Cf.Data.Resources.Debt))
		]
		[Tooltip("PeriodInMonthsTooltip", typeof(Cf.Data.Resources.Debt))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<byte> PeriodInMonths { get; set; }
		
        /// <summary>
        /// Metadata for Debt.ExceptionalPayment property
        /// </summary>
		[Display(
			Name = "ExceptionalPayment",
			ResourceType = typeof(Cf.Data.Resources.Debt))
		]
		[Tooltip("ExceptionalPaymentTooltip", typeof(Cf.Data.Resources.Debt))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal ExceptionalPayment { get; set; }
		
        /// <summary>
        /// Metadata for Debt.IsActive property
        /// </summary>
		[Display(
			Name = "IsActive",
			ResourceType = typeof(Cf.Data.Resources.Debt))
		]
		[Tooltip("IsActiveTooltip", typeof(Cf.Data.Resources.Debt))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public bool IsActive { get; set; }
		
        /// <summary>
        /// Metadata for Debt.Notes property
        /// </summary>
		[Display(
			Name = "Notes",
			ResourceType = typeof(Cf.Data.Resources.Debt))
		]
		[Tooltip("NotesTooltip", typeof(Cf.Data.Resources.Debt))]
		[StringLength(
			200,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Notes { get; set; }
		
        /// <summary>
        /// Metadata for Debt.IssueDescription property
        /// </summary>
		[Display(
			Name = "IssueDescription",
			ResourceType = typeof(Cf.Data.Resources.Debt))
		]
		[Tooltip("IssueDescriptionTooltip", typeof(Cf.Data.Resources.Debt))]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string IssueDescription { get; set; }
		
        /// <summary>
        /// Metadata for Debt.Installment property
        /// </summary>
		[Display(
			Name = "Installment",
			ResourceType = typeof(Cf.Data.Resources.Debt))
		]
		[Tooltip("InstallmentTooltip", typeof(Cf.Data.Resources.Debt))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal Installment { get; set; }
		#endregion
	}
	#endregion

	#region Department meta data class definition
    /// <summary>
    /// Metadata for Department class
    /// </summary>
	public class DepartmentMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for Department.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.Department))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.Department))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Id { get; set; }
		
        /// <summary>
        /// Metadata for Department.Name property
        /// </summary>
		[Display(
			Name = "Name",
			ResourceType = typeof(Cf.Data.Resources.Department))
		]
		[Tooltip("NameTooltip", typeof(Cf.Data.Resources.Department))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Name { get; set; }
		
        /// <summary>
        /// Metadata for Department.SalaryWorkPlace property
        /// </summary>
		[Display(
			Name = "SalaryWorkPlace",
			ResourceType = typeof(Cf.Data.Resources.Department))
		]
		[Tooltip("SalaryWorkPlaceTooltip", typeof(Cf.Data.Resources.Department))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int SalaryWorkPlace { get; set; }
		#endregion
	}
	#endregion

	#region DownPayment meta data class definition
    /// <summary>
    /// Metadata for DownPayment class
    /// </summary>
	public class DownPaymentMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for DownPayment.Payment property
        /// </summary>
		[Display(
			Name = "Payment",
			ResourceType = typeof(Cf.Data.Resources.DownPayment))
		]
		[Tooltip("PaymentTooltip", typeof(Cf.Data.Resources.DownPayment))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Payment { get; set; }
		
        /// <summary>
        /// Metadata for DownPayment.Request property
        /// </summary>
		[Display(
			Name = "Request",
			ResourceType = typeof(Cf.Data.Resources.DownPayment))
		]
		[Tooltip("RequestTooltip", typeof(Cf.Data.Resources.DownPayment))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Request { get; set; }
		#endregion
	}
	#endregion

	#region Employee meta data class definition
    /// <summary>
    /// Metadata for Employee class
    /// </summary>
	public partial class EmployeeMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for Employee.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.Employee))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.Employee))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Id { get; set; }
		
        /// <summary>
        /// Metadata for Employee.FirstName property
        /// </summary>
		[Display(
			Name = "FirstName",
			ResourceType = typeof(Cf.Data.Resources.Employee))
		]
		[Tooltip("FirstNameTooltip", typeof(Cf.Data.Resources.Employee))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string FirstName { get; set; }
		
        /// <summary>
        /// Metadata for Employee.LastName property
        /// </summary>
		[Display(
			Name = "LastName",
			ResourceType = typeof(Cf.Data.Resources.Employee))
		]
		[Tooltip("LastNameTooltip", typeof(Cf.Data.Resources.Employee))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string LastName { get; set; }
		
        /// <summary>
        /// Metadata for Employee.FatherName property
        /// </summary>
		[Display(
			Name = "FatherName",
			ResourceType = typeof(Cf.Data.Resources.Employee))
		]
		[Tooltip("FatherNameTooltip", typeof(Cf.Data.Resources.Employee))]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string FatherName { get; set; }
		
        /// <summary>
        /// Metadata for Employee.MotherName property
        /// </summary>
		[Display(
			Name = "MotherName",
			ResourceType = typeof(Cf.Data.Resources.Employee))
		]
		[Tooltip("MotherNameTooltip", typeof(Cf.Data.Resources.Employee))]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string MotherName { get; set; }
		
        /// <summary>
        /// Metadata for Employee.BirthDate property
        /// </summary>
		[Display(
			Name = "BirthDate",
			ResourceType = typeof(Cf.Data.Resources.Employee))
		]
		[Tooltip("BirthDateTooltip", typeof(Cf.Data.Resources.Employee))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[DisplayFormat(
			ApplyFormatInEditMode = true,
			//ConvertEmptyStringToNull = true,
			DataFormatString = "{0:dd/MM/yyyy}")]
        public Nullable<DateTime> BirthDate { get; set; }
		
        /// <summary>
        /// Metadata for Employee.ExpectedEndDate property
        /// </summary>
		[Display(
			Name = "ExpectedEndDate",
			ResourceType = typeof(Cf.Data.Resources.Employee))
		]
		[Tooltip("ExpectedEndDateTooltip", typeof(Cf.Data.Resources.Employee))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> ExpectedEndDate { get; set; }
		
        /// <summary>
        /// Metadata for Employee.CersStartDate property
        /// </summary>
		[Display(
			Name = "CersStartDate",
			ResourceType = typeof(Cf.Data.Resources.Employee))
		]
		[Tooltip("CersStartDateTooltip", typeof(Cf.Data.Resources.Employee))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> CersStartDate { get; set; }
		
        /// <summary>
        /// Metadata for Employee.CfStartDate property
        /// </summary>
		[Display(
			Name = "CfStartDate",
			ResourceType = typeof(Cf.Data.Resources.Employee))
		]
		[Tooltip("CfStartDateTooltip", typeof(Cf.Data.Resources.Employee))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> CfStartDate { get; set; }
		
        /// <summary>
        /// Metadata for Employee.LeaveDate property
        /// </summary>
		[Display(
			Name = "LeaveDate",
			ResourceType = typeof(Cf.Data.Resources.Employee))
		]
		[Tooltip("LeaveDateTooltip", typeof(Cf.Data.Resources.Employee))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> LeaveDate { get; set; }
		
        /// <summary>
        /// Metadata for Employee.LeaveReason property
        /// </summary>
		[Display(
			Name = "LeaveReason",
			ResourceType = typeof(Cf.Data.Resources.Employee))
		]
		[Tooltip("LeaveReasonTooltip", typeof(Cf.Data.Resources.Employee))]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string LeaveReason { get; set; }
		
        /// <summary>
        /// Metadata for Employee.EmployeeStatus property
        /// </summary>
		[Display(
			Name = "EmployeeStatus",
			ResourceType = typeof(Cf.Data.Resources.Employee))
		]
		[Tooltip("EmployeeStatusTooltip", typeof(Cf.Data.Resources.Employee))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte EmployeeStatus { get; set; }
		
        /// <summary>
        /// Metadata for Employee.Department property
        /// </summary>
		[Display(
			Name = "Department",
			ResourceType = typeof(Cf.Data.Resources.Employee))
		]
		[Tooltip("DepartmentTooltip", typeof(Cf.Data.Resources.Employee))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Department { get; set; }
		
        /// <summary>
        /// Metadata for Employee.Notes property
        /// </summary>
		[Display(
			Name = "Notes",
			ResourceType = typeof(Cf.Data.Resources.Employee))
		]
		[Tooltip("NotesTooltip", typeof(Cf.Data.Resources.Employee))]
		[StringLength(
			500,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Notes { get; set; }
		
        /// <summary>
        /// Metadata for Employee.Category property
        /// </summary>
		[Display(
			Name = "Category",
			ResourceType = typeof(Cf.Data.Resources.Employee))
		]
		[Tooltip("CategoryTooltip", typeof(Cf.Data.Resources.Employee))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte Category { get; set; }
		#endregion
	}
	#endregion

	#region EmployeeSeniority meta data class definition
    /// <summary>
    /// Metadata for EmployeeSeniority class
    /// </summary>
	public class EmployeeSeniorityMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for EmployeeSeniority.Employee property
        /// </summary>
		[Display(
			Name = "Employee",
			ResourceType = typeof(Cf.Data.Resources.EmployeeSeniority))
		]
		[Tooltip("EmployeeTooltip", typeof(Cf.Data.Resources.EmployeeSeniority))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Employee { get; set; }
		
        /// <summary>
        /// Metadata for EmployeeSeniority.ServiceInDays property
        /// </summary>
		[Display(
			Name = "ServiceInDays",
			ResourceType = typeof(Cf.Data.Resources.EmployeeSeniority))
		]
		[Tooltip("ServiceInDaysTooltip", typeof(Cf.Data.Resources.EmployeeSeniority))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public short ServiceInDays { get; set; }
		#endregion
	}
	#endregion

	#region EmployeeStatus meta data class definition
    /// <summary>
    /// Metadata for EmployeeStatus class
    /// </summary>
	public class EmployeeStatusMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for EmployeeStatus.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.EmployeeStatus))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.EmployeeStatus))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte Id { get; set; }
		
        /// <summary>
        /// Metadata for EmployeeStatus.Name property
        /// </summary>
		[Display(
			Name = "Name",
			ResourceType = typeof(Cf.Data.Resources.EmployeeStatus))
		]
		[Tooltip("NameTooltip", typeof(Cf.Data.Resources.EmployeeStatus))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Name { get; set; }
		
        /// <summary>
        /// Metadata for EmployeeStatus.IsActive property
        /// </summary>
		[Display(
			Name = "IsActive",
			ResourceType = typeof(Cf.Data.Resources.EmployeeStatus))
		]
		[Tooltip("IsActiveTooltip", typeof(Cf.Data.Resources.EmployeeStatus))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public bool IsActive { get; set; }
		#endregion
	}
	#endregion

	#region EndWorkGrantBracket meta data class definition
    /// <summary>
    /// Metadata for EndWorkGrantBracket class
    /// </summary>
	public class EndWorkGrantBracketMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for EndWorkGrantBracket.FromYear property
        /// </summary>
		[Display(
			Name = "FromYear",
			ResourceType = typeof(Cf.Data.Resources.EndWorkGrantBracket))
		]
		[Tooltip("FromYearTooltip", typeof(Cf.Data.Resources.EndWorkGrantBracket))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte FromYear { get; set; }
		
        /// <summary>
        /// Metadata for EndWorkGrantBracket.Percentage property
        /// </summary>
		[Display(
			Name = "Percentage",
			ResourceType = typeof(Cf.Data.Resources.EndWorkGrantBracket))
		]
		[Tooltip("PercentageTooltip", typeof(Cf.Data.Resources.EndWorkGrantBracket))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal Percentage { get; set; }
		#endregion
	}
	#endregion

	#region ErrorDefinition meta data class definition
    /// <summary>
    /// Metadata for ErrorDefinition class
    /// </summary>
	public class ErrorDefinitionMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for ErrorDefinition.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.ErrorDefinition))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.ErrorDefinition))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Id { get; set; }
		
        /// <summary>
        /// Metadata for ErrorDefinition.Message property
        /// </summary>
		[Display(
			Name = "Message",
			ResourceType = typeof(Cf.Data.Resources.ErrorDefinition))
		]
		[Tooltip("MessageTooltip", typeof(Cf.Data.Resources.ErrorDefinition))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			1024,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Message { get; set; }
		
        /// <summary>
        /// Metadata for ErrorDefinition.LocalizedMessage property
        /// </summary>
		[Display(
			Name = "LocalizedMessage",
			ResourceType = typeof(Cf.Data.Resources.ErrorDefinition))
		]
		[Tooltip("LocalizedMessageTooltip", typeof(Cf.Data.Resources.ErrorDefinition))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			1024,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string LocalizedMessage { get; set; }
		
        /// <summary>
        /// Metadata for ErrorDefinition.LikeExpression property
        /// </summary>
		[Display(
			Name = "LikeExpression",
			ResourceType = typeof(Cf.Data.Resources.ErrorDefinition))
		]
		[Tooltip("LikeExpressionTooltip", typeof(Cf.Data.Resources.ErrorDefinition))]
		[StringLength(
			256,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string LikeExpression { get; set; }
		#endregion
	}
	#endregion

	#region EventCategory meta data class definition
    /// <summary>
    /// Metadata for EventCategory class
    /// </summary>
	public class EventCategoryMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for EventCategory.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.EventCategory))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.EventCategory))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Id { get; set; }
		
        /// <summary>
        /// Metadata for EventCategory.Name property
        /// </summary>
		[Display(
			Name = "Name",
			ResourceType = typeof(Cf.Data.Resources.EventCategory))
		]
		[Tooltip("NameTooltip", typeof(Cf.Data.Resources.EventCategory))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			128,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Name { get; set; }
		#endregion
	}
	#endregion

	#region EventLog meta data class definition
    /// <summary>
    /// Metadata for EventLog class
    /// </summary>
	public class EventLogMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for EventLog.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.EventLog))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.EventLog))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			9223372036854775807,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public long Id { get; set; }
		
        /// <summary>
        /// Metadata for EventLog.EventSource property
        /// </summary>
		[Display(
			Name = "EventSource",
			ResourceType = typeof(Cf.Data.Resources.EventLog))
		]
		[Tooltip("EventSourceTooltip", typeof(Cf.Data.Resources.EventLog))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int EventSource { get; set; }
		
        /// <summary>
        /// Metadata for EventLog.EventCategory property
        /// </summary>
		[Display(
			Name = "EventCategory",
			ResourceType = typeof(Cf.Data.Resources.EventLog))
		]
		[Tooltip("EventCategoryTooltip", typeof(Cf.Data.Resources.EventLog))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int EventCategory { get; set; }
		
        /// <summary>
        /// Metadata for EventLog.EventStatus property
        /// </summary>
		[Display(
			Name = "EventStatus",
			ResourceType = typeof(Cf.Data.Resources.EventLog))
		]
		[Tooltip("EventStatusTooltip", typeof(Cf.Data.Resources.EventLog))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int EventStatus { get; set; }
		
        /// <summary>
        /// Metadata for EventLog.Parameters property
        /// </summary>
		[Display(
			Name = "Parameters",
			ResourceType = typeof(Cf.Data.Resources.EventLog))
		]
		[Tooltip("ParametersTooltip", typeof(Cf.Data.Resources.EventLog))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Parameters { get; set; }
		
        /// <summary>
        /// Metadata for EventLog.Date property
        /// </summary>
		[Display(
			Name = "Date",
			ResourceType = typeof(Cf.Data.Resources.EventLog))
		]
		[Tooltip("DateTooltip", typeof(Cf.Data.Resources.EventLog))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[DataType(
			DataType.DateTime,
			ErrorMessageResourceName = "DateTimeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public DateTime Date { get; set; }
		
        /// <summary>
        /// Metadata for EventLog.User property
        /// </summary>
		[Display(
			Name = "User",
			ResourceType = typeof(Cf.Data.Resources.EventLog))
		]
		[Tooltip("UserTooltip", typeof(Cf.Data.Resources.EventLog))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int User { get; set; }
		#endregion
	}
	#endregion

	#region EventLogError meta data class definition
    /// <summary>
    /// Metadata for EventLogError class
    /// </summary>
	public class EventLogErrorMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for EventLogError.EventLog property
        /// </summary>
		[Display(
			Name = "EventLog",
			ResourceType = typeof(Cf.Data.Resources.EventLogError))
		]
		[Tooltip("EventLogTooltip", typeof(Cf.Data.Resources.EventLogError))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			9223372036854775807,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public long EventLog { get; set; }
		
        /// <summary>
        /// Metadata for EventLogError.Number property
        /// </summary>
		[Display(
			Name = "Number",
			ResourceType = typeof(Cf.Data.Resources.EventLogError))
		]
		[Tooltip("NumberTooltip", typeof(Cf.Data.Resources.EventLogError))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Number { get; set; }
		
        /// <summary>
        /// Metadata for EventLogError.Message property
        /// </summary>
		[Display(
			Name = "Message",
			ResourceType = typeof(Cf.Data.Resources.EventLogError))
		]
		[Tooltip("MessageTooltip", typeof(Cf.Data.Resources.EventLogError))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			1000,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Message { get; set; }
		
        /// <summary>
        /// Metadata for EventLogError.StackTrace property
        /// </summary>
		[Display(
			Name = "StackTrace",
			ResourceType = typeof(Cf.Data.Resources.EventLogError))
		]
		[Tooltip("StackTraceTooltip", typeof(Cf.Data.Resources.EventLogError))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			4000,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string StackTrace { get; set; }
		#endregion
	}
	#endregion

	#region EventSource meta data class definition
    /// <summary>
    /// Metadata for EventSource class
    /// </summary>
	public class EventSourceMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for EventSource.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.EventSource))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.EventSource))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Id { get; set; }
		
        /// <summary>
        /// Metadata for EventSource.Name property
        /// </summary>
		[Display(
			Name = "Name",
			ResourceType = typeof(Cf.Data.Resources.EventSource))
		]
		[Tooltip("NameTooltip", typeof(Cf.Data.Resources.EventSource))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			128,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Name { get; set; }
		#endregion
	}
	#endregion

	#region EventStatus meta data class definition
    /// <summary>
    /// Metadata for EventStatus class
    /// </summary>
	public class EventStatusMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for EventStatus.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.EventStatus))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.EventStatus))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Id { get; set; }
		
        /// <summary>
        /// Metadata for EventStatus.Name property
        /// </summary>
		[Display(
			Name = "Name",
			ResourceType = typeof(Cf.Data.Resources.EventStatus))
		]
		[Tooltip("NameTooltip", typeof(Cf.Data.Resources.EventStatus))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			20,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Name { get; set; }
		
        /// <summary>
        /// Metadata for EventStatus.Icon property
        /// </summary>
		[Display(
			Name = "Icon",
			ResourceType = typeof(Cf.Data.Resources.EventStatus))
		]
		[Tooltip("IconTooltip", typeof(Cf.Data.Resources.EventStatus))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			512,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Icon { get; set; }
		#endregion
	}
	#endregion

	#region ExceptionalAmount meta data class definition
    /// <summary>
    /// Metadata for ExceptionalAmount class
    /// </summary>
	public class ExceptionalAmountMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for ExceptionalAmount.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.ExceptionalAmount))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.ExceptionalAmount))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Id { get; set; }
		
        /// <summary>
        /// Metadata for ExceptionalAmount.LoanRequest property
        /// </summary>
		[Display(
			Name = "LoanRequest",
			ResourceType = typeof(Cf.Data.Resources.ExceptionalAmount))
		]
		[Tooltip("LoanRequestTooltip", typeof(Cf.Data.Resources.ExceptionalAmount))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int LoanRequest { get; set; }
		
        /// <summary>
        /// Metadata for ExceptionalAmount.SubNumber property
        /// </summary>
		[Display(
			Name = "SubNumber",
			ResourceType = typeof(Cf.Data.Resources.ExceptionalAmount))
		]
		[Tooltip("SubNumberTooltip", typeof(Cf.Data.Resources.ExceptionalAmount))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal SubNumber { get; set; }
		
        /// <summary>
        /// Metadata for ExceptionalAmount.Amount property
        /// </summary>
		[Display(
			Name = "Amount",
			ResourceType = typeof(Cf.Data.Resources.ExceptionalAmount))
		]
		[Tooltip("AmountTooltip", typeof(Cf.Data.Resources.ExceptionalAmount))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal Amount { get; set; }
		
        /// <summary>
        /// Metadata for ExceptionalAmount.Notes property
        /// </summary>
		[Display(
			Name = "Notes",
			ResourceType = typeof(Cf.Data.Resources.ExceptionalAmount))
		]
		[Tooltip("NotesTooltip", typeof(Cf.Data.Resources.ExceptionalAmount))]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Notes { get; set; }
		
        /// <summary>
        /// Metadata for ExceptionalAmount.ExceptionalAmountType property
        /// </summary>
		[Display(
			Name = "ExceptionalAmountType",
			ResourceType = typeof(Cf.Data.Resources.ExceptionalAmount))
		]
		[Tooltip("ExceptionalAmountTypeTooltip", typeof(Cf.Data.Resources.ExceptionalAmount))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte ExceptionalAmountType { get; set; }
		#endregion
	}
	#endregion

	#region ExceptionalAmountType meta data class definition
    /// <summary>
    /// Metadata for ExceptionalAmountType class
    /// </summary>
	public class ExceptionalAmountTypeMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for ExceptionalAmountType.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.ExceptionalAmountType))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.ExceptionalAmountType))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte Id { get; set; }
		
        /// <summary>
        /// Metadata for ExceptionalAmountType.Name property
        /// </summary>
		[Display(
			Name = "Name",
			ResourceType = typeof(Cf.Data.Resources.ExceptionalAmountType))
		]
		[Tooltip("NameTooltip", typeof(Cf.Data.Resources.ExceptionalAmountType))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			128,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Name { get; set; }
		
        /// <summary>
        /// Metadata for ExceptionalAmountType.IsIncome property
        /// </summary>
		[Display(
			Name = "IsIncome",
			ResourceType = typeof(Cf.Data.Resources.ExceptionalAmountType))
		]
		[Tooltip("IsIncomeTooltip", typeof(Cf.Data.Resources.ExceptionalAmountType))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public bool IsIncome { get; set; }
		#endregion
	}
	#endregion

	#region ExternalGrant meta data class definition
    /// <summary>
    /// Metadata for ExternalGrant class
    /// </summary>
	public class ExternalGrantMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for ExternalGrant.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.ExternalGrant))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.ExternalGrant))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Id { get; set; }
		
        /// <summary>
        /// Metadata for ExternalGrant.Employee property
        /// </summary>
		[Display(
			Name = "Employee",
			ResourceType = typeof(Cf.Data.Resources.ExternalGrant))
		]
		[Tooltip("EmployeeTooltip", typeof(Cf.Data.Resources.ExternalGrant))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Employee { get; set; }
		
        /// <summary>
        /// Metadata for ExternalGrant.RequestDate property
        /// </summary>
		[Display(
			Name = "RequestDate",
			ResourceType = typeof(Cf.Data.Resources.ExternalGrant))
		]
		[Tooltip("RequestDateTooltip", typeof(Cf.Data.Resources.ExternalGrant))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> RequestDate { get; set; }
		
        /// <summary>
        /// Metadata for ExternalGrant.GrantType property
        /// </summary>
		[Display(
			Name = "GrantType",
			ResourceType = typeof(Cf.Data.Resources.ExternalGrant))
		]
		[Tooltip("GrantTypeTooltip", typeof(Cf.Data.Resources.ExternalGrant))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte GrantType { get; set; }
		
        /// <summary>
        /// Metadata for ExternalGrant.Description property
        /// </summary>
		[Display(
			Name = "Description",
			ResourceType = typeof(Cf.Data.Resources.ExternalGrant))
		]
		[Tooltip("DescriptionTooltip", typeof(Cf.Data.Resources.ExternalGrant))]
		[StringLength(
			100,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Description { get; set; }
		
        /// <summary>
        /// Metadata for ExternalGrant.Amount property
        /// </summary>
		[Display(
			Name = "Amount",
			ResourceType = typeof(Cf.Data.Resources.ExternalGrant))
		]
		[Tooltip("AmountTooltip", typeof(Cf.Data.Resources.ExternalGrant))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal Amount { get; set; }
		
        /// <summary>
        /// Metadata for ExternalGrant.CersNumber property
        /// </summary>
		[Display(
			Name = "CersNumber",
			ResourceType = typeof(Cf.Data.Resources.ExternalGrant))
		]
		[Tooltip("CersNumberTooltip", typeof(Cf.Data.Resources.ExternalGrant))]
		[StringLength(
			25,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string CersNumber { get; set; }
		
        /// <summary>
        /// Metadata for ExternalGrant.CersDate property
        /// </summary>
		[Display(
			Name = "CersDate",
			ResourceType = typeof(Cf.Data.Resources.ExternalGrant))
		]
		[Tooltip("CersDateTooltip", typeof(Cf.Data.Resources.ExternalGrant))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> CersDate { get; set; }
		
        /// <summary>
        /// Metadata for ExternalGrant.PaymentNumber property
        /// </summary>
		[Display(
			Name = "PaymentNumber",
			ResourceType = typeof(Cf.Data.Resources.ExternalGrant))
		]
		[Tooltip("PaymentNumberTooltip", typeof(Cf.Data.Resources.ExternalGrant))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<short> PaymentNumber { get; set; }
		
        /// <summary>
        /// Metadata for ExternalGrant.PaymentDate property
        /// </summary>
		[Display(
			Name = "PaymentDate",
			ResourceType = typeof(Cf.Data.Resources.ExternalGrant))
		]
		[Tooltip("PaymentDateTooltip", typeof(Cf.Data.Resources.ExternalGrant))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> PaymentDate { get; set; }
		
        /// <summary>
        /// Metadata for ExternalGrant.Notes property
        /// </summary>
		[Display(
			Name = "Notes",
			ResourceType = typeof(Cf.Data.Resources.ExternalGrant))
		]
		[Tooltip("NotesTooltip", typeof(Cf.Data.Resources.ExternalGrant))]
		[StringLength(
			300,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Notes { get; set; }
		#endregion
	}
	#endregion

	#region Grant meta data class definition
    /// <summary>
    /// Metadata for Grant class
    /// </summary>
	public class GrantMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for Grant.Product property
        /// </summary>
		[Display(
			Name = "Product",
			ResourceType = typeof(Cf.Data.Resources.Grant))
		]
		[Tooltip("ProductTooltip", typeof(Cf.Data.Resources.Grant))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Product { get; set; }
		
        /// <summary>
        /// Metadata for Grant.GrantDecision property
        /// </summary>
		[Display(
			Name = "GrantDecision",
			ResourceType = typeof(Cf.Data.Resources.Grant))
		]
		[Tooltip("GrantDecisionTooltip", typeof(Cf.Data.Resources.Grant))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int GrantDecision { get; set; }
		
        /// <summary>
        /// Metadata for Grant.Amount property
        /// </summary>
		[Display(
			Name = "Amount",
			ResourceType = typeof(Cf.Data.Resources.Grant))
		]
		[Tooltip("AmountTooltip", typeof(Cf.Data.Resources.Grant))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal Amount { get; set; }
		#endregion
	}
	#endregion

	#region GrantDecision meta data class definition
    /// <summary>
    /// Metadata for GrantDecision class
    /// </summary>
	public class GrantDecisionMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for GrantDecision.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.GrantDecision))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.GrantDecision))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Id { get; set; }
		
        /// <summary>
        /// Metadata for GrantDecision.Number property
        /// </summary>
		[Display(
			Name = "Number",
			ResourceType = typeof(Cf.Data.Resources.GrantDecision))
		]
		[Tooltip("NumberTooltip", typeof(Cf.Data.Resources.GrantDecision))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public short Number { get; set; }
		
        /// <summary>
        /// Metadata for GrantDecision.Year property
        /// </summary>
		[Display(
			Name = "Year",
			ResourceType = typeof(Cf.Data.Resources.GrantDecision))
		]
		[Tooltip("YearTooltip", typeof(Cf.Data.Resources.GrantDecision))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public short Year { get; set; }
		
        /// <summary>
        /// Metadata for GrantDecision.GrantTypeGroup property
        /// </summary>
		[Display(
			Name = "GrantTypeGroup",
			ResourceType = typeof(Cf.Data.Resources.GrantDecision))
		]
		[Tooltip("GrantTypeGroupTooltip", typeof(Cf.Data.Resources.GrantDecision))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte GrantTypeGroup { get; set; }
		
        /// <summary>
        /// Metadata for GrantDecision.Date property
        /// </summary>
		[Display(
			Name = "Date",
			ResourceType = typeof(Cf.Data.Resources.GrantDecision))
		]
		[Tooltip("DateTooltip", typeof(Cf.Data.Resources.GrantDecision))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public DateTime Date { get; set; }
		
        /// <summary>
        /// Metadata for GrantDecision.CersNumber property
        /// </summary>
		[Display(
			Name = "CersNumber",
			ResourceType = typeof(Cf.Data.Resources.GrantDecision))
		]
		[Tooltip("CersNumberTooltip", typeof(Cf.Data.Resources.GrantDecision))]
		[StringLength(
			20,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string CersNumber { get; set; }
		
        /// <summary>
        /// Metadata for GrantDecision.CersDate property
        /// </summary>
		[Display(
			Name = "CersDate",
			ResourceType = typeof(Cf.Data.Resources.GrantDecision))
		]
		[Tooltip("CersDateTooltip", typeof(Cf.Data.Resources.GrantDecision))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> CersDate { get; set; }
		
        /// <summary>
        /// Metadata for GrantDecision.PaymentNumber property
        /// </summary>
		[Display(
			Name = "PaymentNumber",
			ResourceType = typeof(Cf.Data.Resources.GrantDecision))
		]
		[Tooltip("PaymentNumberTooltip", typeof(Cf.Data.Resources.GrantDecision))]
		[StringLength(
			20,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string PaymentNumber { get; set; }
		
        /// <summary>
        /// Metadata for GrantDecision.PaymentDate property
        /// </summary>
		[Display(
			Name = "PaymentDate",
			ResourceType = typeof(Cf.Data.Resources.GrantDecision))
		]
		[Tooltip("PaymentDateTooltip", typeof(Cf.Data.Resources.GrantDecision))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> PaymentDate { get; set; }
		
        /// <summary>
        /// Metadata for GrantDecision.Notes property
        /// </summary>
		[Display(
			Name = "Notes",
			ResourceType = typeof(Cf.Data.Resources.GrantDecision))
		]
		[Tooltip("NotesTooltip", typeof(Cf.Data.Resources.GrantDecision))]
		[StringLength(
			300,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Notes { get; set; }
		
        /// <summary>
        /// Metadata for GrantDecision.TableNumber property
        /// </summary>
		[Display(
			Name = "TableNumber",
			ResourceType = typeof(Cf.Data.Resources.GrantDecision))
		]
		[Tooltip("TableNumberTooltip", typeof(Cf.Data.Resources.GrantDecision))]
		[StringLength(
			20,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string TableNumber { get; set; }
		
        /// <summary>
        /// Metadata for GrantDecision.TableDate property
        /// </summary>
		[Display(
			Name = "TableDate",
			ResourceType = typeof(Cf.Data.Resources.GrantDecision))
		]
		[Tooltip("TableDateTooltip", typeof(Cf.Data.Resources.GrantDecision))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> TableDate { get; set; }
		
        /// <summary>
        /// Metadata for GrantDecision.BaseNumber property
        /// </summary>
		[Display(
			Name = "BaseNumber",
			ResourceType = typeof(Cf.Data.Resources.GrantDecision))
		]
		[Tooltip("BaseNumberTooltip", typeof(Cf.Data.Resources.GrantDecision))]
		[StringLength(
			20,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string BaseNumber { get; set; }
		
        /// <summary>
        /// Metadata for GrantDecision.BaseDate property
        /// </summary>
		[Display(
			Name = "BaseDate",
			ResourceType = typeof(Cf.Data.Resources.GrantDecision))
		]
		[Tooltip("BaseDateTooltip", typeof(Cf.Data.Resources.GrantDecision))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> BaseDate { get; set; }
		
        /// <summary>
        /// Metadata for GrantDecision.AdditionalClause property
        /// </summary>
		[Display(
			Name = "AdditionalClause",
			ResourceType = typeof(Cf.Data.Resources.GrantDecision))
		]
		[Tooltip("AdditionalClauseTooltip", typeof(Cf.Data.Resources.GrantDecision))]
		[StringLength(
			500,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string AdditionalClause { get; set; }
		
        /// <summary>
        /// Metadata for GrantDecision.AdditionalIntroduction property
        /// </summary>
		[Display(
			Name = "AdditionalIntroduction",
			ResourceType = typeof(Cf.Data.Resources.GrantDecision))
		]
		[Tooltip("AdditionalIntroductionTooltip", typeof(Cf.Data.Resources.GrantDecision))]
		[StringLength(
			500,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string AdditionalIntroduction { get; set; }
		#endregion
	}
	#endregion

	#region GrantDeduction meta data class definition
    /// <summary>
    /// Metadata for GrantDeduction class
    /// </summary>
	public class GrantDeductionMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for GrantDeduction.Grant property
        /// </summary>
		[Display(
			Name = "Grant",
			ResourceType = typeof(Cf.Data.Resources.GrantDeduction))
		]
		[Tooltip("GrantTooltip", typeof(Cf.Data.Resources.GrantDeduction))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Grant { get; set; }
		
        /// <summary>
        /// Metadata for GrantDeduction.Amount property
        /// </summary>
		[Display(
			Name = "Amount",
			ResourceType = typeof(Cf.Data.Resources.GrantDeduction))
		]
		[Tooltip("AmountTooltip", typeof(Cf.Data.Resources.GrantDeduction))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal Amount { get; set; }
		
        /// <summary>
        /// Metadata for GrantDeduction.Description property
        /// </summary>
		[Display(
			Name = "Description",
			ResourceType = typeof(Cf.Data.Resources.GrantDeduction))
		]
		[Tooltip("DescriptionTooltip", typeof(Cf.Data.Resources.GrantDeduction))]
		[StringLength(
			200,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Description { get; set; }
		#endregion
	}
	#endregion

	#region GrantPayment meta data class definition
    /// <summary>
    /// Metadata for GrantPayment class
    /// </summary>
	public class GrantPaymentMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for GrantPayment.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.GrantPayment))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.GrantPayment))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Id { get; set; }
		
        /// <summary>
        /// Metadata for GrantPayment.GrantPaymentOrder property
        /// </summary>
		[Display(
			Name = "GrantPaymentOrder",
			ResourceType = typeof(Cf.Data.Resources.GrantPayment))
		]
		[Tooltip("GrantPaymentOrderTooltip", typeof(Cf.Data.Resources.GrantPayment))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int GrantPaymentOrder { get; set; }
		
        /// <summary>
        /// Metadata for GrantPayment.SubNumber property
        /// </summary>
		[Display(
			Name = "SubNumber",
			ResourceType = typeof(Cf.Data.Resources.GrantPayment))
		]
		[Tooltip("SubNumberTooltip", typeof(Cf.Data.Resources.GrantPayment))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte SubNumber { get; set; }
		
        /// <summary>
        /// Metadata for GrantPayment.Grant property
        /// </summary>
		[Display(
			Name = "Grant",
			ResourceType = typeof(Cf.Data.Resources.GrantPayment))
		]
		[Tooltip("GrantTooltip", typeof(Cf.Data.Resources.GrantPayment))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Grant { get; set; }
		
        /// <summary>
        /// Metadata for GrantPayment.Amount property
        /// </summary>
		[Display(
			Name = "Amount",
			ResourceType = typeof(Cf.Data.Resources.GrantPayment))
		]
		[Tooltip("AmountTooltip", typeof(Cf.Data.Resources.GrantPayment))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal Amount { get; set; }
		
        /// <summary>
        /// Metadata for GrantPayment.Notes property
        /// </summary>
		[Display(
			Name = "Notes",
			ResourceType = typeof(Cf.Data.Resources.GrantPayment))
		]
		[Tooltip("NotesTooltip", typeof(Cf.Data.Resources.GrantPayment))]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Notes { get; set; }
		#endregion
	}
	#endregion

	#region GrantPaymentOrder meta data class definition
    /// <summary>
    /// Metadata for GrantPaymentOrder class
    /// </summary>
	public class GrantPaymentOrderMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for GrantPaymentOrder.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.GrantPaymentOrder))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.GrantPaymentOrder))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Id { get; set; }
		
        /// <summary>
        /// Metadata for GrantPaymentOrder.Number property
        /// </summary>
		[Display(
			Name = "Number",
			ResourceType = typeof(Cf.Data.Resources.GrantPaymentOrder))
		]
		[Tooltip("NumberTooltip", typeof(Cf.Data.Resources.GrantPaymentOrder))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public short Number { get; set; }
		
        /// <summary>
        /// Metadata for GrantPaymentOrder.Year property
        /// </summary>
		[Display(
			Name = "Year",
			ResourceType = typeof(Cf.Data.Resources.GrantPaymentOrder))
		]
		[Tooltip("YearTooltip", typeof(Cf.Data.Resources.GrantPaymentOrder))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public short Year { get; set; }
		
        /// <summary>
        /// Metadata for GrantPaymentOrder.Date property
        /// </summary>
		[Display(
			Name = "Date",
			ResourceType = typeof(Cf.Data.Resources.GrantPaymentOrder))
		]
		[Tooltip("DateTooltip", typeof(Cf.Data.Resources.GrantPaymentOrder))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public DateTime Date { get; set; }
		
        /// <summary>
        /// Metadata for GrantPaymentOrder.Notes property
        /// </summary>
		[Display(
			Name = "Notes",
			ResourceType = typeof(Cf.Data.Resources.GrantPaymentOrder))
		]
		[Tooltip("NotesTooltip", typeof(Cf.Data.Resources.GrantPaymentOrder))]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Notes { get; set; }
		#endregion
	}
	#endregion

	#region GrantRequest meta data class definition
    /// <summary>
    /// Metadata for GrantRequest class
    /// </summary>
	public class GrantRequestMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for GrantRequest.Request property
        /// </summary>
		[Display(
			Name = "Request",
			ResourceType = typeof(Cf.Data.Resources.GrantRequest))
		]
		[Tooltip("RequestTooltip", typeof(Cf.Data.Resources.GrantRequest))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Request { get; set; }
		
        /// <summary>
        /// Metadata for GrantRequest.GrantType property
        /// </summary>
		[Display(
			Name = "GrantType",
			ResourceType = typeof(Cf.Data.Resources.GrantRequest))
		]
		[Tooltip("GrantTypeTooltip", typeof(Cf.Data.Resources.GrantRequest))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte GrantType { get; set; }
		
        /// <summary>
        /// Metadata for GrantRequest.Description property
        /// </summary>
		[Display(
			Name = "Description",
			ResourceType = typeof(Cf.Data.Resources.GrantRequest))
		]
		[Tooltip("DescriptionTooltip", typeof(Cf.Data.Resources.GrantRequest))]
		[StringLength(
			100,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Description { get; set; }
		
        /// <summary>
        /// Metadata for GrantRequest.Amount property
        /// </summary>
		[Display(
			Name = "Amount",
			ResourceType = typeof(Cf.Data.Resources.GrantRequest))
		]
		[Tooltip("AmountTooltip", typeof(Cf.Data.Resources.GrantRequest))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal Amount { get; set; }
		
        /// <summary>
        /// Metadata for GrantRequest.Notes property
        /// </summary>
		[Display(
			Name = "Notes",
			ResourceType = typeof(Cf.Data.Resources.GrantRequest))
		]
		[Tooltip("NotesTooltip", typeof(Cf.Data.Resources.GrantRequest))]
		[StringLength(
			300,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Notes { get; set; }
		
        /// <summary>
        /// Metadata for GrantRequest.EventDate property
        /// </summary>
		[Display(
			Name = "EventDate",
			ResourceType = typeof(Cf.Data.Resources.GrantRequest))
		]
		[Tooltip("EventDateTooltip", typeof(Cf.Data.Resources.GrantRequest))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public DateTime EventDate { get; set; }
		
        /// <summary>
        /// Metadata for GrantRequest.IsFromOtherBranch property
        /// </summary>
		[Display(
			Name = "IsFromOtherBranch",
			ResourceType = typeof(Cf.Data.Resources.GrantRequest))
		]
		[Tooltip("IsFromOtherBranchTooltip", typeof(Cf.Data.Resources.GrantRequest))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public bool IsFromOtherBranch { get; set; }
		#endregion
	}
	#endregion

	#region GrantType meta data class definition
    /// <summary>
    /// Metadata for GrantType class
    /// </summary>
	public class GrantTypeMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for GrantType.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.GrantType))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.GrantType))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte Id { get; set; }
		
        /// <summary>
        /// Metadata for GrantType.Name property
        /// </summary>
		[Display(
			Name = "Name",
			ResourceType = typeof(Cf.Data.Resources.GrantType))
		]
		[Tooltip("NameTooltip", typeof(Cf.Data.Resources.GrantType))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Name { get; set; }
		
        /// <summary>
        /// Metadata for GrantType.Amount property
        /// </summary>
		[Display(
			Name = "Amount",
			ResourceType = typeof(Cf.Data.Resources.GrantType))
		]
		[Tooltip("AmountTooltip", typeof(Cf.Data.Resources.GrantType))]
        public Nullable<decimal> Amount { get; set; }
		
        /// <summary>
        /// Metadata for GrantType.GrantTypeGroup property
        /// </summary>
		[Display(
			Name = "GrantTypeGroup",
			ResourceType = typeof(Cf.Data.Resources.GrantType))
		]
		[Tooltip("GrantTypeGroupTooltip", typeof(Cf.Data.Resources.GrantType))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte GrantTypeGroup { get; set; }
		#endregion
	}
	#endregion

	#region GrantTypeGroup meta data class definition
    /// <summary>
    /// Metadata for GrantTypeGroup class
    /// </summary>
	public class GrantTypeGroupMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for GrantTypeGroup.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.GrantTypeGroup))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.GrantTypeGroup))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte Id { get; set; }
		
        /// <summary>
        /// Metadata for GrantTypeGroup.Name property
        /// </summary>
		[Display(
			Name = "Name",
			ResourceType = typeof(Cf.Data.Resources.GrantTypeGroup))
		]
		[Tooltip("NameTooltip", typeof(Cf.Data.Resources.GrantTypeGroup))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Name { get; set; }
		#endregion
	}
	#endregion

	#region Guarantor meta data class definition
    /// <summary>
    /// Metadata for Guarantor class
    /// </summary>
	public class GuarantorMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for Guarantor.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.Guarantor))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.Guarantor))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Id { get; set; }
		
        /// <summary>
        /// Metadata for Guarantor.RefundableProduct property
        /// </summary>
		[Display(
			Name = "RefundableProduct",
			ResourceType = typeof(Cf.Data.Resources.Guarantor))
		]
		[Tooltip("RefundableProductTooltip", typeof(Cf.Data.Resources.Guarantor))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int RefundableProduct { get; set; }
		
        /// <summary>
        /// Metadata for Guarantor.SubNumber property
        /// </summary>
		[Display(
			Name = "SubNumber",
			ResourceType = typeof(Cf.Data.Resources.Guarantor))
		]
		[Tooltip("SubNumberTooltip", typeof(Cf.Data.Resources.Guarantor))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte SubNumber { get; set; }
		
        /// <summary>
        /// Metadata for Guarantor.Employee property
        /// </summary>
		[Display(
			Name = "Employee",
			ResourceType = typeof(Cf.Data.Resources.Guarantor))
		]
		[Tooltip("EmployeeTooltip", typeof(Cf.Data.Resources.Guarantor))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Employee { get; set; }
		
        /// <summary>
        /// Metadata for Guarantor.GuarantorStatus property
        /// </summary>
		[Display(
			Name = "GuarantorStatus",
			ResourceType = typeof(Cf.Data.Resources.Guarantor))
		]
		[Tooltip("GuarantorStatusTooltip", typeof(Cf.Data.Resources.Guarantor))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte GuarantorStatus { get; set; }
		
        /// <summary>
        /// Metadata for Guarantor.Notes property
        /// </summary>
		[Display(
			Name = "Notes",
			ResourceType = typeof(Cf.Data.Resources.Guarantor))
		]
		[Tooltip("NotesTooltip", typeof(Cf.Data.Resources.Guarantor))]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Notes { get; set; }
		#endregion
	}
	#endregion

	#region GuarantorStatement meta data class definition
    /// <summary>
    /// Metadata for GuarantorStatement class
    /// </summary>
	public class GuarantorStatementMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for GuarantorStatement.Guarantor property
        /// </summary>
		[Display(
			Name = "Guarantor",
			ResourceType = typeof(Cf.Data.Resources.GuarantorStatement))
		]
		[Tooltip("GuarantorTooltip", typeof(Cf.Data.Resources.GuarantorStatement))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Guarantor { get; set; }
		
        /// <summary>
        /// Metadata for GuarantorStatement.GrossSalary property
        /// </summary>
		[Display(
			Name = "GrossSalary",
			ResourceType = typeof(Cf.Data.Resources.GuarantorStatement))
		]
		[Tooltip("GrossSalaryTooltip", typeof(Cf.Data.Resources.GuarantorStatement))]
        public Nullable<decimal> GrossSalary { get; set; }
		
        /// <summary>
        /// Metadata for GuarantorStatement.DeductionsAmount property
        /// </summary>
		[Display(
			Name = "DeductionsAmount",
			ResourceType = typeof(Cf.Data.Resources.GuarantorStatement))
		]
		[Tooltip("DeductionsAmountTooltip", typeof(Cf.Data.Resources.GuarantorStatement))]
        public Nullable<decimal> DeductionsAmount { get; set; }
		
        /// <summary>
        /// Metadata for GuarantorStatement.NetSalary property
        /// </summary>
		[Display(
			Name = "NetSalary",
			ResourceType = typeof(Cf.Data.Resources.GuarantorStatement))
		]
		[Tooltip("NetSalaryTooltip", typeof(Cf.Data.Resources.GuarantorStatement))]
        public Nullable<decimal> NetSalary { get; set; }
		
        /// <summary>
        /// Metadata for GuarantorStatement.ExceptionalIncome property
        /// </summary>
		[Display(
			Name = "ExceptionalIncome",
			ResourceType = typeof(Cf.Data.Resources.GuarantorStatement))
		]
		[Tooltip("ExceptionalIncomeTooltip", typeof(Cf.Data.Resources.GuarantorStatement))]
        public Nullable<decimal> ExceptionalIncome { get; set; }
		#endregion
	}
	#endregion

	#region GuarantorStatus meta data class definition
    /// <summary>
    /// Metadata for GuarantorStatus class
    /// </summary>
	public class GuarantorStatusMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for GuarantorStatus.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.GuarantorStatus))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.GuarantorStatus))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte Id { get; set; }
		
        /// <summary>
        /// Metadata for GuarantorStatus.Name property
        /// </summary>
		[Display(
			Name = "Name",
			ResourceType = typeof(Cf.Data.Resources.GuarantorStatus))
		]
		[Tooltip("NameTooltip", typeof(Cf.Data.Resources.GuarantorStatus))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Name { get; set; }
		#endregion
	}
	#endregion

	#region HealthLoanDecision meta data class definition
    /// <summary>
    /// Metadata for HealthLoanDecision class
    /// </summary>
	public class HealthLoanDecisionMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for HealthLoanDecision.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecision))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.HealthLoanDecision))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Id { get; set; }
		
        /// <summary>
        /// Metadata for HealthLoanDecision.Number property
        /// </summary>
		[Display(
			Name = "Number",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecision))
		]
		[Tooltip("NumberTooltip", typeof(Cf.Data.Resources.HealthLoanDecision))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public short Number { get; set; }
		
        /// <summary>
        /// Metadata for HealthLoanDecision.Year property
        /// </summary>
		[Display(
			Name = "Year",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecision))
		]
		[Tooltip("YearTooltip", typeof(Cf.Data.Resources.HealthLoanDecision))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public short Year { get; set; }
		
        /// <summary>
        /// Metadata for HealthLoanDecision.Date property
        /// </summary>
		[Display(
			Name = "Date",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecision))
		]
		[Tooltip("DateTooltip", typeof(Cf.Data.Resources.HealthLoanDecision))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> Date { get; set; }
		
        /// <summary>
        /// Metadata for HealthLoanDecision.CersNumber property
        /// </summary>
		[Display(
			Name = "CersNumber",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecision))
		]
		[Tooltip("CersNumberTooltip", typeof(Cf.Data.Resources.HealthLoanDecision))]
		[StringLength(
			20,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string CersNumber { get; set; }
		
        /// <summary>
        /// Metadata for HealthLoanDecision.CersDate property
        /// </summary>
		[Display(
			Name = "CersDate",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecision))
		]
		[Tooltip("CersDateTooltip", typeof(Cf.Data.Resources.HealthLoanDecision))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> CersDate { get; set; }
		
        /// <summary>
        /// Metadata for HealthLoanDecision.PaymentNumber property
        /// </summary>
		[Display(
			Name = "PaymentNumber",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecision))
		]
		[Tooltip("PaymentNumberTooltip", typeof(Cf.Data.Resources.HealthLoanDecision))]
		[StringLength(
			20,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string PaymentNumber { get; set; }
		
        /// <summary>
        /// Metadata for HealthLoanDecision.PaymentDate property
        /// </summary>
		[Display(
			Name = "PaymentDate",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecision))
		]
		[Tooltip("PaymentDateTooltip", typeof(Cf.Data.Resources.HealthLoanDecision))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> PaymentDate { get; set; }
		
        /// <summary>
        /// Metadata for HealthLoanDecision.Notes property
        /// </summary>
		[Display(
			Name = "Notes",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecision))
		]
		[Tooltip("NotesTooltip", typeof(Cf.Data.Resources.HealthLoanDecision))]
		[StringLength(
			300,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Notes { get; set; }
		#endregion
	}
	#endregion

	#region HealthLoanDecisionFirstPayment meta data class definition
    /// <summary>
    /// Metadata for HealthLoanDecisionFirstPayment class
    /// </summary>
	public class HealthLoanDecisionFirstPaymentMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for HealthLoanDecisionFirstPayment.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Id { get; set; }
		
        /// <summary>
        /// Metadata for HealthLoanDecisionFirstPayment.Employee property
        /// </summary>
		[Display(
			Name = "Employee",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))
		]
		[Tooltip("EmployeeTooltip", typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Employee { get; set; }
		
        /// <summary>
        /// Metadata for HealthLoanDecisionFirstPayment.PaymentDate property
        /// </summary>
		[Display(
			Name = "PaymentDate",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))
		]
		[Tooltip("PaymentDateTooltip", typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public DateTime PaymentDate { get; set; }
		
        /// <summary>
        /// Metadata for HealthLoanDecisionFirstPayment.PaymentAmount property
        /// </summary>
		[Display(
			Name = "PaymentAmount",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))
		]
		[Tooltip("PaymentAmountTooltip", typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))]
        public Nullable<decimal> PaymentAmount { get; set; }
		
        /// <summary>
        /// Metadata for HealthLoanDecisionFirstPayment.PaymentNotes property
        /// </summary>
		[Display(
			Name = "PaymentNotes",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))
		]
		[Tooltip("PaymentNotesTooltip", typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string PaymentNotes { get; set; }
		
        /// <summary>
        /// Metadata for HealthLoanDecisionFirstPayment.InvoiceDate property
        /// </summary>
		[Display(
			Name = "InvoiceDate",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))
		]
		[Tooltip("InvoiceDateTooltip", typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> InvoiceDate { get; set; }
		
        /// <summary>
        /// Metadata for HealthLoanDecisionFirstPayment.InvoiceAmount property
        /// </summary>
		[Display(
			Name = "InvoiceAmount",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))
		]
		[Tooltip("InvoiceAmountTooltip", typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))]
        public Nullable<decimal> InvoiceAmount { get; set; }
		
        /// <summary>
        /// Metadata for HealthLoanDecisionFirstPayment.InvoiceNotes property
        /// </summary>
		[Display(
			Name = "InvoiceNotes",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))
		]
		[Tooltip("InvoiceNotesTooltip", typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string InvoiceNotes { get; set; }
		
        /// <summary>
        /// Metadata for HealthLoanDecisionFirstPayment.InsuranceDate property
        /// </summary>
		[Display(
			Name = "InsuranceDate",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))
		]
		[Tooltip("InsuranceDateTooltip", typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> InsuranceDate { get; set; }
		
        /// <summary>
        /// Metadata for HealthLoanDecisionFirstPayment.InsuranceAmount property
        /// </summary>
		[Display(
			Name = "InsuranceAmount",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))
		]
		[Tooltip("InsuranceAmountTooltip", typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))]
        public Nullable<decimal> InsuranceAmount { get; set; }
		
        /// <summary>
        /// Metadata for HealthLoanDecisionFirstPayment.InsuranceType property
        /// </summary>
		[Display(
			Name = "InsuranceType",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))
		]
		[Tooltip("InsuranceTypeTooltip", typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<byte> InsuranceType { get; set; }
		
        /// <summary>
        /// Metadata for HealthLoanDecisionFirstPayment.InsuranceNotes property
        /// </summary>
		[Display(
			Name = "InsuranceNotes",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))
		]
		[Tooltip("InsuranceNotesTooltip", typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string InsuranceNotes { get; set; }
		
        /// <summary>
        /// Metadata for HealthLoanDecisionFirstPayment.BoardDate property
        /// </summary>
		[Display(
			Name = "BoardDate",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))
		]
		[Tooltip("BoardDateTooltip", typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> BoardDate { get; set; }
		
        /// <summary>
        /// Metadata for HealthLoanDecisionFirstPayment.BoardAmount property
        /// </summary>
		[Display(
			Name = "BoardAmount",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))
		]
		[Tooltip("BoardAmountTooltip", typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))]
        public Nullable<decimal> BoardAmount { get; set; }
		
        /// <summary>
        /// Metadata for HealthLoanDecisionFirstPayment.BoardType property
        /// </summary>
		[Display(
			Name = "BoardType",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))
		]
		[Tooltip("BoardTypeTooltip", typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<byte> BoardType { get; set; }
		
        /// <summary>
        /// Metadata for HealthLoanDecisionFirstPayment.BoardNotes property
        /// </summary>
		[Display(
			Name = "BoardNotes",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))
		]
		[Tooltip("BoardNotesTooltip", typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string BoardNotes { get; set; }
		
        /// <summary>
        /// Metadata for HealthLoanDecisionFirstPayment.DirectPaymentDate property
        /// </summary>
		[Display(
			Name = "DirectPaymentDate",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))
		]
		[Tooltip("DirectPaymentDateTooltip", typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> DirectPaymentDate { get; set; }
		
        /// <summary>
        /// Metadata for HealthLoanDecisionFirstPayment.DirectPaymentAmount property
        /// </summary>
		[Display(
			Name = "DirectPaymentAmount",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))
		]
		[Tooltip("DirectPaymentAmountTooltip", typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))]
        public Nullable<decimal> DirectPaymentAmount { get; set; }
		
        /// <summary>
        /// Metadata for HealthLoanDecisionFirstPayment.DirectPaymentNotes property
        /// </summary>
		[Display(
			Name = "DirectPaymentNotes",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))
		]
		[Tooltip("DirectPaymentNotesTooltip", typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string DirectPaymentNotes { get; set; }
		
        /// <summary>
        /// Metadata for HealthLoanDecisionFirstPayment.PaymentStatus property
        /// </summary>
		[Display(
			Name = "PaymentStatus",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))
		]
		[Tooltip("PaymentStatusTooltip", typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<byte> PaymentStatus { get; set; }
		
        /// <summary>
        /// Metadata for HealthLoanDecisionFirstPayment.Notes property
        /// </summary>
		[Display(
			Name = "Notes",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))
		]
		[Tooltip("NotesTooltip", typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))]
		[StringLength(
			500,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Notes { get; set; }
		
        /// <summary>
        /// Metadata for HealthLoanDecisionFirstPayment.Department property
        /// </summary>
		[Display(
			Name = "Department",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))
		]
		[Tooltip("DepartmentTooltip", typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> Department { get; set; }
		
        /// <summary>
        /// Metadata for HealthLoanDecisionFirstPayment.HealthLoanDecision property
        /// </summary>
		[Display(
			Name = "HealthLoanDecision",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))
		]
		[Tooltip("HealthLoanDecisionTooltip", typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> HealthLoanDecision { get; set; }
		
        /// <summary>
        /// Metadata for HealthLoanDecisionFirstPayment.RequestCost property
        /// </summary>
		[Display(
			Name = "RequestCost",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))
		]
		[Tooltip("RequestCostTooltip", typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))]
        public Nullable<decimal> RequestCost { get; set; }
		
        /// <summary>
        /// Metadata for HealthLoanDecisionFirstPayment.LoanRequest property
        /// </summary>
		[Display(
			Name = "LoanRequest",
			ResourceType = typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))
		]
		[Tooltip("LoanRequestTooltip", typeof(Cf.Data.Resources.HealthLoanDecisionFirstPayment))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> LoanRequest { get; set; }
		#endregion
	}
	#endregion

	#region IncomingLoan meta data class definition
    /// <summary>
    /// Metadata for IncomingLoan class
    /// </summary>
	public class IncomingLoanMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for IncomingLoan.Loan property
        /// </summary>
		[Display(
			Name = "Loan",
			ResourceType = typeof(Cf.Data.Resources.IncomingLoan))
		]
		[Tooltip("LoanTooltip", typeof(Cf.Data.Resources.IncomingLoan))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Loan { get; set; }
		
        /// <summary>
        /// Metadata for IncomingLoan.MainWorkPlace property
        /// </summary>
		[Display(
			Name = "MainWorkPlace",
			ResourceType = typeof(Cf.Data.Resources.IncomingLoan))
		]
		[Tooltip("MainWorkPlaceTooltip", typeof(Cf.Data.Resources.IncomingLoan))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int MainWorkPlace { get; set; }
		#endregion
	}
	#endregion

	#region Installment meta data class definition
    /// <summary>
    /// Metadata for Installment class
    /// </summary>
	public class InstallmentMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for Installment.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.Installment))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.Installment))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Id { get; set; }
		
        /// <summary>
        /// Metadata for Installment.RefundableProduct property
        /// </summary>
		[Display(
			Name = "RefundableProduct",
			ResourceType = typeof(Cf.Data.Resources.Installment))
		]
		[Tooltip("RefundableProductTooltip", typeof(Cf.Data.Resources.Installment))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int RefundableProduct { get; set; }
		
        /// <summary>
        /// Metadata for Installment.SubNumber property
        /// </summary>
		[Display(
			Name = "SubNumber",
			ResourceType = typeof(Cf.Data.Resources.Installment))
		]
		[Tooltip("SubNumberTooltip", typeof(Cf.Data.Resources.Installment))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public short SubNumber { get; set; }
		
        /// <summary>
        /// Metadata for Installment.DueDate property
        /// </summary>
		[Display(
			Name = "DueDate",
			ResourceType = typeof(Cf.Data.Resources.Installment))
		]
		[Tooltip("DueDateTooltip", typeof(Cf.Data.Resources.Installment))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public DateTime DueDate { get; set; }
		
        /// <summary>
        /// Metadata for Installment.DueCapital property
        /// </summary>
		[Display(
			Name = "DueCapital",
			ResourceType = typeof(Cf.Data.Resources.Installment))
		]
		[Tooltip("DueCapitalTooltip", typeof(Cf.Data.Resources.Installment))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal DueCapital { get; set; }
		
        /// <summary>
        /// Metadata for Installment.DueProfit property
        /// </summary>
		[Display(
			Name = "DueProfit",
			ResourceType = typeof(Cf.Data.Resources.Installment))
		]
		[Tooltip("DueProfitTooltip", typeof(Cf.Data.Resources.Installment))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal DueProfit { get; set; }
		
        /// <summary>
        /// Metadata for Installment.Notes property
        /// </summary>
		[Display(
			Name = "Notes",
			ResourceType = typeof(Cf.Data.Resources.Installment))
		]
		[Tooltip("NotesTooltip", typeof(Cf.Data.Resources.Installment))]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Notes { get; set; }
		#endregion
	}
	#endregion

	#region InstallmentDecrease meta data class definition
    /// <summary>
    /// Metadata for InstallmentDecrease class
    /// </summary>
	public class InstallmentDecreaseMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for InstallmentDecrease.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.InstallmentDecrease))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.InstallmentDecrease))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Id { get; set; }
		
        /// <summary>
        /// Metadata for InstallmentDecrease.InstallmentDecreaseOrder property
        /// </summary>
		[Display(
			Name = "InstallmentDecreaseOrder",
			ResourceType = typeof(Cf.Data.Resources.InstallmentDecrease))
		]
		[Tooltip("InstallmentDecreaseOrderTooltip", typeof(Cf.Data.Resources.InstallmentDecrease))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int InstallmentDecreaseOrder { get; set; }
		
        /// <summary>
        /// Metadata for InstallmentDecrease.Employee property
        /// </summary>
		[Display(
			Name = "Employee",
			ResourceType = typeof(Cf.Data.Resources.InstallmentDecrease))
		]
		[Tooltip("EmployeeTooltip", typeof(Cf.Data.Resources.InstallmentDecrease))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Employee { get; set; }
		
        /// <summary>
        /// Metadata for InstallmentDecrease.Department property
        /// </summary>
		[Display(
			Name = "Department",
			ResourceType = typeof(Cf.Data.Resources.InstallmentDecrease))
		]
		[Tooltip("DepartmentTooltip", typeof(Cf.Data.Resources.InstallmentDecrease))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> Department { get; set; }
		
        /// <summary>
        /// Metadata for InstallmentDecrease.DecreaseAmount property
        /// </summary>
		[Display(
			Name = "DecreaseAmount",
			ResourceType = typeof(Cf.Data.Resources.InstallmentDecrease))
		]
		[Tooltip("DecreaseAmountTooltip", typeof(Cf.Data.Resources.InstallmentDecrease))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal DecreaseAmount { get; set; }
		
        /// <summary>
        /// Metadata for InstallmentDecrease.NewInstallmentAmount property
        /// </summary>
		[Display(
			Name = "NewInstallmentAmount",
			ResourceType = typeof(Cf.Data.Resources.InstallmentDecrease))
		]
		[Tooltip("NewInstallmentAmountTooltip", typeof(Cf.Data.Resources.InstallmentDecrease))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal NewInstallmentAmount { get; set; }
		
        /// <summary>
        /// Metadata for InstallmentDecrease.Notes property
        /// </summary>
		[Display(
			Name = "Notes",
			ResourceType = typeof(Cf.Data.Resources.InstallmentDecrease))
		]
		[Tooltip("NotesTooltip", typeof(Cf.Data.Resources.InstallmentDecrease))]
		[StringLength(
			100,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Notes { get; set; }
		#endregion
	}
	#endregion

	#region InstallmentDecreaseOrder meta data class definition
    /// <summary>
    /// Metadata for InstallmentDecreaseOrder class
    /// </summary>
	public class InstallmentDecreaseOrderMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for InstallmentDecreaseOrder.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.InstallmentDecreaseOrder))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.InstallmentDecreaseOrder))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Id { get; set; }
		
        /// <summary>
        /// Metadata for InstallmentDecreaseOrder.Month property
        /// </summary>
		[Display(
			Name = "Month",
			ResourceType = typeof(Cf.Data.Resources.InstallmentDecreaseOrder))
		]
		[Tooltip("MonthTooltip", typeof(Cf.Data.Resources.InstallmentDecreaseOrder))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public DateTime Month { get; set; }
		
        /// <summary>
        /// Metadata for InstallmentDecreaseOrder.CersNumber property
        /// </summary>
		[Display(
			Name = "CersNumber",
			ResourceType = typeof(Cf.Data.Resources.InstallmentDecreaseOrder))
		]
		[Tooltip("CersNumberTooltip", typeof(Cf.Data.Resources.InstallmentDecreaseOrder))]
		[StringLength(
			25,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string CersNumber { get; set; }
		
        /// <summary>
        /// Metadata for InstallmentDecreaseOrder.CersDate property
        /// </summary>
		[Display(
			Name = "CersDate",
			ResourceType = typeof(Cf.Data.Resources.InstallmentDecreaseOrder))
		]
		[Tooltip("CersDateTooltip", typeof(Cf.Data.Resources.InstallmentDecreaseOrder))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> CersDate { get; set; }
		
        /// <summary>
        /// Metadata for InstallmentDecreaseOrder.Notes property
        /// </summary>
		[Display(
			Name = "Notes",
			ResourceType = typeof(Cf.Data.Resources.InstallmentDecreaseOrder))
		]
		[Tooltip("NotesTooltip", typeof(Cf.Data.Resources.InstallmentDecreaseOrder))]
		[StringLength(
			200,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Notes { get; set; }
		#endregion
	}
	#endregion

	#region InsuranceType meta data class definition
    /// <summary>
    /// Metadata for InsuranceType class
    /// </summary>
	public class InsuranceTypeMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for InsuranceType.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.InsuranceType))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.InsuranceType))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte Id { get; set; }
		
        /// <summary>
        /// Metadata for InsuranceType.Name property
        /// </summary>
		[Display(
			Name = "Name",
			ResourceType = typeof(Cf.Data.Resources.InsuranceType))
		]
		[Tooltip("NameTooltip", typeof(Cf.Data.Resources.InsuranceType))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			32,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Name { get; set; }
		#endregion
	}
	#endregion

	#region Issuer meta data class definition
    /// <summary>
    /// Metadata for Issuer class
    /// </summary>
	public class IssuerMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for Issuer.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.Issuer))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.Issuer))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte Id { get; set; }
		
        /// <summary>
        /// Metadata for Issuer.Name property
        /// </summary>
		[Display(
			Name = "Name",
			ResourceType = typeof(Cf.Data.Resources.Issuer))
		]
		[Tooltip("NameTooltip", typeof(Cf.Data.Resources.Issuer))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Name { get; set; }
		#endregion
	}
	#endregion

	#region Loan meta data class definition
    /// <summary>
    /// Metadata for Loan class
    /// </summary>
	public class LoanMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for Loan.Product property
        /// </summary>
		[Display(
			Name = "Product",
			ResourceType = typeof(Cf.Data.Resources.Loan))
		]
		[Tooltip("ProductTooltip", typeof(Cf.Data.Resources.Loan))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Product { get; set; }
		
        /// <summary>
        /// Metadata for Loan.LoanDecision property
        /// </summary>
		[Display(
			Name = "LoanDecision",
			ResourceType = typeof(Cf.Data.Resources.Loan))
		]
		[Tooltip("LoanDecisionTooltip", typeof(Cf.Data.Resources.Loan))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int LoanDecision { get; set; }
		
        /// <summary>
        /// Metadata for Loan.LoanType property
        /// </summary>
		[Display(
			Name = "LoanType",
			ResourceType = typeof(Cf.Data.Resources.Loan))
		]
		[Tooltip("LoanTypeTooltip", typeof(Cf.Data.Resources.Loan))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public short LoanType { get; set; }
		
        /// <summary>
        /// Metadata for Loan.LoanGenerationStatus property
        /// </summary>
		[Display(
			Name = "LoanGenerationStatus",
			ResourceType = typeof(Cf.Data.Resources.Loan))
		]
		[Tooltip("LoanGenerationStatusTooltip", typeof(Cf.Data.Resources.Loan))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte LoanGenerationStatus { get; set; }
		
        /// <summary>
        /// Metadata for Loan.LoanStatus property
        /// </summary>
		[Display(
			Name = "LoanStatus",
			ResourceType = typeof(Cf.Data.Resources.Loan))
		]
		[Tooltip("LoanStatusTooltip", typeof(Cf.Data.Resources.Loan))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte LoanStatus { get; set; }
		#endregion
	}
	#endregion

	#region LoanChange meta data class definition
    /// <summary>
    /// Metadata for LoanChange class
    /// </summary>
	public class LoanChangeMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for LoanChange.Loan property
        /// </summary>
		[Display(
			Name = "Loan",
			ResourceType = typeof(Cf.Data.Resources.LoanChange))
		]
		[Tooltip("LoanTooltip", typeof(Cf.Data.Resources.LoanChange))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Loan { get; set; }
		
        /// <summary>
        /// Metadata for LoanChange.FromLoan property
        /// </summary>
		[Display(
			Name = "FromLoan",
			ResourceType = typeof(Cf.Data.Resources.LoanChange))
		]
		[Tooltip("FromLoanTooltip", typeof(Cf.Data.Resources.LoanChange))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int FromLoan { get; set; }
		#endregion
	}
	#endregion

	#region LoanDecision meta data class definition
    /// <summary>
    /// Metadata for LoanDecision class
    /// </summary>
	public class LoanDecisionMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for LoanDecision.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.LoanDecision))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.LoanDecision))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Id { get; set; }
		
        /// <summary>
        /// Metadata for LoanDecision.Number property
        /// </summary>
		[Display(
			Name = "Number",
			ResourceType = typeof(Cf.Data.Resources.LoanDecision))
		]
		[Tooltip("NumberTooltip", typeof(Cf.Data.Resources.LoanDecision))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public short Number { get; set; }
		
        /// <summary>
        /// Metadata for LoanDecision.Year property
        /// </summary>
		[Display(
			Name = "Year",
			ResourceType = typeof(Cf.Data.Resources.LoanDecision))
		]
		[Tooltip("YearTooltip", typeof(Cf.Data.Resources.LoanDecision))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public short Year { get; set; }
		
        /// <summary>
        /// Metadata for LoanDecision.Date property
        /// </summary>
		[Display(
			Name = "Date",
			ResourceType = typeof(Cf.Data.Resources.LoanDecision))
		]
		[Tooltip("DateTooltip", typeof(Cf.Data.Resources.LoanDecision))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public DateTime Date { get; set; }
		
        /// <summary>
        /// Metadata for LoanDecision.DeductionStartDate property
        /// </summary>
		[Display(
			Name = "DeductionStartDate",
			ResourceType = typeof(Cf.Data.Resources.LoanDecision))
		]
		[Tooltip("DeductionStartDateTooltip", typeof(Cf.Data.Resources.LoanDecision))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public DateTime DeductionStartDate { get; set; }
		
        /// <summary>
        /// Metadata for LoanDecision.CersNumber property
        /// </summary>
		[Display(
			Name = "CersNumber",
			ResourceType = typeof(Cf.Data.Resources.LoanDecision))
		]
		[Tooltip("CersNumberTooltip", typeof(Cf.Data.Resources.LoanDecision))]
		[StringLength(
			20,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string CersNumber { get; set; }
		
        /// <summary>
        /// Metadata for LoanDecision.CersDate property
        /// </summary>
		[Display(
			Name = "CersDate",
			ResourceType = typeof(Cf.Data.Resources.LoanDecision))
		]
		[Tooltip("CersDateTooltip", typeof(Cf.Data.Resources.LoanDecision))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> CersDate { get; set; }
		
        /// <summary>
        /// Metadata for LoanDecision.Notes property
        /// </summary>
		[Display(
			Name = "Notes",
			ResourceType = typeof(Cf.Data.Resources.LoanDecision))
		]
		[Tooltip("NotesTooltip", typeof(Cf.Data.Resources.LoanDecision))]
		[StringLength(
			300,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Notes { get; set; }
		
        /// <summary>
        /// Metadata for LoanDecision.LoanDecisionType property
        /// </summary>
		[Display(
			Name = "LoanDecisionType",
			ResourceType = typeof(Cf.Data.Resources.LoanDecision))
		]
		[Tooltip("LoanDecisionTypeTooltip", typeof(Cf.Data.Resources.LoanDecision))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte LoanDecisionType { get; set; }
		
        /// <summary>
        /// Metadata for LoanDecision.PaymentNumber property
        /// </summary>
		[Display(
			Name = "PaymentNumber",
			ResourceType = typeof(Cf.Data.Resources.LoanDecision))
		]
		[Tooltip("PaymentNumberTooltip", typeof(Cf.Data.Resources.LoanDecision))]
		[StringLength(
			20,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string PaymentNumber { get; set; }
		
        /// <summary>
        /// Metadata for LoanDecision.PaymentDate property
        /// </summary>
		[Display(
			Name = "PaymentDate",
			ResourceType = typeof(Cf.Data.Resources.LoanDecision))
		]
		[Tooltip("PaymentDateTooltip", typeof(Cf.Data.Resources.LoanDecision))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> PaymentDate { get; set; }
		
        /// <summary>
        /// Metadata for LoanDecision.IsPaidFromSalary property
        /// </summary>
		[Display(
			Name = "IsPaidFromSalary",
			ResourceType = typeof(Cf.Data.Resources.LoanDecision))
		]
		[Tooltip("IsPaidFromSalaryTooltip", typeof(Cf.Data.Resources.LoanDecision))]
        public Nullable<bool> IsPaidFromSalary { get; set; }
		
        /// <summary>
        /// Metadata for LoanDecision.Reason property
        /// </summary>
		[Display(
			Name = "Reason",
			ResourceType = typeof(Cf.Data.Resources.LoanDecision))
		]
		[Tooltip("ReasonTooltip", typeof(Cf.Data.Resources.LoanDecision))]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Reason { get; set; }
		
        /// <summary>
        /// Metadata for LoanDecision.AdditionalClause property
        /// </summary>
		[Display(
			Name = "AdditionalClause",
			ResourceType = typeof(Cf.Data.Resources.LoanDecision))
		]
		[Tooltip("AdditionalClauseTooltip", typeof(Cf.Data.Resources.LoanDecision))]
		[StringLength(
			500,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string AdditionalClause { get; set; }
		
        /// <summary>
        /// Metadata for LoanDecision.AdditionalIntroduction property
        /// </summary>
		[Display(
			Name = "AdditionalIntroduction",
			ResourceType = typeof(Cf.Data.Resources.LoanDecision))
		]
		[Tooltip("AdditionalIntroductionTooltip", typeof(Cf.Data.Resources.LoanDecision))]
		[StringLength(
			100,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string AdditionalIntroduction { get; set; }
		#endregion
	}
	#endregion

	#region LoanDecisionType meta data class definition
    /// <summary>
    /// Metadata for LoanDecisionType class
    /// </summary>
	public class LoanDecisionTypeMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for LoanDecisionType.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.LoanDecisionType))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.LoanDecisionType))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte Id { get; set; }
		
        /// <summary>
        /// Metadata for LoanDecisionType.Name property
        /// </summary>
		[Display(
			Name = "Name",
			ResourceType = typeof(Cf.Data.Resources.LoanDecisionType))
		]
		[Tooltip("NameTooltip", typeof(Cf.Data.Resources.LoanDecisionType))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Name { get; set; }
		#endregion
	}
	#endregion

	#region LoanGenerationStatus meta data class definition
    /// <summary>
    /// Metadata for LoanGenerationStatus class
    /// </summary>
	public class LoanGenerationStatusMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for LoanGenerationStatus.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.LoanGenerationStatus))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.LoanGenerationStatus))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte Id { get; set; }
		
        /// <summary>
        /// Metadata for LoanGenerationStatus.Name property
        /// </summary>
		[Display(
			Name = "Name",
			ResourceType = typeof(Cf.Data.Resources.LoanGenerationStatus))
		]
		[Tooltip("NameTooltip", typeof(Cf.Data.Resources.LoanGenerationStatus))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Name { get; set; }
		#endregion
	}
	#endregion

	#region LoanRequest meta data class definition
    /// <summary>
    /// Metadata for LoanRequest class
    /// </summary>
	public class LoanRequestMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for LoanRequest.Request property
        /// </summary>
		[Display(
			Name = "Request",
			ResourceType = typeof(Cf.Data.Resources.LoanRequest))
		]
		[Tooltip("RequestTooltip", typeof(Cf.Data.Resources.LoanRequest))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Request { get; set; }
		
        /// <summary>
        /// Metadata for LoanRequest.NetIncome property
        /// </summary>
		[Display(
			Name = "NetIncome",
			ResourceType = typeof(Cf.Data.Resources.LoanRequest))
		]
		[Tooltip("NetIncomeTooltip", typeof(Cf.Data.Resources.LoanRequest))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal NetIncome { get; set; }
		
        /// <summary>
        /// Metadata for LoanRequest.TotalDeduction property
        /// </summary>
		[Display(
			Name = "TotalDeduction",
			ResourceType = typeof(Cf.Data.Resources.LoanRequest))
		]
		[Tooltip("TotalDeductionTooltip", typeof(Cf.Data.Resources.LoanRequest))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal TotalDeduction { get; set; }
		#endregion
	}
	#endregion

	#region LoanStatus meta data class definition
    /// <summary>
    /// Metadata for LoanStatus class
    /// </summary>
	public class LoanStatusMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for LoanStatus.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.LoanStatus))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.LoanStatus))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte Id { get; set; }
		
        /// <summary>
        /// Metadata for LoanStatus.Name property
        /// </summary>
		[Display(
			Name = "Name",
			ResourceType = typeof(Cf.Data.Resources.LoanStatus))
		]
		[Tooltip("NameTooltip", typeof(Cf.Data.Resources.LoanStatus))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Name { get; set; }
		#endregion
	}
	#endregion

	#region LoanType meta data class definition
    /// <summary>
    /// Metadata for LoanType class
    /// </summary>
	public class LoanTypeMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for LoanType.ProductType property
        /// </summary>
		[Display(
			Name = "ProductType",
			ResourceType = typeof(Cf.Data.Resources.LoanType))
		]
		[Tooltip("ProductTypeTooltip", typeof(Cf.Data.Resources.LoanType))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public short ProductType { get; set; }
		#endregion
	}
	#endregion

	#region LoanTypeClosure meta data class definition
    /// <summary>
    /// Metadata for LoanTypeClosure class
    /// </summary>
	public class LoanTypeClosureMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for LoanTypeClosure.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.LoanTypeClosure))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.LoanTypeClosure))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Id { get; set; }
		
        /// <summary>
        /// Metadata for LoanTypeClosure.LoanType property
        /// </summary>
		[Display(
			Name = "LoanType",
			ResourceType = typeof(Cf.Data.Resources.LoanTypeClosure))
		]
		[Tooltip("LoanTypeTooltip", typeof(Cf.Data.Resources.LoanTypeClosure))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public short LoanType { get; set; }
		
        /// <summary>
        /// Metadata for LoanTypeClosure.ClosingLoanType property
        /// </summary>
		[Display(
			Name = "ClosingLoanType",
			ResourceType = typeof(Cf.Data.Resources.LoanTypeClosure))
		]
		[Tooltip("ClosingLoanTypeTooltip", typeof(Cf.Data.Resources.LoanTypeClosure))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public short ClosingLoanType { get; set; }
		#endregion
	}
	#endregion

	#region MainWorkPlace meta data class definition
    /// <summary>
    /// Metadata for MainWorkPlace class
    /// </summary>
	public class MainWorkPlaceMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for MainWorkPlace.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.MainWorkPlace))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.MainWorkPlace))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Id { get; set; }
		
        /// <summary>
        /// Metadata for MainWorkPlace.Name property
        /// </summary>
		[Display(
			Name = "Name",
			ResourceType = typeof(Cf.Data.Resources.MainWorkPlace))
		]
		[Tooltip("NameTooltip", typeof(Cf.Data.Resources.MainWorkPlace))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Name { get; set; }
		#endregion
	}
	#endregion

	#region MissingInstallmentDecrease meta data class definition
    /// <summary>
    /// Metadata for MissingInstallmentDecrease class
    /// </summary>
	public class MissingInstallmentDecreaseMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for MissingInstallmentDecrease.Employee property
        /// </summary>
		[Display(
			Name = "Employee",
			ResourceType = typeof(Cf.Data.Resources.MissingInstallmentDecrease))
		]
		[Tooltip("EmployeeTooltip", typeof(Cf.Data.Resources.MissingInstallmentDecrease))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Employee { get; set; }
		
        /// <summary>
        /// Metadata for MissingInstallmentDecrease.SalaryAmount property
        /// </summary>
		[Display(
			Name = "SalaryAmount",
			ResourceType = typeof(Cf.Data.Resources.MissingInstallmentDecrease))
		]
		[Tooltip("SalaryAmountTooltip", typeof(Cf.Data.Resources.MissingInstallmentDecrease))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal SalaryAmount { get; set; }
		
        /// <summary>
        /// Metadata for MissingInstallmentDecrease.TransferMonth property
        /// </summary>
		[Display(
			Name = "TransferMonth",
			ResourceType = typeof(Cf.Data.Resources.MissingInstallmentDecrease))
		]
		[Tooltip("TransferMonthTooltip", typeof(Cf.Data.Resources.MissingInstallmentDecrease))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public DateTime TransferMonth { get; set; }
		
        /// <summary>
        /// Metadata for MissingInstallmentDecrease.FinishedInstallmentsAmount property
        /// </summary>
		[Display(
			Name = "FinishedInstallmentsAmount",
			ResourceType = typeof(Cf.Data.Resources.MissingInstallmentDecrease))
		]
		[Tooltip("FinishedInstallmentsAmountTooltip", typeof(Cf.Data.Resources.MissingInstallmentDecrease))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal FinishedInstallmentsAmount { get; set; }
		
        /// <summary>
        /// Metadata for MissingInstallmentDecrease.RemainingInstallmentsAmount property
        /// </summary>
		[Display(
			Name = "RemainingInstallmentsAmount",
			ResourceType = typeof(Cf.Data.Resources.MissingInstallmentDecrease))
		]
		[Tooltip("RemainingInstallmentsAmountTooltip", typeof(Cf.Data.Resources.MissingInstallmentDecrease))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal RemainingInstallmentsAmount { get; set; }
		
        /// <summary>
        /// Metadata for MissingInstallmentDecrease.Notes property
        /// </summary>
		[Display(
			Name = "Notes",
			ResourceType = typeof(Cf.Data.Resources.MissingInstallmentDecrease))
		]
		[Tooltip("NotesTooltip", typeof(Cf.Data.Resources.MissingInstallmentDecrease))]
		[StringLength(
			100,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Notes { get; set; }
		#endregion
	}
	#endregion

	#region MonthlyBalance meta data class definition
    /// <summary>
    /// Metadata for MonthlyBalance class
    /// </summary>
	public class MonthlyBalanceMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for MonthlyBalance.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.MonthlyBalance))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.MonthlyBalance))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Id { get; set; }
		
        /// <summary>
        /// Metadata for MonthlyBalance.Employee property
        /// </summary>
		[Display(
			Name = "Employee",
			ResourceType = typeof(Cf.Data.Resources.MonthlyBalance))
		]
		[Tooltip("EmployeeTooltip", typeof(Cf.Data.Resources.MonthlyBalance))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Employee { get; set; }
		
        /// <summary>
        /// Metadata for MonthlyBalance.PaymentGroup property
        /// </summary>
		[Display(
			Name = "PaymentGroup",
			ResourceType = typeof(Cf.Data.Resources.MonthlyBalance))
		]
		[Tooltip("PaymentGroupTooltip", typeof(Cf.Data.Resources.MonthlyBalance))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte PaymentGroup { get; set; }
		
        /// <summary>
        /// Metadata for MonthlyBalance.Month property
        /// </summary>
		[Display(
			Name = "Month",
			ResourceType = typeof(Cf.Data.Resources.MonthlyBalance))
		]
		[Tooltip("MonthTooltip", typeof(Cf.Data.Resources.MonthlyBalance))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public DateTime Month { get; set; }
		
        /// <summary>
        /// Metadata for MonthlyBalance.Opening property
        /// </summary>
		[Display(
			Name = "Opening",
			ResourceType = typeof(Cf.Data.Resources.MonthlyBalance))
		]
		[Tooltip("OpeningTooltip", typeof(Cf.Data.Resources.MonthlyBalance))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal Opening { get; set; }
		
        /// <summary>
        /// Metadata for MonthlyBalance.NormalLoans property
        /// </summary>
		[Display(
			Name = "NormalLoans",
			ResourceType = typeof(Cf.Data.Resources.MonthlyBalance))
		]
		[Tooltip("NormalLoansTooltip", typeof(Cf.Data.Resources.MonthlyBalance))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal NormalLoans { get; set; }
		
        /// <summary>
        /// Metadata for MonthlyBalance.IncomingLoans property
        /// </summary>
		[Display(
			Name = "IncomingLoans",
			ResourceType = typeof(Cf.Data.Resources.MonthlyBalance))
		]
		[Tooltip("IncomingLoansTooltip", typeof(Cf.Data.Resources.MonthlyBalance))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal IncomingLoans { get; set; }
		
        /// <summary>
        /// Metadata for MonthlyBalance.Restitution property
        /// </summary>
		[Display(
			Name = "Restitution",
			ResourceType = typeof(Cf.Data.Resources.MonthlyBalance))
		]
		[Tooltip("RestitutionTooltip", typeof(Cf.Data.Resources.MonthlyBalance))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal Restitution { get; set; }
		
        /// <summary>
        /// Metadata for MonthlyBalance.OutgoingLoans property
        /// </summary>
		[Display(
			Name = "OutgoingLoans",
			ResourceType = typeof(Cf.Data.Resources.MonthlyBalance))
		]
		[Tooltip("OutgoingLoansTooltip", typeof(Cf.Data.Resources.MonthlyBalance))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal OutgoingLoans { get; set; }
		
        /// <summary>
        /// Metadata for MonthlyBalance.SalaryPayment property
        /// </summary>
		[Display(
			Name = "SalaryPayment",
			ResourceType = typeof(Cf.Data.Resources.MonthlyBalance))
		]
		[Tooltip("SalaryPaymentTooltip", typeof(Cf.Data.Resources.MonthlyBalance))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal SalaryPayment { get; set; }
		
        /// <summary>
        /// Metadata for MonthlyBalance.CashPayment property
        /// </summary>
		[Display(
			Name = "CashPayment",
			ResourceType = typeof(Cf.Data.Resources.MonthlyBalance))
		]
		[Tooltip("CashPaymentTooltip", typeof(Cf.Data.Resources.MonthlyBalance))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal CashPayment { get; set; }
		#endregion
	}
	#endregion

	#region OutgoingLoan meta data class definition
    /// <summary>
    /// Metadata for OutgoingLoan class
    /// </summary>
	public class OutgoingLoanMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for OutgoingLoan.Loan property
        /// </summary>
		[Display(
			Name = "Loan",
			ResourceType = typeof(Cf.Data.Resources.OutgoingLoan))
		]
		[Tooltip("LoanTooltip", typeof(Cf.Data.Resources.OutgoingLoan))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Loan { get; set; }
		
        /// <summary>
        /// Metadata for OutgoingLoan.LoanDecision property
        /// </summary>
		[Display(
			Name = "LoanDecision",
			ResourceType = typeof(Cf.Data.Resources.OutgoingLoan))
		]
		[Tooltip("LoanDecisionTooltip", typeof(Cf.Data.Resources.OutgoingLoan))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int LoanDecision { get; set; }
		
        /// <summary>
        /// Metadata for OutgoingLoan.MainWorkPlace property
        /// </summary>
		[Display(
			Name = "MainWorkPlace",
			ResourceType = typeof(Cf.Data.Resources.OutgoingLoan))
		]
		[Tooltip("MainWorkPlaceTooltip", typeof(Cf.Data.Resources.OutgoingLoan))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int MainWorkPlace { get; set; }
		
        /// <summary>
        /// Metadata for OutgoingLoan.ApprovedAmount property
        /// </summary>
		[Display(
			Name = "ApprovedAmount",
			ResourceType = typeof(Cf.Data.Resources.OutgoingLoan))
		]
		[Tooltip("ApprovedAmountTooltip", typeof(Cf.Data.Resources.OutgoingLoan))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal ApprovedAmount { get; set; }
		
        /// <summary>
        /// Metadata for OutgoingLoan.NetAmount property
        /// </summary>
		[Display(
			Name = "NetAmount",
			ResourceType = typeof(Cf.Data.Resources.OutgoingLoan))
		]
		[Tooltip("NetAmountTooltip", typeof(Cf.Data.Resources.OutgoingLoan))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal NetAmount { get; set; }
		
        /// <summary>
        /// Metadata for OutgoingLoan.ProfitAmount property
        /// </summary>
		[Display(
			Name = "ProfitAmount",
			ResourceType = typeof(Cf.Data.Resources.OutgoingLoan))
		]
		[Tooltip("ProfitAmountTooltip", typeof(Cf.Data.Resources.OutgoingLoan))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal ProfitAmount { get; set; }
		#endregion
	}
	#endregion

	#region Payment meta data class definition
    /// <summary>
    /// Metadata for Payment class
    /// </summary>
	public class PaymentMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for Payment.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.Payment))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.Payment))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Id { get; set; }
		
        /// <summary>
        /// Metadata for Payment.Employee property
        /// </summary>
		[Display(
			Name = "Employee",
			ResourceType = typeof(Cf.Data.Resources.Payment))
		]
		[Tooltip("EmployeeTooltip", typeof(Cf.Data.Resources.Payment))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Employee { get; set; }
		
        /// <summary>
        /// Metadata for Payment.Date property
        /// </summary>
		[Display(
			Name = "Date",
			ResourceType = typeof(Cf.Data.Resources.Payment))
		]
		[Tooltip("DateTooltip", typeof(Cf.Data.Resources.Payment))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public DateTime Date { get; set; }
		
        /// <summary>
        /// Metadata for Payment.PaymentGroup property
        /// </summary>
		[Display(
			Name = "PaymentGroup",
			ResourceType = typeof(Cf.Data.Resources.Payment))
		]
		[Tooltip("PaymentGroupTooltip", typeof(Cf.Data.Resources.Payment))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte PaymentGroup { get; set; }
		
        /// <summary>
        /// Metadata for Payment.Amount property
        /// </summary>
		[Display(
			Name = "Amount",
			ResourceType = typeof(Cf.Data.Resources.Payment))
		]
		[Tooltip("AmountTooltip", typeof(Cf.Data.Resources.Payment))]
        public Nullable<decimal> Amount { get; set; }
		
        /// <summary>
        /// Metadata for Payment.Notes property
        /// </summary>
		[Display(
			Name = "Notes",
			ResourceType = typeof(Cf.Data.Resources.Payment))
		]
		[Tooltip("NotesTooltip", typeof(Cf.Data.Resources.Payment))]
		[StringLength(
			200,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Notes { get; set; }
		
        /// <summary>
        /// Metadata for Payment.PaymentStatus property
        /// </summary>
		[Display(
			Name = "PaymentStatus",
			ResourceType = typeof(Cf.Data.Resources.Payment))
		]
		[Tooltip("PaymentStatusTooltip", typeof(Cf.Data.Resources.Payment))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<byte> PaymentStatus { get; set; }
		
        /// <summary>
        /// Metadata for Payment.CollectOrder property
        /// </summary>
		[Display(
			Name = "CollectOrder",
			ResourceType = typeof(Cf.Data.Resources.Payment))
		]
		[Tooltip("CollectOrderTooltip", typeof(Cf.Data.Resources.Payment))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> CollectOrder { get; set; }
		#endregion
	}
	#endregion

	#region PaymentGroup meta data class definition
    /// <summary>
    /// Metadata for PaymentGroup class
    /// </summary>
	public class PaymentGroupMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for PaymentGroup.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.PaymentGroup))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.PaymentGroup))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte Id { get; set; }
		
        /// <summary>
        /// Metadata for PaymentGroup.Name property
        /// </summary>
		[Display(
			Name = "Name",
			ResourceType = typeof(Cf.Data.Resources.PaymentGroup))
		]
		[Tooltip("NameTooltip", typeof(Cf.Data.Resources.PaymentGroup))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Name { get; set; }
		#endregion
	}
	#endregion

	#region PaymentStatus meta data class definition
    /// <summary>
    /// Metadata for PaymentStatus class
    /// </summary>
	public class PaymentStatusMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for PaymentStatus.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.PaymentStatus))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.PaymentStatus))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte Id { get; set; }
		
        /// <summary>
        /// Metadata for PaymentStatus.Name property
        /// </summary>
		[Display(
			Name = "Name",
			ResourceType = typeof(Cf.Data.Resources.PaymentStatus))
		]
		[Tooltip("NameTooltip", typeof(Cf.Data.Resources.PaymentStatus))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Name { get; set; }
		#endregion
	}
	#endregion

	#region PayOrder meta data class definition
    /// <summary>
    /// Metadata for PayOrder class
    /// </summary>
	public class PayOrderMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for PayOrder.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.PayOrder))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.PayOrder))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Id { get; set; }
		
        /// <summary>
        /// Metadata for PayOrder.Employee property
        /// </summary>
		[Display(
			Name = "Employee",
			ResourceType = typeof(Cf.Data.Resources.PayOrder))
		]
		[Tooltip("EmployeeTooltip", typeof(Cf.Data.Resources.PayOrder))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Employee { get; set; }
		
        /// <summary>
        /// Metadata for PayOrder.Number property
        /// </summary>
		[Display(
			Name = "Number",
			ResourceType = typeof(Cf.Data.Resources.PayOrder))
		]
		[Tooltip("NumberTooltip", typeof(Cf.Data.Resources.PayOrder))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public short Number { get; set; }
		
        /// <summary>
        /// Metadata for PayOrder.Date property
        /// </summary>
		[Display(
			Name = "Date",
			ResourceType = typeof(Cf.Data.Resources.PayOrder))
		]
		[Tooltip("DateTooltip", typeof(Cf.Data.Resources.PayOrder))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public DateTime Date { get; set; }
		
        /// <summary>
        /// Metadata for PayOrder.VoucherNumber property
        /// </summary>
		[Display(
			Name = "VoucherNumber",
			ResourceType = typeof(Cf.Data.Resources.PayOrder))
		]
		[Tooltip("VoucherNumberTooltip", typeof(Cf.Data.Resources.PayOrder))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<short> VoucherNumber { get; set; }
		
        /// <summary>
        /// Metadata for PayOrder.VoucherDate property
        /// </summary>
		[Display(
			Name = "VoucherDate",
			ResourceType = typeof(Cf.Data.Resources.PayOrder))
		]
		[Tooltip("VoucherDateTooltip", typeof(Cf.Data.Resources.PayOrder))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> VoucherDate { get; set; }
		
        /// <summary>
        /// Metadata for PayOrder.PaymentNumber property
        /// </summary>
		[Display(
			Name = "PaymentNumber",
			ResourceType = typeof(Cf.Data.Resources.PayOrder))
		]
		[Tooltip("PaymentNumberTooltip", typeof(Cf.Data.Resources.PayOrder))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<short> PaymentNumber { get; set; }
		
        /// <summary>
        /// Metadata for PayOrder.PaymentDate property
        /// </summary>
		[Display(
			Name = "PaymentDate",
			ResourceType = typeof(Cf.Data.Resources.PayOrder))
		]
		[Tooltip("PaymentDateTooltip", typeof(Cf.Data.Resources.PayOrder))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> PaymentDate { get; set; }
		
        /// <summary>
        /// Metadata for PayOrder.AccountingDocumentNumber property
        /// </summary>
		[Display(
			Name = "AccountingDocumentNumber",
			ResourceType = typeof(Cf.Data.Resources.PayOrder))
		]
		[Tooltip("AccountingDocumentNumberTooltip", typeof(Cf.Data.Resources.PayOrder))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<short> AccountingDocumentNumber { get; set; }
		
        /// <summary>
        /// Metadata for PayOrder.AccountingDocumentDate property
        /// </summary>
		[Display(
			Name = "AccountingDocumentDate",
			ResourceType = typeof(Cf.Data.Resources.PayOrder))
		]
		[Tooltip("AccountingDocumentDateTooltip", typeof(Cf.Data.Resources.PayOrder))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> AccountingDocumentDate { get; set; }
		
        /// <summary>
        /// Metadata for PayOrder.PaymentGroup property
        /// </summary>
		[Display(
			Name = "PaymentGroup",
			ResourceType = typeof(Cf.Data.Resources.PayOrder))
		]
		[Tooltip("PaymentGroupTooltip", typeof(Cf.Data.Resources.PayOrder))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte PaymentGroup { get; set; }
		
        /// <summary>
        /// Metadata for PayOrder.PaidAmount property
        /// </summary>
		[Display(
			Name = "PaidAmount",
			ResourceType = typeof(Cf.Data.Resources.PayOrder))
		]
		[Tooltip("PaidAmountTooltip", typeof(Cf.Data.Resources.PayOrder))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal PaidAmount { get; set; }
		
        /// <summary>
        /// Metadata for PayOrder.IsProfit property
        /// </summary>
		[Display(
			Name = "IsProfit",
			ResourceType = typeof(Cf.Data.Resources.PayOrder))
		]
		[Tooltip("IsProfitTooltip", typeof(Cf.Data.Resources.PayOrder))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public bool IsProfit { get; set; }
		
        /// <summary>
        /// Metadata for PayOrder.IsFixed property
        /// </summary>
		[Display(
			Name = "IsFixed",
			ResourceType = typeof(Cf.Data.Resources.PayOrder))
		]
		[Tooltip("IsFixedTooltip", typeof(Cf.Data.Resources.PayOrder))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte IsFixed { get; set; }
		
        /// <summary>
        /// Metadata for PayOrder.Notes property
        /// </summary>
		[Display(
			Name = "Notes",
			ResourceType = typeof(Cf.Data.Resources.PayOrder))
		]
		[Tooltip("NotesTooltip", typeof(Cf.Data.Resources.PayOrder))]
		[StringLength(
			200,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Notes { get; set; }
		#endregion
	}
	#endregion

	#region Product meta data class definition
    /// <summary>
    /// Metadata for Product class
    /// </summary>
	public class ProductMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for Product.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.Product))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.Product))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Id { get; set; }
		
        /// <summary>
        /// Metadata for Product.Employee property
        /// </summary>
		[Display(
			Name = "Employee",
			ResourceType = typeof(Cf.Data.Resources.Product))
		]
		[Tooltip("EmployeeTooltip", typeof(Cf.Data.Resources.Product))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Employee { get; set; }
		
        /// <summary>
        /// Metadata for Product.ProductType property
        /// </summary>
		[Display(
			Name = "ProductType",
			ResourceType = typeof(Cf.Data.Resources.Product))
		]
		[Tooltip("ProductTypeTooltip", typeof(Cf.Data.Resources.Product))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public short ProductType { get; set; }
		
        /// <summary>
        /// Metadata for Product.Amount property
        /// </summary>
		[Display(
			Name = "Amount",
			ResourceType = typeof(Cf.Data.Resources.Product))
		]
		[Tooltip("AmountTooltip", typeof(Cf.Data.Resources.Product))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal Amount { get; set; }
		
        /// <summary>
        /// Metadata for Product.Notes property
        /// </summary>
		[Display(
			Name = "Notes",
			ResourceType = typeof(Cf.Data.Resources.Product))
		]
		[Tooltip("NotesTooltip", typeof(Cf.Data.Resources.Product))]
		[StringLength(
			200,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Notes { get; set; }
		#endregion
	}
	#endregion

	#region ProductType meta data class definition
    /// <summary>
    /// Metadata for ProductType class
    /// </summary>
	public class ProductTypeMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for ProductType.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.ProductType))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.ProductType))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public short Id { get; set; }
		
        /// <summary>
        /// Metadata for ProductType.Name property
        /// </summary>
		[Display(
			Name = "Name",
			ResourceType = typeof(Cf.Data.Resources.ProductType))
		]
		[Tooltip("NameTooltip", typeof(Cf.Data.Resources.ProductType))]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Name { get; set; }
		
        /// <summary>
        /// Metadata for ProductType.Rate property
        /// </summary>
		[Display(
			Name = "Rate",
			ResourceType = typeof(Cf.Data.Resources.ProductType))
		]
		[Tooltip("RateTooltip", typeof(Cf.Data.Resources.ProductType))]
        public Nullable<decimal> Rate { get; set; }
		
        /// <summary>
        /// Metadata for ProductType.GuarantorsCount property
        /// </summary>
		[Display(
			Name = "GuarantorsCount",
			ResourceType = typeof(Cf.Data.Resources.ProductType))
		]
		[Tooltip("GuarantorsCountTooltip", typeof(Cf.Data.Resources.ProductType))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte GuarantorsCount { get; set; }
		
        /// <summary>
        /// Metadata for ProductType.AccountNumber property
        /// </summary>
		[Display(
			Name = "AccountNumber",
			ResourceType = typeof(Cf.Data.Resources.ProductType))
		]
		[Tooltip("AccountNumberTooltip", typeof(Cf.Data.Resources.ProductType))]
		[StringLength(
			25,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string AccountNumber { get; set; }
		
        /// <summary>
        /// Metadata for ProductType.PrintLabel property
        /// </summary>
		[Display(
			Name = "PrintLabel",
			ResourceType = typeof(Cf.Data.Resources.ProductType))
		]
		[Tooltip("PrintLabelTooltip", typeof(Cf.Data.Resources.ProductType))]
		[StringLength(
			200,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string PrintLabel { get; set; }
		
        /// <summary>
        /// Metadata for ProductType.ProfitStrategy property
        /// </summary>
		[Display(
			Name = "ProfitStrategy",
			ResourceType = typeof(Cf.Data.Resources.ProductType))
		]
		[Tooltip("ProfitStrategyTooltip", typeof(Cf.Data.Resources.ProductType))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<byte> ProfitStrategy { get; set; }
		
        /// <summary>
        /// Metadata for ProductType.PaymentGroup property
        /// </summary>
		[Display(
			Name = "PaymentGroup",
			ResourceType = typeof(Cf.Data.Resources.ProductType))
		]
		[Tooltip("PaymentGroupTooltip", typeof(Cf.Data.Resources.ProductType))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<byte> PaymentGroup { get; set; }
		
        /// <summary>
        /// Metadata for ProductType.IsActive property
        /// </summary>
		[Display(
			Name = "IsActive",
			ResourceType = typeof(Cf.Data.Resources.ProductType))
		]
		[Tooltip("IsActiveTooltip", typeof(Cf.Data.Resources.ProductType))]
        public Nullable<bool> IsActive { get; set; }
		#endregion
	}
	#endregion

	#region ProductTypeAvailability meta data class definition
    /// <summary>
    /// Metadata for ProductTypeAvailability class
    /// </summary>
	public class ProductTypeAvailabilityMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for ProductTypeAvailability.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.ProductTypeAvailability))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.ProductTypeAvailability))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Id { get; set; }
		
        /// <summary>
        /// Metadata for ProductTypeAvailability.ProductType property
        /// </summary>
		[Display(
			Name = "ProductType",
			ResourceType = typeof(Cf.Data.Resources.ProductTypeAvailability))
		]
		[Tooltip("ProductTypeTooltip", typeof(Cf.Data.Resources.ProductTypeAvailability))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public short ProductType { get; set; }
		
        /// <summary>
        /// Metadata for ProductTypeAvailability.Availability property
        /// </summary>
		[Display(
			Name = "Availability",
			ResourceType = typeof(Cf.Data.Resources.ProductTypeAvailability))
		]
		[Tooltip("AvailabilityTooltip", typeof(Cf.Data.Resources.ProductTypeAvailability))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public short Availability { get; set; }
		#endregion
	}
	#endregion

	#region Profile meta data class definition
    /// <summary>
    /// Metadata for Profile class
    /// </summary>
	public class ProfileMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for Profile.Employee property
        /// </summary>
		[Display(
			Name = "Employee",
			ResourceType = typeof(Cf.Data.Resources.Profile))
		]
		[Tooltip("EmployeeTooltip", typeof(Cf.Data.Resources.Profile))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Employee { get; set; }
		
        /// <summary>
        /// Metadata for Profile.Extension property
        /// </summary>
		[Display(
			Name = "Extension",
			ResourceType = typeof(Cf.Data.Resources.Profile))
		]
		[Tooltip("ExtensionTooltip", typeof(Cf.Data.Resources.Profile))]
		[StringLength(
			25,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Extension { get; set; }
		
        /// <summary>
        /// Metadata for Profile.HomePhone property
        /// </summary>
		[Display(
			Name = "HomePhone",
			ResourceType = typeof(Cf.Data.Resources.Profile))
		]
		[Tooltip("HomePhoneTooltip", typeof(Cf.Data.Resources.Profile))]
		[StringLength(
			25,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string HomePhone { get; set; }
		
        /// <summary>
        /// Metadata for Profile.MobilePhone property
        /// </summary>
		[Display(
			Name = "MobilePhone",
			ResourceType = typeof(Cf.Data.Resources.Profile))
		]
		[Tooltip("MobilePhoneTooltip", typeof(Cf.Data.Resources.Profile))]
		[StringLength(
			25,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string MobilePhone { get; set; }
		
        /// <summary>
        /// Metadata for Profile.Address property
        /// </summary>
		[Display(
			Name = "Address",
			ResourceType = typeof(Cf.Data.Resources.Profile))
		]
		[Tooltip("AddressTooltip", typeof(Cf.Data.Resources.Profile))]
		[StringLength(
			256,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Address { get; set; }
		#endregion
	}
	#endregion

	#region ProfitStrategy meta data class definition
    /// <summary>
    /// Metadata for ProfitStrategy class
    /// </summary>
	public class ProfitStrategyMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for ProfitStrategy.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.ProfitStrategy))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.ProfitStrategy))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte Id { get; set; }
		
        /// <summary>
        /// Metadata for ProfitStrategy.Name property
        /// </summary>
		[Display(
			Name = "Name",
			ResourceType = typeof(Cf.Data.Resources.ProfitStrategy))
		]
		[Tooltip("NameTooltip", typeof(Cf.Data.Resources.ProfitStrategy))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Name { get; set; }
		#endregion
	}
	#endregion

	#region RefundableProduct meta data class definition
    /// <summary>
    /// Metadata for RefundableProduct class
    /// </summary>
	public class RefundableProductMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for RefundableProduct.Product property
        /// </summary>
		[Display(
			Name = "Product",
			ResourceType = typeof(Cf.Data.Resources.RefundableProduct))
		]
		[Tooltip("ProductTooltip", typeof(Cf.Data.Resources.RefundableProduct))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Product { get; set; }
		
        /// <summary>
        /// Metadata for RefundableProduct.PaymentPeriod property
        /// </summary>
		[Display(
			Name = "PaymentPeriod",
			ResourceType = typeof(Cf.Data.Resources.RefundableProduct))
		]
		[Tooltip("PaymentPeriodTooltip", typeof(Cf.Data.Resources.RefundableProduct))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public short PaymentPeriod { get; set; }
		
        /// <summary>
        /// Metadata for RefundableProduct.Installment property
        /// </summary>
		[Display(
			Name = "Installment",
			ResourceType = typeof(Cf.Data.Resources.RefundableProduct))
		]
		[Tooltip("InstallmentTooltip", typeof(Cf.Data.Resources.RefundableProduct))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal Installment { get; set; }
		
        /// <summary>
        /// Metadata for RefundableProduct.NetAmount property
        /// </summary>
		[Display(
			Name = "NetAmount",
			ResourceType = typeof(Cf.Data.Resources.RefundableProduct))
		]
		[Tooltip("NetAmountTooltip", typeof(Cf.Data.Resources.RefundableProduct))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal NetAmount { get; set; }
		
        /// <summary>
        /// Metadata for RefundableProduct.ProfitAmount property
        /// </summary>
		[Display(
			Name = "ProfitAmount",
			ResourceType = typeof(Cf.Data.Resources.RefundableProduct))
		]
		[Tooltip("ProfitAmountTooltip", typeof(Cf.Data.Resources.RefundableProduct))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal ProfitAmount { get; set; }
		
        /// <summary>
        /// Metadata for RefundableProduct.SyrianPoundRounds property
        /// </summary>
		[Display(
			Name = "SyrianPoundRounds",
			ResourceType = typeof(Cf.Data.Resources.RefundableProduct))
		]
		[Tooltip("SyrianPoundRoundsTooltip", typeof(Cf.Data.Resources.RefundableProduct))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal SyrianPoundRounds { get; set; }
		#endregion
	}
	#endregion

	#region Request meta data class definition
    /// <summary>
    /// Metadata for Request class
    /// </summary>
	public class RequestMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for Request.Product property
        /// </summary>
		[Display(
			Name = "Product",
			ResourceType = typeof(Cf.Data.Resources.Request))
		]
		[Tooltip("ProductTooltip", typeof(Cf.Data.Resources.Request))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Product { get; set; }
		
        /// <summary>
        /// Metadata for Request.Date property
        /// </summary>
		[Display(
			Name = "Date",
			ResourceType = typeof(Cf.Data.Resources.Request))
		]
		[Tooltip("DateTooltip", typeof(Cf.Data.Resources.Request))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public DateTime Date { get; set; }
		
        /// <summary>
        /// Metadata for Request.Amount property
        /// </summary>
		[Display(
			Name = "Amount",
			ResourceType = typeof(Cf.Data.Resources.Request))
		]
		[Tooltip("AmountTooltip", typeof(Cf.Data.Resources.Request))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal Amount { get; set; }
		
        /// <summary>
        /// Metadata for Request.Attachment property
        /// </summary>
		[Display(
			Name = "Attachment",
			ResourceType = typeof(Cf.Data.Resources.Request))
		]
		[Tooltip("AttachmentTooltip", typeof(Cf.Data.Resources.Request))]
		[StringLength(
			256,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Attachment { get; set; }
		
        /// <summary>
        /// Metadata for Request.Cost property
        /// </summary>
		[Display(
			Name = "Cost",
			ResourceType = typeof(Cf.Data.Resources.Request))
		]
		[Tooltip("CostTooltip", typeof(Cf.Data.Resources.Request))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal Cost { get; set; }
		
        /// <summary>
        /// Metadata for Request.RequestStatus property
        /// </summary>
		[Display(
			Name = "RequestStatus",
			ResourceType = typeof(Cf.Data.Resources.Request))
		]
		[Tooltip("RequestStatusTooltip", typeof(Cf.Data.Resources.Request))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<byte> RequestStatus { get; set; }
		
        /// <summary>
        /// Metadata for Request.BypassStatus property
        /// </summary>
		[Display(
			Name = "BypassStatus",
			ResourceType = typeof(Cf.Data.Resources.Request))
		]
		[Tooltip("BypassStatusTooltip", typeof(Cf.Data.Resources.Request))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int BypassStatus { get; set; }
		
        /// <summary>
        /// Metadata for Request.Notes property
        /// </summary>
		[Display(
			Name = "Notes",
			ResourceType = typeof(Cf.Data.Resources.Request))
		]
		[Tooltip("NotesTooltip", typeof(Cf.Data.Resources.Request))]
		[StringLength(
			256,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Notes { get; set; }
		#endregion
	}
	#endregion

	#region RequestStatus meta data class definition
    /// <summary>
    /// Metadata for RequestStatus class
    /// </summary>
	public class RequestStatusMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for RequestStatus.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.RequestStatus))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.RequestStatus))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte Id { get; set; }
		
        /// <summary>
        /// Metadata for RequestStatus.Name property
        /// </summary>
		[Display(
			Name = "Name",
			ResourceType = typeof(Cf.Data.Resources.RequestStatus))
		]
		[Tooltip("NameTooltip", typeof(Cf.Data.Resources.RequestStatus))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Name { get; set; }
		#endregion
	}
	#endregion

	#region Resource meta data class definition
    /// <summary>
    /// Metadata for Resource class
    /// </summary>
	public class ResourceMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for Resource.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.Resource))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.Resource))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Id { get; set; }
		
        /// <summary>
        /// Metadata for Resource.Language property
        /// </summary>
		[Display(
			Name = "Language",
			ResourceType = typeof(Cf.Data.Resources.Resource))
		]
		[Tooltip("LanguageTooltip", typeof(Cf.Data.Resources.Resource))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			2,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Language { get; set; }
		
        /// <summary>
        /// Metadata for Resource.Module property
        /// </summary>
		[Display(
			Name = "Module",
			ResourceType = typeof(Cf.Data.Resources.Resource))
		]
		[Tooltip("ModuleTooltip", typeof(Cf.Data.Resources.Resource))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			128,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Module { get; set; }
		
        /// <summary>
        /// Metadata for Resource.Key property
        /// </summary>
		[Display(
			Name = "Key",
			ResourceType = typeof(Cf.Data.Resources.Resource))
		]
		[Tooltip("KeyTooltip", typeof(Cf.Data.Resources.Resource))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			128,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Key { get; set; }
		
        /// <summary>
        /// Metadata for Resource.Value property
        /// </summary>
		[Display(
			Name = "Value",
			ResourceType = typeof(Cf.Data.Resources.Resource))
		]
		[Tooltip("ValueTooltip", typeof(Cf.Data.Resources.Resource))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			1024,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Value { get; set; }
		
        /// <summary>
        /// Metadata for Resource.IsEditable property
        /// </summary>
		[Display(
			Name = "IsEditable",
			ResourceType = typeof(Cf.Data.Resources.Resource))
		]
		[Tooltip("IsEditableTooltip", typeof(Cf.Data.Resources.Resource))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public bool IsEditable { get; set; }
		#endregion
	}
	#endregion

	#region SalaryPayment meta data class definition
    /// <summary>
    /// Metadata for SalaryPayment class
    /// </summary>
	public class SalaryPaymentMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for SalaryPayment.Payment property
        /// </summary>
		[Display(
			Name = "Payment",
			ResourceType = typeof(Cf.Data.Resources.SalaryPayment))
		]
		[Tooltip("PaymentTooltip", typeof(Cf.Data.Resources.SalaryPayment))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Payment { get; set; }
		
        /// <summary>
        /// Metadata for SalaryPayment.Department property
        /// </summary>
		[Display(
			Name = "Department",
			ResourceType = typeof(Cf.Data.Resources.SalaryPayment))
		]
		[Tooltip("DepartmentTooltip", typeof(Cf.Data.Resources.SalaryPayment))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Department { get; set; }
		
        /// <summary>
        /// Metadata for SalaryPayment.Balance property
        /// </summary>
		[Display(
			Name = "Balance",
			ResourceType = typeof(Cf.Data.Resources.SalaryPayment))
		]
		[Tooltip("BalanceTooltip", typeof(Cf.Data.Resources.SalaryPayment))]
        public Nullable<decimal> Balance { get; set; }
		#endregion
	}
	#endregion

	#region SalaryWorkPlace meta data class definition
    /// <summary>
    /// Metadata for SalaryWorkPlace class
    /// </summary>
	public class SalaryWorkPlaceMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for SalaryWorkPlace.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.SalaryWorkPlace))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.SalaryWorkPlace))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Id { get; set; }
		
        /// <summary>
        /// Metadata for SalaryWorkPlace.Name property
        /// </summary>
		[Display(
			Name = "Name",
			ResourceType = typeof(Cf.Data.Resources.SalaryWorkPlace))
		]
		[Tooltip("NameTooltip", typeof(Cf.Data.Resources.SalaryWorkPlace))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Name { get; set; }
		
        /// <summary>
        /// Metadata for SalaryWorkPlace.MainWorkPlace property
        /// </summary>
		[Display(
			Name = "MainWorkPlace",
			ResourceType = typeof(Cf.Data.Resources.SalaryWorkPlace))
		]
		[Tooltip("MainWorkPlaceTooltip", typeof(Cf.Data.Resources.SalaryWorkPlace))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int MainWorkPlace { get; set; }
		#endregion
	}
	#endregion

	#region ServiceEndGrantRequest meta data class definition
    /// <summary>
    /// Metadata for ServiceEndGrantRequest class
    /// </summary>
	public class ServiceEndGrantRequestMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for ServiceEndGrantRequest.GrantRequest property
        /// </summary>
		[Display(
			Name = "GrantRequest",
			ResourceType = typeof(Cf.Data.Resources.ServiceEndGrantRequest))
		]
		[Tooltip("GrantRequestTooltip", typeof(Cf.Data.Resources.ServiceEndGrantRequest))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int GrantRequest { get; set; }
		
        /// <summary>
        /// Metadata for ServiceEndGrantRequest.AverageIncome property
        /// </summary>
		[Display(
			Name = "AverageIncome",
			ResourceType = typeof(Cf.Data.Resources.ServiceEndGrantRequest))
		]
		[Tooltip("AverageIncomeTooltip", typeof(Cf.Data.Resources.ServiceEndGrantRequest))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal AverageIncome { get; set; }
		
        /// <summary>
        /// Metadata for ServiceEndGrantRequest.GrantPercentage property
        /// </summary>
		[Display(
			Name = "GrantPercentage",
			ResourceType = typeof(Cf.Data.Resources.ServiceEndGrantRequest))
		]
		[Tooltip("GrantPercentageTooltip", typeof(Cf.Data.Resources.ServiceEndGrantRequest))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal GrantPercentage { get; set; }
		
        /// <summary>
        /// Metadata for ServiceEndGrantRequest.ServiceInMonthes property
        /// </summary>
		[Display(
			Name = "ServiceInMonthes",
			ResourceType = typeof(Cf.Data.Resources.ServiceEndGrantRequest))
		]
		[Tooltip("ServiceInMonthesTooltip", typeof(Cf.Data.Resources.ServiceEndGrantRequest))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public short ServiceInMonthes { get; set; }
		#endregion
	}
	#endregion

	#region Settlement meta data class definition
    /// <summary>
    /// Metadata for Settlement class
    /// </summary>
	public class SettlementMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for Settlement.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.Settlement))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.Settlement))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Id { get; set; }
		
        /// <summary>
        /// Metadata for Settlement.Installment property
        /// </summary>
		[Display(
			Name = "Installment",
			ResourceType = typeof(Cf.Data.Resources.Settlement))
		]
		[Tooltip("InstallmentTooltip", typeof(Cf.Data.Resources.Settlement))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Installment { get; set; }
		
        /// <summary>
        /// Metadata for Settlement.Payment property
        /// </summary>
		[Display(
			Name = "Payment",
			ResourceType = typeof(Cf.Data.Resources.Settlement))
		]
		[Tooltip("PaymentTooltip", typeof(Cf.Data.Resources.Settlement))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Payment { get; set; }
		
        /// <summary>
        /// Metadata for Settlement.Amount property
        /// </summary>
		[Display(
			Name = "Amount",
			ResourceType = typeof(Cf.Data.Resources.Settlement))
		]
		[Tooltip("AmountTooltip", typeof(Cf.Data.Resources.Settlement))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal Amount { get; set; }
		#endregion
	}
	#endregion

	#region SpecialCaseLoan meta data class definition
    /// <summary>
    /// Metadata for SpecialCaseLoan class
    /// </summary>
	public class SpecialCaseLoanMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for SpecialCaseLoan.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.SpecialCaseLoan))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.SpecialCaseLoan))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Id { get; set; }
		
        /// <summary>
        /// Metadata for SpecialCaseLoan.Employee property
        /// </summary>
		[Display(
			Name = "Employee",
			ResourceType = typeof(Cf.Data.Resources.SpecialCaseLoan))
		]
		[Tooltip("EmployeeTooltip", typeof(Cf.Data.Resources.SpecialCaseLoan))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Employee { get; set; }
		
        /// <summary>
        /// Metadata for SpecialCaseLoan.Date property
        /// </summary>
		[Display(
			Name = "Date",
			ResourceType = typeof(Cf.Data.Resources.SpecialCaseLoan))
		]
		[Tooltip("DateTooltip", typeof(Cf.Data.Resources.SpecialCaseLoan))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public DateTime Date { get; set; }
		
        /// <summary>
        /// Metadata for SpecialCaseLoan.LoanType property
        /// </summary>
		[Display(
			Name = "LoanType",
			ResourceType = typeof(Cf.Data.Resources.SpecialCaseLoan))
		]
		[Tooltip("LoanTypeTooltip", typeof(Cf.Data.Resources.SpecialCaseLoan))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public short LoanType { get; set; }
		
        /// <summary>
        /// Metadata for SpecialCaseLoan.Amount property
        /// </summary>
		[Display(
			Name = "Amount",
			ResourceType = typeof(Cf.Data.Resources.SpecialCaseLoan))
		]
		[Tooltip("AmountTooltip", typeof(Cf.Data.Resources.SpecialCaseLoan))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal Amount { get; set; }
		
        /// <summary>
        /// Metadata for SpecialCaseLoan.Notes property
        /// </summary>
		[Display(
			Name = "Notes",
			ResourceType = typeof(Cf.Data.Resources.SpecialCaseLoan))
		]
		[Tooltip("NotesTooltip", typeof(Cf.Data.Resources.SpecialCaseLoan))]
		[StringLength(
			128,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Notes { get; set; }
		#endregion
	}
	#endregion

	#region Subscription meta data class definition
    /// <summary>
    /// Metadata for Subscription class
    /// </summary>
	public class SubscriptionMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for Subscription.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.Subscription))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.Subscription))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Id { get; set; }
		
        /// <summary>
        /// Metadata for Subscription.Employee property
        /// </summary>
		[Display(
			Name = "Employee",
			ResourceType = typeof(Cf.Data.Resources.Subscription))
		]
		[Tooltip("EmployeeTooltip", typeof(Cf.Data.Resources.Subscription))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Employee { get; set; }
		
        /// <summary>
        /// Metadata for Subscription.Month property
        /// </summary>
		[Display(
			Name = "Month",
			ResourceType = typeof(Cf.Data.Resources.Subscription))
		]
		[Tooltip("MonthTooltip", typeof(Cf.Data.Resources.Subscription))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public DateTime Month { get; set; }
		
        /// <summary>
        /// Metadata for Subscription.Department property
        /// </summary>
		[Display(
			Name = "Department",
			ResourceType = typeof(Cf.Data.Resources.Subscription))
		]
		[Tooltip("DepartmentTooltip", typeof(Cf.Data.Resources.Subscription))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Department { get; set; }
		
        /// <summary>
        /// Metadata for Subscription.SubscriptionType property
        /// </summary>
		[Display(
			Name = "SubscriptionType",
			ResourceType = typeof(Cf.Data.Resources.Subscription))
		]
		[Tooltip("SubscriptionTypeTooltip", typeof(Cf.Data.Resources.Subscription))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte SubscriptionType { get; set; }
		
        /// <summary>
        /// Metadata for Subscription.Amount property
        /// </summary>
		[Display(
			Name = "Amount",
			ResourceType = typeof(Cf.Data.Resources.Subscription))
		]
		[Tooltip("AmountTooltip", typeof(Cf.Data.Resources.Subscription))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal Amount { get; set; }
		
        /// <summary>
        /// Metadata for Subscription.Notes property
        /// </summary>
		[Display(
			Name = "Notes",
			ResourceType = typeof(Cf.Data.Resources.Subscription))
		]
		[Tooltip("NotesTooltip", typeof(Cf.Data.Resources.Subscription))]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Notes { get; set; }
		
        /// <summary>
        /// Metadata for Subscription.IsFixed property
        /// </summary>
		[Display(
			Name = "IsFixed",
			ResourceType = typeof(Cf.Data.Resources.Subscription))
		]
		[Tooltip("IsFixedTooltip", typeof(Cf.Data.Resources.Subscription))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public bool IsFixed { get; set; }
		#endregion
	}
	#endregion

	#region SubscriptionType meta data class definition
    /// <summary>
    /// Metadata for SubscriptionType class
    /// </summary>
	public class SubscriptionTypeMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for SubscriptionType.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.SubscriptionType))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.SubscriptionType))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public byte Id { get; set; }
		
        /// <summary>
        /// Metadata for SubscriptionType.Name property
        /// </summary>
		[Display(
			Name = "Name",
			ResourceType = typeof(Cf.Data.Resources.SubscriptionType))
		]
		[Tooltip("NameTooltip", typeof(Cf.Data.Resources.SubscriptionType))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Name { get; set; }
		#endregion
	}
	#endregion

	#region TransitoryIncomingLoan meta data class definition
    /// <summary>
    /// Metadata for TransitoryIncomingLoan class
    /// </summary>
	public class TransitoryIncomingLoanMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for TransitoryIncomingLoan.Employee property
        /// </summary>
		[Display(
			Name = "Employee",
			ResourceType = typeof(Cf.Data.Resources.TransitoryIncomingLoan))
		]
		[Tooltip("EmployeeTooltip", typeof(Cf.Data.Resources.TransitoryIncomingLoan))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Employee { get; set; }
		
        /// <summary>
        /// Metadata for TransitoryIncomingLoan.MainWorkPlace property
        /// </summary>
		[Display(
			Name = "MainWorkPlace",
			ResourceType = typeof(Cf.Data.Resources.TransitoryIncomingLoan))
		]
		[Tooltip("MainWorkPlaceTooltip", typeof(Cf.Data.Resources.TransitoryIncomingLoan))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int MainWorkPlace { get; set; }
		
        /// <summary>
        /// Metadata for TransitoryIncomingLoan.ApprovedAmount property
        /// </summary>
		[Display(
			Name = "ApprovedAmount",
			ResourceType = typeof(Cf.Data.Resources.TransitoryIncomingLoan))
		]
		[Tooltip("ApprovedAmountTooltip", typeof(Cf.Data.Resources.TransitoryIncomingLoan))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal ApprovedAmount { get; set; }
		
        /// <summary>
        /// Metadata for TransitoryIncomingLoan.Installment property
        /// </summary>
		[Display(
			Name = "Installment",
			ResourceType = typeof(Cf.Data.Resources.TransitoryIncomingLoan))
		]
		[Tooltip("InstallmentTooltip", typeof(Cf.Data.Resources.TransitoryIncomingLoan))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal Installment { get; set; }
		
        /// <summary>
        /// Metadata for TransitoryIncomingLoan.Notes property
        /// </summary>
		[Display(
			Name = "Notes",
			ResourceType = typeof(Cf.Data.Resources.TransitoryIncomingLoan))
		]
		[Tooltip("NotesTooltip", typeof(Cf.Data.Resources.TransitoryIncomingLoan))]
		[StringLength(
			100,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Notes { get; set; }
		
        /// <summary>
        /// Metadata for TransitoryIncomingLoan.IsVerified property
        /// </summary>
		[Display(
			Name = "IsVerified",
			ResourceType = typeof(Cf.Data.Resources.TransitoryIncomingLoan))
		]
		[Tooltip("IsVerifiedTooltip", typeof(Cf.Data.Resources.TransitoryIncomingLoan))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public bool IsVerified { get; set; }
		#endregion
	}
	#endregion

	#region Warrant meta data class definition
    /// <summary>
    /// Metadata for Warrant class
    /// </summary>
	public class WarrantMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for Warrant.Id property
        /// </summary>
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.Warrant))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.Warrant))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Id { get; set; }
		
        /// <summary>
        /// Metadata for Warrant.Debt property
        /// </summary>
		[Display(
			Name = "Debt",
			ResourceType = typeof(Cf.Data.Resources.Warrant))
		]
		[Tooltip("DebtTooltip", typeof(Cf.Data.Resources.Warrant))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Debt { get; set; }
		
        /// <summary>
        /// Metadata for Warrant.Employee property
        /// </summary>
		[Display(
			Name = "Employee",
			ResourceType = typeof(Cf.Data.Resources.Warrant))
		]
		[Tooltip("EmployeeTooltip", typeof(Cf.Data.Resources.Warrant))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public int Employee { get; set; }
		
        /// <summary>
        /// Metadata for Warrant.IsActive property
        /// </summary>
		[Display(
			Name = "IsActive",
			ResourceType = typeof(Cf.Data.Resources.Warrant))
		]
		[Tooltip("IsActiveTooltip", typeof(Cf.Data.Resources.Warrant))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public bool IsActive { get; set; }
		
        /// <summary>
        /// Metadata for Warrant.Notes property
        /// </summary>
		[Display(
			Name = "Notes",
			ResourceType = typeof(Cf.Data.Resources.Warrant))
		]
		[Tooltip("NotesTooltip", typeof(Cf.Data.Resources.Warrant))]
		[StringLength(
			100,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Notes { get; set; }
		#endregion
	}
	#endregion
}
