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
    public partial class FormSubscriptionTypeView : System.Windows.Forms.Form
    {
        public FormSubscriptionTypeView()
        {
            InitializeComponent();
        }

        private void FormSubscriptionTypeView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = SubscriptionTypeVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<SubscriptionTypeVw> dataSource = null;
        public List<SubscriptionTypeVw> DataSource
        {
            set
            {
                dataSource = value;
                subscriptionTypeVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

