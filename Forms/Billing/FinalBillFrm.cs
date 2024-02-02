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
using System.Web.UI.WebControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;
using HMS.Forms.Transaction.IPD;

namespace HMS.Forms.Billing
{
    public partial class FinalBillFrm : Form
    {
        

        string connectionString = ConfigurationManager.ConnectionStrings["HMS.Properties.Settings.HMSConnectionString"].ConnectionString;

        private DataTable dt = new DataTable();
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;

        public FinalBillFrm()
        {
            InitializeComponent();
            IPDSearchtextBox.TextChanged += IPDSearchtextBox_TextChanged;
           
        }      

        

        private void FinalBillFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet.BedManagement' table. You can move, or remove it, as needed.
            this.bedManagementTableAdapter.Fill(this.hMSDataSet.BedManagement);
            // TODO: This line of code loads data into the 'hMSDataSet.TaxMast' table. You can move, or remove it, as needed.
            //this.taxMastTableAdapter.Fill(this.hMSDataSet.TaxMast);
            // TODO: This line of code loads data into the 'hMSDataSet.TaxMast' table. You can move, or remove it, as needed.
            //   this.taxMastTableAdapter.Fill(this.hMSDataSet.TaxMast);
            // TODO: This line of code loads data into the 'hMSDataSet.IPD' table. You can move, or remove it, as needed.
            // this.iPDTableAdapter.Fill(this.hMSDataSet.IPD);
            // Display TaxName data in the taxNameComboBox
            DisplayTaxNames();
            Display();

        }

        private void DisplayTaxNames()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Assuming TaxMast table has a column named TaxName
                    string query = "SELECT TaxName FROM TaxMast";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            string taxName = reader["TaxName"].ToString();
                            taxNameComboBox.Items.Add(taxName);
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void bedManagementDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void IPDSearchtextBox_TextChanged(object sender, EventArgs e)
        {
            
            string searchText = IPDSearchtextBox.Text;

            using (SqlConnection con = new SqlConnection(connectionString))
            
            {
                string query = @"SELECT PatientMast.Id as PatientId, PatientMast.PatGender, IPD.Age, IPD.GarName, PatientMast.PatAddress1, 
                 PatientMast.PatAddress2, PatientMast.PatCity, PatientMast.PatPIN, 
                 PatientMast.PatUnderDr, PatientMast.PatRefferedBy, IPD.AdmissionDate, 
                 Discharge.DischargeDate, PatientMast.PatBalAmt, IPD.Patient, IPD.DispTotal
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
                            AdvanceAmttextBox.Text = reader["PatBalAmt"].ToString();
                            PatNametextBox.Text = reader["Patient"].ToString();
                            PatientidTextBox.Text = reader["PatientId"].ToString();
                            textBoxDissposableAmt.Text = reader["DispTotal"].ToString();


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
                                DischargedateTimePicker.Value = DateTime.Now;
                            }
                        }

                        reader.Close();

                        


                        string ipdSearchValue = IPDSearchtextBox.Text;

                        // Use parameterized query to prevent SQL injection
                        string bedManagementQuery = "SELECT * FROM BedManagement WHERE IPD = @ipdSearchValue";
                        

                        // Use using statement for IDisposable objects like SqlDataAdapter
                        using (SqlDataAdapter adapter = new SqlDataAdapter(bedManagementQuery, con))
                        {
                            // Use SqlParameter to avoid SQL injection and improve security
                            adapter.SelectCommand.Parameters.AddWithValue("@ipdSearchValue", ipdSearchValue);

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

                        // Fetch Advance Ids from Advance table based on PatID
                        string advanceQuery = "SELECT Id FROM Advance WHERE PatID = @patId";
                        using (SqlCommand advanceCommand = new SqlCommand(advanceQuery, con))
                        {
                            advanceCommand.Parameters.AddWithValue("@patId", ipdSearchValue);

                            SqlDataReader advanceReader = advanceCommand.ExecuteReader();

                            List<string> advanceIdsList = new List<string>();

                            while (advanceReader.Read())
                            {
                                advanceIdsList.Add(advanceReader["Id"].ToString());
                            }

                            advanceReader.Close();

                            // Concatenate Advance Ids with comma separator
                            string advanceIdsString = string.Join(", ", advanceIdsList);

                            // Display the result in textBoxAdvIds
                            textBoxAdvIds.Text = advanceIdsString;
                        }


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
            UpdateDTotalAmount();
        }

