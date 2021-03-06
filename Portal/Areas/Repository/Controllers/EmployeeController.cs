using System;
using System.Net;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Configuration;
using Cf.Data;
using Cf.Services;
using Cf.Services.Exceptions;
using Cf.ViewModels;
using Cf.Controllers;

namespace Portal.Areas.Repository.Controllers
{
    public partial class EmployeeController : BaseController
    {
        private string moduleName = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Employee", "ModuleName");
        private string index = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Employee", "ModuleNamePlural");
		
	    public EmployeeController()
    	{
            ViewBag.ModuleName = moduleName;
			ViewBag.Title = index;
		}
		
        /// <summary>
        /// Returns a list of EmployeeVw objects
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(EmployeeVwViewModel Model)
        {
            Db db = new Db(DbServices.ConnectionString);
            ViewBag.Department = new SelectList(DepartmentServices.List(db),"Id","Name");
            ViewBag.Category = new SelectList(CategoryServices.List(db), "Id", "Name");

            if (Model.Filter.HasCriteria)
	        {				
                Model.List = EmployeeVwServices.Get(Model.Filter, db);
            }
			else
                Model.List = new List<EmployeeVw>();
            return View(Model);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Details(Nullable<int>  id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EmployeeVwViewModel employeeVwViewModel = new EmployeeVwViewModel();

            Db db = new Db(DbServices.ConnectionString);

			// employeeVwViewModel.Instance = EmployeeVwServices.Get(id.Value, db);
            employeeVwViewModel.Instance = EmployeeVwServices.GetChildren(id.Value, db);
            if (employeeVwViewModel.Instance == null)
            {
                return HttpNotFound();
            }


            @ViewBag.DebtVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Debt", "ModuleNamePlural");
            // employeeVwViewModel.DebtVwViewModel.List = DebtVwServices.GetByEmployeeId(id.Value, db);
            employeeVwViewModel.DebtVwViewModel.List = employeeVwViewModel.Instance.DebtVwList;
            

            @ViewBag.GuarantorVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Guarantor", "ModuleNamePlural");
            // employeeVwViewModel.GuarantorVwViewModel.List = GuarantorVwServices.GetByEmployeeId(id.Value, db);
            employeeVwViewModel.GuarantorVwViewModel.List = employeeVwViewModel.Instance.GuarantorVwList;
            

            @ViewBag.MonthlyBalanceVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "MonthlyBalance", "ModuleNamePlural");
            // employeeVwViewModel.MonthlyBalanceVwViewModel.List = MonthlyBalanceVwServices.GetByEmployeeId(id.Value, db);
            employeeVwViewModel.MonthlyBalanceVwViewModel.List = employeeVwViewModel.Instance.MonthlyBalanceVwList;
            

            @ViewBag.PaymentVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Payment", "ModuleNamePlural");
            // employeeVwViewModel.PaymentVwViewModel.List = PaymentVwServices.GetByEmployeeId(id.Value, db);
            employeeVwViewModel.PaymentVwViewModel.List = employeeVwViewModel.Instance.PaymentVwList;
            

            @ViewBag.PayOrderVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "PayOrder", "ModuleNamePlural");
            // employeeVwViewModel.PayOrderVwViewModel.List = PayOrderVwServices.GetByEmployeeId(id.Value, db);
            employeeVwViewModel.PayOrderVwViewModel.List = employeeVwViewModel.Instance.PayOrderVwList;
            

            @ViewBag.ProductVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Product", "ModuleNamePlural");
            // employeeVwViewModel.ProductVwViewModel.List = ProductVwServices.GetByEmployeeId(id.Value, db);
            employeeVwViewModel.ProductVwViewModel.List = employeeVwViewModel.Instance.ProductVwList;
            

            @ViewBag.ProfileVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Profile", "ModuleName");
            if (employeeVwViewModel.Instance.ProfileVw != null)
                employeeVwViewModel.ProfileVwViewModel.List.Add(employeeVwViewModel.Instance.ProfileVw);
                // employeeVwViewModel.ProfileVwViewModel.Instance = employeeVwViewModel.Instance.ProfileVw;

