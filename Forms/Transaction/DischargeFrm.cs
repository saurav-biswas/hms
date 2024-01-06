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

namespace HMS.Forms.Transaction
{
    public partial class DischargeFrm : Form

         
    {
        string connectionString = ConfigurationManager.ConnectionStrings["HMS.Properties.Settings.HMSConnectionString"].ConnectionString;
        //SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=HMS;Integrated Security=True");
        public DischargeFrm()
        {
            InitializeComponent();
        }


        private void DischargeFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet.IPD' table. You can move, or remove it, as needed.
            this.iPDTableAdapter.Fill(this.hMSDataSet.IPD);
            // TODO: This line of code loads data into the 'hMSDataSet.DoctorMast' table. You can move, or remove it, as needed.
            this.doctorMastTableAdapter.Fill(this.hMSDataSet.DoctorMast);
            // TODO: This line of code loads data into the 'hMSDataSet.PatientMast' table. You can move, or remove it, as needed.
            this.patientMastTableAdapter.Fill(this.hMSDataSet.PatientMast);
            // TODO: This line of code loads data into the 'hMSDataSet.Discharge' table. You can move, or remove it, as needed.
            this.dischargeTableAdapter.Fill(this.hMSDataSet.Discharge);
            Display();

        }

        
        private void Findbutton_Click(object sender, EventArgs e)
            {
            using (SqlConnection con = new SqlConnection(connectionString))
            //using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=HMS;Integrated Security=True"))
            {
                con.Open();
                    string PID = PatidTextBox.Text;
                    string query = @"SELECT PM.PatName, IPD.Age, PM.PatGender, PM.PatAddress1, PM.PatAddress2, PM.PatCity, PM.PatPIN
                                 FROM PatientMast PM
                                 INNER JOIN IPD ON PM.ID = IPD.PatID
                                 WHERE PM.id = @PID";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@PID", PID);
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        PatNametextBox.Text = reader["PatName"].ToString();
                        AgetextBox.Text = reader["Age"].ToString();
                        GendertextBox.Text = reader["PatGender"].ToString();
                        Address1textBox.Text = reader["PatAddress1"].ToString();
                        Address2textBox.Text = reader["PatAddress2"].ToString();
                        CitytextBox.Text = reader["PatCity"].ToString();
                        PINtextBox.Text = reader["PatPIN"].ToString();
                    }
                    else
                        MessageBox.Show("No Patient Found");
                    con.Close();
                }
            }





        

        private void printbutton_Click(object sender, EventArgs e)
        {
            DischargeSlipRpt report = new DischargeSlipRpt();
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
            //view.ReportSource = report;
            //   view.crystalReportViewer1.ReportSource = report;

            view.Show();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            //using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=HMS;Integrated Security=True"))
            {
                // try
                {
                    con.Open();
                    
                    using (SqlCommand cmdHeader = new SqlCommand(@"INSERT INTO Discharge (Id, Patient, DischargeBy, Comment, NextVisitNo, NextVisitUnit, DischargeDate, IPDNo, Diagnosis, PatID, AdmissionDt) 
                    VALUES (@Id, @PatName, @DischargeBy, @Comment, @NextVisitNo, @NextVisitUnit, @DischargeDt, @IPDNo, @Diagnosis, @PatID)", con))
                    {
                        // conn.Open();

                        // Add parameters with appropriate types
                        cmdHeader.Parameters.AddWithValue("@Id", idTextBox.Text);
                        cmdHeader.Parameters.AddWithValue("@PatName", PatNametextBox.Text);
                        cmdHeader.Parameters.AddWithValue("@DischargeBy", dischargeByComboBox.Text);
                        cmdHeader.Parameters.AddWithValue("@Comment", commentTextBox.Text);
                        cmdHeader.Parameters.AddWithValue("@NextVisitNo", nextVisitNoTextBox.Text);
                        cmdHeader.Parameters.AddWithValue("@NextVisitUnit", nextVisitUnitComboBox.Text);
                        cmdHeader.Parameters.AddWithValue("@DischargeDt", DischargeDateDateTimePicker.Value);
                        cmdHeader.Parameters.AddWithValue("@IPDNo", IPDSearchtextBox.Text);
                        cmdHeader.Parameters.AddWithValue("@Diagnosis", diagnosisTextBox.Text);
                        cmdHeader.Parameters.AddWithValue("@PatID", PatidTextBox.Text);
                        //cmdHeader.Parameters.AddWithValue("@AdmissionDt", AdmissiondateTimePicker.Value);
                        //  AdmissiondateTimePicker.Value

                        // Add other parameters in a similar fashion...

                        cmdHeader.ExecuteNonQuery();


                        //MAKE BED AVLABLE AGAIN
                        /*
                        // Update PatBalAmt in PatientMast table
                        string updateQuery = "UPDATE PatientMast SET PatBalAmt = 0 WHERE ID = @PatientID";
                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                        {
                            updateCmd.Parameters.AddWithValue("@PatientID", PatientidTextBox.Text);
                            updateCmd.ExecuteNonQuery();
                        }
                        */


                        // MessageBox.Show("Data saved successfully!");
                    }
                    //  catch (SqlException ex)
                    {
                        // MessageBox.Show("Error while saving data: " + ex.Message);
                    }
                    //       finally
                    {
                        con.Close();
                    }
                }

                Display();
            }
        }


        void Display()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            //
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * from Discharge", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dischargeDataGridView.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {

                    int n = dischargeDataGridView.Rows.Add();

                    dischargeDataGridView.Rows[n].Cells[0].Value = item["Id"].ToString();
                    dischargeDataGridView.Rows[n].Cells[1].Value = item["IPD"].ToString();
                    dischargeDataGridView.Rows[n].Cells[2].Value = item["DischargeDate"].ToString();
                    dischargeDataGridView.Rows[n].Cells[3].Value = item["Patient"].ToString();
                    dischargeDataGridView.Rows[n].Cells[4].Value = item["DischargeBy"].ToString();
                    dischargeDataGridView.Rows[n].Cells[5].Value = item["Diagnosis"].ToString();
                    dischargeDataGridView.Rows[n].Cells[6].Value = item["Comment"].ToString();
                    dischargeDataGridView.Rows[n].Cells[7].Value = item["NextVisitNo"].ToString();
                    dischargeDataGridView.Rows[n].Cells[8].Value = item["NextVisitUnit"].ToString();
                    dischargeDataGridView.Rows[n].Cells[9].Value = item["PatID"].ToString();

                }

            }
        }

        private void IPDSearchtextBox_TextChanged(object sender, EventArgs e)
        {
            string searchText = IPDSearchtextBox.Text;

            using (SqlConnection con = new SqlConnection(connectionString))
            //using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=HMS;Integrated Security=True"))
            {
                // Query to fetch details from related tables
                string query = @"SELECT IPD.AdmissionDate
                         FROM IPD  WHERE IPD.Id = @searchText";

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
            using (SqlConnection con = new SqlConnection(connectionString))
            //using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=HMS;Integrated Security=True"))
            {
                con.Open();
                string PID = PatidTextBox.Text;
                string query = @"SELECT PM.PatName, IPD.Age, PM.PatGender, PM.PatAddress1, PM.PatAddress2, PM.PatCity, PM.PatPIN
                                 FROM PatientMast PM
                                 INNER JOIN IPD ON PM.ID = IPD.PatID
                                 WHERE PM.id = @PID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@PID", PID);
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    PatNametextBox.Text = reader["PatName"].ToString();
                    AgetextBox.Text = reader["Age"].ToString();
                    GendertextBox.Text = reader["PatGender"].ToString();
                    Address1textBox.Text = reader["PatAddress1"].ToString();
                    Address2textBox.Text = reader["PatAddress2"].ToString();
                    CitytextBox.Text = reader["PatCity"].ToString();
                    PINtextBox.Text = reader["PatPIN"].ToString();
                }
                else
                    MessageBox.Show("No Patient Found");
                con.Close();
            }

            idTextBox.Text                      = dischargeDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            IPDSearchtextBox.Text               = dischargeDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            DischargeDateDateTimePicker.Text    = dischargeDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            PatNametextBox.Text                 = dischargeDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            dischargeByComboBox.Text            = dischargeDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            diagnosisTextBox.Text               = dischargeDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            commentTextBox.Text                 = dischargeDataGridView.SelectedRows[0].Cells[6].Value.ToString();
            nextVisitNoTextBox.Text             = dischargeDataGridView.SelectedRows[0].Cells[7].Value.ToString();
            nextVisitUnitComboBox.Text          = dischargeDataGridView.SelectedRows[0].Cells[8].Value.ToString();
           //AdmissiondateTimePicker.Text        = dischargeDataGridView.SelectedRows[0].Cells[9].Value.ToString();
            //payModeComboBox.Text = advanceDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            PatidTextBox.Text                   = dischargeDataGridView.SelectedRows[0].Cells[9].Value.ToString();


            string searchText = IPDSearchtextBox.Text;

            using (SqlConnection con = new SqlConnection(connectionString))
            //using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=HMS;Integrated Security=True"))
            {
                // Query to fetch details from related tables
                string query = @"SELECT IPD.AdmissionDate
                         FROM IPD  WHERE IPD.Id = @searchText";

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

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            //using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=HMS;Integrated Security=True"))
            {
                con.Open();

                using (SqlCommand cmdHeader = new SqlCommand(@"UPDATE Discharge 
                                                      SET Patient = @PatName, 
                                                          DischargeBy = @DischargeBy, 
                                                          Comment = @Comment, 
                                                          NextVisitNo = @NextVisitNo, 
                                                          NextVisitUnit = @NextVisitUnit, 
                                                          DischargeDate = @DischargeDt, 
                                                          IPD = @IPD, 
                                                          Diagnosis = @Diagnosis, 
                                                          PatID = @PatID 
                                                          
                                                      WHERE Id = @Id", con))
                {
                    cmdHeader.Parameters.AddWithValue("@Id", idTextBox.Text);
                    cmdHeader.Parameters.AddWithValue("@PatName", PatNametextBox.Text);
                    cmdHeader.Parameters.AddWithValue("@DischargeBy", dischargeByComboBox.Text);
                    cmdHeader.Parameters.AddWithValue("@Comment", commentTextBox.Text);
                    cmdHeader.Parameters.AddWithValue("@NextVisitNo", nextVisitNoTextBox.Text);
                    cmdHeader.Parameters.AddWithValue("@NextVisitUnit", nextVisitUnitComboBox.Text);
                    cmdHeader.Parameters.AddWithValue("@DischargeDt", DischargeDateDateTimePicker.Value);
                    cmdHeader.Parameters.AddWithValue("@IPD", IPDSearchtextBox.Text);
                    cmdHeader.Parameters.AddWithValue("@Diagnosis", diagnosisTextBox.Text);
                    cmdHeader.Parameters.AddWithValue("@PatID", PatidTextBox.Text);
                    //cmdHeader.Parameters.AddWithValue("@AdmissionDt", AdmissiondateTimePicker.Value);

                    cmdHeader.ExecuteNonQuery();

                    
                    
                }

                con.Close();
            }
            Display();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            
            idTextBox.Text = "";
            IPDSearchtextBox.Text = "";
            PatNametextBox.Text = "";
            dischargeByComboBox.SelectedIndex = -1;
            commentTextBox.Text = "";
            nextVisitNoTextBox.Text = "";
            nextVisitUnitComboBox.SelectedIndex = -1;
            DischargeDateDateTimePicker.Text = "";
            IPDSearchtextBox.Text = "";
            diagnosisTextBox.Text = "";
            PatidTextBox.Text = "";
            PatNametextBox.Text = "";
            AgetextBox.Text = "";
            GendertextBox.Text = "";
            Address1textBox.Text = "";
            Address2textBox.Text = "";
            CitytextBox.Text = "";
            PINtextBox.Text = "";
            AdmissiondateTimePicker.Text = "";

            idTextBox.Focus();
            Display();

            
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            idTextBox.Text = "";
            IPDSearchtextBox.Text = "";
            PatNametextBox.Text = "";
            dischargeByComboBox.SelectedIndex = -1;
            commentTextBox.Text = "";
            nextVisitNoTextBox.Text = "";
            nextVisitUnitComboBox.SelectedIndex = -1;
            DischargeDateDateTimePicker.Text = "";
            IPDSearchtextBox.Text = "";
            diagnosisTextBox.Text = "";
            PatidTextBox.Text = "";
            PatNametextBox.Text = "";
            AgetextBox.Text = "";
            GendertextBox.Text = "";
            Address1textBox.Text = "";
            Address2textBox.Text = "";
            CitytextBox.Text = "";
            PINtextBox.Text = "";
            AdmissiondateTimePicker.Text = "";

            idTextBox.Focus();
            Display();

        }

        private void dischargeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
