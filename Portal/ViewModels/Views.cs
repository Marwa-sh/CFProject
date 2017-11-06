using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using Cf.Data;
// using PagedList;

namespace Cf.ViewModels
{
    #region AvailabilityCeilingVw class definition
    public partial class AvailabilityCeilingVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of AvailabilityCeilingVw objects to be returned in the model
		/// </summary>
		public List<AvailabilityCeilingVw> List {get; set; } = new List<AvailabilityCeilingVw>();

        /// <summary>
        /// An instance of AvailabilityCeilingVw to be returned in the model
		/// </summary>
        public AvailabilityCeilingVw Instance {get; set; } = new AvailabilityCeilingVw();
        #endregion
	}
	#endregion

    #region AvailabilityVw class definition
    public partial class AvailabilityVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of AvailabilityVw objects to be returned in the model
		/// </summary>
		public List<AvailabilityVw> List {get; set; } = new List<AvailabilityVw>();

        /// <summary>
        /// An instance of AvailabilityVw to be returned in the model
		/// </summary>
        public AvailabilityVw Instance {get; set; } = new AvailabilityVw();
        #endregion
	}
	#endregion

    #region BypassStatusVw class definition
    public partial class BypassStatusVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of BypassStatusVw objects to be returned in the model
		/// </summary>
		public List<BypassStatusVw> List {get; set; } = new List<BypassStatusVw>();

        /// <summary>
        /// An instance of BypassStatusVw to be returned in the model
		/// </summary>
        public BypassStatusVw Instance {get; set; } = new BypassStatusVw();
        #endregion
	}
	#endregion

    #region CashPaymentVw class definition
    public partial class CashPaymentVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of CashPaymentVw objects to be returned in the model
		/// </summary>
		public List<CashPaymentVw> List {get; set; } = new List<CashPaymentVw>();

        /// <summary>
        /// An instance of CashPaymentVw to be returned in the model
		/// </summary>
        public CashPaymentVw Instance {get; set; } = new CashPaymentVw();
        #endregion
	}
	#endregion

    #region CategoryVw class definition
    public partial class CategoryVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of CategoryVw objects to be returned in the model
		/// </summary>
		public List<CategoryVw> List {get; set; } = new List<CategoryVw>();

        /// <summary>
        /// An instance of CategoryVw to be returned in the model
		/// </summary>
        public CategoryVw Instance {get; set; } = new CategoryVw();
        #endregion
	}
	#endregion

    #region CollectOrderVw class definition
    public partial class CollectOrderVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of CollectOrderVw objects to be returned in the model
		/// </summary>
		public List<CollectOrderVw> List {get; set; } = new List<CollectOrderVw>();

        /// <summary>
        /// An instance of CollectOrderVw to be returned in the model
		/// </summary>
        public CollectOrderVw Instance {get; set; } = new CollectOrderVw();
        #endregion
	}
	#endregion

    #region DebtVw class definition
    public partial class DebtVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of DebtVw objects to be returned in the model
		/// </summary>
		public List<DebtVw> List {get; set; } = new List<DebtVw>();

        /// <summary>
        /// An instance of DebtVw to be returned in the model
		/// </summary>
        public DebtVw Instance {get; set; } = new DebtVw();
        #endregion
	}
	#endregion

    #region DepartmentVw class definition
    public partial class DepartmentVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of DepartmentVw objects to be returned in the model
		/// </summary>
		public List<DepartmentVw> List {get; set; } = new List<DepartmentVw>();

        /// <summary>
        /// An instance of DepartmentVw to be returned in the model
		/// </summary>
        public DepartmentVw Instance {get; set; } = new DepartmentVw();
        #endregion
	}
	#endregion

    #region DownPaymentVw class definition
    public partial class DownPaymentVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of DownPaymentVw objects to be returned in the model
		/// </summary>
		public List<DownPaymentVw> List {get; set; } = new List<DownPaymentVw>();

        /// <summary>
        /// An instance of DownPaymentVw to be returned in the model
		/// </summary>
        public DownPaymentVw Instance {get; set; } = new DownPaymentVw();
        #endregion
	}
	#endregion

    #region EmployeeDetailVw class definition
    public partial class EmployeeDetailVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of EmployeeDetailVw objects to be returned in the model
		/// </summary>
		public List<EmployeeDetailVw> List {get; set; } = new List<EmployeeDetailVw>();

        /// <summary>
        /// An instance of EmployeeDetailVw to be returned in the model
		/// </summary>
        public EmployeeDetailVw Instance {get; set; } = new EmployeeDetailVw();
        #endregion
	}
	#endregion

    #region EmployeeSeniorityVw class definition
    public partial class EmployeeSeniorityVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of EmployeeSeniorityVw objects to be returned in the model
		/// </summary>
		public List<EmployeeSeniorityVw> List {get; set; } = new List<EmployeeSeniorityVw>();

        /// <summary>
        /// An instance of EmployeeSeniorityVw to be returned in the model
		/// </summary>
        public EmployeeSeniorityVw Instance {get; set; } = new EmployeeSeniorityVw();
        #endregion
	}
	#endregion

    #region EmployeeStatusVw class definition
    public partial class EmployeeStatusVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of EmployeeStatusVw objects to be returned in the model
		/// </summary>
		public List<EmployeeStatusVw> List {get; set; } = new List<EmployeeStatusVw>();

        /// <summary>
        /// An instance of EmployeeStatusVw to be returned in the model
		/// </summary>
        public EmployeeStatusVw Instance {get; set; } = new EmployeeStatusVw();
        #endregion
	}
	#endregion

    #region EmployeeVw class definition
    public partial class EmployeeVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of EmployeeVw objects to be returned in the model
		/// </summary>
		public List<EmployeeVw> List {get; set; } = new List<EmployeeVw>();

        /// <summary>
        /// An instance of EmployeeVw to be returned in the model
		/// </summary>
        public EmployeeVw Instance {get; set; } = new EmployeeVw();
        #endregion
	}
	#endregion

    #region EndWorkGrantBracketVw class definition
    public partial class EndWorkGrantBracketVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of EndWorkGrantBracketVw objects to be returned in the model
		/// </summary>
		public List<EndWorkGrantBracketVw> List {get; set; } = new List<EndWorkGrantBracketVw>();

        /// <summary>
        /// An instance of EndWorkGrantBracketVw to be returned in the model
		/// </summary>
        public EndWorkGrantBracketVw Instance {get; set; } = new EndWorkGrantBracketVw();
        #endregion
	}
	#endregion

    #region ErrorDefinitionVw class definition
    public partial class ErrorDefinitionVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of ErrorDefinitionVw objects to be returned in the model
		/// </summary>
		public List<ErrorDefinitionVw> List {get; set; } = new List<ErrorDefinitionVw>();

        /// <summary>
        /// An instance of ErrorDefinitionVw to be returned in the model
		/// </summary>
        public ErrorDefinitionVw Instance {get; set; } = new ErrorDefinitionVw();
        #endregion
	}
	#endregion

    #region EventCategoryVw class definition
    public partial class EventCategoryVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of EventCategoryVw objects to be returned in the model
		/// </summary>
		public List<EventCategoryVw> List {get; set; } = new List<EventCategoryVw>();

        /// <summary>
        /// An instance of EventCategoryVw to be returned in the model
		/// </summary>
        public EventCategoryVw Instance {get; set; } = new EventCategoryVw();
        #endregion
	}
	#endregion

    #region EventLogDetailVw class definition
    public partial class EventLogDetailVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of EventLogDetailVw objects to be returned in the model
		/// </summary>
		public List<EventLogDetailVw> List {get; set; } = new List<EventLogDetailVw>();

        /// <summary>
        /// An instance of EventLogDetailVw to be returned in the model
		/// </summary>
        public EventLogDetailVw Instance {get; set; } = new EventLogDetailVw();
        #endregion
	}
	#endregion

    #region EventLogErrorVw class definition
    public partial class EventLogErrorVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of EventLogErrorVw objects to be returned in the model
		/// </summary>
		public List<EventLogErrorVw> List {get; set; } = new List<EventLogErrorVw>();

        /// <summary>
        /// An instance of EventLogErrorVw to be returned in the model
		/// </summary>
        public EventLogErrorVw Instance {get; set; } = new EventLogErrorVw();
        #endregion
	}
	#endregion

    #region EventLogVw class definition
    public partial class EventLogVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of EventLogVw objects to be returned in the model
		/// </summary>
		public List<EventLogVw> List {get; set; } = new List<EventLogVw>();

        /// <summary>
        /// An instance of EventLogVw to be returned in the model
		/// </summary>
        public EventLogVw Instance {get; set; } = new EventLogVw();
        #endregion
	}
	#endregion

    #region EventSourceVw class definition
    public partial class EventSourceVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of EventSourceVw objects to be returned in the model
		/// </summary>
		public List<EventSourceVw> List {get; set; } = new List<EventSourceVw>();

        /// <summary>
        /// An instance of EventSourceVw to be returned in the model
		/// </summary>
        public EventSourceVw Instance {get; set; } = new EventSourceVw();
        #endregion
	}
	#endregion

    #region EventStatusVw class definition
    public partial class EventStatusVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of EventStatusVw objects to be returned in the model
		/// </summary>
		public List<EventStatusVw> List {get; set; } = new List<EventStatusVw>();

        /// <summary>
        /// An instance of EventStatusVw to be returned in the model
		/// </summary>
        public EventStatusVw Instance {get; set; } = new EventStatusVw();
        #endregion
	}
	#endregion

    #region ExceptionalAmountTypeVw class definition
    public partial class ExceptionalAmountTypeVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of ExceptionalAmountTypeVw objects to be returned in the model
		/// </summary>
		public List<ExceptionalAmountTypeVw> List {get; set; } = new List<ExceptionalAmountTypeVw>();

        /// <summary>
        /// An instance of ExceptionalAmountTypeVw to be returned in the model
		/// </summary>
        public ExceptionalAmountTypeVw Instance {get; set; } = new ExceptionalAmountTypeVw();
        #endregion
	}
	#endregion

    #region ExceptionalAmountVw class definition
    public partial class ExceptionalAmountVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of ExceptionalAmountVw objects to be returned in the model
		/// </summary>
		public List<ExceptionalAmountVw> List {get; set; } = new List<ExceptionalAmountVw>();

        /// <summary>
        /// An instance of ExceptionalAmountVw to be returned in the model
		/// </summary>
        public ExceptionalAmountVw Instance {get; set; } = new ExceptionalAmountVw();
        #endregion
	}
	#endregion

    #region ExternalGrantVw class definition
    public partial class ExternalGrantVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of ExternalGrantVw objects to be returned in the model
		/// </summary>
		public List<ExternalGrantVw> List {get; set; } = new List<ExternalGrantVw>();

        /// <summary>
        /// An instance of ExternalGrantVw to be returned in the model
		/// </summary>
        public ExternalGrantVw Instance {get; set; } = new ExternalGrantVw();
        #endregion
	}
	#endregion

    #region GrantDecisionVw class definition
    public partial class GrantDecisionVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of GrantDecisionVw objects to be returned in the model
		/// </summary>
		public List<GrantDecisionVw> List {get; set; } = new List<GrantDecisionVw>();

        /// <summary>
        /// An instance of GrantDecisionVw to be returned in the model
		/// </summary>
        public GrantDecisionVw Instance {get; set; } = new GrantDecisionVw();
        #endregion
	}
	#endregion

    #region GrantDeductionVw class definition
    public partial class GrantDeductionVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of GrantDeductionVw objects to be returned in the model
		/// </summary>
		public List<GrantDeductionVw> List {get; set; } = new List<GrantDeductionVw>();

        /// <summary>
        /// An instance of GrantDeductionVw to be returned in the model
		/// </summary>
        public GrantDeductionVw Instance {get; set; } = new GrantDeductionVw();
        #endregion
	}
	#endregion

    #region GrantDetailVw class definition
    public partial class GrantDetailVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of GrantDetailVw objects to be returned in the model
		/// </summary>
		public List<GrantDetailVw> List {get; set; } = new List<GrantDetailVw>();

        /// <summary>
        /// An instance of GrantDetailVw to be returned in the model
		/// </summary>
        public GrantDetailVw Instance {get; set; } = new GrantDetailVw();
        #endregion
	}
	#endregion

    #region GrantPaymentOrderVw class definition
    public partial class GrantPaymentOrderVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of GrantPaymentOrderVw objects to be returned in the model
		/// </summary>
		public List<GrantPaymentOrderVw> List {get; set; } = new List<GrantPaymentOrderVw>();

        /// <summary>
        /// An instance of GrantPaymentOrderVw to be returned in the model
		/// </summary>
        public GrantPaymentOrderVw Instance {get; set; } = new GrantPaymentOrderVw();
        #endregion
	}
	#endregion

    #region GrantPaymentVw class definition
    public partial class GrantPaymentVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of GrantPaymentVw objects to be returned in the model
		/// </summary>
		public List<GrantPaymentVw> List {get; set; } = new List<GrantPaymentVw>();

        /// <summary>
        /// An instance of GrantPaymentVw to be returned in the model
		/// </summary>
        public GrantPaymentVw Instance {get; set; } = new GrantPaymentVw();
        #endregion
	}
	#endregion

    #region GrantRequestDetailVw class definition
    public partial class GrantRequestDetailVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of GrantRequestDetailVw objects to be returned in the model
		/// </summary>
		public List<GrantRequestDetailVw> List {get; set; } = new List<GrantRequestDetailVw>();

        /// <summary>
        /// An instance of GrantRequestDetailVw to be returned in the model
		/// </summary>
        public GrantRequestDetailVw Instance {get; set; } = new GrantRequestDetailVw();
        #endregion
	}
	#endregion

    #region GrantRequestVw class definition
    public partial class GrantRequestVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of GrantRequestVw objects to be returned in the model
		/// </summary>
		public List<GrantRequestVw> List {get; set; } = new List<GrantRequestVw>();

        /// <summary>
        /// An instance of GrantRequestVw to be returned in the model
		/// </summary>
        public GrantRequestVw Instance {get; set; } = new GrantRequestVw();
        #endregion
	}
	#endregion

    #region GrantTypeGroupVw class definition
    public partial class GrantTypeGroupVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of GrantTypeGroupVw objects to be returned in the model
		/// </summary>
		public List<GrantTypeGroupVw> List {get; set; } = new List<GrantTypeGroupVw>();

        /// <summary>
        /// An instance of GrantTypeGroupVw to be returned in the model
		/// </summary>
        public GrantTypeGroupVw Instance {get; set; } = new GrantTypeGroupVw();
        #endregion
	}
	#endregion

    #region GrantTypeVw class definition
    public partial class GrantTypeVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of GrantTypeVw objects to be returned in the model
		/// </summary>
		public List<GrantTypeVw> List {get; set; } = new List<GrantTypeVw>();

        /// <summary>
        /// An instance of GrantTypeVw to be returned in the model
		/// </summary>
        public GrantTypeVw Instance {get; set; } = new GrantTypeVw();
        #endregion
	}
	#endregion

    #region GrantVw class definition
    public partial class GrantVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of GrantVw objects to be returned in the model
		/// </summary>
		public List<GrantVw> List {get; set; } = new List<GrantVw>();

        /// <summary>
        /// An instance of GrantVw to be returned in the model
		/// </summary>
        public GrantVw Instance {get; set; } = new GrantVw();
        #endregion
	}
	#endregion

    #region GuarantorDetailVw class definition
    public partial class GuarantorDetailVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of GuarantorDetailVw objects to be returned in the model
		/// </summary>
		public List<GuarantorDetailVw> List {get; set; } = new List<GuarantorDetailVw>();

        /// <summary>
        /// An instance of GuarantorDetailVw to be returned in the model
		/// </summary>
        public GuarantorDetailVw Instance {get; set; } = new GuarantorDetailVw();
        #endregion
	}
	#endregion

    #region GuarantorStatementVw class definition
    public partial class GuarantorStatementVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of GuarantorStatementVw objects to be returned in the model
		/// </summary>
		public List<GuarantorStatementVw> List {get; set; } = new List<GuarantorStatementVw>();

        /// <summary>
        /// An instance of GuarantorStatementVw to be returned in the model
		/// </summary>
        public GuarantorStatementVw Instance {get; set; } = new GuarantorStatementVw();
        #endregion
	}
	#endregion

    #region GuarantorStatusVw class definition
    public partial class GuarantorStatusVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of GuarantorStatusVw objects to be returned in the model
		/// </summary>
		public List<GuarantorStatusVw> List {get; set; } = new List<GuarantorStatusVw>();

        /// <summary>
        /// An instance of GuarantorStatusVw to be returned in the model
		/// </summary>
        public GuarantorStatusVw Instance {get; set; } = new GuarantorStatusVw();
        #endregion
	}
	#endregion

    #region GuarantorVw class definition
    public partial class GuarantorVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of GuarantorVw objects to be returned in the model
		/// </summary>
		public List<GuarantorVw> List {get; set; } = new List<GuarantorVw>();

        /// <summary>
        /// An instance of GuarantorVw to be returned in the model
		/// </summary>
        public GuarantorVw Instance {get; set; } = new GuarantorVw();
        #endregion
	}
	#endregion

    #region HealthLoanDecisionFirstPaymentVw class definition
    public partial class HealthLoanDecisionFirstPaymentVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of HealthLoanDecisionFirstPaymentVw objects to be returned in the model
		/// </summary>
		public List<HealthLoanDecisionFirstPaymentVw> List {get; set; } = new List<HealthLoanDecisionFirstPaymentVw>();

        /// <summary>
        /// An instance of HealthLoanDecisionFirstPaymentVw to be returned in the model
		/// </summary>
        public HealthLoanDecisionFirstPaymentVw Instance {get; set; } = new HealthLoanDecisionFirstPaymentVw();
        #endregion
	}
	#endregion

    #region HealthLoanDecisionVw class definition
    public partial class HealthLoanDecisionVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of HealthLoanDecisionVw objects to be returned in the model
		/// </summary>
		public List<HealthLoanDecisionVw> List {get; set; } = new List<HealthLoanDecisionVw>();

        /// <summary>
        /// An instance of HealthLoanDecisionVw to be returned in the model
		/// </summary>
        public HealthLoanDecisionVw Instance {get; set; } = new HealthLoanDecisionVw();
        #endregion
	}
	#endregion

    #region IncomingLoanVw class definition
    public partial class IncomingLoanVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of IncomingLoanVw objects to be returned in the model
		/// </summary>
		public List<IncomingLoanVw> List {get; set; } = new List<IncomingLoanVw>();

        /// <summary>
        /// An instance of IncomingLoanVw to be returned in the model
		/// </summary>
        public IncomingLoanVw Instance {get; set; } = new IncomingLoanVw();
        #endregion
	}
	#endregion

    #region InstallmentDecreaseOrderVw class definition
    public partial class InstallmentDecreaseOrderVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of InstallmentDecreaseOrderVw objects to be returned in the model
		/// </summary>
		public List<InstallmentDecreaseOrderVw> List {get; set; } = new List<InstallmentDecreaseOrderVw>();

        /// <summary>
        /// An instance of InstallmentDecreaseOrderVw to be returned in the model
		/// </summary>
        public InstallmentDecreaseOrderVw Instance {get; set; } = new InstallmentDecreaseOrderVw();
        #endregion
	}
	#endregion

    #region InstallmentDecreaseVw class definition
    public partial class InstallmentDecreaseVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of InstallmentDecreaseVw objects to be returned in the model
		/// </summary>
		public List<InstallmentDecreaseVw> List {get; set; } = new List<InstallmentDecreaseVw>();

        /// <summary>
        /// An instance of InstallmentDecreaseVw to be returned in the model
		/// </summary>
        public InstallmentDecreaseVw Instance {get; set; } = new InstallmentDecreaseVw();
        #endregion
	}
	#endregion

    #region InstallmentVw class definition
    public partial class InstallmentVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of InstallmentVw objects to be returned in the model
		/// </summary>
		public List<InstallmentVw> List {get; set; } = new List<InstallmentVw>();

        /// <summary>
        /// An instance of InstallmentVw to be returned in the model
		/// </summary>
        public InstallmentVw Instance {get; set; } = new InstallmentVw();
        #endregion
	}
	#endregion

    #region InsuranceTypeVw class definition
    public partial class InsuranceTypeVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of InsuranceTypeVw objects to be returned in the model
		/// </summary>
		public List<InsuranceTypeVw> List {get; set; } = new List<InsuranceTypeVw>();

        /// <summary>
        /// An instance of InsuranceTypeVw to be returned in the model
		/// </summary>
        public InsuranceTypeVw Instance {get; set; } = new InsuranceTypeVw();
        #endregion
	}
	#endregion

    #region IssuerVw class definition
    public partial class IssuerVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of IssuerVw objects to be returned in the model
		/// </summary>
		public List<IssuerVw> List {get; set; } = new List<IssuerVw>();

        /// <summary>
        /// An instance of IssuerVw to be returned in the model
		/// </summary>
        public IssuerVw Instance {get; set; } = new IssuerVw();
        #endregion
	}
	#endregion

    #region LoanChangeVw class definition
    public partial class LoanChangeVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of LoanChangeVw objects to be returned in the model
		/// </summary>
		public List<LoanChangeVw> List {get; set; } = new List<LoanChangeVw>();

        /// <summary>
        /// An instance of LoanChangeVw to be returned in the model
		/// </summary>
        public LoanChangeVw Instance {get; set; } = new LoanChangeVw();
        #endregion
	}
	#endregion

    #region LoanDecisionTypeVw class definition
    public partial class LoanDecisionTypeVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of LoanDecisionTypeVw objects to be returned in the model
		/// </summary>
		public List<LoanDecisionTypeVw> List {get; set; } = new List<LoanDecisionTypeVw>();

        /// <summary>
        /// An instance of LoanDecisionTypeVw to be returned in the model
		/// </summary>
        public LoanDecisionTypeVw Instance {get; set; } = new LoanDecisionTypeVw();
        #endregion
	}
	#endregion

    #region LoanDecisionVw class definition
    public partial class LoanDecisionVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of LoanDecisionVw objects to be returned in the model
		/// </summary>
		public List<LoanDecisionVw> List {get; set; } = new List<LoanDecisionVw>();

        /// <summary>
        /// An instance of LoanDecisionVw to be returned in the model
		/// </summary>
        public LoanDecisionVw Instance {get; set; } = new LoanDecisionVw();
        #endregion
	}
	#endregion

    #region LoanDetailVw class definition
    public partial class LoanDetailVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of LoanDetailVw objects to be returned in the model
		/// </summary>
		public List<LoanDetailVw> List {get; set; } = new List<LoanDetailVw>();

        /// <summary>
        /// An instance of LoanDetailVw to be returned in the model
		/// </summary>
        public LoanDetailVw Instance {get; set; } = new LoanDetailVw();
        #endregion
	}
	#endregion

    #region LoanGenerationStatusVw class definition
    public partial class LoanGenerationStatusVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of LoanGenerationStatusVw objects to be returned in the model
		/// </summary>
		public List<LoanGenerationStatusVw> List {get; set; } = new List<LoanGenerationStatusVw>();

        /// <summary>
        /// An instance of LoanGenerationStatusVw to be returned in the model
		/// </summary>
        public LoanGenerationStatusVw Instance {get; set; } = new LoanGenerationStatusVw();
        #endregion
	}
	#endregion

    #region LoanRequestVw class definition
    public partial class LoanRequestVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of LoanRequestVw objects to be returned in the model
		/// </summary>
		public List<LoanRequestVw> List {get; set; } = new List<LoanRequestVw>();

        /// <summary>
        /// An instance of LoanRequestVw to be returned in the model
		/// </summary>
        public LoanRequestVw Instance {get; set; } = new LoanRequestVw();
        #endregion
	}
	#endregion

    #region LoanStatusVw class definition
    public partial class LoanStatusVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of LoanStatusVw objects to be returned in the model
		/// </summary>
		public List<LoanStatusVw> List {get; set; } = new List<LoanStatusVw>();

        /// <summary>
        /// An instance of LoanStatusVw to be returned in the model
		/// </summary>
        public LoanStatusVw Instance {get; set; } = new LoanStatusVw();
        #endregion
	}
	#endregion

    #region LoanTypeClosureVw class definition
    public partial class LoanTypeClosureVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of LoanTypeClosureVw objects to be returned in the model
		/// </summary>
		public List<LoanTypeClosureVw> List {get; set; } = new List<LoanTypeClosureVw>();

        /// <summary>
        /// An instance of LoanTypeClosureVw to be returned in the model
		/// </summary>
        public LoanTypeClosureVw Instance {get; set; } = new LoanTypeClosureVw();
        #endregion
	}
	#endregion

    #region LoanTypeVw class definition
    public partial class LoanTypeVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of LoanTypeVw objects to be returned in the model
		/// </summary>
		public List<LoanTypeVw> List {get; set; } = new List<LoanTypeVw>();

        /// <summary>
        /// An instance of LoanTypeVw to be returned in the model
		/// </summary>
        public LoanTypeVw Instance {get; set; } = new LoanTypeVw();
        #endregion
	}
	#endregion

    #region LoanVw class definition
    public partial class LoanVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of LoanVw objects to be returned in the model
		/// </summary>
		public List<LoanVw> List {get; set; } = new List<LoanVw>();

        /// <summary>
        /// An instance of LoanVw to be returned in the model
		/// </summary>
        public LoanVw Instance {get; set; } = new LoanVw();
        #endregion
	}
	#endregion

    #region MainWorkPlaceVw class definition
    public partial class MainWorkPlaceVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of MainWorkPlaceVw objects to be returned in the model
		/// </summary>
		public List<MainWorkPlaceVw> List {get; set; } = new List<MainWorkPlaceVw>();

        /// <summary>
        /// An instance of MainWorkPlaceVw to be returned in the model
		/// </summary>
        public MainWorkPlaceVw Instance {get; set; } = new MainWorkPlaceVw();
        #endregion
	}
	#endregion

    #region MissingInstallmentDecreaseVw class definition
    public partial class MissingInstallmentDecreaseVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of MissingInstallmentDecreaseVw objects to be returned in the model
		/// </summary>
		public List<MissingInstallmentDecreaseVw> List {get; set; } = new List<MissingInstallmentDecreaseVw>();

        /// <summary>
        /// An instance of MissingInstallmentDecreaseVw to be returned in the model
		/// </summary>
        public MissingInstallmentDecreaseVw Instance {get; set; } = new MissingInstallmentDecreaseVw();
        #endregion
	}
	#endregion

    #region MonthlyBalanceVw class definition
    public partial class MonthlyBalanceVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of MonthlyBalanceVw objects to be returned in the model
		/// </summary>
		public List<MonthlyBalanceVw> List {get; set; } = new List<MonthlyBalanceVw>();

        /// <summary>
        /// An instance of MonthlyBalanceVw to be returned in the model
		/// </summary>
        public MonthlyBalanceVw Instance {get; set; } = new MonthlyBalanceVw();
        #endregion
	}
	#endregion

    #region OutgoingLoanVw class definition
    public partial class OutgoingLoanVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of OutgoingLoanVw objects to be returned in the model
		/// </summary>
		public List<OutgoingLoanVw> List {get; set; } = new List<OutgoingLoanVw>();

        /// <summary>
        /// An instance of OutgoingLoanVw to be returned in the model
		/// </summary>
        public OutgoingLoanVw Instance {get; set; } = new OutgoingLoanVw();
        #endregion
	}
	#endregion

    #region PaymentDetailVw class definition
    public partial class PaymentDetailVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of PaymentDetailVw objects to be returned in the model
		/// </summary>
		public List<PaymentDetailVw> List {get; set; } = new List<PaymentDetailVw>();

        /// <summary>
        /// An instance of PaymentDetailVw to be returned in the model
		/// </summary>
        public PaymentDetailVw Instance {get; set; } = new PaymentDetailVw();
        #endregion
	}
	#endregion

    #region PaymentGroupVw class definition
    public partial class PaymentGroupVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of PaymentGroupVw objects to be returned in the model
		/// </summary>
		public List<PaymentGroupVw> List {get; set; } = new List<PaymentGroupVw>();

        /// <summary>
        /// An instance of PaymentGroupVw to be returned in the model
		/// </summary>
        public PaymentGroupVw Instance {get; set; } = new PaymentGroupVw();
        #endregion
	}
	#endregion

    #region PaymentStatusVw class definition
    public partial class PaymentStatusVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of PaymentStatusVw objects to be returned in the model
		/// </summary>
		public List<PaymentStatusVw> List {get; set; } = new List<PaymentStatusVw>();

        /// <summary>
        /// An instance of PaymentStatusVw to be returned in the model
		/// </summary>
        public PaymentStatusVw Instance {get; set; } = new PaymentStatusVw();
        #endregion
	}
	#endregion

    #region PaymentVw class definition
    public partial class PaymentVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of PaymentVw objects to be returned in the model
		/// </summary>
		public List<PaymentVw> List {get; set; } = new List<PaymentVw>();

        /// <summary>
        /// An instance of PaymentVw to be returned in the model
		/// </summary>
        public PaymentVw Instance {get; set; } = new PaymentVw();
        #endregion
	}
	#endregion

    #region PayOrderVw class definition
    public partial class PayOrderVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of PayOrderVw objects to be returned in the model
		/// </summary>
		public List<PayOrderVw> List {get; set; } = new List<PayOrderVw>();

        /// <summary>
        /// An instance of PayOrderVw to be returned in the model
		/// </summary>
        public PayOrderVw Instance {get; set; } = new PayOrderVw();
        #endregion
	}
	#endregion

    #region ProductDetailVw class definition
    public partial class ProductDetailVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of ProductDetailVw objects to be returned in the model
		/// </summary>
		public List<ProductDetailVw> List {get; set; } = new List<ProductDetailVw>();

        /// <summary>
        /// An instance of ProductDetailVw to be returned in the model
		/// </summary>
        public ProductDetailVw Instance {get; set; } = new ProductDetailVw();
        #endregion
	}
	#endregion

    #region ProductTypeAvailabilityVw class definition
    public partial class ProductTypeAvailabilityVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of ProductTypeAvailabilityVw objects to be returned in the model
		/// </summary>
		public List<ProductTypeAvailabilityVw> List {get; set; } = new List<ProductTypeAvailabilityVw>();

        /// <summary>
        /// An instance of ProductTypeAvailabilityVw to be returned in the model
		/// </summary>
        public ProductTypeAvailabilityVw Instance {get; set; } = new ProductTypeAvailabilityVw();
        #endregion
	}
	#endregion

    #region ProductTypeDetailVw class definition
    public partial class ProductTypeDetailVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of ProductTypeDetailVw objects to be returned in the model
		/// </summary>
		public List<ProductTypeDetailVw> List {get; set; } = new List<ProductTypeDetailVw>();

        /// <summary>
        /// An instance of ProductTypeDetailVw to be returned in the model
		/// </summary>
        public ProductTypeDetailVw Instance {get; set; } = new ProductTypeDetailVw();
        #endregion
	}
	#endregion

    #region ProductTypeVw class definition
    public partial class ProductTypeVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of ProductTypeVw objects to be returned in the model
		/// </summary>
		public List<ProductTypeVw> List {get; set; } = new List<ProductTypeVw>();

        /// <summary>
        /// An instance of ProductTypeVw to be returned in the model
		/// </summary>
        public ProductTypeVw Instance {get; set; } = new ProductTypeVw();
        #endregion
	}
	#endregion

    #region ProductVw class definition
    public partial class ProductVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of ProductVw objects to be returned in the model
		/// </summary>
		public List<ProductVw> List {get; set; } = new List<ProductVw>();

        /// <summary>
        /// An instance of ProductVw to be returned in the model
		/// </summary>
        public ProductVw Instance {get; set; } = new ProductVw();
        #endregion
	}
	#endregion

    #region ProfileVw class definition
    public partial class ProfileVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of ProfileVw objects to be returned in the model
		/// </summary>
		public List<ProfileVw> List {get; set; } = new List<ProfileVw>();

        /// <summary>
        /// An instance of ProfileVw to be returned in the model
		/// </summary>
        public ProfileVw Instance {get; set; } = new ProfileVw();
        #endregion
	}
	#endregion

    #region ProfitStrategyVw class definition
    public partial class ProfitStrategyVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of ProfitStrategyVw objects to be returned in the model
		/// </summary>
		public List<ProfitStrategyVw> List {get; set; } = new List<ProfitStrategyVw>();

        /// <summary>
        /// An instance of ProfitStrategyVw to be returned in the model
		/// </summary>
        public ProfitStrategyVw Instance {get; set; } = new ProfitStrategyVw();
        #endregion
	}
	#endregion

    #region RefundableProductVw class definition
    public partial class RefundableProductVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of RefundableProductVw objects to be returned in the model
		/// </summary>
		public List<RefundableProductVw> List {get; set; } = new List<RefundableProductVw>();

        /// <summary>
        /// An instance of RefundableProductVw to be returned in the model
		/// </summary>
        public RefundableProductVw Instance {get; set; } = new RefundableProductVw();
        #endregion
	}
	#endregion

    #region RequestDetailVw class definition
    public partial class RequestDetailVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of RequestDetailVw objects to be returned in the model
		/// </summary>
		public List<RequestDetailVw> List {get; set; } = new List<RequestDetailVw>();

        /// <summary>
        /// An instance of RequestDetailVw to be returned in the model
		/// </summary>
        public RequestDetailVw Instance {get; set; } = new RequestDetailVw();
        #endregion
	}
	#endregion

    #region RequestStatusVw class definition
    public partial class RequestStatusVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of RequestStatusVw objects to be returned in the model
		/// </summary>
		public List<RequestStatusVw> List {get; set; } = new List<RequestStatusVw>();

        /// <summary>
        /// An instance of RequestStatusVw to be returned in the model
		/// </summary>
        public RequestStatusVw Instance {get; set; } = new RequestStatusVw();
        #endregion
	}
	#endregion

    #region RequestVw class definition
    public partial class RequestVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of RequestVw objects to be returned in the model
		/// </summary>
		public List<RequestVw> List {get; set; } = new List<RequestVw>();

        /// <summary>
        /// An instance of RequestVw to be returned in the model
		/// </summary>
        public RequestVw Instance {get; set; } = new RequestVw();
        #endregion
	}
	#endregion

    #region ResourceVw class definition
    public partial class ResourceVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of ResourceVw objects to be returned in the model
		/// </summary>
		public List<ResourceVw> List {get; set; } = new List<ResourceVw>();

        /// <summary>
        /// An instance of ResourceVw to be returned in the model
		/// </summary>
        public ResourceVw Instance {get; set; } = new ResourceVw();
        #endregion
	}
	#endregion

    #region SalaryPaymentVw class definition
    public partial class SalaryPaymentVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of SalaryPaymentVw objects to be returned in the model
		/// </summary>
		public List<SalaryPaymentVw> List {get; set; } = new List<SalaryPaymentVw>();

        /// <summary>
        /// An instance of SalaryPaymentVw to be returned in the model
		/// </summary>
        public SalaryPaymentVw Instance {get; set; } = new SalaryPaymentVw();
        #endregion
	}
	#endregion

    #region SalaryWorkPlaceVw class definition
    public partial class SalaryWorkPlaceVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of SalaryWorkPlaceVw objects to be returned in the model
		/// </summary>
		public List<SalaryWorkPlaceVw> List {get; set; } = new List<SalaryWorkPlaceVw>();

        /// <summary>
        /// An instance of SalaryWorkPlaceVw to be returned in the model
		/// </summary>
        public SalaryWorkPlaceVw Instance {get; set; } = new SalaryWorkPlaceVw();
        #endregion
	}
	#endregion

    #region ServiceEndGrantRequestVw class definition
    public partial class ServiceEndGrantRequestVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of ServiceEndGrantRequestVw objects to be returned in the model
		/// </summary>
		public List<ServiceEndGrantRequestVw> List {get; set; } = new List<ServiceEndGrantRequestVw>();

        /// <summary>
        /// An instance of ServiceEndGrantRequestVw to be returned in the model
		/// </summary>
        public ServiceEndGrantRequestVw Instance {get; set; } = new ServiceEndGrantRequestVw();
        #endregion
	}
	#endregion

    #region SettlementVw class definition
    public partial class SettlementVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of SettlementVw objects to be returned in the model
		/// </summary>
		public List<SettlementVw> List {get; set; } = new List<SettlementVw>();

        /// <summary>
        /// An instance of SettlementVw to be returned in the model
		/// </summary>
        public SettlementVw Instance {get; set; } = new SettlementVw();
        #endregion
	}
	#endregion

    #region SpecialCaseLoanVw class definition
    public partial class SpecialCaseLoanVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of SpecialCaseLoanVw objects to be returned in the model
		/// </summary>
		public List<SpecialCaseLoanVw> List {get; set; } = new List<SpecialCaseLoanVw>();

        /// <summary>
        /// An instance of SpecialCaseLoanVw to be returned in the model
		/// </summary>
        public SpecialCaseLoanVw Instance {get; set; } = new SpecialCaseLoanVw();
        #endregion
	}
	#endregion

    #region SubscriptionTypeVw class definition
    public partial class SubscriptionTypeVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of SubscriptionTypeVw objects to be returned in the model
		/// </summary>
		public List<SubscriptionTypeVw> List {get; set; } = new List<SubscriptionTypeVw>();

        /// <summary>
        /// An instance of SubscriptionTypeVw to be returned in the model
		/// </summary>
        public SubscriptionTypeVw Instance {get; set; } = new SubscriptionTypeVw();
        #endregion
	}
	#endregion

    #region SubscriptionVw class definition
    public partial class SubscriptionVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of SubscriptionVw objects to be returned in the model
		/// </summary>
		public List<SubscriptionVw> List {get; set; } = new List<SubscriptionVw>();

        /// <summary>
        /// An instance of SubscriptionVw to be returned in the model
		/// </summary>
        public SubscriptionVw Instance {get; set; } = new SubscriptionVw();
        #endregion
	}
	#endregion

    #region TransitoryIncomingLoanVw class definition
    public partial class TransitoryIncomingLoanVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of TransitoryIncomingLoanVw objects to be returned in the model
		/// </summary>
		public List<TransitoryIncomingLoanVw> List {get; set; } = new List<TransitoryIncomingLoanVw>();

        /// <summary>
        /// An instance of TransitoryIncomingLoanVw to be returned in the model
		/// </summary>
        public TransitoryIncomingLoanVw Instance {get; set; } = new TransitoryIncomingLoanVw();
        #endregion
	}
	#endregion

    #region WarrantVw class definition
    public partial class WarrantVwViewModel
	{
		#region Public properties
		/// <summary>
        /// A list of WarrantVw objects to be returned in the model
		/// </summary>
		public List<WarrantVw> List {get; set; } = new List<WarrantVw>();

        /// <summary>
        /// An instance of WarrantVw to be returned in the model
		/// </summary>
        public WarrantVw Instance {get; set; } = new WarrantVw();
        #endregion
	}
	#endregion
}
