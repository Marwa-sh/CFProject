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
        #region EmployeeLoans procedure.


        /// <summary>
        /// Needs summary!
        /// </summary>
        /// <param name="_employeeId"></param>
        /// <param name="_loanStatusId"></param>
        /// <returns>A list of EmployeeLoansResult instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<EmployeeLoansResult> EmployeeLoans([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@LoanStatusId")] Nullable<int> _loanStatusId)
        {
            Db db = new Db(DbServices.ConnectionString);
            return db.EmployeeLoans(_employeeId, _loanStatusId);
        }

        /// <summary>
        /// Needs summary!
        /// </summary>
        /// <param name="_employeeId"></param>
        /// <param name="_loanStatusId"></param>
        /// <returns>A list of EmployeeLoansResult instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<EmployeeLoansResult> EmployeeLoans([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@LoanStatusId")] Nullable<int> _loanStatusId, Db db)
        {
            return db.EmployeeLoans(_employeeId, _loanStatusId);
        }

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of EmployeeLoansFilter that defines filtering options.</param>
        /// <returns>A list of EmployeeLoansResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeLoansResult> EmployeeLoans(EmployeeLoansFilter filterInstance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return db.EmployeeLoans(filterInstance.EmployeeId, filterInstance.LoanStatusId);
        }

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of EmployeeLoansFilter that defines filtering options.</param>
        /// <returns>A list of EmployeeLoansResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeLoansResult> EmployeeLoans(EmployeeLoansFilter filterInstance, Db db)
        {
            return db.EmployeeLoans(filterInstance.EmployeeId, filterInstance.LoanStatusId);
        }

        /// <summary>
        /// Needs summary!
        /// </summary>
        /// <param name="_employeeId"></param>
        /// <param name="_loanStatusId"></param>
        /// <returns>An instance of EmployeeLoansResult or null.</returns>
        public static EmployeeLoansResult EmployeeLoansFirstOrDefault([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@LoanStatusId")] Nullable<int> _loanStatusId)
        {
            Db db = new Db(DbServices.ConnectionString);
            return db.EmployeeLoansFirstOrDefault(_employeeId, _loanStatusId);
        }

        /// <summary>
        /// Needs summary!
        /// </summary>
        /// <param name="_employeeId"></param>
        /// <param name="_loanStatusId"></param>
        /// <returns>An instance of EmployeeLoansResult or null.</returns>
        public static EmployeeLoansResult EmployeeLoansFirstOrDefault([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@LoanStatusId")] Nullable<int> _loanStatusId, Db db)
        {
            return db.EmployeeLoansFirstOrDefault(_employeeId, _loanStatusId);
        }

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of EmployeeLoansFilter that defines filtering options.</param>
        /// <returns>An instance of EmployeeLoansResult or null.</returns>
		public static EmployeeLoansResult EmployeeLoansFirstOrDefault(EmployeeLoansFilter filterInstance)
        {
            Db db = new Db(DbServices.ConnectionString);
            return db.EmployeeLoansFirstOrDefault(filterInstance.EmployeeId, filterInstance.LoanStatusId);
        }

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of EmployeeLoansFilter that defines filtering options.</param>
        /// <returns>An instance of EmployeeLoansResult or null.</returns>
		public static EmployeeLoansResult EmployeeLoansFirstOrDefault(EmployeeLoansFilter filterInstance, Db db)
        {
            return db.EmployeeLoansFirstOrDefault(filterInstance.EmployeeId, filterInstance.LoanStatusId);
        }

        #endregion

        #region LoanMoveFromEmployeeToEmployee procedure.

        /// <summary>
        /// Needs summary!
        /// </summary>
        /// <param name="_loan"></param>
        /// <param name="_employeeId"></param>
        /// <param name="_loanDecisionId"></param>
        public static void LoanMoveFromEmployeeToEmployee([Parameter(Name = "@Loan")] Nullable<int> _loan, [Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@LoanDecisionId")] Nullable<int> _loanDecisionId)
        {
            Db db = new Db(DbServices.ConnectionString);
            db.LoanMoveFromEmployeeToEmployee(_loan, _employeeId, _loanDecisionId);
        }

        /// <summary>
        /// Needs summary!
        /// </summary>
        /// <param name="_loan"></param>
        /// <param name="_employeeId"></param>
        /// <param name="_loanDecisionId"></param>
        public static void LoanMoveFromEmployeeToEmployee([Parameter(Name = "@Loan")] Nullable<int> _loan, [Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@LoanDecisionId")] Nullable<int> _loanDecisionId, Db db)
        {
            db.LoanMoveFromEmployeeToEmployee(_loan, _employeeId, _loanDecisionId);
        }

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of LoanMoveFromEmployeeToEmployeeFilter that defines filtering options.</param>
		public static void LoanMoveFromEmployeeToEmployee(LoanMoveFromEmployeeToEmployeeFilter filterInstance)
        {
            Db db = new Db(DbServices.ConnectionString);
            db.LoanMoveFromEmployeeToEmployee(filterInstance.Loan, filterInstance.EmployeeId, filterInstance.LoanDecisionId);
        }

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of LoanMoveFromEmployeeToEmployeeFilter that defines filtering options.</param>
		public static void LoanMoveFromEmployeeToEmployee(LoanMoveFromEmployeeToEmployeeFilter filterInstance, Db db)
        {
            db.LoanMoveFromEmployeeToEmployee(filterInstance.Loan, filterInstance.EmployeeId, filterInstance.LoanDecisionId);
        }
        #endregion

        #region LoanMoveFromEmployeeToGuarantor procedure.

        /// <summary>
        /// Needs summary!
        /// </summary>
        /// <param name="_loan"></param>
        /// <param name="_employeeId"></param>
        /// <param name="_loanDecisionId"></param>
        /// <param name="_numberOfGuarantors"></param>
        public static void LoanMoveFromEmployeeToGuarantor([Parameter(Name = "@Loan")] Nullable<int> _loan, [Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@LoanDecisionId")] Nullable<int> _loanDecisionId, [Parameter(Name = "@NumberOfGuarantors")] Nullable<int> _numberOfGuarantors)
        {
            Db db = new Db(DbServices.ConnectionString);
            db.LoanMoveFromEmployeeToGuarantor(_loan, _employeeId, _loanDecisionId, _numberOfGuarantors);
        }

        /// <summary>
        /// Needs summary!
        /// </summary>
        /// <param name="_loan"></param>
        /// <param name="_employeeId"></param>
        /// <param name="_loanDecisionId"></param>
        /// <param name="_numberOfGuarantors"></param>
        public static void LoanMoveFromEmployeeToGuarantor([Parameter(Name = "@Loan")] Nullable<int> _loan, [Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@LoanDecisionId")] Nullable<int> _loanDecisionId, [Parameter(Name = "@NumberOfGuarantors")] Nullable<int> _numberOfGuarantors, Db db)
        {
            db.LoanMoveFromEmployeeToGuarantor(_loan, _employeeId, _loanDecisionId, _numberOfGuarantors);
        }

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of LoanMoveFromEmployeeToGuarantorFilter that defines filtering options.</param>
		public static void LoanMoveFromEmployeeToGuarantor(LoanMoveFromEmployeeToGuarantorFilter filterInstance)
        {
            Db db = new Db(DbServices.ConnectionString);
            db.LoanMoveFromEmployeeToGuarantor(filterInstance.Loan, filterInstance.EmployeeId, filterInstance.LoanDecisionId, filterInstance.NumberOfGuarantors);
        }

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of LoanMoveFromEmployeeToGuarantorFilter that defines filtering options.</param>
		public static void LoanMoveFromEmployeeToGuarantor(LoanMoveFromEmployeeToGuarantorFilter filterInstance, Db db)
        {
            db.LoanMoveFromEmployeeToGuarantor(filterInstance.Loan, filterInstance.EmployeeId, filterInstance.LoanDecisionId, filterInstance.NumberOfGuarantors);
        }
        #endregion

        #region EmployeeMonthPayments procedure.


        /// <summary>
        /// Needs summary!
        /// </summary>
        /// <param name="_month"></param>
        /// <param name="_employee"></param>
        /// <returns>A list of EmployeeMonthPaymentsResult instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<EmployeeMonthPaymentsResult> EmployeeMonthPayments([Parameter(Name = "@Month")] Nullable<DateTime> _month, [Parameter(Name = "@Employee")] Nullable<int> _employee)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.EmployeeMonthPayments(_month, _employee);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_month"></param>
		/// <param name="_employee"></param>
		/// <returns>A list of EmployeeMonthPaymentsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeMonthPaymentsResult> EmployeeMonthPayments([Parameter(Name = "@Month")] Nullable<DateTime> _month, [Parameter(Name = "@Employee")] Nullable<int> _employee, Db db)
		{
			return db.EmployeeMonthPayments(_month, _employee);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of EmployeeMonthPaymentsFilter that defines filtering options.</param>
        /// <returns>A list of EmployeeMonthPaymentsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeMonthPaymentsResult> EmployeeMonthPayments(EmployeeMonthPaymentsFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.EmployeeMonthPayments(filterInstance.Month, filterInstance.Employee);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of EmployeeMonthPaymentsFilter that defines filtering options.</param>
        /// <returns>A list of EmployeeMonthPaymentsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeMonthPaymentsResult> EmployeeMonthPayments(EmployeeMonthPaymentsFilter filterInstance, Db db)
		{
			return db.EmployeeMonthPayments(filterInstance.Month, filterInstance.Employee);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_month"></param>
		/// <param name="_employee"></param>
		/// <returns>An instance of EmployeeMonthPaymentsResult or null.</returns>
		public static EmployeeMonthPaymentsResult EmployeeMonthPaymentsFirstOrDefault([Parameter(Name = "@Month")] Nullable<DateTime> _month, [Parameter(Name = "@Employee")] Nullable<int> _employee)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.EmployeeMonthPaymentsFirstOrDefault(_month, _employee);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_month"></param>
		/// <param name="_employee"></param>
		/// <returns>An instance of EmployeeMonthPaymentsResult or null.</returns>
		public static EmployeeMonthPaymentsResult EmployeeMonthPaymentsFirstOrDefault([Parameter(Name = "@Month")] Nullable<DateTime> _month, [Parameter(Name = "@Employee")] Nullable<int> _employee, Db db)
		{
			return db.EmployeeMonthPaymentsFirstOrDefault(_month, _employee);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of EmployeeMonthPaymentsFilter that defines filtering options.</param>
        /// <returns>An instance of EmployeeMonthPaymentsResult or null.</returns>
		public static EmployeeMonthPaymentsResult EmployeeMonthPaymentsFirstOrDefault(EmployeeMonthPaymentsFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.EmployeeMonthPaymentsFirstOrDefault(filterInstance.Month, filterInstance.Employee);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of EmployeeMonthPaymentsFilter that defines filtering options.</param>
        /// <returns>An instance of EmployeeMonthPaymentsResult or null.</returns>
		public static EmployeeMonthPaymentsResult EmployeeMonthPaymentsFirstOrDefault(EmployeeMonthPaymentsFilter filterInstance, Db db)
		{
			return db.EmployeeMonthPaymentsFirstOrDefault(filterInstance.Month, filterInstance.Employee);
		}

		#endregion

		#region EmployeeMonthSubscriptions procedure.


		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_month"></param>
		/// <param name="_employee"></param>
		/// <returns>A list of EmployeeMonthSubscriptionsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeMonthSubscriptionsResult> EmployeeMonthSubscriptions([Parameter(Name = "@Month")] Nullable<DateTime> _month, [Parameter(Name = "@Employee")] Nullable<int> _employee)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.EmployeeMonthSubscriptions(_month, _employee);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_month"></param>
		/// <param name="_employee"></param>
		/// <returns>A list of EmployeeMonthSubscriptionsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeMonthSubscriptionsResult> EmployeeMonthSubscriptions([Parameter(Name = "@Month")] Nullable<DateTime> _month, [Parameter(Name = "@Employee")] Nullable<int> _employee, Db db)
		{
			return db.EmployeeMonthSubscriptions(_month, _employee);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of EmployeeMonthSubscriptionsFilter that defines filtering options.</param>
        /// <returns>A list of EmployeeMonthSubscriptionsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeMonthSubscriptionsResult> EmployeeMonthSubscriptions(EmployeeMonthSubscriptionsFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.EmployeeMonthSubscriptions(filterInstance.Month, filterInstance.Employee);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of EmployeeMonthSubscriptionsFilter that defines filtering options.</param>
        /// <returns>A list of EmployeeMonthSubscriptionsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeMonthSubscriptionsResult> EmployeeMonthSubscriptions(EmployeeMonthSubscriptionsFilter filterInstance, Db db)
		{
			return db.EmployeeMonthSubscriptions(filterInstance.Month, filterInstance.Employee);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_month"></param>
		/// <param name="_employee"></param>
		/// <returns>An instance of EmployeeMonthSubscriptionsResult or null.</returns>
		public static EmployeeMonthSubscriptionsResult EmployeeMonthSubscriptionsFirstOrDefault([Parameter(Name = "@Month")] Nullable<DateTime> _month, [Parameter(Name = "@Employee")] Nullable<int> _employee)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.EmployeeMonthSubscriptionsFirstOrDefault(_month, _employee);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_month"></param>
		/// <param name="_employee"></param>
		/// <returns>An instance of EmployeeMonthSubscriptionsResult or null.</returns>
		public static EmployeeMonthSubscriptionsResult EmployeeMonthSubscriptionsFirstOrDefault([Parameter(Name = "@Month")] Nullable<DateTime> _month, [Parameter(Name = "@Employee")] Nullable<int> _employee, Db db)
		{
			return db.EmployeeMonthSubscriptionsFirstOrDefault(_month, _employee);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of EmployeeMonthSubscriptionsFilter that defines filtering options.</param>
        /// <returns>An instance of EmployeeMonthSubscriptionsResult or null.</returns>
		public static EmployeeMonthSubscriptionsResult EmployeeMonthSubscriptionsFirstOrDefault(EmployeeMonthSubscriptionsFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.EmployeeMonthSubscriptionsFirstOrDefault(filterInstance.Month, filterInstance.Employee);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of EmployeeMonthSubscriptionsFilter that defines filtering options.</param>
        /// <returns>An instance of EmployeeMonthSubscriptionsResult or null.</returns>
		public static EmployeeMonthSubscriptionsResult EmployeeMonthSubscriptionsFirstOrDefault(EmployeeMonthSubscriptionsFilter filterInstance, Db db)
		{
			return db.EmployeeMonthSubscriptionsFirstOrDefault(filterInstance.Month, filterInstance.Employee);
		}

		#endregion

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
		/// <param name="_employeeId"></param>
		/// <param name="_productTypeId"></param>
		/// <param name="_amount"></param>
		/// <param name="_period"></param>
		/// <returns>A list of EmployeeProductCalculatorResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeProductCalculatorResult> EmployeeProductCalculator([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@ProductTypeId")] Nullable<short> _productTypeId, [Parameter(Name = "@Amount")] Nullable<decimal> _amount, [Parameter(Name = "@Period")] Nullable<short> _period, Db db)
		{
			return db.EmployeeProductCalculator(_employeeId, _productTypeId, _amount, _period);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of EmployeeProductCalculatorFilter that defines filtering options.</param>
        /// <returns>A list of EmployeeProductCalculatorResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<EmployeeProductCalculatorResult> EmployeeProductCalculator(EmployeeProductCalculatorFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.EmployeeProductCalculator(filterInstance.EmployeeId, filterInstance.ProductTypeId, filterInstance.Amount, filterInstance.Period);
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

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_productTypeId"></param>
		/// <param name="_amount"></param>
		/// <param name="_period"></param>
		/// <returns>An instance of EmployeeProductCalculatorResult or null.</returns>
		public static EmployeeProductCalculatorResult EmployeeProductCalculatorFirstOrDefault([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@ProductTypeId")] Nullable<short> _productTypeId, [Parameter(Name = "@Amount")] Nullable<decimal> _amount, [Parameter(Name = "@Period")] Nullable<short> _period)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.EmployeeProductCalculatorFirstOrDefault(_employeeId, _productTypeId, _amount, _period);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_productTypeId"></param>
		/// <param name="_amount"></param>
		/// <param name="_period"></param>
		/// <returns>An instance of EmployeeProductCalculatorResult or null.</returns>
		public static EmployeeProductCalculatorResult EmployeeProductCalculatorFirstOrDefault([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@ProductTypeId")] Nullable<short> _productTypeId, [Parameter(Name = "@Amount")] Nullable<decimal> _amount, [Parameter(Name = "@Period")] Nullable<short> _period, Db db)
		{
			return db.EmployeeProductCalculatorFirstOrDefault(_employeeId, _productTypeId, _amount, _period);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of EmployeeProductCalculatorFilter that defines filtering options.</param>
        /// <returns>An instance of EmployeeProductCalculatorResult or null.</returns>
		public static EmployeeProductCalculatorResult EmployeeProductCalculatorFirstOrDefault(EmployeeProductCalculatorFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.EmployeeProductCalculatorFirstOrDefault(filterInstance.EmployeeId, filterInstance.ProductTypeId, filterInstance.Amount, filterInstance.Period);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of EmployeeProductCalculatorFilter that defines filtering options.</param>
        /// <returns>An instance of EmployeeProductCalculatorResult or null.</returns>
		public static EmployeeProductCalculatorResult EmployeeProductCalculatorFirstOrDefault(EmployeeProductCalculatorFilter filterInstance, Db db)
		{
			return db.EmployeeProductCalculatorFirstOrDefault(filterInstance.EmployeeId, filterInstance.ProductTypeId, filterInstance.Amount, filterInstance.Period);
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
		/// <param name="_productTypeId"></param>
		/// <param name="_employeeId"></param>
		/// <returns>A list of GetAvailabilityCeilingByProductTypeId_EmployeeIdResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetAvailabilityCeilingByProductTypeId_EmployeeIdResult> GetAvailabilityCeilingByProductTypeId_EmployeeId([Parameter(Name = "@ProductTypeId")] Nullable<short> _productTypeId, [Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, Db db)
		{
			return db.GetAvailabilityCeilingByProductTypeId_EmployeeId(_productTypeId, _employeeId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetAvailabilityCeilingByProductTypeId_EmployeeIdFilter that defines filtering options.</param>
        /// <returns>A list of GetAvailabilityCeilingByProductTypeId_EmployeeIdResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetAvailabilityCeilingByProductTypeId_EmployeeIdResult> GetAvailabilityCeilingByProductTypeId_EmployeeId(GetAvailabilityCeilingByProductTypeId_EmployeeIdFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetAvailabilityCeilingByProductTypeId_EmployeeId(filterInstance.ProductTypeId, filterInstance.EmployeeId);
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

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_productTypeId"></param>
		/// <param name="_employeeId"></param>
		/// <returns>An instance of GetAvailabilityCeilingByProductTypeId_EmployeeIdResult or null.</returns>
		public static GetAvailabilityCeilingByProductTypeId_EmployeeIdResult GetAvailabilityCeilingByProductTypeId_EmployeeIdFirstOrDefault([Parameter(Name = "@ProductTypeId")] Nullable<short> _productTypeId, [Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetAvailabilityCeilingByProductTypeId_EmployeeIdFirstOrDefault(_productTypeId, _employeeId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_productTypeId"></param>
		/// <param name="_employeeId"></param>
		/// <returns>An instance of GetAvailabilityCeilingByProductTypeId_EmployeeIdResult or null.</returns>
		public static GetAvailabilityCeilingByProductTypeId_EmployeeIdResult GetAvailabilityCeilingByProductTypeId_EmployeeIdFirstOrDefault([Parameter(Name = "@ProductTypeId")] Nullable<short> _productTypeId, [Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, Db db)
		{
			return db.GetAvailabilityCeilingByProductTypeId_EmployeeIdFirstOrDefault(_productTypeId, _employeeId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetAvailabilityCeilingByProductTypeId_EmployeeIdFilter that defines filtering options.</param>
        /// <returns>An instance of GetAvailabilityCeilingByProductTypeId_EmployeeIdResult or null.</returns>
		public static GetAvailabilityCeilingByProductTypeId_EmployeeIdResult GetAvailabilityCeilingByProductTypeId_EmployeeIdFirstOrDefault(GetAvailabilityCeilingByProductTypeId_EmployeeIdFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetAvailabilityCeilingByProductTypeId_EmployeeIdFirstOrDefault(filterInstance.ProductTypeId, filterInstance.EmployeeId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetAvailabilityCeilingByProductTypeId_EmployeeIdFilter that defines filtering options.</param>
        /// <returns>An instance of GetAvailabilityCeilingByProductTypeId_EmployeeIdResult or null.</returns>
		public static GetAvailabilityCeilingByProductTypeId_EmployeeIdResult GetAvailabilityCeilingByProductTypeId_EmployeeIdFirstOrDefault(GetAvailabilityCeilingByProductTypeId_EmployeeIdFilter filterInstance, Db db)
		{
			return db.GetAvailabilityCeilingByProductTypeId_EmployeeIdFirstOrDefault(filterInstance.ProductTypeId, filterInstance.EmployeeId);
		}

		#endregion

		#region GetDebts procedure.


		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_date"></param>
		/// <returns>A list of GetDebtsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetDebtsResult> GetDebts([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetDebts(_employeeId, _date);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_date"></param>
		/// <returns>A list of GetDebtsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetDebtsResult> GetDebts([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date, Db db)
		{
			return db.GetDebts(_employeeId, _date);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetDebtsFilter that defines filtering options.</param>
        /// <returns>A list of GetDebtsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetDebtsResult> GetDebts(GetDebtsFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetDebts(filterInstance.EmployeeId, filterInstance.Date);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetDebtsFilter that defines filtering options.</param>
        /// <returns>A list of GetDebtsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetDebtsResult> GetDebts(GetDebtsFilter filterInstance, Db db)
		{
			return db.GetDebts(filterInstance.EmployeeId, filterInstance.Date);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_date"></param>
		/// <returns>An instance of GetDebtsResult or null.</returns>
		public static GetDebtsResult GetDebtsFirstOrDefault([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetDebtsFirstOrDefault(_employeeId, _date);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_date"></param>
		/// <returns>An instance of GetDebtsResult or null.</returns>
		public static GetDebtsResult GetDebtsFirstOrDefault([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date, Db db)
		{
			return db.GetDebtsFirstOrDefault(_employeeId, _date);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetDebtsFilter that defines filtering options.</param>
        /// <returns>An instance of GetDebtsResult or null.</returns>
		public static GetDebtsResult GetDebtsFirstOrDefault(GetDebtsFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetDebtsFirstOrDefault(filterInstance.EmployeeId, filterInstance.Date);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetDebtsFilter that defines filtering options.</param>
        /// <returns>An instance of GetDebtsResult or null.</returns>
		public static GetDebtsResult GetDebtsFirstOrDefault(GetDebtsFilter filterInstance, Db db)
		{
			return db.GetDebtsFirstOrDefault(filterInstance.EmployeeId, filterInstance.Date);
		}

		#endregion

		#region GetDebtScalar procedure.

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_date"></param>
		/// <param name="_employeeId"></param>
		public static decimal GetDebtScalar([Parameter(Name = "@Date")] Nullable<DateTime> _date, [Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId)
		{
			Db db = new Db(DbServices.ConnectionString);
			 return db.GetDebtScalar(_date, _employeeId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_date"></param>
		/// <param name="_employeeId"></param>
		public static decimal GetDebtScalar([Parameter(Name = "@Date")] Nullable<DateTime> _date, [Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, Db db)
		{
			return db.GetDebtScalar(_date, _employeeId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetDebtScalarFilter that defines filtering options.</param>
		public static decimal GetDebtScalar(GetDebtScalarFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetDebtScalar(filterInstance.Date, filterInstance.EmployeeId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetDebtScalarFilter that defines filtering options.</param>
		public static decimal GetDebtScalar(GetDebtScalarFilter filterInstance, Db db)
		{
			return db.GetDebtScalar(filterInstance.Date, filterInstance.EmployeeId);
		}
		#endregion

		#region GetDebtSolvency procedure.


		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_productId"></param>
		/// <returns>A list of GetDebtSolvencyResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetDebtSolvencyResult> GetDebtSolvency([Parameter(Name = "@ProductId")] Nullable<int> _productId)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetDebtSolvency(_productId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_productId"></param>
		/// <returns>A list of GetDebtSolvencyResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetDebtSolvencyResult> GetDebtSolvency([Parameter(Name = "@ProductId")] Nullable<int> _productId, Db db)
		{
			return db.GetDebtSolvency(_productId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetDebtSolvencyFilter that defines filtering options.</param>
        /// <returns>A list of GetDebtSolvencyResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetDebtSolvencyResult> GetDebtSolvency(GetDebtSolvencyFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetDebtSolvency(filterInstance.ProductId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetDebtSolvencyFilter that defines filtering options.</param>
        /// <returns>A list of GetDebtSolvencyResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetDebtSolvencyResult> GetDebtSolvency(GetDebtSolvencyFilter filterInstance, Db db)
		{
			return db.GetDebtSolvency(filterInstance.ProductId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_productId"></param>
		/// <returns>An instance of GetDebtSolvencyResult or null.</returns>
		public static GetDebtSolvencyResult GetDebtSolvencyFirstOrDefault([Parameter(Name = "@ProductId")] Nullable<int> _productId)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetDebtSolvencyFirstOrDefault(_productId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_productId"></param>
		/// <returns>An instance of GetDebtSolvencyResult or null.</returns>
		public static GetDebtSolvencyResult GetDebtSolvencyFirstOrDefault([Parameter(Name = "@ProductId")] Nullable<int> _productId, Db db)
		{
			return db.GetDebtSolvencyFirstOrDefault(_productId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetDebtSolvencyFilter that defines filtering options.</param>
        /// <returns>An instance of GetDebtSolvencyResult or null.</returns>
		public static GetDebtSolvencyResult GetDebtSolvencyFirstOrDefault(GetDebtSolvencyFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetDebtSolvencyFirstOrDefault(filterInstance.ProductId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetDebtSolvencyFilter that defines filtering options.</param>
        /// <returns>An instance of GetDebtSolvencyResult or null.</returns>
		public static GetDebtSolvencyResult GetDebtSolvencyFirstOrDefault(GetDebtSolvencyFilter filterInstance, Db db)
		{
			return db.GetDebtSolvencyFirstOrDefault(filterInstance.ProductId);
		}

		#endregion

		#region GetDueProfit procedure.

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_amount"></param>
		/// <param name="_period"></param>
		/// <param name="_rate"></param>
		public static decimal GetDueProfit([Parameter(Name = "@Amount")] Nullable<decimal> _amount, [Parameter(Name = "@Period")] Nullable<short> _period, [Parameter(Name = "@Rate")] Nullable<double> _rate)
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
		public static decimal GetDueProfit([Parameter(Name = "@Amount")] Nullable<decimal> _amount, [Parameter(Name = "@Period")] Nullable<short> _period, [Parameter(Name = "@Rate")] Nullable<double> _rate, Db db)
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

		#region GetEmployeeDebts procedure.


		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_date"></param>
		/// <returns>A list of GetEmployeeDebtsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetEmployeeDebtsResult> GetEmployeeDebts([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetEmployeeDebts(_employeeId, _date);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_date"></param>
		/// <returns>A list of GetEmployeeDebtsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetEmployeeDebtsResult> GetEmployeeDebts([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date, Db db)
		{
			return db.GetEmployeeDebts(_employeeId, _date);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetEmployeeDebtsFilter that defines filtering options.</param>
        /// <returns>A list of GetEmployeeDebtsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetEmployeeDebtsResult> GetEmployeeDebts(GetEmployeeDebtsFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetEmployeeDebts(filterInstance.EmployeeId, filterInstance.Date);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetEmployeeDebtsFilter that defines filtering options.</param>
        /// <returns>A list of GetEmployeeDebtsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetEmployeeDebtsResult> GetEmployeeDebts(GetEmployeeDebtsFilter filterInstance, Db db)
		{
			return db.GetEmployeeDebts(filterInstance.EmployeeId, filterInstance.Date);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_date"></param>
		/// <returns>An instance of GetEmployeeDebtsResult or null.</returns>
		public static GetEmployeeDebtsResult GetEmployeeDebtsFirstOrDefault([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetEmployeeDebtsFirstOrDefault(_employeeId, _date);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_date"></param>
		/// <returns>An instance of GetEmployeeDebtsResult or null.</returns>
		public static GetEmployeeDebtsResult GetEmployeeDebtsFirstOrDefault([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date, Db db)
		{
			return db.GetEmployeeDebtsFirstOrDefault(_employeeId, _date);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetEmployeeDebtsFilter that defines filtering options.</param>
        /// <returns>An instance of GetEmployeeDebtsResult or null.</returns>
		public static GetEmployeeDebtsResult GetEmployeeDebtsFirstOrDefault(GetEmployeeDebtsFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetEmployeeDebtsFirstOrDefault(filterInstance.EmployeeId, filterInstance.Date);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetEmployeeDebtsFilter that defines filtering options.</param>
        /// <returns>An instance of GetEmployeeDebtsResult or null.</returns>
		public static GetEmployeeDebtsResult GetEmployeeDebtsFirstOrDefault(GetEmployeeDebtsFilter filterInstance, Db db)
		{
			return db.GetEmployeeDebtsFirstOrDefault(filterInstance.EmployeeId, filterInstance.Date);
		}

		#endregion

		#region GetEmployeeSolvency procedure.


		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_date"></param>
		/// <param name="_amount"></param>
		/// <param name="_installment"></param>
		/// <param name="_grossSalary"></param>
		/// <param name="_netSalary"></param>
		/// <returns>A list of GetEmployeeSolvencyResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetEmployeeSolvencyResult> GetEmployeeSolvency([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date, [Parameter(Name = "@Amount")] Nullable<decimal> _amount, [Parameter(Name = "@Installment")] Nullable<decimal> _installment, [Parameter(Name = "@GrossSalary")] Nullable<decimal> _grossSalary, [Parameter(Name = "@NetSalary")] Nullable<decimal> _netSalary)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetEmployeeSolvency(_employeeId, _date, _amount, _installment, _grossSalary, _netSalary);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_date"></param>
		/// <param name="_amount"></param>
		/// <param name="_installment"></param>
		/// <param name="_grossSalary"></param>
		/// <param name="_netSalary"></param>
		/// <returns>A list of GetEmployeeSolvencyResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetEmployeeSolvencyResult> GetEmployeeSolvency([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date, [Parameter(Name = "@Amount")] Nullable<decimal> _amount, [Parameter(Name = "@Installment")] Nullable<decimal> _installment, [Parameter(Name = "@GrossSalary")] Nullable<decimal> _grossSalary, [Parameter(Name = "@NetSalary")] Nullable<decimal> _netSalary, Db db)
		{
			return db.GetEmployeeSolvency(_employeeId, _date, _amount, _installment, _grossSalary, _netSalary);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetEmployeeSolvencyFilter that defines filtering options.</param>
        /// <returns>A list of GetEmployeeSolvencyResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetEmployeeSolvencyResult> GetEmployeeSolvency(GetEmployeeSolvencyFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetEmployeeSolvency(filterInstance.EmployeeId, filterInstance.Date, filterInstance.Amount, filterInstance.Installment, filterInstance.GrossSalary, filterInstance.NetSalary);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetEmployeeSolvencyFilter that defines filtering options.</param>
        /// <returns>A list of GetEmployeeSolvencyResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetEmployeeSolvencyResult> GetEmployeeSolvency(GetEmployeeSolvencyFilter filterInstance, Db db)
		{
			return db.GetEmployeeSolvency(filterInstance.EmployeeId, filterInstance.Date, filterInstance.Amount, filterInstance.Installment, filterInstance.GrossSalary, filterInstance.NetSalary);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_date"></param>
		/// <param name="_amount"></param>
		/// <param name="_installment"></param>
		/// <param name="_grossSalary"></param>
		/// <param name="_netSalary"></param>
		/// <returns>An instance of GetEmployeeSolvencyResult or null.</returns>
		public static GetEmployeeSolvencyResult GetEmployeeSolvencyFirstOrDefault([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date, [Parameter(Name = "@Amount")] Nullable<decimal> _amount, [Parameter(Name = "@Installment")] Nullable<decimal> _installment, [Parameter(Name = "@GrossSalary")] Nullable<decimal> _grossSalary, [Parameter(Name = "@NetSalary")] Nullable<decimal> _netSalary)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetEmployeeSolvencyFirstOrDefault(_employeeId, _date, _amount, _installment, _grossSalary, _netSalary);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_date"></param>
		/// <param name="_amount"></param>
		/// <param name="_installment"></param>
		/// <param name="_grossSalary"></param>
		/// <param name="_netSalary"></param>
		/// <returns>An instance of GetEmployeeSolvencyResult or null.</returns>
		public static GetEmployeeSolvencyResult GetEmployeeSolvencyFirstOrDefault([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date, [Parameter(Name = "@Amount")] Nullable<decimal> _amount, [Parameter(Name = "@Installment")] Nullable<decimal> _installment, [Parameter(Name = "@GrossSalary")] Nullable<decimal> _grossSalary, [Parameter(Name = "@NetSalary")] Nullable<decimal> _netSalary, Db db)
		{
			return db.GetEmployeeSolvencyFirstOrDefault(_employeeId, _date, _amount, _installment, _grossSalary, _netSalary);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetEmployeeSolvencyFilter that defines filtering options.</param>
        /// <returns>An instance of GetEmployeeSolvencyResult or null.</returns>
		public static GetEmployeeSolvencyResult GetEmployeeSolvencyFirstOrDefault(GetEmployeeSolvencyFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetEmployeeSolvencyFirstOrDefault(filterInstance.EmployeeId, filterInstance.Date, filterInstance.Amount, filterInstance.Installment, filterInstance.GrossSalary, filterInstance.NetSalary);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetEmployeeSolvencyFilter that defines filtering options.</param>
        /// <returns>An instance of GetEmployeeSolvencyResult or null.</returns>
		public static GetEmployeeSolvencyResult GetEmployeeSolvencyFirstOrDefault(GetEmployeeSolvencyFilter filterInstance, Db db)
		{
			return db.GetEmployeeSolvencyFirstOrDefault(filterInstance.EmployeeId, filterInstance.Date, filterInstance.Amount, filterInstance.Installment, filterInstance.GrossSalary, filterInstance.NetSalary);
		}

		#endregion

		#region GetEmployeeSumDebts procedure.


		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_date"></param>
		/// <returns>A list of GetEmployeeSumDebtsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetEmployeeSumDebtsResult> GetEmployeeSumDebts([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetEmployeeSumDebts(_employeeId, _date);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_date"></param>
		/// <returns>A list of GetEmployeeSumDebtsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetEmployeeSumDebtsResult> GetEmployeeSumDebts([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date, Db db)
		{
			return db.GetEmployeeSumDebts(_employeeId, _date);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetEmployeeSumDebtsFilter that defines filtering options.</param>
        /// <returns>A list of GetEmployeeSumDebtsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetEmployeeSumDebtsResult> GetEmployeeSumDebts(GetEmployeeSumDebtsFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetEmployeeSumDebts(filterInstance.EmployeeId, filterInstance.Date);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetEmployeeSumDebtsFilter that defines filtering options.</param>
        /// <returns>A list of GetEmployeeSumDebtsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetEmployeeSumDebtsResult> GetEmployeeSumDebts(GetEmployeeSumDebtsFilter filterInstance, Db db)
		{
			return db.GetEmployeeSumDebts(filterInstance.EmployeeId, filterInstance.Date);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_date"></param>
		/// <returns>An instance of GetEmployeeSumDebtsResult or null.</returns>
		public static GetEmployeeSumDebtsResult GetEmployeeSumDebtsFirstOrDefault([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetEmployeeSumDebtsFirstOrDefault(_employeeId, _date);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_date"></param>
		/// <returns>An instance of GetEmployeeSumDebtsResult or null.</returns>
		public static GetEmployeeSumDebtsResult GetEmployeeSumDebtsFirstOrDefault([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date, Db db)
		{
			return db.GetEmployeeSumDebtsFirstOrDefault(_employeeId, _date);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetEmployeeSumDebtsFilter that defines filtering options.</param>
        /// <returns>An instance of GetEmployeeSumDebtsResult or null.</returns>
		public static GetEmployeeSumDebtsResult GetEmployeeSumDebtsFirstOrDefault(GetEmployeeSumDebtsFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetEmployeeSumDebtsFirstOrDefault(filterInstance.EmployeeId, filterInstance.Date);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetEmployeeSumDebtsFilter that defines filtering options.</param>
        /// <returns>An instance of GetEmployeeSumDebtsResult or null.</returns>
		public static GetEmployeeSumDebtsResult GetEmployeeSumDebtsFirstOrDefault(GetEmployeeSumDebtsFilter filterInstance, Db db)
		{
			return db.GetEmployeeSumDebtsFirstOrDefault(filterInstance.EmployeeId, filterInstance.Date);
		}

		#endregion

		#region GetEmployeeWarrants procedure.


		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_date"></param>
		/// <returns>A list of GetEmployeeWarrantsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetEmployeeWarrantsResult> GetEmployeeWarrants([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetEmployeeWarrants(_employeeId, _date);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_date"></param>
		/// <returns>A list of GetEmployeeWarrantsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetEmployeeWarrantsResult> GetEmployeeWarrants([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date, Db db)
		{
			return db.GetEmployeeWarrants(_employeeId, _date);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetEmployeeWarrantsFilter that defines filtering options.</param>
        /// <returns>A list of GetEmployeeWarrantsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetEmployeeWarrantsResult> GetEmployeeWarrants(GetEmployeeWarrantsFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetEmployeeWarrants(filterInstance.EmployeeId, filterInstance.Date);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetEmployeeWarrantsFilter that defines filtering options.</param>
        /// <returns>A list of GetEmployeeWarrantsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetEmployeeWarrantsResult> GetEmployeeWarrants(GetEmployeeWarrantsFilter filterInstance, Db db)
		{
			return db.GetEmployeeWarrants(filterInstance.EmployeeId, filterInstance.Date);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_date"></param>
		/// <returns>An instance of GetEmployeeWarrantsResult or null.</returns>
		public static GetEmployeeWarrantsResult GetEmployeeWarrantsFirstOrDefault([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetEmployeeWarrantsFirstOrDefault(_employeeId, _date);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_date"></param>
		/// <returns>An instance of GetEmployeeWarrantsResult or null.</returns>
		public static GetEmployeeWarrantsResult GetEmployeeWarrantsFirstOrDefault([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date, Db db)
		{
			return db.GetEmployeeWarrantsFirstOrDefault(_employeeId, _date);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetEmployeeWarrantsFilter that defines filtering options.</param>
        /// <returns>An instance of GetEmployeeWarrantsResult or null.</returns>
		public static GetEmployeeWarrantsResult GetEmployeeWarrantsFirstOrDefault(GetEmployeeWarrantsFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetEmployeeWarrantsFirstOrDefault(filterInstance.EmployeeId, filterInstance.Date);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetEmployeeWarrantsFilter that defines filtering options.</param>
        /// <returns>An instance of GetEmployeeWarrantsResult or null.</returns>
		public static GetEmployeeWarrantsResult GetEmployeeWarrantsFirstOrDefault(GetEmployeeWarrantsFilter filterInstance, Db db)
		{
			return db.GetEmployeeWarrantsFirstOrDefault(filterInstance.EmployeeId, filterInstance.Date);
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

		#region GetInstallmentPaidAmounts procedure.


		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_refundableProductId"></param>
		/// <returns>A list of GetInstallmentPaidAmountsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetInstallmentPaidAmountsResult> GetInstallmentPaidAmounts([Parameter(Name = "@RefundableProductId")] Nullable<int> _refundableProductId)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetInstallmentPaidAmounts(_refundableProductId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_refundableProductId"></param>
		/// <returns>A list of GetInstallmentPaidAmountsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetInstallmentPaidAmountsResult> GetInstallmentPaidAmounts([Parameter(Name = "@RefundableProductId")] Nullable<int> _refundableProductId, Db db)
		{
			return db.GetInstallmentPaidAmounts(_refundableProductId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetInstallmentPaidAmountsFilter that defines filtering options.</param>
        /// <returns>A list of GetInstallmentPaidAmountsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetInstallmentPaidAmountsResult> GetInstallmentPaidAmounts(GetInstallmentPaidAmountsFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetInstallmentPaidAmounts(filterInstance.RefundableProductId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetInstallmentPaidAmountsFilter that defines filtering options.</param>
        /// <returns>A list of GetInstallmentPaidAmountsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetInstallmentPaidAmountsResult> GetInstallmentPaidAmounts(GetInstallmentPaidAmountsFilter filterInstance, Db db)
		{
			return db.GetInstallmentPaidAmounts(filterInstance.RefundableProductId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_refundableProductId"></param>
		/// <returns>An instance of GetInstallmentPaidAmountsResult or null.</returns>
		public static GetInstallmentPaidAmountsResult GetInstallmentPaidAmountsFirstOrDefault([Parameter(Name = "@RefundableProductId")] Nullable<int> _refundableProductId)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetInstallmentPaidAmountsFirstOrDefault(_refundableProductId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_refundableProductId"></param>
		/// <returns>An instance of GetInstallmentPaidAmountsResult or null.</returns>
		public static GetInstallmentPaidAmountsResult GetInstallmentPaidAmountsFirstOrDefault([Parameter(Name = "@RefundableProductId")] Nullable<int> _refundableProductId, Db db)
		{
			return db.GetInstallmentPaidAmountsFirstOrDefault(_refundableProductId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetInstallmentPaidAmountsFilter that defines filtering options.</param>
        /// <returns>An instance of GetInstallmentPaidAmountsResult or null.</returns>
		public static GetInstallmentPaidAmountsResult GetInstallmentPaidAmountsFirstOrDefault(GetInstallmentPaidAmountsFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetInstallmentPaidAmountsFirstOrDefault(filterInstance.RefundableProductId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetInstallmentPaidAmountsFilter that defines filtering options.</param>
        /// <returns>An instance of GetInstallmentPaidAmountsResult or null.</returns>
		public static GetInstallmentPaidAmountsResult GetInstallmentPaidAmountsFirstOrDefault(GetInstallmentPaidAmountsFilter filterInstance, Db db)
		{
			return db.GetInstallmentPaidAmountsFirstOrDefault(filterInstance.RefundableProductId);
		}

		#endregion

		#region GetInstallments procedure.


		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_refundableProductId"></param>
		/// <returns>A list of GetInstallmentsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetInstallmentsResult> GetInstallments([Parameter(Name = "@RefundableProductId")] Nullable<int> _refundableProductId)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetInstallments(_refundableProductId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_refundableProductId"></param>
		/// <returns>A list of GetInstallmentsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetInstallmentsResult> GetInstallments([Parameter(Name = "@RefundableProductId")] Nullable<int> _refundableProductId, Db db)
		{
			return db.GetInstallments(_refundableProductId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetInstallmentsFilter that defines filtering options.</param>
        /// <returns>A list of GetInstallmentsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetInstallmentsResult> GetInstallments(GetInstallmentsFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetInstallments(filterInstance.RefundableProductId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetInstallmentsFilter that defines filtering options.</param>
        /// <returns>A list of GetInstallmentsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetInstallmentsResult> GetInstallments(GetInstallmentsFilter filterInstance, Db db)
		{
			return db.GetInstallments(filterInstance.RefundableProductId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_refundableProductId"></param>
		/// <returns>An instance of GetInstallmentsResult or null.</returns>
		public static GetInstallmentsResult GetInstallmentsFirstOrDefault([Parameter(Name = "@RefundableProductId")] Nullable<int> _refundableProductId)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetInstallmentsFirstOrDefault(_refundableProductId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_refundableProductId"></param>
		/// <returns>An instance of GetInstallmentsResult or null.</returns>
		public static GetInstallmentsResult GetInstallmentsFirstOrDefault([Parameter(Name = "@RefundableProductId")] Nullable<int> _refundableProductId, Db db)
		{
			return db.GetInstallmentsFirstOrDefault(_refundableProductId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetInstallmentsFilter that defines filtering options.</param>
        /// <returns>An instance of GetInstallmentsResult or null.</returns>
		public static GetInstallmentsResult GetInstallmentsFirstOrDefault(GetInstallmentsFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetInstallmentsFirstOrDefault(filterInstance.RefundableProductId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetInstallmentsFilter that defines filtering options.</param>
        /// <returns>An instance of GetInstallmentsResult or null.</returns>
		public static GetInstallmentsResult GetInstallmentsFirstOrDefault(GetInstallmentsFilter filterInstance, Db db)
		{
			return db.GetInstallmentsFirstOrDefault(filterInstance.RefundableProductId);
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

		#region GetRefundableProducts procedure.


		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <returns>A list of GetRefundableProductsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetRefundableProductsResult> GetRefundableProducts([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetRefundableProducts(_employeeId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <returns>A list of GetRefundableProductsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetRefundableProductsResult> GetRefundableProducts([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, Db db)
		{
			return db.GetRefundableProducts(_employeeId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetRefundableProductsFilter that defines filtering options.</param>
        /// <returns>A list of GetRefundableProductsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetRefundableProductsResult> GetRefundableProducts(GetRefundableProductsFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetRefundableProducts(filterInstance.EmployeeId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetRefundableProductsFilter that defines filtering options.</param>
        /// <returns>A list of GetRefundableProductsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetRefundableProductsResult> GetRefundableProducts(GetRefundableProductsFilter filterInstance, Db db)
		{
			return db.GetRefundableProducts(filterInstance.EmployeeId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <returns>An instance of GetRefundableProductsResult or null.</returns>
		public static GetRefundableProductsResult GetRefundableProductsFirstOrDefault([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetRefundableProductsFirstOrDefault(_employeeId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <returns>An instance of GetRefundableProductsResult or null.</returns>
		public static GetRefundableProductsResult GetRefundableProductsFirstOrDefault([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, Db db)
		{
			return db.GetRefundableProductsFirstOrDefault(_employeeId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetRefundableProductsFilter that defines filtering options.</param>
        /// <returns>An instance of GetRefundableProductsResult or null.</returns>
		public static GetRefundableProductsResult GetRefundableProductsFirstOrDefault(GetRefundableProductsFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetRefundableProductsFirstOrDefault(filterInstance.EmployeeId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetRefundableProductsFilter that defines filtering options.</param>
        /// <returns>An instance of GetRefundableProductsResult or null.</returns>
		public static GetRefundableProductsResult GetRefundableProductsFirstOrDefault(GetRefundableProductsFilter filterInstance, Db db)
		{
			return db.GetRefundableProductsFirstOrDefault(filterInstance.EmployeeId);
		}

		#endregion

		#region GetWarrants procedure.


		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_date"></param>
		/// <returns>A list of GetWarrantsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetWarrantsResult> GetWarrants([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetWarrants(_employeeId, _date);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_date"></param>
		/// <returns>A list of GetWarrantsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetWarrantsResult> GetWarrants([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date, Db db)
		{
			return db.GetWarrants(_employeeId, _date);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetWarrantsFilter that defines filtering options.</param>
        /// <returns>A list of GetWarrantsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetWarrantsResult> GetWarrants(GetWarrantsFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetWarrants(filterInstance.EmployeeId, filterInstance.Date);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetWarrantsFilter that defines filtering options.</param>
        /// <returns>A list of GetWarrantsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetWarrantsResult> GetWarrants(GetWarrantsFilter filterInstance, Db db)
		{
			return db.GetWarrants(filterInstance.EmployeeId, filterInstance.Date);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_date"></param>
		/// <returns>An instance of GetWarrantsResult or null.</returns>
		public static GetWarrantsResult GetWarrantsFirstOrDefault([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetWarrantsFirstOrDefault(_employeeId, _date);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_date"></param>
		/// <returns>An instance of GetWarrantsResult or null.</returns>
		public static GetWarrantsResult GetWarrantsFirstOrDefault([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@Date")] Nullable<DateTime> _date, Db db)
		{
			return db.GetWarrantsFirstOrDefault(_employeeId, _date);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetWarrantsFilter that defines filtering options.</param>
        /// <returns>An instance of GetWarrantsResult or null.</returns>
		public static GetWarrantsResult GetWarrantsFirstOrDefault(GetWarrantsFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetWarrantsFirstOrDefault(filterInstance.EmployeeId, filterInstance.Date);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetWarrantsFilter that defines filtering options.</param>
        /// <returns>An instance of GetWarrantsResult or null.</returns>
		public static GetWarrantsResult GetWarrantsFirstOrDefault(GetWarrantsFilter filterInstance, Db db)
		{
			return db.GetWarrantsFirstOrDefault(filterInstance.EmployeeId, filterInstance.Date);
		}

		#endregion

		#region GetWarrantSolvency procedure.


		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_productId"></param>
		/// <returns>A list of GetWarrantSolvencyResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetWarrantSolvencyResult> GetWarrantSolvency([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@ProductId")] Nullable<int> _productId)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetWarrantSolvency(_employeeId, _productId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_productId"></param>
		/// <returns>A list of GetWarrantSolvencyResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetWarrantSolvencyResult> GetWarrantSolvency([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@ProductId")] Nullable<int> _productId, Db db)
		{
			return db.GetWarrantSolvency(_employeeId, _productId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetWarrantSolvencyFilter that defines filtering options.</param>
        /// <returns>A list of GetWarrantSolvencyResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetWarrantSolvencyResult> GetWarrantSolvency(GetWarrantSolvencyFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetWarrantSolvency(filterInstance.EmployeeId, filterInstance.ProductId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetWarrantSolvencyFilter that defines filtering options.</param>
        /// <returns>A list of GetWarrantSolvencyResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<GetWarrantSolvencyResult> GetWarrantSolvency(GetWarrantSolvencyFilter filterInstance, Db db)
		{
			return db.GetWarrantSolvency(filterInstance.EmployeeId, filterInstance.ProductId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_productId"></param>
		/// <returns>An instance of GetWarrantSolvencyResult or null.</returns>
		public static GetWarrantSolvencyResult GetWarrantSolvencyFirstOrDefault([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@ProductId")] Nullable<int> _productId)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetWarrantSolvencyFirstOrDefault(_employeeId, _productId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_employeeId"></param>
		/// <param name="_productId"></param>
		/// <returns>An instance of GetWarrantSolvencyResult or null.</returns>
		public static GetWarrantSolvencyResult GetWarrantSolvencyFirstOrDefault([Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@ProductId")] Nullable<int> _productId, Db db)
		{
			return db.GetWarrantSolvencyFirstOrDefault(_employeeId, _productId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetWarrantSolvencyFilter that defines filtering options.</param>
        /// <returns>An instance of GetWarrantSolvencyResult or null.</returns>
		public static GetWarrantSolvencyResult GetWarrantSolvencyFirstOrDefault(GetWarrantSolvencyFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.GetWarrantSolvencyFirstOrDefault(filterInstance.EmployeeId, filterInstance.ProductId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of GetWarrantSolvencyFilter that defines filtering options.</param>
        /// <returns>An instance of GetWarrantSolvencyResult or null.</returns>
		public static GetWarrantSolvencyResult GetWarrantSolvencyFirstOrDefault(GetWarrantSolvencyFilter filterInstance, Db db)
		{
			return db.GetWarrantSolvencyFirstOrDefault(filterInstance.EmployeeId, filterInstance.ProductId);
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

		#region LoanMoveToEmployee procedure.

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_loan"></param>
		/// <param name="_employeeId"></param>
		/// <param name="_loanDecisionId"></param>
		public static void LoanMoveToEmployee([Parameter(Name = "@Loan")] Nullable<int> _loan, [Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@LoanDecisionId")] Nullable<int> _loanDecisionId)
		{
			Db db = new Db(DbServices.ConnectionString);
			db.LoanMoveToEmployee(_loan, _employeeId, _loanDecisionId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_loan"></param>
		/// <param name="_employeeId"></param>
		/// <param name="_loanDecisionId"></param>
		public static void LoanMoveToEmployee([Parameter(Name = "@Loan")] Nullable<int> _loan, [Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, [Parameter(Name = "@LoanDecisionId")] Nullable<int> _loanDecisionId, Db db)
		{
			db.LoanMoveToEmployee(_loan, _employeeId, _loanDecisionId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of LoanMoveToEmployeeFilter that defines filtering options.</param>
		public static void LoanMoveToEmployee(LoanMoveToEmployeeFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			db.LoanMoveToEmployee(filterInstance.Loan, filterInstance.EmployeeId, filterInstance.LoanDecisionId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of LoanMoveToEmployeeFilter that defines filtering options.</param>
		public static void LoanMoveToEmployee(LoanMoveToEmployeeFilter filterInstance, Db db)
		{
			db.LoanMoveToEmployee(filterInstance.Loan, filterInstance.EmployeeId, filterInstance.LoanDecisionId);
		}
		#endregion

		#region MonthlyBalanceSum procedure.


		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_minMonth"></param>
		/// <param name="_maxMonth"></param>
		/// <param name="_employeeId"></param>
		/// <returns>A list of MonthlyBalanceSumResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<MonthlyBalanceSumResult> MonthlyBalanceSum([Parameter(Name = "@MinMonth")] Nullable<DateTime> _minMonth, [Parameter(Name = "@MaxMonth")] Nullable<DateTime> _maxMonth, [Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.MonthlyBalanceSum(_minMonth, _maxMonth, _employeeId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_minMonth"></param>
		/// <param name="_maxMonth"></param>
		/// <param name="_employeeId"></param>
		/// <returns>A list of MonthlyBalanceSumResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<MonthlyBalanceSumResult> MonthlyBalanceSum([Parameter(Name = "@MinMonth")] Nullable<DateTime> _minMonth, [Parameter(Name = "@MaxMonth")] Nullable<DateTime> _maxMonth, [Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, Db db)
		{
			return db.MonthlyBalanceSum(_minMonth, _maxMonth, _employeeId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of MonthlyBalanceSumFilter that defines filtering options.</param>
        /// <returns>A list of MonthlyBalanceSumResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<MonthlyBalanceSumResult> MonthlyBalanceSum(MonthlyBalanceSumFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.MonthlyBalanceSum(filterInstance.MinMonth, filterInstance.MaxMonth, filterInstance.EmployeeId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of MonthlyBalanceSumFilter that defines filtering options.</param>
        /// <returns>A list of MonthlyBalanceSumResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<MonthlyBalanceSumResult> MonthlyBalanceSum(MonthlyBalanceSumFilter filterInstance, Db db)
		{
			return db.MonthlyBalanceSum(filterInstance.MinMonth, filterInstance.MaxMonth, filterInstance.EmployeeId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_minMonth"></param>
		/// <param name="_maxMonth"></param>
		/// <param name="_employeeId"></param>
		/// <returns>An instance of MonthlyBalanceSumResult or null.</returns>
		public static MonthlyBalanceSumResult MonthlyBalanceSumFirstOrDefault([Parameter(Name = "@MinMonth")] Nullable<DateTime> _minMonth, [Parameter(Name = "@MaxMonth")] Nullable<DateTime> _maxMonth, [Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.MonthlyBalanceSumFirstOrDefault(_minMonth, _maxMonth, _employeeId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_minMonth"></param>
		/// <param name="_maxMonth"></param>
		/// <param name="_employeeId"></param>
		/// <returns>An instance of MonthlyBalanceSumResult or null.</returns>
		public static MonthlyBalanceSumResult MonthlyBalanceSumFirstOrDefault([Parameter(Name = "@MinMonth")] Nullable<DateTime> _minMonth, [Parameter(Name = "@MaxMonth")] Nullable<DateTime> _maxMonth, [Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, Db db)
		{
			return db.MonthlyBalanceSumFirstOrDefault(_minMonth, _maxMonth, _employeeId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of MonthlyBalanceSumFilter that defines filtering options.</param>
        /// <returns>An instance of MonthlyBalanceSumResult or null.</returns>
		public static MonthlyBalanceSumResult MonthlyBalanceSumFirstOrDefault(MonthlyBalanceSumFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.MonthlyBalanceSumFirstOrDefault(filterInstance.MinMonth, filterInstance.MaxMonth, filterInstance.EmployeeId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of MonthlyBalanceSumFilter that defines filtering options.</param>
        /// <returns>An instance of MonthlyBalanceSumResult or null.</returns>
		public static MonthlyBalanceSumResult MonthlyBalanceSumFirstOrDefault(MonthlyBalanceSumFilter filterInstance, Db db)
		{
			return db.MonthlyBalanceSumFirstOrDefault(filterInstance.MinMonth, filterInstance.MaxMonth, filterInstance.EmployeeId);
		}

		#endregion

		#region PaymentBetweenTwoDates procedure.

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_minDate"></param>
		/// <param name="_maxDate"></param>
		/// <returns>A list of PaymentBetweenTwoDatesResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentBetweenTwoDatesResult> PaymentBetweenTwoDates([Parameter(Name = "@MinDate")] Nullable<DateTime> _minDate, [Parameter(Name = "@MaxDate")] Nullable<DateTime> _maxDate)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.PaymentBetweenTwoDates(_minDate, _maxDate);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of PaymentBetweenTwoDatesFilter that defines filtering options.</param>
        /// <returns>A list of PaymentBetweenTwoDatesResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<PaymentBetweenTwoDatesResult> PaymentBetweenTwoDates(PaymentBetweenTwoDatesFilter filterInstance, Db db)
		{
			return db.PaymentBetweenTwoDates(filterInstance.MinDate, filterInstance.MaxDate);
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
		/// <param name="_productType"></param>
		/// <param name="_amount"></param>
		/// <param name="_period"></param>
		/// <returns>A list of ProductCalculatorResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductCalculatorResult> ProductCalculator([Parameter(Name = "@ProductType")] Nullable<short> _productType, [Parameter(Name = "@Amount")] Nullable<decimal> _amount, [Parameter(Name = "@Period")] Nullable<short> _period, Db db)
		{
			return db.ProductCalculator(_productType, _amount, _period);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of ProductCalculatorFilter that defines filtering options.</param>
        /// <returns>A list of ProductCalculatorResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ProductCalculatorResult> ProductCalculator(ProductCalculatorFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.ProductCalculator(filterInstance.ProductType, filterInstance.Amount, filterInstance.Period);
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

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_productType"></param>
		/// <param name="_amount"></param>
		/// <param name="_period"></param>
		/// <returns>An instance of ProductCalculatorResult or null.</returns>
		public static ProductCalculatorResult ProductCalculatorFirstOrDefault([Parameter(Name = "@ProductType")] Nullable<short> _productType, [Parameter(Name = "@Amount")] Nullable<decimal> _amount, [Parameter(Name = "@Period")] Nullable<short> _period)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.ProductCalculatorFirstOrDefault(_productType, _amount, _period);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_productType"></param>
		/// <param name="_amount"></param>
		/// <param name="_period"></param>
		/// <returns>An instance of ProductCalculatorResult or null.</returns>
		public static ProductCalculatorResult ProductCalculatorFirstOrDefault([Parameter(Name = "@ProductType")] Nullable<short> _productType, [Parameter(Name = "@Amount")] Nullable<decimal> _amount, [Parameter(Name = "@Period")] Nullable<short> _period, Db db)
		{
			return db.ProductCalculatorFirstOrDefault(_productType, _amount, _period);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of ProductCalculatorFilter that defines filtering options.</param>
        /// <returns>An instance of ProductCalculatorResult or null.</returns>
		public static ProductCalculatorResult ProductCalculatorFirstOrDefault(ProductCalculatorFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.ProductCalculatorFirstOrDefault(filterInstance.ProductType, filterInstance.Amount, filterInstance.Period);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of ProductCalculatorFilter that defines filtering options.</param>
        /// <returns>An instance of ProductCalculatorResult or null.</returns>
		public static ProductCalculatorResult ProductCalculatorFirstOrDefault(ProductCalculatorFilter filterInstance, Db db)
		{
			return db.ProductCalculatorFirstOrDefault(filterInstance.ProductType, filterInstance.Amount, filterInstance.Period);
		}

		#endregion

		#region ReportEmployeeLoansBetweenTwoDates procedure.


		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_fromDate"></param>
		/// <param name="_toDate"></param>
		/// <param name="_employeeId"></param>
		/// <returns>A list of ReportEmployeeLoansBetweenTwoDatesResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ReportEmployeeLoansBetweenTwoDatesResult> ReportEmployeeLoansBetweenTwoDates([Parameter(Name = "@FromDate")] Nullable<DateTime> _fromDate, [Parameter(Name = "@ToDate")] Nullable<DateTime> _toDate, [Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.ReportEmployeeLoansBetweenTwoDates(_fromDate, _toDate, _employeeId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_fromDate"></param>
		/// <param name="_toDate"></param>
		/// <param name="_employeeId"></param>
		/// <returns>A list of ReportEmployeeLoansBetweenTwoDatesResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ReportEmployeeLoansBetweenTwoDatesResult> ReportEmployeeLoansBetweenTwoDates([Parameter(Name = "@FromDate")] Nullable<DateTime> _fromDate, [Parameter(Name = "@ToDate")] Nullable<DateTime> _toDate, [Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, Db db)
		{
			return db.ReportEmployeeLoansBetweenTwoDates(_fromDate, _toDate, _employeeId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of ReportEmployeeLoansBetweenTwoDatesFilter that defines filtering options.</param>
        /// <returns>A list of ReportEmployeeLoansBetweenTwoDatesResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ReportEmployeeLoansBetweenTwoDatesResult> ReportEmployeeLoansBetweenTwoDates(ReportEmployeeLoansBetweenTwoDatesFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.ReportEmployeeLoansBetweenTwoDates(filterInstance.FromDate, filterInstance.ToDate, filterInstance.EmployeeId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of ReportEmployeeLoansBetweenTwoDatesFilter that defines filtering options.</param>
        /// <returns>A list of ReportEmployeeLoansBetweenTwoDatesResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ReportEmployeeLoansBetweenTwoDatesResult> ReportEmployeeLoansBetweenTwoDates(ReportEmployeeLoansBetweenTwoDatesFilter filterInstance, Db db)
		{
			return db.ReportEmployeeLoansBetweenTwoDates(filterInstance.FromDate, filterInstance.ToDate, filterInstance.EmployeeId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_fromDate"></param>
		/// <param name="_toDate"></param>
		/// <param name="_employeeId"></param>
		/// <returns>An instance of ReportEmployeeLoansBetweenTwoDatesResult or null.</returns>
		public static ReportEmployeeLoansBetweenTwoDatesResult ReportEmployeeLoansBetweenTwoDatesFirstOrDefault([Parameter(Name = "@FromDate")] Nullable<DateTime> _fromDate, [Parameter(Name = "@ToDate")] Nullable<DateTime> _toDate, [Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.ReportEmployeeLoansBetweenTwoDatesFirstOrDefault(_fromDate, _toDate, _employeeId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_fromDate"></param>
		/// <param name="_toDate"></param>
		/// <param name="_employeeId"></param>
		/// <returns>An instance of ReportEmployeeLoansBetweenTwoDatesResult or null.</returns>
		public static ReportEmployeeLoansBetweenTwoDatesResult ReportEmployeeLoansBetweenTwoDatesFirstOrDefault([Parameter(Name = "@FromDate")] Nullable<DateTime> _fromDate, [Parameter(Name = "@ToDate")] Nullable<DateTime> _toDate, [Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, Db db)
		{
			return db.ReportEmployeeLoansBetweenTwoDatesFirstOrDefault(_fromDate, _toDate, _employeeId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of ReportEmployeeLoansBetweenTwoDatesFilter that defines filtering options.</param>
        /// <returns>An instance of ReportEmployeeLoansBetweenTwoDatesResult or null.</returns>
		public static ReportEmployeeLoansBetweenTwoDatesResult ReportEmployeeLoansBetweenTwoDatesFirstOrDefault(ReportEmployeeLoansBetweenTwoDatesFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.ReportEmployeeLoansBetweenTwoDatesFirstOrDefault(filterInstance.FromDate, filterInstance.ToDate, filterInstance.EmployeeId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of ReportEmployeeLoansBetweenTwoDatesFilter that defines filtering options.</param>
        /// <returns>An instance of ReportEmployeeLoansBetweenTwoDatesResult or null.</returns>
		public static ReportEmployeeLoansBetweenTwoDatesResult ReportEmployeeLoansBetweenTwoDatesFirstOrDefault(ReportEmployeeLoansBetweenTwoDatesFilter filterInstance, Db db)
		{
			return db.ReportEmployeeLoansBetweenTwoDatesFirstOrDefault(filterInstance.FromDate, filterInstance.ToDate, filterInstance.EmployeeId);
		}

		#endregion

		#region ReportLoansBetweenTwoDates procedure.


		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_fromDate"></param>
		/// <param name="_toDate"></param>
		/// <returns>A list of ReportLoansBetweenTwoDatesResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ReportLoansBetweenTwoDatesResult> ReportLoansBetweenTwoDates([Parameter(Name = "@FromDate")] Nullable<DateTime> _fromDate, [Parameter(Name = "@ToDate")] Nullable<DateTime> _toDate)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.ReportLoansBetweenTwoDates(_fromDate, _toDate);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_fromDate"></param>
		/// <param name="_toDate"></param>
		/// <returns>A list of ReportLoansBetweenTwoDatesResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ReportLoansBetweenTwoDatesResult> ReportLoansBetweenTwoDates([Parameter(Name = "@FromDate")] Nullable<DateTime> _fromDate, [Parameter(Name = "@ToDate")] Nullable<DateTime> _toDate, Db db)
		{
			return db.ReportLoansBetweenTwoDates(_fromDate, _toDate);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of ReportLoansBetweenTwoDatesFilter that defines filtering options.</param>
        /// <returns>A list of ReportLoansBetweenTwoDatesResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ReportLoansBetweenTwoDatesResult> ReportLoansBetweenTwoDates(ReportLoansBetweenTwoDatesFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.ReportLoansBetweenTwoDates(filterInstance.FromDate, filterInstance.ToDate);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of ReportLoansBetweenTwoDatesFilter that defines filtering options.</param>
        /// <returns>A list of ReportLoansBetweenTwoDatesResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ReportLoansBetweenTwoDatesResult> ReportLoansBetweenTwoDates(ReportLoansBetweenTwoDatesFilter filterInstance, Db db)
		{
			return db.ReportLoansBetweenTwoDates(filterInstance.FromDate, filterInstance.ToDate);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_fromDate"></param>
		/// <param name="_toDate"></param>
		/// <returns>An instance of ReportLoansBetweenTwoDatesResult or null.</returns>
		public static ReportLoansBetweenTwoDatesResult ReportLoansBetweenTwoDatesFirstOrDefault([Parameter(Name = "@FromDate")] Nullable<DateTime> _fromDate, [Parameter(Name = "@ToDate")] Nullable<DateTime> _toDate)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.ReportLoansBetweenTwoDatesFirstOrDefault(_fromDate, _toDate);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_fromDate"></param>
		/// <param name="_toDate"></param>
		/// <returns>An instance of ReportLoansBetweenTwoDatesResult or null.</returns>
		public static ReportLoansBetweenTwoDatesResult ReportLoansBetweenTwoDatesFirstOrDefault([Parameter(Name = "@FromDate")] Nullable<DateTime> _fromDate, [Parameter(Name = "@ToDate")] Nullable<DateTime> _toDate, Db db)
		{
			return db.ReportLoansBetweenTwoDatesFirstOrDefault(_fromDate, _toDate);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of ReportLoansBetweenTwoDatesFilter that defines filtering options.</param>
        /// <returns>An instance of ReportLoansBetweenTwoDatesResult or null.</returns>
		public static ReportLoansBetweenTwoDatesResult ReportLoansBetweenTwoDatesFirstOrDefault(ReportLoansBetweenTwoDatesFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.ReportLoansBetweenTwoDatesFirstOrDefault(filterInstance.FromDate, filterInstance.ToDate);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of ReportLoansBetweenTwoDatesFilter that defines filtering options.</param>
        /// <returns>An instance of ReportLoansBetweenTwoDatesResult or null.</returns>
		public static ReportLoansBetweenTwoDatesResult ReportLoansBetweenTwoDatesFirstOrDefault(ReportLoansBetweenTwoDatesFilter filterInstance, Db db)
		{
			return db.ReportLoansBetweenTwoDatesFirstOrDefault(filterInstance.FromDate, filterInstance.ToDate);
		}

		#endregion

		#region ReportMonthlyBalanceSum procedure.


		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_minMonth"></param>
		/// <param name="_maxMonth"></param>
		/// <param name="_employeeId"></param>
		/// <returns>A list of ReportMonthlyBalanceSumResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ReportMonthlyBalanceSumResult> ReportMonthlyBalanceSum([Parameter(Name = "@MinMonth")] Nullable<DateTime> _minMonth, [Parameter(Name = "@MaxMonth")] Nullable<DateTime> _maxMonth, [Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.ReportMonthlyBalanceSum(_minMonth, _maxMonth, _employeeId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_minMonth"></param>
		/// <param name="_maxMonth"></param>
		/// <param name="_employeeId"></param>
		/// <returns>A list of ReportMonthlyBalanceSumResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ReportMonthlyBalanceSumResult> ReportMonthlyBalanceSum([Parameter(Name = "@MinMonth")] Nullable<DateTime> _minMonth, [Parameter(Name = "@MaxMonth")] Nullable<DateTime> _maxMonth, [Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, Db db)
		{
			return db.ReportMonthlyBalanceSum(_minMonth, _maxMonth, _employeeId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of ReportMonthlyBalanceSumFilter that defines filtering options.</param>
        /// <returns>A list of ReportMonthlyBalanceSumResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ReportMonthlyBalanceSumResult> ReportMonthlyBalanceSum(ReportMonthlyBalanceSumFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.ReportMonthlyBalanceSum(filterInstance.MinMonth, filterInstance.MaxMonth, filterInstance.EmployeeId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of ReportMonthlyBalanceSumFilter that defines filtering options.</param>
        /// <returns>A list of ReportMonthlyBalanceSumResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ReportMonthlyBalanceSumResult> ReportMonthlyBalanceSum(ReportMonthlyBalanceSumFilter filterInstance, Db db)
		{
			return db.ReportMonthlyBalanceSum(filterInstance.MinMonth, filterInstance.MaxMonth, filterInstance.EmployeeId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_minMonth"></param>
		/// <param name="_maxMonth"></param>
		/// <param name="_employeeId"></param>
		/// <returns>An instance of ReportMonthlyBalanceSumResult or null.</returns>
		public static ReportMonthlyBalanceSumResult ReportMonthlyBalanceSumFirstOrDefault([Parameter(Name = "@MinMonth")] Nullable<DateTime> _minMonth, [Parameter(Name = "@MaxMonth")] Nullable<DateTime> _maxMonth, [Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.ReportMonthlyBalanceSumFirstOrDefault(_minMonth, _maxMonth, _employeeId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_minMonth"></param>
		/// <param name="_maxMonth"></param>
		/// <param name="_employeeId"></param>
		/// <returns>An instance of ReportMonthlyBalanceSumResult or null.</returns>
		public static ReportMonthlyBalanceSumResult ReportMonthlyBalanceSumFirstOrDefault([Parameter(Name = "@MinMonth")] Nullable<DateTime> _minMonth, [Parameter(Name = "@MaxMonth")] Nullable<DateTime> _maxMonth, [Parameter(Name = "@EmployeeId")] Nullable<int> _employeeId, Db db)
		{
			return db.ReportMonthlyBalanceSumFirstOrDefault(_minMonth, _maxMonth, _employeeId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of ReportMonthlyBalanceSumFilter that defines filtering options.</param>
        /// <returns>An instance of ReportMonthlyBalanceSumResult or null.</returns>
		public static ReportMonthlyBalanceSumResult ReportMonthlyBalanceSumFirstOrDefault(ReportMonthlyBalanceSumFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.ReportMonthlyBalanceSumFirstOrDefault(filterInstance.MinMonth, filterInstance.MaxMonth, filterInstance.EmployeeId);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of ReportMonthlyBalanceSumFilter that defines filtering options.</param>
        /// <returns>An instance of ReportMonthlyBalanceSumResult or null.</returns>
		public static ReportMonthlyBalanceSumResult ReportMonthlyBalanceSumFirstOrDefault(ReportMonthlyBalanceSumFilter filterInstance, Db db)
		{
			return db.ReportMonthlyBalanceSumFirstOrDefault(filterInstance.MinMonth, filterInstance.MaxMonth, filterInstance.EmployeeId);
		}

		#endregion

		#region ReportPaymentsBetweenTwoDates procedure.

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_firstMonth"></param>
		/// <param name="_secondMonth"></param>
		/// <param name="_limit"></param>
		/// <param name="_paymentDiff"></param>
		/// <returns>A list of ReportPaymentsBetweenTwoDatesResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ReportPaymentsBetweenTwoDatesResult> ReportPaymentsBetweenTwoDates([Parameter(Name = "@FirstMonth")] Nullable<DateTime> _firstMonth, [Parameter(Name = "@SecondMonth")] Nullable<DateTime> _secondMonth, [Parameter(Name = "@Limit")] Nullable<double> _limit, [Parameter(Name = "@PaymentDiff")] Nullable<int> _paymentDiff)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.ReportPaymentsBetweenTwoDates(_firstMonth, _secondMonth, _limit, _paymentDiff);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of ReportPaymentsBetweenTwoDatesFilter that defines filtering options.</param>
        /// <returns>A list of ReportPaymentsBetweenTwoDatesResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ReportPaymentsBetweenTwoDatesResult> ReportPaymentsBetweenTwoDates(ReportPaymentsBetweenTwoDatesFilter filterInstance, Db db)
		{
			return db.ReportPaymentsBetweenTwoDates(filterInstance.FirstMonth, filterInstance.SecondMonth, filterInstance.Limit, filterInstance.PaymentDiff);
		}
		#endregion

		#region ReportSubscriptionsBetweenTwoDates procedure.

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_firstMonth"></param>
		/// <param name="_secondMonth"></param>
		/// <param name="_limit"></param>
		/// <param name="_subscriptionDiff"></param>
		/// <returns>A list of ReportSubscriptionsBetweenTwoDatesResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ReportSubscriptionsBetweenTwoDatesResult> ReportSubscriptionsBetweenTwoDates([Parameter(Name = "@FirstMonth")] Nullable<DateTime> _firstMonth, [Parameter(Name = "@SecondMonth")] Nullable<DateTime> _secondMonth, [Parameter(Name = "@Limit")] Nullable<double> _limit, [Parameter(Name = "@SubscriptionDiff")] Nullable<int> _subscriptionDiff)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.ReportSubscriptionsBetweenTwoDates(_firstMonth, _secondMonth, _limit, _subscriptionDiff);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of ReportSubscriptionsBetweenTwoDatesFilter that defines filtering options.</param>
        /// <returns>A list of ReportSubscriptionsBetweenTwoDatesResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<ReportSubscriptionsBetweenTwoDatesResult> ReportSubscriptionsBetweenTwoDates(ReportSubscriptionsBetweenTwoDatesFilter filterInstance, Db db)
		{
			return db.ReportSubscriptionsBetweenTwoDates(filterInstance.FirstMonth, filterInstance.SecondMonth, filterInstance.Limit, filterInstance.SubscriptionDiff);
		}
		#endregion

		#region RequestStatistics procedure.


		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_minDate"></param>
		/// <param name="_maxDate"></param>
		/// <returns>A list of RequestStatisticsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<RequestStatisticsResult> RequestStatistics([Parameter(Name = "@MinDate")] Nullable<DateTime> _minDate, [Parameter(Name = "@MaxDate")] Nullable<DateTime> _maxDate)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.RequestStatistics(_minDate, _maxDate);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_minDate"></param>
		/// <param name="_maxDate"></param>
		/// <returns>A list of RequestStatisticsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<RequestStatisticsResult> RequestStatistics([Parameter(Name = "@MinDate")] Nullable<DateTime> _minDate, [Parameter(Name = "@MaxDate")] Nullable<DateTime> _maxDate, Db db)
		{
			return db.RequestStatistics(_minDate, _maxDate);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of RequestStatisticsFilter that defines filtering options.</param>
        /// <returns>A list of RequestStatisticsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<RequestStatisticsResult> RequestStatistics(RequestStatisticsFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.RequestStatistics(filterInstance.MinDate, filterInstance.MaxDate);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of RequestStatisticsFilter that defines filtering options.</param>
        /// <returns>A list of RequestStatisticsResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<RequestStatisticsResult> RequestStatistics(RequestStatisticsFilter filterInstance, Db db)
		{
			return db.RequestStatistics(filterInstance.MinDate, filterInstance.MaxDate);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_minDate"></param>
		/// <param name="_maxDate"></param>
		/// <returns>An instance of RequestStatisticsResult or null.</returns>
		public static RequestStatisticsResult RequestStatisticsFirstOrDefault([Parameter(Name = "@MinDate")] Nullable<DateTime> _minDate, [Parameter(Name = "@MaxDate")] Nullable<DateTime> _maxDate)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.RequestStatisticsFirstOrDefault(_minDate, _maxDate);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_minDate"></param>
		/// <param name="_maxDate"></param>
		/// <returns>An instance of RequestStatisticsResult or null.</returns>
		public static RequestStatisticsResult RequestStatisticsFirstOrDefault([Parameter(Name = "@MinDate")] Nullable<DateTime> _minDate, [Parameter(Name = "@MaxDate")] Nullable<DateTime> _maxDate, Db db)
		{
			return db.RequestStatisticsFirstOrDefault(_minDate, _maxDate);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of RequestStatisticsFilter that defines filtering options.</param>
        /// <returns>An instance of RequestStatisticsResult or null.</returns>
		public static RequestStatisticsResult RequestStatisticsFirstOrDefault(RequestStatisticsFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.RequestStatisticsFirstOrDefault(filterInstance.MinDate, filterInstance.MaxDate);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of RequestStatisticsFilter that defines filtering options.</param>
        /// <returns>An instance of RequestStatisticsResult or null.</returns>
		public static RequestStatisticsResult RequestStatisticsFirstOrDefault(RequestStatisticsFilter filterInstance, Db db)
		{
			return db.RequestStatisticsFirstOrDefault(filterInstance.MinDate, filterInstance.MaxDate);
		}

		#endregion

		#region SubscriptionsBetweenTwoDates procedure.

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_minDate"></param>
		/// <param name="_maxDate"></param>
		/// <returns>A list of SubscriptionsBetweenTwoDatesResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SubscriptionsBetweenTwoDatesResult> SubscriptionsBetweenTwoDates([Parameter(Name = "@MinDate")] Nullable<DateTime> _minDate, [Parameter(Name = "@MaxDate")] Nullable<DateTime> _maxDate)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.SubscriptionsBetweenTwoDates(_minDate, _maxDate);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of SubscriptionsBetweenTwoDatesFilter that defines filtering options.</param>
        /// <returns>A list of SubscriptionsBetweenTwoDatesResult instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<SubscriptionsBetweenTwoDatesResult> SubscriptionsBetweenTwoDates(SubscriptionsBetweenTwoDatesFilter filterInstance, Db db)
		{
			return db.SubscriptionsBetweenTwoDates(filterInstance.MinDate, filterInstance.MaxDate);
		}
		#endregion

		#region SumComingLoansForEmployee procedure.

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_fromDate"></param>
		/// <param name="_toDate"></param>
		/// <param name="_employee"></param>
		public static double SumComingLoansForEmployee([Parameter(Name = "@FromDate")] Nullable<DateTime> _fromDate, [Parameter(Name = "@ToDate")] Nullable<DateTime> _toDate, [Parameter(Name = "@Employee")] Nullable<int> _employee)
		{
			Db db = new Db(DbServices.ConnectionString);
			 return db.SumComingLoansForEmployee(_fromDate, _toDate, _employee);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_fromDate"></param>
		/// <param name="_toDate"></param>
		/// <param name="_employee"></param>
		public static double SumComingLoansForEmployee([Parameter(Name = "@FromDate")] Nullable<DateTime> _fromDate, [Parameter(Name = "@ToDate")] Nullable<DateTime> _toDate, [Parameter(Name = "@Employee")] Nullable<int> _employee, Db db)
		{
			return db.SumComingLoansForEmployee(_fromDate, _toDate, _employee);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of SumComingLoansForEmployeeFilter that defines filtering options.</param>
		public static double SumComingLoansForEmployee(SumComingLoansForEmployeeFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.SumComingLoansForEmployee(filterInstance.FromDate, filterInstance.ToDate, filterInstance.Employee);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of SumComingLoansForEmployeeFilter that defines filtering options.</param>
		public static double SumComingLoansForEmployee(SumComingLoansForEmployeeFilter filterInstance, Db db)
		{
			return db.SumComingLoansForEmployee(filterInstance.FromDate, filterInstance.ToDate, filterInstance.Employee);
		}
		#endregion

		#region SumLoansForEmployee procedure.

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_fromDate"></param>
		/// <param name="_toDate"></param>
		/// <param name="_employee"></param>
		public static double SumLoansForEmployee([Parameter(Name = "@FromDate")] Nullable<DateTime> _fromDate, [Parameter(Name = "@ToDate")] Nullable<DateTime> _toDate, [Parameter(Name = "@Employee")] Nullable<int> _employee)
		{
			Db db = new Db(DbServices.ConnectionString);
			 return db.SumLoansForEmployee(_fromDate, _toDate, _employee);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_fromDate"></param>
		/// <param name="_toDate"></param>
		/// <param name="_employee"></param>
		public static double SumLoansForEmployee([Parameter(Name = "@FromDate")] Nullable<DateTime> _fromDate, [Parameter(Name = "@ToDate")] Nullable<DateTime> _toDate, [Parameter(Name = "@Employee")] Nullable<int> _employee, Db db)
		{
			return db.SumLoansForEmployee(_fromDate, _toDate, _employee);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of SumLoansForEmployeeFilter that defines filtering options.</param>
		public static double SumLoansForEmployee(SumLoansForEmployeeFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.SumLoansForEmployee(filterInstance.FromDate, filterInstance.ToDate, filterInstance.Employee);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of SumLoansForEmployeeFilter that defines filtering options.</param>
		public static double SumLoansForEmployee(SumLoansForEmployeeFilter filterInstance, Db db)
		{
			return db.SumLoansForEmployee(filterInstance.FromDate, filterInstance.ToDate, filterInstance.Employee);
		}
		#endregion

		#region SumOutgoingLoansForEmployee procedure.

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_fromDate"></param>
		/// <param name="_toDate"></param>
		/// <param name="_employee"></param>
		public static double SumOutgoingLoansForEmployee([Parameter(Name = "@FromDate")] Nullable<DateTime> _fromDate, [Parameter(Name = "@ToDate")] Nullable<DateTime> _toDate, [Parameter(Name = "@Employee")] Nullable<int> _employee)
		{
			Db db = new Db(DbServices.ConnectionString);
			 return db.SumOutgoingLoansForEmployee(_fromDate, _toDate, _employee);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_fromDate"></param>
		/// <param name="_toDate"></param>
		/// <param name="_employee"></param>
		public static double SumOutgoingLoansForEmployee([Parameter(Name = "@FromDate")] Nullable<DateTime> _fromDate, [Parameter(Name = "@ToDate")] Nullable<DateTime> _toDate, [Parameter(Name = "@Employee")] Nullable<int> _employee, Db db)
		{
			return db.SumOutgoingLoansForEmployee(_fromDate, _toDate, _employee);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of SumOutgoingLoansForEmployeeFilter that defines filtering options.</param>
		public static double SumOutgoingLoansForEmployee(SumOutgoingLoansForEmployeeFilter filterInstance)
		{
			Db db = new Db(DbServices.ConnectionString);
			return db.SumOutgoingLoansForEmployee(filterInstance.FromDate, filterInstance.ToDate, filterInstance.Employee);
		}

        /// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of SumOutgoingLoansForEmployeeFilter that defines filtering options.</param>
		public static double SumOutgoingLoansForEmployee(SumOutgoingLoansForEmployeeFilter filterInstance, Db db)
		{
			return db.SumOutgoingLoansForEmployee(filterInstance.FromDate, filterInstance.ToDate, filterInstance.Employee);
		}
		#endregion
	}
	#endregion
}
