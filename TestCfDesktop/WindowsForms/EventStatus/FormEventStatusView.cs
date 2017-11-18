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
    public partial class FormEventStatusView : System.Windows.Forms.Form
    {
        public FormEventStatusView()
        {
            InitializeComponent();
        }

        private void FormEventStatusView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = EventStatusVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<EventStatusVw> dataSource = null;
        public List<EventStatusVw> DataSource
        {
            set
            {
                dataSource = value;
                eventStatusVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}
