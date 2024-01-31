using HMS.Forms.Billing;
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
using System.Configuration;
using HMS.Forms.Master;


namespace HMS.Forms.Transaction
{
    public partial class StkRecdFrm : Form
    {
        // string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        string connectionString = ConfigurationManager.ConnectionStrings["HMS.Properties.Settings.HMSConnectionString"].ConnectionString;
        // SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=HMS;Integrated Security=True");

        public StkRecdFrm()
        {
            InitializeComponent();
           
            textBoxSuppName.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBoxSuppName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxSuppName.AutoCompleteCustomSource = new AutoCompleteStringCollection(); // Initialize autocomplete source
        }

        private void StkRecdFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet.GRNHdr' table. You can move, or remove it, as needed.
            this.gRNHdrTableAdapter.Fill(this.hMSDataSet.GRNHdr);
            // TODO: This line of code loads data into the 'hMSDataSet.GRNLin' table. You can move, or remove it, as needed.
            this.gRNLinTableAdapter.Fill(this.hMSDataSet.GRNLin);
            LoadTaxNames();
            InitializeAutoComplete();
            InitializeGridViewAutoComplete();
            // Subscribe the textBoxGAmt_TextChanged event
            textBoxGAmt.TextChanged += textBoxGAmt_TextChanged;

            string generatedGRNNo = GenerateGRNNo();
            textBoxGRNNo.Text = generatedGRNNo;
            Display();
            
        }

