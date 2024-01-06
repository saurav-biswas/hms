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
            this.doctorMastBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.doctorMastBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.doctorMastBindingNavigator)).BeginInit();
            this.doctorMastBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bloodGroupMastBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorMastDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(90, 14);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // docNameLabel
            // 
            docNameLabel.AutoSize = true;
            docNameLabel.Location = new System.Drawing.Point(48, 40);
            docNameLabel.Name = "docNameLabel";
            docNameLabel.Size = new System.Drawing.Size(61, 13);
            docNameLabel.TabIndex = 2;
            docNameLabel.Text = "Doc Name:";
            // 
            // docDesignationLabel
            // 
            docDesignationLabel.AutoSize = true;
            docDesignationLabel.Location = new System.Drawing.Point(20, 66);
            docDesignationLabel.Name = "docDesignationLabel";
            docDesignationLabel.Size = new System.Drawing.Size(89, 13);
            docDesignationLabel.TabIndex = 4;
            docDesignationLabel.Text = "Doc Designation:";
            // 
            // docQualificationLabel
            // 
            docQualificationLabel.AutoSize = true;
            docQualificationLabel.Location = new System.Drawing.Point(18, 92);
            docQualificationLabel.Name = "docQualificationLabel";
            docQualificationLabel.Size = new System.Drawing.Size(91, 13);
            docQualificationLabel.TabIndex = 6;
            docQualificationLabel.Text = "Doc Qualification:";
            // 
            // docSpecialistLabel
            // 
            docSpecialistLabel.AutoSize = true;
            docSpecialistLabel.Location = new System.Drawing.Point(31, 118);
            docSpecialistLabel.Name = "docSpecialistLabel";
            docSpecialistLabel.Size = new System.Drawing.Size(78, 13);
            docSpecialistLabel.TabIndex = 8;
            docSpecialistLabel.Text = "Doc Specialist:";
            // 
            // docPhoneLabel
            // 
            docPhoneLabel.AutoSize = true;
            docPhoneLabel.Location = new System.Drawing.Point(418, 14);
            docPhoneLabel.Name = "docPhoneLabel";
            docPhoneLabel.Size = new System.Drawing.Size(64, 13);
            docPhoneLabel.TabIndex = 10;
            docPhoneLabel.Text = "Doc Phone:";
            // 
            // docEmailLabel
            // 
            docEmailLabel.AutoSize = true;
            docEmailLabel.Location = new System.Drawing.Point(424, 40);
            docEmailLabel.Name = "docEmailLabel";
            docEmailLabel.Size = new System.Drawing.Size(58, 13);
            docEmailLabel.TabIndex = 12;
            docEmailLabel.Text = "Doc Email:";
            // 
            // docDOBLabel
            // 
            docDOBLabel.AutoSize = true;
            docDOBLabel.Location = new System.Drawing.Point(426, 67);
            docDOBLabel.Name = "docDOBLabel";
            docDOBLabel.Size = new System.Drawing.Size(56, 13);
            docDOBLabel.TabIndex = 14;
            docDOBLabel.Text = "Doc DOB:";
            // 
            // docBloodGroupLabel
            // 
            docBloodGroupLabel.AutoSize = true;
            docBloodGroupLabel.Location = new System.Drawing.Point(390, 92);
            docBloodGroupLabel.Name = "docBloodGroupLabel";
            docBloodGroupLabel.Size = new System.Drawing.Size(92, 13);
            docBloodGroupLabel.TabIndex = 16;
            docBloodGroupLabel.Text = "Doc Blood Group:";
            // 
            // docGenderLabel
            // 
            docGenderLabel.AutoSize = true;
            docGenderLabel.Location = new System.Drawing.Point(414, 118);
            docGenderLabel.Name = "docGenderLabel";
            docGenderLabel.Size = new System.Drawing.Size(68, 13);
            docGenderLabel.TabIndex = 18;
            docGenderLabel.Text = "Doc Gender:";
            // 
            // docAddress1Label
            // 
            docAddress1Label.AutoSize = true;
            docAddress1Label.Location = new System.Drawing.Point(32, 144);
            docAddress1Label.Name = "docAddress1Label";
            docAddress1Label.Size = new System.Drawing.Size(77, 13);
            docAddress1Label.TabIndex = 20;
            docAddress1Label.Text = "Doc Address1:";
            // 
            // docAddress2Label
            // 
            docAddress2Label.AutoSize = true;
            docAddress2Label.Location = new System.Drawing.Point(32, 170);
            docAddress2Label.Name = "docAddress2Label";
            docAddress2Label.Size = new System.Drawing.Size(77, 13);
            docAddress2Label.TabIndex = 22;
            docAddress2Label.Text = "Doc Address2:";
            // 
            // docCityLabel
            // 
            docCityLabel.AutoSize = true;
            docCityLabel.Location = new System.Drawing.Point(432, 144);
            docCityLabel.Name = "docCityLabel";
            docCityLabel.Size = new System.Drawing.Size(50, 13);
            docCityLabel.TabIndex = 24;
            docCityLabel.Text = "Doc City:";
            // 
            // docPINLabel
            // 
            docPINLabel.AutoSize = true;
            docPINLabel.Location = new System.Drawing.Point(431, 170);
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
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BedManagementTableAdapter = null;
            this.tableAdapterManager.BedNumberMastTableAdapter = null;
            this.tableAdapterManager.BedTypeMastTableAdapter = null;
            this.tableAdapterManager.BloodGroupMastTableAdapter = this.bloodGroupMastTableAdapter;
            this.tableAdapterManager.DischargeTableAdapter = null;
            this.tableAdapterManager.DoctorDepartmentMastTableAdapter = null;
            this.tableAdapterManager.DoctorMastTableAdapter = this.doctorMastTableAdapter;
            this.tableAdapterManager.IPDTableAdapter = null;
            this.tableAdapterManager.OPDTableAdapter = null;
            this.tableAdapterManager.PatientMastTableAdapter = null;
            this.tableAdapterManager.PrescriptionTableAdapter = null;
            this.tableAdapterManager.PresMedTableAdapter = null;
            this.tableAdapterManager.TaxMastTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HMS.HMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bloodGroupMastTableAdapter
            // 
            this.bloodGroupMastTableAdapter.ClearBeforeFill = true;
            // 
            // doctorMastBindingNavigator
            // 
            this.doctorMastBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.doctorMastBindingNavigator.BindingSource = this.doctorMastBindingSource;
            this.doctorMastBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.doctorMastBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.doctorMastBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.doctorMastBindingNavigatorSaveItem});
            this.doctorMastBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.doctorMastBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.doctorMastBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.doctorMastBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.doctorMastBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.doctorMastBindingNavigator.Name = "doctorMastBindingNavigator";
            this.doctorMastBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.doctorMastBindingNavigator.Size = new System.Drawing.Size(807, 25);
            this.doctorMastBindingNavigator.TabIndex = 0;
            this.doctorMastBindingNavigator.Text = "bindingNavigator1";
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
            // doctorMastBindingNavigatorSaveItem
            // 
            this.doctorMastBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.doctorMastBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("doctorMastBindingNavigatorSaveItem.Image")));
            this.doctorMastBindingNavigatorSaveItem.Name = "doctorMastBindingNavigatorSaveItem";
            this.doctorMastBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.doctorMastBindingNavigatorSaveItem.Text = "Save Data";
            this.doctorMastBindingNavigatorSaveItem.Click += new System.EventHandler(this.doctorMastBindingNavigatorSaveItem_Click_1);
            // 
            // panel1
            // 
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
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 216);
            this.panel1.TabIndex = 1;
            // 
            // docPINTextBox
            // 
            this.docPINTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorMastBindingSource, "DocPIN", true));
            this.docPINTextBox.Location = new System.Drawing.Point(488, 167);
            this.docPINTextBox.Name = "docPINTextBox";
            this.docPINTextBox.Size = new System.Drawing.Size(203, 20);
            this.docPINTextBox.TabIndex = 27;
            // 
            // docCityTextBox
            // 
            this.docCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorMastBindingSource, "DocCity", true));
            this.docCityTextBox.Location = new System.Drawing.Point(488, 141);
            this.docCityTextBox.Name = "docCityTextBox";
            this.docCityTextBox.Size = new System.Drawing.Size(203, 20);
            this.docCityTextBox.TabIndex = 25;
            // 
            // docAddress2TextBox
            // 
            this.docAddress2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorMastBindingSource, "DocAddress2", true));
            this.docAddress2TextBox.Location = new System.Drawing.Point(115, 167);
            this.docAddress2TextBox.Name = "docAddress2TextBox";
            this.docAddress2TextBox.Size = new System.Drawing.Size(203, 20);
            this.docAddress2TextBox.TabIndex = 23;
            // 
            // docAddress1TextBox
            // 
            this.docAddress1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorMastBindingSource, "DocAddress1", true));
            this.docAddress1TextBox.Location = new System.Drawing.Point(115, 141);
            this.docAddress1TextBox.Name = "docAddress1TextBox";
            this.docAddress1TextBox.Size = new System.Drawing.Size(203, 20);
            this.docAddress1TextBox.TabIndex = 21;
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
            this.docGenderComboBox.Location = new System.Drawing.Point(488, 115);
            this.docGenderComboBox.Name = "docGenderComboBox";
            this.docGenderComboBox.Size = new System.Drawing.Size(203, 21);
            this.docGenderComboBox.TabIndex = 19;
            // 
            // docBloodGroupComboBox
            // 
            this.docBloodGroupComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorMastBindingSource, "DocBloodGroup", true));
            this.docBloodGroupComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bloodGroupMastBindingSource, "BloodGroup", true));
            this.docBloodGroupComboBox.DataSource = this.bloodGroupMastBindingSource;
            this.docBloodGroupComboBox.DisplayMember = "BloodGroup";
            this.docBloodGroupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.docBloodGroupComboBox.FormattingEnabled = true;
            this.docBloodGroupComboBox.Location = new System.Drawing.Point(488, 89);
            this.docBloodGroupComboBox.Name = "docBloodGroupComboBox";
            this.docBloodGroupComboBox.Size = new System.Drawing.Size(203, 21);
            this.docBloodGroupComboBox.TabIndex = 17;
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
            this.docDOBDateTimePicker.Location = new System.Drawing.Point(488, 63);
            this.docDOBDateTimePicker.Name = "docDOBDateTimePicker";
            this.docDOBDateTimePicker.Size = new System.Drawing.Size(203, 20);
            this.docDOBDateTimePicker.TabIndex = 15;
            // 
            // docEmailTextBox
            // 
            this.docEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorMastBindingSource, "DocEmail", true));
            this.docEmailTextBox.Location = new System.Drawing.Point(488, 37);
            this.docEmailTextBox.Name = "docEmailTextBox";
            this.docEmailTextBox.Size = new System.Drawing.Size(203, 20);
            this.docEmailTextBox.TabIndex = 13;
            // 
            // docPhoneTextBox
            // 
            this.docPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorMastBindingSource, "DocPhone", true));
            this.docPhoneTextBox.Location = new System.Drawing.Point(488, 11);
            this.docPhoneTextBox.Name = "docPhoneTextBox";
            this.docPhoneTextBox.Size = new System.Drawing.Size(203, 20);
            this.docPhoneTextBox.TabIndex = 11;
            // 
            // docSpecialistTextBox
            // 
            this.docSpecialistTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorMastBindingSource, "DocSpecialist", true));
            this.docSpecialistTextBox.Location = new System.Drawing.Point(115, 115);
            this.docSpecialistTextBox.Name = "docSpecialistTextBox";
            this.docSpecialistTextBox.Size = new System.Drawing.Size(203, 20);
            this.docSpecialistTextBox.TabIndex = 9;
            // 
            // docQualificationTextBox
            // 
            this.docQualificationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorMastBindingSource, "DocQualification", true));
            this.docQualificationTextBox.Location = new System.Drawing.Point(115, 89);
            this.docQualificationTextBox.Name = "docQualificationTextBox";
            this.docQualificationTextBox.Size = new System.Drawing.Size(203, 20);
            this.docQualificationTextBox.TabIndex = 7;
            // 
            // docDesignationTextBox
            // 
            this.docDesignationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorMastBindingSource, "DocDesignation", true));
            this.docDesignationTextBox.Location = new System.Drawing.Point(115, 63);
            this.docDesignationTextBox.Name = "docDesignationTextBox";
            this.docDesignationTextBox.Size = new System.Drawing.Size(203, 20);
            this.docDesignationTextBox.TabIndex = 5;
            // 
            // docNameTextBox
            // 
            this.docNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorMastBindingSource, "DocName", true));
            this.docNameTextBox.Location = new System.Drawing.Point(115, 37);
            this.docNameTextBox.Name = "docNameTextBox";
            this.docNameTextBox.Size = new System.Drawing.Size(203, 20);
            this.docNameTextBox.TabIndex = 3;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorMastBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(115, 11);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(203, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // doctorMastDataGridView
            // 
            this.doctorMastDataGridView.AllowUserToAddRows = false;
            this.doctorMastDataGridView.AllowUserToDeleteRows = false;
            this.doctorMastDataGridView.AllowUserToOrderColumns = true;
            this.doctorMastDataGridView.AutoGenerateColumns = false;
            this.doctorMastDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorMastDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14});
            this.doctorMastDataGridView.DataSource = this.doctorMastBindingSource;
            this.doctorMastDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.doctorMastDataGridView.Location = new System.Drawing.Point(0, 241);
            this.doctorMastDataGridView.Name = "doctorMastDataGridView";
            this.doctorMastDataGridView.ReadOnly = true;
            this.doctorMastDataGridView.Size = new System.Drawing.Size(807, 347);
            this.doctorMastDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DocName";
            this.dataGridViewTextBoxColumn2.HeaderText = "DocName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DocDesignation";
            this.dataGridViewTextBoxColumn3.HeaderText = "DocDesignation";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DocQualification";
            this.dataGridViewTextBoxColumn4.HeaderText = "DocQualification";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DocSpecialist";
            this.dataGridViewTextBoxColumn5.HeaderText = "DocSpecialist";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DocPhone";
            this.dataGridViewTextBoxColumn6.HeaderText = "DocPhone";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DocEmail";
            this.dataGridViewTextBoxColumn7.HeaderText = "DocEmail";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DocDOB";
            this.dataGridViewTextBoxColumn8.HeaderText = "DocDOB";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "DocBloodGroup";
            this.dataGridViewTextBoxColumn9.HeaderText = "DocBloodGroup";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "DocGender";
            this.dataGridViewTextBoxColumn10.HeaderText = "DocGender";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "DocAddress1";
            this.dataGridViewTextBoxColumn11.HeaderText = "DocAddress1";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "DocAddress2";
            this.dataGridViewTextBoxColumn12.HeaderText = "DocAddress2";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "DocCity";
            this.dataGridViewTextBoxColumn13.HeaderText = "DocCity";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "DocPIN";
            this.dataGridViewTextBoxColumn14.HeaderText = "DocPIN";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            // 
            // DoctorMastFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 588);
            this.Controls.Add(this.doctorMastDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.doctorMastBindingNavigator);
            this.Name = "DoctorMastFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorMast";
            this.Load += new System.EventHandler(this.DoctorMast_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorMastBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorMastBindingNavigator)).EndInit();
            this.doctorMastBindingNavigator.ResumeLayout(false);
            this.doctorMastBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bloodGroupMastBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorMastDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HMSDataSet hMSDataSet;
        private System.Windows.Forms.BindingSource doctorMastBindingSource;
        private HMSDataSetTableAdapters.DoctorMastTableAdapter doctorMastTableAdapter;
        private HMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator doctorMastBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton doctorMastBindingNavigatorSaveItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView doctorMastDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
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
    }
}