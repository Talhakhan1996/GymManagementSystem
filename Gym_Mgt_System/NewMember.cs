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
    public partial class NewMember : Form
    {
        Connection_Class con = new Connection_Class();
        Member_class mc = new Member_class();
        public NewMember()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void rdiobtn_male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdiobtn_female_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txtbx_name.Clear();
            txtbx_cnic.Clear();
            txtbx_mobile.Clear();
            txtbx_email.Clear();
            txtbx_address.Clear();

            cmbBx_gender.ResetText();
            cmbBx_gymtime.ResetText();
            cmbBx_membership.ResetText();

            dteTmePckr_dob.Value = DateTime.Now;
            dteTmePckr_joindate.Value = DateTime.Now;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //INSERT Method
            INSERT();
            MessageBox.Show("Data Inserted");
            txtbx_name.Clear();
            txtbx_cnic.Clear();
            txtbx_mobile.Clear();
            txtbx_email.Clear();
            txtbx_address.Clear();

            cmbBx_gender.ResetText();
            cmbBx_gymtime.ResetText();
            cmbBx_membership.ResetText();

            dteTmePckr_dob.Value = DateTime.Now;
            dteTmePckr_joindate.Value = DateTime.Now;
        }

        public void INSERT()
        {
            mc.name = txtbx_name.Text;
            mc.cnic = txtbx_cnic.Text;
            mc.gender = cmbBx_gender.Text;
            mc.dob = dteTmePckr_dob.Text;
            mc.mobile = txtbx_mobile.Text;
            mc.email = txtbx_email.Text;
            mc.joindate = dteTmePckr_joindate.Text;
            mc.gymtime = cmbBx_gymtime.Text;
            mc.address = txtbx_address.Text;
            mc.membershiptype = cmbBx_membership.Text;
            mc.insert();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_viewmembers_Click(object sender, EventArgs e)
        {
            ViewMembers vm = new ViewMembers();
            vm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateMember um = new UpdateMember();
            um.Show();
        }

        private void txtbx_email_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtbx_email_Leave(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if(Regex.IsMatch(txtbx_email.Text,pattern))
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
