using Cf.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cf.ViewModels
{
    public class EmployeeLoansViewModel
    {
        public EmployeeLoansFilter EmployeeLoansFilter { get; set; }
        public List<EmployeeLoansResult> EmployeeLoansResult { get; set; } = new List<Data.EmployeeLoansResult>();
    }

    public partial class LoanVwViewModel
    {
        public GetInstallmentsResult InstallmentResultInstance { get; set; } = new GetInstallmentsResult();
        public List<GetInstallmentsResult> InstallmentsResultList { get; set; } = new List<GetInstallmentsResult>();

        public List<SelectedLoans> SelectedLoansList { get; set; } = new List<SelectedLoans>();
        public List<SelectedGuarantor> SelectedGuarantorsList { get; set; } = new List<SelectedGuarantor>();
        public EmployeeVw EmployeeInfo { get; set; }
        public int EmployeeId { get; set; }
        public EmployeeLoansResult InstanceResult { get; set; } = new Data.EmployeeLoansResult();
        public EmployeeLoansFilter EmployeeLoansFilter { get; set; }
        public List<EmployeeLoansResult> EmployeeLoansResult { get; set; } = new List<Data.EmployeeLoansResult>();
    }

    public partial class AvailabilityVwViewModel
    {
        public Availability Availability { get; set; }
    }
}