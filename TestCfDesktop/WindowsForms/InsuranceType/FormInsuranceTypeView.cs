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
    public partial class FormInsuranceTypeView : System.Windows.Forms.Form
    {
        public FormInsuranceTypeView()
        {
            InitializeComponent();
        }

        private void FormInsuranceTypeView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = InsuranceTypeVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<InsuranceTypeVw> dataSource = null;
        public List<InsuranceTypeVw> DataSource
        {
            set
            {
                dataSource = value;
                insuranceTypeVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

