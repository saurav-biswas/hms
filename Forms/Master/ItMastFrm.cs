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

namespace HMS.Forms.Master
{
    public partial class ItMastFrm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["HMS.Properties.Settings.HMSConnectionString"].ConnectionString;
        //SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=HMS;Integrated Security=True");
        private string prefix = "IT"; // Define your prefix here
        public ItMastFrm()
        {
            InitializeComponent();
            LoadData(); // Load data initially when the form loads
            dataGridViewItMast.MouseDoubleClick += dataGridViewItMast_MouseDoubleClick;
        }

        private void buttonCatMast_Click(object sender, EventArgs e)
        {
            ItCatFrm myForm = new ItCatFrm();

            myForm.ShowDialog();
        }

        private void ItMastFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet.ItCatMast' table. You can move, or remove it, as needed.
            this.itCatMastTableAdapter.Fill(this.hMSDataSet.ItCatMast);
            textBoxItCode.Text = GenerateNextItCode(prefix);
            comboBoxItUnit.SelectedIndex = -1;
            comboBoxCatList.SelectedIndex = -1;

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
                int itStock = Convert.ToInt32(textBoxCurStock.Text);
                decimal itRate = Convert.ToDecimal(textBoxItRate.Text);
                decimal itAmt = Convert.ToDecimal(textBoxItAmt.Text);

                using (SqlConnection con = new SqlConnection(connectionString))
                //using (SqlConnection connection = new SqlConnection(con.ConnectionString))
                {
                    con.Open();

                    string checkIfExistsQuery = "SELECT COUNT(*) FROM ItMast WHERE ItCode = @ItCode";
                    SqlCommand checkIfExistsCommand = new SqlCommand(checkIfExistsQuery, con);
                    checkIfExistsCommand.Parameters.AddWithValue("@ItCode", itCode);

                    int existingCount = (int)checkIfExistsCommand.ExecuteScalar();

                    string query = "";
                    if (existingCount > 0)
                    {
                        query = "UPDATE ItMast SET ItName = @ItName, ItCat = @ItCat, ItUnit = @ItUnit, ItStock = @ItStock, ItRate = @ItRate, ItAmt = @ItAmt WHERE ItCode = @ItCode";
                    }
                    else
                    {
                        query = "INSERT INTO ItMast (ItCode, ItName, ItCat, ItUnit, ItStock, ItRate, ItAmt) VALUES (@ItCode, @ItName, @ItCat, @ItUnit, @ItStock, @ItRate, @ItAmt)";
                    }

                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@ItCode", itCode);
                    command.Parameters.AddWithValue("@ItName", itName);
                    command.Parameters.AddWithValue("@ItCat", itCat);
                    command.Parameters.AddWithValue("@ItUnit", itUnit);
                    command.Parameters.AddWithValue("@ItStock", itStock);
                    command.Parameters.AddWithValue("@ItRate", itRate);
                    command.Parameters.AddWithValue("@ItAmt", itAmt);

                    // Log the SQL query (for debugging purposes)
                    Console.WriteLine("SQL Query: " + command.CommandText);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Operation successful!");

                        // Clear input fields after successful operation
                        textBoxItName.Text = "";
                        comboBoxCatList.SelectedIndex = -1; // Assuming this resets the combo box selection
                        comboBoxItUnit.SelectedIndex = -1; // Assuming this resets the combo box selection
                        textBoxCurStock.Text = "";
                        textBoxItRate.Text = "";
                        textBoxItAmt.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Operation failed!");
                    }

                    LoadData(); // Reload data after saving
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
                    }
                }
            }
        }
    }
}
