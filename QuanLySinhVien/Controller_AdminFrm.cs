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
    public partial class Controller_AdminFrm : Form
    {
        public Controller_AdminFrm()
        {
            InitializeComponent();
        }

        private void btnThemGVMoi_Click(object sender, EventArgs e)
        {
            ThemMoiGiangVienFrm f = new ThemMoiGiangVienFrm();
            f.ShowDialog();
        }

        private void btnThemSVMoi_Click(object sender, EventArgs e)
        {
            ThemSinhVienFrm f = new ThemSinhVienFrm();
            this.Hide();
            f.ShowDialog();
        }

        private void btnThemTGMH_Click(object sender, EventArgs e)
        {
            ThemTGMHFrm frm = new ThemTGMHFrm();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
