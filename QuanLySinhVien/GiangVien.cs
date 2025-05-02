using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    public class GiangVien
    {
        public string HoTen { get; set; }
        public string CapBac {get; set;}
        public int MaSo { get; set; }
        public string NgaySinh { get; set; }

        public int GioiTinh { get; set; }
        public string ThoiGianVao {get; set; }
        public string MoTa { get; set; }
        public string ChucVu { get; set; }
        public string MonHocGiangDay { get; set; }

        public GiangVien() { }

        public GiangVien(string capBac, string hoTen, int maSo, string ngaySinh, int gioiTinh, string thoiGianVao, string moTa, string chucVu, string monHocGiangDay)
        {
            HoTen = hoTen;
            CapBac = capBac;
            MaSo = maSo;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            ThoiGianVao = thoiGianVao;
            MoTa = moTa;
            ChucVu = chucVu;
            MonHocGiangDay = monHocGiangDay;
        }
    }
}
