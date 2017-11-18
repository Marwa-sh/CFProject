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
    public partial class FormOutgoingLoanView : System.Windows.Forms.Form
    {
        public FormOutgoingLoanView()
        {
            InitializeComponent();
        }

        private void FormOutgoingLoanView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = OutgoingLoanVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<OutgoingLoanVw> dataSource = null;
        public List<OutgoingLoanVw> DataSource
        {
            set
            {
                dataSource = value;
                outgoingLoanVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