        private void bedManagementDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void OtherItemsdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OtherItemsdataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) // Ensure the cell changed is within the grid
            {
                if (OtherItemsdataGridView.Columns[e.ColumnIndex].Name == "FBOItemsAmt")
                {
                    decimal total = 0;

                    foreach (DataGridViewRow row in OtherItemsdataGridView.Rows)
                    {
                        if (row.Cells["FBOItemsAmt"].Value != null && !string.IsNullOrEmpty(row.Cells["FBOItemsAmt"].Value.ToString()))
                        {
                            decimal value = 0;
                            if (decimal.TryParse(row.Cells["FBOItemsAmt"].Value.ToString(), out value))
                            {
                                total += value;
                            }
                        }
                    }

                    OtherAmttextBox.Text = total.ToString();

                    // Assuming idTextBox is a TextBox control on your form
                    string billNoValue = idTextBox.Text;

                    // Assuming dataGridViewDocChrg is the name of your DataGridView
                    if (!string.IsNullOrEmpty(billNoValue) && dataGridViewDocChrg.Columns["FBOItemsTID"] != null)
                    {
                        // Choose the row index you want to update
                        int targetRowIndex = 0; // Change this to the desired row index

                        // Check if the target row index is within the valid range
                        if (targetRowIndex >= 0 && targetRowIndex < dataGridViewDocChrg.Rows.Count)
                        {
                            // Set the value of "FBOItemsTID" column in the specified row
                            dataGridViewDocChrg.Rows[targetRowIndex].Cells["FBOItemsTID"].Value = billNoValue;
                        }
                        else
                        {
                            // Handle the case where the target row index is out of range
                            MessageBox.Show("Invalid row index in dataGridViewDocChrg.");
                        }
                    }

                }
            }
        }






        private void OtherItemsdataGridView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            UpdateTotalAmt();
            UpdateReceivablesAmt();
        }

        private void OtherAmttextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalAmt();
            UpdateReceivablesAmt();
            UpdateDTotalAmount();
        }

        private void UpdateDTotalAmount()
        {
            // Parse values from BedAmtTextBox and OtherAmttextBox
            if (decimal.TryParse(BedAmtTextBox.Text, out decimal bedAmount) &&
                decimal.TryParse(OtherAmttextBox.Text, out decimal otherAmount))
            {
                // Calculate the sum and display it in DetailTotalAmttextBox
                decimal totalAmount = bedAmount + otherAmount;
                DetailTotalAmttextBox.Text = totalAmount.ToString(); // Assuming the amounts are in currency format
            }
            else
            {
                // Handle the case where parsing fails or one of the values is not a valid decimal
                DetailTotalAmttextBox.Text = "0";
            }
        }

        private void UpdateTotalAmt()
        {
            // Parse values from BedAmtTextBox and OtherAmttextBox
            if (decimal.TryParse(BedAmtTextBox.Text, out decimal bedAmount) &&
                decimal.TryParse(OtherAmttextBox.Text, out decimal otherAmount) &&
                decimal.TryParse(textBoxDissposableAmt.Text, out decimal DissposableAmount))
            {
                // Calculate total amount
                decimal totalAmount = bedAmount + otherAmount + + DissposableAmount;

                // Display the total amount in DetailTotalAmttextBox
                DetailTotalAmttextBox.Text = totalAmount.ToString();
            }
            else
            {
                // Handle invalid input if needed
                DetailTotalAmttextBox.Text = "0";
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
                    TaxAmttextBox.Text = "0";
                }
            }
            else
            {
                // Handle invalid percentage rate if needed
                TaxAmttextBox.Text = "0";
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
                TotAmttextBox.Text = "0";
            }
        }

        private void TotAmttextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateTotAmt();
            UpdateReceivablesAmt();
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
                ChargeableAmttextBox.Text = "0";
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
                ReceivablesAmttextBox.Text = "0";
            }
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            idTextBox.ReadOnly = false;
            using (SqlConnection con = new SqlConnection(connectionString))
           
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
                                                    "DtlTAmt = @DtlTAmt, TotalAmt = @TotalAmt, ChargableAmt = @ChargableAmt, DissposableAmt = @DissposableAmt " +
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
                                updateCmd.Parameters.AddWithValue("@DissposableAmt", textBoxDissposableAmt.Text);
                                // Add other parameters...

                                updateCmd.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            // Insert a new record
                            using (SqlCommand cmdHeader = new SqlCommand("INSERT INTO FinalBillHdr (Id, IPD, BillDate, TaxRate, TaxAmt, Concession, DrFees, Medicine, Blood, OtherCharges, AdvanceReceived, TotalReceivable, PatientID, PatientName, PayMode, BedTAmt, OtherTAmt, TaxName, DtlTAmt, TotalAmt, ChargableAmt, DissposableAmt) " +
                                "VALUES (@Id, @IPD, @BillDate, @TaxRate, @TaxAmt, @Concession, @DrFees, @Medicine, @Blood, @OtherCharges, @AdvanceReceived, @TotalReceivable, @PatientID, @PatientName, @PayMode, @BedTAmt, @OtherTAmt, @TaxName, @DtlTAmt, @TotalAmt, @ChargableAmt, @DissposableAmt)", con))
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
                                cmdHeader.Parameters.AddWithValue("@DissposableAmt", textBoxDissposableAmt.Text);
                                // Add other parameters...

                                cmdHeader.ExecuteNonQuery();
                            }
                        }
                    }

                    string clearQuery = "DELETE FROM FinalBillOtherAmount WHERE FBOItemsTID = @idTextBox";
                    using (SqlCommand clearCmd = new SqlCommand(clearQuery, con))
                    {
                        clearCmd.Parameters.AddWithValue("@idTextBox", idTextBox.Text);
                        clearCmd.ExecuteNonQuery();
                    }

                    string clearQueryA = "DELETE FROM FinalBillDr WHERE FBDBILLNO = @idTextBox";
                    using (SqlCommand clearCmd = new SqlCommand(clearQueryA, con))
                    {
                        clearCmd.Parameters.AddWithValue("@idTextBox", idTextBox.Text);
                        clearCmd.ExecuteNonQuery();
                    }

                    // Your existing loop to insert data into FinalBillOtherAmount table
                    foreach (DataGridViewRow row in OtherItemsdataGridView.Rows)
                    {
                        if (!row.IsNewRow)
                        {

                            
                            string oiParticulars = Convert.ToString(row.Cells["FBOItemsPerticulars"].Value);
                            string oiAmountStr = Convert.ToString(row.Cells["FBOItemsAmt"].Value);

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

                    // Save data from dataGridViewDocChrg to FinalBillDr table
                    foreach (DataGridViewRow row in dataGridViewDocChrg.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            string billNo = Convert.ToString(row.Cells["BillNo"].Value);
                            string DrDate = Convert.ToString(row.Cells["DrDate"].Value);
                            string doctor = Convert.ToString(row.Cells["Doctor"].Value);
                            string docAmountStr = Convert.ToString(row.Cells["DocAmount"].Value);

                            if (!string.IsNullOrWhiteSpace(doctor) && !string.IsNullOrWhiteSpace(docAmountStr))
                            {
                                decimal docAmount = Convert.ToDecimal(docAmountStr);

                                // Assuming idTextBox contains the BillNo value
                                string billNoValue = idTextBox.Text;

                                // Insert data into FinalBillDr table
                                string insertDrQuery = "INSERT INTO FinalBillDr (FBDBILLNO, FBDDRDT, FBDDR, FBDAMT) " +
                                                        "VALUES (@BillNo, @DrDate, @Doctor, @DocAmount)";

                                using (SqlCommand cmdDr = new SqlCommand(insertDrQuery, con))
                                {
                                    cmdDr.Parameters.AddWithValue("@BillNo", billNoValue);
                                    cmdDr.Parameters.AddWithValue("@DrDate", DrDate);
                                    cmdDr.Parameters.AddWithValue("@Doctor", doctor);
                                    cmdDr.Parameters.AddWithValue("@DocAmount", docAmount);

                                    cmdDr.ExecuteNonQuery();
                                }
                            }
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

                idTextBox.Text = "";
                IPDSearchtextBox.Text = "RNH/";
                FinalpayDateDateTimePicker.Value = DateTime.Now;
                percentageTextBox.Text = "15";
                TaxAmttextBox.Text = "0.00";
                ConcessionAmttextBox.Text = "0.00";
                DocFeesAmttextBox.Text = "0.00";
                MedicinesAmttextBox.Text = "0.00";
                BloodAmttextBox.Text = "0.00";
                OthrChrgAmtstextBox.Text = "0.00";
                AdvanceAmttextBox.Text = "0.00";
                ReceivablesAmttextBox.Text = "0.00";
                PatientidTextBox.Text = "";
                PatNametextBox.Text = "";
                payModeComboBox.SelectedIndex = -1;
                BedAmtTextBox.Text = "0.00";
                OtherAmttextBox.Text = "0.00";
                taxNameComboBox.SelectedIndex = -1;
                DetailTotalAmttextBox.Text = "0.00";
                TotAmttextBox.Text = "0.00";
                ChargeableAmttextBox.Text = "0.00";
                textBoxDissposableAmt.Text = "0.00";
                percentageTextBox.Text = "15";
                PatGendertextBox.Text = "";
                PatAgetextBox.Text = "";
                GarNametextBox.Text = "";
                Address1textBox.Text = "";
                Address2textBox.Text = "";
                CitytextBox.Text = "";
                PINtextBox.Text = "";
                UnderDrtextBox.Text = "";
                AdmissiondateTimePicker.Value = DateTime.Now;
                DischargedateTimePicker.Value = DateTime.Now;
                idTextBox.Focus();
                Display(); // Assuming Display() method refreshes the form or display data
            }
            OtherItemsdataGridView.Rows.Clear();
            dataGridViewDocChrg.Rows.Clear();
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
                    FinalBillListdataGridView.Rows[n].Cells[21].Value = item["DissposableAmt"].ToString();




                }

            }
        }

        

        

        private void printbutton_Click(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load("Reports/FinalBillRep.rpt"); // Load your Crystal Report

            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in OtherItemsdataGridView.Columns)
            {
                dt.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in OtherItemsdataGridView.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }

            

            report.Subreports[0].DataSourceConnections.Clear();
            report.Subreports[0].SetDataSource(bedManagementDataGridView.DataSource);

            report.Subreports[1].DataSourceConnections.Clear();
            report.Subreports[1].SetDataSource(dt);

            FinalBillRep fbr = new FinalBillRep();


            

            FinalBillReportViewer view = new FinalBillReportViewer();
            report.SetParameterValue("FB_BILLNO", idTextBox.Text);
            report.SetParameterValue("FB_BILLDATE", FinalpayDateDateTimePicker.Text);
            report.SetParameterValue("FB_TAXAMT", TaxAmttextBox.Text);
            report.SetParameterValue("FB_CONCESSION", ConcessionAmttextBox.Text);
            report.SetParameterValue("FB_DRAMT", DocFeesAmttextBox.Text);
            report.SetParameterValue("FB_MEDAMT", MedicinesAmttextBox.Text);
            report.SetParameterValue("FB_BLOODAMT", BloodAmttextBox.Text);
            report.SetParameterValue("FB_OTHAMT", OthrChrgAmtstextBox.Text);
            report.SetParameterValue("FB_ADVREVAMT", AdvanceAmttextBox.Text);
            report.SetParameterValue("FB_PAYABLEAMT", ReceivablesAmttextBox.Text);
            report.SetParameterValue("FB_PATID", PatientidTextBox.Text);
            report.SetParameterValue("FB_PATNAME", PatNametextBox.Text);
            report.SetParameterValue("FB_TAXNAME", taxNameComboBox.Text);
            report.SetParameterValue("FB_DTLAMT", DetailTotalAmttextBox.Text);
            report.SetParameterValue("FB_TOTAMT", TotAmttextBox.Text);
            report.SetParameterValue("FB_CHARGEAMT", ChargeableAmttextBox.Text);
            report.SetParameterValue("FB_GENDER", PatGendertextBox.Text);
            report.SetParameterValue("FB_AGE", PatAgetextBox.Text);
            report.SetParameterValue("FB_GARNAME", GarNametextBox.Text);
            report.SetParameterValue("FB_ADDRESS1", Address1textBox.Text);
            report.SetParameterValue("FB_ADDRESS2", Address2textBox.Text);
            report.SetParameterValue("FB_CITY", CitytextBox.Text);
            report.SetParameterValue("FB_PIN", PINtextBox.Text);
            report.SetParameterValue("FB_ADMISSIONDT", AdmissiondateTimePicker.Text);
            report.SetParameterValue("FB_DISCHARGEDT", DischargedateTimePicker.Text);
            report.SetParameterValue("FB_UNDERDR", UnderDrtextBox.Text);
            report.SetParameterValue("FB_REFDR", RefDrtextBox.Text);
            report.SetParameterValue("FB_DISPAMT", textBoxDissposableAmt.Text);
            report.SetParameterValue("FB_PO", textBoxPO.Text);
            report.SetParameterValue("FB_PS", textBoxPS.Text);
            report.SetParameterValue("FB_COUNTRY", textBoxCountry.Text);
            report.SetParameterValue("FB_ADVIDS", textBoxAdvIds.Text);




            // Check if the ConcessionAmttextBox value is 0 or null
            decimal concessionAmount = 0;
            if (!string.IsNullOrEmpty(ConcessionAmttextBox.Text))
            {
                decimal.TryParse(ConcessionAmttextBox.Text, out concessionAmount);
            }

            // Set the visibility of Crystal Report fields based on the concession amount
            report.ReportDefinition.ReportObjects["Text27"].ObjectFormat.EnableSuppress = (concessionAmount == 0);
            report.ReportDefinition.ReportObjects["FBCONCESSION1"].ObjectFormat.EnableSuppress = (concessionAmount == 0);



            view.crystalReportViewer1.ReportSource = report;
            view.Show();
        }


        private void FinalBillListdataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            idTextBox.ReadOnly = true;

            idTextBox.Text                      = FinalBillListdataGridView.SelectedRows[0].Cells[0].Value.ToString();
            FinalpayDateDateTimePicker.Text     = FinalBillListdataGridView.SelectedRows[0].Cells[1].Value.ToString();
            PatientidTextBox.Text               = FinalBillListdataGridView.SelectedRows[0].Cells[2].Value.ToString();
            PatNametextBox.Text                 = FinalBillListdataGridView.SelectedRows[0].Cells[3].Value.ToString();
            payModeComboBox.Text                = FinalBillListdataGridView.SelectedRows[0].Cells[4].Value.ToString();
            IPDSearchtextBox.Text               = FinalBillListdataGridView.SelectedRows[0].Cells[5].Value.ToString();
          //  BedAmtTextBox.Text                  = FinalBillListdataGridView.SelectedRows[0].Cells[6].Value.ToString();
            OtherAmttextBox.Text                = FinalBillListdataGridView.SelectedRows[0].Cells[7].Value.ToString();
            DetailTotalAmttextBox.Text          = FinalBillListdataGridView.SelectedRows[0].Cells[8].Value.ToString();
            taxNameComboBox.Text                = FinalBillListdataGridView.SelectedRows[0].Cells[9].Value.ToString();
            percentageTextBox.Text              = FinalBillListdataGridView.SelectedRows[0].Cells[10].Value.ToString();
            TaxAmttextBox.Text                  = FinalBillListdataGridView.SelectedRows[0].Cells[11].Value.ToString();
            ConcessionAmttextBox.Text           = FinalBillListdataGridView.SelectedRows[0].Cells[12].Value.ToString();
            TotAmttextBox.Text                  = FinalBillListdataGridView.SelectedRows[0].Cells[13].Value.ToString();
            DocFeesAmttextBox.Text              = FinalBillListdataGridView.SelectedRows[0].Cells[14].Value.ToString();
            textBoxDocTot.Text                  = FinalBillListdataGridView.SelectedRows[0].Cells[14].Value.ToString();
            MedicinesAmttextBox.Text            = FinalBillListdataGridView.SelectedRows[0].Cells[15].Value.ToString();
            BloodAmttextBox.Text                = FinalBillListdataGridView.SelectedRows[0].Cells[16].Value.ToString();
            OthrChrgAmtstextBox.Text            = FinalBillListdataGridView.SelectedRows[0].Cells[17].Value.ToString();
            ChargeableAmttextBox.Text           = FinalBillListdataGridView.SelectedRows[0].Cells[18].Value.ToString();
            AdvanceAmttextBox.Text              = FinalBillListdataGridView.SelectedRows[0].Cells[19].Value.ToString();
            ReceivablesAmttextBox.Text          = FinalBillListdataGridView.SelectedRows[0].Cells[20].Value.ToString();
            textBoxDissposableAmt.Text          = FinalBillListdataGridView.SelectedRows[0].Cells[21].Value.ToString();

            // Fetch data from FinalBillOtherAmount based on idTextBox
            string query = "SELECT FBOItemsTID, FBOItemsId, FBOItemsPerticulars, FBOItemsAmt " +
                           "FROM FinalBillOtherAmount " +
                           "WHERE FBOItemsTID = @FBOItemsTID";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@FBOItemsTID", idTextBox.Text);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Clear existing rows in OtherItemsdataGridView
                        OtherItemsdataGridView.Rows.Clear();

                        // Populate OtherItemsdataGridView with data from the database
                        while (reader.Read())
                        {
                            OtherItemsdataGridView.Rows.Add(
                                reader["FBOItemsTID"].ToString(),
                                reader["FBOItemsId"].ToString(),
                                reader["FBOItemsPerticulars"].ToString(),
                                reader["FBOItemsAmt"].ToString()
                            );
                        }
                    }
                }
            }



            // Fetch data from dataGridViewDocChrg based on idTextBox
            string querya = "SELECT FBDBILLNO, FBDDRDT, FBDDR, FBDAMT " +
                           "FROM FinalBillDr " +
                           "WHERE FBDBILLNO = @FBDBILLNO";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand command = new SqlCommand(querya, con))
                {
                    command.Parameters.AddWithValue("@FBDBILLNO", idTextBox.Text);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Clear existing rows in dataGridViewDocChrg
                        dataGridViewDocChrg.Rows.Clear();

                        // Populate dataGridViewDocChrg with data from the database
                        while (reader.Read())
                        {
                            dataGridViewDocChrg.Rows.Add(
                                reader["FBDBILLNO"].ToString(),
                                reader["FBDDRDT"].ToString(),
                                reader["FBDDR"].ToString(),
                                reader["FBDAMT"].ToString()
                            );
                        }
                    }
                }
            }

        }

        // Method to fetch data from the FinalBillOtherAmount table based on ID
        


        private void FinalpayDateDateTimePicker_ValueChanged_1(object sender, EventArgs e)
        {
            FinalpayDateDateTimePicker.CustomFormat = "dd-MM-yyyy HH:mm:ss";
        }

        private void FinalBillListdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DischargedateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DischargedateTimePicker.CustomFormat = "dd-MM-yyyy HH:mm:ss";
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
                row.Cells["FBOItemsId"].Value = currentSlNo++;
                row.Cells["FBOItemsTID"].Value = idTextBox.Text;
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

        private void PatientidTextBox_TextChanged(object sender, EventArgs e)
        {
            // Assuming you have a SqlConnection named "sqlConnection"
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // Replace "YourTableName" with the actual table name
                string query = "SELECT PatPO, PatPS, PatCountry FROM PatientMast WHERE Id = @PatientId";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    con.Open();

                    // Assuming "Id" is an integer. If it's a different data type, adjust accordingly.
                    if (int.TryParse(PatientidTextBox.Text, out int patientId))
                    {
                        command.Parameters.AddWithValue("@PatientId", patientId);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Replace "YourColumnNames" with the actual column names
                                textBoxPO.Text = reader["PatPO"].ToString();
                                textBoxPS.Text = reader["PatPS"].ToString();
                                textBoxCountry.Text = reader["PatCountry"].ToString();
                            }
                            else
                            {
                                // Handle the case when no matching record is found
                                textBoxPO.Text = string.Empty;
                                textBoxPS.Text = string.Empty;
                                textBoxCountry.Text = string.Empty;
                            }
                        }
                    }
                    else
                    {
                        // Handle the case when the entered text is not a valid integer
                        textBoxPO.Text = string.Empty;
                        textBoxPS.Text = string.Empty;
                        textBoxCountry.Text = string.Empty;
                    }
                }
            }
        }


        private void buttonEstimation_Click(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load("Reports/EstimationRpt.rpt"); // Load your Crystal Report

            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in OtherItemsdataGridView.Columns)
            {
                dt.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in OtherItemsdataGridView.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }



            report.Subreports[0].DataSourceConnections.Clear();
            report.Subreports[0].SetDataSource(bedManagementDataGridView.DataSource);

            report.Subreports[1].DataSourceConnections.Clear();
            report.Subreports[1].SetDataSource(dt);

            EstimationRpt fbr = new EstimationRpt();




            EstimationViewer view = new EstimationViewer();
            report.SetParameterValue("FB_BILLNO", idTextBox.Text);
            report.SetParameterValue("FB_BILLDATE", FinalpayDateDateTimePicker.Text);
            report.SetParameterValue("FB_TAXAMT", TaxAmttextBox.Text);
            report.SetParameterValue("FB_CONCESSION", ConcessionAmttextBox.Text);
            report.SetParameterValue("FB_DRAMT", DocFeesAmttextBox.Text);
            report.SetParameterValue("FB_MEDAMT", MedicinesAmttextBox.Text);
            report.SetParameterValue("FB_BLOODAMT", BloodAmttextBox.Text);
            report.SetParameterValue("FB_OTHAMT", OthrChrgAmtstextBox.Text);
            report.SetParameterValue("FB_ADVREVAMT", AdvanceAmttextBox.Text);
            report.SetParameterValue("FB_PAYABLEAMT", ReceivablesAmttextBox.Text);
            report.SetParameterValue("FB_PATID", PatientidTextBox.Text);
            report.SetParameterValue("FB_PATNAME", PatNametextBox.Text);
            report.SetParameterValue("FB_TAXNAME", taxNameComboBox.Text);
            report.SetParameterValue("FB_DTLAMT", DetailTotalAmttextBox.Text);
            report.SetParameterValue("FB_TOTAMT", TotAmttextBox.Text);
            report.SetParameterValue("FB_CHARGEAMT", ChargeableAmttextBox.Text);
            report.SetParameterValue("FB_GENDER", PatGendertextBox.Text);
            report.SetParameterValue("FB_AGE", PatAgetextBox.Text);
            report.SetParameterValue("FB_GARNAME", GarNametextBox.Text);
            report.SetParameterValue("FB_ADDRESS1", Address1textBox.Text);
            report.SetParameterValue("FB_ADDRESS2", Address2textBox.Text);
            report.SetParameterValue("FB_CITY", CitytextBox.Text);
            report.SetParameterValue("FB_PIN", PINtextBox.Text);
            report.SetParameterValue("FB_ADMISSIONDT", AdmissiondateTimePicker.Text);
            report.SetParameterValue("FB_DISCHARGEDT", DischargedateTimePicker.Text);
            report.SetParameterValue("FB_UNDERDR", UnderDrtextBox.Text);
            report.SetParameterValue("FB_REFDR", RefDrtextBox.Text);
            report.SetParameterValue("FB_DISPAMT", textBoxDissposableAmt.Text);
            report.SetParameterValue("FB_PO", textBoxPO.Text);
            report.SetParameterValue("FB_PS", textBoxPS.Text);
            report.SetParameterValue("FB_COUNTRY", textBoxCountry.Text);
            report.SetParameterValue("FB_ADVIDS", textBoxAdvIds.Text);


            // Check if the ConcessionAmttextBox value is 0 or null
            decimal concessionAmount = 0;
            if (!string.IsNullOrEmpty(ConcessionAmttextBox.Text))
            {
                decimal.TryParse(ConcessionAmttextBox.Text, out concessionAmount);
            }

            // Set the visibility of Crystal Report fields based on the concession amount
            report.ReportDefinition.ReportObjects["Text27"].ObjectFormat.EnableSuppress = (concessionAmount == 0);
            report.ReportDefinition.ReportObjects["FBCONCESSION1"].ObjectFormat.EnableSuppress = (concessionAmount == 0);




            view.crystalReportViewer2.ReportSource = report;
            view.Show();
        }

        private void textBoxDissposableAmt_TextChanged(object sender, EventArgs e)
        {
            UpdateReceivablesAmt();
            UpdateChargeableAmt();
        }

       

        private void buttonDel_Click(object sender, EventArgs e)
        {
            // Ensure that the user has selected a row in the FinalBillListdataGridView
            if (FinalBillListdataGridView.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = FinalBillListdataGridView.SelectedRows[0];

                // Retrieve the values from the DataGridView
                string idToDelete = selectedRow.Cells["Id"].Value.ToString();
                string ipd = selectedRow.Cells["IPD"].Value.ToString();
                string patientId = selectedRow.Cells["PatientID"].Value.ToString();

                // Prompt the user to confirm the deletion
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                   // Assuming you have a method to update PatientMast.PatBalAmt
                    UpdatePatientBalance(ipd, patientId);

                    // Assuming you have a method to delete the record
                    DeleteRecord(idToDelete);
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                        // Delete from DischargeLin table first
                        using (SqlCommand cmdDischargeLin = new SqlCommand("DELETE FROM FinalBillOtherAmount WHERE FBOItemsTID = @Id", con, transaction))
                        {
                            cmdDischargeLin.Parameters.AddWithValue("@Id", idToDelete);
                            cmdDischargeLin.ExecuteNonQuery();
                        }


                        // Delete from DischargeLin table first
                        using (SqlCommand cmdDischargeLin = new SqlCommand("DELETE FROM FinalBillDr WHERE FBDBILLNO = @Id", con, transaction))
                        {
                            cmdDischargeLin.Parameters.AddWithValue("@Id", idToDelete);
                            cmdDischargeLin.ExecuteNonQuery();
                        }


                        // Then delete from Discharge table
                        using (SqlCommand cmdDischarge = new SqlCommand("DELETE FROM FinalBillHdr WHERE Id = @Id", con, transaction))
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

        private void buttonIPD_Click(object sender, EventArgs e)
        {
            IPDFrm myForm = new IPDFrm();

            myForm.ShowDialog();
        }

        private void dataGridViewDocChrg_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = dataGridViewDocChrg.Columns[e.ColumnIndex].Name;

                if (columnName == "DocAmount")
                {
                    UpdateTotal();
                }
                else if (columnName == "Doctor")
                {
                    // Handle live search for the "Doctor" column
                    AutoFillDoctorName(dataGridViewDocChrg.Rows[e.RowIndex]);
                }
            }
        }

        private void AutoFillDoctorName(DataGridViewRow row)
        {
            string partialInput = row.Cells["Doctor"].Value?.ToString();

            if (!string.IsNullOrEmpty(partialInput))
            {
                // Fetch matching doctor names from the database
                List<string> matchingDoctorNames = GetMatchingDoctorNames(partialInput);

                // Display the matching names in a dropdown or set the value based on your UI choice
                // Here, I'll just set the value to the first matching name (if any)
                if (matchingDoctorNames.Count > 0)
                {
                    row.Cells["Doctor"].Value = matchingDoctorNames[0];
                }
            }
        }

        private List<string> GetMatchingDoctorNames(string partialInput)
        {
            // Replace the following code with your actual database retrieval logic
            List<string> matchingDoctorNames = new List<string>();

            // Assuming you have a connection object named "connection" and a command object named "command"
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand command = new SqlCommand("SELECT DocName FROM DoctorMast WHERE DocName LIKE @PartialInput", con))
                {
                    command.Parameters.AddWithValue("@PartialInput", "%" + partialInput + "%");

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            matchingDoctorNames.Add(reader["DocName"].ToString());
                        }
                    }
                }
            }

            return matchingDoctorNames;
        }

        private void UpdateTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dataGridViewDocChrg.Rows)
            {
                if (row.Cells["DocAmount"].Value != null && !string.IsNullOrEmpty(row.Cells["DocAmount"].Value.ToString()))
                {
                    decimal value = 0;
                    if (decimal.TryParse(row.Cells["DocAmount"].Value.ToString(), out value))
                    {
                        total += value;
                    }
                }
            }

            textBoxDocTot.Text = total.ToString();
            DocFeesAmttextBox.Text = total.ToString();
        }

        private void dataGridViewDocChrg_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewDocChrg.Rows)
            {
                row.Cells["BillNo"].Value = idTextBox.Text;
            }
        }

        private void buttonPrintDrChrgs_Click(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load("Reports/FinalBillDr.rpt"); // Load your Crystal Report

            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in dataGridViewDocChrg.Columns)
            {
                dt.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in dataGridViewDocChrg.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }


            ShowDataTableValues(dt);

            report.Subreports[0].DataSourceConnections.Clear();
            report.Subreports[0].SetDataSource(dataGridViewDocChrg.DataSource);

            //report.Subreports[0].DataSourceConnections.Clear();
            //report.Subreports[0].SetDataSource(dt);
           
            FinalBillDr fbr = new FinalBillDr();

            FinalBillDrViewer view = new FinalBillDrViewer();
            report.SetParameterValue("FB_BILLNO", idTextBox.Text);
            report.SetParameterValue("FB_BILLDATE", FinalpayDateDateTimePicker.Text);
            report.SetParameterValue("FB_IPD", IPDSearchtextBox.Text);
            report.SetParameterValue("FB_PATNAME", PatNametextBox.Text);
            report.SetParameterValue("FB_GENDER", PatGendertextBox.Text);
            report.SetParameterValue("FB_AGE", PatAgetextBox.Text);
         


            view.crystalReportViewer1.ReportSource = report;
            view.Show();
        }

        private void AdmissiondateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            AdmissiondateTimePicker.CustomFormat = "dd-MM-yyyy HH:mm:ss";
        }

        private void ShowDataTableValues(DataTable dt)
        {
            StringBuilder message = new StringBuilder();

            // Display column names
            message.AppendLine("Column Names:");
            foreach (DataColumn column in dt.Columns)
            {
                message.Append(column.ColumnName).Append("\t");
            }
            message.AppendLine();

            // Display data rows
            message.AppendLine("Data Rows:");
            foreach (DataRow row in dt.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    message.Append(item.ToString()).Append("\t");
                }
                message.AppendLine();
            }

            MessageBox.Show(message.ToString(), "DataTable Values");
        }

    }
}
