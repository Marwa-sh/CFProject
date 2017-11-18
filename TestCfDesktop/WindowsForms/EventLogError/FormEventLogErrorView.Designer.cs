namespace Cf
{
    partial class FormEventLogErrorView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEventLogErrorView));
            this.eventLogErrorVwBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventLogErrorVwBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.eventLogErrorVwDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnEventLogId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEventLogEventSourceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEventLogEventSourceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEventLogEventCategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEventLogEventCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEventLogEventStatusId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEventLogEventStatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEventLogEventStatusIcon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEventLogParameters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEventLogDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEventLogUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnStackTrace = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.slblEllapsedTimeName = new System.Windows.Forms.ToolStripStatusLabel();
			this.slblEllapsedTimeValue = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.eventLogErrorVwBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLogErrorVwBindingNavigator)).BeginInit();
            this.eventLogErrorVwBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLogErrorVwDataGridView)).BeginInit();
			this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventLogErrorVwBindingSource
            // 
            this.eventLogErrorVwBindingSource.DataSource = typeof(Cf.Data.EventLogErrorVw);
            // 
            // eventLogErrorVwBindingNavigator
            // 
            this.eventLogErrorVwBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eventLogErrorVwBindingNavigator.AllowItemReorder = true;
            this.eventLogErrorVwBindingNavigator.BindingSource = this.eventLogErrorVwBindingSource;
            this.eventLogErrorVwBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eventLogErrorVwBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.eventLogErrorVwBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.eventLogErrorVwBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.eventLogErrorVwBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eventLogErrorVwBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eventLogErrorVwBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eventLogErrorVwBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eventLogErrorVwBindingNavigator.Name = "eventLogErrorVwBindingNavigator";
            this.eventLogErrorVwBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eventLogErrorVwBindingNavigator.Size = new System.Drawing.Size(598, 25);
            this.eventLogErrorVwBindingNavigator.TabIndex = 0;
            this.eventLogErrorVwBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // eventLogErrorVwDataGridView
            // 
            this.eventLogErrorVwDataGridView.AutoGenerateColumns = false;
            this.eventLogErrorVwDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventLogErrorVwDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnEventLogId,
            this.dataGridViewTextBoxColumnEventLogEventSourceId,
            this.dataGridViewTextBoxColumnEventLogEventSourceName,
            this.dataGridViewTextBoxColumnEventLogEventCategoryId,
            this.dataGridViewTextBoxColumnEventLogEventCategoryName,
            this.dataGridViewTextBoxColumnEventLogEventStatusId,
            this.dataGridViewTextBoxColumnEventLogEventStatusName,
            this.dataGridViewTextBoxColumnEventLogEventStatusIcon,
            this.dataGridViewTextBoxColumnEventLogParameters,
            this.dataGridViewTextBoxColumnEventLogDate,
            this.dataGridViewTextBoxColumnEventLogUser,
            this.dataGridViewTextBoxColumnNumber,
            this.dataGridViewTextBoxColumnMessage,
            this.dataGridViewTextBoxColumnStackTrace});
            this.eventLogErrorVwDataGridView.DataSource = this.eventLogErrorVwBindingSource;
            this.eventLogErrorVwDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventLogErrorVwDataGridView.Location = new System.Drawing.Point(0, 25);
            this.eventLogErrorVwDataGridView.Name = "eventLogErrorVwDataGridView";
            this.eventLogErrorVwDataGridView.Size = new System.Drawing.Size(598, 346);
            this.eventLogErrorVwDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumnEventLogId
            // 
            this.dataGridViewTextBoxColumnEventLogId.DataPropertyName = "EventLogId";
            this.dataGridViewTextBoxColumnEventLogId.HeaderText = "EventLogId";
            this.dataGridViewTextBoxColumnEventLogId.Name = "dataGridViewTextBoxColumnEventLogId";
            // 
            // dataGridViewTextBoxColumnEventLogEventSourceId
            // 
            this.dataGridViewTextBoxColumnEventLogEventSourceId.DataPropertyName = "EventLogEventSourceId";
            this.dataGridViewTextBoxColumnEventLogEventSourceId.HeaderText = "EventLogEventSourceId";
            this.dataGridViewTextBoxColumnEventLogEventSourceId.Name = "dataGridViewTextBoxColumnEventLogEventSourceId";
            // 
            // dataGridViewTextBoxColumnEventLogEventSourceName
            // 
            this.dataGridViewTextBoxColumnEventLogEventSourceName.DataPropertyName = "EventLogEventSourceName";
            this.dataGridViewTextBoxColumnEventLogEventSourceName.HeaderText = "EventLogEventSourceName";
            this.dataGridViewTextBoxColumnEventLogEventSourceName.Name = "dataGridViewTextBoxColumnEventLogEventSourceName";
            // 
            // dataGridViewTextBoxColumnEventLogEventCategoryId
            // 
            this.dataGridViewTextBoxColumnEventLogEventCategoryId.DataPropertyName = "EventLogEventCategoryId";
            this.dataGridViewTextBoxColumnEventLogEventCategoryId.HeaderText = "EventLogEventCategoryId";
            this.dataGridViewTextBoxColumnEventLogEventCategoryId.Name = "dataGridViewTextBoxColumnEventLogEventCategoryId";
            // 
            // dataGridViewTextBoxColumnEventLogEventCategoryName
            // 
            this.dataGridViewTextBoxColumnEventLogEventCategoryName.DataPropertyName = "EventLogEventCategoryName";
            this.dataGridViewTextBoxColumnEventLogEventCategoryName.HeaderText = "EventLogEventCategoryName";
            this.dataGridViewTextBoxColumnEventLogEventCategoryName.Name = "dataGridViewTextBoxColumnEventLogEventCategoryName";
            // 
            // dataGridViewTextBoxColumnEventLogEventStatusId
            // 
            this.dataGridViewTextBoxColumnEventLogEventStatusId.DataPropertyName = "EventLogEventStatusId";
            this.dataGridViewTextBoxColumnEventLogEventStatusId.HeaderText = "EventLogEventStatusId";
            this.dataGridViewTextBoxColumnEventLogEventStatusId.Name = "dataGridViewTextBoxColumnEventLogEventStatusId";
            // 
            // dataGridViewTextBoxColumnEventLogEventStatusName
            // 
            this.dataGridViewTextBoxColumnEventLogEventStatusName.DataPropertyName = "EventLogEventStatusName";
            this.dataGridViewTextBoxColumnEventLogEventStatusName.HeaderText = "EventLogEventStatusName";
            this.dataGridViewTextBoxColumnEventLogEventStatusName.Name = "dataGridViewTextBoxColumnEventLogEventStatusName";
            // 
            // dataGridViewTextBoxColumnEventLogEventStatusIcon
            // 
            this.dataGridViewTextBoxColumnEventLogEventStatusIcon.DataPropertyName = "EventLogEventStatusIcon";
            this.dataGridViewTextBoxColumnEventLogEventStatusIcon.HeaderText = "EventLogEventStatusIcon";
            this.dataGridViewTextBoxColumnEventLogEventStatusIcon.Name = "dataGridViewTextBoxColumnEventLogEventStatusIcon";
            // 
            // dataGridViewTextBoxColumnEventLogParameters
            // 
            this.dataGridViewTextBoxColumnEventLogParameters.DataPropertyName = "EventLogParameters";
            this.dataGridViewTextBoxColumnEventLogParameters.HeaderText = "EventLogParameters";
            this.dataGridViewTextBoxColumnEventLogParameters.Name = "dataGridViewTextBoxColumnEventLogParameters";
            // 
            // dataGridViewTextBoxColumnEventLogDate
            // 
            this.dataGridViewTextBoxColumnEventLogDate.DataPropertyName = "EventLogDate";
            this.dataGridViewTextBoxColumnEventLogDate.HeaderText = "EventLogDate";
            this.dataGridViewTextBoxColumnEventLogDate.Name = "dataGridViewTextBoxColumnEventLogDate";
            // 
            // dataGridViewTextBoxColumnEventLogUser
            // 
            this.dataGridViewTextBoxColumnEventLogUser.DataPropertyName = "EventLogUser";
            this.dataGridViewTextBoxColumnEventLogUser.HeaderText = "EventLogUser";
            this.dataGridViewTextBoxColumnEventLogUser.Name = "dataGridViewTextBoxColumnEventLogUser";
            // 
            // dataGridViewTextBoxColumnNumber
            // 
            this.dataGridViewTextBoxColumnNumber.DataPropertyName = "Number";
            this.dataGridViewTextBoxColumnNumber.HeaderText = "Number";
            this.dataGridViewTextBoxColumnNumber.Name = "dataGridViewTextBoxColumnNumber";
            // 
            // dataGridViewTextBoxColumnMessage
            // 
            this.dataGridViewTextBoxColumnMessage.DataPropertyName = "Message";
            this.dataGridViewTextBoxColumnMessage.HeaderText = "Message";
            this.dataGridViewTextBoxColumnMessage.Name = "dataGridViewTextBoxColumnMessage";
            // 
            // dataGridViewTextBoxColumnStackTrace
            // 
            this.dataGridViewTextBoxColumnStackTrace.DataPropertyName = "StackTrace";
            this.dataGridViewTextBoxColumnStackTrace.HeaderText = "StackTrace";
            this.dataGridViewTextBoxColumnStackTrace.Name = "dataGridViewTextBoxColumnStackTrace";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slblEllapsedTimeName,
            this.slblEllapsedTimeValue});
			this.statusStrip1.Location = new System.Drawing.Point(0, 349);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(598, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// slblEllapsedTimeName
			// 
			this.slblEllapsedTimeName.Name = "slblEllapsedTimeName";
			this.slblEllapsedTimeName.Size = new System.Drawing.Size(80, 17);
			this.slblEllapsedTimeName.Text = "Ellapsed time:";
			// 
			// slblEllapsedTimeValue
			// 
			this.slblEllapsedTimeValue.Name = "slblEllapsedTimeValue";
			this.slblEllapsedTimeValue.Size = new System.Drawing.Size(0, 17);
            // 
            // FormEventLogErrorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 371);
			this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.eventLogErrorVwDataGridView);
            this.Controls.Add(this.eventLogErrorVwBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEventLogErrorView";
            this.Text = "View eventLogErrors";
            this.Load += new System.EventHandler(this.FormEventLogErrorView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLogErrorVwBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLogErrorVwBindingNavigator)).EndInit();
            this.eventLogErrorVwBindingNavigator.ResumeLayout(false);
            this.eventLogErrorVwBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLogErrorVwDataGridView)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource eventLogErrorVwBindingSource;
        private System.Windows.Forms.BindingNavigator eventLogErrorVwBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView eventLogErrorVwDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEventLogId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEventLogEventSourceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEventLogEventSourceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEventLogEventCategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEventLogEventCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEventLogEventStatusId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEventLogEventStatusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEventLogEventStatusIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEventLogParameters;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEventLogDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEventLogUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnStackTrace;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel slblEllapsedTimeName;
		private System.Windows.Forms.ToolStripStatusLabel slblEllapsedTimeValue;
    }
}
