using System;

namespace Cf.Data.Resources
{
    #region ResourceBase class
    /// <summary>
    /// Base Resource management class
    /// </summary>
    public abstract class ResourceBase
    {
        /// <summary>
        /// Gets the Culture for which localized resources should be got
        /// </summary>
        public static string Culture
        {
            get
            {
                return "ar";
                // return System.Threading.Thread.CurrentThread.CurrentUICulture.TwoLetterISOLanguageName;
            }
        }
    }
    #endregion
}
