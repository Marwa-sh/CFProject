using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel.DataAnnotations;

namespace Cf.Data
{
	#region EmployeeCustom filter and result classes
    #region EmployeeCustomFilter class definition
	/// <summary>
    /// Filter class for EmployeeCustom.
	/// </summary>
    [MetadataType(typeof(EmployeeCustomFilterMetaData))]
	public partial class EmployeeCustomFilter
	{
		#region Public properties
		#endregion
	}
	#endregion

    #region EmployeeCustom result class
    public partial class EmployeeCustomResult
    {
        internal EmployeeCustomResult
        (
            List<EmployeeCustomResult1> result1,
            List<EmployeeCustomResult2> result2
        )
        {
            this.Result1 = result1;
            this.Result2 = result2;
        }
        public List<EmployeeCustomResult1> Result1 {get; private set; }
        public List<EmployeeCustomResult2> Result2 {get; private set; }
    }
    #endregion

    #region EmployeeCustomResult1 class definition
	/// <summary>
    /// Result class for EmployeeCustom.
	/// </summary>
    [MetadataType(typeof(EmployeeCustomResult1MetaData))]
	public partial class EmployeeCustomResult1
	{
		#region Public properties
        public int Id {get; set; }
		
        public string FirstName {get; set; }
		
        public string LastName {get; set; }
		
        public string FatherName {get; set; }
		
        public string MotherName {get; set; }
		
        public Nullable<DateTime> BirthDate {get; set; }
		
        public Nullable<DateTime> ExpectedEndDate {get; set; }
		
        public Nullable<DateTime> CersStartDate {get; set; }
		
        public Nullable<DateTime> CfStartDate {get; set; }
		
        public Nullable<DateTime> LeaveDate {get; set; }
		
        public string LeaveReason {get; set; }
		
        public byte EmployeeStatus {get; set; }
		
        public int Department {get; set; }
		
        public string Notes {get; set; }
		
        public byte Category {get; set; }
		#endregion
	}
	#endregion

    #region EmployeeCustomResult2 class definition
	/// <summary>
    /// Result class for EmployeeCustom.
	/// </summary>
    [MetadataType(typeof(EmployeeCustomResult2MetaData))]
	public partial class EmployeeCustomResult2
	{
		#region Public properties
        public int Product {get; set; }
		
        public int LoanDecision {get; set; }
		
        public short LoanType {get; set; }
		
        public byte LoanGenerationStatus {get; set; }
		
        public byte LoanStatus {get; set; }
		#endregion
	}
	#endregion
    #endregion

