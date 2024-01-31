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
using System.Windows.Forms.VisualStyles;

namespace HMS.Forms.Master
{
    public partial class DoctorMastFrm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["HMS.Properties.Settings.HMSConnectionString"].ConnectionString;
        public DoctorMastFrm()
        {
            InitializeComponent();
            doctorMastDataGridView.MouseDoubleClick += doctorMastDataGridView_MouseDoubleClick;
        }
      

        private void DoctorMast_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet.BloodGroupMast' table. You can move, or remove it, as needed.
            this.bloodGroupMastTableAdapter.Fill(this.hMSDataSet.BloodGroupMast);
            // TODO: This line of code loads data into the 'hMSDataSet.DoctorMast' table. You can move, or remove it, as needed.
            //this.doctorMastTableAdapter.Fill(this.hMSDataSet.DoctorMast);
            // TODO: This line of code loads data into the 'hMSDataSet.BloodGroupMast' table. You can move, or remove it, as needed.
           // this.bloodGroupMastTableAdapter.Fill(this.hMSDataSet.BloodGroupMast);
            // TODO: This line of code loads data into the 'hMSDataSet.DoctorMast' table. You can move, or remove it, as needed.
            this.doctorMastTableAdapter.Fill(this.hMSDataSet.DoctorMast);
            Display();
            ClearFields();
        }

       

        private void DoctorMastFrm_KeyDown(object sender, KeyEventArgs e)
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

                // Check if the Id already exists in the database
                string checkQuery = "SELECT COUNT(*) FROM DoctorMast WHERE Id = @Id";

                using (SqlCommand checkCommand = new SqlCommand(checkQuery, con))
                {
                    checkCommand.Parameters.AddWithValue("@Id", idTextBox.Text);
                    int count = (int)checkCommand.ExecuteScalar();

                    if (count > 0)
                    {
                        // Id exists, perform UPDATE
                        string updateQuery = "UPDATE DoctorMast SET DocName = @DocName, DocDesignation = @DocDesignation, DocQualification = @DocQualification, DocSpecialist = @DocSpecialist, DocPhone = @DocPhone, DocEmail = @DocEmail, DocDOB = @DocDOB, DocBloodGroup = @DocBloodGroup, DocGender = @DocGender, DocAddress1 = @DocAddress1, DocAddress2 = @DocAddress2, DocCity = @DocCity, DocPIN = @DocPIN " +
                                             "WHERE Id = @Id";

                        using (SqlCommand updateCommand = new SqlCommand(updateQuery, con))
                        {
                            updateCommand.Parameters.AddWithValue("@Id", idTextBox.Text);
                            updateCommand.Parameters.AddWithValue("@DocName", docNameTextBox.Text);
                            updateCommand.Parameters.AddWithValue("@DocDesignation", docDesignationTextBox.Text);
                            updateCommand.Parameters.AddWithValue("@DocQualification", docQualificationTextBox.Text);
                            updateCommand.Parameters.AddWithValue("@DocSpecialist", docSpecialistTextBox.Text);
                            updateCommand.Parameters.AddWithValue("@DocPhone", docPhoneTextBox.Text);
                            updateCommand.Parameters.AddWithValue("@DocEmail", docEmailTextBox.Text);
                            updateCommand.Parameters.AddWithValue("@DocDOB", docDOBDateTimePicker.Text);
                            updateCommand.Parameters.AddWithValue("@DocBloodGroup", docBloodGroupComboBox.Text);
                            updateCommand.Parameters.AddWithValue("@DocGender", docGenderComboBox.Text);
                            updateCommand.Parameters.AddWithValue("@DocAddress1", docAddress1TextBox.Text);
                            updateCommand.Parameters.AddWithValue("@DocAddress2", docAddress2TextBox.Text);
                            updateCommand.Parameters.AddWithValue("@DocCity", docCityTextBox.Text);
                            updateCommand.Parameters.AddWithValue("@DocPIN", docPINTextBox.Text);



                            // Execute the update query
                            updateCommand.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        // BedNumber doesn't exist, perform INSERT
                        string insertQuery = "INSERT INTO DoctorMast (Id, DocName, DocDesignation, DocQualification, DocSpecialist, DocPhone, DocEmail, DocDOB, DocBloodGroup, DocGender, DocAddress1, DocAddress2, DocCity, DocPIN ) " +
                                             "VALUES (@Id, @DocName, @DocDesignation, @DocQualification, @DocSpecialist, @DocPhone, @DocEmail, @DocDOB, @DocBloodGroup, @DocGender, @DocAddress1, @DocAddress2, @DocCity, @DocPIN)";

                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, con))
                        {
                            insertCommand.Parameters.AddWithValue("@Id", idTextBox.Text);
                            insertCommand.Parameters.AddWithValue("@DocName", docNameTextBox.Text);
                            insertCommand.Parameters.AddWithValue("@DocDesignation", docDesignationTextBox.Text);
                            insertCommand.Parameters.AddWithValue("@DocQualification", docQualificationTextBox.Text);
                            insertCommand.Parameters.AddWithValue("@DocSpecialist", docSpecialistTextBox.Text);
                            insertCommand.Parameters.AddWithValue("@DocPhone", docPhoneTextBox.Text);
                            insertCommand.Parameters.AddWithValue("@DocEmail", docEmailTextBox.Text);
                            insertCommand.Parameters.AddWithValue("@DocDOB", docDOBDateTimePicker.Text);
                            insertCommand.Parameters.AddWithValue("@DocBloodGroup", docBloodGroupComboBox.Text);
                            insertCommand.Parameters.AddWithValue("@DocGender", docGenderComboBox.Text);
                            insertCommand.Parameters.AddWithValue("@DocAddress1", docAddress1TextBox.Text);
                            insertCommand.Parameters.AddWithValue("@DocAddress2", docAddress2TextBox.Text);
                            insertCommand.Parameters.AddWithValue("@DocCity", docCityTextBox.Text);
                            insertCommand.Parameters.AddWithValue("@DocPIN", docPINTextBox.Text);

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
                SqlDataAdapter sda = new SqlDataAdapter("Select Id, DocName, DocSpecialist, DocPhone from DoctorMast", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                doctorMastDataGridView.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = doctorMastDataGridView.Rows.Add();

                    doctorMastDataGridView.Rows[n].Cells[0].Value = item["Id"].ToString();
                    doctorMastDataGridView.Rows[n].Cells[1].Value = item["DocName"].ToString();
                    doctorMastDataGridView.Rows[n].Cells[2].Value = item["DocSpecialist"].ToString();
                    doctorMastDataGridView.Rows[n].Cells[3].Value = item["DocPhone"].ToString();
                    
                }
            }
        }

        private void ClearFields()
        {
            // Clear all input fields
            idTextBox.Text = "";
            docNameTextBox.Text = "";
            docDesignationTextBox.Text = "";
            docQualificationTextBox.Text = "";
            docSpecialistTextBox.Text = "";
            docPhoneTextBox.Text = "";
            docEmailTextBox.Text = "";
            docDOBDateTimePicker.Text = "";
            docBloodGroupComboBox.SelectedIndex = -1;
            docGenderComboBox.SelectedIndex = -1;
            docAddress1TextBox.Text = "";
            docAddress2TextBox.Text = "";
            docCityTextBox.Text = "";
            docPINTextBox.Text = "";

        }

        private void buttonDel_Click(object sender, EventArgs e)
        {

            // Ensure that the user has selected a row in the IPDdataGridView
            if (doctorMastDataGridView.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = doctorMastDataGridView.SelectedRows[0];

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
                        using (SqlCommand cmdDischarge = new SqlCommand("DELETE FROM DoctorMast WHERE Id = @Id", con, transaction))
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
            ClearFields();

        }

        private void doctorMastDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (doctorMastDataGridView.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = doctorMastDataGridView.SelectedRows[0];

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

                string selectQuery = "SELECT * FROM DoctorMast WHERE Id = @Id";

                using (SqlCommand selectCommand = new SqlCommand(selectQuery, con))
                {
                    selectCommand.Parameters.AddWithValue("@Id", id);

                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Load data into respective textboxes and controls
                            idTextBox.Text = reader["Id"].ToString();
                            docNameTextBox.Text = reader["DocName"].ToString();
                            docDesignationTextBox.Text = reader["DocDesignation"].ToString();
                            docQualificationTextBox.Text = reader["DocQualification"].ToString();
                            docSpecialistTextBox.Text = reader["DocSpecialist"].ToString();
                            docPhoneTextBox.Text = reader["DocPhone"].ToString();
                            docEmailTextBox.Text = reader["DocEmail"].ToString();
                            docDOBDateTimePicker.Text = reader["DocDOB"].ToString();
                            docBloodGroupComboBox.Text = reader["DocBloodGroup"].ToString();


                            string genderValue = reader["DocGender"].ToString();
                            if (docGenderComboBox.Items.Cast<string>().Any(item => item.Equals(genderValue, StringComparison.OrdinalIgnoreCase)))
                            {
                                docGenderComboBox.SelectedItem = genderValue;
                            }
                            else
                            {
                                // If the gender value is not in the combo box items, add it
                                docGenderComboBox.Items.Add(genderValue);
                                docGenderComboBox.SelectedItem = genderValue;
                            }



                            docGenderComboBox.Text = reader["DocGender"].ToString();
                            docAddress1TextBox.Text = reader["DocAddress1"].ToString();
                            docAddress2TextBox.Text = reader["DocAddress2"].ToString();
                            docCityTextBox.Text = reader["DocCity"].ToString();
                            docPINTextBox.Text = reader["DocPIN"].ToString();
                        }
                    }
                }

                con.Close();
            }
        }
    }
}
