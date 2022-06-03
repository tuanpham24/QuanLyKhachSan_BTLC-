
using QuanLyKhachSan.Connections;
using QuanLyKhachSan.Forms;
using System.Data.SqlClient;


namespace QuanLyKhachSan
{
    public partial class frmLogin : Form
    {
        Connection dataConn;
        public frmLogin()
        {
            InitializeComponent();
            txtPwd.PasswordChar = '*';
            dataConn = new Connection();
        }

        private void checkShowPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShowPwd.Checked)
            {
                txtPwd.PasswordChar = (char)0;
            }
            else
            {
                txtPwd.PasswordChar = '*';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = dataConn.getConnection();
            try
            {
                sqlConnection.Open();
                string userName = txtUN.Text;
                string pwd = txtPwd.Text;
                string sql = "SELECT * FROM UserAccount WHERE Username = '" + userName + "' AND Password =  '" + pwd + "' ";
                SqlCommand sqlCmd = new SqlCommand(sql, sqlConnection);
                SqlDataReader dataReader = sqlCmd.ExecuteReader();
                if (dataReader.Read())
                {
                    MessageBox.Show("Đăng nhập thành công! Bấm OK để tiếp tục.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMain frmMain = new frmMain();
                    frmMain.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu chưa đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Err: " + ex.Message, "Err", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }

        }
    }
}
