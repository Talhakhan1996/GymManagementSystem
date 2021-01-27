using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Mgt_System
{
    public partial class ViewPayments : Form
    {
        Connection_Class con = new Connection_Class();
        FeePayment_Class fp = new FeePayment_Class();
        public ViewPayments()
        {
            InitializeComponent();
        }

        private void ViewPayments_Load(object sender, EventArgs e)
        {
            READ();
        }
        public void READ()
        {
            dataGridView1.DataSource = null;
            fp.Read_Data();
            dataGridView1.DataSource = fp.dt;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (txtbx_search.Text == "")
            {
                MessageBox.Show("Please Fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtbx_search.Focus();
                return;
            }

            dataGridView1.DataSource = null;
            fp.search_text = txtbx_search.Text;
            fp.Search_Data();
            dataGridView1.DataSource = fp.dt;
        }

        private void txtbx_search_TextChanged(object sender, EventArgs e)
        {
            if (txtbx_search.Text == "")
            {
                READ();
            }
        }
    }
}
