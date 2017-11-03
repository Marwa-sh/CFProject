using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using PagedList;

namespace Cf.Data
{
    #region AvailabilityVw class definition
    public partial class AvailabilityVw
	{
		#region Public properties
        /// <summary>
        /// A list of related AvailabilityCeilingVw objects
		/// </summary>
		public List<AvailabilityCeilingVw> AvailabilityCeilingVwList {get; set;}

        /// <summary>
        /// A list of related ProductTypeAvailabilityVw objects
		/// </summary>
		public List<ProductTypeAvailabilityVw> ProductTypeAvailabilityVwList {get; set;}
		#endregion
    }
	#endregion

    #region BypassStatusVw class definition
    public partial class BypassStatusVw
	{
		#region Public properties
        /// <summary>
        /// A list of related RequestVw objects
		/// </summary>
		public List<RequestVw> RequestVwList {get; set;}
		#endregion
    }
	#endregion

    #region CategoryVw class definition
    public partial class CategoryVw
	{
		#region Public properties
        /// <summary>
        /// A list of related EmployeeVw objects
		/// </summary>
		public List<EmployeeVw> EmployeeVwList {get; set;}
		#endregion
    }
	#endregion

    #region CollectOrderVw class definition
    public partial class CollectOrderVw
	{
		#region Public properties
        /// <summary>
        /// A list of related PaymentVw objects
		/// </summary>
		public List<PaymentVw> PaymentVwList {get; set;}
		#endregion
    }
	#endregion

    #region DebtVw class definition
    public partial class DebtVw
	{
		#region Public properties
        /// <summary>
        /// A list of related WarrantVw objects
		/// </summary>
		public List<WarrantVw> WarrantVwList {get; set;}
		#endregion
    }
	#endregion

    #region DepartmentVw class definition
    public partial class DepartmentVw
	{
		#region Public properties
        /// <summary>
        /// A list of related EmployeeVw objects
		/// </summary>
		public List<EmployeeVw> EmployeeVwList {get; set;}

        /// <summary>
        /// A list of related InstallmentDecreaseVw objects
		/// </summary>
		public List<InstallmentDecreaseVw> InstallmentDecreaseVwList {get; set;}

        /// <summary>
        /// A list of related SalaryPaymentVw objects
		/// </summary>
		public List<SalaryPaymentVw> SalaryPaymentVwList {get; set;}

        /// <summary>
        /// A list of related SubscriptionVw objects
		/// </summary>
		public List<SubscriptionVw> SubscriptionVwList {get; set;}
		#endregion
    }
	#endregion

    #region EmployeeDetailVw class definition
    public partial class EmployeeDetailVw
	{
		#region Public properties
		/// <summary>
        /// A reference to related MissingInstallmentDecrease child object
		/// </summary>
		public MissingInstallmentDecrease MissingInstallmentDecrease {get; set;}

        /// <summary>
        /// A list of related Debt objects
		/// </summary>
		public List<Debt> DebtList {get; set;}

		/// <summary>
        /// A reference to related EmployeeSeniority child object
		/// </summary>
		public EmployeeSeniority EmployeeSeniority {get; set;}

        /// <summary>
        /// A list of related ExternalGrant objects
		/// </summary>
		public List<ExternalGrant> ExternalGrantList {get; set;}

        /// <summary>
        /// A list of related GuarantorDetailVw objects
		/// </summary>
		public List<GuarantorDetailVw> GuarantorDetailVwList {get; set;}

        /// <summary>
        /// A list of related HealthLoanDecisionFirstPayment objects
		/// </summary>
		public List<HealthLoanDecisionFirstPayment> HealthLoanDecisionFirstPaymentList {get; set;}

        /// <summary>
        /// A list of related InstallmentDecrease objects
		/// </summary>
		public List<InstallmentDecrease> InstallmentDecreaseList {get; set;}

        /// <summary>
        /// A list of related MonthlyBalance objects
		/// </summary>
		public List<MonthlyBalance> MonthlyBalanceList {get; set;}

        /// <summary>
        /// A list of related PaymentDetailVw objects
		/// </summary>
		public List<PaymentDetailVw> PaymentDetailVwList {get; set;}

        /// <summary>
        /// A list of related PayOrder objects
		/// </summary>
		public List<PayOrder> PayOrderList {get; set;}

