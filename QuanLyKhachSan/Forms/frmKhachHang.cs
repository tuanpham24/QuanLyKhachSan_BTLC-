
using QuanLyKhachSan.Connections;
using System.Data;
using QuanLyKhachSan.Models;

namespace QuanLyKhachSan.Forms
{
    public partial class frmKhachHang : Form
    {
        KhachHangDAL khdal;
        public frmKhachHang()
        {
            InitializeComponent();
            khdal = new KhachHangDAL();
        }


        public void showAllKhachHang()
        {
            DataTable dataTable = khdal.getAllKhachHang();
            dataGridViewKhachHang.DataSource = dataTable;

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            showAllKhachHang();
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            KhachHang khachHang = new KhachHang();
            khachHang.MaKH = txtMaKH.Text;
            khachHang.TenKH = txtTenKH.Text;
            //khachHang.GioiTinh = txtGioiTinh.Text;

            
            if (radioButtonNam.Checked)
            {
                khachHang.GioiTinh = radioButtonNam.Text;
            }
            if (radioButtonNu.Checked)
            {
                khachHang.GioiTinh = radioButtonNu.Text;
            }
            if (radioButtonKhac.Checked)
            {
                khachHang.GioiTinh = radioButtonKhac.Text;
            }

            khachHang.Tuoi = Int32.Parse(txtTuoi.Text);
            khachHang.Sdt = txtSdt.Text;
            khachHang.DiaChi = txtDiaChi.Text;
            khachHang.MaPhong  = txtMaPhong.Text;

            if (khdal.insertKhachHang(khachHang))
            {
                showAllKhachHang();
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra! Hãy xem lại các dữ liệu nhập vào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }



        private void dataGridViewKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                txtMaKH.Text = dataGridViewKhachHang.Rows[index].Cells["MaKH"].Value.ToString();
                txtTenKH.Text = dataGridViewKhachHang.Rows[index].Cells["TenKH"].Value.ToString();
                //txtGioiTinh.Text = dataGridViewKhachHang.Rows[index].Cells["GioiTinh"].Value.ToString();
                txtTuoi.Text = dataGridViewKhachHang.Rows[index].Cells["Tuoi"].Value.ToString();
                txtSdt.Text = dataGridViewKhachHang.Rows[index].Cells["Sdt"].Value.ToString();
                txtDiaChi.Text = dataGridViewKhachHang.Rows[index].Cells["DiaChi"].Value.ToString();
                txtMaPhong.Text = dataGridViewKhachHang.Rows[index].Cells["MaPhong"].Value.ToString();
            }
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            KhachHang khachHang = new KhachHang();
            khachHang.MaKH = txtMaKH.Text;
            khachHang.TenKH = txtTenKH.Text;

            if (radioButtonNam.Checked)
            {
                khachHang.GioiTinh = radioButtonNam.Text;
            }
            if (radioButtonNu.Checked)
            {
                khachHang.GioiTinh = radioButtonNu.Text;
            }
            if (radioButtonKhac.Checked)
            {
                khachHang.GioiTinh = radioButtonKhac.Text;
            }

            khachHang.Tuoi = Int32.Parse(txtTuoi.Text);
            khachHang.Sdt = txtSdt.Text;
            khachHang.DiaChi = txtDiaChi.Text;
            khachHang.MaPhong = txtMaPhong.Text;

            if (khdal.updateKhachHang(khachHang))
            {
                showAllKhachHang();
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra! Hãy xem lại các dữ liệu nhập vào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                KhachHang khachHang = new KhachHang();
                khachHang.MaKH = txtMaKH.Text;
                khachHang.TenKH = txtTenKH.Text;

                if (khdal.deleteKhachHang(khachHang))
                {
                    showAllKhachHang();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra! Hãy xem lại các dữ liệu nhập vào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            } 
        }
    }
}
