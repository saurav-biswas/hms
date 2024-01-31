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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Xamarin.Forms;


namespace HMS.Reports
{
    public partial class StkStatementDtlViewer : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["HMS.Properties.Settings.HMSConnectionString"].ConnectionString;
       // ReportDocument crystal = new ReportDocument();

        public StkStatementDtlViewer()
        {
            InitializeComponent();
        }




        private void StkStatementDtlViewer_Load(object sender, EventArgs e)
        {
            try
            {
                // Assuming you have a DataSet named HMSDataSet
                HMSDataSet dataSet = new HMSDataSet();

                // Fetch data from the database into the DataSet
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("SELECT ItCode, ItName, ItUnit, ItRate, ItStock, ItAmt FROM ItMast", con);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    // You can explicitly set the command type to StoredProcedure if needed
                    // command.CommandType = CommandType.StoredProcedure;

                    adapter.Fill(dataSet, "ItMast");
                }

                // Create an instance of your Crystal Report
                StkStatementDtl report = new StkStatementDtl(); // Replace with the actual name of your Crystal Report class

                // Set the DataSet as the report's data source
                report.SetDataSource(dataSet);

                // Set the report to the CrystalReportViewer
                crystalReportViewer1.ReportSource = report;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        
    }
}
