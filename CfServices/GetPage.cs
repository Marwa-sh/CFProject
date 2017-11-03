using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using Cf.Data;

namespace Cf.Services
{
    #region ResourceServices
    public static partial class ResourceServices
    {
        #region ResourceGetPageByModule_Key_Value procedure.
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
		public static List<Resource> GetPageByModule_Key_Value(Nullable<int> _pageIndex, Nullable<int> _pageSize, string _language, string _searchQuery, out int _totalRowCount)
		{
			Db db = new Db(DbServices.ConnectionString);
            return GetPageByModule_Key_Value(_pageIndex, _pageSize, _language, _searchQuery, db, out _totalRowCount);
		}

        /// <summary>
        /// Skips (PageIndex) pages and returns the next (PageSize) records from the dbo.Resource table
        /// </summary>
        /// <param name="_pageIndex">Number of pages that should be skipped.. PageIndex starts with 0</param>
        /// <param name="_pageSize">Number of rows that should be taken. If PageSize = 0 all matching records will be returned.</param>
        /// <param name="_language">Language locale</param>
        /// <param name="_searchQuery"></param>
        /// <param name="db">Db object on which the command will be executed</param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
        /// <returns>A list of Resource instances.</returns>
        /// <remarks>This method never returns null, 
        ///	if no records are available, length of the list will be 0.</remarks>
        public static List<Resource> GetPageByModule_Key_Value(Nullable<int> _pageIndex, Nullable<int> _pageSize, string _language, string _searchQuery, Db db, out int _totalRowCount)
		{
			return db.ResourceGetPageByModule_Key_Value(_pageIndex, _pageSize, _language, _searchQuery, out _totalRowCount);
		}

        /// <summary>
		/// Skips (PageIndex) pages and returns the next (PageSize) records from the dbo.Resource table
		/// </summary>
        /// <param name="filterInstance">An instance of ResourceGetPageByModule_Key_ValueFilter that defines filtering options.</param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
        /// <returns>A list of Resource instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<Resource> GetPageByModule_Key_Value(ResourceGetPageByModule_Key_ValueFilter filterInstance, out int _totalRowCount)
		{
            Db db = new Db(DbServices.ConnectionString);
			return GetPageByModule_Key_Value(filterInstance, db, out _totalRowCount);
		}

        /// <summary>
		/// Skips (PageIndex) pages and returns the next (PageSize) records from the dbo.Resource table
		/// </summary>
        /// <param name="filterInstance">An instance of ResourceGetPageByModule_Key_ValueFilter that defines filtering options.</param>
        /// <param name="db">Db object on which the command will be executed</param>
        /// <param name="_totalRowCount">Total number of rows returned by the specified filter.</param>
        /// <returns>A list of Resource instances.</returns>
		/// <remarks>This method never returns null, 
		///	if no records are available, length of the list will be 0.</remarks>
		public static List<Resource> GetPageByModule_Key_Value(ResourceGetPageByModule_Key_ValueFilter filterInstance, Db db, out int _totalRowCount)
		{
			return db.ResourceGetPageByModule_Key_Value(filterInstance, out _totalRowCount);
		}
		#endregion
    }
    #endregion
}
