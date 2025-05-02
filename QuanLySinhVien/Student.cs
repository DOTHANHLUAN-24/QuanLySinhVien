using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    public class Student
    {
        public long MaSo { get; set; }
        public string HoTen { get; set; }
        public string NgaySinh { get; set; }
        public int GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }
        public string TenLop { get; set; }
        public string MaLop { get; set; }


        public Student() { }

        public Student(long _maSo, string _hoTen, string _ngaySinh, int _gioiTinh, string _diaChi, string _soDienThoai, string _maKhoa, string _tenKhoa, string tenLop, string maLop)
        {
            MaSo = _maSo;
            HoTen = _hoTen;
            NgaySinh = _ngaySinh;
            GioiTinh = _gioiTinh;
            DiaChi = _diaChi;
            SoDienThoai = _soDienThoai;
            MaKhoa = _maKhoa;
            TenKhoa = _tenKhoa;
            TenLop = tenLop;
            MaLop = maLop;
        }




    }
}
