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
    public partial class FormSpecialCaseLoanView : System.Windows.Forms.Form
    {
        public FormSpecialCaseLoanView()
        {
            InitializeComponent();
        }

        private void FormSpecialCaseLoanView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = SpecialCaseLoanVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<SpecialCaseLoanVw> dataSource = null;
        public List<SpecialCaseLoanVw> DataSource
        {
            set
            {
                dataSource = value;
                specialCaseLoanVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

