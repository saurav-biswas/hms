namespace HMS.Forms.Master
{
    partial class PatientMastFrm
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
            System.Windows.Forms.Label patNameLabel;
            System.Windows.Forms.Label patQualificationLabel;
            System.Windows.Forms.Label patRefferedByLabel;
            System.Windows.Forms.Label patPhoneLabel;
            System.Windows.Forms.Label patEmailLabel;
            System.Windows.Forms.Label patDOBLabel;
            System.Windows.Forms.Label patBloodGroupLabel;
            System.Windows.Forms.Label patGenderLabel;
            System.Windows.Forms.Label patAddress1Label;
            System.Windows.Forms.Label patCityLabel;
            System.Windows.Forms.Label patPINLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientMastFrm));
            this.patientMastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hMSDataSet = new HMS.HMSDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboBoxReligion = new System.Windows.Forms.ComboBox();
            this.patPINTextBox = new System.Windows.Forms.TextBox();
            this.patCityTextBox = new System.Windows.Forms.TextBox();
            this.patAddress2TextBox = new System.Windows.Forms.TextBox();
            this.patAddress1TextBox = new System.Windows.Forms.TextBox();
            this.patGenderComboBox = new System.Windows.Forms.ComboBox();
            this.patBloodGroupComboBox = new System.Windows.Forms.ComboBox();
            this.bloodGroupMastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patDOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.patEmailTextBox = new System.Windows.Forms.TextBox();
            this.patPhoneTextBox = new System.Windows.Forms.TextBox();
            this.patRefferedByTextBox = new System.Windows.Forms.TextBox();
            this.patQualificationTextBox = new System.Windows.Forms.TextBox();
            this.patNameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.patientMastTableAdapter = new HMS.HMSDataSetTableAdapters.PatientMastTableAdapter();
            this.tableAdapterManager = new HMS.HMSDataSetTableAdapters.TableAdapterManager();
            this.doctorMastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorMastTableAdapter = new HMS.HMSDataSetTableAdapters.DoctorMastTableAdapter();
            this.bloodGroupMastTableAdapter = new HMS.HMSDataSetTableAdapters.BloodGroupMastTableAdapter();
            this.patientMastDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatBalAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatBloodGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatUnderDr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatRefferedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            patNameLabel = new System.Windows.Forms.Label();
            patQualificationLabel = new System.Windows.Forms.Label();
            patRefferedByLabel = new System.Windows.Forms.Label();
            patPhoneLabel = new System.Windows.Forms.Label();
            patEmailLabel = new System.Windows.Forms.Label();
            patDOBLabel = new System.Windows.Forms.Label();
            patBloodGroupLabel = new System.Windows.Forms.Label();
            patGenderLabel = new System.Windows.Forms.Label();
            patAddress1Label = new System.Windows.Forms.Label();
            patCityLabel = new System.Windows.Forms.Label();
            patPINLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.patientMastBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bloodGroupMastBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorMastBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientMastDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(68, 60);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // patNameLabel
            // 
            patNameLabel.AutoSize = true;
            patNameLabel.Location = new System.Drawing.Point(49, 82);
            patNameLabel.Name = "patNameLabel";
            patNameLabel.Size = new System.Drawing.Size(38, 13);
            patNameLabel.TabIndex = 2;
            patNameLabel.Text = "Name:";
            // 
            // patQualificationLabel
            // 
            patQualificationLabel.AutoSize = true;
            patQualificationLabel.Location = new System.Drawing.Point(19, 108);
            patQualificationLabel.Name = "patQualificationLabel";
            patQualificationLabel.Size = new System.Drawing.Size(68, 13);
            patQualificationLabel.TabIndex = 4;
            patQualificationLabel.Text = "Qualification:";
            // 
            // patRefferedByLabel
            // 
            patRefferedByLabel.AutoSize = true;
            patRefferedByLabel.Location = new System.Drawing.Point(21, 134);
            patRefferedByLabel.Name = "patRefferedByLabel";
            patRefferedByLabel.Size = new System.Drawing.Size(66, 13);
            patRefferedByLabel.TabIndex = 6;
            patRefferedByLabel.Text = "Reffered By:";
            // 
            // patPhoneLabel
            // 
            patPhoneLabel.AutoSize = true;
            patPhoneLabel.Location = new System.Drawing.Point(397, 56);
            patPhoneLabel.Name = "patPhoneLabel";
            patPhoneLabel.Size = new System.Drawing.Size(41, 13);
            patPhoneLabel.TabIndex = 8;
            patPhoneLabel.Text = "Phone:";
            // 
            // patEmailLabel
            // 
            patEmailLabel.AutoSize = true;
            patEmailLabel.Location = new System.Drawing.Point(403, 82);
            patEmailLabel.Name = "patEmailLabel";
            patEmailLabel.Size = new System.Drawing.Size(35, 13);
            patEmailLabel.TabIndex = 10;
            patEmailLabel.Text = "Email:";
            // 
            // patDOBLabel
            // 
            patDOBLabel.AutoSize = true;
            patDOBLabel.Location = new System.Drawing.Point(405, 108);
            patDOBLabel.Name = "patDOBLabel";
            patDOBLabel.Size = new System.Drawing.Size(33, 13);
            patDOBLabel.TabIndex = 12;
            patDOBLabel.Text = "DOB:";
            // 
            // patBloodGroupLabel
            // 
            patBloodGroupLabel.AutoSize = true;
            patBloodGroupLabel.Location = new System.Drawing.Point(369, 134);
            patBloodGroupLabel.Name = "patBloodGroupLabel";
            patBloodGroupLabel.Size = new System.Drawing.Size(69, 13);
            patBloodGroupLabel.TabIndex = 14;
            patBloodGroupLabel.Text = "Blood Group:";
            // 
            // patGenderLabel
            // 
            patGenderLabel.AutoSize = true;
            patGenderLabel.Location = new System.Drawing.Point(391, 161);
            patGenderLabel.Name = "patGenderLabel";
            patGenderLabel.Size = new System.Drawing.Size(45, 13);
            patGenderLabel.TabIndex = 16;
            patGenderLabel.Text = "Gender:";
            // 
            // patAddress1Label
            // 
            patAddress1Label.AutoSize = true;
            patAddress1Label.Location = new System.Drawing.Point(39, 188);
            patAddress1Label.Name = "patAddress1Label";
            patAddress1Label.Size = new System.Drawing.Size(48, 13);
            patAddress1Label.TabIndex = 18;
            patAddress1Label.Text = "Address:";
            // 
            // patCityLabel
            // 
            patCityLabel.AutoSize = true;
            patCityLabel.Location = new System.Drawing.Point(409, 188);
            patCityLabel.Name = "patCityLabel";
            patCityLabel.Size = new System.Drawing.Size(27, 13);
            patCityLabel.TabIndex = 22;
            patCityLabel.Text = "City:";
            // 
            // patPINLabel
            // 
            patPINLabel.AutoSize = true;
            patPINLabel.Location = new System.Drawing.Point(408, 214);
            patPINLabel.Name = "patPINLabel";
            patPINLabel.Size = new System.Drawing.Size(28, 13);
            patPINLabel.TabIndex = 24;
            patPINLabel.Text = "PIN:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(39, 160);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(48, 13);
            label1.TabIndex = 26;
            label1.Text = "Religion:";
            // 
            // patientMastBindingSource
            // 
            this.patientMastBindingSource.DataMember = "PatientMast";
            this.patientMastBindingSource.DataSource = this.hMSDataSet;
            // 
            // hMSDataSet
            // 
            this.hMSDataSet.DataSetName = "HMSDataSet";
            this.hMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonDel);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.comboBoxReligion);
            this.panel1.Controls.Add(patPINLabel);
            this.panel1.Controls.Add(this.patPINTextBox);
            this.panel1.Controls.Add(patCityLabel);
            this.panel1.Controls.Add(this.patCityTextBox);
            this.panel1.Controls.Add(this.patAddress2TextBox);
            this.panel1.Controls.Add(patAddress1Label);
            this.panel1.Controls.Add(this.patAddress1TextBox);
            this.panel1.Controls.Add(patGenderLabel);
            this.panel1.Controls.Add(this.patGenderComboBox);
            this.panel1.Controls.Add(patBloodGroupLabel);
            this.panel1.Controls.Add(this.patBloodGroupComboBox);
            this.panel1.Controls.Add(patDOBLabel);
            this.panel1.Controls.Add(this.patDOBDateTimePicker);
            this.panel1.Controls.Add(patEmailLabel);
            this.panel1.Controls.Add(this.patEmailTextBox);
            this.panel1.Controls.Add(patPhoneLabel);
            this.panel1.Controls.Add(this.patPhoneTextBox);
            this.panel1.Controls.Add(patRefferedByLabel);
            this.panel1.Controls.Add(this.patRefferedByTextBox);
            this.panel1.Controls.Add(patQualificationLabel);
            this.panel1.Controls.Add(this.patQualificationTextBox);
            this.panel1.Controls.Add(patNameLabel);
            this.panel1.Controls.Add(this.patNameTextBox);
            this.panel1.Controls.Add(idLabel);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 266);
            this.panel1.TabIndex = 2;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(382, 13);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 110;
            this.buttonDel.Text = "Delete";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(177, 13);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 109;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // comboBoxReligion
            // 
            this.comboBoxReligion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientMastBindingSource, "PatReligion", true));
            this.comboBoxReligion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReligion.FormattingEnabled = true;
            this.comboBoxReligion.Items.AddRange(new object[] {
            "Hinduism",
            "Islam",
            "Christianity",
            "Buddhism",
            "Jainism"});
            this.comboBoxReligion.Location = new System.Drawing.Point(93, 157);
            this.comboBoxReligion.Name = "comboBoxReligion";
            this.comboBoxReligion.Size = new System.Drawing.Size(203, 21);
            this.comboBoxReligion.TabIndex = 25;
            // 
            // patPINTextBox
            // 
            this.patPINTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientMastBindingSource, "PatPIN", true));
            this.patPINTextBox.Location = new System.Drawing.Point(444, 211);
            this.patPINTextBox.Name = "patPINTextBox";
            this.patPINTextBox.Size = new System.Drawing.Size(203, 20);
            this.patPINTextBox.TabIndex = 12;
            // 
            // patCityTextBox
            // 
            this.patCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientMastBindingSource, "PatCity", true));
            this.patCityTextBox.Location = new System.Drawing.Point(444, 185);
            this.patCityTextBox.Name = "patCityTextBox";
            this.patCityTextBox.Size = new System.Drawing.Size(203, 20);
            this.patCityTextBox.TabIndex = 11;
            // 
            // patAddress2TextBox
            // 
            this.patAddress2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientMastBindingSource, "PatAddress2", true));
            this.patAddress2TextBox.Location = new System.Drawing.Point(93, 211);
            this.patAddress2TextBox.Name = "patAddress2TextBox";
            this.patAddress2TextBox.Size = new System.Drawing.Size(203, 20);
            this.patAddress2TextBox.TabIndex = 10;
            // 
            // patAddress1TextBox
            // 
            this.patAddress1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientMastBindingSource, "PatAddress1", true));
            this.patAddress1TextBox.Location = new System.Drawing.Point(93, 185);
            this.patAddress1TextBox.Name = "patAddress1TextBox";
            this.patAddress1TextBox.Size = new System.Drawing.Size(203, 20);
            this.patAddress1TextBox.TabIndex = 9;
            // 
            // patGenderComboBox
            // 
            this.patGenderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientMastBindingSource, "PatGender", true));
            this.patGenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patGenderComboBox.FormattingEnabled = true;
            this.patGenderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.patGenderComboBox.Location = new System.Drawing.Point(444, 158);
            this.patGenderComboBox.Name = "patGenderComboBox";
            this.patGenderComboBox.Size = new System.Drawing.Size(203, 21);
            this.patGenderComboBox.TabIndex = 8;
            // 
            // patBloodGroupComboBox
            // 
            this.patBloodGroupComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientMastBindingSource, "PatBloodGroup", true));
            this.patBloodGroupComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bloodGroupMastBindingSource, "BloodGroup", true));
            this.patBloodGroupComboBox.DataSource = this.bloodGroupMastBindingSource;
            this.patBloodGroupComboBox.DisplayMember = "BloodGroup";
            this.patBloodGroupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patBloodGroupComboBox.FormattingEnabled = true;
            this.patBloodGroupComboBox.Location = new System.Drawing.Point(444, 131);
            this.patBloodGroupComboBox.Name = "patBloodGroupComboBox";
            this.patBloodGroupComboBox.Size = new System.Drawing.Size(203, 21);
            this.patBloodGroupComboBox.TabIndex = 7;
            this.patBloodGroupComboBox.ValueMember = "BloodGroup";
            // 
            // bloodGroupMastBindingSource
            // 
            this.bloodGroupMastBindingSource.DataMember = "BloodGroupMast";
            this.bloodGroupMastBindingSource.DataSource = this.hMSDataSet;
            // 
            // patDOBDateTimePicker
            // 
            this.patDOBDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.patientMastBindingSource, "PatDOB", true));
            this.patDOBDateTimePicker.Location = new System.Drawing.Point(444, 105);
            this.patDOBDateTimePicker.Name = "patDOBDateTimePicker";
            this.patDOBDateTimePicker.Size = new System.Drawing.Size(203, 20);
            this.patDOBDateTimePicker.TabIndex = 6;
            // 
            // patEmailTextBox
            // 
            this.patEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientMastBindingSource, "PatEmail", true));
            this.patEmailTextBox.Location = new System.Drawing.Point(444, 79);
            this.patEmailTextBox.Name = "patEmailTextBox";
            this.patEmailTextBox.Size = new System.Drawing.Size(203, 20);
            this.patEmailTextBox.TabIndex = 5;
            // 
            // patPhoneTextBox
            // 
            this.patPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientMastBindingSource, "PatPhone", true));
            this.patPhoneTextBox.Location = new System.Drawing.Point(444, 53);
            this.patPhoneTextBox.Name = "patPhoneTextBox";
            this.patPhoneTextBox.Size = new System.Drawing.Size(203, 20);
            this.patPhoneTextBox.TabIndex = 4;
            // 
            // patRefferedByTextBox
            // 
            this.patRefferedByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientMastBindingSource, "PatRefferedBy", true));
            this.patRefferedByTextBox.Location = new System.Drawing.Point(93, 131);
            this.patRefferedByTextBox.Name = "patRefferedByTextBox";
            this.patRefferedByTextBox.Size = new System.Drawing.Size(203, 20);
            this.patRefferedByTextBox.TabIndex = 3;
            // 
            // patQualificationTextBox
            // 
            this.patQualificationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientMastBindingSource, "PatQualification", true));
            this.patQualificationTextBox.Location = new System.Drawing.Point(93, 105);
            this.patQualificationTextBox.Name = "patQualificationTextBox";
            this.patQualificationTextBox.Size = new System.Drawing.Size(203, 20);
            this.patQualificationTextBox.TabIndex = 2;
            // 
            // patNameTextBox
            // 
            this.patNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientMastBindingSource, "PatName", true));
            this.patNameTextBox.Location = new System.Drawing.Point(93, 79);
            this.patNameTextBox.Name = "patNameTextBox";
            this.patNameTextBox.Size = new System.Drawing.Size(203, 20);
            this.patNameTextBox.TabIndex = 1;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientMastBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(93, 53);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(203, 20);
            this.idTextBox.TabIndex = 0;
            // 
            // patientMastTableAdapter
            // 
            this.patientMastTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.PatientMastTableAdapter = this.patientMastTableAdapter;
            this.tableAdapterManager.PrescriptionTableAdapter = null;
            this.tableAdapterManager.PresMedTableAdapter = null;
            this.tableAdapterManager.SuppMastTableAdapter = null;
            this.tableAdapterManager.TaxMastTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HMS.HMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // doctorMastBindingSource
            // 
            this.doctorMastBindingSource.DataMember = "DoctorMast";
            this.doctorMastBindingSource.DataSource = this.hMSDataSet;
            // 
            // doctorMastTableAdapter
            // 
            this.doctorMastTableAdapter.ClearBeforeFill = true;
            // 
            // bloodGroupMastTableAdapter
            // 
            this.bloodGroupMastTableAdapter.ClearBeforeFill = true;
            // 
            // patientMastDataGridView
            // 
            this.patientMastDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientMastDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PatName,
            this.PatPhone,
            this.PatBalAmt,
            this.PatDOB,
            this.PatBloodGroup,
            this.PatGender,
            this.PatCity,
            this.PatUnderDr,
            this.PatRefferedBy});
            this.patientMastDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientMastDataGridView.Location = new System.Drawing.Point(0, 266);
            this.patientMastDataGridView.Name = "patientMastDataGridView";
            this.patientMastDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientMastDataGridView.Size = new System.Drawing.Size(681, 320);
            this.patientMastDataGridView.TabIndex = 2;
            this.patientMastDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.patientMastDataGridView_MouseDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // PatName
            // 
            this.PatName.FillWeight = 200F;
            this.PatName.HeaderText = "PatName";
            this.PatName.Name = "PatName";
            this.PatName.Width = 200;
            // 
            // PatPhone
            // 
            this.PatPhone.FillWeight = 150F;
            this.PatPhone.HeaderText = "PatPhone";
            this.PatPhone.Name = "PatPhone";
            this.PatPhone.Width = 150;
            // 
            // PatBalAmt
            // 
            this.PatBalAmt.HeaderText = "PatBalAmt";
            this.PatBalAmt.Name = "PatBalAmt";
            // 
            // PatDOB
            // 
            this.PatDOB.HeaderText = "PatDOB";
            this.PatDOB.Name = "PatDOB";
            // 
            // PatBloodGroup
            // 
            this.PatBloodGroup.HeaderText = "PatBloodGroup";
            this.PatBloodGroup.Name = "PatBloodGroup";
            // 
            // PatGender
            // 
            this.PatGender.HeaderText = "PatGender";
            this.PatGender.Name = "PatGender";
            // 
            // PatCity
            // 
            this.PatCity.HeaderText = "PatCity";
            this.PatCity.Name = "PatCity";
            // 
            // PatUnderDr
            // 
            this.PatUnderDr.HeaderText = "PatUnderDr";
            this.PatUnderDr.Name = "PatUnderDr";
            // 
            // PatRefferedBy
            // 
            this.PatRefferedBy.HeaderText = "PatRefferedBy";
            this.PatRefferedBy.Name = "PatRefferedBy";
            // 
            // PatientMastFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 586);
            this.Controls.Add(this.patientMastDataGridView);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "PatientMastFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Master";
            this.Load += new System.EventHandler(this.PatientMastFrm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PatientMastFrm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.patientMastBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bloodGroupMastBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorMastBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientMastDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HMSDataSet hMSDataSet;
        private System.Windows.Forms.BindingSource patientMastBindingSource;
        private HMSDataSetTableAdapters.PatientMastTableAdapter patientMastTableAdapter;
        private HMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox patQualificationTextBox;
        private System.Windows.Forms.TextBox patNameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox patRefferedByTextBox;
        private System.Windows.Forms.TextBox patPhoneTextBox;
        private System.Windows.Forms.DateTimePicker patDOBDateTimePicker;
        private System.Windows.Forms.TextBox patEmailTextBox;
        private System.Windows.Forms.ComboBox patGenderComboBox;
        private System.Windows.Forms.ComboBox patBloodGroupComboBox;
        private System.Windows.Forms.BindingSource doctorMastBindingSource;
        private HMSDataSetTableAdapters.DoctorMastTableAdapter doctorMastTableAdapter;
        private System.Windows.Forms.BindingSource bloodGroupMastBindingSource;
        private HMSDataSetTableAdapters.BloodGroupMastTableAdapter bloodGroupMastTableAdapter;
        private System.Windows.Forms.TextBox patPINTextBox;
        private System.Windows.Forms.TextBox patCityTextBox;
        private System.Windows.Forms.TextBox patAddress2TextBox;
        private System.Windows.Forms.TextBox patAddress1TextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.ComboBox comboBoxReligion;
        private System.Windows.Forms.DataGridView patientMastDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatBalAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatBloodGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatUnderDr;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatRefferedBy;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonSave;
    }
}