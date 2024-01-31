using HMS.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.Shared;
using Xamarin.Forms;
using System.Configuration;
using HMS.Forms.Billing;
using HMS.Forms.Master;
using HMS.Forms.Transaction.IPD;

namespace HMS.Forms.Transaction
{
    public partial class DischargeFrm : Form

         
    {
        string connectionString = ConfigurationManager.ConnectionStrings["HMS.Properties.Settings.HMSConnectionString"].ConnectionString;
       
        public DischargeFrm()
        {
            InitializeComponent();
        }


        private void DischargeFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet.DoctorMast' table. You can move, or remove it, as needed.
            this.doctorMastTableAdapter.Fill(this.hMSDataSet.DoctorMast);

            // TODO: This line of code loads data into the 'hMSDataSet.IPD' table. You can move, or remove it, as needed.
            //this.iPDTableAdapter.Fill(this.hMSDataSet.IPD);
            // TODO: This line of code loads data into the 'hMSDataSet.DoctorMast' table. You can move, or remove it, as needed.
            //this.doctorMastTableAdapter.Fill(this.hMSDataSet.DoctorMast);
            // TODO: This line of code loads data into the 'hMSDataSet.PatientMast' table. You can move, or remove it, as needed.
            //this.patientMastTableAdapter.Fill(this.hMSDataSet.PatientMast);
            // TODO: This line of code loads data into the 'hMSDataSet.Discharge' table. You can move, or remove it, as needed.
            //this.dischargeTableAdapter.Fill(this.hMSDataSet.Discharge);
            Display();
            
            
            dischargeByComboBox.SelectedIndex = -1;
            DischargeDateDateTimePicker.Value = DateTime.Now; // Set to desired default date or leave as is
            IPDSearchtextBox.Text = "RNH/";
            AdmissiondateTimePicker.Value = DateTime.Now; // Set to desired default date or leave as is
            PatNametextBox.Text = string.Empty;
            diagnosisTextBox.Text = string.Empty;
            commentTextBox.Text = string.Empty;
            nextVisitNoTextBox.Text = string.Empty;
            nextVisitUnitComboBox.SelectedIndex = -1;
            AgetextBox.Text = string.Empty;
            GendertextBox.Text = string.Empty;
            Address1textBox.Text = string.Empty;
            Address2textBox.Text = string.Empty;
            CitytextBox.Text = string.Empty;
            PINtextBox.Text = string.Empty;
            

            // Clear any existing rows
            AdvicesdataGridView.Rows.Clear();


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT ISNULL(MAX(Id), 0) + 1 AS NextId FROM Discharge";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();

                        object result = command.ExecuteScalar();
                        int nextId = Convert.ToInt32(result);

