namespace HMS.Forms.Master
{
    partial class DoctorDepartmentFrm
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
            System.Windows.Forms.Label departmentNameLabel;
            System.Windows.Forms.Label idLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorDepartmentFrm));
            this.hMSDataSet = new HMS.HMSDataSet();
            this.doctorDepartmentMastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorDepartmentMastTableAdapter = new HMS.HMSDataSetTableAdapters.DoctorDepartmentMastTableAdapter();
            this.tableAdapterManager = new HMS.HMSDataSetTableAdapters.TableAdapterManager();
            this.doctorDepartmentMastBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.doctorDepartmentMastBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.departmentNameTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            departmentNameLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDepartmentMastBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDepartmentMastBindingNavigator)).BeginInit();
            this.doctorDepartmentMastBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // departmentNameLabel
            // 
            departmentNameLabel.AutoSize = true;
            departmentNameLabel.Location = new System.Drawing.Point(7, 35);
            departmentNameLabel.Name = "departmentNameLabel";
            departmentNameLabel.Size = new System.Drawing.Size(96, 13);
            departmentNameLabel.TabIndex = 5;
            departmentNameLabel.Text = "Department Name:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(84, 9);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 6;
            idLabel.Text = "Id:";
            // 
            // hMSDataSet
            // 
            this.hMSDataSet.DataSetName = "HMSDataSet";
            this.hMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorDepartmentMastBindingSource
            // 
            this.doctorDepartmentMastBindingSource.DataMember = "DoctorDepartmentMast";
            this.doctorDepartmentMastBindingSource.DataSource = this.hMSDataSet;
            // 
            // doctorDepartmentMastTableAdapter
            // 
            this.doctorDepartmentMastTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.DoctorDepartmentMastTableAdapter = this.doctorDepartmentMastTableAdapter;
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
            this.tableAdapterManager.TaxMastTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HMS.HMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // doctorDepartmentMastBindingNavigator
            // 
            this.doctorDepartmentMastBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.doctorDepartmentMastBindingNavigator.BindingSource = this.doctorDepartmentMastBindingSource;
            this.doctorDepartmentMastBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.doctorDepartmentMastBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.doctorDepartmentMastBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.doctorDepartmentMastBindingNavigatorSaveItem});
            this.doctorDepartmentMastBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.doctorDepartmentMastBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.doctorDepartmentMastBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.doctorDepartmentMastBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.doctorDepartmentMastBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.doctorDepartmentMastBindingNavigator.Name = "doctorDepartmentMastBindingNavigator";
            this.doctorDepartmentMastBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.doctorDepartmentMastBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.doctorDepartmentMastBindingNavigator.TabIndex = 5;
            this.doctorDepartmentMastBindingNavigator.Text = "bindingNavigator1";
            this.doctorDepartmentMastBindingNavigator.RefreshItems += new System.EventHandler(this.doctorDepartmentMastBindingNavigator_RefreshItems);
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
            this.bindingNavigatorPositionItem.Click += new System.EventHandler(this.bindingNavigatorPositionItem_Click);
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
            // doctorDepartmentMastBindingNavigatorSaveItem
            // 
            this.doctorDepartmentMastBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.doctorDepartmentMastBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("doctorDepartmentMastBindingNavigatorSaveItem.Image")));
            this.doctorDepartmentMastBindingNavigatorSaveItem.Name = "doctorDepartmentMastBindingNavigatorSaveItem";
            this.doctorDepartmentMastBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.doctorDepartmentMastBindingNavigatorSaveItem.Text = "Save Data";
            this.doctorDepartmentMastBindingNavigatorSaveItem.Click += new System.EventHandler(this.doctorDepartmentMastBindingNavigatorSaveItem_Click);
            // 
            // departmentNameTextBox
            // 
            this.departmentNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorDepartmentMastBindingSource, "DepartmentName", true));
            this.departmentNameTextBox.Location = new System.Drawing.Point(109, 32);
            this.departmentNameTextBox.Name = "departmentNameTextBox";
            this.departmentNameTextBox.Size = new System.Drawing.Size(257, 20);
            this.departmentNameTextBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(idLabel);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(this.departmentNameTextBox);
            this.panel1.Controls.Add(departmentNameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 72);
            this.panel1.TabIndex = 7;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorDepartmentMastBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(109, 6);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.departmentNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.doctorDepartmentMastBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(800, 286);
            this.dataGridView1.TabIndex = 8;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 41;
            // 
            // departmentNameDataGridViewTextBoxColumn
            // 
            this.departmentNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departmentNameDataGridViewTextBoxColumn.DataPropertyName = "DepartmentName";
            this.departmentNameDataGridViewTextBoxColumn.HeaderText = "Department Name";
            this.departmentNameDataGridViewTextBoxColumn.Name = "departmentNameDataGridViewTextBoxColumn";
            this.departmentNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DoctorDepartmentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 383);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.doctorDepartmentMastBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "DoctorDepartmentFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Doctor Department";
            this.Load += new System.EventHandler(this.DoctorDepartmentFrm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DoctorDepartmentFrm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDepartmentMastBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDepartmentMastBindingNavigator)).EndInit();
            this.doctorDepartmentMastBindingNavigator.ResumeLayout(false);
            this.doctorDepartmentMastBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private HMSDataSet hMSDataSet;
        private System.Windows.Forms.BindingSource doctorDepartmentMastBindingSource;
        private HMSDataSetTableAdapters.DoctorDepartmentMastTableAdapter doctorDepartmentMastTableAdapter;
        private HMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator doctorDepartmentMastBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton doctorDepartmentMastBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox departmentNameTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentNameDataGridViewTextBoxColumn;
    }
}