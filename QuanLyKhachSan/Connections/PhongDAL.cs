
using System.Data;
using System.Data.SqlClient;
using QuanLyKhachSan.Models;



namespace QuanLyKhachSan.Connections
{
    public class PhongDAL { 


        Connection dataConn;
        SqlDataAdapter dataAdapter;
        SqlCommand sqlCmd;
         
        public PhongDAL()
        {
            dataConn = new Connection();
        }

        // Get all data
        public DataTable getAllPhong()
        {
            DataTable dataTable = new DataTable();

            string sql = "SELECT * FROM dbo.Phong";
            using(SqlConnection sqlConnection = dataConn.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(sql, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }

            return dataTable;
        }


        public bool insertPhong(Phong phong)
        {
            SqlConnection sqlConnection = dataConn.getConnection();
            string sql = "INSERT INTO dbo.Phong VALUES(@MaPhong, @SoPhong, @LoaiPhong, @SoNguoi)";
            try
            {
                sqlConnection.Open();
                sqlCmd = new SqlCommand(sql, sqlConnection);
                sqlCmd.Parameters.Add("@MaPhong", SqlDbType.Char).Value = phong.MaPhong;
                sqlCmd.Parameters.Add("@SoPhong", SqlDbType.Int).Value = phong.SoPhong;
                sqlCmd.Parameters.Add("@LoaiPhong", SqlDbType.Char).Value = phong.LoaiPhong;
                sqlCmd.Parameters.Add("@SoNguoi", SqlDbType.Int).Value = phong.SoNguoi;
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

        public bool updatePhong(Phong phong)
        {
            SqlConnection sqlConnection = dataConn.getConnection();
            string sql = "UPDATE dbo.Phong SET MaPhong = @MaPhong, SoPhong = @SoPhong, LoaiPhong = @LoaiPhong, SoNguoi = @SoNguoi WHERE MaPhong = @MaPhong";
            try
            {
                sqlCmd = new SqlCommand(sql, sqlConnection);
                sqlConnection.Open();
                sqlCmd.Parameters.Add("@MaPhong", SqlDbType.Char).Value = phong.MaPhong;
                sqlCmd.Parameters.Add("@SoPhong", SqlDbType.Int).Value = phong.SoPhong;
                sqlCmd.Parameters.Add("@LoaiPhong", SqlDbType.Char).Value = phong.LoaiPhong;
                sqlCmd.Parameters.Add("@SoNguoi", SqlDbType.Int).Value = phong.SoNguoi;
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

        public bool deletePhong(Phong phong)
        {
            string sql = "DELETE dbo.Phong WHERE MaPhong = @MaPhong";
            SqlConnection sqlConnection = dataConn.getConnection();
            try
            {
                sqlConnection.Open();
                sqlCmd = new SqlCommand(sql, sqlConnection);
                sqlCmd.Parameters.Add("@MaPhong", SqlDbType.Char).Value = phong.MaPhong;
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