                        // Display the next available ID in a TextBox or Label
                        idTextBox.Text = nextId.ToString();
                    }
                    catch (Exception ex)
                    {
                        // Handle exceptions
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        
       

        private void printbutton_Click(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load("Reports/DischargeSlipRpt.rpt"); // Load your Crystal Report

            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in AdvicesdataGridView.Columns)
            {
                dt.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in AdvicesdataGridView.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }

            report.Subreports[0].DataSourceConnections.Clear();
            report.Subreports[0].SetDataSource(dt);


            DischargeSlipRpt fbr = new DischargeSlipRpt();

            DischargeSlipViewer view = new DischargeSlipViewer();

            report.SetParameterValue("DIS_PatName", PatNametextBox.Text);
            report.SetParameterValue("DIS_Age", AgetextBox.Text);
            report.SetParameterValue("DIS_Gender", GendertextBox.Text);
            report.SetParameterValue("DIS_Address1", Address1textBox.Text);
            report.SetParameterValue("DIS_Address2", Address2textBox.Text);
            report.SetParameterValue("DIS_City", CitytextBox.Text);
            report.SetParameterValue("DIS_PIN", PINtextBox.Text);
            report.SetParameterValue("DIS_Diagnosis", diagnosisTextBox.Text);
            report.SetParameterValue("DIS_AdmissionDt", AdmissiondateTimePicker.Text);
            report.SetParameterValue("DIS_DischargeDt", DischargeDateDateTimePicker.Text);
            report.SetParameterValue("DIS_DrName", dischargeByComboBox.Text);

            view.crystalReportViewer1.ReportSource = report;
            view.Show();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlTransaction transaction = con.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand cmdHeader = new SqlCommand(@"IF EXISTS (SELECT 1 FROM Discharge WHERE Id = @Id)
                    BEGIN
                        UPDATE Discharge
                        SET IPD = @IPD, DischargeBy = @DischargeBy, DischargeDate = @DischargeDate, Diagnosis = @Diagnosis,
                            Comment = @Comment, NextVisitNo = @NextVisitNo, NextVisitUnit = @NextVisitUnit, Patient = @Patient
                        WHERE Id = @Id
                    END
                    ELSE
                    BEGIN
                        INSERT INTO Discharge (Patient, DischargeBy, Comment, NextVisitNo, NextVisitUnit, DischargeDate, IPD, Diagnosis, AdmissionDt)
                        VALUES (@Patient, @DischargeBy, @Comment, @NextVisitNo, @NextVisitUnit, @DischargeDate, @IPD, @Diagnosis, @AdmissionDt)
                    END", con, transaction))
                        {
                            cmdHeader.Parameters.AddWithValue("@Id", idTextBox.Text);
                            cmdHeader.Parameters.AddWithValue("@IPD", IPDSearchtextBox.Text);
                            cmdHeader.Parameters.AddWithValue("@DischargeBy", dischargeByComboBox.Text);
                            cmdHeader.Parameters.AddWithValue("@DischargeDate", DischargeDateDateTimePicker.Value);
                            cmdHeader.Parameters.AddWithValue("@Diagnosis", diagnosisTextBox.Text);
                            cmdHeader.Parameters.AddWithValue("@Comment", commentTextBox.Text);
                            cmdHeader.Parameters.AddWithValue("@NextVisitNo", nextVisitNoTextBox.Text);
                            cmdHeader.Parameters.AddWithValue("@NextVisitUnit", nextVisitUnitComboBox.Text);
                            cmdHeader.Parameters.AddWithValue("@Patient", PatNametextBox.Text);
                            cmdHeader.Parameters.AddWithValue("@AdmissionDt", AdmissiondateTimePicker.Value);

                            cmdHeader.ExecuteNonQuery();

                            foreach (DataGridViewRow row in AdvicesdataGridView.Rows)
                            {
                                var disIdCell = row.Cells["DisID"];
                                var slnoCell = row.Cells["SLNO"];
                                var particularsCell = row.Cells["Perticulars"];

                                if (disIdCell != null && slnoCell != null && particularsCell != null &&
                                    disIdCell.Value != null && slnoCell.Value != null && particularsCell.Value != null)
                                {
                                    string disId = row.Cells["DisID"].Value.ToString();
                                    string slno = row.Cells["SLNO"].Value.ToString();
                                    string particulars = row.Cells["Perticulars"].Value.ToString();

                                    using (SqlCommand cmdDischargeLin = new SqlCommand(@"MERGE INTO DischargeLin AS target
                                USING (VALUES (@DisID, @SLNO, @Perticulars)) AS source (DisID, SLNO, Perticulars)
                                ON target.DisID = @DisID AND target.SLNO = @SLNO
                                WHEN MATCHED THEN
                                    UPDATE SET target.Perticulars = @Perticulars
                                WHEN NOT MATCHED THEN
                                    INSERT (DisID, SLNO, Perticulars) VALUES (@DisID, @SLNO, @Perticulars);", con, transaction))
                                    {
                                        cmdDischargeLin.Parameters.AddWithValue("@DisID", disId);
                                        cmdDischargeLin.Parameters.AddWithValue("@SLNO", slno);
                                        cmdDischargeLin.Parameters.AddWithValue("@Perticulars", particulars);

                                        cmdDischargeLin.ExecuteNonQuery();
                                    }
                                }
                            }

                            transaction.Commit();
                            MessageBox.Show("Data saved successfully!");
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error while saving data: " + ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }

            Display(); // Refresh the displayed data after saving

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT ISNULL(MAX(Id), 0) + 1 AS NextId FROM Discharge";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    try
                    {
                        con.Open();

                        object result = command.ExecuteScalar();
                        int nextId = Convert.ToInt32(result);

                        // Display the next available ID in a TextBox or Label
                        idTextBox.Text = nextId.ToString();
                    }
                    catch (Exception ex)
                    {
                        // Handle exceptions
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }

            // Clear the values of the specified fields
            IPDSearchtextBox.Text = "RNH/";
            dischargeByComboBox.SelectedIndex = -1;
            DischargeDateDateTimePicker.Value = DateTime.Now; // Reset to default date
            AdmissiondateTimePicker.Value = DateTime.Now; // Reset to default date
            PatNametextBox.Text = string.Empty;
            diagnosisTextBox.Text = string.Empty;
            commentTextBox.Text = string.Empty;
            nextVisitNoTextBox.Text = string.Empty;
            nextVisitUnitComboBox.SelectedIndex = -1;
            AgetextBox.Text = string.Empty;
            GendertextBox.Text = string.Empty;
            Address1textBox.Text = string.Empty;
            Address2textBox.Text = string.Empty;
            CitytextBox.Text = string.Empty;
            PINtextBox.Text = string.Empty;
            IPDSearchtextBox.ReadOnly = false;
        }



        void Display()
        {
           
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    // Query to select specific columns from the Discharge table
                    string query = "SELECT Id, Patient, DischargeBy, DischargeDate, IPD FROM Discharge ORDER BY Id DESC";

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        SqlDataAdapter sda = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        // Clear existing data in the dischargeDataGridView
                        dischargeDataGridView.Rows.Clear();

                        foreach (DataRow row in dt.Rows)
                        {
                            // Add the fetched data to the dischargeDataGridView
                            int rowIndex = dischargeDataGridView.Rows.Add();
                            dischargeDataGridView.Rows[rowIndex].Cells[0].Value = row["Id"].ToString();
                            dischargeDataGridView.Rows[rowIndex].Cells[1].Value = row["IPD"].ToString();
                            dischargeDataGridView.Rows[rowIndex].Cells[2].Value = row["DischargeDate"].ToString();
                            dischargeDataGridView.Rows[rowIndex].Cells[3].Value = row["Patient"].ToString();
                            dischargeDataGridView.Rows[rowIndex].Cells[4].Value = row["DischargeBy"].ToString();
                           
                            // Add more columns as needed
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            

        }

        private void IPDSearchtextBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = IPDSearchtextBox.Text;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = @"SELECT IPD.AdmissionDate, IPD.Patient, IPD.Age,
                        PatientMast.PatGender, PatientMast.PatAddress1, 
                        PatientMast.PatAddress2, PatientMast.PatCity, PatientMast.PatPIN
                        FROM IPD
                        INNER JOIN PatientMast ON IPD.PatID = PatientMast.Id
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
                            // Assign fetched values to respective UI elements

                            if (reader["AdmissionDate"] != DBNull.Value)
                            {
                                AdmissiondateTimePicker.Value = Convert.ToDateTime(reader["AdmissionDate"]);
                            }

                            // Show values in respective UI elements
                            PatNametextBox.Text = reader["Patient"].ToString();
                            AgetextBox.Text = reader["Age"].ToString();
                            GendertextBox.Text = reader["PatGender"].ToString();
                            Address1textBox.Text = reader["PatAddress1"].ToString();
                            Address2textBox.Text = reader["PatAddress2"].ToString();
                            CitytextBox.Text = reader["PatCity"].ToString();
                            PINtextBox.Text = reader["PatPIN"].ToString();
                        }

                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        // Handle exceptions
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }


        private void dischargeDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            IPDSearchtextBox.ReadOnly = true;
            if (dischargeDataGridView.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dischargeDataGridView.SelectedRows[0];

                // Retrieve the value from the "Id" column and set it to idTextBox
                idTextBox.Text = selectedRow.Cells["Id"].Value.ToString();

                // Fetch additional data from the database based on the selected "Id"
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT IPD, DischargeDate, Patient, DischargeBy, Diagnosis, Comment, NextVisitNo, NextVisitUnit, AdmissionDt FROM Discharge WHERE Id = @Id";

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@Id", idTextBox.Text);

                        try
                        {
                            con.Open();
                            SqlDataReader reader = command.ExecuteReader();

                            if (reader.Read())
                            {
                                // Populate text boxes and other controls with the fetched data
                                IPDSearchtextBox.Text = reader["IPD"].ToString();
                                DischargeDateDateTimePicker.Value = Convert.ToDateTime(reader["DischargeDate"]);
                                PatNametextBox.Text = reader["Patient"].ToString();
                                dischargeByComboBox.Text = reader["DischargeBy"].ToString();

                                // Handle nullable fields
                                diagnosisTextBox.Text = reader["Diagnosis"] != DBNull.Value ? reader["Diagnosis"].ToString() : string.Empty;
                                commentTextBox.Text = reader["Comment"] != DBNull.Value ? reader["Comment"].ToString() : string.Empty;
                                nextVisitNoTextBox.Text = reader["NextVisitNo"] != DBNull.Value ? reader["NextVisitNo"].ToString() : string.Empty;
                                nextVisitUnitComboBox.Text = reader["NextVisitUnit"] != DBNull.Value ? reader["NextVisitUnit"].ToString() : string.Empty;

                                AdmissiondateTimePicker.Value = reader["AdmissionDt"] != DBNull.Value
                                    ? Convert.ToDateTime(reader["AdmissionDt"])
                                    : DateTime.Now; // Set to default date or handle accordingly
                            }

                            reader.Close();
                        }
                        catch (Exception ex)
                        {
                            // Handle exceptions
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }
            }

    }



    private void dischargeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DischargeFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void AdvicesdataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the edited cell is in the Perticulars column
            if (e.ColumnIndex == AdvicesdataGridView.Columns["Perticulars"].Index && e.RowIndex >= 0)
            {
                int nextId = Convert.ToInt32(idTextBox.Text); // Get the value from idTextBox
                int serialNumber = e.RowIndex + 1; // Get the current row index as serial number (starting from 1)

                // Update DisID and SLNO columns with the corresponding values
                AdvicesdataGridView.Rows[e.RowIndex].Cells["DisID"].Value = nextId;
                AdvicesdataGridView.Rows[e.RowIndex].Cells["SLNO"].Value = serialNumber;
            }
        }

        private void DisplayDischargeLinData(string disId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT DisID, SLNO, Perticulars FROM DischargeLin WHERE DisID = @DisID";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@DisID", disId);

                    try
                    {
                        con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        // Clear existing data in the AdvicesdataGridView
                        AdvicesdataGridView.Rows.Clear();

                        foreach (DataRow row in dt.Rows)
                        {
                            // Add the fetched data to the AdvicesdataGridView
                            int rowIndex = AdvicesdataGridView.Rows.Add();
                            AdvicesdataGridView.Rows[rowIndex].Cells["DisID"].Value = row["DisID"].ToString();
                            AdvicesdataGridView.Rows[rowIndex].Cells["SLNO"].Value = row["SLNO"].ToString();
                            AdvicesdataGridView.Rows[rowIndex].Cells["Perticulars"].Value = row["Perticulars"].ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {
           
            // Call the method with the current idTextBox value
            DisplayDischargeLinData(idTextBox.Text);
           
        }

        private void buttonIPD_Click(object sender, EventArgs e)
        {
            IPDFrm myForm = new IPDFrm();

            myForm.ShowDialog();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            // Ensure that the user has selected a row in the dischargeDataGridView
            if (dischargeDataGridView.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dischargeDataGridView.SelectedRows[0];

                // Retrieve the value from the "Id" column and set it to idToDelete
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
                        // Delete from DischargeLin table first
                        using (SqlCommand cmdDischargeLin = new SqlCommand("DELETE FROM DischargeLin WHERE DisID = @Id", con, transaction))
                        {
                            cmdDischargeLin.Parameters.AddWithValue("@Id", idToDelete);
                            cmdDischargeLin.ExecuteNonQuery();
                        }

                        // Then delete from Discharge table
                        using (SqlCommand cmdDischarge = new SqlCommand("DELETE FROM Discharge WHERE Id = @Id", con, transaction))
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
            dischargeByComboBox.SelectedIndex = -1;
            DischargeDateDateTimePicker.Value = DateTime.Now; // Set to desired default date or leave as is
            IPDSearchtextBox.Text = "RNH/";
            AdmissiondateTimePicker.Value = DateTime.Now; // Set to desired default date or leave as is
            PatNametextBox.Text = string.Empty;
            diagnosisTextBox.Text = string.Empty;
            commentTextBox.Text = string.Empty;
            nextVisitNoTextBox.Text = string.Empty;
            nextVisitUnitComboBox.SelectedIndex = -1;
            AgetextBox.Text = string.Empty;
            GendertextBox.Text = string.Empty;
            Address1textBox.Text = string.Empty;
            Address2textBox.Text = string.Empty;
            CitytextBox.Text = string.Empty;
            PINtextBox.Text = string.Empty;
        }

        private void DischargeDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DischargeDateDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }

        private void AdmissiondateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            AdmissiondateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }
    }
}
