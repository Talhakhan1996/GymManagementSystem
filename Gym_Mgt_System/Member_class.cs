using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Mgt_System
{
    class Member_class : Connection_Class
    {
        public string name { get; set; }
        public string cnic { get; set; }
        public string gender { get; set; }
        public string dob { get; set; }
        public string mobile { get; set; }
        public string email { get; set; }
        public string gymtime { get; set; }
        public string joindate { get; set; }
        public string address { get; set; }
        public string membershiptype { get; set; }

        //For ID
        public int id { get; set; }
        
        //For Search Values
        public string search_text { get; set; }

        //Read Properties
        public DataTable dt = new DataTable();
        private DataSet ds = new DataSet(); 
        
        //Insert method
        public void insert()
        {
            GetDBConnection.Open();
            using (var cmd = new SqlCommand())
            {
                cmd.CommandText = "insert into Member (Member_name,Member_CNIC,Member_gender,Member_dob,Member_mobile,Member_Email,Join_date,Gym_time,Member_address,Membership_type) values(@name,@cnic,@gender,@dob,@mobile,@email,@joindate,@gymtime,@address,@membershiptype)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = GetDBConnection;

                //PARAMETERS @name,@cnic,@gender,@dob,@mobile,@email,@joindate,@gymtime,@address,@membershiptype
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                cmd.Parameters.Add("@cnic", SqlDbType.NVarChar).Value = cnic;
                cmd.Parameters.Add("@gender", SqlDbType.NVarChar).Value = gender;
                cmd.Parameters.Add("@dob", SqlDbType.NVarChar).Value = dob;
                cmd.Parameters.Add("@mobile", SqlDbType.NVarChar).Value = mobile;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
                cmd.Parameters.Add("@joindate", SqlDbType.NVarChar).Value = joindate;
                cmd.Parameters.Add("@gymtime", SqlDbType.NVarChar).Value = gymtime;
                cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
                cmd.Parameters.Add("@membershiptype", SqlDbType.NVarChar).Value = membershiptype;
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
                cmd.CommandText = "Select * from Member";
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
                cmd.CommandText = "Select * from Member where Member_name ='"+search_text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                cmd.CommandType = CommandType.Text;
                cmd.Connection = GetDBConnection;
                sda.Fill(dt);
                GetDBConnection.Close();
            }
        }

        //Delete Method
        public void Delete_Data()
        {
            GetDBConnection.Open();
            using (var cmd = new SqlCommand())
            {
                dt.Clear();
                cmd.CommandText = "Delete from Member where Member_id = @id";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                cmd.CommandType = CommandType.Text;

                //PARAMETERS @name
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                cmd.Connection = GetDBConnection;
                sda.Fill(dt);
                GetDBConnection.Close();
            }
        }

        //Update Method
        public void Update_Data()
        {
            GetDBConnection.Open();
            using (var cmd = new SqlCommand())
            {
                dt.Clear();
                cmd.CommandText = "Update Member SET Member_mobile=@mobile, Member_Email=@email, Gym_time=@gymtime, Member_address=@address, Membership_type=@membershiptype where Member_id = @id";
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                cmd.CommandType = CommandType.Text;

                //PARAMETERS
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmd.Parameters.Add("@mobile", SqlDbType.NVarChar).Value = mobile;
                cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
                cmd.Parameters.Add("@gymtime", SqlDbType.NVarChar).Value = gymtime;
                cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
                cmd.Parameters.Add("@membershiptype", SqlDbType.NVarChar).Value = membershiptype;

                cmd.Connection = GetDBConnection;
                sda.Fill(dt);
                GetDBConnection.Close();
            }
        }
    }
}

