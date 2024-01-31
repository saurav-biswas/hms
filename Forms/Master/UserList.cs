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

namespace HMS.Forms.Master
{
    public partial class UserList : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["HMS.Properties.Settings.HMSConnectionString"].ConnectionString;

        public UserList()
        {
            InitializeComponent();
            textBoxUsername.TextChanged += textBoxUsername_TextChanged;
        }


        private void UserList_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Check if passwords match
            if (textBoxPass.Text != textBoxCpass.Text)
            {
                MessageBox.Show("Passwords do not match. Please re-enter your password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method if passwords don't match
            }

            // Assuming you have textboxes for user input
            string username = textBoxUsername.Text;
            string fullName = textBoxFullName.Text;
            string password = textBoxPass.Text;

            // Perform any other validation or processing before saving

            // Save user data to the database
            try
            {
                // Establish a connection using the connection string
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["HMS.Properties.Settings.HMSConnectionString"].ConnectionString))
                {
                    connection.Open(); // Open the connection

                    // Create a command with parameters to insert or update the data
                    string query = "IF NOT EXISTS (SELECT 1 FROM Users WHERE Username = @Username) " +
                                   "INSERT INTO Users (Username, FullName, Password) VALUES (@Username, @FullName, @Password) " +
                                   "ELSE " +
                                   "UPDATE Users SET FullName = @FullName, Password = @Password WHERE Username = @Username";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters to the command
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@FullName", fullName);
                        command.Parameters.AddWithValue("@Password", password);

                        // Execute the command
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("User data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Clear the text fields after successful save
                
                textBoxUsername.Text = "";
                textBoxFullName.Text = "";
                textBoxPass.Text = "";
                textBoxCpass.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Display();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            // Ensure that the user has selected a row in the IPDdataGridView
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridViewUsers.SelectedRows[0];

                // Retrieve the value from the "IPD" column and set it to idToDelete
                string idToDelete = selectedRow.Cells["Username"].Value.ToString();

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
                        using (SqlCommand cmdDischarge = new SqlCommand("DELETE FROM Users WHERE Username = @Username", con, transaction))
                        {
                            cmdDischarge.Parameters.AddWithValue("@Username", idToDelete);
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

        void Display()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlDataAdapter sda = new SqlDataAdapter("Select * from Users ORDER BY Username ASC", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridViewUsers.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {

                    int n = dataGridViewUsers.Rows.Add();

                    dataGridViewUsers.Rows[n].Cells[0].Value = item["Username"].ToString();
                    dataGridViewUsers.Rows[n].Cells[1].Value = item["FullName"].ToString();
                    

                }
            }

        }

        private void dataGridViewUsers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Check if a row is clicked
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridViewUsers.SelectedRows[0];

                // Access the data from the selected row
                string username = selectedRow.Cells["Username"].Value.ToString();
                

                // Populate the textboxes with the data
                textBoxUsername.Text = username;
            }
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            // Get the username from textBoxUsername
            string username = textBoxUsername.Text;

            // SQL query to retrieve data based on the username
            string query = "SELECT Fullname, Password FROM Users WHERE Username = @Username";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    // Add parameters to the query to prevent SQL injection
                    command.Parameters.AddWithValue("@Username", username);

                    try
                    {
                        // Open the connection
                        con.Open();

                        // Execute the query and read the data
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Set the retrieved data to the respective textboxes
                                textBoxFullName.Text = reader["Fullname"].ToString();
                                textBoxPass.Text = reader["Password"].ToString();
                                textBoxCpass.Text = reader["Password"].ToString();
                            }
                            else
                            {
                                // Handle the case where the username is not found
                                textBoxFullName.Text = string.Empty;
                                textBoxPass.Text = string.Empty;
                                textBoxCpass.Text = string.Empty;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions that may occur during the database operation
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
