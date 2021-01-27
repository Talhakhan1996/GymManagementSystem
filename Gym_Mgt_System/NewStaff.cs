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
    public partial class NewStaff : Form
    {
        Trainer_class tc = new Trainer_class();
        public NewStaff()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //INSERT
            INSERT();
            MessageBox.Show("Data Inserted");
            txtbx_name.Clear();
            txtbx_mobile.Clear();
            txtbx_email.Clear();
            txtbx_address.Clear();
            dteTmePckr_dob.Value = DateTime.Now;
            cmbBx_gender.ResetText();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txtbx_name.Clear();
            txtbx_mobile.Clear();
            txtbx_email.Clear();
            txtbx_address.Clear();
            dteTmePckr_dob.Value = DateTime.Now;
            cmbBx_gender.ResetText();
        }

        public void INSERT()
        {
            tc.name = txtbx_name.Text;
            tc.gender = cmbBx_gender.Text;
            tc.dob = dteTmePckr_dob.Text;
            tc.mobile = txtbx_mobile.Text;
            tc.email = txtbx_email.Text;
            tc.address = txtbx_address.Text;
            tc.insert();
        }

        private void btn_viewtrainers_Click(object sender, EventArgs e)
        {
            ViewTrainers vt = new ViewTrainers();
            vt.Show();
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
