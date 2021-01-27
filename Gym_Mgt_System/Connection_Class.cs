using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Mgt_System
{
    class Connection_Class
    {
        public SqlConnection GetDBConnection;
        public Connection_Class()
        {
            string connection_string = @"Data Source=DESKTOP-KVDU2MC\SQLEXPRESS;Initial Catalog=Gym_Mgt_System;Integrated Security=True";
            GetDBConnection = new SqlConnection(connection_string);
            
        }
    }
}
























//SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KVDU2MC\SQLEXPRESS;Initial Catalog=Gym_Mgt_System;Integrated Security=True");
//con.Open();
//return con;
//public SqlCommand cmd = new SqlCommand();
//public DataSet ds = new DataSet();
//public SqlDataAdapter ada = new SqlDataAdapter();
//public SqlDataReader dr;

//public void class1()
//{
//    if (con.State == ConnectionState.Open)
//    {
//        con.Close();
//        con.Open();
//    }
//    con.ConnectionString = @"Data Source=DESKTOP-KVDU2MC\SQLEXPRESS;Initial Catalog=Gym_Mgt_System;Integrated Security=True";
//    con.Open();
//    cmd.Connection = con;
//}