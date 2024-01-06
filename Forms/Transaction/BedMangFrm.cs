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
using System.IO;
using System.Configuration;


namespace HMS.Forms.Transaction
{
    public partial class BedMangFrm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["HMS.Properties.Settings.HMSConnectionString"].ConnectionString;
        // SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=HMS;Integrated Security=True");
        public BedMangFrm()
        {
            InitializeComponent();
        }

        private void BedMangFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet.DoctorMast' table. You can move, or remove it, as needed.
            this.doctorMastTableAdapter.Fill(this.hMSDataSet.DoctorMast);
            // TODO: This line of code loads data into the 'hMSDataSet.DoctorDepartmentMast' table. You can move, or remove it, as needed.
            this.doctorDepartmentMastTableAdapter.Fill(this.hMSDataSet.DoctorDepartmentMast);
            // TODO: This line of code loads data into the 'hMSDataSet.BedManagement' table. You can move, or remove it, as needed.
            this.bedManagementTableAdapter.Fill(this.hMSDataSet.BedManagement);
            // TODO: This line of code loads data into the 'hMSDataSet.BedNumberMast' table. You can move, or remove it, as needed.
            this.bedNumberMastTableAdapter.Fill(this.hMSDataSet.BedNumberMast);
            // TODO: This line of code loads data into the 'hMSDataSet.BedTypeMast' table. You can move, or remove it, as needed.
            this.bedTypeMastTableAdapter.Fill(this.hMSDataSet.BedTypeMast);
            Display();

        }

        private void Addbutton_Click(object sender, EventArgs e)
        {

            idTextBox.Text = "";
            IPDSearchtextBox.Text = "";
            PatientNametextBox.Text = "";
            GendertextBox.Text = "";
            AgetextBox.Text = "";
            DoctorNameComboBox.SelectedIndex = -1;
            AdmissiondateTimePicker.Text = "";
            FromDtDateTimePicker.Text = "";
            bedTypeComboBox.SelectedIndex = -1;
            bedNoComboBox.SelectedIndex = -1;
            ToDtdateTimePicker.Text = "";
            DaystextBox.Text = "";
            BedRateTextBox.Text = "";
            BedAmounttextBox.Text = "";
            

            idTextBox.Focus();
            Display();

        }


        void Display()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                
                SqlDataAdapter sda = new SqlDataAdapter("Select * from BedManagement", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BedManagedataGridView.Rows.Clear();
                foreach (DataRow item in dt.Rows)
                {

                    int n = BedManagedataGridView.Rows.Add();

                    BedManagedataGridView.Rows[n].Cells[0].Value = item["Id"].ToString();
                    BedManagedataGridView.Rows[n].Cells[1].Value = item["IPD"].ToString();
                    BedManagedataGridView.Rows[n].Cells[2].Value = item["Patient"].ToString();
                    BedManagedataGridView.Rows[n].Cells[3].Value = item["DrName"].ToString();
                    BedManagedataGridView.Rows[n].Cells[4].Value = item["FromDate"].ToString();
                    BedManagedataGridView.Rows[n].Cells[5].Value = item["BedType"].ToString();
                    BedManagedataGridView.Rows[n].Cells[6].Value = item["BedNo"].ToString();
                    BedManagedataGridView.Rows[n].Cells[7].Value = item["Todate"].ToString();
                    BedManagedataGridView.Rows[n].Cells[8].Value = item["Days"].ToString();
                    BedManagedataGridView.Rows[n].Cells[9].Value = item["Rate"].ToString();
                    BedManagedataGridView.Rows[n].Cells[10].Value = item["BedAmount"].ToString();

                }
            }

        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            idTextBox.Text = "";
            IPDSearchtextBox.Text = "";
            PatientNametextBox.Text = "";
            GendertextBox.Text = "";
            AgetextBox.Text = "";
            DoctorNameComboBox.SelectedIndex = -1;
            AdmissiondateTimePicker.Text = "";
            FromDtDateTimePicker.Text = "";
            bedTypeComboBox.SelectedIndex = -1;
            bedNoComboBox.SelectedIndex = -1;
            ToDtdateTimePicker.Text = "";
            DaystextBox.Text = "";
            BedRateTextBox.Text = "";
            BedAmounttextBox.Text = "";


            idTextBox.Focus();
            Display();

        }

        private void IPDSearchtextBox_TextChanged(object sender, EventArgs e)
        {


            string searchText = IPDSearchtextBox.Text;

            using (SqlConnection con = new SqlConnection(connectionString))
            //using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=HMS;Integrated Security=True"))
            {
                // Query to fetch details from related tables
                string query = @"SELECT IPD.Patient, PatientMast.PatGender, IPD.Age, IPD.AdmissionDate
                         FROM IPD
                         INNER JOIN PatientMast ON IPD.PatID = PatientMast.Id
                         WHERE IPD.Id = @searchText";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@searchText", searchText);

                    try
                    {
                        con.Open();

                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read())
                        {
                            // Assign fetched values to respective UI elements
                            if (reader["Patient"] != DBNull.Value)
                            {
                                PatientNametextBox.Text = reader["Patient"].ToString();
                            }

                            if (reader["PatGender"] != DBNull.Value)
                            {
                                GendertextBox.Text = reader["PatGender"].ToString();
                            }

                            if (reader["Age"] != DBNull.Value)
                            {
                                AgetextBox.Text = reader["Age"].ToString();
                            }

                            if (reader["AdmissionDate"] != DBNull.Value)
                            {
                                AdmissiondateTimePicker.Value = Convert.ToDateTime(reader["AdmissionDate"]);
                            }
                            else
                            {
                                // Handle the case when AdmissionDate is DBNull if needed
                                // AdmissiondateTimePicker.Value = DateTime.MinValue; // Set some default value
                            }
                        }


                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        // Handle exceptions
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DoctorNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ToDtdateTimePicker_ValueChanged(object sender, EventArgs e)
        {

            if (ToDtdateTimePicker.Value < FromDtDateTimePicker.Value)
            {
                ToDtdateTimePicker.Value = FromDtDateTimePicker.Value;
            }
                // Assuming FromDtdateTimePicker and ToDtdateTimePicker are DateTimePicker controls
                DateTime fromDate = FromDtDateTimePicker.Value;
            DateTime toDate = ToDtdateTimePicker.Value;

            TimeSpan difference = toDate - fromDate;
            int daysDifference = (int)difference.TotalDays;

            // If the difference is zero, set it to 1
            if (daysDifference <= 0)
            {
                daysDifference = 1;
            }

            // Display the difference in the DaystextBox
            DaystextBox.Text = daysDifference.ToString();
        }

        private void BedRateTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateBedAmount();
        }

        private void bedNoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                
            

        }

        private void DaystextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateBedAmount();
        }

        private void CalculateBedAmount()
        {
            int days = 0;
            decimal bedRate = 0;

            if (int.TryParse(DaystextBox.Text, out days) && decimal.TryParse(BedRateTextBox.Text, out bedRate))
            {
                decimal bedAmount = days * bedRate;
                BedAmounttextBox.Text = bedAmount.ToString();
            }
        }

       


        private void Savebutton_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            using (SqlConnection con = new SqlConnection(connectionString))
            //string connectionString = "Data Source=.;Initial Catalog=HMS;Integrated Security=True"; // Replace with your connection string

           // using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"INSERT INTO BedManagement (Id, IPD, DrName, FromDate, BedType, BedNo, Todate, Days, Rate, BedAmount, Patient)
                         VALUES (@Id, @IPD, @DrName, @FromDate, @BedType, @BedNo, @Todate, @Days, @Rate, @BedAmount, @Patient)";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@Id", idTextBox.Text);
                    command.Parameters.AddWithValue("@IPD", IPDSearchtextBox.Text);
                    command.Parameters.AddWithValue("@DrName", DoctorNameComboBox.Text);
                    command.Parameters.AddWithValue("@FromDate", FromDtDateTimePicker.Value);
                    command.Parameters.AddWithValue("@BedType", bedTypeComboBox.Text);
                    command.Parameters.AddWithValue("@BedNo", bedNoComboBox.Text);
                    command.Parameters.AddWithValue("@Todate", ToDtdateTimePicker.Value);
                    command.Parameters.AddWithValue("@Days", int.Parse(DaystextBox.Text));
                    command.Parameters.AddWithValue("@Rate", decimal.Parse(BedRateTextBox.Text));
                    command.Parameters.AddWithValue("@BedAmount", decimal.Parse(BedAmounttextBox.Text));
                    command.Parameters.AddWithValue("@Patient", IPDSearchtextBox.Text);

                    // try
                    //  {
                    con.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data saved successfully!");
                        // Optionally, clear the fields after successful save
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to save data!");
                    }
                    //  }
                    //  catch (Exception ex)
                    //  {
                    //      MessageBox.Show("Error: " + ex.Message);
                    //  }

                    Display();
                }
            }

        }



        // Optional: Clear fields after successful save
        private void ClearFields()
        {
            idTextBox.Text = "";
            IPDSearchtextBox.Text = "";
            DoctorNameComboBox.Text = "";
            FromDtDateTimePicker.Value = DateTime.Today;
            bedTypeComboBox.Text = "";
            bedNoComboBox.Text = "";
            ToDtdateTimePicker.Value = DateTime.Today;
            DaystextBox.Text = "";
            BedRateTextBox.Text = "";
            BedAmounttextBox.Text = "";

            idTextBox.Focus();
        }

        private void BedManagedataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            idTextBox.Text                          = BedManagedataGridView.SelectedRows[0].Cells[0].Value.ToString();
            IPDSearchtextBox.Text                   = BedManagedataGridView.SelectedRows[0].Cells[1].Value.ToString();
            PatientNametextBox.Text                 = BedManagedataGridView.SelectedRows[0].Cells[2].Value.ToString();
            DoctorNameComboBox.SelectedIndex = DoctorNameComboBox.FindStringExact(BedManagedataGridView.SelectedRows[0].Cells[3].Value.ToString());
