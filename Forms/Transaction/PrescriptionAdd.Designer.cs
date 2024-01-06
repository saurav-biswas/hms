namespace HMS.Forms.Transaction
{
    partial class PrescriptionAdd
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
            System.Windows.Forms.Label prescriptionTypeLabel;
            System.Windows.Forms.Label patientLabel;
            System.Windows.Forms.Label doctorLabel;
            System.Windows.Forms.Label bloodPressureLabel;
            System.Windows.Forms.Label foodAllergiesLabel;
            System.Windows.Forms.Label tendencyBleedLabel;
            System.Windows.Forms.Label heartDiseaseLabel;
            System.Windows.Forms.Label diabeticLabel;
            System.Windows.Forms.Label addedAtLabel;
            System.Windows.Forms.Label femalePregnancyLabel;
            System.Windows.Forms.Label breastFeedingLabel;
            System.Windows.Forms.Label currentMedicationLabel;
            System.Windows.Forms.Label surgeryLabel;
            System.Windows.Forms.Label accidentLabel;
            System.Windows.Forms.Label othersLabel;
            System.Windows.Forms.Label pulseRateLabel;
            System.Windows.Forms.Label temperatureLabel;
            System.Windows.Forms.Label problemDescriptionLabel;
            System.Windows.Forms.Label testLabel;
            System.Windows.Forms.Label adviceLabel;
            System.Windows.Forms.Label nextVisitPeriodLabel;
            System.Windows.Forms.Label presDateLabel;
            this.hMSDataSet = new HMS.HMSDataSet();
            this.prescriptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prescriptionTableAdapter = new HMS.HMSDataSetTableAdapters.PrescriptionTableAdapter();
            this.tableAdapterManager = new HMS.HMSDataSetTableAdapters.TableAdapterManager();
            this.doctorMastTableAdapter = new HMS.HMSDataSetTableAdapters.DoctorMastTableAdapter();
            this.patientMastTableAdapter = new HMS.HMSDataSetTableAdapters.PatientMastTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.presDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.adviceTextBox = new System.Windows.Forms.TextBox();
            this.testTextBox = new System.Windows.Forms.TextBox();
            this.problemDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.temperatureTextBox = new System.Windows.Forms.TextBox();
            this.pulseRateTextBox = new System.Windows.Forms.TextBox();
            this.othersTextBox = new System.Windows.Forms.TextBox();
            this.accidentTextBox = new System.Windows.Forms.TextBox();
            this.surgeryTextBox = new System.Windows.Forms.TextBox();
            this.currentMedicationTextBox = new System.Windows.Forms.TextBox();
            this.breastFeedingComboBox = new System.Windows.Forms.ComboBox();
            this.femalePregnancyComboBox = new System.Windows.Forms.ComboBox();
            this.addedAtTextBox = new System.Windows.Forms.TextBox();
            this.diabeticTextBox = new System.Windows.Forms.TextBox();
            this.heartDiseaseTextBox = new System.Windows.Forms.TextBox();
            this.tendencyBleedTextBox = new System.Windows.Forms.TextBox();
            this.foodAllergiesTextBox = new System.Windows.Forms.TextBox();
            this.bloodPressureTextBox = new System.Windows.Forms.TextBox();
            this.doctorComboBox = new System.Windows.Forms.ComboBox();
            this.doctorMastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientComboBox = new System.Windows.Forms.ComboBox();
            this.patientMastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prescriptionTypeComboBox = new System.Windows.Forms.ComboBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.presMedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.presMedTableAdapter = new HMS.HMSDataSetTableAdapters.PresMedTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nextVisitTypeComboBox = new System.Windows.Forms.ComboBox();
            this.nextVisitPeriodTextBox = new System.Windows.Forms.TextBox();
            this.presMedDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            prescriptionTypeLabel = new System.Windows.Forms.Label();
            patientLabel = new System.Windows.Forms.Label();
            doctorLabel = new System.Windows.Forms.Label();
            bloodPressureLabel = new System.Windows.Forms.Label();
            foodAllergiesLabel = new System.Windows.Forms.Label();
            tendencyBleedLabel = new System.Windows.Forms.Label();
            heartDiseaseLabel = new System.Windows.Forms.Label();
            diabeticLabel = new System.Windows.Forms.Label();
            addedAtLabel = new System.Windows.Forms.Label();
            femalePregnancyLabel = new System.Windows.Forms.Label();
            breastFeedingLabel = new System.Windows.Forms.Label();
            currentMedicationLabel = new System.Windows.Forms.Label();
            surgeryLabel = new System.Windows.Forms.Label();
            accidentLabel = new System.Windows.Forms.Label();
            othersLabel = new System.Windows.Forms.Label();
            pulseRateLabel = new System.Windows.Forms.Label();
            temperatureLabel = new System.Windows.Forms.Label();
            problemDescriptionLabel = new System.Windows.Forms.Label();
            testLabel = new System.Windows.Forms.Label();
            adviceLabel = new System.Windows.Forms.Label();
            nextVisitPeriodLabel = new System.Windows.Forms.Label();
            presDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorMastBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientMastBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presMedBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.presMedDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(110, 16);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // prescriptionTypeLabel
            // 
            prescriptionTypeLabel.AutoSize = true;
            prescriptionTypeLabel.Location = new System.Drawing.Point(37, 42);
            prescriptionTypeLabel.Name = "prescriptionTypeLabel";
            prescriptionTypeLabel.Size = new System.Drawing.Size(92, 13);
            prescriptionTypeLabel.TabIndex = 2;
            prescriptionTypeLabel.Text = "Prescription Type:";
            // 
            // patientLabel
            // 
            patientLabel.AutoSize = true;
            patientLabel.Location = new System.Drawing.Point(86, 69);
            patientLabel.Name = "patientLabel";
            patientLabel.Size = new System.Drawing.Size(43, 13);
            patientLabel.TabIndex = 4;
            patientLabel.Text = "Patient:";
            // 
            // doctorLabel
            // 
            doctorLabel.AutoSize = true;
            doctorLabel.Location = new System.Drawing.Point(87, 96);
            doctorLabel.Name = "doctorLabel";
            doctorLabel.Size = new System.Drawing.Size(42, 13);
            doctorLabel.TabIndex = 6;
            doctorLabel.Text = "Doctor:";
            // 
            // bloodPressureLabel
            // 
            bloodPressureLabel.AutoSize = true;
            bloodPressureLabel.Location = new System.Drawing.Point(367, 42);
            bloodPressureLabel.Name = "bloodPressureLabel";
            bloodPressureLabel.Size = new System.Drawing.Size(81, 13);
            bloodPressureLabel.TabIndex = 8;
            bloodPressureLabel.Text = "Blood Pressure:";
            // 
            // foodAllergiesLabel
            // 
            foodAllergiesLabel.AutoSize = true;
            foodAllergiesLabel.Location = new System.Drawing.Point(372, 68);
            foodAllergiesLabel.Name = "foodAllergiesLabel";
            foodAllergiesLabel.Size = new System.Drawing.Size(76, 13);
            foodAllergiesLabel.TabIndex = 10;
            foodAllergiesLabel.Text = "Food Allergies:";
            // 
            // tendencyBleedLabel
            // 
            tendencyBleedLabel.AutoSize = true;
            tendencyBleedLabel.Location = new System.Drawing.Point(360, 94);
            tendencyBleedLabel.Name = "tendencyBleedLabel";
            tendencyBleedLabel.Size = new System.Drawing.Size(88, 13);
            tendencyBleedLabel.TabIndex = 12;
            tendencyBleedLabel.Text = "Tendency Bleed:";
            // 
            // heartDiseaseLabel
            // 
            heartDiseaseLabel.AutoSize = true;
            heartDiseaseLabel.Location = new System.Drawing.Point(371, 120);
            heartDiseaseLabel.Name = "heartDiseaseLabel";
            heartDiseaseLabel.Size = new System.Drawing.Size(77, 13);
            heartDiseaseLabel.TabIndex = 14;
            heartDiseaseLabel.Text = "Heart Disease:";
            // 
            // diabeticLabel
            // 
            diabeticLabel.AutoSize = true;
            diabeticLabel.Location = new System.Drawing.Point(399, 146);
            diabeticLabel.Name = "diabeticLabel";
            diabeticLabel.Size = new System.Drawing.Size(49, 13);
            diabeticLabel.TabIndex = 16;
            diabeticLabel.Text = "Diabetic:";
            // 
            // addedAtLabel
            // 
            addedAtLabel.AutoSize = true;
            addedAtLabel.Location = new System.Drawing.Point(394, 172);
            addedAtLabel.Name = "addedAtLabel";
            addedAtLabel.Size = new System.Drawing.Size(54, 13);
            addedAtLabel.TabIndex = 18;
            addedAtLabel.Text = "Added At:";
            // 
            // femalePregnancyLabel
            // 
            femalePregnancyLabel.AutoSize = true;
            femalePregnancyLabel.Location = new System.Drawing.Point(31, 123);
            femalePregnancyLabel.Name = "femalePregnancyLabel";
            femalePregnancyLabel.Size = new System.Drawing.Size(98, 13);
            femalePregnancyLabel.TabIndex = 20;
            femalePregnancyLabel.Text = "Female Pregnancy:";
            // 
            // breastFeedingLabel
            // 
            breastFeedingLabel.AutoSize = true;
            breastFeedingLabel.Location = new System.Drawing.Point(48, 150);
            breastFeedingLabel.Name = "breastFeedingLabel";
            breastFeedingLabel.Size = new System.Drawing.Size(81, 13);
            breastFeedingLabel.TabIndex = 22;
            breastFeedingLabel.Text = "Breast Feeding:";
            // 
            // currentMedicationLabel
            // 
            currentMedicationLabel.AutoSize = true;
            currentMedicationLabel.Location = new System.Drawing.Point(680, 42);
            currentMedicationLabel.Name = "currentMedicationLabel";
            currentMedicationLabel.Size = new System.Drawing.Size(99, 13);
            currentMedicationLabel.TabIndex = 24;
            currentMedicationLabel.Text = "Current Medication:";
            // 
            // surgeryLabel
            // 
            surgeryLabel.AutoSize = true;
            surgeryLabel.Location = new System.Drawing.Point(733, 68);
            surgeryLabel.Name = "surgeryLabel";
            surgeryLabel.Size = new System.Drawing.Size(46, 13);
            surgeryLabel.TabIndex = 26;
            surgeryLabel.Text = "Surgery:";
            // 
            // accidentLabel
            // 
            accidentLabel.AutoSize = true;
            accidentLabel.Location = new System.Drawing.Point(727, 94);
            accidentLabel.Name = "accidentLabel";
            accidentLabel.Size = new System.Drawing.Size(52, 13);
            accidentLabel.TabIndex = 28;
            accidentLabel.Text = "Accident:";
            // 
            // othersLabel
            // 
            othersLabel.AutoSize = true;
            othersLabel.Location = new System.Drawing.Point(738, 120);
            othersLabel.Name = "othersLabel";
            othersLabel.Size = new System.Drawing.Size(41, 13);
            othersLabel.TabIndex = 30;
            othersLabel.Text = "Others:";
            // 
            // pulseRateLabel
            // 
            pulseRateLabel.AutoSize = true;
            pulseRateLabel.Location = new System.Drawing.Point(717, 146);
            pulseRateLabel.Name = "pulseRateLabel";
            pulseRateLabel.Size = new System.Drawing.Size(62, 13);
            pulseRateLabel.TabIndex = 32;
            pulseRateLabel.Text = "Pulse Rate:";
            // 
            // temperatureLabel
            // 
            temperatureLabel.AutoSize = true;
            temperatureLabel.Location = new System.Drawing.Point(709, 172);
            temperatureLabel.Name = "temperatureLabel";
            temperatureLabel.Size = new System.Drawing.Size(70, 13);
            temperatureLabel.TabIndex = 34;
            temperatureLabel.Text = "Temperature:";
            // 
            // problemDescriptionLabel
            // 
            problemDescriptionLabel.AutoSize = true;
            problemDescriptionLabel.Location = new System.Drawing.Point(25, 177);
            problemDescriptionLabel.Name = "problemDescriptionLabel";
            problemDescriptionLabel.Size = new System.Drawing.Size(104, 13);
            problemDescriptionLabel.TabIndex = 36;
            problemDescriptionLabel.Text = "Problem Description:";
            // 
            // testLabel
            // 
            testLabel.AutoSize = true;
            testLabel.Location = new System.Drawing.Point(417, 199);
            testLabel.Name = "testLabel";
            testLabel.Size = new System.Drawing.Size(31, 13);
            testLabel.TabIndex = 38;
            testLabel.Text = "Test:";
            // 
            // adviceLabel
            // 
            adviceLabel.AutoSize = true;
            adviceLabel.Location = new System.Drawing.Point(736, 199);
            adviceLabel.Name = "adviceLabel";
            adviceLabel.Size = new System.Drawing.Size(43, 13);
            adviceLabel.TabIndex = 40;
            adviceLabel.Text = "Advice:";
            // 
            // nextVisitPeriodLabel
            // 
            nextVisitPeriodLabel.AutoSize = true;
            nextVisitPeriodLabel.Location = new System.Drawing.Point(42, 32);
            nextVisitPeriodLabel.Name = "nextVisitPeriodLabel";
            nextVisitPeriodLabel.Size = new System.Drawing.Size(54, 13);
            nextVisitPeriodLabel.TabIndex = 0;
            nextVisitPeriodLabel.Text = "Next Visit:";
            // 
            // presDateLabel
            // 
            presDateLabel.AutoSize = true;
            presDateLabel.Location = new System.Drawing.Point(415, 16);
            presDateLabel.Name = "presDateLabel";
            presDateLabel.Size = new System.Drawing.Size(33, 13);
            presDateLabel.TabIndex = 42;
            presDateLabel.Text = "Date:";
            // 
            // hMSDataSet
            // 
            this.hMSDataSet.DataSetName = "HMSDataSet";
            this.hMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // prescriptionBindingSource
            // 
            this.prescriptionBindingSource.DataMember = "Prescription";
            this.prescriptionBindingSource.DataSource = this.hMSDataSet;
            // 
            // prescriptionTableAdapter
            // 
            this.prescriptionTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.OPDTableAdapter = null;
            this.tableAdapterManager.PatientMastTableAdapter = this.patientMastTableAdapter;
            this.tableAdapterManager.PrescriptionTableAdapter = this.prescriptionTableAdapter;
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
            this.panel1.Controls.Add(presDateLabel);
            this.panel1.Controls.Add(this.presDateDateTimePicker);
            this.panel1.Controls.Add(adviceLabel);
            this.panel1.Controls.Add(this.adviceTextBox);
            this.panel1.Controls.Add(testLabel);
            this.panel1.Controls.Add(this.testTextBox);
            this.panel1.Controls.Add(problemDescriptionLabel);
            this.panel1.Controls.Add(this.problemDescriptionTextBox);
            this.panel1.Controls.Add(temperatureLabel);
            this.panel1.Controls.Add(this.temperatureTextBox);
            this.panel1.Controls.Add(pulseRateLabel);
            this.panel1.Controls.Add(this.pulseRateTextBox);
            this.panel1.Controls.Add(othersLabel);
            this.panel1.Controls.Add(this.othersTextBox);
            this.panel1.Controls.Add(accidentLabel);
            this.panel1.Controls.Add(this.accidentTextBox);
            this.panel1.Controls.Add(surgeryLabel);
            this.panel1.Controls.Add(this.surgeryTextBox);
            this.panel1.Controls.Add(currentMedicationLabel);
            this.panel1.Controls.Add(this.currentMedicationTextBox);
            this.panel1.Controls.Add(breastFeedingLabel);
            this.panel1.Controls.Add(this.breastFeedingComboBox);
            this.panel1.Controls.Add(femalePregnancyLabel);
            this.panel1.Controls.Add(this.femalePregnancyComboBox);
            this.panel1.Controls.Add(addedAtLabel);
            this.panel1.Controls.Add(this.addedAtTextBox);
            this.panel1.Controls.Add(diabeticLabel);
            this.panel1.Controls.Add(this.diabeticTextBox);
            this.panel1.Controls.Add(heartDiseaseLabel);
            this.panel1.Controls.Add(this.heartDiseaseTextBox);
            this.panel1.Controls.Add(tendencyBleedLabel);
            this.panel1.Controls.Add(this.tendencyBleedTextBox);
            this.panel1.Controls.Add(foodAllergiesLabel);
            this.panel1.Controls.Add(this.foodAllergiesTextBox);
            this.panel1.Controls.Add(bloodPressureLabel);
            this.panel1.Controls.Add(this.bloodPressureTextBox);
            this.panel1.Controls.Add(doctorLabel);
            this.panel1.Controls.Add(this.doctorComboBox);
            this.panel1.Controls.Add(patientLabel);
            this.panel1.Controls.Add(this.patientComboBox);
            this.panel1.Controls.Add(prescriptionTypeLabel);
            this.panel1.Controls.Add(this.prescriptionTypeComboBox);
            this.panel1.Controls.Add(idLabel);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 244);
            this.panel1.TabIndex = 2;
            // 
            // presDateDateTimePicker
            // 
            this.presDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.prescriptionBindingSource, "PresDate", true));
            this.presDateDateTimePicker.Location = new System.Drawing.Point(454, 13);
            this.presDateDateTimePicker.Name = "presDateDateTimePicker";
            this.presDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.presDateDateTimePicker.TabIndex = 43;
            // 
            // adviceTextBox
            // 
            this.adviceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionBindingSource, "Advice", true));
            this.adviceTextBox.Location = new System.Drawing.Point(785, 196);
            this.adviceTextBox.Name = "adviceTextBox";
            this.adviceTextBox.Size = new System.Drawing.Size(203, 20);
            this.adviceTextBox.TabIndex = 41;
            // 
            // testTextBox
            // 
            this.testTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionBindingSource, "Test", true));
            this.testTextBox.Location = new System.Drawing.Point(454, 196);
            this.testTextBox.Name = "testTextBox";
            this.testTextBox.Size = new System.Drawing.Size(203, 20);
            this.testTextBox.TabIndex = 39;
            // 
            // problemDescriptionTextBox
            // 
            this.problemDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionBindingSource, "ProblemDescription", true));
            this.problemDescriptionTextBox.Location = new System.Drawing.Point(135, 174);
            this.problemDescriptionTextBox.Name = "problemDescriptionTextBox";
            this.problemDescriptionTextBox.Size = new System.Drawing.Size(203, 20);
            this.problemDescriptionTextBox.TabIndex = 37;
            // 
            // temperatureTextBox
            // 
            this.temperatureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionBindingSource, "Temperature", true));
            this.temperatureTextBox.Location = new System.Drawing.Point(785, 169);
            this.temperatureTextBox.Name = "temperatureTextBox";
            this.temperatureTextBox.Size = new System.Drawing.Size(203, 20);
            this.temperatureTextBox.TabIndex = 35;
            // 
            // pulseRateTextBox
            // 
            this.pulseRateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionBindingSource, "PulseRate", true));
            this.pulseRateTextBox.Location = new System.Drawing.Point(785, 143);
            this.pulseRateTextBox.Name = "pulseRateTextBox";
            this.pulseRateTextBox.Size = new System.Drawing.Size(203, 20);
            this.pulseRateTextBox.TabIndex = 33;
            // 
            // othersTextBox
            // 
            this.othersTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionBindingSource, "Others", true));
            this.othersTextBox.Location = new System.Drawing.Point(785, 117);
            this.othersTextBox.Name = "othersTextBox";
            this.othersTextBox.Size = new System.Drawing.Size(203, 20);
            this.othersTextBox.TabIndex = 31;
            // 
            // accidentTextBox
            // 
            this.accidentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionBindingSource, "Accident", true));
            this.accidentTextBox.Location = new System.Drawing.Point(785, 91);
            this.accidentTextBox.Name = "accidentTextBox";
            this.accidentTextBox.Size = new System.Drawing.Size(203, 20);
            this.accidentTextBox.TabIndex = 29;
            // 
            // surgeryTextBox
            // 
            this.surgeryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionBindingSource, "Surgery", true));
            this.surgeryTextBox.Location = new System.Drawing.Point(785, 65);
            this.surgeryTextBox.Name = "surgeryTextBox";
            this.surgeryTextBox.Size = new System.Drawing.Size(203, 20);
            this.surgeryTextBox.TabIndex = 27;
            // 
            // currentMedicationTextBox
            // 
            this.currentMedicationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionBindingSource, "CurrentMedication", true));
            this.currentMedicationTextBox.Location = new System.Drawing.Point(785, 39);
            this.currentMedicationTextBox.Name = "currentMedicationTextBox";
            this.currentMedicationTextBox.Size = new System.Drawing.Size(203, 20);
            this.currentMedicationTextBox.TabIndex = 25;
            // 
            // breastFeedingComboBox
            // 
            this.breastFeedingComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionBindingSource, "BreastFeeding", true));
            this.breastFeedingComboBox.FormattingEnabled = true;
            this.breastFeedingComboBox.Items.AddRange(new object[] {
            "No",
            "Yes",
            "Sometime"});
            this.breastFeedingComboBox.Location = new System.Drawing.Point(135, 147);
            this.breastFeedingComboBox.Name = "breastFeedingComboBox";
            this.breastFeedingComboBox.Size = new System.Drawing.Size(203, 21);
            this.breastFeedingComboBox.TabIndex = 23;
            // 
            // femalePregnancyComboBox
            // 
            this.femalePregnancyComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionBindingSource, "FemalePregnancy", true));
            this.femalePregnancyComboBox.FormattingEnabled = true;
            this.femalePregnancyComboBox.Items.AddRange(new object[] {
            "No",
            "Yes"});
            this.femalePregnancyComboBox.Location = new System.Drawing.Point(135, 120);
            this.femalePregnancyComboBox.Name = "femalePregnancyComboBox";
            this.femalePregnancyComboBox.Size = new System.Drawing.Size(203, 21);
            this.femalePregnancyComboBox.TabIndex = 21;
            // 
            // addedAtTextBox
            // 
            this.addedAtTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionBindingSource, "AddedAt", true));
            this.addedAtTextBox.Location = new System.Drawing.Point(454, 169);
            this.addedAtTextBox.Name = "addedAtTextBox";
            this.addedAtTextBox.Size = new System.Drawing.Size(203, 20);
            this.addedAtTextBox.TabIndex = 19;
            // 
            // diabeticTextBox
            // 
            this.diabeticTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionBindingSource, "Diabetic", true));
            this.diabeticTextBox.Location = new System.Drawing.Point(454, 143);
            this.diabeticTextBox.Name = "diabeticTextBox";
            this.diabeticTextBox.Size = new System.Drawing.Size(203, 20);
            this.diabeticTextBox.TabIndex = 17;
            // 
            // heartDiseaseTextBox
            // 
            this.heartDiseaseTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionBindingSource, "HeartDisease", true));
            this.heartDiseaseTextBox.Location = new System.Drawing.Point(454, 117);
            this.heartDiseaseTextBox.Name = "heartDiseaseTextBox";
            this.heartDiseaseTextBox.Size = new System.Drawing.Size(203, 20);
            this.heartDiseaseTextBox.TabIndex = 15;
            // 
            // tendencyBleedTextBox
            // 
            this.tendencyBleedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionBindingSource, "TendencyBleed", true));
            this.tendencyBleedTextBox.Location = new System.Drawing.Point(454, 91);
            this.tendencyBleedTextBox.Name = "tendencyBleedTextBox";
            this.tendencyBleedTextBox.Size = new System.Drawing.Size(203, 20);
            this.tendencyBleedTextBox.TabIndex = 13;
            // 
            // foodAllergiesTextBox
            // 
            this.foodAllergiesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionBindingSource, "FoodAllergies", true));
            this.foodAllergiesTextBox.Location = new System.Drawing.Point(454, 65);
            this.foodAllergiesTextBox.Name = "foodAllergiesTextBox";
            this.foodAllergiesTextBox.Size = new System.Drawing.Size(203, 20);
            this.foodAllergiesTextBox.TabIndex = 11;
            // 
            // bloodPressureTextBox
            // 
            this.bloodPressureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionBindingSource, "BloodPressure", true));
            this.bloodPressureTextBox.Location = new System.Drawing.Point(454, 39);
            this.bloodPressureTextBox.Name = "bloodPressureTextBox";
            this.bloodPressureTextBox.Size = new System.Drawing.Size(203, 20);
            this.bloodPressureTextBox.TabIndex = 9;
            // 
            // doctorComboBox
            // 
            this.doctorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionBindingSource, "Doctor", true));
            this.doctorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.doctorMastBindingSource, "DocName", true));
            this.doctorComboBox.DataSource = this.doctorMastBindingSource;
            this.doctorComboBox.DisplayMember = "DocName";
            this.doctorComboBox.FormattingEnabled = true;
            this.doctorComboBox.Location = new System.Drawing.Point(135, 93);
            this.doctorComboBox.Name = "doctorComboBox";
            this.doctorComboBox.Size = new System.Drawing.Size(203, 21);
            this.doctorComboBox.TabIndex = 7;
            this.doctorComboBox.ValueMember = "DocName";
            // 
            // doctorMastBindingSource
            // 
            this.doctorMastBindingSource.DataMember = "DoctorMast";
            this.doctorMastBindingSource.DataSource = this.hMSDataSet;
            // 
            // patientComboBox
            // 
            this.patientComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionBindingSource, "Patient", true));
            this.patientComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.patientMastBindingSource, "PatName", true));
            this.patientComboBox.DataSource = this.patientMastBindingSource;
            this.patientComboBox.DisplayMember = "PatName";
            this.patientComboBox.FormattingEnabled = true;
            this.patientComboBox.Location = new System.Drawing.Point(135, 66);
            this.patientComboBox.Name = "patientComboBox";
            this.patientComboBox.Size = new System.Drawing.Size(203, 21);
            this.patientComboBox.TabIndex = 5;
            this.patientComboBox.ValueMember = "PatName";
            // 
            // patientMastBindingSource
            // 
            this.patientMastBindingSource.DataMember = "PatientMast";
            this.patientMastBindingSource.DataSource = this.hMSDataSet;
            // 
            // prescriptionTypeComboBox
            // 
            this.prescriptionTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionBindingSource, "PrescriptionType", true));
            this.prescriptionTypeComboBox.FormattingEnabled = true;
            this.prescriptionTypeComboBox.Items.AddRange(new object[] {
            "OPD",
            "IPD"});
            this.prescriptionTypeComboBox.Location = new System.Drawing.Point(135, 39);
            this.prescriptionTypeComboBox.Name = "prescriptionTypeComboBox";
            this.prescriptionTypeComboBox.Size = new System.Drawing.Size(203, 21);
            this.prescriptionTypeComboBox.TabIndex = 3;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(135, 13);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(203, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // presMedBindingSource
            // 
            this.presMedBindingSource.DataMember = "PresMed";
            this.presMedBindingSource.DataSource = this.hMSDataSet;
            // 
            // presMedTableAdapter
            // 
            this.presMedTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nextVisitTypeComboBox);
            this.panel2.Controls.Add(nextVisitPeriodLabel);
            this.panel2.Controls.Add(this.nextVisitPeriodTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 628);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1012, 100);
            this.panel2.TabIndex = 3;
            // 
            // nextVisitTypeComboBox
            // 
            this.nextVisitTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionBindingSource, "NextVisitType", true));
            this.nextVisitTypeComboBox.FormattingEnabled = true;
            this.nextVisitTypeComboBox.Items.AddRange(new object[] {
            "Days",
            "Weeks",
            "Months",
            "Years"});
            this.nextVisitTypeComboBox.Location = new System.Drawing.Point(147, 28);
            this.nextVisitTypeComboBox.Name = "nextVisitTypeComboBox";
            this.nextVisitTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.nextVisitTypeComboBox.TabIndex = 3;
            // 
            // nextVisitPeriodTextBox
            // 
            this.nextVisitPeriodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prescriptionBindingSource, "NextVisitPeriod", true));
            this.nextVisitPeriodTextBox.Location = new System.Drawing.Point(102, 29);
            this.nextVisitPeriodTextBox.Name = "nextVisitPeriodTextBox";
            this.nextVisitPeriodTextBox.Size = new System.Drawing.Size(39, 20);
            this.nextVisitPeriodTextBox.TabIndex = 1;
            // 
            // presMedDataGridView
            // 
            this.presMedDataGridView.AutoGenerateColumns = false;
            this.presMedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.presMedDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.presMedDataGridView.DataSource = this.presMedBindingSource;
            this.presMedDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.presMedDataGridView.Location = new System.Drawing.Point(0, 244);
            this.presMedDataGridView.Name = "presMedDataGridView";
            this.presMedDataGridView.Size = new System.Drawing.Size(1012, 384);
            this.presMedDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MedicineName";
            this.dataGridViewTextBoxColumn2.HeaderText = "MedicineName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Dose";
            this.dataGridViewTextBoxColumn3.HeaderText = "Dose";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Duration";
            this.dataGridViewTextBoxColumn4.HeaderText = "Duration";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Timeing";
            this.dataGridViewTextBoxColumn5.HeaderText = "Timeing";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DoseIntervel";
            this.dataGridViewTextBoxColumn6.HeaderText = "DoseIntervel";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Comment";
            this.dataGridViewTextBoxColumn7.HeaderText = "Comment";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "PrescriptionID";
            this.dataGridViewTextBoxColumn8.HeaderText = "PrescriptionID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // PrescriptionAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 728);
            this.Controls.Add(this.presMedDataGridView);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PrescriptionAdd";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prescription";
            this.Load += new System.EventHandler(this.Prescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prescriptionBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorMastBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientMastBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presMedBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.presMedDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HMSDataSet hMSDataSet;
        private System.Windows.Forms.BindingSource prescriptionBindingSource;
        private HMSDataSetTableAdapters.PrescriptionTableAdapter prescriptionTableAdapter;
        private HMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox bloodPressureTextBox;
        private System.Windows.Forms.ComboBox doctorComboBox;
        private System.Windows.Forms.ComboBox patientComboBox;
        private System.Windows.Forms.ComboBox prescriptionTypeComboBox;
        private System.Windows.Forms.TextBox addedAtTextBox;
        private System.Windows.Forms.TextBox diabeticTextBox;
        private System.Windows.Forms.TextBox heartDiseaseTextBox;
        private System.Windows.Forms.TextBox tendencyBleedTextBox;
        private System.Windows.Forms.TextBox foodAllergiesTextBox;
        private System.Windows.Forms.ComboBox breastFeedingComboBox;
        private System.Windows.Forms.ComboBox femalePregnancyComboBox;
        private HMSDataSetTableAdapters.PatientMastTableAdapter patientMastTableAdapter;
        private System.Windows.Forms.BindingSource patientMastBindingSource;
        private HMSDataSetTableAdapters.DoctorMastTableAdapter doctorMastTableAdapter;
        private System.Windows.Forms.BindingSource doctorMastBindingSource;
        private System.Windows.Forms.TextBox temperatureTextBox;
        private System.Windows.Forms.TextBox pulseRateTextBox;
        private System.Windows.Forms.TextBox othersTextBox;
        private System.Windows.Forms.TextBox accidentTextBox;
        private System.Windows.Forms.TextBox surgeryTextBox;
        private System.Windows.Forms.TextBox currentMedicationTextBox;
        private System.Windows.Forms.TextBox adviceTextBox;
        private System.Windows.Forms.TextBox testTextBox;
        private System.Windows.Forms.TextBox problemDescriptionTextBox;
        private System.Windows.Forms.BindingSource presMedBindingSource;
        private HMSDataSetTableAdapters.PresMedTableAdapter presMedTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox nextVisitTypeComboBox;
        private System.Windows.Forms.TextBox nextVisitPeriodTextBox;
        private System.Windows.Forms.DateTimePicker presDateDateTimePicker;
        private System.Windows.Forms.DataGridView presMedDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}