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
using System.Configuration;
using HMS.Forms.Transaction.IPD;

namespace HMS.Forms.Transaction
{
    public partial class BedMangFrm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["HMS.Properties.Settings.HMSConnectionString"].ConnectionString;
        
        public BedMangFrm()
        {
            InitializeComponent();
        }

        private void BedMangFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet.DoctorMast' table. You can move, or remove it, as needed.
            this.doctorMastTableAdapter.Fill(this.hMSDataSet.DoctorMast);
            // TODO: This line of code loads data into the 'hMSDataSet.DoctorDepartmentMast' table. You can move, or remove it, as needed.
            this.doctorDepartmentMastTableAdapter.Fill(this.hMSDataSet.DoctorDepartmentMast);
            // TODO: This line of code loads data into the 'hMSDataSet.BedManagement' table. You can move, or remove it, as needed.
            //this.bedManagementTableAdapter.Fill(this.hMSDataSet.BedManagement);
            // TODO: This line of code loads data into the 'hMSDataSet.BedNumberMast' table. You can move, or remove it, as needed.
            this.bedNumberMastTableAdapter.Fill(this.hMSDataSet.BedNumberMast);
            // TODO: This line of code loads data into the 'hMSDataSet.BedTypeMast' table. You can move, or remove it, as needed.
            this.bedTypeMastTableAdapter.Fill(this.hMSDataSet.BedTypeMast);
            Display();
           // idTextBox.Text = string.Empty;
            IPDSearchtextBox.Text = "RNH/";
            PatientNametextBox.Text = string.Empty;
            GendertextBox.Text = string.Empty;
            AgetextBox.Text = string.Empty;
            DoctorNameComboBox.SelectedIndex = -1;
            AdmissiondateTimePicker.Value = DateTime.Now; // Set to desired default date or leave as is
            FromDtDateTimePicker.Value = DateTime.Now; // Set to desired default date or leave as is
            bedTypeComboBox.SelectedIndex = -1;
            bedNoComboBox.SelectedIndex = -1;
            ToDtdateTimePicker.Value = DateTime.Now; // Set to desired default date or leave as is
            DaystextBox.Text = "0";
            BedRateTextBox.Text = "0";
            BedAmounttextBox.Text = "0";
            idTextBox.Text = GetNextAvailableId().ToString();
        }

        void Display()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                
                SqlDataAdapter sda = new SqlDataAdapter("Select * from BedManagement ORDER BY Id DESC", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BedManagedataGridView.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {

                    int n = BedManagedataGridView.Rows.Add();

                    BedManagedataGridView.Rows[n].Cells[0].Value = item["Id"].ToString();
                    BedManagedataGridView.Rows[n].Cells[1].Value = item["IPD"].ToString();
                    BedManagedataGridView.Rows[n].Cells[2].Value = item["Patient"].ToString();
                    BedManagedataGridView.Rows[n].Cells[3].Value = item["DrName"].ToString();
                    BedManagedataGridView.Rows[n].Cells[4].Value = item["FromDate"].ToString();
                    BedManagedataGridView.Rows[n].Cells[5].Value = item["BedType"].ToString();
                    BedManagedataGridView.Rows[n].Cells[6].Value = item["BedNo"].ToString();
                    BedManagedataGridView.Rows[n].Cells[7].Value = item["Todate"].ToString();
                    BedManagedataGridView.Rows[n].Cells[8].Value = item["Days"].ToString();
                    BedManagedataGridView.Rows[n].Cells[9].Value = item["Rate"].ToString();
                    BedManagedataGridView.Rows[n].Cells[10].Value = item["BedAmount"].ToString();

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
                string query = @"SELECT IPD.Patient, PatientMast.PatGender, IPD.Age, IPD.AdmissionDate
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
                            if (reader["Patient"] != DBNull.Value)
                            {
                                PatientNametextBox.Text = reader["Patient"].ToString();
                            }

                            if (reader["PatGender"] != DBNull.Value)
                            {
                                GendertextBox.Text = reader["PatGender"].ToString();
                            }

                            if (reader["Age"] != DBNull.Value)
                            {
                                AgetextBox.Text = reader["Age"].ToString();
                            }

                            if (reader["AdmissionDate"] != DBNull.Value)
                            {
                                AdmissiondateTimePicker.Value = Convert.ToDateTime(reader["AdmissionDate"]);
                            }
                            else
                            {
                                // Handle the case when AdmissionDate is DBNull if needed
                                // AdmissiondateTimePicker.Value = DateTime.MinValue; // Set some default value
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void ToDtdateTimePicker_ValueChanged(object sender, EventArgs e)
        {

            if (ToDtdateTimePicker.Value < FromDtDateTimePicker.Value)
            {
                ToDtdateTimePicker.Value = FromDtDateTimePicker.Value;
            }
                // Assuming FromDtdateTimePicker and ToDtdateTimePicker are DateTimePicker controls
                DateTime fromDate = FromDtDateTimePicker.Value;
            DateTime toDate = ToDtdateTimePicker.Value;

            TimeSpan difference = toDate - fromDate;
            int daysDifference = (int)difference.TotalDays;

            // If the difference is zero, set it to 1
            if (daysDifference <= 0)
            {
                daysDifference = 1;
            }

            // Display the difference in the DaystextBox
            DaystextBox.Text = daysDifference.ToString();
        }

        private void BedRateTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateBedAmount();
        }

        private void bedNoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                
            

        }

        private void DaystextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateBedAmount();
        }

        private void CalculateBedAmount()
        {
            int days = 0;
            decimal bedRate = 0;

            if (int.TryParse(DaystextBox.Text, out days) && decimal.TryParse(BedRateTextBox.Text, out bedRate))
            {
                decimal bedAmount = days * bedRate;
                BedAmounttextBox.Text = bedAmount.ToString();
            }
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string checkIfExistsQuery = "SELECT COUNT(*) FROM BedManagement WHERE Id = @Id";
                string insertOrUpdateQuery = @"
            IF EXISTS (SELECT 1 FROM BedManagement WHERE Id = @Id)
            BEGIN
                UPDATE BedManagement 
                SET IPD = @IPD, DrName = @DrName, FromDate = @FromDate, BedType = @BedType, BedNo = @BedNo, Todate = @Todate, 
                    Days = @Days, Rate = @Rate, BedAmount = @BedAmount, Patient = @Patient
                WHERE Id = @Id
            END
            ELSE
            BEGIN
                INSERT INTO BedManagement (IPD, DrName, FromDate, BedType, BedNo, Todate, Days, Rate, BedAmount, Patient)
                VALUES (@IPD, @DrName, @FromDate, @BedType, @BedNo, @Todate, @Days, @Rate, @BedAmount, @Patient)
            END";

                using (SqlCommand checkIfExistsCommand = new SqlCommand(checkIfExistsQuery, con))
                using (SqlCommand insertOrUpdateCommand = new SqlCommand(insertOrUpdateQuery, con))
                {
                    checkIfExistsCommand.Parameters.AddWithValue("@Id", idTextBox.Text);
                    insertOrUpdateCommand.Parameters.AddWithValue("@Id", idTextBox.Text);
                    insertOrUpdateCommand.Parameters.AddWithValue("@IPD", IPDSearchtextBox.Text);
                    insertOrUpdateCommand.Parameters.AddWithValue("@DrName", DoctorNameComboBox.Text);
                    insertOrUpdateCommand.Parameters.AddWithValue("@FromDate", FromDtDateTimePicker.Value);
                    insertOrUpdateCommand.Parameters.AddWithValue("@BedType", bedTypeComboBox.Text);
                    insertOrUpdateCommand.Parameters.AddWithValue("@BedNo", bedNoComboBox.Text);
                    insertOrUpdateCommand.Parameters.AddWithValue("@Todate", (object)ToDtdateTimePicker.Value ?? DBNull.Value);
                    insertOrUpdateCommand.Parameters.AddWithValue("@Days", int.Parse(DaystextBox.Text));
                    insertOrUpdateCommand.Parameters.AddWithValue("@Rate", decimal.Parse(BedRateTextBox.Text));
                    insertOrUpdateCommand.Parameters.AddWithValue("@BedAmount", decimal.Parse(BedAmounttextBox.Text));
                    insertOrUpdateCommand.Parameters.AddWithValue("@Patient", IPDSearchtextBox.Text);

                    con.Open();
                    SqlTransaction transaction = con.BeginTransaction();

                    try
                    {
                        checkIfExistsCommand.Transaction = transaction;
                        int existingRecordCount = (int)checkIfExistsCommand.ExecuteScalar();

                        insertOrUpdateCommand.Transaction = transaction;

                        if (existingRecordCount > 0)
                        {
                            int rowsAffected = insertOrUpdateCommand.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                // Optionally, clear the fields after successful save
                                ClearFields();
                                transaction.Commit();
                                MessageBox.Show("Data updated successfully!");
                            }
                            else
                            {
                                transaction.Rollback();
                                MessageBox.Show("Failed to update data!");
                            }
                        }
                        else
                        {
                            int rowsAffected = insertOrUpdateCommand.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                // Optionally, clear the fields after successful save
                                ClearFields();
                                transaction.Commit();
                                MessageBox.Show("Data saved successfully!");
                            }
                            else
                            {
                                transaction.Rollback();
                                MessageBox.Show("Failed to save data!");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        transaction.Dispose();
                    }

                    //idTextBox.Text = string.Empty;
                    IPDSearchtextBox.Text = "RNH/";
                    PatientNametextBox.Text = string.Empty;
                    GendertextBox.Text = string.Empty;
                    AgetextBox.Text = string.Empty;
                    DoctorNameComboBox.SelectedIndex = -1;
                    AdmissiondateTimePicker.Value = DateTime.Now; // Set to desired default date or leave as is
                    FromDtDateTimePicker.Value = DateTime.Now; // Set to desired default date or leave as is
                    bedTypeComboBox.SelectedIndex = -1;
                    bedNoComboBox.SelectedIndex = -1;
                    ToDtdateTimePicker.Value = DateTime.Now; // Set to desired default date or leave as is
                    DaystextBox.Text = "0";
                    BedRateTextBox.Text = "0";
                    BedAmounttextBox.Text = "0";
                    Display();
                    
                }
            }
            IPDSearchtextBox.ReadOnly = false;
            idTextBox.Text = GetNextAvailableId().ToString();

        }


        // Optional: Clear fields after successful save
        private void ClearFields()
        {
           // idTextBox.Text = "";
            IPDSearchtextBox.Text = "RNH/";
            DoctorNameComboBox.Text = "";
            FromDtDateTimePicker.Value = DateTime.Today;
            bedTypeComboBox.Text = "";
            bedNoComboBox.Text = "";
            ToDtdateTimePicker.Value = DateTime.Now;
            DaystextBox.Text = "0";
            BedRateTextBox.Text = "0";
            BedAmounttextBox.Text = "0";

            idTextBox.Focus();
        }

        private void BedManagedataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            IPDSearchtextBox.ReadOnly = true;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                DataGridViewRow selectedRow = BedManagedataGridView.CurrentRow;

                if (selectedRow != null)
                {
                    int selectedId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                    // Create and open a SQL connection
                    con.Open();

                    // Prepare the SQL query to fetch data based on Id
                    string query = "SELECT Id, Patient, BedType, BedNo, FromDate, BedAmount, IPD, Todate, Days, Rate, DrName " +
                                   "FROM BedManagement " +
                                   "WHERE Id = @SelectedId";

                    // Create a SqlCommand with the connection and query
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@SelectedId", selectedId);

                        // Execute the query
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read()) // If data is fetched
                        {
                            // Populate UI elements with fetched data
                            idTextBox.Text = reader["Id"].ToString();
                            PatientNametextBox.Text = reader["Patient"].ToString();
                            bedTypeComboBox.Text = reader["BedType"].ToString();
                            bedNoComboBox.Text = reader["BedNo"].ToString();
                            FromDtDateTimePicker.Value = Convert.ToDateTime(reader["FromDate"]);
                            BedAmounttextBox.Text = reader["BedAmount"].ToString();
                            IPDSearchtextBox.Text = reader["IPD"].ToString();
                            ToDtdateTimePicker.Value = Convert.ToDateTime(reader["Todate"]);
                            DaystextBox.Text = reader["Days"].ToString();
                            BedRateTextBox.Text = reader["Rate"].ToString();
                            DoctorNameComboBox.Text = reader["DrName"].ToString();
                        }

                        // Close the reader
                        reader.Close();
                    }
                }
            }

        }

        

        private void bedTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void BedMangFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private int GetNextAvailableId()
        {
            int nextId = 1;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(Id) + 1 AS NextId FROM BedManagement";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    con.Open();
                    object result = command.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        nextId = Convert.ToInt32(result);
                    }
                }
            }

            return nextId;
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            // Ensure that the user has selected a row in the IPDdataGridView
            if (BedManagedataGridView.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = BedManagedataGridView.SelectedRows[0];

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
                        using (SqlCommand cmdDischarge = new SqlCommand("DELETE FROM BedManagement WHERE Id = @Id", con, transaction))
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
    }
}
