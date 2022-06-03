


namespace QuanLyKhachSan.Models
{
    public class Phong
    {
        private string _MaPhong;
        private int _SoPhong;
        private string _LoaiPhong;
        private int _SoNguoi;

        public Phong() { }

        public Phong(string maPhong, int soPhong, string loaiPhong, int soNguoi)
        {
            _MaPhong = maPhong;
            _SoPhong = soPhong;
            _LoaiPhong = loaiPhong;
            _SoNguoi = soNguoi;
        }

        public string MaPhong { get => _MaPhong; set => _MaPhong = value; }
        public int SoPhong { get => _SoPhong; set => _SoPhong = value;}
        public string LoaiPhong { get => _LoaiPhong; set => _LoaiPhong = value;}
        public int SoNguoi { get => _SoNguoi; set => _SoNguoi = value;}

    }
}
