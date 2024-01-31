using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Xamarin.Forms;
using HMS.Reports;

namespace HMS.Forms.Master
{
    public partial class ItMastFrm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["HMS.Properties.Settings.HMSConnectionString"].ConnectionString;
        
        private string prefix = "IT"; // Define your prefix here
        public ItMastFrm()
        {
            InitializeComponent();
             // Load data initially when the form loads
            dataGridViewItMast.MouseDoubleClick += dataGridViewItMast_MouseDoubleClick;
        }

        private void buttonCatMast_Click(object sender, EventArgs e)
        {
            ItCatFrm myForm = new ItCatFrm();

            myForm.ShowDialog();
        }

        private void ItMastFrm_Load(object sender, EventArgs e)
        {
            // Calculate and update ItStock for each ItCode
            
            // TODO: This line of code loads data into the 'hMSDataSet.ItCatMast' table. You can move, or remove it, as needed.
            this.itCatMastTableAdapter.Fill(this.hMSDataSet.ItCatMast);
            textBoxItCode.Text = GenerateNextItCode(prefix);
            comboBoxItUnit.SelectedIndex = -1;
            comboBoxCatList.SelectedIndex = -1;
            
            LoadData();
            UpdateItStockAndAmt();

        }
        private void LoadData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            //using (SqlConnection connection = new SqlConnection(con.ConnectionString))
            {
                con.Open();
                string query = "SELECT * FROM ItMast";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewItMast.DataSource = dt;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                string itCode = textBoxItCode.Text;
                string itName = textBoxItName.Text;
                string itCat = comboBoxCatList.Text;
                string itUnit = comboBoxItUnit.Text;
                decimal itStock = Convert.ToDecimal(textBoxCurStock.Text);
                decimal itRate = Convert.ToDecimal(textBoxItRate.Text);
                decimal itAmt = Convert.ToDecimal(textBoxItAmt.Text);
                decimal itOpStk = Convert.ToDecimal(textBoxOpeningStk.Text); // Assuming textBoxOpeningStk is the control for opening stock

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string checkIfExistsQuery = "SELECT COUNT(*) FROM ItMast WHERE ItCode = @ItCode";
                    SqlCommand checkIfExistsCommand = new SqlCommand(checkIfExistsQuery, con);
                    checkIfExistsCommand.Parameters.AddWithValue("@ItCode", itCode);

                    int existingCount = (int)checkIfExistsCommand.ExecuteScalar();

                    string query = "";
                    if (existingCount > 0)
                    {
                        query = "UPDATE ItMast SET ItName = @ItName, ItCat = @ItCat, ItUnit = @ItUnit, ItStock = @ItStock, ItRate = @ItRate, ItAmt = @ItAmt, ItOpStk = @ItOpStk WHERE ItCode = @ItCode";
                    }
                    else
                    {
                        query = "INSERT INTO ItMast (ItCode, ItName, ItCat, ItUnit, ItStock, ItRate, ItAmt, ItOpStk) VALUES (@ItCode, @ItName, @ItCat, @ItUnit, @ItStock, @ItRate, @ItAmt, @ItOpStk)";
                    }

                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@ItCode", itCode);
                    command.Parameters.AddWithValue("@ItName", itName);
                    command.Parameters.AddWithValue("@ItCat", itCat);
                    command.Parameters.AddWithValue("@ItUnit", itUnit);
                    command.Parameters.AddWithValue("@ItStock", itStock);
                    command.Parameters.AddWithValue("@ItRate", itRate);
                    command.Parameters.AddWithValue("@ItAmt", itAmt);
                    command.Parameters.AddWithValue("@ItOpStk", itOpStk);

                    // Log the SQL query (for debugging purposes)
                    Console.WriteLine("SQL Query: " + command.CommandText);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Save successful!");

                        // Clear input fields after successful operation
                        textBoxItName.Text = "";
                        comboBoxCatList.SelectedIndex = -1;
                        comboBoxItUnit.SelectedIndex = -1;
                        textBoxCurStock.Text = "0.00";
                        textBoxItRate.Text = "0.00";
                        textBoxItAmt.Text = "0.00";
                        textBoxOpeningStk.Text = "0.00"; 
                    }
                    else
                    {
                        MessageBox.Show("Save failed!");
                    }

