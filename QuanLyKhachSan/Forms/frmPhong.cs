

using QuanLyKhachSan.Connections;
using QuanLyKhachSan.Models;
using System.Data;

namespace QuanLyKhachSan.Forms
{
    public partial class frmPhong : Form
    {
        PhongDAL phongDal;
        public frmPhong()
        {
            InitializeComponent();
            phongDal = new PhongDAL();
        }

        public void showAllPhong()
        {
            DataTable dataTable = phongDal.getAllPhong();
            dataGridViewPhong.DataSource = dataTable;
        }
        private void frmPhong_Load(object sender, EventArgs e)
        {
            showAllPhong();
        }

        private void dataGridViewPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMaPhong.Text = dataGridViewPhong.Rows[index].Cells["MaPhong"].Value.ToString();
                txtSoPhong.Text = dataGridViewPhong.Rows[index].Cells["SoPhong"].Value.ToString();
                txtLoaiPhong.Text = dataGridViewPhong.Rows[index].Cells["LoaiPhong"].Value.ToString();
                txtSoNguoi.Text = dataGridViewPhong.Rows[index].Cells["SoNguoi"].Value.ToString();
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            Phong phong = new Phong();
            phong.MaPhong = txtMaPhong.Text;
            phong.SoPhong = Int32.Parse(txtSoPhong.Text);
            phong.LoaiPhong = txtLoaiPhong.Text;
            phong.SoNguoi = Int32.Parse(txtSoNguoi.Text);

            if (phongDal.insertPhong(phong))
            {
                showAllPhong();
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra! Hãy xem lại các dữ liệu nhập vào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Phong phong = new Phong();
            phong.MaPhong = txtMaPhong.Text;
            phong.SoPhong = Int32.Parse(txtSoPhong.Text);
            phong.LoaiPhong = txtLoaiPhong.Text;
            phong.SoNguoi = Int32.Parse(txtSoNguoi.Text);

            if (phongDal.updatePhong(phong))
            {
                showAllPhong();
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra! Hãy xem lại các dữ liệu nhập vào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa phòng này?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Phong phong = new Phong();
                phong.MaPhong = txtMaPhong.Text;

                if (phongDal.deletePhong(phong))
                {
                    showAllPhong();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra! Hãy xem lại các dữ liệu nhập vào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }

        }
    }
}
