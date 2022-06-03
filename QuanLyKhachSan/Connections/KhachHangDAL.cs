
using QuanLyKhachSan.Models;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyKhachSan.Connections
{
    public class KhachHangDAL
    {
        Connection dataConn;
        SqlDataAdapter dataAdapter;
        SqlCommand sqlCmd;

        public KhachHangDAL()
        {
            dataConn = new Connection();
        }

        public DataTable getAllKhachHang()
        {
            DataTable dataTable = new DataTable();
            string sql = "SELECT * FROM dbo.KhachHang";
            using(SqlConnection sqlConnection = dataConn.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(sql, sqlConnection);

                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }


        public bool insertKhachHang(KhachHang khachHang)
        {
            string sql = "INSERT INTO dbo.KhachHang VALUES(@MaKH, @TenKH, @GioiTinh, @Tuoi, @Sdt, @DiaChi, @MaPhong)";
            SqlConnection sqlConnection = dataConn.getConnection();

            try
            {
                sqlCmd = new SqlCommand(sql, sqlConnection);

                sqlConnection.Open();
                sqlCmd.Parameters.Add("@MaKH", SqlDbType.Char).Value = khachHang.MaKH;
                sqlCmd.Parameters.Add("@TenKH", SqlDbType.NVarChar).Value = khachHang.TenKH;
                sqlCmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = khachHang.GioiTinh;
                sqlCmd.Parameters.Add("@Tuoi", SqlDbType.Int).Value = khachHang.Tuoi;
                sqlCmd.Parameters.Add("@Sdt", SqlDbType.Char).Value = khachHang.Sdt;
                sqlCmd.Parameters.Add("@DiaChi", SqlDbType.NVarChar).Value = khachHang.DiaChi;
                sqlCmd.Parameters.Add("@MaPhong", SqlDbType.Char).Value = khachHang.MaPhong;
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


        // Update data
        public bool updateKhachHang(KhachHang khachHang)
        {
            string sql = "UPDATE dbo.KhachHang SET MaKH = @MaKH, @TenKH = TenKH, GioiTinh = @GioiTinh , Tuoi = @Tuoi, Sdt = @Sdt, DiaChi = @DiaChi, MaPhong = @MaPhong WHERE MaKH = @MaKH";
            SqlConnection sqlConnection = dataConn.getConnection();

            try
            {
                sqlCmd = new SqlCommand(sql, sqlConnection);

                sqlConnection.Open();
                sqlCmd.Parameters.Add("@MaKH", SqlDbType.Char).Value = khachHang.MaKH;
                sqlCmd.Parameters.Add("@TenKH", SqlDbType.NVarChar).Value = khachHang.TenKH;
                sqlCmd.Parameters.Add("@GioiTinh", SqlDbType.NVarChar).Value = khachHang.GioiTinh;
                sqlCmd.Parameters.Add("@Tuoi", SqlDbType.Int).Value = khachHang.Tuoi;
                sqlCmd.Parameters.Add("@Sdt", SqlDbType.Char).Value = khachHang.Sdt;
                sqlCmd.Parameters.Add("@DiaCHi", SqlDbType.NVarChar).Value = khachHang.DiaChi;
                sqlCmd.Parameters.Add("@MaPhong", SqlDbType.Char).Value = khachHang.MaPhong;

                
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

        // Delete
        public bool deleteKhachHang(KhachHang khachHang)
        {
            string sql = "DELETE dbo.KhachHang WHERE MaKH = @MaKH AND TenKH = @TenKH";
            SqlConnection sqlConnection = dataConn.getConnection();

            try
            {
                sqlCmd = new SqlCommand(sql, sqlConnection);

                sqlConnection.Open();
                sqlCmd.Parameters.Add("@MaKH", SqlDbType.Char).Value = khachHang.MaKH;
                sqlCmd.Parameters.Add("@TenKH", SqlDbType.NVarChar).Value = khachHang.TenKH;

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
