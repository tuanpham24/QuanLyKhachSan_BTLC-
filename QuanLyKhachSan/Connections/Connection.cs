

using System.Data.SqlClient;

namespace QuanLyKhachSan.Connections
{
    public class Connection
    {
        /*

        private static string connectString = @"Data Source=ANHTUAN\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True";
        public SqlConnection getConnection()
        {
            return new SqlConnection(connectString);
        }
        */


        string connStr = "";
        public string dataConnection()
        {
            connStr = @"Data Source=ANHTUAN\SQLEXPRESS;Initial Catalog=QLKhachSan;Integrated Security=True";
            return connStr;
        }

        public SqlConnection getConnection()
        {
            return new SqlConnection(dataConnection());
        }
    }
}