	#region EmployeeProductCalculator filter and result classes
    #region EmployeeProductCalculatorFilter class definition
	/// <summary>
    /// Filter class for EmployeeProductCalculator.
	/// </summary>
    [MetadataType(typeof(EmployeeProductCalculatorFilterMetaData))]
	public partial class EmployeeProductCalculatorFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<int> EmployeeId {get; set; }
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<short> ProductTypeId {get; set; }
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<decimal> Amount {get; set; }
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<short> Period {get; set; }
		#endregion
	}
	#endregion

    #region EmployeeProductCalculatorResult class definition
	/// <summary>
    /// Result class for EmployeeProductCalculator.
	/// </summary>
    [MetadataType(typeof(EmployeeProductCalculatorResultMetaData))]
	public partial class EmployeeProductCalculatorResult
	{
		#region Public properties
        public Nullable<int> EmployeeId {get; set; }
		
        public string FullName {get; set; }
		
        public Nullable<DateTime> CersStartDate {get; set; }
		
        public Nullable<DateTime> CfStartDate {get; set; }
		
        public Nullable<DateTime> LeaveDate {get; set; }
		
        public string LeaveReason {get; set; }
		
        public int DepartmentId {get; set; }
		
        public string DepartmentName {get; set; }
		
        public int DepartmentSalaryWorkPlaceId {get; set; }
		
        public string DepartmentSalaryWorkPlaceName {get; set; }
		
        public byte EmployeeStatusId {get; set; }
		
        public string EmployeeStatusName {get; set; }
		
        public byte CategoryId {get; set; }
		
        public string CategoryName {get; set; }
		
        public Nullable<decimal> MaxAmount {get; set; }
		
        public Nullable<short> Seniority {get; set; }
		
        public Nullable<byte> MinSeniority {get; set; }
		
        public Nullable<byte> MinReusePeriod {get; set; }
		
        public Nullable<short> ProductTypeId {get; set; }
		
        public Nullable<decimal> Amount {get; set; }
		
        public Nullable<decimal> NetAmount {get; set; }
		
        public Nullable<decimal> ProfitAmount {get; set; }
		
        public Nullable<decimal> Installment {get; set; }
		
        public Nullable<double> Rate {get; set; }
		
        public Nullable<byte> GuarantorsCount {get; set; }
		#endregion
	}
	#endregion
    #endregion

	#region GetAvailabilityCeilingByProductTypeId_EmployeeId filter and result classes
    #region GetAvailabilityCeilingByProductTypeId_EmployeeIdFilter class definition
	/// <summary>
    /// Filter class for GetAvailabilityCeilingByProductTypeId_EmployeeId.
	/// </summary>
    [MetadataType(typeof(GetAvailabilityCeilingByProductTypeId_EmployeeIdFilterMetaData))]
	public partial class GetAvailabilityCeilingByProductTypeId_EmployeeIdFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<short> ProductTypeId {get; set; }
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<int> EmployeeId {get; set; }
		#endregion
	}
	#endregion

    #region GetAvailabilityCeilingByProductTypeId_EmployeeIdResult class definition
	/// <summary>
    /// Result class for GetAvailabilityCeilingByProductTypeId_EmployeeId.
	/// </summary>
    [MetadataType(typeof(GetAvailabilityCeilingByProductTypeId_EmployeeIdResultMetaData))]
	public partial class GetAvailabilityCeilingByProductTypeId_EmployeeIdResult
	{
		#region Public properties
        public Nullable<int> EmployeeId {get; set; }
		
        public Nullable<short> ProductTypeId {get; set; }
		
        public Nullable<short> Seniority {get; set; }
		
        public Nullable<byte> MinSeniority {get; set; }
		
        public Nullable<byte> MinReusePeriod {get; set; }
		
        public Nullable<decimal> MaxAmount {get; set; }
		#endregion
	}
	#endregion
    #endregion

	#region GetDueProfit filter and result classes
    #region GetDueProfitFilter class definition
	/// <summary>
    /// Filter class for GetDueProfit.
	/// </summary>
    [MetadataType(typeof(GetDueProfitFilterMetaData))]
	public partial class GetDueProfitFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<decimal> Amount {get; set; }
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<short> Period {get; set; }
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<double> Rate {get; set; }
		#endregion
	}
	#endregion

    #region GetDueProfit result class
    public partial class GetDueProfitResult
    {
        internal GetDueProfitResult
        (
        )
        {
        }
    }
    #endregion
    #endregion

	#region GetFinancialRatio filter and result classes
    #region GetFinancialRatioFilter class definition
	/// <summary>
    /// Filter class for GetFinancialRatio.
	/// </summary>
    [MetadataType(typeof(GetFinancialRatioFilterMetaData))]
	public partial class GetFinancialRatioFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<short> Period {get; set; }
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<double> Rate {get; set; }
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<bool> Type {get; set; }
		#endregion
	}
	#endregion

    #region GetFinancialRatio result class
    public partial class GetFinancialRatioResult
    {
        internal GetFinancialRatioResult
        (
        )
        {
        }
    }
    #endregion
    #endregion

	#region GetInstallment filter and result classes
    #region GetInstallmentFilter class definition
	/// <summary>
    /// Filter class for GetInstallment.
	/// </summary>
    [MetadataType(typeof(GetInstallmentFilterMetaData))]
	public partial class GetInstallmentFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<decimal> Amount {get; set; }
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<short> Period {get; set; }
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<double> Rate {get; set; }
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<bool> Type {get; set; }
		#endregion
	}
	#endregion

    #region GetInstallment result class
    public partial class GetInstallmentResult
    {
        internal GetInstallmentResult
        (
        )
        {
        }
    }
    #endregion
    #endregion

	#region GetInstallmentPaidAmounts filter and result classes
    #region GetInstallmentPaidAmountsFilter class definition
	/// <summary>
    /// Filter class for GetInstallmentPaidAmounts.
	/// </summary>
    [MetadataType(typeof(GetInstallmentPaidAmountsFilterMetaData))]
	public partial class GetInstallmentPaidAmountsFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<int> RefundableProductId {get; set; }
		#endregion
	}
	#endregion

    #region GetInstallmentPaidAmountsResult class definition
	/// <summary>
    /// Result class for GetInstallmentPaidAmounts.
	/// </summary>
    [MetadataType(typeof(GetInstallmentPaidAmountsResultMetaData))]
	public partial class GetInstallmentPaidAmountsResult
	{
		#region Public properties
        public int InstallmentId {get; set; }
		
        public decimal PaidAmount {get; set; }
		#endregion
	}
	#endregion
    #endregion

	#region GetInstallments filter and result classes
    #region GetInstallmentsFilter class definition
	/// <summary>
    /// Filter class for GetInstallments.
	/// </summary>
    [MetadataType(typeof(GetInstallmentsFilterMetaData))]
	public partial class GetInstallmentsFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<int> RefundableProductId {get; set; }
		#endregion
	}
	#endregion

    #region GetInstallmentsResult class definition
	/// <summary>
    /// Result class for GetInstallments.
	/// </summary>
    [MetadataType(typeof(GetInstallmentsResultMetaData))]
	public partial class GetInstallmentsResult
	{
		#region Public properties
        public int Id {get; set; }
		
        public int RefundableProduct {get; set; }
		
        public short SubNumber {get; set; }
		
        public DateTime DueDate {get; set; }
		
        public decimal DueCapital {get; set; }
		
        public decimal DueProfit {get; set; }
		
        public decimal PaidAmount {get; set; }
		
        public int PaymentStatus {get; set; }
		#endregion
	}
	#endregion
    #endregion

	#region GetPresentValue filter and result classes
    #region GetPresentValueFilter class definition
	/// <summary>
    /// Filter class for GetPresentValue.
	/// </summary>
    [MetadataType(typeof(GetPresentValueFilterMetaData))]
	public partial class GetPresentValueFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<decimal> Installment {get; set; }
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<short> Period {get; set; }
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<double> Rate {get; set; }
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<bool> Type {get; set; }
		#endregion
	}
	#endregion

    #region GetPresentValue result class
    public partial class GetPresentValueResult
    {
        internal GetPresentValueResult
        (
        )
        {
        }
    }
    #endregion
    #endregion

	#region GetRefundableProducts filter and result classes
    #region GetRefundableProductsFilter class definition
	/// <summary>
    /// Filter class for GetRefundableProducts.
	/// </summary>
    [MetadataType(typeof(GetRefundableProductsFilterMetaData))]
	public partial class GetRefundableProductsFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<int> EmployeeId {get; set; }
		#endregion
	}
	#endregion

    #region GetRefundableProductsResult class definition
	/// <summary>
    /// Result class for GetRefundableProducts.
	/// </summary>
    [MetadataType(typeof(GetRefundableProductsResultMetaData))]
	public partial class GetRefundableProductsResult
	{
		#region Public properties
        public int ProductId {get; set; }
		
        public int ProductEmployeeId {get; set; }
		
        public decimal Installment {get; set; }
		
        public decimal NetAmount {get; set; }
		
        public decimal ProfitAmount {get; set; }
		
        public short PaymentPeriod {get; set; }
		
        public Nullable<decimal> DueAmount {get; set; }
		
        public Nullable<decimal> PaidAmount {get; set; }
		#endregion
	}
	#endregion
    #endregion

	#region LoanGenerate filter and result classes
    #region LoanGenerateFilter class definition
	/// <summary>
    /// Filter class for LoanGenerate.
	/// </summary>
    [MetadataType(typeof(LoanGenerateFilterMetaData))]
	public partial class LoanGenerateFilter
	{
		#region Public properties
		/// <summary>
		/// معرف المنتج
		/// </summary>
		public Nullable<int> ProductId {get; set; }
		
		/// <summary>
		/// معرف قرار السلف
		/// </summary>
		public Nullable<int> LoanDecisionId {get; set; }
		/// <summary>
		/// معرف حالة توليد البطاقة
		/// </summary>
		public Nullable<byte> LoanGenerationStatusId {get; set; }
		#endregion
	}
	#endregion

    #region LoanGenerate result class
    public partial class LoanGenerateResult
    {
        internal LoanGenerateResult
        (
        )
        {
        }
    }
    #endregion
    #endregion

	#region ProductCalculator filter and result classes
    #region ProductCalculatorFilter class definition
	/// <summary>
    /// Filter class for ProductCalculator.
	/// </summary>
    [MetadataType(typeof(ProductCalculatorFilterMetaData))]
	public partial class ProductCalculatorFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<short> ProductType {get; set; }
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<decimal> Amount {get; set; }
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<short> Period {get; set; }
		#endregion
	}
	#endregion

    #region ProductCalculatorResult class definition
	/// <summary>
    /// Result class for ProductCalculator.
	/// </summary>
    [MetadataType(typeof(ProductCalculatorResultMetaData))]
	public partial class ProductCalculatorResult
	{
		#region Public properties
        public Nullable<short> ProductTypeId {get; set; }
		
        public Nullable<decimal> Amount {get; set; }
		
        public Nullable<decimal> NetAmount {get; set; }
		
        public Nullable<decimal> ProfitAmount {get; set; }
		
        public Nullable<decimal> Installment {get; set; }
		
        public Nullable<double> Rate {get; set; }
		
        public Nullable<byte> GuarantorsCount {get; set; }
		#endregion
	}
	#endregion
    #endregion
}
