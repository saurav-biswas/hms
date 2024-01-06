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
    public partial class PrescriptionList : Form
    {
        public PrescriptionList()
        {
            InitializeComponent();
        }

        private void prescriptionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.prescriptionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hMSDataSet);

        }

        private void PrescriptionList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet.Prescription' table. You can move, or remove it, as needed.
            this.prescriptionTableAdapter.Fill(this.hMSDataSet.Prescription);

        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            PrescriptionAdd myForm = new PrescriptionAdd();

            myForm.ShowDialog();
        }
    }
}
