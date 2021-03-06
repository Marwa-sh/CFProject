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
    public partial class FormAvailabilityCeilingView : System.Windows.Forms.Form
    {
        public FormAvailabilityCeilingView()
        {
            InitializeComponent();
        }

        private void FormAvailabilityCeilingView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = AvailabilityCeilingVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<AvailabilityCeilingVw> dataSource = null;
        public List<AvailabilityCeilingVw> DataSource
        {
            set
            {
                dataSource = value;
                availabilityCeilingVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

