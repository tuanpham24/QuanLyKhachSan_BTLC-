
using QuanLyKhachSan.Connections;
using QuanLyKhachSan.Models;
using System.Data;  


namespace QuanLyKhachSan.Forms
{
    public partial class frmHoaDon : Form
    {
        HoaDonDAL hoadondal;
        public frmHoaDon()
        {
            InitializeComponent();
            hoadondal = new HoaDonDAL();
        }

        public void showAllHoaDon()
        {
            DataTable dataTable = hoadondal.getAllHoaDon();
            dataGridViewHoaDon.DataSource = dataTable;
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            showAllHoaDon();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HoaDon hoaDon = new HoaDon();
            hoaDon.MaHD = txtMaHD.Text;
            hoaDon.MaPhong = txtMaPhong.Text;
            hoaDon.TongTien = float.Parse(txtTongTien.Text);
            if (radioButtonChuaTT.Checked)
            {
                hoaDon.TrangThaiTT = radioButtonChuaTT.Text;
            }
            if (radioButtonDaTT.Checked)
            {
                hoaDon.TrangThaiTT = radioButtonDaTT.Text;
            }

            hoaDon.NgayXuat = DateTime.Parse(dateTimePickerNgayXuat.Text);

            if (hoadondal.insertHoaDon(hoaDon))
            {
                showAllHoaDon();
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra! Hãy xem lại các dữ liệu nhập vào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HoaDon hoaDon = new HoaDon();
            hoaDon.MaHD = txtMaHD.Text;
            hoaDon.MaPhong = txtMaPhong.Text;
            hoaDon.TongTien = float.Parse(txtTongTien.Text);
            if (radioButtonChuaTT.Checked)
            {
                hoaDon.TrangThaiTT = radioButtonChuaTT.Text;
            }
            if (radioButtonDaTT.Checked)
            {
                hoaDon.TrangThaiTT = radioButtonDaTT.Text;
            }

            hoaDon.NgayXuat = DateTime.Parse(dateTimePickerNgayXuat.Text);

            if (hoadondal.updateHoaDon(hoaDon))
            {
                showAllHoaDon();
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra! Hãy xem lại các dữ liệu nhập vào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                HoaDon hoaDon = new HoaDon();
                hoaDon.MaHD = txtMaHD.Text;
                if (hoadondal.deleteHoaDon(hoaDon))
                {
                    showAllHoaDon();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra! Hãy xem lại các dữ liệu nhập vào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }  
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string maPhongSear = txtSearch.Text;
            DataTable datatable = hoadondal.searchHD(maPhongSear);
            dataGridViewHoaDon.DataSource = datatable;
        }

        private void dataGridViewHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                txtMaHD.Text = dataGridViewHoaDon.Rows[index].Cells["MaHD"].Value.ToString();
                txtMaPhong.Text = dataGridViewHoaDon.Rows[index].Cells["MaPhong"].Value.ToString();
                txtTongTien.Text = dataGridViewHoaDon.Rows[index].Cells["TongTien"].Value.ToString();
                dateTimePickerNgayXuat.Text = dataGridViewHoaDon.Rows[index].Cells["NgayXuat"].Value.ToString();
                //txtMaHD.Text = dataGridViewHoaDon.Rows[index].Cells["Tinh"].Value.ToString();
            }
        }

        
    }
}