                    LoadData(); // Reload data after saving
                    textBoxItCode.Text = GenerateNextItCode(prefix);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private string GenerateNextItCode(string prefix)
        {
            string customID = string.Empty;

            using (SqlConnection con = new SqlConnection(connectionString))
            //using (SqlConnection connection = new SqlConnection(con.ConnectionString))
            {
                con.Open();

                string query = $"SELECT MAX(ItCode) FROM ItMast WHERE ItCode LIKE '{prefix}%'";

                SqlCommand command = new SqlCommand(query, con);
                object result = command.ExecuteScalar();
                int latestNumber = 0;

                if (result != DBNull.Value && result != null)
                {
                    string latestSerial = result.ToString();
                    int.TryParse(latestSerial.Substring(prefix.Length), out latestNumber);
                }

                int nextNumber = latestNumber + 1;
                customID = $"{prefix}{nextNumber:D6}";
            }

            return customID;
        }

        private void dataGridViewItMast_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridView dataGridView = sender as DataGridView;
            if (dataGridView != null)
            {
                DataGridView.HitTestInfo hitTestInfo = dataGridView.HitTest(e.X, e.Y);
                if (hitTestInfo.Type == DataGridViewHitTestType.Cell)
                {
                    int rowIndex = hitTestInfo.RowIndex;
                    if (rowIndex >= 0)
                    {
                        DataGridViewRow row = dataGridView.Rows[rowIndex];
                        // Retrieve data from the selected row and populate your form fields
                        textBoxItCode.Text = row.Cells["ItCode"].Value.ToString();
                        textBoxItName.Text = row.Cells["ItName"].Value.ToString();
                        comboBoxCatList.Text = row.Cells["ItCat"].Value.ToString();
                        comboBoxItUnit.Text = row.Cells["ItUnit"].Value.ToString();
                        textBoxCurStock.Text = row.Cells["ItStock"].Value.ToString();
                        textBoxItRate.Text = row.Cells["ItRate"].Value.ToString();
                        textBoxItAmt.Text = row.Cells["ItAmt"].Value.ToString();
                        textBoxOpeningStk.Text = row.Cells["ItOpStk"].Value.ToString();
                    }
                }
            }
        }

        private void ItMastFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void UpdateItStockAndAmt()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Update ItStock and calculate ItAmt for each ItCode
                    string updateQuery = @"
                UPDATE ItMast
                SET ItStock = (
                    ISNULL((SELECT SUM(GRNLin.ItQty) FROM GRNLin WHERE GRNLin.ItCode = ItMast.ItCode), 0) 
                    - ISNULL((SELECT SUM(DisposableIssLin.ItQty) FROM DisposableIssLin WHERE DisposableIssLin.ItCode = ItMast.ItCode), 0)
                    + ISNULL(ItMast.ItOpStk, 0)),
                ItAmt = ISNULL(
                    (ISNULL((SELECT SUM(GRNLin.ItQty) FROM GRNLin WHERE GRNLin.ItCode = ItMast.ItCode), 0) 
                    - ISNULL((SELECT SUM(DisposableIssLin.ItQty) FROM DisposableIssLin WHERE DisposableIssLin.ItCode = ItMast.ItCode), 0)
                    + ISNULL(ItMast.ItOpStk, 0))
                    * ItMast.ItRate, 0)
            ";

                    SqlCommand updateCommand = new SqlCommand(updateQuery, con);
                    updateCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating ItStock and ItAmt: " + ex.Message);
            }
        }


        private void textBoxItAmt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCurStock_TextChanged(object sender, EventArgs e)
        {
            UpdateItAmt();
        }

        private void textBoxItRate_TextChanged(object sender, EventArgs e)
        {
            UpdateItAmt();
        }

        private void UpdateItAmt()
        {
            try
            {
                decimal curStock = decimal.TryParse(textBoxCurStock.Text, out decimal stock) ? stock : 0;
                decimal itRate = decimal.TryParse(textBoxItRate.Text, out decimal rate) ? rate : 0;

                decimal itAmt = curStock * itRate;
                textBoxItAmt.Text = itAmt.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating ItAmt: " + ex.Message);
            }
        }

        private void textBoxOpeningStk_TextChanged(object sender, EventArgs e)
        {
            // Assuming textBoxOpeningStk and textBoxCurStock are TextBox controls
            if (double.TryParse(textBoxOpeningStk.Text, out double openingStock))
            {
                // Retrieve the value from the database for "GRNLin"
                double grnQty = GetSumFromDatabase("GRNLin", "ItQty", textBoxItCode.Text);

                // Retrieve the value from the database for "DisposableIssLin"
                double disposableQty = GetSumFromDatabase("DisposableIssLin", "ItQty", textBoxItCode.Text);

                // Calculate the updated value
                double updatedValue = openingStock + grnQty - disposableQty;

                textBoxCurStock.Text = updatedValue.ToString();
               // UpdateItStockAndAmt();
            }
            else
            {
                // Handle the case where the text in textBoxOpeningStk is not a valid integer
                //textBoxCurStock.Text = "0.00";
               // UpdateItStockAndAmt();
            }
        }


        private int GetSumFromDatabase(string tableName, string columnName, string itCode)
        {
            // Use proper database connection and query to get the sum from the specified table and column
            // Note: This is a simplified example, and you should use parameterized queries to prevent SQL injection
            int sum = 0;

            // Replace "YourConnectionString" with your actual database connection string
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string query = $"SELECT SUM({columnName}) FROM {tableName} WHERE ItCode = @ItCode";
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@ItCode", itCode);
                    object result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        sum = Convert.ToInt32(result);
                    }
                }
            }

            return sum;
        }


        private void buttonPrint_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new instance of the Crystal Report document
                Reports.StkStatementDtl rpt = new Reports.StkStatementDtl();

                // Create a DataTable to store the data from the DataGridView
                DataTable dt = (DataTable)dataGridViewItMast.DataSource;


                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn col in dt.Columns)
                    {
                        Console.WriteLine($"{col.ColumnName}: {row[col]}");
                    }
                }


                // Set the DataTable as the report's data source
                rpt.SetDataSource(dt);

                // Create an instance of the Crystal Report Viewer form
                Reports.StkStatementDtlViewer reportViewer = new Reports.StkStatementDtlViewer();

                // Set the report source for the viewer
                reportViewer.crystalReportViewer1.ReportSource = rpt;

                // Show the Crystal Report Viewer form
                reportViewer.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating Crystal Report: " + ex.Message);
            }
        }

        // Inside the ItMastFrm class
        public void HandlePrintRequest()
        {
            try
            {
                Reports.StkStatementDtl rpt = new Reports.StkStatementDtl();
                if (dataGridViewItMast != null && dataGridViewItMast.DataSource is DataTable dt)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        foreach (DataColumn col in dt.Columns)
                        {
                            Console.WriteLine($"{col.ColumnName}: {row[col]}");
                        }
                    }

                    // Set the DataTable as the report's data source
                    rpt.SetDataSource(dt);

                    // Create an instance of the Crystal Report Viewer form
                    Reports.StkStatementDtlViewer reportViewer = new Reports.StkStatementDtlViewer();

                    // Set the report source for the viewer
                    reportViewer.crystalReportViewer1.ReportSource = rpt;

                    // Show the Crystal Report Viewer form
                    reportViewer.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Data source is null or not set.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating Crystal Report: " + ex.Message);
            }
        }



    }

}