        /// <summary>
        /// A list of related ProductDetailVw objects
		/// </summary>
		public List<ProductDetailVw> ProductDetailVwList {get; set;}

		/// <summary>
        /// A reference to related Profile child object
		/// </summary>
		public Profile Profile {get; set;}

        /// <summary>
        /// A list of related SpecialCaseLoan objects
		/// </summary>
		public List<SpecialCaseLoan> SpecialCaseLoanList {get; set;}

        /// <summary>
        /// A list of related Subscription objects
		/// </summary>
		public List<Subscription> SubscriptionList {get; set;}

		/// <summary>
        /// A reference to related TransitoryIncomingLoan child object
		/// </summary>
		public TransitoryIncomingLoan TransitoryIncomingLoan {get; set;}

        /// <summary>
        /// A list of related Warrant objects
		/// </summary>
		public List<Warrant> WarrantList {get; set;}
		#endregion
    }
	#endregion

    #region EmployeeStatusVw class definition
    public partial class EmployeeStatusVw
	{
		#region Public properties
        /// <summary>
        /// A list of related EmployeeVw objects
		/// </summary>
		public List<EmployeeVw> EmployeeVwList {get; set;}
		#endregion
    }
	#endregion

    #region EmployeeVw class definition
    public partial class EmployeeVw
	{
		#region Public properties
		/// <summary>
        /// A reference to related MissingInstallmentDecreaseVw child object
		/// </summary>
		public MissingInstallmentDecreaseVw MissingInstallmentDecreaseVw {get; set;}

        /// <summary>
        /// A list of related DebtVw objects
		/// </summary>
		public List<DebtVw> DebtVwList {get; set;}

		/// <summary>
        /// A reference to related EmployeeSeniorityVw child object
		/// </summary>
		public EmployeeSeniorityVw EmployeeSeniorityVw {get; set;}

        /// <summary>
        /// A list of related ExternalGrantVw objects
		/// </summary>
		public List<ExternalGrantVw> ExternalGrantVwList {get; set;}

        /// <summary>
        /// A list of related GuarantorVw objects
		/// </summary>
		public List<GuarantorVw> GuarantorVwList {get; set;}

        /// <summary>
        /// A list of related HealthLoanDecisionFirstPaymentVw objects
		/// </summary>
		public List<HealthLoanDecisionFirstPaymentVw> HealthLoanDecisionFirstPaymentVwList {get; set;}

        /// <summary>
        /// A list of related InstallmentDecreaseVw objects
		/// </summary>
		public List<InstallmentDecreaseVw> InstallmentDecreaseVwList {get; set;}

        /// <summary>
        /// A list of related MonthlyBalanceVw objects
		/// </summary>
		public List<MonthlyBalanceVw> MonthlyBalanceVwList {get; set;}

        /// <summary>
        /// A list of related PaymentVw objects
		/// </summary>
		public List<PaymentVw> PaymentVwList {get; set;}

        /// <summary>
        /// A list of related PayOrderVw objects
		/// </summary>
		public List<PayOrderVw> PayOrderVwList {get; set;}

        /// <summary>
        /// A list of related ProductVw objects
		/// </summary>
		public List<ProductVw> ProductVwList {get; set;}

		/// <summary>
        /// A reference to related ProfileVw child object
		/// </summary>
		public ProfileVw ProfileVw {get; set;}

        /// <summary>
        /// A list of related SpecialCaseLoanVw objects
		/// </summary>
		public List<SpecialCaseLoanVw> SpecialCaseLoanVwList {get; set;}

        /// <summary>
        /// A list of related SubscriptionVw objects
		/// </summary>
		public List<SubscriptionVw> SubscriptionVwList {get; set;}

		/// <summary>
        /// A reference to related TransitoryIncomingLoanVw child object
		/// </summary>
		public TransitoryIncomingLoanVw TransitoryIncomingLoanVw {get; set;}

        /// <summary>
        /// A list of related WarrantVw objects
		/// </summary>
		public List<WarrantVw> WarrantVwList {get; set;}
		#endregion
    }
	#endregion

    #region EventCategoryVw class definition
    public partial class EventCategoryVw
	{
		#region Public properties
        /// <summary>
        /// A list of related EventLogVw objects
		/// </summary>
		public List<EventLogVw> EventLogVwList {get; set;}
		#endregion
    }
	#endregion

