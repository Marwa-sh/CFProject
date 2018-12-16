using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel.DataAnnotations;

namespace Cf.Data
{
	#region EmployeeLoans filter and result classes
    #region EmployeeLoansFilter class definition
	/// <summary>
    /// Filter class for EmployeeLoans.
	/// </summary>
    [MetadataType(typeof(EmployeeLoansFilterMetaData))]
	public partial class EmployeeLoansFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<int> EmployeeId {get; set; }
        /// <summary>
        /// Needs summary!
        /// </summary>
        public Nullable<int> LoanStatusId { get; set; }
        #endregion
    }
	#endregion

	#region EmployeeLoansResult class definition
	/// <summary>
    /// Result class for EmployeeLoans.
	/// </summary>
    [MetadataType(typeof(EmployeeLoansResultMetaData))]
	public partial class EmployeeLoansResult
	{
		#region Public properties
        public int ProductEmployeeId {get; set; }
		
        public string ProductEmployeeFullName {get; set; }
		
        public short ProductProductTypeId {get; set; }
		
        public string ProductProductTypeName {get; set; }
        public decimal ProductAmount { get; set; }
        public int ProductId {get; set; }        

        public decimal PaidAmount {get; set; }
		
        public short PaymentPeriod {get; set; }
		
        public int RemainPeriod {get; set; }
		#endregion
	}
    #endregion
    #endregion

    #region LoanMoveFromEmployeeToEmployee filter and result classes
    #region LoanMoveFromEmployeeToEmployeeFilter class definition
    /// <summary>
    /// Filter class for LoanMoveFromEmployeeToEmployee.
    /// </summary>
    public partial class LoanMoveFromEmployeeToEmployeeFilter
    {
        #region Public properties
        /// <summary>
        /// Needs summary!
        /// </summary>
        public Nullable<int> Loan { get; set; }

        /// <summary>
        /// Needs summary!
        /// </summary>
        public Nullable<int> EmployeeId { get; set; }
        /// <summary>
        /// Needs summary!
        /// </summary>
        public Nullable<int> LoanDecisionId { get; set; }
        #endregion
    }
    #endregion
    #endregion

    #region LoanMoveFromEmployeeToGuarantor filter and result classes
    #region LoanMoveFromEmployeeToGuarantorFilter class definition
    /// <summary>
    /// Filter class for LoanMoveFromEmployeeToGuarantor.
    /// </summary>
    public partial class LoanMoveFromEmployeeToGuarantorFilter
    {
        #region Public properties
        /// <summary>
        /// Needs summary!
        /// </summary>
        public Nullable<int> Loan { get; set; }

        /// <summary>
        /// Needs summary!
        /// </summary>
        public Nullable<int> EmployeeId { get; set; }

        /// <summary>
        /// Needs summary!
        /// </summary>
        public Nullable<int> LoanDecisionId { get; set; }
        /// <summary>
        /// Needs summary!
        /// </summary>
        public Nullable<int> NumberOfGuarantors { get; set; }
        #endregion
    }
    #endregion
    #endregion

    #region EmployeeMonthPayments filter and result classes
    #region EmployeeMonthPaymentsFilter class definition
    /// <summary>
    /// Filter class for EmployeeMonthPayments.
    /// </summary>
    [MetadataType(typeof(EmployeeMonthPaymentsFilterMetaData))]
	public partial class EmployeeMonthPaymentsFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> Month {get; set; }
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<int> Employee {get; set; }
		#endregion
	}
	#endregion

	#region EmployeeMonthPaymentsResult class definition
	/// <summary>
    /// Result class for EmployeeMonthPayments.
	/// </summary>
    [MetadataType(typeof(EmployeeMonthPaymentsResultMetaData))]
	public partial class EmployeeMonthPaymentsResult
	{
		#region Public properties
        public int EmployeeId {get; set; }
		
        public string EmployeeFullName {get; set; }
		
        public string EmployeeDepartmentSalaryWorkPlaceName {get; set; }
		
        public Nullable<decimal> Amount {get; set; }
		
        public string Month {get; set; }
		
        public byte PaymentGroupId {get; set; }
		
        public string PaymentGroupName {get; set; }
		#endregion
	}
	#endregion
    #endregion

	#region EmployeeMonthSubscriptions filter and result classes
    #region EmployeeMonthSubscriptionsFilter class definition
	/// <summary>
    /// Filter class for EmployeeMonthSubscriptions.
	/// </summary>
    [MetadataType(typeof(EmployeeMonthSubscriptionsFilterMetaData))]
	public partial class EmployeeMonthSubscriptionsFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> Month {get; set; }
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<int> Employee {get; set; }
		#endregion
	}
	#endregion

	#region EmployeeMonthSubscriptionsResult class definition
	/// <summary>
    /// Result class for EmployeeMonthSubscriptions.
	/// </summary>
    [MetadataType(typeof(EmployeeMonthSubscriptionsResultMetaData))]
	public partial class EmployeeMonthSubscriptionsResult
	{
		#region Public properties
        public int EmployeeId {get; set; }
		
        public string EmployeeFullName {get; set; }
		
        public string EmployeeDepartmentSalaryWorkPlaceName {get; set; }
		
        public Nullable<decimal> Amount {get; set; }
		
        public string Month {get; set; }
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
		
        public string DepartmentName {get; set; }
		
        public string DepartmentSalaryWorkPlaceName {get; set; }
		
        public string EmployeeStatusName {get; set; }
		
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
		
        public Nullable<decimal> AnnualRate {get; set; }
		
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

	#region GetDebts filter and result classes
    #region GetDebtsFilter class definition
	/// <summary>
    /// Filter class for GetDebts.
	/// </summary>
    [MetadataType(typeof(GetDebtsFilterMetaData))]
	public partial class GetDebtsFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<int> EmployeeId {get; set; }
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> Date {get; set; }
		#endregion
	}
	#endregion

	#region GetDebtsResult class definition
	/// <summary>
    /// Result class for GetDebts.
	/// </summary>
    [MetadataType(typeof(GetDebtsResultMetaData))]
	public partial class GetDebtsResult
	{
		#region Public properties
        public int Id {get; set; }
		
        public int EmployeeId {get; set; }
		
        public decimal OriginalAmount {get; set; }
		
        public Nullable<decimal> RemainingAmount {get; set; }
		
        public decimal Installment {get; set; }
		#endregion
	}
	#endregion
    #endregion

	#region GetDebtScalar filter and result classes
    #region GetDebtScalarFilter class definition
	/// <summary>
    /// Filter class for GetDebtScalar.
	/// </summary>
    [MetadataType(typeof(GetDebtScalarFilterMetaData))]
	public partial class GetDebtScalarFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> Date {get; set; }
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<int> EmployeeId {get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region GetDebtSolvency filter and result classes
    #region GetDebtSolvencyFilter class definition
	/// <summary>
    /// Filter class for GetDebtSolvency.
	/// </summary>
    [MetadataType(typeof(GetDebtSolvencyFilterMetaData))]
	public partial class GetDebtSolvencyFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<int> ProductId {get; set; }
		#endregion
	}
	#endregion

	#region GetDebtSolvencyResult class definition
	/// <summary>
    /// Result class for GetDebtSolvency.
	/// </summary>
    [MetadataType(typeof(GetDebtSolvencyResultMetaData))]
	public partial class GetDebtSolvencyResult
	{
		#region Public properties
        public Nullable<int> EmployeeId {get; set; }
		
        public Nullable<decimal> DebtRemainingAmount {get; set; }
		
        public Nullable<decimal> WarrantRemainingAmount {get; set; }
		
        public Nullable<decimal> TotalAmount {get; set; }
		
        public Nullable<decimal> DebtInstallment {get; set; }
		
        public Nullable<decimal> WarrantInstallment {get; set; }
		
        public Nullable<decimal> TotalInstallment {get; set; }
		
        public Nullable<decimal> MaxAllowedDebt {get; set; }
		
        public Nullable<decimal> MaxAllowedDeduction {get; set; }
		
        public Nullable<decimal> IncomeSolvency {get; set; }
		
        public Nullable<decimal> NetSalarySolvency {get; set; }
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
	#endregion

	#region GetEmployeeDebts filter and result classes
    #region GetEmployeeDebtsFilter class definition
	/// <summary>
    /// Filter class for GetEmployeeDebts.
	/// </summary>
    [MetadataType(typeof(GetEmployeeDebtsFilterMetaData))]
	public partial class GetEmployeeDebtsFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<int> EmployeeId {get; set; }
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> Date {get; set; }
		#endregion
	}
	#endregion

	#region GetEmployeeDebtsResult class definition
	/// <summary>
    /// Result class for GetEmployeeDebts.
	/// </summary>
    [MetadataType(typeof(GetEmployeeDebtsResultMetaData))]
	public partial class GetEmployeeDebtsResult
	{
		#region Public properties
        public int EmployeeId {get; set; }
		
        public Nullable<decimal> OriginalAmount {get; set; }
		
        public Nullable<decimal> RemainingAmount {get; set; }
		
        public Nullable<decimal> Installment {get; set; }
		#endregion
	}
	#endregion
    #endregion

	#region GetEmployeeSolvency filter and result classes
    #region GetEmployeeSolvencyFilter class definition
	/// <summary>
    /// Filter class for GetEmployeeSolvency.
	/// </summary>
    [MetadataType(typeof(GetEmployeeSolvencyFilterMetaData))]
	public partial class GetEmployeeSolvencyFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<int> EmployeeId {get; set; }
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> Date {get; set; }
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<decimal> Amount {get; set; }
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<decimal> Installment {get; set; }
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<decimal> GrossSalary {get; set; }
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<decimal> NetSalary {get; set; }
		#endregion
	}
	#endregion

	#region GetEmployeeSolvencyResult class definition
	/// <summary>
    /// Result class for GetEmployeeSolvency.
	/// </summary>
    [MetadataType(typeof(GetEmployeeSolvencyResultMetaData))]
	public partial class GetEmployeeSolvencyResult
	{
		#region Public properties
        public int EmployeeId {get; set; }
		
        public string FullName {get; set; }
		
        public decimal DebtRemainingAmount {get; set; }
		
        public decimal WarrantRemainingAmount {get; set; }
		
        public Nullable<decimal> TotalAmount {get; set; }
		
        public decimal DebtInstallment {get; set; }
		
        public decimal WarrantInstallment {get; set; }
		
        public Nullable<decimal> TotalInstallment {get; set; }
		
        public Nullable<decimal> MaxAllowedDebt {get; set; }
		
        public Nullable<decimal> MaxAllowedDeduction {get; set; }
		
        public Nullable<decimal> IncomeSolvency {get; set; }
		
        public Nullable<decimal> NetSalarySolvency {get; set; }
		#endregion
	}
	#endregion
    #endregion

	#region GetEmployeeSumDebts filter and result classes
    #region GetEmployeeSumDebtsFilter class definition
	/// <summary>
    /// Filter class for GetEmployeeSumDebts.
	/// </summary>
    [MetadataType(typeof(GetEmployeeSumDebtsFilterMetaData))]
	public partial class GetEmployeeSumDebtsFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<int> EmployeeId {get; set; }
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> Date {get; set; }
		#endregion
	}
	#endregion

	#region GetEmployeeSumDebtsResult class definition
	/// <summary>
    /// Result class for GetEmployeeSumDebts.
	/// </summary>
    [MetadataType(typeof(GetEmployeeSumDebtsResultMetaData))]
	public partial class GetEmployeeSumDebtsResult
	{
		#region Public properties
        public int EmployeeId {get; set; }
		
        public string FullName {get; set; }
		
        public int HasDebts {get; set; }
		
        public decimal DebtOriginalAmount {get; set; }
		
        public decimal DebtRemainingAmount {get; set; }
		
        public decimal DebtInstallment {get; set; }
		
        public int HasWarrants {get; set; }
		
        public decimal WarrantOriginalAmount {get; set; }
		
        public decimal WarrantRemainingAmount {get; set; }
		
        public decimal WarrantInstallment {get; set; }
		
        public Nullable<decimal> TotalAmount {get; set; }
		
        public Nullable<decimal> TotalInstallment {get; set; }
		#endregion
	}
	#endregion
    #endregion

	#region GetEmployeeWarrants filter and result classes
    #region GetEmployeeWarrantsFilter class definition
	/// <summary>
    /// Filter class for GetEmployeeWarrants.
	/// </summary>
    [MetadataType(typeof(GetEmployeeWarrantsFilterMetaData))]
	public partial class GetEmployeeWarrantsFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<int> EmployeeId {get; set; }
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> Date {get; set; }
		#endregion
	}
	#endregion

	#region GetEmployeeWarrantsResult class definition
	/// <summary>
    /// Result class for GetEmployeeWarrants.
	/// </summary>
    [MetadataType(typeof(GetEmployeeWarrantsResultMetaData))]
	public partial class GetEmployeeWarrantsResult
	{
		#region Public properties
        public int EmployeeId {get; set; }
		
        public Nullable<decimal> OriginalAmount {get; set; }
		
        public Nullable<decimal> RemainingAmount {get; set; }
		
        public Nullable<decimal> Installment {get; set; }
		#endregion
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
        public int RefundableProductId {get; set; }
		
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
        public int RefundableProductId {get; set; }
		
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

	#region GetWarrants filter and result classes
    #region GetWarrantsFilter class definition
	/// <summary>
    /// Filter class for GetWarrants.
	/// </summary>
    [MetadataType(typeof(GetWarrantsFilterMetaData))]
	public partial class GetWarrantsFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<int> EmployeeId {get; set; }
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> Date {get; set; }
		#endregion
	}
	#endregion

	#region GetWarrantsResult class definition
	/// <summary>
    /// Result class for GetWarrants.
	/// </summary>
    [MetadataType(typeof(GetWarrantsResultMetaData))]
	public partial class GetWarrantsResult
	{
		#region Public properties
        public int Id {get; set; }
		
        public int DebtId {get; set; }
		
        public int EmployeeId {get; set; }
		
        public Nullable<decimal> OriginalAmount {get; set; }
		
        public Nullable<decimal> RemainingAmount {get; set; }
		
        public Nullable<decimal> Installment {get; set; }
		#endregion
	}
	#endregion
    #endregion

	#region GetWarrantSolvency filter and result classes
    #region GetWarrantSolvencyFilter class definition
	/// <summary>
    /// Filter class for GetWarrantSolvency.
	/// </summary>
    [MetadataType(typeof(GetWarrantSolvencyFilterMetaData))]
	public partial class GetWarrantSolvencyFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<int> EmployeeId {get; set; }
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<int> ProductId {get; set; }
		#endregion
	}
	#endregion

	#region GetWarrantSolvencyResult class definition
	/// <summary>
    /// Result class for GetWarrantSolvency.
	/// </summary>
    [MetadataType(typeof(GetWarrantSolvencyResultMetaData))]
	public partial class GetWarrantSolvencyResult
	{
		#region Public properties
        public Nullable<int> EmployeeId {get; set; }
		
        public Nullable<decimal> DebtRemainingAmount {get; set; }
		
        public Nullable<decimal> WarrantRemainingAmount {get; set; }
		
        public Nullable<decimal> TotalAmount {get; set; }
		
        public Nullable<decimal> DebtInstallment {get; set; }
		
        public Nullable<decimal> WarrantInstallment {get; set; }
		
        public Nullable<decimal> TotalInstallment {get; set; }
		
        public Nullable<decimal> MaxAllowedDebt {get; set; }
		
        public Nullable<decimal> MaxAllowedDeduction {get; set; }
		
        public Nullable<decimal> IncomeSolvency {get; set; }
		
        public Nullable<decimal> NetSalarySolvency {get; set; }
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
	#endregion

	#region LoanMoveToEmployee filter and result classes
    #region LoanMoveToEmployeeFilter class definition
	/// <summary>
    /// Filter class for LoanMoveToEmployee.
	/// </summary>
    [MetadataType(typeof(LoanMoveToEmployeeFilterMetaData))]
	public partial class LoanMoveToEmployeeFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<int> Loan {get; set; }
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<int> EmployeeId {get; set; }
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<int> LoanDecisionId {get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region MonthlyBalanceSum filter and result classes
    #region MonthlyBalanceSumFilter class definition
	/// <summary>
    /// Filter class for MonthlyBalanceSum.
	/// </summary>
    [MetadataType(typeof(MonthlyBalanceSumFilterMetaData))]
	public partial class MonthlyBalanceSumFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> MinMonth {get; set; }
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> MaxMonth {get; set; }
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<int> EmployeeId {get; set; }
		#endregion
	}
	#endregion

	#region MonthlyBalanceSumResult class definition
	/// <summary>
    /// Result class for MonthlyBalanceSum.
	/// </summary>
    [MetadataType(typeof(MonthlyBalanceSumResultMetaData))]
	public partial class MonthlyBalanceSumResult
	{
		#region Public properties
        public DateTime Month {get; set; }
		
        public Nullable<decimal> Opening {get; set; }
		
        public Nullable<decimal> NormalLoans {get; set; }
		
        public Nullable<decimal> IncomingLoans {get; set; }
		
        public Nullable<decimal> OutgoingLoans {get; set; }
		
        public Nullable<decimal> Restitutions {get; set; }
		
        public Nullable<decimal> SalaryPayments {get; set; }
		
        public Nullable<decimal> CashPayments {get; set; }
		
        public Nullable<decimal> AllLoans {get; set; }
		
        public Nullable<decimal> AllPayments {get; set; }
		#endregion
	}
	#endregion
    #endregion

	#region PaymentBetweenTwoDates filter and result classes
    #region PaymentBetweenTwoDatesFilter class definition
	/// <summary>
    /// Filter class for PaymentBetweenTwoDates.
	/// </summary>
    [MetadataType(typeof(PaymentBetweenTwoDatesFilterMetaData))]
	public partial class PaymentBetweenTwoDatesFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> MinDate {get; set; }
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> MaxDate {get; set; }
		#endregion
	}
	#endregion

	#region PaymentBetweenTwoDatesResult class definition
	/// <summary>
    /// Result class for PaymentBetweenTwoDates.
	/// </summary>
    [MetadataType(typeof(PaymentBetweenTwoDatesResultMetaData))]
	public partial class PaymentBetweenTwoDatesResult
	{
		#region Public properties
        public Nullable<decimal> FirstMonthAmount {get; set; }
		
        public Nullable<decimal> SecondMonthAmount {get; set; }
		#endregion
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
		
        public Nullable<decimal> AnnualRate {get; set; }
		
        public Nullable<byte> GuarantorsCount {get; set; }
		#endregion
	}
	#endregion
    #endregion

	#region ReportEmployeeLoansBetweenTwoDates filter and result classes
    #region ReportEmployeeLoansBetweenTwoDatesFilter class definition
	/// <summary>
    /// Filter class for ReportEmployeeLoansBetweenTwoDates.
	/// </summary>
    [MetadataType(typeof(ReportEmployeeLoansBetweenTwoDatesFilterMetaData))]
	public partial class ReportEmployeeLoansBetweenTwoDatesFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> FromDate {get; set; }
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> ToDate {get; set; }
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<int> EmployeeId {get; set; }
		#endregion
	}
	#endregion

	#region ReportEmployeeLoansBetweenTwoDatesResult class definition
	/// <summary>
    /// Result class for ReportEmployeeLoansBetweenTwoDates.
	/// </summary>
    [MetadataType(typeof(ReportEmployeeLoansBetweenTwoDatesResultMetaData))]
	public partial class ReportEmployeeLoansBetweenTwoDatesResult
	{
		#region Public properties
        public int ProductEmployeeId {get; set; }
		
        public string ProductEmployeeFullName {get; set; }
		
        public string ProductProductTypeName {get; set; }
		
        public decimal ProductAmount {get; set; }
		
        public short LoanDecisionNumber {get; set; }
		
        public DateTime LoanDecisionDate {get; set; }
		
        public string LoanDecisionPaymentNumber {get; set; }
		
        public Nullable<DateTime> LoanDecisionPaymentDate {get; set; }
		
        public decimal Installment {get; set; }
		
        public decimal ProfitAmount {get; set; }
		
        public string Guarantors {get; set; }
		#endregion
	}
	#endregion
    #endregion

	#region ReportLoansBetweenTwoDates filter and result classes
    #region ReportLoansBetweenTwoDatesFilter class definition
	/// <summary>
    /// Filter class for ReportLoansBetweenTwoDates.
	/// </summary>
    [MetadataType(typeof(ReportLoansBetweenTwoDatesFilterMetaData))]
	public partial class ReportLoansBetweenTwoDatesFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> FromDate {get; set; }
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> ToDate {get; set; }
		#endregion
	}
	#endregion

	#region ReportLoansBetweenTwoDatesResult class definition
	/// <summary>
    /// Result class for ReportLoansBetweenTwoDates.
	/// </summary>
    [MetadataType(typeof(ReportLoansBetweenTwoDatesResultMetaData))]
	public partial class ReportLoansBetweenTwoDatesResult
	{
		#region Public properties
        public short ProductProductTypeId {get; set; }
		
        public string ProductProductTypeName {get; set; }
		
        public Nullable<decimal> Amounts {get; set; }
		
        public Nullable<int> LoanCounts {get; set; }
		
        public Nullable<decimal> ProfitAmount {get; set; }
		#endregion
	}
	#endregion
    #endregion

	#region ReportMonthlyBalanceSum filter and result classes
    #region ReportMonthlyBalanceSumFilter class definition
	/// <summary>
    /// Filter class for ReportMonthlyBalanceSum.
	/// </summary>
    [MetadataType(typeof(ReportMonthlyBalanceSumFilterMetaData))]
	public partial class ReportMonthlyBalanceSumFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> MinMonth {get; set; }
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> MaxMonth {get; set; }
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<int> EmployeeId {get; set; }
		#endregion
	}
	#endregion

	#region ReportMonthlyBalanceSumResult class definition
	/// <summary>
    /// Result class for ReportMonthlyBalanceSum.
	/// </summary>
    [MetadataType(typeof(ReportMonthlyBalanceSumResultMetaData))]
	public partial class ReportMonthlyBalanceSumResult
	{
		#region Public properties
        public int EmployeeId {get; set; }
		
        public string EmployeeFullName {get; set; }
		
        public DateTime Month {get; set; }
		
        public Nullable<decimal> Opening {get; set; }
		
        public Nullable<decimal> NormalLoans {get; set; }
		
        public Nullable<decimal> IncomingLoans {get; set; }
		
        public Nullable<decimal> OutgoingLoans {get; set; }
		
        public Nullable<decimal> Restitutions {get; set; }
		
        public Nullable<decimal> SalaryPayments {get; set; }
		
        public Nullable<decimal> CashPayments {get; set; }
		
        public Nullable<decimal> AllLoans {get; set; }
		
        public Nullable<decimal> AllPayments {get; set; }
		#endregion
	}
	#endregion
    #endregion

	#region ReportPaymentsBetweenTwoDates filter and result classes
    #region ReportPaymentsBetweenTwoDatesFilter class definition
	/// <summary>
    /// Filter class for ReportPaymentsBetweenTwoDates.
	/// </summary>
    [MetadataType(typeof(ReportPaymentsBetweenTwoDatesFilterMetaData))]
	public partial class ReportPaymentsBetweenTwoDatesFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> FirstMonth {get; set; }
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> SecondMonth {get; set; }
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<double> Limit {get; set; }
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<int> PaymentDiff {get; set; }
		#endregion
	}
	#endregion

	#region ReportPaymentsBetweenTwoDatesResult class definition
	/// <summary>
    /// Result class for ReportPaymentsBetweenTwoDates.
	/// </summary>
    [MetadataType(typeof(ReportPaymentsBetweenTwoDatesResultMetaData))]
	public partial class ReportPaymentsBetweenTwoDatesResult
	{
		#region Public properties
        public Nullable<int> FirstEmployeeId {get; set; }
		
        public string FirstEmployeeFullName {get; set; }
		
        public string FirstSalaryWorkPlaceName {get; set; }
		
        public Nullable<decimal> FirstAmount {get; set; }
		
        public string FirstDate {get; set; }
		
        public Nullable<byte> FirstPaymentGroupId {get; set; }
		
        public string FirstPaymentGroupName {get; set; }
		
        public Nullable<int> SecondEmployeeId {get; set; }
		
        public string SecondEmployeeFullName {get; set; }
		
        public string SecondSalaryWorkPlaceName {get; set; }
		
        public Nullable<decimal> SecondAmount {get; set; }
		
        public string SecondDate {get; set; }
		
        public Nullable<byte> SecondPaymentGroupId {get; set; }
		
        public string SecondPaymentGroupName {get; set; }
		
        public Nullable<int> PaymentDiffrence {get; set; }
		#endregion
	}
	#endregion
    #endregion

	#region ReportSubscriptionsBetweenTwoDates filter and result classes
    #region ReportSubscriptionsBetweenTwoDatesFilter class definition
	/// <summary>
    /// Filter class for ReportSubscriptionsBetweenTwoDates.
	/// </summary>
    [MetadataType(typeof(ReportSubscriptionsBetweenTwoDatesFilterMetaData))]
	public partial class ReportSubscriptionsBetweenTwoDatesFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> FirstMonth {get; set; }
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> SecondMonth {get; set; }
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<double> Limit {get; set; }
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<int> SubscriptionDiff {get; set; }
		#endregion
	}
	#endregion

	#region ReportSubscriptionsBetweenTwoDatesResult class definition
	/// <summary>
    /// Result class for ReportSubscriptionsBetweenTwoDates.
	/// </summary>
    [MetadataType(typeof(ReportSubscriptionsBetweenTwoDatesResultMetaData))]
	public partial class ReportSubscriptionsBetweenTwoDatesResult
	{
		#region Public properties
        public Nullable<int> FirstEmployeeId {get; set; }
		
        public string FirstEmployeeFullName {get; set; }
		
        public string FirstSalaryWorkPlaceName {get; set; }
		
        public Nullable<decimal> FirstAmount {get; set; }
		
        public string FirstMonth {get; set; }
		
        public Nullable<int> SecondEmployeeId {get; set; }
		
        public string SecondEmployeeFullName {get; set; }
		
        public string SecondSalaryWorkPlaceName {get; set; }
		
        public Nullable<decimal> SecondAmount {get; set; }
		
        public string SecondMonth {get; set; }
		
        public Nullable<int> SubscriptionDiffrence {get; set; }
		#endregion
	}
	#endregion
    #endregion

	#region RequestStatistics filter and result classes
    #region RequestStatisticsFilter class definition
	/// <summary>
    /// Filter class for RequestStatistics.
	/// </summary>
    [MetadataType(typeof(RequestStatisticsFilterMetaData))]
	public partial class RequestStatisticsFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> MinDate {get; set; }
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> MaxDate {get; set; }
		#endregion
	}
	#endregion

	#region RequestStatisticsResult class definition
	/// <summary>
    /// Result class for RequestStatistics.
	/// </summary>
    [MetadataType(typeof(RequestStatisticsResultMetaData))]
	public partial class RequestStatisticsResult
	{
		#region Public properties
        public Nullable<byte> RequestStatusId {get; set; }
		
        public string RequestStatusName {get; set; }
		
        public Nullable<int> RequestCount {get; set; }
		
        public Nullable<decimal> RequestSum {get; set; }
		#endregion
	}
	#endregion
    #endregion

	#region SubscriptionsBetweenTwoDates filter and result classes
    #region SubscriptionsBetweenTwoDatesFilter class definition
	/// <summary>
    /// Filter class for SubscriptionsBetweenTwoDates.
	/// </summary>
    [MetadataType(typeof(SubscriptionsBetweenTwoDatesFilterMetaData))]
	public partial class SubscriptionsBetweenTwoDatesFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> MinDate {get; set; }
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> MaxDate {get; set; }
		#endregion
	}
	#endregion

	#region SubscriptionsBetweenTwoDatesResult class definition
	/// <summary>
    /// Result class for SubscriptionsBetweenTwoDates.
	/// </summary>
    [MetadataType(typeof(SubscriptionsBetweenTwoDatesResultMetaData))]
	public partial class SubscriptionsBetweenTwoDatesResult
	{
		#region Public properties
        public Nullable<decimal> FirstMonthAmount {get; set; }
		
        public Nullable<decimal> SecondMonthAmount {get; set; }
		#endregion
	}
	#endregion
    #endregion

	#region SumComingLoansForEmployee filter and result classes
    #region SumComingLoansForEmployeeFilter class definition
	/// <summary>
    /// Filter class for SumComingLoansForEmployee.
	/// </summary>
    [MetadataType(typeof(SumComingLoansForEmployeeFilterMetaData))]
	public partial class SumComingLoansForEmployeeFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> FromDate {get; set; }
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> ToDate {get; set; }
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<int> Employee {get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region SumLoansForEmployee filter and result classes
    #region SumLoansForEmployeeFilter class definition
	/// <summary>
    /// Filter class for SumLoansForEmployee.
	/// </summary>
    [MetadataType(typeof(SumLoansForEmployeeFilterMetaData))]
	public partial class SumLoansForEmployeeFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> FromDate {get; set; }
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> ToDate {get; set; }
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<int> Employee {get; set; }
		#endregion
	}
	#endregion
	#endregion

	#region SumOutgoingLoansForEmployee filter and result classes
    #region SumOutgoingLoansForEmployeeFilter class definition
	/// <summary>
    /// Filter class for SumOutgoingLoansForEmployee.
	/// </summary>
    [MetadataType(typeof(SumOutgoingLoansForEmployeeFilterMetaData))]
	public partial class SumOutgoingLoansForEmployeeFilter
	{
		#region Public properties
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> FromDate {get; set; }
		
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<DateTime> ToDate {get; set; }
		/// <summary>
		/// Needs summary!
		/// </summary>
		public Nullable<int> Employee {get; set; }
		#endregion
	}
	#endregion
	#endregion
}
