using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace Cf.Data
{
	#region EmployeeLoans filter and result classes
	#region EmployeeLoansFilter meta data class definition
    /// <summary>
    /// Metadata for EmployeeLoansFilter class
    /// </summary>
	public partial class EmployeeLoansFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for EmployeeLoansFilter.EmployeeId property
        /// </summary>
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.EmployeeLoansFilter))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.EmployeeLoansFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> EmployeeId { get; set; }
		#endregion
	}
	#endregion

    #region EmployeeLoansResultMetaData class definition
	/// <summary>
    /// Result class for EmployeeLoans.
	/// </summary>
	public partial class EmployeeLoansResultMetaData
	{
		#region Public properties
		[Display(
			Name = "ProductEmployeeId",
			ResourceType = typeof(Cf.Data.Resources.EmployeeLoansResult))
		]
		[Tooltip("ProductEmployeeIdTooltip", typeof(Cf.Data.Resources.EmployeeLoansResult))]
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
        public int ProductEmployeeId {get; set; }
		
		[Display(
			Name = "ProductEmployeeFullName",
			ResourceType = typeof(Cf.Data.Resources.EmployeeLoansResult))
		]
		[Tooltip("ProductEmployeeFullNameTooltip", typeof(Cf.Data.Resources.EmployeeLoansResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string ProductEmployeeFullName {get; set; }
		
		[Display(
			Name = "ProductProductTypeId",
			ResourceType = typeof(Cf.Data.Resources.EmployeeLoansResult))
		]
		[Tooltip("ProductProductTypeIdTooltip", typeof(Cf.Data.Resources.EmployeeLoansResult))]
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
        public short ProductProductTypeId {get; set; }
		
		[Display(
			Name = "ProductProductTypeName",
			ResourceType = typeof(Cf.Data.Resources.EmployeeLoansResult))
		]
		[Tooltip("ProductProductTypeNameTooltip", typeof(Cf.Data.Resources.EmployeeLoansResult))]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string ProductProductTypeName {get; set; }
		
		[Display(
			Name = "ProductId",
			ResourceType = typeof(Cf.Data.Resources.EmployeeLoansResult))
		]
		[Tooltip("ProductIdTooltip", typeof(Cf.Data.Resources.EmployeeLoansResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal ProductId {get; set; }
		
		[Display(
			Name = "PaidAmount",
			ResourceType = typeof(Cf.Data.Resources.EmployeeLoansResult))
		]
		[Tooltip("PaidAmountTooltip", typeof(Cf.Data.Resources.EmployeeLoansResult))]
        public Nullable<decimal> PaidAmount {get; set; }
		
		[Display(
			Name = "PaymentPeriod",
			ResourceType = typeof(Cf.Data.Resources.EmployeeLoansResult))
		]
		[Tooltip("PaymentPeriodTooltip", typeof(Cf.Data.Resources.EmployeeLoansResult))]
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
        public short PaymentPeriod {get; set; }
		
		[Display(
			Name = "RemainPeriod",
			ResourceType = typeof(Cf.Data.Resources.EmployeeLoansResult))
		]
		[Tooltip("RemainPeriodTooltip", typeof(Cf.Data.Resources.EmployeeLoansResult))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> RemainPeriod {get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region EmployeeMonthPayments filter and result classes
	#region EmployeeMonthPaymentsFilter meta data class definition
    /// <summary>
    /// Metadata for EmployeeMonthPaymentsFilter class
    /// </summary>
	public partial class EmployeeMonthPaymentsFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for EmployeeMonthPaymentsFilter.Month property
        /// </summary>
		[Display(
			Name = "Month",
			ResourceType = typeof(Cf.Data.Resources.EmployeeMonthPaymentsFilter))
		]
		[Tooltip("MonthTooltip", typeof(Cf.Data.Resources.EmployeeMonthPaymentsFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> Month { get; set; }
		
        /// <summary>
        /// Metadata for EmployeeMonthPaymentsFilter.Employee property
        /// </summary>
		[Display(
			Name = "Employee",
			ResourceType = typeof(Cf.Data.Resources.EmployeeMonthPaymentsFilter))
		]
		[Tooltip("EmployeeTooltip", typeof(Cf.Data.Resources.EmployeeMonthPaymentsFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> Employee { get; set; }
		#endregion
	}
	#endregion

    #region EmployeeMonthPaymentsResultMetaData class definition
	/// <summary>
    /// Result class for EmployeeMonthPayments.
	/// </summary>
	public partial class EmployeeMonthPaymentsResultMetaData
	{
		#region Public properties
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.EmployeeMonthPaymentsResult))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.EmployeeMonthPaymentsResult))]
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
        public int EmployeeId {get; set; }
		
		[Display(
			Name = "EmployeeFullName",
			ResourceType = typeof(Cf.Data.Resources.EmployeeMonthPaymentsResult))
		]
		[Tooltip("EmployeeFullNameTooltip", typeof(Cf.Data.Resources.EmployeeMonthPaymentsResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string EmployeeFullName {get; set; }
		
		[Display(
			Name = "EmployeeDepartmentSalaryWorkPlaceName",
			ResourceType = typeof(Cf.Data.Resources.EmployeeMonthPaymentsResult))
		]
		[Tooltip("EmployeeDepartmentSalaryWorkPlaceNameTooltip", typeof(Cf.Data.Resources.EmployeeMonthPaymentsResult))]
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
        public string EmployeeDepartmentSalaryWorkPlaceName {get; set; }
		
		[Display(
			Name = "Amount",
			ResourceType = typeof(Cf.Data.Resources.EmployeeMonthPaymentsResult))
		]
		[Tooltip("AmountTooltip", typeof(Cf.Data.Resources.EmployeeMonthPaymentsResult))]
        public Nullable<decimal> Amount {get; set; }
		
		[Display(
			Name = "Month",
			ResourceType = typeof(Cf.Data.Resources.EmployeeMonthPaymentsResult))
		]
		[Tooltip("MonthTooltip", typeof(Cf.Data.Resources.EmployeeMonthPaymentsResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			38,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Month {get; set; }
		
		[Display(
			Name = "PaymentGroupId",
			ResourceType = typeof(Cf.Data.Resources.EmployeeMonthPaymentsResult))
		]
		[Tooltip("PaymentGroupIdTooltip", typeof(Cf.Data.Resources.EmployeeMonthPaymentsResult))]
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
        public byte PaymentGroupId {get; set; }
		
		[Display(
			Name = "PaymentGroupName",
			ResourceType = typeof(Cf.Data.Resources.EmployeeMonthPaymentsResult))
		]
		[Tooltip("PaymentGroupNameTooltip", typeof(Cf.Data.Resources.EmployeeMonthPaymentsResult))]
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
        public string PaymentGroupName {get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region EmployeeMonthSubscriptions filter and result classes
	#region EmployeeMonthSubscriptionsFilter meta data class definition
    /// <summary>
    /// Metadata for EmployeeMonthSubscriptionsFilter class
    /// </summary>
	public partial class EmployeeMonthSubscriptionsFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for EmployeeMonthSubscriptionsFilter.Month property
        /// </summary>
		[Display(
			Name = "Month",
			ResourceType = typeof(Cf.Data.Resources.EmployeeMonthSubscriptionsFilter))
		]
		[Tooltip("MonthTooltip", typeof(Cf.Data.Resources.EmployeeMonthSubscriptionsFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> Month { get; set; }
		
        /// <summary>
        /// Metadata for EmployeeMonthSubscriptionsFilter.Employee property
        /// </summary>
		[Display(
			Name = "Employee",
			ResourceType = typeof(Cf.Data.Resources.EmployeeMonthSubscriptionsFilter))
		]
		[Tooltip("EmployeeTooltip", typeof(Cf.Data.Resources.EmployeeMonthSubscriptionsFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> Employee { get; set; }
		#endregion
	}
	#endregion

    #region EmployeeMonthSubscriptionsResultMetaData class definition
	/// <summary>
    /// Result class for EmployeeMonthSubscriptions.
	/// </summary>
	public partial class EmployeeMonthSubscriptionsResultMetaData
	{
		#region Public properties
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.EmployeeMonthSubscriptionsResult))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.EmployeeMonthSubscriptionsResult))]
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
        public int EmployeeId {get; set; }
		
		[Display(
			Name = "EmployeeFullName",
			ResourceType = typeof(Cf.Data.Resources.EmployeeMonthSubscriptionsResult))
		]
		[Tooltip("EmployeeFullNameTooltip", typeof(Cf.Data.Resources.EmployeeMonthSubscriptionsResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string EmployeeFullName {get; set; }
		
		[Display(
			Name = "EmployeeDepartmentSalaryWorkPlaceName",
			ResourceType = typeof(Cf.Data.Resources.EmployeeMonthSubscriptionsResult))
		]
		[Tooltip("EmployeeDepartmentSalaryWorkPlaceNameTooltip", typeof(Cf.Data.Resources.EmployeeMonthSubscriptionsResult))]
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
        public string EmployeeDepartmentSalaryWorkPlaceName {get; set; }
		
		[Display(
			Name = "Amount",
			ResourceType = typeof(Cf.Data.Resources.EmployeeMonthSubscriptionsResult))
		]
		[Tooltip("AmountTooltip", typeof(Cf.Data.Resources.EmployeeMonthSubscriptionsResult))]
        public Nullable<decimal> Amount {get; set; }
		
		[Display(
			Name = "Month",
			ResourceType = typeof(Cf.Data.Resources.EmployeeMonthSubscriptionsResult))
		]
		[Tooltip("MonthTooltip", typeof(Cf.Data.Resources.EmployeeMonthSubscriptionsResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			38,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string Month {get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region EmployeeProductCalculator filter and result classes
	#region EmployeeProductCalculatorFilter meta data class definition
    /// <summary>
    /// Metadata for EmployeeProductCalculatorFilter class
    /// </summary>
	public partial class EmployeeProductCalculatorFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for EmployeeProductCalculatorFilter.EmployeeId property
        /// </summary>
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorFilter))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> EmployeeId { get; set; }
		
        /// <summary>
        /// Metadata for EmployeeProductCalculatorFilter.ProductTypeId property
        /// </summary>
		[Display(
			Name = "ProductTypeId",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorFilter))
		]
		[Tooltip("ProductTypeIdTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<short> ProductTypeId { get; set; }
		
        /// <summary>
        /// Metadata for EmployeeProductCalculatorFilter.Amount property
        /// </summary>
		[Display(
			Name = "Amount",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorFilter))
		]
		[Tooltip("AmountTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorFilter))]
        public Nullable<decimal> Amount { get; set; }
		
        /// <summary>
        /// Metadata for EmployeeProductCalculatorFilter.Period property
        /// </summary>
		[Display(
			Name = "Period",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorFilter))
		]
		[Tooltip("PeriodTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<short> Period { get; set; }
		#endregion
	}
	#endregion

    #region EmployeeProductCalculatorResultMetaData class definition
	/// <summary>
    /// Result class for EmployeeProductCalculator.
	/// </summary>
	public partial class EmployeeProductCalculatorResultMetaData
	{
		#region Public properties
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> EmployeeId {get; set; }
		
		[Display(
			Name = "FullName",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("FullNameTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string FullName {get; set; }
		
		[Display(
			Name = "CersStartDate",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("CersStartDateTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> CersStartDate {get; set; }
		
		[Display(
			Name = "CfStartDate",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("CfStartDateTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> CfStartDate {get; set; }
		
		[Display(
			Name = "LeaveDate",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("LeaveDateTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> LeaveDate {get; set; }
		
		[Display(
			Name = "LeaveReason",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("LeaveReasonTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string LeaveReason {get; set; }
		
		[Display(
			Name = "DepartmentName",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("DepartmentNameTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
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
        public string DepartmentName {get; set; }
		
		[Display(
			Name = "DepartmentSalaryWorkPlaceName",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("DepartmentSalaryWorkPlaceNameTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
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
        public string DepartmentSalaryWorkPlaceName {get; set; }
		
		[Display(
			Name = "EmployeeStatusName",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("EmployeeStatusNameTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
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
        public string EmployeeStatusName {get; set; }
		
		[Display(
			Name = "CategoryName",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("CategoryNameTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
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
        public string CategoryName {get; set; }
		
		[Display(
			Name = "MaxAmount",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("MaxAmountTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
        public Nullable<decimal> MaxAmount {get; set; }
		
		[Display(
			Name = "Seniority",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("SeniorityTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<short> Seniority {get; set; }
		
		[Display(
			Name = "MinSeniority",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("MinSeniorityTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<byte> MinSeniority {get; set; }
		
		[Display(
			Name = "MinReusePeriod",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("MinReusePeriodTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<byte> MinReusePeriod {get; set; }
		
		[Display(
			Name = "ProductTypeId",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("ProductTypeIdTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<short> ProductTypeId {get; set; }
		
		[Display(
			Name = "Amount",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("AmountTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
        public Nullable<decimal> Amount {get; set; }
		
		[Display(
			Name = "NetAmount",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("NetAmountTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
        public Nullable<decimal> NetAmount {get; set; }
		
		[Display(
			Name = "ProfitAmount",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("ProfitAmountTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
        public Nullable<decimal> ProfitAmount {get; set; }
		
		[Display(
			Name = "Installment",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("InstallmentTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
        public Nullable<decimal> Installment {get; set; }
		
		[Display(
			Name = "Rate",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("RateTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
        public Nullable<double> Rate {get; set; }
		
		[Display(
			Name = "AnnualRate",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("AnnualRateTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
        public Nullable<decimal> AnnualRate {get; set; }
		
		[Display(
			Name = "GuarantorsCount",
			ResourceType = typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))
		]
		[Tooltip("GuarantorsCountTooltip", typeof(Cf.Data.Resources.EmployeeProductCalculatorResult))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<byte> GuarantorsCount {get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region GetAvailabilityCeilingByProductTypeId_EmployeeId filter and result classes
	#region GetAvailabilityCeilingByProductTypeId_EmployeeIdFilter meta data class definition
    /// <summary>
    /// Metadata for GetAvailabilityCeilingByProductTypeId_EmployeeIdFilter class
    /// </summary>
	public partial class GetAvailabilityCeilingByProductTypeId_EmployeeIdFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for GetAvailabilityCeilingByProductTypeId_EmployeeIdFilter.ProductTypeId property
        /// </summary>
		[Display(
			Name = "ProductTypeId",
			ResourceType = typeof(Cf.Data.Resources.GetAvailabilityCeilingByProductTypeId_EmployeeIdFilter))
		]
		[Tooltip("ProductTypeIdTooltip", typeof(Cf.Data.Resources.GetAvailabilityCeilingByProductTypeId_EmployeeIdFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<short> ProductTypeId { get; set; }
		
        /// <summary>
        /// Metadata for GetAvailabilityCeilingByProductTypeId_EmployeeIdFilter.EmployeeId property
        /// </summary>
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.GetAvailabilityCeilingByProductTypeId_EmployeeIdFilter))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.GetAvailabilityCeilingByProductTypeId_EmployeeIdFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> EmployeeId { get; set; }
		#endregion
	}
	#endregion

    #region GetAvailabilityCeilingByProductTypeId_EmployeeIdResultMetaData class definition
	/// <summary>
    /// Result class for GetAvailabilityCeilingByProductTypeId_EmployeeId.
	/// </summary>
	public partial class GetAvailabilityCeilingByProductTypeId_EmployeeIdResultMetaData
	{
		#region Public properties
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.GetAvailabilityCeilingByProductTypeId_EmployeeIdResult))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.GetAvailabilityCeilingByProductTypeId_EmployeeIdResult))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> EmployeeId {get; set; }
		
		[Display(
			Name = "ProductTypeId",
			ResourceType = typeof(Cf.Data.Resources.GetAvailabilityCeilingByProductTypeId_EmployeeIdResult))
		]
		[Tooltip("ProductTypeIdTooltip", typeof(Cf.Data.Resources.GetAvailabilityCeilingByProductTypeId_EmployeeIdResult))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<short> ProductTypeId {get; set; }
		
		[Display(
			Name = "Seniority",
			ResourceType = typeof(Cf.Data.Resources.GetAvailabilityCeilingByProductTypeId_EmployeeIdResult))
		]
		[Tooltip("SeniorityTooltip", typeof(Cf.Data.Resources.GetAvailabilityCeilingByProductTypeId_EmployeeIdResult))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<short> Seniority {get; set; }
		
		[Display(
			Name = "MinSeniority",
			ResourceType = typeof(Cf.Data.Resources.GetAvailabilityCeilingByProductTypeId_EmployeeIdResult))
		]
		[Tooltip("MinSeniorityTooltip", typeof(Cf.Data.Resources.GetAvailabilityCeilingByProductTypeId_EmployeeIdResult))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<byte> MinSeniority {get; set; }
		
		[Display(
			Name = "MinReusePeriod",
			ResourceType = typeof(Cf.Data.Resources.GetAvailabilityCeilingByProductTypeId_EmployeeIdResult))
		]
		[Tooltip("MinReusePeriodTooltip", typeof(Cf.Data.Resources.GetAvailabilityCeilingByProductTypeId_EmployeeIdResult))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<byte> MinReusePeriod {get; set; }
		
		[Display(
			Name = "MaxAmount",
			ResourceType = typeof(Cf.Data.Resources.GetAvailabilityCeilingByProductTypeId_EmployeeIdResult))
		]
		[Tooltip("MaxAmountTooltip", typeof(Cf.Data.Resources.GetAvailabilityCeilingByProductTypeId_EmployeeIdResult))]
        public Nullable<decimal> MaxAmount {get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region GetDebts filter and result classes
	#region GetDebtsFilter meta data class definition
    /// <summary>
    /// Metadata for GetDebtsFilter class
    /// </summary>
	public partial class GetDebtsFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for GetDebtsFilter.EmployeeId property
        /// </summary>
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.GetDebtsFilter))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.GetDebtsFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> EmployeeId { get; set; }
		
        /// <summary>
        /// Metadata for GetDebtsFilter.Date property
        /// </summary>
		[Display(
			Name = "Date",
			ResourceType = typeof(Cf.Data.Resources.GetDebtsFilter))
		]
		[Tooltip("DateTooltip", typeof(Cf.Data.Resources.GetDebtsFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> Date { get; set; }
		#endregion
	}
	#endregion

    #region GetDebtsResultMetaData class definition
	/// <summary>
    /// Result class for GetDebts.
	/// </summary>
	public partial class GetDebtsResultMetaData
	{
		#region Public properties
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.GetDebtsResult))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.GetDebtsResult))]
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
        public int Id {get; set; }
		
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.GetDebtsResult))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.GetDebtsResult))]
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
        public int EmployeeId {get; set; }
		
		[Display(
			Name = "OriginalAmount",
			ResourceType = typeof(Cf.Data.Resources.GetDebtsResult))
		]
		[Tooltip("OriginalAmountTooltip", typeof(Cf.Data.Resources.GetDebtsResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal OriginalAmount {get; set; }
		
		[Display(
			Name = "RemainingAmount",
			ResourceType = typeof(Cf.Data.Resources.GetDebtsResult))
		]
		[Tooltip("RemainingAmountTooltip", typeof(Cf.Data.Resources.GetDebtsResult))]
        public Nullable<decimal> RemainingAmount {get; set; }
		
		[Display(
			Name = "Installment",
			ResourceType = typeof(Cf.Data.Resources.GetDebtsResult))
		]
		[Tooltip("InstallmentTooltip", typeof(Cf.Data.Resources.GetDebtsResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal Installment {get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region GetDebtScalar filter and result classes
	#region GetDebtScalarFilter meta data class definition
    /// <summary>
    /// Metadata for GetDebtScalarFilter class
    /// </summary>
	public partial class GetDebtScalarFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for GetDebtScalarFilter.Date property
        /// </summary>
		[Display(
			Name = "Date",
			ResourceType = typeof(Cf.Data.Resources.GetDebtScalarFilter))
		]
		[Tooltip("DateTooltip", typeof(Cf.Data.Resources.GetDebtScalarFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> Date { get; set; }
		
        /// <summary>
        /// Metadata for GetDebtScalarFilter.EmployeeId property
        /// </summary>
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.GetDebtScalarFilter))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.GetDebtScalarFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> EmployeeId { get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region GetDebtSolvency filter and result classes
	#region GetDebtSolvencyFilter meta data class definition
    /// <summary>
    /// Metadata for GetDebtSolvencyFilter class
    /// </summary>
	public partial class GetDebtSolvencyFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for GetDebtSolvencyFilter.ProductId property
        /// </summary>
		[Display(
			Name = "ProductId",
			ResourceType = typeof(Cf.Data.Resources.GetDebtSolvencyFilter))
		]
		[Tooltip("ProductIdTooltip", typeof(Cf.Data.Resources.GetDebtSolvencyFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> ProductId { get; set; }
		#endregion
	}
	#endregion

    #region GetDebtSolvencyResultMetaData class definition
	/// <summary>
    /// Result class for GetDebtSolvency.
	/// </summary>
	public partial class GetDebtSolvencyResultMetaData
	{
		#region Public properties
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.GetDebtSolvencyResult))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.GetDebtSolvencyResult))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> EmployeeId {get; set; }
		
		[Display(
			Name = "DebtRemainingAmount",
			ResourceType = typeof(Cf.Data.Resources.GetDebtSolvencyResult))
		]
		[Tooltip("DebtRemainingAmountTooltip", typeof(Cf.Data.Resources.GetDebtSolvencyResult))]
        public Nullable<decimal> DebtRemainingAmount {get; set; }
		
		[Display(
			Name = "WarrantRemainingAmount",
			ResourceType = typeof(Cf.Data.Resources.GetDebtSolvencyResult))
		]
		[Tooltip("WarrantRemainingAmountTooltip", typeof(Cf.Data.Resources.GetDebtSolvencyResult))]
        public Nullable<decimal> WarrantRemainingAmount {get; set; }
		
		[Display(
			Name = "TotalAmount",
			ResourceType = typeof(Cf.Data.Resources.GetDebtSolvencyResult))
		]
		[Tooltip("TotalAmountTooltip", typeof(Cf.Data.Resources.GetDebtSolvencyResult))]
        public Nullable<decimal> TotalAmount {get; set; }
		
		[Display(
			Name = "DebtInstallment",
			ResourceType = typeof(Cf.Data.Resources.GetDebtSolvencyResult))
		]
		[Tooltip("DebtInstallmentTooltip", typeof(Cf.Data.Resources.GetDebtSolvencyResult))]
        public Nullable<decimal> DebtInstallment {get; set; }
		
		[Display(
			Name = "WarrantInstallment",
			ResourceType = typeof(Cf.Data.Resources.GetDebtSolvencyResult))
		]
		[Tooltip("WarrantInstallmentTooltip", typeof(Cf.Data.Resources.GetDebtSolvencyResult))]
        public Nullable<decimal> WarrantInstallment {get; set; }
		
		[Display(
			Name = "TotalInstallment",
			ResourceType = typeof(Cf.Data.Resources.GetDebtSolvencyResult))
		]
		[Tooltip("TotalInstallmentTooltip", typeof(Cf.Data.Resources.GetDebtSolvencyResult))]
        public Nullable<decimal> TotalInstallment {get; set; }
		
		[Display(
			Name = "MaxAllowedDebt",
			ResourceType = typeof(Cf.Data.Resources.GetDebtSolvencyResult))
		]
		[Tooltip("MaxAllowedDebtTooltip", typeof(Cf.Data.Resources.GetDebtSolvencyResult))]
        public Nullable<decimal> MaxAllowedDebt {get; set; }
		
		[Display(
			Name = "MaxAllowedDeduction",
			ResourceType = typeof(Cf.Data.Resources.GetDebtSolvencyResult))
		]
		[Tooltip("MaxAllowedDeductionTooltip", typeof(Cf.Data.Resources.GetDebtSolvencyResult))]
        public Nullable<decimal> MaxAllowedDeduction {get; set; }
		
		[Display(
			Name = "IncomeSolvency",
			ResourceType = typeof(Cf.Data.Resources.GetDebtSolvencyResult))
		]
		[Tooltip("IncomeSolvencyTooltip", typeof(Cf.Data.Resources.GetDebtSolvencyResult))]
        public Nullable<decimal> IncomeSolvency {get; set; }
		
		[Display(
			Name = "NetSalarySolvency",
			ResourceType = typeof(Cf.Data.Resources.GetDebtSolvencyResult))
		]
		[Tooltip("NetSalarySolvencyTooltip", typeof(Cf.Data.Resources.GetDebtSolvencyResult))]
        public Nullable<decimal> NetSalarySolvency {get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region GetDueProfit filter and result classes
	#region GetDueProfitFilter meta data class definition
    /// <summary>
    /// Metadata for GetDueProfitFilter class
    /// </summary>
	public partial class GetDueProfitFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for GetDueProfitFilter.Amount property
        /// </summary>
		[Display(
			Name = "Amount",
			ResourceType = typeof(Cf.Data.Resources.GetDueProfitFilter))
		]
		[Tooltip("AmountTooltip", typeof(Cf.Data.Resources.GetDueProfitFilter))]
        public Nullable<decimal> Amount { get; set; }
		
        /// <summary>
        /// Metadata for GetDueProfitFilter.Period property
        /// </summary>
		[Display(
			Name = "Period",
			ResourceType = typeof(Cf.Data.Resources.GetDueProfitFilter))
		]
		[Tooltip("PeriodTooltip", typeof(Cf.Data.Resources.GetDueProfitFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<short> Period { get; set; }
		
        /// <summary>
        /// Metadata for GetDueProfitFilter.Rate property
        /// </summary>
		[Display(
			Name = "Rate",
			ResourceType = typeof(Cf.Data.Resources.GetDueProfitFilter))
		]
		[Tooltip("RateTooltip", typeof(Cf.Data.Resources.GetDueProfitFilter))]
        public Nullable<double> Rate { get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region GetEmployeeDebts filter and result classes
	#region GetEmployeeDebtsFilter meta data class definition
    /// <summary>
    /// Metadata for GetEmployeeDebtsFilter class
    /// </summary>
	public partial class GetEmployeeDebtsFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for GetEmployeeDebtsFilter.EmployeeId property
        /// </summary>
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeDebtsFilter))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.GetEmployeeDebtsFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> EmployeeId { get; set; }
		
        /// <summary>
        /// Metadata for GetEmployeeDebtsFilter.Date property
        /// </summary>
		[Display(
			Name = "Date",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeDebtsFilter))
		]
		[Tooltip("DateTooltip", typeof(Cf.Data.Resources.GetEmployeeDebtsFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> Date { get; set; }
		#endregion
	}
	#endregion

    #region GetEmployeeDebtsResultMetaData class definition
	/// <summary>
    /// Result class for GetEmployeeDebts.
	/// </summary>
	public partial class GetEmployeeDebtsResultMetaData
	{
		#region Public properties
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeDebtsResult))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.GetEmployeeDebtsResult))]
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
        public int EmployeeId {get; set; }
		
		[Display(
			Name = "OriginalAmount",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeDebtsResult))
		]
		[Tooltip("OriginalAmountTooltip", typeof(Cf.Data.Resources.GetEmployeeDebtsResult))]
        public Nullable<decimal> OriginalAmount {get; set; }
		
		[Display(
			Name = "RemainingAmount",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeDebtsResult))
		]
		[Tooltip("RemainingAmountTooltip", typeof(Cf.Data.Resources.GetEmployeeDebtsResult))]
        public Nullable<decimal> RemainingAmount {get; set; }
		
		[Display(
			Name = "Installment",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeDebtsResult))
		]
		[Tooltip("InstallmentTooltip", typeof(Cf.Data.Resources.GetEmployeeDebtsResult))]
        public Nullable<decimal> Installment {get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region GetEmployeeSolvency filter and result classes
	#region GetEmployeeSolvencyFilter meta data class definition
    /// <summary>
    /// Metadata for GetEmployeeSolvencyFilter class
    /// </summary>
	public partial class GetEmployeeSolvencyFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for GetEmployeeSolvencyFilter.EmployeeId property
        /// </summary>
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeSolvencyFilter))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.GetEmployeeSolvencyFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> EmployeeId { get; set; }
		
        /// <summary>
        /// Metadata for GetEmployeeSolvencyFilter.Date property
        /// </summary>
		[Display(
			Name = "Date",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeSolvencyFilter))
		]
		[Tooltip("DateTooltip", typeof(Cf.Data.Resources.GetEmployeeSolvencyFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> Date { get; set; }
		
        /// <summary>
        /// Metadata for GetEmployeeSolvencyFilter.Amount property
        /// </summary>
		[Display(
			Name = "Amount",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeSolvencyFilter))
		]
		[Tooltip("AmountTooltip", typeof(Cf.Data.Resources.GetEmployeeSolvencyFilter))]
        public Nullable<decimal> Amount { get; set; }
		
        /// <summary>
        /// Metadata for GetEmployeeSolvencyFilter.Installment property
        /// </summary>
		[Display(
			Name = "Installment",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeSolvencyFilter))
		]
		[Tooltip("InstallmentTooltip", typeof(Cf.Data.Resources.GetEmployeeSolvencyFilter))]
        public Nullable<decimal> Installment { get; set; }
		
        /// <summary>
        /// Metadata for GetEmployeeSolvencyFilter.GrossSalary property
        /// </summary>
		[Display(
			Name = "GrossSalary",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeSolvencyFilter))
		]
		[Tooltip("GrossSalaryTooltip", typeof(Cf.Data.Resources.GetEmployeeSolvencyFilter))]
        public Nullable<decimal> GrossSalary { get; set; }
		
        /// <summary>
        /// Metadata for GetEmployeeSolvencyFilter.NetSalary property
        /// </summary>
		[Display(
			Name = "NetSalary",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeSolvencyFilter))
		]
		[Tooltip("NetSalaryTooltip", typeof(Cf.Data.Resources.GetEmployeeSolvencyFilter))]
        public Nullable<decimal> NetSalary { get; set; }
		#endregion
	}
	#endregion

    #region GetEmployeeSolvencyResultMetaData class definition
	/// <summary>
    /// Result class for GetEmployeeSolvency.
	/// </summary>
	public partial class GetEmployeeSolvencyResultMetaData
	{
		#region Public properties
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeSolvencyResult))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.GetEmployeeSolvencyResult))]
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
        public int EmployeeId {get; set; }
		
		[Display(
			Name = "FullName",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeSolvencyResult))
		]
		[Tooltip("FullNameTooltip", typeof(Cf.Data.Resources.GetEmployeeSolvencyResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			100,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string FullName {get; set; }
		
		[Display(
			Name = "DebtRemainingAmount",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeSolvencyResult))
		]
		[Tooltip("DebtRemainingAmountTooltip", typeof(Cf.Data.Resources.GetEmployeeSolvencyResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal DebtRemainingAmount {get; set; }
		
		[Display(
			Name = "WarrantRemainingAmount",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeSolvencyResult))
		]
		[Tooltip("WarrantRemainingAmountTooltip", typeof(Cf.Data.Resources.GetEmployeeSolvencyResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal WarrantRemainingAmount {get; set; }
		
		[Display(
			Name = "TotalAmount",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeSolvencyResult))
		]
		[Tooltip("TotalAmountTooltip", typeof(Cf.Data.Resources.GetEmployeeSolvencyResult))]
        public Nullable<decimal> TotalAmount {get; set; }
		
		[Display(
			Name = "DebtInstallment",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeSolvencyResult))
		]
		[Tooltip("DebtInstallmentTooltip", typeof(Cf.Data.Resources.GetEmployeeSolvencyResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal DebtInstallment {get; set; }
		
		[Display(
			Name = "WarrantInstallment",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeSolvencyResult))
		]
		[Tooltip("WarrantInstallmentTooltip", typeof(Cf.Data.Resources.GetEmployeeSolvencyResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal WarrantInstallment {get; set; }
		
		[Display(
			Name = "TotalInstallment",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeSolvencyResult))
		]
		[Tooltip("TotalInstallmentTooltip", typeof(Cf.Data.Resources.GetEmployeeSolvencyResult))]
        public Nullable<decimal> TotalInstallment {get; set; }
		
		[Display(
			Name = "MaxAllowedDebt",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeSolvencyResult))
		]
		[Tooltip("MaxAllowedDebtTooltip", typeof(Cf.Data.Resources.GetEmployeeSolvencyResult))]
        public Nullable<decimal> MaxAllowedDebt {get; set; }
		
		[Display(
			Name = "MaxAllowedDeduction",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeSolvencyResult))
		]
		[Tooltip("MaxAllowedDeductionTooltip", typeof(Cf.Data.Resources.GetEmployeeSolvencyResult))]
        public Nullable<decimal> MaxAllowedDeduction {get; set; }
		
		[Display(
			Name = "IncomeSolvency",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeSolvencyResult))
		]
		[Tooltip("IncomeSolvencyTooltip", typeof(Cf.Data.Resources.GetEmployeeSolvencyResult))]
        public Nullable<decimal> IncomeSolvency {get; set; }
		
		[Display(
			Name = "NetSalarySolvency",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeSolvencyResult))
		]
		[Tooltip("NetSalarySolvencyTooltip", typeof(Cf.Data.Resources.GetEmployeeSolvencyResult))]
        public Nullable<decimal> NetSalarySolvency {get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region GetEmployeeSumDebts filter and result classes
	#region GetEmployeeSumDebtsFilter meta data class definition
    /// <summary>
    /// Metadata for GetEmployeeSumDebtsFilter class
    /// </summary>
	public partial class GetEmployeeSumDebtsFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for GetEmployeeSumDebtsFilter.EmployeeId property
        /// </summary>
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeSumDebtsFilter))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.GetEmployeeSumDebtsFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> EmployeeId { get; set; }
		
        /// <summary>
        /// Metadata for GetEmployeeSumDebtsFilter.Date property
        /// </summary>
		[Display(
			Name = "Date",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeSumDebtsFilter))
		]
		[Tooltip("DateTooltip", typeof(Cf.Data.Resources.GetEmployeeSumDebtsFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> Date { get; set; }
		#endregion
	}
	#endregion

    #region GetEmployeeSumDebtsResultMetaData class definition
	/// <summary>
    /// Result class for GetEmployeeSumDebts.
	/// </summary>
	public partial class GetEmployeeSumDebtsResultMetaData
	{
		#region Public properties
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeSumDebtsResult))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.GetEmployeeSumDebtsResult))]
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
        public int EmployeeId {get; set; }
		
		[Display(
			Name = "FullName",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeSumDebtsResult))
		]
		[Tooltip("FullNameTooltip", typeof(Cf.Data.Resources.GetEmployeeSumDebtsResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[StringLength(
			100,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string FullName {get; set; }
		
		[Display(
			Name = "HasDebts",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeSumDebtsResult))
		]
		[Tooltip("HasDebtsTooltip", typeof(Cf.Data.Resources.GetEmployeeSumDebtsResult))]
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
        public int HasDebts {get; set; }
		
		[Display(
			Name = "DebtOriginalAmount",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeSumDebtsResult))
		]
		[Tooltip("DebtOriginalAmountTooltip", typeof(Cf.Data.Resources.GetEmployeeSumDebtsResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal DebtOriginalAmount {get; set; }
		
		[Display(
			Name = "DebtRemainingAmount",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeSumDebtsResult))
		]
		[Tooltip("DebtRemainingAmountTooltip", typeof(Cf.Data.Resources.GetEmployeeSumDebtsResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal DebtRemainingAmount {get; set; }
		
		[Display(
			Name = "DebtInstallment",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeSumDebtsResult))
		]
		[Tooltip("DebtInstallmentTooltip", typeof(Cf.Data.Resources.GetEmployeeSumDebtsResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal DebtInstallment {get; set; }
		
		[Display(
			Name = "HasWarrants",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeSumDebtsResult))
		]
		[Tooltip("HasWarrantsTooltip", typeof(Cf.Data.Resources.GetEmployeeSumDebtsResult))]
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
        public int HasWarrants {get; set; }
		
		[Display(
			Name = "WarrantOriginalAmount",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeSumDebtsResult))
		]
		[Tooltip("WarrantOriginalAmountTooltip", typeof(Cf.Data.Resources.GetEmployeeSumDebtsResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal WarrantOriginalAmount {get; set; }
		
		[Display(
			Name = "WarrantRemainingAmount",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeSumDebtsResult))
		]
		[Tooltip("WarrantRemainingAmountTooltip", typeof(Cf.Data.Resources.GetEmployeeSumDebtsResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal WarrantRemainingAmount {get; set; }
		
		[Display(
			Name = "WarrantInstallment",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeSumDebtsResult))
		]
		[Tooltip("WarrantInstallmentTooltip", typeof(Cf.Data.Resources.GetEmployeeSumDebtsResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal WarrantInstallment {get; set; }
		
		[Display(
			Name = "TotalAmount",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeSumDebtsResult))
		]
		[Tooltip("TotalAmountTooltip", typeof(Cf.Data.Resources.GetEmployeeSumDebtsResult))]
        public Nullable<decimal> TotalAmount {get; set; }
		
		[Display(
			Name = "TotalInstallment",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeSumDebtsResult))
		]
		[Tooltip("TotalInstallmentTooltip", typeof(Cf.Data.Resources.GetEmployeeSumDebtsResult))]
        public Nullable<decimal> TotalInstallment {get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region GetEmployeeWarrants filter and result classes
	#region GetEmployeeWarrantsFilter meta data class definition
    /// <summary>
    /// Metadata for GetEmployeeWarrantsFilter class
    /// </summary>
	public partial class GetEmployeeWarrantsFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for GetEmployeeWarrantsFilter.EmployeeId property
        /// </summary>
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeWarrantsFilter))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.GetEmployeeWarrantsFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> EmployeeId { get; set; }
		
        /// <summary>
        /// Metadata for GetEmployeeWarrantsFilter.Date property
        /// </summary>
		[Display(
			Name = "Date",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeWarrantsFilter))
		]
		[Tooltip("DateTooltip", typeof(Cf.Data.Resources.GetEmployeeWarrantsFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> Date { get; set; }
		#endregion
	}
	#endregion

    #region GetEmployeeWarrantsResultMetaData class definition
	/// <summary>
    /// Result class for GetEmployeeWarrants.
	/// </summary>
	public partial class GetEmployeeWarrantsResultMetaData
	{
		#region Public properties
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeWarrantsResult))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.GetEmployeeWarrantsResult))]
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
        public int EmployeeId {get; set; }
		
		[Display(
			Name = "OriginalAmount",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeWarrantsResult))
		]
		[Tooltip("OriginalAmountTooltip", typeof(Cf.Data.Resources.GetEmployeeWarrantsResult))]
        public Nullable<decimal> OriginalAmount {get; set; }
		
		[Display(
			Name = "RemainingAmount",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeWarrantsResult))
		]
		[Tooltip("RemainingAmountTooltip", typeof(Cf.Data.Resources.GetEmployeeWarrantsResult))]
        public Nullable<decimal> RemainingAmount {get; set; }
		
		[Display(
			Name = "Installment",
			ResourceType = typeof(Cf.Data.Resources.GetEmployeeWarrantsResult))
		]
		[Tooltip("InstallmentTooltip", typeof(Cf.Data.Resources.GetEmployeeWarrantsResult))]
        public Nullable<decimal> Installment {get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region GetFinancialRatio filter and result classes
	#region GetFinancialRatioFilter meta data class definition
    /// <summary>
    /// Metadata for GetFinancialRatioFilter class
    /// </summary>
	public partial class GetFinancialRatioFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for GetFinancialRatioFilter.Period property
        /// </summary>
		[Display(
			Name = "Period",
			ResourceType = typeof(Cf.Data.Resources.GetFinancialRatioFilter))
		]
		[Tooltip("PeriodTooltip", typeof(Cf.Data.Resources.GetFinancialRatioFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<short> Period { get; set; }
		
        /// <summary>
        /// Metadata for GetFinancialRatioFilter.Rate property
        /// </summary>
		[Display(
			Name = "Rate",
			ResourceType = typeof(Cf.Data.Resources.GetFinancialRatioFilter))
		]
		[Tooltip("RateTooltip", typeof(Cf.Data.Resources.GetFinancialRatioFilter))]
        public Nullable<double> Rate { get; set; }
		
        /// <summary>
        /// Metadata for GetFinancialRatioFilter.Type property
        /// </summary>
		[Display(
			Name = "Type",
			ResourceType = typeof(Cf.Data.Resources.GetFinancialRatioFilter))
		]
		[Tooltip("TypeTooltip", typeof(Cf.Data.Resources.GetFinancialRatioFilter))]
        public Nullable<bool> Type { get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region GetInstallment filter and result classes
	#region GetInstallmentFilter meta data class definition
    /// <summary>
    /// Metadata for GetInstallmentFilter class
    /// </summary>
	public partial class GetInstallmentFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for GetInstallmentFilter.Amount property
        /// </summary>
		[Display(
			Name = "Amount",
			ResourceType = typeof(Cf.Data.Resources.GetInstallmentFilter))
		]
		[Tooltip("AmountTooltip", typeof(Cf.Data.Resources.GetInstallmentFilter))]
        public Nullable<decimal> Amount { get; set; }
		
        /// <summary>
        /// Metadata for GetInstallmentFilter.Period property
        /// </summary>
		[Display(
			Name = "Period",
			ResourceType = typeof(Cf.Data.Resources.GetInstallmentFilter))
		]
		[Tooltip("PeriodTooltip", typeof(Cf.Data.Resources.GetInstallmentFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<short> Period { get; set; }
		
        /// <summary>
        /// Metadata for GetInstallmentFilter.Rate property
        /// </summary>
		[Display(
			Name = "Rate",
			ResourceType = typeof(Cf.Data.Resources.GetInstallmentFilter))
		]
		[Tooltip("RateTooltip", typeof(Cf.Data.Resources.GetInstallmentFilter))]
        public Nullable<double> Rate { get; set; }
		
        /// <summary>
        /// Metadata for GetInstallmentFilter.Type property
        /// </summary>
		[Display(
			Name = "Type",
			ResourceType = typeof(Cf.Data.Resources.GetInstallmentFilter))
		]
		[Tooltip("TypeTooltip", typeof(Cf.Data.Resources.GetInstallmentFilter))]
        public Nullable<bool> Type { get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region GetInstallmentPaidAmounts filter and result classes
	#region GetInstallmentPaidAmountsFilter meta data class definition
    /// <summary>
    /// Metadata for GetInstallmentPaidAmountsFilter class
    /// </summary>
	public partial class GetInstallmentPaidAmountsFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for GetInstallmentPaidAmountsFilter.RefundableProductId property
        /// </summary>
		[Display(
			Name = "RefundableProductId",
			ResourceType = typeof(Cf.Data.Resources.GetInstallmentPaidAmountsFilter))
		]
		[Tooltip("RefundableProductIdTooltip", typeof(Cf.Data.Resources.GetInstallmentPaidAmountsFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> RefundableProductId { get; set; }
		#endregion
	}
	#endregion

    #region GetInstallmentPaidAmountsResultMetaData class definition
	/// <summary>
    /// Result class for GetInstallmentPaidAmounts.
	/// </summary>
	public partial class GetInstallmentPaidAmountsResultMetaData
	{
		#region Public properties
		[Display(
			Name = "RefundableProductId",
			ResourceType = typeof(Cf.Data.Resources.GetInstallmentPaidAmountsResult))
		]
		[Tooltip("RefundableProductIdTooltip", typeof(Cf.Data.Resources.GetInstallmentPaidAmountsResult))]
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
        public int RefundableProductId {get; set; }
		
		[Display(
			Name = "InstallmentId",
			ResourceType = typeof(Cf.Data.Resources.GetInstallmentPaidAmountsResult))
		]
		[Tooltip("InstallmentIdTooltip", typeof(Cf.Data.Resources.GetInstallmentPaidAmountsResult))]
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
        public int InstallmentId {get; set; }
		
		[Display(
			Name = "PaidAmount",
			ResourceType = typeof(Cf.Data.Resources.GetInstallmentPaidAmountsResult))
		]
		[Tooltip("PaidAmountTooltip", typeof(Cf.Data.Resources.GetInstallmentPaidAmountsResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal PaidAmount {get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region GetInstallments filter and result classes
	#region GetInstallmentsFilter meta data class definition
    /// <summary>
    /// Metadata for GetInstallmentsFilter class
    /// </summary>
	public partial class GetInstallmentsFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for GetInstallmentsFilter.RefundableProductId property
        /// </summary>
		[Display(
			Name = "RefundableProductId",
			ResourceType = typeof(Cf.Data.Resources.GetInstallmentsFilter))
		]
		[Tooltip("RefundableProductIdTooltip", typeof(Cf.Data.Resources.GetInstallmentsFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> RefundableProductId { get; set; }
		#endregion
	}
	#endregion

    #region GetInstallmentsResultMetaData class definition
	/// <summary>
    /// Result class for GetInstallments.
	/// </summary>
	public partial class GetInstallmentsResultMetaData
	{
		#region Public properties
		[Display(
			Name = "RefundableProductId",
			ResourceType = typeof(Cf.Data.Resources.GetInstallmentsResult))
		]
		[Tooltip("RefundableProductIdTooltip", typeof(Cf.Data.Resources.GetInstallmentsResult))]
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
        public int RefundableProductId {get; set; }
		
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.GetInstallmentsResult))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.GetInstallmentsResult))]
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
        public int Id {get; set; }
		
		[Display(
			Name = "RefundableProduct",
			ResourceType = typeof(Cf.Data.Resources.GetInstallmentsResult))
		]
		[Tooltip("RefundableProductTooltip", typeof(Cf.Data.Resources.GetInstallmentsResult))]
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
        public int RefundableProduct {get; set; }
		
		[Display(
			Name = "SubNumber",
			ResourceType = typeof(Cf.Data.Resources.GetInstallmentsResult))
		]
		[Tooltip("SubNumberTooltip", typeof(Cf.Data.Resources.GetInstallmentsResult))]
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
        public short SubNumber {get; set; }
		
		[Display(
			Name = "DueDate",
			ResourceType = typeof(Cf.Data.Resources.GetInstallmentsResult))
		]
		[Tooltip("DueDateTooltip", typeof(Cf.Data.Resources.GetInstallmentsResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public DateTime DueDate {get; set; }
		
		[Display(
			Name = "DueCapital",
			ResourceType = typeof(Cf.Data.Resources.GetInstallmentsResult))
		]
		[Tooltip("DueCapitalTooltip", typeof(Cf.Data.Resources.GetInstallmentsResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal DueCapital {get; set; }
		
		[Display(
			Name = "DueProfit",
			ResourceType = typeof(Cf.Data.Resources.GetInstallmentsResult))
		]
		[Tooltip("DueProfitTooltip", typeof(Cf.Data.Resources.GetInstallmentsResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal DueProfit {get; set; }
		
		[Display(
			Name = "PaidAmount",
			ResourceType = typeof(Cf.Data.Resources.GetInstallmentsResult))
		]
		[Tooltip("PaidAmountTooltip", typeof(Cf.Data.Resources.GetInstallmentsResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal PaidAmount {get; set; }
		
		[Display(
			Name = "PaymentStatus",
			ResourceType = typeof(Cf.Data.Resources.GetInstallmentsResult))
		]
		[Tooltip("PaymentStatusTooltip", typeof(Cf.Data.Resources.GetInstallmentsResult))]
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
        public int PaymentStatus {get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region GetPresentValue filter and result classes
	#region GetPresentValueFilter meta data class definition
    /// <summary>
    /// Metadata for GetPresentValueFilter class
    /// </summary>
	public partial class GetPresentValueFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for GetPresentValueFilter.Installment property
        /// </summary>
		[Display(
			Name = "Installment",
			ResourceType = typeof(Cf.Data.Resources.GetPresentValueFilter))
		]
		[Tooltip("InstallmentTooltip", typeof(Cf.Data.Resources.GetPresentValueFilter))]
        public Nullable<decimal> Installment { get; set; }
		
        /// <summary>
        /// Metadata for GetPresentValueFilter.Period property
        /// </summary>
		[Display(
			Name = "Period",
			ResourceType = typeof(Cf.Data.Resources.GetPresentValueFilter))
		]
		[Tooltip("PeriodTooltip", typeof(Cf.Data.Resources.GetPresentValueFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<short> Period { get; set; }
		
        /// <summary>
        /// Metadata for GetPresentValueFilter.Rate property
        /// </summary>
		[Display(
			Name = "Rate",
			ResourceType = typeof(Cf.Data.Resources.GetPresentValueFilter))
		]
		[Tooltip("RateTooltip", typeof(Cf.Data.Resources.GetPresentValueFilter))]
        public Nullable<double> Rate { get; set; }
		
        /// <summary>
        /// Metadata for GetPresentValueFilter.Type property
        /// </summary>
		[Display(
			Name = "Type",
			ResourceType = typeof(Cf.Data.Resources.GetPresentValueFilter))
		]
		[Tooltip("TypeTooltip", typeof(Cf.Data.Resources.GetPresentValueFilter))]
        public Nullable<bool> Type { get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region GetRefundableProducts filter and result classes
	#region GetRefundableProductsFilter meta data class definition
    /// <summary>
    /// Metadata for GetRefundableProductsFilter class
    /// </summary>
	public partial class GetRefundableProductsFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for GetRefundableProductsFilter.EmployeeId property
        /// </summary>
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.GetRefundableProductsFilter))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.GetRefundableProductsFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> EmployeeId { get; set; }
		#endregion
	}
	#endregion

    #region GetRefundableProductsResultMetaData class definition
	/// <summary>
    /// Result class for GetRefundableProducts.
	/// </summary>
	public partial class GetRefundableProductsResultMetaData
	{
		#region Public properties
		[Display(
			Name = "ProductId",
			ResourceType = typeof(Cf.Data.Resources.GetRefundableProductsResult))
		]
		[Tooltip("ProductIdTooltip", typeof(Cf.Data.Resources.GetRefundableProductsResult))]
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
        public int ProductId {get; set; }
		
		[Display(
			Name = "ProductEmployeeId",
			ResourceType = typeof(Cf.Data.Resources.GetRefundableProductsResult))
		]
		[Tooltip("ProductEmployeeIdTooltip", typeof(Cf.Data.Resources.GetRefundableProductsResult))]
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
        public int ProductEmployeeId {get; set; }
		
		[Display(
			Name = "Installment",
			ResourceType = typeof(Cf.Data.Resources.GetRefundableProductsResult))
		]
		[Tooltip("InstallmentTooltip", typeof(Cf.Data.Resources.GetRefundableProductsResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal Installment {get; set; }
		
		[Display(
			Name = "NetAmount",
			ResourceType = typeof(Cf.Data.Resources.GetRefundableProductsResult))
		]
		[Tooltip("NetAmountTooltip", typeof(Cf.Data.Resources.GetRefundableProductsResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal NetAmount {get; set; }
		
		[Display(
			Name = "ProfitAmount",
			ResourceType = typeof(Cf.Data.Resources.GetRefundableProductsResult))
		]
		[Tooltip("ProfitAmountTooltip", typeof(Cf.Data.Resources.GetRefundableProductsResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public decimal ProfitAmount {get; set; }
		
		[Display(
			Name = "PaymentPeriod",
			ResourceType = typeof(Cf.Data.Resources.GetRefundableProductsResult))
		]
		[Tooltip("PaymentPeriodTooltip", typeof(Cf.Data.Resources.GetRefundableProductsResult))]
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
        public short PaymentPeriod {get; set; }
		
		[Display(
			Name = "DueAmount",
			ResourceType = typeof(Cf.Data.Resources.GetRefundableProductsResult))
		]
		[Tooltip("DueAmountTooltip", typeof(Cf.Data.Resources.GetRefundableProductsResult))]
        public Nullable<decimal> DueAmount {get; set; }
		
		[Display(
			Name = "PaidAmount",
			ResourceType = typeof(Cf.Data.Resources.GetRefundableProductsResult))
		]
		[Tooltip("PaidAmountTooltip", typeof(Cf.Data.Resources.GetRefundableProductsResult))]
        public Nullable<decimal> PaidAmount {get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region GetWarrants filter and result classes
	#region GetWarrantsFilter meta data class definition
    /// <summary>
    /// Metadata for GetWarrantsFilter class
    /// </summary>
	public partial class GetWarrantsFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for GetWarrantsFilter.EmployeeId property
        /// </summary>
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.GetWarrantsFilter))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.GetWarrantsFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> EmployeeId { get; set; }
		
        /// <summary>
        /// Metadata for GetWarrantsFilter.Date property
        /// </summary>
		[Display(
			Name = "Date",
			ResourceType = typeof(Cf.Data.Resources.GetWarrantsFilter))
		]
		[Tooltip("DateTooltip", typeof(Cf.Data.Resources.GetWarrantsFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> Date { get; set; }
		#endregion
	}
	#endregion

    #region GetWarrantsResultMetaData class definition
	/// <summary>
    /// Result class for GetWarrants.
	/// </summary>
	public partial class GetWarrantsResultMetaData
	{
		#region Public properties
		[Display(
			Name = "Id",
			ResourceType = typeof(Cf.Data.Resources.GetWarrantsResult))
		]
		[Tooltip("IdTooltip", typeof(Cf.Data.Resources.GetWarrantsResult))]
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
        public int Id {get; set; }
		
		[Display(
			Name = "DebtId",
			ResourceType = typeof(Cf.Data.Resources.GetWarrantsResult))
		]
		[Tooltip("DebtIdTooltip", typeof(Cf.Data.Resources.GetWarrantsResult))]
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
        public int DebtId {get; set; }
		
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.GetWarrantsResult))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.GetWarrantsResult))]
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
        public int EmployeeId {get; set; }
		
		[Display(
			Name = "OriginalAmount",
			ResourceType = typeof(Cf.Data.Resources.GetWarrantsResult))
		]
		[Tooltip("OriginalAmountTooltip", typeof(Cf.Data.Resources.GetWarrantsResult))]
        public Nullable<decimal> OriginalAmount {get; set; }
		
		[Display(
			Name = "RemainingAmount",
			ResourceType = typeof(Cf.Data.Resources.GetWarrantsResult))
		]
		[Tooltip("RemainingAmountTooltip", typeof(Cf.Data.Resources.GetWarrantsResult))]
        public Nullable<decimal> RemainingAmount {get; set; }
		
		[Display(
			Name = "Installment",
			ResourceType = typeof(Cf.Data.Resources.GetWarrantsResult))
		]
		[Tooltip("InstallmentTooltip", typeof(Cf.Data.Resources.GetWarrantsResult))]
        public Nullable<decimal> Installment {get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region GetWarrantSolvency filter and result classes
	#region GetWarrantSolvencyFilter meta data class definition
    /// <summary>
    /// Metadata for GetWarrantSolvencyFilter class
    /// </summary>
	public partial class GetWarrantSolvencyFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for GetWarrantSolvencyFilter.EmployeeId property
        /// </summary>
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.GetWarrantSolvencyFilter))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.GetWarrantSolvencyFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> EmployeeId { get; set; }
		
        /// <summary>
        /// Metadata for GetWarrantSolvencyFilter.ProductId property
        /// </summary>
		[Display(
			Name = "ProductId",
			ResourceType = typeof(Cf.Data.Resources.GetWarrantSolvencyFilter))
		]
		[Tooltip("ProductIdTooltip", typeof(Cf.Data.Resources.GetWarrantSolvencyFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> ProductId { get; set; }
		#endregion
	}
	#endregion

    #region GetWarrantSolvencyResultMetaData class definition
	/// <summary>
    /// Result class for GetWarrantSolvency.
	/// </summary>
	public partial class GetWarrantSolvencyResultMetaData
	{
		#region Public properties
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.GetWarrantSolvencyResult))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.GetWarrantSolvencyResult))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> EmployeeId {get; set; }
		
		[Display(
			Name = "DebtRemainingAmount",
			ResourceType = typeof(Cf.Data.Resources.GetWarrantSolvencyResult))
		]
		[Tooltip("DebtRemainingAmountTooltip", typeof(Cf.Data.Resources.GetWarrantSolvencyResult))]
        public Nullable<decimal> DebtRemainingAmount {get; set; }
		
		[Display(
			Name = "WarrantRemainingAmount",
			ResourceType = typeof(Cf.Data.Resources.GetWarrantSolvencyResult))
		]
		[Tooltip("WarrantRemainingAmountTooltip", typeof(Cf.Data.Resources.GetWarrantSolvencyResult))]
        public Nullable<decimal> WarrantRemainingAmount {get; set; }
		
		[Display(
			Name = "TotalAmount",
			ResourceType = typeof(Cf.Data.Resources.GetWarrantSolvencyResult))
		]
		[Tooltip("TotalAmountTooltip", typeof(Cf.Data.Resources.GetWarrantSolvencyResult))]
        public Nullable<decimal> TotalAmount {get; set; }
		
		[Display(
			Name = "DebtInstallment",
			ResourceType = typeof(Cf.Data.Resources.GetWarrantSolvencyResult))
		]
		[Tooltip("DebtInstallmentTooltip", typeof(Cf.Data.Resources.GetWarrantSolvencyResult))]
        public Nullable<decimal> DebtInstallment {get; set; }
		
		[Display(
			Name = "WarrantInstallment",
			ResourceType = typeof(Cf.Data.Resources.GetWarrantSolvencyResult))
		]
		[Tooltip("WarrantInstallmentTooltip", typeof(Cf.Data.Resources.GetWarrantSolvencyResult))]
        public Nullable<decimal> WarrantInstallment {get; set; }
		
		[Display(
			Name = "TotalInstallment",
			ResourceType = typeof(Cf.Data.Resources.GetWarrantSolvencyResult))
		]
		[Tooltip("TotalInstallmentTooltip", typeof(Cf.Data.Resources.GetWarrantSolvencyResult))]
        public Nullable<decimal> TotalInstallment {get; set; }
		
		[Display(
			Name = "MaxAllowedDebt",
			ResourceType = typeof(Cf.Data.Resources.GetWarrantSolvencyResult))
		]
		[Tooltip("MaxAllowedDebtTooltip", typeof(Cf.Data.Resources.GetWarrantSolvencyResult))]
        public Nullable<decimal> MaxAllowedDebt {get; set; }
		
		[Display(
			Name = "MaxAllowedDeduction",
			ResourceType = typeof(Cf.Data.Resources.GetWarrantSolvencyResult))
		]
		[Tooltip("MaxAllowedDeductionTooltip", typeof(Cf.Data.Resources.GetWarrantSolvencyResult))]
        public Nullable<decimal> MaxAllowedDeduction {get; set; }
		
		[Display(
			Name = "IncomeSolvency",
			ResourceType = typeof(Cf.Data.Resources.GetWarrantSolvencyResult))
		]
		[Tooltip("IncomeSolvencyTooltip", typeof(Cf.Data.Resources.GetWarrantSolvencyResult))]
        public Nullable<decimal> IncomeSolvency {get; set; }
		
		[Display(
			Name = "NetSalarySolvency",
			ResourceType = typeof(Cf.Data.Resources.GetWarrantSolvencyResult))
		]
		[Tooltip("NetSalarySolvencyTooltip", typeof(Cf.Data.Resources.GetWarrantSolvencyResult))]
        public Nullable<decimal> NetSalarySolvency {get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region LoanGenerate filter and result classes
	#region LoanGenerateFilter meta data class definition
    /// <summary>
    /// Metadata for LoanGenerateFilter class
    /// </summary>
	public partial class LoanGenerateFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for LoanGenerateFilter.ProductId property
        /// </summary>
		[Display(
			Name = "ProductId",
			ResourceType = typeof(Cf.Data.Resources.LoanGenerateFilter))
		]
		[Tooltip("ProductIdTooltip", typeof(Cf.Data.Resources.LoanGenerateFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> ProductId { get; set; }
		
        /// <summary>
        /// Metadata for LoanGenerateFilter.LoanDecisionId property
        /// </summary>
		[Display(
			Name = "LoanDecisionId",
			ResourceType = typeof(Cf.Data.Resources.LoanGenerateFilter))
		]
		[Tooltip("LoanDecisionIdTooltip", typeof(Cf.Data.Resources.LoanGenerateFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> LoanDecisionId { get; set; }
		
        /// <summary>
        /// Metadata for LoanGenerateFilter.LoanGenerationStatusId property
        /// </summary>
		[Display(
			Name = "LoanGenerationStatusId",
			ResourceType = typeof(Cf.Data.Resources.LoanGenerateFilter))
		]
		[Tooltip("LoanGenerationStatusIdTooltip", typeof(Cf.Data.Resources.LoanGenerateFilter))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<byte> LoanGenerationStatusId { get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region LoanMoveToEmployee filter and result classes
	#region LoanMoveToEmployeeFilter meta data class definition
    /// <summary>
    /// Metadata for LoanMoveToEmployeeFilter class
    /// </summary>
	public partial class LoanMoveToEmployeeFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for LoanMoveToEmployeeFilter.Loan property
        /// </summary>
		[Display(
			Name = "Loan",
			ResourceType = typeof(Cf.Data.Resources.LoanMoveToEmployeeFilter))
		]
		[Tooltip("LoanTooltip", typeof(Cf.Data.Resources.LoanMoveToEmployeeFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> Loan { get; set; }
		
        /// <summary>
        /// Metadata for LoanMoveToEmployeeFilter.EmployeeId property
        /// </summary>
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.LoanMoveToEmployeeFilter))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.LoanMoveToEmployeeFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> EmployeeId { get; set; }
		
        /// <summary>
        /// Metadata for LoanMoveToEmployeeFilter.LoanDecisionId property
        /// </summary>
		[Display(
			Name = "LoanDecisionId",
			ResourceType = typeof(Cf.Data.Resources.LoanMoveToEmployeeFilter))
		]
		[Tooltip("LoanDecisionIdTooltip", typeof(Cf.Data.Resources.LoanMoveToEmployeeFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> LoanDecisionId { get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region MonthlyBalanceSum filter and result classes
	#region MonthlyBalanceSumFilter meta data class definition
    /// <summary>
    /// Metadata for MonthlyBalanceSumFilter class
    /// </summary>
	public partial class MonthlyBalanceSumFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for MonthlyBalanceSumFilter.MinMonth property
        /// </summary>
		[Display(
			Name = "MinMonth",
			ResourceType = typeof(Cf.Data.Resources.MonthlyBalanceSumFilter))
		]
		[Tooltip("MinMonthTooltip", typeof(Cf.Data.Resources.MonthlyBalanceSumFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> MinMonth { get; set; }
		
        /// <summary>
        /// Metadata for MonthlyBalanceSumFilter.MaxMonth property
        /// </summary>
		[Display(
			Name = "MaxMonth",
			ResourceType = typeof(Cf.Data.Resources.MonthlyBalanceSumFilter))
		]
		[Tooltip("MaxMonthTooltip", typeof(Cf.Data.Resources.MonthlyBalanceSumFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> MaxMonth { get; set; }
		
        /// <summary>
        /// Metadata for MonthlyBalanceSumFilter.EmployeeId property
        /// </summary>
		[Display(
			Name = "EmployeeId",
			ResourceType = typeof(Cf.Data.Resources.MonthlyBalanceSumFilter))
		]
		[Tooltip("EmployeeIdTooltip", typeof(Cf.Data.Resources.MonthlyBalanceSumFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> EmployeeId { get; set; }
		#endregion
	}
	#endregion

    #region MonthlyBalanceSumResultMetaData class definition
	/// <summary>
    /// Result class for MonthlyBalanceSum.
	/// </summary>
	public partial class MonthlyBalanceSumResultMetaData
	{
		#region Public properties
		[Display(
			Name = "Month",
			ResourceType = typeof(Cf.Data.Resources.MonthlyBalanceSumResult))
		]
		[Tooltip("MonthTooltip", typeof(Cf.Data.Resources.MonthlyBalanceSumResult))]
		[Required(
			ErrorMessageResourceName = "RequiredCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public DateTime Month {get; set; }
		
		[Display(
			Name = "Opening",
			ResourceType = typeof(Cf.Data.Resources.MonthlyBalanceSumResult))
		]
		[Tooltip("OpeningTooltip", typeof(Cf.Data.Resources.MonthlyBalanceSumResult))]
        public Nullable<decimal> Opening {get; set; }
		
		[Display(
			Name = "NormalLoans",
			ResourceType = typeof(Cf.Data.Resources.MonthlyBalanceSumResult))
		]
		[Tooltip("NormalLoansTooltip", typeof(Cf.Data.Resources.MonthlyBalanceSumResult))]
        public Nullable<decimal> NormalLoans {get; set; }
		
		[Display(
			Name = "IncomingLoans",
			ResourceType = typeof(Cf.Data.Resources.MonthlyBalanceSumResult))
		]
		[Tooltip("IncomingLoansTooltip", typeof(Cf.Data.Resources.MonthlyBalanceSumResult))]
        public Nullable<decimal> IncomingLoans {get; set; }
		
		[Display(
			Name = "OutgoingLoans",
			ResourceType = typeof(Cf.Data.Resources.MonthlyBalanceSumResult))
		]
		[Tooltip("OutgoingLoansTooltip", typeof(Cf.Data.Resources.MonthlyBalanceSumResult))]
        public Nullable<decimal> OutgoingLoans {get; set; }
		
		[Display(
			Name = "Restitutions",
			ResourceType = typeof(Cf.Data.Resources.MonthlyBalanceSumResult))
		]
		[Tooltip("RestitutionsTooltip", typeof(Cf.Data.Resources.MonthlyBalanceSumResult))]
        public Nullable<decimal> Restitutions {get; set; }
		
		[Display(
			Name = "SalaryPayments",
			ResourceType = typeof(Cf.Data.Resources.MonthlyBalanceSumResult))
		]
		[Tooltip("SalaryPaymentsTooltip", typeof(Cf.Data.Resources.MonthlyBalanceSumResult))]
        public Nullable<decimal> SalaryPayments {get; set; }
		
		[Display(
			Name = "CashPayments",
			ResourceType = typeof(Cf.Data.Resources.MonthlyBalanceSumResult))
		]
		[Tooltip("CashPaymentsTooltip", typeof(Cf.Data.Resources.MonthlyBalanceSumResult))]
        public Nullable<decimal> CashPayments {get; set; }
		
		[Display(
			Name = "AllLoans",
			ResourceType = typeof(Cf.Data.Resources.MonthlyBalanceSumResult))
		]
		[Tooltip("AllLoansTooltip", typeof(Cf.Data.Resources.MonthlyBalanceSumResult))]
        public Nullable<decimal> AllLoans {get; set; }
		
		[Display(
			Name = "AllPayments",
			ResourceType = typeof(Cf.Data.Resources.MonthlyBalanceSumResult))
		]
		[Tooltip("AllPaymentsTooltip", typeof(Cf.Data.Resources.MonthlyBalanceSumResult))]
        public Nullable<decimal> AllPayments {get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region PaymentBetweenTwoDates filter and result classes
	#region PaymentBetweenTwoDatesFilter meta data class definition
    /// <summary>
    /// Metadata for PaymentBetweenTwoDatesFilter class
    /// </summary>
	public partial class PaymentBetweenTwoDatesFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for PaymentBetweenTwoDatesFilter.MinDate property
        /// </summary>
		[Display(
			Name = "MinDate",
			ResourceType = typeof(Cf.Data.Resources.PaymentBetweenTwoDatesFilter))
		]
		[Tooltip("MinDateTooltip", typeof(Cf.Data.Resources.PaymentBetweenTwoDatesFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> MinDate { get; set; }
		
        /// <summary>
        /// Metadata for PaymentBetweenTwoDatesFilter.MaxDate property
        /// </summary>
		[Display(
			Name = "MaxDate",
			ResourceType = typeof(Cf.Data.Resources.PaymentBetweenTwoDatesFilter))
		]
		[Tooltip("MaxDateTooltip", typeof(Cf.Data.Resources.PaymentBetweenTwoDatesFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> MaxDate { get; set; }
		#endregion
	}
	#endregion

    #region PaymentBetweenTwoDatesResultMetaData class definition
	/// <summary>
    /// Result class for PaymentBetweenTwoDates.
	/// </summary>
	public partial class PaymentBetweenTwoDatesResultMetaData
	{
		#region Public properties
		[Display(
			Name = "FirstMonthAmount",
			ResourceType = typeof(Cf.Data.Resources.PaymentBetweenTwoDatesResult))
		]
		[Tooltip("FirstMonthAmountTooltip", typeof(Cf.Data.Resources.PaymentBetweenTwoDatesResult))]
        public Nullable<decimal> FirstMonthAmount {get; set; }
		
		[Display(
			Name = "SecondMonthAmount",
			ResourceType = typeof(Cf.Data.Resources.PaymentBetweenTwoDatesResult))
		]
		[Tooltip("SecondMonthAmountTooltip", typeof(Cf.Data.Resources.PaymentBetweenTwoDatesResult))]
        public Nullable<decimal> SecondMonthAmount {get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region ProductCalculator filter and result classes
	#region ProductCalculatorFilter meta data class definition
    /// <summary>
    /// Metadata for ProductCalculatorFilter class
    /// </summary>
	public partial class ProductCalculatorFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for ProductCalculatorFilter.ProductType property
        /// </summary>
		[Display(
			Name = "ProductType",
			ResourceType = typeof(Cf.Data.Resources.ProductCalculatorFilter))
		]
		[Tooltip("ProductTypeTooltip", typeof(Cf.Data.Resources.ProductCalculatorFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<short> ProductType { get; set; }
		
        /// <summary>
        /// Metadata for ProductCalculatorFilter.Amount property
        /// </summary>
		[Display(
			Name = "Amount",
			ResourceType = typeof(Cf.Data.Resources.ProductCalculatorFilter))
		]
		[Tooltip("AmountTooltip", typeof(Cf.Data.Resources.ProductCalculatorFilter))]
        public Nullable<decimal> Amount { get; set; }
		
        /// <summary>
        /// Metadata for ProductCalculatorFilter.Period property
        /// </summary>
		[Display(
			Name = "Period",
			ResourceType = typeof(Cf.Data.Resources.ProductCalculatorFilter))
		]
		[Tooltip("PeriodTooltip", typeof(Cf.Data.Resources.ProductCalculatorFilter))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<short> Period { get; set; }
		#endregion
	}
	#endregion

    #region ProductCalculatorResultMetaData class definition
	/// <summary>
    /// Result class for ProductCalculator.
	/// </summary>
	public partial class ProductCalculatorResultMetaData
	{
		#region Public properties
		[Display(
			Name = "ProductTypeId",
			ResourceType = typeof(Cf.Data.Resources.ProductCalculatorResult))
		]
		[Tooltip("ProductTypeIdTooltip", typeof(Cf.Data.Resources.ProductCalculatorResult))]
		[Range(
			0,
			32767,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<short> ProductTypeId {get; set; }
		
		[Display(
			Name = "Amount",
			ResourceType = typeof(Cf.Data.Resources.ProductCalculatorResult))
		]
		[Tooltip("AmountTooltip", typeof(Cf.Data.Resources.ProductCalculatorResult))]
        public Nullable<decimal> Amount {get; set; }
		
		[Display(
			Name = "NetAmount",
			ResourceType = typeof(Cf.Data.Resources.ProductCalculatorResult))
		]
		[Tooltip("NetAmountTooltip", typeof(Cf.Data.Resources.ProductCalculatorResult))]
        public Nullable<decimal> NetAmount {get; set; }
		
		[Display(
			Name = "ProfitAmount",
			ResourceType = typeof(Cf.Data.Resources.ProductCalculatorResult))
		]
		[Tooltip("ProfitAmountTooltip", typeof(Cf.Data.Resources.ProductCalculatorResult))]
        public Nullable<decimal> ProfitAmount {get; set; }
		
		[Display(
			Name = "Installment",
			ResourceType = typeof(Cf.Data.Resources.ProductCalculatorResult))
		]
		[Tooltip("InstallmentTooltip", typeof(Cf.Data.Resources.ProductCalculatorResult))]
        public Nullable<decimal> Installment {get; set; }
		
		[Display(
			Name = "Rate",
			ResourceType = typeof(Cf.Data.Resources.ProductCalculatorResult))
		]
		[Tooltip("RateTooltip", typeof(Cf.Data.Resources.ProductCalculatorResult))]
        public Nullable<double> Rate {get; set; }
		
		[Display(
			Name = "AnnualRate",
			ResourceType = typeof(Cf.Data.Resources.ProductCalculatorResult))
		]
		[Tooltip("AnnualRateTooltip", typeof(Cf.Data.Resources.ProductCalculatorResult))]
        public Nullable<decimal> AnnualRate {get; set; }
		
		[Display(
			Name = "GuarantorsCount",
			ResourceType = typeof(Cf.Data.Resources.ProductCalculatorResult))
		]
		[Tooltip("GuarantorsCountTooltip", typeof(Cf.Data.Resources.ProductCalculatorResult))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<byte> GuarantorsCount {get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region ReportLoansBetweenTwoDates filter and result classes
	#region ReportLoansBetweenTwoDatesFilter meta data class definition
    /// <summary>
    /// Metadata for ReportLoansBetweenTwoDatesFilter class
    /// </summary>
	public partial class ReportLoansBetweenTwoDatesFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for ReportLoansBetweenTwoDatesFilter.FromDate property
        /// </summary>
		[Display(
			Name = "FromDate",
			ResourceType = typeof(Cf.Data.Resources.ReportLoansBetweenTwoDatesFilter))
		]
		[Tooltip("FromDateTooltip", typeof(Cf.Data.Resources.ReportLoansBetweenTwoDatesFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> FromDate { get; set; }
		
        /// <summary>
        /// Metadata for ReportLoansBetweenTwoDatesFilter.ToDate property
        /// </summary>
		[Display(
			Name = "ToDate",
			ResourceType = typeof(Cf.Data.Resources.ReportLoansBetweenTwoDatesFilter))
		]
		[Tooltip("ToDateTooltip", typeof(Cf.Data.Resources.ReportLoansBetweenTwoDatesFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> ToDate { get; set; }
		#endregion
	}
	#endregion

    #region ReportLoansBetweenTwoDatesResultMetaData class definition
	/// <summary>
    /// Result class for ReportLoansBetweenTwoDates.
	/// </summary>
	public partial class ReportLoansBetweenTwoDatesResultMetaData
	{
		#region Public properties
		[Display(
			Name = "ProductProductTypeId",
			ResourceType = typeof(Cf.Data.Resources.ReportLoansBetweenTwoDatesResult))
		]
		[Tooltip("ProductProductTypeIdTooltip", typeof(Cf.Data.Resources.ReportLoansBetweenTwoDatesResult))]
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
        public short ProductProductTypeId {get; set; }
		
		[Display(
			Name = "ProductProductTypeName",
			ResourceType = typeof(Cf.Data.Resources.ReportLoansBetweenTwoDatesResult))
		]
		[Tooltip("ProductProductTypeNameTooltip", typeof(Cf.Data.Resources.ReportLoansBetweenTwoDatesResult))]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string ProductProductTypeName {get; set; }
		
		[Display(
			Name = "Amounts",
			ResourceType = typeof(Cf.Data.Resources.ReportLoansBetweenTwoDatesResult))
		]
		[Tooltip("AmountsTooltip", typeof(Cf.Data.Resources.ReportLoansBetweenTwoDatesResult))]
        public Nullable<decimal> Amounts {get; set; }
		
		[Display(
			Name = "LoanCounts",
			ResourceType = typeof(Cf.Data.Resources.ReportLoansBetweenTwoDatesResult))
		]
		[Tooltip("LoanCountsTooltip", typeof(Cf.Data.Resources.ReportLoansBetweenTwoDatesResult))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> LoanCounts {get; set; }
		
		[Display(
			Name = "ProfitAmount",
			ResourceType = typeof(Cf.Data.Resources.ReportLoansBetweenTwoDatesResult))
		]
		[Tooltip("ProfitAmountTooltip", typeof(Cf.Data.Resources.ReportLoansBetweenTwoDatesResult))]
        public Nullable<decimal> ProfitAmount {get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region ReportPaymentsBetweenTwoDates filter and result classes
	#region ReportPaymentsBetweenTwoDatesFilter meta data class definition
    /// <summary>
    /// Metadata for ReportPaymentsBetweenTwoDatesFilter class
    /// </summary>
	public partial class ReportPaymentsBetweenTwoDatesFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for ReportPaymentsBetweenTwoDatesFilter.FirstMonth property
        /// </summary>
		[Display(
			Name = "FirstMonth",
			ResourceType = typeof(Cf.Data.Resources.ReportPaymentsBetweenTwoDatesFilter))
		]
		[Tooltip("FirstMonthTooltip", typeof(Cf.Data.Resources.ReportPaymentsBetweenTwoDatesFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> FirstMonth { get; set; }
		
        /// <summary>
        /// Metadata for ReportPaymentsBetweenTwoDatesFilter.SecondMonth property
        /// </summary>
		[Display(
			Name = "SecondMonth",
			ResourceType = typeof(Cf.Data.Resources.ReportPaymentsBetweenTwoDatesFilter))
		]
		[Tooltip("SecondMonthTooltip", typeof(Cf.Data.Resources.ReportPaymentsBetweenTwoDatesFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> SecondMonth { get; set; }
		
        /// <summary>
        /// Metadata for ReportPaymentsBetweenTwoDatesFilter.Limit property
        /// </summary>
		[Display(
			Name = "Limit",
			ResourceType = typeof(Cf.Data.Resources.ReportPaymentsBetweenTwoDatesFilter))
		]
		[Tooltip("LimitTooltip", typeof(Cf.Data.Resources.ReportPaymentsBetweenTwoDatesFilter))]
        public Nullable<double> Limit { get; set; }
		
        /// <summary>
        /// Metadata for ReportPaymentsBetweenTwoDatesFilter.PaymentDiff property
        /// </summary>
		[Display(
			Name = "PaymentDiff",
			ResourceType = typeof(Cf.Data.Resources.ReportPaymentsBetweenTwoDatesFilter))
		]
		[Tooltip("PaymentDiffTooltip", typeof(Cf.Data.Resources.ReportPaymentsBetweenTwoDatesFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> PaymentDiff { get; set; }
		#endregion
	}
	#endregion

    #region ReportPaymentsBetweenTwoDatesResultMetaData class definition
	/// <summary>
    /// Result class for ReportPaymentsBetweenTwoDates.
	/// </summary>
	public partial class ReportPaymentsBetweenTwoDatesResultMetaData
	{
		#region Public properties
		[Display(
			Name = "FirstEmployeeId",
			ResourceType = typeof(Cf.Data.Resources.ReportPaymentsBetweenTwoDatesResult))
		]
		[Tooltip("FirstEmployeeIdTooltip", typeof(Cf.Data.Resources.ReportPaymentsBetweenTwoDatesResult))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> FirstEmployeeId {get; set; }
		
		[Display(
			Name = "FirstEmployeeFullName",
			ResourceType = typeof(Cf.Data.Resources.ReportPaymentsBetweenTwoDatesResult))
		]
		[Tooltip("FirstEmployeeFullNameTooltip", typeof(Cf.Data.Resources.ReportPaymentsBetweenTwoDatesResult))]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string FirstEmployeeFullName {get; set; }
		
		[Display(
			Name = "FirstSalaryWorkPlaceName",
			ResourceType = typeof(Cf.Data.Resources.ReportPaymentsBetweenTwoDatesResult))
		]
		[Tooltip("FirstSalaryWorkPlaceNameTooltip", typeof(Cf.Data.Resources.ReportPaymentsBetweenTwoDatesResult))]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string FirstSalaryWorkPlaceName {get; set; }
		
		[Display(
			Name = "FirstAmount",
			ResourceType = typeof(Cf.Data.Resources.ReportPaymentsBetweenTwoDatesResult))
		]
		[Tooltip("FirstAmountTooltip", typeof(Cf.Data.Resources.ReportPaymentsBetweenTwoDatesResult))]
        public Nullable<decimal> FirstAmount {get; set; }
		
		[Display(
			Name = "FirstDate",
			ResourceType = typeof(Cf.Data.Resources.ReportPaymentsBetweenTwoDatesResult))
		]
		[Tooltip("FirstDateTooltip", typeof(Cf.Data.Resources.ReportPaymentsBetweenTwoDatesResult))]
		[StringLength(
			38,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string FirstDate {get; set; }
		
		[Display(
			Name = "FirstPaymentGroupId",
			ResourceType = typeof(Cf.Data.Resources.ReportPaymentsBetweenTwoDatesResult))
		]
		[Tooltip("FirstPaymentGroupIdTooltip", typeof(Cf.Data.Resources.ReportPaymentsBetweenTwoDatesResult))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<byte> FirstPaymentGroupId {get; set; }
		
		[Display(
			Name = "FirstPaymentGroupName",
			ResourceType = typeof(Cf.Data.Resources.ReportPaymentsBetweenTwoDatesResult))
		]
		[Tooltip("FirstPaymentGroupNameTooltip", typeof(Cf.Data.Resources.ReportPaymentsBetweenTwoDatesResult))]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string FirstPaymentGroupName {get; set; }
		
		[Display(
			Name = "SecondEmployeeId",
			ResourceType = typeof(Cf.Data.Resources.ReportPaymentsBetweenTwoDatesResult))
		]
		[Tooltip("SecondEmployeeIdTooltip", typeof(Cf.Data.Resources.ReportPaymentsBetweenTwoDatesResult))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> SecondEmployeeId {get; set; }
		
		[Display(
			Name = "SecondEmployeeFullName",
			ResourceType = typeof(Cf.Data.Resources.ReportPaymentsBetweenTwoDatesResult))
		]
		[Tooltip("SecondEmployeeFullNameTooltip", typeof(Cf.Data.Resources.ReportPaymentsBetweenTwoDatesResult))]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string SecondEmployeeFullName {get; set; }
		
		[Display(
			Name = "SecondSalaryWorkPlaceName",
			ResourceType = typeof(Cf.Data.Resources.ReportPaymentsBetweenTwoDatesResult))
		]
		[Tooltip("SecondSalaryWorkPlaceNameTooltip", typeof(Cf.Data.Resources.ReportPaymentsBetweenTwoDatesResult))]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string SecondSalaryWorkPlaceName {get; set; }
		
		[Display(
			Name = "SecondAmount",
			ResourceType = typeof(Cf.Data.Resources.ReportPaymentsBetweenTwoDatesResult))
		]
		[Tooltip("SecondAmountTooltip", typeof(Cf.Data.Resources.ReportPaymentsBetweenTwoDatesResult))]
        public Nullable<decimal> SecondAmount {get; set; }
		
		[Display(
			Name = "SecondDate",
			ResourceType = typeof(Cf.Data.Resources.ReportPaymentsBetweenTwoDatesResult))
		]
		[Tooltip("SecondDateTooltip", typeof(Cf.Data.Resources.ReportPaymentsBetweenTwoDatesResult))]
		[StringLength(
			38,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string SecondDate {get; set; }
		
		[Display(
			Name = "SecondPaymentGroupId",
			ResourceType = typeof(Cf.Data.Resources.ReportPaymentsBetweenTwoDatesResult))
		]
		[Tooltip("SecondPaymentGroupIdTooltip", typeof(Cf.Data.Resources.ReportPaymentsBetweenTwoDatesResult))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<byte> SecondPaymentGroupId {get; set; }
		
		[Display(
			Name = "SecondPaymentGroupName",
			ResourceType = typeof(Cf.Data.Resources.ReportPaymentsBetweenTwoDatesResult))
		]
		[Tooltip("SecondPaymentGroupNameTooltip", typeof(Cf.Data.Resources.ReportPaymentsBetweenTwoDatesResult))]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string SecondPaymentGroupName {get; set; }
		
		[Display(
			Name = "PaymentDiffrence",
			ResourceType = typeof(Cf.Data.Resources.ReportPaymentsBetweenTwoDatesResult))
		]
		[Tooltip("PaymentDiffrenceTooltip", typeof(Cf.Data.Resources.ReportPaymentsBetweenTwoDatesResult))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> PaymentDiffrence {get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region ReportSubscriptionsBetweenTwoDates filter and result classes
	#region ReportSubscriptionsBetweenTwoDatesFilter meta data class definition
    /// <summary>
    /// Metadata for ReportSubscriptionsBetweenTwoDatesFilter class
    /// </summary>
	public partial class ReportSubscriptionsBetweenTwoDatesFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for ReportSubscriptionsBetweenTwoDatesFilter.FirstMonth property
        /// </summary>
		[Display(
			Name = "FirstMonth",
			ResourceType = typeof(Cf.Data.Resources.ReportSubscriptionsBetweenTwoDatesFilter))
		]
		[Tooltip("FirstMonthTooltip", typeof(Cf.Data.Resources.ReportSubscriptionsBetweenTwoDatesFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> FirstMonth { get; set; }
		
        /// <summary>
        /// Metadata for ReportSubscriptionsBetweenTwoDatesFilter.SecondMonth property
        /// </summary>
		[Display(
			Name = "SecondMonth",
			ResourceType = typeof(Cf.Data.Resources.ReportSubscriptionsBetweenTwoDatesFilter))
		]
		[Tooltip("SecondMonthTooltip", typeof(Cf.Data.Resources.ReportSubscriptionsBetweenTwoDatesFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> SecondMonth { get; set; }
		
        /// <summary>
        /// Metadata for ReportSubscriptionsBetweenTwoDatesFilter.Limit property
        /// </summary>
		[Display(
			Name = "Limit",
			ResourceType = typeof(Cf.Data.Resources.ReportSubscriptionsBetweenTwoDatesFilter))
		]
		[Tooltip("LimitTooltip", typeof(Cf.Data.Resources.ReportSubscriptionsBetweenTwoDatesFilter))]
        public Nullable<double> Limit { get; set; }
		
        /// <summary>
        /// Metadata for ReportSubscriptionsBetweenTwoDatesFilter.SubscriptionDiff property
        /// </summary>
		[Display(
			Name = "SubscriptionDiff",
			ResourceType = typeof(Cf.Data.Resources.ReportSubscriptionsBetweenTwoDatesFilter))
		]
		[Tooltip("SubscriptionDiffTooltip", typeof(Cf.Data.Resources.ReportSubscriptionsBetweenTwoDatesFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> SubscriptionDiff { get; set; }
		#endregion
	}
	#endregion

    #region ReportSubscriptionsBetweenTwoDatesResultMetaData class definition
	/// <summary>
    /// Result class for ReportSubscriptionsBetweenTwoDates.
	/// </summary>
	public partial class ReportSubscriptionsBetweenTwoDatesResultMetaData
	{
		#region Public properties
		[Display(
			Name = "FirstEmployeeId",
			ResourceType = typeof(Cf.Data.Resources.ReportSubscriptionsBetweenTwoDatesResult))
		]
		[Tooltip("FirstEmployeeIdTooltip", typeof(Cf.Data.Resources.ReportSubscriptionsBetweenTwoDatesResult))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> FirstEmployeeId {get; set; }
		
		[Display(
			Name = "FirstEmployeeFullName",
			ResourceType = typeof(Cf.Data.Resources.ReportSubscriptionsBetweenTwoDatesResult))
		]
		[Tooltip("FirstEmployeeFullNameTooltip", typeof(Cf.Data.Resources.ReportSubscriptionsBetweenTwoDatesResult))]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string FirstEmployeeFullName {get; set; }
		
		[Display(
			Name = "FirstSalaryWorkPlaceName",
			ResourceType = typeof(Cf.Data.Resources.ReportSubscriptionsBetweenTwoDatesResult))
		]
		[Tooltip("FirstSalaryWorkPlaceNameTooltip", typeof(Cf.Data.Resources.ReportSubscriptionsBetweenTwoDatesResult))]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string FirstSalaryWorkPlaceName {get; set; }
		
		[Display(
			Name = "FirstAmount",
			ResourceType = typeof(Cf.Data.Resources.ReportSubscriptionsBetweenTwoDatesResult))
		]
		[Tooltip("FirstAmountTooltip", typeof(Cf.Data.Resources.ReportSubscriptionsBetweenTwoDatesResult))]
        public Nullable<decimal> FirstAmount {get; set; }
		
		[Display(
			Name = "FirstMonth",
			ResourceType = typeof(Cf.Data.Resources.ReportSubscriptionsBetweenTwoDatesResult))
		]
		[Tooltip("FirstMonthTooltip", typeof(Cf.Data.Resources.ReportSubscriptionsBetweenTwoDatesResult))]
		[StringLength(
			38,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string FirstMonth {get; set; }
		
		[Display(
			Name = "SecondEmployeeId",
			ResourceType = typeof(Cf.Data.Resources.ReportSubscriptionsBetweenTwoDatesResult))
		]
		[Tooltip("SecondEmployeeIdTooltip", typeof(Cf.Data.Resources.ReportSubscriptionsBetweenTwoDatesResult))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> SecondEmployeeId {get; set; }
		
		[Display(
			Name = "SecondEmployeeFullName",
			ResourceType = typeof(Cf.Data.Resources.ReportSubscriptionsBetweenTwoDatesResult))
		]
		[Tooltip("SecondEmployeeFullNameTooltip", typeof(Cf.Data.Resources.ReportSubscriptionsBetweenTwoDatesResult))]
		[StringLength(
			101,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string SecondEmployeeFullName {get; set; }
		
		[Display(
			Name = "SecondSalaryWorkPlaceName",
			ResourceType = typeof(Cf.Data.Resources.ReportSubscriptionsBetweenTwoDatesResult))
		]
		[Tooltip("SecondSalaryWorkPlaceNameTooltip", typeof(Cf.Data.Resources.ReportSubscriptionsBetweenTwoDatesResult))]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string SecondSalaryWorkPlaceName {get; set; }
		
		[Display(
			Name = "SecondAmount",
			ResourceType = typeof(Cf.Data.Resources.ReportSubscriptionsBetweenTwoDatesResult))
		]
		[Tooltip("SecondAmountTooltip", typeof(Cf.Data.Resources.ReportSubscriptionsBetweenTwoDatesResult))]
        public Nullable<decimal> SecondAmount {get; set; }
		
		[Display(
			Name = "SecondMonth",
			ResourceType = typeof(Cf.Data.Resources.ReportSubscriptionsBetweenTwoDatesResult))
		]
		[Tooltip("SecondMonthTooltip", typeof(Cf.Data.Resources.ReportSubscriptionsBetweenTwoDatesResult))]
		[StringLength(
			38,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string SecondMonth {get; set; }
		
		[Display(
			Name = "SubscriptionDiffrence",
			ResourceType = typeof(Cf.Data.Resources.ReportSubscriptionsBetweenTwoDatesResult))
		]
		[Tooltip("SubscriptionDiffrenceTooltip", typeof(Cf.Data.Resources.ReportSubscriptionsBetweenTwoDatesResult))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> SubscriptionDiffrence {get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region RequestStatistics filter and result classes
	#region RequestStatisticsFilter meta data class definition
    /// <summary>
    /// Metadata for RequestStatisticsFilter class
    /// </summary>
	public partial class RequestStatisticsFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for RequestStatisticsFilter.MinDate property
        /// </summary>
		[Display(
			Name = "MinDate",
			ResourceType = typeof(Cf.Data.Resources.RequestStatisticsFilter))
		]
		[Tooltip("MinDateTooltip", typeof(Cf.Data.Resources.RequestStatisticsFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> MinDate { get; set; }
		
        /// <summary>
        /// Metadata for RequestStatisticsFilter.MaxDate property
        /// </summary>
		[Display(
			Name = "MaxDate",
			ResourceType = typeof(Cf.Data.Resources.RequestStatisticsFilter))
		]
		[Tooltip("MaxDateTooltip", typeof(Cf.Data.Resources.RequestStatisticsFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> MaxDate { get; set; }
		#endregion
	}
	#endregion

    #region RequestStatisticsResultMetaData class definition
	/// <summary>
    /// Result class for RequestStatistics.
	/// </summary>
	public partial class RequestStatisticsResultMetaData
	{
		#region Public properties
		[Display(
			Name = "RequestStatusId",
			ResourceType = typeof(Cf.Data.Resources.RequestStatisticsResult))
		]
		[Tooltip("RequestStatusIdTooltip", typeof(Cf.Data.Resources.RequestStatisticsResult))]
		[Range(
			0,
			127,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<byte> RequestStatusId {get; set; }
		
		[Display(
			Name = "RequestStatusName",
			ResourceType = typeof(Cf.Data.Resources.RequestStatisticsResult))
		]
		[Tooltip("RequestStatusNameTooltip", typeof(Cf.Data.Resources.RequestStatisticsResult))]
		[StringLength(
			50,
			MinimumLength = 0,
			ErrorMessageResourceName = "StringLengthCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public string RequestStatusName {get; set; }
		
		[Display(
			Name = "RequestCount",
			ResourceType = typeof(Cf.Data.Resources.RequestStatisticsResult))
		]
		[Tooltip("RequestCountTooltip", typeof(Cf.Data.Resources.RequestStatisticsResult))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> RequestCount {get; set; }
		
		[Display(
			Name = "RequestSum",
			ResourceType = typeof(Cf.Data.Resources.RequestStatisticsResult))
		]
		[Tooltip("RequestSumTooltip", typeof(Cf.Data.Resources.RequestStatisticsResult))]
        public Nullable<decimal> RequestSum {get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region SubscriptionsBetweenTwoDates filter and result classes
	#region SubscriptionsBetweenTwoDatesFilter meta data class definition
    /// <summary>
    /// Metadata for SubscriptionsBetweenTwoDatesFilter class
    /// </summary>
	public partial class SubscriptionsBetweenTwoDatesFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for SubscriptionsBetweenTwoDatesFilter.MinDate property
        /// </summary>
		[Display(
			Name = "MinDate",
			ResourceType = typeof(Cf.Data.Resources.SubscriptionsBetweenTwoDatesFilter))
		]
		[Tooltip("MinDateTooltip", typeof(Cf.Data.Resources.SubscriptionsBetweenTwoDatesFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> MinDate { get; set; }
		
        /// <summary>
        /// Metadata for SubscriptionsBetweenTwoDatesFilter.MaxDate property
        /// </summary>
		[Display(
			Name = "MaxDate",
			ResourceType = typeof(Cf.Data.Resources.SubscriptionsBetweenTwoDatesFilter))
		]
		[Tooltip("MaxDateTooltip", typeof(Cf.Data.Resources.SubscriptionsBetweenTwoDatesFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> MaxDate { get; set; }
		#endregion
	}
	#endregion

    #region SubscriptionsBetweenTwoDatesResultMetaData class definition
	/// <summary>
    /// Result class for SubscriptionsBetweenTwoDates.
	/// </summary>
	public partial class SubscriptionsBetweenTwoDatesResultMetaData
	{
		#region Public properties
		[Display(
			Name = "FirstMonthAmount",
			ResourceType = typeof(Cf.Data.Resources.SubscriptionsBetweenTwoDatesResult))
		]
		[Tooltip("FirstMonthAmountTooltip", typeof(Cf.Data.Resources.SubscriptionsBetweenTwoDatesResult))]
        public Nullable<decimal> FirstMonthAmount {get; set; }
		
		[Display(
			Name = "SecondMonthAmount",
			ResourceType = typeof(Cf.Data.Resources.SubscriptionsBetweenTwoDatesResult))
		]
		[Tooltip("SecondMonthAmountTooltip", typeof(Cf.Data.Resources.SubscriptionsBetweenTwoDatesResult))]
        public Nullable<decimal> SecondMonthAmount {get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region SumComingLoansForEmployee filter and result classes
	#region SumComingLoansForEmployeeFilter meta data class definition
    /// <summary>
    /// Metadata for SumComingLoansForEmployeeFilter class
    /// </summary>
	public partial class SumComingLoansForEmployeeFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for SumComingLoansForEmployeeFilter.FromDate property
        /// </summary>
		[Display(
			Name = "FromDate",
			ResourceType = typeof(Cf.Data.Resources.SumComingLoansForEmployeeFilter))
		]
		[Tooltip("FromDateTooltip", typeof(Cf.Data.Resources.SumComingLoansForEmployeeFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> FromDate { get; set; }
		
        /// <summary>
        /// Metadata for SumComingLoansForEmployeeFilter.ToDate property
        /// </summary>
		[Display(
			Name = "ToDate",
			ResourceType = typeof(Cf.Data.Resources.SumComingLoansForEmployeeFilter))
		]
		[Tooltip("ToDateTooltip", typeof(Cf.Data.Resources.SumComingLoansForEmployeeFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> ToDate { get; set; }
		
        /// <summary>
        /// Metadata for SumComingLoansForEmployeeFilter.Employee property
        /// </summary>
		[Display(
			Name = "Employee",
			ResourceType = typeof(Cf.Data.Resources.SumComingLoansForEmployeeFilter))
		]
		[Tooltip("EmployeeTooltip", typeof(Cf.Data.Resources.SumComingLoansForEmployeeFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> Employee { get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region SumLoansForEmployee filter and result classes
	#region SumLoansForEmployeeFilter meta data class definition
    /// <summary>
    /// Metadata for SumLoansForEmployeeFilter class
    /// </summary>
	public partial class SumLoansForEmployeeFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for SumLoansForEmployeeFilter.FromDate property
        /// </summary>
		[Display(
			Name = "FromDate",
			ResourceType = typeof(Cf.Data.Resources.SumLoansForEmployeeFilter))
		]
		[Tooltip("FromDateTooltip", typeof(Cf.Data.Resources.SumLoansForEmployeeFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> FromDate { get; set; }
		
        /// <summary>
        /// Metadata for SumLoansForEmployeeFilter.ToDate property
        /// </summary>
		[Display(
			Name = "ToDate",
			ResourceType = typeof(Cf.Data.Resources.SumLoansForEmployeeFilter))
		]
		[Tooltip("ToDateTooltip", typeof(Cf.Data.Resources.SumLoansForEmployeeFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> ToDate { get; set; }
		
        /// <summary>
        /// Metadata for SumLoansForEmployeeFilter.Employee property
        /// </summary>
		[Display(
			Name = "Employee",
			ResourceType = typeof(Cf.Data.Resources.SumLoansForEmployeeFilter))
		]
		[Tooltip("EmployeeTooltip", typeof(Cf.Data.Resources.SumLoansForEmployeeFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> Employee { get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region SumOutgoingLoansForEmployee filter and result classes
	#region SumOutgoingLoansForEmployeeFilter meta data class definition
    /// <summary>
    /// Metadata for SumOutgoingLoansForEmployeeFilter class
    /// </summary>
	public partial class SumOutgoingLoansForEmployeeFilterMetaData
	{
		#region Public properties
        /// <summary>
        /// Metadata for SumOutgoingLoansForEmployeeFilter.FromDate property
        /// </summary>
		[Display(
			Name = "FromDate",
			ResourceType = typeof(Cf.Data.Resources.SumOutgoingLoansForEmployeeFilter))
		]
		[Tooltip("FromDateTooltip", typeof(Cf.Data.Resources.SumOutgoingLoansForEmployeeFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> FromDate { get; set; }
		
        /// <summary>
        /// Metadata for SumOutgoingLoansForEmployeeFilter.ToDate property
        /// </summary>
		[Display(
			Name = "ToDate",
			ResourceType = typeof(Cf.Data.Resources.SumOutgoingLoansForEmployeeFilter))
		]
		[Tooltip("ToDateTooltip", typeof(Cf.Data.Resources.SumOutgoingLoansForEmployeeFilter))]
		[DataType(
			DataType.Date,
			ErrorMessageResourceName = "DateCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<DateTime> ToDate { get; set; }
		
        /// <summary>
        /// Metadata for SumOutgoingLoansForEmployeeFilter.Employee property
        /// </summary>
		[Display(
			Name = "Employee",
			ResourceType = typeof(Cf.Data.Resources.SumOutgoingLoansForEmployeeFilter))
		]
		[Tooltip("EmployeeTooltip", typeof(Cf.Data.Resources.SumOutgoingLoansForEmployeeFilter))]
		[Range(
			0,
			2147483647,
			ErrorMessageResourceName = "RangeCheck",
			ErrorMessageResourceType = typeof(Cf.Data.Resources.CommonResources))
		]
        public Nullable<int> Employee { get; set; }
		#endregion
	}
	#endregion
	#endregion
}