    #region EventLogDetailVw class definition
    public partial class EventLogDetailVw
	{
		#region Public properties
		/// <summary>
        /// A reference to related EventLogError child object
		/// </summary>
		public EventLogError EventLogError {get; set;}
		#endregion
    }
	#endregion

    #region EventLogVw class definition
    public partial class EventLogVw
	{
		#region Public properties
		/// <summary>
        /// A reference to related EventLogErrorVw child object
		/// </summary>
		public EventLogErrorVw EventLogErrorVw {get; set;}
		#endregion
    }
	#endregion

    #region EventSourceVw class definition
    public partial class EventSourceVw
	{
		#region Public properties
        /// <summary>
        /// A list of related EventLogVw objects
		/// </summary>
		public List<EventLogVw> EventLogVwList {get; set;}
		#endregion
    }
	#endregion

    #region EventStatusVw class definition
    public partial class EventStatusVw
	{
		#region Public properties
        /// <summary>
        /// A list of related EventLogVw objects
		/// </summary>
		public List<EventLogVw> EventLogVwList {get; set;}
		#endregion
    }
	#endregion

    #region ExceptionalAmountTypeVw class definition
    public partial class ExceptionalAmountTypeVw
	{
		#region Public properties
        /// <summary>
        /// A list of related ExceptionalAmountVw objects
		/// </summary>
		public List<ExceptionalAmountVw> ExceptionalAmountVwList {get; set;}
		#endregion
    }
	#endregion

    #region GrantDecisionVw class definition
    public partial class GrantDecisionVw
	{
		#region Public properties
        /// <summary>
        /// A list of related GrantVw objects
		/// </summary>
		public List<GrantVw> GrantVwList {get; set;}
		#endregion
    }
	#endregion

    #region GrantDetailVw class definition
    public partial class GrantDetailVw
	{
		#region Public properties
		/// <summary>
        /// A reference to related GrantDeduction child object
		/// </summary>
		public GrantDeduction GrantDeduction {get; set;}

        /// <summary>
        /// A list of related GrantPayment objects
		/// </summary>
		public List<GrantPayment> GrantPaymentList {get; set;}

		/// <summary>
        /// A reference to related ProductDetailVw object
		/// </summary>
		public ProductDetailVw ProductDetailVw {get; set;}
		#endregion
    }
	#endregion

    #region GrantPaymentOrderVw class definition
    public partial class GrantPaymentOrderVw
	{
		#region Public properties
        /// <summary>
        /// A list of related GrantPaymentVw objects
		/// </summary>
		public List<GrantPaymentVw> GrantPaymentVwList {get; set;}
		#endregion
    }
	#endregion

    #region GrantRequestDetailVw class definition
    public partial class GrantRequestDetailVw
	{
		#region Public properties
		/// <summary>
        /// A reference to related ServiceEndGrantRequest child object
		/// </summary>
		public ServiceEndGrantRequest ServiceEndGrantRequest {get; set;}

		/// <summary>
        /// A reference to related RequestDetailVw object
		/// </summary>
		public RequestDetailVw RequestDetailVw {get; set;}
		#endregion
    }
	#endregion

    #region GrantRequestVw class definition
    public partial class GrantRequestVw
	{
		#region Public properties
		/// <summary>
        /// A reference to related ServiceEndGrantRequestVw child object
		/// </summary>
		public ServiceEndGrantRequestVw ServiceEndGrantRequestVw {get; set;}

		/// <summary>
        /// A reference to related RequestVw object
		/// </summary>
		public RequestVw RequestVw {get; set;}
		#endregion
    }
	#endregion

    #region GrantTypeGroupVw class definition
    public partial class GrantTypeGroupVw
	{
		#region Public properties
        /// <summary>
        /// A list of related GrantDecisionVw objects
		/// </summary>
		public List<GrantDecisionVw> GrantDecisionVwList {get; set;}

        /// <summary>
        /// A list of related GrantTypeVw objects
		/// </summary>
		public List<GrantTypeVw> GrantTypeVwList {get; set;}
		#endregion
    }
	#endregion

    #region GrantTypeVw class definition
    public partial class GrantTypeVw
	{
		#region Public properties
        /// <summary>
        /// A list of related GrantRequestVw objects
		/// </summary>
		public List<GrantRequestVw> GrantRequestVwList {get; set;}

