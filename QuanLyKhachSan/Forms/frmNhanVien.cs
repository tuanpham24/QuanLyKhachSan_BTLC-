
using QuanLyKhachSan.Connections;
using QuanLyKhachSan.Models;
using System.Data;

namespace QuanLyKhachSan.Forms
{
    public partial class frmNhanVien : Form
    {
        NhanVienDAL nhanviendal;
        public frmNhanVien()
        {
            InitializeComponent();
            nhanviendal = new NhanVienDAL();
        }

        public void showAllNhanVien()
        {
            DataTable dataTable = nhanviendal.getAllNhanVien();
            dataGridViewNhanVien.DataSource = dataTable;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            showAllNhanVien();
        }

        private void dataGridViewNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMaNV.Text = dataGridViewNhanVien.Rows[index].Cells["MaNV"].Value.ToString();
                txtTenNV.Text = dataGridViewNhanVien.Rows[index].Cells["TenNV"].Value.ToString();
                txtChucVu.Text = dataGridViewNhanVien.Rows[index].Cells["ChucVU"].Value.ToString();
                txtMaDV.Text = dataGridViewNhanVien.Rows[index].Cells["MaDV"].Value.ToString();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.MaNV = txtMaNV.Text;
            nhanVien.TenNV = txtTenNV.Text;
            nhanVien.ChucVu = txtChucVu.Text;
            nhanVien.MaDV = txtMaDV.Text;

            if (nhanviendal.insertNhanVien(nhanVien))
            {
                showAllNhanVien();
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra! Hãy xem lại các dữ liệu nhập vào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien();
            nhanVien.MaNV = txtMaNV.Text;
            nhanVien.TenNV = txtTenNV.Text;
            nhanVien.ChucVu = txtChucVu.Text;
            nhanVien.MaDV = txtMaDV.Text;

            if (nhanviendal.updateNhanVien(nhanVien))
            {
                showAllNhanVien();
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra! Hãy xem lại các dữ liệu nhập vào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                NhanVien nhanVien = new NhanVien();
                nhanVien.MaNV = txtMaNV.Text;
                nhanVien.TenNV = txtTenNV.Text;
                nhanVien.ChucVu = txtChucVu.Text;
                nhanVien.MaDV = txtMaDV.Text;

                if (nhanviendal.deleteNhanVien(nhanVien))
                {
                    showAllNhanVien();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra! Hãy xem lại các dữ liệu nhập vào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            } 
        }
    }
}
