namespace HMS.Forms.Transaction
{
    partial class GRNListFrm
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
            this.hMSDataSet = new HMS.HMSDataSet();
            this.gRNHdrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gRNHdrTableAdapter = new HMS.HMSDataSetTableAdapters.GRNHdrTableAdapter();
            this.tableAdapterManager = new HMS.HMSDataSetTableAdapters.TableAdapterManager();
            this.gRNHdrDataGridView = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRNHdrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRNHdrDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // hMSDataSet
            // 
            this.hMSDataSet.DataSetName = "HMSDataSet";
            this.hMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gRNHdrBindingSource
            // 
            this.gRNHdrBindingSource.DataMember = "GRNHdr";
            this.gRNHdrBindingSource.DataSource = this.hMSDataSet;
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
            this.tableAdapterManager.DischargeTableAdapter = null;
            this.tableAdapterManager.DoctorDepartmentMastTableAdapter = null;
            this.tableAdapterManager.DoctorMastTableAdapter = null;
            this.tableAdapterManager.FinalBillHdrTableAdapter = null;
            this.tableAdapterManager.FinalBillOtherAmountTableAdapter = null;
            this.tableAdapterManager.GRNHdrTableAdapter = this.gRNHdrTableAdapter;
            this.tableAdapterManager.GRNLinTableAdapter = null;
            this.tableAdapterManager.IPDTableAdapter = null;
            this.tableAdapterManager.ItCatMastTableAdapter = null;
            this.tableAdapterManager.ItMastTableAdapter = null;
            this.tableAdapterManager.OPDTableAdapter = null;
            this.tableAdapterManager.PatientMastTableAdapter = null;
            this.tableAdapterManager.PrescriptionTableAdapter = null;
            this.tableAdapterManager.PresMedTableAdapter = null;
            this.tableAdapterManager.TaxMastTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HMS.HMSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gRNHdrDataGridView
            // 
            this.gRNHdrDataGridView.AutoGenerateColumns = false;
            this.gRNHdrDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gRNHdrDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.gRNHdrDataGridView.DataSource = this.gRNHdrBindingSource;
            this.gRNHdrDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gRNHdrDataGridView.Location = new System.Drawing.Point(0, 0);
            this.gRNHdrDataGridView.Name = "gRNHdrDataGridView";
            this.gRNHdrDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gRNHdrDataGridView.Size = new System.Drawing.Size(800, 450);
            this.gRNHdrDataGridView.TabIndex = 1;
            this.gRNHdrDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gRNHdrDataGridView_MouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "GRNNo";
            this.dataGridViewTextBoxColumn2.HeaderText = "GRNNo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SuppCode";
            this.dataGridViewTextBoxColumn3.HeaderText = "SuppCode";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "InvNo";
            this.dataGridViewTextBoxColumn4.HeaderText = "InvNo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "InvDt";
            this.dataGridViewTextBoxColumn5.HeaderText = "InvDt";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "GAmt";
            this.dataGridViewTextBoxColumn6.HeaderText = "GAmt";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "TaxName";
            this.dataGridViewTextBoxColumn7.HeaderText = "TaxName";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TaxAmt";
            this.dataGridViewTextBoxColumn8.HeaderText = "TaxAmt";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "OtherCharges";
            this.dataGridViewTextBoxColumn9.HeaderText = "OtherCharges";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "NAmt";
            this.dataGridViewTextBoxColumn10.HeaderText = "NAmt";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // GRNListFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gRNHdrDataGridView);
            this.Name = "GRNListFrm";
            this.Text = "GRNListFrm";
            this.Load += new System.EventHandler(this.GRNListFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRNHdrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gRNHdrDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HMSDataSet hMSDataSet;
        private System.Windows.Forms.BindingSource gRNHdrBindingSource;
        private HMSDataSetTableAdapters.GRNHdrTableAdapter gRNHdrTableAdapter;
        private HMSDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView gRNHdrDataGridView;
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
    }
}