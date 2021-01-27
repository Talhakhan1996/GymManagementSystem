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
    public partial class DeleteMember : Form
    {
        Connection_Class con = new Connection_Class();
        Member_class mc = new Member_class();

        public DeleteMember()
        {
            InitializeComponent();
        }

        private void DeleteMember_Load(object sender, EventArgs e)
        {
            READ();            
        }

        public void READ()
        {
            dataGridView1.DataSource = null;
            mc.Read_Data();
            dataGridView1.DataSource = mc.dt;
        }
        public void DELETE()
        {
            if(MessageBox.Show("This will delete your data. Confirm?", "Delete Data", MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                mc.id = int.Parse(txtbx_delete.Text);
                mc.Delete_Data();
                txtbx_delete.Clear();
                dataGridView1.DataSource = mc.dt;
            }
            else
            {
                this.Activate();
                READ();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DELETE();
            READ();
        }
    }
}
