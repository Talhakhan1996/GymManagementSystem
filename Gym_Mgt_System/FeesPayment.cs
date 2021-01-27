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
    public partial class FeesPayment : Form
    {
        Connection_Class con = new Connection_Class();
        FeePayment_Class fp = new FeePayment_Class();
        public FeesPayment()
        {
            InitializeComponent();
        }

        private void btn_viewpayments_Click(object sender, EventArgs e)
        {
            ViewPayments vp = new ViewPayments();
            vp.Show();
        }

        private void FeesPayment_Load(object sender, EventArgs e)
        {
            fp.show_name();
            cmbBx_name.DataSource = fp.datafill;
        }
        public void INSERT()
        {
            fp.name = cmbBx_name.Text;
            fp.amount = txtbx_fees.Text;
            fp.desc = txtbx_feesdesc.Text;
            fp.paid_date = dteTmePckr_feedate.Text;
            fp.pkg_name = cmbBx_packagename.Text;
            fp.pkg_type = cmbBx_packagetype.Text;
            fp.insert();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            INSERT();
            MessageBox.Show("Data Inserted");
            cmbBx_name.ResetText();
            txtbx_fees.Clear();
            txtbx_feesdesc.Clear();
            dteTmePckr_feedate.Value = DateTime.Now;
            cmbBx_packagename.ResetText();
            cmbBx_packagetype.ResetText();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            cmbBx_name.ResetText();
            txtbx_fees.Clear();
            txtbx_feesdesc.Clear();
            dteTmePckr_feedate.Value = DateTime.Now;
            cmbBx_packagename.ResetText();
            cmbBx_packagetype.ResetText();
        }

        private void txtbx_fees_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void cmbBx_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            //fp.Get_name();
        }
    }
}
