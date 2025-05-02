using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Numerics;
using Microsoft.Reporting.WinForms;


namespace QuanLySinhVien
{
    public partial class SinhVienActionFrm : Form
    {
        public string hoTenNguoiDangNhap = "";
        public long MaSo;

        public SinhVienActionFrm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void SinhVienActionFrm_Load(object sender, EventArgs e)
        {


            string tenDangNhap = hoTenNguoiDangNhap;
            bool isFound = false;

            //Debug.WriteLine("Chào mọi người");
            lblLoiChao.Text = "Chào mừng đến với phần mềm quản lý sinh viên! " + tenDangNhap;
            txtHoTenSV.Text = tenDangNhap;
            txtTenSV.Text = tenDangNhap;
            DataProvider.GetAllInfoStudent(MaSo);
            if (DataProvider.infoStudentLogin.Count > 0)
            {
                foreach (var student in DataProvider.infoStudentLogin)
                {
                    txtGioiTinh.Text = student.GioiTinh == 1 ? "Nam" : "Nữ";
                    string birthDay = student.NgaySinh;
                    DateTime birthDayFormat = DateTime.Parse(birthDay);
                    string formatDateTime = birthDayFormat.ToString("dd/MM/yyyy");
                    txtNgaySinh.Text = formatDateTime;
                    txtDiaChi.Text = student.DiaChi;
                    txtDienThoai.Text = student.SoDienThoai;
                    txtMaKhoa.Text = student.MaKhoa;
                    txtTenKhoa.Text = student.TenKhoa;
                    txtMaSoSV.Text = student.MaSo.ToString();
                    txtMaLop.Text = student.MaLop.ToString();
                    txtTenLop.Text = student.TenLop.ToString();
                }
            }
            else
            {
                Debug.WriteLine("Không có sinh viên nào trong danh sách!");
            }
        }

        private void lblLoiChao_Click(object sender, EventArgs e)
        {

        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnXemDiemSV_Click(object sender, EventArgs e)
        {
            ReportFrm f = new ReportFrm("Xem điểm bên sinh viên", MaSo);
            f.ShowDialog();
        }

        private void btnXemMonHocSV_Click(object sender, EventArgs e)
        {
            ReportFrm f = new ReportFrm("Xem môn học bên sinh viên", MaSo);
            f.ShowDialog();
        }

        private void btnXemGiangVienSV_Click(object sender, EventArgs e)
        {
            ReportFrm f = new ReportFrm("Xem giảng viên bên sinh viên", MaSo);
            f.ShowDialog();
        }

        private void btnDangKyMonHocSV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang phát triển!");
        }

        private void btnXemThoiKhoaBieuSV_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Chức năng đang phát triển!");
            ThoiKhoaBieuSVFrm f = new ThoiKhoaBieuSVFrm();
            f.maSo = MaSo;
            f.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhapFrm f = new DangNhapFrm();
            f.ShowDialog();
        }
    }
}
