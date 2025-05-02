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
    public partial class ThemTGMHFrm : Form
    {
        DataTable dt = new DataTable();
        public string soBuoi;

        public ThemTGMHFrm()
        {
            InitializeComponent();
        }

        private void LoadDataMH()
        {
            //quey -> lấy data từ CSDL -> database -> datagridview
            string query = "  select * from MonHoc where ThoiGianHoc is null";
            //Xóa sạch dữ liệu trước
            dt.Clear();
            //Load dữ liệu mới vào trong datatable
            dt = DataProvider.LoadCSDL(query);
            //Điền vào trong datagridview
            dtgvMH.DataSource = dt;

            dtgvMH.Columns["MaMH"].HeaderText = "Mã Môn Học";
            dtgvMH.Columns["TenMH"].HeaderText = "Tên Môn Học";
            dtgvMH.Columns["SoTinChi"].HeaderText = "Số Tín Chỉ";
            dtgvMH.Columns["SoTiet"].HeaderText = "Số Tiết";
            dtgvMH.Columns["HoTenGiangVien"].HeaderText = "Người Hướng Dẫn";
        }

        private void btnHienThiDTGV_Click(object sender, EventArgs e)
        {
            LoadDataMH();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Debug.WriteLine(dtgvMH.SelectedRows.Count.ToString() + " dòng được chọn");

            if(dtgvMH.SelectedRows.Count > 0)
            {
                //Lấy dòng đầu tiên khi nhấn vào
                var row = dtgvMH.SelectedRows[0];

                // Truyền giá trị lên các textBox ở trên
                // Tại vì .Value trả về kiểu object nên phải ép kiểu về string
                txtMaMH.Text = row.Cells["MaMH"].Value.ToString();
                txtMH.Text = row.Cells["TenMH"].Value.ToString();
                txtSoTinChi.Text = row.Cells["SoTinChi"].Value.ToString();
                txtSoTiet.Text = row.Cells["SoTiet"].Value.ToString();
                txtHoTenGV.Text = row.Cells["HoTenGiangVien"].Value.ToString();

                UnEnableControl(new List<Control> { txtMaMH, txtMaNhom, txtSoTiet, txtSoTinChi, txtHoTenGV, txtMH });
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
             
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("RadioButton1 is checked");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("RadioButton2 is checked");

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("RadioButton3 is checked");
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
    }
}
