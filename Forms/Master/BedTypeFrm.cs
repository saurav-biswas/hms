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
    public partial class BedTypeFrm : Form
    {
        public BedTypeFrm()
        {
            InitializeComponent();
        }

        private void bedTypeMastBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
            this.Validate();
            this.bedTypeMastBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hMSDataSet);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }

        private void BedTypeFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet.BedTypeMast' table. You can move, or remove it, as needed.
            this.bedTypeMastTableAdapter.Fill(this.hMSDataSet.BedTypeMast);

        }
    }
}
