using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portal.ViewModels
{
    public class EmployeeLoansReport
    {        
        public List<string> LoansTypesNames { get; set; }
        public List<decimal> OriginalAmounts { get; set; }
        public List<decimal> RemainingAmounts { get; set; }
        public List<decimal> PaidAmounts { get; set; }
    }
}