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
    public partial class TaxMast : Form
    {
        public TaxMast()
        {
            InitializeComponent();
        }

        private void TaxMast_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet.TaxMast' table. You can move, or remove it, as needed.
            this.taxMastTableAdapter.Fill(this.hMSDataSet.TaxMast);
            // TODO: This line of code loads data into the 'hMSDataSet.TaxMast' table. You can move, or remove it, as needed.
            this.taxMastTableAdapter.Fill(this.hMSDataSet.TaxMast);

        }

        private void taxMastBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
            this.Validate();
            this.taxMastBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hMSDataSet);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }
    }
}
