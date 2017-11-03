using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cf.Data.Resources
{
    /// <summary>
    /// Manages Resources
    /// </summary>
    public class ResourcesCollection
    {
        #region Private Fields
        private static string cs = System.Configuration.ConfigurationManager.ConnectionStrings["CfDatabase"].ConnectionString;
        private static object locker = new object();
        #endregion

        /// <summary>
        /// Resources like module/language/key
        /// </summary>
        private static Dictionary<string, Dictionary<string, Dictionary<string, ResourceValueItem>>> Resources { get; set; }

        /// <summary>
        /// Clears and reinitializes the resources dictionary
        /// </summary>
        /// <example>
        /// List&lt;Resource&gt; items = new List&lt;Resource&gt;()
        ///     {
        ///         new Resource() {Language = "en", Module = "Atm", Key = "Name", Value = "Name"},
        ///         new Resource() {Language = "en", Module = "Atm", Key = "Address", Value = "Address"},
        ///         new Resource() {Language = "ar", Module = "Atm", Key = "Name", Value = "محمد"},
        ///         new Resource() {Language = "ar", Module = "Atm", Key = "Address", Value = "العنوان"},
        ///         new Resource() {Language = "__", Module = "Config", Key = "SmtpAgent", Value = "smtp.aya.sy"},
        ///         new Resource() {Language = "__", Module = "Config", Key = "SenderEmail", Value = "ibrahim.alibrahim@ebridge-sy.com"},
        ///         new Resource() {Language = "__", Module = "Config", Key = "FeedbackReplySubject", Value = "Reply to your feedback from REB support team"}
        ///     };
        /// </example>
        public static void ReloadResources()
        {
            lock (locker)
            {
                Resources = new Dictionary<string, Dictionary<string, Dictionary<string, ResourceValueItem>>>();
                Db db = new Db(cs);
                List<Data.Resource> items = db.ResourceList();
                foreach (Data.Resource item in items)
                {
                    if (!Resources.ContainsKey(item.Module))
                        Resources.Add(item.Module, new Dictionary<string, Dictionary<string, ResourceValueItem>>());
                    if (!Resources[item.Module].ContainsKey(item.Language))
                        Resources[item.Module].Add(item.Language, new Dictionary<string, ResourceValueItem>());
                    Resources[item.Module][item.Language][item.Key] = new ResourceValueItem() { Value = item.Value, IsEditable = item.IsEditable };
                }
            }
        }

        /// <summary>
        /// Get resource value
        /// </summary>
        /// <param name="language"></param>
        /// <param name="module"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetString(string language, string module, string key)
        {
            string value = key;
            try
            {
               value = Resources[module][language][key].Value;
            }
            catch { }
            return value != null ? value : string.Empty;
        }

        /// <summary>
        /// Returns a list of resources page by page
        /// </summary>
        /// <param name="pageStart">Page start index</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="module">The module selector</param>
        /// <param name="language">language</param>
        /// <param name="totalRowsCount">total module/language resources count</param>
        /// <returns></returns>
        public static List<Data.Resource> GetPagedResources(string language, int pageStart, int pageSize, string module, out int totalRowsCount)
        {
            List<Data.Resource> resources = new List<Data.Resource>();
            int i = 0;
            if (Resources.ContainsKey(module) && Resources[module].ContainsKey(language))
            {
                Dictionary<string, ResourceValueItem> items = Resources[module][language];
                foreach (KeyValuePair<string, ResourceValueItem> item in items)
                {
                    if (i >= pageStart * pageSize && i < (pageStart + 1) * pageSize)
                    {
                        resources.Add(new Cf.Data.Resource()
                        {
                            Module = module,
                            Language = language,
                            Key = item.Key,
                            Value = item.Value.Value,
                            IsEditable = item.Value.IsEditable
                        });
                    }
                    i++;
                }
            }
            totalRowsCount = i;
            return resources;
        }

        /// <summary>
        /// Adds a Resource to the Resources dictionnary
        /// </summary>
        public static void AddResource(Data.Resource resource)
        {
            Resources[resource.Module][resource.Language][resource.Key] = new ResourceValueItem()
            {
                Value = resource.Value,
                IsEditable = resource.IsEditable
            };
        }
        /// <summary>
        /// List modules
        /// </summary>
        /// <returns>List of modules as strings</returns>
        public static List<string> ListModules()
        {
            return Resources.Keys.ToList();
        }

        /// <summary>
        /// Returns the distinct keys in all modules dictionaries (i.e. Language(s)).
        /// </summary>
        /// <returns>Supported Languages List.</returns>
        public static List<string> ListSupportedLanguages()
        {
            return Resources.Values
                .SelectMany(d => d.Keys) // select the keys of the values dictionaries
                .Distinct() // maintain only distinct keys
                .Where(s => !s.StartsWith("_")) // not starting with "_"
                .ToList(); 
        }

        /// <summary>
        /// Get specific resource
        /// </summary>
        /// <param name="language">ar/en</param>
        /// <param name="module">module name</param>
        /// <param name="key">resource key</param>
        /// <param name="notTranslated">Informs whether the resource is translated or not</param>
        /// <returns>Returns the matching resource</returns>
        public static Data.Resource GetResource(string language, string module, string key, out bool notTranslated)
        {
            string value = key;

            Data.Resource resource = new Data.Resource()
            {
                Module = module,
                Language = language,
                Key = key
            };
            try
            {
                ResourceValueItem item = Resources[module][language][key];
                resource.Value = item.Value;
                resource.IsEditable = item.IsEditable;
                notTranslated = false;
            }
            catch
            {
                try
                {
                    string complementaryLanguage = (language == "ar" ? "en" : "ar");
                    ResourceValueItem item = Resources[module][complementaryLanguage][key];
                    resource.Value = item.Value;
                    resource.IsEditable = item.IsEditable;
                    notTranslated = true;
                }
                catch
                {
                    notTranslated = false;
                    resource = null;
                }
            }
            return resource;
        }
        /// <summary>
        /// Edit specific resource
        /// </summary>
        /// <param name="resource">The modified resource</param>
        public static void EditResource(Data.Resource resource)
        {
            Resources[resource.Module][resource.Language][resource.Key].Value = resource.Value;
        }

        /// <summary>
        /// Retreives the non translated resources in the language parameter
        /// </summary>
        /// <param name="pageStart">Page start index</param>
        /// <param name="pageSize">Page size</param>
        /// <param name="language">language</param>
        /// <param name="totalRowsCount">total module/language resources count</param>
        /// <returns></returns>
        public static List<Data.Resource> GetNonTranslatedResources(string language, int pageStart, int pageSize, out int totalRowsCount)
        {
            List<Data.Resource> resources = new List<Data.Resource>();
            string complementaryLanguage = (language == "ar" ? "en" : "ar");
            int i = 0;
            List<string> modules = ListModules();
            foreach (string module in modules)
            {
                if (Resources.ContainsKey(module) && Resources[module].ContainsKey(complementaryLanguage))
                {
                    Dictionary<string, ResourceValueItem> complementaryItems = Resources[module][complementaryLanguage];
                    Dictionary<string, ResourceValueItem> originalItems = Resources[module][language];
                    foreach (KeyValuePair<string, ResourceValueItem> complementaryItem in complementaryItems)
                    {
                        if (!originalItems.ContainsKey(complementaryItem.Key))
                        {
                            if (i >= pageStart * pageSize && i < (pageStart + 1) * pageSize)
                            {
                                resources.Add(new Cf.Data.Resource()
                                {
                                    Module = module,
                                    Language = complementaryLanguage,
                                    Key = complementaryItem.Key,
                                    Value = complementaryItem.Value.Value,
                                    IsEditable = complementaryItem.Value.IsEditable
                                });
                            }
                            i++;
                        }
                    }
                }
            }
            totalRowsCount = i;
            return resources;
        }
    }

    class ResourceValueItem
    {
        public string Value { get; set; }
        public bool IsEditable { get; set; }
    }
}
