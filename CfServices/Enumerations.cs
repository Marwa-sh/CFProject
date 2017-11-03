using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cf.Services
{
    /// <summary>
    /// Enumerates Module names
    /// </summary>
    public enum ModuleName
    {
        /// <summary>
        /// ResourceManager module name
        /// </summary>
        ResourceManager,
        /// <summary>
        /// Employee module name
        /// </summary>
        Employee,
        /// <summary>
        /// LoanDemand module name
        /// </summary>
        LoanDemand
    }

    /// <summary>
    /// Enumerates ResourceManager values
    /// </summary>
    public enum ResourceManager : int
    {
        /// <summary>
        /// Value for InvalidResource
        /// </summary>
        InvalidResource = 200,
        /// <summary>
        /// Value for non-editable resource
        /// </summary>
        IsNotEditableResource = 201
    }
}