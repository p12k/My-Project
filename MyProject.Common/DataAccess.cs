using System.Data;
using System.Data.SqlClient;

namespace MyProject.Common
{
    public class DataAccess
    {
        public static  int ExecuteNonQuery(SqlConnection con ,SqlCommand sqlCommand)
        {
              int strls=0;

            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();
                sqlCommand.Connection = con;
                strls = sqlCommand.ExecuteNonQuery();
                con.Close();
            }

            
            catch(Exception ex)
            {
                throw ex;
            }

            return strls;
        }


        public static DataTable GetDataTable(SqlConnection connection, SqlCommand command)
        {
           
            
            try
            {
                DataTable dataTable = new DataTable();
                command.Connection = connection;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                return dataTable;
            }
            catch(Exception Ex)
            {
                throw Ex;
            }
           

        }
        public static SqlConnection GetConnection(SqlConnection connection)
        {
           // SqlConnection con = new SqlConnection(Constants.Connection.ConnectionString);
            return connection;
        }
      
    }

}
