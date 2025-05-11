using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;

namespace QuanLySinhVien
{
    public partial class GiangVienAction : Form
    {
        public string hoTenNguoiDangNhap = "";
        public long maSoGiangVien = -1;

        public GiangVienAction()
        {
            InitializeComponent();
        }

        private void GiangVienAction_Load(object sender, EventArgs e)
        {
            //Debug.WriteLine("{0} - {1}", maSoGiangVien, hoTenNguoiDangNhap);
            txtHoTen.Text = hoTenNguoiDangNhap;
            DataProvider.GetAllInfoTeacher(maSoGiangVien);
            if (DataProvider.infoGiangVienLogin.Count > 0)
            {
                foreach (var giangVien in DataProvider.infoGiangVienLogin)
                {
                    txtGioiTinh.Text = giangVien.GioiTinh == 1 ? "Nam" : "Nữ";
                    string birthDay = giangVien.NgaySinh;
                    DateTime birthDayFormat = DateTime.Parse(birthDay);
                    string formatDateTime = birthDayFormat.ToString("dd/MM/yyyy");
                    txtNgaySinh.Text = formatDateTime;
                    txtHoTen.Text = giangVien.HoTen;
                    txtMaSoGiangVien.Text = giangVien.MaSo.ToString();
                    txtCapBac.Text = giangVien.CapBac;
                    string thoiGianVao = giangVien.ThoiGianVao;
                    DateTime thoiGianVaoFormat = DateTime.Parse(thoiGianVao);
                    formatDateTime = thoiGianVaoFormat.ToString("dd/MM/yyyy");
                    txtThoiGianVao.Text = formatDateTime;
                    txtMoTa.Text = giangVien.MoTa;
                    txtChucVu.Text = giangVien.ChucVu;
                    txtMonHocGiangDay.Text = giangVien.MonHocGiangDay;
                }
            }
            else
            {
                Debug.WriteLine("Không có giảng viên nào trong danh sách!");
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhapFrm f = new DangNhapFrm();
            f.ShowDialog();
        }

        private void btnXemDiemTheoGV_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportFrm f = new ReportFrm("Xem điểm bên giảng viên", hoTenNguoiDangNhap);
            f.ShowDialog();
        }
    }
}
