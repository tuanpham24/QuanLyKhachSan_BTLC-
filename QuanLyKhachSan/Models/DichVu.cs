


namespace QuanLyKhachSan.Models
{
    public class DichVu
    {
        private string _MaDV;
        private string _TenDV;

        public DichVu() { }

        public DichVu(string maDV, string tenDV)
        {
            _MaDV = maDV;
            _TenDV = tenDV;
        }

        public string MaDV { get => _MaDV; set => _MaDV = value; }
        public string TenDV { get => _TenDV; set => _TenDV = value;}
    }
}
