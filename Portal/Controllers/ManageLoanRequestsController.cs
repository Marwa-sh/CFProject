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

namespace Portal.Controllers
{
    public class ManageLoanRequestsController : BaseController
    {

        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanRequest", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanRequest", "ModuleNamePlural");
        private string insert = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "Insert");
        private string update = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "Update");
        private string delete = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "Delete");
        private string save = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "Save");
        private string back = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "Back");
        private string details = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "Details");
        private string confirmDelete = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "ConfirmDelete");
        private string yes = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "Yes");
        private string no = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "No");
        private string search = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "Search");
        private string filterOptions = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "FilterOptions");

        private string TitleGuarantor = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Guarantor", "ModuleNamePlural");
        private string TitleExceptionalAount = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "ExceptionalAmount", "ModuleNamePlural");
        private string LoanDecision = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "LoanDecision", "ModuleName");
        private string noRecords = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "NoRecords");


        public ManageLoanRequestsController()
        {
            ViewBag.ModuleName = moduleName;
            ViewBag.Action = details;
            ViewBag.Details = details;
            ViewBag.Update = update;
            ViewBag.Back = back;
            ViewBag.Insert = insert;
            ViewBag.Delete = delete;
            ViewBag.Title = index;
             
            ViewBag.ConfirmDelete = confirmDelete;
            ViewBag.Yes = yes;
            ViewBag.No = no;
            ViewBag.Search = search;
            ViewBag.FilterOptions = filterOptions;

            ViewBag.Approve = "Approve";
            ViewBag.Reject = "Reject";
            ViewBag.Exception = "Exception";

            ViewBag.NoRecords = noRecords;

            ViewBag.NewLoanRequests = "NewLoanRequests";
            ViewBag.SatisfyConditionsLoanRequests = "قيد إعداد القرار"; //"SatisfyConditionsLoanRequests";
            ViewBag.ExceptionalLoanRequests = "ExceptionalLoanRequests";


            ViewBag.Validate = "Validate";
        }

        // GET: ManageLoanRequests
        public ActionResult Index()
        {
            Db db = new Db(DbServices.ConnectionString);
            List<LoanRequestVw> requests = null;
            requests = LoanRequestVwServices.List(db);

            for (int i = 0; i < requests.Count; i++)
            {
                int productId = requests[i].RequestProductId;
                //int numOfGuarantors = GuarantorVwServices.GetByRefundableProductProductId(productId).Count;
                //if(numOfGuarantors==0)

            }

            string roleName = "Manager";
            //switch (roleName)
            //{
            //    case "Employee" :
            //        {
            //            requests=LoanRequestVwServices.List(db).Where(c => c.RequestRequestStatusId.Value == (int)RequestStatusEnum.New).ToList();
            //            break;
            //        }
            //    case  "Manager":
            //        {
            //            requests = LoanRequestVwServices.List(db).Where(c => (c.RequestRequestStatusId.Value == (int)RequestStatusEnum.ExcludedFromValidation || c.RequestRequestStatusId.Value == (int)RequestStatusEnum.Valid || c.RequestRequestStatusId.Value == (int)RequestStatusEnum.New)).ToList();
            //            break;
            //        }
            //    case "FinancialManager":
            //        {
            //            requests = LoanRequestVwServices.List(db).Where(c => (c.RequestRequestStatusId.Value == (int)RequestStatusEnum.New || c.RequestRequestStatusId.Value == (int)RequestStatusEnum.Valid)).ToList();
            //            break;
            //        }

            //    default:
            //        break;
            //}
            

            ViewBag.DecisionType = 1;

            ViewBag.RoleName = roleName;
            LoanRequestVwViewModel vm = new LoanRequestVwViewModel();
            vm.List = requests;
            return View(vm);
        }

        
        [HttpPost]
        public ActionResult Details(int ? id)
        {
            ViewBag.ModuleName = moduleName;
            ViewBag.Action = details;
            ViewBag.Details = details;
            ViewBag.Update = update;
            ViewBag.Back = back;
            ViewBag.Insert = insert;
            ViewBag.Delete = delete;

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

            List<GuarantorVw> Guarantors = GuarantorVwServices.GetByRefundableProductProductId(id.Value);
            productVwViewModel.RefundableProductVwViewModel.GuarantorVwViewModel.List = Guarantors;


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

        public ActionResult Validate(int? id)
        {
            if (id == null)
            {               
                return RedirectToAction("Index");
            }

            Request request = RequestServices.Get(id.Value);
            request.RequestStatus =(int) RequestStatusEnum.Valid;
            RequestServices.Update(request);
             
            return RedirectToAction("Index");
        }

        #endregion
        #region Reject

        public ActionResult Reject(int? id)
        { 
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            Request request = RequestServices.Get(id.Value);
            request.RequestStatus = (int)RequestStatusEnum.Invalid;
            RequestServices.Update(request);

            return RedirectToAction("Index");
        }

        #endregion
        #region Approve

        public ActionResult Approve(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }

            Request request = RequestServices.Get(id.Value);
            request.RequestStatus = (int)RequestStatusEnum.Approved;
            RequestServices.Update(request);

            return RedirectToAction("Index");
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
    }
}