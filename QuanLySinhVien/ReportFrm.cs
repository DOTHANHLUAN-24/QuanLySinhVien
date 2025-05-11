using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QuanLySinhVien
{
    public partial class ReportFrm : Form
    {
        private string _option;
        private long _maSo;
        private string _hoTen;

        public ReportFrm(string option)
        {
            InitializeComponent();
            _option = option;
        }

        public ReportFrm(string option, long maSo)
        {
            InitializeComponent();
            _option = option;
            _maSo = maSo;
        }

        public ReportFrm(string option, string hoTen)
        {
            InitializeComponent();
            _option = option;
            _hoTen = hoTen;
        }

        private void ReportFrm_Load(object sender, EventArgs e)
        {
            if (_option == "Xem danh sách sinh viên")
            {
                try
                {
                    //Truyền đúng file
                    reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySinhVien.ReportSV.rdlc";
                    string query = @"SELECT MaSV, HoTen, Format(NgaySinh, 'dd/MM/yyyy') AS NgaySinh, 
                                    Case when GioiTinh = 1 then N'Nam' else N'Nữ' end as GioiTinh, DiaChi, DienThoai, MaKhoa FROM SinhVien";
                    ReportDataSource reportDataSource = new ReportDataSource()
                    {
                        Name = "DataSetSinhVien",
                        Value = DataProvider.LoadCSDL(query)
                    };
                    //Thông tin để truyền vào
                    //reportDataSource.Name = "DataSetSV";
                    //reportDataSource.Value = DataProvider.LoadCSDL(query);
                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (_option == "Xem danh sách sinh viên theo khoa")
            {
                try
                {
                    reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySinhVien.ReportSVTheoKhoa.rdlc";
                    string query1 = @"select sv.MaSV, sv.HoTen, Format(sv.NgaySinh, 'dd/MM/yyyy') AS NgaySinh,
                                   Case when sv.GioiTinh = 1 then N'Nam' else N'Nữ' end as GioiTinh, sv.DiaChi, sv.DienThoai 
                                    from SinhVien sv Join Khoa k on sv.MaKhoa = k.MaKhoa order by k.TenKhoa";
                    string query2 = @"select k.TenKhoa from SinhVien sv Join Khoa k on sv.MaKhoa = k.MaKhoa order by k.TenKhoa";

                    var reportDataSource1 = new ReportDataSource()
                    {
                        Name = "DataSetSinhVienTheoKhoa",
                        Value = DataProvider.LoadCSDL(query1)
                    };

                    var reportDataSource2 = new ReportDataSource()
                    {
                        Name = "DataSetKhoa",
                        Value = DataProvider.LoadCSDL(query2)
                    };

                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (_option == "Xem điểm sinh viên")
            {
                try
                {
                    reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySinhVien.ReportXemDiem.rdlc";
                    string query = @"select * from KetQua";
                    ReportDataSource reportDataSource = new ReportDataSource()
                    {
                        Name = "DataSetDiem",
                        Value = DataProvider.LoadCSDL(query)
                    };
                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (_option == "Xem điểm theo môn")
            {
                try
                {
                    reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySinhVien.ReportDiemTheoMon.rdlc";
                    string query1 = @"select kq.MaSV, kq.MaMH, kq.Diem from MonHoc mh Join KetQua kq on mh.MaMH = kq.MaMH";
                    string query2 = @"select mh.TenMH, mh.HoTenGiangVien from MonHoc mh Join KetQua kq on mh.MaMH = kq.MaMH";

                    var reportDataSource1 = new ReportDataSource()
                    {
                        Name = "DataSetDiemTheoMon",
                        Value = DataProvider.LoadCSDL(query1)
                    };
                    var reportDataSource2 = new ReportDataSource()
                    {
                        Name = "DataSetTenMonHoc",
                        Value = DataProvider.LoadCSDL(query2)
                    };

                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (_option == "Xem điểm bên sinh viên")
            {
                try
                {
                    reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySinhVien.ReportDiemTheoSV.rdlc";
                    string query1 = $@"select sv.MaSV, sv.HoTen from SinhVien sv where sv.MaSV = {_maSo}";
                    string query2 = $@"select kq.*, mh.* from KetQua kq join MonHoc mh on kq.MaMH = mh.MaMH where kq.MaSV = {_maSo}";

                    var reportDataSource1 = new ReportDataSource()
                    {
                        Name = "DataSetSinhVien",
                        Value = DataProvider.LoadCSDL(query1)
                    };

                    var reportDataSource2 = new ReportDataSource()
                    {
                        Name = "DataSetKetQua",
                        Value = DataProvider.LoadCSDL(query2)
                    };
                    var reportDataSource3 = new ReportDataSource()
                    {
                        Name = "DataSetMonHoc",
                        Value = DataProvider.LoadCSDL($"select kq.*, mh.* from KetQua kq join MonHoc mh on kq.MaMH = mh.MaMH where kq.MaSV = {_maSo}")
                    };

                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (_option == "Xem môn học bên sinh viên")
            {
                try
                {
                    reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySinhVien.ReportMonHocTheoSV.rdlc";
                    string query =
                        $@"select mh.* from MonHoc mh join KetQua kq on mh.MaMH = kq.MaMH join SinhVien sv on kq.MaSV = sv.MaSV where sv.MaSV = {_maSo}";

                    var reportDataSource = new ReportDataSource()
                    {
                        Name = "DataSetMonHoc",
                        Value = DataProvider.LoadCSDL(query)
                    };

                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (_option == "Xem giảng viên bên sinh viên")
            {
                try
                {
                    reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySinhVien.ReportGiangVienTheoSV.rdlc";
                    string query1 = $@"select MaSV, Format(NgaySinh, 'dd/MM/yyyy') AS NgaySinh, Case when GioiTinh = 1 then N'Nam' else N'Nữ' end as GioiTinh, HoTen from SinhVien where MaSV = {_maSo}";
                    string query2 = $@"select gv.* from GiangVien gv join MonHoc mh on gv.HoTenGiangVien = mh.HoTenGiangVien join KetQua kq on mh.MaMH = kq.MaMH where kq.MaSV = {_maSo}";

                    var reportDataSource1 = new ReportDataSource()
                    {
                        Name = "DataSetThongTinSinhVien",
                        Value = DataProvider.LoadCSDL(query1)
                    };

                    var reportDataSource2 = new ReportDataSource()
                    {
                        Name = "DataSetThongTinGiangVien",
                        Value = DataProvider.LoadCSDL(query2)
                    };

                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if(_option == "Xem điểm bên giảng viên")
            {
                try
                {
                    reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySinhVien.ReportDiemTheoGV.rdlc";
                    string query1 = $@"select * from SinhVien sv join KetQua kq on sv.MaSV = kq.MaSV join MonHoc mh on kq.Nhom = mh.Nhom where mh.HoTenGiangVien = N'{_hoTen}'";
                    string query2 = $@"select * from MonHoc mh where mh.HoTenGiangVien = N'{_hoTen}'";
                    string query3 = $@"select * from KetQua kq join MonHoc mh on kq.Nhom = mh.Nhom where mh.HoTenGiangVien = N'{_hoTen}'";

                    var reportDataSource1 = new ReportDataSource()
                    {
                        Name = "dbSV",
                        Value = DataProvider.LoadCSDL(query1)
                    };

                    var reportDataSource2 = new ReportDataSource()
                    {
                        Name = "dbMH",
                        Value = DataProvider.LoadCSDL(query2)
                    };

                    var reportDataSource3 = new ReportDataSource()
                    {
                        Name = "db_KetQua",
                        Value = DataProvider.LoadCSDL(query3)
                    };

                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
                    this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);

                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
