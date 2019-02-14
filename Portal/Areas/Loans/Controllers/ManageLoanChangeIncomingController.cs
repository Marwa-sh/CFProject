using Cf.Controllers;
using Cf.Data;
using Cf.Services;
using Cf.Services.Exceptions;
using Cf.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portal.Areas.Loans.Controllers
{
    public class ManageLoanChangeIncomingController : BaseController
    {
        private string title = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "ManageLoansChanges");
        private string discover = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "Discover");
        private string employeeIdTo = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "employeeIdTo");
        private string changeLoanToEmployee = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "ChangeLoanToEmployee");
        private string moveLoansToGuarantor = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "MoveLoansToGuarantor");
        private string guarantors = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Guarantor", "ModuleNamePlural");
        private string moveToGuarantors = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "MoveToGuarantors");
        private string transitoryIncomingLoan = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "TransitoryIncomingLoan", "ModuleNamePlural");

        public ManageLoanChangeIncomingController()
        {
            ViewBag.Title = title;
            ViewBag.Discover = discover;
            ViewBag.EmployeeIdTo = employeeIdTo;
            ViewBag.ChangeLoanToEmployee = changeLoanToEmployee;
            ViewBag.MoveLoansToGuarantor = moveLoansToGuarantor;
            ViewBag.Guarantors = guarantors;
            ViewBag.MoveToGuarantors = moveToGuarantors;
            ViewBag.TransitoryIncomingLoan = transitoryIncomingLoan;
        }

        // GET: Loans/ManageLoanChanges
        public ActionResult Index()
        {           
            return View();
        }

        public ActionResult ChangeLoanToIncoming(LoanVwViewModel Model, string operationType)
        {
            Db db = new Db(DbServices.ConnectionString);
            ViewBag.ProductTypeList = new SelectList(ProductTypeServices.List(db), "Id", "Name");
            ViewBag.LoanStatusList = new SelectList(LoanStatusServices.List(db), "Id", "Name");
            if (operationType != null)
            {
                //Response response = ProcessMoveLoanToEmployee(Model.SelectedLoansList, Model.EmployeeLoansFilter.EmployeeId.Value, Model.EmployeeId);
                // if(response.IsSuccess)
                // {
                //     return RedirectToAction("Index");
                // }
                // else
                // {
                //     return View(Model);
                // }               
                return View(Model);
            }
            else
            {
                if (Model.EmployeeLoansFilter != null && Model.EmployeeLoansFilter.EmployeeId != 0)
                {
                    Model.EmployeeLoansFilter.LoanStatusId = 0;
                    Model.EmployeeLoansResult = db.EmployeeLoans(Model.EmployeeLoansFilter);
                }
                else
                    Model.EmployeeLoansResult = new List<EmployeeLoansResult>();
                return View(Model);
            }
        }
 
        #region HelperFunctions

        public Response ProcessMoveLoanToEmployee(List<SelectedLoans> loans, int oldEmployeeId, int newEmployeeId)
        {

            Db db = new Db();
            Response response = new Cf.ViewModels.Response();
            try
            {
                if (!(db.Connection.State == ConnectionState.Open)) db.Connection.Open();
                db.Transaction = db.Connection.BeginTransaction();

                // 1- Loan Decision
                LoanDecision loanDecision = new LoanDecision()
                {
                    Date = System.DateTime.Now,
                    Year = (short)System.DateTime.Now.Year,
                    DeductionStartDate = System.DateTime.Now,
                    LoanDecisionType = (int)LoanDecisionTypeEnum.ChangeSubscriber                  
                };
                loanDecision = LoanDecisionServices.Insert(loanDecision);

                // 2- move loans
                foreach (SelectedLoans loan in loans)
                {
                    if(loan.IsSelected)
                    {
                        List<EmployeeProductCalculatorResult> result = db.EmployeeProductCalculator(newEmployeeId, (short)loan.ProductTypeId, loan.RemainingAmount, (short)loan.RemainingPeriod);
                        if (result.Count > 0)
                        {
                            db.LoanMoveFromEmployeeToEmployee(loan.LoanId, newEmployeeId, loanDecision.Id);
                        }                        
                    }
                }
                db.Transaction.Commit();
                db.Connection.Close();
                response.IsSuccess = true;
            }
            catch (CfException exc)
            {
                db.Transaction.Rollback();
                db.Connection.Close();
                response.IsSuccess = false;
                response.Messages.Add(exc.ErrorDefinition.LocalizedMessage);
            }
            catch (Exception exc)
            {
                db.Transaction.Rollback();
                db.Connection.Close();
                response.IsSuccess = false;
                response.Messages.Add(exc.Message);
            }
            return response;
        }
      
        #endregion
    }
}