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
    public partial class SearchMember : Form
    {
        Connection_Class con = new Connection_Class();
        Member_class mc = new Member_class();
        public SearchMember()
        {
            InitializeComponent();
        }

        private void SearchMember_Load(object sender, EventArgs e)
        {
            READ();
        }

        public void READ()
        {
            dataGridView1.DataSource = null;
            mc.Read_Data();
            dataGridView1.DataSource = mc.dt;
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
            mc.search_text = txtbx_search.Text;
            mc.Search_Data();
            dataGridView1.DataSource = mc.dt;
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
