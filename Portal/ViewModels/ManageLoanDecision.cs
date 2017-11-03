using Cf.Data;
using Cf.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portal.ViewModels
{
    public class ManageLoanDecision
    {
        public LoanDecision LoanDecision { get; set; }
        public List<int> LoanRequestIds { get; set; }
        public LoanRequestVwViewModel LoanRequestVwViewModel { get; set; }
        

        public ManageLoanDecision()
        {
            LoanRequestIds = new List<int>();
            LoanRequestVwViewModel = new LoanRequestVwViewModel();

        }
    }
}