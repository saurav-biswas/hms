using HMS.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.Shared;
using System.Configuration;
using System.Data.SqlClient;

namespace HMS
{
    public partial class Login : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["HMS.Properties.Settings.HMSConnectionString"].ConnectionString;
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet.DoctorDepartmentMast' table. You can move, or remove it, as needed.
           // this.doctorDepartmentMastTableAdapter.Fill(this.hMSDataSet.DoctorDepartmentMast);

        }

        private void Okbutton_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                String username = IDtextBox.Text;
                String password = PasswordtextBox.Text;

                try
                {
                    String query = "SELECT * FROM users WHERE username = @username AND password = @password";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        MainFrm myForm = new MainFrm();
                        this.Hide();
                        myForm.ShowDialog();
                        
                    }
                    else
                    {
                        MessageBox.Show("Invalid ID or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        IDtextBox.Clear();
                        PasswordtextBox.Clear();
                        IDtextBox.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
