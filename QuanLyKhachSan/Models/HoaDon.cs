

namespace QuanLyKhachSan.Models
{
    public class HoaDon
    {
        private string _MaHD;
        private string _MaPhong;
        private DateTime _NgayXuat;
        private float _TongTien;
        private string _TrangThaiTT;

        public HoaDon() { }

        public HoaDon(string maHD, string maPhong, DateTime ngayXuat, float tongTien, string trangThaiTT)
        {
            _MaHD = maHD;
            _MaPhong = maPhong;
            _NgayXuat = ngayXuat;
            _TongTien = tongTien;
            _TrangThaiTT = trangThaiTT;
        }

        public string MaHD { get => _MaHD; set => _MaHD = value; }
        public string MaPhong { get => _MaPhong; set => _MaPhong = value;}
        public DateTime NgayXuat { get => _NgayXuat; set => _NgayXuat = value; }
        public float TongTien { get => _TongTien; set => _TongTien = value; }
        public string TrangThaiTT { get => _TrangThaiTT; set => _TrangThaiTT = value;}

    }
}