        /// <summary>
        /// A list of related ExternalGrantVw objects
		/// </summary>
		public List<ExternalGrantVw> ExternalGrantVwList {get; set;}
		#endregion
    }
	#endregion

    #region GrantVw class definition
    public partial class GrantVw
	{
		#region Public properties
		/// <summary>
        /// A reference to related GrantDeductionVw child object
		/// </summary>
		public GrantDeductionVw GrantDeductionVw {get; set;}

        /// <summary>
        /// A list of related GrantPaymentVw objects
		/// </summary>
		public List<GrantPaymentVw> GrantPaymentVwList {get; set;}

		/// <summary>
        /// A reference to related ProductVw object
		/// </summary>
		public ProductVw ProductVw {get; set;}
		#endregion
    }
	#endregion

    #region GuarantorDetailVw class definition
    public partial class GuarantorDetailVw
	{
		#region Public properties
		/// <summary>
        /// A reference to related GuarantorStatement child object
		/// </summary>
		public GuarantorStatement GuarantorStatement {get; set;}
		#endregion
    }
	#endregion

    #region GuarantorStatusVw class definition
    public partial class GuarantorStatusVw
	{
		#region Public properties
        /// <summary>
        /// A list of related GuarantorVw objects
		/// </summary>
		public List<GuarantorVw> GuarantorVwList {get; set;}
		#endregion
    }
	#endregion

    #region GuarantorVw class definition
    public partial class GuarantorVw
	{
		#region Public properties
		/// <summary>
        /// A reference to related GuarantorStatementVw child object
		/// </summary>
		public GuarantorStatementVw GuarantorStatementVw {get; set;}
		#endregion
    }
	#endregion

    #region HealthLoanDecisionVw class definition
    public partial class HealthLoanDecisionVw
	{
		#region Public properties
        /// <summary>
        /// A list of related HealthLoanDecisionFirstPaymentVw objects
		/// </summary>
		public List<HealthLoanDecisionFirstPaymentVw> HealthLoanDecisionFirstPaymentVwList {get; set;}
		#endregion
    }
	#endregion

    #region InstallmentDecreaseOrderVw class definition
    public partial class InstallmentDecreaseOrderVw
	{
		#region Public properties
        /// <summary>
        /// A list of related InstallmentDecreaseVw objects
		/// </summary>
		public List<InstallmentDecreaseVw> InstallmentDecreaseVwList {get; set;}
		#endregion
    }
	#endregion

    #region InstallmentVw class definition
    public partial class InstallmentVw
	{
		#region Public properties
        /// <summary>
        /// A list of related SettlementVw objects
		/// </summary>
		public List<SettlementVw> SettlementVwList {get; set;}
		#endregion
    }
	#endregion

    #region InsuranceTypeVw class definition
    public partial class InsuranceTypeVw
	{
		#region Public properties
        /// <summary>
        /// A list of related HealthLoanDecisionFirstPaymentVw objects
		/// </summary>
		public List<HealthLoanDecisionFirstPaymentVw> HealthLoanDecisionFirstPaymentVwList {get; set;}
		#endregion
    }
	#endregion

    #region IssuerVw class definition
    public partial class IssuerVw
	{
		#region Public properties
        /// <summary>
        /// A list of related DebtVw objects
		/// </summary>
		public List<DebtVw> DebtVwList {get; set;}
		#endregion
    }
	#endregion

    #region LoanDecisionTypeVw class definition
    public partial class LoanDecisionTypeVw
	{
		#region Public properties
        /// <summary>
        /// A list of related LoanDecisionVw objects
		/// </summary>
		public List<LoanDecisionVw> LoanDecisionVwList {get; set;}
		#endregion
    }
	#endregion

    #region LoanDecisionVw class definition
    public partial class LoanDecisionVw
	{
		#region Public properties
        /// <summary>
        /// A list of related LoanVw objects
		/// </summary>
		public List<LoanVw> LoanVwList {get; set;}

        /// <summary>
        /// A list of related OutgoingLoanVw objects
		/// </summary>
		public List<OutgoingLoanVw> OutgoingLoanVwList {get; set;}
		#endregion
    }
	#endregion

