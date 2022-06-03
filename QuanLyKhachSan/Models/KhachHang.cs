



namespace QuanLyKhachSan.Models
{
    public class KhachHang
    {
        private string _MaKH;
        private string _TenKH;
        private string _GioiTinh;
        private int _Tuoi;
        private string _Sdt;
        private string _DiaChi;
        private string _MaPhong;

        public KhachHang() { }

        public KhachHang(string maKH, string tenKH, string gioiTinh, int tuoi, string sdt, string diaChi, string maPhong)
        {
            _MaKH = maKH;
            _TenKH = tenKH;
            _GioiTinh = gioiTinh;
            _Tuoi = tuoi;
            _Sdt = sdt;
            _DiaChi = diaChi;
            _MaPhong = maPhong;
        }

        public string MaKH { get => _MaKH; set => _MaKH = value; }
        public string TenKH { get => _TenKH; set => _TenKH = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public int Tuoi { get => _Tuoi; set => _Tuoi = value; }
        public string Sdt { get => _Sdt; set => _Sdt = value; }
        public string DiaChi { get => _DiaChi; set => _DiaChi = value; }
        public string MaPhong { get => _MaPhong; set => _MaPhong = value; }
    }
}
