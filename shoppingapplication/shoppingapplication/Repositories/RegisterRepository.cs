using Microsoft.AspNetCore.Mvc.Diagnostics;
using shoppingapplication.Models;
using System.Data;
using System.Data.SqlClient;

namespace shoppingapplication.Repositories
{
    public class RegisterRepository:IRegisterRepository
    {
        public RegisterRepository()
        {

        }
        public int RepositoryInsertUser(loginmodel user)
        {
            string dbconnection= @"Data Source=DESKTOP-BNMUPTQ\SQLEXPRESS;Initial Catalog=shopping;Integrated Security=True;";
            SqlConnection con=new SqlConnection(dbconnection);
            con.Open();
            string sqlquery = "sp_insert_user_details";
            SqlCommand cmd=new SqlCommand(sqlquery, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", user.useracc_name);
            cmd.Parameters.AddWithValue("@age", user.useracc_age);
            cmd.Parameters.AddWithValue("@gender", user.useracc_gender);
            cmd.Parameters.AddWithValue("@address", user.useracc_address);
            cmd.Parameters.AddWithValue("@contact_num", "97832");            
            cmd.Parameters.AddWithValue("@username", user.useracc_uname);
            cmd.Parameters.AddWithValue("@password", user.useracc_password);
            int recordsCount = cmd.ExecuteNonQuery();
            return recordsCount;
        }
    }
}
