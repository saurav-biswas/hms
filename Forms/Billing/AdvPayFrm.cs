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

        /*
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

        }*/

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

                decimal previousAdvAmt = 0; // Variable to store the previous AdvAmt

                if (count > 0)
                {
                    // If the record exists, retrieve the previous AdvAmt
                    SqlCommand selectPrevCmd = new SqlCommand(@"SELECT AdvAmt FROM Advance WHERE Id = @Id", con);
                    selectPrevCmd.Parameters.AddWithValue("@Id", idTextBox.Text);
                    previousAdvAmt = Convert.ToDecimal(selectPrevCmd.ExecuteScalar());

                    // Update the existing record
                    SqlCommand updateCmd = new SqlCommand(@"UPDATE Advance SET PayDate = @PayDate, PatientID = @PatientID, Patient = @Patient, AdvAmt = @AdvAmt, PayMode = @PayMode, PatID = @PatID WHERE Id = @Id", con);
                    updateCmd.Parameters.AddWithValue("@Id", idTextBox.Text);
                    updateCmd.Parameters.AddWithValue("@PayDate", AdvpayDateDateTimePicker.Value.ToString("yyyy-MM-dd"));
                    updateCmd.Parameters.AddWithValue("@PatientID", PatientidTextBox.Text);
                    updateCmd.Parameters.AddWithValue("@Patient", PatNametextBox.Text);
                    updateCmd.Parameters.AddWithValue("@AdvAmt", advAmtTextBox.Text);
                    updateCmd.Parameters.AddWithValue("@PayMode", payModeComboBox.Text);
                    updateCmd.Parameters.AddWithValue("@PatID", textBoxIPD.Text);
                    updateCmd.ExecuteNonQuery();

                    // Retrieve the values needed for updating PatientMast table
                    //string ipd = textBoxIPD.Text;
                    string patientId = PatientidTextBox.Text;
                    // Convert the necessary values to the correct types
                    if (!string.IsNullOrEmpty(patientId))
                    {
                        // Update PatientMast table
                        UpdatePatientMast(patientId);
                        //MessageBox.Show("Changes saved successfully!");
                    }
                    else
                    {
                        // Handle the case where patientId is empty (e.g., show an error message)
                        MessageBox.Show("Invalid Patient ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



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


                    string patientId = PatientidTextBox.Text;
                    // Convert the necessary values to the correct types
                    if (!string.IsNullOrEmpty(patientId))
                    {
                        // Update PatientMast table
                        UpdatePatientMast(patientId);
                        //MessageBox.Show("Changes saved successfully!");
                    }
                    else
                    {
                        // Handle the case where patientId is empty (e.g., show an error message)
                        MessageBox.Show("Invalid Patient ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


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


        private void UpdatePatientMast(string patientId)
        {
            try
            {
                // Get the total advance amount for the given patientId
                decimal totalAdvAmt = GetTotalAdvanceAmount(patientId);

                Console.WriteLine($"Patient ID: {patientId}, Total Advance Amount: {totalAdvAmt}");

                // Update PatientMast table
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Assuming you have a SqlCommand named 'cmd'
                    using (SqlCommand cmd = new SqlCommand("UPDATE PatientMast SET PatBalAmt = @TotalAdvAmt WHERE Id = @PatientID", con))
                    {
                        cmd.Parameters.AddWithValue("@TotalAdvAmt", totalAdvAmt);
                        cmd.Parameters.AddWithValue("@PatientID", patientId);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions according to your application's requirements
                MessageBox.Show($"Error in UpdatePatientMast: {ex.Message}");
            }
        }


        // Method to get the total advance amount for a patient
        private decimal GetTotalAdvanceAmount(string patientId)
        {
            decimal totalAdvAmt = 0;

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Assuming you have a SqlCommand named 'cmd'
                    using (SqlCommand cmd = new SqlCommand("SELECT SUM(AdvAmt) FROM Advance WHERE PatientID = @PatientID", con))
                    {
                        cmd.Parameters.AddWithValue("@PatientID", patientId);

                        // ExecuteScalar is used to retrieve a single value from the database
                        object result = cmd.ExecuteScalar();

                        // Check if the result is not null and is a valid decimal value
                        if (result != null && decimal.TryParse(result.ToString(), out totalAdvAmt))
                        {
                            // The sum is obtained from the database
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions according to your application's requirements
                Console.WriteLine($"Error in GetTotalAdvanceAmount: {ex.Message}");
            }

            return totalAdvAmt;
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

                    // Get the value from "advanceDataGridView.IPD"
                    string ipd = selectedRow.Cells["IPD"].Value.ToString();
                    string patientId = selectedRow.Cells["PatientID"].Value.ToString();

                    // Update patient balance after deletion
                    UpdatePatientBalance(ipd, patientId);
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Clear other controls
            idTextBox.Text = string.Empty;
            AdvpayDateDateTimePicker.Value = DateTime.Now; // Set the date to your default value
            textBoxIPD.Text = string.Empty;
            advAmtTextBox.Text = string.Empty;
            payModeComboBox.SelectedIndex = -1; // Assuming you want to clear the selection
            PatientidTextBox.Text = string.Empty;
            PatNametextBox.Text = string.Empty;
        }



        private void UpdatePatientBalance(string ipd, string patientId)
        {
            // Assuming you have a method to retrieve the sum of Advance.AdvAmt
            decimal sumAdvanceAmt = GetSumAdvanceAmt(ipd);

            // Assuming you have a method to update PatientMast.PatBalAmt
            UpdatePatBalAmt(patientId, sumAdvanceAmt);
        }

        private decimal GetSumAdvanceAmt(string ipd)
        {
            decimal sumAdvanceAmt = 0;

            // Assuming you have a SqlConnection named 'sqlConnection'
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Assuming you have a SqlCommand named 'cmd'
                using (SqlCommand cmd = new SqlCommand("SELECT SUM(AdvAmt) FROM Advance WHERE PatID = @IPD", con))
                {
                    cmd.Parameters.AddWithValue("@IPD", ipd);

                    // ExecuteScalar is used to retrieve a single value from the database
                    object result = cmd.ExecuteScalar();

                    // Check if the result is not null and is a valid decimal value
                    if (result != null && decimal.TryParse(result.ToString(), out sumAdvanceAmt))
                    {
                        // The sum is obtained from the database
                    }
                }
            }

            return sumAdvanceAmt;
        }

        private void UpdatePatBalAmt(string patientId, decimal newBalance)
        {
            // Assuming you have a SqlConnection named 'sqlConnection'
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Assuming you have a SqlCommand named 'cmd'
                using (SqlCommand cmd = new SqlCommand("UPDATE PatientMast SET PatBalAmt = @NewBalance WHERE Id = @PatientID", con))
                {
                    cmd.Parameters.AddWithValue("@NewBalance", newBalance);
                    cmd.Parameters.AddWithValue("@PatientID", patientId);

                    // Execute the update query
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Check if the update was successful
                    if (rowsAffected > 0)
                    {
                        // Update successful
                    }
                    else
                    {
                        // Update failed, handle accordingly
                    }
                }
            }
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
                        // Get the value from "advanceDataGridView.IPD"
                        string ipdToDelete = advanceDataGridView.SelectedRows[0].Cells["IPD"].Value.ToString();

                        // Check if there are related records in "FinalBillHdr.IPD" column
                        if (HasRelatedRecords(ipdToDelete, "FinalBillHdr", "IPD", con, transaction))
                        {
                            MessageBox.Show("Cannot delete the record because it has related records in the FinalBillHdr table.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return; // Exit the method without performing deletion
                        }

                        // Delete from Advance table
                        using (SqlCommand cmdDelete = new SqlCommand("DELETE FROM Advance WHERE Id = @Id", con, transaction))
                        {
                            cmdDelete.Parameters.AddWithValue("@Id", idToDelete);
                            cmdDelete.ExecuteNonQuery();
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

        private bool HasRelatedRecords(string valueToDelete, string tableName, string columnName, SqlConnection con, SqlTransaction transaction)
        {
            string checkQuery = $"SELECT COUNT(*) FROM {tableName} WHERE {columnName} = @Value";

            using (SqlCommand checkCmd = new SqlCommand(checkQuery, con, transaction))
            {
                checkCmd.Parameters.AddWithValue("@Value", valueToDelete);

                int relatedRecordCount = (int)checkCmd.ExecuteScalar();

                return (relatedRecordCount > 0);
            }
        }

    }
}
