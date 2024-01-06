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
    public partial class BedNumberMast : Form
    {
        public BedNumberMast()
        {
            InitializeComponent();
        }

        private void bedNumberMastBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            { 
            this.Validate();
            this.bedNumberMastBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hMSDataSet);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }

        private void BedNumberMast_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet.BedTypeMast' table. You can move, or remove it, as needed.
            this.bedTypeMastTableAdapter.Fill(this.hMSDataSet.BedTypeMast);
            // TODO: This line of code loads data into the 'hMSDataSet.BedNumberMast' table. You can move, or remove it, as needed.
            this.bedNumberMastTableAdapter.Fill(this.hMSDataSet.BedNumberMast);

        }
    }
}
