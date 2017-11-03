using System;

namespace Cf.Data.Resources
{
    /// <summary>
    /// Manages common resources
    /// </summary>
public class CommonResources : ResourceBase
{
    internal CommonResources()
    {
    }

    /// <summary>
    /// Looks up a localized string similar to The {0} must be in a date format.
    /// </summary>
    public static string DateCheck
    {
        get
        {
            return ResourcesCollection.GetString(Culture, "CommonResources", "DateCheck");
        }
    }

    /// <summary>
    /// Looks up a localized string similar to The {0} must be in a date time format.
    /// </summary>
    public static string DateTimeCheck
    {
        get
        {
            return ResourcesCollection.GetString(Culture, "CommonResources", "DateTimeCheck");
        }
    }

    /// <summary>
    /// Looks up a localized string similar to The {0} must be larger than {1}.
    /// </summary>
    public static string RangeCheck
    {
        get
        {
            return ResourcesCollection.GetString(Culture, "CommonResources", "RangeCheck");
        }
    }

    /// <summary>
    /// Looks up a localized string similar to {0} is required.
    /// </summary>
    public static string RequiredCheck
    {
        get
        {
            return ResourcesCollection.GetString(Culture, "CommonResources", "RequiredCheck");
        }
    }

    /// <summary>
    /// Looks up a localized string similar to The {0} must be between {2} and {1}.
    /// </summary>
    public static string StringLengthCheck
    {
        get
        {
            return ResourcesCollection.GetString(Culture, "CommonResources", "StringLengthCheck");
        }
    }

    /// <summary>
    /// Looks up a localized string similar to The {0} must be in a time format.
    /// </summary>
    public static string TimeCheck
    {
        get
        {
            return ResourcesCollection.GetString(Culture, "CommonResources", "TimeCheck");
        }
    }
    /// <summary>
    /// Looks up a localized string similar to The {0} dont match {1}.
    /// </summary>
    public static string CompareCheck
    {
        get
        {   
            return ResourcesCollection.GetString(Culture, "CommonResources", "CompareCheck");
        }
    }

    /// <summary>
    /// Looks up a localized string similar to The {0} must be a number.
    /// </summary>
    public static string NumberCheck
    {
        get
        {
            return ResourcesCollection.GetString(Culture, "CommonResources", "NumberCheck");
        }
    }
    /// <summary>
    /// Looks up a localized string similar to The {0} must be an email address.
    /// </summary>
    public static string EmailCheck
    {
        get
        {
            return ResourcesCollection.GetString(Culture, "CommonResources", "EmailCheck");
        }
    }
}
}
