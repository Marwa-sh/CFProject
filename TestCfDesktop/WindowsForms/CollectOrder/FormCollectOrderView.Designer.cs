namespace Cf
{
    partial class FormCollectOrderView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCollectOrderView));
            this.collectOrderVwBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.collectOrderVwBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.collectOrderVwDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnAccountingDocumentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnAccountingDocumentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.slblEllapsedTimeName = new System.Windows.Forms.ToolStripStatusLabel();
			this.slblEllapsedTimeValue = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.collectOrderVwBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectOrderVwBindingNavigator)).BeginInit();
            this.collectOrderVwBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collectOrderVwDataGridView)).BeginInit();
			this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // collectOrderVwBindingSource
            // 
            this.collectOrderVwBindingSource.DataSource = typeof(Cf.Data.CollectOrderVw);
            // 
            // collectOrderVwBindingNavigator
            // 
            this.collectOrderVwBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.collectOrderVwBindingNavigator.AllowItemReorder = true;
            this.collectOrderVwBindingNavigator.BindingSource = this.collectOrderVwBindingSource;
            this.collectOrderVwBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.collectOrderVwBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.collectOrderVwBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.collectOrderVwBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.collectOrderVwBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.collectOrderVwBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.collectOrderVwBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.collectOrderVwBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.collectOrderVwBindingNavigator.Name = "collectOrderVwBindingNavigator";
            this.collectOrderVwBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.collectOrderVwBindingNavigator.Size = new System.Drawing.Size(598, 25);
            this.collectOrderVwBindingNavigator.TabIndex = 0;
            this.collectOrderVwBindingNavigator.Text = "bindingNavigator1";
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
            // collectOrderVwDataGridView
            // 
            this.collectOrderVwDataGridView.AutoGenerateColumns = false;
            this.collectOrderVwDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.collectOrderVwDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnId,
            this.dataGridViewTextBoxColumnNumber,
            this.dataGridViewTextBoxColumnDate,
            this.dataGridViewTextBoxColumnAccountingDocumentNumber,
            this.dataGridViewTextBoxColumnAccountingDocumentDate});
            this.collectOrderVwDataGridView.DataSource = this.collectOrderVwBindingSource;
            this.collectOrderVwDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.collectOrderVwDataGridView.Location = new System.Drawing.Point(0, 25);
            this.collectOrderVwDataGridView.Name = "collectOrderVwDataGridView";
            this.collectOrderVwDataGridView.Size = new System.Drawing.Size(598, 346);
            this.collectOrderVwDataGridView.TabIndex = 1;
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
            // dataGridViewTextBoxColumnDate
            // 
            this.dataGridViewTextBoxColumnDate.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumnDate.HeaderText = "Date";
            this.dataGridViewTextBoxColumnDate.Name = "dataGridViewTextBoxColumnDate";
            // 
            // dataGridViewTextBoxColumnAccountingDocumentNumber
            // 
            this.dataGridViewTextBoxColumnAccountingDocumentNumber.DataPropertyName = "AccountingDocumentNumber";
            this.dataGridViewTextBoxColumnAccountingDocumentNumber.HeaderText = "AccountingDocumentNumber";
            this.dataGridViewTextBoxColumnAccountingDocumentNumber.Name = "dataGridViewTextBoxColumnAccountingDocumentNumber";
            // 
            // dataGridViewTextBoxColumnAccountingDocumentDate
            // 
            this.dataGridViewTextBoxColumnAccountingDocumentDate.DataPropertyName = "AccountingDocumentDate";
            this.dataGridViewTextBoxColumnAccountingDocumentDate.HeaderText = "AccountingDocumentDate";
            this.dataGridViewTextBoxColumnAccountingDocumentDate.Name = "dataGridViewTextBoxColumnAccountingDocumentDate";
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
            // FormCollectOrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 371);
			this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.collectOrderVwDataGridView);
            this.Controls.Add(this.collectOrderVwBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCollectOrderView";
            this.Text = "View collectOrders";
            this.Load += new System.EventHandler(this.FormCollectOrderView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.collectOrderVwBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collectOrderVwBindingNavigator)).EndInit();
            this.collectOrderVwBindingNavigator.ResumeLayout(false);
            this.collectOrderVwBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.collectOrderVwDataGridView)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource collectOrderVwBindingSource;
        private System.Windows.Forms.BindingNavigator collectOrderVwBindingNavigator;
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
        private System.Windows.Forms.DataGridView collectOrderVwDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnAccountingDocumentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnAccountingDocumentDate;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel slblEllapsedTimeName;
		private System.Windows.Forms.ToolStripStatusLabel slblEllapsedTimeValue;
    }
}
