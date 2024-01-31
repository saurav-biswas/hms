namespace HMS.Forms.Master
{
    partial class DoctorMastFrm
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
            System.Windows.Forms.Label docNameLabel;
            System.Windows.Forms.Label docDesignationLabel;
            System.Windows.Forms.Label docQualificationLabel;
            System.Windows.Forms.Label docSpecialistLabel;
            System.Windows.Forms.Label docPhoneLabel;
            System.Windows.Forms.Label docEmailLabel;
            System.Windows.Forms.Label docDOBLabel;
            System.Windows.Forms.Label docBloodGroupLabel;
            System.Windows.Forms.Label docGenderLabel;
            System.Windows.Forms.Label docAddress1Label;
            System.Windows.Forms.Label docAddress2Label;
            System.Windows.Forms.Label docCityLabel;
            System.Windows.Forms.Label docPINLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorMastFrm));
            this.hMSDataSet = new HMS.HMSDataSet();
            this.doctorMastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorMastTableAdapter = new HMS.HMSDataSetTableAdapters.DoctorMastTableAdapter();
            this.tableAdapterManager = new HMS.HMSDataSetTableAdapters.TableAdapterManager();
            this.bloodGroupMastTableAdapter = new HMS.HMSDataSetTableAdapters.BloodGroupMastTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.docPINTextBox = new System.Windows.Forms.TextBox();
            this.docCityTextBox = new System.Windows.Forms.TextBox();
            this.docAddress2TextBox = new System.Windows.Forms.TextBox();
            this.docAddress1TextBox = new System.Windows.Forms.TextBox();
            this.docGenderComboBox = new System.Windows.Forms.ComboBox();
            this.docBloodGroupComboBox = new System.Windows.Forms.ComboBox();
            this.bloodGroupMastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.docDOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.docEmailTextBox = new System.Windows.Forms.TextBox();
            this.docPhoneTextBox = new System.Windows.Forms.TextBox();
            this.docSpecialistTextBox = new System.Windows.Forms.TextBox();
            this.docQualificationTextBox = new System.Windows.Forms.TextBox();
            this.docDesignationTextBox = new System.Windows.Forms.TextBox();
            this.docNameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.doctorMastDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocSpecialist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            docNameLabel = new System.Windows.Forms.Label();
            docDesignationLabel = new System.Windows.Forms.Label();
            docQualificationLabel = new System.Windows.Forms.Label();
            docSpecialistLabel = new System.Windows.Forms.Label();
            docPhoneLabel = new System.Windows.Forms.Label();
            docEmailLabel = new System.Windows.Forms.Label();
            docDOBLabel = new System.Windows.Forms.Label();
            docBloodGroupLabel = new System.Windows.Forms.Label();
            docGenderLabel = new System.Windows.Forms.Label();
            docAddress1Label = new System.Windows.Forms.Label();
            docAddress2Label = new System.Windows.Forms.Label();
            docCityLabel = new System.Windows.Forms.Label();
            docPINLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorMastBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bloodGroupMastBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorMastDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(90, 52);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // docNameLabel
            // 
            docNameLabel.AutoSize = true;
            docNameLabel.Location = new System.Drawing.Point(48, 78);
            docNameLabel.Name = "docNameLabel";
            docNameLabel.Size = new System.Drawing.Size(61, 13);
            docNameLabel.TabIndex = 2;
            docNameLabel.Text = "Doc Name:";
            // 
            // docDesignationLabel
            // 
            docDesignationLabel.AutoSize = true;
            docDesignationLabel.Location = new System.Drawing.Point(20, 104);
            docDesignationLabel.Name = "docDesignationLabel";
            docDesignationLabel.Size = new System.Drawing.Size(89, 13);
            docDesignationLabel.TabIndex = 4;
            docDesignationLabel.Text = "Doc Designation:";
            // 
            // docQualificationLabel
            // 
            docQualificationLabel.AutoSize = true;
            docQualificationLabel.Location = new System.Drawing.Point(18, 130);
            docQualificationLabel.Name = "docQualificationLabel";
            docQualificationLabel.Size = new System.Drawing.Size(91, 13);
            docQualificationLabel.TabIndex = 6;
            docQualificationLabel.Text = "Doc Qualification:";
            // 
            // docSpecialistLabel
            // 
            docSpecialistLabel.AutoSize = true;
            docSpecialistLabel.Location = new System.Drawing.Point(31, 156);
            docSpecialistLabel.Name = "docSpecialistLabel";
            docSpecialistLabel.Size = new System.Drawing.Size(78, 13);
            docSpecialistLabel.TabIndex = 8;
            docSpecialistLabel.Text = "Doc Specialist:";
            // 
            // docPhoneLabel
            // 
            docPhoneLabel.AutoSize = true;
            docPhoneLabel.Location = new System.Drawing.Point(418, 52);
            docPhoneLabel.Name = "docPhoneLabel";
            docPhoneLabel.Size = new System.Drawing.Size(64, 13);
            docPhoneLabel.TabIndex = 10;
            docPhoneLabel.Text = "Doc Phone:";
            // 
            // docEmailLabel
            // 
            docEmailLabel.AutoSize = true;
            docEmailLabel.Location = new System.Drawing.Point(424, 78);
            docEmailLabel.Name = "docEmailLabel";
            docEmailLabel.Size = new System.Drawing.Size(58, 13);
            docEmailLabel.TabIndex = 12;
            docEmailLabel.Text = "Doc Email:";
            // 
            // docDOBLabel
            // 
            docDOBLabel.AutoSize = true;
            docDOBLabel.Location = new System.Drawing.Point(426, 105);
            docDOBLabel.Name = "docDOBLabel";
            docDOBLabel.Size = new System.Drawing.Size(56, 13);
            docDOBLabel.TabIndex = 14;
            docDOBLabel.Text = "Doc DOB:";
            // 
            // docBloodGroupLabel
            // 
            docBloodGroupLabel.AutoSize = true;
            docBloodGroupLabel.Location = new System.Drawing.Point(390, 130);
            docBloodGroupLabel.Name = "docBloodGroupLabel";
            docBloodGroupLabel.Size = new System.Drawing.Size(92, 13);
            docBloodGroupLabel.TabIndex = 16;
            docBloodGroupLabel.Text = "Doc Blood Group:";
            // 
            // docGenderLabel
            // 
            docGenderLabel.AutoSize = true;
            docGenderLabel.Location = new System.Drawing.Point(414, 156);
            docGenderLabel.Name = "docGenderLabel";
            docGenderLabel.Size = new System.Drawing.Size(68, 13);
            docGenderLabel.TabIndex = 18;
            docGenderLabel.Text = "Doc Gender:";
            // 
            // docAddress1Label
            // 
            docAddress1Label.AutoSize = true;
            docAddress1Label.Location = new System.Drawing.Point(32, 182);
            docAddress1Label.Name = "docAddress1Label";
            docAddress1Label.Size = new System.Drawing.Size(77, 13);
            docAddress1Label.TabIndex = 20;
            docAddress1Label.Text = "Doc Address1:";
            // 
            // docAddress2Label
            // 
            docAddress2Label.AutoSize = true;
            docAddress2Label.Location = new System.Drawing.Point(32, 208);
            docAddress2Label.Name = "docAddress2Label";
            docAddress2Label.Size = new System.Drawing.Size(77, 13);
            docAddress2Label.TabIndex = 22;
            docAddress2Label.Text = "Doc Address2:";
            // 
            // docCityLabel
            // 
            docCityLabel.AutoSize = true;
            docCityLabel.Location = new System.Drawing.Point(432, 182);
            docCityLabel.Name = "docCityLabel";
            docCityLabel.Size = new System.Drawing.Size(50, 13);
            docCityLabel.TabIndex = 24;
            docCityLabel.Text = "Doc City:";
            // 
            // docPINLabel
            // 
            docPINLabel.AutoSize = true;
            docPINLabel.Location = new System.Drawing.Point(431, 208);
            docPINLabel.Name = "docPINLabel";
            docPINLabel.Size = new System.Drawing.Size(51, 13);
            docPINLabel.TabIndex = 26;
            docPINLabel.Text = "Doc PIN:";
            // 
            // hMSDataSet
            // 
            this.hMSDataSet.DataSetName = "HMSDataSet";
            this.hMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdvanceTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BedManagementTableAdapter = null;
            this.tableAdapterManager.BedNumberMastTableAdapter = null;
            this.tableAdapterManager.BedTypeMastTableAdapter = null;
            this.tableAdapterManager.BloodGroupMastTableAdapter = this.bloodGroupMastTableAdapter;
            this.tableAdapterManager.DischargeLinTableAdapter = null;
            this.tableAdapterManager.DischargeTableAdapter = null;
            this.tableAdapterManager.DisposableIssHdrTableAdapter = null;
            this.tableAdapterManager.DisposableIssLinTableAdapter = null;
            this.tableAdapterManager.DoctorDepartmentMastTableAdapter = null;
            this.tableAdapterManager.DoctorMastTableAdapter = this.doctorMastTableAdapter;
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
            // bloodGroupMastTableAdapter
            // 
            this.bloodGroupMastTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonDel);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(docPINLabel);
            this.panel1.Controls.Add(this.docPINTextBox);
            this.panel1.Controls.Add(docCityLabel);
            this.panel1.Controls.Add(this.docCityTextBox);
            this.panel1.Controls.Add(docAddress2Label);
            this.panel1.Controls.Add(this.docAddress2TextBox);
            this.panel1.Controls.Add(docAddress1Label);
            this.panel1.Controls.Add(this.docAddress1TextBox);
            this.panel1.Controls.Add(docGenderLabel);
            this.panel1.Controls.Add(this.docGenderComboBox);
            this.panel1.Controls.Add(docBloodGroupLabel);
            this.panel1.Controls.Add(this.docBloodGroupComboBox);
            this.panel1.Controls.Add(docDOBLabel);
            this.panel1.Controls.Add(this.docDOBDateTimePicker);
            this.panel1.Controls.Add(docEmailLabel);
            this.panel1.Controls.Add(this.docEmailTextBox);
            this.panel1.Controls.Add(docPhoneLabel);
            this.panel1.Controls.Add(this.docPhoneTextBox);
            this.panel1.Controls.Add(docSpecialistLabel);
            this.panel1.Controls.Add(this.docSpecialistTextBox);
            this.panel1.Controls.Add(docQualificationLabel);
            this.panel1.Controls.Add(this.docQualificationTextBox);
            this.panel1.Controls.Add(docDesignationLabel);
            this.panel1.Controls.Add(this.docDesignationTextBox);
            this.panel1.Controls.Add(docNameLabel);
            this.panel1.Controls.Add(this.docNameTextBox);
            this.panel1.Controls.Add(idLabel);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 275);
            this.panel1.TabIndex = 1;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(372, 12);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 108;
            this.buttonDel.Text = "Delete";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(167, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 107;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // docPINTextBox
            // 
            this.docPINTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorMastBindingSource, "DocPIN", true));
            this.docPINTextBox.Location = new System.Drawing.Point(488, 205);
            this.docPINTextBox.Name = "docPINTextBox";
            this.docPINTextBox.Size = new System.Drawing.Size(203, 20);
            this.docPINTextBox.TabIndex = 13;
            // 
            // docCityTextBox
            // 
            this.docCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorMastBindingSource, "DocCity", true));
            this.docCityTextBox.Location = new System.Drawing.Point(488, 179);
            this.docCityTextBox.Name = "docCityTextBox";
            this.docCityTextBox.Size = new System.Drawing.Size(203, 20);
            this.docCityTextBox.TabIndex = 12;
            // 
            // docAddress2TextBox
            // 
            this.docAddress2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorMastBindingSource, "DocAddress2", true));
            this.docAddress2TextBox.Location = new System.Drawing.Point(115, 205);
            this.docAddress2TextBox.Name = "docAddress2TextBox";
            this.docAddress2TextBox.Size = new System.Drawing.Size(203, 20);
            this.docAddress2TextBox.TabIndex = 11;
            // 
            // docAddress1TextBox
            // 
            this.docAddress1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorMastBindingSource, "DocAddress1", true));
            this.docAddress1TextBox.Location = new System.Drawing.Point(115, 179);
            this.docAddress1TextBox.Name = "docAddress1TextBox";
            this.docAddress1TextBox.Size = new System.Drawing.Size(203, 20);
            this.docAddress1TextBox.TabIndex = 10;
            // 
            // docGenderComboBox
            // 
            this.docGenderComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorMastBindingSource, "DocGender", true));
            this.docGenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.docGenderComboBox.FormattingEnabled = true;
            this.docGenderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.docGenderComboBox.Location = new System.Drawing.Point(488, 153);
            this.docGenderComboBox.Name = "docGenderComboBox";
            this.docGenderComboBox.Size = new System.Drawing.Size(203, 21);
            this.docGenderComboBox.TabIndex = 9;
            // 
            // docBloodGroupComboBox
            // 
            this.docBloodGroupComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorMastBindingSource, "DocBloodGroup", true));
            this.docBloodGroupComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bloodGroupMastBindingSource, "BloodGroup", true));
            this.docBloodGroupComboBox.DataSource = this.bloodGroupMastBindingSource;
            this.docBloodGroupComboBox.DisplayMember = "BloodGroup";
            this.docBloodGroupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.docBloodGroupComboBox.FormattingEnabled = true;
            this.docBloodGroupComboBox.Location = new System.Drawing.Point(488, 127);
            this.docBloodGroupComboBox.Name = "docBloodGroupComboBox";
            this.docBloodGroupComboBox.Size = new System.Drawing.Size(203, 21);
            this.docBloodGroupComboBox.TabIndex = 8;
            this.docBloodGroupComboBox.ValueMember = "BloodGroup";
            // 
            // bloodGroupMastBindingSource
            // 
            this.bloodGroupMastBindingSource.DataMember = "BloodGroupMast";
            this.bloodGroupMastBindingSource.DataSource = this.hMSDataSet;
            // 
            // docDOBDateTimePicker
            // 
            this.docDOBDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.doctorMastBindingSource, "DocDOB", true));
            this.docDOBDateTimePicker.Location = new System.Drawing.Point(488, 101);
            this.docDOBDateTimePicker.Name = "docDOBDateTimePicker";
            this.docDOBDateTimePicker.Size = new System.Drawing.Size(203, 20);
            this.docDOBDateTimePicker.TabIndex = 7;
            // 
            // docEmailTextBox
            // 
            this.docEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorMastBindingSource, "DocEmail", true));
            this.docEmailTextBox.Location = new System.Drawing.Point(488, 75);
            this.docEmailTextBox.Name = "docEmailTextBox";
            this.docEmailTextBox.Size = new System.Drawing.Size(203, 20);
            this.docEmailTextBox.TabIndex = 6;
            // 
            // docPhoneTextBox
            // 
            this.docPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorMastBindingSource, "DocPhone", true));
            this.docPhoneTextBox.Location = new System.Drawing.Point(488, 49);
            this.docPhoneTextBox.Name = "docPhoneTextBox";
            this.docPhoneTextBox.Size = new System.Drawing.Size(203, 20);
            this.docPhoneTextBox.TabIndex = 5;
            // 
            // docSpecialistTextBox
            // 
            this.docSpecialistTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorMastBindingSource, "DocSpecialist", true));
            this.docSpecialistTextBox.Location = new System.Drawing.Point(115, 153);
            this.docSpecialistTextBox.Name = "docSpecialistTextBox";
            this.docSpecialistTextBox.Size = new System.Drawing.Size(203, 20);
            this.docSpecialistTextBox.TabIndex = 4;
            // 
            // docQualificationTextBox
            // 
            this.docQualificationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorMastBindingSource, "DocQualification", true));
            this.docQualificationTextBox.Location = new System.Drawing.Point(115, 127);
            this.docQualificationTextBox.Name = "docQualificationTextBox";
            this.docQualificationTextBox.Size = new System.Drawing.Size(203, 20);
            this.docQualificationTextBox.TabIndex = 3;
            // 
            // docDesignationTextBox
            // 
            this.docDesignationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorMastBindingSource, "DocDesignation", true));
            this.docDesignationTextBox.Location = new System.Drawing.Point(115, 101);
            this.docDesignationTextBox.Name = "docDesignationTextBox";
            this.docDesignationTextBox.Size = new System.Drawing.Size(203, 20);
            this.docDesignationTextBox.TabIndex = 2;
            // 
            // docNameTextBox
            // 
            this.docNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorMastBindingSource, "DocName", true));
            this.docNameTextBox.Location = new System.Drawing.Point(115, 75);
            this.docNameTextBox.Name = "docNameTextBox";
            this.docNameTextBox.Size = new System.Drawing.Size(203, 20);
            this.docNameTextBox.TabIndex = 1;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorMastBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(115, 49);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(203, 20);
            this.idTextBox.TabIndex = 0;
            // 
            // doctorMastDataGridView
            // 
            this.doctorMastDataGridView.AllowUserToAddRows = false;
            this.doctorMastDataGridView.AllowUserToDeleteRows = false;
            this.doctorMastDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorMastDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.DocName,
            this.DocSpecialist,
            this.DocPhone});
            this.doctorMastDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doctorMastDataGridView.Location = new System.Drawing.Point(0, 275);
            this.doctorMastDataGridView.Name = "doctorMastDataGridView";
            this.doctorMastDataGridView.ReadOnly = true;
            this.doctorMastDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.doctorMastDataGridView.Size = new System.Drawing.Size(725, 313);
            this.doctorMastDataGridView.TabIndex = 2;
            this.doctorMastDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.doctorMastDataGridView_MouseDoubleClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // DocName
            // 
            this.DocName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DocName.HeaderText = "DocName";
            this.DocName.Name = "DocName";
            this.DocName.ReadOnly = true;
            // 
            // DocSpecialist
            // 
            this.DocSpecialist.FillWeight = 200F;
            this.DocSpecialist.HeaderText = "DocSpecialist";
            this.DocSpecialist.Name = "DocSpecialist";
            this.DocSpecialist.ReadOnly = true;
            this.DocSpecialist.Width = 200;
            // 
            // DocPhone
            // 
            this.DocPhone.FillWeight = 150F;
            this.DocPhone.HeaderText = "DocPhone";
            this.DocPhone.Name = "DocPhone";
            this.DocPhone.ReadOnly = true;
            this.DocPhone.Width = 150;
            // 
            // DoctorMastFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 588);
            this.Controls.Add(this.doctorMastDataGridView);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "DoctorMastFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor Master";
            this.Load += new System.EventHandler(this.DoctorMast_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DoctorMastFrm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorMastBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bloodGroupMastBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorMastDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HMSDataSet hMSDataSet;
        private System.Windows.Forms.BindingSource doctorMastBindingSource;
        private HMSDataSetTableAdapters.DoctorMastTableAdapter doctorMastTableAdapter;
        private HMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView doctorMastDataGridView;
        private System.Windows.Forms.ComboBox docGenderComboBox;
        private System.Windows.Forms.ComboBox docBloodGroupComboBox;
        private System.Windows.Forms.DateTimePicker docDOBDateTimePicker;
        private System.Windows.Forms.TextBox docEmailTextBox;
        private System.Windows.Forms.TextBox docPhoneTextBox;
        private System.Windows.Forms.TextBox docSpecialistTextBox;
        private System.Windows.Forms.TextBox docQualificationTextBox;
        private System.Windows.Forms.TextBox docDesignationTextBox;
        private System.Windows.Forms.TextBox docNameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private HMSDataSetTableAdapters.BloodGroupMastTableAdapter bloodGroupMastTableAdapter;
        private System.Windows.Forms.TextBox docPINTextBox;
        private System.Windows.Forms.TextBox docCityTextBox;
        private System.Windows.Forms.TextBox docAddress2TextBox;
        private System.Windows.Forms.TextBox docAddress1TextBox;
        private System.Windows.Forms.BindingSource bloodGroupMastBindingSource;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocSpecialist;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocPhone;
    }
}