using Cf.Data;
using Cf.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cf.ViewModels
{

    public partial class LoanRequestViewModel
    {         
        public EmployeeProductCalculatorResult EmployeeProductCalculatorResult { get; set; }
        public GetEmployeeSolvencyResult GetEmployeeSolvencyResult { get; set; }
    }

    public partial class LoanDecisionViewModel
    {
        public LoanVwViewModel Loans { get; set; } = new LoanVwViewModel();
    }

}