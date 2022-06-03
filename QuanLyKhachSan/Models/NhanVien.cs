


namespace QuanLyKhachSan.Models
{
    public class NhanVien
    {
        private string _MaNV;
        private string _TenNV;
        private string _ChucVu;
        private string _MaDV;

        public NhanVien() { }
        public NhanVien(string maNV, string tenNV, string chucVu, string maDV)
        {
            _MaNV = maNV;
            _TenNV = tenNV;
            _ChucVu = chucVu;
            _MaDV = maDV;
        }


        public string MaNV { get => _MaNV; set => _MaNV = value; }
        public string TenNV { get => _TenNV; set => _TenNV = value;}
        public string ChucVu { get => _ChucVu; set => _ChucVu = value;}
        public string MaDV { get => _MaDV; set => _MaDV = value;}
    }
}
