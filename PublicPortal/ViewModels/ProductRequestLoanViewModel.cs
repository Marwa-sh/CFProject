using Cf.Data;
using Cf.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portal.ViewModels
{
    public class ProductRequestLoanViewModel
    {
        public Product Product { get; set; }
        public Request Request { get; set; }
        public LoanRequest LoanRequest { get; set; }
        public RefundableProduct RefundableProduct { get; set; }



        public ProductVwViewModel ProductVwViewModel { get; set; }
        public RequestVwViewModel RequestVwViewModel { get; set; }
        public LoanRequestVwViewModel LoanRequestVwViewModel { get; set; }
        public RefundableProductVwViewModel RefundableProductVwViewModel { get; set; }

        public ExceptionalAmountVwViewModel ExceptionalAmountVwViewModel { get; set; }


         

        public ProductRequestLoanViewModel()
        {
            ExceptionalAmountVwViewModel = new ExceptionalAmountVwViewModel();
        }
    }
}