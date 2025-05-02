using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    public class MonHoc
    {
        public string maMH { get; set; }
        public string tenMH { get; set; }
        public int soTinChi { get; set; }
        public int soTiet { get; set; }
        public string hoTenGiangVien { get; set; }
        public string thoiGianHoc { get; set; }

        public MonHoc() { }
        public MonHoc(string maMH, string tenMH, int soTinChi, int soTiet, string hoTenGiangVien, string thoiGianHoc)
        {
            this.maMH = maMH;
            this.tenMH = tenMH;
            this.soTinChi = soTinChi;
            this.soTiet = soTiet;
            this.hoTenGiangVien = hoTenGiangVien;
            this.thoiGianHoc = thoiGianHoc;
        }
    }
}
