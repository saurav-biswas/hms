namespace HMS.Forms.Master
{
    partial class TaxMast
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label percentageLabel;
            System.Windows.Forms.Label taxNameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaxMast));
            this.hMSDataSet = new HMS.HMSDataSet();
            this.taxMastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taxMastTableAdapter = new HMS.HMSDataSetTableAdapters.TaxMastTableAdapter();
            this.tableAdapterManager = new HMS.HMSDataSetTableAdapters.TableAdapterManager();
            this.taxMastBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.taxMastBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.taxNameTextBox = new System.Windows.Forms.TextBox();
            this.percentageTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.taxMastDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            percentageLabel = new System.Windows.Forms.Label();
            taxNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxMastBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxMastBindingNavigator)).BeginInit();
            this.taxMastBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taxMastDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(62, 17);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // percentageLabel
            // 
            percentageLabel.AutoSize = true;
            percentageLabel.Location = new System.Drawing.Point(16, 43);
            percentageLabel.Name = "percentageLabel";
            percentageLabel.Size = new System.Drawing.Size(65, 13);
            percentageLabel.TabIndex = 2;
            percentageLabel.Text = "Percentage:";
            // 
            // taxNameLabel
            // 
            taxNameLabel.AutoSize = true;
            taxNameLabel.Location = new System.Drawing.Point(22, 69);
            taxNameLabel.Name = "taxNameLabel";
            taxNameLabel.Size = new System.Drawing.Size(59, 13);
            taxNameLabel.TabIndex = 4;
            taxNameLabel.Text = "Tax Name:";
            // 
            // hMSDataSet
            // 
            this.hMSDataSet.DataSetName = "HMSDataSet";
            this.hMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taxMastBindingSource
            // 
            this.taxMastBindingSource.DataMember = "TaxMast";
            this.taxMastBindingSource.DataSource = this.hMSDataSet;
            // 
            // taxMastTableAdapter
            // 
            this.taxMastTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdvanceTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BedManagementTableAdapter = null;
            this.tableAdapterManager.BedNumberMastTableAdapter = null;
            this.tableAdapterManager.BedTypeMastTableAdapter = null;
            this.tableAdapterManager.BloodGroupMastTableAdapter = null;
            this.tableAdapterManager.DischargeLinTableAdapter = null;
            this.tableAdapterManager.DischargeTableAdapter = null;
            this.tableAdapterManager.DisposableIssHdrTableAdapter = null;
            this.tableAdapterManager.DisposableIssLinTableAdapter = null;
            this.tableAdapterManager.DoctorDepartmentMastTableAdapter = null;
            this.tableAdapterManager.DoctorMastTableAdapter = null;
            this.tableAdapterManager.FinalBillHdrTableAdapter = null;
            this.tableAdapterManager.FinalBillOtherAmountTableAdapter = null;
            this.tableAdapterManager.GRNHdrTableAdapter = null;
            this.tableAdapterManager.GRNLinTableAdapter = null;
            this.tableAdapterManager.IPDTableAdapter = null;
            this.tableAdapterManager.ItCatMastTableAdapter = null;
            this.tableAdapterManager.ItMastTableAdapter = null;
            this.tableAdapterManager.OPDTableAdapter = null;
            this.tableAdapterManager.PatientMastTableAdapter = null;
            this.tableAdapterManager.PrescriptionTableAdapter = null;
            this.tableAdapterManager.PresMedTableAdapter = null;
            this.tableAdapterManager.SuppMastTableAdapter = null;
            this.tableAdapterManager.TaxMastTableAdapter = this.taxMastTableAdapter;
            this.tableAdapterManager.UpdateOrder = HMS.HMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // taxMastBindingNavigator
            // 
            this.taxMastBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.taxMastBindingNavigator.BindingSource = this.taxMastBindingSource;
            this.taxMastBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.taxMastBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.taxMastBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.taxMastBindingNavigatorSaveItem});
            this.taxMastBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.taxMastBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.taxMastBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.taxMastBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.taxMastBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.taxMastBindingNavigator.Name = "taxMastBindingNavigator";
            this.taxMastBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.taxMastBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.taxMastBindingNavigator.TabIndex = 0;
            this.taxMastBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            // taxMastBindingNavigatorSaveItem
            // 
            this.taxMastBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.taxMastBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("taxMastBindingNavigatorSaveItem.Image")));
            this.taxMastBindingNavigatorSaveItem.Name = "taxMastBindingNavigatorSaveItem";
            this.taxMastBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.taxMastBindingNavigatorSaveItem.Text = "Save Data";
            this.taxMastBindingNavigatorSaveItem.Click += new System.EventHandler(this.taxMastBindingNavigatorSaveItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(taxNameLabel);
            this.panel1.Controls.Add(this.taxNameTextBox);
            this.panel1.Controls.Add(percentageLabel);
            this.panel1.Controls.Add(this.percentageTextBox);
            this.panel1.Controls.Add(idLabel);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 2;
            // 
            // taxNameTextBox
            // 
            this.taxNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taxMastBindingSource, "TaxName", true));
            this.taxNameTextBox.Location = new System.Drawing.Point(87, 66);
            this.taxNameTextBox.Name = "taxNameTextBox";
            this.taxNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.taxNameTextBox.TabIndex = 2;
            // 
            // percentageTextBox
            // 
            this.percentageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taxMastBindingSource, "Percentage", true));
            this.percentageTextBox.Location = new System.Drawing.Point(87, 40);
            this.percentageTextBox.Name = "percentageTextBox";
            this.percentageTextBox.Size = new System.Drawing.Size(100, 20);
            this.percentageTextBox.TabIndex = 1;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taxMastBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(87, 14);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 0;
            // 
            // taxMastDataGridView
            // 
            this.taxMastDataGridView.AutoGenerateColumns = false;
            this.taxMastDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taxMastDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.taxMastDataGridView.DataSource = this.taxMastBindingSource;
            this.taxMastDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taxMastDataGridView.Location = new System.Drawing.Point(0, 125);
            this.taxMastDataGridView.Name = "taxMastDataGridView";
            this.taxMastDataGridView.Size = new System.Drawing.Size(800, 349);
            this.taxMastDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Percentage";
            this.dataGridViewTextBoxColumn2.HeaderText = "Percentage";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "TaxName";
            this.dataGridViewTextBoxColumn3.HeaderText = "TaxName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // TaxMast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.taxMastDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.taxMastBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "TaxMast";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tax Master";
            this.Load += new System.EventHandler(this.TaxMast_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TaxMast_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxMastBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxMastBindingNavigator)).EndInit();
            this.taxMastBindingNavigator.ResumeLayout(false);
            this.taxMastBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taxMastDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HMSDataSet hMSDataSet;
        private System.Windows.Forms.BindingSource taxMastBindingSource;
        private HMSDataSetTableAdapters.TaxMastTableAdapter taxMastTableAdapter;
        private HMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator taxMastBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton taxMastBindingNavigatorSaveItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox taxNameTextBox;
        private System.Windows.Forms.TextBox percentageTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.DataGridView taxMastDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}