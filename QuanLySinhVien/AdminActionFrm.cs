using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QuanLySinhVien
{
    public partial class AdminActionFrm : Form
    {
        DataTable dt = new DataTable();

        public AdminActionFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
        }


        private void btnHienThiTatCa_Click(object sender, EventArgs e)
        {
            LoadTableMonHoc();
        }

        private void LoadTableMonHoc()
        {
            //quey -> lấy data từ CSDL -> database -> datagridview
            string query = "Select * from MonHoc";
            //Xóa sạch dữ liệu trước
            dt.Clear();
            //Load dữ liệu mới vào trong datatable
            dt = DataProvider.LoadCSDL(query);
            //Điền vào trong datagridview
            dtgvMH.DataSource = dt;

            // Đổi tên cột hiển thị trong DataGridView
            dtgvMH.Columns["MaMH"].HeaderText = "Mã Môn Học";
            dtgvMH.Columns["TenMH"].HeaderText = "Tên Môn Học";
            dtgvMH.Columns["SoTinChi"].HeaderText = "Số Tín Chỉ";
            dtgvMH.Columns["SoTiet"].HeaderText = "Số Tiết";
            dtgvMH.Columns["HoTenGiangVien"].HeaderText = "Người Hướng Dẫn";
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        { 
            EnableControl(new List<Control> { txtMaMH, txtMH, txtSoTiet, txtSoTinChi, comboGiangVien, btnLuu });
            UnEnableControl(new List<Control> { btnXoa, btnSua });
            ResetText(new List<Control> { txtMaMH, txtMH, txtSoTiet, txtSoTinChi, comboGiangVien });
            txtMaMH.Focus();
        }

        private void EnableControl(List<Control> controls)
        {
            foreach (var control in controls)
            {
                control.Enabled = true;
            }
        }

        private void UnEnableControl(List<Control> controls)
        {
            foreach (var control in controls)
            {
                control.Enabled = false;
            }
        }

        private void ResetText(List<Control> controls)
        {
            foreach (var control in controls)
            {
                control.Text = string.Empty;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string MaMH = txtMaMH.Text;
            string TenMH = txtMH.Text;
            string soTinChi = txtSoTinChi.Text;
            string SoTiet = txtSoTiet.Text;
            string HoTenGiangVien = comboGiangVien.Text;
            string maNhom = DataProvider.makeId();

            string query = $"Insert into MonHoc(MaMH, TenMH, SoTinChi, SoTiet, HoTenGiangVien, Nhom) values('{MaMH}', N'{TenMH}', {soTinChi}, {SoTiet}, N'{HoTenGiangVien}', N'{maNhom}')";

            //Lưu vào CSDL
            int result = DataProvider.ThaoTacCSDL(query);
            if (result > 0)
            {
                MessageBox.Show("Thêm mới thành công");
                //Load lại dữ liệu
                LoadTableMonHoc();
                UnEnableControl(new List<Control> { txtMaMH, txtMH, txtSoTiet, txtSoTinChi, comboGiangVien, btnLuu });
                ResetText(new List<Control> { txtMaMH, txtMH, txtSoTiet, txtSoTinChi, comboGiangVien });
            }
            else
            {
                MessageBox.Show("Thêm mới thất bại");
            }
        }

        private void dtgvMH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvMH.SelectedRows.Count > 0)
            {
                //Lấy dòng đầu tiên khi nhấn vào
                var row = dtgvMH.SelectedRows[0];

                // Truyền giá trị lên các textBox ở trên
                // Tại vì .Value trả về kiểu object nên phải ép kiểu về string
                txtMaMH.Text = row.Cells["MaMH"].Value.ToString();
                txtMH.Text = row.Cells["TenMH"].Value.ToString();
                txtSoTinChi.Text = row.Cells["SoTinChi"].Value.ToString();
                txtSoTiet.Text = row.Cells["SoTiet"].Value.ToString();
                comboGiangVien.Text = row.Cells["HoTenGiangVien"].Value.ToString(); 

                // Hiển thị các textBox lên:
                // Sẽ hiển thị các ô sửa và xóa
                EnableControl(new List<Control> { txtMH, txtSoTiet, txtSoTinChi, comboGiangVien, btnXoa, btnSua });
                UnEnableControl(new List<Control> { txtMaMH });
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string MaMH = txtMaMH.Text;
            string TenMH = txtMH.Text;
            string soTinChi = txtSoTinChi.Text;
            string SoTiet = txtSoTiet.Text;
            string HoTenGiangVien = comboGiangVien.Text;

            string query = $"Update MonHoc set TenMH = N'{TenMH}', SoTinChi = {soTinChi}, SoTiet = {SoTiet}, HoTenGiangVien = N'{HoTenGiangVien}' where MaMH = '{MaMH}'";
            int result = DataProvider.ThaoTacCSDL(query);

            if (result > 0)
            {
                MessageBox.Show("Sửa môn học thành công");
                //Load lại dữ liệu
                LoadTableMonHoc();
                UnEnableControl(new List<Control> { txtMaMH, txtMH, txtSoTiet, txtSoTinChi, comboGiangVien, btnLuu, btnSua, btnXoa });
                ResetText(new List<Control> { txtMaMH, txtSoTiet, txtSoTinChi, comboGiangVien });
            }
            else
            {
                MessageBox.Show("Sửa môn học thất bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaMH = txtMaMH.Text;
            string query = $"Delete MonHoc Where MaMH = '{MaMH}'";
            int result = DataProvider.ThaoTacCSDL(query);

            if (result > 0)
            {
                MessageBox.Show("Xóa môn học thành công");
                //Load lại dữ liệu
                LoadTableMonHoc();
                UnEnableControl(new List<Control> { txtMaMH, txtMH, txtSoTiet, txtSoTinChi, comboGiangVien, btnLuu, btnSua, btnXoa });
                ResetText(new List<Control> { txtMaMH, txtSoTiet, txtSoTinChi, comboGiangVien, txtMH });
            }
            else
            {
                MessageBox.Show("Xóa môn học thất bại");
            }
        }

        private void comboMaMH_Click(object sender, EventArgs e)
        {
            LoadComboMaMH();
        }

        private void LoadComboMaMH()
        {
            string query = "Select MaMH, TenMH from MonHoc";
            //Trả về datatable
            comboMaMH.DataSource = DataProvider.LoadCSDL(query);
            comboMaMH.ValueMember = "MaMH"; // Lấy giá trị của item
            comboMaMH.DisplayMember = "TenMH"; // Hiển thị rõ tên của môn học lên combo
        }

        private void LoadComboGiangVien()
        {
            string query = "select HoTenGiangVien, MaSoGiangVien from GiangVien";
            comboGiangVien.DataSource = DataProvider.LoadCSDL(query);
            comboGiangVien.ValueMember = "MaSoGiangVien";
            comboGiangVien.DisplayMember = "HoTenGiangVien";
        }

        private void btnTimMHTheoMa_Click(object sender, EventArgs e)
        {
            string MaMH = comboMaMH.SelectedValue.ToString();
            string query = $"Select * from MonHoc where MaMH = '{MaMH}'";
            dt.Clear();
            dt = DataProvider.LoadCSDL(query);
            dtgvMH.DataSource = dt;
        }

        private void btnTimMHTheoNoiDung_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtNoiDung.Text;
            string query = $"Select * from MonHoc where TenMH LIKE N'%{tuKhoa}%'";
            dt.Clear();
            dt = DataProvider.LoadCSDL(query);
            dtgvMH.DataSource = dt;
        }

        private void btnXemDSSV_Click(object sender, EventArgs e)
        {
            ReportFrm f = new ReportFrm("Xem danh sách sinh viên");
            f.ShowDialog();

        }

        private void btnXemDSSVTheoKhoa_Click(object sender, EventArgs e)
        {
            ReportFrm f = new ReportFrm("Xem danh sách sinh viên theo khoa");
            f.ShowDialog();
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            ReportFrm f = new ReportFrm("Xem điểm sinh viên");
            f.ShowDialog();
        }

        private void btnXemDiemTheoMon_Click(object sender, EventArgs e)
        {
            ReportFrm f = new ReportFrm("Xem điểm theo môn");
            f.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chào mừng bạn đến với trang điểm");
            //Tắt form đăng nhập
            this.Hide();
            //Mở form chính
            InfomationInScore mainFrm = new InfomationInScore();
            mainFrm.ShowDialog();
        }

        private void txtSoTiet_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboMaMH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboGiangVien_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboGiangVien_Click(object sender, EventArgs e)
        {
            LoadComboGiangVien();
        }

        private void btnThemGiaoVien_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThemMoiGiangVienFrm f = new ThemMoiGiangVienFrm();
            f.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhapFrm f = new DangNhapFrm();
            f.ShowDialog();
        }

        private void btnThemDuLieu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Controller_AdminFrm f = new Controller_AdminFrm();
            f.ShowDialog();
        }
    }
}
