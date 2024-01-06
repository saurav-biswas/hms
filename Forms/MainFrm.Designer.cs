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
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iPDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bedManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dischargeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancePaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.differenceAmountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hMSDataSet = new HMS.HMSDataSet();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodsReceivedNoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.billingToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
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
            this.itemsToolStripMenuItem});
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
            this.oPDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.oPDToolStripMenuItem.Text = "OPD";
            this.oPDToolStripMenuItem.Visible = false;
            this.oPDToolStripMenuItem.Click += new System.EventHandler(this.oPDToolStripMenuItem_Click);
            // 
            // iPDToolStripMenuItem
            // 
            this.iPDToolStripMenuItem.Name = "iPDToolStripMenuItem";
            this.iPDToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.iPDToolStripMenuItem.Text = "IPD";
            this.iPDToolStripMenuItem.Click += new System.EventHandler(this.iPDToolStripMenuItem_Click);
            // 
            // prescriptionToolStripMenuItem
            // 
            this.prescriptionToolStripMenuItem.Name = "prescriptionToolStripMenuItem";
            this.prescriptionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prescriptionToolStripMenuItem.Text = "Prescription";
            this.prescriptionToolStripMenuItem.Visible = false;
            this.prescriptionToolStripMenuItem.Click += new System.EventHandler(this.prescriptionToolStripMenuItem_Click);
            // 
            // bedManagementToolStripMenuItem
            // 
            this.bedManagementToolStripMenuItem.Name = "bedManagementToolStripMenuItem";
            this.bedManagementToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bedManagementToolStripMenuItem.Text = "Bed Management";
            this.bedManagementToolStripMenuItem.Click += new System.EventHandler(this.bedManagementToolStripMenuItem_Click);
            // 
            // dischargeToolStripMenuItem
            // 
            this.dischargeToolStripMenuItem.Name = "dischargeToolStripMenuItem";
            this.dischargeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dischargeToolStripMenuItem.Text = "Discharge";
            this.dischargeToolStripMenuItem.Click += new System.EventHandler(this.dischargeToolStripMenuItem_Click);
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
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // hMSDataSet
            // 
            this.hMSDataSet.DataSetName = "HMSDataSet";
            this.hMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goodsReceivedNoteToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // goodsReceivedNoteToolStripMenuItem
            // 
            this.goodsReceivedNoteToolStripMenuItem.Name = "goodsReceivedNoteToolStripMenuItem";
            this.goodsReceivedNoteToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.goodsReceivedNoteToolStripMenuItem.Text = "Goods Received Note";
            this.goodsReceivedNoteToolStripMenuItem.Click += new System.EventHandler(this.goodsReceivedNoteToolStripMenuItem_Click);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 501);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}