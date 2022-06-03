
using QuanLyKhachSan.Connections;
using QuanLyKhachSan.Models;
using System.Data;

namespace QuanLyKhachSan.Forms
{
    public partial class frmDichVu : Form
    {
        DichVuDAL dichvudal;
        public frmDichVu()
        {
            InitializeComponent();
            dichvudal = new DichVuDAL();
        }
        
        public void showAllDichVu()
        {
            DataTable dataTable = dichvudal.getAllDichVu();
            dataGridViewDichVu.DataSource = dataTable;
        }
        private void frmDichVu_Load(object sender, EventArgs e)
        {
            showAllDichVu();
        }

        private void dataGridViewDichVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMaDV.Text = dataGridViewDichVu.Rows[index].Cells["MaDV"].Value.ToString();
                txtTenDV.Text = dataGridViewDichVu.Rows[index].Cells["TenDV"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DichVu dichVu = new DichVu();
            dichVu.MaDV = txtMaDV.Text;
            dichVu.TenDV = txtTenDV.Text;

            if (dichvudal.insertDichVu(dichVu))
            {
                showAllDichVu();
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra! Hãy xem lại các dữ liệu nhập vào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DichVu dichVu = new DichVu();
            dichVu.MaDV = txtMaDV.Text;
            dichVu.TenDV = txtTenDV.Text;

            if (dichvudal.updateDichVu(dichVu))
            {
                showAllDichVu();
            }
            else
            {
                MessageBox.Show("Đã có lỗi xảy ra! Hãy xem lại các dữ liệu nhập vào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa dịch vụ này?", "Cảnh báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes){
                DichVu dichVu = new DichVu();
                dichVu.MaDV = txtMaDV.Text;
                dichVu.TenDV = txtTenDV.Text;

                if (dichvudal.deleteDichVu(dichVu))
                {
                    showAllDichVu();
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra! Hãy xem lại các dữ liệu nhập vào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            
        }


    }
}