    #region LoanDetailVw class definition
    public partial class LoanDetailVw
	{
		#region Public properties
		/// <summary>
        /// A reference to related IncomingLoan child object
		/// </summary>
		public IncomingLoan IncomingLoan {get; set;}

		/// <summary>
        /// A reference to related LoanChange child object
		/// </summary>
		public LoanChange LoanChange {get; set;}

        /// <summary>
        /// A list of related LoanChange objects
		/// </summary>
		public List<LoanChange> FromLoanChangeList {get; set;}

		/// <summary>
        /// A reference to related OutgoingLoan child object
		/// </summary>
		public OutgoingLoan OutgoingLoan {get; set;}

		/// <summary>
        /// A reference to related ProductDetailVw object
		/// </summary>
		public ProductDetailVw ProductDetailVw {get; set;}
		#endregion
    }
	#endregion

    #region LoanGenerationStatusVw class definition
    public partial class LoanGenerationStatusVw
	{
		#region Public properties
        /// <summary>
        /// A list of related LoanVw objects
		/// </summary>
		public List<LoanVw> LoanVwList {get; set;}
		#endregion
    }
	#endregion

    #region LoanRequestVw class definition
    public partial class LoanRequestVw
	{
		#region Public properties
        /// <summary>
        /// A list of related ExceptionalAmountVw objects
		/// </summary>
		public List<ExceptionalAmountVw> ExceptionalAmountVwList {get; set;}

		/// <summary>
        /// A reference to related RequestVw object
		/// </summary>
		public RequestVw RequestVw {get; set;}
		#endregion
    }
	#endregion

    #region LoanStatusVw class definition
    public partial class LoanStatusVw
	{
		#region Public properties
        /// <summary>
        /// A list of related LoanVw objects
		/// </summary>
		public List<LoanVw> LoanVwList {get; set;}
		#endregion
    }
	#endregion

    #region LoanTypeVw class definition
    public partial class LoanTypeVw
	{
		#region Public properties
        /// <summary>
        /// A list of related LoanVw objects
		/// </summary>
		public List<LoanVw> LoanVwList {get; set;}

        /// <summary>
        /// A list of related LoanTypeClosureVw objects
		/// </summary>
		public List<LoanTypeClosureVw> ClosingLoanTypeClosureVwList {get; set;}

        /// <summary>
        /// A list of related LoanTypeClosureVw objects
		/// </summary>
		public List<LoanTypeClosureVw> LoanTypeClosureVwList {get; set;}

        /// <summary>
        /// A list of related SpecialCaseLoanVw objects
		/// </summary>
		public List<SpecialCaseLoanVw> SpecialCaseLoanVwList {get; set;}

		/// <summary>
        /// A reference to related ProductTypeVw object
		/// </summary>
		public ProductTypeVw ProductTypeVw {get; set;}
		#endregion
    }
	#endregion

    #region LoanVw class definition
    public partial class LoanVw
	{
		#region Public properties
		/// <summary>
        /// A reference to related IncomingLoanVw child object
		/// </summary>
		public IncomingLoanVw IncomingLoanVw {get; set;}

		/// <summary>
        /// A reference to related LoanChangeVw child object
		/// </summary>
		public LoanChangeVw LoanChangeVw {get; set;}

        /// <summary>
        /// A list of related LoanChangeVw objects
		/// </summary>
		public List<LoanChangeVw> FromLoanChangeVwList {get; set;}

		/// <summary>
        /// A reference to related OutgoingLoanVw child object
		/// </summary>
		public OutgoingLoanVw OutgoingLoanVw {get; set;}

		/// <summary>
        /// A reference to related ProductVw object
		/// </summary>
		public ProductVw ProductVw {get; set;}
		#endregion
    }
	#endregion

    #region MainWorkPlaceVw class definition
    public partial class MainWorkPlaceVw
	{
		#region Public properties
        /// <summary>
        /// A list of related IncomingLoanVw objects
		/// </summary>
		public List<IncomingLoanVw> IncomingLoanVwList {get; set;}

        /// <summary>
        /// A list of related OutgoingLoanVw objects
		/// </summary>
		public List<OutgoingLoanVw> OutgoingLoanVwList {get; set;}

        /// <summary>
        /// A list of related SalaryWorkPlaceVw objects
		/// </summary>
		public List<SalaryWorkPlaceVw> SalaryWorkPlaceVwList {get; set;}