            @ViewBag.SubscriptionVwTitle = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "Subscription", "ModuleNamePlural");
            // employeeVwViewModel.SubscriptionVwViewModel.List = SubscriptionVwServices.GetByEmployeeId(id.Value, db);
            employeeVwViewModel.SubscriptionVwViewModel.List = employeeVwViewModel.Instance.SubscriptionVwList;
            
            
            return View(employeeVwViewModel);
        }

        public ActionResult Create()
        {
			Db db = new Db(DbServices.ConnectionString);

            ViewBag.CategoryList = new SelectList(CategoryServices.List(db), "Id", "Name");
            ViewBag.DepartmentList = new SelectList(DepartmentServices.List(db), "Id", "Name");
            ViewBag.EmployeeStatusList = new SelectList(EmployeeStatusServices.List(db), "Id", "Name");
			return View();
        }

        // POST: employeeVw/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, FirstName, LastName, FatherName, MotherName, BirthDate, ExpectedEndDate, CersStartDate, CfStartDate, LeaveDate, LeaveReason, EmployeeStatus, Department, Notes, Category")] Employee employee)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                EmployeeServices.Insert(CurrentUser.Id, employee, db);
					TempData["Success"] = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "InsertConfirmed");
					return RedirectToAction("Index");
				}
				catch(CfException cfex)
				{
					TempData["Failure"] = cfex.ErrorDefinition.LocalizedMessage;
				}
				catch(Exception ex)
				{
					TempData["Failure"] = ex.Message;
				}
            }

            ViewBag.CategoryList = new SelectList(CategoryServices.List(db), "Id", "Name");
            ViewBag.DepartmentList = new SelectList(DepartmentServices.List(db), "Id", "Name");
            ViewBag.EmployeeStatusList = new SelectList(EmployeeStatusServices.List(db), "Id", "Name");
            return View(employee);
        }

        // GET: Employee/Edit/5
        public ActionResult Edit(Nullable<int>  id)
        {
            Db db = new Db(DbServices.ConnectionString);

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = EmployeeServices.Get(id.Value, db);
            if (employee == null)
            {
                return HttpNotFound();
            }

            ViewBag.CategoryList = new SelectList(CategoryServices.List(db), "Id", "Name", employee.Category);
            ViewBag.DepartmentList = new SelectList(DepartmentServices.List(db), "Id", "Name", employee.Department);
            ViewBag.EmployeeStatusList = new SelectList(EmployeeStatusServices.List(db), "Id", "Name", employee.EmployeeStatus);
            return View(employee);
        }

        // POST: Employee/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id, FirstName, LastName, FatherName, MotherName, BirthDate, ExpectedEndDate, CersStartDate, CfStartDate, LeaveDate, LeaveReason, EmployeeStatus, Department, Notes, Category")] Employee employee)
        {
			Db db = new Db(DbServices.ConnectionString);
            if (ModelState.IsValid)
            {
				try
				{
	                EmployeeServices.Update(CurrentUser.Id, employee, db);
					TempData["Success"] = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "UpdateConfirmed");
					return RedirectToAction("Index");
				}
				catch(CfException cfex)
				{
					TempData["Failure"] = cfex.ErrorDefinition.LocalizedMessage;
				}
				catch(Exception ex)
				{
					TempData["Failure"] = ex.Message;
				}
            }

            ViewBag.CategoryList = new SelectList(CategoryServices.List(db), "Id", "Name", employee.Category);
            ViewBag.DepartmentList = new SelectList(DepartmentServices.List(db), "Id", "Name", employee.Department);
            ViewBag.EmployeeStatusList = new SelectList(EmployeeStatusServices.List(db), "Id", "Name", employee.EmployeeStatus);
            return View(employee);
        }
        // GET: Employee/Delete/5
        public ActionResult Delete(Nullable<int> id)
        {
			if (id == null)
			{
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Db db = new Db(DbServices.ConnectionString);
            Employee employee = EmployeeServices.Get(id.Value, db);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employee/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int  id)
        {
			try
			{
				Db db = new Db(DbServices.ConnectionString);
	            EmployeeServices.Delete(CurrentUser.Id, id, db);
				TempData["Success"] = ResourceServices.GetString(Cf.Data.Resources.ResourceBase.Culture, "UI", "DeleteConfirmed");
				// return RedirectToAction("Index");
			}
			catch(CfException cfex)
			{
				TempData["Failure"] = cfex.ErrorDefinition.LocalizedMessage;
			}
			catch(Exception ex)
			{
				TempData["Failure"] = ex.Message;
			}
            // return View(employee);
			return RedirectToAction("Index");

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}

