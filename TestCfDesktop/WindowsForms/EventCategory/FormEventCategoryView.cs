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
    public partial class FormEventCategoryView : System.Windows.Forms.Form
    {
        public FormEventCategoryView()
        {
            InitializeComponent();
        }

        private void FormEventCategoryView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = EventCategoryVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<EventCategoryVw> dataSource = null;
        public List<EventCategoryVw> DataSource
        {
            set
            {
                dataSource = value;
                eventCategoryVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

