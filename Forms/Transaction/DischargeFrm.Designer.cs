namespace HMS.Forms.Transaction
{
    partial class DischargeFrm
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
            System.Windows.Forms.Label dischargeByLabel;
            System.Windows.Forms.Label commentLabel;
            System.Windows.Forms.Label nextVisitNoLabel;
            System.Windows.Forms.Label dischargeDateLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.Label diagnosisLabel;
            System.Windows.Forms.Label label5;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DischargeFrm));
            this.hMSDataSet = new HMS.HMSDataSet();
            this.dischargeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new HMS.HMSDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonIPD = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.dischargeByComboBox = new System.Windows.Forms.ComboBox();
            this.doctorMastBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.IPDSearchtextBox = new System.Windows.Forms.TextBox();
            this.nextVisitNoTextBox = new System.Windows.Forms.TextBox();
            this.AdmissiondateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.nextVisitUnitComboBox = new System.Windows.Forms.ComboBox();
            this.PINtextBox = new System.Windows.Forms.TextBox();
            this.DischargeDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.CitytextBox = new System.Windows.Forms.TextBox();
            this.Address2textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PatNametextBox = new System.Windows.Forms.TextBox();
            this.Address1textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GendertextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.diagnosisTextBox = new System.Windows.Forms.TextBox();
            this.AgetextBox = new System.Windows.Forms.TextBox();
            this.tabPageAdvices = new System.Windows.Forms.TabPage();
            this.AdvicesdataGridView = new System.Windows.Forms.DataGridView();
            this.DisID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perticulars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Savebutton = new System.Windows.Forms.Button();
            this.printbutton = new System.Windows.Forms.Button();
            this.doctorMastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientMastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iPDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dischargeDataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IPDNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DischargeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DischargeBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorMastTableAdapter = new HMS.HMSDataSetTableAdapters.DoctorMastTableAdapter();
            idLabel = new System.Windows.Forms.Label();
            dischargeByLabel = new System.Windows.Forms.Label();
            commentLabel = new System.Windows.Forms.Label();
            nextVisitNoLabel = new System.Windows.Forms.Label();
            dischargeDateLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            diagnosisLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dischargeBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorMastBindingSource1)).BeginInit();
            this.tabPageAdvices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdvicesdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorMastBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientMastBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dischargeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(19, 20);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(70, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "Discharge Id:";
            // 
            // dischargeByLabel
            // 
            dischargeByLabel.AutoSize = true;
            dischargeByLabel.Location = new System.Drawing.Point(16, 73);
            dischargeByLabel.Name = "dischargeByLabel";
            dischargeByLabel.Size = new System.Drawing.Size(73, 13);
            dischargeByLabel.TabIndex = 4;
            dischargeByLabel.Text = "Discharge By:";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Location = new System.Drawing.Point(357, 95);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(54, 13);
            commentLabel.TabIndex = 6;
            commentLabel.Text = "Comment:";
            // 
            // nextVisitNoLabel
            // 
            nextVisitNoLabel.AutoSize = true;
            nextVisitNoLabel.Location = new System.Drawing.Point(340, 121);
            nextVisitNoLabel.Name = "nextVisitNoLabel";
            nextVisitNoLabel.Size = new System.Drawing.Size(71, 13);
            nextVisitNoLabel.TabIndex = 8;
            nextVisitNoLabel.Text = "Next Visit No:";
            // 
            // dischargeDateLabel
            // 
            dischargeDateLabel.AutoSize = true;
            dischargeDateLabel.Location = new System.Drawing.Point(5, 101);
            dischargeDateLabel.Name = "dischargeDateLabel";
            dischargeDateLabel.Size = new System.Drawing.Size(84, 13);
            dischargeDateLabel.TabIndex = 11;
            dischargeDateLabel.Text = "Discharge Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(328, 44);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(74, 13);
            label1.TabIndex = 45;
            label1.Text = "Patient Name:";
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(61, 47);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(28, 13);
            idLabel1.TabIndex = 46;
            idLabel1.Text = "IPD:";
            // 
            // diagnosisLabel
            // 
            diagnosisLabel.AutoSize = true;
            diagnosisLabel.Location = new System.Drawing.Point(355, 73);
            diagnosisLabel.Name = "diagnosisLabel";
            diagnosisLabel.Size = new System.Drawing.Size(56, 13);
            diagnosisLabel.TabIndex = 48;
            diagnosisLabel.Text = "Diagnosis:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(4, 127);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(83, 13);
            label5.TabIndex = 62;
            label5.Text = "Admission Date:";
            // 
            // hMSDataSet
            // 
            this.hMSDataSet.DataSetName = "HMSDataSet";
            this.hMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dischargeBindingSource
            // 
            this.dischargeBindingSource.DataMember = "Discharge";
            this.dischargeBindingSource.DataSource = this.hMSDataSet;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonIPD);
            this.panel1.Controls.Add(this.buttonDel);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.Savebutton);
            this.panel1.Controls.Add(this.printbutton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 294);
            this.panel1.TabIndex = 2;
            // 
            // buttonIPD
            // 
            this.buttonIPD.Location = new System.Drawing.Point(785, 17);
            this.buttonIPD.Name = "buttonIPD";
            this.buttonIPD.Size = new System.Drawing.Size(75, 23);
            this.buttonIPD.TabIndex = 93;
            this.buttonIPD.Text = "IPD";
            this.buttonIPD.UseVisualStyleBackColor = true;
            this.buttonIPD.Click += new System.EventHandler(this.buttonIPD_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(406, 17);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 92;
            this.buttonDel.Text = "Delete";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMain);
            this.tabControl1.Controls.Add(this.tabPageAdvices);
            this.tabControl1.Location = new System.Drawing.Point(12, 46);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(877, 242);
            this.tabControl1.TabIndex = 91;
            // 
            // tabPageMain
            // 
            this.tabPageMain.Controls.Add(idLabel);
            this.tabPageMain.Controls.Add(this.idTextBox);
            this.tabPageMain.Controls.Add(this.dischargeByComboBox);
            this.tabPageMain.Controls.Add(dischargeByLabel);
            this.tabPageMain.Controls.Add(this.commentTextBox);
            this.tabPageMain.Controls.Add(this.IPDSearchtextBox);
            this.tabPageMain.Controls.Add(commentLabel);
            this.tabPageMain.Controls.Add(label5);
            this.tabPageMain.Controls.Add(this.nextVisitNoTextBox);
            this.tabPageMain.Controls.Add(this.AdmissiondateTimePicker);
            this.tabPageMain.Controls.Add(nextVisitNoLabel);
            this.tabPageMain.Controls.Add(this.label7);
            this.tabPageMain.Controls.Add(this.nextVisitUnitComboBox);
            this.tabPageMain.Controls.Add(this.PINtextBox);
            this.tabPageMain.Controls.Add(this.DischargeDateDateTimePicker);
            this.tabPageMain.Controls.Add(this.label6);
            this.tabPageMain.Controls.Add(dischargeDateLabel);
            this.tabPageMain.Controls.Add(this.CitytextBox);
            this.tabPageMain.Controls.Add(this.Address2textBox);
            this.tabPageMain.Controls.Add(this.label4);
            this.tabPageMain.Controls.Add(this.PatNametextBox);
            this.tabPageMain.Controls.Add(this.Address1textBox);
            this.tabPageMain.Controls.Add(label1);
            this.tabPageMain.Controls.Add(this.label3);
            this.tabPageMain.Controls.Add(this.GendertextBox);
            this.tabPageMain.Controls.Add(idLabel1);
            this.tabPageMain.Controls.Add(this.label2);
            this.tabPageMain.Controls.Add(this.diagnosisTextBox);
            this.tabPageMain.Controls.Add(this.AgetextBox);
            this.tabPageMain.Controls.Add(diagnosisLabel);
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(869, 216);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Main";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dischargeBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(95, 17);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(203, 20);
            this.idTextBox.TabIndex = 0;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // dischargeByComboBox
            // 
            this.dischargeByComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dischargeBindingSource, "DischargeBy", true));
            this.dischargeByComboBox.DataSource = this.doctorMastBindingSource1;
            this.dischargeByComboBox.DisplayMember = "DocName";
            this.dischargeByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dischargeByComboBox.FormattingEnabled = true;
            this.dischargeByComboBox.Location = new System.Drawing.Point(95, 70);
            this.dischargeByComboBox.Name = "dischargeByComboBox";
            this.dischargeByComboBox.Size = new System.Drawing.Size(203, 21);
            this.dischargeByComboBox.TabIndex = 3;
            this.dischargeByComboBox.ValueMember = "DocName";
            // 
            // doctorMastBindingSource1
            // 
            this.doctorMastBindingSource1.DataMember = "DoctorMast";
            this.doctorMastBindingSource1.DataSource = this.hMSDataSet;
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dischargeBindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(417, 92);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(203, 20);
            this.commentTextBox.TabIndex = 8;
            // 
            // IPDSearchtextBox
            // 
            this.IPDSearchtextBox.Location = new System.Drawing.Point(94, 44);
            this.IPDSearchtextBox.Name = "IPDSearchtextBox";
            this.IPDSearchtextBox.Size = new System.Drawing.Size(203, 20);
            this.IPDSearchtextBox.TabIndex = 5;
            this.IPDSearchtextBox.TextChanged += new System.EventHandler(this.IPDSearchtextBox_TextChanged);
            // 
            // nextVisitNoTextBox
            // 
            this.nextVisitNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dischargeBindingSource, "NextVisitNo", true));
            this.nextVisitNoTextBox.Location = new System.Drawing.Point(417, 118);
            this.nextVisitNoTextBox.Name = "nextVisitNoTextBox";
            this.nextVisitNoTextBox.Size = new System.Drawing.Size(74, 20);
            this.nextVisitNoTextBox.TabIndex = 9;
            // 
            // AdmissiondateTimePicker
            // 
            this.AdmissiondateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dischargeBindingSource, "DischargeDate", true));
            this.AdmissiondateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AdmissiondateTimePicker.Location = new System.Drawing.Point(94, 123);
            this.AdmissiondateTimePicker.Name = "AdmissiondateTimePicker";
            this.AdmissiondateTimePicker.Size = new System.Drawing.Size(203, 20);
            this.AdmissiondateTimePicker.TabIndex = 6;
            this.AdmissiondateTimePicker.ValueChanged += new System.EventHandler(this.AdmissiondateTimePicker_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(654, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "PIN";
            // 
            // nextVisitUnitComboBox
            // 
            this.nextVisitUnitComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dischargeBindingSource, "NextVisitUnit", true));
            this.nextVisitUnitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nextVisitUnitComboBox.FormattingEnabled = true;
            this.nextVisitUnitComboBox.Items.AddRange(new object[] {
            "Days",
            "Weeks",
            "Months",
            "Years"});
            this.nextVisitUnitComboBox.Location = new System.Drawing.Point(492, 118);
            this.nextVisitUnitComboBox.Name = "nextVisitUnitComboBox";
            this.nextVisitUnitComboBox.Size = new System.Drawing.Size(128, 21);
            this.nextVisitUnitComboBox.TabIndex = 10;
            // 
            // PINtextBox
            // 
            this.PINtextBox.Location = new System.Drawing.Point(699, 141);
            this.PINtextBox.Name = "PINtextBox";
            this.PINtextBox.ReadOnly = true;
            this.PINtextBox.Size = new System.Drawing.Size(155, 20);
            this.PINtextBox.TabIndex = 60;
            // 
            // DischargeDateDateTimePicker
            // 
            this.DischargeDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dischargeBindingSource, "DischargeDate", true));
            this.DischargeDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DischargeDateDateTimePicker.Location = new System.Drawing.Point(95, 97);
            this.DischargeDateDateTimePicker.Name = "DischargeDateDateTimePicker";
            this.DischargeDateDateTimePicker.Size = new System.Drawing.Size(203, 20);
            this.DischargeDateDateTimePicker.TabIndex = 4;
            this.DischargeDateDateTimePicker.ValueChanged += new System.EventHandler(this.DischargeDateDateTimePicker_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(654, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "City";
            // 
            // CitytextBox
            // 
            this.CitytextBox.Location = new System.Drawing.Point(699, 117);
            this.CitytextBox.Name = "CitytextBox";
            this.CitytextBox.ReadOnly = true;
            this.CitytextBox.Size = new System.Drawing.Size(155, 20);
            this.CitytextBox.TabIndex = 58;
            // 
            // Address2textBox
            // 
            this.Address2textBox.Location = new System.Drawing.Point(699, 94);
            this.Address2textBox.Name = "Address2textBox";
            this.Address2textBox.ReadOnly = true;
            this.Address2textBox.Size = new System.Drawing.Size(155, 20);
            this.Address2textBox.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(654, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Address";
            // 
            // PatNametextBox
            // 
            this.PatNametextBox.Location = new System.Drawing.Point(417, 41);
            this.PatNametextBox.Name = "PatNametextBox";
            this.PatNametextBox.ReadOnly = true;
            this.PatNametextBox.Size = new System.Drawing.Size(203, 20);
            this.PatNametextBox.TabIndex = 44;
            // 
            // Address1textBox
            // 
            this.Address1textBox.Location = new System.Drawing.Point(699, 68);
            this.Address1textBox.Name = "Address1textBox";
            this.Address1textBox.ReadOnly = true;
            this.Address1textBox.Size = new System.Drawing.Size(155, 20);
            this.Address1textBox.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(654, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Gender";
            // 
            // GendertextBox
            // 
            this.GendertextBox.Location = new System.Drawing.Point(699, 42);
            this.GendertextBox.Name = "GendertextBox";
            this.GendertextBox.ReadOnly = true;
            this.GendertextBox.Size = new System.Drawing.Size(155, 20);
            this.GendertextBox.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(654, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Age";
            // 
            // diagnosisTextBox
            // 
            this.diagnosisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dischargeBindingSource, "Diagnosis", true));
            this.diagnosisTextBox.Location = new System.Drawing.Point(417, 70);
            this.diagnosisTextBox.Name = "diagnosisTextBox";
            this.diagnosisTextBox.Size = new System.Drawing.Size(203, 20);
            this.diagnosisTextBox.TabIndex = 7;
            // 
            // AgetextBox
            // 
            this.AgetextBox.Location = new System.Drawing.Point(699, 17);
            this.AgetextBox.Name = "AgetextBox";
            this.AgetextBox.ReadOnly = true;
            this.AgetextBox.Size = new System.Drawing.Size(155, 20);
            this.AgetextBox.TabIndex = 50;
            // 
            // tabPageAdvices
            // 
            this.tabPageAdvices.Controls.Add(this.AdvicesdataGridView);
            this.tabPageAdvices.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdvices.Name = "tabPageAdvices";
            this.tabPageAdvices.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdvices.Size = new System.Drawing.Size(869, 216);
            this.tabPageAdvices.TabIndex = 1;
            this.tabPageAdvices.Text = "Advices";
            this.tabPageAdvices.UseVisualStyleBackColor = true;
            // 
            // AdvicesdataGridView
            // 
            this.AdvicesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdvicesdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DisID,
            this.SLNO,
            this.Perticulars});
            this.AdvicesdataGridView.Location = new System.Drawing.Point(6, 6);
            this.AdvicesdataGridView.Name = "AdvicesdataGridView";
            this.AdvicesdataGridView.Size = new System.Drawing.Size(857, 204);
            this.AdvicesdataGridView.TabIndex = 56;
            this.AdvicesdataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.AdvicesdataGridView_CellEndEdit);
            // 
            // DisID
            // 
            this.DisID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DisID.HeaderText = "Discharge ID";
            this.DisID.Name = "DisID";
            this.DisID.ReadOnly = true;
            this.DisID.Visible = false;
            // 
            // SLNO
            // 
            this.SLNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SLNO.HeaderText = "Sl No";
            this.SLNO.Name = "SLNO";
            this.SLNO.ReadOnly = true;
            this.SLNO.Visible = false;
            // 
            // Perticulars
            // 
            this.Perticulars.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Perticulars.HeaderText = "Particulars";
            this.Perticulars.MinimumWidth = 400;
            this.Perticulars.Name = "Perticulars";
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(148, 17);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(75, 23);
            this.Savebutton.TabIndex = 0;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // printbutton
            // 
            this.printbutton.Location = new System.Drawing.Point(273, 17);
            this.printbutton.Name = "printbutton";
            this.printbutton.Size = new System.Drawing.Size(75, 23);
            this.printbutton.TabIndex = 1;
            this.printbutton.Text = "Print";
            this.printbutton.UseVisualStyleBackColor = true;
            this.printbutton.Click += new System.EventHandler(this.printbutton_Click);
            // 
            // doctorMastBindingSource
            // 
            this.doctorMastBindingSource.DataMember = "DoctorMast";
            this.doctorMastBindingSource.DataSource = this.hMSDataSet;
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
            // dischargeDataGridView
            // 
            this.dischargeDataGridView.AllowUserToAddRows = false;
            this.dischargeDataGridView.AllowUserToDeleteRows = false;
            this.dischargeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dischargeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.IPDNo,
            this.DischargeDate,
            this.Patient,
            this.DischargeBy});
            this.dischargeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dischargeDataGridView.Location = new System.Drawing.Point(0, 294);
            this.dischargeDataGridView.Name = "dischargeDataGridView";
            this.dischargeDataGridView.ReadOnly = true;
            this.dischargeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dischargeDataGridView.Size = new System.Drawing.Size(901, 311);
            this.dischargeDataGridView.TabIndex = 2;
            this.dischargeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dischargeDataGridView_CellContentClick);
            this.dischargeDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dischargeDataGridView_MouseDoubleClick);
            // 
            // Id
            // 
            this.Id.FillWeight = 50F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // IPDNo
            // 
            this.IPDNo.HeaderText = "IPDNo";
            this.IPDNo.Name = "IPDNo";
            this.IPDNo.ReadOnly = true;
            // 
            // DischargeDate
            // 
            this.DischargeDate.HeaderText = "DischargeDate";
            this.DischargeDate.Name = "DischargeDate";
            this.DischargeDate.ReadOnly = true;
            // 
            // Patient
            // 
            this.Patient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Patient.HeaderText = "Patient Name";
            this.Patient.Name = "Patient";
            this.Patient.ReadOnly = true;
            // 
            // DischargeBy
            // 
            this.DischargeBy.FillWeight = 200F;
            this.DischargeBy.HeaderText = "DischargeBy";
            this.DischargeBy.Name = "DischargeBy";
            this.DischargeBy.ReadOnly = true;
            this.DischargeBy.Width = 200;
            // 
            // doctorMastTableAdapter
            // 
            this.doctorMastTableAdapter.ClearBeforeFill = true;
            // 
            // DischargeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 605);
            this.Controls.Add(this.dischargeDataGridView);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "DischargeFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Discharge";
            this.Load += new System.EventHandler(this.DischargeFrm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DischargeFrm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dischargeBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tabPageMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorMastBindingSource1)).EndInit();
            this.tabPageAdvices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AdvicesdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorMastBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientMastBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dischargeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HMSDataSet hMSDataSet;
        private System.Windows.Forms.BindingSource dischargeBindingSource;
        private HMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox nextVisitUnitComboBox;
        private System.Windows.Forms.TextBox nextVisitNoTextBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.ComboBox dischargeByComboBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.DataGridView dischargeDataGridView;
        private System.Windows.Forms.BindingSource patientMastBindingSource;
        private System.Windows.Forms.BindingSource doctorMastBindingSource;
        private System.Windows.Forms.DateTimePicker DischargeDateDateTimePicker;
        private System.Windows.Forms.TextBox PatNametextBox;
        private System.Windows.Forms.BindingSource iPDBindingSource;
        private System.Windows.Forms.TextBox diagnosisTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CitytextBox;
        private System.Windows.Forms.TextBox Address2textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Address1textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GendertextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AgetextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PINtextBox;
        private System.Windows.Forms.DateTimePicker AdmissiondateTimePicker;
        private System.Windows.Forms.TextBox IPDSearchtextBox;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Button printbutton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPageAdvices;
        private System.Windows.Forms.DataGridView AdvicesdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPDNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DischargeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn DischargeBy;
        private System.Windows.Forms.BindingSource doctorMastBindingSource1;
        private HMSDataSetTableAdapters.DoctorMastTableAdapter doctorMastTableAdapter;
        private System.Windows.Forms.Button buttonIPD;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Perticulars;
    }
}