using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Xamarin.Forms;

namespace HMS.Forms.Transaction
{
    public partial class DisposableIssFrm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["HMS.Properties.Settings.HMSConnectionString"].ConnectionString;
        private SqlConnection con;

        public DisposableIssFrm()
        {
            InitializeComponent();
        }

        private void DisposableIssFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet.ItMast' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'hMSDataSet.ItMast' table. You can move, or remove it, as needed.
            this.itMastTableAdapter.Fill(this.hMSDataSet.ItMast);
            
           // InitializeGridViewAutoComplete();
            Display();
            textBoxIPD.Text = "RNH/";
            textBoxPatName.Text = string.Empty;
            textBoxBedNo.Text = string.Empty;
            textBoxDoctor.Text = string.Empty;
            textBoxAmount.Text = string.Empty;
            dateTimePickerIssueDt.Value = DateTime.Now; // Set to desired default date or leave as is
                                                        //textBoxDisNo.Text = GetNextAvailableId().ToString();
            DateTime selectedDate = dateTimePickerIssueDt.Value;
            string generatedISSNo = GenerateISSNo(selectedDate);
            textBoxDisNo.Text = generatedISSNo;
        }

        private void textBoxIPD_TextChanged(object sender, EventArgs e)
        {
            // Assuming you have a SqlConnection named 'connection'
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // Open the connection
                con.Open();

                // Fetch data from IPD table
                string ipdValue = textBoxIPD.Text;
                string ipdQuery = "SELECT Id, Patient, PrecheckedBy FROM IPD WHERE Id = @Id";

                using (SqlCommand ipdCommand = new SqlCommand(ipdQuery, con))
                {
                    ipdCommand.Parameters.AddWithValue("@Id", ipdValue);

                    using (SqlDataReader reader = ipdCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Assuming you have textBoxPatName and textBoxDoctor controls
                            textBoxIPD.Text = reader["Id"].ToString();
                            textBoxPatName.Text = reader["Patient"] != DBNull.Value ? reader["Patient"].ToString() : string.Empty;
                            textBoxDoctor.Text = reader["PrecheckedBy"] != DBNull.Value ? reader["PrecheckedBy"].ToString() : string.Empty;

                            // Check if textBoxBedNo is not null before accessing it
                            if (textBoxBedNo != null)
                            {
                                // Fetch the latest BedNo from BedManagement table
                                string bedQuery = "SELECT TOP 1 BedNo FROM BedManagement WHERE IPD = @IPD ORDER BY Id DESC";

                                using (SqlCommand bedCommand = new SqlCommand(bedQuery, con))
                                {
                                    bedCommand.Parameters.AddWithValue("@IPD", ipdValue);

                                    // Close the SqlDataReader before executing the new command
                                    reader.Close();

                                    using (SqlDataReader bedReader = bedCommand.ExecuteReader())
                                    {
                                        if (bedReader.Read())
                                        {
                                            // Assuming you have textBoxBedNo control
                                            textBoxBedNo.Text = bedReader["BedNo"] != DBNull.Value ? bedReader["BedNo"].ToString() : string.Empty;
                                        }
                                        else
                                        {
                                            // Handle the case when no data is found
                                            textBoxBedNo.Text = "";
                                        }
                                    }
                                }
                            }
                        }
                        else
                        {
                            // Handle the case when no data is found for IPD
                            textBoxPatName.Text = "";
                            textBoxDoctor.Text = "";

                            // Check if textBoxBedNo is not null before accessing it
                            if (textBoxBedNo != null)
                            {
                                // Clear the value of textBoxBedNo
                                textBoxBedNo.Text = "";
                            }
                        }
                    }
                }

                // Close the connection
                con.Close();
            }
        }


        private void InitializeGridViewAutoComplete()
        {
            // Setting up auto-complete for the "ItName" column
            DataGridViewComboBoxColumn ItName = (DataGridViewComboBoxColumn)dataGridViewItems.Columns["ItName"]; // Replace "ItName" with the actual column name
            ItName.AutoComplete = true;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT ItName FROM ItMast", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string itemName = reader["ItName"].ToString();
                    ItName.Items.Add(itemName);
                }

                reader.Close();
                con.Close();
            }
        }
        

        private void FetchItMastData(string selectedItCode, int rowIndex)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Fetch data from ItMast table based on ItCode
                string query = "SELECT ItName, ItUnit, ItRate FROM ItMast WHERE ItCode = @ItCode";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ItCode", selectedItCode);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Populate data into dataGridViewGRN columns
                    dataGridViewItems.Rows[rowIndex].Cells["ItName"].Value = reader["ItName"].ToString();
                    dataGridViewItems.Rows[rowIndex].Cells["ItUnit"].Value = reader["ItUnit"].ToString();
                    dataGridViewItems.Rows[rowIndex].Cells["ItRate"].Value = reader["ItRate"].ToString();
                }

                reader.Close();
                con.Close();
            }
        }

        private void dataGridViewItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = dataGridViewItems.Columns[e.ColumnIndex].Name;

                
                if (columnName == "ItName")
                {
                    // Handle live search for the "ItName" column
                    AutoFillItName(dataGridViewItems.Rows[e.RowIndex]);
                    
                }

            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = dataGridViewItems.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Check if the cell belongs to the "ItName" column
                if (cell.OwningColumn.Name == "ItName") // Replace "ItName" with the actual column name
                {
                    string enteredItemName = cell.Value?.ToString();

                    if (!string.IsNullOrWhiteSpace(enteredItemName))
                    {
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            con.Open();

                            SqlCommand cmd = new SqlCommand("SELECT ItCode, ItRate, ItUnit FROM ItMast WHERE ItName = @ItName", con);
                            cmd.Parameters.AddWithValue("@ItName", enteredItemName);

                            SqlDataReader reader = cmd.ExecuteReader();
                            if (reader.Read())
                            {
                                // Populate ItCode, ItRate, ItUnit columns based on the selected ItName
                                dataGridViewItems.Rows[e.RowIndex].Cells["ItCode"].Value = reader["ItCode"].ToString();
                                dataGridViewItems.Rows[e.RowIndex].Cells["ItRate"].Value = reader["ItRate"].ToString();
                                dataGridViewItems.Rows[e.RowIndex].Cells["ItUnit"].Value = reader["ItUnit"].ToString();
                            }
                            else
                            {
                                // Clear ItCode, ItRate, ItUnit if no matching ItName found
                                dataGridViewItems.Rows[e.RowIndex].Cells["ItCode"].Value = string.Empty;
                                dataGridViewItems.Rows[e.RowIndex].Cells["ItRate"].Value = string.Empty;
                                dataGridViewItems.Rows[e.RowIndex].Cells["ItUnit"].Value = string.Empty;
                            }

                            reader.Close();
                            con.Close();
                        }
                    }
                }
            }

            // Check if the changed cell is in "ItQty" or "ItRate" column
            if (e.RowIndex >= 0 && (dataGridViewItems.Columns[e.ColumnIndex].Name == "ItQty" || dataGridViewItems.Columns[e.ColumnIndex].Name == "ItRate"))
            {
                DataGridViewCell qtyCell = dataGridViewItems.Rows[e.RowIndex].Cells["ItQty"];
                DataGridViewCell rateCell = dataGridViewItems.Rows[e.RowIndex].Cells["ItRate"];
                DataGridViewCell amtCell = dataGridViewItems.Rows[e.RowIndex].Cells["ItAmt"];

                if (qtyCell.Value != null && rateCell.Value != null)
                {
                    // Check if the values in "ItQty" and "ItRate" cells are numeric
                    if (decimal.TryParse(qtyCell.Value.ToString(), out decimal qty) && decimal.TryParse(rateCell.Value.ToString(), out decimal rate))
                    {
                        // Calculate and display the product in "ItAmt" cell
                        amtCell.Value = (qty * rate).ToString();
                    }
                    else
                    {
                        // Handle non-numeric input, clear "ItAmt" cell
                        amtCell.Value = string.Empty;
                    }
                }
                else
                {
                    // Clear "ItAmt" cell if either "ItQty" or "ItRate" is null
                    amtCell.Value = string.Empty;
                }
            }

            //add value in textBoxGAmt
            if (e.RowIndex >= 0 && dataGridViewItems.Columns[e.ColumnIndex].Name == "ItAmt")
            {
                // Recalculate the total sum of the "ItAmt" column
                decimal totalAmount = 0;

                foreach (DataGridViewRow row in dataGridViewItems.Rows)
                {
                    // Check if the cell value is not null and a valid decimal
                    if (row.Cells["ItAmt"].Value != null && decimal.TryParse(row.Cells["ItAmt"].Value.ToString(), out decimal amount))
                    {
                        totalAmount += amount;
                    }
                }

                // Show the total sum in textBoxGAmt
                textBoxAmount.Text = totalAmount.ToString();
            }


        }

        private void AutoFillItName(DataGridViewRow row)
        {
            string partialInput = row.Cells["ItName"].Value?.ToString();

            if (!string.IsNullOrEmpty(partialInput))
            {
                // Fetch matching item names from the database
                List<string> matchingItNames = GetMatchingItNames(partialInput);

                // Display the matching names in a dropdown or set the value based on your UI choice
                // Here, I'll just set the value to the first matching name (if any)
                if (matchingItNames.Count > 0)
                {
                    row.Cells["ItName"].Value = matchingItNames[0];
                }
            }
        }

        private List<string> GetMatchingItNames(string partialInput)
        {
            List<string> matchingItNames = new List<string>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                using (SqlCommand command = new SqlCommand("SELECT ItName FROM ItMast WHERE ItName LIKE @PartialInput", con))

                {
                    try 
                    { 
                        command.Parameters.AddWithValue("@PartialInput", "%" + partialInput + "%");

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                matchingItNames.Add(reader["ItName"].ToString());
                            }
                        }
                    }

                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            return matchingItNames;
        }





        /*
        private void dataGridViewItems_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridViewItems.Columns[e.ColumnIndex].Name == "ItCode")
            {
                // Fetch data from ItMast based on ItCode
                string selectedItCode = dataGridViewItems.Rows[e.RowIndex].Cells["ItCode"].Value?.ToString();

                if (!string.IsNullOrEmpty(selectedItCode))
                {
                    FetchItMastData(selectedItCode, e.RowIndex);
                }
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = dataGridViewItems.Rows[e.RowIndex].Cells[e.ColumnIndex];

                // Check if the cell belongs to the "ItName" column
                if (cell.OwningColumn.Name == "ItName") // Replace "ItName" with the actual column name
                {
                    string enteredItemName = cell.Value?.ToString();

                    if (!string.IsNullOrWhiteSpace(enteredItemName))
                    {
                        using (SqlConnection con = new SqlConnection(connectionString))
                        {
                            con.Open();

                            SqlCommand cmd = new SqlCommand("SELECT ItCode, ItRate, ItUnit FROM ItMast WHERE ItName = @ItName", con);
                            cmd.Parameters.AddWithValue("@ItName", enteredItemName);

                            SqlDataReader reader = cmd.ExecuteReader();
                            if (reader.Read())
                            {
                                // Populate ItCode, ItRate, ItUnit columns based on the selected ItName
                                dataGridViewItems.Rows[e.RowIndex].Cells["ItCode"].Value = reader["ItCode"].ToString();
                                dataGridViewItems.Rows[e.RowIndex].Cells["ItRate"].Value = reader["ItRate"].ToString();
                                dataGridViewItems.Rows[e.RowIndex].Cells["ItUnit"].Value = reader["ItUnit"].ToString();
                            }
                            else
                            {
                                // Clear ItCode, ItRate, ItUnit if no matching ItName found
                                dataGridViewItems.Rows[e.RowIndex].Cells["ItCode"].Value = string.Empty;
                                dataGridViewItems.Rows[e.RowIndex].Cells["ItRate"].Value = string.Empty;
                                dataGridViewItems.Rows[e.RowIndex].Cells["ItUnit"].Value = string.Empty;
                            }

                            reader.Close();
                            con.Close();
                        }
                    }
                }
            }

            // Check if the changed cell is in "ItQty" or "ItRate" column
            if (e.RowIndex >= 0 && (dataGridViewItems.Columns[e.ColumnIndex].Name == "ItQty" || dataGridViewItems.Columns[e.ColumnIndex].Name == "ItRate"))
            {
                DataGridViewCell qtyCell = dataGridViewItems.Rows[e.RowIndex].Cells["ItQty"];
                DataGridViewCell rateCell = dataGridViewItems.Rows[e.RowIndex].Cells["ItRate"];
                DataGridViewCell amtCell = dataGridViewItems.Rows[e.RowIndex].Cells["ItAmt"];

                if (qtyCell.Value != null && rateCell.Value != null)
                {
                    // Check if the values in "ItQty" and "ItRate" cells are numeric
                    if (decimal.TryParse(qtyCell.Value.ToString(), out decimal qty) && decimal.TryParse(rateCell.Value.ToString(), out decimal rate))
                    {
                        // Calculate and display the product in "ItAmt" cell
                        amtCell.Value = (qty * rate).ToString();
                    }
                    else
                    {
                        // Handle non-numeric input, clear "ItAmt" cell
                        amtCell.Value = string.Empty;
                    }
                }
                else
                {
                    // Clear "ItAmt" cell if either "ItQty" or "ItRate" is null
                    amtCell.Value = string.Empty;
                }
            }

            //add value in textBoxGAmt
            if (e.RowIndex >= 0 && dataGridViewItems.Columns[e.ColumnIndex].Name == "ItAmt")
            {
                // Recalculate the total sum of the "ItAmt" column
                decimal totalAmount = 0;

                foreach (DataGridViewRow row in dataGridViewItems.Rows)
                {
                    // Check if the cell value is not null and a valid decimal
                    if (row.Cells["ItAmt"].Value != null && decimal.TryParse(row.Cells["ItAmt"].Value.ToString(), out decimal amount))
                    {
                        totalAmount += amount;
                    }
                }

                // Show the total sum in textBoxGAmt
                textBoxAmount.Text = totalAmount.ToString();
            }
        }
        */
        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Assuming you have a SqlConnection and SqlCommand for database interaction
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Check if the record already exists in DisposableIssHdr
                SqlCommand checkCommand = new SqlCommand("SELECT COUNT(*) FROM DisposableIssHdr WHERE DisNo = @DisNo", con);
                checkCommand.Parameters.AddWithValue("@DisNo", textBoxDisNo.Text);

                int count = (int)checkCommand.ExecuteScalar();

                if (count > 0)
                {
                    // Update existing record in DisposableIssHdr
                    SqlCommand updateCommand = new SqlCommand("UPDATE DisposableIssHdr SET IPD = @IPD, Date = @Date, Bed = @Bed, Dr = @Dr, Amt = @Amt WHERE DisNo = @DisNo", con);
                    updateCommand.Parameters.AddWithValue("@DisNo", textBoxDisNo.Text);
                    updateCommand.Parameters.AddWithValue("@IPD", textBoxIPD.Text);
                    updateCommand.Parameters.AddWithValue("@Date", dateTimePickerIssueDt.Value);
                    updateCommand.Parameters.AddWithValue("@Bed", textBoxBedNo.Text);
                    updateCommand.Parameters.AddWithValue("@Dr", textBoxDoctor.Text);
                    updateCommand.Parameters.AddWithValue("@Amt", textBoxAmount.Text);

                    updateCommand.ExecuteNonQuery();
                }
                else
                {
                    // Insert new record into DisposableIssHdr
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO DisposableIssHdr (DisNo, IPD, Date, Bed, Dr, Amt) VALUES (@DisNo, @IPD, @Date, @Bed, @Dr, @Amt)", con);
                    insertCommand.Parameters.AddWithValue("@DisNo", textBoxDisNo.Text);
                    insertCommand.Parameters.AddWithValue("@IPD", textBoxIPD.Text);
                    insertCommand.Parameters.AddWithValue("@Date", dateTimePickerIssueDt.Value);
                    insertCommand.Parameters.AddWithValue("@Bed", textBoxBedNo.Text);
                    insertCommand.Parameters.AddWithValue("@Dr", textBoxDoctor.Text);
                    insertCommand.Parameters.AddWithValue("@Amt", textBoxAmount.Text);

                    insertCommand.ExecuteNonQuery();
                }

                // Update or insert records into DisposableIssLin
                foreach (DataGridViewRow row in dataGridViewItems.Rows)
                {
                    // Ensure that @ItCode is not null before adding it as a parameter
                    if (row.Cells["ItCode"].Value != null)
                    {
                        SqlCommand updateCommand = new SqlCommand("UPDATE DisposableIssLin SET ItName = @ItName, ItUnit = @ItUnit, ItQty = @ItQty, ItRate = @ItRate, ItAmt = @ItAmt WHERE DisNo = @DisNo AND ItCode = @ItCode", con);
                        updateCommand.Parameters.AddWithValue("@ItCode", row.Cells["ItCode"].Value);
                        updateCommand.Parameters.AddWithValue("@DisNo", textBoxDisNo.Text);
                        updateCommand.Parameters.AddWithValue("@ItName", row.Cells["ItName"].Value);
                        updateCommand.Parameters.AddWithValue("@ItUnit", row.Cells["ItUnit"].Value);
                        updateCommand.Parameters.AddWithValue("@ItQty", row.Cells["ItQty"].Value);
                        updateCommand.Parameters.AddWithValue("@ItRate", row.Cells["ItRate"].Value);
                        updateCommand.Parameters.AddWithValue("@ItAmt", row.Cells["ItAmt"].Value);

                        int updatedRows = updateCommand.ExecuteNonQuery();

                        if (updatedRows == 0)
                        {
                            // If no rows were updated, perform the insert operation
                            SqlCommand insertCommand = new SqlCommand("INSERT INTO DisposableIssLin (DisNo, ItCode, ItName, ItUnit, ItQty, ItRate, ItAmt) VALUES (@DisNo, @ItCode, @ItName, @ItUnit, @ItQty, @ItRate, @ItAmt)", con);
                            insertCommand.Parameters.AddWithValue("@ItCode", row.Cells["ItCode"].Value);
                            insertCommand.Parameters.AddWithValue("@DisNo", textBoxDisNo.Text);
                            insertCommand.Parameters.AddWithValue("@ItName", row.Cells["ItName"].Value);
                            insertCommand.Parameters.AddWithValue("@ItUnit", row.Cells["ItUnit"].Value);
                            insertCommand.Parameters.AddWithValue("@ItQty", row.Cells["ItQty"].Value);
                            insertCommand.Parameters.AddWithValue("@ItRate", row.Cells["ItRate"].Value);
                            insertCommand.Parameters.AddWithValue("@ItAmt", row.Cells["ItAmt"].Value);

                            insertCommand.ExecuteNonQuery();
                        }
                    }
                }

                // Display method
                Display();
                textBoxIPD.ReadOnly = false;
                textBoxIPD.Text = "RNH/";
                textBoxPatName.Text = string.Empty;
                textBoxBedNo.Text = string.Empty;
                textBoxDoctor.Text = string.Empty;
                textBoxAmount.Text = string.Empty;
                dateTimePickerIssueDt.Value = DateTime.Now; // Set to desired default date or leave as is
                                                            //textBoxDisNo.Text = GetNextAvailableId().ToString();
                DateTime selectedDate = dateTimePickerIssueDt.Value;
                string generatedISSNo = GenerateISSNo(selectedDate);
                textBoxDisNo.Text = generatedISSNo;
                dataGridViewItems.Rows.Clear();


                // Close the connection
                con.Close();
            }

            MessageBox.Show("Data saved/updated successfully.");
            

        }







        void Display()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Fetch data from DisposableIssHdr and related IPD table
                string displayQuery = "SELECT dh.DisNo, dh.IPD, dh.Date, ipd.Patient, dh.Amt " +
                                      "FROM DisposableIssHdr dh " +
                                      "JOIN IPD ipd ON dh.IPD = ipd.Id ORDER BY DisNo DESC";

                using (SqlCommand displayCmd = new SqlCommand(displayQuery, con))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(displayCmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridViewDisposableList.Rows.Clear();

                    if (dataTable != null && dataTable.Rows.Count > 0)
                    {
                        foreach (DataRow item in dataTable.Rows)
                        {
                            int n = dataGridViewDisposableList.Rows.Add();

                            // Assuming your DataGridView columns are already defined in the designer

                            // Check if the column exists before accessing it
                            dataGridViewDisposableList.Rows[n].Cells["DisNo"].Value = item["DisNo"].ToString();
                            dataGridViewDisposableList.Rows[n].Cells["IPD"].Value = item["IPD"].ToString();
                            dataGridViewDisposableList.Rows[n].Cells["Date"].Value = item["Date"].ToString();
                            dataGridViewDisposableList.Rows[n].Cells["Patient"].Value = item["Patient"].ToString();
                            dataGridViewDisposableList.Rows[n].Cells["Amount"].Value = item["Amt"] != DBNull.Value ? item["Amt"].ToString() : string.Empty;

                            // Update IPD.DispTotal
                            UpdateDispTotal(item["IPD"].ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("No data to display.");
                    }
                }
                con.Close();
            }
        }

        void UpdateDispTotal(string ipdId)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Calculate total for DisposableIssHdr.Amt for the given IPD.Id
                string totalQuery = "SELECT SUM(Amt) AS TotalAmt FROM DisposableIssHdr WHERE IPD = @IPD";
                using (SqlCommand totalCmd = new SqlCommand(totalQuery, con))
                {
                    totalCmd.Parameters.AddWithValue("@IPD", ipdId);

                    object totalResult = totalCmd.ExecuteScalar();

                    if (totalResult != null && totalResult != DBNull.Value)
                    {
                        // Update IPD.DispTotal
                        string updateQuery = "UPDATE IPD SET DispTotal = @DispTotal WHERE Id = @IPD";
                        using (SqlCommand updateCmd = new SqlCommand(updateQuery, con))
                        {
                            updateCmd.Parameters.AddWithValue("@DispTotal", totalResult);
                            updateCmd.Parameters.AddWithValue("@IPD", ipdId);

                            updateCmd.ExecuteNonQuery();
                        }
                    }
                }
                con.Close();
            }
        }




        private void dataGridViewDisposableList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBoxIPD.ReadOnly = true;
            if (dataGridViewDisposableList.CurrentRow != null)
            {
                // Get the value of the "GRNNo" column in the selected row
                string selectedDisNo = dataGridViewDisposableList.CurrentRow.Cells["DisNo"].Value?.ToString();

                if (!string.IsNullOrEmpty(selectedDisNo))
                {
                    // Fetch data from the database based on the selected GRNNo
                    FetchDataFromDatabase(selectedDisNo);
                }
            }
        }

        private void FetchDataFromDatabase(string selectedDisNo)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Fetch data from DisposableIssHdr table
                string query = "SELECT * FROM DisposableIssHdr WHERE DisNo = @DisNo";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@DisNo", selectedDisNo);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Populate data into respective textboxes and controls
                    textBoxDisNo.Text = reader["DisNo"].ToString();
                    textBoxIPD.Text = reader["IPD"].ToString();
                    dateTimePickerIssueDt.Value = Convert.ToDateTime(reader["Date"]);
                    textBoxBedNo.Text = reader["Bed"].ToString();
                    textBoxDoctor.Text = reader["Dr"].ToString();
                    textBoxAmount.Text = reader["Amt"].ToString();
                    

                    // Fetch data from IPD table based on Id
                    FetchPatientData(reader["IPD"].ToString());

                    // Fetch data from DisLin table based on DisNo
                    FetchDisLinData(selectedDisNo);
                }

                reader.Close();
                con.Close();
            }
        }

        private void FetchPatientData(string IPD)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Fetch data from SuppMast table based on IPD
                string query = "SELECT Patient FROM IPD WHERE Id = @IPD";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@IPD", IPD);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Display SuppName in textBoxPatName
                    textBoxPatName.Text = reader["Patient"].ToString();
                }
                else
                {
                    // Clear textBoxPatName if no matching SuppCode found
                    textBoxPatName.Text = string.Empty;
                }

                reader.Close();
                con.Close();
            }
        }


        private void FetchDisLinData(string selectedDisNo)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Fetch data from DisposableIssLin table based on DisNo
                string query = "SELECT ItCode, ItName, ItUnit, ItQty, ItRate, ItAmt FROM DisposableIssLin WHERE DisNo = @DisNo";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@DisNo", selectedDisNo);

                SqlDataReader reader = cmd.ExecuteReader();

                // Clear existing rows in dataGridViewItems
                dataGridViewItems.Rows.Clear();

                while (reader.Read())
                {
                    int n = dataGridViewItems.Rows.Add();

                    // Populate data into dataGridViewItems columns
                    dataGridViewItems.Rows[n].Cells["ItCode"].Value = reader["ItCode"].ToString();
                    dataGridViewItems.Rows[n].Cells["ItName"].Value = reader["ItName"].ToString();
                    dataGridViewItems.Rows[n].Cells["ItUnit"].Value = reader["ItUnit"].ToString();
                    dataGridViewItems.Rows[n].Cells["ItQty"].Value = reader["ItQty"].ToString();
                    dataGridViewItems.Rows[n].Cells["ItRate"].Value = reader["ItRate"].ToString();
                    dataGridViewItems.Rows[n].Cells["ItAmt"].Value = reader["ItAmt"].ToString();


                }

                reader.Close();
                con.Close();
            }
        }


        

        private string GenerateISSNo(DateTime selectedDate)
        {
            string prefix = "ISS/";
            string dateFormat = selectedDate.ToString("yyMMdd");

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT MAX(RIGHT(DISNo, 3)) FROM DisposableIssHdr WHERE SUBSTRING(DISNo, 5, 6) = @CurrentDate", con);
                cmd.Parameters.AddWithValue("@CurrentDate", dateFormat);

                object result = cmd.ExecuteScalar();
                int serialNumber = (result == DBNull.Value) ? 1 : Convert.ToInt32(result) + 1;

                string formattedSerialNumber = serialNumber.ToString("000");
                string generatedISSNo = $"{prefix}{dateFormat}/{formattedSerialNumber}";

                con.Close();

                return generatedISSNo;
            }
        }

        private void dateTimePickerIssueDt_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePickerIssueDt.Value;
            string generatedISSNo = GenerateISSNo(selectedDate);

            // Assuming textBoxDisNo is your TextBox control
            textBoxDisNo.Text = generatedISSNo;
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            // Ensure that the user has selected a row in the dischargeDataGridView
            if (dataGridViewDisposableList.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridViewDisposableList.SelectedRows[0];

                // Retrieve the value from the "Id" column and set it to idToDelete
                string idToDelete = selectedRow.Cells["DisNo"].Value.ToString();

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
                        using (SqlCommand cmdDischargeLin = new SqlCommand("DELETE FROM DisposableIssLin WHERE DisNo = @DisNo", con, transaction))
                        {
                            cmdDischargeLin.Parameters.AddWithValue("@DisNo", idToDelete);
                            cmdDischargeLin.ExecuteNonQuery();
                        }

                        // Then delete from Discharge table
                        using (SqlCommand cmdDischarge = new SqlCommand("DELETE FROM DisposableIssHdr WHERE DisNo = @DisNo", con, transaction))
                        {
                            cmdDischarge.Parameters.AddWithValue("@DisNo", idToDelete);
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
