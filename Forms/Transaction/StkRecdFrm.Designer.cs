namespace HMS.Forms.Transaction
{
    partial class StkRecdFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StkRecdFrm));
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerBillDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBillNo = new System.Windows.Forms.TextBox();
            this.textBoxSuppCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxGRNNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxOtherCharges = new System.Windows.Forms.TextBox();
            this.textBoxTaxName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTaxAmt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxGAmt = new System.Windows.Forms.TextBox();
            this.textBoxSuppName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonTaxMaster = new System.Windows.Forms.Button();
            this.buttonSupplierMast = new System.Windows.Forms.Button();
            this.buttonItMast = new System.Windows.Forms.Button();
            this.gRNHdrDataGridView = new System.Windows.Forms.DataGridView();
            this.GRNNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SuppCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvDt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtherCharges = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gRNHdrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hMSDataSet = new HMS.HMSDataSet();
            this.gRNLinBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gRNLinTableAdapter = new HMS.HMSDataSetTableAdapters.GRNLinTableAdapter();
            this.gRNHdrTableAdapter = new HMS.HMSDataSetTableAdapters.GRNHdrTableAdapter();
            this.tableAdapterManager = new HMS.HMSDataSetTableAdapters.TableAdapterManager();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewGRN = new System.Windows.Forms.DataGridView();
            this.ItCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ItUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gRNHdrDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRNHdrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRNLinBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGRN)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bill Date";
            // 
            // dateTimePickerBillDate
            // 
            this.dateTimePickerBillDate.Location = new System.Drawing.Point(79, 98);
            this.dateTimePickerBillDate.Name = "dateTimePickerBillDate";
            this.dateTimePickerBillDate.Size = new System.Drawing.Size(235, 20);
            this.dateTimePickerBillDate.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bill No";
            // 
            // textBoxBillNo
            // 
            this.textBoxBillNo.Location = new System.Drawing.Point(78, 71);
            this.textBoxBillNo.Name = "textBoxBillNo";
            this.textBoxBillNo.Size = new System.Drawing.Size(235, 20);
            this.textBoxBillNo.TabIndex = 6;
            // 
            // textBoxSuppCode
            // 
            this.textBoxSuppCode.Location = new System.Drawing.Point(78, 45);
            this.textBoxSuppCode.Name = "textBoxSuppCode";
            this.textBoxSuppCode.ReadOnly = true;
            this.textBoxSuppCode.Size = new System.Drawing.Size(46, 20);
            this.textBoxSuppCode.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Supplier";
            // 
            // textBoxGRNNo
            // 
            this.textBoxGRNNo.Location = new System.Drawing.Point(78, 19);
            this.textBoxGRNNo.Name = "textBoxGRNNo";
            this.textBoxGRNNo.ReadOnly = true;
            this.textBoxGRNNo.Size = new System.Drawing.Size(235, 20);
            this.textBoxGRNNo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "GRN No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(507, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Net Amount";
            // 
            // textBoxNAmount
            // 
            this.textBoxNAmount.Location = new System.Drawing.Point(576, 255);
            this.textBoxNAmount.Name = "textBoxNAmount";
            this.textBoxNAmount.ReadOnly = true;
            this.textBoxNAmount.Size = new System.Drawing.Size(158, 20);
            this.textBoxNAmount.TabIndex = 15;
            this.textBoxNAmount.Text = "0.00";
            this.textBoxNAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(495, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Other Charges";
            // 
            // textBoxOtherCharges
            // 
            this.textBoxOtherCharges.Location = new System.Drawing.Point(576, 229);
            this.textBoxOtherCharges.Name = "textBoxOtherCharges";
            this.textBoxOtherCharges.Size = new System.Drawing.Size(158, 20);
            this.textBoxOtherCharges.TabIndex = 13;
            this.textBoxOtherCharges.Text = "0.00";
            this.textBoxOtherCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxOtherCharges.TextChanged += new System.EventHandler(this.textBoxOtherCharges_TextChanged);
            // 
            // textBoxTaxName
            // 
            this.textBoxTaxName.Location = new System.Drawing.Point(412, 202);
            this.textBoxTaxName.Name = "textBoxTaxName";
            this.textBoxTaxName.Size = new System.Drawing.Size(158, 20);
            this.textBoxTaxName.TabIndex = 12;
            this.textBoxTaxName.TextChanged += new System.EventHandler(this.textBoxTaxName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tax";
            // 
            // textBoxTaxAmt
            // 
            this.textBoxTaxAmt.Location = new System.Drawing.Point(576, 203);
            this.textBoxTaxAmt.Name = "textBoxTaxAmt";
            this.textBoxTaxAmt.Size = new System.Drawing.Size(158, 20);
            this.textBoxTaxAmt.TabIndex = 10;
            this.textBoxTaxAmt.Text = "0.00";
            this.textBoxTaxAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxTaxAmt.TextChanged += new System.EventHandler(this.textBoxTaxAmt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(497, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gross Amount";
            // 
            // textBoxGAmt
            // 
            this.textBoxGAmt.Location = new System.Drawing.Point(576, 177);
            this.textBoxGAmt.Name = "textBoxGAmt";
            this.textBoxGAmt.ReadOnly = true;
            this.textBoxGAmt.Size = new System.Drawing.Size(158, 20);
            this.textBoxGAmt.TabIndex = 8;
            this.textBoxGAmt.Text = "0.00";
            this.textBoxGAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxGAmt.TextChanged += new System.EventHandler(this.textBoxGAmt_TextChanged);
            // 
            // textBoxSuppName
            // 
            this.textBoxSuppName.Location = new System.Drawing.Point(130, 45);
            this.textBoxSuppName.Name = "textBoxSuppName";
            this.textBoxSuppName.Size = new System.Drawing.Size(183, 20);
            this.textBoxSuppName.TabIndex = 12;
            this.textBoxSuppName.TextChanged += new System.EventHandler(this.textBoxSuppName_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonDel);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonTaxMaster);
            this.panel1.Controls.Add(this.buttonSupplierMast);
            this.panel1.Controls.Add(this.buttonItMast);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 57);
            this.panel1.TabIndex = 18;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(146, 21);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 16;
            this.buttonDel.Text = "Delete";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(25, 21);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 12;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonTaxMaster
            // 
            this.buttonTaxMaster.Location = new System.Drawing.Point(693, 21);
            this.buttonTaxMaster.Name = "buttonTaxMaster";
            this.buttonTaxMaster.Size = new System.Drawing.Size(100, 23);
            this.buttonTaxMaster.TabIndex = 15;
            this.buttonTaxMaster.Text = "Tax Master";
            this.buttonTaxMaster.UseVisualStyleBackColor = true;
            this.buttonTaxMaster.Click += new System.EventHandler(this.buttonTaxMaster_Click);
            // 
            // buttonSupplierMast
            // 
            this.buttonSupplierMast.Location = new System.Drawing.Point(560, 21);
            this.buttonSupplierMast.Name = "buttonSupplierMast";
            this.buttonSupplierMast.Size = new System.Drawing.Size(100, 23);
            this.buttonSupplierMast.TabIndex = 14;
            this.buttonSupplierMast.Text = "Supplier Master";
            this.buttonSupplierMast.UseVisualStyleBackColor = true;
            this.buttonSupplierMast.Click += new System.EventHandler(this.buttonSupplierMast_Click);
            // 
            // buttonItMast
            // 
            this.buttonItMast.Location = new System.Drawing.Point(428, 21);
            this.buttonItMast.Name = "buttonItMast";
            this.buttonItMast.Size = new System.Drawing.Size(100, 23);
            this.buttonItMast.TabIndex = 13;
            this.buttonItMast.Text = "Items Master";
            this.buttonItMast.UseVisualStyleBackColor = true;
            this.buttonItMast.Click += new System.EventHandler(this.buttonItMast_Click);
            // 
            // gRNHdrDataGridView
            // 
            this.gRNHdrDataGridView.AllowUserToAddRows = false;
            this.gRNHdrDataGridView.AllowUserToDeleteRows = false;
            this.gRNHdrDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gRNHdrDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GRNNo,
            this.SuppCode,
            this.InvNo,
            this.InvDt,
            this.GAmt,
            this.TaxName,
            this.TaxAmt,
            this.OtherCharges,
            this.NAmt});
            this.gRNHdrDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gRNHdrDataGridView.Location = new System.Drawing.Point(0, 372);
            this.gRNHdrDataGridView.Name = "gRNHdrDataGridView";
            this.gRNHdrDataGridView.ReadOnly = true;
            this.gRNHdrDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gRNHdrDataGridView.Size = new System.Drawing.Size(817, 263);
            this.gRNHdrDataGridView.TabIndex = 0;
            this.gRNHdrDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gRNHdrDataGridView_MouseDoubleClick);
            // 
            // GRNNo
            // 
            this.GRNNo.HeaderText = "GRNNo";
            this.GRNNo.Name = "GRNNo";
            this.GRNNo.ReadOnly = true;
            // 
            // SuppCode
            // 
            this.SuppCode.HeaderText = "SuppCode";
            this.SuppCode.Name = "SuppCode";
            this.SuppCode.ReadOnly = true;
            // 
            // InvNo
            // 
            this.InvNo.HeaderText = "InvNo";
            this.InvNo.Name = "InvNo";
            this.InvNo.ReadOnly = true;
            // 
            // InvDt
            // 
            this.InvDt.HeaderText = "InvDt";
            this.InvDt.Name = "InvDt";
            this.InvDt.ReadOnly = true;
            // 
            // GAmt
            // 
            this.GAmt.HeaderText = "GAmt";
            this.GAmt.Name = "GAmt";
            this.GAmt.ReadOnly = true;
            // 
            // TaxName
            // 
            this.TaxName.HeaderText = "TaxName";
            this.TaxName.Name = "TaxName";
            this.TaxName.ReadOnly = true;
            // 
            // TaxAmt
            // 
            this.TaxAmt.HeaderText = "TaxAmt";
            this.TaxAmt.Name = "TaxAmt";
            this.TaxAmt.ReadOnly = true;
            // 
            // OtherCharges
            // 
            this.OtherCharges.HeaderText = "OtherCharges";
            this.OtherCharges.Name = "OtherCharges";
            this.OtherCharges.ReadOnly = true;
            // 
            // NAmt
            // 
            this.NAmt.HeaderText = "NAmt";
            this.NAmt.Name = "NAmt";
            this.NAmt.ReadOnly = true;
            // 
            // gRNHdrBindingSource
            // 
            this.gRNHdrBindingSource.DataMember = "GRNHdr";
            this.gRNHdrBindingSource.DataSource = this.hMSDataSet;
            // 
            // hMSDataSet
            // 
            this.hMSDataSet.DataSetName = "HMSDataSet";
            this.hMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gRNLinBindingSource
            // 
            this.gRNLinBindingSource.DataMember = "GRNLin";
            this.gRNLinBindingSource.DataSource = this.hMSDataSet;
            // 
            // gRNLinTableAdapter
            // 
            this.gRNLinTableAdapter.ClearBeforeFill = true;
            // 
            // gRNHdrTableAdapter
            // 
            this.gRNHdrTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.GRNHdrTableAdapter = this.gRNHdrTableAdapter;
            this.tableAdapterManager.GRNLinTableAdapter = this.gRNLinTableAdapter;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewGRN);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(785, 281);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Materials";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewGRN
            // 
            this.dataGridViewGRN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGRN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItCode,
            this.ItName,
            this.ItUnit,
            this.ItQty,
            this.ItRate,
            this.ItAmt});
            this.dataGridViewGRN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewGRN.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewGRN.Name = "dataGridViewGRN";
            this.dataGridViewGRN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGRN.Size = new System.Drawing.Size(779, 275);
            this.dataGridViewGRN.TabIndex = 1;
            this.dataGridViewGRN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGRN_CellContentClick);
            this.dataGridViewGRN.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGRN_CellValueChanged);
            // 
            // ItCode
            // 
            this.ItCode.HeaderText = "ItCode";
            this.ItCode.Name = "ItCode";
            this.ItCode.ReadOnly = true;
            // 
            // ItName
            // 
            this.ItName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItName.HeaderText = "ItName";
            this.ItName.Name = "ItName";
            this.ItName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ItName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ItUnit
            // 
            this.ItUnit.HeaderText = "It Unit";
            this.ItUnit.Name = "ItUnit";
            this.ItUnit.ReadOnly = true;
            // 
            // ItQty
            // 
            this.ItQty.HeaderText = "ItQty";
            this.ItQty.Name = "ItQty";
            // 
            // ItRate
            // 
            this.ItRate.HeaderText = "ItRate";
            this.ItRate.Name = "ItRate";
            // 
            // ItAmt
            // 
            this.ItAmt.HeaderText = "ItAmt";
            this.ItAmt.Name = "ItAmt";
            this.ItAmt.ReadOnly = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.textBoxNAmount);
            this.tabPage1.Controls.Add(this.textBoxSuppName);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBoxOtherCharges);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBoxTaxName);
            this.tabPage1.Controls.Add(this.textBoxGRNNo);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.dateTimePickerBillDate);
            this.tabPage1.Controls.Add(this.textBoxTaxAmt);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBoxGAmt);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBoxSuppCode);
            this.tabPage1.Controls.Add(this.textBoxBillNo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(785, 281);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 63);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(793, 307);
            this.tabControl1.TabIndex = 17;
            // 
            // StkRecdFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(817, 635);
            this.Controls.Add(this.gRNHdrDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StkRecdFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Goods Receive Note";
            this.Load += new System.EventHandler(this.StkRecdFrm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gRNHdrDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRNHdrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRNLinBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGRN)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxGRNNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSuppCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerBillDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBillNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxGAmt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxOtherCharges;
        private System.Windows.Forms.TextBox textBoxTaxName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTaxAmt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxNAmount;
        private HMSDataSet hMSDataSet;
        private System.Windows.Forms.BindingSource gRNLinBindingSource;
        private HMSDataSetTableAdapters.GRNLinTableAdapter gRNLinTableAdapter;
        private System.Windows.Forms.TextBox textBoxSuppName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonTaxMaster;
        private System.Windows.Forms.Button buttonSupplierMast;
        private System.Windows.Forms.Button buttonItMast;
        private System.Windows.Forms.BindingSource gRNHdrBindingSource;
        private HMSDataSetTableAdapters.GRNHdrTableAdapter gRNHdrTableAdapter;
        private HMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView gRNHdrDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewGRN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItCode;
        private System.Windows.Forms.DataGridViewComboBoxColumn ItName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItAmt;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRNNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SuppCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvDt;
        private System.Windows.Forms.DataGridViewTextBoxColumn GAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn OtherCharges;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAmt;
        private System.Windows.Forms.Button buttonDel;
    }
}