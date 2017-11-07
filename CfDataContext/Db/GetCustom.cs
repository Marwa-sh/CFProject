using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace Cf.Data
{
	#region Db class definition
    public partial class Db
    {
        #region LoanGenerate procedure.
		[Function(Name = "dbo.LoanGenerate")]
		private int _LoanGenerate([Parameter(Name = "@ProductId")] Nullable<int> _productId, [Parameter(Name = "@LoanDecisionId")] Nullable<int> _loanDecisionId, [Parameter(Name = "@LoanGenerationStatusId")] Nullable<byte> _loanGenerationStatusId)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _productId, _loanDecisionId, _loanGenerationStatusId);
			return (int) (result.ReturnValue);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
		/// <param name="_productId">معرف المنتج</param>
		/// <param name="_loanDecisionId">معرف قرار السلف</param>
		/// <param name="_loanGenerationStatusId">معرف حالة توليد البطاقة</param>
		public void LoanGenerate([Parameter(Name = "@ProductId")] Nullable<int> _productId, [Parameter(Name = "@LoanDecisionId")] Nullable<int> _loanDecisionId, [Parameter(Name = "@LoanGenerationStatusId")] Nullable<byte> _loanGenerationStatusId)
		{
			_LoanGenerate(_productId, _loanDecisionId, _loanGenerationStatusId);
		}

		/// <summary>
		/// Needs summary!
		/// </summary>
        /// <param name="filterInstance">An instance of LoanGenerateFilter that defines filtering options.</param>
		public void LoanGenerate(LoanGenerateFilter filterInstance)
		{
			_LoanGenerate(filterInstance.ProductId, filterInstance.LoanDecisionId, filterInstance.LoanGenerationStatusId);
		}
		#endregion
	}
	#endregion

	#region LoanGenerate filter and result classes
	#region LoanGenerateFilter class definition
	/// <summary>
    /// Filter class for LoanGenerate.
	/// </summary>
	public partial class LoanGenerateFilter
	{
		#region Public properties
		/// <summary>
		/// معرف المنتج
		/// </summary>
		public Nullable<int> ProductId {get; set; }
		
		/// <summary>
		/// معرف قرار السلف
		/// </summary>
		public Nullable<int> LoanDecisionId {get; set; }
		/// <summary>
		/// معرف حالة توليد البطاقة
		/// </summary>
		public Nullable<byte> LoanGenerationStatusId {get; set; }
		#endregion
	}
	#endregion

	#endregion
}
