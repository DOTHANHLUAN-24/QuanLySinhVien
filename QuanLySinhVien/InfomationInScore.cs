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

            //dtgvHienThiDiem.Columns
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
    }
}
