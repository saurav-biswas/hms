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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonTaxMaster = new System.Windows.Forms.Button();
            this.buttonSupplierMast = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerBillDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBillNo = new System.Windows.Forms.TextBox();
            this.textBoxSuppCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxGRNNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonItMast = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridViewGRN = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxOtherCharges = new System.Windows.Forms.TextBox();
            this.textBoxTaxName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTaxAmt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxGAmt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGRN)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonTaxMaster);
            this.panel1.Controls.Add(this.buttonSupplierMast);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dateTimePickerBillDate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxBillNo);
            this.panel1.Controls.Add(this.textBoxSuppCode);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxGRNNo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonItMast);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 110);
            this.panel1.TabIndex = 0;
            // 
            // buttonTaxMaster
            // 
            this.buttonTaxMaster.Location = new System.Drawing.Point(679, 64);
            this.buttonTaxMaster.Name = "buttonTaxMaster";
            this.buttonTaxMaster.Size = new System.Drawing.Size(100, 23);
            this.buttonTaxMaster.TabIndex = 11;
            this.buttonTaxMaster.Text = "Tax Master";
            this.buttonTaxMaster.UseVisualStyleBackColor = true;
            this.buttonTaxMaster.Click += new System.EventHandler(this.buttonTaxMaster_Click);
            // 
            // buttonSupplierMast
            // 
            this.buttonSupplierMast.Location = new System.Drawing.Point(679, 38);
            this.buttonSupplierMast.Name = "buttonSupplierMast";
            this.buttonSupplierMast.Size = new System.Drawing.Size(100, 23);
            this.buttonSupplierMast.TabIndex = 10;
            this.buttonSupplierMast.Text = "Supplier Master";
            this.buttonSupplierMast.UseVisualStyleBackColor = true;
            this.buttonSupplierMast.Click += new System.EventHandler(this.buttonSupplierMast_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bill Date";
            // 
            // dateTimePickerBillDate
            // 
            this.dateTimePickerBillDate.Location = new System.Drawing.Point(481, 66);
            this.dateTimePickerBillDate.Name = "dateTimePickerBillDate";
            this.dateTimePickerBillDate.Size = new System.Drawing.Size(158, 20);
            this.dateTimePickerBillDate.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(398, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bill No";
            // 
            // textBoxBillNo
            // 
            this.textBoxBillNo.Location = new System.Drawing.Point(481, 40);
            this.textBoxBillNo.Name = "textBoxBillNo";
            this.textBoxBillNo.Size = new System.Drawing.Size(158, 20);
            this.textBoxBillNo.TabIndex = 6;
            // 
            // textBoxSuppCode
            // 
            this.textBoxSuppCode.Location = new System.Drawing.Point(93, 71);
            this.textBoxSuppCode.Name = "textBoxSuppCode";
            this.textBoxSuppCode.Size = new System.Drawing.Size(158, 20);
            this.textBoxSuppCode.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Supplier";
            // 
            // textBoxGRNNo
            // 
            this.textBoxGRNNo.Location = new System.Drawing.Point(93, 45);
            this.textBoxGRNNo.Name = "textBoxGRNNo";
            this.textBoxGRNNo.Size = new System.Drawing.Size(158, 20);
            this.textBoxGRNNo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "GRN No";
            // 
            // buttonItMast
            // 
            this.buttonItMast.Location = new System.Drawing.Point(679, 12);
            this.buttonItMast.Name = "buttonItMast";
            this.buttonItMast.Size = new System.Drawing.Size(100, 23);
            this.buttonItMast.TabIndex = 1;
            this.buttonItMast.Text = "Items Master";
            this.buttonItMast.UseVisualStyleBackColor = true;
            this.buttonItMast.Click += new System.EventHandler(this.buttonItMast_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(81, 13);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // dataGridViewGRN
            // 
            this.dataGridViewGRN.AllowUserToAddRows = false;
            this.dataGridViewGRN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGRN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewGRN.Location = new System.Drawing.Point(0, 110);
            this.dataGridViewGRN.Name = "dataGridViewGRN";
            this.dataGridViewGRN.ReadOnly = true;
            this.dataGridViewGRN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGRN.Size = new System.Drawing.Size(800, 389);
            this.dataGridViewGRN.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBoxNAmount);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBoxOtherCharges);
            this.panel2.Controls.Add(this.textBoxTaxName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBoxTaxAmt);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBoxGAmt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 343);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 156);
            this.panel2.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(552, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Net Amount";
            // 
            // textBoxNAmount
            // 
            this.textBoxNAmount.Location = new System.Drawing.Point(621, 90);
            this.textBoxNAmount.Name = "textBoxNAmount";
            this.textBoxNAmount.Size = new System.Drawing.Size(158, 20);
            this.textBoxNAmount.TabIndex = 15;
            this.textBoxNAmount.Text = "0.00";
            this.textBoxNAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(540, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Other Charges";
            // 
            // textBoxOtherCharges
            // 
            this.textBoxOtherCharges.Location = new System.Drawing.Point(621, 64);
            this.textBoxOtherCharges.Name = "textBoxOtherCharges";
            this.textBoxOtherCharges.Size = new System.Drawing.Size(158, 20);
            this.textBoxOtherCharges.TabIndex = 13;
            this.textBoxOtherCharges.Text = "0.00";
            this.textBoxOtherCharges.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxOtherCharges.TextChanged += new System.EventHandler(this.textBoxOtherCharges_TextChanged);
            // 
            // textBoxTaxName
            // 
            this.textBoxTaxName.Location = new System.Drawing.Point(457, 37);
            this.textBoxTaxName.Name = "textBoxTaxName";
            this.textBoxTaxName.Size = new System.Drawing.Size(158, 20);
            this.textBoxTaxName.TabIndex = 12;
            this.textBoxTaxName.TextChanged += new System.EventHandler(this.textBoxTaxName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(419, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tax";
            // 
            // textBoxTaxAmt
            // 
            this.textBoxTaxAmt.Location = new System.Drawing.Point(621, 38);
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
            this.label5.Location = new System.Drawing.Point(542, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gross Amount";
            // 
            // textBoxGAmt
            // 
            this.textBoxGAmt.Location = new System.Drawing.Point(621, 12);
            this.textBoxGAmt.Name = "textBoxGAmt";
            this.textBoxGAmt.Size = new System.Drawing.Size(158, 20);
            this.textBoxGAmt.TabIndex = 8;
            this.textBoxGAmt.Text = "0.00";
            this.textBoxGAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxGAmt.TextChanged += new System.EventHandler(this.textBoxGAmt_TextChanged);
            // 
            // StkRecdFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewGRN);
            this.Controls.Add(this.panel1);
            this.Name = "StkRecdFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Goods Receive Note";
            this.Load += new System.EventHandler(this.StkRecdFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGRN)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonItMast;
        private System.Windows.Forms.DataGridView dataGridViewGRN;
        private System.Windows.Forms.TextBox textBoxGRNNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSuppCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerBillDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxBillNo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxGAmt;
        private System.Windows.Forms.Button buttonSupplierMast;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxOtherCharges;
        private System.Windows.Forms.TextBox textBoxTaxName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTaxAmt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxNAmount;
        private System.Windows.Forms.Button buttonTaxMaster;
    }
}