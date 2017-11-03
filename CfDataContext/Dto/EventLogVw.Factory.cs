using System;
using System.Reflection;

namespace Cf.Data
{
    public partial class EventLogVw
    {
        public string Html
        {
            get
            {
                // return GetHtml(EventCategoryId, Parameters);
                try
                {
                    Assembly a = System.Reflection.Assembly.GetExecutingAssembly();
                    return a.CreateInstance("Cf.Data." + EventCategoryName + "VwXmlRepresenter", false, BindingFlags.CreateInstance, null, new string[1] { Parameters }, System.Globalization.CultureInfo.CurrentCulture, null).ToString();
                }
                catch
                {
                    return new UncategorizedXmlRepresenter(Parameters).ToString();
                }
            }
            set
            {
            }
        }
        private static string GetHtml(int eventCategoryId, string parameters)
        {
            switch (eventCategoryId)
            {
                case (int)EventCategoryEnum.Availability:
                    return (new AvailabilityVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.AvailabilityCeiling:
                    return (new AvailabilityCeilingVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.BypassStatus:
                    return (new BypassStatusVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.CashPayment:
                    return (new CashPaymentVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.Category:
                    return (new CategoryVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.CollectOrder:
                    return (new CollectOrderVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.Debt:
                    return (new DebtVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.Department:
                    return (new DepartmentVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.DownPayment:
                    return (new DownPaymentVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.Employee:
                    return (new EmployeeVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.EmployeeSeniority:
                    return (new EmployeeSeniorityVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.EmployeeStatus:
                    return (new EmployeeStatusVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.EndWorkGrantBracket:
                    return (new EndWorkGrantBracketVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.ErrorDefinition:
                    return (new ErrorDefinitionVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.EventCategory:
                    return (new EventCategoryVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.EventLog:
                    return (new EventLogVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.EventLogError:
                    return (new EventLogErrorVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.EventSource:
                    return (new EventSourceVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.EventStatus:
                    return (new EventStatusVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.ExceptionalAmount:
                    return (new ExceptionalAmountVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.ExceptionalAmountType:
                    return (new ExceptionalAmountTypeVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.ExternalGrant:
                    return (new ExternalGrantVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.Grant:
                    return (new GrantVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.GrantDecision:
                    return (new GrantDecisionVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.GrantDeduction:
                    return (new GrantDeductionVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.GrantPayment:
                    return (new GrantPaymentVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.GrantPaymentOrder:
                    return (new GrantPaymentOrderVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.GrantRequest:
                    return (new GrantRequestVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.GrantType:
                    return (new GrantTypeVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.GrantTypeGroup:
                    return (new GrantTypeGroupVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.Guarantor:
                    return (new GuarantorVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.GuarantorStatement:
                    return (new GuarantorStatementVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.GuarantorStatus:
                    return (new GuarantorStatusVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.HealthLoanDecision:
                    return (new HealthLoanDecisionVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.HealthLoanDecisionFirstPayment:
                    return (new HealthLoanDecisionFirstPaymentVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.IncomingLoan:
                    return (new IncomingLoanVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.Installment:
                    return (new InstallmentVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.InstallmentDecrease:
                    return (new InstallmentDecreaseVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.InstallmentDecreaseOrder:
                    return (new InstallmentDecreaseOrderVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.InsuranceType:
                    return (new InsuranceTypeVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.Issuer:
                    return (new IssuerVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.Loan:
                    return (new LoanVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.LoanChange:
                    return (new LoanChangeVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.LoanDecision:
                    return (new LoanDecisionVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.LoanDecisionType:
                    return (new LoanDecisionTypeVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.LoanGenerationStatus:
                    return (new LoanGenerationStatusVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.LoanRequest:
                    return (new LoanRequestVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.LoanStatus:
                    return (new LoanStatusVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.LoanType:
                    return (new LoanTypeVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.LoanTypeClosure:
                    return (new LoanTypeClosureVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.MainWorkPlace:
                    return (new MainWorkPlaceVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.MissingInstallmentDecrease:
                    return (new MissingInstallmentDecreaseVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.MonthlyBalance:
                    return (new MonthlyBalanceVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.OutgoingLoan:
                    return (new OutgoingLoanVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.Payment:
                    return (new PaymentVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.PaymentGroup:
                    return (new PaymentGroupVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.PaymentStatus:
                    return (new PaymentStatusVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.PayOrder:
                    return (new PayOrderVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.Product:
                    return (new ProductVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.ProductType:
                    return (new ProductTypeVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.ProductTypeAvailability:
                    return (new ProductTypeAvailabilityVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.Profile:
                    return (new ProfileVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.ProfitStrategy:
                    return (new ProfitStrategyVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.RefundableProduct:
                    return (new RefundableProductVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.Request:
                    return (new RequestVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.RequestStatus:
                    return (new RequestStatusVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.Resource:
                    return (new ResourceVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.SalaryPayment:
                    return (new SalaryPaymentVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.SalaryWorkPlace:
                    return (new SalaryWorkPlaceVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.ServiceEndGrantRequest:
                    return (new ServiceEndGrantRequestVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.Settlement:
                    return (new SettlementVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.SpecialCaseLoan:
                    return (new SpecialCaseLoanVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.Subscription:
                    return (new SubscriptionVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.SubscriptionType:
                    return (new SubscriptionTypeVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.TransitoryIncomingLoan:
                    return (new TransitoryIncomingLoanVwXmlRepresenter(parameters)).ToString();
                case (int)EventCategoryEnum.Warrant:
                    return (new WarrantVwXmlRepresenter(parameters)).ToString();
                default:
                    return (new UncategorizedXmlRepresenter(parameters)).ToString();
            }
        }
    }
}
