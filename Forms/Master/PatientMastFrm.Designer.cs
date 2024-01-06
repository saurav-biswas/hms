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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientMastFrm));
            this.patientMastBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.patientMastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hMSDataSet = new HMS.HMSDataSet();
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
            this.patientMastBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
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
            ((System.ComponentModel.ISupportInitialize)(this.patientMastBindingNavigator)).BeginInit();
            this.patientMastBindingNavigator.SuspendLayout();
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
            idLabel.Location = new System.Drawing.Point(58, 20);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // patNameLabel
            // 
            patNameLabel.AutoSize = true;
            patNameLabel.Location = new System.Drawing.Point(39, 42);
            patNameLabel.Name = "patNameLabel";
            patNameLabel.Size = new System.Drawing.Size(38, 13);
            patNameLabel.TabIndex = 2;
            patNameLabel.Text = "Name:";
            // 
            // patQualificationLabel
            // 
            patQualificationLabel.AutoSize = true;
            patQualificationLabel.Location = new System.Drawing.Point(9, 68);
            patQualificationLabel.Name = "patQualificationLabel";
            patQualificationLabel.Size = new System.Drawing.Size(68, 13);
            patQualificationLabel.TabIndex = 4;
            patQualificationLabel.Text = "Qualification:";
            // 
            // patRefferedByLabel
            // 
            patRefferedByLabel.AutoSize = true;
            patRefferedByLabel.Location = new System.Drawing.Point(11, 94);
            patRefferedByLabel.Name = "patRefferedByLabel";
            patRefferedByLabel.Size = new System.Drawing.Size(66, 13);
            patRefferedByLabel.TabIndex = 6;
            patRefferedByLabel.Text = "Reffered By:";
            // 
            // patPhoneLabel
            // 
            patPhoneLabel.AutoSize = true;
            patPhoneLabel.Location = new System.Drawing.Point(387, 16);
            patPhoneLabel.Name = "patPhoneLabel";
            patPhoneLabel.Size = new System.Drawing.Size(41, 13);
            patPhoneLabel.TabIndex = 8;
            patPhoneLabel.Text = "Phone:";
            // 
            // patEmailLabel
            // 
            patEmailLabel.AutoSize = true;
            patEmailLabel.Location = new System.Drawing.Point(393, 42);
            patEmailLabel.Name = "patEmailLabel";
            patEmailLabel.Size = new System.Drawing.Size(35, 13);
            patEmailLabel.TabIndex = 10;
            patEmailLabel.Text = "Email:";
            // 
            // patDOBLabel
            // 
            patDOBLabel.AutoSize = true;
            patDOBLabel.Location = new System.Drawing.Point(395, 68);
            patDOBLabel.Name = "patDOBLabel";
            patDOBLabel.Size = new System.Drawing.Size(33, 13);
            patDOBLabel.TabIndex = 12;
            patDOBLabel.Text = "DOB:";
            // 
            // patBloodGroupLabel
            // 
            patBloodGroupLabel.AutoSize = true;
            patBloodGroupLabel.Location = new System.Drawing.Point(359, 94);
            patBloodGroupLabel.Name = "patBloodGroupLabel";
            patBloodGroupLabel.Size = new System.Drawing.Size(69, 13);
            patBloodGroupLabel.TabIndex = 14;
            patBloodGroupLabel.Text = "Blood Group:";
            // 
            // patGenderLabel
            // 
            patGenderLabel.AutoSize = true;
            patGenderLabel.Location = new System.Drawing.Point(381, 121);
            patGenderLabel.Name = "patGenderLabel";
            patGenderLabel.Size = new System.Drawing.Size(45, 13);
            patGenderLabel.TabIndex = 16;
            patGenderLabel.Text = "Gender:";
            // 
            // patAddress1Label
            // 
            patAddress1Label.AutoSize = true;
            patAddress1Label.Location = new System.Drawing.Point(29, 148);
            patAddress1Label.Name = "patAddress1Label";
            patAddress1Label.Size = new System.Drawing.Size(48, 13);
            patAddress1Label.TabIndex = 18;
            patAddress1Label.Text = "Address:";
            // 
            // patCityLabel
            // 
            patCityLabel.AutoSize = true;
            patCityLabel.Location = new System.Drawing.Point(399, 148);
            patCityLabel.Name = "patCityLabel";
            patCityLabel.Size = new System.Drawing.Size(27, 13);
            patCityLabel.TabIndex = 22;
            patCityLabel.Text = "City:";
            // 
            // patPINLabel
            // 
            patPINLabel.AutoSize = true;
            patPINLabel.Location = new System.Drawing.Point(398, 174);
            patPINLabel.Name = "patPINLabel";
            patPINLabel.Size = new System.Drawing.Size(28, 13);
            patPINLabel.TabIndex = 24;
            patPINLabel.Text = "PIN:";
            // 
            // patientMastBindingNavigator
            // 
            this.patientMastBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.patientMastBindingNavigator.BindingSource = this.patientMastBindingSource;
            this.patientMastBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.patientMastBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.patientMastBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.patientMastBindingNavigatorSaveItem});
            this.patientMastBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.patientMastBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.patientMastBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.patientMastBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.patientMastBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.patientMastBindingNavigator.Name = "patientMastBindingNavigator";
            this.patientMastBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.patientMastBindingNavigator.Size = new System.Drawing.Size(830, 25);
            this.patientMastBindingNavigator.TabIndex = 0;
            this.patientMastBindingNavigator.Text = "bindingNavigator1";
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
            // patientMastBindingNavigatorSaveItem
            // 
            this.patientMastBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.patientMastBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("patientMastBindingNavigatorSaveItem.Image")));
            this.patientMastBindingNavigatorSaveItem.Name = "patientMastBindingNavigatorSaveItem";
            this.patientMastBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.patientMastBindingNavigatorSaveItem.Text = "Save Data";
            this.patientMastBindingNavigatorSaveItem.Click += new System.EventHandler(this.patientMastBindingNavigatorSaveItem_Click);
            // 
            // panel1
            // 
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
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 219);
            this.panel1.TabIndex = 2;
            // 
            // patPINTextBox
            // 
            this.patPINTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientMastBindingSource, "PatPIN", true));
            this.patPINTextBox.Location = new System.Drawing.Point(434, 171);
            this.patPINTextBox.Name = "patPINTextBox";
            this.patPINTextBox.Size = new System.Drawing.Size(203, 20);
            this.patPINTextBox.TabIndex = 25;
            // 
            // patCityTextBox
            // 
            this.patCityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientMastBindingSource, "PatCity", true));
            this.patCityTextBox.Location = new System.Drawing.Point(434, 145);
            this.patCityTextBox.Name = "patCityTextBox";
            this.patCityTextBox.Size = new System.Drawing.Size(203, 20);
            this.patCityTextBox.TabIndex = 23;
            // 
            // patAddress2TextBox
            // 
            this.patAddress2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientMastBindingSource, "PatAddress2", true));
            this.patAddress2TextBox.Location = new System.Drawing.Point(83, 171);
            this.patAddress2TextBox.Name = "patAddress2TextBox";
            this.patAddress2TextBox.Size = new System.Drawing.Size(203, 20);
            this.patAddress2TextBox.TabIndex = 21;
            // 
            // patAddress1TextBox
            // 
            this.patAddress1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientMastBindingSource, "PatAddress1", true));
            this.patAddress1TextBox.Location = new System.Drawing.Point(83, 145);
            this.patAddress1TextBox.Name = "patAddress1TextBox";
            this.patAddress1TextBox.Size = new System.Drawing.Size(203, 20);
            this.patAddress1TextBox.TabIndex = 19;
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
            this.patGenderComboBox.Location = new System.Drawing.Point(434, 118);
            this.patGenderComboBox.Name = "patGenderComboBox";
            this.patGenderComboBox.Size = new System.Drawing.Size(203, 21);
            this.patGenderComboBox.TabIndex = 17;
            // 
            // patBloodGroupComboBox
            // 
            this.patBloodGroupComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientMastBindingSource, "PatBloodGroup", true));
            this.patBloodGroupComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bloodGroupMastBindingSource, "BloodGroup", true));
            this.patBloodGroupComboBox.DataSource = this.bloodGroupMastBindingSource;
            this.patBloodGroupComboBox.DisplayMember = "BloodGroup";
            this.patBloodGroupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.patBloodGroupComboBox.FormattingEnabled = true;
            this.patBloodGroupComboBox.Location = new System.Drawing.Point(434, 91);
            this.patBloodGroupComboBox.Name = "patBloodGroupComboBox";
            this.patBloodGroupComboBox.Size = new System.Drawing.Size(203, 21);
            this.patBloodGroupComboBox.TabIndex = 15;
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
            this.patDOBDateTimePicker.Location = new System.Drawing.Point(434, 65);
            this.patDOBDateTimePicker.Name = "patDOBDateTimePicker";
            this.patDOBDateTimePicker.Size = new System.Drawing.Size(203, 20);
            this.patDOBDateTimePicker.TabIndex = 13;
            // 
            // patEmailTextBox
            // 
            this.patEmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientMastBindingSource, "PatEmail", true));
            this.patEmailTextBox.Location = new System.Drawing.Point(434, 39);
            this.patEmailTextBox.Name = "patEmailTextBox";
            this.patEmailTextBox.Size = new System.Drawing.Size(203, 20);
            this.patEmailTextBox.TabIndex = 11;
            // 
            // patPhoneTextBox
            // 
            this.patPhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientMastBindingSource, "PatPhone", true));
            this.patPhoneTextBox.Location = new System.Drawing.Point(434, 13);
            this.patPhoneTextBox.Name = "patPhoneTextBox";
            this.patPhoneTextBox.Size = new System.Drawing.Size(203, 20);
            this.patPhoneTextBox.TabIndex = 9;
            // 
            // patRefferedByTextBox
            // 
            this.patRefferedByTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientMastBindingSource, "PatRefferedBy", true));
            this.patRefferedByTextBox.Location = new System.Drawing.Point(83, 91);
            this.patRefferedByTextBox.Name = "patRefferedByTextBox";
            this.patRefferedByTextBox.Size = new System.Drawing.Size(203, 20);
            this.patRefferedByTextBox.TabIndex = 7;
            // 
            // patQualificationTextBox
            // 
            this.patQualificationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientMastBindingSource, "PatQualification", true));
            this.patQualificationTextBox.Location = new System.Drawing.Point(83, 65);
            this.patQualificationTextBox.Name = "patQualificationTextBox";
            this.patQualificationTextBox.Size = new System.Drawing.Size(203, 20);
            this.patQualificationTextBox.TabIndex = 5;
            // 
            // patNameTextBox
            // 
            this.patNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientMastBindingSource, "PatName", true));
            this.patNameTextBox.Location = new System.Drawing.Point(83, 39);
            this.patNameTextBox.Name = "patNameTextBox";
            this.patNameTextBox.Size = new System.Drawing.Size(203, 20);
            this.patNameTextBox.TabIndex = 3;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientMastBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(83, 13);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(203, 20);
            this.idTextBox.TabIndex = 1;
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
            this.tableAdapterManager.DischargeTableAdapter = null;
            this.tableAdapterManager.DoctorDepartmentMastTableAdapter = null;
            this.tableAdapterManager.DoctorMastTableAdapter = null;
            this.tableAdapterManager.IPDTableAdapter = null;
            this.tableAdapterManager.OPDTableAdapter = null;
            this.tableAdapterManager.PatientMastTableAdapter = this.patientMastTableAdapter;
            this.tableAdapterManager.PrescriptionTableAdapter = null;
            this.tableAdapterManager.PresMedTableAdapter = null;
            this.tableAdapterManager.TaxMastTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HMS.HMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.patientMastDataGridView.AutoGenerateColumns = false;
            this.patientMastDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientMastDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.patientMastDataGridView.DataSource = this.patientMastBindingSource;
            this.patientMastDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.patientMastDataGridView.Location = new System.Drawing.Point(0, 244);
            this.patientMastDataGridView.Name = "patientMastDataGridView";
            this.patientMastDataGridView.Size = new System.Drawing.Size(830, 342);
            this.patientMastDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PatName";
            this.dataGridViewTextBoxColumn1.HeaderText = "PatName";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PatQualification";
            this.dataGridViewTextBoxColumn2.HeaderText = "PatQualification";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PatPhone";
            this.dataGridViewTextBoxColumn3.HeaderText = "PatPhone";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PatEmail";
            this.dataGridViewTextBoxColumn4.HeaderText = "PatEmail";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PatDOB";
            this.dataGridViewTextBoxColumn5.HeaderText = "PatDOB";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "PatBloodGroup";
            this.dataGridViewTextBoxColumn6.HeaderText = "PatBloodGroup";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "PatGender";
            this.dataGridViewTextBoxColumn7.HeaderText = "PatGender";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PatAddress1";
            this.dataGridViewTextBoxColumn8.HeaderText = "PatAddress1";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "PatAddress2";
            this.dataGridViewTextBoxColumn9.HeaderText = "PatAddress2";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "PatCity";
            this.dataGridViewTextBoxColumn10.HeaderText = "PatCity";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "PatPIN";
            this.dataGridViewTextBoxColumn11.HeaderText = "PatPIN";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "PatRefferedBy";
            this.dataGridViewTextBoxColumn12.HeaderText = "PatRefferedBy";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn13.HeaderText = "Id";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "PatAdvAmt";
            this.dataGridViewTextBoxColumn14.HeaderText = "PatAdvAmt";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // PatientMastFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 586);
            this.Controls.Add(this.patientMastDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.patientMastBindingNavigator);
            this.Name = "PatientMastFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Master";
            this.Load += new System.EventHandler(this.PatientMastFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientMastBindingNavigator)).EndInit();
            this.patientMastBindingNavigator.ResumeLayout(false);
            this.patientMastBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientMastBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bloodGroupMastBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorMastBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientMastDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HMSDataSet hMSDataSet;
        private System.Windows.Forms.BindingSource patientMastBindingSource;
        private HMSDataSetTableAdapters.PatientMastTableAdapter patientMastTableAdapter;
        private HMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator patientMastBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton patientMastBindingNavigatorSaveItem;
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
        private System.Windows.Forms.DataGridView patientMastDataGridView;
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
    }
}