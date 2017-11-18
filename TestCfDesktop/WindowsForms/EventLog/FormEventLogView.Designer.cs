namespace Cf
{
    partial class FormEventLogView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEventLogView));
            this.eventLogVwBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventLogVwBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.eventLogVwDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEventSourceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEventSourceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEventCategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEventCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEventStatusId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEventStatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEventStatusIcon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnParameters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.slblEllapsedTimeName = new System.Windows.Forms.ToolStripStatusLabel();
			this.slblEllapsedTimeValue = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.eventLogVwBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLogVwBindingNavigator)).BeginInit();
            this.eventLogVwBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLogVwDataGridView)).BeginInit();
			this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventLogVwBindingSource
            // 
            this.eventLogVwBindingSource.DataSource = typeof(Cf.Data.EventLogVw);
            // 
            // eventLogVwBindingNavigator
            // 
            this.eventLogVwBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.eventLogVwBindingNavigator.AllowItemReorder = true;
            this.eventLogVwBindingNavigator.BindingSource = this.eventLogVwBindingSource;
            this.eventLogVwBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.eventLogVwBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.eventLogVwBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.eventLogVwBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.eventLogVwBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.eventLogVwBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.eventLogVwBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.eventLogVwBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.eventLogVwBindingNavigator.Name = "eventLogVwBindingNavigator";
            this.eventLogVwBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.eventLogVwBindingNavigator.Size = new System.Drawing.Size(598, 25);
            this.eventLogVwBindingNavigator.TabIndex = 0;
            this.eventLogVwBindingNavigator.Text = "bindingNavigator1";
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
            // eventLogVwDataGridView
            // 
            this.eventLogVwDataGridView.AutoGenerateColumns = false;
            this.eventLogVwDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eventLogVwDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnId,
            this.dataGridViewTextBoxColumnEventSourceId,
            this.dataGridViewTextBoxColumnEventSourceName,
            this.dataGridViewTextBoxColumnEventCategoryId,
            this.dataGridViewTextBoxColumnEventCategoryName,
            this.dataGridViewTextBoxColumnEventStatusId,
            this.dataGridViewTextBoxColumnEventStatusName,
            this.dataGridViewTextBoxColumnEventStatusIcon,
            this.dataGridViewTextBoxColumnParameters,
            this.dataGridViewTextBoxColumnDate,
            this.dataGridViewTextBoxColumnUser});
            this.eventLogVwDataGridView.DataSource = this.eventLogVwBindingSource;
            this.eventLogVwDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventLogVwDataGridView.Location = new System.Drawing.Point(0, 25);
            this.eventLogVwDataGridView.Name = "eventLogVwDataGridView";
            this.eventLogVwDataGridView.Size = new System.Drawing.Size(598, 346);
            this.eventLogVwDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumnId
            // 
            this.dataGridViewTextBoxColumnId.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumnId.HeaderText = "Id";
            this.dataGridViewTextBoxColumnId.Name = "dataGridViewTextBoxColumnId";
            // 
            // dataGridViewTextBoxColumnEventSourceId
            // 
            this.dataGridViewTextBoxColumnEventSourceId.DataPropertyName = "EventSourceId";
            this.dataGridViewTextBoxColumnEventSourceId.HeaderText = "EventSourceId";
            this.dataGridViewTextBoxColumnEventSourceId.Name = "dataGridViewTextBoxColumnEventSourceId";
            // 
            // dataGridViewTextBoxColumnEventSourceName
            // 
            this.dataGridViewTextBoxColumnEventSourceName.DataPropertyName = "EventSourceName";
            this.dataGridViewTextBoxColumnEventSourceName.HeaderText = "EventSourceName";
            this.dataGridViewTextBoxColumnEventSourceName.Name = "dataGridViewTextBoxColumnEventSourceName";
            // 
            // dataGridViewTextBoxColumnEventCategoryId
            // 
            this.dataGridViewTextBoxColumnEventCategoryId.DataPropertyName = "EventCategoryId";
            this.dataGridViewTextBoxColumnEventCategoryId.HeaderText = "EventCategoryId";
            this.dataGridViewTextBoxColumnEventCategoryId.Name = "dataGridViewTextBoxColumnEventCategoryId";
            // 
            // dataGridViewTextBoxColumnEventCategoryName
            // 
            this.dataGridViewTextBoxColumnEventCategoryName.DataPropertyName = "EventCategoryName";
            this.dataGridViewTextBoxColumnEventCategoryName.HeaderText = "EventCategoryName";
            this.dataGridViewTextBoxColumnEventCategoryName.Name = "dataGridViewTextBoxColumnEventCategoryName";
            // 
            // dataGridViewTextBoxColumnEventStatusId
            // 
            this.dataGridViewTextBoxColumnEventStatusId.DataPropertyName = "EventStatusId";
            this.dataGridViewTextBoxColumnEventStatusId.HeaderText = "EventStatusId";
            this.dataGridViewTextBoxColumnEventStatusId.Name = "dataGridViewTextBoxColumnEventStatusId";
            // 
            // dataGridViewTextBoxColumnEventStatusName
            // 
            this.dataGridViewTextBoxColumnEventStatusName.DataPropertyName = "EventStatusName";
            this.dataGridViewTextBoxColumnEventStatusName.HeaderText = "EventStatusName";
            this.dataGridViewTextBoxColumnEventStatusName.Name = "dataGridViewTextBoxColumnEventStatusName";
            // 
            // dataGridViewTextBoxColumnEventStatusIcon
            // 
            this.dataGridViewTextBoxColumnEventStatusIcon.DataPropertyName = "EventStatusIcon";
            this.dataGridViewTextBoxColumnEventStatusIcon.HeaderText = "EventStatusIcon";
            this.dataGridViewTextBoxColumnEventStatusIcon.Name = "dataGridViewTextBoxColumnEventStatusIcon";
            // 
            // dataGridViewTextBoxColumnParameters
            // 
            this.dataGridViewTextBoxColumnParameters.DataPropertyName = "Parameters";
            this.dataGridViewTextBoxColumnParameters.HeaderText = "Parameters";
            this.dataGridViewTextBoxColumnParameters.Name = "dataGridViewTextBoxColumnParameters";
            // 
            // dataGridViewTextBoxColumnDate
            // 
            this.dataGridViewTextBoxColumnDate.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumnDate.HeaderText = "Date";
            this.dataGridViewTextBoxColumnDate.Name = "dataGridViewTextBoxColumnDate";
            // 
            // dataGridViewTextBoxColumnUser
            // 
            this.dataGridViewTextBoxColumnUser.DataPropertyName = "User";
            this.dataGridViewTextBoxColumnUser.HeaderText = "User";
            this.dataGridViewTextBoxColumnUser.Name = "dataGridViewTextBoxColumnUser";
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
            // FormEventLogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 371);
			this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.eventLogVwDataGridView);
            this.Controls.Add(this.eventLogVwBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEventLogView";
            this.Text = "View eventLogs";
            this.Load += new System.EventHandler(this.FormEventLogView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLogVwBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLogVwBindingNavigator)).EndInit();
            this.eventLogVwBindingNavigator.ResumeLayout(false);
            this.eventLogVwBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLogVwDataGridView)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource eventLogVwBindingSource;
        private System.Windows.Forms.BindingNavigator eventLogVwBindingNavigator;
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
        private System.Windows.Forms.DataGridView eventLogVwDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEventSourceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEventSourceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEventCategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEventCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEventStatusId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEventStatusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEventStatusIcon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnParameters;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnUser;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel slblEllapsedTimeName;
		private System.Windows.Forms.ToolStripStatusLabel slblEllapsedTimeValue;
    }
}
