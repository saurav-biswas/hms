namespace HMS.Forms.Billing
{
    partial class FinalBillFrm
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
            System.Windows.Forms.Label patIDLabel1;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label advAmtLabel;
            System.Windows.Forms.Label payDateLabel;
            System.Windows.Forms.Label payModeLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label OtherItems;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label taxNameLabel;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label9;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label21;
            System.Windows.Forms.Label label22;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FinalBillFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPrintDrChrgs = new System.Windows.Forms.Button();
            this.buttonIPD = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEstimation = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.FBMaintabPage = new System.Windows.Forms.TabPage();
            this.textBoxAdvIds = new System.Windows.Forms.TextBox();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.textBoxPS = new System.Windows.Forms.TextBox();
            this.textBoxPO = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxDissposableAmt = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.DischargedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AdmissiondateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RefDrtextBox = new System.Windows.Forms.TextBox();
            this.UnderDrtextBox = new System.Windows.Forms.TextBox();
            this.PINtextBox = new System.Windows.Forms.TextBox();
            this.CitytextBox = new System.Windows.Forms.TextBox();
            this.Address2textBox = new System.Windows.Forms.TextBox();
            this.Address1textBox = new System.Windows.Forms.TextBox();
            this.GarNametextBox = new System.Windows.Forms.TextBox();
            this.PatAgetextBox = new System.Windows.Forms.TextBox();
            this.PatGendertextBox = new System.Windows.Forms.TextBox();
            this.FinalpayDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.percentageTextBox = new System.Windows.Forms.TextBox();
            this.taxMastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hMSDataSet = new HMS.HMSDataSet();
            this.ReceivablesAmttextBox = new System.Windows.Forms.TextBox();
            this.payModeComboBox = new System.Windows.Forms.ComboBox();
            this.AdvanceAmttextBox = new System.Windows.Forms.TextBox();
            this.IPDSearchtextBox = new System.Windows.Forms.TextBox();
            this.ChargeableAmttextBox = new System.Windows.Forms.TextBox();
            this.PatientidTextBox = new System.Windows.Forms.TextBox();
            this.OthrChrgAmtstextBox = new System.Windows.Forms.TextBox();
            this.BloodAmttextBox = new System.Windows.Forms.TextBox();
            this.PatNametextBox = new System.Windows.Forms.TextBox();
            this.TotAmttextBox = new System.Windows.Forms.TextBox();
            this.MedicinesAmttextBox = new System.Windows.Forms.TextBox();
            this.DocFeesAmttextBox = new System.Windows.Forms.TextBox();
            this.DetailTotalAmttextBox = new System.Windows.Forms.TextBox();
            this.taxNameComboBox = new System.Windows.Forms.ComboBox();
            this.TaxAmttextBox = new System.Windows.Forms.TextBox();
            this.ConcessionAmttextBox = new System.Windows.Forms.TextBox();
            this.tabPageDrChrg = new System.Windows.Forms.TabPage();
            this.dataGridViewDocChrg = new System.Windows.Forms.DataGridView();
            this.BillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxDocTot = new System.Windows.Forms.TextBox();
            this.FBBedtabPage = new System.Windows.Forms.TabPage();
            this.bedManagementDataGridView = new System.Windows.Forms.DataGridView();
            this.BedAmtTextBox = new System.Windows.Forms.TextBox();
            this.FBOtherItemstabPage = new System.Windows.Forms.TabPage();
            this.OtherItemsdataGridView = new System.Windows.Forms.DataGridView();
            this.FBOItemsTID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FBOItemsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FBOItemsPerticulars = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FBOItemsAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtherAmttextBox = new System.Windows.Forms.TextBox();
            this.Savebutton = new System.Windows.Forms.Button();
            this.printbutton = new System.Windows.Forms.Button();
            this.bedManagementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iPDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new HMS.HMSDataSetTableAdapters.TableAdapterManager();
            this.FinalBillListdataGridView = new System.Windows.Forms.DataGridView();
            this.bedManagementTableAdapter = new HMS.HMSDataSetTableAdapters.BedManagementTableAdapter();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayMode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IPD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BedAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtherAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetailAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concession = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocFees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medicines = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Blood = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtherCharges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChargeableAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdvanceAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalReceivable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DissposableAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            patIDLabel1 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            advAmtLabel = new System.Windows.Forms.Label();
            payDateLabel = new System.Windows.Forms.Label();
            payModeLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            OtherItems = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            taxNameLabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label21 = new System.Windows.Forms.Label();
            label22 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.FBMaintabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taxMastBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).BeginInit();
            this.tabPageDrChrg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocChrg)).BeginInit();
            this.FBBedtabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bedManagementDataGridView)).BeginInit();
            this.FBOtherItemstabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OtherItemsdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedManagementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalBillListdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // patIDLabel1
            // 
            patIDLabel1.AutoSize = true;
            patIDLabel1.Location = new System.Drawing.Point(66, 70);
            patIDLabel1.Name = "patIDLabel1";
            patIDLabel1.Size = new System.Drawing.Size(28, 13);
            patIDLabel1.TabIndex = 46;
            patIDLabel1.Text = "IPD:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(20, 95);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(74, 13);
            label1.TabIndex = 45;
            label1.Text = "Patient Name:";
            // 
            // advAmtLabel
            // 
            advAmtLabel.AutoSize = true;
            advAmtLabel.Location = new System.Drawing.Point(813, 292);
            advAmtLabel.Name = "advAmtLabel";
            advAmtLabel.Size = new System.Drawing.Size(68, 13);
            advAmtLabel.TabIndex = 11;
            advAmtLabel.Text = "Bed Amount:";
            // 
            // payDateLabel
            // 
            payDateLabel.AutoSize = true;
            payDateLabel.Location = new System.Drawing.Point(45, 43);
            payDateLabel.Name = "payDateLabel";
            payDateLabel.Size = new System.Drawing.Size(49, 13);
            payDateLabel.TabIndex = 9;
            payDateLabel.Text = "Bill Date:";
            // 
            // payModeLabel
            // 
            payModeLabel.AutoSize = true;
            payModeLabel.Location = new System.Drawing.Point(35, 121);
            payModeLabel.Name = "payModeLabel";
            payModeLabel.Size = new System.Drawing.Size(58, 13);
            payModeLabel.TabIndex = 7;
            payModeLabel.Text = "Pay Mode:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(17, 11);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(77, 13);
            idLabel.TabIndex = 0;
            idLabel.Text = "TransactionID:";
            // 
            // OtherItems
            // 
            OtherItems.AutoSize = true;
            OtherItems.Location = new System.Drawing.Point(3, 0);
            OtherItems.Name = "OtherItems";
            OtherItems.Size = new System.Drawing.Size(64, 13);
            OtherItems.TabIndex = 57;
            OtherItems.Text = "Other Items:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(828, 294);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(75, 13);
            label2.TabIndex = 58;
            label2.Text = "Other Amount:";
            // 
            // taxNameLabel
            // 
            taxNameLabel.AutoSize = true;
            taxNameLabel.Location = new System.Drawing.Point(330, 46);
            taxNameLabel.Name = "taxNameLabel";
            taxNameLabel.Size = new System.Drawing.Size(59, 13);
            taxNameLabel.TabIndex = 61;
            taxNameLabel.Text = "Tax Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(445, 72);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(62, 13);
            label3.TabIndex = 65;
            label3.Text = "Concession";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(445, 20);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(61, 13);
            label4.TabIndex = 67;
            label4.Text = "Detail Total";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(775, 40);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(65, 13);
            label5.TabIndex = 69;
            label5.Text = "Doctor Fees";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(775, 66);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(55, 13);
            label6.TabIndex = 71;
            label6.Text = "Medicines";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(775, 92);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(34, 13);
            label7.TabIndex = 73;
            label7.Text = "Blood";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(775, 118);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(75, 13);
            label8.TabIndex = 75;
            label8.Text = "Other Charges";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(445, 124);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(70, 13);
            label9.TabIndex = 77;
            label9.Text = "Total Amount";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(775, 144);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(100, 13);
            label10.TabIndex = 79;
            label10.Text = "Chargeable Amount";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(775, 206);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(89, 13);
            label11.TabIndex = 81;
            label11.Text = "Advance Amount";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(775, 232);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(93, 13);
            label12.TabIndex = 83;
            label12.Text = "Total Receivables";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(19, 12);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(64, 13);
            label13.TabIndex = 85;
            label13.Text = "Bed Details:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new System.Drawing.Point(7, 9);
            label21.Name = "label21";
            label21.Size = new System.Drawing.Size(84, 13);
            label21.TabIndex = 61;
            label21.Text = "Doctor Charges:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new System.Drawing.Point(832, 303);
            label22.Name = "label22";
            label22.Size = new System.Drawing.Size(69, 13);
            label22.TabIndex = 62;
            label22.Text = "Doc Amount:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonPrintDrChrgs);
            this.panel1.Controls.Add(this.buttonIPD);
            this.panel1.Controls.Add(this.buttonDel);
            this.panel1.Controls.Add(this.buttonEstimation);
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.Savebutton);
            this.panel1.Controls.Add(this.printbutton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 412);
            this.panel1.TabIndex = 2;
            // 
            // buttonPrintDrChrgs
            // 
            this.buttonPrintDrChrgs.Location = new System.Drawing.Point(532, 14);
            this.buttonPrintDrChrgs.Name = "buttonPrintDrChrgs";
            this.buttonPrintDrChrgs.Size = new System.Drawing.Size(122, 23);
            this.buttonPrintDrChrgs.TabIndex = 108;
            this.buttonPrintDrChrgs.Text = "Print Doctor Charges";
            this.buttonPrintDrChrgs.UseVisualStyleBackColor = true;
            this.buttonPrintDrChrgs.Click += new System.EventHandler(this.buttonPrintDrChrgs_Click);
            // 
            // buttonIPD
            // 
            this.buttonIPD.Location = new System.Drawing.Point(1079, 14);
            this.buttonIPD.Name = "buttonIPD";
            this.buttonIPD.Size = new System.Drawing.Size(75, 23);
            this.buttonIPD.TabIndex = 107;
            this.buttonIPD.Text = "IPD";
            this.buttonIPD.UseVisualStyleBackColor = true;
            this.buttonIPD.Click += new System.EventHandler(this.buttonIPD_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(711, 14);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 88;
            this.buttonDel.Text = "Delete";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEstimation
            // 
            this.buttonEstimation.Location = new System.Drawing.Point(396, 14);
            this.buttonEstimation.Name = "buttonEstimation";
            this.buttonEstimation.Size = new System.Drawing.Size(75, 23);
            this.buttonEstimation.TabIndex = 2;
            this.buttonEstimation.Text = "Estimation";
            this.buttonEstimation.UseVisualStyleBackColor = true;
            this.buttonEstimation.Click += new System.EventHandler(this.buttonEstimation_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.FBMaintabPage);
            this.tabControl1.Controls.Add(this.tabPageDrChrg);
            this.tabControl1.Controls.Add(this.FBBedtabPage);
            this.tabControl1.Controls.Add(this.FBOtherItemstabPage);
            this.tabControl1.Location = new System.Drawing.Point(33, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1125, 363);
            this.tabControl1.TabIndex = 87;
            // 
            // FBMaintabPage
            // 
            this.FBMaintabPage.Controls.Add(this.textBoxAdvIds);
            this.FBMaintabPage.Controls.Add(this.textBoxCountry);
            this.FBMaintabPage.Controls.Add(this.textBoxPS);
            this.FBMaintabPage.Controls.Add(this.textBoxPO);
            this.FBMaintabPage.Controls.Add(this.label20);
            this.FBMaintabPage.Controls.Add(this.textBoxDissposableAmt);
            this.FBMaintabPage.Controls.Add(this.label19);
            this.FBMaintabPage.Controls.Add(this.label18);
            this.FBMaintabPage.Controls.Add(this.label17);
            this.FBMaintabPage.Controls.Add(this.label16);
            this.FBMaintabPage.Controls.Add(this.label15);
            this.FBMaintabPage.Controls.Add(this.label14);
            this.FBMaintabPage.Controls.Add(this.DischargedateTimePicker);
            this.FBMaintabPage.Controls.Add(this.AdmissiondateTimePicker);
            this.FBMaintabPage.Controls.Add(this.RefDrtextBox);
            this.FBMaintabPage.Controls.Add(this.UnderDrtextBox);
            this.FBMaintabPage.Controls.Add(this.PINtextBox);
            this.FBMaintabPage.Controls.Add(this.CitytextBox);
            this.FBMaintabPage.Controls.Add(this.Address2textBox);
            this.FBMaintabPage.Controls.Add(this.Address1textBox);
            this.FBMaintabPage.Controls.Add(this.GarNametextBox);
            this.FBMaintabPage.Controls.Add(this.PatAgetextBox);
            this.FBMaintabPage.Controls.Add(this.PatGendertextBox);
            this.FBMaintabPage.Controls.Add(this.FinalpayDateDateTimePicker);
            this.FBMaintabPage.Controls.Add(this.idTextBox);
            this.FBMaintabPage.Controls.Add(label12);
            this.FBMaintabPage.Controls.Add(this.percentageTextBox);
            this.FBMaintabPage.Controls.Add(this.ReceivablesAmttextBox);
            this.FBMaintabPage.Controls.Add(idLabel);
            this.FBMaintabPage.Controls.Add(label11);
            this.FBMaintabPage.Controls.Add(this.payModeComboBox);
            this.FBMaintabPage.Controls.Add(this.AdvanceAmttextBox);
            this.FBMaintabPage.Controls.Add(this.IPDSearchtextBox);
            this.FBMaintabPage.Controls.Add(label10);
            this.FBMaintabPage.Controls.Add(payModeLabel);
            this.FBMaintabPage.Controls.Add(this.ChargeableAmttextBox);
            this.FBMaintabPage.Controls.Add(payDateLabel);
            this.FBMaintabPage.Controls.Add(label8);
            this.FBMaintabPage.Controls.Add(this.PatientidTextBox);
            this.FBMaintabPage.Controls.Add(this.OthrChrgAmtstextBox);
            this.FBMaintabPage.Controls.Add(label7);
            this.FBMaintabPage.Controls.Add(label9);
            this.FBMaintabPage.Controls.Add(this.BloodAmttextBox);
            this.FBMaintabPage.Controls.Add(this.PatNametextBox);
            this.FBMaintabPage.Controls.Add(label6);
            this.FBMaintabPage.Controls.Add(this.TotAmttextBox);
            this.FBMaintabPage.Controls.Add(this.MedicinesAmttextBox);
            this.FBMaintabPage.Controls.Add(label1);
            this.FBMaintabPage.Controls.Add(label5);
            this.FBMaintabPage.Controls.Add(this.DocFeesAmttextBox);
            this.FBMaintabPage.Controls.Add(patIDLabel1);
            this.FBMaintabPage.Controls.Add(this.DetailTotalAmttextBox);
            this.FBMaintabPage.Controls.Add(this.taxNameComboBox);
            this.FBMaintabPage.Controls.Add(taxNameLabel);
            this.FBMaintabPage.Controls.Add(this.TaxAmttextBox);
            this.FBMaintabPage.Controls.Add(this.ConcessionAmttextBox);
            this.FBMaintabPage.Controls.Add(label4);
            this.FBMaintabPage.Controls.Add(label3);
            this.FBMaintabPage.Location = new System.Drawing.Point(4, 22);
            this.FBMaintabPage.Name = "FBMaintabPage";
            this.FBMaintabPage.Padding = new System.Windows.Forms.Padding(3);
            this.FBMaintabPage.Size = new System.Drawing.Size(1117, 337);
            this.FBMaintabPage.TabIndex = 0;
            this.FBMaintabPage.Text = "Main";
            this.FBMaintabPage.UseVisualStyleBackColor = true;
            // 
            // textBoxAdvIds
            // 
            this.textBoxAdvIds.Location = new System.Drawing.Point(376, 300);
            this.textBoxAdvIds.Name = "textBoxAdvIds";
            this.textBoxAdvIds.ReadOnly = true;
            this.textBoxAdvIds.Size = new System.Drawing.Size(207, 20);
            this.textBoxAdvIds.TabIndex = 132;
            this.textBoxAdvIds.Visible = false;
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Location = new System.Drawing.Point(103, 300);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.ReadOnly = true;
            this.textBoxCountry.Size = new System.Drawing.Size(204, 20);
            this.textBoxCountry.TabIndex = 131;
            // 
            // textBoxPS
            // 
            this.textBoxPS.Location = new System.Drawing.Point(206, 274);
            this.textBoxPS.Name = "textBoxPS";
            this.textBoxPS.ReadOnly = true;
            this.textBoxPS.Size = new System.Drawing.Size(100, 20);
            this.textBoxPS.TabIndex = 130;
            // 
            // textBoxPO
            // 
            this.textBoxPO.Location = new System.Drawing.Point(101, 274);
            this.textBoxPO.Name = "textBoxPO";
            this.textBoxPO.ReadOnly = true;
            this.textBoxPO.Size = new System.Drawing.Size(100, 20);
            this.textBoxPO.TabIndex = 129;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(775, 14);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(64, 13);
            this.label20.TabIndex = 128;
            this.label20.Text = "Dissposable";
            // 
            // textBoxDissposableAmt
            // 
            this.textBoxDissposableAmt.Location = new System.Drawing.Point(882, 11);
            this.textBoxDissposableAmt.Name = "textBoxDissposableAmt";
            this.textBoxDissposableAmt.Size = new System.Drawing.Size(184, 20);
            this.textBoxDissposableAmt.TabIndex = 127;
            this.textBoxDissposableAmt.Text = "0";
            this.textBoxDissposableAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxDissposableAmt.TextChanged += new System.EventHandler(this.textBoxDissposableAmt_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(373, 251);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 13);
            this.label19.TabIndex = 126;
            this.label19.Text = "Discharge Dt.:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(373, 229);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(74, 13);
            this.label18.TabIndex = 125;
            this.label18.Text = "Admission Dt.:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(391, 210);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 124;
            this.label17.Text = "Under Dr.:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(46, 200);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 13);
            this.label16.TabIndex = 123;
            this.label16.Text = "Address:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 174);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 122;
            this.label15.Text = "Gardian Name:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 148);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 121;
            this.label14.Text = "Gender/Age:";
            // 
            // DischargedateTimePicker
            // 
            this.DischargedateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DischargedateTimePicker.Location = new System.Drawing.Point(448, 248);
            this.DischargedateTimePicker.Name = "DischargedateTimePicker";
            this.DischargedateTimePicker.Size = new System.Drawing.Size(263, 20);
            this.DischargedateTimePicker.TabIndex = 7;
            this.DischargedateTimePicker.ValueChanged += new System.EventHandler(this.DischargedateTimePicker_ValueChanged);
            // 
            // AdmissiondateTimePicker
            // 
            this.AdmissiondateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.AdmissiondateTimePicker.Location = new System.Drawing.Point(448, 226);
            this.AdmissiondateTimePicker.Name = "AdmissiondateTimePicker";
            this.AdmissiondateTimePicker.Size = new System.Drawing.Size(263, 20);
            this.AdmissiondateTimePicker.TabIndex = 6;
            this.AdmissiondateTimePicker.ValueChanged += new System.EventHandler(this.AdmissiondateTimePicker_ValueChanged);
            // 
            // RefDrtextBox
            // 
            this.RefDrtextBox.Location = new System.Drawing.Point(394, 148);
            this.RefDrtextBox.Name = "RefDrtextBox";
            this.RefDrtextBox.ReadOnly = true;
            this.RefDrtextBox.Size = new System.Drawing.Size(203, 20);
            this.RefDrtextBox.TabIndex = 118;
            this.RefDrtextBox.Visible = false;
            // 
            // UnderDrtextBox
            // 
            this.UnderDrtextBox.Location = new System.Drawing.Point(448, 203);
            this.UnderDrtextBox.Name = "UnderDrtextBox";
            this.UnderDrtextBox.ReadOnly = true;
            this.UnderDrtextBox.Size = new System.Drawing.Size(263, 20);
            this.UnderDrtextBox.TabIndex = 117;
            // 
            // PINtextBox
            // 
            this.PINtextBox.Location = new System.Drawing.Point(206, 248);
            this.PINtextBox.Name = "PINtextBox";
            this.PINtextBox.ReadOnly = true;
            this.PINtextBox.Size = new System.Drawing.Size(100, 20);
            this.PINtextBox.TabIndex = 116;
            // 
            // CitytextBox
            // 
            this.CitytextBox.Location = new System.Drawing.Point(100, 248);
            this.CitytextBox.Name = "CitytextBox";
            this.CitytextBox.ReadOnly = true;
            this.CitytextBox.Size = new System.Drawing.Size(100, 20);
            this.CitytextBox.TabIndex = 115;
            // 
            // Address2textBox
            // 
            this.Address2textBox.Location = new System.Drawing.Point(100, 222);
            this.Address2textBox.Name = "Address2textBox";
            this.Address2textBox.ReadOnly = true;
            this.Address2textBox.Size = new System.Drawing.Size(207, 20);
            this.Address2textBox.TabIndex = 114;
            // 
            // Address1textBox
            // 
            this.Address1textBox.Location = new System.Drawing.Point(100, 196);
            this.Address1textBox.Name = "Address1textBox";
            this.Address1textBox.ReadOnly = true;
            this.Address1textBox.Size = new System.Drawing.Size(207, 20);
            this.Address1textBox.TabIndex = 113;
            // 
            // GarNametextBox
            // 
            this.GarNametextBox.Location = new System.Drawing.Point(100, 170);
            this.GarNametextBox.Name = "GarNametextBox";
            this.GarNametextBox.ReadOnly = true;
            this.GarNametextBox.Size = new System.Drawing.Size(207, 20);
            this.GarNametextBox.TabIndex = 112;
            // 
            // PatAgetextBox
            // 
            this.PatAgetextBox.Location = new System.Drawing.Point(207, 145);
            this.PatAgetextBox.Name = "PatAgetextBox";
            this.PatAgetextBox.ReadOnly = true;
            this.PatAgetextBox.Size = new System.Drawing.Size(100, 20);
            this.PatAgetextBox.TabIndex = 111;
            // 
            // PatGendertextBox
            // 
            this.PatGendertextBox.Location = new System.Drawing.Point(101, 145);
            this.PatGendertextBox.Name = "PatGendertextBox";
            this.PatGendertextBox.ReadOnly = true;
            this.PatGendertextBox.Size = new System.Drawing.Size(100, 20);
            this.PatGendertextBox.TabIndex = 110;
            // 
            // FinalpayDateDateTimePicker
            // 
            this.FinalpayDateDateTimePicker.CustomFormat = "";
            this.FinalpayDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FinalpayDateDateTimePicker.Location = new System.Drawing.Point(103, 41);
            this.FinalpayDateDateTimePicker.Name = "FinalpayDateDateTimePicker";
            this.FinalpayDateDateTimePicker.Size = new System.Drawing.Size(203, 20);
            this.FinalpayDateDateTimePicker.TabIndex = 1;
            this.FinalpayDateDateTimePicker.ValueChanged += new System.EventHandler(this.FinalpayDateDateTimePicker_ValueChanged_1);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(100, 11);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(207, 20);
            this.idTextBox.TabIndex = 0;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // percentageTextBox
            // 
            this.percentageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.taxMastBindingSource, "Percentage", true));
            this.percentageTextBox.Location = new System.Drawing.Point(522, 43);
            this.percentageTextBox.Name = "percentageTextBox";
            this.percentageTextBox.ReadOnly = true;
            this.percentageTextBox.Size = new System.Drawing.Size(50, 20);
            this.percentageTextBox.TabIndex = 86;
            this.percentageTextBox.Text = "15";
            // 
            // taxMastBindingSource
            // 
            this.taxMastBindingSource.DataMember = "TaxMast";
            this.taxMastBindingSource.DataSource = this.hMSDataSet;
            // 
            // hMSDataSet
            // 
            this.hMSDataSet.DataSetName = "HMSDataSet";
            this.hMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ReceivablesAmttextBox
            // 
            this.ReceivablesAmttextBox.Location = new System.Drawing.Point(882, 229);
            this.ReceivablesAmttextBox.Name = "ReceivablesAmttextBox";
            this.ReceivablesAmttextBox.ReadOnly = true;
            this.ReceivablesAmttextBox.Size = new System.Drawing.Size(184, 20);
            this.ReceivablesAmttextBox.TabIndex = 82;
            this.ReceivablesAmttextBox.Text = "0";
            this.ReceivablesAmttextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ReceivablesAmttextBox.TextChanged += new System.EventHandler(this.ReceivablesAmttextBox_TextChanged);
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
            this.payModeComboBox.Location = new System.Drawing.Point(99, 118);
            this.payModeComboBox.Name = "payModeComboBox";
            this.payModeComboBox.Size = new System.Drawing.Size(207, 21);
            this.payModeComboBox.TabIndex = 3;
            // 
            // AdvanceAmttextBox
            // 
            this.AdvanceAmttextBox.Location = new System.Drawing.Point(882, 203);
            this.AdvanceAmttextBox.Name = "AdvanceAmttextBox";
            this.AdvanceAmttextBox.ReadOnly = true;
            this.AdvanceAmttextBox.Size = new System.Drawing.Size(184, 20);
            this.AdvanceAmttextBox.TabIndex = 80;
            this.AdvanceAmttextBox.Text = "0";
            this.AdvanceAmttextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AdvanceAmttextBox.TextChanged += new System.EventHandler(this.AdvanceAmttextBox_TextChanged);
            // 
            // IPDSearchtextBox
            // 
            this.IPDSearchtextBox.Location = new System.Drawing.Point(100, 67);
            this.IPDSearchtextBox.Name = "IPDSearchtextBox";
            this.IPDSearchtextBox.Size = new System.Drawing.Size(207, 20);
            this.IPDSearchtextBox.TabIndex = 2;
            this.IPDSearchtextBox.TextChanged += new System.EventHandler(this.IPDSearchtextBox_TextChanged);
            // 
            // ChargeableAmttextBox
            // 
            this.ChargeableAmttextBox.Location = new System.Drawing.Point(882, 141);
            this.ChargeableAmttextBox.Name = "ChargeableAmttextBox";
            this.ChargeableAmttextBox.ReadOnly = true;
            this.ChargeableAmttextBox.Size = new System.Drawing.Size(184, 20);
            this.ChargeableAmttextBox.TabIndex = 78;
            this.ChargeableAmttextBox.Text = "0";
            this.ChargeableAmttextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ChargeableAmttextBox.TextChanged += new System.EventHandler(this.ChargeableAmttextBox_TextChanged);
            // 
            // PatientidTextBox
            // 
            this.PatientidTextBox.Location = new System.Drawing.Point(395, 170);
            this.PatientidTextBox.Name = "PatientidTextBox";
            this.PatientidTextBox.ReadOnly = true;
            this.PatientidTextBox.Size = new System.Drawing.Size(207, 20);
            this.PatientidTextBox.TabIndex = 43;
            this.PatientidTextBox.Visible = false;
            this.PatientidTextBox.TextChanged += new System.EventHandler(this.PatientidTextBox_TextChanged);
            // 
            // OthrChrgAmtstextBox
            // 
            this.OthrChrgAmtstextBox.Location = new System.Drawing.Point(882, 115);
            this.OthrChrgAmtstextBox.Name = "OthrChrgAmtstextBox";
            this.OthrChrgAmtstextBox.Size = new System.Drawing.Size(184, 20);
            this.OthrChrgAmtstextBox.TabIndex = 11;
            this.OthrChrgAmtstextBox.Text = "0";
            this.OthrChrgAmtstextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.OthrChrgAmtstextBox.TextChanged += new System.EventHandler(this.OthrChrgAmtstextBox_TextChanged);
            // 
            // BloodAmttextBox
            // 
            this.BloodAmttextBox.Location = new System.Drawing.Point(882, 89);
            this.BloodAmttextBox.Name = "BloodAmttextBox";
            this.BloodAmttextBox.Size = new System.Drawing.Size(184, 20);
            this.BloodAmttextBox.TabIndex = 10;
            this.BloodAmttextBox.Text = "0";
            this.BloodAmttextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BloodAmttextBox.TextChanged += new System.EventHandler(this.BloodAmttextBox_TextChanged);
            // 
            // PatNametextBox
            // 
            this.PatNametextBox.Location = new System.Drawing.Point(99, 92);
            this.PatNametextBox.Name = "PatNametextBox";
            this.PatNametextBox.ReadOnly = true;
            this.PatNametextBox.Size = new System.Drawing.Size(207, 20);
            this.PatNametextBox.TabIndex = 44;
            // 
            // TotAmttextBox
            // 
            this.TotAmttextBox.Location = new System.Drawing.Point(527, 121);
            this.TotAmttextBox.Name = "TotAmttextBox";
            this.TotAmttextBox.ReadOnly = true;
            this.TotAmttextBox.Size = new System.Drawing.Size(184, 20);
            this.TotAmttextBox.TabIndex = 76;
            this.TotAmttextBox.Text = "0";
            this.TotAmttextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TotAmttextBox.TextChanged += new System.EventHandler(this.TotAmttextBox_TextChanged);
            // 
            // MedicinesAmttextBox
            // 
            this.MedicinesAmttextBox.Location = new System.Drawing.Point(882, 63);
            this.MedicinesAmttextBox.Name = "MedicinesAmttextBox";
            this.MedicinesAmttextBox.Size = new System.Drawing.Size(184, 20);
            this.MedicinesAmttextBox.TabIndex = 9;
            this.MedicinesAmttextBox.Text = "0";
            this.MedicinesAmttextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MedicinesAmttextBox.TextChanged += new System.EventHandler(this.MedicinesAmttextBox_TextChanged);
            // 
            // DocFeesAmttextBox
            // 
            this.DocFeesAmttextBox.Location = new System.Drawing.Point(882, 37);
            this.DocFeesAmttextBox.Name = "DocFeesAmttextBox";
            this.DocFeesAmttextBox.Size = new System.Drawing.Size(184, 20);
            this.DocFeesAmttextBox.TabIndex = 8;
            this.DocFeesAmttextBox.Text = "0";
            this.DocFeesAmttextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DocFeesAmttextBox.TextChanged += new System.EventHandler(this.DocFeesAmttextBox_TextChanged);
            // 
            // DetailTotalAmttextBox
            // 
            this.DetailTotalAmttextBox.Location = new System.Drawing.Point(527, 17);
            this.DetailTotalAmttextBox.Name = "DetailTotalAmttextBox";
            this.DetailTotalAmttextBox.ReadOnly = true;
            this.DetailTotalAmttextBox.Size = new System.Drawing.Size(184, 20);
            this.DetailTotalAmttextBox.TabIndex = 66;
            this.DetailTotalAmttextBox.Text = "0";
            this.DetailTotalAmttextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DetailTotalAmttextBox.TextChanged += new System.EventHandler(this.DetailTotalAmttextBox_TextChanged);
            // 
            // taxNameComboBox
            // 
            this.taxNameComboBox.DisplayMember = "TaxName";
            this.taxNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.taxNameComboBox.FormattingEnabled = true;
            this.taxNameComboBox.Location = new System.Drawing.Point(395, 43);
            this.taxNameComboBox.Name = "taxNameComboBox";
            this.taxNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.taxNameComboBox.TabIndex = 4;
            this.taxNameComboBox.ValueMember = "TaxName";
            // 
            // TaxAmttextBox
            // 
            this.TaxAmttextBox.Location = new System.Drawing.Point(578, 43);
            this.TaxAmttextBox.Name = "TaxAmttextBox";
            this.TaxAmttextBox.ReadOnly = true;
            this.TaxAmttextBox.Size = new System.Drawing.Size(133, 20);
            this.TaxAmttextBox.TabIndex = 63;
            this.TaxAmttextBox.Text = "0";
            this.TaxAmttextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TaxAmttextBox.TextChanged += new System.EventHandler(this.TaxAmttextBox_TextChanged);
            // 
            // ConcessionAmttextBox
            // 
            this.ConcessionAmttextBox.Location = new System.Drawing.Point(527, 69);
            this.ConcessionAmttextBox.Name = "ConcessionAmttextBox";
            this.ConcessionAmttextBox.Size = new System.Drawing.Size(184, 20);
            this.ConcessionAmttextBox.TabIndex = 5;
            this.ConcessionAmttextBox.Text = "0";
            this.ConcessionAmttextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ConcessionAmttextBox.TextChanged += new System.EventHandler(this.ConcessionAmttextBox_TextChanged);
            // 
            // tabPageDrChrg
            // 
            this.tabPageDrChrg.Controls.Add(label21);
            this.tabPageDrChrg.Controls.Add(this.dataGridViewDocChrg);
            this.tabPageDrChrg.Controls.Add(this.textBoxDocTot);
            this.tabPageDrChrg.Controls.Add(label22);
            this.tabPageDrChrg.Location = new System.Drawing.Point(4, 22);
            this.tabPageDrChrg.Name = "tabPageDrChrg";
            this.tabPageDrChrg.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDrChrg.Size = new System.Drawing.Size(1117, 337);
            this.tabPageDrChrg.TabIndex = 3;
            this.tabPageDrChrg.Text = "Doctor Charges";
            this.tabPageDrChrg.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDocChrg
            // 
            this.dataGridViewDocChrg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDocChrg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillNo,
            this.DrDate,
            this.Doctor,
            this.DocAmount});
            this.dataGridViewDocChrg.Location = new System.Drawing.Point(10, 28);
            this.dataGridViewDocChrg.Name = "dataGridViewDocChrg";
            this.dataGridViewDocChrg.Size = new System.Drawing.Size(1099, 266);
            this.dataGridViewDocChrg.TabIndex = 60;
            this.dataGridViewDocChrg.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDocChrg_CellValueChanged);
            this.dataGridViewDocChrg.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewDocChrg_RowsAdded);
            // 
            // BillNo
            // 
            this.BillNo.HeaderText = "Final Bill No.";
            this.BillNo.Name = "BillNo";
            this.BillNo.ReadOnly = true;
            // 
            // DrDate
            // 
            this.DrDate.HeaderText = "Date";
            this.DrDate.Name = "DrDate";
            // 
            // Doctor
            // 
            this.Doctor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Doctor.HeaderText = "Doctor";
            this.Doctor.MinimumWidth = 400;
            this.Doctor.Name = "Doctor";
            this.Doctor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DocAmount
            // 
            this.DocAmount.HeaderText = "Amount";
            this.DocAmount.Name = "DocAmount";
            // 
            // textBoxDocTot
            // 
            this.textBoxDocTot.Location = new System.Drawing.Point(906, 300);
            this.textBoxDocTot.Name = "textBoxDocTot";
            this.textBoxDocTot.ReadOnly = true;
            this.textBoxDocTot.Size = new System.Drawing.Size(203, 20);
            this.textBoxDocTot.TabIndex = 63;
            this.textBoxDocTot.Text = "0";
            this.textBoxDocTot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FBBedtabPage
            // 
            this.FBBedtabPage.Controls.Add(label13);
            this.FBBedtabPage.Controls.Add(this.bedManagementDataGridView);
            this.FBBedtabPage.Controls.Add(this.BedAmtTextBox);
            this.FBBedtabPage.Controls.Add(advAmtLabel);
            this.FBBedtabPage.Location = new System.Drawing.Point(4, 22);
            this.FBBedtabPage.Name = "FBBedtabPage";
            this.FBBedtabPage.Padding = new System.Windows.Forms.Padding(3);
            this.FBBedtabPage.Size = new System.Drawing.Size(1117, 337);
            this.FBBedtabPage.TabIndex = 1;
            this.FBBedtabPage.Text = "Beds";
            this.FBBedtabPage.UseVisualStyleBackColor = true;
            // 
            // bedManagementDataGridView
            // 
            this.bedManagementDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bedManagementDataGridView.Location = new System.Drawing.Point(22, 28);
            this.bedManagementDataGridView.Name = "bedManagementDataGridView";
            this.bedManagementDataGridView.Size = new System.Drawing.Size(1089, 255);
            this.bedManagementDataGridView.TabIndex = 83;
            this.bedManagementDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bedManagementDataGridView_CellContentClick);
            this.bedManagementDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.bedManagementDataGridView_RowsAdded);
            // 
            // BedAmtTextBox
            // 
            this.BedAmtTextBox.Location = new System.Drawing.Point(887, 289);
            this.BedAmtTextBox.Name = "BedAmtTextBox";
            this.BedAmtTextBox.ReadOnly = true;
            this.BedAmtTextBox.Size = new System.Drawing.Size(203, 20);
            this.BedAmtTextBox.TabIndex = 12;
            this.BedAmtTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BedAmtTextBox.TextChanged += new System.EventHandler(this.BedAmtTextBox_TextChanged);
            // 
            // FBOtherItemstabPage
            // 
            this.FBOtherItemstabPage.Controls.Add(OtherItems);
            this.FBOtherItemstabPage.Controls.Add(this.OtherItemsdataGridView);
            this.FBOtherItemstabPage.Controls.Add(this.OtherAmttextBox);
            this.FBOtherItemstabPage.Controls.Add(label2);
            this.FBOtherItemstabPage.Location = new System.Drawing.Point(4, 22);
            this.FBOtherItemstabPage.Name = "FBOtherItemstabPage";
            this.FBOtherItemstabPage.Size = new System.Drawing.Size(1117, 337);
            this.FBOtherItemstabPage.TabIndex = 2;
            this.FBOtherItemstabPage.Text = "Other Items";
            this.FBOtherItemstabPage.UseVisualStyleBackColor = true;
            // 
            // OtherItemsdataGridView
            // 
            this.OtherItemsdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OtherItemsdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FBOItemsTID,
            this.FBOItemsId,
            this.FBOItemsPerticulars,
            this.FBOItemsAmt});
            this.OtherItemsdataGridView.Location = new System.Drawing.Point(6, 19);
            this.OtherItemsdataGridView.Name = "OtherItemsdataGridView";
            this.OtherItemsdataGridView.Size = new System.Drawing.Size(1099, 266);
            this.OtherItemsdataGridView.TabIndex = 55;
            this.OtherItemsdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OtherItemsdataGridView_CellContentClick);
            this.OtherItemsdataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.OtherItemsdataGridView_CellValueChanged);
            this.OtherItemsdataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.OtherItemsdataGridView_RowsAdded_1);
            this.OtherItemsdataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.OtherItemsdataGridView_RowsRemoved);
            // 
            // FBOItemsTID
            // 
            this.FBOItemsTID.HeaderText = "Final Bill No.";
            this.FBOItemsTID.Name = "FBOItemsTID";
            this.FBOItemsTID.ReadOnly = true;
            // 
            // FBOItemsId
            // 
            this.FBOItemsId.HeaderText = "SlNo";
            this.FBOItemsId.Name = "FBOItemsId";
            this.FBOItemsId.ReadOnly = true;
            // 
            // FBOItemsPerticulars
            // 
            this.FBOItemsPerticulars.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FBOItemsPerticulars.HeaderText = "Particulars";
            this.FBOItemsPerticulars.MinimumWidth = 400;
            this.FBOItemsPerticulars.Name = "FBOItemsPerticulars";
            // 
            // FBOItemsAmt
            // 
            this.FBOItemsAmt.HeaderText = "Amount";
            this.FBOItemsAmt.Name = "FBOItemsAmt";
            // 
            // OtherAmttextBox
            // 
            this.OtherAmttextBox.Location = new System.Drawing.Point(902, 291);
            this.OtherAmttextBox.Name = "OtherAmttextBox";
            this.OtherAmttextBox.ReadOnly = true;
            this.OtherAmttextBox.Size = new System.Drawing.Size(203, 20);
            this.OtherAmttextBox.TabIndex = 59;
            this.OtherAmttextBox.Text = "0";
            this.OtherAmttextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.OtherAmttextBox.TextChanged += new System.EventHandler(this.OtherAmttextBox_TextChanged);
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(140, 14);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(75, 23);
            this.Savebutton.TabIndex = 0;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // printbutton
            // 
            this.printbutton.Location = new System.Drawing.Point(266, 14);
            this.printbutton.Name = "printbutton";
            this.printbutton.Size = new System.Drawing.Size(75, 23);
            this.printbutton.TabIndex = 1;
            this.printbutton.Text = "Print";
            this.printbutton.UseVisualStyleBackColor = true;
            this.printbutton.Click += new System.EventHandler(this.printbutton_Click);
            // 
            // bedManagementBindingSource
            // 
            this.bedManagementBindingSource.DataMember = "BedManagement";
            this.bedManagementBindingSource.DataSource = this.hMSDataSet;
            // 
            // iPDBindingSource
            // 
            this.iPDBindingSource.DataMember = "IPD";
            this.iPDBindingSource.DataSource = this.hMSDataSet;
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
            // FinalBillListdataGridView
            // 
            this.FinalBillListdataGridView.AllowUserToAddRows = false;
            this.FinalBillListdataGridView.AllowUserToDeleteRows = false;
            this.FinalBillListdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FinalBillListdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Date,
            this.PatientID,
            this.PatientName,
            this.PayMode,
            this.IPD,
            this.BedAmt,
            this.OtherAmt,
            this.DetailAmt,
            this.TaxName,
            this.TaxRate,
            this.TaxAmt,
            this.Concession,
            this.TotalAmt,
            this.DocFees,
            this.Medicines,
            this.Blood,
            this.OtherCharges,
            this.ChargeableAmt,
            this.AdvanceAmt,
            this.TotalReceivable,
            this.DissposableAmt});
            this.FinalBillListdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FinalBillListdataGridView.Location = new System.Drawing.Point(0, 412);
            this.FinalBillListdataGridView.Name = "FinalBillListdataGridView";
            this.FinalBillListdataGridView.ReadOnly = true;
            this.FinalBillListdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FinalBillListdataGridView.Size = new System.Drawing.Size(1203, 250);
            this.FinalBillListdataGridView.TabIndex = 3;
            this.FinalBillListdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FinalBillListdataGridView_CellContentClick);
            this.FinalBillListdataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.FinalBillListdataGridView_CellMouseDoubleClick);
            this.FinalBillListdataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FinalBillListdataGridView_MouseDoubleClick);
            // 
            // bedManagementTableAdapter
            // 
            this.bedManagementTableAdapter.ClearBeforeFill = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // PatientID
            // 
            this.PatientID.HeaderText = "PatientID";
            this.PatientID.Name = "PatientID";
            this.PatientID.ReadOnly = true;
            // 
            // PatientName
            // 
            this.PatientName.HeaderText = "PatientName";
            this.PatientName.Name = "PatientName";
            this.PatientName.ReadOnly = true;
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
            // BedAmt
            // 
            this.BedAmt.HeaderText = "BedAmt";
            this.BedAmt.Name = "BedAmt";
            this.BedAmt.ReadOnly = true;
            // 
            // OtherAmt
            // 
            this.OtherAmt.HeaderText = "OtherAmt";
            this.OtherAmt.Name = "OtherAmt";
            this.OtherAmt.ReadOnly = true;
            // 
            // DetailAmt
            // 
            this.DetailAmt.HeaderText = "Detail Amount";
            this.DetailAmt.Name = "DetailAmt";
            this.DetailAmt.ReadOnly = true;
            // 
            // TaxName
            // 
            this.TaxName.HeaderText = "Tax Name";
            this.TaxName.Name = "TaxName";
            this.TaxName.ReadOnly = true;
            // 
            // TaxRate
            // 
            this.TaxRate.HeaderText = "Tax Rate";
            this.TaxRate.Name = "TaxRate";
            this.TaxRate.ReadOnly = true;
            // 
            // TaxAmt
            // 
            this.TaxAmt.HeaderText = "Tax Amt";
            this.TaxAmt.Name = "TaxAmt";
            this.TaxAmt.ReadOnly = true;
            // 
            // Concession
            // 
            this.Concession.HeaderText = "Concession";
            this.Concession.Name = "Concession";
            this.Concession.ReadOnly = true;
            // 
            // TotalAmt
            // 
            this.TotalAmt.HeaderText = "Total Amount";
            this.TotalAmt.Name = "TotalAmt";
            this.TotalAmt.ReadOnly = true;
            // 
            // DocFees
            // 
            this.DocFees.HeaderText = "Doctor Fees";
            this.DocFees.Name = "DocFees";
            this.DocFees.ReadOnly = true;
            // 
            // Medicines
            // 
            this.Medicines.HeaderText = "Medicines";
            this.Medicines.Name = "Medicines";
            this.Medicines.ReadOnly = true;
            // 
            // Blood
            // 
            this.Blood.HeaderText = "Blood";
            this.Blood.Name = "Blood";
            this.Blood.ReadOnly = true;
            // 
            // OtherCharges
            // 
            this.OtherCharges.HeaderText = "OtherCharges";
            this.OtherCharges.Name = "OtherCharges";
            this.OtherCharges.ReadOnly = true;
            // 
            // ChargeableAmt
            // 
            this.ChargeableAmt.HeaderText = "ChargeableAmt";
            this.ChargeableAmt.Name = "ChargeableAmt";
            this.ChargeableAmt.ReadOnly = true;
            // 
            // AdvanceAmt
            // 
            this.AdvanceAmt.HeaderText = "AdvanceAmt";
            this.AdvanceAmt.Name = "AdvanceAmt";
            this.AdvanceAmt.ReadOnly = true;
            // 
            // TotalReceivable
            // 
            this.TotalReceivable.HeaderText = "TotalReceivable";
            this.TotalReceivable.Name = "TotalReceivable";
            this.TotalReceivable.ReadOnly = true;
            // 
            // DissposableAmt
            // 
            this.DissposableAmt.HeaderText = "DissposableAmt";
            this.DissposableAmt.Name = "DissposableAmt";
            this.DissposableAmt.ReadOnly = true;
            // 
            // FinalBillFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 662);
            this.Controls.Add(this.FinalBillListdataGridView);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FinalBillFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Final Bill";
            this.Load += new System.EventHandler(this.FinalBillFrm_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.FBMaintabPage.ResumeLayout(false);
            this.FBMaintabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.taxMastBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).EndInit();
            this.tabPageDrChrg.ResumeLayout(false);
            this.tabPageDrChrg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDocChrg)).EndInit();
            this.FBBedtabPage.ResumeLayout(false);
            this.FBBedtabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bedManagementDataGridView)).EndInit();
            this.FBOtherItemstabPage.ResumeLayout(false);
            this.FBOtherItemstabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OtherItemsdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedManagementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iPDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalBillListdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.TextBox PatNametextBox;
        private System.Windows.Forms.TextBox PatientidTextBox;
        private System.Windows.Forms.TextBox BedAmtTextBox;
        private System.Windows.Forms.Button printbutton;
        private System.Windows.Forms.ComboBox payModeComboBox;
        private System.Windows.Forms.TextBox idTextBox;
        private HMSDataSet hMSDataSet;
        private System.Windows.Forms.BindingSource iPDBindingSource;
        private System.Windows.Forms.DataGridView OtherItemsdataGridView;
        private System.Windows.Forms.TextBox OtherAmttextBox;
        private System.Windows.Forms.BindingSource taxMastBindingSource;
        private HMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox taxNameComboBox;
        private System.Windows.Forms.TextBox TaxAmttextBox;
        private System.Windows.Forms.TextBox ConcessionAmttextBox;
        private System.Windows.Forms.TextBox DetailTotalAmttextBox;
        private System.Windows.Forms.TextBox DocFeesAmttextBox;
        private System.Windows.Forms.TextBox MedicinesAmttextBox;
        private System.Windows.Forms.TextBox BloodAmttextBox;
        private System.Windows.Forms.TextBox OthrChrgAmtstextBox;
        private System.Windows.Forms.TextBox ChargeableAmttextBox;
        private System.Windows.Forms.TextBox TotAmttextBox;
        private System.Windows.Forms.TextBox AdvanceAmttextBox;
        private System.Windows.Forms.TextBox ReceivablesAmttextBox;
        private System.Windows.Forms.DataGridView FinalBillListdataGridView;
        private System.Windows.Forms.BindingSource bedManagementBindingSource;
        private HMSDataSetTableAdapters.BedManagementTableAdapter bedManagementTableAdapter;
        private System.Windows.Forms.DataGridView bedManagementDataGridView;
        private System.Windows.Forms.TextBox IPDSearchtextBox;
        private System.Windows.Forms.TextBox percentageTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage FBMaintabPage;
        private System.Windows.Forms.TabPage FBBedtabPage;
        private System.Windows.Forms.TabPage FBOtherItemstabPage;
        private System.Windows.Forms.DateTimePicker FinalpayDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker DischargedateTimePicker;
        private System.Windows.Forms.DateTimePicker AdmissiondateTimePicker;
        private System.Windows.Forms.TextBox RefDrtextBox;
        private System.Windows.Forms.TextBox UnderDrtextBox;
        private System.Windows.Forms.TextBox PINtextBox;
        private System.Windows.Forms.TextBox CitytextBox;
        private System.Windows.Forms.TextBox Address2textBox;
        private System.Windows.Forms.TextBox Address1textBox;
        private System.Windows.Forms.TextBox GarNametextBox;
        private System.Windows.Forms.TextBox PatAgetextBox;
        private System.Windows.Forms.TextBox PatGendertextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button buttonEstimation;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxDissposableAmt;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.TextBox textBoxPS;
        private System.Windows.Forms.TextBox textBoxPO;
        private System.Windows.Forms.TextBox textBoxAdvIds;
        private System.Windows.Forms.Button buttonIPD;
        private System.Windows.Forms.TabPage tabPageDrChrg;
        private System.Windows.Forms.DataGridView dataGridViewDocChrg;
        private System.Windows.Forms.TextBox textBoxDocTot;
        private System.Windows.Forms.DataGridViewTextBoxColumn FBOItemsTID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FBOItemsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FBOItemsPerticulars;
        private System.Windows.Forms.DataGridViewTextBoxColumn FBOItemsAmt;
        private System.Windows.Forms.Button buttonPrintDrChrgs;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayMode;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPD;
        private System.Windows.Forms.DataGridViewTextBoxColumn BedAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn OtherAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetailAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concession;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocFees;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medicines;
        private System.Windows.Forms.DataGridViewTextBoxColumn Blood;
        private System.Windows.Forms.DataGridViewTextBoxColumn OtherCharges;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChargeableAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdvanceAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalReceivable;
        private System.Windows.Forms.DataGridViewTextBoxColumn DissposableAmt;
    }
}