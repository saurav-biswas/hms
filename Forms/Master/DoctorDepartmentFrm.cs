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

namespace HMS.Forms.Master
{
    public partial class DoctorDepartmentFrm : Form
    {
        public DoctorDepartmentFrm()
        {
            InitializeComponent();
        }

        private void doctorDepartmentMastBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
            this.Validate();
            this.doctorDepartmentMastBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hMSDataSet);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }

        private void DoctorDepartmentFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet.DoctorDepartmentMast' table. You can move, or remove it, as needed.
            this.doctorDepartmentMastTableAdapter.Fill(this.hMSDataSet.DoctorDepartmentMast);

        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }

        private void doctorDepartmentMastBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
