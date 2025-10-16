using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
		
namespace QuanLySinhVien
{
    public class DangNhap
    {
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string HoTen { get; set; }
        public string Quyen { get; set; }
        public long MaSo { get; set; }

        public DangNhap()
        {
        }
        public DangNhap(string taiKhoan, string matKhau, string hoTen, string quyen, long maSo)
        {
            TaiKhoan = taiKhoan;
            MatKhau = matKhau;
            HoTen = hoTen;
            Quyen = quyen;
            MaSo = maSo;
        }   
    }
}
