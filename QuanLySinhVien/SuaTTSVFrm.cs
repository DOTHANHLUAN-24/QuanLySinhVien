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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLySinhVien
{
    public partial class SuaTTSVFrm : Form
    {

        DataTable dt = new DataTable();

        bool isUpdating = false;
        public SuaTTSVFrm()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void LoadTableMH() 
        {
            string query = $@"select MaSV, HoTen, NgaySinh, Case GioiTinh when 1 then N'Nam' when 0 then N'Nữ' End as NgaySinh, DiaChi, DienThoai, MaKhoa, MaLop from SinhVien";
            dt.Clear();

            dt = DataProvider.LoadCSDL(query);
            dtgvTTSV.DataSource = dt;

            dtgvTTSV.Columns[0].HeaderText = "Mã Sinh Viên";
            dtgvTTSV.Columns[1].HeaderText = "Họ và Tên";
            dtgvTTSV.Columns[2].HeaderText = "Ngày Sinh";
            dtgvTTSV.Columns[3].HeaderText = "Giới Tính";
            dtgvTTSV.Columns[4].HeaderText = "Địa Chỉ";
            dtgvTTSV.Columns[5].HeaderText = "Số Điện Thoại";
            dtgvTTSV.Columns[6].HeaderText = "Mã Khoa";
            dtgvTTSV.Columns[7].HeaderText = "Mã Lớp";
        }

        private void dtgvTTSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Debug.WriteLine(dtgvTTSV.SelectedRows.Count);

            if(dtgvTTSV.SelectedRows.Count > 0)
            {
                var row = dtgvTTSV.SelectedRows[0];
                txtMaSo.Text = row.Cells[0].Value.ToString();
                txtMaSo.Enabled = false;
                txtHoTen.Text = row.Cells[1].Value.ToString();
                dtpNgaySinh.Value = DateTime.Parse(row.Cells[2].Value.ToString());
                //Debug.WriteLine(row.Cells[3].Value.ToString());
                //comboGioiTinh.SelectedItem = row.Cells[3].Value.ToString();
                foreach (var x in comboGioiTinh.Items)
                {
                    if (x.ToString() == row.Cells[3].Value.ToString())
                    {
                        comboGioiTinh.SelectedItem = x;
                        break;
                    }
                }
                txtDienThoai.Text = row.Cells[5].Value.ToString();
                txtDiaChi.Text = row.Cells[4].Value.ToString();
                txtMaKhoa.Text = row.Cells[6].Value.ToString();
                txtMaLop.Text = row.Cells[7].Value.ToString();
            }
        }

        private void btnHienThiTT_Click(object sender, EventArgs e)
        {
            LoadTableMH();
        }


        private void LoadComboBoxMaLop()
        {
            string query = $@"select MaSV, HoTen, NgaySinh, Case GioiTinh when 1 then N'Nam' when 0 then N'Nữ' End as NgaySinh, DiaChi, DienThoai, MaKhoa, MaLop MaLop from LopHoc";
            dt = DataProvider.LoadCSDL(query);
            comboMaLop.DataSource = dt;


        }

        private void SuaTTSVFrm_Load(object sender, EventArgs e)
        {
            comboGioiTinh.Items.Add("Nam");
            comboGioiTinh.Items.Add("Nữ");

            DataProvider.GetAllMaLop();
            foreach (var item in DataProvider.dsMaLop)
            {
                comboMaLop.Items.Add(item);
            }

            DataProvider.GetAllNameStudent();
            foreach (var item in DataProvider.dsTenSV)
            {
                comboHoVaTen.Items.Add(item);
            }
        }

        private void btnTimKiemTheoLop_Click(object sender, EventArgs e)
        {
            string maLopInput = comboMaLop.Text;
            string where = $"MaLop = '{maLopInput}'";
            queryHasWhere(where);
        }

        private void comboHoVaTen_TextChanged(object sender, EventArgs e)
        {
            //    List<string> suggestName = new List<string>();
            //    string text = comboHoVaTen.Text;

            //    if(text.Trim() != "" && text.Length > 0)
            //    {
            //        foreach (var item in DataProvider.dsTenSV)
            //        {
            //            if (item.ToLower().Contains(text.ToLower()))
            //            {
            //                suggestName.Add(item);
            //            }
            //        }
            //    }
            //    else
            //    {
            //        suggestName = DataProvider.dsTenSV;
            //    }

            //    comboHoVaTen.Items.Clear();
            //    comboHoVaTen.Items.AddRange(suggestName.ToArray());
        }

        private void comboHoVaTen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboHoVaTen_KeyUp(object sender, KeyEventArgs e)
        {
            /*
            List<string> suggestName = new List<string>();
            string text = comboHoVaTen.Text;

            if (text.Trim() != "" && text.Length > 0)
            {
                foreach (var item in DataProvider.dsTenSV)
                {
                    if (item.ToLower().Contains(text.ToLower()))
                    {
                        suggestName.Add(item);
                    }
                }
            }
            else
            {
                suggestName = DataProvider.dsTenSV;
            }

            if (suggestName.Count > 0)
            {
                comboHoVaTen.DroppedDown = true; // Mở dropdown
                comboHoVaTen.Items.Clear();
                comboHoVaTen.Items.AddRange(suggestName.ToArray());

                comboHoVaTen.SelectionStart = text.Length;
                comboHoVaTen.SelectionLength = 0;
                Cursor.Current = Cursors.Default;
            }
            else
            {
                comboHoVaTen.DroppedDown = false;
            }
        */

            string text = comboHoVaTen.Text;
            int selStart = comboHoVaTen.SelectionStart;

            List<string> suggestName;

            if (!string.IsNullOrWhiteSpace(text))
            {
                suggestName = DataProvider.dsTenSV
                    .Where(item => item.IndexOf(text, StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();
            }
            else
            {
                suggestName = new List<string>(DataProvider.dsTenSV);
            }

            // Tránh reset text khi đang gõ
            if (suggestName.Count > 0)
            {
                // Tạm thời ngắt binding để giữ trạng thái nhập
                comboHoVaTen.BeginUpdate();

                string currentText = comboHoVaTen.Text;

                comboHoVaTen.Items.Clear();
                comboHoVaTen.Items.AddRange(suggestName.ToArray());

                comboHoVaTen.DroppedDown = true;

                comboHoVaTen.Text = currentText;
                comboHoVaTen.SelectionStart = selStart;
                comboHoVaTen.SelectionLength = 0;

                comboHoVaTen.EndUpdate();
                Cursor.Current = Cursors.Default;
            }
            else
            {
                comboHoVaTen.DroppedDown = false;
            }
        }

        private void btnTimKiemTheoTen_Click(object sender, EventArgs e)
        {
            string nameToFind = comboHoVaTen.Text;

            string where = $"HoTen like N'%{nameToFind}%'";
            queryHasWhere(where);
        }

        private void btnTimKiemTheoMaSo_Click(object sender, EventArgs e)
        {
            string msInput = textBox1.Text;
            Debug.WriteLine(msInput);
            Debug.WriteLine("{0}", msInput);
            if(long.TryParse(msInput, out long idToFind)) {
                Debug.WriteLine(idToFind);
                string where = $"MaSV = {idToFind}";
                queryHasWhere(where);
            }
        }

        private void queryHasWhere(string where)
        {
            string query = $@"select MaSV, HoTen, NgaySinh, Case GioiTinh when 1 then N'Nam' when 0 then N'Nữ' End as NgaySinh, DiaChi, DienThoai, MaKhoa, MaLop from SinhVien where {where}";

            Debug.WriteLine("{0}", query);

            dt.Clear();
            dt = DataProvider.LoadCSDL(query);
            dtgvTTSV.DataSource = dt;

            dtgvTTSV.Columns[0].HeaderText = "Mã Sinh Viên";
            dtgvTTSV.Columns[1].HeaderText = "Họ và Tên";
            dtgvTTSV.Columns[2].HeaderText = "Ngày Sinh";
            dtgvTTSV.Columns[3].HeaderText = "Giới Tính";
            dtgvTTSV.Columns[4].HeaderText = "Địa Chỉ";
            dtgvTTSV.Columns[5].HeaderText = "Số Điện Thoại";
            dtgvTTSV.Columns[6].HeaderText = "Mã Khoa";
            dtgvTTSV.Columns[7].HeaderText = "Mã Lớp";
        }
    }
}
