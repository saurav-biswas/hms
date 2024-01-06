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
        public PatientMastFrm()
        {
            InitializeComponent();
        }

        private void patientMastBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
            this.Validate();
            this.patientMastBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hMSDataSet);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }

}

        private void PatientMastFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet.BloodGroupMast' table. You can move, or remove it, as needed.
            this.bloodGroupMastTableAdapter.Fill(this.hMSDataSet.BloodGroupMast);
            // TODO: This line of code loads data into the 'hMSDataSet.DoctorMast' table. You can move, or remove it, as needed.
            this.doctorMastTableAdapter.Fill(this.hMSDataSet.DoctorMast);
            // TODO: This line of code loads data into the 'hMSDataSet.PatientMast' table. You can move, or remove it, as needed.
            this.patientMastTableAdapter.Fill(this.hMSDataSet.PatientMast);

        }
    }
}
