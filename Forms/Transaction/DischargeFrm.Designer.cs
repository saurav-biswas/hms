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
            System.Windows.Forms.Label PatidLabel;
            System.Windows.Forms.Label idLabel1;
            System.Windows.Forms.Label diagnosisLabel;
            System.Windows.Forms.Label label5;
            this.hMSDataSet = new HMS.HMSDataSet();
            this.dischargeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dischargeTableAdapter = new HMS.HMSDataSetTableAdapters.DischargeTableAdapter();
            this.tableAdapterManager = new HMS.HMSDataSetTableAdapters.TableAdapterManager();
            this.doctorMastTableAdapter = new HMS.HMSDataSetTableAdapters.DoctorMastTableAdapter();
            this.patientMastTableAdapter = new HMS.HMSDataSetTableAdapters.PatientMastTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Savebutton = new System.Windows.Forms.Button();
            this.Updatebutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.printbutton = new System.Windows.Forms.Button();
            this.IPDSearchtextBox = new System.Windows.Forms.TextBox();
            this.AdmissiondateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.PINtextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CitytextBox = new System.Windows.Forms.TextBox();
            this.Address2textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Address1textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.GendertextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AgetextBox = new System.Windows.Forms.TextBox();
            this.diagnosisTextBox = new System.Windows.Forms.TextBox();
            this.Findbutton = new System.Windows.Forms.Button();
            this.PatNametextBox = new System.Windows.Forms.TextBox();
            this.PatidTextBox = new System.Windows.Forms.TextBox();
            this.patientMastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DischargeDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nextVisitUnitComboBox = new System.Windows.Forms.ComboBox();
            this.nextVisitNoTextBox = new System.Windows.Forms.TextBox();
            this.commentTextBox = new System.Windows.Forms.TextBox();
            this.dischargeByComboBox = new System.Windows.Forms.ComboBox();
            this.doctorMastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.iPDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dischargeDataGridView = new System.Windows.Forms.DataGridView();
            this.iPDTableAdapter = new HMS.HMSDataSetTableAdapters.IPDTableAdapter();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IPDNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DischargeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DischargeBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diagnosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NextVisitNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NextVisitUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            dischargeByLabel = new System.Windows.Forms.Label();
            commentLabel = new System.Windows.Forms.Label();
            nextVisitNoLabel = new System.Windows.Forms.Label();
            dischargeDateLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            PatidLabel = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            diagnosisLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dischargeBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientMastBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorMastBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dischargeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(49, 53);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(70, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "Discharge Id:";
            // 
            // dischargeByLabel
            // 
            dischargeByLabel.AutoSize = true;
            dischargeByLabel.Location = new System.Drawing.Point(46, 106);
            dischargeByLabel.Name = "dischargeByLabel";
            dischargeByLabel.Size = new System.Drawing.Size(73, 13);
            dischargeByLabel.TabIndex = 4;
            dischargeByLabel.Text = "Discharge By:";
            // 
            // commentLabel
            // 
            commentLabel.AutoSize = true;
            commentLabel.Location = new System.Drawing.Point(387, 128);
            commentLabel.Name = "commentLabel";
            commentLabel.Size = new System.Drawing.Size(54, 13);
            commentLabel.TabIndex = 6;
            commentLabel.Text = "Comment:";
            // 
            // nextVisitNoLabel
            // 
            nextVisitNoLabel.AutoSize = true;
            nextVisitNoLabel.Location = new System.Drawing.Point(370, 154);
            nextVisitNoLabel.Name = "nextVisitNoLabel";
            nextVisitNoLabel.Size = new System.Drawing.Size(71, 13);
            nextVisitNoLabel.TabIndex = 8;
            nextVisitNoLabel.Text = "Next Visit No:";
            // 
            // dischargeDateLabel
            // 
            dischargeDateLabel.AutoSize = true;
            dischargeDateLabel.Location = new System.Drawing.Point(35, 134);
            dischargeDateLabel.Name = "dischargeDateLabel";
            dischargeDateLabel.Size = new System.Drawing.Size(84, 13);
            dischargeDateLabel.TabIndex = 11;
            dischargeDateLabel.Text = "Discharge Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(358, 77);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(74, 13);
            label1.TabIndex = 45;
            label1.Text = "Patient Name:";
            // 
            // PatidLabel
            // 
            PatidLabel.AutoSize = true;
            PatidLabel.Location = new System.Drawing.Point(64, 77);
            PatidLabel.Name = "PatidLabel";
            PatidLabel.Size = new System.Drawing.Size(55, 13);
            PatidLabel.TabIndex = 42;
            PatidLabel.Text = "Patient Id:";
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(91, 159);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(28, 13);
            idLabel1.TabIndex = 46;
            idLabel1.Text = "IPD:";
            // 
            // diagnosisLabel
            // 
            diagnosisLabel.AutoSize = true;
            diagnosisLabel.Location = new System.Drawing.Point(385, 106);
            diagnosisLabel.Name = "diagnosisLabel";
            diagnosisLabel.Size = new System.Drawing.Size(56, 13);
            diagnosisLabel.TabIndex = 48;
            diagnosisLabel.Text = "Diagnosis:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(35, 187);
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
            this.tableAdapterManager.DischargeTableAdapter = this.dischargeTableAdapter;
            this.tableAdapterManager.DoctorDepartmentMastTableAdapter = null;
            this.tableAdapterManager.DoctorMastTableAdapter = this.doctorMastTableAdapter;
            this.tableAdapterManager.FinalBillHdrTableAdapter = null;
            this.tableAdapterManager.FinalBillOtherAmountTableAdapter = null;
            this.tableAdapterManager.IPDTableAdapter = null;
            this.tableAdapterManager.OPDTableAdapter = null;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.Savebutton);
            this.panel1.Controls.Add(this.Updatebutton);
            this.panel1.Controls.Add(this.Cancelbutton);
            this.panel1.Controls.Add(this.Addbutton);
            this.panel1.Controls.Add(this.printbutton);
            this.panel1.Controls.Add(this.IPDSearchtextBox);
            this.panel1.Controls.Add(label5);
            this.panel1.Controls.Add(this.AdmissiondateTimePicker);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.PINtextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.CitytextBox);
            this.panel1.Controls.Add(this.Address2textBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Address1textBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.GendertextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AgetextBox);
            this.panel1.Controls.Add(diagnosisLabel);
            this.panel1.Controls.Add(this.diagnosisTextBox);
            this.panel1.Controls.Add(idLabel1);
            this.panel1.Controls.Add(this.Findbutton);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.PatNametextBox);
            this.panel1.Controls.Add(PatidLabel);
            this.panel1.Controls.Add(this.PatidTextBox);
            this.panel1.Controls.Add(dischargeDateLabel);
            this.panel1.Controls.Add(this.DischargeDateDateTimePicker);
            this.panel1.Controls.Add(this.nextVisitUnitComboBox);
            this.panel1.Controls.Add(nextVisitNoLabel);
            this.panel1.Controls.Add(this.nextVisitNoTextBox);
            this.panel1.Controls.Add(commentLabel);
            this.panel1.Controls.Add(this.commentTextBox);
            this.panel1.Controls.Add(dischargeByLabel);
            this.panel1.Controls.Add(this.dischargeByComboBox);
            this.panel1.Controls.Add(idLabel);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 210);
            this.panel1.TabIndex = 2;
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(148, 17);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(75, 23);
            this.Savebutton.TabIndex = 90;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // Updatebutton
            // 
            this.Updatebutton.Location = new System.Drawing.Point(246, 17);
            this.Updatebutton.Name = "Updatebutton";
            this.Updatebutton.Size = new System.Drawing.Size(75, 23);
            this.Updatebutton.TabIndex = 89;
            this.Updatebutton.Text = "Update";
            this.Updatebutton.UseVisualStyleBackColor = true;
            this.Updatebutton.Click += new System.EventHandler(this.Updatebutton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(341, 17);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton.TabIndex = 88;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(41, 17);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(75, 23);
            this.Addbutton.TabIndex = 87;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // printbutton
            // 
            this.printbutton.Location = new System.Drawing.Point(446, 17);
            this.printbutton.Name = "printbutton";
            this.printbutton.Size = new System.Drawing.Size(75, 23);
            this.printbutton.TabIndex = 86;
            this.printbutton.Text = "Print";
            this.printbutton.UseVisualStyleBackColor = true;
            this.printbutton.Click += new System.EventHandler(this.printbutton_Click);
            // 
            // IPDSearchtextBox
            // 
            this.IPDSearchtextBox.Location = new System.Drawing.Point(124, 156);
            this.IPDSearchtextBox.Name = "IPDSearchtextBox";
            this.IPDSearchtextBox.Size = new System.Drawing.Size(203, 20);
            this.IPDSearchtextBox.TabIndex = 85;
            this.IPDSearchtextBox.TextChanged += new System.EventHandler(this.IPDSearchtextBox_TextChanged);
            // 
            // AdmissiondateTimePicker
            // 
            this.AdmissiondateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dischargeBindingSource, "DischargeDate", true));
            this.AdmissiondateTimePicker.Location = new System.Drawing.Point(125, 183);
            this.AdmissiondateTimePicker.Name = "AdmissiondateTimePicker";
            this.AdmissiondateTimePicker.Size = new System.Drawing.Size(203, 20);
            this.AdmissiondateTimePicker.TabIndex = 63;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(684, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "PIN";
            // 
            // PINtextBox
            // 
            this.PINtextBox.Location = new System.Drawing.Point(729, 174);
            this.PINtextBox.Name = "PINtextBox";
            this.PINtextBox.ReadOnly = true;
            this.PINtextBox.Size = new System.Drawing.Size(155, 20);
            this.PINtextBox.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(684, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "City";
            // 
            // CitytextBox
            // 
            this.CitytextBox.Location = new System.Drawing.Point(729, 150);
            this.CitytextBox.Name = "CitytextBox";
            this.CitytextBox.ReadOnly = true;
            this.CitytextBox.Size = new System.Drawing.Size(155, 20);
            this.CitytextBox.TabIndex = 58;
            // 
            // Address2textBox
            // 
            this.Address2textBox.Location = new System.Drawing.Point(729, 127);
            this.Address2textBox.Name = "Address2textBox";
            this.Address2textBox.ReadOnly = true;
            this.Address2textBox.Size = new System.Drawing.Size(155, 20);
            this.Address2textBox.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(684, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Address";
            // 
            // Address1textBox
            // 
            this.Address1textBox.Location = new System.Drawing.Point(729, 101);
            this.Address1textBox.Name = "Address1textBox";
            this.Address1textBox.ReadOnly = true;
            this.Address1textBox.Size = new System.Drawing.Size(155, 20);
            this.Address1textBox.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(684, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Gender";
            // 
            // GendertextBox
            // 
            this.GendertextBox.Location = new System.Drawing.Point(729, 75);
            this.GendertextBox.Name = "GendertextBox";
            this.GendertextBox.ReadOnly = true;
            this.GendertextBox.Size = new System.Drawing.Size(155, 20);
            this.GendertextBox.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(684, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Age";
            // 
            // AgetextBox
            // 
            this.AgetextBox.Location = new System.Drawing.Point(729, 50);
            this.AgetextBox.Name = "AgetextBox";
            this.AgetextBox.ReadOnly = true;
            this.AgetextBox.Size = new System.Drawing.Size(155, 20);
            this.AgetextBox.TabIndex = 50;
            // 
            // diagnosisTextBox
            // 
            this.diagnosisTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dischargeBindingSource, "Diagnosis", true));
            this.diagnosisTextBox.Location = new System.Drawing.Point(447, 103);
            this.diagnosisTextBox.Name = "diagnosisTextBox";
            this.diagnosisTextBox.Size = new System.Drawing.Size(203, 20);
            this.diagnosisTextBox.TabIndex = 49;
            // 
            // Findbutton
            // 
            this.Findbutton.Location = new System.Drawing.Point(307, 74);
            this.Findbutton.Name = "Findbutton";
            this.Findbutton.Size = new System.Drawing.Size(20, 23);
            this.Findbutton.TabIndex = 46;
            this.Findbutton.Text = "🔎";
            this.Findbutton.UseVisualStyleBackColor = true;
            this.Findbutton.Click += new System.EventHandler(this.Findbutton_Click);
            // 
            // PatNametextBox
            // 
            this.PatNametextBox.Location = new System.Drawing.Point(447, 74);
            this.PatNametextBox.Name = "PatNametextBox";
            this.PatNametextBox.ReadOnly = true;
            this.PatNametextBox.Size = new System.Drawing.Size(203, 20);
            this.PatNametextBox.TabIndex = 44;
            // 
            // PatidTextBox
            // 
            this.PatidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientMastBindingSource, "Id", true));
            this.PatidTextBox.Location = new System.Drawing.Point(125, 74);
            this.PatidTextBox.Name = "PatidTextBox";
            this.PatidTextBox.Size = new System.Drawing.Size(176, 20);
            this.PatidTextBox.TabIndex = 43;
            // 
            // patientMastBindingSource
            // 
            this.patientMastBindingSource.DataMember = "PatientMast";
            this.patientMastBindingSource.DataSource = this.hMSDataSet;
            // 
            // DischargeDateDateTimePicker
            // 
            this.DischargeDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.dischargeBindingSource, "DischargeDate", true));
            this.DischargeDateDateTimePicker.Location = new System.Drawing.Point(125, 130);
            this.DischargeDateDateTimePicker.Name = "DischargeDateDateTimePicker";
            this.DischargeDateDateTimePicker.Size = new System.Drawing.Size(203, 20);
            this.DischargeDateDateTimePicker.TabIndex = 12;
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
            this.nextVisitUnitComboBox.Location = new System.Drawing.Point(522, 151);
            this.nextVisitUnitComboBox.Name = "nextVisitUnitComboBox";
            this.nextVisitUnitComboBox.Size = new System.Drawing.Size(128, 21);
            this.nextVisitUnitComboBox.TabIndex = 11;
            // 
            // nextVisitNoTextBox
            // 
            this.nextVisitNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dischargeBindingSource, "NextVisitNo", true));
            this.nextVisitNoTextBox.Location = new System.Drawing.Point(447, 151);
            this.nextVisitNoTextBox.Name = "nextVisitNoTextBox";
            this.nextVisitNoTextBox.Size = new System.Drawing.Size(74, 20);
            this.nextVisitNoTextBox.TabIndex = 9;
            // 
            // commentTextBox
            // 
            this.commentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dischargeBindingSource, "Comment", true));
            this.commentTextBox.Location = new System.Drawing.Point(447, 125);
            this.commentTextBox.Name = "commentTextBox";
            this.commentTextBox.Size = new System.Drawing.Size(203, 20);
            this.commentTextBox.TabIndex = 7;
            // 
            // dischargeByComboBox
            // 
            this.dischargeByComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dischargeBindingSource, "DischargeBy", true));
            this.dischargeByComboBox.DataSource = this.doctorMastBindingSource;
            this.dischargeByComboBox.DisplayMember = "DocName";
            this.dischargeByComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dischargeByComboBox.FormattingEnabled = true;
            this.dischargeByComboBox.Location = new System.Drawing.Point(125, 103);
            this.dischargeByComboBox.Name = "dischargeByComboBox";
            this.dischargeByComboBox.Size = new System.Drawing.Size(203, 21);
            this.dischargeByComboBox.TabIndex = 5;
            this.dischargeByComboBox.ValueMember = "DocName";
            // 
            // doctorMastBindingSource
            // 
            this.doctorMastBindingSource.DataMember = "DoctorMast";
            this.doctorMastBindingSource.DataSource = this.hMSDataSet;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dischargeBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(125, 50);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(203, 20);
            this.idTextBox.TabIndex = 1;
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
            this.DischargeBy,
            this.Diagnosis,
            this.Comment,
            this.NextVisitNo,
            this.NextVisitUnit,
            this.PatID});
            this.dischargeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dischargeDataGridView.Location = new System.Drawing.Point(0, 210);
            this.dischargeDataGridView.Name = "dischargeDataGridView";
            this.dischargeDataGridView.ReadOnly = true;
            this.dischargeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dischargeDataGridView.Size = new System.Drawing.Size(901, 395);
            this.dischargeDataGridView.TabIndex = 2;
            this.dischargeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dischargeDataGridView_CellContentClick);
            this.dischargeDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dischargeDataGridView_MouseDoubleClick);
            // 
            // iPDTableAdapter
            // 
            this.iPDTableAdapter.ClearBeforeFill = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
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
            this.Patient.HeaderText = "Patient Name";
            this.Patient.Name = "Patient";
            this.Patient.ReadOnly = true;
            // 
            // DischargeBy
            // 
            this.DischargeBy.HeaderText = "DischargeBy";
            this.DischargeBy.Name = "DischargeBy";
            this.DischargeBy.ReadOnly = true;
            // 
            // Diagnosis
            // 
            this.Diagnosis.HeaderText = "Diagnosis";
            this.Diagnosis.Name = "Diagnosis";
            this.Diagnosis.ReadOnly = true;
            // 
            // Comment
            // 
            this.Comment.HeaderText = "Comment";
            this.Comment.Name = "Comment";
            this.Comment.ReadOnly = true;
            // 
            // NextVisitNo
            // 
            this.NextVisitNo.HeaderText = "NextVisitNo";
            this.NextVisitNo.Name = "NextVisitNo";
            this.NextVisitNo.ReadOnly = true;
            // 
            // NextVisitUnit
            // 
            this.NextVisitUnit.HeaderText = "NextVisitUnit";
            this.NextVisitUnit.Name = "NextVisitUnit";
            this.NextVisitUnit.ReadOnly = true;
            // 
            // PatID
            // 
            this.PatID.HeaderText = "PatID";
            this.PatID.Name = "PatID";
            this.PatID.ReadOnly = true;
            // 
            // DischargeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 605);
            this.Controls.Add(this.dischargeDataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "DischargeFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DischargeFrm";
            this.Load += new System.EventHandler(this.DischargeFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dischargeBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientMastBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorMastBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dischargeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HMSDataSet hMSDataSet;
        private System.Windows.Forms.BindingSource dischargeBindingSource;
        private HMSDataSetTableAdapters.DischargeTableAdapter dischargeTableAdapter;
        private HMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox nextVisitUnitComboBox;
        private System.Windows.Forms.TextBox nextVisitNoTextBox;
        private System.Windows.Forms.TextBox commentTextBox;
        private System.Windows.Forms.ComboBox dischargeByComboBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.DataGridView dischargeDataGridView;
        private HMSDataSetTableAdapters.PatientMastTableAdapter patientMastTableAdapter;
        private System.Windows.Forms.BindingSource patientMastBindingSource;
        private HMSDataSetTableAdapters.DoctorMastTableAdapter doctorMastTableAdapter;
        private System.Windows.Forms.BindingSource doctorMastBindingSource;
        private System.Windows.Forms.DateTimePicker DischargeDateDateTimePicker;
        private System.Windows.Forms.Button Findbutton;
        private System.Windows.Forms.TextBox PatNametextBox;
        private System.Windows.Forms.TextBox PatidTextBox;
        private System.Windows.Forms.BindingSource iPDBindingSource;
        private HMSDataSetTableAdapters.IPDTableAdapter iPDTableAdapter;
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
        private System.Windows.Forms.Button Updatebutton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button printbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPDNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DischargeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn DischargeBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comment;
        private System.Windows.Forms.DataGridViewTextBoxColumn NextVisitNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NextVisitUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatID;
    }
}