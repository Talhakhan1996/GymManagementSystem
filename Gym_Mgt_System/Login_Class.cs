using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Mgt_System
{
    class Login_Class : Connection_Class
    {
        public string username { get; set; }
        public string password { get; set; }
        
        public bool Validation()
        {
            GetDBConnection.Open();
            bool check = false;
            using (var cmd = new SqlCommand())
            {
                cmd.CommandText = "Select * from Admin_Login username=@user AND pass=@pass";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = GetDBConnection;

                //PARAMETERS
                cmd.Parameters.Add("@user", SqlDbType.NVarChar).Value = username;
                cmd.Parameters.Add("@pass", SqlDbType.NVarChar).Value = password;

                check = true;
                GetDBConnection.Close();
                return check;
            }
        }
    }
}













//static string userid;
//static string password;


//public Login_Class(string _userid, string _password)
//{
//    userid = _userid;
//    password = _password;
//}

//public string getidinfo
//{
//    get
//    {
//        return userid;
//    }
//}

//public string getpassinfo

//{
//    get
//    {
//        return password;
//    }
//}
//try
//{
//    SqlConnection con = Connection_Class.GetDBConnection();
//    string SQL = @"SELECT * FROM Admin_Login where 
//                    username ='" + userid + "' AND pass ='" + password + "'";
//    SqlDataAdapter sda = new SqlDataAdapter(SQL, con);
//    DataTable dt = new DataTable();
//    sda.Fill(dt);
//    con.Close();
//}
//catch (InvalidCastException e)
//{
//    throw (e);    // Rethrowing exception e
//}
//return null;
//SqlCommand cmd = new SqlCommand("select userid,password from login where userid='" + textBox1.Text + "'and password='" + textBox2.Text + "'", con);  

//public string username { get; set; }
//public string password { get; set; }

//public void Select()
//{
//    con = new SqlConnection();
//    cmd = new SqlCommand();
//    ds = new DataSet();
//    ada = new SqlDataAdapter();

//    cmd = new SqlCommand("SELECT username,pass FROM Admin_Login WHERE username = @username AND pass = @pass", con);

//    SqlParameter uName = new SqlParameter("@username", SqlDbType.VarChar);
//    SqlParameter uPassword = new SqlParameter("@pass", SqlDbType.VarChar);

//    cmd.Parameters.Add(uName);
//    cmd.Parameters.Add(uPassword);

//    cmd.Connection.Open();

//    dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);

//    cmd.Connection.Close();
//}