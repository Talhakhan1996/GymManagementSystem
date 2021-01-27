using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Mgt_System
{
    public partial class Login : Form
    {
        Connection_Class con = new Connection_Class();
        Login_Class LG = new Login_Class();
        //string userid;
        //string password;
        public object ex { get; private set; }

        public Login()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            LG.username = txtUserName.Text;
            LG.password = txtPassword.Text;
            bool verify = LG.Validation();
            if (txtUserName.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Please Fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
                return;
            }
            
            else if (verify)
            {
                MessageBox.Show("Asalam aliqum : You are Successfully Logged In");
                this.Hide();
                new Form1().Show();
            }
            
            else 
            {
                MessageBox.Show("Invalid username or password");
            }            
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
        }
    }
}





























//if (txtUserName.Text == "")
//{
//    MessageBox.Show("Please enter user name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//    txtUserName.Focus();
//    return;
//}
//else if (txtPassword.Text == "")
//{
//    MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//    txtPassword.Focus();
//    return;
//}
//else
//{
//    //Login_Class LG = new Login_Class(txtUserName.Text, txtPassword.Text);
//    //LG.Validation();
//    //if(txtUserName.Text == "userid" && txtPassword.Text == "password")
//    //{
//    //    this.Hide();
//    //    new Form1().Show();
//    //}
//    //if (dt.Rows.Count < 1)
//    //{
//    //    this.Hide();
//    //    new Form1().Show();
//    //}
//    else
//        MessageBox.Show("Invalid username or password");
//}
//try
//{
//    if(dr.Read()==true)
//    {
//        MessageBox.Show("You have logged in successfully " + txtUserName.Text);
//        //Hide the login form
//        this.Hide();
//    }

//    else
//    {
//        MessageBox.Show("Login Failed...Try again !", "Login Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);

//        txtUserName.Clear();
//        txtPassword.Clear();
//        txtUserName.Focus();
//    }
//}
//catch (Exception ex)
//{

//    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//}