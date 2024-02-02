namespace HMS.Forms.Billing
{
    partial class AdvPayFrm
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
            System.Windows.Forms.Label payModeLabel;
            System.Windows.Forms.Label payDateLabel;
            System.Windows.Forms.Label advAmtLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label PatidLabel;
            System.Windows.Forms.Label patIDLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvPayFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonIPD = new System.Windows.Forms.Button();
            this.textBoxIPD = new System.Windows.Forms.TextBox();
            this.Savebutton = new System.Windows.Forms.Button();
            this.PatNametextBox = new System.Windows.Forms.TextBox();
            this.PatientidTextBox = new System.Windows.Forms.TextBox();
            this.advAmtTextBox = new System.Windows.Forms.TextBox();
            this.AdvpayDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.printbutton = new System.Windows.Forms.Button();
            this.payModeComboBox = new System.Windows.Forms.ComboBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.iPDBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hMSDataSet = new HMS.HMSDataSet();
            this.iPDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientMastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new HMS.HMSDataSetTableAdapters.TableAdapterManager();
            this.patientMastBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.advanceDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdvAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IPD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            payModeLabel = new System.Windows.Forms.Label();
            payDateLabel = new System.Windows.Forms.Label();
            advAmtLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            PatidLabel = new System.Windows.Forms.Label();
            patIDLabel1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPDBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientMastBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientMastBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advanceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(24, 47);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(77, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "TransactionID:";
            // 
            // payModeLabel
            // 
            payModeLabel.AutoSize = true;
            payModeLabel.Location = new System.Drawing.Point(350, 75);
            payModeLabel.Name = "payModeLabel";
            payModeLabel.Size = new System.Drawing.Size(58, 13);
            payModeLabel.TabIndex = 7;
            payModeLabel.Text = "Pay Mode:";
            // 
            // payDateLabel
            // 
            payDateLabel.AutoSize = true;
            payDateLabel.Location = new System.Drawing.Point(47, 77);
            payDateLabel.Name = "payDateLabel";
            payDateLabel.Size = new System.Drawing.Size(54, 13);
            payDateLabel.TabIndex = 9;
            payDateLabel.Text = "Pay Date:";
            // 
            // advAmtLabel
            // 
            advAmtLabel.AutoSize = true;
            advAmtLabel.Location = new System.Drawing.Point(362, 50);
            advAmtLabel.Name = "advAmtLabel";
            advAmtLabel.Size = new System.Drawing.Size(46, 13);
            advAmtLabel.TabIndex = 11;
            advAmtLabel.Text = "Amount:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(324, 131);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(74, 13);
            label1.TabIndex = 45;
            label1.Text = "Patient Name:";
            // 
            // PatidLabel
            // 
            PatidLabel.AutoSize = true;
            PatidLabel.Location = new System.Drawing.Point(353, 102);
            PatidLabel.Name = "PatidLabel";
            PatidLabel.Size = new System.Drawing.Size(55, 13);
            PatidLabel.TabIndex = 42;
            PatidLabel.Text = "Patient Id:";
            // 
            // patIDLabel1
            // 
            patIDLabel1.AutoSize = true;
            patIDLabel1.Location = new System.Drawing.Point(61, 102);
            patIDLabel1.Name = "patIDLabel1";
            patIDLabel1.Size = new System.Drawing.Size(28, 13);
            patIDLabel1.TabIndex = 46;
            patIDLabel1.Text = "IPD:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonDel);
            this.panel1.Controls.Add(this.buttonIPD);
            this.panel1.Controls.Add(this.textBoxIPD);
            this.panel1.Controls.Add(this.Savebutton);
            this.panel1.Controls.Add(patIDLabel1);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.PatNametextBox);
            this.panel1.Controls.Add(PatidLabel);
            this.panel1.Controls.Add(this.PatientidTextBox);
            this.panel1.Controls.Add(advAmtLabel);
            this.panel1.Controls.Add(this.advAmtTextBox);
            this.panel1.Controls.Add(payDateLabel);
            this.panel1.Controls.Add(this.AdvpayDateDateTimePicker);
            this.panel1.Controls.Add(this.printbutton);
            this.panel1.Controls.Add(payModeLabel);
            this.panel1.Controls.Add(this.payModeComboBox);
            this.panel1.Controls.Add(idLabel);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 168);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(387, 14);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 55;
            this.buttonDel.Text = "Delete";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonIPD
            // 
            this.buttonIPD.Location = new System.Drawing.Point(751, 14);
            this.buttonIPD.Name = "buttonIPD";
            this.buttonIPD.Size = new System.Drawing.Size(75, 23);
            this.buttonIPD.TabIndex = 54;
            this.buttonIPD.Text = "IPD";
            this.buttonIPD.UseVisualStyleBackColor = true;
            this.buttonIPD.Click += new System.EventHandler(this.buttonIPD_Click);
            // 
            // textBoxIPD
            // 
            this.textBoxIPD.Location = new System.Drawing.Point(107, 99);
            this.textBoxIPD.Name = "textBoxIPD";
            this.textBoxIPD.Size = new System.Drawing.Size(203, 20);
            this.textBoxIPD.TabIndex = 53;
            this.textBoxIPD.TextChanged += new System.EventHandler(this.textBoxIPD_TextChanged);
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(140, 14);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(75, 23);
            this.Savebutton.TabIndex = 51;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // PatNametextBox
            // 
            this.PatNametextBox.Location = new System.Drawing.Point(413, 128);
            this.PatNametextBox.Name = "PatNametextBox";
            this.PatNametextBox.ReadOnly = true;
            this.PatNametextBox.Size = new System.Drawing.Size(203, 20);
            this.PatNametextBox.TabIndex = 44;
            // 
            // PatientidTextBox
            // 
            this.PatientidTextBox.Location = new System.Drawing.Point(414, 99);
            this.PatientidTextBox.Name = "PatientidTextBox";
            this.PatientidTextBox.ReadOnly = true;
            this.PatientidTextBox.Size = new System.Drawing.Size(202, 20);
            this.PatientidTextBox.TabIndex = 43;
            // 
            // advAmtTextBox
            // 
            this.advAmtTextBox.Location = new System.Drawing.Point(414, 47);
            this.advAmtTextBox.Name = "advAmtTextBox";
            this.advAmtTextBox.Size = new System.Drawing.Size(203, 20);
            this.advAmtTextBox.TabIndex = 12;
            this.advAmtTextBox.TextChanged += new System.EventHandler(this.advAmtTextBox_TextChanged);
            // 
            // AdvpayDateDateTimePicker
            // 
            this.AdvpayDateDateTimePicker.CustomFormat = "dd-mm-yyyy";
            this.AdvpayDateDateTimePicker.Location = new System.Drawing.Point(107, 73);
            this.AdvpayDateDateTimePicker.Name = "AdvpayDateDateTimePicker";
            this.AdvpayDateDateTimePicker.Size = new System.Drawing.Size(203, 20);
            this.AdvpayDateDateTimePicker.TabIndex = 10;
            this.AdvpayDateDateTimePicker.ValueChanged += new System.EventHandler(this.payDateDateTimePicker_ValueChanged);
            // 
            // printbutton
            // 
            this.printbutton.Location = new System.Drawing.Point(267, 14);
            this.printbutton.Name = "printbutton";
            this.printbutton.Size = new System.Drawing.Size(75, 23);
            this.printbutton.TabIndex = 9;
            this.printbutton.Text = "Print";
            this.printbutton.UseVisualStyleBackColor = true;
            this.printbutton.Click += new System.EventHandler(this.printbutton_Click);
            // 
            // payModeComboBox
            // 
            this.payModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.payModeComboBox.FormattingEnabled = true;
            this.payModeComboBox.Items.AddRange(new object[] {
            "UPI",
            "Cash",
            "Card",
            "Bank Transfer",
            "Cheque"});
            this.payModeComboBox.Location = new System.Drawing.Point(414, 72);
            this.payModeComboBox.Name = "payModeComboBox";
            this.payModeComboBox.Size = new System.Drawing.Size(203, 21);
            this.payModeComboBox.TabIndex = 8;
            this.payModeComboBox.SelectedIndexChanged += new System.EventHandler(this.payModeComboBox_SelectedIndexChanged);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(107, 47);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(203, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // iPDBindingSource1
            // 
            this.iPDBindingSource1.DataMember = "IPD";
            this.iPDBindingSource1.DataSource = this.hMSDataSet;
            // 
            // hMSDataSet
            // 
            this.hMSDataSet.DataSetName = "HMSDataSet";
            this.hMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iPDBindingSource
            // 
            this.iPDBindingSource.DataMember = "IPD";
            this.iPDBindingSource.DataSource = this.hMSDataSet;
            // 
            // advanceBindingSource
            // 
            this.advanceBindingSource.DataMember = "Advance";
            this.advanceBindingSource.DataSource = this.hMSDataSet;
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
            this.tableAdapterManager.FinalBillDrTableAdapter = null;
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
            // patientMastBindingSource1
            // 
            this.patientMastBindingSource1.DataMember = "PatientMast";
            this.patientMastBindingSource1.DataSource = this.hMSDataSet;
            // 
            // advanceDataGridView
            // 
            this.advanceDataGridView.AllowUserToAddRows = false;
            this.advanceDataGridView.AllowUserToDeleteRows = false;
            this.advanceDataGridView.AllowUserToOrderColumns = true;
            this.advanceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.advanceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PayDate,
            this.PatientID,
            this.Patient,
            this.AdvAmt,
            this.PayMode,
            this.IPD});
            this.advanceDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.advanceDataGridView.Location = new System.Drawing.Point(0, 168);
            this.advanceDataGridView.Name = "advanceDataGridView";
            this.advanceDataGridView.ReadOnly = true;
            this.advanceDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.advanceDataGridView.Size = new System.Drawing.Size(838, 299);
            this.advanceDataGridView.TabIndex = 2;
            this.advanceDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.advanceDataGridView_CellContentClick);
            this.advanceDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.advanceDataGridView_MouseDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // PayDate
            // 
            this.PayDate.HeaderText = "PayDate";
            this.PayDate.Name = "PayDate";
            this.PayDate.ReadOnly = true;
            // 
            // PatientID
            // 
            this.PatientID.HeaderText = "PatientID";
            this.PatientID.Name = "PatientID";
            this.PatientID.ReadOnly = true;
            // 
            // Patient
            // 
            this.Patient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Patient.HeaderText = "Patient";
            this.Patient.Name = "Patient";
            this.Patient.ReadOnly = true;
            // 
            // AdvAmt
            // 
            this.AdvAmt.HeaderText = "AdvAmt";
            this.AdvAmt.Name = "AdvAmt";
            this.AdvAmt.ReadOnly = true;
            // 
            // PayMode
            // 
            this.PayMode.HeaderText = "PayMode";
            this.PayMode.Name = "PayMode";
            this.PayMode.ReadOnly = true;
            // 
            // IPD
            // 
            this.IPD.HeaderText = "IPD";
            this.IPD.Name = "IPD";
            this.IPD.ReadOnly = true;
            // 
            // AdvPayFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 467);
            this.Controls.Add(this.advanceDataGridView);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdvPayFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advance Payment";
            this.Load += new System.EventHandler(this.AdvPayFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iPDBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientMastBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientMastBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advanceDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HMSDataSet hMSDataSet;
        private System.Windows.Forms.BindingSource advanceBindingSource;
        private HMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.ComboBox payModeComboBox;
        private System.Windows.Forms.BindingSource patientMastBindingSource;
        private System.Windows.Forms.DateTimePicker AdvpayDateDateTimePicker;
        private System.Windows.Forms.BindingSource patientMastBindingSource1;
        private System.Windows.Forms.TextBox advAmtTextBox;
        private System.Windows.Forms.BindingSource iPDBindingSource;
        private System.Windows.Forms.TextBox PatNametextBox;
        private System.Windows.Forms.TextBox PatientidTextBox;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Button printbutton;
        private System.Windows.Forms.DataGridView advanceDataGridView;
        private System.Windows.Forms.BindingSource iPDBindingSource1;
        private System.Windows.Forms.TextBox textBoxIPD;
        private System.Windows.Forms.Button buttonIPD;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdvAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPD;
    }
}