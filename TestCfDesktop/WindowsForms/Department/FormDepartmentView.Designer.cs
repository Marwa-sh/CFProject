namespace Cf
{
    partial class FormDepartmentView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDepartmentView));
            this.departmentVwBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentVwBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.departmentVwDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnSalaryWorkPlaceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnSalaryWorkPlaceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnSalaryWorkPlaceMainWorkPlaceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnSalaryWorkPlaceMainWorkPlaceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.slblEllapsedTimeName = new System.Windows.Forms.ToolStripStatusLabel();
			this.slblEllapsedTimeValue = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.departmentVwBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentVwBindingNavigator)).BeginInit();
            this.departmentVwBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentVwDataGridView)).BeginInit();
			this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // departmentVwBindingSource
            // 
            this.departmentVwBindingSource.DataSource = typeof(Cf.Data.DepartmentVw);
            // 
            // departmentVwBindingNavigator
            // 
            this.departmentVwBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.departmentVwBindingNavigator.AllowItemReorder = true;
            this.departmentVwBindingNavigator.BindingSource = this.departmentVwBindingSource;
            this.departmentVwBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.departmentVwBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.departmentVwBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.departmentVwBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.departmentVwBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.departmentVwBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.departmentVwBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.departmentVwBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.departmentVwBindingNavigator.Name = "departmentVwBindingNavigator";
            this.departmentVwBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.departmentVwBindingNavigator.Size = new System.Drawing.Size(598, 25);
            this.departmentVwBindingNavigator.TabIndex = 0;
            this.departmentVwBindingNavigator.Text = "bindingNavigator1";
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
            // departmentVwDataGridView
            // 
            this.departmentVwDataGridView.AutoGenerateColumns = false;
            this.departmentVwDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departmentVwDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnId,
            this.dataGridViewTextBoxColumnName,
            this.dataGridViewTextBoxColumnSalaryWorkPlaceId,
            this.dataGridViewTextBoxColumnSalaryWorkPlaceName,
            this.dataGridViewTextBoxColumnSalaryWorkPlaceMainWorkPlaceId,
            this.dataGridViewTextBoxColumnSalaryWorkPlaceMainWorkPlaceName});
            this.departmentVwDataGridView.DataSource = this.departmentVwBindingSource;
            this.departmentVwDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.departmentVwDataGridView.Location = new System.Drawing.Point(0, 25);
            this.departmentVwDataGridView.Name = "departmentVwDataGridView";
            this.departmentVwDataGridView.Size = new System.Drawing.Size(598, 346);
            this.departmentVwDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumnId
            // 
            this.dataGridViewTextBoxColumnId.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumnId.HeaderText = "Id";
            this.dataGridViewTextBoxColumnId.Name = "dataGridViewTextBoxColumnId";
            // 
            // dataGridViewTextBoxColumnName
            // 
            this.dataGridViewTextBoxColumnName.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumnName.HeaderText = "Name";
            this.dataGridViewTextBoxColumnName.Name = "dataGridViewTextBoxColumnName";
            // 
            // dataGridViewTextBoxColumnSalaryWorkPlaceId
            // 
            this.dataGridViewTextBoxColumnSalaryWorkPlaceId.DataPropertyName = "SalaryWorkPlaceId";
            this.dataGridViewTextBoxColumnSalaryWorkPlaceId.HeaderText = "SalaryWorkPlaceId";
            this.dataGridViewTextBoxColumnSalaryWorkPlaceId.Name = "dataGridViewTextBoxColumnSalaryWorkPlaceId";
            // 
            // dataGridViewTextBoxColumnSalaryWorkPlaceName
            // 
            this.dataGridViewTextBoxColumnSalaryWorkPlaceName.DataPropertyName = "SalaryWorkPlaceName";
            this.dataGridViewTextBoxColumnSalaryWorkPlaceName.HeaderText = "SalaryWorkPlaceName";
            this.dataGridViewTextBoxColumnSalaryWorkPlaceName.Name = "dataGridViewTextBoxColumnSalaryWorkPlaceName";
            // 
            // dataGridViewTextBoxColumnSalaryWorkPlaceMainWorkPlaceId
            // 
            this.dataGridViewTextBoxColumnSalaryWorkPlaceMainWorkPlaceId.DataPropertyName = "SalaryWorkPlaceMainWorkPlaceId";
            this.dataGridViewTextBoxColumnSalaryWorkPlaceMainWorkPlaceId.HeaderText = "SalaryWorkPlaceMainWorkPlaceId";
            this.dataGridViewTextBoxColumnSalaryWorkPlaceMainWorkPlaceId.Name = "dataGridViewTextBoxColumnSalaryWorkPlaceMainWorkPlaceId";
            // 
            // dataGridViewTextBoxColumnSalaryWorkPlaceMainWorkPlaceName
            // 
            this.dataGridViewTextBoxColumnSalaryWorkPlaceMainWorkPlaceName.DataPropertyName = "SalaryWorkPlaceMainWorkPlaceName";
            this.dataGridViewTextBoxColumnSalaryWorkPlaceMainWorkPlaceName.HeaderText = "SalaryWorkPlaceMainWorkPlaceName";
            this.dataGridViewTextBoxColumnSalaryWorkPlaceMainWorkPlaceName.Name = "dataGridViewTextBoxColumnSalaryWorkPlaceMainWorkPlaceName";
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
            // FormDepartmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 371);
			this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.departmentVwDataGridView);
            this.Controls.Add(this.departmentVwBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDepartmentView";
            this.Text = "View departments";
            this.Load += new System.EventHandler(this.FormDepartmentView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departmentVwBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentVwBindingNavigator)).EndInit();
            this.departmentVwBindingNavigator.ResumeLayout(false);
            this.departmentVwBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentVwDataGridView)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource departmentVwBindingSource;
        private System.Windows.Forms.BindingNavigator departmentVwBindingNavigator;
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
        private System.Windows.Forms.DataGridView departmentVwDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnSalaryWorkPlaceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnSalaryWorkPlaceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnSalaryWorkPlaceMainWorkPlaceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnSalaryWorkPlaceMainWorkPlaceName;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel slblEllapsedTimeName;
		private System.Windows.Forms.ToolStripStatusLabel slblEllapsedTimeValue;
    }
}