        /// <summary>
        /// A list of related TransitoryIncomingLoanVw objects
		/// </summary>
		public List<TransitoryIncomingLoanVw> TransitoryIncomingLoanVwList {get; set;}
		#endregion
    }
	#endregion

    #region PaymentDetailVw class definition
    public partial class PaymentDetailVw
	{
		#region Public properties
		/// <summary>
        /// A reference to related CashPayment child object
		/// </summary>
		public CashPayment CashPayment {get; set;}

		/// <summary>
        /// A reference to related DownPayment child object
		/// </summary>
		public DownPayment DownPayment {get; set;}

		/// <summary>
        /// A reference to related SalaryPayment child object
		/// </summary>
		public SalaryPayment SalaryPayment {get; set;}

        /// <summary>
        /// A list of related Settlement objects
		/// </summary>
		public List<Settlement> SettlementList {get; set;}
		#endregion
    }
	#endregion

    #region PaymentGroupVw class definition
    public partial class PaymentGroupVw
	{
		#region Public properties
        /// <summary>
        /// A list of related MonthlyBalanceVw objects
		/// </summary>
		public List<MonthlyBalanceVw> MonthlyBalanceVwList {get; set;}

        /// <summary>
        /// A list of related PaymentVw objects
		/// </summary>
		public List<PaymentVw> PaymentVwList {get; set;}

        /// <summary>
        /// A list of related PayOrderVw objects
		/// </summary>
		public List<PayOrderVw> PayOrderVwList {get; set;}

        /// <summary>
        /// A list of related ProductTypeVw objects
		/// </summary>
		public List<ProductTypeVw> ProductTypeVwList {get; set;}
		#endregion
    }
	#endregion

    #region PaymentStatusVw class definition
    public partial class PaymentStatusVw
	{
		#region Public properties
        /// <summary>
        /// A list of related PaymentVw objects
		/// </summary>
		public List<PaymentVw> PaymentVwList {get; set;}
		#endregion
    }
	#endregion

    #region PaymentVw class definition
    public partial class PaymentVw
	{
		#region Public properties
		/// <summary>
        /// A reference to related CashPaymentVw child object
		/// </summary>
		public CashPaymentVw CashPaymentVw {get; set;}

		/// <summary>
        /// A reference to related DownPaymentVw child object
		/// </summary>
		public DownPaymentVw DownPaymentVw {get; set;}

		/// <summary>
        /// A reference to related SalaryPaymentVw child object
		/// </summary>
		public SalaryPaymentVw SalaryPaymentVw {get; set;}

        /// <summary>
        /// A list of related SettlementVw objects
		/// </summary>
		public List<SettlementVw> SettlementVwList {get; set;}
		#endregion
    }
	#endregion

    #region ProductDetailVw class definition
    public partial class ProductDetailVw
	{
		#region Public properties
		/// <summary>
        /// A reference to related GrantDetailVw child object
		/// </summary>
		public GrantDetailVw GrantDetailVw {get; set;}

		/// <summary>
        /// A reference to related LoanDetailVw child object
		/// </summary>
		public LoanDetailVw LoanDetailVw {get; set;}

		/// <summary>
        /// A reference to related RefundableProduct child object
		/// </summary>
		public RefundableProduct RefundableProduct {get; set;}

		/// <summary>
        /// A reference to related RequestDetailVw child object
		/// </summary>
		public RequestDetailVw RequestDetailVw {get; set;}
		#endregion
    }
	#endregion

    #region ProductTypeDetailVw class definition
    public partial class ProductTypeDetailVw
	{
		#region Public properties
		/// <summary>
        /// A reference to related LoanType child object
		/// </summary>
		public LoanType LoanType {get; set;}

        /// <summary>
        /// A list of related ProductDetailVw objects
		/// </summary>
		public List<ProductDetailVw> ProductDetailVwList {get; set;}

        /// <summary>
        /// A list of related ProductTypeAvailability objects
		/// </summary>
		public List<ProductTypeAvailability> ProductTypeAvailabilityList {get; set;}
		#endregion
    }
	#endregion

    #region ProductTypeVw class definition
    public partial class ProductTypeVw
	{
		#region Public properties
		/// <summary>
        /// A reference to related LoanTypeVw child object
		/// </summary>
		public LoanTypeVw LoanTypeVw {get; set;}

