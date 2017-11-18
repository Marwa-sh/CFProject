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
    public partial class FormAvailabilityView : System.Windows.Forms.Form
    {
        public FormAvailabilityView()
        {
            InitializeComponent();
        }

        private void FormAvailabilityView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = AvailabilityVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<AvailabilityVw> dataSource = null;
        public List<AvailabilityVw> DataSource
        {
            set
            {
                dataSource = value;
                availabilityVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

