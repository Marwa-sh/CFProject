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
    public partial class FormTransitoryIncomingLoanView : System.Windows.Forms.Form
    {
        public FormTransitoryIncomingLoanView()
        {
            InitializeComponent();
        }

        private void FormTransitoryIncomingLoanView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = TransitoryIncomingLoanVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<TransitoryIncomingLoanVw> dataSource = null;
        public List<TransitoryIncomingLoanVw> DataSource
        {
            set
            {
                dataSource = value;
                transitoryIncomingLoanVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

