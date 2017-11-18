namespace Cf
{
    partial class FormEmployeeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployeeView));
            this.employeeVwBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeVwBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.employeeVwDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnFatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnFullName3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnMotherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnExpectedEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnCersStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnCfStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnLeaveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnLeaveReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEmployeeStatusId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEmployeeStatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEmployeeStatusIsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnDepartmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnDepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnDepartmentSalaryWorkPlaceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnDepartmentSalaryWorkPlaceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnDepartmentSalaryWorkPlaceMainWorkPlaceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnDepartmentSalaryWorkPlaceMainWorkPlaceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnCategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.slblEllapsedTimeName = new System.Windows.Forms.ToolStripStatusLabel();
			this.slblEllapsedTimeValue = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.employeeVwBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeVwBindingNavigator)).BeginInit();
            this.employeeVwBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeVwDataGridView)).BeginInit();
			this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeVwBindingSource
            // 
            this.employeeVwBindingSource.DataSource = typeof(Cf.Data.EmployeeVw);
            // 
            // employeeVwBindingNavigator
            // 
            this.employeeVwBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.employeeVwBindingNavigator.AllowItemReorder = true;
            this.employeeVwBindingNavigator.BindingSource = this.employeeVwBindingSource;
            this.employeeVwBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.employeeVwBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.employeeVwBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.employeeVwBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.employeeVwBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.employeeVwBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.employeeVwBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.employeeVwBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.employeeVwBindingNavigator.Name = "employeeVwBindingNavigator";
            this.employeeVwBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.employeeVwBindingNavigator.Size = new System.Drawing.Size(598, 25);
            this.employeeVwBindingNavigator.TabIndex = 0;
            this.employeeVwBindingNavigator.Text = "bindingNavigator1";
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
            // employeeVwDataGridView
            // 
            this.employeeVwDataGridView.AutoGenerateColumns = false;
            this.employeeVwDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeVwDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnId,
            this.dataGridViewTextBoxColumnFirstName,
            this.dataGridViewTextBoxColumnLastName,
            this.dataGridViewTextBoxColumnFullName,
            this.dataGridViewTextBoxColumnFatherName,
            this.dataGridViewTextBoxColumnFullName3,
            this.dataGridViewTextBoxColumnMotherName,
            this.dataGridViewTextBoxColumnBirthDate,
            this.dataGridViewTextBoxColumnExpectedEndDate,
            this.dataGridViewTextBoxColumnCersStartDate,
            this.dataGridViewTextBoxColumnCfStartDate,
            this.dataGridViewTextBoxColumnLeaveDate,
            this.dataGridViewTextBoxColumnLeaveReason,
            this.dataGridViewTextBoxColumnEmployeeStatusId,
            this.dataGridViewTextBoxColumnEmployeeStatusName,
            this.dataGridViewTextBoxColumnEmployeeStatusIsActive,
            this.dataGridViewTextBoxColumnDepartmentId,
            this.dataGridViewTextBoxColumnDepartmentName,
            this.dataGridViewTextBoxColumnDepartmentSalaryWorkPlaceId,
            this.dataGridViewTextBoxColumnDepartmentSalaryWorkPlaceName,
            this.dataGridViewTextBoxColumnDepartmentSalaryWorkPlaceMainWorkPlaceId,
            this.dataGridViewTextBoxColumnDepartmentSalaryWorkPlaceMainWorkPlaceName,
            this.dataGridViewTextBoxColumnNotes,
            this.dataGridViewTextBoxColumnCategoryId,
            this.dataGridViewTextBoxColumnCategoryName});
            this.employeeVwDataGridView.DataSource = this.employeeVwBindingSource;
            this.employeeVwDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.employeeVwDataGridView.Location = new System.Drawing.Point(0, 25);
            this.employeeVwDataGridView.Name = "employeeVwDataGridView";
            this.employeeVwDataGridView.Size = new System.Drawing.Size(598, 346);
            this.employeeVwDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumnId
            // 
            this.dataGridViewTextBoxColumnId.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumnId.HeaderText = "Id";
            this.dataGridViewTextBoxColumnId.Name = "dataGridViewTextBoxColumnId";
            // 
            // dataGridViewTextBoxColumnFirstName
            // 
            this.dataGridViewTextBoxColumnFirstName.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumnFirstName.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumnFirstName.Name = "dataGridViewTextBoxColumnFirstName";
            // 
            // dataGridViewTextBoxColumnLastName
            // 
            this.dataGridViewTextBoxColumnLastName.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumnLastName.HeaderText = "LastName";
            this.dataGridViewTextBoxColumnLastName.Name = "dataGridViewTextBoxColumnLastName";
            // 
            // dataGridViewTextBoxColumnFullName
            // 
            this.dataGridViewTextBoxColumnFullName.DataPropertyName = "FullName";
            this.dataGridViewTextBoxColumnFullName.HeaderText = "FullName";
            this.dataGridViewTextBoxColumnFullName.Name = "dataGridViewTextBoxColumnFullName";
            // 
            // dataGridViewTextBoxColumnFatherName
            // 
            this.dataGridViewTextBoxColumnFatherName.DataPropertyName = "FatherName";
            this.dataGridViewTextBoxColumnFatherName.HeaderText = "FatherName";
            this.dataGridViewTextBoxColumnFatherName.Name = "dataGridViewTextBoxColumnFatherName";
            // 
            // dataGridViewTextBoxColumnFullName3
            // 
            this.dataGridViewTextBoxColumnFullName3.DataPropertyName = "FullName3";
            this.dataGridViewTextBoxColumnFullName3.HeaderText = "FullName3";
            this.dataGridViewTextBoxColumnFullName3.Name = "dataGridViewTextBoxColumnFullName3";
            // 
            // dataGridViewTextBoxColumnMotherName
            // 
            this.dataGridViewTextBoxColumnMotherName.DataPropertyName = "MotherName";
            this.dataGridViewTextBoxColumnMotherName.HeaderText = "MotherName";
            this.dataGridViewTextBoxColumnMotherName.Name = "dataGridViewTextBoxColumnMotherName";
            // 
            // dataGridViewTextBoxColumnBirthDate
            // 
            this.dataGridViewTextBoxColumnBirthDate.DataPropertyName = "BirthDate";
            this.dataGridViewTextBoxColumnBirthDate.HeaderText = "BirthDate";
            this.dataGridViewTextBoxColumnBirthDate.Name = "dataGridViewTextBoxColumnBirthDate";
            // 
            // dataGridViewTextBoxColumnExpectedEndDate
            // 
            this.dataGridViewTextBoxColumnExpectedEndDate.DataPropertyName = "ExpectedEndDate";
            this.dataGridViewTextBoxColumnExpectedEndDate.HeaderText = "ExpectedEndDate";
            this.dataGridViewTextBoxColumnExpectedEndDate.Name = "dataGridViewTextBoxColumnExpectedEndDate";
            // 
            // dataGridViewTextBoxColumnCersStartDate
            // 
            this.dataGridViewTextBoxColumnCersStartDate.DataPropertyName = "CersStartDate";
            this.dataGridViewTextBoxColumnCersStartDate.HeaderText = "CersStartDate";
            this.dataGridViewTextBoxColumnCersStartDate.Name = "dataGridViewTextBoxColumnCersStartDate";
            // 
            // dataGridViewTextBoxColumnCfStartDate
            // 
            this.dataGridViewTextBoxColumnCfStartDate.DataPropertyName = "CfStartDate";
            this.dataGridViewTextBoxColumnCfStartDate.HeaderText = "CfStartDate";
            this.dataGridViewTextBoxColumnCfStartDate.Name = "dataGridViewTextBoxColumnCfStartDate";
            // 
            // dataGridViewTextBoxColumnLeaveDate
            // 
            this.dataGridViewTextBoxColumnLeaveDate.DataPropertyName = "LeaveDate";
            this.dataGridViewTextBoxColumnLeaveDate.HeaderText = "LeaveDate";
            this.dataGridViewTextBoxColumnLeaveDate.Name = "dataGridViewTextBoxColumnLeaveDate";
            // 
            // dataGridViewTextBoxColumnLeaveReason
            // 
            this.dataGridViewTextBoxColumnLeaveReason.DataPropertyName = "LeaveReason";
            this.dataGridViewTextBoxColumnLeaveReason.HeaderText = "LeaveReason";
            this.dataGridViewTextBoxColumnLeaveReason.Name = "dataGridViewTextBoxColumnLeaveReason";
            // 
            // dataGridViewTextBoxColumnEmployeeStatusId
            // 
            this.dataGridViewTextBoxColumnEmployeeStatusId.DataPropertyName = "EmployeeStatusId";
            this.dataGridViewTextBoxColumnEmployeeStatusId.HeaderText = "EmployeeStatusId";
            this.dataGridViewTextBoxColumnEmployeeStatusId.Name = "dataGridViewTextBoxColumnEmployeeStatusId";
            // 
            // dataGridViewTextBoxColumnEmployeeStatusName
            // 
            this.dataGridViewTextBoxColumnEmployeeStatusName.DataPropertyName = "EmployeeStatusName";
            this.dataGridViewTextBoxColumnEmployeeStatusName.HeaderText = "EmployeeStatusName";
            this.dataGridViewTextBoxColumnEmployeeStatusName.Name = "dataGridViewTextBoxColumnEmployeeStatusName";
            // 
            // dataGridViewTextBoxColumnEmployeeStatusIsActive
            // 
            this.dataGridViewTextBoxColumnEmployeeStatusIsActive.DataPropertyName = "EmployeeStatusIsActive";
            this.dataGridViewTextBoxColumnEmployeeStatusIsActive.HeaderText = "EmployeeStatusIsActive";
            this.dataGridViewTextBoxColumnEmployeeStatusIsActive.Name = "dataGridViewTextBoxColumnEmployeeStatusIsActive";
            // 
            // dataGridViewTextBoxColumnDepartmentId
            // 
            this.dataGridViewTextBoxColumnDepartmentId.DataPropertyName = "DepartmentId";
            this.dataGridViewTextBoxColumnDepartmentId.HeaderText = "DepartmentId";
            this.dataGridViewTextBoxColumnDepartmentId.Name = "dataGridViewTextBoxColumnDepartmentId";
            // 
            // dataGridViewTextBoxColumnDepartmentName
            // 
            this.dataGridViewTextBoxColumnDepartmentName.DataPropertyName = "DepartmentName";
            this.dataGridViewTextBoxColumnDepartmentName.HeaderText = "DepartmentName";
            this.dataGridViewTextBoxColumnDepartmentName.Name = "dataGridViewTextBoxColumnDepartmentName";
            // 
            // dataGridViewTextBoxColumnDepartmentSalaryWorkPlaceId
            // 
            this.dataGridViewTextBoxColumnDepartmentSalaryWorkPlaceId.DataPropertyName = "DepartmentSalaryWorkPlaceId";
            this.dataGridViewTextBoxColumnDepartmentSalaryWorkPlaceId.HeaderText = "DepartmentSalaryWorkPlaceId";
            this.dataGridViewTextBoxColumnDepartmentSalaryWorkPlaceId.Name = "dataGridViewTextBoxColumnDepartmentSalaryWorkPlaceId";
            // 
            // dataGridViewTextBoxColumnDepartmentSalaryWorkPlaceName
            // 
            this.dataGridViewTextBoxColumnDepartmentSalaryWorkPlaceName.DataPropertyName = "DepartmentSalaryWorkPlaceName";
            this.dataGridViewTextBoxColumnDepartmentSalaryWorkPlaceName.HeaderText = "DepartmentSalaryWorkPlaceName";
            this.dataGridViewTextBoxColumnDepartmentSalaryWorkPlaceName.Name = "dataGridViewTextBoxColumnDepartmentSalaryWorkPlaceName";
            // 
            // dataGridViewTextBoxColumnDepartmentSalaryWorkPlaceMainWorkPlaceId
            // 
            this.dataGridViewTextBoxColumnDepartmentSalaryWorkPlaceMainWorkPlaceId.DataPropertyName = "DepartmentSalaryWorkPlaceMainWorkPlaceId";
            this.dataGridViewTextBoxColumnDepartmentSalaryWorkPlaceMainWorkPlaceId.HeaderText = "DepartmentSalaryWorkPlaceMainWorkPlaceId";
            this.dataGridViewTextBoxColumnDepartmentSalaryWorkPlaceMainWorkPlaceId.Name = "dataGridViewTextBoxColumnDepartmentSalaryWorkPlaceMainWorkPlaceId";
            // 
            // dataGridViewTextBoxColumnDepartmentSalaryWorkPlaceMainWorkPlaceName
            // 
            this.dataGridViewTextBoxColumnDepartmentSalaryWorkPlaceMainWorkPlaceName.DataPropertyName = "DepartmentSalaryWorkPlaceMainWorkPlaceName";
            this.dataGridViewTextBoxColumnDepartmentSalaryWorkPlaceMainWorkPlaceName.HeaderText = "DepartmentSalaryWorkPlaceMainWorkPlaceName";
            this.dataGridViewTextBoxColumnDepartmentSalaryWorkPlaceMainWorkPlaceName.Name = "dataGridViewTextBoxColumnDepartmentSalaryWorkPlaceMainWorkPlaceName";
            // 
            // dataGridViewTextBoxColumnNotes
            // 
            this.dataGridViewTextBoxColumnNotes.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumnNotes.HeaderText = "Notes";
            this.dataGridViewTextBoxColumnNotes.Name = "dataGridViewTextBoxColumnNotes";
            // 
            // dataGridViewTextBoxColumnCategoryId
            // 
            this.dataGridViewTextBoxColumnCategoryId.DataPropertyName = "CategoryId";
            this.dataGridViewTextBoxColumnCategoryId.HeaderText = "CategoryId";
            this.dataGridViewTextBoxColumnCategoryId.Name = "dataGridViewTextBoxColumnCategoryId";
            // 
            // dataGridViewTextBoxColumnCategoryName
            // 
            this.dataGridViewTextBoxColumnCategoryName.DataPropertyName = "CategoryName";
            this.dataGridViewTextBoxColumnCategoryName.HeaderText = "CategoryName";
            this.dataGridViewTextBoxColumnCategoryName.Name = "dataGridViewTextBoxColumnCategoryName";
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
            // FormEmployeeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 371);
			this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.employeeVwDataGridView);
            this.Controls.Add(this.employeeVwBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEmployeeView";
            this.Text = "View employees";
            this.Load += new System.EventHandler(this.FormEmployeeView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeVwBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeVwBindingNavigator)).EndInit();
            this.employeeVwBindingNavigator.ResumeLayout(false);
            this.employeeVwBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeVwDataGridView)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource employeeVwBindingSource;
        private System.Windows.Forms.BindingNavigator employeeVwBindingNavigator;
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
        private System.Windows.Forms.DataGridView employeeVwDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnFatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnFullName3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnMotherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnExpectedEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnCersStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnCfStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnLeaveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnLeaveReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEmployeeStatusId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEmployeeStatusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEmployeeStatusIsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnDepartmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnDepartmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnDepartmentSalaryWorkPlaceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnDepartmentSalaryWorkPlaceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnDepartmentSalaryWorkPlaceMainWorkPlaceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnDepartmentSalaryWorkPlaceMainWorkPlaceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnCategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnCategoryName;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel slblEllapsedTimeName;
		private System.Windows.Forms.ToolStripStatusLabel slblEllapsedTimeValue;
    }
}
