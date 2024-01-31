namespace HMS.Forms.Master
{
    partial class ItMastFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItMastFrm));
            this.buttonCatMast = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.textBoxOpeningStk = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxItAmt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxItUnit = new System.Windows.Forms.ComboBox();
            this.textBoxItRate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCurStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCatList = new System.Windows.Forms.ComboBox();
            this.itCatMastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hMSDataSet = new HMS.HMSDataSet();
            this.textBoxItName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxItCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewItMast = new System.Windows.Forms.DataGridView();
            this.itCatMastTableAdapter = new HMS.HMSDataSetTableAdapters.ItCatMastTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itCatMastBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItMast)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCatMast
            // 
            this.buttonCatMast.Location = new System.Drawing.Point(646, 22);
            this.buttonCatMast.Name = "buttonCatMast";
            this.buttonCatMast.Size = new System.Drawing.Size(108, 23);
            this.buttonCatMast.TabIndex = 6;
            this.buttonCatMast.Text = "Catogory Master";
            this.buttonCatMast.UseVisualStyleBackColor = true;
            this.buttonCatMast.Click += new System.EventHandler(this.buttonCatMast_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(114, 22);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonPrint);
            this.panel1.Controls.Add(this.textBoxOpeningStk);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBoxItAmt);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboBoxItUnit);
            this.panel1.Controls.Add(this.textBoxItRate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxCurStock);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxCatList);
            this.panel1.Controls.Add(this.textBoxItName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxItCode);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.buttonCatMast);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 199);
            this.panel1.TabIndex = 2;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(295, 22);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(75, 23);
            this.buttonPrint.TabIndex = 18;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // textBoxOpeningStk
            // 
            this.textBoxOpeningStk.Location = new System.Drawing.Point(580, 76);
            this.textBoxOpeningStk.Name = "textBoxOpeningStk";
            this.textBoxOpeningStk.Size = new System.Drawing.Size(100, 20);
            this.textBoxOpeningStk.TabIndex = 3;
            this.textBoxOpeningStk.Text = "0.00";
            this.textBoxOpeningStk.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxOpeningStk.TextChanged += new System.EventHandler(this.textBoxOpeningStk_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(502, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Opening Stock";
            // 
            // textBoxItAmt
            // 
            this.textBoxItAmt.Location = new System.Drawing.Point(580, 154);
            this.textBoxItAmt.Name = "textBoxItAmt";
            this.textBoxItAmt.ReadOnly = true;
            this.textBoxItAmt.Size = new System.Drawing.Size(100, 20);
            this.textBoxItAmt.TabIndex = 6;
            this.textBoxItAmt.Text = "0.00";
            this.textBoxItAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxItAmt.TextChanged += new System.EventHandler(this.textBoxItAmt_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(502, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Amount";
            // 
            // comboBoxItUnit
            // 
            this.comboBoxItUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxItUnit.FormattingEnabled = true;
            this.comboBoxItUnit.Items.AddRange(new object[] {
            "Pcs",
            "No",
            "Grm",
            "Kg",
            "Roll",
            "Ltr"});
            this.comboBoxItUnit.Location = new System.Drawing.Point(114, 159);
            this.comboBoxItUnit.Name = "comboBoxItUnit";
            this.comboBoxItUnit.Size = new System.Drawing.Size(100, 21);
            this.comboBoxItUnit.TabIndex = 2;
            // 
            // textBoxItRate
            // 
            this.textBoxItRate.Location = new System.Drawing.Point(580, 129);
            this.textBoxItRate.Name = "textBoxItRate";
            this.textBoxItRate.Size = new System.Drawing.Size(100, 20);
            this.textBoxItRate.TabIndex = 4;
            this.textBoxItRate.Text = "0.00";
            this.textBoxItRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxItRate.TextChanged += new System.EventHandler(this.textBoxItRate_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(502, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Rate";
            // 
            // textBoxCurStock
            // 
            this.textBoxCurStock.Location = new System.Drawing.Point(580, 102);
            this.textBoxCurStock.Name = "textBoxCurStock";
            this.textBoxCurStock.ReadOnly = true;
            this.textBoxCurStock.Size = new System.Drawing.Size(100, 20);
            this.textBoxCurStock.TabIndex = 4;
            this.textBoxCurStock.Text = "0.00";
            this.textBoxCurStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxCurStock.TextChanged += new System.EventHandler(this.textBoxCurStock_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(502, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Current Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Unit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Category";
            // 
            // comboBoxCatList
            // 
            this.comboBoxCatList.DataSource = this.itCatMastBindingSource;
            this.comboBoxCatList.DisplayMember = "CatName";
            this.comboBoxCatList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCatList.FormattingEnabled = true;
            this.comboBoxCatList.Location = new System.Drawing.Point(114, 129);
            this.comboBoxCatList.Name = "comboBoxCatList";
            this.comboBoxCatList.Size = new System.Drawing.Size(310, 21);
            this.comboBoxCatList.TabIndex = 1;
            this.comboBoxCatList.ValueMember = "CatName";
            // 
            // itCatMastBindingSource
            // 
            this.itCatMastBindingSource.DataMember = "ItCatMast";
            this.itCatMastBindingSource.DataSource = this.hMSDataSet;
            // 
            // hMSDataSet
            // 
            this.hMSDataSet.DataSetName = "HMSDataSet";
            this.hMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxItName
            // 
            this.textBoxItName.Location = new System.Drawing.Point(114, 102);
            this.textBoxItName.Name = "textBoxItName";
            this.textBoxItName.Size = new System.Drawing.Size(310, 20);
            this.textBoxItName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Item Name";
            // 
            // textBoxItCode
            // 
            this.textBoxItCode.Location = new System.Drawing.Point(114, 76);
            this.textBoxItCode.Name = "textBoxItCode";
            this.textBoxItCode.ReadOnly = true;
            this.textBoxItCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxItCode.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Item Code";
            // 
            // dataGridViewItMast
            // 
            this.dataGridViewItMast.AllowUserToAddRows = false;
            this.dataGridViewItMast.AllowUserToDeleteRows = false;
            this.dataGridViewItMast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItMast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewItMast.Location = new System.Drawing.Point(0, 199);
            this.dataGridViewItMast.Name = "dataGridViewItMast";
            this.dataGridViewItMast.ReadOnly = true;
            this.dataGridViewItMast.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItMast.Size = new System.Drawing.Size(800, 251);
            this.dataGridViewItMast.TabIndex = 3;
            this.dataGridViewItMast.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewItMast_MouseDoubleClick);
            // 
            // itCatMastTableAdapter
            // 
            this.itCatMastTableAdapter.ClearBeforeFill = true;
            // 
            // ItMastFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewItMast);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "ItMastFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item Master";
            this.Load += new System.EventHandler(this.ItMastFrm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItMastFrm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itCatMastBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItMast)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCatMast;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxItCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxItName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCatList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCurStock;
        private System.Windows.Forms.Label label5;
        private HMSDataSet hMSDataSet;
        private System.Windows.Forms.BindingSource itCatMastBindingSource;
        private System.Windows.Forms.ComboBox comboBoxItUnit;
        private System.Windows.Forms.TextBox textBoxItRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxItAmt;
        private System.Windows.Forms.Label label7;
        private HMSDataSetTableAdapters.ItCatMastTableAdapter itCatMastTableAdapter;
        private System.Windows.Forms.TextBox textBoxOpeningStk;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Button buttonPrint;
        public System.Windows.Forms.DataGridView dataGridViewItMast;
    }
}