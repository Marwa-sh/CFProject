using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel.DataAnnotations;

namespace Cf.Data
{
    #region EmployeeVw
    public partial class Employee
    {
        public Employee()
        {

        }
        #region Public properties
        private string name;
        public string Name
        {
            get
            {
                return FirstName + " " + LastName;
            }
            set
            {
                name = value;
            }
        }
        private string id_name;
        public string Id_Name
        {
            get
            {
                return Id+ " " + FirstName + " " + LastName;
            }
            set
            {
                id_name = value;
            }
        }
        #endregion
    }
    #endregion
}
