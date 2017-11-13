using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using Cf.Data;

namespace Cf.Services
{
	#region Db class definition
	public static partial class DbServices
	{
		#region EmployeeProductCalculator procedure.


		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_productTypeId"></param>
		/// <param name="_amount"></param>
		/// <param name="_period"></param>
		/// <returns>A list of EmployeeProductCalculatorResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeProductCalculatorResult> EmployeeProductCalculator([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@ProductTypeId")] Nullable<short> _productTypeId, [Parameter(Name = "@Amount")] Nullable<decimal> _amount, [Parameter(Name = "@Period")] Nullable<short> _period)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.EmployeeProductCalculator(_employeeId, _productTypeId, _amount, _period);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="filterInstance">An instance of EmployeeProductCalculatorFilter that defines filtering options.</param>
		/// <returns>A list of EmployeeProductCalculatorResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeProductCalculatorResult> EmployeeProductCalculator(EmployeeProductCalculatorFilter filterInstance, Db db)
		{
			return db.EmployeeProductCalculator(filterInstance.EmployeeId, filterInstance.ProductTypeId, filterInstance.Amount, filterInstance.Period);
		}
		#endregion

		#region GetAvailabilityCeilingByProductTypeId_EmployeeId procedure.


		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_productTypeId"></param>
		/// <param name="_employeeId"></param>
		/// <returns>A list of GetAvailabilityCeilingByProductTypeId_EmployeeIdResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetAvailabilityCeilingByProductTypeId_EmployeeIdResult> GetAvailabilityCeilingByProductTypeId_EmployeeId([Parameter(Name = "@ProductTypeId")] Nullable<short> _productTypeId, [Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetAvailabilityCeilingByProductTypeId_EmployeeId(_productTypeId, _employeeId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="filterInstance">An instance of GetAvailabilityCeilingByProductTypeId_EmployeeIdFilter that defines filtering options.</param>
		/// <returns>A list of GetAvailabilityCeilingByProductTypeId_EmployeeIdResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetAvailabilityCeilingByProductTypeId_EmployeeIdResult> GetAvailabilityCeilingByProductTypeId_EmployeeId(GetAvailabilityCeilingByProductTypeId_EmployeeIdFilter filterInstance, Db db)
		{
			return db.GetAvailabilityCeilingByProductTypeId_EmployeeId(filterInstance.ProductTypeId, filterInstance.EmployeeId);
		}
		#endregion

