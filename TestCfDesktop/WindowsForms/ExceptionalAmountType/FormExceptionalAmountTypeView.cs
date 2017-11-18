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
    public partial class FormExceptionalAmountTypeView : System.Windows.Forms.Form
    {
        public FormExceptionalAmountTypeView()
        {
            InitializeComponent();
        }

        private void FormExceptionalAmountTypeView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = ExceptionalAmountTypeVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<ExceptionalAmountTypeVw> dataSource = null;
        public List<ExceptionalAmountTypeVw> DataSource
        {
            set
            {
                dataSource = value;
                exceptionalAmountTypeVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

