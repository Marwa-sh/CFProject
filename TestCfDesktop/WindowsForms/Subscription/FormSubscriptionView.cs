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
    public partial class FormSubscriptionView : System.Windows.Forms.Form
    {
        public FormSubscriptionView()
        {
            InitializeComponent();
        }

        private void FormSubscriptionView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = SubscriptionVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<SubscriptionVw> dataSource = null;
        public List<SubscriptionVw> DataSource
        {
            set
            {
                dataSource = value;
                subscriptionVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

