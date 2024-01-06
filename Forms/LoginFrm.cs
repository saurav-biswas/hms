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

namespace HMS
{
    public partial class Login : Form
    {
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
            MainFrm myForm = new MainFrm();

            myForm.ShowDialog();
        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
