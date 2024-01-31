namespace HMS.Reports
{
    partial class AdmissionPrntFrm
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
            this.AdmissionNotextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Printbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AdmissionNotextBox
            // 
            this.AdmissionNotextBox.Location = new System.Drawing.Point(138, 31);
            this.AdmissionNotextBox.Name = "AdmissionNotextBox";
            this.AdmissionNotextBox.Size = new System.Drawing.Size(100, 20);
            this.AdmissionNotextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Admission Number";
            // 
            // Printbutton
            // 
            this.Printbutton.Location = new System.Drawing.Point(138, 70);
            this.Printbutton.Name = "Printbutton";
            this.Printbutton.Size = new System.Drawing.Size(75, 23);
            this.Printbutton.TabIndex = 2;
            this.Printbutton.Text = "Print";
            this.Printbutton.UseVisualStyleBackColor = true;
            // 
            // AdmissionPrntFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 163);
            this.Controls.Add(this.Printbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdmissionNotextBox);
            this.Name = "AdmissionPrntFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admission Print";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AdmissionNotextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Printbutton;
    }
}