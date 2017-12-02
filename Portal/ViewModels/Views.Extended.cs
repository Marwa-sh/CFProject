using Cf.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cf.ViewModels
{
    public partial class LoanVwViewModel
    {
        public GetInstallmentsResult InstallmentResultInstance { get; set; } = new GetInstallmentsResult();
        public List<GetInstallmentsResult> InstallmentsResultList { get; set; } = new List<GetInstallmentsResult>();
    }
}