//            DoctorNameComboBox.Text                 = BedManagedataGridView.SelectedRows[0].Cells[3].Value.ToString();
            FromDtDateTimePicker.Text               = BedManagedataGridView.SelectedRows[0].Cells[4].Value.ToString();
            bedTypeComboBox.SelectedIndex = bedTypeComboBox.FindStringExact(BedManagedataGridView.SelectedRows[0].Cells[5].Value.ToString());
            //bedTypeComboBox.Text                    = BedManagedataGridView.SelectedRows[0].Cells[5].Value.ToString();
            //bedNoComboBox.Text                      = BedManagedataGridView.SelectedRows[0].Cells[6].Value.ToString();
            bedNoComboBox.SelectedIndex = bedNoComboBox.FindStringExact(BedManagedataGridView.SelectedRows[0].Cells[6].Value.ToString());
            ToDtdateTimePicker.Text                 = BedManagedataGridView.SelectedRows[0].Cells[7].Value.ToString();
            DaystextBox.Text                        = BedManagedataGridView.SelectedRows[0].Cells[8].Value.ToString();
            BedRateTextBox.Text                     = BedManagedataGridView.SelectedRows[0].Cells[9].Value.ToString();
            BedAmounttextBox.Text                   = BedManagedataGridView.SelectedRows[0].Cells[10].Value.ToString();

            /*
            DoctorNameComboBox.SelectedIndex        = DoctorNameComboBox.FindStringExact(BedManagedataGridView.SelectedRows[0].Cells[3].Value.ToString());
            
            
            */

        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            //string connectionString = "Data Source=.;Initial Catalog=HMS;Integrated Security=True"; // Replace with your connection string

            //using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"UPDATE BedManagement 
                        SET IPD = @IPD, 
                            DrName = @DrName, 
                            FromDate = @FromDate, 
                            BedType = @BedType, 
                            BedNo = @BedNo, 
                            Todate = @Todate, 
                            Days = @Days, 
                            Rate = @Rate, 
                            BedAmount = @BedAmount, 
                            Patient = @Patient 
                        WHERE Id = @Id";

                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@Id", idTextBox.Text);
                    command.Parameters.AddWithValue("@IPD", IPDSearchtextBox.Text);
                    command.Parameters.AddWithValue("@DrName", DoctorNameComboBox.Text);
                    command.Parameters.AddWithValue("@FromDate", FromDtDateTimePicker.Value);
                    command.Parameters.AddWithValue("@BedType", bedTypeComboBox.Text);
                    command.Parameters.AddWithValue("@BedNo", bedNoComboBox.Text);
                    command.Parameters.AddWithValue("@Todate", ToDtdateTimePicker.Value);
                    command.Parameters.AddWithValue("@Days", int.Parse(DaystextBox.Text));
                    command.Parameters.AddWithValue("@Rate", decimal.Parse(BedRateTextBox.Text));
                    command.Parameters.AddWithValue("@BedAmount", decimal.Parse(BedAmounttextBox.Text));
                    command.Parameters.AddWithValue("@Patient", IPDSearchtextBox.Text);

                    con.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data updated successfully!");
                        // Optionally, clear the fields after successful update
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update data!");
                    }

                    Display(); // Assuming this function displays updated data
                }
            }
            

        }

        private void bedTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}
