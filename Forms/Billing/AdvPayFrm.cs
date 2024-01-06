using HMS.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO.Ports;
using System.Reflection;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Configuration;


namespace HMS.Forms.Billing
{
    public partial class AdvPayFrm : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["HMS.Properties.Settings.HMSConnectionString"].ConnectionString;
        //        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=HMS;Integrated Security=True");
        public AdvPayFrm()
        {
            InitializeComponent();
        }

        private void AdvPayFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet.IPD' table. You can move, or remove it, as needed.
            this.iPDTableAdapter.Fill(this.hMSDataSet.IPD);
            // TODO: This line of code loads data into the 'hMSDataSet1.PatientMast' table. You can move, or remove it, as needed.
            this.patientMastTableAdapter.Fill(this.hMSDataSet.PatientMast);
            // TODO: This line of code loads data into the 'hMSDataSet.Advance' table. You can move, or remove it, as needed.
            this.advanceTableAdapter.Fill(this.hMSDataSet.Advance);
            Display();
        }

        private void printbutton_Click(object sender, EventArgs e)
        {
            AdvancePayRep report = new AdvancePayRep();
            AdvcrystalReportViewer view = new AdvcrystalReportViewer();
            
            report.SetParameterValue("AP_ID", idTextBox.Text);
            report.SetParameterValue("AP_PatName", PatNametextBox.Text);
            report.SetParameterValue("AP_AdvAmt", advAmtTextBox.Text);
            report.SetParameterValue("AP_PayMode", payModeComboBox.Text);
            report.SetParameterValue("AP_Date", AdvpayDateDateTimePicker.Text);
            report.SetParameterValue("AP_IPD", patIDComboBox.Text);
            view.crystalReportViewer1.ReportSource = report;
            //view.ReportSource = report;
            //   view.crystalReportViewer1.ReportSource = report;

            view.Show();
        }

        private void payModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void payDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Findbutton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            //using (SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=HMS;Integrated Security=True"))
            {

                con.Open();

                string PID = PatientidTextBox.Text;
                string patName = PatNametextBox.Text;

                string query = "SELECT PatName FROM PatientMast WHERE id  = " + PID;
                SqlCommand cmd = new SqlCommand(query, con);

                var reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    PatNametextBox.Text = reader["PatName"].ToString();
                }
                else
                    MessageBox.Show("No Patient Found");


                con.Close();


            }
        }

        private void advAmtTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Addbutton_Click(object sender, EventArgs e)
        {

            idTextBox.Text = "";
            AdvpayDateDateTimePicker.Text = "";
            PatientidTextBox.Text = "";
            PatNametextBox.Text = "";
            advAmtTextBox.Text = "";
            payModeComboBox.SelectedIndex = -1;
            patIDComboBox.Text = "";
            

            idTextBox.Focus();
            Display();
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            { 

                con.Open();
            SqlCommand cmd = new SqlCommand(@"INSERT INTO Advance (Id,PayDate,PatientID,Patient,AdvAmt,PayMode,PatID) 
            values ('" + idTextBox.Text + "','" + AdvpayDateDateTimePicker.Value.ToString("yyyy-MM-dd") + "','" + PatientidTextBox.Text + "','" + PatNametextBox.Text + "','" + advAmtTextBox.Text + "','" + payModeComboBox.Text + "','" + patIDComboBox.Text + "')", con);



            cmd.ExecuteNonQuery();

            // Updating PatientMast
            SqlCommand cmdUpdate = new SqlCommand(@"UPDATE PatientMast 
                                        SET PatBalAmt = PatBalAmt + @AdvAmt 
                                        WHERE Id = @PatientID", con);

            // Parameterizing values to prevent SQL injection
            cmdUpdate.Parameters.AddWithValue("@AdvAmt", Convert.ToDecimal(advAmtTextBox.Text));
            cmdUpdate.Parameters.AddWithValue("@PatientID", PatientidTextBox.Text);

            cmdUpdate.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Saved...!");
            Display();
        }
        }

        void Display()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            //

            {
                SqlDataAdapter sda = new SqlDataAdapter("Select * from Advance", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            advanceDataGridView.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {

                int n = advanceDataGridView.Rows.Add();

                advanceDataGridView.Rows[n].Cells[0].Value = item["Id"].ToString();
                advanceDataGridView.Rows[n].Cells[1].Value = item["PayDate"].ToString();
                advanceDataGridView.Rows[n].Cells[2].Value = item["PatientID"].ToString();
                advanceDataGridView.Rows[n].Cells[3].Value = item["Patient"].ToString();
                advanceDataGridView.Rows[n].Cells[4].Value = item["AdvAmt"].ToString();
                advanceDataGridView.Rows[n].Cells[5].Value = item["PayMode"].ToString();
                advanceDataGridView.Rows[n].Cells[6].Value = item["PatID"].ToString();


            }
        }
        }

        private void Updatebutton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            //
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"UPDATE Advance SET PayDate = @PayDate, PatientID = @PatientID, Patient = @Patient, AdvAmt = @AdvAmt, PayMode = @PayMode WHERE Id = @Id", con);

                cmd.Parameters.AddWithValue("@PayDate", AdvpayDateDateTimePicker.Value.ToString("yyyy-MM-dd"));
                cmd.Parameters.AddWithValue("@PatientID", PatientidTextBox.Text);
                cmd.Parameters.AddWithValue("@Patient", PatNametextBox.Text);
                cmd.Parameters.AddWithValue("@AdvAmt", advAmtTextBox.Text);
                cmd.Parameters.AddWithValue("@PayMode", payModeComboBox.Text);
                cmd.Parameters.AddWithValue("@Id", idTextBox.Text);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Update Successfully.....!");
                Display();
            }
        }


        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            idTextBox.Text = "";
            AdvpayDateDateTimePicker.Text = "";
            PatientidTextBox.Text = "";
            PatNametextBox.Text = "";
            advAmtTextBox.Text = "";
            payModeComboBox.SelectedIndex = -1;
            patIDComboBox.Text = "";

            idTextBox.Focus();
        }

        private void advanceDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            idTextBox.Text =                advanceDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            AdvpayDateDateTimePicker.Text = advanceDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            PatientidTextBox.Text =         advanceDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            PatNametextBox.Text =           advanceDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            advAmtTextBox.Text =            advanceDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            payModeComboBox.Text =          advanceDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            patIDComboBox.Text =            advanceDataGridView.SelectedRows[0].Cells[6].Value.ToString();

          
        }

        private void patIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void advanceDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
