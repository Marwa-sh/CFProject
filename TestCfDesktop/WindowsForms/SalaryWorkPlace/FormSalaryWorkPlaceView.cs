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
    public partial class FormSalaryWorkPlaceView : System.Windows.Forms.Form
    {
        public FormSalaryWorkPlaceView()
        {
            InitializeComponent();
        }

        private void FormSalaryWorkPlaceView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = SalaryWorkPlaceVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<SalaryWorkPlaceVw> dataSource = null;
        public List<SalaryWorkPlaceVw> DataSource
        {
            set
            {
                dataSource = value;
                salaryWorkPlaceVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

