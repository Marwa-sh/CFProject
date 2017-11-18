using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cf;

namespace TestCfDesktop
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void ShowForm(Form form, string text)
        {
            int index = tabFormContainer.TabPages.IndexOfKey(text);
            if (index == -1)
            {
                TabPage tp = new TabPage(text);
                tp.Name = text;
                form.MdiParent = this;
                tabFormContainer.TabPages.Add(tp);
                form.Dock = DockStyle.Fill;
                tp.Controls.Add(form);
                form.Show();
                tabFormContainer.SelectedTab = tp;
            }
            else
                tabFormContainer.SelectedTab = tabFormContainer.TabPages[index];
        }
        private void lvCf_Click(object sender, EventArgs e)
        {
            try
            {
                switch (lvCf.FocusedItem.Text)
                {
                    case "Availability":
                        ShowForm(new FormAvailabilityView(), "Availability");
                        break;
                    case "AvailabilityCeiling":
                        ShowForm(new FormAvailabilityCeilingView(), "AvailabilityCeiling");
                        break;
                    case "BypassStatus":
                        ShowForm(new FormBypassStatusView(), "BypassStatus");
                        break;
                    case "CashPayment":
                        ShowForm(new FormCashPaymentView(), "CashPayment");
                        break;
                    case "Category":
                        ShowForm(new FormCategoryView(), "Category");
                        break;
                    case "CollectOrder":
                        ShowForm(new FormCollectOrderView(), "CollectOrder");
                        break;
                    case "Debt":
                        ShowForm(new FormDebtView(), "Debt");
                        break;
                    case "Department":
                        ShowForm(new FormDepartmentView(), "Department");
                        break;
                    case "DownPayment":
                        ShowForm(new FormDownPaymentView(), "DownPayment");
                        break;
                    case "Employee":
                        ShowForm(new FormEmployeeView(), "Employee");
                        break;
                    case "EmployeeSeniority":
                        ShowForm(new FormEmployeeSeniorityView(), "EmployeeSeniority");
                        break;
                    case "EmployeeStatus":
                        ShowForm(new FormEmployeeStatusView(), "EmployeeStatus");
                        break;
                    case "EndWorkGrantBracket":
                        ShowForm(new FormEndWorkGrantBracketView(), "EndWorkGrantBracket");
                        break;
                    case "ErrorDefinition":
                        ShowForm(new FormErrorDefinitionView(), "ErrorDefinition");
                        break;
                    case "EventCategory":
                        ShowForm(new FormEventCategoryView(), "EventCategory");
                        break;
                    case "EventLog":
                        ShowForm(new FormEventLogView(), "EventLog");
                        break;
                    case "EventLogError":
                        ShowForm(new FormEventLogErrorView(), "EventLogError");
                        break;
                    case "EventSource":
                        ShowForm(new FormEventSourceView(), "EventSource");
                        break;
                    case "EventStatus":
                        ShowForm(new FormEventStatusView(), "EventStatus");
                        break;
                    case "ExceptionalAmount":
                        ShowForm(new FormExceptionalAmountView(), "ExceptionalAmount");
                        break;
                    case "ExceptionalAmountType":
                        ShowForm(new FormExceptionalAmountTypeView(), "ExceptionalAmountType");
                        break;
                    case "ExternalGrant":
                        ShowForm(new FormExternalGrantView(), "ExternalGrant");
                        break;
                    case "Grant":
                        ShowForm(new FormGrantView(), "Grant");
                        break;
                    case "GrantDecision":
                        ShowForm(new FormGrantDecisionView(), "GrantDecision");
                        break;
                    case "GrantDeduction":
                        ShowForm(new FormGrantDeductionView(), "GrantDeduction");
                        break;
                    case "GrantPayment":
                        ShowForm(new FormGrantPaymentView(), "GrantPayment");
                        break;
                    case "GrantPaymentOrder":
                        ShowForm(new FormGrantPaymentOrderView(), "GrantPaymentOrder");
                        break;
                    case "GrantRequest":
                        ShowForm(new FormGrantRequestView(), "GrantRequest");
                        break;
                    case "GrantType":
                        ShowForm(new FormGrantTypeView(), "GrantType");
                        break;
                    case "GrantTypeGroup":
                        ShowForm(new FormGrantTypeGroupView(), "GrantTypeGroup");
                        break;
                    case "Guarantor":
                        ShowForm(new FormGuarantorView(), "Guarantor");
                        break;
                    case "GuarantorStatement":
                        ShowForm(new FormGuarantorStatementView(), "GuarantorStatement");
                        break;
                    case "GuarantorStatus":
                        ShowForm(new FormGuarantorStatusView(), "GuarantorStatus");
                        break;
                    case "HealthLoanDecision":
                        ShowForm(new FormHealthLoanDecisionView(), "HealthLoanDecision");
                        break;
                    case "HealthLoanDecisionFirstPayment":
                        ShowForm(new FormHealthLoanDecisionFirstPaymentView(), "HealthLoanDecisionFirstPayment");
                        break;
                    case "IncomingLoan":
                        ShowForm(new FormIncomingLoanView(), "IncomingLoan");
                        break;
                    case "Installment":
                        ShowForm(new FormInstallmentView(), "Installment");
                        break;
                    case "InstallmentDecrease":
                        ShowForm(new FormInstallmentDecreaseView(), "InstallmentDecrease");
                        break;
                    case "InstallmentDecreaseOrder":
                        ShowForm(new FormInstallmentDecreaseOrderView(), "InstallmentDecreaseOrder");
                        break;
                    case "InsuranceType":
                        ShowForm(new FormInsuranceTypeView(), "InsuranceType");
                        break;
                    case "Issuer":
                        ShowForm(new FormIssuerView(), "Issuer");
                        break;
                    case "Loan":
                        ShowForm(new FormLoanView(), "Loan");
                        break;
                    case "LoanChange":
                        ShowForm(new FormLoanChangeView(), "LoanChange");
                        break;
                    case "LoanDecision":
                        ShowForm(new FormLoanDecisionView(), "LoanDecision");
                        break;
                    case "LoanDecisionType":
                        ShowForm(new FormLoanDecisionTypeView(), "LoanDecisionType");
                        break;
                    case "LoanGenerationStatus":
                        ShowForm(new FormLoanGenerationStatusView(), "LoanGenerationStatus");
                        break;
                    case "LoanRequest":
                        ShowForm(new FormLoanRequestView(), "LoanRequest");
                        break;
                    case "LoanStatus":
                        ShowForm(new FormLoanStatusView(), "LoanStatus");
                        break;
                    case "LoanType":
                        ShowForm(new FormLoanTypeView(), "LoanType");
                        break;
                    case "LoanTypeClosure":
                        ShowForm(new FormLoanTypeClosureView(), "LoanTypeClosure");
                        break;
                    case "MainWorkPlace":
                        ShowForm(new FormMainWorkPlaceView(), "MainWorkPlace");
                        break;
                    case "MissingInstallmentDecrease":
                        ShowForm(new FormMissingInstallmentDecreaseView(), "MissingInstallmentDecrease");
                        break;
                    case "MonthlyBalance":
                        ShowForm(new FormMonthlyBalanceView(), "MonthlyBalance");
                        break;
                    case "OutgoingLoan":
                        ShowForm(new FormOutgoingLoanView(), "OutgoingLoan");
                        break;
                    case "Payment":
                        ShowForm(new FormPaymentView(), "Payment");
                        break;
                    case "PaymentGroup":
                        ShowForm(new FormPaymentGroupView(), "PaymentGroup");
                        break;
                    case "PaymentStatus":
                        ShowForm(new FormPaymentStatusView(), "PaymentStatus");
                        break;
                    case "PayOrder":
                        ShowForm(new FormPayOrderView(), "PayOrder");
                        break;
                    case "Product":
                        ShowForm(new FormProductView(), "Product");
                        break;
                    case "ProductType":
                        ShowForm(new FormProductTypeView(), "ProductType");
                        break;
                    case "ProductTypeAvailability":
                        ShowForm(new FormProductTypeAvailabilityView(), "ProductTypeAvailability");
                        break;
                    case "Profile":
                        ShowForm(new FormProfileView(), "Profile");
                        break;
                    case "ProfitStrategy":
                        ShowForm(new FormProfitStrategyView(), "ProfitStrategy");
                        break;
                    case "RefundableProduct":
                        ShowForm(new FormRefundableProductView(), "RefundableProduct");
                        break;
                    case "Request":
                        ShowForm(new FormRequestView(), "Request");
                        break;
                    case "RequestStatus":
                        ShowForm(new FormRequestStatusView(), "RequestStatus");
                        break;
                    case "Resource":
                        ShowForm(new FormResourceView(), "Resource");
                        break;
                    case "SalaryPayment":
                        ShowForm(new FormSalaryPaymentView(), "SalaryPayment");
                        break;
                    case "SalaryWorkPlace":
                        ShowForm(new FormSalaryWorkPlaceView(), "SalaryWorkPlace");
                        break;
                    case "ServiceEndGrantRequest":
                        ShowForm(new FormServiceEndGrantRequestView(), "ServiceEndGrantRequest");
                        break;
                    case "Settlement":
                        ShowForm(new FormSettlementView(), "Settlement");
                        break;
                    case "SpecialCaseLoan":
                        ShowForm(new FormSpecialCaseLoanView(), "SpecialCaseLoan");
                        break;
                    case "Subscription":
                        ShowForm(new FormSubscriptionView(), "Subscription");
                        break;
                    case "SubscriptionType":
                        ShowForm(new FormSubscriptionTypeView(), "SubscriptionType");
                        break;
                    case "TransitoryIncomingLoan":
                        ShowForm(new FormTransitoryIncomingLoanView(), "TransitoryIncomingLoan");
                        break;
                    case "Warrant":
                        ShowForm(new FormWarrantView(), "Warrant");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
