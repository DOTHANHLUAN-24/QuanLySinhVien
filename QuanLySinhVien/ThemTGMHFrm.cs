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
    public partial class ThemTGMHFrm : Form
    {
        DataTable dt = new DataTable();

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

            if (dtgvMH.SelectedRows.Count > 0)
            {
                //Lấy dòng đầu tiên khi nhấn vào
                var row = dtgvMH.SelectedRows[0];
                btnLuu.Enabled = true;

                // Truyền giá trị lên các textBox ở trên
                // Tại vì .Value trả về kiểu object nên phải ép kiểu về string
                txtMaMH.Text = row.Cells["MaMH"].Value.ToString();
                txtMH.Text = row.Cells["TenMH"].Value.ToString();
                txtSoTinChi.Text = row.Cells["SoTinChi"].Value.ToString();
                txtSoTiet.Text = row.Cells["SoTiet"].Value.ToString();
                txtHoTenGV.Text = row.Cells["HoTenGiangVien"].Value.ToString();
                txtMaNhom.Text = row.Cells["Nhom"].Value.ToString();

                groupBox4.Enabled = true;

                if (Int32.Parse(txtSoTinChi.Text) >= 4)
                {
                    radioButton1.Enabled = false;
                    radioButton2.Enabled = false;
                    radioButton3.Enabled = true;
                } else if (Int32.Parse(txtSoTinChi.Text) == 3 || Int32.Parse(txtSoTinChi.Text) == 2)
                {
                    radioButton1.Enabled = true;
                    radioButton2.Enabled = true;
                    radioButton3.Enabled = false;
                } else if(Int32.Parse(txtSoTinChi.Text) == 1)
                {
                    radioButton1.Enabled = true;
                    radioButton2.Enabled = false;
                    radioButton3.Enabled = false;
                }

                UnEnableControl(new List<Control> { txtMaMH, txtMaNhom, txtSoTiet, txtSoTinChi, txtHoTenGV, txtMH });
            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {
             
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                comboB1.Items.Clear();
                comboB2.Items.Clear();
                comboB3.Items.Clear();
                //Debug.WriteLine("RadioButton1 is checked");
                groupBox1.Enabled = true;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                if(Int32.Parse(txtSoTinChi.Text) == 3)
                {
                    List<string> lichHocTC3B11T = new List<string>();
                    for (int i = 2; i <= 7; i++)
                    {
                        for (int j = 1; j <= 11; j++)
                        {
                            if (j == 5)
                                continue;

                            string tietHoc = $"Thứ {i} - Tiết bắt đầu: {j} - Tiết kết thúc: {j + 2};";
                            lichHocTC3B11T.Add(tietHoc);
                        }
                    }

                    comboB1.Items.AddRange(lichHocTC3B11T.ToArray());
                }
                else if (Int32.Parse(txtSoTinChi.Text) == 1 || Int32.Parse(txtSoTinChi.Text) == 2)
                {
                    List<string> lichHocTC12B11T = new List<string>();
                    for (int i = 2; i <= 7; i++)
                    {
                        for (int j = 1; j <= 12; j++)
                        {
                            if (j == 5)
                                continue;

                            string tietHoc = $"Thứ {i} - Tiết bắt đầu: {j} - Tiết kết thúc: {j + 1};";
                            lichHocTC12B11T.Add(tietHoc);
                        }
                    }

                    comboB1.Items.AddRange(lichHocTC12B11T.ToArray());
                } 
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                comboB1.Items.Clear();
                comboB2.Items.Clear();
                comboB3.Items.Clear();
                //Debug.WriteLine("RadioButton2 is checked");
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                groupBox3.Enabled = false;

                if(Int32.Parse(txtSoTinChi.Text) == 3)
                {
                    List<string> lichHocTC3B21T = new List<string>();
                    for (int i = 2; i <= 7; i++)
                    {
                        for (int j = 1; j <= 12; j++)
                        {
                            if (j == 4 || j == 5)
                                continue;
                            string tietHoc = $"Thứ {i} - Tiết bắt đầu: {j} - Tiết kết thúc: {j + 1};";

                            lichHocTC3B21T.Add(tietHoc);
                        }
                    }

                    comboB1.Items.AddRange(lichHocTC3B21T.ToArray());
                    comboB2.Items.AddRange(lichHocTC3B21T.ToArray());
                } else if(Int32.Parse(txtSoTinChi.Text) == 2 || Int32.Parse(txtSoTinChi.Text) == 1)
                {
                    List<string> lichHocTC2B21T = new List<string>();
                    for (int i = 2; i <= 7; i++)
                    {
                        for (int j = 1; j <= 11; j++)
                        {
                            if (j == 5)
                                continue;

                            string tietHoc = $"Thứ {i} - Tiết bắt đầu: {j} - Tiết kết thúc: {j + 2};";
                            lichHocTC2B21T.Add(tietHoc);
                        }
                    }

                    comboB1.Items.AddRange(lichHocTC2B21T.ToArray());
                    comboB2.Items.AddRange(lichHocTC2B21T.ToArray());
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                comboB1.Items.Clear();
                comboB2.Items.Clear();
                comboB3.Items.Clear();
                //Debug.WriteLine("RadioButton3 is checked");
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;

                if(Int32.Parse(txtSoTinChi.Text) == 4)
                {
                    List<string> lichHocTC4B31T = new List<string>();
                    for (int i = 2; i <= 7; i++)
                    {
                        for (int j = 1; j <= 11; j++)
                        {
                            if (j == 5)
                                continue;

                            string tietHoc = $"Thứ {i} - Tiết bắt đầu: {j} - Tiết kết thúc: {j + 2};";
                            lichHocTC4B31T.Add(tietHoc);
                        }
                    }

                    comboB1.Items.AddRange(lichHocTC4B31T.ToArray());
                    comboB2.Items.AddRange(lichHocTC4B31T.ToArray());
                    comboB3.Items.AddRange(lichHocTC4B31T.ToArray());
                }
            }
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

        private void ThemTGMHFrm_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
            btnLuu.Enabled = false;

            comboB1.Items.Clear();
            comboB2.Items.Clear();
            comboB3.Items.Clear();
        }

        //Nút lưu dữ liệu
        private void button1_Click(object sender, EventArgs e)
        {
            string selectedItem1 = comboB1.SelectedItem?.ToString();
            string selectedItem2 = comboB2.SelectedItem?.ToString();
            string selectedItem3 = comboB3.SelectedItem?.ToString();
            string lichHoc = "";
            if (int.Parse(txtSoTinChi.Text) >= 4 && selectedItem1 != null && selectedItem2 != null && selectedItem3 != null)
            {
                lichHoc = $"{selectedItem1} {selectedItem2} {selectedItem3}";
                //Debug.WriteLine(lichHoc);
                //Debug.WriteLine("Lưu dữ liệu với 3 thời gian học {0}; {1}; {2}", selectedItem1, selectedItem3, selectedItem2);

            } else if ((Int32.Parse(txtSoTinChi.Text) == 3 || Int32.Parse(txtSoTinChi.Text) == 2) && selectedItem1 != null && selectedItem2 != null) {
                lichHoc = $"{selectedItem1} {selectedItem2}";
            } else if (Int32.Parse(txtSoTinChi.Text) == 1 && selectedItem1 != null)
            {
                lichHoc = $"{selectedItem1}";
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thời gian học cho môn học này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if(lichHoc != "")
            {
                string query = $@"update MonHoc set ThoiGianHoc = N'{lichHoc}' where MaMH = '{txtMaMH.Text}'";
                DataProvider.LoadCSDL(query);
                MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comboB1.Enabled = false;
                comboB2.Enabled = false;
                comboB3.Enabled = false;
                comboB1.Items.Clear();
                comboB2.Items.Clear();
                comboB3.Items.Clear();
                comboB1.SelectedIndex = -1;
                comboB2.SelectedIndex = -1;
                comboB3.SelectedIndex = -1;
                LoadDataMH();

                ResetText(new List<Control> { txtMaMH, txtMaNhom, txtSoTiet, txtSoTinChi, txtHoTenGV, txtMH });
            }
        }

        private void comboB1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboB1.SelectedItem.ToString();
            
            var itemsToRemove = danhSachLoaiBo(selectedItem);

            // Xóa các item cùng ngày (trừ cái đã chọn)
            foreach (var item in itemsToRemove)
            {
                comboB2.Items.Remove(item);
                comboB3.Items.Remove(item);
            }

            comboB2.Items.Remove(selectedItem);
            comboB3.Items.Remove(selectedItem);
        }

        private void comboB2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboB2.SelectedItem.ToString();

            var itemsToRemove = danhSachLoaiBo(selectedItem);

            foreach (var item in itemsToRemove)
            {
                comboB1.Items.Remove(item);
                comboB3.Items.Remove(item);
            }


            comboB1.Items.Remove(selectedItem);
            comboB3.Items.Remove(selectedItem);
        }

        private void comboB3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboB3.SelectedItem.ToString();

            var itemsToRemove = danhSachLoaiBo(selectedItem);

            foreach (var item in itemsToRemove)
            {
                comboB2.Items.Remove(item);
                comboB1.Items.Remove(item);
            }


            comboB2.Items.Remove(selectedItem);
            comboB1.Items.Remove(selectedItem);
        }

        private List<object> danhSachLoaiBo(string selectedItem)
        {
            // Tách để lấy phần "Thứ x"
            string ngay = selectedItem.Split('-')[0].Trim(); // => "Thứ 2"

            // Tìm tất cả item cần loại bỏ
            List<object> itemsToRemove = new List<object>();
            foreach (var item in comboB1.Items)
            {
                string value = item.ToString();
                if (value.StartsWith(ngay) && value != selectedItem)
                {
                    itemsToRemove.Add(item);
                }
            }

            return itemsToRemove;
        }

        private void ThemTGMHFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            AdminActionFrm f = new AdminActionFrm();
            f.ShowDialog();
        }
    }
}
