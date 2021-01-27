using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Mgt_System
{
    public partial class UpdateMember : Form
    {
        Connection_Class con = new Connection_Class();
        Member_class mc = new Member_class();
        int indexRow;
        public UpdateMember()
        {
            InitializeComponent();
        }

        private void UpdateMember_Load(object sender, EventArgs e)
        {
            READ();
        }
        public void READ()
        {
            dataGridView1.DataSource = null;
            mc.Read_Data();
            dataGridView1.DataSource = mc.dt;
        }

        private void datagridview1(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            txtbx_id.Text = row.Cells[0].Value.ToString();
            txtbx_email.Text = row.Cells[6].Value.ToString();
            txtbx_mobile.Text = row.Cells[5].Value.ToString();
            txtbx_address.Text = row.Cells[9].Value.ToString();
            cmbBx_gymtime.Text = row.Cells[8].Value.ToString();
            cmbBx_membership.Text = row.Cells[10].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            UPDATE();
            READ();
        }

        public void UPDATE()
        {
            if (MessageBox.Show("This will Update your data. Confirm?", "Update Data", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                mc.id = int.Parse(txtbx_id.Text);
                mc.mobile = txtbx_mobile.Text;
                mc.email = txtbx_email.Text;
                mc.gymtime = cmbBx_gymtime.Text;
                mc.address = txtbx_address.Text;
                mc.membershiptype = cmbBx_membership.Text;
                mc.Update_Data();

                txtbx_id.Clear();
                txtbx_address.Clear();
                txtbx_email.Clear();
                txtbx_mobile.Clear();
                cmbBx_gymtime.ResetText();
                cmbBx_membership.ResetText();
                dataGridView1.DataSource = mc.dt;
                MessageBox.Show("Data Update Succesfully");
            }
            else
            {
                this.Activate();
                READ();
            }
        }

        private void txtbx_email_Leave(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (Regex.IsMatch(txtbx_email.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.txtbx_email, "Please Provide valid email");
            }
        }
    }
}
