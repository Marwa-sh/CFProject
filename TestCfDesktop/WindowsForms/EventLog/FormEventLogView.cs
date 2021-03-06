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
    public partial class FormEventLogView : System.Windows.Forms.Form
    {
        public FormEventLogView()
        {
            InitializeComponent();
        }

        private void FormEventLogView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = EventLogVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<EventLogVw> dataSource = null;
        public List<EventLogVw> DataSource
        {
            set
            {
                dataSource = value;
                eventLogVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

