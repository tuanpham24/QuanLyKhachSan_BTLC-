

using System.Data;
using System.Data.SqlClient;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Connections
{
    public class NhanVienDAL
    {
        Connection dataConn;
        SqlDataAdapter dataAdapter;
        SqlCommand sqlCmd;

        public NhanVienDAL()
        {
            dataConn = new Connection();
        }

        public DataTable getAllNhanVien()
        {
            DataTable dataTable = new DataTable();
            string sql = "SELECT * FROM dbo.NhanVien";

            using (SqlConnection sqlConnection = dataConn.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(sql, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
                
            }
            return dataTable;
        }

        public bool insertNhanVien(NhanVien nhanVien)
        {
            string sql = "INSERT INTO dbo.NhanVien VALUES(@MaNV, @TenNV, @ChucVu, @MaDV)";
            SqlConnection sqlConnection = dataConn.getConnection();

            try
            {
                sqlCmd = new SqlCommand(sql, sqlConnection);
                sqlConnection.Open();
                sqlCmd.Parameters.Add("@MaNV", SqlDbType.Char).Value = nhanVien.MaNV;
                /*
                sqlCmd.Parameters.AddWithValue("@MaNV", nhanVien.MaNV ?? (object)DBNull.Value);
                sqlCmd.Parameters.AddWithValue("@TenNV", nhanVien.TenNV ?? (object)DBNull.Value);
                sqlCmd.Parameters.AddWithValue("@ChucVu", nhanVien.ChucVu ?? (object)DBNull.Value);
                sqlCmd.Parameters.AddWithValue("@MaDV", nhanVien.MaDV ?? (object)DBNull.Value);
                /*/
                sqlCmd.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = nhanVien.TenNV;
                sqlCmd.Parameters.Add("@ChucVu", SqlDbType.NVarChar).Value = nhanVien.ChucVu;
                sqlCmd.Parameters.Add("@MaDV", SqlDbType.Char).Value = nhanVien.MaDV;

                sqlCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Err: " + ex.Message, "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                sqlConnection.Close() ;
            }
            return true;
        }

        public bool updateNhanVien(NhanVien nhanVien)
        {
            string sql = "UPDATE dbo.NhanVien SET MaNV = @MaNV, TenNV = @TenNV, ChucVu = @ChucVu, MaDV = @MaDV WHERE MaNV = @MaNV";
            SqlConnection sqlConnection = dataConn.getConnection();

            try
            {
                sqlConnection.Open();
                sqlCmd = new SqlCommand(sql, sqlConnection);
                sqlCmd.Parameters.Add("@MaNV", SqlDbType.Char).Value = nhanVien.MaNV;
                sqlCmd.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = nhanVien.TenNV;
                sqlCmd.Parameters.Add("@ChucVu", SqlDbType.NVarChar).Value = nhanVien.ChucVu;
                sqlCmd.Parameters.Add("@MaDV", SqlDbType.Char).Value = nhanVien.MaDV;

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

        public bool deleteNhanVien(NhanVien nhanVien)
        {
            string sql = "DELETE dbo.NhanVien WHERE MaNV = @MaNV";
            SqlConnection sqlConnection = dataConn.getConnection();

            try
            {
                sqlConnection.Open();
                sqlCmd = new SqlCommand(sql, sqlConnection);
                sqlCmd.Parameters.Add("@MaNV", SqlDbType.Char).Value = nhanVien.MaNV;
                sqlCmd.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = nhanVien.TenNV;
                sqlCmd.Parameters.Add("@ChucVu", SqlDbType.NVarChar).Value = nhanVien.ChucVu;
                sqlCmd.Parameters.Add("@MaDV", SqlDbType.Char).Value = nhanVien.MaDV;

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
