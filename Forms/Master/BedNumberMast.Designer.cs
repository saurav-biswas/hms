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
            System.Windows.Forms.Label bedNumberLabel;
            System.Windows.Forms.Label bedTypeLabel1;
            System.Windows.Forms.Label currentStatusLabel1;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BedNumberMast));
            this.hMSDataSet = new HMS.HMSDataSet();
            this.bedNumberMastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new HMS.HMSDataSetTableAdapters.TableAdapterManager();
            this.bedNumberTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDel = new System.Windows.Forms.Button();
            this.textBoxRate = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.currentStatusComboBox = new System.Windows.Forms.ComboBox();
            this.bedTypeComboBox = new System.Windows.Forms.ComboBox();
            this.bedTypeMastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bedNumberMastDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BedNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BedType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedTypeMastTableAdapter = new HMS.HMSDataSetTableAdapters.BedTypeMastTableAdapter();
            bedNumberLabel = new System.Windows.Forms.Label();
            bedTypeLabel1 = new System.Windows.Forms.Label();
            currentStatusLabel1 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedNumberMastBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bedTypeMastBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedNumberMastDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bedNumberLabel
            // 
            bedNumberLabel.AutoSize = true;
            bedNumberLabel.Location = new System.Drawing.Point(13, 54);
            bedNumberLabel.Name = "bedNumberLabel";
            bedNumberLabel.Size = new System.Drawing.Size(69, 13);
            bedNumberLabel.TabIndex = 4;
            bedNumberLabel.Text = "Bed Number:";
            // 
            // bedTypeLabel1
            // 
            bedTypeLabel1.AutoSize = true;
            bedTypeLabel1.Location = new System.Drawing.Point(26, 80);
            bedTypeLabel1.Name = "bedTypeLabel1";
            bedTypeLabel1.Size = new System.Drawing.Size(56, 13);
            bedTypeLabel1.TabIndex = 9;
            bedTypeLabel1.Text = "Bed Type:";
            // 
            // currentStatusLabel1
            // 
            currentStatusLabel1.AutoSize = true;
            currentStatusLabel1.Location = new System.Drawing.Point(347, 80);
            currentStatusLabel1.Name = "currentStatusLabel1";
            currentStatusLabel1.Size = new System.Drawing.Size(77, 13);
            currentStatusLabel1.TabIndex = 10;
            currentStatusLabel1.Text = "Current Status:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(347, 54);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(33, 13);
            label1.TabIndex = 13;
            label1.Text = "Rate:";
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdvanceTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BedManagementTableAdapter = null;
            this.tableAdapterManager.BedNumberMastTableAdapter = null;
            this.tableAdapterManager.BedTypeMastTableAdapter = null;
            this.tableAdapterManager.BloodGroupMastTableAdapter = null;
            this.tableAdapterManager.Connection = null;
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
            this.tableAdapterManager.TaxMastTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HMS.HMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // bedNumberTextBox
            // 
            this.bedNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bedNumberMastBindingSource, "BedNumber", true));
            this.bedNumberTextBox.Location = new System.Drawing.Point(88, 51);
            this.bedNumberTextBox.Name = "bedNumberTextBox";
            this.bedNumberTextBox.Size = new System.Drawing.Size(121, 20);
            this.bedNumberTextBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonDel);
            this.panel1.Controls.Add(this.textBoxRate);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(currentStatusLabel1);
            this.panel1.Controls.Add(this.currentStatusComboBox);
            this.panel1.Controls.Add(bedTypeLabel1);
            this.panel1.Controls.Add(this.bedTypeComboBox);
            this.panel1.Controls.Add(this.bedNumberTextBox);
            this.panel1.Controls.Add(bedNumberLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 129);
            this.panel1.TabIndex = 12;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(339, 10);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 106;
            this.buttonDel.Text = "Delete";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // textBoxRate
            // 
            this.textBoxRate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bedNumberMastBindingSource, "BedNumber", true));
            this.textBoxRate.Location = new System.Drawing.Point(430, 51);
            this.textBoxRate.Name = "textBoxRate";
            this.textBoxRate.Size = new System.Drawing.Size(121, 20);
            this.textBoxRate.TabIndex = 12;
            this.textBoxRate.Text = "0";
            this.textBoxRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(134, 10);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // currentStatusComboBox
            // 
            this.currentStatusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bedNumberMastBindingSource, "CurrentStatus", true));
            this.currentStatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currentStatusComboBox.FormattingEnabled = true;
            this.currentStatusComboBox.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.currentStatusComboBox.Location = new System.Drawing.Point(430, 77);
            this.currentStatusComboBox.Name = "currentStatusComboBox";
            this.currentStatusComboBox.Size = new System.Drawing.Size(121, 21);
            this.currentStatusComboBox.TabIndex = 3;
            // 
            // bedTypeComboBox
            // 
            this.bedTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bedNumberMastBindingSource, "BedType", true));
            this.bedTypeComboBox.DataSource = this.bedTypeMastBindingSource;
            this.bedTypeComboBox.DisplayMember = "BedType";
            this.bedTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bedTypeComboBox.FormattingEnabled = true;
            this.bedTypeComboBox.Location = new System.Drawing.Point(88, 77);
            this.bedTypeComboBox.Name = "bedTypeComboBox";
            this.bedTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.bedTypeComboBox.TabIndex = 2;
            this.bedTypeComboBox.ValueMember = "BedType";
            // 
            // bedTypeMastBindingSource
            // 
            this.bedTypeMastBindingSource.DataMember = "BedTypeMast";
            this.bedTypeMastBindingSource.DataSource = this.hMSDataSet;
            // 
            // bedNumberMastDataGridView
            // 
            this.bedNumberMastDataGridView.AllowUserToAddRows = false;
            this.bedNumberMastDataGridView.AllowUserToDeleteRows = false;
            this.bedNumberMastDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bedNumberMastDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.BedNumber,
            this.BedType,
            this.CurrentStatus,
            this.Rate});
            this.bedNumberMastDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bedNumberMastDataGridView.Location = new System.Drawing.Point(0, 129);
            this.bedNumberMastDataGridView.Name = "bedNumberMastDataGridView";
            this.bedNumberMastDataGridView.ReadOnly = true;
            this.bedNumberMastDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bedNumberMastDataGridView.Size = new System.Drawing.Size(561, 321);
            this.bedNumberMastDataGridView.TabIndex = 12;
            this.bedNumberMastDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.bedNumberMastDataGridView_MouseDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // BedNumber
            // 
            this.BedNumber.HeaderText = "BedNumber";
            this.BedNumber.Name = "BedNumber";
            this.BedNumber.ReadOnly = true;
            // 
            // BedType
            // 
            this.BedType.HeaderText = "BedType";
            this.BedType.Name = "BedType";
            this.BedType.ReadOnly = true;
            // 
            // CurrentStatus
            // 
            this.CurrentStatus.HeaderText = "CurrentStatus";
            this.CurrentStatus.Name = "CurrentStatus";
            this.CurrentStatus.ReadOnly = true;
            // 
            // Rate
            // 
            this.Rate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            // 
            // bedTypeMastTableAdapter
            // 
            this.bedTypeMastTableAdapter.ClearBeforeFill = true;
            // 
            // BedNumberMast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 450);
            this.Controls.Add(this.bedNumberMastDataGridView);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "BedNumberMast";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bed Number Master";
            this.Load += new System.EventHandler(this.BedNumberMast_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BedNumberMast_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedNumberMastBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bedTypeMastBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedNumberMastDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HMSDataSet hMSDataSet;
        private System.Windows.Forms.BindingSource bedNumberMastBindingSource;
        private HMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox bedNumberTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView bedNumberMastDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ComboBox currentStatusComboBox;
        private System.Windows.Forms.ComboBox bedTypeComboBox;
        private System.Windows.Forms.BindingSource bedTypeMastBindingSource;
        private HMSDataSetTableAdapters.BedTypeMastTableAdapter bedTypeMastTableAdapter;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxRate;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn BedNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn BedType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
    }
}