
using System.Data;
using System.Data.SqlClient;
using QuanLyKhachSan.Connections;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Connections
{
    public class DichVuDAL
    {
        Connection dataConn;
        SqlDataAdapter dataAdapter;
        SqlCommand sqlCmd;

        public DichVuDAL()
        {
            dataConn = new Connection();
        }
        
        public DataTable getAllDichVu()
        {
            DataTable dataTable = new DataTable();

            using(SqlConnection sqlConnection = dataConn.getConnection())
            {
                string sql = "SELECT * FROM dbo.DichVu";
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(sql, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }

            return dataTable;
        }

        public bool insertDichVu(DichVu dichVu)
        {
            string sql = "INSERT INTO dbo.DichVu VALUES(@MaDV, @TenDV)";
            SqlConnection sqlConnection = dataConn.getConnection();
            try
            {
                sqlConnection.Open();
                sqlCmd = new SqlCommand(sql, sqlConnection);
                sqlCmd.Parameters.Add("MaDV", SqlDbType.Char).Value = dichVu.MaDV;
                sqlCmd.Parameters.Add("TenDV", SqlDbType.NVarChar).Value = dichVu.TenDV;
                
                sqlCmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Err: " + ex.Message, "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }

        public bool updateDichVu(DichVu dichVu)
        {
            string sql = "UPDATE dbo.DichVu SET MaDV = @MaDV, TenDV = @TenDV WHERE MaDV = @MaDV";
            SqlConnection sqlConnection = dataConn.getConnection();
            try
            {
                sqlConnection.Open();
                sqlCmd = new SqlCommand(sql, sqlConnection);
                sqlCmd.Parameters.Add("@MaDV", SqlDbType.Char).Value = dichVu.MaDV;
                sqlCmd.Parameters.Add("@TenDV", SqlDbType.NVarChar).Value = dichVu.TenDV;
                
                sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Err: " + ex.Message, "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        public bool deleteDichVu(DichVu dichVu)
        {
            string sql = "DELETE dbo.DichVu WHERE MaDV = @MaDV";
            SqlConnection sqlConnection = dataConn.getConnection();
            try
            {
                sqlConnection.Open();
                sqlCmd = new SqlCommand(sql, sqlConnection);
                sqlCmd.Parameters.Add("@MaDV", SqlDbType.Char).Value = dichVu.MaDV;
                sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Err: " + ex.Message, "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
    }
}
