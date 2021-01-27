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
    public partial class ViewMembers : Form
    {
        Connection_Class con = new Connection_Class();
        Member_class mc = new Member_class();
        public ViewMembers()
        {
            InitializeComponent();
        }

        private void ViewMembers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gym_Mgt_SystemDataSet2.Member' table. You can move, or remove it, as needed.
            //this.memberTableAdapter.Fill(this.gym_Mgt_SystemDataSet2.Member);
            READ();
        }

        public void READ()
        {
            dataGridView1.DataSource = null;
            mc.Read_Data();
            dataGridView1.DataSource = mc.dt;
        }
    }
}
