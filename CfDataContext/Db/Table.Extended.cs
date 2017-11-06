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
        [Function(Name = "dbo.LoanGeneration")]
        private int _LoanGeneration([Parameter(Name = "@ProductId")] int _productId, [Parameter(Name = "@LoanDecisionId")] int _loanDecisionId, [Parameter(Name = "@LoanGenerationStatusId")] byte _loanGenerationStatusId)
        {
            IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _productId, _loanDecisionId, _loanGenerationStatusId);
            return (int) (result.ReturnValue);
        }

        /// <summary>
        /// Selects all rows from the dbo.EmployeeStatus table.
        /// </summary>
        /// <returns>A list of EmployeeStatus instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public void LoanGeneration([Parameter(Name = "@ProductId")] int _productId, [Parameter(Name = "@LoanDecisionId")] int _loanDecisionId, [Parameter(Name = "@LoanGenerationStatusId")] byte _loanGenerationStatusId)
        {
			_LoanGeneration(_productId, _loanDecisionId, _loanGenerationStatusId);
        }
		#endregion
		#endregion
	}
}
