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
        #region ResourceGetPageByModule_Key_Value procedure.
		[Function(Name = "dbo.ResourceGetPageByModule_Key_Value")]
		private ISingleResult<Resource> _ResourceGetPageByModule_Key_Value([Parameter(Name = "@PageIndex")] Nullable<int> _pageIndex, [Parameter(Name = "@PageSize")] Nullable<int> _pageSize, [Parameter(Name = "@Language")] string _language, [Parameter(Name = "@SearchQuery")] string _searchQuery)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), _pageIndex, _pageSize, _language, _searchQuery);
			return (result.ReturnValue as ISingleResult<Resource>);
		}

		/// <summary>
		/// Skips (PageIndex) pages and returns the next (PageSize) records from the dbo.Resource table
		/// </summary>
		/// <param name="_pageIndex">Number of pages that should be skipped.. PageIndex starts with 0</param>
		/// <param name="_pageSize">Number of rows that should be taken. If PageSize = 0 all matching records will be returned.</param>
		/// <param name="_language">Language locale</param>
		/// <param name="_searchQuery"></param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
		/// <returns>A list of Resource instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Resource> ResourceGetPageByModule_Key_Value([Parameter(Name = "@PageIndex")] Nullable<int> _pageIndex, [Parameter(Name = "@PageSize")] Nullable<int> _pageSize, [Parameter(Name = "@Language")] string _language, [Parameter(Name = "@SearchQuery")] string _searchQuery, out int _totalRowCount)
		{
			ISingleResult<Resource> list = _ResourceGetPageByModule_Key_Value(_pageIndex, _pageSize, _language, _searchQuery);
            _totalRowCount = (int)list.ReturnValue;
            return list.ToList<Resource>();
		}

        /// <summary>
		/// Skips (PageIndex) pages and returns the next (PageSize) records from the dbo.Resource table
		/// </summary>
        /// <param name="filterInstance">An instance of ResourceGetPageByModule_Key_ValueFilter that defines filtering options.</param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
        /// <returns>A list of Resource instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public List<Resource> ResourceGetPageByModule_Key_Value(ResourceGetPageByModule_Key_ValueFilter filterInstance, out int _totalRowCount)
		{
			ISingleResult<Resource> list = _ResourceGetPageByModule_Key_Value(filterInstance.PageIndex, filterInstance.PageSize, filterInstance.Language, filterInstance.SearchQuery);
            _totalRowCount = (int)list.ReturnValue;
            return list.ToList<Resource>();
		}
		#endregion
	}
	#endregion

    #region GetPageFilterBase class definition
	/// <summary>
    /// Base of filter classes.
	/// </summary>
	public partial class GetPageFilterBase
	{
		#region Public properties
		/// <summary>
		/// Number of pages that should be skipped.
		/// </summary>
		public Nullable<int> PageIndex {get; set; }
		
		/// <summary>
		/// Number of rows that should be taken.
		/// </summary>
		public Nullable<int> PageSize {get; set; }
		#endregion
	}
	#endregion

	#region ResourceGetPageByModule_Key_ValueFilter class definition
	/// <summary>
    /// Filter class for ResourceGetPageByModule_Key_Value.
	/// </summary>
	public partial class ResourceGetPageByModule_Key_ValueFilter : GetPageFilterBase
	{
		#region Public properties
		/// <summary>
		/// Language locale
		/// </summary>
		public string Language {get; set; }
		/// <summary>
		/// Needs summary!
		/// </summary>
		public string SearchQuery {get; set; }
		#endregion
	}
	#endregion
}
