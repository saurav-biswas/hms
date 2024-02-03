namespace HMS.Forms
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.masterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bedMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bedTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bloodGroupMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taxMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iPDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bedManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dischargeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodsReceivedNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disposableIssueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancePaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.differenceAmountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iPDRegisterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hMSDataSet = new HMS.HMSDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelFrmName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.billingToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(253, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // masterToolStripMenuItem
            // 
            this.masterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorMasterToolStripMenuItem,
            this.patientMasterToolStripMenuItem,
            this.bedMasterToolStripMenuItem,
            this.bloodGroupMasterToolStripMenuItem,
            this.taxMasterToolStripMenuItem,
            this.itemsToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.masterToolStripMenuItem.Name = "masterToolStripMenuItem";
            this.masterToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.masterToolStripMenuItem.Text = "Master";
            // 
            // doctorMasterToolStripMenuItem
            // 
            this.doctorMasterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departmentToolStripMenuItem,
            this.doctorsToolStripMenuItem});
            this.doctorMasterToolStripMenuItem.Name = "doctorMasterToolStripMenuItem";
            this.doctorMasterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.doctorMasterToolStripMenuItem.Text = "Doctor Master";
            // 
            // departmentToolStripMenuItem
            // 
            this.departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            this.departmentToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.departmentToolStripMenuItem.Text = "Department";
            this.departmentToolStripMenuItem.Visible = false;
            this.departmentToolStripMenuItem.Click += new System.EventHandler(this.departmentToolStripMenuItem_Click);
            // 
            // doctorsToolStripMenuItem
            // 
            this.doctorsToolStripMenuItem.Name = "doctorsToolStripMenuItem";
            this.doctorsToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.doctorsToolStripMenuItem.Text = "Doctors";
            this.doctorsToolStripMenuItem.Click += new System.EventHandler(this.doctorsToolStripMenuItem_Click);
            // 
            // patientMasterToolStripMenuItem
            // 
            this.patientMasterToolStripMenuItem.Name = "patientMasterToolStripMenuItem";
            this.patientMasterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.patientMasterToolStripMenuItem.Text = "Patient Master";
            this.patientMasterToolStripMenuItem.Click += new System.EventHandler(this.patientMasterToolStripMenuItem_Click);
            // 
            // bedMasterToolStripMenuItem
            // 
            this.bedMasterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bedTypeToolStripMenuItem,
            this.beNumberToolStripMenuItem});
            this.bedMasterToolStripMenuItem.Name = "bedMasterToolStripMenuItem";
            this.bedMasterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bedMasterToolStripMenuItem.Text = "Bed Master";
            // 
            // bedTypeToolStripMenuItem
            // 
            this.bedTypeToolStripMenuItem.Name = "bedTypeToolStripMenuItem";
            this.bedTypeToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.bedTypeToolStripMenuItem.Text = "Bed Type";
            this.bedTypeToolStripMenuItem.Click += new System.EventHandler(this.bedTypeToolStripMenuItem_Click);
            // 
            // beNumberToolStripMenuItem
            // 
            this.beNumberToolStripMenuItem.Name = "beNumberToolStripMenuItem";
            this.beNumberToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.beNumberToolStripMenuItem.Text = "Bed Number";
            this.beNumberToolStripMenuItem.Click += new System.EventHandler(this.beNumberToolStripMenuItem_Click);
            // 
            // bloodGroupMasterToolStripMenuItem
            // 
            this.bloodGroupMasterToolStripMenuItem.Name = "bloodGroupMasterToolStripMenuItem";
            this.bloodGroupMasterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bloodGroupMasterToolStripMenuItem.Text = "Blood Group Master";
            this.bloodGroupMasterToolStripMenuItem.Click += new System.EventHandler(this.bloodGroupMasterToolStripMenuItem_Click);
            // 
            // taxMasterToolStripMenuItem
            // 
            this.taxMasterToolStripMenuItem.Name = "taxMasterToolStripMenuItem";
            this.taxMasterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.taxMasterToolStripMenuItem.Text = "Tax Master";
            this.taxMasterToolStripMenuItem.Click += new System.EventHandler(this.taxMasterToolStripMenuItem_Click);
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.itemsToolStripMenuItem.Text = "Items";
            this.itemsToolStripMenuItem.Click += new System.EventHandler(this.itemsToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oPDToolStripMenuItem,
            this.iPDToolStripMenuItem,
            this.prescriptionToolStripMenuItem,
            this.bedManagementToolStripMenuItem,
            this.dischargeToolStripMenuItem,
            this.stockToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // oPDToolStripMenuItem
            // 
            this.oPDToolStripMenuItem.Name = "oPDToolStripMenuItem";
            this.oPDToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.oPDToolStripMenuItem.Text = "OPD";
            this.oPDToolStripMenuItem.Visible = false;
            this.oPDToolStripMenuItem.Click += new System.EventHandler(this.oPDToolStripMenuItem_Click);
            // 
            // iPDToolStripMenuItem
            // 
            this.iPDToolStripMenuItem.Name = "iPDToolStripMenuItem";
            this.iPDToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.iPDToolStripMenuItem.Text = "IPD";
            this.iPDToolStripMenuItem.Click += new System.EventHandler(this.iPDToolStripMenuItem_Click);
            // 
            // prescriptionToolStripMenuItem
            // 
            this.prescriptionToolStripMenuItem.Name = "prescriptionToolStripMenuItem";
            this.prescriptionToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.prescriptionToolStripMenuItem.Text = "Prescription";
            this.prescriptionToolStripMenuItem.Visible = false;
            this.prescriptionToolStripMenuItem.Click += new System.EventHandler(this.prescriptionToolStripMenuItem_Click);
            // 
            // bedManagementToolStripMenuItem
            // 
            this.bedManagementToolStripMenuItem.Name = "bedManagementToolStripMenuItem";
            this.bedManagementToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.bedManagementToolStripMenuItem.Text = "Bed Management";
            this.bedManagementToolStripMenuItem.Click += new System.EventHandler(this.bedManagementToolStripMenuItem_Click);
            // 
            // dischargeToolStripMenuItem
            // 
            this.dischargeToolStripMenuItem.Name = "dischargeToolStripMenuItem";
            this.dischargeToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.dischargeToolStripMenuItem.Text = "Discharge";
            this.dischargeToolStripMenuItem.Click += new System.EventHandler(this.dischargeToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goodsReceivedNoteToolStripMenuItem,
            this.disposableIssueToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // goodsReceivedNoteToolStripMenuItem
            // 
            this.goodsReceivedNoteToolStripMenuItem.Name = "goodsReceivedNoteToolStripMenuItem";
            this.goodsReceivedNoteToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.goodsReceivedNoteToolStripMenuItem.Text = "Goods Received Note";
            this.goodsReceivedNoteToolStripMenuItem.Click += new System.EventHandler(this.goodsReceivedNoteToolStripMenuItem_Click);
            // 
            // disposableIssueToolStripMenuItem
            // 
            this.disposableIssueToolStripMenuItem.Name = "disposableIssueToolStripMenuItem";
            this.disposableIssueToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.disposableIssueToolStripMenuItem.Text = "Disposable Issue";
            this.disposableIssueToolStripMenuItem.Click += new System.EventHandler(this.disposableIssueToolStripMenuItem_Click);
            // 
            // billingToolStripMenuItem
            // 
            this.billingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.advancePaymentToolStripMenuItem,
            this.finalBillToolStripMenuItem,
            this.differenceAmountToolStripMenuItem});
            this.billingToolStripMenuItem.Name = "billingToolStripMenuItem";
            this.billingToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.billingToolStripMenuItem.Text = "Billing";
            // 
            // advancePaymentToolStripMenuItem
            // 
            this.advancePaymentToolStripMenuItem.Name = "advancePaymentToolStripMenuItem";
            this.advancePaymentToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.advancePaymentToolStripMenuItem.Text = "Advance Payment";
            this.advancePaymentToolStripMenuItem.Click += new System.EventHandler(this.advancePaymentToolStripMenuItem_Click);
            // 
            // finalBillToolStripMenuItem
            // 
            this.finalBillToolStripMenuItem.Name = "finalBillToolStripMenuItem";
            this.finalBillToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.finalBillToolStripMenuItem.Text = "Final Bill";
            this.finalBillToolStripMenuItem.Click += new System.EventHandler(this.finalBillToolStripMenuItem_Click);
            // 
            // differenceAmountToolStripMenuItem
            // 
            this.differenceAmountToolStripMenuItem.Name = "differenceAmountToolStripMenuItem";
            this.differenceAmountToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.differenceAmountToolStripMenuItem.Text = "Difference Return";
            this.differenceAmountToolStripMenuItem.Visible = false;
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iPDRegisterToolStripMenuItem,
            this.stockReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // iPDRegisterToolStripMenuItem
            // 
            this.iPDRegisterToolStripMenuItem.Name = "iPDRegisterToolStripMenuItem";
            this.iPDRegisterToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.iPDRegisterToolStripMenuItem.Text = "IPD Register";
            this.iPDRegisterToolStripMenuItem.Click += new System.EventHandler(this.iPDRegisterToolStripMenuItem_Click);
            // 
            // stockReportToolStripMenuItem
            // 
            this.stockReportToolStripMenuItem.Name = "stockReportToolStripMenuItem";
            this.stockReportToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.stockReportToolStripMenuItem.Text = "Stock Report";
            this.stockReportToolStripMenuItem.Click += new System.EventHandler(this.stockReportToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::HMS.Properties.Resources.hms_logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(494, 564);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // hMSDataSet
            // 
            this.hMSDataSet.DataSetName = "HMSDataSet";
            this.hMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelFrmName);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 61);
            this.panel1.TabIndex = 2;
            // 
            // labelFrmName
            // 
            this.labelFrmName.AutoSize = true;
            this.labelFrmName.Location = new System.Drawing.Point(12, 11);
            this.labelFrmName.Name = "labelFrmName";
            this.labelFrmName.Size = new System.Drawing.Size(254, 13);
            this.labelFrmName.TabIndex = 0;
            this.labelFrmName.Text = "HMS | 02-02-2024 | Developed By Kolkata Websites";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.buttonExit);
            this.panel2.Location = new System.Drawing.Point(294, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 60);
            this.panel2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(105, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 41);
            this.button1.TabIndex = 1;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExit.Location = new System.Drawing.Point(147, 11);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(41, 40);
            this.buttonExit.TabIndex = 0;
            this.buttonExit.Text = "X";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 564);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrm";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HMS | 29-01-2024 | Developed By Kolkata Websites";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem masterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bloodGroupMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bedMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bedTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taxMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iPDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prescriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bedManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dischargeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancePaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finalBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem differenceAmountToolStripMenuItem;
        private HMSDataSet hMSDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodsReceivedNoteToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem iPDRegisterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disposableIssueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelFrmName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button button1;
    }
}