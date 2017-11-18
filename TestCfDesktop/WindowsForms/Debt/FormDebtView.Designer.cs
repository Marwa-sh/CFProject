namespace Cf
{
    partial class FormDebtView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDebtView));
            this.debtVwBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.debtVwBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.debtVwDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEmployeeFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEmployeeLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEmployeeFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEmployeeFatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEmployeeFullName3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEmployeeMotherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEmployeeBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEmployeeExpectedEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEmployeeCersStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEmployeeCfStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEmployeeLeaveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEmployeeLeaveReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEmployeeEmployeeStatusId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEmployeeEmployeeStatusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEmployeeEmployeeStatusIsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEmployeeDepartmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEmployeeDepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEmployeeDepartmentSalaryWorkPlaceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEmployeeDepartmentSalaryWorkPlaceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEmployeeNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEmployeeCategoryId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnEmployeeCategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnIssuerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnIssuerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnReferenceNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnPeriodInMonths = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnExceptionalPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnIsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnIssueDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnInstallment = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.slblEllapsedTimeName = new System.Windows.Forms.ToolStripStatusLabel();
			this.slblEllapsedTimeValue = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.debtVwBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtVwBindingNavigator)).BeginInit();
            this.debtVwBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.debtVwDataGridView)).BeginInit();
			this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // debtVwBindingSource
            // 
            this.debtVwBindingSource.DataSource = typeof(Cf.Data.DebtVw);
            // 
            // debtVwBindingNavigator
            // 
            this.debtVwBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.debtVwBindingNavigator.AllowItemReorder = true;
            this.debtVwBindingNavigator.BindingSource = this.debtVwBindingSource;
            this.debtVwBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.debtVwBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.debtVwBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.debtVwBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.debtVwBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.debtVwBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.debtVwBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.debtVwBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.debtVwBindingNavigator.Name = "debtVwBindingNavigator";
            this.debtVwBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.debtVwBindingNavigator.Size = new System.Drawing.Size(598, 25);
            this.debtVwBindingNavigator.TabIndex = 0;
            this.debtVwBindingNavigator.Text = "bindingNavigator1";
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
            // debtVwDataGridView
            // 
            this.debtVwDataGridView.AutoGenerateColumns = false;
            this.debtVwDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.debtVwDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnId,
            this.dataGridViewTextBoxColumnEmployeeId,
            this.dataGridViewTextBoxColumnEmployeeFirstName,
            this.dataGridViewTextBoxColumnEmployeeLastName,
            this.dataGridViewTextBoxColumnEmployeeFullName,
            this.dataGridViewTextBoxColumnEmployeeFatherName,
            this.dataGridViewTextBoxColumnEmployeeFullName3,
            this.dataGridViewTextBoxColumnEmployeeMotherName,
            this.dataGridViewTextBoxColumnEmployeeBirthDate,
            this.dataGridViewTextBoxColumnEmployeeExpectedEndDate,
            this.dataGridViewTextBoxColumnEmployeeCersStartDate,
            this.dataGridViewTextBoxColumnEmployeeCfStartDate,
            this.dataGridViewTextBoxColumnEmployeeLeaveDate,
            this.dataGridViewTextBoxColumnEmployeeLeaveReason,
            this.dataGridViewTextBoxColumnEmployeeEmployeeStatusId,
            this.dataGridViewTextBoxColumnEmployeeEmployeeStatusName,
            this.dataGridViewTextBoxColumnEmployeeEmployeeStatusIsActive,
            this.dataGridViewTextBoxColumnEmployeeDepartmentId,
            this.dataGridViewTextBoxColumnEmployeeDepartmentName,
            this.dataGridViewTextBoxColumnEmployeeDepartmentSalaryWorkPlaceId,
            this.dataGridViewTextBoxColumnEmployeeDepartmentSalaryWorkPlaceName,
            this.dataGridViewTextBoxColumnEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId,
            this.dataGridViewTextBoxColumnEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName,
            this.dataGridViewTextBoxColumnEmployeeNotes,
            this.dataGridViewTextBoxColumnEmployeeCategoryId,
            this.dataGridViewTextBoxColumnEmployeeCategoryName,
            this.dataGridViewTextBoxColumnAmount,
            this.dataGridViewTextBoxColumnIssuerId,
            this.dataGridViewTextBoxColumnIssuerName,
            this.dataGridViewTextBoxColumnReferenceNumber,
            this.dataGridViewTextBoxColumnDate,
            this.dataGridViewTextBoxColumnPeriodInMonths,
            this.dataGridViewTextBoxColumnExceptionalPayment,
            this.dataGridViewTextBoxColumnIsActive,
            this.dataGridViewTextBoxColumnNotes,
            this.dataGridViewTextBoxColumnIssueDescription,
            this.dataGridViewTextBoxColumnInstallment});
            this.debtVwDataGridView.DataSource = this.debtVwBindingSource;
            this.debtVwDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debtVwDataGridView.Location = new System.Drawing.Point(0, 25);
            this.debtVwDataGridView.Name = "debtVwDataGridView";
            this.debtVwDataGridView.Size = new System.Drawing.Size(598, 346);
            this.debtVwDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumnId
            // 
            this.dataGridViewTextBoxColumnId.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumnId.HeaderText = "Id";
            this.dataGridViewTextBoxColumnId.Name = "dataGridViewTextBoxColumnId";
            // 
            // dataGridViewTextBoxColumnEmployeeId
            // 
            this.dataGridViewTextBoxColumnEmployeeId.DataPropertyName = "EmployeeId";
            this.dataGridViewTextBoxColumnEmployeeId.HeaderText = "EmployeeId";
            this.dataGridViewTextBoxColumnEmployeeId.Name = "dataGridViewTextBoxColumnEmployeeId";
            // 
            // dataGridViewTextBoxColumnEmployeeFirstName
            // 
            this.dataGridViewTextBoxColumnEmployeeFirstName.DataPropertyName = "EmployeeFirstName";
            this.dataGridViewTextBoxColumnEmployeeFirstName.HeaderText = "EmployeeFirstName";
            this.dataGridViewTextBoxColumnEmployeeFirstName.Name = "dataGridViewTextBoxColumnEmployeeFirstName";
            // 
            // dataGridViewTextBoxColumnEmployeeLastName
            // 
            this.dataGridViewTextBoxColumnEmployeeLastName.DataPropertyName = "EmployeeLastName";
            this.dataGridViewTextBoxColumnEmployeeLastName.HeaderText = "EmployeeLastName";
            this.dataGridViewTextBoxColumnEmployeeLastName.Name = "dataGridViewTextBoxColumnEmployeeLastName";
            // 
            // dataGridViewTextBoxColumnEmployeeFullName
            // 
            this.dataGridViewTextBoxColumnEmployeeFullName.DataPropertyName = "EmployeeFullName";
            this.dataGridViewTextBoxColumnEmployeeFullName.HeaderText = "EmployeeFullName";
            this.dataGridViewTextBoxColumnEmployeeFullName.Name = "dataGridViewTextBoxColumnEmployeeFullName";
            // 
            // dataGridViewTextBoxColumnEmployeeFatherName
            // 
            this.dataGridViewTextBoxColumnEmployeeFatherName.DataPropertyName = "EmployeeFatherName";
            this.dataGridViewTextBoxColumnEmployeeFatherName.HeaderText = "EmployeeFatherName";
            this.dataGridViewTextBoxColumnEmployeeFatherName.Name = "dataGridViewTextBoxColumnEmployeeFatherName";
            // 
            // dataGridViewTextBoxColumnEmployeeFullName3
            // 
            this.dataGridViewTextBoxColumnEmployeeFullName3.DataPropertyName = "EmployeeFullName3";
            this.dataGridViewTextBoxColumnEmployeeFullName3.HeaderText = "EmployeeFullName3";
            this.dataGridViewTextBoxColumnEmployeeFullName3.Name = "dataGridViewTextBoxColumnEmployeeFullName3";
            // 
            // dataGridViewTextBoxColumnEmployeeMotherName
            // 
            this.dataGridViewTextBoxColumnEmployeeMotherName.DataPropertyName = "EmployeeMotherName";
            this.dataGridViewTextBoxColumnEmployeeMotherName.HeaderText = "EmployeeMotherName";
            this.dataGridViewTextBoxColumnEmployeeMotherName.Name = "dataGridViewTextBoxColumnEmployeeMotherName";
            // 
            // dataGridViewTextBoxColumnEmployeeBirthDate
            // 
            this.dataGridViewTextBoxColumnEmployeeBirthDate.DataPropertyName = "EmployeeBirthDate";
            this.dataGridViewTextBoxColumnEmployeeBirthDate.HeaderText = "EmployeeBirthDate";
            this.dataGridViewTextBoxColumnEmployeeBirthDate.Name = "dataGridViewTextBoxColumnEmployeeBirthDate";
            // 
            // dataGridViewTextBoxColumnEmployeeExpectedEndDate
            // 
            this.dataGridViewTextBoxColumnEmployeeExpectedEndDate.DataPropertyName = "EmployeeExpectedEndDate";
            this.dataGridViewTextBoxColumnEmployeeExpectedEndDate.HeaderText = "EmployeeExpectedEndDate";
            this.dataGridViewTextBoxColumnEmployeeExpectedEndDate.Name = "dataGridViewTextBoxColumnEmployeeExpectedEndDate";
            // 
            // dataGridViewTextBoxColumnEmployeeCersStartDate
            // 
            this.dataGridViewTextBoxColumnEmployeeCersStartDate.DataPropertyName = "EmployeeCersStartDate";
            this.dataGridViewTextBoxColumnEmployeeCersStartDate.HeaderText = "EmployeeCersStartDate";
            this.dataGridViewTextBoxColumnEmployeeCersStartDate.Name = "dataGridViewTextBoxColumnEmployeeCersStartDate";
            // 
            // dataGridViewTextBoxColumnEmployeeCfStartDate
            // 
            this.dataGridViewTextBoxColumnEmployeeCfStartDate.DataPropertyName = "EmployeeCfStartDate";
            this.dataGridViewTextBoxColumnEmployeeCfStartDate.HeaderText = "EmployeeCfStartDate";
            this.dataGridViewTextBoxColumnEmployeeCfStartDate.Name = "dataGridViewTextBoxColumnEmployeeCfStartDate";
            // 
            // dataGridViewTextBoxColumnEmployeeLeaveDate
            // 
            this.dataGridViewTextBoxColumnEmployeeLeaveDate.DataPropertyName = "EmployeeLeaveDate";
            this.dataGridViewTextBoxColumnEmployeeLeaveDate.HeaderText = "EmployeeLeaveDate";
            this.dataGridViewTextBoxColumnEmployeeLeaveDate.Name = "dataGridViewTextBoxColumnEmployeeLeaveDate";
            // 
            // dataGridViewTextBoxColumnEmployeeLeaveReason
            // 
            this.dataGridViewTextBoxColumnEmployeeLeaveReason.DataPropertyName = "EmployeeLeaveReason";
            this.dataGridViewTextBoxColumnEmployeeLeaveReason.HeaderText = "EmployeeLeaveReason";
            this.dataGridViewTextBoxColumnEmployeeLeaveReason.Name = "dataGridViewTextBoxColumnEmployeeLeaveReason";
            // 
            // dataGridViewTextBoxColumnEmployeeEmployeeStatusId
            // 
            this.dataGridViewTextBoxColumnEmployeeEmployeeStatusId.DataPropertyName = "EmployeeEmployeeStatusId";
            this.dataGridViewTextBoxColumnEmployeeEmployeeStatusId.HeaderText = "EmployeeEmployeeStatusId";
            this.dataGridViewTextBoxColumnEmployeeEmployeeStatusId.Name = "dataGridViewTextBoxColumnEmployeeEmployeeStatusId";
            // 
            // dataGridViewTextBoxColumnEmployeeEmployeeStatusName
            // 
            this.dataGridViewTextBoxColumnEmployeeEmployeeStatusName.DataPropertyName = "EmployeeEmployeeStatusName";
            this.dataGridViewTextBoxColumnEmployeeEmployeeStatusName.HeaderText = "EmployeeEmployeeStatusName";
            this.dataGridViewTextBoxColumnEmployeeEmployeeStatusName.Name = "dataGridViewTextBoxColumnEmployeeEmployeeStatusName";
            // 
            // dataGridViewTextBoxColumnEmployeeEmployeeStatusIsActive
            // 
            this.dataGridViewTextBoxColumnEmployeeEmployeeStatusIsActive.DataPropertyName = "EmployeeEmployeeStatusIsActive";
            this.dataGridViewTextBoxColumnEmployeeEmployeeStatusIsActive.HeaderText = "EmployeeEmployeeStatusIsActive";
            this.dataGridViewTextBoxColumnEmployeeEmployeeStatusIsActive.Name = "dataGridViewTextBoxColumnEmployeeEmployeeStatusIsActive";
            // 
            // dataGridViewTextBoxColumnEmployeeDepartmentId
            // 
            this.dataGridViewTextBoxColumnEmployeeDepartmentId.DataPropertyName = "EmployeeDepartmentId";
            this.dataGridViewTextBoxColumnEmployeeDepartmentId.HeaderText = "EmployeeDepartmentId";
            this.dataGridViewTextBoxColumnEmployeeDepartmentId.Name = "dataGridViewTextBoxColumnEmployeeDepartmentId";
            // 
            // dataGridViewTextBoxColumnEmployeeDepartmentName
            // 
            this.dataGridViewTextBoxColumnEmployeeDepartmentName.DataPropertyName = "EmployeeDepartmentName";
            this.dataGridViewTextBoxColumnEmployeeDepartmentName.HeaderText = "EmployeeDepartmentName";
            this.dataGridViewTextBoxColumnEmployeeDepartmentName.Name = "dataGridViewTextBoxColumnEmployeeDepartmentName";
            // 
            // dataGridViewTextBoxColumnEmployeeDepartmentSalaryWorkPlaceId
            // 
            this.dataGridViewTextBoxColumnEmployeeDepartmentSalaryWorkPlaceId.DataPropertyName = "EmployeeDepartmentSalaryWorkPlaceId";
            this.dataGridViewTextBoxColumnEmployeeDepartmentSalaryWorkPlaceId.HeaderText = "EmployeeDepartmentSalaryWorkPlaceId";
            this.dataGridViewTextBoxColumnEmployeeDepartmentSalaryWorkPlaceId.Name = "dataGridViewTextBoxColumnEmployeeDepartmentSalaryWorkPlaceId";
            // 
            // dataGridViewTextBoxColumnEmployeeDepartmentSalaryWorkPlaceName
            // 
            this.dataGridViewTextBoxColumnEmployeeDepartmentSalaryWorkPlaceName.DataPropertyName = "EmployeeDepartmentSalaryWorkPlaceName";
            this.dataGridViewTextBoxColumnEmployeeDepartmentSalaryWorkPlaceName.HeaderText = "EmployeeDepartmentSalaryWorkPlaceName";
            this.dataGridViewTextBoxColumnEmployeeDepartmentSalaryWorkPlaceName.Name = "dataGridViewTextBoxColumnEmployeeDepartmentSalaryWorkPlaceName";
            // 
            // dataGridViewTextBoxColumnEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId
            // 
            this.dataGridViewTextBoxColumnEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId.DataPropertyName = "EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId";
            this.dataGridViewTextBoxColumnEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId.HeaderText = "EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId";
            this.dataGridViewTextBoxColumnEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId.Name = "dataGridViewTextBoxColumnEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId";
            // 
            // dataGridViewTextBoxColumnEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName
            // 
            this.dataGridViewTextBoxColumnEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName.DataPropertyName = "EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName";
            this.dataGridViewTextBoxColumnEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName.HeaderText = "EmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName";
            this.dataGridViewTextBoxColumnEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName.Name = "dataGridViewTextBoxColumnEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName";
            // 
            // dataGridViewTextBoxColumnEmployeeNotes
            // 
            this.dataGridViewTextBoxColumnEmployeeNotes.DataPropertyName = "EmployeeNotes";
            this.dataGridViewTextBoxColumnEmployeeNotes.HeaderText = "EmployeeNotes";
            this.dataGridViewTextBoxColumnEmployeeNotes.Name = "dataGridViewTextBoxColumnEmployeeNotes";
            // 
            // dataGridViewTextBoxColumnEmployeeCategoryId
            // 
            this.dataGridViewTextBoxColumnEmployeeCategoryId.DataPropertyName = "EmployeeCategoryId";
            this.dataGridViewTextBoxColumnEmployeeCategoryId.HeaderText = "EmployeeCategoryId";
            this.dataGridViewTextBoxColumnEmployeeCategoryId.Name = "dataGridViewTextBoxColumnEmployeeCategoryId";
            // 
            // dataGridViewTextBoxColumnEmployeeCategoryName
            // 
            this.dataGridViewTextBoxColumnEmployeeCategoryName.DataPropertyName = "EmployeeCategoryName";
            this.dataGridViewTextBoxColumnEmployeeCategoryName.HeaderText = "EmployeeCategoryName";
            this.dataGridViewTextBoxColumnEmployeeCategoryName.Name = "dataGridViewTextBoxColumnEmployeeCategoryName";
            // 
            // dataGridViewTextBoxColumnAmount
            // 
            this.dataGridViewTextBoxColumnAmount.DataPropertyName = "Amount";
            this.dataGridViewTextBoxColumnAmount.HeaderText = "Amount";
            this.dataGridViewTextBoxColumnAmount.Name = "dataGridViewTextBoxColumnAmount";
            // 
            // dataGridViewTextBoxColumnIssuerId
            // 
            this.dataGridViewTextBoxColumnIssuerId.DataPropertyName = "IssuerId";
            this.dataGridViewTextBoxColumnIssuerId.HeaderText = "IssuerId";
            this.dataGridViewTextBoxColumnIssuerId.Name = "dataGridViewTextBoxColumnIssuerId";
            // 
            // dataGridViewTextBoxColumnIssuerName
            // 
            this.dataGridViewTextBoxColumnIssuerName.DataPropertyName = "IssuerName";
            this.dataGridViewTextBoxColumnIssuerName.HeaderText = "IssuerName";
            this.dataGridViewTextBoxColumnIssuerName.Name = "dataGridViewTextBoxColumnIssuerName";
            // 
            // dataGridViewTextBoxColumnReferenceNumber
            // 
            this.dataGridViewTextBoxColumnReferenceNumber.DataPropertyName = "ReferenceNumber";
            this.dataGridViewTextBoxColumnReferenceNumber.HeaderText = "ReferenceNumber";
            this.dataGridViewTextBoxColumnReferenceNumber.Name = "dataGridViewTextBoxColumnReferenceNumber";
            // 
            // dataGridViewTextBoxColumnDate
            // 
            this.dataGridViewTextBoxColumnDate.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumnDate.HeaderText = "Date";
            this.dataGridViewTextBoxColumnDate.Name = "dataGridViewTextBoxColumnDate";
            // 
            // dataGridViewTextBoxColumnPeriodInMonths
            // 
            this.dataGridViewTextBoxColumnPeriodInMonths.DataPropertyName = "PeriodInMonths";
            this.dataGridViewTextBoxColumnPeriodInMonths.HeaderText = "PeriodInMonths";
            this.dataGridViewTextBoxColumnPeriodInMonths.Name = "dataGridViewTextBoxColumnPeriodInMonths";
            // 
            // dataGridViewTextBoxColumnExceptionalPayment
            // 
            this.dataGridViewTextBoxColumnExceptionalPayment.DataPropertyName = "ExceptionalPayment";
            this.dataGridViewTextBoxColumnExceptionalPayment.HeaderText = "ExceptionalPayment";
            this.dataGridViewTextBoxColumnExceptionalPayment.Name = "dataGridViewTextBoxColumnExceptionalPayment";
            // 
            // dataGridViewTextBoxColumnIsActive
            // 
            this.dataGridViewTextBoxColumnIsActive.DataPropertyName = "IsActive";
            this.dataGridViewTextBoxColumnIsActive.HeaderText = "IsActive";
            this.dataGridViewTextBoxColumnIsActive.Name = "dataGridViewTextBoxColumnIsActive";
            // 
            // dataGridViewTextBoxColumnNotes
            // 
            this.dataGridViewTextBoxColumnNotes.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumnNotes.HeaderText = "Notes";
            this.dataGridViewTextBoxColumnNotes.Name = "dataGridViewTextBoxColumnNotes";
            // 
            // dataGridViewTextBoxColumnIssueDescription
            // 
            this.dataGridViewTextBoxColumnIssueDescription.DataPropertyName = "IssueDescription";
            this.dataGridViewTextBoxColumnIssueDescription.HeaderText = "IssueDescription";
            this.dataGridViewTextBoxColumnIssueDescription.Name = "dataGridViewTextBoxColumnIssueDescription";
            // 
            // dataGridViewTextBoxColumnInstallment
            // 
            this.dataGridViewTextBoxColumnInstallment.DataPropertyName = "Installment";
            this.dataGridViewTextBoxColumnInstallment.HeaderText = "Installment";
            this.dataGridViewTextBoxColumnInstallment.Name = "dataGridViewTextBoxColumnInstallment";
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
            // FormDebtView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 371);
			this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.debtVwDataGridView);
            this.Controls.Add(this.debtVwBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDebtView";
            this.Text = "View debts";
            this.Load += new System.EventHandler(this.FormDebtView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.debtVwBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.debtVwBindingNavigator)).EndInit();
            this.debtVwBindingNavigator.ResumeLayout(false);
            this.debtVwBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.debtVwDataGridView)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource debtVwBindingSource;
        private System.Windows.Forms.BindingNavigator debtVwBindingNavigator;
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
        private System.Windows.Forms.DataGridView debtVwDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEmployeeFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEmployeeLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEmployeeFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEmployeeFatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEmployeeFullName3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEmployeeMotherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEmployeeBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEmployeeExpectedEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEmployeeCersStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEmployeeCfStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEmployeeLeaveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEmployeeLeaveReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEmployeeEmployeeStatusId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEmployeeEmployeeStatusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEmployeeEmployeeStatusIsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEmployeeDepartmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEmployeeDepartmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEmployeeDepartmentSalaryWorkPlaceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEmployeeDepartmentSalaryWorkPlaceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEmployeeDepartmentSalaryWorkPlaceMainWorkPlaceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEmployeeNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEmployeeCategoryId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnEmployeeCategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnIssuerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnIssuerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnReferenceNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnPeriodInMonths;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnExceptionalPayment;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnIsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnIssueDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnInstallment;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel slblEllapsedTimeName;
		private System.Windows.Forms.ToolStripStatusLabel slblEllapsedTimeValue;
    }
}
