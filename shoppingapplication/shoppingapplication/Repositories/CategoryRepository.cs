using System.Data;
using System.Data.SqlClient;
namespace shoppingapplication.Repositories
{
    public class CategoryRepository:ICategoryRepository
    {
        public CategoryRepository()
        {

        }
        public int RepoInsertCategory(int categoryName,string categoryDesc)
        {
            string dbconnection = @"Data Source=DESKTOP-BNMUPTQ\SQLEXPRESS;Initial Catalog=shopping;Integrated Security=True;";
            SqlConnection con = new SqlConnection(dbconnection);
            con.Open();
            string sqlquery = "sp_insert_categories";
            SqlCommand cmd = new SqlCommand(sqlquery, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@categoryname", categoryName);
            cmd.Parameters.AddWithValue("@categorydesc", categoryDesc);
            int recordsCount=cmd.ExecuteNonQuery();
            return recordsCount;
        }
    }
}
