using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Mgt_System
{
    class Trainer_class : Connection_Class
    {
        public string name { get; set; }
        public string gender { get; set; }
        public string dob { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public string address { get; set; }

        //For ID
        public int id { get; set; }

        //Read Properties
        public DataTable dt = new DataTable();

        //Insert method
        public void insert()
        {
            GetDBConnection.Open();
            using (var cmd = new SqlCommand())
            {
                cmd.CommandText = "insert into Trainer (Trainer_name,Trainer_gender,Trainer_dob,Trainer_mobile,Trainer_Email,Trainer_address) values(@name,@gender,@dob,@mobile,@email,@address)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = GetDBConnection;

                //PARAMETERS @name,@cnic,@gender,@dob,@mobile,@email,@joindate,@gymtime,@address,@membershiptype
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                cmd.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender;
                cmd.Parameters.Add("@dob", SqlDbType.NVarChar).Value = dob;
                cmd.Parameters.Add("@mobile", SqlDbType.NVarChar).Value = mobile;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
                cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
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
                cmd.CommandText = "Select * from Trainer";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = GetDBConnection;
                sda.Fill(dt);
                GetDBConnection.Close();
            }
        }
    }
}
