namespace HMS.Forms.Transaction
{
    partial class OPD
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
            System.Windows.Forms.Label patientLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label heightLabel;
            System.Windows.Forms.Label weightLabel;
            System.Windows.Forms.Label bloodPressureLabel;
            System.Windows.Forms.Label doctorLabel;
            System.Windows.Forms.Label doctorChargesLabel;
            System.Windows.Forms.Label paymentModeLabel;
            System.Windows.Forms.Label symptomsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OPD));
            System.Windows.Forms.Label oPDDateLabel;
            this.hMSDataSet = new HMS.HMSDataSet();
            this.oPDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oPDTableAdapter = new HMS.HMSDataSetTableAdapters.OPDTableAdapter();
            this.tableAdapterManager = new HMS.HMSDataSetTableAdapters.TableAdapterManager();
            this.doctorMastTableAdapter = new HMS.HMSDataSetTableAdapters.DoctorMastTableAdapter();
            this.patientMastTableAdapter = new HMS.HMSDataSetTableAdapters.PatientMastTableAdapter();
            this.oPDBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.oPDBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.symptomsTextBox = new System.Windows.Forms.TextBox();
            this.paymentModeComboBox = new System.Windows.Forms.ComboBox();
            this.doctorChargesTextBox = new System.Windows.Forms.TextBox();
            this.doctorComboBox = new System.Windows.Forms.ComboBox();
            this.doctorMastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bloodPressureTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.patientComboBox = new System.Windows.Forms.ComboBox();
            this.patientMastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.oPDDataGridView = new System.Windows.Forms.DataGridView();
            this.oPDDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPDDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            patientLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            heightLabel = new System.Windows.Forms.Label();
            weightLabel = new System.Windows.Forms.Label();
            bloodPressureLabel = new System.Windows.Forms.Label();
            doctorLabel = new System.Windows.Forms.Label();
            doctorChargesLabel = new System.Windows.Forms.Label();
            paymentModeLabel = new System.Windows.Forms.Label();
            symptomsLabel = new System.Windows.Forms.Label();
            oPDDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPDBindingNavigator)).BeginInit();
            this.oPDBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorMastBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientMastBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPDDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(64, 16);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // patientLabel
            // 
            patientLabel.AutoSize = true;
            patientLabel.Location = new System.Drawing.Point(40, 42);
            patientLabel.Name = "patientLabel";
            patientLabel.Size = new System.Drawing.Size(43, 13);
            patientLabel.TabIndex = 2;
            patientLabel.Text = "Patient:";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new System.Drawing.Point(54, 69);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(29, 13);
            ageLabel.TabIndex = 4;
            ageLabel.Text = "Age:";
            // 
            // heightLabel
            // 
            heightLabel.AutoSize = true;
            heightLabel.Location = new System.Drawing.Point(42, 95);
            heightLabel.Name = "heightLabel";
            heightLabel.Size = new System.Drawing.Size(41, 13);
            heightLabel.TabIndex = 6;
            heightLabel.Text = "Height:";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new System.Drawing.Point(39, 121);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(44, 13);
            weightLabel.TabIndex = 8;
            weightLabel.Text = "Weight:";
            // 
            // bloodPressureLabel
            // 
            bloodPressureLabel.AutoSize = true;
            bloodPressureLabel.Location = new System.Drawing.Point(2, 147);
            bloodPressureLabel.Name = "bloodPressureLabel";
            bloodPressureLabel.Size = new System.Drawing.Size(81, 13);
            bloodPressureLabel.TabIndex = 10;
            bloodPressureLabel.Text = "Blood Pressure:";
            // 
            // doctorLabel
            // 
            doctorLabel.AutoSize = true;
            doctorLabel.Location = new System.Drawing.Point(406, 42);
            doctorLabel.Name = "doctorLabel";
            doctorLabel.Size = new System.Drawing.Size(42, 13);
            doctorLabel.TabIndex = 12;
            doctorLabel.Text = "Doctor:";
            // 
            // doctorChargesLabel
            // 
            doctorChargesLabel.AutoSize = true;
            doctorChargesLabel.Location = new System.Drawing.Point(364, 69);
            doctorChargesLabel.Name = "doctorChargesLabel";
            doctorChargesLabel.Size = new System.Drawing.Size(84, 13);
            doctorChargesLabel.TabIndex = 14;
            doctorChargesLabel.Text = "Doctor Charges:";
            // 
            // paymentModeLabel
            // 
            paymentModeLabel.AutoSize = true;
            paymentModeLabel.Location = new System.Drawing.Point(367, 95);
            paymentModeLabel.Name = "paymentModeLabel";
            paymentModeLabel.Size = new System.Drawing.Size(81, 13);
            paymentModeLabel.TabIndex = 16;
            paymentModeLabel.Text = "Payment Mode:";
            // 
            // symptomsLabel
            // 
            symptomsLabel.AutoSize = true;
            symptomsLabel.Location = new System.Drawing.Point(390, 124);
            symptomsLabel.Name = "symptomsLabel";
            symptomsLabel.Size = new System.Drawing.Size(58, 13);
            symptomsLabel.TabIndex = 18;
            symptomsLabel.Text = "Symptoms:";
            // 
            // hMSDataSet
            // 
            this.hMSDataSet.DataSetName = "HMSDataSet";
            this.hMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oPDBindingSource
            // 
            this.oPDBindingSource.DataMember = "OPD";
            this.oPDBindingSource.DataSource = this.hMSDataSet;
            // 
            // oPDTableAdapter
            // 
            this.oPDTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BedManagementTableAdapter = null;
            this.tableAdapterManager.BedNumberMastTableAdapter = null;
            this.tableAdapterManager.BedTypeMastTableAdapter = null;
            this.tableAdapterManager.BloodGroupMastTableAdapter = null;
            this.tableAdapterManager.DischargeTableAdapter = null;
            this.tableAdapterManager.DoctorDepartmentMastTableAdapter = null;
            this.tableAdapterManager.DoctorMastTableAdapter = this.doctorMastTableAdapter;
            this.tableAdapterManager.IPDTableAdapter = null;
            this.tableAdapterManager.OPDTableAdapter = this.oPDTableAdapter;
            this.tableAdapterManager.PatientMastTableAdapter = this.patientMastTableAdapter;
            this.tableAdapterManager.PrescriptionTableAdapter = null;
            this.tableAdapterManager.PresMedTableAdapter = null;
            this.tableAdapterManager.TaxMastTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HMS.HMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // doctorMastTableAdapter
            // 
            this.doctorMastTableAdapter.ClearBeforeFill = true;
            // 
            // patientMastTableAdapter
            // 
            this.patientMastTableAdapter.ClearBeforeFill = true;
            // 
            // oPDBindingNavigator
            // 
            this.oPDBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.oPDBindingNavigator.BindingSource = this.oPDBindingSource;
            this.oPDBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.oPDBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.oPDBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.oPDBindingNavigatorSaveItem});
            this.oPDBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.oPDBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.oPDBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.oPDBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.oPDBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.oPDBindingNavigator.Name = "oPDBindingNavigator";
            this.oPDBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.oPDBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.oPDBindingNavigator.TabIndex = 0;
            this.oPDBindingNavigator.Text = "bindingNavigator1";
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
            // oPDBindingNavigatorSaveItem
            // 
            this.oPDBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.oPDBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("oPDBindingNavigatorSaveItem.Image")));
            this.oPDBindingNavigatorSaveItem.Name = "oPDBindingNavigatorSaveItem";
            this.oPDBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.oPDBindingNavigatorSaveItem.Text = "Save Data";
            this.oPDBindingNavigatorSaveItem.Click += new System.EventHandler(this.oPDBindingNavigatorSaveItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(oPDDateLabel);
            this.panel1.Controls.Add(this.oPDDateDateTimePicker);
            this.panel1.Controls.Add(symptomsLabel);
            this.panel1.Controls.Add(this.symptomsTextBox);
            this.panel1.Controls.Add(paymentModeLabel);
            this.panel1.Controls.Add(this.paymentModeComboBox);
            this.panel1.Controls.Add(doctorChargesLabel);
            this.panel1.Controls.Add(this.doctorChargesTextBox);
            this.panel1.Controls.Add(doctorLabel);
            this.panel1.Controls.Add(this.doctorComboBox);
            this.panel1.Controls.Add(bloodPressureLabel);
            this.panel1.Controls.Add(this.bloodPressureTextBox);
            this.panel1.Controls.Add(weightLabel);
            this.panel1.Controls.Add(this.weightTextBox);
            this.panel1.Controls.Add(heightLabel);
            this.panel1.Controls.Add(this.heightTextBox);
            this.panel1.Controls.Add(ageLabel);
            this.panel1.Controls.Add(this.ageTextBox);
            this.panel1.Controls.Add(patientLabel);
            this.panel1.Controls.Add(this.patientComboBox);
            this.panel1.Controls.Add(idLabel);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 185);
            this.panel1.TabIndex = 2;
            // 
            // symptomsTextBox
            // 
            this.symptomsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oPDBindingSource, "Symptoms", true));
            this.symptomsTextBox.Location = new System.Drawing.Point(454, 121);
            this.symptomsTextBox.Name = "symptomsTextBox";
            this.symptomsTextBox.Size = new System.Drawing.Size(203, 20);
            this.symptomsTextBox.TabIndex = 19;
            // 
            // paymentModeComboBox
            // 
            this.paymentModeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oPDBindingSource, "PaymentMode", true));
            this.paymentModeComboBox.FormattingEnabled = true;
            this.paymentModeComboBox.Items.AddRange(new object[] {
            "UPI",
            "Cash",
            "Card",
            "Bank Transfer"});
            this.paymentModeComboBox.Location = new System.Drawing.Point(454, 92);
            this.paymentModeComboBox.Name = "paymentModeComboBox";
            this.paymentModeComboBox.Size = new System.Drawing.Size(203, 21);
            this.paymentModeComboBox.TabIndex = 17;
            // 
            // doctorChargesTextBox
            // 
            this.doctorChargesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oPDBindingSource, "DoctorCharges", true));
            this.doctorChargesTextBox.Location = new System.Drawing.Point(454, 66);
            this.doctorChargesTextBox.Name = "doctorChargesTextBox";
            this.doctorChargesTextBox.Size = new System.Drawing.Size(203, 20);
            this.doctorChargesTextBox.TabIndex = 15;
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oPDBindingSource, "Doctor", true));
            this.doctorComboBox.DataSource = this.doctorMastBindingSource;
            this.doctorComboBox.DisplayMember = "DocName";
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.Location = new System.Drawing.Point(454, 39);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(203, 21);
            this.doctorComboBox.TabIndex = 13;
            this.doctorComboBox.ValueMember = "DocName";
            // 
            // doctorMastBindingSource
            // 
            this.doctorMastBindingSource.DataMember = "DoctorMast";
            this.doctorMastBindingSource.DataSource = this.hMSDataSet;
            // 
            // bloodPressureTextBox
            // 
            this.bloodPressureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oPDBindingSource, "BloodPressure", true));
            this.bloodPressureTextBox.Location = new System.Drawing.Point(89, 144);
            this.bloodPressureTextBox.Name = "bloodPressureTextBox";
            this.bloodPressureTextBox.Size = new System.Drawing.Size(203, 20);
            this.bloodPressureTextBox.TabIndex = 11;
            // 
            // weightTextBox
            // 
            this.weightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oPDBindingSource, "Weight", true));
            this.weightTextBox.Location = new System.Drawing.Point(89, 118);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(203, 20);
            this.weightTextBox.TabIndex = 9;
            // 
            // heightTextBox
            // 
            this.heightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oPDBindingSource, "Height", true));
            this.heightTextBox.Location = new System.Drawing.Point(89, 92);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.Size = new System.Drawing.Size(203, 20);
            this.heightTextBox.TabIndex = 7;
            // 
            // ageTextBox
            // 
            this.ageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oPDBindingSource, "Age", true));
            this.ageTextBox.Location = new System.Drawing.Point(89, 66);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(203, 20);
            this.ageTextBox.TabIndex = 5;
            // 
            // patientComboBox
            // 
            this.patientComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oPDBindingSource, "Patient", true));
            this.patientComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.patientMastBindingSource, "PatName", true));
            this.patientComboBox.DataSource = this.patientMastBindingSource;
            this.patientComboBox.DisplayMember = "PatName";
            this.patientComboBox.FormattingEnabled = true;
            this.patientComboBox.Location = new System.Drawing.Point(89, 39);
            this.patientComboBox.Name = "patientComboBox";
            this.patientComboBox.Size = new System.Drawing.Size(203, 21);
            this.patientComboBox.TabIndex = 3;
            this.patientComboBox.ValueMember = "PatName";
            // 
            // patientMastBindingSource
            // 
            this.patientMastBindingSource.DataMember = "PatientMast";
            this.patientMastBindingSource.DataSource = this.hMSDataSet;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.oPDBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(89, 13);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(203, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // oPDDataGridView
            // 
            this.oPDDataGridView.AutoGenerateColumns = false;
            this.oPDDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oPDDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.OPDDate,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.oPDDataGridView.DataSource = this.oPDBindingSource;
            this.oPDDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oPDDataGridView.Location = new System.Drawing.Point(0, 210);
            this.oPDDataGridView.Name = "oPDDataGridView";
            this.oPDDataGridView.Size = new System.Drawing.Size(800, 274);
            this.oPDDataGridView.TabIndex = 2;
            // 
            // oPDDateLabel
            // 
            oPDDateLabel.AutoSize = true;
            oPDDateLabel.Location = new System.Drawing.Point(415, 16);
            oPDDateLabel.Name = "oPDDateLabel";
            oPDDateLabel.Size = new System.Drawing.Size(33, 13);
            oPDDateLabel.TabIndex = 20;
            oPDDateLabel.Text = "Date:";
            // 
            // oPDDateDateTimePicker
            // 
            this.oPDDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.oPDBindingSource, "OPDDate", true));
            this.oPDDateDateTimePicker.Location = new System.Drawing.Point(454, 13);
            this.oPDDateDateTimePicker.Name = "oPDDateDateTimePicker";
            this.oPDDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.oPDDateDateTimePicker.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // OPDDate
            // 
            this.OPDDate.DataPropertyName = "OPDDate";
            this.OPDDate.HeaderText = "Date";
            this.OPDDate.Name = "OPDDate";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Patient";
            this.dataGridViewTextBoxColumn2.HeaderText = "Patient";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn3.HeaderText = "Age";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Height";
            this.dataGridViewTextBoxColumn4.HeaderText = "Height";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Weight";
            this.dataGridViewTextBoxColumn5.HeaderText = "Weight";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "BloodPressure";
            this.dataGridViewTextBoxColumn6.HeaderText = "BloodPressure";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Doctor";
            this.dataGridViewTextBoxColumn7.HeaderText = "Doctor";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "DoctorCharges";
            this.dataGridViewTextBoxColumn8.HeaderText = "DoctorCharges";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "PaymentMode";
            this.dataGridViewTextBoxColumn9.HeaderText = "PaymentMode";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Symptoms";
            this.dataGridViewTextBoxColumn10.HeaderText = "Symptoms";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // OPD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 484);
            this.Controls.Add(this.oPDDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.oPDBindingNavigator);
            this.Name = "OPD";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OPD";
            this.Load += new System.EventHandler(this.OPD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPDBindingNavigator)).EndInit();
            this.oPDBindingNavigator.ResumeLayout(false);
            this.oPDBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorMastBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientMastBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPDDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HMSDataSet hMSDataSet;
        private System.Windows.Forms.BindingSource oPDBindingSource;
        private HMSDataSetTableAdapters.OPDTableAdapter oPDTableAdapter;
        private HMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator oPDBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton oPDBindingNavigatorSaveItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox bloodPressureTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.ComboBox patientComboBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.DataGridView oPDDataGridView;
        private System.Windows.Forms.TextBox symptomsTextBox;
        private System.Windows.Forms.ComboBox paymentModeComboBox;
        private System.Windows.Forms.TextBox doctorChargesTextBox;
        private System.Windows.Forms.ComboBox doctorComboBox;
        private HMSDataSetTableAdapters.PatientMastTableAdapter patientMastTableAdapter;
        private System.Windows.Forms.BindingSource patientMastBindingSource;
        private HMSDataSetTableAdapters.DoctorMastTableAdapter doctorMastTableAdapter;
        private System.Windows.Forms.BindingSource doctorMastBindingSource;
        private System.Windows.Forms.DateTimePicker oPDDateDateTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPDDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
    }
}