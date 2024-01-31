using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace HMS.Forms.Master
{
    public partial class BedNumberMast : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["HMS.Properties.Settings.HMSConnectionString"].ConnectionString;
        public BedNumberMast()
        {
            InitializeComponent();
        }


        private void BedNumberMast_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet.BedTypeMast' table. You can move, or remove it, as needed.
            this.bedTypeMastTableAdapter.Fill(this.hMSDataSet.BedTypeMast);
            // TODO: This line of code loads data into the 'hMSDataSet.BedNumberMast' table. You can move, or remove it, as needed.
           // this.bedNumberMastTableAdapter.Fill(this.hMSDataSet.BedNumberMast);
            //this.hMSDataSet.EnforceConstraints = false;
            ClearFields();
            Display();
        }

        private void BedNumberMast_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Check if the BedNumber already exists in the database
                string checkQuery = "SELECT COUNT(*) FROM BedNumberMast WHERE BedNumber = @BedNumber";

                using (SqlCommand checkCommand = new SqlCommand(checkQuery, con))
                {
                    checkCommand.Parameters.AddWithValue("@BedNumber", bedNumberTextBox.Text);
                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        // BedNumber exists, perform UPDATE
                        string updateQuery = "UPDATE BedNumberMast SET BedType = @BedType, CurrentStatus = @CurrentStatus, BedRate = @BedRate " +
                                             "WHERE BedNumber = @BedNumber";

                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, con))
                        {
                            updateCommand.Parameters.AddWithValue("@BedNumber", bedNumberTextBox.Text);
                            updateCommand.Parameters.AddWithValue("@BedType", bedTypeComboBox.Text);
                            updateCommand.Parameters.AddWithValue("@CurrentStatus", currentStatusComboBox.Text);
                            updateCommand.Parameters.AddWithValue("@BedRate", textBoxRate.Text);

                            // Execute the update query
                            updateCommand.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        // BedNumber doesn't exist, perform INSERT
                        string insertQuery = "INSERT INTO BedNumberMast (BedNumber, BedType, CurrentStatus, BedRate) " +
                                             "VALUES (@BedNumber, @BedType, @CurrentStatus, @BedRate)";

                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, con))
                        {
                            insertCommand.Parameters.AddWithValue("@BedNumber", bedNumberTextBox.Text);
                            insertCommand.Parameters.AddWithValue("@BedType", bedTypeComboBox.Text);
                            insertCommand.Parameters.AddWithValue("@CurrentStatus", currentStatusComboBox.Text);
                            insertCommand.Parameters.AddWithValue("@BedRate", textBoxRate.Text);

                            // Execute the insert query
                            insertCommand.ExecuteNonQuery();
                        }
                    }
                }

                con.Close();
                ClearFields();
            }

            // Refresh or update the DataGridView after saving data
            Display();
        }


        void Display()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * from BedNumberMast", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                bedNumberMastDataGridView.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = bedNumberMastDataGridView.Rows.Add();

                    bedNumberMastDataGridView.Rows[n].Cells[0].Value = item["Id"].ToString();
                    bedNumberMastDataGridView.Rows[n].Cells[1].Value = item["BedNumber"].ToString();
                    bedNumberMastDataGridView.Rows[n].Cells[2].Value = item["BedType"].ToString();
                    bedNumberMastDataGridView.Rows[n].Cells[3].Value = item["CurrentStatus"].ToString();
                    bedNumberMastDataGridView.Rows[n].Cells[4].Value = item["BedRate"].ToString();                 
                }
            }
        }

        private void ClearFields()
        {
            // Clear all input fields
            bedNumberTextBox.Text = "";
            bedTypeComboBox.SelectedIndex = -1; // Set to -1 to clear selection
            currentStatusComboBox.SelectedIndex = -1; // Set to -1 to clear selection
            textBoxRate.Text = "";
        }



        

        private void bedNumberMastDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (bedNumberMastDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = bedNumberMastDataGridView.SelectedRows[0];

                bedNumberTextBox.Text = selectedRow.Cells["BedNumber"].Value.ToString();
                textBoxRate.Text = selectedRow.Cells["Rate"].Value.ToString();

                // Set the value of bedTypeComboBox based on the ValueMember column
                string bedTypeValue = selectedRow.Cells["BedType"].Value.ToString();
                foreach (var item in bedTypeComboBox.Items)
                {
                    DataRowView row = item as DataRowView;
                    if (row != null && row.Row["BedType"].ToString() == bedTypeValue)
                    {
                        bedTypeComboBox.SelectedValue = bedTypeValue;
                        break;
                    }
                }

                string currentStatusValue = selectedRow.Cells["CurrentStatus"].Value.ToString();
                if (currentStatusComboBox.Items.Contains(currentStatusValue))
                {
                    currentStatusComboBox.SelectedItem = currentStatusValue;
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            // Ensure that the user has selected a row in the IPDdataGridView
            if (bedNumberMastDataGridView.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = bedNumberMastDataGridView.SelectedRows[0];

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
                        using (SqlCommand cmdDischarge = new SqlCommand("DELETE FROM BedNumberMast WHERE Id = @Id", con, transaction))
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
        
