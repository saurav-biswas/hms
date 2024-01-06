namespace HMS.Forms.Master
{
    partial class ItCatFrm
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
            this.textBoxCatID = new System.Windows.Forms.TextBox();
            this.textBoxCatName = new System.Windows.Forms.TextBox();
            this.labelCatName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelCatID = new System.Windows.Forms.Label();
            this.dataGridViewCatForm = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatForm)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCatID
            // 
            this.textBoxCatID.Location = new System.Drawing.Point(110, 64);
            this.textBoxCatID.Name = "textBoxCatID";
            this.textBoxCatID.ReadOnly = true;
            this.textBoxCatID.Size = new System.Drawing.Size(143, 20);
            this.textBoxCatID.TabIndex = 0;
            // 
            // textBoxCatName
            // 
            this.textBoxCatName.Location = new System.Drawing.Point(110, 90);
            this.textBoxCatName.Name = "textBoxCatName";
            this.textBoxCatName.Size = new System.Drawing.Size(338, 20);
            this.textBoxCatName.TabIndex = 1;
            // 
            // labelCatName
            // 
            this.labelCatName.AutoSize = true;
            this.labelCatName.Location = new System.Drawing.Point(25, 96);
            this.labelCatName.Name = "labelCatName";
            this.labelCatName.Size = new System.Drawing.Size(49, 13);
            this.labelCatName.TabIndex = 2;
            this.labelCatName.Text = "Catogery";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.labelCatID);
            this.panel1.Controls.Add(this.textBoxCatName);
            this.panel1.Controls.Add(this.labelCatName);
            this.panel1.Controls.Add(this.textBoxCatID);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 146);
            this.panel1.TabIndex = 3;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(134, 13);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelCatID
            // 
            this.labelCatID.AutoSize = true;
            this.labelCatID.Location = new System.Drawing.Point(25, 64);
            this.labelCatID.Name = "labelCatID";
            this.labelCatID.Size = new System.Drawing.Size(18, 13);
            this.labelCatID.TabIndex = 3;
            this.labelCatID.Text = "ID";
            // 
            // dataGridViewCatForm
            // 
            this.dataGridViewCatForm.AllowUserToAddRows = false;
            this.dataGridViewCatForm.AllowUserToDeleteRows = false;
            this.dataGridViewCatForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCatForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCatForm.Location = new System.Drawing.Point(0, 146);
            this.dataGridViewCatForm.Name = "dataGridViewCatForm";
            this.dataGridViewCatForm.ReadOnly = true;
            this.dataGridViewCatForm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCatForm.Size = new System.Drawing.Size(474, 186);
            this.dataGridViewCatForm.TabIndex = 4;
            this.dataGridViewCatForm.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewCatForm_MouseDoubleClick);
            // 
            // ItCatFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 332);
            this.Controls.Add(this.dataGridViewCatForm);
            this.Controls.Add(this.panel1);
            this.Name = "ItCatFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catogery Master";
            this.Load += new System.EventHandler(this.ItCatFrm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCatID;
        private System.Windows.Forms.TextBox textBoxCatName;
        private System.Windows.Forms.Label labelCatName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCatID;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridViewCatForm;
    }
}