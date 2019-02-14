using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cf.ViewModels
{
    public class HelperClasses
    {
    }
    public class SelectedLoans
    {
        public bool IsSelected { get; set; }
        public int LoanId { get; set; }
        public decimal RemainingAmount { get; set; }
        public int RemainingPeriod { get; set; }
        public int ProductTypeId { get; set; }
    }
    public class SelectedGuarantor
    {
        public bool IsSelected { get; set; }
        public int GuarantorId { get; set; }
    }
    public class Response
    {
        public bool IsSuccess { get; set; }
        public List<string> Messages { get; set; } = new List<string>();
    }
}