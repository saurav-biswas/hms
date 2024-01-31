namespace HMS.Forms.Transaction
{
    partial class DisposableIssFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisposableIssFrm));
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIPD = new System.Windows.Forms.TextBox();
            this.textBoxPatName = new System.Windows.Forms.TextBox();
            this.textBoxBedNo = new System.Windows.Forms.TextBox();
            this.dateTimePickerIssueDt = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewDisposableList = new System.Windows.Forms.DataGridView();
            this.DisNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IPD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonDel = new System.Windows.Forms.Button();
            this.textBoxDoctor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxDisNo = new System.Windows.Forms.TextBox();
            this.hMSDataSet = new HMS.HMSDataSet();
            this.itMastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itMastTableAdapter = new HMS.HMSDataSetTableAdapters.ItMastTableAdapter();
            this.ItCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisposableList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itMastBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(25, 12);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IPD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bed No";
            // 
            // textBoxIPD
            // 
            this.textBoxIPD.Location = new System.Drawing.Point(84, 85);
            this.textBoxIPD.Name = "textBoxIPD";
            this.textBoxIPD.Size = new System.Drawing.Size(214, 20);
            this.textBoxIPD.TabIndex = 6;
            this.textBoxIPD.TextChanged += new System.EventHandler(this.textBoxIPD_TextChanged);
            // 
            // textBoxPatName
            // 
            this.textBoxPatName.Location = new System.Drawing.Point(84, 152);
            this.textBoxPatName.Name = "textBoxPatName";
            this.textBoxPatName.ReadOnly = true;
            this.textBoxPatName.Size = new System.Drawing.Size(214, 20);
            this.textBoxPatName.TabIndex = 7;
            // 
            // textBoxBedNo
            // 
            this.textBoxBedNo.Location = new System.Drawing.Point(84, 185);
            this.textBoxBedNo.Name = "textBoxBedNo";
            this.textBoxBedNo.ReadOnly = true;
            this.textBoxBedNo.Size = new System.Drawing.Size(214, 20);
            this.textBoxBedNo.TabIndex = 8;
            // 
            // dateTimePickerIssueDt
            // 
            this.dateTimePickerIssueDt.Location = new System.Drawing.Point(84, 117);
            this.dateTimePickerIssueDt.Name = "dateTimePickerIssueDt";
            this.dateTimePickerIssueDt.Size = new System.Drawing.Size(214, 20);
            this.dateTimePickerIssueDt.TabIndex = 9;
            this.dateTimePickerIssueDt.ValueChanged += new System.EventHandler(this.dateTimePickerIssueDt_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewDisposableList);
            this.panel1.Controls.Add(this.dataGridViewItems);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 637);
            this.panel1.TabIndex = 11;
            // 
            // dataGridViewDisposableList
            // 
            this.dataGridViewDisposableList.AllowUserToAddRows = false;
            this.dataGridViewDisposableList.AllowUserToDeleteRows = false;
            this.dataGridViewDisposableList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDisposableList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DisNo,
            this.IPD,
            this.Date,
            this.Patient,
            this.Amount});
            this.dataGridViewDisposableList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewDisposableList.Location = new System.Drawing.Point(0, 298);
            this.dataGridViewDisposableList.Name = "dataGridViewDisposableList";
            this.dataGridViewDisposableList.ReadOnly = true;
            this.dataGridViewDisposableList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDisposableList.Size = new System.Drawing.Size(937, 339);
            this.dataGridViewDisposableList.TabIndex = 12;
            this.dataGridViewDisposableList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewDisposableList_MouseDoubleClick);
            // 
            // DisNo
            // 
            this.DisNo.HeaderText = "DisNo";
            this.DisNo.Name = "DisNo";
            this.DisNo.ReadOnly = true;
            // 
            // IPD
            // 
            this.IPD.HeaderText = "IPD";
            this.IPD.Name = "IPD";
            this.IPD.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // Patient
            // 
            this.Patient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Patient.HeaderText = "Patient";
            this.Patient.Name = "Patient";
            this.Patient.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItCode,
            this.ItName,
            this.ItUnit,
            this.ItQty,
            this.ItRate,
            this.ItAmt});
            this.dataGridViewItems.Location = new System.Drawing.Point(304, 0);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.Size = new System.Drawing.Size(633, 292);
            this.dataGridViewItems.TabIndex = 10;
            this.dataGridViewItems.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewItems_CellValueChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonDel);
            this.panel2.Controls.Add(this.textBoxDoctor);
            this.panel2.Controls.Add(this.buttonSave);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBoxAmount);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.textBoxIPD);
            this.panel2.Controls.Add(this.textBoxPatName);
            this.panel2.Controls.Add(this.textBoxBedNo);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBoxDisNo);
            this.panel2.Controls.Add(this.dateTimePickerIssueDt);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 292);
            this.panel2.TabIndex = 17;
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(195, 12);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(75, 23);
            this.buttonDel.TabIndex = 17;
            this.buttonDel.Text = "Delete";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // textBoxDoctor
            // 
            this.textBoxDoctor.Location = new System.Drawing.Point(84, 220);
            this.textBoxDoctor.Name = "textBoxDoctor";
            this.textBoxDoctor.ReadOnly = true;
            this.textBoxDoctor.Size = new System.Drawing.Size(214, 20);
            this.textBoxDoctor.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Doctor";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Location = new System.Drawing.Point(84, 257);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.ReadOnly = true;
            this.textBoxAmount.Size = new System.Drawing.Size(214, 20);
            this.textBoxAmount.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Dis. No.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Amount";
            // 
            // textBoxDisNo
            // 
            this.textBoxDisNo.Location = new System.Drawing.Point(84, 48);
            this.textBoxDisNo.Name = "textBoxDisNo";
            this.textBoxDisNo.ReadOnly = true;
            this.textBoxDisNo.Size = new System.Drawing.Size(214, 20);
            this.textBoxDisNo.TabIndex = 14;
            // 
            // hMSDataSet
            // 
            this.hMSDataSet.DataSetName = "HMSDataSet";
            this.hMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itMastBindingSource
            // 
            this.itMastBindingSource.DataMember = "ItMast";
            this.itMastBindingSource.DataSource = this.hMSDataSet;
            // 
            // itMastTableAdapter
            // 
            this.itMastTableAdapter.ClearBeforeFill = true;
            // 
            // ItCode
            // 
            this.ItCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ItCode.HeaderText = "Item Code";
            this.ItCode.Name = "ItCode";
            this.ItCode.Width = 80;
            // 
            // ItName
            // 
            this.ItName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItName.HeaderText = "Items";
            this.ItName.Name = "ItName";
            this.ItName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // ItUnit
            // 
            this.ItUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ItUnit.HeaderText = "Unit";
            this.ItUnit.Name = "ItUnit";
            this.ItUnit.Width = 51;
            // 
            // ItQty
            // 
            this.ItQty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ItQty.HeaderText = "Quantity";
            this.ItQty.Name = "ItQty";
            this.ItQty.Width = 71;
            // 
            // ItRate
            // 
            this.ItRate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ItRate.HeaderText = "Rate";
            this.ItRate.Name = "ItRate";
            this.ItRate.ReadOnly = true;
            this.ItRate.Width = 55;
            // 
            // ItAmt
            // 
            this.ItAmt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ItAmt.HeaderText = "Amount";
            this.ItAmt.Name = "ItAmt";
            this.ItAmt.ReadOnly = true;
            this.ItAmt.Width = 68;
            // 
            // DisposableIssFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 637);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DisposableIssFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Disposable Issue";
            this.Load += new System.EventHandler(this.DisposableIssFrm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDisposableList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itMastBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIPD;
        private System.Windows.Forms.TextBox textBoxPatName;
        private System.Windows.Forms.TextBox textBoxBedNo;
        private System.Windows.Forms.DateTimePicker dateTimePickerIssueDt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewDisposableList;
        private System.Windows.Forms.TextBox textBoxDoctor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxDisNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Label label7;
        private HMSDataSet hMSDataSet;
        private System.Windows.Forms.BindingSource itMastBindingSource;
        private HMSDataSetTableAdapters.ItMastTableAdapter itMastTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.DataGridView dataGridViewItems;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItAmt;
    }
}