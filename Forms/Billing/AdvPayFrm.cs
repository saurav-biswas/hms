using HMS.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO.Ports;
using System.Reflection;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Configuration;
using HMS.Forms.Transaction.IPD;

namespace HMS.Forms.Billing
{
    public partial class AdvPayFrm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["HMS.Properties.Settings.HMSConnectionString"].ConnectionString;
        public AdvPayFrm()
        {
            InitializeComponent();
        }

        private void AdvPayFrm_Load(object sender, EventArgs e)
        { 
            // TODO: This line of code loads data into the 'hMSDataSet.IPD' table. You can move, or remove it, as needed.
           // this.iPDTableAdapter.Fill(this.hMSDataSet.IPD);
            // TODO: This line of code loads data into the 'hMSDataSet1.PatientMast' table. You can move, or remove it, as needed.
           // this.patientMastTableAdapter.Fill(this.hMSDataSet.PatientMast);
            // TODO: This line of code loads data into the 'hMSDataSet.Advance' table. You can move, or remove it, as needed.
          //  this.advanceTableAdapter.Fill(this.hMSDataSet.Advance);
            Display();
        }

        private void printbutton_Click(object sender, EventArgs e)
        {
            AdvancePayRep report = new AdvancePayRep();
            AdvcrystalReportViewer view = new AdvcrystalReportViewer();
            
            report.SetParameterValue("AP_ID", idTextBox.Text);
            report.SetParameterValue("AP_PatName", PatNametextBox.Text);
            report.SetParameterValue("AP_AdvAmt", advAmtTextBox.Text);
            report.SetParameterValue("AP_PayMode", payModeComboBox.Text);
            report.SetParameterValue("AP_Date", AdvpayDateDateTimePicker.Text);
            report.SetParameterValue("AP_IPD", textBoxIPD.Text);
            view.crystalReportViewer1.ReportSource = report;
           
            view.Show();
        }

        private void payModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void payDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        

        private void advAmtTextBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void Savebutton_Click(object sender, EventArgs e)
        {
            idTextBox.ReadOnly = false;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Check if the record exists
                SqlCommand checkCmd = new SqlCommand(@"SELECT COUNT(*) FROM Advance WHERE Id = @Id", con);
                checkCmd.Parameters.AddWithValue("@Id", idTextBox.Text);
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    // If the record exists, update it
                    SqlCommand updateCmd = new SqlCommand(@"UPDATE Advance SET PayDate = @PayDate, PatientID = @PatientID, Patient = @Patient, AdvAmt = @AdvAmt, PayMode = @PayMode, PatID = @PatID WHERE Id = @Id", con);
                    updateCmd.Parameters.AddWithValue("@Id", idTextBox.Text);
                    updateCmd.Parameters.AddWithValue("@PayDate", AdvpayDateDateTimePicker.Value.ToString("yyyy-MM-dd"));
                    updateCmd.Parameters.AddWithValue("@PatientID", PatientidTextBox.Text);
                    updateCmd.Parameters.AddWithValue("@Patient", PatNametextBox.Text);
                    updateCmd.Parameters.AddWithValue("@AdvAmt", advAmtTextBox.Text);
                    updateCmd.Parameters.AddWithValue("@PayMode", payModeComboBox.Text);
                    updateCmd.Parameters.AddWithValue("@PatID", textBoxIPD.Text);
                    updateCmd.ExecuteNonQuery();
                }
                else
                {
                    // If the record doesn't exist, insert it
                    SqlCommand insertCmd = new SqlCommand(@"INSERT INTO Advance (Id, PayDate, PatientID, Patient, AdvAmt, PayMode, PatID) VALUES (@Id, @PayDate, @PatientID, @Patient, @AdvAmt, @PayMode, @PatID)", con);
                    insertCmd.Parameters.AddWithValue("@Id", idTextBox.Text);
                    insertCmd.Parameters.AddWithValue("@PayDate", AdvpayDateDateTimePicker.Value.ToString("yyyy-MM-dd"));
                    insertCmd.Parameters.AddWithValue("@PatientID", PatientidTextBox.Text);
                    insertCmd.Parameters.AddWithValue("@Patient", PatNametextBox.Text);
                    insertCmd.Parameters.AddWithValue("@AdvAmt", advAmtTextBox.Text);
                    insertCmd.Parameters.AddWithValue("@PayMode", payModeComboBox.Text);
                    insertCmd.Parameters.AddWithValue("@PatID", textBoxIPD.Text);
                    insertCmd.ExecuteNonQuery();
                    
                    // Updating PatientMast
                    SqlCommand cmdUpdate = new SqlCommand(@"UPDATE PatientMast SET PatBalAmt = PatBalAmt + @AdvAmt WHERE Id = @PatientID", con);
                    cmdUpdate.Parameters.AddWithValue("@AdvAmt", advAmtTextBox.Text);
                    cmdUpdate.Parameters.AddWithValue("@PatientID", PatientidTextBox.Text);
                    cmdUpdate.ExecuteNonQuery();
                }
                
                

