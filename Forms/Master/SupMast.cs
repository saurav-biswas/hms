using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.Forms.Master
{
    public partial class SupMast : Form
    {
        public SupMast()
        {
            InitializeComponent();
        }

        private void suppMastBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.suppMastBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hMSDataSet);

        }

        private void SupMast_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet.SuppMast' table. You can move, or remove it, as needed.
            this.suppMastTableAdapter.Fill(this.hMSDataSet.SuppMast);

        }
    }
}
