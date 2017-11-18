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
    public partial class FormMainWorkPlaceView : System.Windows.Forms.Form
    {
        public FormMainWorkPlaceView()
        {
            InitializeComponent();
        }

        private void FormMainWorkPlaceView_Load(object sender, EventArgs e)
        {
            if (dataSource == null)
            {
				DateTime dt = DateTime.Now;
				DataSource = MainWorkPlaceVwServices.List(new Db(DbServices.ConnectionString));
				slblEllapsedTimeValue.Text = (DateTime.Now.Subtract(dt).TotalMilliseconds / 1000).ToString();
            }
        }

        #region Public properties
        private List<MainWorkPlaceVw> dataSource = null;
        public List<MainWorkPlaceVw> DataSource
        {
            set
            {
                dataSource = value;
                mainWorkPlaceVwBindingSource.DataSource = dataSource;
            }
        }
        #endregion
    }
}