                con.Close();
                MessageBox.Show("Successfully Saved...!");
                Display();
            }
            idTextBox.Text = string.Empty;
            AdvpayDateDateTimePicker.Value = DateTime.Now; // Set the date to your default value
            textBoxIPD.Text = string.Empty;
            advAmtTextBox.Text = string.Empty;
            payModeComboBox.SelectedIndex = -1; // Assuming you want to clear the selection
            PatientidTextBox.Text = string.Empty;
            PatNametextBox.Text = string.Empty;

        }


        void Display()
        {
            try
            {
                // Clear existing rows in the DataGridView
                advanceDataGridView.Rows.Clear();

                // Retrieve data from the Advance table
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Id, Patient, AdvAmt, PayMode, PayDate, PatID AS IPD, PatientID FROM Advance";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Add rows to the DataGridView
                        advanceDataGridView.Rows.Add(reader["Id"], reader["PayDate"], reader["PatientID"], reader["Patient"], reader["AdvAmt"], reader["PayMode"], reader["IPD"]);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

    



    private void advanceDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            idTextBox.ReadOnly = true;
            idTextBox.Text =                advanceDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            AdvpayDateDateTimePicker.Text = advanceDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            PatientidTextBox.Text =         advanceDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            PatNametextBox.Text =           advanceDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            advAmtTextBox.Text =            advanceDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            payModeComboBox.Text =          advanceDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            textBoxIPD.Text =               advanceDataGridView.SelectedRows[0].Cells[6].Value.ToString();

          
        }

        

        private void advanceDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxIPD_TextChanged(object sender, EventArgs e)
        {
            
             string searchText = textBoxIPD.Text;

            using (SqlConnection con = new SqlConnection(connectionString))
    
            {
                string query = @"SELECT IPD.Id, IPD.Patient, IPD.PatID
                         FROM IPD
                         WHERE IPD.Id = @searchText";

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@searchText", searchText);

                        try
                        {
                            con.Open();

                            SqlDataReader reader = command.ExecuteReader();

                            if (reader.Read())
                            {
                                PatientidTextBox.Text = reader["PatId"].ToString();
                                PatNametextBox.Text = reader["Patient"].ToString();

                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
            }
             
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonIPD_Click(object sender, EventArgs e)
        {
            IPDFrm myForm = new IPDFrm();

            myForm.ShowDialog();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            // Ensure that the user has selected a row in the IPDdataGridView
            if (advanceDataGridView.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = advanceDataGridView.SelectedRows[0];

                // Retrieve the value from the "IPD" column and set it to idToDelete
                string idToDelete = selectedRow.Cells["Id"].Value.ToString();

                // Prompt the user to confirm the deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Perform deletion
                    DeleteRecord(idToDelete);
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            idTextBox.Text = string.Empty;
            AdvpayDateDateTimePicker.Value = DateTime.Now; // Set the date to your default value
            textBoxIPD.Text = string.Empty;
            advAmtTextBox.Text = string.Empty;
            payModeComboBox.SelectedIndex = -1; // Assuming you want to clear the selection
            PatientidTextBox.Text = string.Empty;
            PatNametextBox.Text = string.Empty;
        }

        private void DeleteRecord(string idToDelete)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {

                        // Then delete from IPD table
                        using (SqlCommand cmdDischarge = new SqlCommand("DELETE FROM Advance WHERE Id = @Id", con, transaction))
                        {
                            cmdDischarge.Parameters.AddWithValue("@Id", idToDelete);
                            cmdDischarge.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Record deleted successfully!");
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error while deleting record: " + ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }

            // Refresh the displayed data after deletion
            Display();

        }
    }
}
