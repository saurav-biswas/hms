using System;

namespace HMS.Forms.Transaction
{
    partial class BedMangFrm
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
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.Label BedIssDtLabel;
            System.Windows.Forms.Label DoctorNameLabel;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label bedTypeLabel;
            System.Windows.Forms.Label bedNumberLabel;
            System.Windows.Forms.Label bedRateLabel;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BedMangFrm));
            this.Savebutton = new System.Windows.Forms.Button();
            this.IPDSearchtextBox = new System.Windows.Forms.TextBox();
            this.AdmissiondateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dischargeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hMSDataSet = new HMS.HMSDataSet();
            this.patientMastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iPDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iPDTableAdapter = new HMS.HMSDataSetTableAdapters.IPDTableAdapter();
            this.GendertextBox = new System.Windows.Forms.TextBox();
            this.AgetextBox = new System.Windows.Forms.TextBox();
            this.FromDtDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dischargeTableAdapter = new HMS.HMSDataSetTableAdapters.DischargeTableAdapter();
            this.tableAdapterManager = new HMS.HMSDataSetTableAdapters.TableAdapterManager();
            this.patientMastTableAdapter = new HMS.HMSDataSetTableAdapters.PatientMastTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonIPD = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.DoctorNameComboBox = new System.Windows.Forms.ComboBox();
            this.doctorMastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DaystextBox = new System.Windows.Forms.TextBox();
            this.ToDtdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.BedAmounttextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.BedRateTextBox = new System.Windows.Forms.TextBox();
            this.bedNumberMastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bedNoComboBox = new System.Windows.Forms.ComboBox();
            this.bedTypeComboBox = new System.Windows.Forms.ComboBox();
            this.bedTypeMastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PatientNametextBox = new System.Windows.Forms.TextBox();
            this.bedTypeMastTableAdapter = new HMS.HMSDataSetTableAdapters.BedTypeMastTableAdapter();
            this.bedNumberMastTableAdapter = new HMS.HMSDataSetTableAdapters.BedNumberMastTableAdapter();
            this.BedManagedataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IPD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FromDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BedType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BedNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Todate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Days = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BedAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedManagementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorDepartmentMastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorDepartmentMastTableAdapter = new HMS.HMSDataSetTableAdapters.DoctorDepartmentMastTableAdapter();
            this.doctorMastTableAdapter = new HMS.HMSDataSetTableAdapters.DoctorMastTableAdapter();
            label5 = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            BedIssDtLabel = new System.Windows.Forms.Label();
            DoctorNameLabel = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            bedTypeLabel = new System.Windows.Forms.Label();
            bedNumberLabel = new System.Windows.Forms.Label();
            bedRateLabel = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dischargeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientMastBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPDBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorMastBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedNumberMastBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedTypeMastBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BedManagedataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedManagementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDepartmentMastBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(10, 198);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(83, 13);
            label5.TabIndex = 62;
            label5.Text = "Admission Date:";
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(66, 90);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(28, 13);
            idLabel1.TabIndex = 46;
            idLabel1.Text = "IPD:";
            // 
            // BedIssDtLabel
            // 
            BedIssDtLabel.AutoSize = true;
            BedIssDtLabel.Location = new System.Drawing.Point(396, 64);
            BedIssDtLabel.Name = "BedIssDtLabel";
            BedIssDtLabel.Size = new System.Drawing.Size(83, 13);
            BedIssDtLabel.TabIndex = 11;
            BedIssDtLabel.Text = "Bed Issue Date:";
            // 
            // DoctorNameLabel
            // 
            DoctorNameLabel.AutoSize = true;
            DoctorNameLabel.Location = new System.Drawing.Point(51, 167);
            DoctorNameLabel.Name = "DoctorNameLabel";
            DoctorNameLabel.Size = new System.Drawing.Size(42, 13);
            DoctorNameLabel.TabIndex = 4;
            DoctorNameLabel.Text = "Doctor:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(20, 118);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(74, 13);
            label8.TabIndex = 91;
            label8.Text = "Patient Name:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(20, 141);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(75, 13);
            label9.TabIndex = 93;
            label9.Text = "Gender / Age:";
            // 
            // bedTypeLabel
            // 
            bedTypeLabel.AutoSize = true;
            bedTypeLabel.Location = new System.Drawing.Point(417, 90);
            bedTypeLabel.Name = "bedTypeLabel";
            bedTypeLabel.Size = new System.Drawing.Size(56, 13);
            bedTypeLabel.TabIndex = 93;
            bedTypeLabel.Text = "Bed Type:";
            // 
            // bedNumberLabel
            // 
            bedNumberLabel.AutoSize = true;
            bedNumberLabel.Location = new System.Drawing.Point(404, 117);
            bedNumberLabel.Name = "bedNumberLabel";
            bedNumberLabel.Size = new System.Drawing.Size(69, 13);
            bedNumberLabel.TabIndex = 94;
            bedNumberLabel.Text = "Bed Number:";
            // 
            // bedRateLabel
            // 
            bedRateLabel.AutoSize = true;
            bedRateLabel.Location = new System.Drawing.Point(671, 116);
            bedRateLabel.Name = "bedRateLabel";
            bedRateLabel.Size = new System.Drawing.Size(55, 13);
            bedRateLabel.TabIndex = 95;
            bedRateLabel.Text = "Bed Rate:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(13, 69);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(80, 13);
            label10.TabIndex = 97;
            label10.Text = "Transaction ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(644, 66);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(82, 13);
            label1.TabIndex = 101;
            label1.Text = "Bed Clear Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(692, 91);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(34, 13);
            label2.TabIndex = 103;
            label2.Text = "Days:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(680, 141);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(46, 13);
            label3.TabIndex = 104;
            label3.Text = "Amount:";
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(148, 17);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(75, 23);
            this.Savebutton.TabIndex = 8;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // IPDSearchtextBox
            // 
            this.IPDSearchtextBox.Location = new System.Drawing.Point(99, 87);
            this.IPDSearchtextBox.Name = "IPDSearchtextBox";
            this.IPDSearchtextBox.Size = new System.Drawing.Size(203, 20);
            this.IPDSearchtextBox.TabIndex = 1;
            this.IPDSearchtextBox.TextChanged += new System.EventHandler(this.IPDSearchtextBox_TextChanged);
            // 
            // AdmissiondateTimePicker
            // 
            this.AdmissiondateTimePicker.CustomFormat = " ";
            this.AdmissiondateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dischargeBindingSource, "DischargeDate", true));
            this.AdmissiondateTimePicker.Location = new System.Drawing.Point(99, 194);
            this.AdmissiondateTimePicker.Name = "AdmissiondateTimePicker";
            this.AdmissiondateTimePicker.Size = new System.Drawing.Size(203, 20);
            this.AdmissiondateTimePicker.TabIndex = 3;
            // 
            // dischargeBindingSource
            // 
            this.dischargeBindingSource.DataMember = "Discharge";
            this.dischargeBindingSource.DataSource = this.hMSDataSet;
            // 
            // hMSDataSet
            // 
            this.hMSDataSet.DataSetName = "HMSDataSet";
            this.hMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientMastBindingSource
            // 
            this.patientMastBindingSource.DataMember = "PatientMast";
            this.patientMastBindingSource.DataSource = this.hMSDataSet;
            // 
            // iPDBindingSource
            // 
            this.iPDBindingSource.DataMember = "IPD";
            this.iPDBindingSource.DataSource = this.hMSDataSet;
            // 
            // iPDTableAdapter
            // 
            this.iPDTableAdapter.ClearBeforeFill = true;
            // 
            // GendertextBox
            // 
            this.GendertextBox.Location = new System.Drawing.Point(99, 138);
            this.GendertextBox.Name = "GendertextBox";
            this.GendertextBox.ReadOnly = true;
            this.GendertextBox.Size = new System.Drawing.Size(132, 20);
            this.GendertextBox.TabIndex = 52;
            // 
            // AgetextBox
            // 
            this.AgetextBox.Location = new System.Drawing.Point(237, 138);
            this.AgetextBox.Name = "AgetextBox";
            this.AgetextBox.ReadOnly = true;
            this.AgetextBox.Size = new System.Drawing.Size(65, 20);
            this.AgetextBox.TabIndex = 50;
            // 
            // FromDtDateTimePicker
            // 
            this.FromDtDateTimePicker.CustomFormat = " ";
            this.FromDtDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dischargeBindingSource, "DischargeDate", true));
            this.FromDtDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FromDtDateTimePicker.Location = new System.Drawing.Point(479, 62);
            this.FromDtDateTimePicker.Name = "FromDtDateTimePicker";
            this.FromDtDateTimePicker.Size = new System.Drawing.Size(114, 20);
            this.FromDtDateTimePicker.TabIndex = 4;
            // 
            // dischargeTableAdapter
            // 
            this.dischargeTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.DischargeTableAdapter = this.dischargeTableAdapter;
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
            this.tableAdapterManager.PatientMastTableAdapter = this.patientMastTableAdapter;
            this.tableAdapterManager.PrescriptionTableAdapter = null;
            this.tableAdapterManager.PresMedTableAdapter = null;
            this.tableAdapterManager.SuppMastTableAdapter = null;
            this.tableAdapterManager.TaxMastTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HMS.HMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // patientMastTableAdapter
            // 
            this.patientMastTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonIPD);
            this.panel1.Controls.Add(this.buttonDel);
            this.panel1.Controls.Add(this.DoctorNameComboBox);
            this.panel1.Controls.Add(label3);
            this.panel1.Controls.Add(label2);
            this.panel1.Controls.Add(this.DaystextBox);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.ToDtdateTimePicker);
            this.panel1.Controls.Add(this.BedAmounttextBox);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(label10);
            this.panel1.Controls.Add(bedRateLabel);
            this.panel1.Controls.Add(this.BedRateTextBox);
            this.panel1.Controls.Add(bedNumberLabel);
            this.panel1.Controls.Add(this.bedNoComboBox);
            this.panel1.Controls.Add(bedTypeLabel);
            this.panel1.Controls.Add(this.bedTypeComboBox);
            this.panel1.Controls.Add(label9);
            this.panel1.Controls.Add(label8);
            this.panel1.Controls.Add(this.PatientNametextBox);
            this.panel1.Controls.Add(this.Savebutton);
            this.panel1.Controls.Add(this.IPDSearchtextBox);
            this.panel1.Controls.Add(label5);
            this.panel1.Controls.Add(this.AdmissiondateTimePicker);
            this.panel1.Controls.Add(this.GendertextBox);
            this.panel1.Controls.Add(this.AgetextBox);
            this.panel1.Controls.Add(idLabel1);
            this.panel1.Controls.Add(BedIssDtLabel);
            this.panel1.Controls.Add(this.FromDtDateTimePicker);
            this.panel1.Controls.Add(DoctorNameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 253);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonIPD
            // 
            this.buttonIPD.Location = new System.Drawing.Point(773, 12);
            this.buttonIPD.Name = "buttonIPD";
            this.buttonIPD.Size = new System.Drawing.Size(75, 23);
            this.buttonIPD.TabIndex = 106;
            this.buttonIPD.Text = "IPD";
            this.buttonIPD.UseVisualStyleBackColor = true;
            this.buttonIPD.Click += new System.EventHandler(this.buttonIPD_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(343, 17);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 105;
            this.buttonDel.Text = "Delete";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // DoctorNameComboBox
            // 
            this.DoctorNameComboBox.DataSource = this.doctorMastBindingSource;
            this.DoctorNameComboBox.DisplayMember = "DocName";
            this.DoctorNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DoctorNameComboBox.FormattingEnabled = true;
            this.DoctorNameComboBox.Location = new System.Drawing.Point(99, 164);
            this.DoctorNameComboBox.Name = "DoctorNameComboBox";
            this.DoctorNameComboBox.Size = new System.Drawing.Size(203, 21);
            this.DoctorNameComboBox.TabIndex = 2;
            this.DoctorNameComboBox.ValueMember = "DocName";
            // 
            // doctorMastBindingSource
            // 
            this.doctorMastBindingSource.DataMember = "DoctorMast";
            this.doctorMastBindingSource.DataSource = this.hMSDataSet;
            // 
            // DaystextBox
            // 
            this.DaystextBox.Location = new System.Drawing.Point(733, 88);
            this.DaystextBox.Name = "DaystextBox";
            this.DaystextBox.ReadOnly = true;
            this.DaystextBox.Size = new System.Drawing.Size(115, 20);
            this.DaystextBox.TabIndex = 102;
            this.DaystextBox.Text = "0";
            this.DaystextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DaystextBox.TextChanged += new System.EventHandler(this.DaystextBox_TextChanged);
            // 
            // ToDtdateTimePicker
            // 
            this.ToDtdateTimePicker.CustomFormat = "";
            this.ToDtdateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dischargeBindingSource, "DischargeDate", true));
            this.ToDtdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToDtdateTimePicker.Location = new System.Drawing.Point(733, 62);
            this.ToDtdateTimePicker.Name = "ToDtdateTimePicker";
            this.ToDtdateTimePicker.Size = new System.Drawing.Size(115, 20);
            this.ToDtdateTimePicker.TabIndex = 7;
            this.ToDtdateTimePicker.ValueChanged += new System.EventHandler(this.ToDtdateTimePicker_ValueChanged);
            // 
            // BedAmounttextBox
            // 
            this.BedAmounttextBox.Location = new System.Drawing.Point(733, 138);
            this.BedAmounttextBox.Name = "BedAmounttextBox";
            this.BedAmounttextBox.ReadOnly = true;
            this.BedAmounttextBox.Size = new System.Drawing.Size(115, 20);
            this.BedAmounttextBox.TabIndex = 99;
            this.BedAmounttextBox.Text = "0";
            this.BedAmounttextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(99, 61);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(203, 20);
            this.idTextBox.TabIndex = 0;
            // 
            // BedRateTextBox
            // 
            this.BedRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bedNumberMastBindingSource, "BedRate", true));
            this.BedRateTextBox.Location = new System.Drawing.Point(733, 113);
            this.BedRateTextBox.Name = "BedRateTextBox";
            this.BedRateTextBox.ReadOnly = true;
            this.BedRateTextBox.Size = new System.Drawing.Size(115, 20);
            this.BedRateTextBox.TabIndex = 96;
            this.BedRateTextBox.Text = "0";
            this.BedRateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BedRateTextBox.TextChanged += new System.EventHandler(this.BedRateTextBox_TextChanged);
            // 
            // bedNumberMastBindingSource
            // 
            this.bedNumberMastBindingSource.DataMember = "BedNumberMast";
            this.bedNumberMastBindingSource.DataSource = this.hMSDataSet;
            // 
            // bedNoComboBox
            // 
            this.bedNoComboBox.DataSource = this.bedNumberMastBindingSource;
            this.bedNoComboBox.DisplayMember = "BedNumber";
            this.bedNoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bedNoComboBox.FormattingEnabled = true;
            this.bedNoComboBox.Location = new System.Drawing.Point(479, 114);
            this.bedNoComboBox.Name = "bedNoComboBox";
            this.bedNoComboBox.Size = new System.Drawing.Size(114, 21);
            this.bedNoComboBox.TabIndex = 6;
            this.bedNoComboBox.ValueMember = "BedNumber";
            this.bedNoComboBox.SelectedIndexChanged += new System.EventHandler(this.bedNoComboBox_SelectedIndexChanged);
            // 
            // bedTypeComboBox
            // 
            this.bedTypeComboBox.DataSource = this.bedTypeMastBindingSource;
            this.bedTypeComboBox.DisplayMember = "BedType";
            this.bedTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bedTypeComboBox.FormattingEnabled = true;
            this.bedTypeComboBox.Location = new System.Drawing.Point(479, 87);
            this.bedTypeComboBox.Name = "bedTypeComboBox";
            this.bedTypeComboBox.Size = new System.Drawing.Size(114, 21);
            this.bedTypeComboBox.TabIndex = 5;
            this.bedTypeComboBox.ValueMember = "BedType";
            this.bedTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.bedTypeComboBox_SelectedIndexChanged);
            // 
            // bedTypeMastBindingSource
            // 
            this.bedTypeMastBindingSource.DataMember = "BedTypeMast";
            this.bedTypeMastBindingSource.DataSource = this.hMSDataSet;
            // 
            // PatientNametextBox
            // 
            this.PatientNametextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientMastBindingSource, "Id", true));
            this.PatientNametextBox.Location = new System.Drawing.Point(99, 113);
            this.PatientNametextBox.Name = "PatientNametextBox";
            this.PatientNametextBox.ReadOnly = true;
            this.PatientNametextBox.Size = new System.Drawing.Size(203, 20);
            this.PatientNametextBox.TabIndex = 2;
            // 
            // bedTypeMastTableAdapter
            // 
            this.bedTypeMastTableAdapter.ClearBeforeFill = true;
            // 
            // bedNumberMastTableAdapter
            // 
            this.bedNumberMastTableAdapter.ClearBeforeFill = true;
            // 
            // BedManagedataGridView
            // 
            this.BedManagedataGridView.AllowUserToAddRows = false;
            this.BedManagedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BedManagedataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.IPD,
            this.Patient,
            this.Doctor,
            this.FromDate,
            this.BedType,
            this.BedNo,
            this.Todate,
            this.Days,
            this.Rate,
            this.BedAmount});
            this.BedManagedataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BedManagedataGridView.Location = new System.Drawing.Point(0, 253);
            this.BedManagedataGridView.Name = "BedManagedataGridView";
            this.BedManagedataGridView.ReadOnly = true;
            this.BedManagedataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BedManagedataGridView.Size = new System.Drawing.Size(874, 228);
            this.BedManagedataGridView.TabIndex = 5;
            this.BedManagedataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.BedManagedataGridView_MouseDoubleClick);
            // 
            // id
            // 
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // IPD
            // 
            this.IPD.HeaderText = "IPD";
            this.IPD.Name = "IPD";
            this.IPD.ReadOnly = true;
            // 
            // Patient
            // 
            this.Patient.HeaderText = "Patient Name";
            this.Patient.Name = "Patient";
            this.Patient.ReadOnly = true;
            // 
            // Doctor
            // 
            this.Doctor.HeaderText = "Doctor";
            this.Doctor.Name = "Doctor";
            this.Doctor.ReadOnly = true;
            // 
            // FromDate
            // 
            this.FromDate.HeaderText = "Issue Date";
            this.FromDate.Name = "FromDate";
            this.FromDate.ReadOnly = true;
            // 
            // BedType
            // 
            this.BedType.HeaderText = "Bed Type";
            this.BedType.Name = "BedType";
            this.BedType.ReadOnly = true;
            // 
            // BedNo
            // 
            this.BedNo.HeaderText = "Bed No";
            this.BedNo.Name = "BedNo";
            this.BedNo.ReadOnly = true;
            // 
            // Todate
            // 
            this.Todate.HeaderText = "Clear Date";
            this.Todate.Name = "Todate";
            this.Todate.ReadOnly = true;
            // 
            // Days
            // 
            this.Days.HeaderText = "Days";
            this.Days.Name = "Days";
            this.Days.ReadOnly = true;
            // 
            // Rate
            // 
            this.Rate.HeaderText = "Bed Rate";
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            // 
            // BedAmount
            // 
            this.BedAmount.HeaderText = "Bed Amount";
            this.BedAmount.Name = "BedAmount";
            this.BedAmount.ReadOnly = true;
            // 
            // bedManagementBindingSource
            // 
            this.bedManagementBindingSource.DataMember = "BedManagement";
            this.bedManagementBindingSource.DataSource = this.hMSDataSet;
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
            // doctorMastTableAdapter
            // 
            this.doctorMastTableAdapter.ClearBeforeFill = true;
            // 
            // BedMangFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 481);
            this.Controls.Add(this.BedManagedataGridView);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "BedMangFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bed Management";
            this.Load += new System.EventHandler(this.BedMangFrm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BedMangFrm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dischargeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientMastBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPDBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorMastBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedNumberMastBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedTypeMastBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BedManagedataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedManagementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDepartmentMastBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        

        #endregion

        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.TextBox IPDSearchtextBox;
        private System.Windows.Forms.DateTimePicker AdmissiondateTimePicker;
        private System.Windows.Forms.BindingSource dischargeBindingSource;
        private HMSDataSet hMSDataSet;
        private System.Windows.Forms.BindingSource patientMastBindingSource;
        private System.Windows.Forms.BindingSource iPDBindingSource;
        private HMSDataSetTableAdapters.IPDTableAdapter iPDTableAdapter;
        private System.Windows.Forms.TextBox GendertextBox;
        private System.Windows.Forms.TextBox AgetextBox;
        private System.Windows.Forms.DateTimePicker FromDtDateTimePicker;
        private HMSDataSetTableAdapters.DischargeTableAdapter dischargeTableAdapter;
        private HMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private HMSDataSetTableAdapters.PatientMastTableAdapter patientMastTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox PatientNametextBox;
        private System.Windows.Forms.BindingSource bedTypeMastBindingSource;
        private HMSDataSetTableAdapters.BedTypeMastTableAdapter bedTypeMastTableAdapter;
        private System.Windows.Forms.ComboBox bedTypeComboBox;
        private System.Windows.Forms.BindingSource bedNumberMastBindingSource;
        private HMSDataSetTableAdapters.BedNumberMastTableAdapter bedNumberMastTableAdapter;
        private System.Windows.Forms.TextBox BedRateTextBox;
        private System.Windows.Forms.ComboBox bedNoComboBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.DateTimePicker ToDtdateTimePicker;
        private System.Windows.Forms.TextBox BedAmounttextBox;
        private System.Windows.Forms.TextBox DaystextBox;
        private System.Windows.Forms.DataGridView BedManagedataGridView;
        private System.Windows.Forms.BindingSource bedManagementBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn billPrintTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn FromDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BedType;
        private System.Windows.Forms.DataGridViewTextBoxColumn BedNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Todate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Days;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BedAmount;
        private System.Windows.Forms.ComboBox DoctorNameComboBox;
        private System.Windows.Forms.BindingSource doctorDepartmentMastBindingSource;
        private HMSDataSetTableAdapters.DoctorDepartmentMastTableAdapter doctorDepartmentMastTableAdapter;
        private System.Windows.Forms.BindingSource doctorMastBindingSource;
        private HMSDataSetTableAdapters.DoctorMastTableAdapter doctorMastTableAdapter;
        private System.Windows.Forms.Button buttonIPD;
        private System.Windows.Forms.Button buttonDel;
    }
}