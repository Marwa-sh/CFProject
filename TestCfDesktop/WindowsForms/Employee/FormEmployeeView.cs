using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Linq;
using System.Windows.Forms;
using Cf.Data;
using Cf.Services;

namespace Cf
{
    public partial class FormEmployeeView : System.Windows.Forms.Form
    {
        public FormEmployeeView()
        {
            InitializeComponent();
        }

        private void FormEmployeeView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = EmployeeVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<EmployeeVw> dataSource = null;
        public List<EmployeeVw> DataSource
        {
            set
            {
                dataSource = value;
                employeeVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

