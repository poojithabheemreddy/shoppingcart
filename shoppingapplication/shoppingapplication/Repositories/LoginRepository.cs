using shoppingapplication.Models;
using shoppingapplication.Repositories;
using System.Data;
using System.Data.SqlClient;

namespace shoppingapplication.Repositories
{
    public class LoginRepository:ILoginRepository
    {
        public LoginRepository() 
        { 
        }
        public loginmodel RepositoryGetUserDetails(loginmodel login)
        {
            string dbConnection = @"Data Source=DESKTOP-BNMUPTQ\SQLEXPRESS;Initial Catalog=shopping;Integrated Security=True;";
            SqlConnection con = new SqlConnection(dbConnection);
            con.Open();
            string sqlQuery = "sp_get_userdetails";
            SqlCommand cmd=new SqlCommand(sqlQuery, con);
            cmd.CommandType = CommandType.StoredProcedure; 
            cmd.Parameters.AddWithValue("@u_name", login.useracc_uname);
            cmd.Parameters.AddWithValue("@p_word", login.useracc_password);
            SqlDataReader reader = cmd.ExecuteReader();
            loginmodel objloginmodel=new loginmodel();
            while (reader.Read())
            {
                objloginmodel.useracc_id = reader["user_id"].ToString();
                objloginmodel.useracc_typeid = reader["useracc_typeid"].ToString();
                objloginmodel.useracc_uname = reader["name"].ToString();
                objloginmodel.useracc_age = reader["age"].ToString();
                objloginmodel.useracc_gender = reader["gender"].ToString();
                objloginmodel.useracc_address = reader["address"].ToString();
                objloginmodel.useracc_phone = reader["contact_num"].ToString();
                

            }
            return objloginmodel;

            

        }
    }
}
