using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Cf.Data;
using Cf.Services;

namespace Cf.ViewModels
{
    public  partial class ResourceViewModel
    {
        public ResourceViewModel()
        {
            // List = new List<ResourceVw>();
            // Instance = new ResourceVw();
            // Filter = new ResourceVwSelector();
        }
        public List<ResourceVw> List { get; set; } = new List<ResourceVw>();
        // public ResourceVwSelector Filter { get; set; } = new ResourceVwSelector();
        public ResourceVw Instance { get; set; } = new ResourceVw();
    }
}