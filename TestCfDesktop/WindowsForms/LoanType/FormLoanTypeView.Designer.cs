namespace Cf
{
    partial class FormLoanTypeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoanTypeView));
            this.loanTypeVwBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loanTypeVwBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.loanTypeVwDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnProductTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnProductTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnProductTypeRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnProductTypeGuarantorsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnProductTypeAccountNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnProductTypePrintLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnProductTypeProfitStrategyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnProductTypeProfitStrategyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnProductTypePaymentGroupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnProductTypePaymentGroupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnProductTypeIsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.slblEllapsedTimeName = new System.Windows.Forms.ToolStripStatusLabel();
			this.slblEllapsedTimeValue = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.loanTypeVwBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanTypeVwBindingNavigator)).BeginInit();
            this.loanTypeVwBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loanTypeVwDataGridView)).BeginInit();
			this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loanTypeVwBindingSource
            // 
            this.loanTypeVwBindingSource.DataSource = typeof(Cf.Data.LoanTypeVw);
            // 
            // loanTypeVwBindingNavigator
            // 
            this.loanTypeVwBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.loanTypeVwBindingNavigator.AllowItemReorder = true;
            this.loanTypeVwBindingNavigator.BindingSource = this.loanTypeVwBindingSource;
            this.loanTypeVwBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.loanTypeVwBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.loanTypeVwBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.loanTypeVwBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.loanTypeVwBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.loanTypeVwBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.loanTypeVwBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.loanTypeVwBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.loanTypeVwBindingNavigator.Name = "loanTypeVwBindingNavigator";
            this.loanTypeVwBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.loanTypeVwBindingNavigator.Size = new System.Drawing.Size(598, 25);
            this.loanTypeVwBindingNavigator.TabIndex = 0;
            this.loanTypeVwBindingNavigator.Text = "bindingNavigator1";
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
            // loanTypeVwDataGridView
            // 
            this.loanTypeVwDataGridView.AutoGenerateColumns = false;
            this.loanTypeVwDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.loanTypeVwDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnProductTypeId,
            this.dataGridViewTextBoxColumnProductTypeName,
            this.dataGridViewTextBoxColumnProductTypeRate,
            this.dataGridViewTextBoxColumnProductTypeGuarantorsCount,
            this.dataGridViewTextBoxColumnProductTypeAccountNumber,
            this.dataGridViewTextBoxColumnProductTypePrintLabel,
            this.dataGridViewTextBoxColumnProductTypeProfitStrategyId,
            this.dataGridViewTextBoxColumnProductTypeProfitStrategyName,
            this.dataGridViewTextBoxColumnProductTypePaymentGroupId,
            this.dataGridViewTextBoxColumnProductTypePaymentGroupName,
            this.dataGridViewTextBoxColumnProductTypeIsActive});
            this.loanTypeVwDataGridView.DataSource = this.loanTypeVwBindingSource;
            this.loanTypeVwDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loanTypeVwDataGridView.Location = new System.Drawing.Point(0, 25);
            this.loanTypeVwDataGridView.Name = "loanTypeVwDataGridView";
            this.loanTypeVwDataGridView.Size = new System.Drawing.Size(598, 346);
            this.loanTypeVwDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumnProductTypeId
            // 
            this.dataGridViewTextBoxColumnProductTypeId.DataPropertyName = "ProductTypeId";
            this.dataGridViewTextBoxColumnProductTypeId.HeaderText = "ProductTypeId";
            this.dataGridViewTextBoxColumnProductTypeId.Name = "dataGridViewTextBoxColumnProductTypeId";
            // 
            // dataGridViewTextBoxColumnProductTypeName
            // 
            this.dataGridViewTextBoxColumnProductTypeName.DataPropertyName = "ProductTypeName";
            this.dataGridViewTextBoxColumnProductTypeName.HeaderText = "ProductTypeName";
            this.dataGridViewTextBoxColumnProductTypeName.Name = "dataGridViewTextBoxColumnProductTypeName";
            // 
            // dataGridViewTextBoxColumnProductTypeRate
            // 
            this.dataGridViewTextBoxColumnProductTypeRate.DataPropertyName = "ProductTypeRate";
            this.dataGridViewTextBoxColumnProductTypeRate.HeaderText = "ProductTypeRate";
            this.dataGridViewTextBoxColumnProductTypeRate.Name = "dataGridViewTextBoxColumnProductTypeRate";
            // 
            // dataGridViewTextBoxColumnProductTypeGuarantorsCount
            // 
            this.dataGridViewTextBoxColumnProductTypeGuarantorsCount.DataPropertyName = "ProductTypeGuarantorsCount";
            this.dataGridViewTextBoxColumnProductTypeGuarantorsCount.HeaderText = "ProductTypeGuarantorsCount";
            this.dataGridViewTextBoxColumnProductTypeGuarantorsCount.Name = "dataGridViewTextBoxColumnProductTypeGuarantorsCount";
            // 
            // dataGridViewTextBoxColumnProductTypeAccountNumber
            // 
            this.dataGridViewTextBoxColumnProductTypeAccountNumber.DataPropertyName = "ProductTypeAccountNumber";
            this.dataGridViewTextBoxColumnProductTypeAccountNumber.HeaderText = "ProductTypeAccountNumber";
            this.dataGridViewTextBoxColumnProductTypeAccountNumber.Name = "dataGridViewTextBoxColumnProductTypeAccountNumber";
            // 
            // dataGridViewTextBoxColumnProductTypePrintLabel
            // 
            this.dataGridViewTextBoxColumnProductTypePrintLabel.DataPropertyName = "ProductTypePrintLabel";
            this.dataGridViewTextBoxColumnProductTypePrintLabel.HeaderText = "ProductTypePrintLabel";
            this.dataGridViewTextBoxColumnProductTypePrintLabel.Name = "dataGridViewTextBoxColumnProductTypePrintLabel";
            // 
            // dataGridViewTextBoxColumnProductTypeProfitStrategyId
            // 
            this.dataGridViewTextBoxColumnProductTypeProfitStrategyId.DataPropertyName = "ProductTypeProfitStrategyId";
            this.dataGridViewTextBoxColumnProductTypeProfitStrategyId.HeaderText = "ProductTypeProfitStrategyId";
            this.dataGridViewTextBoxColumnProductTypeProfitStrategyId.Name = "dataGridViewTextBoxColumnProductTypeProfitStrategyId";
            // 
            // dataGridViewTextBoxColumnProductTypeProfitStrategyName
            // 
            this.dataGridViewTextBoxColumnProductTypeProfitStrategyName.DataPropertyName = "ProductTypeProfitStrategyName";
            this.dataGridViewTextBoxColumnProductTypeProfitStrategyName.HeaderText = "ProductTypeProfitStrategyName";
            this.dataGridViewTextBoxColumnProductTypeProfitStrategyName.Name = "dataGridViewTextBoxColumnProductTypeProfitStrategyName";
            // 
            // dataGridViewTextBoxColumnProductTypePaymentGroupId
            // 
            this.dataGridViewTextBoxColumnProductTypePaymentGroupId.DataPropertyName = "ProductTypePaymentGroupId";
            this.dataGridViewTextBoxColumnProductTypePaymentGroupId.HeaderText = "ProductTypePaymentGroupId";
            this.dataGridViewTextBoxColumnProductTypePaymentGroupId.Name = "dataGridViewTextBoxColumnProductTypePaymentGroupId";
            // 
            // dataGridViewTextBoxColumnProductTypePaymentGroupName
            // 
            this.dataGridViewTextBoxColumnProductTypePaymentGroupName.DataPropertyName = "ProductTypePaymentGroupName";
            this.dataGridViewTextBoxColumnProductTypePaymentGroupName.HeaderText = "ProductTypePaymentGroupName";
            this.dataGridViewTextBoxColumnProductTypePaymentGroupName.Name = "dataGridViewTextBoxColumnProductTypePaymentGroupName";
            // 
            // dataGridViewTextBoxColumnProductTypeIsActive
            // 
            this.dataGridViewTextBoxColumnProductTypeIsActive.DataPropertyName = "ProductTypeIsActive";
            this.dataGridViewTextBoxColumnProductTypeIsActive.HeaderText = "ProductTypeIsActive";
            this.dataGridViewTextBoxColumnProductTypeIsActive.Name = "dataGridViewTextBoxColumnProductTypeIsActive";
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
            // FormLoanTypeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 371);
			this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.loanTypeVwDataGridView);
            this.Controls.Add(this.loanTypeVwBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLoanTypeView";
            this.Text = "View loanTypes";
            this.Load += new System.EventHandler(this.FormLoanTypeView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loanTypeVwBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loanTypeVwBindingNavigator)).EndInit();
            this.loanTypeVwBindingNavigator.ResumeLayout(false);
            this.loanTypeVwBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loanTypeVwDataGridView)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource loanTypeVwBindingSource;
        private System.Windows.Forms.BindingNavigator loanTypeVwBindingNavigator;
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
        private System.Windows.Forms.DataGridView loanTypeVwDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnProductTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnProductTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnProductTypeRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnProductTypeGuarantorsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnProductTypeAccountNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnProductTypePrintLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnProductTypeProfitStrategyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnProductTypeProfitStrategyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnProductTypePaymentGroupId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnProductTypePaymentGroupName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnProductTypeIsActive;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel slblEllapsedTimeName;
		private System.Windows.Forms.ToolStripStatusLabel slblEllapsedTimeValue;
    }
}
