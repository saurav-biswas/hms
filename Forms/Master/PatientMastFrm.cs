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

namespace HMS.Forms.Master
{
    public partial class PatientMastFrm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["HMS.Properties.Settings.HMSConnectionString"].ConnectionString;

        public PatientMastFrm()
        {
            InitializeComponent();
            patientMastDataGridView.MouseDoubleClick += patientMastDataGridView_MouseDoubleClick;
        }

       

        private void PatientMastFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet.BloodGroupMast' table. You can move, or remove it, as needed.
            this.bloodGroupMastTableAdapter.Fill(this.hMSDataSet.BloodGroupMast);
            // TODO: This line of code loads data into the 'hMSDataSet.DoctorMast' table. You can move, or remove it, as needed.
            this.doctorMastTableAdapter.Fill(this.hMSDataSet.DoctorMast);
            // TODO: This line of code loads data into the 'hMSDataSet.PatientMast' table. You can move, or remove it, as needed.
            this.patientMastTableAdapter.Fill(this.hMSDataSet.PatientMast);

            Display();
            ClearFields();
        }

        private void PatientMastFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        void Display()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {

                // Retrieve the maximum existing ID from the PatientMast table
                string getMaxIdQuery = "SELECT MAX(Id) FROM PatientMast";

                using (SqlCommand getMaxIdCommand = new SqlCommand(getMaxIdQuery, con))
                {
                    con.Open();
                    object maxId = getMaxIdCommand.ExecuteScalar();

                    if (maxId != DBNull.Value)
                    {
                        // Increment the maximum ID to get the next available ID
                        int nextId = Convert.ToInt32(maxId) + 1;

                        // Display the next available ID in a TextBox or label on your form
                        // Replace idTextBox with the actual control you want to use
                        idTextBox.Text = nextId.ToString();
                    }
                }

                SqlDataAdapter sda = new SqlDataAdapter("Select Id, PatName, PatPhone, PatBalAmt, PatDOB, PatBloodGroup, PatGender, PatCity, PatUnderDr, PatRefferedBy from PatientMast", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                patientMastDataGridView.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = patientMastDataGridView.Rows.Add();

                    patientMastDataGridView.Rows[n].Cells[0].Value = item["Id"].ToString();
                    patientMastDataGridView.Rows[n].Cells[1].Value = item["PatName"].ToString();
                    patientMastDataGridView.Rows[n].Cells[2].Value = item["PatPhone"].ToString();
                    patientMastDataGridView.Rows[n].Cells[3].Value = item["PatBalAmt"].ToString();
                    patientMastDataGridView.Rows[n].Cells[3].Value = item["PatDOB"].ToString();
                    patientMastDataGridView.Rows[n].Cells[3].Value = item["PatBloodGroup"].ToString();
                    patientMastDataGridView.Rows[n].Cells[3].Value = item["PatGender"].ToString();
                    patientMastDataGridView.Rows[n].Cells[3].Value = item["PatCity"].ToString();
                    patientMastDataGridView.Rows[n].Cells[3].Value = item["PatUnderDr"].ToString();
                    patientMastDataGridView.Rows[n].Cells[3].Value = item["PatRefferedBy"].ToString();

                }
            }
        }

        private void ClearFields()
        {
            // Clear all input fields
           // idTextBox.Text = "";
            patNameTextBox.Text = "";
            patQualificationTextBox.Text = "";
            patRefferedByTextBox.Text = "";
            comboBoxReligion.Text = "";
            patAddress1TextBox.Text = "";
            patAddress2TextBox.Text = "";
            patPhoneTextBox.Text = "";
            patEmailTextBox.Text = "";
            patDOBDateTimePicker.Text = "";
            patBloodGroupComboBox.SelectedIndex = -1;
            patGenderComboBox.SelectedIndex = -1;
            patCityTextBox.Text = "";
            patPINTextBox.Text = "";

        }

       


        private void patientMastDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (patientMastDataGridView.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = patientMastDataGridView.SelectedRows[0];

                // Retrieve the value from the "Id" column and set it to idToLoad
                string idToLoad = selectedRow.Cells["Id"].Value.ToString();

                // Load data based on the selected ID
                LoadDataById(idToLoad);
            }
        }


        private void LoadDataById(string id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                string selectQuery = "SELECT * FROM PatientMast WHERE Id = @Id";

                using (SqlCommand selectCommand = new SqlCommand(selectQuery, con))
                {
                    selectCommand.Parameters.AddWithValue("@Id", id);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Load data into respective textboxes and controls
                            idTextBox.Text = reader["Id"].ToString();//
                            patNameTextBox.Text = reader["PatName"].ToString();//
                            patQualificationTextBox.Text = reader["PatQualification"].ToString();//
                            patRefferedByTextBox.Text = reader["PatRefferedBy"].ToString();//
                            comboBoxReligion.Text = reader["PatReligion"].ToString();//
                            patAddress1TextBox.Text = reader["PatAddress1"].ToString();//
                            patAddress2TextBox.Text = reader["PatAddress2"].ToString();//
                            patPhoneTextBox.Text = reader["PatPhone"].ToString();//
                            patEmailTextBox.Text = reader["PatEmail"].ToString();//
                            patDOBDateTimePicker.Text = reader["PatDOB"].ToString();//
                            patBloodGroupComboBox.Text = reader["PatBloodGroup"].ToString();//
                            patGenderComboBox.Text = reader["PatGender"].ToString();//
                            patCityTextBox.Text = reader["PatCity"].ToString();//
                            patPINTextBox.Text = reader["PatPIN"].ToString();//


                           







                        }
                    }
                }

                con.Close();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            // Ensure that the user has selected a row in the IPDdataGridView
            if (patientMastDataGridView.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = patientMastDataGridView.SelectedRows[0];

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

                // Check if there are related records in the IPD table
                string checkQuery = "SELECT COUNT(*) FROM IPD WHERE PatID = @PatID";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, con))
                {
                    checkCmd.Parameters.AddWithValue("@PatID", idToDelete);

                    int relatedRecordCount = (int)checkCmd.ExecuteScalar();

                    if (relatedRecordCount > 0)
                    {
                        MessageBox.Show("Cannot delete the record because it has related records in the IPD table.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return; // Exit the method without performing deletion
                    }
                }

                // If there are no related records, proceed with deletion
                string deleteQuery = "DELETE FROM PatientMast WHERE Id = @Id";

                using (SqlCommand cmd = new SqlCommand(deleteQuery, con))
                {
                    cmd.Parameters.AddWithValue("@Id", idToDelete);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record deleted successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            Display();
            ClearFields();
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                // Check if the Id already exists in the database
                string checkQuery = "SELECT COUNT(*) FROM PatientMast WHERE Id = @Id";

                using (SqlCommand checkCommand = new SqlCommand(checkQuery, con))
                {
                    checkCommand.Parameters.AddWithValue("@Id", idTextBox.Text);
                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        // Id exists, perform UPDATE
                        string updateQuery = "UPDATE PatientMast SET PatName = @PatName, PatQualification = @PatQualification, PatRefferedBy = @PatRefferedBy, PatReligion = @PatReligion, PatAddress1 = @PatAddress1, PatAddress2 = @PatAddress2, PatPhone = @PatPhone, PatEmail = @PatEmail, PatDOB = @PatDOB, PatBloodGroup = @PatBloodGroup, PatGender = @PatGender, PatCity = @PatCity, PatPIN = @PatPIN " +
                                             "WHERE Id = @Id";

                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, con))
                        {
                            updateCommand.Parameters.AddWithValue("@Id", idTextBox.Text);
                            updateCommand.Parameters.AddWithValue("@PatName", patNameTextBox.Text);
                            updateCommand.Parameters.AddWithValue("@PatQualification", patQualificationTextBox.Text);
                            updateCommand.Parameters.AddWithValue("@PatRefferedBy", patRefferedByTextBox.Text);
                            updateCommand.Parameters.AddWithValue("@PatReligion", comboBoxReligion.Text);
                            updateCommand.Parameters.AddWithValue("@PatAddress1", patAddress1TextBox.Text);
                            updateCommand.Parameters.AddWithValue("@PatAddress2", patAddress2TextBox.Text);
                            updateCommand.Parameters.AddWithValue("@PatPhone", patPhoneTextBox.Text);
                            updateCommand.Parameters.AddWithValue("@PatEmail", patEmailTextBox.Text);
                            updateCommand.Parameters.AddWithValue("@PatDOB", patDOBDateTimePicker.Text);
                            updateCommand.Parameters.AddWithValue("@PatBloodGroup", patBloodGroupComboBox.Text);
                            updateCommand.Parameters.AddWithValue("@PatGender", patGenderComboBox.Text);
                            updateCommand.Parameters.AddWithValue("@PatCity", patCityTextBox.Text);
                            updateCommand.Parameters.AddWithValue("@PatPIN", patPINTextBox.Text);



                            // Execute the update query
                            updateCommand.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        // BedNumber doesn't exist, perform INSERT
                        string insertQuery = "INSERT INTO PatientMast (PatName, PatQualification, PatRefferedBy, PatReligion, PatAddress1, PatAddress2, PatPhone, PatEmail, PatDOB, PatBloodGroup, PatGender, PatCity, PatPIN) " +
                                             "VALUES (@PatName, @PatQualification, @PatRefferedBy, @PatReligion, @PatAddress1, @PatAddress2, @PatPhone, @PatEmail, @PatDOB, @PatBloodGroup , @PatGender , @PatCity, @PatPIN)";

                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, con))
                        {
                            insertCommand.Parameters.AddWithValue("@Id", idTextBox.Text);
                            insertCommand.Parameters.AddWithValue("@PatName", patNameTextBox.Text);
                            insertCommand.Parameters.AddWithValue("@PatQualification", patQualificationTextBox.Text);
                            insertCommand.Parameters.AddWithValue("@PatRefferedBy", patRefferedByTextBox.Text);
                            insertCommand.Parameters.AddWithValue("@PatReligion", comboBoxReligion.Text);
                            insertCommand.Parameters.AddWithValue("@PatAddress1", patAddress1TextBox.Text);
                            insertCommand.Parameters.AddWithValue("@PatAddress2", patAddress2TextBox.Text);
                            insertCommand.Parameters.AddWithValue("@PatPhone", patPhoneTextBox.Text);
                            insertCommand.Parameters.AddWithValue("@PatEmail", patEmailTextBox.Text);
                            insertCommand.Parameters.AddWithValue("@PatDOB", patDOBDateTimePicker.Text);
                            insertCommand.Parameters.AddWithValue("@PatBloodGroup", patBloodGroupComboBox.Text);
                            insertCommand.Parameters.AddWithValue("@PatGender", patGenderComboBox.Text);
                            insertCommand.Parameters.AddWithValue("@PatCity", patCityTextBox.Text);
                            insertCommand.Parameters.AddWithValue("@PatPIN", patPINTextBox.Text);

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
    }
}
