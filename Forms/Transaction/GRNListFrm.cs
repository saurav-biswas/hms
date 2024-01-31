using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.Forms.Transaction
{
    public partial class GRNListFrm : Form
    {
        public GRNListFrm()
        {
            InitializeComponent();
        }

        private void gRNHdrBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gRNHdrBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hMSDataSet);

        }

        private void GRNListFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hMSDataSet.GRNHdr' table. You can move, or remove it, as needed.
            this.gRNHdrTableAdapter.Fill(this.hMSDataSet.GRNHdr);

        }

        private void gRNHdrDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
