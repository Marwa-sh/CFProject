using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using QueryBuilder;

namespace Cf.Data
{
	#region Db class definition
    public partial class Db
    {
        #region CashPaymentVw
        public List<CashPaymentVw> Get(CashPaymentVwFilter filter)
        {
            return ExecuteQuery<CashPaymentVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<CashPaymentVw>();
        }
        public List<CashPaymentVw> GetPage(CashPaymentVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<CashPaymentVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<CashPaymentVw>();
        }
        public int GetTotalRowCount(CashPaymentVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region CollectOrderVw
        public List<CollectOrderVw> Get(CollectOrderVwFilter filter)
        {
            return ExecuteQuery<CollectOrderVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<CollectOrderVw>();
        }
        public List<CollectOrderVw> GetPage(CollectOrderVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<CollectOrderVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<CollectOrderVw>();
        }
        public int GetTotalRowCount(CollectOrderVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region DebtVw
        public List<DebtVw> Get(DebtVwFilter filter)
        {
            return ExecuteQuery<DebtVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<DebtVw>();
        }
        public List<DebtVw> GetPage(DebtVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<DebtVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<DebtVw>();
        }
        public int GetTotalRowCount(DebtVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region DepartmentVw
        public List<DepartmentVw> Get(DepartmentVwFilter filter)
        {
            return ExecuteQuery<DepartmentVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<DepartmentVw>();
        }
        public List<DepartmentVw> GetPage(DepartmentVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<DepartmentVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<DepartmentVw>();
        }
        public int GetTotalRowCount(DepartmentVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region DownPaymentVw
        public List<DownPaymentVw> Get(DownPaymentVwFilter filter)
        {
            return ExecuteQuery<DownPaymentVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<DownPaymentVw>();
        }
        public List<DownPaymentVw> GetPage(DownPaymentVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<DownPaymentVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<DownPaymentVw>();
        }
        public int GetTotalRowCount(DownPaymentVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region EmployeeVw
        public List<EmployeeVw> Get(EmployeeVwFilter filter)
        {
            return ExecuteQuery<EmployeeVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<EmployeeVw>();
        }
        public List<EmployeeVw> GetPage(EmployeeVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<EmployeeVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<EmployeeVw>();
        }
        public int GetTotalRowCount(EmployeeVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region ErrorDefinitionVw
        public List<ErrorDefinitionVw> Get(ErrorDefinitionVwFilter filter)
        {
            return ExecuteQuery<ErrorDefinitionVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<ErrorDefinitionVw>();
        }
        public List<ErrorDefinitionVw> GetPage(ErrorDefinitionVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<ErrorDefinitionVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<ErrorDefinitionVw>();
        }
        public int GetTotalRowCount(ErrorDefinitionVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region EventCategoryVw
        public List<EventCategoryVw> Get(EventCategoryVwFilter filter)
        {
            return ExecuteQuery<EventCategoryVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<EventCategoryVw>();
        }
        public List<EventCategoryVw> GetPage(EventCategoryVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<EventCategoryVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<EventCategoryVw>();
        }
        public int GetTotalRowCount(EventCategoryVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region EventLogErrorVw
        public List<EventLogErrorVw> Get(EventLogErrorVwFilter filter)
        {
            return ExecuteQuery<EventLogErrorVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<EventLogErrorVw>();
        }
        public List<EventLogErrorVw> GetPage(EventLogErrorVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<EventLogErrorVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<EventLogErrorVw>();
        }
        public int GetTotalRowCount(EventLogErrorVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region EventLogVw
        public List<EventLogVw> Get(EventLogVwFilter filter)
        {
            return ExecuteQuery<EventLogVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<EventLogVw>();
        }
        public List<EventLogVw> GetPage(EventLogVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<EventLogVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<EventLogVw>();
        }
        public int GetTotalRowCount(EventLogVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region ExternalGrantVw
        public List<ExternalGrantVw> Get(ExternalGrantVwFilter filter)
        {
            return ExecuteQuery<ExternalGrantVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<ExternalGrantVw>();
        }
        public List<ExternalGrantVw> GetPage(ExternalGrantVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<ExternalGrantVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<ExternalGrantVw>();
        }
        public int GetTotalRowCount(ExternalGrantVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region GrantDecisionVw
        public List<GrantDecisionVw> Get(GrantDecisionVwFilter filter)
        {
            return ExecuteQuery<GrantDecisionVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<GrantDecisionVw>();
        }
        public List<GrantDecisionVw> GetPage(GrantDecisionVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<GrantDecisionVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<GrantDecisionVw>();
        }
        public int GetTotalRowCount(GrantDecisionVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region GrantPaymentOrderVw
        public List<GrantPaymentOrderVw> Get(GrantPaymentOrderVwFilter filter)
        {
            return ExecuteQuery<GrantPaymentOrderVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<GrantPaymentOrderVw>();
        }
        public List<GrantPaymentOrderVw> GetPage(GrantPaymentOrderVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<GrantPaymentOrderVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<GrantPaymentOrderVw>();
        }
        public int GetTotalRowCount(GrantPaymentOrderVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region GrantPaymentVw
        public List<GrantPaymentVw> Get(GrantPaymentVwFilter filter)
        {
            return ExecuteQuery<GrantPaymentVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<GrantPaymentVw>();
        }
        public List<GrantPaymentVw> GetPage(GrantPaymentVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<GrantPaymentVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<GrantPaymentVw>();
        }
        public int GetTotalRowCount(GrantPaymentVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region GrantRequestVw
        public List<GrantRequestVw> Get(GrantRequestVwFilter filter)
        {
            return ExecuteQuery<GrantRequestVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<GrantRequestVw>();
        }
        public List<GrantRequestVw> GetPage(GrantRequestVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<GrantRequestVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<GrantRequestVw>();
        }
        public int GetTotalRowCount(GrantRequestVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region GrantVw
        public List<GrantVw> Get(GrantVwFilter filter)
        {
            return ExecuteQuery<GrantVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<GrantVw>();
        }
        public List<GrantVw> GetPage(GrantVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<GrantVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<GrantVw>();
        }
        public int GetTotalRowCount(GrantVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region GuarantorVw
        public List<GuarantorVw> Get(GuarantorVwFilter filter)
        {
            return ExecuteQuery<GuarantorVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<GuarantorVw>();
        }
        public List<GuarantorVw> GetPage(GuarantorVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<GuarantorVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<GuarantorVw>();
        }
        public int GetTotalRowCount(GuarantorVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region HealthLoanDecisionFirstPaymentVw
        public List<HealthLoanDecisionFirstPaymentVw> Get(HealthLoanDecisionFirstPaymentVwFilter filter)
        {
            return ExecuteQuery<HealthLoanDecisionFirstPaymentVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<HealthLoanDecisionFirstPaymentVw>();
        }
        public List<HealthLoanDecisionFirstPaymentVw> GetPage(HealthLoanDecisionFirstPaymentVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<HealthLoanDecisionFirstPaymentVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<HealthLoanDecisionFirstPaymentVw>();
        }
        public int GetTotalRowCount(HealthLoanDecisionFirstPaymentVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region HealthLoanDecisionVw
        public List<HealthLoanDecisionVw> Get(HealthLoanDecisionVwFilter filter)
        {
            return ExecuteQuery<HealthLoanDecisionVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<HealthLoanDecisionVw>();
        }
        public List<HealthLoanDecisionVw> GetPage(HealthLoanDecisionVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<HealthLoanDecisionVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<HealthLoanDecisionVw>();
        }
        public int GetTotalRowCount(HealthLoanDecisionVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region IncomingLoanVw
        public List<IncomingLoanVw> Get(IncomingLoanVwFilter filter)
        {
            return ExecuteQuery<IncomingLoanVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<IncomingLoanVw>();
        }
        public List<IncomingLoanVw> GetPage(IncomingLoanVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<IncomingLoanVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<IncomingLoanVw>();
        }
        public int GetTotalRowCount(IncomingLoanVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region InstallmentDecreaseOrderVw
        public List<InstallmentDecreaseOrderVw> Get(InstallmentDecreaseOrderVwFilter filter)
        {
            return ExecuteQuery<InstallmentDecreaseOrderVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<InstallmentDecreaseOrderVw>();
        }
        public List<InstallmentDecreaseOrderVw> GetPage(InstallmentDecreaseOrderVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<InstallmentDecreaseOrderVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<InstallmentDecreaseOrderVw>();
        }
        public int GetTotalRowCount(InstallmentDecreaseOrderVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region InstallmentDecreaseVw
        public List<InstallmentDecreaseVw> Get(InstallmentDecreaseVwFilter filter)
        {
            return ExecuteQuery<InstallmentDecreaseVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<InstallmentDecreaseVw>();
        }
        public List<InstallmentDecreaseVw> GetPage(InstallmentDecreaseVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<InstallmentDecreaseVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<InstallmentDecreaseVw>();
        }
        public int GetTotalRowCount(InstallmentDecreaseVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region InstallmentVw
        public List<InstallmentVw> Get(InstallmentVwFilter filter)
        {
            return ExecuteQuery<InstallmentVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<InstallmentVw>();
        }
        public List<InstallmentVw> GetPage(InstallmentVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<InstallmentVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<InstallmentVw>();
        }
        public int GetTotalRowCount(InstallmentVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region LoanChangeVw
        public List<LoanChangeVw> Get(LoanChangeVwFilter filter)
        {
            return ExecuteQuery<LoanChangeVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<LoanChangeVw>();
        }
        public List<LoanChangeVw> GetPage(LoanChangeVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<LoanChangeVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<LoanChangeVw>();
        }
        public int GetTotalRowCount(LoanChangeVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region LoanDecisionVw
        public List<LoanDecisionVw> Get(LoanDecisionVwFilter filter)
        {
            return ExecuteQuery<LoanDecisionVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<LoanDecisionVw>();
        }
        public List<LoanDecisionVw> GetPage(LoanDecisionVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<LoanDecisionVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<LoanDecisionVw>();
        }
        public int GetTotalRowCount(LoanDecisionVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region LoanExtendedVw
        public List<LoanExtendedVw> Get(LoanExtendedVwFilter filter)
        {
            return ExecuteQuery<LoanExtendedVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<LoanExtendedVw>();
        }
        public List<LoanExtendedVw> GetPage(LoanExtendedVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<LoanExtendedVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<LoanExtendedVw>();
        }
        public int GetTotalRowCount(LoanExtendedVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region LoanRequestVw
        public List<LoanRequestVw> Get(LoanRequestVwFilter filter)
        {
            return ExecuteQuery<LoanRequestVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<LoanRequestVw>();
        }
        public List<LoanRequestVw> GetPage(LoanRequestVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<LoanRequestVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<LoanRequestVw>();
        }
        public int GetTotalRowCount(LoanRequestVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region LoanTypeVw
        public List<LoanTypeVw> Get(LoanTypeVwFilter filter)
        {
            return ExecuteQuery<LoanTypeVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<LoanTypeVw>();
        }
        public List<LoanTypeVw> GetPage(LoanTypeVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<LoanTypeVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<LoanTypeVw>();
        }
        public int GetTotalRowCount(LoanTypeVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region LoanVw
        public List<LoanVw> Get(LoanVwFilter filter)
        {
            return ExecuteQuery<LoanVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<LoanVw>();
        }
        public List<LoanVw> GetPage(LoanVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<LoanVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<LoanVw>();
        }
        public int GetTotalRowCount(LoanVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region MissingInstallmentDecreaseVw
        public List<MissingInstallmentDecreaseVw> Get(MissingInstallmentDecreaseVwFilter filter)
        {
            return ExecuteQuery<MissingInstallmentDecreaseVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<MissingInstallmentDecreaseVw>();
        }
        public List<MissingInstallmentDecreaseVw> GetPage(MissingInstallmentDecreaseVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<MissingInstallmentDecreaseVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<MissingInstallmentDecreaseVw>();
        }
        public int GetTotalRowCount(MissingInstallmentDecreaseVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region MonthlyBalanceVw
        public List<MonthlyBalanceVw> Get(MonthlyBalanceVwFilter filter)
        {
            return ExecuteQuery<MonthlyBalanceVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<MonthlyBalanceVw>();
        }
        public List<MonthlyBalanceVw> GetPage(MonthlyBalanceVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<MonthlyBalanceVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<MonthlyBalanceVw>();
        }
        public int GetTotalRowCount(MonthlyBalanceVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region OutgoingLoanVw
        public List<OutgoingLoanVw> Get(OutgoingLoanVwFilter filter)
        {
            return ExecuteQuery<OutgoingLoanVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<OutgoingLoanVw>();
        }
        public List<OutgoingLoanVw> GetPage(OutgoingLoanVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<OutgoingLoanVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<OutgoingLoanVw>();
        }
        public int GetTotalRowCount(OutgoingLoanVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region PaymentVw
        public List<PaymentVw> Get(PaymentVwFilter filter)
        {
            return ExecuteQuery<PaymentVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<PaymentVw>();
        }
        public List<PaymentVw> GetPage(PaymentVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<PaymentVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<PaymentVw>();
        }
        public int GetTotalRowCount(PaymentVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region PayOrderVw
        public List<PayOrderVw> Get(PayOrderVwFilter filter)
        {
            return ExecuteQuery<PayOrderVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<PayOrderVw>();
        }
        public List<PayOrderVw> GetPage(PayOrderVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<PayOrderVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<PayOrderVw>();
        }
        public int GetTotalRowCount(PayOrderVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region ProductVw
        public List<ProductVw> Get(ProductVwFilter filter)
        {
            return ExecuteQuery<ProductVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<ProductVw>();
        }
        public List<ProductVw> GetPage(ProductVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<ProductVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<ProductVw>();
        }
        public int GetTotalRowCount(ProductVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region RefundableProductVw
        public List<RefundableProductVw> Get(RefundableProductVwFilter filter)
        {
            return ExecuteQuery<RefundableProductVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<RefundableProductVw>();
        }
        public List<RefundableProductVw> GetPage(RefundableProductVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<RefundableProductVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<RefundableProductVw>();
        }
        public int GetTotalRowCount(RefundableProductVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region RequestVw
        public List<RequestVw> Get(RequestVwFilter filter)
        {
            return ExecuteQuery<RequestVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<RequestVw>();
        }
        public List<RequestVw> GetPage(RequestVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<RequestVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<RequestVw>();
        }
        public int GetTotalRowCount(RequestVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region ResourceVw
        public List<ResourceVw> Get(ResourceVwFilter filter)
        {
            return ExecuteQuery<ResourceVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<ResourceVw>();
        }
        public List<ResourceVw> GetPage(ResourceVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<ResourceVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<ResourceVw>();
        }
        public int GetTotalRowCount(ResourceVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region SalaryPaymentVw
        public List<SalaryPaymentVw> Get(SalaryPaymentVwFilter filter)
        {
            return ExecuteQuery<SalaryPaymentVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<SalaryPaymentVw>();
        }
        public List<SalaryPaymentVw> GetPage(SalaryPaymentVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<SalaryPaymentVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<SalaryPaymentVw>();
        }
        public int GetTotalRowCount(SalaryPaymentVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region SalaryWorkPlaceVw
        public List<SalaryWorkPlaceVw> Get(SalaryWorkPlaceVwFilter filter)
        {
            return ExecuteQuery<SalaryWorkPlaceVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<SalaryWorkPlaceVw>();
        }
        public List<SalaryWorkPlaceVw> GetPage(SalaryWorkPlaceVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<SalaryWorkPlaceVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<SalaryWorkPlaceVw>();
        }
        public int GetTotalRowCount(SalaryWorkPlaceVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region ServiceEndGrantRequestVw
        public List<ServiceEndGrantRequestVw> Get(ServiceEndGrantRequestVwFilter filter)
        {
            return ExecuteQuery<ServiceEndGrantRequestVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<ServiceEndGrantRequestVw>();
        }
        public List<ServiceEndGrantRequestVw> GetPage(ServiceEndGrantRequestVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<ServiceEndGrantRequestVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<ServiceEndGrantRequestVw>();
        }
        public int GetTotalRowCount(ServiceEndGrantRequestVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region SettlementVw
        public List<SettlementVw> Get(SettlementVwFilter filter)
        {
            return ExecuteQuery<SettlementVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<SettlementVw>();
        }
        public List<SettlementVw> GetPage(SettlementVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<SettlementVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<SettlementVw>();
        }
        public int GetTotalRowCount(SettlementVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region SpecialCaseLoanVw
        public List<SpecialCaseLoanVw> Get(SpecialCaseLoanVwFilter filter)
        {
            return ExecuteQuery<SpecialCaseLoanVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<SpecialCaseLoanVw>();
        }
        public List<SpecialCaseLoanVw> GetPage(SpecialCaseLoanVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<SpecialCaseLoanVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<SpecialCaseLoanVw>();
        }
        public int GetTotalRowCount(SpecialCaseLoanVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region SubscriptionVw
        public List<SubscriptionVw> Get(SubscriptionVwFilter filter)
        {
            return ExecuteQuery<SubscriptionVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<SubscriptionVw>();
        }
        public List<SubscriptionVw> GetPage(SubscriptionVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<SubscriptionVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<SubscriptionVw>();
        }
        public int GetTotalRowCount(SubscriptionVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region TransitoryIncomingLoanVw
        public List<TransitoryIncomingLoanVw> Get(TransitoryIncomingLoanVwFilter filter)
        {
            return ExecuteQuery<TransitoryIncomingLoanVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<TransitoryIncomingLoanVw>();
        }
        public List<TransitoryIncomingLoanVw> GetPage(TransitoryIncomingLoanVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<TransitoryIncomingLoanVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<TransitoryIncomingLoanVw>();
        }
        public int GetTotalRowCount(TransitoryIncomingLoanVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion

        #region WarrantVw
        public List<WarrantVw> Get(WarrantVwFilter filter)
        {
            return ExecuteQuery<WarrantVw>(filter.ToString(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<WarrantVw>();
        }
        public List<WarrantVw> GetPage(WarrantVwFilter filter, int pageIndex, int pageSize)
        {
            return ExecuteQuery<WarrantVw>(filter.ToString(pageIndex, pageSize, ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).ToList<WarrantVw>();
        }
        public int GetTotalRowCount(WarrantVwFilter filter)
        {
            return ExecuteQuery<Scalar<int>>(filter.GetTotalRowCountStatement(ParameterReplacementOption.BracketEnclosedNumber), filter.ExtractValues().ToArray()).First<Scalar<int>>().Value;
        }
        #endregion
	}
	#endregion
}
