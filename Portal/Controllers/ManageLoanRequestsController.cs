using Cf.Controllers;
using Cf.Data;
using Cf.Services;
using Cf.ViewModels;
using Portal.ViewModels;
using System;
using System.Collections.Generic;
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


        // GET: ManageLoanRequests
        public ActionResult Index()
        {

            ViewBag.Title = index;
            ViewBag.ModuleName = moduleName;
            ViewBag.Insert = insert;
            ViewBag.Update = update;
            ViewBag.Delete = delete;
            ViewBag.Details = details;
            ViewBag.ConfirmDelete = confirmDelete;
            ViewBag.Yes = yes;
            ViewBag.No = no;
            ViewBag.Search = search;
            ViewBag.FilterOptions = filterOptions;

            ViewBag.Approve = "Approve";
            ViewBag.Reject = "Reject";
            ViewBag.Exception = "Exception";


            ViewBag.NewLoanRequests = "NewLoanRequests";
            ViewBag.SatisfyConditionsLoanRequests = "SatisfyConditionsLoanRequests";
            ViewBag.ExceptionalLoanRequests = "ExceptionalLoanRequests";


            Db db = new Db(DbServices.ConnectionString);
            List<LoanRequestVw> requests = null;

            
            string roleName = "Manager";
            switch (roleName)
            {
                case "Employee" :
                    {
                        requests=LoanRequestVwServices.List(db).Where(c => c.RequestRequestStatusId.Value == (int)LoanRequestStatusEnum.New).ToList();
                        break;
                    }
                case  "Manager":
                    {
                        requests = LoanRequestVwServices.List(db).Where(c => (c.RequestRequestStatusId.Value == (int)LoanRequestStatusEnum.Exceptional || c.RequestRequestStatusId.Value == (int)LoanRequestStatusEnum.StatisfyConditions || c.RequestRequestStatusId.Value == (int)LoanRequestStatusEnum.New)).ToList();
                        break;
                    }
                case "FinancialManager":
                    {
                        requests = LoanRequestVwServices.List(db).Where(c => (c.RequestRequestStatusId.Value == (int)LoanRequestStatusEnum.StatisfyConditions || c.RequestRequestStatusId.Value == (int)LoanRequestStatusEnum.StatisfyConditions)).ToList();
                        break;
                    }

                default:
                    break;
            }
            

            ViewBag.DecisionType = 1;

            ViewBag.RoleName = roleName;

            //ViewBag.ProductTypeList = new SelectList(ProductTypeServices.List(db), "Id", "Name");
            //ViewBag.RequestStatusList = new SelectList(RequestStatusServices.List(db), "Id", "Name");
            LoanRequestVwViewModel vm = new LoanRequestVwViewModel();
            vm.List = requests;
            return View(vm);
        }

        #region CreateLoanRequestDecision
        public ActionResult CreateLoanRequestDecision()
        {
            ViewBag.ModuleName = moduleName;
            ViewBag.Action = insert;
            ViewBag.Save = save;
            ViewBag.Back = back;
            ViewBag.Details = details;
            ViewBag.Update = update;
            Db db = new Db(DbServices.ConnectionString);

            ManageLoanDecision vm = new ManageLoanDecision();
            vm.LoanRequestVwViewModel.List = LoanRequestVwServices.List(db).Where(c=>c.RequestRequestStatusId.Value==4).ToList();



            return View(vm);
        }

        [HttpPost]
        public ActionResult CreateLoanRequestDecision(ManageLoanDecision model)
        {
            return View();
        }

        #endregion
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

            // Product
            ProductVwViewModel productVwViewModel = new ProductVwViewModel();
            productVwViewModel.Instance = ProductVwServices.GetChildren(id.Value, db);
            if (productVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            // Request
            RequestVwViewModel requestVwViewModel = new RequestVwViewModel();
            requestVwViewModel.Instance = RequestVwServices.GetChildren(id.Value, db);
            if (requestVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            // Loan Request
            LoanRequestVwViewModel loanRequestVwViewModel = new LoanRequestVwViewModel();
            loanRequestVwViewModel.Instance = LoanRequestVwServices.GetChildren(id.Value, db);
            if (loanRequestVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            // RefundableProduct
            RefundableProductVwViewModel refundableProductVwViewModel = new RefundableProductVwViewModel();
            refundableProductVwViewModel.Instance = RefundableProductVwServices.GetChildren(id.Value, db);
            if (refundableProductVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }

            refundableProductVwViewModel.GuarantorVwViewModel.List = refundableProductVwViewModel.Instance.GuarantorVwList;

            ProductRequestLoanViewModel vm = new ProductRequestLoanViewModel();
            vm.ProductVwViewModel = productVwViewModel;
            vm.RequestVwViewModel = requestVwViewModel;
            vm.LoanRequestVwViewModel = loanRequestVwViewModel;
            vm.RefundableProductVwViewModel = refundableProductVwViewModel;

            vm.ExceptionalAmountVwViewModel.List = ExceptionalAmountVwServices.GetByLoanRequestRequestProductId(id.Value);




            return PartialView(vm);
        }


        enum LoanRequestStatusEnum
        {
            New=1,
            StatisfyConditions,
            NotStatisfyConditions,
            Exceptional,
            ReadyForDecisionPreparation,
            ReadyForDecisionMaking,
            Executed,
            Canceled
        }
    }
}