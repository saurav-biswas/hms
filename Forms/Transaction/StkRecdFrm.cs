using HMS.Forms.Billing;
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
using System.Configuration;
using HMS.Forms.Master;


namespace HMS.Forms.Transaction
{
    public partial class StkRecdFrm : Form
    {
        // string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        string connectionString = ConfigurationManager.ConnectionStrings["HMS.Properties.Settings.HMSConnectionString"].ConnectionString;
        // SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=HMS;Integrated Security=True");

        public StkRecdFrm()
        {
            InitializeComponent();
            

        }

        private void StkRecdFrm_Load(object sender, EventArgs e)
        {
            LoadTaxNames();
            // Subscribe the textBoxGAmt_TextChanged event
            textBoxGAmt.TextChanged += textBoxGAmt_TextChanged;
        }

        private void textBoxTaxName_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxTaxName.Text))
            {
                if (taxPercentages.TryGetValue(textBoxTaxName.Text, out decimal percentage))
                {
                    if (decimal.TryParse(textBoxGAmt.Text, out decimal gAmt))
                    {
                        decimal taxAmt = (percentage / 100) * gAmt;
                        textBoxTaxAmt.Text = taxAmt.ToString(); // Format tax amount to two decimal places
                    }
                }
            }

        }

        // Declare taxPercentages at the class level
        private Dictionary<string, decimal> taxPercentages = new Dictionary<string, decimal>();

        private void LoadTaxNames()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            //string connectionString = "Data Source=.;Initial Catalog=HMS;Integrated Security=True"; // Get connection string from your configuration file

            //using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT TaxName, Percentage FROM TaxMast";
                SqlCommand command = new SqlCommand(query, con);

                con.Open();
                SqlDataReader reader = command.ExecuteReader();

                AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();

                while (reader.Read())
                {
                    string taxName = reader["TaxName"].ToString();
                    decimal percentage = Convert.ToDecimal(reader["Percentage"]);

                    autoCompleteCollection.Add(taxName);
                    taxPercentages.Add(taxName, percentage);
                }

                textBoxTaxName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textBoxTaxName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                textBoxTaxName.AutoCompleteCustomSource = autoCompleteCollection;

                // Subscribe to the textBoxTaxName.TextChanged event to calculate tax amount
                textBoxTaxName.TextChanged += textBoxTaxName_TextChanged;

                con.Close();
            }
        }

        // Calculate total amount function
        private void CalculateTotalAmount()
        {
            if (decimal.TryParse(textBoxGAmt.Text, out decimal gAmt) &&
                decimal.TryParse(textBoxTaxAmt.Text, out decimal taxAmt) &&
                decimal.TryParse(textBoxOtherCharges.Text, out decimal otherCharges))
            {
                decimal totalAmount = gAmt + taxAmt + otherCharges;
                textBoxNAmount.Text = totalAmount.ToString(); // Format to two decimal places
            }
        }

        private void textBoxGAmt_TextChanged(object sender, EventArgs e)
        {
         //   textBoxTaxName_TextChanged(sender, e);
            

            // Format textBoxGAmt to always display two decimal places
            if (decimal.TryParse(textBoxGAmt.Text, out decimal gAmt))
            {
                textBoxGAmt.Text = gAmt.ToString();
            }
            textBoxTaxName_TextChanged(sender, e); // Update tax amount
            CalculateTotalAmount();
        }

        private void textBoxOtherCharges_TextChanged(object sender, EventArgs e)
        {
            
            if (decimal.TryParse(textBoxOtherCharges.Text, out decimal gAmt))
            {
                textBoxOtherCharges.Text = gAmt.ToString();
            }
            CalculateTotalAmount();
        }

        private void textBoxTaxAmt_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalAmount();
        }

        private void buttonItMast_Click(object sender, EventArgs e)
        {
            ItMastFrm myForm = new ItMastFrm();

            myForm.ShowDialog();
        }

        private void buttonSupplierMast_Click(object sender, EventArgs e)
        {

        }

        private void buttonTaxMaster_Click(object sender, EventArgs e)
        {
            TaxMast myForm = new TaxMast();

            myForm.ShowDialog();
        }
    }
}
