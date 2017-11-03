namespace Cf.Data
{
    #region EmployeeVw
    public partial class EmployeeVw
    {
        public EmployeeVw()
        {

        }
        #region Public properties
        private string name;
        public string Name
        {
            get
            {
                return FullName;
            }
            set
            {
                name = value;
            }
        }
        #endregion
    }
    #endregion
}