        private void textBoxTaxName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxTaxName.Text))
            {
                // Clear textBoxTaxAmt when textBoxTaxName is blank
                textBoxTaxAmt.Text = "0";

                return;
            }
            if (taxPercentages.TryGetValue(textBoxTaxName.Text, out decimal percentage))
            {
                if (decimal.TryParse(textBoxGAmt.Text, out decimal gAmt))
                {
                    decimal taxAmt = (percentage / 100) * gAmt;
                    textBoxTaxAmt.Text = taxAmt.ToString(); // Format tax amount to two decimal places
                }
            }


        }

        // Declare taxPercentages at the class level
        private Dictionary<string, decimal> taxPercentages = new Dictionary<string, decimal>();

        private void LoadTaxNames()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            //string connectionString = "Data Source=.;Initial Catalog=HMS;Integrated Security=True"; // Get connection string from your configuration file

            //using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TaxName, Percentage FROM TaxMast";
                SqlCommand command = new SqlCommand(query, con);

                con.Open();
                SqlDataReader reader = command.ExecuteReader();

                AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();

                while (reader.Read())
                {
                    string taxName = reader["TaxName"].ToString();
                    decimal percentage = Convert.ToDecimal(reader["Percentage"]);

                    autoCompleteCollection.Add(taxName);
                    taxPercentages.Add(taxName, percentage);
                }

                textBoxTaxName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textBoxTaxName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                textBoxTaxName.AutoCompleteCustomSource = autoCompleteCollection;

                // Subscribe to the textBoxTaxName.TextChanged event to calculate tax amount
                textBoxTaxName.TextChanged += textBoxTaxName_TextChanged;

                con.Close();
            }
        }

        // Calculate total amount function
        private void CalculateTotalAmount()
        {
            if (decimal.TryParse(textBoxGAmt.Text, out decimal gAmt) &&
                decimal.TryParse(textBoxTaxAmt.Text, out decimal taxAmt) &&
                decimal.TryParse(textBoxOtherCharges.Text, out decimal otherCharges))
            {
                decimal totalAmount = gAmt + taxAmt + otherCharges;
                textBoxNAmount.Text = totalAmount.ToString(); // Format to two decimal places
            }
        }

        private void textBoxGAmt_TextChanged(object sender, EventArgs e)
        {
         //   textBoxTaxName_TextChanged(sender, e);
            

            // Format textBoxGAmt to always display two decimal places
            if (decimal.TryParse(textBoxGAmt.Text, out decimal gAmt))
            {
                textBoxGAmt.Text = gAmt.ToString();
            }
            textBoxTaxName_TextChanged(sender, e); // Update tax amount
            CalculateTotalAmount();
        }

        private void textBoxOtherCharges_TextChanged(object sender, EventArgs e)
        {
            
            if (decimal.TryParse(textBoxOtherCharges.Text, out decimal gAmt))
            {
                textBoxOtherCharges.Text = gAmt.ToString();
            }
            CalculateTotalAmount();
        }

        private void textBoxTaxAmt_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }

        private void buttonItMast_Click(object sender, EventArgs e)
        {
            ItMastFrm myForm = new ItMastFrm();

            myForm.ShowDialog();
        }

        private void buttonSupplierMast_Click(object sender, EventArgs e)
        {
            SupMast myForm = new SupMast();

            myForm.ShowDialog();
        }

        private void buttonTaxMaster_Click(object sender, EventArgs e)
        {
            TaxMast myForm = new TaxMast();

            myForm.ShowDialog();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (dataGridViewGRN.Rows.Count == 0)
            {
                MessageBox.Show("Please add items to the Material Table before saving.");
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Check if the data already exists in GRNHdr table
                bool dataExists = CheckDataExists(con, textBoxGRNNo.Text, "GRNHdr");

                if (dataExists)
                {
                    // Update existing record
                    UpdateGRNHdr(con);
                }
                else
                {
                    // Insert new record
                    InsertGRNHdr(con);
                }

                // Save data to GRNLin table
                SaveDataToGRNLin(con);
                

                con.Close();
                MessageBox.Show("Successfully Saved...!");
                Display();
                //UpdateStockQuantities(con);
            }
        }

        private bool CheckDataExists(SqlConnection con, string grnNo, string tableName)
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM " + tableName + " WHERE GRNNo = @GRNNo", con);
            cmd.Parameters.AddWithValue("@GRNNo", grnNo);

            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }

        private void UpdateGRNHdr(SqlConnection con)
        {
            // Update existing record in GRNHdr table
            SqlCommand cmdUpdate = new SqlCommand(@"UPDATE GRNHdr SET 
            SuppCode = @SuppCode,
            InvNo = @InvNo,
            InvDt = @InvDt,
            GAmt = @GAmt,
            TaxName = @TaxName,
            TaxAmt = @TaxAmt,
            OtherCharges = @OtherCharges,
            NAmt = @NAmt
            WHERE GRNNo = @GRNNo", con);

            // Set parameters
            cmdUpdate.Parameters.AddWithValue("@GRNNo", textBoxGRNNo.Text);
            cmdUpdate.Parameters.AddWithValue("@SuppCode", textBoxSuppCode.Text);
            cmdUpdate.Parameters.AddWithValue("@InvNo", textBoxBillNo.Text);
            cmdUpdate.Parameters.AddWithValue("@InvDt", dateTimePickerBillDate.Value.ToString("yyyy-MM-dd"));
            cmdUpdate.Parameters.AddWithValue("@GAmt", textBoxGAmt.Text);
            cmdUpdate.Parameters.AddWithValue("@TaxName", textBoxTaxName.Text);
            cmdUpdate.Parameters.AddWithValue("@TaxAmt", textBoxTaxAmt.Text);
            cmdUpdate.Parameters.AddWithValue("@OtherCharges", textBoxOtherCharges.Text);
            cmdUpdate.Parameters.AddWithValue("@NAmt", textBoxNAmount.Text);

            cmdUpdate.ExecuteNonQuery();
        }

        private void InsertGRNHdr(SqlConnection con)
        {
            // Insert new record into GRNHdr table
            SqlCommand cmdInsert = new SqlCommand(@"INSERT INTO GRNHdr (GRNNo, SuppCode, InvNo, InvDt, GAmt, TaxName, TaxAmt, OtherCharges, NAmt) 
             VALUES (@GRNNo, @SuppCode, @InvNo, @InvDt, @GAmt, @TaxName, @TaxAmt, @OtherCharges, @NAmt)", con);

            // Set parameters
            cmdInsert.Parameters.AddWithValue("@GRNNo", textBoxGRNNo.Text);
            cmdInsert.Parameters.AddWithValue("@SuppCode", textBoxSuppCode.Text);
            cmdInsert.Parameters.AddWithValue("@InvNo", textBoxBillNo.Text);
            cmdInsert.Parameters.AddWithValue("@InvDt", dateTimePickerBillDate.Value.ToString("yyyy-MM-dd"));
            cmdInsert.Parameters.AddWithValue("@GAmt", textBoxGAmt.Text);
            cmdInsert.Parameters.AddWithValue("@TaxName", textBoxTaxName.Text);
            cmdInsert.Parameters.AddWithValue("@TaxAmt", textBoxTaxAmt.Text);
            cmdInsert.Parameters.AddWithValue("@OtherCharges", textBoxOtherCharges.Text);
            cmdInsert.Parameters.AddWithValue("@NAmt", textBoxNAmount.Text);

            cmdInsert.ExecuteNonQuery();
        }

        private void SaveDataToGRNLin(SqlConnection con)
        {
            foreach (DataGridViewRow row in dataGridViewGRN.Rows)
            {
                // Check if the row is not a new row (which might be empty)
                if (!row.IsNewRow)
                {
                    DataGridViewCell itCodeCell = row.Cells["ItCode"];

                    // Check if the cell is not null and if its value is not null or empty
                    if (itCodeCell != null && itCodeCell.Value != null && !string.IsNullOrEmpty(itCodeCell.Value.ToString()))
                    {
                        string ItCode = itCodeCell.Value.ToString();

                        // Check if the data already exists for the current ItCode and GRNNo
                        bool dataExists = CheckDataExistsInGRNLin(con, textBoxGRNNo.Text, ItCode);

                        if (dataExists)
                        {
                            // If data exists, perform an update
                            UpdateGRNLin(con, ItCode, row);
                        }
                        else
                        {
                            // If data doesn't exist, perform an insertion
                            InsertGRNLin(con, row);
                        }
                    }
                }
            }
        }


        private bool CheckDataExistsInGRNLin(SqlConnection con, string grnNo, string itCode)
        {
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM GRNLin WHERE GRNNo = @GRNNo AND ItCode = @ItCode", con);
            cmd.Parameters.AddWithValue("@GRNNo", grnNo);
            cmd.Parameters.AddWithValue("@ItCode", itCode);

            int count = (int)cmd.ExecuteScalar();
            return count > 0;
        }

        private void UpdateGRNLin(SqlConnection con, string itCode, DataGridViewRow row)
        {
            // Update existing record in GRNLin table
            SqlCommand cmdUpdate = new SqlCommand(@"UPDATE GRNLin SET 
            ItQty = @ItQty,
            ItRate = @ItRate,
            ItAmt = @ItAmt
            WHERE GRNNo = @GRNNo AND ItCode = @ItCode", con);

            // Set parameters
            cmdUpdate.Parameters.AddWithValue("@GRNNo", textBoxGRNNo.Text);
            cmdUpdate.Parameters.AddWithValue("@ItCode", itCode);
            cmdUpdate.Parameters.AddWithValue("@ItQty", row.Cells["ItQty"].Value.ToString());
            cmdUpdate.Parameters.AddWithValue("@ItRate", row.Cells["ItRate"].Value.ToString());
            cmdUpdate.Parameters.AddWithValue("@ItAmt", row.Cells["ItAmt"].Value.ToString());

            cmdUpdate.ExecuteNonQuery();
        }

        private void InsertGRNLin(SqlConnection con, DataGridViewRow row)
        {
            // Insert new record into GRNLin table
            SqlCommand cmdInsert = new SqlCommand(@"INSERT INTO GRNLin (GRNNo, InvDt, ItCode, ItQty, ItRate, ItAmt) 
        VALUES (@GRNNo, @InvDt, @ItCode, @ItQty, @ItRate, @ItAmt)", con);

            // Set parameters
            cmdInsert.Parameters.AddWithValue("@GRNNo", textBoxGRNNo.Text);
            cmdInsert.Parameters.AddWithValue("@InvDt", dateTimePickerBillDate.Value.ToString("yyyy-MM-dd"));
            cmdInsert.Parameters.AddWithValue("@ItCode", row.Cells["ItCode"].Value.ToString());
            cmdInsert.Parameters.AddWithValue("@ItQty", row.Cells["ItQty"].Value.ToString());
            cmdInsert.Parameters.AddWithValue("@ItRate", row.Cells["ItRate"].Value.ToString());
            cmdInsert.Parameters.AddWithValue("@ItAmt", row.Cells["ItAmt"].Value.ToString());

            cmdInsert.ExecuteNonQuery();
        }

        void Display()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select GRNNo, SuppCode, InvNo, InvDt, GAmt, TaxName, TaxAmt, OtherCharges, NAmt from GRNHdr ORDER BY GRNNo DESC", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                gRNHdrDataGridView.Rows.Clear();

                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow item in dt.Rows)
                    {
                        int n = gRNHdrDataGridView.Rows.Add();

                        // Assuming your DataGridView columns are already defined in the designer

                        // Check if the column exists before accessing it
                        gRNHdrDataGridView.Rows[n].Cells["GRNNo"].Value = item["GRNNo"].ToString();
                        gRNHdrDataGridView.Rows[n].Cells["SuppCode"].Value = item["SuppCode"].ToString();
                        gRNHdrDataGridView.Rows[n].Cells["InvNo"].Value = item["InvNo"].ToString();
                        gRNHdrDataGridView.Rows[n].Cells["InvDt"].Value = item["InvDt"].ToString();
                        gRNHdrDataGridView.Rows[n].Cells["GAmt"].Value = item["GAmt"].ToString();
                        gRNHdrDataGridView.Rows[n].Cells["TaxName"].Value = item["TaxName"].ToString();
                        gRNHdrDataGridView.Rows[n].Cells["TaxAmt"].Value = item["TaxAmt"].ToString();
                        gRNHdrDataGridView.Rows[n].Cells["OtherCharges"].Value = item["OtherCharges"].ToString();
                        gRNHdrDataGridView.Rows[n].Cells["NAmt"].Value = item["NAmt"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("No data to display.");
                }
            }

        }


        private void dataGridViewGRN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InitializeAutoComplete()
        {
            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT SuppName FROM SuppMast", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string suppName = reader["SuppName"].ToString();
                    autoCompleteCollection.Add(suppName);
                }

                reader.Close();
                con.Close();
            }

            textBoxSuppName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxSuppName.AutoCompleteSource = AutoCompleteSource.CustomSource;
            textBoxSuppName.AutoCompleteCustomSource = autoCompleteCollection;
        }


        private void textBoxSuppName_TextChanged(object sender, EventArgs e)
        {
            string enteredSuppName = textBoxSuppName.Text.Trim();

            if (string.IsNullOrWhiteSpace(enteredSuppName))
            {
                textBoxSuppCode.Text = string.Empty; // Clear textBoxSuppCode if textBoxSuppName is empty
                return;
            }

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT SuppCode FROM SuppMast WHERE SuppName = @SuppName", con);
                cmd.Parameters.AddWithValue("@SuppName", enteredSuppName);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string suppCode = reader["SuppCode"].ToString();
                    textBoxSuppCode.Text = suppCode;
                }
                else
                {
                    textBoxSuppCode.Text = string.Empty; // Clear textBoxSuppCode if no matching SuppName found
                }

                reader.Close();
                con.Close();
            }

        }

        private string GenerateGRNNo()
        {
            string prefix = "GRN/";
            string dateFormat = DateTime.Now.ToString("yyMMdd");

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT MAX(RIGHT(GRNNo, 3)) FROM GRNHdr WHERE SUBSTRING(GRNNo, 5, 6) = @CurrentDate", con);
                cmd.Parameters.AddWithValue("@CurrentDate", dateFormat);

                object result = cmd.ExecuteScalar();
                int serialNumber = (result == DBNull.Value) ? 1 : Convert.ToInt32(result) + 1;

                string formattedSerialNumber = serialNumber.ToString("000");
                string generatedGRNNo = $"{prefix}{dateFormat}/{formattedSerialNumber}";

                con.Close();

                return generatedGRNNo;
            }
        }

        private void InitializeGridViewAutoComplete()
        {
            // Setting up auto-complete for the "ItName" column
            DataGridViewComboBoxColumn ItName = (DataGridViewComboBoxColumn)dataGridViewGRN.Columns["ItName"]; // Replace "ItName" with the actual column name
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

        private void dataGridViewGRN_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0 && dataGridViewGRN.Columns[e.ColumnIndex].Name == "ItCode")
            {
                // Fetch data from ItMast based on ItCode
                string selectedItCode = dataGridViewGRN.Rows[e.RowIndex].Cells["ItCode"].Value?.ToString();

                if (!string.IsNullOrEmpty(selectedItCode))
                {
                    FetchItMastData(selectedItCode, e.RowIndex);
                }
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = dataGridViewGRN.Rows[e.RowIndex].Cells[e.ColumnIndex];

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
                                dataGridViewGRN.Rows[e.RowIndex].Cells["ItCode"].Value = reader["ItCode"].ToString();
                                dataGridViewGRN.Rows[e.RowIndex].Cells["ItRate"].Value = reader["ItRate"].ToString();
                                dataGridViewGRN.Rows[e.RowIndex].Cells["ItUnit"].Value = reader["ItUnit"].ToString();
                            }
                            else
                            {
                                // Clear ItCode, ItRate, ItUnit if no matching ItName found
                                dataGridViewGRN.Rows[e.RowIndex].Cells["ItCode"].Value = string.Empty;
                                dataGridViewGRN.Rows[e.RowIndex].Cells["ItRate"].Value = string.Empty;
                                dataGridViewGRN.Rows[e.RowIndex].Cells["ItUnit"].Value = string.Empty;
                            }

                            reader.Close();
                            con.Close();
                        }
                    }
                }
            }

            // Check if the changed cell is in "ItQty" or "ItRate" column
            if (e.RowIndex >= 0 && (dataGridViewGRN.Columns[e.ColumnIndex].Name == "ItQty" || dataGridViewGRN.Columns[e.ColumnIndex].Name == "ItRate"))
            {
                DataGridViewCell qtyCell = dataGridViewGRN.Rows[e.RowIndex].Cells["ItQty"];
                DataGridViewCell rateCell = dataGridViewGRN.Rows[e.RowIndex].Cells["ItRate"];
                DataGridViewCell amtCell = dataGridViewGRN.Rows[e.RowIndex].Cells["ItAmt"];

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
            if (e.RowIndex >= 0 && dataGridViewGRN.Columns[e.ColumnIndex].Name == "ItAmt")
            {
                // Recalculate the total sum of the "ItAmt" column
                decimal totalAmount = 0;

                foreach (DataGridViewRow row in dataGridViewGRN.Rows)
                {
                    // Check if the cell value is not null and a valid decimal
                    if (row.Cells["ItAmt"].Value != null && decimal.TryParse(row.Cells["ItAmt"].Value.ToString(), out decimal amount))
                    {
                        totalAmount += amount;
                    }
                }

                // Show the total sum in textBoxGAmt
                textBoxGAmt.Text = totalAmount.ToString();
            }

        }

        private void gRNHdrDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (gRNHdrDataGridView.CurrentRow != null)
            {
                // Get the value of the "GRNNo" column in the selected row
                string selectedGRNNo = gRNHdrDataGridView.CurrentRow.Cells["GRNNo"].Value?.ToString();

                if (!string.IsNullOrEmpty(selectedGRNNo))
                {
                    // Fetch data from the database based on the selected GRNNo
                    FetchDataFromDatabase(selectedGRNNo);
                }
            }
        }

        private void FetchDataFromDatabase(string selectedGRNNo)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Fetch data from GRNHdr table
                string query = "SELECT * FROM GRNHdr WHERE GRNNo = @GRNNo";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@GRNNo", selectedGRNNo);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Populate data into respective textboxes and controls
                    textBoxGRNNo.Text = reader["GRNNo"].ToString();
                    textBoxSuppCode.Text = reader["SuppCode"].ToString();
                    textBoxBillNo.Text = reader["InvNo"].ToString();
                    dateTimePickerBillDate.Value = Convert.ToDateTime(reader["InvDt"]);
                    textBoxGAmt.Text = reader["GAmt"].ToString();
                    textBoxTaxName.Text = reader["TaxName"].ToString();
                    textBoxTaxAmt.Text = reader["TaxAmt"].ToString();
                    textBoxOtherCharges.Text = reader["OtherCharges"].ToString();
                    textBoxNAmount.Text = reader["NAmt"].ToString();

                    // Fetch data from SuppMast table based on SuppCode
                    FetchSuppMastData(reader["SuppCode"].ToString());

                    // Fetch data from GRNLin table based on GRNNo
                    FetchGRNLinData(selectedGRNNo);
                }

                reader.Close();
                con.Close();
            }
        }
        /*
        private void textBoxSuppCode_TextChanged(object sender, EventArgs e)
        {
            string suppCode = textBoxSuppCode.Text.Trim();

            if (!string.IsNullOrEmpty(suppCode))
            {
                // Fetch data from SuppMast based on SuppCode
                FetchSuppMastData(suppCode);
            }
            else
            {
                // Clear textBoxSuppName if textBoxSuppCode is empty
                textBoxSuppName.Text = string.Empty;
            }
        }
        */

        private void FetchSuppMastData(string suppCode)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Fetch data from SuppMast table based on SuppCode
                string query = "SELECT SuppName FROM SuppMast WHERE SuppCode = @SuppCode";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@SuppCode", suppCode);

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // Display SuppName in textBoxSuppName
                    textBoxSuppName.Text = reader["SuppName"].ToString();
                }
                else
                {
                    // Clear textBoxSuppName if no matching SuppCode found
                    textBoxSuppName.Text = string.Empty;
                }

                reader.Close();
                con.Close();
            }
        }


        private void FetchGRNLinData(string selectedGRNNo)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Fetch data from GRNLin table based on GRNNo
                string query = "SELECT ItCode, ItQty, ItAmt FROM GRNLin WHERE GRNNo = @GRNNo";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@GRNNo", selectedGRNNo);

                SqlDataReader reader = cmd.ExecuteReader();

                // Clear existing rows in dataGridViewGRN
                dataGridViewGRN.Rows.Clear();

                while (reader.Read())
                {
                    int n = dataGridViewGRN.Rows.Add();

                    // Populate data into dataGridViewGRN columns
                    dataGridViewGRN.Rows[n].Cells["ItCode"].Value = reader["ItCode"].ToString();
                    dataGridViewGRN.Rows[n].Cells["ItQty"].Value = reader["ItQty"].ToString();
                    dataGridViewGRN.Rows[n].Cells["ItAmt"].Value = reader["ItAmt"].ToString();
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
                    dataGridViewGRN.Rows[rowIndex].Cells["ItName"].Value = reader["ItName"].ToString();
                    dataGridViewGRN.Rows[rowIndex].Cells["ItUnit"].Value = reader["ItUnit"].ToString();
                    dataGridViewGRN.Rows[rowIndex].Cells["ItRate"].Value = reader["ItRate"].ToString();
                }

                reader.Close();
                con.Close();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            // Ensure that the user has selected a row in the gRNHdrDataGridView
            if (gRNHdrDataGridView.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = gRNHdrDataGridView.SelectedRows[0];

                // Retrieve the value from the "Id" column and set it to idToDelete
                string idToDelete = selectedRow.Cells["GRNNo"].Value.ToString();

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
                        using (SqlCommand cmdDischargeLin = new SqlCommand("DELETE FROM GRNLin WHERE GRNNo = @GRNNo", con, transaction))
                        {
                            cmdDischargeLin.Parameters.AddWithValue("@GRNNo", idToDelete);
                            cmdDischargeLin.ExecuteNonQuery();
                        }

                        // Then delete from Discharge table
                        using (SqlCommand cmdDischarge = new SqlCommand("DELETE FROM GRNHdr WHERE GRNNo = @GRNNo", con, transaction))
                        {
                            cmdDischarge.Parameters.AddWithValue("@GRNNo", idToDelete);
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
