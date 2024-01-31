using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace HMS.Forms.Master
{
    public partial class ItCatFrm : Form
    {

        string connectionString = ConfigurationManager.ConnectionStrings["HMS.Properties.Settings.HMSConnectionString"].ConnectionString;
        //SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=HMS;Integrated Security=True");

        private string prefix = "CAT/"; // Define your prefix here

        public ItCatFrm()
        {
            InitializeComponent();
            LoadData();
            dataGridViewCatForm.MouseDoubleClick += dataGridViewCatForm_MouseDoubleClick;

        }

        private void ItCatFrm_Load(object sender, EventArgs e)
        {
            
            textBoxCatID.Text = GenerateCustomID(prefix);
        }

        private void LoadData()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            //using (SqlConnection connection = new SqlConnection(con.ConnectionString))
            {
                con.Open();
                string query = "SELECT CatID, CatName FROM ItCatMast";

                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dataGridViewCatForm.DataSource = dataTable;
            }
        }

        private string GenerateCustomID(string prefix)
        {
            string customID = string.Empty;

            using (SqlConnection con = new SqlConnection(connectionString))
            //using (SqlConnection connection = new SqlConnection(con.ConnectionString))
            {
                con.Open();

                string query = $"SELECT MAX(CatID) FROM ItCatMast WHERE CatID LIKE '{prefix}%'";


                SqlCommand command = new SqlCommand(query, con);
                object result = command.ExecuteScalar();
                int latestNumber = 0;

                if (result != DBNull.Value && result != null)
                {
                    string latestSerial = result.ToString();
                    int.TryParse(latestSerial.Substring(prefix.Length), out latestNumber);
                }

                int nextNumber = latestNumber + 1;
                customID = $"{prefix}{nextNumber:D4}";
            }

            return customID;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string catID = textBoxCatID.Text.Trim();
            string catName = textBoxCatName.Text.Trim();

            using (SqlConnection con = new SqlConnection(connectionString))
            //using (SqlConnection connection = new SqlConnection(con.ConnectionString))
            {
                con.Open();

                string selectQuery = "SELECT CatID FROM ItCatMast WHERE CatID = @catID";
                SqlCommand selectCommand = new SqlCommand(selectQuery, con);
                selectCommand.Parameters.AddWithValue("@catID", catID);

                object result = selectCommand.ExecuteScalar();

                if (result != null) // Update if exists, otherwise insert
                {
                    string updateQuery = "UPDATE ItCatMast SET CatName = @catName WHERE CatID = @catID";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, con);
                    updateCommand.Parameters.AddWithValue("@catName", catName);
                    updateCommand.Parameters.AddWithValue("@catID", catID);
                    updateCommand.ExecuteNonQuery();
                }
                else
                {
                    string insertQuery = "INSERT INTO ItCatMast (CatID, CatName) VALUES (@catID, @catName)";
                    SqlCommand insertCommand = new SqlCommand(insertQuery, con);
                    insertCommand.Parameters.AddWithValue("@catID", catID);
                    insertCommand.Parameters.AddWithValue("@catName", catName);
                    insertCommand.ExecuteNonQuery();
                }
            }
            textBoxCatID.Text = GenerateCustomID(prefix);
            textBoxCatName.Text = "";
            LoadData(); // Refresh the DataGridView after save
        }

        private void dataGridViewCatForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hitTest = dataGridViewCatForm.HitTest(e.X, e.Y);

            if (hitTest.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewCatForm.Rows[hitTest.RowIndex];

                // Assuming CatID is in the first column (index 0) and CatName is in the second column (index 1)
                textBoxCatID.Text = row.Cells[0].Value.ToString();
                textBoxCatName.Text = row.Cells[1].Value.ToString();
            }
        }

        private void ItCatFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        // Other form initialization code and event handlers...
    }
}
