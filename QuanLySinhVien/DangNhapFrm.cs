using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class DangNhapFrm : Form
    {
        public string hoTenNguoiDangNhap = "";
        public long idNguoiDung = -1;

        public DangNhapFrm()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //Tắt chương trình luôn
            Dispose();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            //Lấy dữ liệu của người dùng nhập
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            errorProvider1.Clear();

            bool isFound = false;
            string quyenDangNhap = "";

            if(tenDangNhap.Trim() == "")
            {
                errorProvider1.SetError(txtTenDangNhap, "Tên đăng nhập không được để trống");
            }
            if (matKhau.Length < 6)
            {
                errorProvider1.SetError(txtMatKhau, "Mật khẩu phải có ít nhất 6 ký tự");
            }

                foreach (var dn in DataProvider.dsDangNhap)
                {
                    if (dn.TaiKhoan == tenDangNhap && dn.MatKhau == matKhau)
                    {
                        isFound = true;
                        quyenDangNhap = dn.Quyen;
                        hoTenNguoiDangNhap = dn.HoTen;
                        idNguoiDung = dn.MaSo;
                        break;
                    }
                }

            if (isFound)
            {
                //Nếu đúng thì sẽ hiện thông báo
                MessageBox.Show("Đăng nhập thành công");
                //Tắt form đăng nhập
                this.Hide();

                if (quyenDangNhap == "Quản trị viên")
                {
                    //Mở form chính
                    AdminActionFrm mainFrm = new AdminActionFrm();
                    mainFrm.ShowDialog();
                } else if (quyenDangNhap == "Giảng viên")
                {
                    GiangVienAction giangVienFrm = new GiangVienAction();
                    giangVienFrm.hoTenNguoiDangNhap = hoTenNguoiDangNhap;
                    giangVienFrm.maSoGiangVien = idNguoiDung;
                    giangVienFrm.ShowDialog();
                }
                else
                {
                    SinhVienActionFrm svFrm = new SinhVienActionFrm();
                    svFrm.hoTenNguoiDangNhap = hoTenNguoiDangNhap;
                    svFrm.MaSo = idNguoiDung;
                    svFrm.ShowDialog();
                }

            }
            else
            {
                MessageBox.Show("Sai tên hoặc mật khẩu");
            }
        }

        private void DangNhapFrm_Load(object sender, EventArgs e)
        {
            //Lấy hết tất cả dữ liệu trong database
            DataProvider.GetAllInfo();
        }

        private void DangNhapFrm_Enter(object sender, EventArgs e)
        {
            
        }

        private void DangNhapFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) { 
                Debug.WriteLine("Enter pressed");
                btnDangNhap_Click(sender, e);
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Debug.WriteLine("Enter pressed");
                btnDangNhap_Click(sender, e);
            }
        }
    }
}