        /// <summary>
        /// A list of related ProductVw objects
		/// </summary>
		public List<ProductVw> ProductVwList {get; set;}

        /// <summary>
        /// A list of related ProductTypeAvailabilityVw objects
		/// </summary>
		public List<ProductTypeAvailabilityVw> ProductTypeAvailabilityVwList {get; set;}
		#endregion
    }
	#endregion

    #region ProductVw class definition
    public partial class ProductVw
	{
		#region Public properties
		/// <summary>
        /// A reference to related GrantVw child object
		/// </summary>
		public GrantVw GrantVw {get; set;}

		/// <summary>
        /// A reference to related LoanVw child object
		/// </summary>
		public LoanVw LoanVw {get; set;}

		/// <summary>
        /// A reference to related RefundableProductVw child object
		/// </summary>
		public RefundableProductVw RefundableProductVw {get; set;}

		/// <summary>
        /// A reference to related RequestVw child object
		/// </summary>
		public RequestVw RequestVw {get; set;}
		#endregion
    }
	#endregion

    #region ProfitStrategyVw class definition
    public partial class ProfitStrategyVw
	{
		#region Public properties
        /// <summary>
        /// A list of related ProductTypeVw objects
		/// </summary>
		public List<ProductTypeVw> ProductTypeVwList {get; set;}
		#endregion
    }
	#endregion

    #region RefundableProductVw class definition
    public partial class RefundableProductVw
	{
		#region Public properties
        /// <summary>
        /// A list of related GuarantorVw objects
		/// </summary>
		public List<GuarantorVw> GuarantorVwList {get; set;}

        /// <summary>
        /// A list of related InstallmentVw objects
		/// </summary>
		public List<InstallmentVw> InstallmentVwList {get; set;}

		/// <summary>
        /// A reference to related ProductVw object
		/// </summary>
		public ProductVw ProductVw {get; set;}
		#endregion
    }
	#endregion

    #region RequestDetailVw class definition
    public partial class RequestDetailVw
	{
		#region Public properties
        /// <summary>
        /// A list of related DownPayment objects
		/// </summary>
		public List<DownPayment> DownPaymentList {get; set;}

		/// <summary>
        /// A reference to related GrantRequestDetailVw child object
		/// </summary>
		public GrantRequestDetailVw GrantRequestDetailVw {get; set;}

		/// <summary>
        /// A reference to related LoanRequest child object
		/// </summary>
		public LoanRequest LoanRequest {get; set;}

		/// <summary>
        /// A reference to related ProductDetailVw object
		/// </summary>
		public ProductDetailVw ProductDetailVw {get; set;}
		#endregion
    }
	#endregion

    #region RequestStatusVw class definition
    public partial class RequestStatusVw
	{
		#region Public properties
        /// <summary>
        /// A list of related RequestVw objects
		/// </summary>
		public List<RequestVw> RequestVwList {get; set;}
		#endregion
    }
	#endregion

    #region RequestVw class definition
    public partial class RequestVw
	{
		#region Public properties
        /// <summary>
        /// A list of related DownPaymentVw objects
		/// </summary>
		public List<DownPaymentVw> DownPaymentVwList {get; set;}

		/// <summary>
        /// A reference to related GrantRequestVw child object
		/// </summary>
		public GrantRequestVw GrantRequestVw {get; set;}

		/// <summary>
        /// A reference to related LoanRequestVw child object
		/// </summary>
		public LoanRequestVw LoanRequestVw {get; set;}

		/// <summary>
        /// A reference to related ProductVw object
		/// </summary>
		public ProductVw ProductVw {get; set;}
		#endregion
    }
	#endregion

    #region SalaryWorkPlaceVw class definition
    public partial class SalaryWorkPlaceVw
	{
		#region Public properties
        /// <summary>
        /// A list of related DepartmentVw objects
		/// </summary>
		public List<DepartmentVw> DepartmentVwList {get; set;}
		#endregion
    }
	#endregion

    #region SubscriptionTypeVw class definition
    public partial class SubscriptionTypeVw
	{
		#region Public properties
        /// <summary>
        /// A list of related SubscriptionVw objects
		/// </summary>
		public List<SubscriptionVw> SubscriptionVwList {get; set;}
		#endregion
    }
	#endregion
}
