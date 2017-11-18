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
    public partial class FormEventLogErrorView : System.Windows.Forms.Form
    {
        public FormEventLogErrorView()
        {
            InitializeComponent();
        }

        private void FormEventLogErrorView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = EventLogErrorVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<EventLogErrorVw> dataSource = null;
        public List<EventLogErrorVw> DataSource
        {
            set
            {
                dataSource = value;
                eventLogErrorVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

