using System;
using System.ComponentModel;
using System.Reflection;

namespace Cf.Data
{
    /// <summary>
    /// An attribute used for tooltip resources
    /// </summary>
    public class TooltipAttribute : DescriptionAttribute
    {
        /// <summary>
        /// A description localized to a specified language
        /// </summary>
        public string LocalizedDescription { get; set; }

        /// <summary>
        /// Hidden to force a message to be displayed
        /// </summary>
        private TooltipAttribute()
            : base("")
        {
        }
 
        /// <summary>
        /// Tooltip attribute for adding helper messages to model entities.
        /// </summary>
        /// <param name="name">The tooltip message to be displayed</param>
        /// <param name="ResourceType">The resource type</param>
        public TooltipAttribute(string name, Type ResourceType)
        {
            PropertyInfo pi = ResourceType.GetProperty(name);
            string s = pi.GetValue(null).ToString();
            this.LocalizedDescription = s;
        }
    }
}
