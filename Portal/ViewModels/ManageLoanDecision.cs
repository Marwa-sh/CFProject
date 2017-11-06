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
        public List<RequestCustomized> Requests { get; set; } = new List<RequestCustomized>();

        public LoanRequestVwViewModel LoanRequestVwViewModel { get; set; }
        

        public ManageLoanDecision()
        {
            Requests = new List<RequestCustomized>();
            LoanRequestVwViewModel = new LoanRequestVwViewModel();

        }


        public class RequestCustomized
        {
            public int RequestId { set; get; }
            public bool isChecked { set; get; }
        }
    }
}