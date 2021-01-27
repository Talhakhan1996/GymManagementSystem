using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Mgt_System
{
    class FeePayment_Class : Connection_Class
    {
         //get set properties
        public int id { get; set; }
        public string name { get; set; }
        public string amount { get; set; }
        public string desc { get; set; }
        public string paid_date { get; set; }
        public string pkg_name { get; set; }
        public string pkg_type { get; set; }

        //For Search Values
        public string search_text { get; set; }

        //Read Properties
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet();

        public void insert()
        {
            GetDBConnection.Open();
            using (var cmd = new SqlCommand())
            {
                cmd.CommandText = "insert into Payment (Payment_Customer_name,Payment_amount,Payment_description,Payment_date,Package_name,Package_type) values(@name,@amount,@desc,@paid_date,@pkg_name,@pkg_type)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = GetDBConnection;

                //PARAMETERS @name,@cnic,@gender,@dob,@mobile,@email,@joindate,@gymtime,@address,@membershiptype
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                cmd.Parameters.Add("@amount", SqlDbType.NVarChar).Value = amount;
                cmd.Parameters.Add("@desc", SqlDbType.NVarChar).Value = desc;
                cmd.Parameters.Add("@paid_date", SqlDbType.NVarChar).Value = paid_date;
                cmd.Parameters.Add("@pkg_name", SqlDbType.NVarChar).Value = pkg_name;
                cmd.Parameters.Add("@pkg_type", SqlDbType.NVarChar).Value = pkg_type;
                cmd.ExecuteNonQuery();
                GetDBConnection.Close();
            }
        }

        //Read Method
        public void Read_Data()
        {
            GetDBConnection.Open();
            using (var cmd = new SqlCommand())
            {
                dt.Clear();
                cmd.CommandText = "Select * from Payment";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = GetDBConnection;
                sda.Fill(dt);
                GetDBConnection.Close();
            }
        }

        
        //Search Method
        public void Search_Data()
        {
            GetDBConnection.Open();
            using (var cmd = new SqlCommand())
            {
                dt.Clear();
                cmd.CommandText = "Select * from Payment where Payment_Customer_name ='" + search_text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = GetDBConnection;
                sda.Fill(dt);
                GetDBConnection.Close();
            }
        }

        //show name
        public List<string> datafill = new List<string>();
        public void show_name()
        {
            GetDBConnection.Open();
            using (var cmd = new SqlCommand())
            {
                datafill.Clear();
                SqlDataReader rd;
                cmd.CommandText = "Select * from member";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = GetDBConnection;
                rd = cmd.ExecuteReader();
                while(rd.Read())
                {
                    datafill.Add(rd[1].ToString());
                }
                GetDBConnection.Close();
            }
        }
    }
}
