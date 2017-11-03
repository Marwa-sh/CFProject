using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cf.Services.Exceptions
{
#region UnexpectedException

/// <summary>
/// Represents an unexpected exception derived from CfExceptionBase class
/// </summary>
public class UnexpectedException : CfException
{
    /// <summary>
    /// Public constructor of UnexpectedException class
    /// </summary>
    /// <param name="module">Module name</param>
    /// <param name="message">Error message</param>
    /// <param name="exc">Inner exception. Default value is null</param>
    public UnexpectedException(string module, string message, Exception exc = null)
        : base(module, -1, message, exc)
    { }
}
#endregion

#region ResourceManagerException
/// <summary>
/// Represents a resource manager exception derived from CfExceptionBase class
/// </summary>
public class ResourceManagerException : CfException
{
    private static string resourceManagerModule = ModuleName.ResourceManager.ToString();

    /// <summary>
    /// Public constructor of ResourceManagerException class
    /// </summary>
    /// <param name="number">Exception number</param>
    /// <param name="message">Error message</param>
    /// <param name="exc">Inner exception. Default value is null</param>
    public ResourceManagerException(int number, string message, Exception exc = null)
        : base(resourceManagerModule, -1, message, exc)
    {
        this.Number = number;
    }

    /// <summary>
    /// Public static ResourceManagerException that represents an invalid resource
    /// </summary>
    public static ResourceManagerException InvalidResource
        = new ResourceManagerException((int)ResourceManager.InvalidResource, "Invalid Resource");

    /// <summary>
    /// Public static ResourceManagerException that represents a non-editable resource
    /// </summary>
    public static ResourceManagerException IsNotEditableResource
        = new ResourceManagerException((int)ResourceManager.IsNotEditableResource, "Invalid Resource");
}
#endregion
}
