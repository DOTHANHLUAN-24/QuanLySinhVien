using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class ThemMoiGiangVienFrm : Form
    {
        public ThemMoiGiangVienFrm()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnThemMoiGiangVien_Click(object sender, EventArgs e)
        {
            string hoTen = txtHoTenGiangVien.Text;
            string ngaySinh = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
            string thoiGianVao = dtpThoiGianVao.Value.ToString("yyyy-MM-dd");
            string chucVu = comboChucVu.Text;
            string capBac = comboCapBac.Text;
            string moTa = txtMoTa.Text;
            string monHocGiangDay = txtMonHocGiangDay.Text;
            //Debug.WriteLine($"{hoTen} - {ngaySinh} - {thoiGianVao} - {chucVu}");

            string query =
                "  insert into GiangVien(HoTenGiangVien, NgaySinh, CapBac, ThoiGianVao, MoTa, ChucVu, MonHocGiangDay) " +
                $"values (N'{hoTen}', '{ngaySinh}', N'{capBac}', '{thoiGianVao}', N'{moTa}', N'{chucVu}', N'{monHocGiangDay}')";
            //Debug.WriteLine("{0} - {1}", thoiGianVao, ngaySinh);
            //Debug.WriteLine("{0} - {1}", dtpNgaySinh.Value, dtpThoiGianVao.Value);
            int result = DataProvider.ThaoTacCSDL(query);
            if (result > 0)
            {
                MessageBox.Show("Thêm mới thành công!");
                this.Hide();
                AdminActionFrm f = new AdminActionFrm();
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại mời nhập lại dữ liệu");
            }


        }

        private void ThemMoiGiangVienFrm_Load(object sender, EventArgs e)
        {
            // Thêm dữ liệu vào combobox Chức vụ
            comboChucVu.Items.Add("Cán bộ giảng dạy");
            comboChucVu.Items.Add("Trợ giảng");
            comboChucVu.Items.Add("Trưởng bộ môn");
            comboChucVu.Items.Add("Phó bộ môn");
            comboChucVu.Items.Add("Trưởng khoa");
            comboChucVu.Items.Add("Phó khoa");
            comboChucVu.Items.Add("Hiệu trưởng");
            comboChucVu.Items.Add("Phó hiệu trưởng");

            // Thêm combobox Cấp bậc
            comboCapBac.Items.Add("Giáo Sư Tiến Sĩ");
            comboCapBac.Items.Add("Phó Giáo Sư Tiến Sĩ");
            comboCapBac.Items.Add("Tiến sĩ");
            comboCapBac.Items.Add("Thạc sĩ");
            comboCapBac.Items.Add("Cử nhân");
        }
    }
}
