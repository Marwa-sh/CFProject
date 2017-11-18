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
    public partial class FormProductTypeAvailabilityView : System.Windows.Forms.Form
    {
        public FormProductTypeAvailabilityView()
        {
            InitializeComponent();
        }

        private void FormProductTypeAvailabilityView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = ProductTypeAvailabilityVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<ProductTypeAvailabilityVw> dataSource = null;
        public List<ProductTypeAvailabilityVw> DataSource
        {
            set
            {
                dataSource = value;
                productTypeAvailabilityVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

