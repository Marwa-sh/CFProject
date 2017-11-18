namespace Cf
{
    partial class FormLoanDecisionView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoanDecisionView));
            this.loanDecisionVwBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loanDecisionVwBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.loanDecisionVwDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnDeductionStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnCersNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnCersDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnLoanDecisionTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnLoanDecisionTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnPaymentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnPaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnIsPaidFromSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnAdditionalClause = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnAdditionalIntroduction = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.slblEllapsedTimeName = new System.Windows.Forms.ToolStripStatusLabel();
			this.slblEllapsedTimeValue = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.loanDecisionVwBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanDecisionVwBindingNavigator)).BeginInit();
            this.loanDecisionVwBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loanDecisionVwDataGridView)).BeginInit();
			this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loanDecisionVwBindingSource
            // 
            this.loanDecisionVwBindingSource.DataSource = typeof(Cf.Data.LoanDecisionVw);
            // 
            // loanDecisionVwBindingNavigator
            // 
            this.loanDecisionVwBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.loanDecisionVwBindingNavigator.AllowItemReorder = true;
            this.loanDecisionVwBindingNavigator.BindingSource = this.loanDecisionVwBindingSource;
            this.loanDecisionVwBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.loanDecisionVwBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.loanDecisionVwBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.loanDecisionVwBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.loanDecisionVwBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.loanDecisionVwBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.loanDecisionVwBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.loanDecisionVwBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.loanDecisionVwBindingNavigator.Name = "loanDecisionVwBindingNavigator";
            this.loanDecisionVwBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.loanDecisionVwBindingNavigator.Size = new System.Drawing.Size(598, 25);
            this.loanDecisionVwBindingNavigator.TabIndex = 0;
            this.loanDecisionVwBindingNavigator.Text = "bindingNavigator1";
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
            // loanDecisionVwDataGridView
            // 
            this.loanDecisionVwDataGridView.AutoGenerateColumns = false;
            this.loanDecisionVwDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loanDecisionVwDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnId,
            this.dataGridViewTextBoxColumnNumber,
            this.dataGridViewTextBoxColumnYear,
            this.dataGridViewTextBoxColumnDate,
            this.dataGridViewTextBoxColumnDeductionStartDate,
            this.dataGridViewTextBoxColumnCersNumber,
            this.dataGridViewTextBoxColumnCersDate,
            this.dataGridViewTextBoxColumnNotes,
            this.dataGridViewTextBoxColumnLoanDecisionTypeId,
            this.dataGridViewTextBoxColumnLoanDecisionTypeName,
            this.dataGridViewTextBoxColumnPaymentNumber,
            this.dataGridViewTextBoxColumnPaymentDate,
            this.dataGridViewTextBoxColumnIsPaidFromSalary,
            this.dataGridViewTextBoxColumnReason,
            this.dataGridViewTextBoxColumnAdditionalClause,
            this.dataGridViewTextBoxColumnAdditionalIntroduction});
            this.loanDecisionVwDataGridView.DataSource = this.loanDecisionVwBindingSource;
            this.loanDecisionVwDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loanDecisionVwDataGridView.Location = new System.Drawing.Point(0, 25);
            this.loanDecisionVwDataGridView.Name = "loanDecisionVwDataGridView";
            this.loanDecisionVwDataGridView.Size = new System.Drawing.Size(598, 346);
            this.loanDecisionVwDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumnId
            // 
            this.dataGridViewTextBoxColumnId.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumnId.HeaderText = "Id";
            this.dataGridViewTextBoxColumnId.Name = "dataGridViewTextBoxColumnId";
            // 
            // dataGridViewTextBoxColumnNumber
            // 
            this.dataGridViewTextBoxColumnNumber.DataPropertyName = "Number";
            this.dataGridViewTextBoxColumnNumber.HeaderText = "Number";
            this.dataGridViewTextBoxColumnNumber.Name = "dataGridViewTextBoxColumnNumber";
            // 
            // dataGridViewTextBoxColumnYear
            // 
            this.dataGridViewTextBoxColumnYear.DataPropertyName = "Year";
            this.dataGridViewTextBoxColumnYear.HeaderText = "Year";
            this.dataGridViewTextBoxColumnYear.Name = "dataGridViewTextBoxColumnYear";
            // 
            // dataGridViewTextBoxColumnDate
            // 
            this.dataGridViewTextBoxColumnDate.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumnDate.HeaderText = "Date";
            this.dataGridViewTextBoxColumnDate.Name = "dataGridViewTextBoxColumnDate";
            // 
            // dataGridViewTextBoxColumnDeductionStartDate
            // 
            this.dataGridViewTextBoxColumnDeductionStartDate.DataPropertyName = "DeductionStartDate";
            this.dataGridViewTextBoxColumnDeductionStartDate.HeaderText = "DeductionStartDate";
            this.dataGridViewTextBoxColumnDeductionStartDate.Name = "dataGridViewTextBoxColumnDeductionStartDate";
            // 
            // dataGridViewTextBoxColumnCersNumber
            // 
            this.dataGridViewTextBoxColumnCersNumber.DataPropertyName = "CersNumber";
            this.dataGridViewTextBoxColumnCersNumber.HeaderText = "CersNumber";
            this.dataGridViewTextBoxColumnCersNumber.Name = "dataGridViewTextBoxColumnCersNumber";
            // 
            // dataGridViewTextBoxColumnCersDate
            // 
            this.dataGridViewTextBoxColumnCersDate.DataPropertyName = "CersDate";
            this.dataGridViewTextBoxColumnCersDate.HeaderText = "CersDate";
            this.dataGridViewTextBoxColumnCersDate.Name = "dataGridViewTextBoxColumnCersDate";
            // 
            // dataGridViewTextBoxColumnNotes
            // 
            this.dataGridViewTextBoxColumnNotes.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumnNotes.HeaderText = "Notes";
            this.dataGridViewTextBoxColumnNotes.Name = "dataGridViewTextBoxColumnNotes";
            // 
            // dataGridViewTextBoxColumnLoanDecisionTypeId
            // 
            this.dataGridViewTextBoxColumnLoanDecisionTypeId.DataPropertyName = "LoanDecisionTypeId";
            this.dataGridViewTextBoxColumnLoanDecisionTypeId.HeaderText = "LoanDecisionTypeId";
            this.dataGridViewTextBoxColumnLoanDecisionTypeId.Name = "dataGridViewTextBoxColumnLoanDecisionTypeId";
            // 
            // dataGridViewTextBoxColumnLoanDecisionTypeName
            // 
            this.dataGridViewTextBoxColumnLoanDecisionTypeName.DataPropertyName = "LoanDecisionTypeName";
            this.dataGridViewTextBoxColumnLoanDecisionTypeName.HeaderText = "LoanDecisionTypeName";
            this.dataGridViewTextBoxColumnLoanDecisionTypeName.Name = "dataGridViewTextBoxColumnLoanDecisionTypeName";
            // 
            // dataGridViewTextBoxColumnPaymentNumber
            // 
            this.dataGridViewTextBoxColumnPaymentNumber.DataPropertyName = "PaymentNumber";
            this.dataGridViewTextBoxColumnPaymentNumber.HeaderText = "PaymentNumber";
            this.dataGridViewTextBoxColumnPaymentNumber.Name = "dataGridViewTextBoxColumnPaymentNumber";
            // 
            // dataGridViewTextBoxColumnPaymentDate
            // 
            this.dataGridViewTextBoxColumnPaymentDate.DataPropertyName = "PaymentDate";
            this.dataGridViewTextBoxColumnPaymentDate.HeaderText = "PaymentDate";
            this.dataGridViewTextBoxColumnPaymentDate.Name = "dataGridViewTextBoxColumnPaymentDate";
            // 
            // dataGridViewTextBoxColumnIsPaidFromSalary
            // 
            this.dataGridViewTextBoxColumnIsPaidFromSalary.DataPropertyName = "IsPaidFromSalary";
            this.dataGridViewTextBoxColumnIsPaidFromSalary.HeaderText = "IsPaidFromSalary";
            this.dataGridViewTextBoxColumnIsPaidFromSalary.Name = "dataGridViewTextBoxColumnIsPaidFromSalary";
            // 
            // dataGridViewTextBoxColumnReason
            // 
            this.dataGridViewTextBoxColumnReason.DataPropertyName = "Reason";
            this.dataGridViewTextBoxColumnReason.HeaderText = "Reason";
            this.dataGridViewTextBoxColumnReason.Name = "dataGridViewTextBoxColumnReason";
            // 
            // dataGridViewTextBoxColumnAdditionalClause
            // 
            this.dataGridViewTextBoxColumnAdditionalClause.DataPropertyName = "AdditionalClause";
            this.dataGridViewTextBoxColumnAdditionalClause.HeaderText = "AdditionalClause";
            this.dataGridViewTextBoxColumnAdditionalClause.Name = "dataGridViewTextBoxColumnAdditionalClause";
            // 
            // dataGridViewTextBoxColumnAdditionalIntroduction
            // 
            this.dataGridViewTextBoxColumnAdditionalIntroduction.DataPropertyName = "AdditionalIntroduction";
            this.dataGridViewTextBoxColumnAdditionalIntroduction.HeaderText = "AdditionalIntroduction";
            this.dataGridViewTextBoxColumnAdditionalIntroduction.Name = "dataGridViewTextBoxColumnAdditionalIntroduction";
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
            // FormLoanDecisionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 371);
			this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.loanDecisionVwDataGridView);
            this.Controls.Add(this.loanDecisionVwBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLoanDecisionView";
            this.Text = "View loanDecisions";
            this.Load += new System.EventHandler(this.FormLoanDecisionView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loanDecisionVwBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanDecisionVwBindingNavigator)).EndInit();
            this.loanDecisionVwBindingNavigator.ResumeLayout(false);
            this.loanDecisionVwBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loanDecisionVwDataGridView)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource loanDecisionVwBindingSource;
        private System.Windows.Forms.BindingNavigator loanDecisionVwBindingNavigator;
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
        private System.Windows.Forms.DataGridView loanDecisionVwDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnDeductionStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnCersNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnCersDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnLoanDecisionTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnLoanDecisionTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnPaymentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnPaymentDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnIsPaidFromSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnAdditionalClause;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnAdditionalIntroduction;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel slblEllapsedTimeName;
		private System.Windows.Forms.ToolStripStatusLabel slblEllapsedTimeValue;
    }
}
