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
    public partial class FormEmployeeSeniorityView : System.Windows.Forms.Form
    {
        public FormEmployeeSeniorityView()
        {
            InitializeComponent();
        }

        private void FormEmployeeSeniorityView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = EmployeeSeniorityVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<EmployeeSeniorityVw> dataSource = null;
        public List<EmployeeSeniorityVw> DataSource
        {
            set
            {
                dataSource = value;
                employeeSeniorityVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

