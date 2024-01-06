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


namespace HMS.Forms.Transaction.IPD
{
    public partial class IPDFrm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["HMS.Properties.Settings.HMSConnectionString"].ConnectionString;
//        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=HMS;Integrated Security=True");

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

        }

        private void admissionDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            admissionDateDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {

            idTextBox.Text = "";
            PatidTextBox.Text = "";
            PatNametextBox.Text = "";
            ageTextBox.Text = "";
            heightTextBox.Text = "";
            weightTextBox.Text = "";
            bloodPressureTextBox.Text = "";
            precheckedByComboBox.SelectedIndex = -1;
            admissionDateDateTimePicker.Text = "";
            symptomsTextBox.Text = "";
            garNameTextBox.Text = "";
            garRelationTextBox.Text = "";
            garPhoneTextBox.Text = "";
            garAddress1TextBox.Text = "";
            garAddress2TextBox.Text = "";
            garCityTextBox.Text = "";
            garPINTextBox.Text = "";
            admitNameTextBox.Text = "";
            admitRelationTextBox.Text = "";
            admitPhoneTextBox.Text = "";
            admitAddress1TextBox.Text = "";
            admitAddress2TextBox.Text = "";
            admitCityTextBox.Text = "";
            admitPINTextBox.Text = "";

            //      cmbCategory.SelectedIndex = -1;
            idTextBox.Focus();

        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
           // using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=HMS;Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO IPD (patID, Patient, ID, Age, Height, Weight, BloodPressure,PrecheckedBy,AdmissionDate,Symptoms,GarName,GarRelation,GarPhone,GarAddress1,GarAddress2,GarCity,GarPIN,AdmitName,AdmitRelation,AdmitPhone,AdmitAddress1,AdmitAddress2,AdmitCity,AdmitPIN) 
                                       VALUES (@Patid, @PatName, @ID, @Age, @Height, @Weight, @BloodPressure, @PrecheckedBy, @AdmissionDate, @Symptoms, @GarName, @GarRelation, @GarPhone, @GarAddress1, @GarAddress2, @GarCity, @GarPIN, @AdmitName, @AdmitRelation, @AdmitPhone, @AdmitAddress1, @AdmitAddress2, @AdmitCity, @AdmitPIN)", con);

                // Add parameters and their values
                cmd.Parameters.AddWithValue("@Patid", PatidTextBox.Text);
                cmd.Parameters.AddWithValue("@PatName", PatNametextBox.Text);
                cmd.Parameters.AddWithValue("@ID", idTextBox.Text);
                cmd.Parameters.AddWithValue("@Age", ageTextBox.Text);
                cmd.Parameters.AddWithValue("@Height", weightTextBox.Text);
                cmd.Parameters.AddWithValue("@Weight", heightTextBox.Text);
                cmd.Parameters.AddWithValue("@BloodPressure", bloodPressureTextBox.Text);
                cmd.Parameters.AddWithValue("PrecheckedBy", precheckedByComboBox.Text);
                cmd.Parameters.AddWithValue("AdmissionDate", admissionDateDateTimePicker.Text);
                cmd.Parameters.AddWithValue("Symptoms", symptomsTextBox.Text);
                cmd.Parameters.AddWithValue("GarName", garNameTextBox.Text);
                cmd.Parameters.AddWithValue("GarRelation", garRelationTextBox.Text);
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
                cmd.Parameters.AddWithValue("AdmitPIN" , admitPINTextBox.Text);
                // Example for Age (convert to the appropriate type)
                // Add parameters for other fields in a similar manner
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Saved...!");
                Display();
            }                     
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            // using (SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=HMS;Integrated Security=True"))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"UPDATE IPD SET PatID = @PatID, Patient = @Patient, ID = @ID, Age = @Age, Height = @Height, Weight = @Weight, BloodPressure = @BloodPressure, PrecheckedBy = @PrecheckedBy, AdmissionDate = @AdmissionDate, Symptoms = @Symptoms, GarName = @GarName, GarRelation = @GarRelation, GarPhone = @GarPhone, GarAddress1 = @GarAddress1, GarAddress2 = @GarAddress2, GarCity = @GarCity, GarPIN = @GarPIN, AdmitName = @AdmitName, AdmitRelation = @AdmitRelation, AdmitPhone = @AdmitPhone, AdmitAddress1 = @AdmitAddress1, AdmitAddress2 = @AdmitAddress2, AdmitCity = @AdmitCity, AdmitPIN = @AdmitPIN WHERE ID = @IDParam", con);

                cmd.Parameters.AddWithValue("@PatID", PatidTextBox.Text);
                cmd.Parameters.AddWithValue("@Patient", PatNametextBox.Text);
                cmd.Parameters.AddWithValue("@ID", idTextBox.Text);
                cmd.Parameters.AddWithValue("@Age", ageTextBox.Text);
                cmd.Parameters.AddWithValue("@Height", heightTextBox.Text);
                cmd.Parameters.AddWithValue("@Weight", weightTextBox.Text);
                cmd.Parameters.AddWithValue("@BloodPressure", bloodPressureTextBox.Text);
                cmd.Parameters.AddWithValue("@PrecheckedBy", precheckedByComboBox.Text);
                cmd.Parameters.AddWithValue("@AdmissionDate", admissionDateDateTimePicker.Value.ToString("yyyy - MM - dd HH: mm:ss"));
                cmd.Parameters.AddWithValue("@Symptoms", symptomsTextBox.Text);
                cmd.Parameters.AddWithValue("@GarName", garNameTextBox.Text);
                cmd.Parameters.AddWithValue("@GarRelation", garRelationTextBox.Text);
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
                cmd.Parameters.AddWithValue("@IDParam", idTextBox.Text);


                // Add other parameters similarly for the remaining fields...

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Update Successfully!");
                Display();
            }

        }


    
        

        void Display()
        { 
             using (SqlConnection con = new SqlConnection(connectionString))
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * from IPD", con);
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
                IPDdataGridView.Rows[n].Cells[15].Value = item ["GarCity"].ToString();
                IPDdataGridView.Rows[n].Cells[16].Value = item ["GarPIN"].ToString();
                IPDdataGridView.Rows[n].Cells[17].Value = item ["AdmitName"].ToString();
                IPDdataGridView.Rows[n].Cells[18].Value = item ["AdmitRelation"].ToString();
                IPDdataGridView.Rows[n].Cells[19].Value = item ["AdmitPhone"].ToString();
                IPDdataGridView.Rows[n].Cells[20].Value = item ["AdmitAddress1"].ToString();
                IPDdataGridView.Rows[n].Cells[21].Value = item ["AdmitAddress2"].ToString();
                IPDdataGridView.Rows[n].Cells[22].Value = item ["AdmitCity"].ToString();
                IPDdataGridView.Rows[n].Cells[23].Value = item ["AdmitPIN"].ToString();
                
                
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
            admissionreport.SetParameterValue("Pat_Gender", GendertextBox.Text);
            admissionreport.SetParameterValue("Pat_RefferesBy", RefferedBytextBox.Text);
            view.crystalReportViewer1.ReportSource = admissionreport;
            //view..ReportSource = admissionreport;
            
            view.Show();




        }

        private void Findbutton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            // using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=HMS;Integrated Security=True"))
            {
                con.Open();

                string PID = PatidTextBox.Text;

                string query = "SELECT PatName, PatAddress1, PatAddress2, PatCity, PatPIN, PatGender, PatRefferedBy FROM PatientMast WHERE id = @PID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@PID", PID);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    PatNametextBox.Text = reader["PatName"].ToString();
                    Address1textBox.Text = reader["PatAddress1"].ToString();
                    Address2textBox.Text = reader["PatAddress2"].ToString();
                    AddressCitytextBox.Text = reader["PatCity"].ToString();
                    AddressPINtextBox.Text = reader["PatPIN"].ToString();
                    GendertextBox.Text = reader["PatGender"].ToString();
                    RefferedBytextBox.Text = reader["PatRefferedBy"].ToString();
                }
                else
                {
                    MessageBox.Show("No Patient Found");
                    // Clear the textboxes if no patient is found
                    PatNametextBox.Text = "";
                    Address1textBox.Text = "";
                    Address2textBox.Text = "";
                    AddressCitytextBox.Text = "";
                    AddressPINtextBox.Text = "";
                    GendertextBox.Text = "";
                    RefferedBytextBox.Text = "";
                }

                con.Close();
            }
        }

        private void IPDdataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
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
            garRelationTextBox.Text = IPDdataGridView.SelectedRows[0].Cells[11].Value.ToString();
            garPhoneTextBox.Text = IPDdataGridView.SelectedRows[0].Cells[12].Value.ToString();
            garAddress1TextBox.Text = IPDdataGridView.SelectedRows[0].Cells[13].Value.ToString();
            garAddress2TextBox.Text = IPDdataGridView.SelectedRows[0].Cells[14].Value.ToString();
            garCityTextBox.Text = IPDdataGridView.SelectedRows[0].Cells[15].Value.ToString();
            garPINTextBox.Text = IPDdataGridView.SelectedRows[0].Cells[16].Value.ToString();
            admitNameTextBox.Text = IPDdataGridView.SelectedRows[0].Cells[17].Value.ToString();
            admitRelationTextBox.Text = IPDdataGridView.SelectedRows[0].Cells[18].Value.ToString();
            admitPhoneTextBox.Text = IPDdataGridView.SelectedRows[0].Cells[19].Value.ToString();
            admitAddress1TextBox.Text = IPDdataGridView.SelectedRows[0].Cells[20].Value.ToString();
            admitAddress2TextBox.Text = IPDdataGridView.SelectedRows[0].Cells[21].Value.ToString();
            admitCityTextBox.Text = IPDdataGridView.SelectedRows[0].Cells[22].Value.ToString();
            admitPINTextBox.Text = IPDdataGridView.SelectedRows[0].Cells[23].Value.ToString();

            using (SqlConnection con = new SqlConnection(connectionString))
            //using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=HMS;Integrated Security=True"))
            {
                con.Open();

                string PID = PatidTextBox.Text;

                string query = "SELECT PatAddress1, PatAddress2, PatCity, PatPIN, PatGender, PatRefferedBy FROM PatientMast WHERE id = @PID";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@PID", PID);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    Address1textBox.Text = reader["PatAddress1"].ToString();
                    Address2textBox.Text = reader["PatAddress2"].ToString();
                    AddressCitytextBox.Text = reader["PatCity"].ToString();
                    AddressPINtextBox.Text = reader["PatPIN"].ToString();
                    GendertextBox.Text = reader["PatGender"].ToString();
                    RefferedBytextBox.Text = reader["PatRefferedBy"].ToString();
                }
                else
                {
                    MessageBox.Show("No Patient Found");
                    // Clear the textboxes if no patient is found
                    Address1textBox.Text = "";
                    Address2textBox.Text = "";
                    AddressCitytextBox.Text = "";
                    AddressPINtextBox.Text = "";
                    GendertextBox.Text = "";
                    RefferedBytextBox.Text = "";
                }

                con.Close();
            }

        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {

            idTextBox.Text = "";
            PatidTextBox.Text = "";
            PatNametextBox.Text = "";
            ageTextBox.Text = "";
            heightTextBox.Text = "";
            weightTextBox.Text = "";
            bloodPressureTextBox.Text = "";
            precheckedByComboBox.SelectedIndex = -1;
            admissionDateDateTimePicker.Text = "";
            symptomsTextBox.Text = "";
            garNameTextBox.Text = "";
            garRelationTextBox.Text = "";
            garPhoneTextBox.Text = "";
            garAddress1TextBox.Text = "";
            garAddress2TextBox.Text = "";
            garCityTextBox.Text = "";
            garPINTextBox.Text = "";
            admitNameTextBox.Text = "";
            admitRelationTextBox.Text = "";
            admitPhoneTextBox.Text = "";
            admitAddress1TextBox.Text = "";
            admitAddress2TextBox.Text = "";
            admitCityTextBox.Text = "";
            admitPINTextBox.Text = "";

            //      cmbCategory.SelectedIndex = -1;
            idTextBox.Focus();

        }

        private void precheckedByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void IPDdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}