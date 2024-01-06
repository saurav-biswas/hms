namespace HMS.Forms.Master
{
    partial class BedNumberMast
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
            System.Windows.Forms.Label bedNumberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BedNumberMast));
            System.Windows.Forms.Label bedTypeLabel1;
            System.Windows.Forms.Label currentStatusLabel1;
            this.hMSDataSet = new HMS.HMSDataSet();
            this.bedNumberMastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bedNumberMastTableAdapter = new HMS.HMSDataSetTableAdapters.BedNumberMastTableAdapter();
            this.tableAdapterManager = new HMS.HMSDataSetTableAdapters.TableAdapterManager();
            this.bedNumberMastBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bedNumberMastBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.bedNumberTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bedNumberMastDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedTypeComboBox = new System.Windows.Forms.ComboBox();
            this.currentStatusComboBox = new System.Windows.Forms.ComboBox();
            this.bedTypeMastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bedTypeMastTableAdapter = new HMS.HMSDataSetTableAdapters.BedTypeMastTableAdapter();
            idLabel = new System.Windows.Forms.Label();
            bedNumberLabel = new System.Windows.Forms.Label();
            bedTypeLabel1 = new System.Windows.Forms.Label();
            currentStatusLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedNumberMastBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedNumberMastBindingNavigator)).BeginInit();
            this.bedNumberMastBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bedNumberMastDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedTypeMastBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(63, 16);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 2;
            idLabel.Text = "Id:";
            // 
            // bedNumberLabel
            // 
            bedNumberLabel.AutoSize = true;
            bedNumberLabel.Location = new System.Drawing.Point(13, 40);
            bedNumberLabel.Name = "bedNumberLabel";
            bedNumberLabel.Size = new System.Drawing.Size(69, 13);
            bedNumberLabel.TabIndex = 4;
            bedNumberLabel.Text = "Bed Number:";
            // 
            // hMSDataSet
            // 
            this.hMSDataSet.DataSetName = "HMSDataSet";
            this.hMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bedNumberMastBindingSource
            // 
            this.bedNumberMastBindingSource.DataMember = "BedNumberMast";
            this.bedNumberMastBindingSource.DataSource = this.hMSDataSet;
            // 
            // bedNumberMastTableAdapter
            // 
            this.bedNumberMastTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BedNumberMastTableAdapter = this.bedNumberMastTableAdapter;
            this.tableAdapterManager.BedTypeMastTableAdapter = null;
            this.tableAdapterManager.BloodGroupMastTableAdapter = null;
            this.tableAdapterManager.DoctorDepartmentMastTableAdapter = null;
            this.tableAdapterManager.DoctorMastTableAdapter = null;
            this.tableAdapterManager.PatientMastTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HMS.HMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bedNumberMastBindingNavigator
            // 
            this.bedNumberMastBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bedNumberMastBindingNavigator.BindingSource = this.bedNumberMastBindingSource;
            this.bedNumberMastBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bedNumberMastBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bedNumberMastBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bedNumberMastBindingNavigatorSaveItem});
            this.bedNumberMastBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bedNumberMastBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bedNumberMastBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bedNumberMastBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bedNumberMastBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bedNumberMastBindingNavigator.Name = "bedNumberMastBindingNavigator";
            this.bedNumberMastBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bedNumberMastBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.bedNumberMastBindingNavigator.TabIndex = 0;
            this.bedNumberMastBindingNavigator.Text = "bindingNavigator1";
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
            // bedNumberMastBindingNavigatorSaveItem
            // 
            this.bedNumberMastBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bedNumberMastBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bedNumberMastBindingNavigatorSaveItem.Image")));
            this.bedNumberMastBindingNavigatorSaveItem.Name = "bedNumberMastBindingNavigatorSaveItem";
            this.bedNumberMastBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.bedNumberMastBindingNavigatorSaveItem.Text = "Save Data";
            this.bedNumberMastBindingNavigatorSaveItem.Click += new System.EventHandler(this.bedNumberMastBindingNavigatorSaveItem_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bedNumberMastBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(88, 13);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(121, 20);
            this.idTextBox.TabIndex = 3;
            // 
            // bedNumberTextBox
            // 
            this.bedNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bedNumberMastBindingSource, "BedNumber", true));
            this.bedNumberTextBox.Location = new System.Drawing.Point(88, 37);
            this.bedNumberTextBox.Name = "bedNumberTextBox";
            this.bedNumberTextBox.Size = new System.Drawing.Size(121, 20);
            this.bedNumberTextBox.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(currentStatusLabel1);
            this.panel1.Controls.Add(this.currentStatusComboBox);
            this.panel1.Controls.Add(bedTypeLabel1);
            this.panel1.Controls.Add(this.bedTypeComboBox);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(idLabel);
            this.panel1.Controls.Add(this.bedNumberTextBox);
            this.panel1.Controls.Add(bedNumberLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 104);
            this.panel1.TabIndex = 12;
            // 
            // bedNumberMastDataGridView
            // 
            this.bedNumberMastDataGridView.AutoGenerateColumns = false;
            this.bedNumberMastDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bedNumberMastDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.bedNumberMastDataGridView.DataSource = this.bedNumberMastBindingSource;
            this.bedNumberMastDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bedNumberMastDataGridView.Location = new System.Drawing.Point(0, 129);
            this.bedNumberMastDataGridView.Name = "bedNumberMastDataGridView";
            this.bedNumberMastDataGridView.Size = new System.Drawing.Size(800, 321);
            this.bedNumberMastDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BedNumber";
            this.dataGridViewTextBoxColumn2.HeaderText = "BedNumber";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "BedType";
            this.dataGridViewTextBoxColumn3.HeaderText = "BedType";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CurrentStatus";
            this.dataGridViewTextBoxColumn4.HeaderText = "CurrentStatus";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // bedTypeLabel1
            // 
            bedTypeLabel1.AutoSize = true;
            bedTypeLabel1.Location = new System.Drawing.Point(26, 66);
            bedTypeLabel1.Name = "bedTypeLabel1";
            bedTypeLabel1.Size = new System.Drawing.Size(56, 13);
            bedTypeLabel1.TabIndex = 9;
            bedTypeLabel1.Text = "Bed Type:";
            // 
            // bedTypeComboBox
            // 
            this.bedTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bedNumberMastBindingSource, "BedType", true));
            this.bedTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bedTypeMastBindingSource, "BedType", true));
            this.bedTypeComboBox.DataSource = this.bedTypeMastBindingSource;
            this.bedTypeComboBox.DisplayMember = "BedType";
            this.bedTypeComboBox.FormattingEnabled = true;
            this.bedTypeComboBox.Location = new System.Drawing.Point(88, 63);
            this.bedTypeComboBox.Name = "bedTypeComboBox";
            this.bedTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.bedTypeComboBox.TabIndex = 10;
            this.bedTypeComboBox.ValueMember = "BedType";
            // 
            // currentStatusLabel1
            // 
            currentStatusLabel1.AutoSize = true;
            currentStatusLabel1.Location = new System.Drawing.Point(349, 16);
            currentStatusLabel1.Name = "currentStatusLabel1";
            currentStatusLabel1.Size = new System.Drawing.Size(77, 13);
            currentStatusLabel1.TabIndex = 10;
            currentStatusLabel1.Text = "Current Status:";
            // 
            // currentStatusComboBox
            // 
            this.currentStatusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bedNumberMastBindingSource, "CurrentStatus", true));
            this.currentStatusComboBox.FormattingEnabled = true;
            this.currentStatusComboBox.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.currentStatusComboBox.Location = new System.Drawing.Point(432, 13);
            this.currentStatusComboBox.Name = "currentStatusComboBox";
            this.currentStatusComboBox.Size = new System.Drawing.Size(121, 21);
            this.currentStatusComboBox.TabIndex = 11;
            // 
            // bedTypeMastBindingSource
            // 
            this.bedTypeMastBindingSource.DataMember = "BedTypeMast";
            this.bedTypeMastBindingSource.DataSource = this.hMSDataSet;
            // 
            // bedTypeMastTableAdapter
            // 
            this.bedTypeMastTableAdapter.ClearBeforeFill = true;
            // 
            // BedNumberMast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bedNumberMastDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bedNumberMastBindingNavigator);
            this.Name = "BedNumberMast";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bed Number Master";
            this.Load += new System.EventHandler(this.BedNumberMast_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedNumberMastBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedNumberMastBindingNavigator)).EndInit();
            this.bedNumberMastBindingNavigator.ResumeLayout(false);
            this.bedNumberMastBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bedNumberMastDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedTypeMastBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HMSDataSet hMSDataSet;
        private System.Windows.Forms.BindingSource bedNumberMastBindingSource;
        private HMSDataSetTableAdapters.BedNumberMastTableAdapter bedNumberMastTableAdapter;
        private HMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bedNumberMastBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton bedNumberMastBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox bedNumberTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView bedNumberMastDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ComboBox currentStatusComboBox;
        private System.Windows.Forms.ComboBox bedTypeComboBox;
        private System.Windows.Forms.BindingSource bedTypeMastBindingSource;
        private HMSDataSetTableAdapters.BedTypeMastTableAdapter bedTypeMastTableAdapter;
    }
}