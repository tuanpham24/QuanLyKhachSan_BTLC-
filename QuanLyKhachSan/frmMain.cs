
using QuanLyKhachSan.Forms;


namespace QuanLyKhachSan
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void KhachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang frmKH = new frmKhachHang();
            frmKH.Show();
        }

        private void PhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhong frmP = new frmPhong();
            frmP.Show();
        }

        private void HoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoaDon frmHD = new frmHoaDon();
            frmHD.Show();
        }

        private void DichVuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDichVu frmDV = new frmDichVu();
            frmDV.Show();
        }

        private void NhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanVien frmNV = new frmNhanVien();
            frmNV.Show();
        }




    }
}