using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class InfomationInScore : Form
    {
        DataTable dt = new DataTable();

        public InfomationInScore()
        {
            InitializeComponent();
        }

        private void LoadTableScore()
        {
            string query = @"select kq.*, sv.HoTen, mh.TenMH from KetQua kq 
                            join SinhVien sv on kq.MaSV = sv.MaSV 
                            join MonHoc mh on kq.MaMH = mh.MaMH;";
            dt.Clear();
            
            dt = DataProvider.LoadCSDL(query);
            dtgvHienThiDiem.DataSource = dt;

            dtgvHienThiDiem.Columns["MaSV"].HeaderText = "Mã Sinh Viên";
            dtgvHienThiDiem.Columns["HoTen"].HeaderText = "Họ Tên";
            dtgvHienThiDiem.Columns["MaMH"].HeaderText = "Mã Môn Học";
            dtgvHienThiDiem.Columns["TenMH"].HeaderText = "Tên Môn Học";
            dtgvHienThiDiem.Columns["Diem"].HeaderText = "Điểm";
            dtgvHienThiDiem.Columns["DiemA"].HeaderText = "Điểm A";
            dtgvHienThiDiem.Columns["DiemB"].HeaderText = "Điểm B";
            dtgvHienThiDiem.Columns["DiemC"].HeaderText = "Điểm C";
            dtgvHienThiDiem.Columns["Nhom"].HeaderText = "Nhóm";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgvHienThiDiem.SelectedRows.Count > 0)
            {
                var row = dtgvHienThiDiem.SelectedRows[0];

            }
        }

        private void btnHienThiDiem_Click(object sender, EventArgs e)
        {
            LoadTableScore();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTimTheoTen_Click(object sender, EventArgs e)
        {
            string tenCanTim = txtTimTheoTen.Text;
            string query = $@"select kq.*, sv.HoTen, mh.TenMH from KetQua kq 
                                join SinhVien sv on kq.MaSV = sv.MaSV 
                                join MonHoc mh on kq.MaMH = mh.MaMH 
                                where sv.HoTen Like N'%{tenCanTim}%'";
            dt.Clear();
            dt = DataProvider.LoadCSDL(query);
            dtgvHienThiDiem.DataSource = dt;
        }

        private void InfomationInScore_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            AdminActionFrm adminActionFrm = new AdminActionFrm();
            adminActionFrm.Show();
        }
    }
}
