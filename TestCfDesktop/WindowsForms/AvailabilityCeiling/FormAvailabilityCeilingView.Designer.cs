namespace Cf
{
    partial class FormAvailabilityCeilingView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAvailabilityCeilingView));
            this.availabilityCeilingVwBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.availabilityCeilingVwBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.availabilityCeilingVwDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnAvailabilityId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnAvailabilityName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnAvailabilityMinSeniority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnAvailabilityMinReusePeriod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnFromYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnMaxAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.slblEllapsedTimeName = new System.Windows.Forms.ToolStripStatusLabel();
			this.slblEllapsedTimeValue = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.availabilityCeilingVwBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availabilityCeilingVwBindingNavigator)).BeginInit();
            this.availabilityCeilingVwBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availabilityCeilingVwDataGridView)).BeginInit();
			this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // availabilityCeilingVwBindingSource
            // 
            this.availabilityCeilingVwBindingSource.DataSource = typeof(Cf.Data.AvailabilityCeilingVw);
            // 
            // availabilityCeilingVwBindingNavigator
            // 
            this.availabilityCeilingVwBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.availabilityCeilingVwBindingNavigator.AllowItemReorder = true;
            this.availabilityCeilingVwBindingNavigator.BindingSource = this.availabilityCeilingVwBindingSource;
            this.availabilityCeilingVwBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.availabilityCeilingVwBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.availabilityCeilingVwBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.availabilityCeilingVwBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.availabilityCeilingVwBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.availabilityCeilingVwBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.availabilityCeilingVwBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.availabilityCeilingVwBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.availabilityCeilingVwBindingNavigator.Name = "availabilityCeilingVwBindingNavigator";
            this.availabilityCeilingVwBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.availabilityCeilingVwBindingNavigator.Size = new System.Drawing.Size(598, 25);
            this.availabilityCeilingVwBindingNavigator.TabIndex = 0;
            this.availabilityCeilingVwBindingNavigator.Text = "bindingNavigator1";
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
            // availabilityCeilingVwDataGridView
            // 
            this.availabilityCeilingVwDataGridView.AutoGenerateColumns = false;
            this.availabilityCeilingVwDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availabilityCeilingVwDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnId,
            this.dataGridViewTextBoxColumnAvailabilityId,
            this.dataGridViewTextBoxColumnAvailabilityName,
            this.dataGridViewTextBoxColumnAvailabilityMinSeniority,
            this.dataGridViewTextBoxColumnAvailabilityMinReusePeriod,
            this.dataGridViewTextBoxColumnFromYear,
            this.dataGridViewTextBoxColumnMaxAmount});
            this.availabilityCeilingVwDataGridView.DataSource = this.availabilityCeilingVwBindingSource;
            this.availabilityCeilingVwDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.availabilityCeilingVwDataGridView.Location = new System.Drawing.Point(0, 25);
            this.availabilityCeilingVwDataGridView.Name = "availabilityCeilingVwDataGridView";
            this.availabilityCeilingVwDataGridView.Size = new System.Drawing.Size(598, 346);
            this.availabilityCeilingVwDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumnId
            // 
            this.dataGridViewTextBoxColumnId.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumnId.HeaderText = "Id";
            this.dataGridViewTextBoxColumnId.Name = "dataGridViewTextBoxColumnId";
            // 
            // dataGridViewTextBoxColumnAvailabilityId
            // 
            this.dataGridViewTextBoxColumnAvailabilityId.DataPropertyName = "AvailabilityId";
            this.dataGridViewTextBoxColumnAvailabilityId.HeaderText = "AvailabilityId";
            this.dataGridViewTextBoxColumnAvailabilityId.Name = "dataGridViewTextBoxColumnAvailabilityId";
            // 
            // dataGridViewTextBoxColumnAvailabilityName
            // 
            this.dataGridViewTextBoxColumnAvailabilityName.DataPropertyName = "AvailabilityName";
            this.dataGridViewTextBoxColumnAvailabilityName.HeaderText = "AvailabilityName";
            this.dataGridViewTextBoxColumnAvailabilityName.Name = "dataGridViewTextBoxColumnAvailabilityName";
            // 
            // dataGridViewTextBoxColumnAvailabilityMinSeniority
            // 
            this.dataGridViewTextBoxColumnAvailabilityMinSeniority.DataPropertyName = "AvailabilityMinSeniority";
            this.dataGridViewTextBoxColumnAvailabilityMinSeniority.HeaderText = "AvailabilityMinSeniority";
            this.dataGridViewTextBoxColumnAvailabilityMinSeniority.Name = "dataGridViewTextBoxColumnAvailabilityMinSeniority";
            // 
            // dataGridViewTextBoxColumnAvailabilityMinReusePeriod
            // 
            this.dataGridViewTextBoxColumnAvailabilityMinReusePeriod.DataPropertyName = "AvailabilityMinReusePeriod";
            this.dataGridViewTextBoxColumnAvailabilityMinReusePeriod.HeaderText = "AvailabilityMinReusePeriod";
            this.dataGridViewTextBoxColumnAvailabilityMinReusePeriod.Name = "dataGridViewTextBoxColumnAvailabilityMinReusePeriod";
            // 
            // dataGridViewTextBoxColumnFromYear
            // 
            this.dataGridViewTextBoxColumnFromYear.DataPropertyName = "FromYear";
            this.dataGridViewTextBoxColumnFromYear.HeaderText = "FromYear";
            this.dataGridViewTextBoxColumnFromYear.Name = "dataGridViewTextBoxColumnFromYear";
            // 
            // dataGridViewTextBoxColumnMaxAmount
            // 
            this.dataGridViewTextBoxColumnMaxAmount.DataPropertyName = "MaxAmount";
            this.dataGridViewTextBoxColumnMaxAmount.HeaderText = "MaxAmount";
            this.dataGridViewTextBoxColumnMaxAmount.Name = "dataGridViewTextBoxColumnMaxAmount";
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
            // FormAvailabilityCeilingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 371);
			this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.availabilityCeilingVwDataGridView);
            this.Controls.Add(this.availabilityCeilingVwBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAvailabilityCeilingView";
            this.Text = "View availabilityCeilings";
            this.Load += new System.EventHandler(this.FormAvailabilityCeilingView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.availabilityCeilingVwBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.availabilityCeilingVwBindingNavigator)).EndInit();
            this.availabilityCeilingVwBindingNavigator.ResumeLayout(false);
            this.availabilityCeilingVwBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availabilityCeilingVwDataGridView)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource availabilityCeilingVwBindingSource;
        private System.Windows.Forms.BindingNavigator availabilityCeilingVwBindingNavigator;
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
        private System.Windows.Forms.DataGridView availabilityCeilingVwDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnAvailabilityId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnAvailabilityName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnAvailabilityMinSeniority;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnAvailabilityMinReusePeriod;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnFromYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnMaxAmount;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel slblEllapsedTimeName;
		private System.Windows.Forms.ToolStripStatusLabel slblEllapsedTimeValue;
    }
}
