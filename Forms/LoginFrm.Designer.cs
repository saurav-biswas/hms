namespace HMS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IDtextBox = new System.Windows.Forms.TextBox();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.Okbutton = new System.Windows.Forms.Button();
            this.Cancelbutton = new System.Windows.Forms.Button();
            this.hMSDataSet = new HMS.HMSDataSet();
            this.hMSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorDepartmentMastBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorDepartmentMastTableAdapter = new HMS.HMSDataSetTableAdapters.DoctorDepartmentMastTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDepartmentMastBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // IDtextBox
            // 
            this.IDtextBox.Location = new System.Drawing.Point(103, 20);
            this.IDtextBox.Name = "IDtextBox";
            this.IDtextBox.Size = new System.Drawing.Size(172, 20);
            this.IDtextBox.TabIndex = 0;
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Location = new System.Drawing.Point(103, 49);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.PasswordChar = '*';
            this.PasswordtextBox.Size = new System.Drawing.Size(172, 20);
            this.PasswordtextBox.TabIndex = 1;
            // 
            // Okbutton
            // 
            this.Okbutton.Location = new System.Drawing.Point(103, 87);
            this.Okbutton.Name = "Okbutton";
            this.Okbutton.Size = new System.Drawing.Size(75, 23);
            this.Okbutton.TabIndex = 2;
            this.Okbutton.Text = "Ok";
            this.Okbutton.UseVisualStyleBackColor = true;
            this.Okbutton.Click += new System.EventHandler(this.Okbutton_Click);
            // 
            // Cancelbutton
            // 
            this.Cancelbutton.Location = new System.Drawing.Point(200, 87);
            this.Cancelbutton.Name = "Cancelbutton";
            this.Cancelbutton.Size = new System.Drawing.Size(75, 23);
            this.Cancelbutton.TabIndex = 3;
            this.Cancelbutton.Text = "Cancel";
            this.Cancelbutton.UseVisualStyleBackColor = true;
            this.Cancelbutton.Click += new System.EventHandler(this.Cancelbutton_Click);
            // 
            // hMSDataSet
            // 
            this.hMSDataSet.DataSetName = "HMSDataSet";
            this.hMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hMSDataSetBindingSource
            // 
            this.hMSDataSetBindingSource.DataSource = this.hMSDataSet;
            this.hMSDataSetBindingSource.Position = 0;
            // 
            // doctorDepartmentMastBindingSource
            // 
            this.doctorDepartmentMastBindingSource.DataMember = "DoctorDepartmentMast";
            this.doctorDepartmentMastBindingSource.DataSource = this.hMSDataSetBindingSource;
            // 
            // doctorDepartmentMastTableAdapter
            // 
            this.doctorDepartmentMastTableAdapter.ClearBeforeFill = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 131);
            this.ControlBox = false;
            this.Controls.Add(this.Cancelbutton);
            this.Controls.Add(this.Okbutton);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.IDtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hMSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDepartmentMastBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IDtextBox;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Button Okbutton;
        private System.Windows.Forms.Button Cancelbutton;
        private System.Windows.Forms.BindingSource hMSDataSetBindingSource;
        private HMSDataSet hMSDataSet;
        private System.Windows.Forms.BindingSource doctorDepartmentMastBindingSource;
        private HMSDataSetTableAdapters.DoctorDepartmentMastTableAdapter doctorDepartmentMastTableAdapter;
    }
}

