using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    public class KetQua
    {
        public long MaSoSV { get; set; }

        public string HoTenSV { get; set; }
        public string TenMonHoc { get; set; }
        public string MaMonHoc { get; set; }
        public string MaLop { get; set; }
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }
        public string DiemA { get; set; }
        public string DiemB { get; set; }
        public string DiemC { get; set; }

        public string DiemTB { get; set; }
        public int SoTinChi { get; set; }


        public KetQua() { }

        public KetQua(long maSoSV, string hoTenSV, string tenMonHoc, string maMonHoc, string maLop, string maKhoa, string tenKhoa, string diemA, string diemB, string diemC, string diemTB, int soTinChi)
        {
            MaSoSV = maSoSV;
            HoTenSV = hoTenSV;
            TenMonHoc = tenMonHoc;
            MaMonHoc = maMonHoc;
            MaLop = maLop;
            MaKhoa = maKhoa;
            TenKhoa = tenKhoa;
            DiemA = diemA;
            DiemB = diemB;
            DiemC = diemC;
            DiemTB = diemTB;
            SoTinChi = soTinChi;
        }
    }
}
