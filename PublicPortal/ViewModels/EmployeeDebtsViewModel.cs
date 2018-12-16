using Cf.Data;
using Cf.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portal.ViewModels
{
    public class EmployeeDebtsViewModel
    {
        public LoanRequestViewModel LoanRequest { get; set; } = new LoanRequestViewModel();
        public Debt Debt { get; set; } = new Debt();
        public List<Warrant> Warrants { get; set; } = new List<Warrant>();
    }
    public class GetEmployeeSolvencyViewModel
    {
        public GetEmployeeSolvencyFilter Filter { get; set; } = new GetEmployeeSolvencyFilter();
        public GetEmployeeSolvencyResult Result { get; set; } = new GetEmployeeSolvencyResult();
        public EmployeeVw Employee { get; set; }
    }
}