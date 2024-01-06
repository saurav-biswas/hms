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
    public partial class PrescriptionAdd : Form
    {
        public PrescriptionAdd()
        {
            InitializeComponent();
        }

        private void prescriptionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prescriptionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hMSDataSet);

        }

        private void Prescription_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet.PresMed' table. You can move, or remove it, as needed.
            this.presMedTableAdapter.Fill(this.hMSDataSet.PresMed);
            // TODO: This line of code loads data into the 'hMSDataSet.DoctorMast' table. You can move, or remove it, as needed.
            this.doctorMastTableAdapter.Fill(this.hMSDataSet.DoctorMast);
            // TODO: This line of code loads data into the 'hMSDataSet.PatientMast' table. You can move, or remove it, as needed.
            this.patientMastTableAdapter.Fill(this.hMSDataSet.PatientMast);
            // TODO: This line of code loads data into the 'hMSDataSet.Prescription' table. You can move, or remove it, as needed.
            this.prescriptionTableAdapter.Fill(this.hMSDataSet.Prescription);

        }
    }
}
