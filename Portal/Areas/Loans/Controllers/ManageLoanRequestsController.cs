using Cf.Controllers;
using Cf.Data;
using Cf.Services;
using Cf.Services.Exceptions;
using Cf.ViewModels;
using Portal.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portal.Areas.Loans.Controllers
{
    public class ManageLoanRequestsController : BaseController
    {

        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ManageLoanRequest", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanRequest", "ModuleNamePlural");
        
        private string TitleGuarantor = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Guarantor", "ModuleNamePlural");
        private string TitleExceptionalAount = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ExceptionalAmount", "ModuleNamePlural");
        private string LoanDecision = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanDecision", "ModuleName");

        private string approve = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "Approve");
        private string reject = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "Reject");
        private string exception = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "Exception");
        private string validate = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "Validate");

        private string newLoanRequests = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ManageLoanRequest", "NewLoanRequests");
        private string validLoanRequests = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ManageLoanRequest", "ValidLoanRequests");
        private string approvedLoanRequests = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ManageLoanRequest", "ApprovedLoanRequests");
        private string exceptionalLoanRequests = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ManageLoanRequest", "ExceptionalLoanRequests");
        private string rejectedLoanRequests = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ManageLoanRequest", "RejectedLoanRequests");

        private string manageLoanRequests = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ManageLoanRequest", "ManageLoanRequests");

        public ManageLoanRequestsController()
        {           
            ViewBag.ModuleName = moduleName;
            ViewBag.Title = index;
            ViewBag.ManageLoanRequests= manageLoanRequests;

            ViewBag.Approve = approve;
            ViewBag.Reject = reject;
            ViewBag.Exception = exception;
            ViewBag.Validate = validate;

            ViewBag.NewLoanRequests = newLoanRequests;
            ViewBag.ValidLoanRequests = validLoanRequests;
            ViewBag.ApprovedLoanRequests = approvedLoanRequests;
            ViewBag.ExceptionalLoanRequests = exceptionalLoanRequests;
            ViewBag.RejectedLoanRequests = rejectedLoanRequests;
        }

        // GET: ManageLoanRequests
        public ActionResult Index()
        {
            Db db = new Db(DbServices.ConnectionString);
            List<LoanRequestVw> requests = null;
            requests = LoanRequestVwServices.List(db);

           
            ViewBag.DecisionType = (int)LoanDecisionTypeEnum.Normal;

            ViewBag.NewLoanRequestsCount = requests.Where(c=>(c.RequestRequestStatusId==(int)RequestStatusEnum.New)).ToList().Count;
            ViewBag.ValidLoanRequestsCount = requests.Where(c => (c.RequestRequestStatusId == (int)RequestStatusEnum.Valid)).ToList().Count;
            ViewBag.ApprovedLoanRequestsCount = requests.Where(c => (c.RequestRequestStatusId == (int)RequestStatusEnum.Approved)).ToList().Count;
            ViewBag.ExceptionalLoanRequestsCount = requests.Where(c => (c.RequestRequestStatusId == (int)RequestStatusEnum.ExcludedFromValidation)).ToList().Count;
            ViewBag.RejectedLoanRequestsCount = requests.Where(c => (c.RequestRequestStatusId == (int)RequestStatusEnum.Invalid)).ToList().Count;

            LoanRequestVwViewModel vm = new LoanRequestVwViewModel();
            vm.List = requests;
            return View(vm);
        }


        [HttpPost]
        public ActionResult Details(int? id)
        {           
            ViewBag.TitleGuarantor = TitleGuarantor;
            ViewBag.TitleExceptionalAount = TitleExceptionalAount;
            // Details Of Products

            if (id == null)
            {
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                return RedirectToAction("Index");
            }

            Db db = new Db(DbServices.ConnectionString);

            ProductVwViewModel productVwViewModel = new ProductVwViewModel();
            productVwViewModel.Instance = ProductVwServices.GetChildren(id.Value, db);
            if (productVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }
            productVwViewModel.RequestVwViewModel.Instance = RequestVwServices.Get(id.Value);
            productVwViewModel.RequestVwViewModel.LoanRequestVwViewModel.Instance = LoanRequestVwServices.Get(id.Value);
            productVwViewModel.RefundableProductVwViewModel.Instance = RefundableProductVwServices.Get(id.Value);

            List<GuarantorVw> Guarantors = GuarantorVwServices.GetByRefundableProductProductId(id.Value);
            productVwViewModel.RefundableProductVwViewModel.GuarantorVwViewModel.List = Guarantors;

            //productVwViewModel.RefundableProductVwViewModel.GuarantorVwViewModel.Instance.GuarantorStatementVw=GuarantorStatementVwServices.

            productVwViewModel.RequestVwViewModel.LoanRequestVwViewModel.ExceptionalAmountVwViewModel.List = ExceptionalAmountVwServices.GetByLoanRequestRequestProductId(id.Value);

            List<ExceptionalAmountVw> NetDeduction = ExceptionalAmountVwServices.GetByLoanRequestRequestProductId(id.Value).Where(c => c.ExceptionalAmountTypeId == (int)ExceptionalAmountTypeEnum.NetDeduction).ToList();
            List<ExceptionalAmountVw> ExceptionalIncome = ExceptionalAmountVwServices.GetByLoanRequestRequestProductId(id.Value).Where(c => c.ExceptionalAmountTypeId == (int)ExceptionalAmountTypeEnum.ExceptionalIncome).ToList();
            List<ExceptionalAmountVw> ExceptionalDeduction = ExceptionalAmountVwServices.GetByLoanRequestRequestProductId(id.Value).Where(c => c.ExceptionalAmountTypeId == (int)ExceptionalAmountTypeEnum.ExceptionalDeduction).ToList();

            ViewBag.NetDeduction = NetDeduction;
            ViewBag.ExceptionalIncome = ExceptionalIncome;
            ViewBag.ExceptionalDeduction = ExceptionalDeduction;

            return PartialView(productVwViewModel);
        }


        #region Validate

        [HttpPost]
        public string Validate(decimal ? Amount , int ? RequestId)
        {
            if (RequestId == 0)
            {
                return "Error";// RedirectToAction("ManageNewRequests");
            }
            try
            {
                Db db = new Db(DbServices.ConnectionString);
                
                LoanRequestVw request = LoanRequestVwServices.Get(RequestId.Value);
                RefundableProductVw refendable = RefundableProductVwServices.Get(RequestId.Value);
                int numOfGuarantorsNeeded = 0;

                EmployeeProductCalculatorFilter f = new EmployeeProductCalculatorFilter();
                f.EmployeeId = request.RequestProductEmployeeId; f.ProductTypeId = (short)request.RequestProductProductTypeId;
                f.Amount = (decimal)request.RequestAmount; f.Period = (short)refendable.PaymentPeriod;
                List<EmployeeProductCalculatorResult> result = db.EmployeeProductCalculator(f);
                if (result.Count > 0)
                {
                    numOfGuarantorsNeeded = result[0].GuarantorsCount.Value;
                }

                int numOfGuarantors = GuarantorVwServices.GetByRefundableProductProductId(RequestId.Value).Count;
                if (numOfGuarantors == numOfGuarantorsNeeded)
                {
                    Product p = ProductServices.Get(RequestId.Value,db);
                    p.Amount = Amount.Value;
                    ProductServices.Update(p);
                    Request r = RequestServices.Get(RequestId.Value);
                    r.RequestStatus = (int)RequestStatusEnum.Valid;
                    RequestServices.Update(r);                    
                }
                else
                {
                    //TempData["Failure"] = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Guarantors", "NumberOfGuarantors");
                    return ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Guarantors", "NumberOfGuarantors");
                }

            }
            catch (Exception e)
            {
                //EventLog eventLog = DbServices.Log(CurrentUser.Id, db, (int)EventCategoryEnum.Department, (int)EventSourceEnum.Department, (int)EventStatusEnum.Insert, new DepartmentVwXmlFormatter(instance), handler);
                //if (eventLog != null)
                //    throw DbServices.LogError(eventLog, ex, "Department", db);
                //else
                //    throw ex;
            }
            return "Success";// RedirectToAction("ManageNewRequests");
        }

        #endregion
        #region Reject

        public ActionResult Reject(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("ManageNewRequests");
            }

            Request request = RequestServices.Get(id.Value);
            request.RequestStatus = (int)RequestStatusEnum.Invalid;
            RequestServices.Update(request);

            return RedirectToAction("ManageNewRequests");
        }

        #endregion
        #region Approve

        public ActionResult Approve(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("ManageValidRequests");
            }
            try
            {
                // 1- update loan reuest status
                Request request = RequestServices.Get(id.Value);
                request.RequestStatus = (int)RequestStatusEnum.Approved;
                RequestServices.Update(request);

                // 2- update guarantors status
                List<Guarantor> Guarantors = GuarantorServices.GetByRefundableProduct(id.Value);
                for (int i = 0; i < Guarantors.Count; i++)
                {
                    Guarantor temp = Guarantors[i];
                    temp.GuarantorStatus =(int) GuarantorStatusEnum.UnderStudy;
                    GuarantorServices.Update(temp);
                }
            }
            catch (Exception ex)
            {

            }            
            return RedirectToAction("ManageValidRequests");
        }

        #endregion

        #region Exception
        public ActionResult Exception(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            Request request = RequestServices.Get(id.Value);
            request.RequestStatus = (int)RequestStatusEnum.ExcludedFromValidation;
            RequestServices.Update(request);

            return RedirectToAction("Index");
        }
        #endregion


        #region FinantialApprove

        public ActionResult FinantialApprove(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            Request request = RequestServices.Get(id.Value);
            request.RequestStatus = (int)RequestStatusEnum.FinanciallyApproved;
            RequestServices.Update(request);

            return RedirectToAction("Index");
        }


        #endregion

        #region Guaranntors Approve
        [HttpPost]
        public string AcceptGuarantor(int ? id)
        {
            string StartDivSuccess= "<div class='alert alert-success no-border mb-2' role='alert'><strong>";            
            string EndDiv = "</strong></div> ";
            try
            {
                if(id==null)
                {
                    return "Error";
                }
                Guarantor g = GuarantorServices.Get(id.Value);
                g.GuarantorStatus =(int) GuarantorStatusEnum.Accepted;
                GuarantorServices.Update(g);

            }
            catch(Exception ex)
            {
                return "Error";
            }
            return StartDivSuccess+ "Approved"+EndDiv;
        }

        #endregion
        #region Guaranntors Reject
        [HttpPost]
        public string RejectGuarantor(int? id)
        {
            string StartDivReject = "<div class='alert alert-danger no-border mb-2' role='alert'><strong>";
            string EndDiv = "</strong></div> ";
            try
            {
                if (id == null)
                {
                    return "Error";
                }
                Guarantor g = GuarantorServices.Get(id.Value);
                g.GuarantorStatus = (int)GuarantorStatusEnum.Rejected;
                GuarantorServices.Update(g);

            }
            catch (Exception ex)
            {
                return "Error";
            }
            return StartDivReject + "Rejected" + EndDiv;
        }

        #endregion

        #region Manage New Requests
        public ActionResult ManageNewRequests()
        {
            LoanRequestVwViewModel vm = new LoanRequestVwViewModel();
            try
            {
                Db db = new Db(DbServices.ConnectionString);
                List<LoanRequestVw> requests = null;
                requests = LoanRequestVwServices.List(db).Where(c => c.RequestRequestStatusId == RequestStatusEnum.New.GetHashCode()).ToList();              
                vm.List = requests;
            }
            catch (Exception exc)
            {
                throw;
            }
            
            return View(vm);             
        }
        #endregion

        #region Manage Valide Requests
        public ActionResult ManageValidRequests()
        {
            LoanRequestVwViewModel vm = new LoanRequestVwViewModel();
            try
            {
                Db db = new Db(DbServices.ConnectionString);
                List<LoanRequestVw> requests = null;
                requests = LoanRequestVwServices.List(db).Where(c => c.RequestRequestStatusId == RequestStatusEnum.Valid.GetHashCode()).ToList();
                vm.List = requests;
            }
            catch (Exception exc)
            {
                throw;
            }

            return View(vm);            
        }
        #endregion

        #region Manage Approved Requests
        public ActionResult ManageApprovedRequests()
        {
            LoanRequestVwViewModel vm = new LoanRequestVwViewModel();
            try
            {
                Db db = new Db(DbServices.ConnectionString);
                List<LoanRequestVw> requests = null;
                requests = LoanRequestVwServices.List(db).Where(c => c.RequestRequestStatusId == RequestStatusEnum.Approved.GetHashCode()).ToList();
                vm.List = requests;
            }
            catch (Exception exc)
            {
                throw;
            }

            return View(vm);
        }
        #endregion

        #region Manage Exceptional Requests
        public ActionResult ManageExceptionalRequest()
        {
            LoanRequestVwViewModel vm = new LoanRequestVwViewModel();
            try
            {
                Db db = new Db(DbServices.ConnectionString);
                List<LoanRequestVw> requests = null;
                requests = LoanRequestVwServices.List(db).Where(c => c.RequestRequestStatusId == RequestStatusEnum.ExcludedFromValidation.GetHashCode()).ToList();
                vm.List = requests;
            }
            catch (Exception exc)
            {
                throw;
            }

            return View(vm);
        }
        #endregion

        #region Manage Rejected Requests
        public ActionResult ManageRejectedRequest()
        {
            LoanRequestVwViewModel vm = new LoanRequestVwViewModel();
            try
            {
                Db db = new Db(DbServices.ConnectionString);
                List<LoanRequestVw> requests = null;
                requests = LoanRequestVwServices.List(db).Where(c => c.RequestRequestStatusId == RequestStatusEnum.Invalid.GetHashCode()).ToList();
                vm.List = requests;
            }
            catch (Exception exc)
            {
                throw;
            }

            return View(vm);
        }
        #endregion



    }
}