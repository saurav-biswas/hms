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
using System.Security.Cryptography;
using HMS.Reports;
using System.IO;
using System.IO.Ports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.Shared;
using System.Configuration;
using HMS.Forms.Master;

namespace HMS.Forms.Transaction.IPD
{
    public partial class IPDFrm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["HMS.Properties.Settings.HMSConnectionString"].ConnectionString;


        public IPDFrm()
        {
            InitializeComponent();
        }

        private void IPDFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet.DoctorMast' table. You can move, or remove it, as needed.
            this.doctorMastTableAdapter.Fill(this.hMSDataSet.DoctorMast);
            // TODO: This line of code loads data into the 'hMSDataSet.Discharge' table. You can move, or remove it, as needed.
            //this.dischargeTableAdapter.Fill(this.hMSDataSet.Discharge);
            // TODO: This line of code loads data into the 'hMSDataSet.IPD' table. You can move, or remove it, as needed.
            //this.iPDTableAdapter.Fill(this.hMSDataSet.IPD);
            Display();
            if (radioButtonNewPat.Checked)
            {
                SetNextAvailableID();
            }

        }

        private void admissionDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            admissionDateDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }

       
        

        void Display()
        { 
             using (SqlConnection con = new SqlConnection(connectionString))
        {
                SqlDataAdapter sda = new SqlDataAdapter("Select * from IPD ORDER BY Id DESC", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                IPDdataGridView.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {
                    int n = IPDdataGridView.Rows.Add();

                    IPDdataGridView.Rows[n].Cells[0].Value = item ["Id"].ToString();
                    IPDdataGridView.Rows[n].Cells[1].Value = item ["AdmissionDate"].ToString();
                    IPDdataGridView.Rows[n].Cells[2].Value = item ["PatID"].ToString();
                    IPDdataGridView.Rows[n].Cells[3].Value = item ["Patient"].ToString();
                    IPDdataGridView.Rows[n].Cells[4].Value = item ["PrecheckedBy"].ToString();
                    IPDdataGridView.Rows[n].Cells[5].Value = item ["Age"].ToString();
                    IPDdataGridView.Rows[n].Cells[6].Value = item ["Height"].ToString();
                    IPDdataGridView.Rows[n].Cells[7].Value = item ["Weight"].ToString();
                    IPDdataGridView.Rows[n].Cells[8].Value = item ["BloodPressure"].ToString();
                    IPDdataGridView.Rows[n].Cells[9].Value = item ["Symptoms"].ToString();
                    IPDdataGridView.Rows[n].Cells[10].Value = item ["GarName"].ToString();
                    IPDdataGridView.Rows[n].Cells[11].Value = item ["GarRelation"].ToString();
                    IPDdataGridView.Rows[n].Cells[12].Value = item ["GarPhone"].ToString();
                    IPDdataGridView.Rows[n].Cells[13].Value = item ["GarAddress1"].ToString();
                    IPDdataGridView.Rows[n].Cells[14].Value = item ["GarAddress2"].ToString();
                    IPDdataGridView.Rows[n].Cells[15].Value = item ["GarPO"].ToString();
                    IPDdataGridView.Rows[n].Cells[16].Value = item ["GarPS"].ToString();
                    IPDdataGridView.Rows[n].Cells[17].Value = item ["GarCity"].ToString();
                    IPDdataGridView.Rows[n].Cells[18].Value = item ["GarPIN"].ToString();
                    IPDdataGridView.Rows[n].Cells[19].Value = item ["GarCountry"].ToString();
                    IPDdataGridView.Rows[n].Cells[20].Value = item ["AdmitName"].ToString();
                    IPDdataGridView.Rows[n].Cells[21].Value = item ["AdmitRelation"].ToString();
                    IPDdataGridView.Rows[n].Cells[22].Value = item ["AdmitPhone"].ToString();
                    IPDdataGridView.Rows[n].Cells[23].Value = item ["AdmitAddress1"].ToString();
                    IPDdataGridView.Rows[n].Cells[24].Value = item ["AdmitAddress2"].ToString();
                    IPDdataGridView.Rows[n].Cells[25].Value = item ["AdmitCity"].ToString();
                    IPDdataGridView.Rows[n].Cells[26].Value = item ["AdmitPIN"].ToString();
                
                
                }


             }
        }

        private void IPDdataGridView_MouseClick(object sender, MouseEventArgs e)
        {
           

        }

        private void Printbutton_Click(object sender, EventArgs e)
        {
            AdmissionRep admissionreport = new AdmissionRep();
            AdmissionReportViewer view = new AdmissionReportViewer();
           
            admissionreport.SetParameterValue("Pat_ID" , idTextBox.Text);
            admissionreport.SetParameterValue("Pat_Name", PatNametextBox.Text);
            admissionreport.SetParameterValue("Pat_GarName", garNameTextBox.Text);
            admissionreport.SetParameterValue("Pat_Address1", Address1textBox.Text);
            admissionreport.SetParameterValue("Pat_Address2", Address2textBox.Text);
            admissionreport.SetParameterValue("Pat_City", AddressCitytextBox.Text);
            admissionreport.SetParameterValue("Pat_PIN", AddressPINtextBox.Text);
            admissionreport.SetParameterValue("Pat_PrecheckedBy", precheckedByComboBox.Text);
            admissionreport.SetParameterValue("Pat_AdmissionDate", admissionDateDateTimePicker.Text);
            admissionreport.SetParameterValue("Pat_Age", ageTextBox.Text);
            admissionreport.SetParameterValue("Pat_Gender", comboBoxGender.Text);
            admissionreport.SetParameterValue("Pat_RefferesBy", RefferedBytextBox.Text);
            admissionreport.SetParameterValue("Pat_Religion", comboBoxReligion.Text);
            admissionreport.SetParameterValue("Pat_Phone", garPhoneTextBox.Text);
            admissionreport.SetParameterValue("Pat_Relation", comboBoxgarRelation.Text); 
            admissionreport.SetParameterValue("Pat_Country", textBoxGarCountry.Text);
            admissionreport.SetParameterValue("Pat_PO", textBoxGarPO.Text);
            admissionreport.SetParameterValue("Pat_PS", textBoxGarPS.Text);
            admissionreport.SetParameterValue("Pat_AdmitBy", admitNameTextBox.Text);
            view.crystalReportViewer1.ReportSource = admissionreport;
            //view..ReportSource = admissionreport;
            
            view.Show();




        }


        private void IPDdataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            idTextBox.ReadOnly = true;
            idTextBox.Text = IPDdataGridView.SelectedRows[0].Cells[0].Value.ToString();
            admissionDateDateTimePicker.Text = IPDdataGridView.SelectedRows[0].Cells[1].Value.ToString();
            PatidTextBox.Text = IPDdataGridView.SelectedRows[0].Cells[2].Value.ToString();
            PatNametextBox.Text = IPDdataGridView.SelectedRows[0].Cells[3].Value.ToString();
            precheckedByComboBox.Text = IPDdataGridView.SelectedRows[0].Cells[4].Value.ToString();
            ageTextBox.Text = IPDdataGridView.SelectedRows[0].Cells[5].Value.ToString();
            heightTextBox.Text = IPDdataGridView.SelectedRows[0].Cells[6].Value.ToString();
            weightTextBox.Text = IPDdataGridView.SelectedRows[0].Cells[7].Value.ToString();
            bloodPressureTextBox.Text = IPDdataGridView.SelectedRows[0].Cells[8].Value.ToString();
            symptomsTextBox.Text = IPDdataGridView.SelectedRows[0].Cells[9].Value.ToString();
            garNameTextBox.Text = IPDdataGridView.SelectedRows[0].Cells[10].Value.ToString();
            comboBoxgarRelation.Text = IPDdataGridView.SelectedRows[0].Cells[11].Value.ToString();
            garPhoneTextBox.Text = IPDdataGridView.SelectedRows[0].Cells[12].Value.ToString();
            garAddress1TextBox.Text = IPDdataGridView.SelectedRows[0].Cells[13].Value.ToString();
            garAddress2TextBox.Text = IPDdataGridView.SelectedRows[0].Cells[14].Value.ToString();
            textBoxGarPO.Text = IPDdataGridView.SelectedRows[0].Cells[15].Value.ToString();
            textBoxGarPS.Text = IPDdataGridView.SelectedRows[0].Cells[16].Value.ToString();
            garCityTextBox.Text = IPDdataGridView.SelectedRows[0].Cells[17].Value.ToString();
            garPINTextBox.Text = IPDdataGridView.SelectedRows[0].Cells[18].Value.ToString();
            textBoxGarCountry.Text = IPDdataGridView.SelectedRows[0].Cells[19].Value.ToString();
            admitNameTextBox.Text = IPDdataGridView.SelectedRows[0].Cells[20].Value.ToString();
            admitRelationTextBox.Text = IPDdataGridView.SelectedRows[0].Cells[21].Value.ToString();
            admitPhoneTextBox.Text = IPDdataGridView.SelectedRows[0].Cells[22].Value.ToString();
            admitAddress1TextBox.Text = IPDdataGridView.SelectedRows[0].Cells[23].Value.ToString();
            admitAddress2TextBox.Text = IPDdataGridView.SelectedRows[0].Cells[24].Value.ToString();
            admitCityTextBox.Text = IPDdataGridView.SelectedRows[0].Cells[25].Value.ToString();
            admitPINTextBox.Text = IPDdataGridView.SelectedRows[0].Cells[26].Value.ToString();


            using (SqlConnection con = new SqlConnection(connectionString))
            
            {
                con.Open();

                string PID = PatidTextBox.Text;

                string query = "SELECT PatAddress1, PatAddress2, PatCity, PatPIN, PatGender, PatRefferedBy, PatReligion FROM PatientMast WHERE id = @PID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@PID", PID);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Address1textBox.Text = reader["PatAddress1"].ToString();
                    Address2textBox.Text = reader["PatAddress2"].ToString();
                    AddressCitytextBox.Text = reader["PatCity"].ToString();
                    AddressPINtextBox.Text = reader["PatPIN"].ToString();
                    comboBoxGender.Text = reader["PatGender"].ToString();
                    RefferedBytextBox.Text = reader["PatRefferedBy"].ToString();
                    comboBoxReligion.Text = reader["PatReligion"].ToString();
                    // Set the radioButtonOldPat Checked property to true
                    radioButtonOldPat.Checked = true;
                    listViewPatDetails.Visible = false;
                }
                else
                {
                    MessageBox.Show("No Patient Found");
                    // Clear the textboxes if no patient is found
                    Address1textBox.Text = "";
                    Address2textBox.Text = "";
                    AddressCitytextBox.Text = "";
                    AddressPINtextBox.Text = "";
                    comboBoxGender.Text = "";
                    RefferedBytextBox.Text = "";
                    comboBoxReligion.Text = "";
                    // Set the radioButtonOldPat Checked property to false
                    radioButtonOldPat.Checked = false;
                }

                con.Close();
            }

        }

        private void precheckedByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IPDdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void IPDFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void buttonPatMast_Click(object sender, EventArgs e)
        {
            PatientMastFrm myForm = new PatientMastFrm();

            myForm.ShowDialog();
        }

        private void PatNametextBox_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonOldPat.Checked)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string searchText = PatNametextBox.Text.Trim();

                    // Fetch data based on PatName or PatPhone matching the entered text
                    string query = "SELECT PatName, PatPhone, PatDOB, PatGender, PatAddress1, PatAddress2, PatCity, PatPIN, PatRefferedBy, PatUnderDr, PatReligion " +
                                   "FROM PatientMast " +
                                   "WHERE PatName LIKE @SearchText OR PatPhone LIKE @SearchText";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@SearchText", "%" + searchText + "%");

                    SqlDataReader reader = cmd.ExecuteReader();

                    // Clear existing items in the ListView
                    listViewPatDetails.Items.Clear();

                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = reader["PatName"].ToString() + " | " + reader["PatPhone"].ToString();

                        listViewPatDetails.Items.Add(item);
                    }

                    // Set visibility based on whether there are items in the ListView
                    listViewPatDetails.Visible = !string.IsNullOrEmpty(searchText) && listViewPatDetails.Items.Count > 0;
                }
            }
        }

        private void radioButtonOldPat_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOldPat.Checked)
            {
                listViewPatDetails.Visible = true;
                // Trigger the search operation or any other necessary action here
                // Consider calling the code that populates listViewPatDetails
                //PatidTextBox.Text = "";
            }
            else
            {
                listViewPatDetails.Visible = false;
                // If needed, clear the listViewPatDetails or perform any other actions when radioButtonOldPat is unchecked
            }
        }

        private void radioButtonNewPat_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonNewPat.Checked)
                {
                    listViewPatDetails.Visible = false;
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        // Query to get the next available ID from the PatientMast table
                        string query = "SELECT MAX(id) + 1 AS NextId FROM PatientMast";

                        SqlCommand cmd = new SqlCommand(query, con);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read() && !reader.IsDBNull(0))
                        {
                            // Set the PatidTextBox to the next available ID
                            PatidTextBox.Text = reader["NextId"].ToString();
                        }
                        else
                        {
                            // If no records exist in the table, start with ID 1
                            PatidTextBox.Text = "1";
                        }
                    }
                    // If needed, clear the listViewPatDetails or perform any other actions when radioButtonNewPat is checked
                }
                else
                {
                    // Any actions to perform when radioButtonNewPat is unchecked
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewPatDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPatDetails.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewPatDetails.SelectedItems[0];
                string selectedText = selectedItem.Text;

                // Check if the selected text has the expected format (assuming PatName and PatPhone are separated by "|")
                string[] parts = selectedText.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length >= 2) // Ensure there are at least 2 parts after splitting
                {
                    string selectedPatName = parts[0].Trim();
                    string selectedPatPhone = parts[1].Trim();

                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();

                        // Fetch details from PatientMast table based on PatName and PatPhone
                        string query = "SELECT id, PatUnderDr, PatPhone, PatDOB, PatGender, PatReligion, " +
                                       "PatAddress1, PatAddress2, PatCity, PatPIN, PatRefferedBy, PatName " +
                                       "FROM PatientMast " +
                                       "WHERE PatName = @PatName AND PatPhone = @PatPhone";

                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@PatName", selectedPatName);
                        cmd.Parameters.AddWithValue("@PatPhone", selectedPatPhone);

                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            // Populate UI elements with fetched data
                            PatidTextBox.Text = reader["id"] == DBNull.Value ? string.Empty : reader["id"].ToString();
                            precheckedByComboBox.Text = reader["PatUnderDr"].ToString();
                            garPhoneTextBox.Text = reader["PatPhone"] == DBNull.Value ? string.Empty : reader["PatPhone"].ToString();
                            dateTimePickerDOB.Value = reader["PatDOB"] == DBNull.Value ? DateTime.Now : Convert.ToDateTime(reader["PatDOB"]);
                            comboBoxGender.Text = reader["PatGender"].ToString();
                            comboBoxReligion.Text = reader["PatReligion"].ToString();
                            garAddress1TextBox.Text = reader["PatAddress1"].ToString();
                            garAddress2TextBox.Text = reader["PatAddress2"].ToString();
                            garCityTextBox.Text = reader["PatCity"].ToString();
                            garPINTextBox.Text = reader["PatPIN"].ToString();
                            RefferedBytextBox.Text = reader["PatRefferedBy"].ToString();
                            PatNametextBox.Text = reader["PatName"].ToString();

                            listViewPatDetails.Visible = false;
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Selected item does not match the expected format.");
                }
            }
        }

        private void dateTimePickerDOB_ValueChanged(object sender, EventArgs e)
        {
            // Calculate age based on the date of birth
            DateTime dob = dateTimePickerDOB.Value;
            DateTime today = DateTime.Today;

            // Calculate the age
            int age = today.Year - dob.Year;
            if (dob.Date > today.AddYears(-age))
            {
                age--;
            }

            // Display the age in the ageTextBox
            ageTextBox.Text = age.ToString();
        }


        private void SetNextAvailableID()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                // Query to get the next available ID from the PatientMast table
                string query = "SELECT MAX(id) + 1 AS NextId FROM PatientMast";

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() && !reader.IsDBNull(0))
                {
                    // Set the PatidTextBox to the next available ID
                    PatidTextBox.Text = reader["NextId"].ToString();
                }
                else
                {
                    // If no records exist in the table, start with ID 1
                    PatidTextBox.Text = "1";
                }
            }
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            
            if (radioButtonOldPat.Checked)
            {
                // Check if the ID already exists in the IPD table
                if (IsIdExistsInIPD(idTextBox.Text))
                {
                    // Perform an UPDATE operation if the ID exists
                    UpdateIPDRecord();
                }
                else
                {
                    // Perform an INSERT operation if the ID doesn't exist
                    InsertIntoIPDTable();
                }
            }

            else if (radioButtonNewPat.Checked)  // Include this condition
            {
                // Call a method or write the logic specific to new patients here
                HandleNewPatient();
            }
            SetDefaultValues(this.Controls);
            idTextBox.ReadOnly = false;
            // Rest of your code
        }


        private void SetDefaultValues(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = string.Empty;
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = -1;
                }
                else if (control is DateTimePicker)
                {
                    ((DateTimePicker)control).Value = DateTime.Now;
                }
                // Add other control types as needed

                // Recursively set default values for controls in containers like GroupBox or Panel
                if (control.HasChildren)
                {
                    SetDefaultValues(control.Controls);
                }
                textBoxGarCountry.Text = "India";
            }
        }

        private bool IsIdExistsInIPD(string id)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "SELECT COUNT(*) FROM IPD WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", id);

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private void InsertIntoIPDTable()
        {
            if (radioButtonOldPat.Checked)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO IPD (patID, Patient, ID, Age, Height, Weight, BloodPressure,PrecheckedBy,AdmissionDate,Symptoms,GarName,GarRelation,GarPhone,GarAddress1,GarAddress2,GarCity,GarPIN,AdmitName,AdmitRelation,AdmitPhone,AdmitAddress1,AdmitAddress2,AdmitCity,AdmitPIN,GarCountry,GarPO,GarPS) 
                                           VALUES (@Patid, @PatName, @ID, @Age, @Height, @Weight, @BloodPressure, @PrecheckedBy, @AdmissionDate, @Symptoms, @GarName, @GarRelation, @GarPhone, @GarAddress1, @GarAddress2, @GarCity, @GarPIN, @AdmitName, @AdmitRelation, @AdmitPhone, @AdmitAddress1, @AdmitAddress2, @AdmitCity, @AdmitPIN, @GarCountry, @GarPO, @GarPS)", con);

                    // Add parameters and their values
                    cmd.Parameters.AddWithValue("@Patid", PatidTextBox.Text);
                    cmd.Parameters.AddWithValue("@PatName", PatNametextBox.Text);
                    cmd.Parameters.AddWithValue("@ID", idTextBox.Text);
                    cmd.Parameters.AddWithValue("@Age", ageTextBox.Text);
                    cmd.Parameters.AddWithValue("@Height", heightTextBox.Text);
                    cmd.Parameters.AddWithValue("@Weight", weightTextBox.Text);
                    cmd.Parameters.AddWithValue("@BloodPressure", bloodPressureTextBox.Text);
                    cmd.Parameters.AddWithValue("@PrecheckedBy", precheckedByComboBox.Text);
                    cmd.Parameters.AddWithValue("@AdmissionDate", admissionDateDateTimePicker.Text);
                    cmd.Parameters.AddWithValue("@Symptoms", symptomsTextBox.Text);
                    cmd.Parameters.AddWithValue("@GarName", garNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@GarRelation", comboBoxgarRelation.Text);
                    cmd.Parameters.AddWithValue("@GarPhone", garPhoneTextBox.Text);
                    cmd.Parameters.AddWithValue("@GarAddress1", garAddress1TextBox.Text);
                    cmd.Parameters.AddWithValue("@GarAddress2", garAddress2TextBox.Text);
                    cmd.Parameters.AddWithValue("@GarCity", garCityTextBox.Text);
                    cmd.Parameters.AddWithValue("@GarPIN", garPINTextBox.Text);
                    cmd.Parameters.AddWithValue("@AdmitName", admitNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@AdmitRelation", admitRelationTextBox.Text);
                    cmd.Parameters.AddWithValue("@AdmitPhone", admitPhoneTextBox.Text);
                    cmd.Parameters.AddWithValue("@AdmitAddress1", admitAddress1TextBox.Text);
                    cmd.Parameters.AddWithValue("@AdmitAddress2", admitAddress2TextBox.Text);
                    cmd.Parameters.AddWithValue("@AdmitCity", admitCityTextBox.Text);
                    cmd.Parameters.AddWithValue("@AdmitPIN", admitPINTextBox.Text);
                    cmd.Parameters.AddWithValue("@GarCountry", textBoxGarCountry.Text);
                    cmd.Parameters.AddWithValue("@GarPO", textBoxGarPO.Text);
                    cmd.Parameters.AddWithValue("@GarPS", textBoxGarPS.Text);

                    // Example for Age (convert to the appropriate type)
                    // Add parameters for other fields in a similar manner
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Successfully Saved...!");
                    Display();


                }
            }
            else if (radioButtonNewPat.Checked)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        
                        // Insert into PatientMast table
                        SqlCommand cmdPatientMast = new SqlCommand(@"INSERT INTO PatientMast (PatName, PatPhone, PatGender, PatAddress1, PatAddress2, PatCity, PatPIN, PatRefferedBy, PatUnderDr, PatReligion, PatCountry, PatPO, PatPS) 
                                   VALUES (@PatName, @PatPhone, @PatGender, @PatAddress1, @PatAddress2, @PatCity, @PatPIN, @PatRefferedBy, @PatUnderDr, @PatReligion, @PatCountry, @PatPO, @PatPS)", con);

                        cmdPatientMast.Parameters.AddWithValue("@PatName", PatNametextBox.Text);
                        cmdPatientMast.Parameters.AddWithValue("@PatPhone", garPhoneTextBox.Text);
                      //  cmdPatientMast.Parameters.AddWithValue("@PatDOB", dateTimePickerDOB.Text);
                        cmdPatientMast.Parameters.AddWithValue("@PatGender", comboBoxGender.Text);
                        cmdPatientMast.Parameters.AddWithValue("@PatAddress1", garAddress1TextBox.Text);
                        cmdPatientMast.Parameters.AddWithValue("@PatAddress2", garAddress2TextBox.Text);
                        cmdPatientMast.Parameters.AddWithValue("@PatCity", garCityTextBox.Text);
                        cmdPatientMast.Parameters.AddWithValue("@PatPIN", garPINTextBox.Text);
                        cmdPatientMast.Parameters.AddWithValue("@PatRefferedBy", RefferedBytextBox.Text);
                        cmdPatientMast.Parameters.AddWithValue("@PatUnderDr", precheckedByComboBox.Text);
                        cmdPatientMast.Parameters.AddWithValue("@PatReligion", comboBoxReligion.Text);
                        cmdPatientMast.Parameters.AddWithValue("@PatCountry", textBoxGarCountry.Text);
                        cmdPatientMast.Parameters.AddWithValue("@PatPO", textBoxPO.Text);
                        cmdPatientMast.Parameters.AddWithValue("@PatPS", textBoxPS.Text);

                        cmdPatientMast.ExecuteNonQuery();
                        
                        // Insert into IPD table
                        SqlCommand cmdIPD = new SqlCommand(@"INSERT INTO IPD (patID, Patient, ID, Age, Height, Weight, BloodPressure,PrecheckedBy,AdmissionDate,Symptoms,GarName,GarRelation,GarPhone,GarAddress1,GarAddress2,GarCity,GarPIN,AdmitName,AdmitRelation,AdmitPhone,AdmitAddress1,AdmitAddress2,AdmitCity,AdmitPIN,GarCountry,GarPO,GarPS) 
                                   VALUES (@Patid, @PatName, @ID, @Age, @Height, @Weight, @BloodPressure, @PrecheckedBy, @AdmissionDate, @Symptoms, @GarName, @GarRelation, @GarPhone, @GarAddress1, @GarAddress2, @GarCity, @GarPIN, @AdmitName, @AdmitRelation, @AdmitPhone, @AdmitAddress1, @AdmitAddress2, @AdmitCity, @AdmitPIN, @GarCountry, @GarPO, @GarPS)", con);

                        // Add parameters and their values
                        cmdIPD.Parameters.AddWithValue("@Patid", PatidTextBox.Text);
                        cmdIPD.Parameters.AddWithValue("@PatName", PatNametextBox.Text);
                        cmdIPD.Parameters.AddWithValue("@ID", idTextBox.Text);
                        cmdIPD.Parameters.AddWithValue("@Age", ageTextBox.Text);
                        cmdIPD.Parameters.AddWithValue("@Height", heightTextBox.Text);
                        cmdIPD.Parameters.AddWithValue("@Weight", weightTextBox.Text);
                        cmdIPD.Parameters.AddWithValue("@BloodPressure", bloodPressureTextBox.Text);
                        cmdIPD.Parameters.AddWithValue("@PrecheckedBy", precheckedByComboBox.Text);
                        cmdIPD.Parameters.AddWithValue("@AdmissionDate", admissionDateDateTimePicker.Value);
                        cmdIPD.Parameters.AddWithValue("@Symptoms", symptomsTextBox.Text);
                        cmdIPD.Parameters.AddWithValue("@GarName", garNameTextBox.Text);
                        cmdIPD.Parameters.AddWithValue("@GarRelation", comboBoxgarRelation.Text);
                        cmdIPD.Parameters.AddWithValue("@GarPhone", garPhoneTextBox.Text);
                        cmdIPD.Parameters.AddWithValue("@GarAddress1", garAddress1TextBox.Text);
                        cmdIPD.Parameters.AddWithValue("@GarAddress2", garAddress2TextBox.Text);
                        cmdIPD.Parameters.AddWithValue("@GarCity", garCityTextBox.Text);
                        cmdIPD.Parameters.AddWithValue("@GarPIN", garPINTextBox.Text);
                        cmdIPD.Parameters.AddWithValue("@AdmitName", admitNameTextBox.Text);
                        cmdIPD.Parameters.AddWithValue("@AdmitRelation", admitRelationTextBox.Text);
                        cmdIPD.Parameters.AddWithValue("@AdmitPhone", admitPhoneTextBox.Text);
                        cmdIPD.Parameters.AddWithValue("@AdmitAddress1", admitAddress1TextBox.Text);
                        cmdIPD.Parameters.AddWithValue("@AdmitAddress2", admitAddress2TextBox.Text);
                        cmdIPD.Parameters.AddWithValue("@AdmitCity", admitCityTextBox.Text);
                        cmdIPD.Parameters.AddWithValue("@AdmitPIN", admitPINTextBox.Text);
                        cmdIPD.Parameters.AddWithValue("@GarCountry", textBoxGarCountry.Text);
                        cmdIPD.Parameters.AddWithValue("@GarPO", textBoxGarPO.Text);
                        cmdIPD.Parameters.AddWithValue("@GarPS", textBoxGarPS.Text);

                        cmdIPD.ExecuteNonQuery();

                        MessageBox.Show("Successfully Saved...!");
                        Display();
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception, e.g., log it or show an error message to the user
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                // Handle if neither radio button is checked
                MessageBox.Show("Error...!");
            }
        }

        private void UpdateIPDRecord()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"UPDATE IPD SET patID = @Patid, Patient = @PatName, Age = @Age, Height = @Height, Weight = @Weight, BloodPressure = @BloodPressure, PrecheckedBy = @PrecheckedBy, AdmissionDate = @AdmissionDate, Symptoms = @Symptoms, GarName = @GarName, GarRelation = @GarRelation, GarPhone = @GarPhone, GarAddress1 = @GarAddress1, GarAddress2 = @GarAddress2, GarCity = @GarCity, GarPIN = @GarPIN, AdmitName = @AdmitName, AdmitRelation = @AdmitRelation, AdmitPhone = @AdmitPhone, AdmitAddress1 = @AdmitAddress1, AdmitAddress2 = @AdmitAddress2, AdmitCity = @AdmitCity, AdmitPIN = @AdmitPIN, GarCountry = @GarCountry, GarPO = @GarPO, GarPS = @GarPS WHERE Id = @Id", con);

                // Add parameters and their values for the UPDATE operation
                // cmd.Parameters.AddWithValue("@Id", idTextBox.Text);

                cmd.Parameters.AddWithValue("@Id", idTextBox.Text);
                cmd.Parameters.AddWithValue("@Patid", PatidTextBox.Text);
                cmd.Parameters.AddWithValue("@PatName", PatNametextBox.Text);
                cmd.Parameters.AddWithValue("@Age", ageTextBox.Text);
                cmd.Parameters.AddWithValue("@Height", heightTextBox.Text);
                cmd.Parameters.AddWithValue("@Weight", weightTextBox.Text);
                cmd.Parameters.AddWithValue("@BloodPressure", bloodPressureTextBox.Text);
                cmd.Parameters.AddWithValue("PrecheckedBy", precheckedByComboBox.Text);
                cmd.Parameters.AddWithValue("AdmissionDate", admissionDateDateTimePicker.Text);
                cmd.Parameters.AddWithValue("Symptoms", symptomsTextBox.Text);
                cmd.Parameters.AddWithValue("GarName", garNameTextBox.Text);
                cmd.Parameters.AddWithValue("GarRelation", comboBoxgarRelation.Text);
                cmd.Parameters.AddWithValue("GarPhone", garPhoneTextBox.Text);
                cmd.Parameters.AddWithValue("GarAddress1", garAddress1TextBox.Text);
                cmd.Parameters.AddWithValue("GarAddress2", garAddress2TextBox.Text);
                cmd.Parameters.AddWithValue("GarCity", garCityTextBox.Text);
                cmd.Parameters.AddWithValue("GarPIN", garPINTextBox.Text);
                cmd.Parameters.AddWithValue("AdmitName", admitNameTextBox.Text);
                cmd.Parameters.AddWithValue("AdmitRelation", admitRelationTextBox.Text);
                cmd.Parameters.AddWithValue("AdmitPhone", admitPhoneTextBox.Text);
                cmd.Parameters.AddWithValue("AdmitAddress1", admitAddress1TextBox.Text);
                cmd.Parameters.AddWithValue("AdmitAddress2", admitAddress2TextBox.Text);
                cmd.Parameters.AddWithValue("AdmitCity", admitCityTextBox.Text);
                cmd.Parameters.AddWithValue("AdmitPIN", admitPINTextBox.Text);
                cmd.Parameters.AddWithValue("@GarCountry", textBoxGarCountry.Text);
                cmd.Parameters.AddWithValue("@GarPO", textBoxGarPO.Text);
                cmd.Parameters.AddWithValue("@GarPS", textBoxGarPS.Text);

                // Add parameters for other fields to be updated

                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Updated...!");
                Display();
            }
        }

        private void HandleNewPatient()
        {


                try
                {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Insert into PatientMast table
                    SqlCommand cmdPatientMast = new SqlCommand(@"INSERT INTO PatientMast (PatName, PatPhone, PatGender, PatAddress1, PatAddress2, PatCity, PatPIN, PatRefferedBy, PatUnderDr, PatReligion, PatCountry, PatPO, PatPS) 
                                   VALUES (@PatName, @PatPhone, @PatGender, @PatAddress1, @PatAddress2, @PatCity, @PatPIN, @PatRefferedBy, @PatUnderDr, @PatReligion, @PatCountry, @PatPO, @PatPS)", con);

                    cmdPatientMast.Parameters.AddWithValue("@PatName", PatNametextBox.Text);
                    cmdPatientMast.Parameters.AddWithValue("@PatPhone", garPhoneTextBox.Text);
                    //  cmdPatientMast.Parameters.AddWithValue("@PatDOB", dateTimePickerDOB.Text);
                    cmdPatientMast.Parameters.AddWithValue("@PatGender", comboBoxGender.Text);
                    cmdPatientMast.Parameters.AddWithValue("@PatAddress1", garAddress1TextBox.Text);
                    cmdPatientMast.Parameters.AddWithValue("@PatAddress2", garAddress2TextBox.Text);
                    cmdPatientMast.Parameters.AddWithValue("@PatCity", garCityTextBox.Text);
                    cmdPatientMast.Parameters.AddWithValue("@PatPIN", garPINTextBox.Text);
                    cmdPatientMast.Parameters.AddWithValue("@PatRefferedBy", RefferedBytextBox.Text);
                    cmdPatientMast.Parameters.AddWithValue("@PatUnderDr", precheckedByComboBox.Text);
                    cmdPatientMast.Parameters.AddWithValue("@PatReligion", comboBoxReligion.Text);
                    cmdPatientMast.Parameters.AddWithValue("@PatCountry", textBoxGarCountry.Text);
                    cmdPatientMast.Parameters.AddWithValue("@PatPO", textBoxPO.Text);
                    cmdPatientMast.Parameters.AddWithValue("@PatPS", textBoxPS.Text);

                    cmdPatientMast.ExecuteNonQuery();

                    // Insert into IPD table
                    SqlCommand cmdIPD = new SqlCommand(@"INSERT INTO IPD (patID, Patient, ID, Age, Height, Weight, BloodPressure,PrecheckedBy,AdmissionDate,Symptoms,GarName,GarRelation,GarPhone,GarAddress1,GarAddress2,GarCity,GarPIN,AdmitName,AdmitRelation,AdmitPhone,AdmitAddress1,AdmitAddress2,AdmitCity,AdmitPIN,GarCountry,GarPO,GarPS) 
                                   VALUES (@Patid, @PatName, @ID, @Age, @Height, @Weight, @BloodPressure, @PrecheckedBy, @AdmissionDate, @Symptoms, @GarName, @GarRelation, @GarPhone, @GarAddress1, @GarAddress2, @GarCity, @GarPIN, @AdmitName, @AdmitRelation, @AdmitPhone, @AdmitAddress1, @AdmitAddress2, @AdmitCity, @AdmitPIN, @GarCountry, @GarPO, @GarPS)", con);

                    // Add parameters and their values
                    cmdIPD.Parameters.AddWithValue("@Patid", PatidTextBox.Text);
                    cmdIPD.Parameters.AddWithValue("@PatName", PatNametextBox.Text);
                    cmdIPD.Parameters.AddWithValue("@ID", idTextBox.Text);
                    cmdIPD.Parameters.AddWithValue("@Age", ageTextBox.Text);
                    cmdIPD.Parameters.AddWithValue("@Height", heightTextBox.Text);
                    cmdIPD.Parameters.AddWithValue("@Weight", weightTextBox.Text);
                    cmdIPD.Parameters.AddWithValue("@BloodPressure", bloodPressureTextBox.Text);
                    cmdIPD.Parameters.AddWithValue("@PrecheckedBy", precheckedByComboBox.Text);
                    cmdIPD.Parameters.AddWithValue("@AdmissionDate", admissionDateDateTimePicker.Value);
                    cmdIPD.Parameters.AddWithValue("@Symptoms", symptomsTextBox.Text);
                    cmdIPD.Parameters.AddWithValue("@GarName", garNameTextBox.Text);
                    cmdIPD.Parameters.AddWithValue("@GarRelation", comboBoxgarRelation.Text);
                    cmdIPD.Parameters.AddWithValue("@GarPhone", garPhoneTextBox.Text);
                    cmdIPD.Parameters.AddWithValue("@GarAddress1", garAddress1TextBox.Text);
                    cmdIPD.Parameters.AddWithValue("@GarAddress2", garAddress2TextBox.Text);
                    cmdIPD.Parameters.AddWithValue("@GarCity", garCityTextBox.Text);
                    cmdIPD.Parameters.AddWithValue("@GarPIN", garPINTextBox.Text);
                    cmdIPD.Parameters.AddWithValue("@AdmitName", admitNameTextBox.Text);
                    cmdIPD.Parameters.AddWithValue("@AdmitRelation", admitRelationTextBox.Text);
                    cmdIPD.Parameters.AddWithValue("@AdmitPhone", admitPhoneTextBox.Text);
                    cmdIPD.Parameters.AddWithValue("@AdmitAddress1", admitAddress1TextBox.Text);
                    cmdIPD.Parameters.AddWithValue("@AdmitAddress2", admitAddress2TextBox.Text);
                    cmdIPD.Parameters.AddWithValue("@AdmitCity", admitCityTextBox.Text);
                    cmdIPD.Parameters.AddWithValue("@AdmitPIN", admitPINTextBox.Text);
                    cmdIPD.Parameters.AddWithValue("@GarCountry", textBoxGarCountry.Text);
                    cmdIPD.Parameters.AddWithValue("@GarPO", textBoxGarPO.Text);
                    cmdIPD.Parameters.AddWithValue("@GarPS", textBoxGarPS.Text);

                    cmdIPD.ExecuteNonQuery();

                    MessageBox.Show("Successfully Saved...!");
                    Display();


                }
            }
            catch (Exception ex)
            {
                // Handle the exception, e.g., log it or show an error message to the user
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            // Ensure that the user has selected a row in the IPDdataGridView
            if (IPDdataGridView.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = IPDdataGridView.SelectedRows[0];

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
                        using (SqlCommand cmdDischarge = new SqlCommand("DELETE FROM IPD WHERE Id = @Id", con, transaction))
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

        private void garAddress1TextBox_TextChanged(object sender, EventArgs e)
        {
            Address1textBox.Text = garAddress1TextBox.Text;
        }

        private void garAddress2TextBox_TextChanged(object sender, EventArgs e)
        {
            Address2textBox.Text = garAddress2TextBox.Text;
        }

        private void garCityTextBox_TextChanged(object sender, EventArgs e)
        {
            AddressCitytextBox.Text = garCityTextBox.Text;
        }

        private void garPINTextBox_TextChanged(object sender, EventArgs e)
        {
            AddressPINtextBox.Text = garPINTextBox.Text;
        }

        private void textBoxGarCountry_TextChanged(object sender, EventArgs e)
        {
            textBoxCountry.Text = textBoxGarCountry.Text;
        }

        private void textBoxGarPO_TextChanged(object sender, EventArgs e)
        {
            textBoxPO.Text = textBoxGarPO.Text;
        }

        private void textBoxGarPS_TextChanged(object sender, EventArgs e)
        {
            textBoxPS.Text = textBoxGarPS.Text;
        }
    }
}