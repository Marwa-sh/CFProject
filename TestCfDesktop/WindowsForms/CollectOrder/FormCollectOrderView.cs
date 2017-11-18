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
    public partial class FormCollectOrderView : System.Windows.Forms.Form
    {
        public FormCollectOrderView()
        {
            InitializeComponent();
        }

        private void FormCollectOrderView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = CollectOrderVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<CollectOrderVw> dataSource = null;
        public List<CollectOrderVw> DataSource
        {
            set
            {
                dataSource = value;
                collectOrderVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

