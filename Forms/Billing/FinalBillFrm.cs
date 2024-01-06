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
using Xamarin.Forms;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
using System.Globalization;
using HMS.Reports;
using System.Configuration;
using CrystalDecisions.Windows.Forms;
using GridMvc;

namespace HMS.Forms.Billing
{
    public partial class FinalBillFrm : Form
    {
        

        string connectionString = ConfigurationManager.ConnectionStrings["HMS.Properties.Settings.HMSConnectionString"].ConnectionString;

       // SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=HMS;Integrated Security=True");
        private DataTable dt = new DataTable();
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;

        public FinalBillFrm()
        {
            InitializeComponent();
            IPDSearchtextBox.TextChanged += IPDSearchtextBox_TextChanged;
           
        }      

        private void Findbutton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            //using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=HMS;Integrated Security=True"))
            {

                con.Open();

                string PID = PatientidTextBox.Text;
                string patName = PatNametextBox.Text;

                string query = "SELECT PatName FROM PatientMast WHERE id  = " + PID;
                SqlCommand cmd = new SqlCommand(query, con);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    PatNametextBox.Text = reader["PatName"].ToString();
                }
                else
                    MessageBox.Show("No Patient Found");


                con.Close();


            }  
        }

        private void FinalBillFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet.BedManagement' table. You can move, or remove it, as needed.
            this.bedManagementTableAdapter.Fill(this.hMSDataSet.BedManagement);
            // TODO: This line of code loads data into the 'hMSDataSet.TaxMast' table. You can move, or remove it, as needed.
            this.taxMastTableAdapter.Fill(this.hMSDataSet.TaxMast);
            // TODO: This line of code loads data into the 'hMSDataSet.TaxMast' table. You can move, or remove it, as needed.
         //   this.taxMastTableAdapter.Fill(this.hMSDataSet.TaxMast);
            // TODO: This line of code loads data into the 'hMSDataSet.IPD' table. You can move, or remove it, as needed.
            this.iPDTableAdapter.Fill(this.hMSDataSet.IPD);
            Display();

        }



        private void bedManagementDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void IPDSearchtextBox_TextChanged(object sender, EventArgs e)
        {
            
                string searchText = IPDSearchtextBox.Text;

            using (SqlConnection con = new SqlConnection(connectionString))
            //using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=HMS;Integrated Security=True"))
            {
                string query = @"SELECT PatientMast.PatGender, IPD.Age, IPD.GarName, PatientMast.PatAddress1, 
                         PatientMast.PatAddress2, PatientMast.PatCity, PatientMast.PatPIN, 
                         PatientMast.PatUnderDr, PatientMast.PatRefferedBy, IPD.AdmissionDate, 
                         Discharge.DischargeDate
                         FROM IPD
                         INNER JOIN PatientMast ON IPD.PatID = PatientMast.Id
                         LEFT JOIN Discharge ON IPD.Id = Discharge.IPD
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
                                PatGendertextBox.Text = reader["PatGender"].ToString();
                                PatAgetextBox.Text = reader["Age"].ToString();
                                GarNametextBox.Text = reader["GarName"].ToString();
                                Address1textBox.Text = reader["PatAddress1"].ToString();
                                Address2textBox.Text = reader["PatAddress2"].ToString();
                                CitytextBox.Text = reader["PatCity"].ToString();
                                PINtextBox.Text = reader["PatPIN"].ToString();
                                UnderDrtextBox.Text = reader["PatUnderDr"].ToString();
                                RefDrtextBox.Text = reader["PatRefferedBy"].ToString();

                                if (reader["AdmissionDate"] != DBNull.Value)
                                {
                                    AdmissiondateTimePicker.Value = Convert.ToDateTime(reader["AdmissionDate"]);
                                }

                                if (reader["DischargeDate"] != DBNull.Value)
                                {
                                    DischargedateTimePicker.Value = Convert.ToDateTime(reader["DischargeDate"]);
                                }
                                else
                                {
                                    DischargedateTimePicker.Value = DateTime.MinValue;
                                }
                            }

                            reader.Close();

                            // Now, let's update the BedManagementDataGridView

                            string bedManagementQuery = $"SELECT * FROM BedManagement WHERE IPD = '{searchText}'";
                            SqlDataAdapter adapter = new SqlDataAdapter(bedManagementQuery, con);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            bedManagementDataGridView.DataSource = dataTable;

                            // Calculate the total BedAmount and display it in BedAmtTextBox
                            decimal totalBedAmount = 0;

                            foreach (DataRow row in dataTable.Rows)
                            {
                                if (decimal.TryParse(row["BedAmount"].ToString(), out decimal bedAmount))
                                {
                                    totalBedAmount += bedAmount;
                                }
                            }

                            BedAmtTextBox.Text = totalBedAmount.ToString(); // Assuming BedAmount is a currency field
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }



        }

        private void BedAmtTextBox_TextChanged(object sender, EventArgs e)
        {
            //UpdateTotalAmount();
        }

        private void bedManagementDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void OtherItemsdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OtherItemsdataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // UpdateTotalAmount();
            if (OtherItemsdataGridView.Columns["Amount"] != null && e.ColumnIndex == OtherItemsdataGridView.Columns["Amount"].Index)
            {
                CalculateTotalAmount();
            }
        }



        private void OtherItemsdataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateTotalAmt();
        }

        private void OtherAmttextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalAmt();
        }

        private void UpdateTotalAmt()
        {
            // Parse values from BedAmtTextBox and OtherAmttextBox
            if (decimal.TryParse(BedAmtTextBox.Text, out decimal bedAmount) &&
                decimal.TryParse(OtherAmttextBox.Text, out decimal otherAmount))
            {
                // Calculate total amount
                decimal totalAmount = bedAmount + otherAmount;

                // Display the total amount in DetailTotalAmttextBox
                DetailTotalAmttextBox.Text = totalAmount.ToString();
            }
            else
            {
                // Handle invalid input if needed
                DetailTotalAmttextBox.Text = "Invalid input";
            }
        }

        private void TaxAmttextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateTotAmt();
        }

        private void DetailTotalAmttextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateTaxAmount();
            UpdateTotAmt();
            //UpdateAdvanceAmount();

        }

        private void UpdateTaxAmount()
        {
            // Parse percentage rate from percentageTextBox
            if (decimal.TryParse(percentageTextBox.Text, out decimal percentageRate))
            {
                // Parse total amount from DetailTotalAmttextBox
                if (decimal.TryParse(DetailTotalAmttextBox.Text, out decimal totalAmount))
                {
                    // Calculate tax amount based on the percentage rate
                    decimal taxAmount = (percentageRate / 100) * totalAmount;

                    // Display the tax amount in TaxAmttextBox
                    TaxAmttextBox.Text = taxAmount.ToString();
                }
                else
                {
                    // Handle invalid total amount if needed
                    TaxAmttextBox.Text = "Invalid total amount";
                }
            }
            else
            {
                // Handle invalid percentage rate if needed
                TaxAmttextBox.Text = "Invalid percentage rate";
            }

        }


        private void UpdateTotAmt()
        {
            // Parse values from DetailTotalAmttextBox, TaxAmttextBox, and ConcessionAmttextBox
            if (decimal.TryParse(DetailTotalAmttextBox.Text, out decimal totalAmount) &&
                decimal.TryParse(TaxAmttextBox.Text, out decimal taxAmount) &&
                decimal.TryParse(ConcessionAmttextBox.Text, out decimal concessionAmount))
            {
                // Calculate total amount considering tax and concession
                decimal finalAmount = totalAmount + taxAmount - concessionAmount;

                // Display the final amount in TotAmttextBox
                TotAmttextBox.Text = finalAmount.ToString();
            }
            else
            {
                // Handle invalid input if needed
                TotAmttextBox.Text = "Invalid input";
            }
        }

        private void TotAmttextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateTotAmt();
            //   UpdateReceivablesAmt();
        }

        private void ConcessionAmttextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateTotAmt();
            UpdateReceivablesAmt();
        }

        private void DocFeesAmttextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateChargeableAmt();
        }

        private void MedicinesAmttextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateChargeableAmt();
        }

        private void BloodAmttextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateChargeableAmt();
        }

        private void OthrChrgAmtstextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateChargeableAmt();
        }

        private void UpdateChargeableAmt()
        {
            // Parse values from DocFeesAmttextBox, MedicinesAmttextBox, BloodAmttextBox, and OthrChrgAmtstextBox
            if (decimal.TryParse(DocFeesAmttextBox.Text, out decimal docFeesAmount) &&
                decimal.TryParse(MedicinesAmttextBox.Text, out decimal medicinesAmount) &&
                decimal.TryParse(BloodAmttextBox.Text, out decimal bloodAmount) &&
                decimal.TryParse(OthrChrgAmtstextBox.Text, out decimal otherChargesAmount))
            {
                // Calculate chargeable amount by summing all charges
                decimal chargeableAmount = docFeesAmount + medicinesAmount + bloodAmount + otherChargesAmount;

                // Display the chargeable amount in ChargeableAmttextBox
                ChargeableAmttextBox.Text = chargeableAmount.ToString();
            }
            else
            {
                // Handle invalid input if needed
                ChargeableAmttextBox.Text = "Invalid input";
            }
        }

        private void UpdateAdvanceAmount(string patID)
        {
            // Perform database operations to retrieve the sum of AdvAmt for the specified PatID
            if (!string.IsNullOrEmpty(patID))
            {
                // Assuming conn is your SqlConnection object
                using (SqlConnection con = new SqlConnection(connectionString))
                //using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=HMS;Integrated Security=True"))
                {
                    string query = "SELECT SUM(AdvAmt) FROM Advance WHERE PatID = @PatID";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@PatID", patID);

                        try
                        {
                            con.Open();
                            object result = cmd.ExecuteScalar();
                            if (result != DBNull.Value)
                            {
                                decimal advanceAmount = Convert.ToDecimal(result);

                                // Display the sum of AdvAmt in AdvanceAmttextBox
                                AdvanceAmttextBox.Text = advanceAmount.ToString();
                            }
                            else
                            {
                                // Handle case where no records are found for the provided PatID
                                AdvanceAmttextBox.Text = "No advance found";
                            }
                        }
                        catch (SqlException ex)
                        {
                            // Handle any SQL exceptions here
                            AdvanceAmttextBox.Text = "SQL Error: " + ex.Message;
                        }
                        finally
                        {
                            con.Close();
                        }
                    }
                }
            }
        }

        private void ChargeableAmttextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateReceivablesAmt();
        }

        private void AdvanceAmttextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateReceivablesAmt();
        }

        private void UpdateReceivablesAmt()
        {
            // Parse values from TotAmttextBox, ChargeableAmttextBox, and AdvanceAmttextBox
            if (decimal.TryParse(TotAmttextBox.Text, out decimal totalAmount) &&
                decimal.TryParse(ChargeableAmttextBox.Text, out decimal chargeableAmount) &&
                decimal.TryParse(AdvanceAmttextBox.Text, out decimal advanceAmount))
            {
                // Calculate receivables amount by summing total, chargeable, and advance
                decimal receivablesAmount = totalAmount + chargeableAmount - advanceAmount;

                // Display the receivables amount in ReceivablesAmttextBox
                ReceivablesAmttextBox.Text = receivablesAmount.ToString();
            }
            else
            {
                // Handle invalid input if needed
                ReceivablesAmttextBox.Text = "Invalid input";
            }
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            //using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=HMS;Integrated Security=True"))
            {
                try
                {
                    con.Open();

                    // Check if the record with the given ID already exists
                    string checkExistenceQuery = "SELECT COUNT(*) FROM FinalBillHdr WHERE Id = @Id";
                    using (SqlCommand checkExistenceCmd = new SqlCommand(checkExistenceQuery, con))
                    {
                        checkExistenceCmd.Parameters.AddWithValue("@Id", idTextBox.Text);

                        int count = (int)checkExistenceCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            // Update the existing record
                            string updateQuerya = "UPDATE FinalBillHdr SET IPD = @IPD, BillDate = @BillDate, TaxRate = @TaxRate, " +
                                                    "TaxAmt = @TaxAmt, Concession = @Concession, DrFees = @DrFees, Medicine = @Medicine, " +
                                                    "Blood = @Blood, OtherCharges = @OtherCharges, AdvanceReceived = @AdvanceReceived, " +
                                                    "TotalReceivable = @TotalReceivable, PatientID = @PatientID, PatientName = @PatientName, " +
                                                    "PayMode = @PayMode, BedTAmt = @BedTAmt, OtherTAmt = @OtherTAmt, TaxName = @TaxName, " +
                                                    "DtlTAmt = @DtlTAmt, TotalAmt = @TotalAmt, ChargableAmt = @ChargableAmt " +
                                                    "WHERE Id = @Id";

                            using (SqlCommand updateCmd = new SqlCommand(updateQuerya, con))
                            {
                                // Add parameters with appropriate types
                                updateCmd.Parameters.AddWithValue("@Id", idTextBox.Text);
                                updateCmd.Parameters.AddWithValue("@IPD", IPDSearchtextBox.Text);
                                updateCmd.Parameters.AddWithValue("@BillDate", FinalpayDateDateTimePicker.Value);
                                updateCmd.Parameters.AddWithValue("@TaxRate", percentageTextBox.Text);
                                updateCmd.Parameters.AddWithValue("@TaxAmt", TaxAmttextBox.Text);
                                updateCmd.Parameters.AddWithValue("@Concession", ConcessionAmttextBox.Text);
                                updateCmd.Parameters.AddWithValue("@DrFees", DocFeesAmttextBox.Text);
                                updateCmd.Parameters.AddWithValue("@Medicine", MedicinesAmttextBox.Text);
                                updateCmd.Parameters.AddWithValue("@Blood", BloodAmttextBox.Text);
                                updateCmd.Parameters.AddWithValue("@OtherCharges", OthrChrgAmtstextBox.Text);
                                updateCmd.Parameters.AddWithValue("@AdvanceReceived", AdvanceAmttextBox.Text);
                                updateCmd.Parameters.AddWithValue("@TotalReceivable", ReceivablesAmttextBox.Text);
                                updateCmd.Parameters.AddWithValue("@PatientID", PatientidTextBox.Text);
                                updateCmd.Parameters.AddWithValue("@PatientName", PatNametextBox.Text);
                                updateCmd.Parameters.AddWithValue("@PayMode", payModeComboBox.Text);
                                updateCmd.Parameters.AddWithValue("@BedTAmt", BedAmtTextBox.Text);
                                updateCmd.Parameters.AddWithValue("@OtherTAmt", OtherAmttextBox.Text);
                                updateCmd.Parameters.AddWithValue("@TaxName", taxNameComboBox.Text);
                                updateCmd.Parameters.AddWithValue("@DtlTAmt", DetailTotalAmttextBox.Text);
                                updateCmd.Parameters.AddWithValue("@TotalAmt", TotAmttextBox.Text);
                                updateCmd.Parameters.AddWithValue("@ChargableAmt", ChargeableAmttextBox.Text);
                                // Add other parameters...

                                updateCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Insert a new record
                            using (SqlCommand cmdHeader = new SqlCommand("INSERT INTO FinalBillHdr (Id, IPD, BillDate, TaxRate, TaxAmt, Concession, DrFees, Medicine, Blood, OtherCharges, AdvanceReceived, TotalReceivable, PatientID, PatientName, PayMode, BedTAmt, OtherTAmt, TaxName, DtlTAmt, TotalAmt, ChargableAmt) " +
                                "VALUES (@Id, @IPD, @BillDate, @TaxRate, @TaxAmt, @Concession, @DrFees, @Medicine, @Blood, @OtherCharges, @AdvanceReceived, @TotalReceivable, @PatientID, @PatientName, @PayMode, @BedTAmt, @OtherTAmt, @TaxName, @DtlTAmt, @TotalAmt, @ChargableAmt)", con))
                            {
                                // Add parameters with appropriate types
                                cmdHeader.Parameters.AddWithValue("@Id", idTextBox.Text);
                                cmdHeader.Parameters.AddWithValue("@IPD", IPDSearchtextBox.Text);
                                cmdHeader.Parameters.AddWithValue("@BillDate", FinalpayDateDateTimePicker.Value);
                                cmdHeader.Parameters.AddWithValue("@TaxRate", percentageTextBox.Text);
                                cmdHeader.Parameters.AddWithValue("@TaxAmt", TaxAmttextBox.Text);
                                cmdHeader.Parameters.AddWithValue("@Concession", ConcessionAmttextBox.Text);
                                cmdHeader.Parameters.AddWithValue("@DrFees", DocFeesAmttextBox.Text);
                                cmdHeader.Parameters.AddWithValue("@Medicine", MedicinesAmttextBox.Text);
                                cmdHeader.Parameters.AddWithValue("@Blood", BloodAmttextBox.Text);
                                cmdHeader.Parameters.AddWithValue("@OtherCharges", OthrChrgAmtstextBox.Text);
                                cmdHeader.Parameters.AddWithValue("@AdvanceReceived", AdvanceAmttextBox.Text);
                                cmdHeader.Parameters.AddWithValue("@TotalReceivable", ReceivablesAmttextBox.Text);
                                cmdHeader.Parameters.AddWithValue("@PatientID", PatientidTextBox.Text);
                                cmdHeader.Parameters.AddWithValue("@PatientName", PatNametextBox.Text);
                                cmdHeader.Parameters.AddWithValue("@PayMode", payModeComboBox.Text);
                                cmdHeader.Parameters.AddWithValue("@BedTAmt", BedAmtTextBox.Text);
                                cmdHeader.Parameters.AddWithValue("@OtherTAmt", OtherAmttextBox.Text);
                                cmdHeader.Parameters.AddWithValue("@TaxName", taxNameComboBox.Text);
                                cmdHeader.Parameters.AddWithValue("@DtlTAmt", DetailTotalAmttextBox.Text);
                                cmdHeader.Parameters.AddWithValue("@TotalAmt", TotAmttextBox.Text);
                                cmdHeader.Parameters.AddWithValue("@ChargableAmt", ChargeableAmttextBox.Text);
                                // Add other parameters...

                                cmdHeader.ExecuteNonQuery();
                            }
                        }
                    }

                    // Your existing code to insert data into FinalBillOtherAmount table...

                    // Your existing code to update PatientMast table...

                    // Your code for updating FinalBillOtherAmount table
                    string clearQuery = "DELETE FROM FinalBillOtherAmount WHERE FBOItemsTID = @idTextBox";

                    using (SqlCommand clearCmd = new SqlCommand(clearQuery, con))
                    {
                        clearCmd.Parameters.AddWithValue("@idTextBox", idTextBox.Text);
                        clearCmd.ExecuteNonQuery();
                    }
                    // Your existing loop to insert data into FinalBillOtherAmount table
                    foreach (DataGridViewRow row in OtherItemsdataGridView.Rows)
                    {
                        if (!row.IsNewRow)
                        {

                            
                            string oiParticulars = Convert.ToString(row.Cells["Particulars"].Value);
                            string oiAmountStr = Convert.ToString(row.Cells["Amount"].Value);

                            if (!string.IsNullOrWhiteSpace(oiParticulars) && !string.IsNullOrWhiteSpace(oiAmountStr))
                            {

                                if (oiParticulars.Length > 50)
                                {
                                    oiParticulars = oiParticulars.Substring(0, 50);
                                }

                                decimal oiAmount = Convert.ToDecimal(oiAmountStr);

                                // Assuming idTextBox contains the FBOItemsTID value
                                string ipdValue = idTextBox.Text;

                                string query = "INSERT INTO FinalBillOtherAmount (FBOItemsTID, FBOItemsId, FBOItemsPerticulars, FBOItemsAmt) " +
                                                "VALUES (@idTextBox, @SlNo, @Particulars, @Amount)";

                                using (SqlCommand cmdOther = new SqlCommand(query, con))
                                {
                                    cmdOther.Parameters.AddWithValue("@idTextBox", ipdValue);
                                    cmdOther.Parameters.AddWithValue("@SlNo", currentSlNo++); // Increment SlNo here
                                    cmdOther.Parameters.AddWithValue("@Particulars", oiParticulars);
                                    cmdOther.Parameters.AddWithValue("@Amount", oiAmount);

                                    cmdOther.ExecuteNonQuery();
                                }
                            }
                              
                        }

                        string updateQuery = "UPDATE PatientMast SET PatBalAmt = 0 WHERE ID = @PatientID";
                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                        {
                            updateCmd.Parameters.AddWithValue("@PatientID", PatientidTextBox.Text);
                            updateCmd.ExecuteNonQuery();
                        }



                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error while saving data: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }

                Display(); // Assuming Display() method refreshes the form or display data
            }
            
        }

        private void ReceivablesAmttextBox_TextChanged(object sender, EventArgs e)
        {

        }
        
        void Display()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            //
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * from FinalBillHdr", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                FinalBillListdataGridView.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {

                    int n = FinalBillListdataGridView.Rows.Add();

                    FinalBillListdataGridView.Rows[n].Cells[0].Value = item["Id"].ToString();//
                    FinalBillListdataGridView.Rows[n].Cells[1].Value = item["BillDate"].ToString();//
                    FinalBillListdataGridView.Rows[n].Cells[2].Value = item["PatientID"].ToString();//
                    FinalBillListdataGridView.Rows[n].Cells[3].Value = item["PatientName"].ToString();//
                    FinalBillListdataGridView.Rows[n].Cells[4].Value = item["PayMode"].ToString();//
                    FinalBillListdataGridView.Rows[n].Cells[5].Value = item["IPD"].ToString();//
                    FinalBillListdataGridView.Rows[n].Cells[6].Value = item["BedTAmt"].ToString();//
                    FinalBillListdataGridView.Rows[n].Cells[7].Value = item["OtherTAmt"].ToString();//
                    FinalBillListdataGridView.Rows[n].Cells[8].Value = item["DtlTAmt"].ToString();//
                    FinalBillListdataGridView.Rows[n].Cells[9].Value = item["TaxName"].ToString();//
                    FinalBillListdataGridView.Rows[n].Cells[10].Value = item["TaxRate"].ToString();//
                    FinalBillListdataGridView.Rows[n].Cells[11].Value = item["TaxAmt"].ToString();//
                    FinalBillListdataGridView.Rows[n].Cells[12].Value = item["Concession"].ToString();//
                    FinalBillListdataGridView.Rows[n].Cells[13].Value = item["TotalAmt"].ToString();//
                    FinalBillListdataGridView.Rows[n].Cells[14].Value = item["DrFees"].ToString();//
                    FinalBillListdataGridView.Rows[n].Cells[15].Value = item["Medicine"].ToString();//
                    FinalBillListdataGridView.Rows[n].Cells[16].Value = item["Blood"].ToString();//
                    FinalBillListdataGridView.Rows[n].Cells[17].Value = item["OtherCharges"].ToString();//
                    FinalBillListdataGridView.Rows[n].Cells[18].Value = item["ChargableAmt"].ToString();//
                    FinalBillListdataGridView.Rows[n].Cells[19].Value = item["AdvanceReceived"].ToString();//
                    FinalBillListdataGridView.Rows[n].Cells[20].Value = item["TotalReceivable"].ToString();//




                }

            }
        }

        

        private void Addbutton_Click(object sender, EventArgs e)
        {
            idTextBox.Text = "";
            IPDSearchtextBox.Text = "";
            FinalpayDateDateTimePicker.Text = "";
            percentageTextBox.Text = "15";
            TaxAmttextBox.Text = "";
            ConcessionAmttextBox.Text = "";
            DocFeesAmttextBox.Text = "";
            MedicinesAmttextBox.Text = "";
            BloodAmttextBox.Text = "";
            OthrChrgAmtstextBox.Text = "";
            AdvanceAmttextBox.Text = "";
            ReceivablesAmttextBox.Text = "";
            PatientidTextBox.Text = "";
            PatNametextBox.Text = "";
            payModeComboBox.SelectedIndex = -1;
            BedAmtTextBox.Text = "";
            OtherAmttextBox.Text = "";
            taxNameComboBox.SelectedIndex = -1;
            DetailTotalAmttextBox.Text = "";
            TotAmttextBox.Text = "";
            ChargeableAmttextBox.Text = "";
            idTextBox.Focus();
            Display();

        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            idTextBox.Text = "";
            IPDSearchtextBox.Text = "";
            FinalpayDateDateTimePicker.Text = "";
            percentageTextBox.Text = "15";
            TaxAmttextBox.Text = "";
            ConcessionAmttextBox.Text = "";
            DocFeesAmttextBox.Text = "";
            MedicinesAmttextBox.Text = "";
            BloodAmttextBox.Text = "";
            OthrChrgAmtstextBox.Text = "";
            AdvanceAmttextBox.Text = "";
            ReceivablesAmttextBox.Text = "";
            PatientidTextBox.Text = "";
            PatNametextBox.Text = "";
            payModeComboBox.SelectedIndex = -1;
            BedAmtTextBox.Text = "";
            OtherAmttextBox.Text = "";
            taxNameComboBox.SelectedIndex = -1;
            DetailTotalAmttextBox.Text = "";
            TotAmttextBox.Text = "";
            ChargeableAmttextBox.Text = "";
            idTextBox.Focus();
            Display();
        }

        private void printbutton_Click(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load("Reports/FinalBillRep.rpt"); // Load your Crystal Report

         //   string connectionString = "Your_Connection_String"; // Replace with your connection string

            string query = @"
        SELECT
                BedManagement.Id AS BedId,
            BedManagement.Patient AS BedPatient,
            BedManagement.BedType,
            BedManagement.BedNo,
            BedManagement.FromDate AS BedFromDate,
            BedManagement.BedAmount,
            BedManagement.IPD AS BedIPD,
            BedManagement.Todate AS BedToDate,
            BedManagement.Days AS BedDays,
            BedManagement.Rate AS BedRate,
            BedManagement.DrName AS BedDrName,
    
            FinalBillHdr.Id AS BillId,
            FinalBillHdr.IPD AS BillIPD,
            FinalBillHdr.BillDate,
            FinalBillHdr.TaxRate,
            FinalBillHdr.TaxAmt,
            FinalBillHdr.Concession,
            FinalBillHdr.DrFees,
            FinalBillHdr.Medicine,
            FinalBillHdr.Blood,
            FinalBillHdr.OtherCharges,
            FinalBillHdr.AdvanceReceived,
            FinalBillHdr.TotalReceivable,
            FinalBillHdr.PatientID AS BillPatientID,
            FinalBillHdr.PatientName AS BillPatientName,
            FinalBillHdr.PayMode,
            FinalBillHdr.BedTAmt,
            FinalBillHdr.OtherTAmt,
            FinalBillHdr.TaxName,
            FinalBillHdr.DtlTAmt,
            FinalBillHdr.TotalAmt,
            FinalBillHdr.ChargableAmt,
    
            IPD.Id AS IPDId,
            IPD.Patient AS IPDPatient,
            IPD.Age,
            IPD.Height,
            IPD.Weight,
            IPD.BloodPressure,
            IPD.PrecheckedBy,
            IPD.AdmissionDate,
            IPD.Symptoms,
            IPD.GarName,
            IPD.GarRelation,
            IPD.GarPhone,
            IPD.GarAddress1,
            IPD.GarAddress2,
            IPD.GarCity,
            IPD.GarPIN,
            IPD.AdmitName,
            IPD.AdmitRelation,
            IPD.AdmitPhone,
            IPD.AdmitAddress1,
            IPD.AdmitAddress2,
            IPD.AdmitCity,
            IPD.AdmitPIN,
            IPD.PatID,
    
            FinalBillOtherAmount.FBOItemsId,
            FinalBillOtherAmount.FBOItemsPerticulars,
            FinalBillOtherAmount.FBOItemsAmt,
            FinalBillOtherAmount.FBOItemsTID
            FROM
                BedManagement
            INNER JOIN
                IPD ON BedManagement.IPD = IPD.Id
            INNER JOIN
                FinalBillHdr ON FinalBillHdr.IPD = IPD.Id
            INNER JOIN
                FinalBillOtherAmount ON FinalBillOtherAmount.FBOItemsTID = FinalBillHdr.Id
            WHERE
            FinalBillHdr.Id = @BillId";



            using (SqlConnection connection = new SqlConnection(connectionString)) 
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@BillId", idTextBox.Text); // Ensure the parameter name matches the SQL query

                // Create a SQL Data Adapter
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    // Create a DataSet to hold the data
                    HMSDataSet dataSet = new HMSDataSet();

                    connection.Open();
                    // Fill the DataSet with the data from the query
                    adapter.Fill(dataSet, "HMSDataSet");
                    connection.Close();

                    // Set the data source for the report
                    report.SetDataSource(dataSet);

                    // Set the Crystal Report Viewer's report source to the loaded report
                    //crystalReportViewer1.ReportSource = report;
                }
            }

            // Rest of your code for setting parameters and displaying the report seems fine
            // ...

            FinalBillRep fbr = new FinalBillRep();


            // fbr.SetDataSource(ds);
            //  FinalBillReportViewer.getfrm.Show();
            // FinalBillReportViewer.getfrm.crystalReportViewer1.ReportSource = fbr;

            FinalBillReportViewer view = new FinalBillReportViewer();
            fbr.SetParameterValue("FB_BILLNO", idTextBox.Text);
            fbr.SetParameterValue("FB_BILLDATE", FinalpayDateDateTimePicker.Text);
            fbr.SetParameterValue("FB_TAXAMT", TaxAmttextBox.Text);
            fbr.SetParameterValue("FB_CONCESSION", ConcessionAmttextBox.Text);
            fbr.SetParameterValue("FB_DRAMT", DocFeesAmttextBox.Text);
            fbr.SetParameterValue("FB_MEDAMT", MedicinesAmttextBox.Text);
            fbr.SetParameterValue("FB_BLOODAMT", BloodAmttextBox.Text);
            fbr.SetParameterValue("FB_OTHAMT", OthrChrgAmtstextBox.Text);
            fbr.SetParameterValue("FB_ADVREVAMT", AdvanceAmttextBox.Text);
            fbr.SetParameterValue("FB_PAYABLEAMT", ReceivablesAmttextBox.Text);
            fbr.SetParameterValue("FB_PATID", PatientidTextBox.Text);
            fbr.SetParameterValue("FB_PATNAME", PatNametextBox.Text);
            fbr.SetParameterValue("FB_TAXNAME", taxNameComboBox.Text);
            fbr.SetParameterValue("FB_DTLAMT", DetailTotalAmttextBox.Text);
            fbr.SetParameterValue("FB_TOTAMT", TotAmttextBox.Text);
            fbr.SetParameterValue("FB_CHARGEAMT", ChargeableAmttextBox.Text);
            fbr.SetParameterValue("FB_GENDER", PatGendertextBox.Text);
            fbr.SetParameterValue("FB_AGE", PatAgetextBox.Text);
            fbr.SetParameterValue("FB_GARNAME", GarNametextBox.Text);
            fbr.SetParameterValue("FB_ADDRESS1", Address1textBox.Text);
            fbr.SetParameterValue("FB_ADDRESS2", Address2textBox.Text);
            fbr.SetParameterValue("FB_CITY", CitytextBox.Text);
            fbr.SetParameterValue("FB_PIN", PINtextBox.Text);
            fbr.SetParameterValue("FB_ADMISSIONDT", AdmissiondateTimePicker.Text);
            fbr.SetParameterValue("FB_DISCHARGEDT", DischargedateTimePicker.Text);
            fbr.SetParameterValue("FB_UNDERDR", UnderDrtextBox.Text);
            fbr.SetParameterValue("FB_REFDR", RefDrtextBox.Text);



            view.crystalReportViewer1.ReportSource = fbr;
            view.Show();
        }


        private void FinalBillListdataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            

            idTextBox.Text                      = FinalBillListdataGridView.SelectedRows[0].Cells[0].Value.ToString();
            FinalpayDateDateTimePicker.Text     = FinalBillListdataGridView.SelectedRows[0].Cells[1].Value.ToString();
            PatientidTextBox.Text               = FinalBillListdataGridView.SelectedRows[0].Cells[2].Value.ToString();
            PatNametextBox.Text                 = FinalBillListdataGridView.SelectedRows[0].Cells[3].Value.ToString();
            payModeComboBox.Text                = FinalBillListdataGridView.SelectedRows[0].Cells[4].Value.ToString();
            IPDSearchtextBox.Text               = FinalBillListdataGridView.SelectedRows[0].Cells[5].Value.ToString();
            BedAmtTextBox.Text                  = FinalBillListdataGridView.SelectedRows[0].Cells[6].Value.ToString();
            OtherAmttextBox.Text                = FinalBillListdataGridView.SelectedRows[0].Cells[7].Value.ToString();
            DetailTotalAmttextBox.Text          = FinalBillListdataGridView.SelectedRows[0].Cells[8].Value.ToString();
            taxNameComboBox.Text                = FinalBillListdataGridView.SelectedRows[0].Cells[9].Value.ToString();
            percentageTextBox.Text              = FinalBillListdataGridView.SelectedRows[0].Cells[10].Value.ToString();
            TaxAmttextBox.Text                  = FinalBillListdataGridView.SelectedRows[0].Cells[11].Value.ToString();
            ConcessionAmttextBox.Text           = FinalBillListdataGridView.SelectedRows[0].Cells[12].Value.ToString();
            TotAmttextBox.Text                  = FinalBillListdataGridView.SelectedRows[0].Cells[13].Value.ToString();
            DocFeesAmttextBox.Text              = FinalBillListdataGridView.SelectedRows[0].Cells[14].Value.ToString();
            MedicinesAmttextBox.Text            = FinalBillListdataGridView.SelectedRows[0].Cells[15].Value.ToString();
            BloodAmttextBox.Text                = FinalBillListdataGridView.SelectedRows[0].Cells[16].Value.ToString();
            OthrChrgAmtstextBox.Text            = FinalBillListdataGridView.SelectedRows[0].Cells[17].Value.ToString();
            ChargeableAmttextBox.Text           = FinalBillListdataGridView.SelectedRows[0].Cells[18].Value.ToString();
            AdvanceAmttextBox.Text              = FinalBillListdataGridView.SelectedRows[0].Cells[19].Value.ToString();
            ReceivablesAmttextBox.Text          = FinalBillListdataGridView.SelectedRows[0].Cells[20].Value.ToString();




        }

        private void FinalpayDateDateTimePicker_ValueChanged_1(object sender, EventArgs e)
        {
           
        }

        private void FinalBillListdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DischargedateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void idTextBox_TextChanged(object sender, EventArgs e)
        {
            string fbid = idTextBox.Text;
            DataGridViewColumn fbidColumn = OtherItemsdataGridView.Columns["FBID"];

            if (fbidColumn != null)
            {
                foreach (DataGridViewRow row in OtherItemsdataGridView.Rows)
                {
                    row.Cells["FBID"].Value = fbid;
                }
            }


        }

        private int currentSlNo = 1;


        private void CalculateTotalAmount()
        {
            decimal totalAmount = 0;

            foreach (DataGridViewRow row in OtherItemsdataGridView.Rows)
            {
                if (decimal.TryParse(row.Cells["Amount"].Value?.ToString(), out decimal amount))
                {
                    totalAmount += amount;
                }
            }

           // OtherAmttextBox.Text = totalAmount.ToString("C");
            OtherAmttextBox.Text = totalAmount.ToString();
        }

        private void OtherItemsdataGridView_RowsAdded_1(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach (DataGridViewRow row in OtherItemsdataGridView.Rows)
            {
                row.Cells["SlNo"].Value = currentSlNo++;
            }
        }

        private void FinalBillListdataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = FinalBillListdataGridView.Rows[e.RowIndex];

                if (selectedRow != null && selectedRow.Cells["Id"].Value != null)
                {
                    string selectedId = selectedRow.Cells["Id"].Value.ToString();

                    // Fetch data from FinalBillOtherAmount based on the selected ID

                    using (SqlConnection con = new SqlConnection(connectionString))
                    //using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=HMS;Integrated Security=True"))
                    {
                        con.Open();

                        string fetchQuery = "SELECT FBOItemsId, FBOItemsPerticulars, FBOItemsAmt FROM FinalBillOtherAmount WHERE FBOItemsTID = @SelectedId";

                        using (SqlCommand fetchCmd = new SqlCommand(fetchQuery, con))
                        {
                            fetchCmd.Parameters.AddWithValue("@SelectedId", selectedId);

                            using (SqlDataReader reader = fetchCmd.ExecuteReader())
                            {
                                // Clear existing data in OtherItemsdataGridView
                                OtherItemsdataGridView.Rows.Clear();

                                while (reader.Read())
                                {
                                    // Retrieve data from the reader and add rows to OtherItemsdataGridView
                                    string itemId = reader["FBOItemsId"].ToString();
                                    string particulars = reader["FBOItemsPerticulars"].ToString();
                                    string amount = reader["FBOItemsAmt"].ToString();

                                    // Add the data to the OtherItemsdataGridView
                                    OtherItemsdataGridView.Rows.Add(selectedId, itemId, particulars, amount );
                                }
                            }
                            con.Close();
                        }
                    }
                }
            }
        }

       
    }



}
