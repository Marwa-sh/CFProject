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
    public partial class FormDepartmentView : System.Windows.Forms.Form
    {
        public FormDepartmentView()
        {
            InitializeComponent();
        }

        private void FormDepartmentView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = DepartmentVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<DepartmentVw> dataSource = null;
        public List<DepartmentVw> DataSource
        {
            set
            {
                dataSource = value;
                departmentVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

