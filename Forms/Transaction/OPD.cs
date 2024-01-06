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

namespace HMS.Forms.Transaction
{
    public partial class OPD : Form
    {
        public OPD()
        {
            InitializeComponent();
        }

        private void oPDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
            this.Validate();
            this.oPDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hMSDataSet);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }

        private void OPD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet.DoctorMast' table. You can move, or remove it, as needed.
            this.doctorMastTableAdapter.Fill(this.hMSDataSet.DoctorMast);
            // TODO: This line of code loads data into the 'hMSDataSet.PatientMast' table. You can move, or remove it, as needed.
            this.patientMastTableAdapter.Fill(this.hMSDataSet.PatientMast);
            // TODO: This line of code loads data into the 'hMSDataSet.OPD' table. You can move, or remove it, as needed.
            this.oPDTableAdapter.Fill(this.hMSDataSet.OPD);

        }
    }
}
