
using System.Data;
using System.Data;
using QuanLyKhachSan.Connections;
using System.Data.SqlClient;
using QuanLyKhachSan.Models;


namespace QuanLyKhachSan.Connections
{
    public class HoaDonDAL
    {
        Connection dataConn;
        SqlDataAdapter dataAdapter;
        SqlCommand sqlCmd;

        public HoaDonDAL()
        {
            dataConn = new Connection();
        }

        public DataTable getAllHoaDon()
        {
            string sql = "SELECT * FROM dbo.HoaDon";
            DataTable dataTable = new DataTable();
            using(SqlConnection sqlConnection = dataConn.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(sql, sqlConnection);
                dataAdapter.Fill(dataTable);            
                sqlConnection.Close();
            }
            return dataTable;
        }

        public bool insertHoaDon(HoaDon hoaDon)
        {
            string sql = "INSERT INTO dbo.HoaDon VALUES(@MaHD, @MaPhong, @NgayXuat, @TongTien, @TinhTrang)";
            SqlConnection sqlConnection = dataConn.getConnection();

            try
            {
                sqlConnection.Open();
                sqlCmd = new SqlCommand(sql, sqlConnection);
                sqlCmd.Parameters.Add("@MaHD", SqlDbType.Char).Value = hoaDon.MaHD;
                sqlCmd.Parameters.Add("@MaPhong", SqlDbType.Char).Value = hoaDon.MaPhong;
                sqlCmd.Parameters.Add("@NgayXuat", SqlDbType.Date).Value = hoaDon.NgayXuat;
                sqlCmd.Parameters.Add("@TongTien", SqlDbType.Float).Value = hoaDon.TongTien;
                sqlCmd.Parameters.Add("@TinhTrang", SqlDbType.NVarChar).Value = hoaDon.TrangThaiTT;
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

        public bool updateHoaDon(HoaDon hoaDon)
        {
            string sql = "UPDATE dbo.HoaDon SET MaHD = @MaHD, MaPhong = @MaPhong, NgayXuat = @NgayXuat, TongTien = @TongTien, TinhTrang = @TinhTrang WHERE MaHD = @MaHD";
            SqlConnection sqlConnection = dataConn.getConnection();

            try
            {
                sqlConnection.Open();
                sqlCmd = new SqlCommand(sql, sqlConnection);
                sqlCmd.Parameters.Add("@MaHD", SqlDbType.Char).Value = hoaDon.MaHD;
                sqlCmd.Parameters.Add("@MaPhong", SqlDbType.Char).Value = hoaDon.MaPhong;
                sqlCmd.Parameters.Add("@NgayXuat", SqlDbType.Date).Value = hoaDon.NgayXuat;
                sqlCmd.Parameters.Add("@TongTien", SqlDbType.Float).Value = hoaDon.TongTien;
                sqlCmd.Parameters.Add("@TinhTrang", SqlDbType.Char).Value = hoaDon.TrangThaiTT;
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


        public DataTable searchHD(string maPhong)
        {
            string sql = "select p.*, hd.* from Phong as p " +
                "inner join HoaDon as hd on p.MaPhong = hd.MaPhong and p.MaPhong = '" + maPhong + "' ";
            DataTable datatable = new DataTable();
            using (SqlConnection sqlConnection = dataConn.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(sql, sqlConnection);
                dataAdapter.Fill(datatable);
                sqlConnection.Close();
            }
            return datatable;
        }

        public bool deleteHoaDon(HoaDon hoaDon)
        {
            string sql = "DELETE dbo.HoaDon WHERE MaHD = @MaHD";
            SqlConnection sqlConnection = dataConn.getConnection();

            try
            {
                sqlConnection.Open();
                sqlCmd = new SqlCommand(sql, sqlConnection);
                sqlCmd.Parameters.Add("@MaHD", SqlDbType.Char).Value = hoaDon.MaHD;
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
