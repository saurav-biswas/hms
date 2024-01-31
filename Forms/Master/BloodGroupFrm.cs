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
    public partial class BloodGroupFrm : Form
    {
        public BloodGroupFrm()
        {
            InitializeComponent();
        }

        private void bloodGroupMastBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
            this.Validate();
            this.bloodGroupMastBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hMSDataSet);
                MessageBox.Show("Update successful");
        }

            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }

}

        private void BloodGroupFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet.BloodGroupMast' table. You can move, or remove it, as needed.
            this.bloodGroupMastTableAdapter.Fill(this.hMSDataSet.BloodGroupMast);

        }

        private void BloodGroupFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
