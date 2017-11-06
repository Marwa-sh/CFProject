using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Cf.Data
{
    public partial class Db
    {
        #region LoanDecision procedures.
        #region Initialize Loan
        [Function(Name = "dbo.InitializeLoan")]
        private int _LoanDecisionInitializeLoan([Parameter(Name = "@LoanRequestId")] int _id, [Parameter(Name = "@MinSeniority")] byte _minSeniority)
        {
            IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
            return (int) (result.ReturnValue);
        }

        /// <summary>
        /// Selects all rows from the dbo.EmployeeStatus table.
        /// </summary>
        /// <returns>A list of EmployeeStatus instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public void LoanDecisionInitializeLoan()
        {
            LoanDecisionInitializeLoan();
        }
        #endregion
    }
    #endregion
}
