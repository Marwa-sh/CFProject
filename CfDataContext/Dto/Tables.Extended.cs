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
                return Id + " " + FirstName + " " + LastName;
            }
            set
            {
                id_name = value;
            }
        }
		public string FullName { get; set; }
		public string FullName3 { get; set; }
		#endregion
	}
    #endregion

    #region LoanVw
    public partial class LoanVw
    {
        public bool IsChecked { get; set; }
    }
    #endregion

}