		#region GetDueProfit procedure.

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_amount"></param>
		/// <param name="_period"></param>
		/// <param name="_rate"></param>
		public static decimal GetDueProfit([Parameter(Name = "@Amount")] Nullable<decimal> _amount, [Parameter(Name = "@Period")] Nullable<short> _period, [Parameter(Name = "@Rate")] Nullable<decimal> _rate)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetDueProfit(_amount, _period, _rate);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_amount"></param>
		/// <param name="_period"></param>
		/// <param name="_rate"></param>
		public static decimal GetDueProfit([Parameter(Name = "@Amount")] Nullable<decimal> _amount, [Parameter(Name = "@Period")] Nullable<short> _period, [Parameter(Name = "@Rate")] Nullable<decimal> _rate, Db db)
		{
			return db.GetDueProfit(_amount, _period, _rate);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="filterInstance">An instance of GetDueProfitFilter that defines filtering options.</param>
		public static decimal GetDueProfit(GetDueProfitFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetDueProfit(filterInstance.Amount, filterInstance.Period, filterInstance.Rate);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="filterInstance">An instance of GetDueProfitFilter that defines filtering options.</param>
		public static decimal GetDueProfit(GetDueProfitFilter filterInstance, Db db)
		{
			return db.GetDueProfit(filterInstance.Amount, filterInstance.Period, filterInstance.Rate);
		}
		#endregion

		#region GetFinancialRatio procedure.

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_period"></param>
		/// <param name="_rate"></param>
		/// <param name="_type"></param>
		public static double GetFinancialRatio([Parameter(Name = "@Period")] Nullable<short> _period, [Parameter(Name = "@Rate")] Nullable<double> _rate, [Parameter(Name = "@Type")] Nullable<bool> _type)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetFinancialRatio(_period, _rate, _type);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_period"></param>
		/// <param name="_rate"></param>
		/// <param name="_type"></param>
		public static double GetFinancialRatio([Parameter(Name = "@Period")] Nullable<short> _period, [Parameter(Name = "@Rate")] Nullable<double> _rate, [Parameter(Name = "@Type")] Nullable<bool> _type, Db db)
		{
			return db.GetFinancialRatio(_period, _rate, _type);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="filterInstance">An instance of GetFinancialRatioFilter that defines filtering options.</param>
		public static double GetFinancialRatio(GetFinancialRatioFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetFinancialRatio(filterInstance.Period, filterInstance.Rate, filterInstance.Type);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="filterInstance">An instance of GetFinancialRatioFilter that defines filtering options.</param>
		public static double GetFinancialRatio(GetFinancialRatioFilter filterInstance, Db db)
		{
			return db.GetFinancialRatio(filterInstance.Period, filterInstance.Rate, filterInstance.Type);
		}
		#endregion

		#region GetInstallment procedure.

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_amount"></param>
		/// <param name="_period"></param>
		/// <param name="_rate"></param>
		/// <param name="_type"></param>
		public static decimal GetInstallment([Parameter(Name = "@Amount")] Nullable<decimal> _amount, [Parameter(Name = "@Period")] Nullable<short> _period, [Parameter(Name = "@Rate")] Nullable<double> _rate, [Parameter(Name = "@Type")] Nullable<bool> _type)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetInstallment(_amount, _period, _rate, _type);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_amount"></param>
		/// <param name="_period"></param>
		/// <param name="_rate"></param>
		/// <param name="_type"></param>
		public static decimal GetInstallment([Parameter(Name = "@Amount")] Nullable<decimal> _amount, [Parameter(Name = "@Period")] Nullable<short> _period, [Parameter(Name = "@Rate")] Nullable<double> _rate, [Parameter(Name = "@Type")] Nullable<bool> _type, Db db)
		{
			return db.GetInstallment(_amount, _period, _rate, _type);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="filterInstance">An instance of GetInstallmentFilter that defines filtering options.</param>
		public static decimal GetInstallment(GetInstallmentFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetInstallment(filterInstance.Amount, filterInstance.Period, filterInstance.Rate, filterInstance.Type);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="filterInstance">An instance of GetInstallmentFilter that defines filtering options.</param>
		public static decimal GetInstallment(GetInstallmentFilter filterInstance, Db db)
		{
			return db.GetInstallment(filterInstance.Amount, filterInstance.Period, filterInstance.Rate, filterInstance.Type);
		}
		#endregion

		#region GetPresentValue procedure.

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_installment"></param>
		/// <param name="_period"></param>
		/// <param name="_rate"></param>
		/// <param name="_type"></param>
		public static decimal GetPresentValue([Parameter(Name = "@Installment")] Nullable<decimal> _installment, [Parameter(Name = "@Period")] Nullable<short> _period, [Parameter(Name = "@Rate")] Nullable<double> _rate, [Parameter(Name = "@Type")] Nullable<bool> _type)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetPresentValue(_installment, _period, _rate, _type);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_installment"></param>
		/// <param name="_period"></param>
		/// <param name="_rate"></param>
		/// <param name="_type"></param>
		public static decimal GetPresentValue([Parameter(Name = "@Installment")] Nullable<decimal> _installment, [Parameter(Name = "@Period")] Nullable<short> _period, [Parameter(Name = "@Rate")] Nullable<double> _rate, [Parameter(Name = "@Type")] Nullable<bool> _type, Db db)
		{
			return db.GetPresentValue(_installment, _period, _rate, _type);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="filterInstance">An instance of GetPresentValueFilter that defines filtering options.</param>
		public static decimal GetPresentValue(GetPresentValueFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetPresentValue(filterInstance.Installment, filterInstance.Period, filterInstance.Rate, filterInstance.Type);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="filterInstance">An instance of GetPresentValueFilter that defines filtering options.</param>
		public static decimal GetPresentValue(GetPresentValueFilter filterInstance, Db db)
		{
			return db.GetPresentValue(filterInstance.Installment, filterInstance.Period, filterInstance.Rate, filterInstance.Type);
		}
		#endregion

		#region LoanGenerate procedure.

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_productId">معرف المنتج</param>
		/// <param name="_loanDecisionId">معرف قرار السلف</param>
		/// <param name="_loanGenerationStatusId">معرف حالة توليد البطاقة</param>
		public static void LoanGenerate([Parameter(Name = "@ProductId")] Nullable<int> _productId, [Parameter(Name = "@LoanDecisionId")] Nullable<int> _loanDecisionId, [Parameter(Name = "@LoanGenerationStatusId")] Nullable<byte> _loanGenerationStatusId)
		{
			Db db = new Db(DbServices.ConnectionString);
			db.LoanGenerate(_productId, _loanDecisionId, _loanGenerationStatusId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_productId">معرف المنتج</param>
		/// <param name="_loanDecisionId">معرف قرار السلف</param>
		/// <param name="_loanGenerationStatusId">معرف حالة توليد البطاقة</param>
		public static void LoanGenerate([Parameter(Name = "@ProductId")] Nullable<int> _productId, [Parameter(Name = "@LoanDecisionId")] Nullable<int> _loanDecisionId, [Parameter(Name = "@LoanGenerationStatusId")] Nullable<byte> _loanGenerationStatusId, Db db)
		{
			db.LoanGenerate(_productId, _loanDecisionId, _loanGenerationStatusId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="filterInstance">An instance of LoanGenerateFilter that defines filtering options.</param>
		public static void LoanGenerate(LoanGenerateFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			db.LoanGenerate(filterInstance.ProductId, filterInstance.LoanDecisionId, filterInstance.LoanGenerationStatusId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="filterInstance">An instance of LoanGenerateFilter that defines filtering options.</param>
		public static void LoanGenerate(LoanGenerateFilter filterInstance, Db db)
		{
			db.LoanGenerate(filterInstance.ProductId, filterInstance.LoanDecisionId, filterInstance.LoanGenerationStatusId);
		}
		#endregion

		#region ProductCalculator procedure.


		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_productType"></param>
		/// <param name="_amount"></param>
		/// <param name="_period"></param>
		/// <returns>A list of ProductCalculatorResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductCalculatorResult> ProductCalculator([Parameter(Name = "@ProductType")] Nullable<short> _productType, [Parameter(Name = "@Amount")] Nullable<decimal> _amount, [Parameter(Name = "@Period")] Nullable<short> _period)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.ProductCalculator(_productType, _amount, _period);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="filterInstance">An instance of ProductCalculatorFilter that defines filtering options.</param>
		/// <returns>A list of ProductCalculatorResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductCalculatorResult> ProductCalculator(ProductCalculatorFilter filterInstance, Db db)
		{
			return db.ProductCalculator(filterInstance.ProductType, filterInstance.Amount, filterInstance.Period);
		}
		#endregion
	}
	#endregion
}
