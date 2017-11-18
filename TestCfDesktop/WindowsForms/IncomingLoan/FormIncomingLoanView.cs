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
    public partial class FormIncomingLoanView : System.Windows.Forms.Form
    {
        public FormIncomingLoanView()
        {
            InitializeComponent();
        }

        private void FormIncomingLoanView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = IncomingLoanVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<IncomingLoanVw> dataSource = null;
        public List<IncomingLoanVw> DataSource
        {
            set
            {
                dataSource = value;
                incomingLoanVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

