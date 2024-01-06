using System.Data.SqlClient;

namespace HMS.Forms.Billing
{
    internal class bedManagementDataGridView
    {
        private SqlCommand cmd;

        public bedManagementDataGridView(SqlCommand cmd)
        {
            this.cmd = cmd;
        }
    }
}