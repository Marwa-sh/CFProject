using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cf.Services.Exceptions;
using Cf.Data;

namespace Cf.Services
{
    public static partial class ResourceServices
    {
        /// <summary>
        /// Relaod resources
        /// </summary>
        public static void ReloadResources()
        {
            try
            {
                Cf.Data.Resources.ResourcesCollection.ReloadResources();
            }
            catch (Exception exc)
            {
                throw new UnexpectedException(ModuleName.ResourceManager.ToString(), exc.Message, exc);
            }
        }
        /// <summary>
        /// Gets the resource value
        /// </summary>
        /// <param name="language">locale language</param>
        /// <param name="module">module name</param>
        /// <param name="key">resource key</param>
        /// <returns>Returns the resource value</returns>
        public static string GetString(string language, string module, string key)
        {
            return Cf.Data.Resources.ResourcesCollection.GetString(language, module, key);
        }

        /// <summary>
        /// Gets a page of resources
        /// </summary>
        /// <param name="language">Localized language for resources</param>
        /// <param name="index">Page index starting from 0</param>
        /// <param name="length">Page size</param>
        /// <param name="queryWord">Search word</param>
        /// <param name="totalRowCount">Total row count for all rows returned by the search</param>
        /// <returns></returns>
        public static List<Resource> GetPagedResources(string language, int index, int length, string queryWord, out int totalRowCount)
        {
            Db db = new Db(DbServices.ConnectionString);
            return db.ResourceGetPageByModule_Key_Value(index, length, language, queryWord, out totalRowCount);
        }

        /// <summary>
        /// Gets non-translated resources
        /// </summary>
        /// <param name="language">Localized language for resources</param>
        /// <param name="pageStart">Page index starting from 0</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="totalRowsCount">Total row count for all rows returned by the search</param>
        /// <returns></returns>
        public static List<Resource> GetNonTranslatedResources(string language, int pageStart, int pageSize, out int totalRowsCount)
        {
            return Cf.Data.Resources.ResourcesCollection.GetNonTranslatedResources(language, pageStart, pageSize, out totalRowsCount);
        }

        /// <summary>
        /// Lists all resource module names
        /// </summary>
        /// <returns>A list of strings that represent module names</returns>
        public static List<string> ListModules()
        {
            return Cf.Data.Resources.ResourcesCollection.ListModules();
        }

        /// <summary>
        /// Gets a resource value for a specific module, key and language
        /// </summary>
        /// <param name="language">Localized language for the resource</param>
        /// <param name="module">Module name</param>
        /// <param name="key">Resource key</param>
        /// <param name="notTranslated">Informs whether the resource is already translated or not</param>
        /// <returns>Returns a Resource object for the specified language, module and key</returns>
        public static Cf.Data.Resource GetResource(string language, string module, string key, out bool notTranslated)
        {
            return Cf.Data.Resources.ResourcesCollection.GetResource(language, module, key, out notTranslated);
        }

        /// <summary>
        /// Edits the Value and the IsEditable of a resource.
        /// </summary>
        /// <param name="resource">The Resource object to be edited</param>
        public static void EditResource(Cf.Data.Resource resource)
        {
            bool notTranslated;
            Cf.Data.Resource originalResource = GetResource(resource.Language, resource.Module, resource.Key, out notTranslated);
            if (originalResource == null)
                throw ResourceManagerException.InvalidResource;
            if (!originalResource.IsEditable)
                throw ResourceManagerException.IsNotEditableResource;
            originalResource.Value = resource.Value;
            Db db = new Db(DbServices.ConnectionString);
            if (notTranslated)
            {
                Cf.Data.Resources.ResourcesCollection.AddResource(originalResource);
                db.ResourceInsert(originalResource);
            }
            else
            {
                Cf.Data.Resources.ResourcesCollection.EditResource(originalResource);
                db.ResourceUpdate(originalResource);
            }
        }
    }
}
