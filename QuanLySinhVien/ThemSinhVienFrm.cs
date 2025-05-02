using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.AnimatorNS;

namespace QuanLySinhVien
{
    public partial class ThemSinhVienFrm : Form
    {
        public ThemSinhVienFrm()
        {
            InitializeComponent();
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Controller_AdminFrm f = new Controller_AdminFrm();
            this.Hide();
            f.ShowDialog();
        }

        private void btnLuuTT_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTen.Text;
            string diaChi = txtDiaChi.Text;
            string sdt = txtDienThoai.Text;
            string maLop = comboMaLop.SelectedValue.ToString();
            string maKhoa = comboMaKhoa.SelectedValue.ToString();
            string gioiTinh = comboGioiTinh.SelectedItem.ToString();
            string ngaySinh = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
            int _gioiTinh;
            if (gioiTinh == "Nam")
            {
                _gioiTinh = 1;
            }
            else
            {
                _gioiTinh = 0;
            }
            string query = $"insert into SinhVien (HoTen, DiaChi, DienThoai, MaLop, MaKhoa, GioiTinh, NgaySinh) values (N'{hoTen}', N'{diaChi}', '{sdt}', '{maLop}', '{maKhoa}', '{_gioiTinh}', {ngaySinh})";
            int result = DataProvider.ThaoTacCSDL(query);
            if (result > 0)
            {
                MessageBox.Show("Thêm sinh viên thành công");
                txtHoTen.Clear();
                txtDiaChi.Clear();
                txtDienThoai.Clear();
                comboMaLop.SelectedIndex = 1;
                comboMaKhoa.SelectedIndex = 1;
                comboGioiTinh.SelectedIndex = 1;
            }
            else
            {
                MessageBox.Show("Thêm sinh viên thất bại");
            }
        }

        private void ThemSinhVien_Load(object sender, EventArgs e)
        {
            comboGioiTinh.Items.Add("Nam");
            comboGioiTinh.Items.Add("Nữ");
            string query1 = "select MaKhoa, TenKhoa from Khoa";
            comboMaKhoa.DataSource = DataProvider.LoadCSDL(query1);
            comboMaKhoa.ValueMember = "MaKhoa";
            comboMaKhoa.DisplayMember = "TenKhoa";
        }

        private void comboMaKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboMaKhoa.SelectedValue.ToString();
            string query2 = $"select MaLop, TenLop from LopHoc where MaKhoa = '{selectedValue}'";
            comboMaLop.DataSource = DataProvider.LoadCSDL(query2);
            comboMaLop.ValueMember = "MaLop";   
            comboMaLop.DisplayMember = "TenLop";
        }
    }
}
