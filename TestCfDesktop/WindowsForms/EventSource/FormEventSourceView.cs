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
    public partial class FormEventSourceView : System.Windows.Forms.Form
    {
        public FormEventSourceView()
        {
            InitializeComponent();
        }

        private void FormEventSourceView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = EventSourceVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<EventSourceVw> dataSource = null;
        public List<EventSourceVw> DataSource
        {
            set
            {
                dataSource = value;
                eventSourceVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

