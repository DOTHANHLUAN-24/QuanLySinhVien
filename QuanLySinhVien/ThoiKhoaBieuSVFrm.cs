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
using System.Xml.Linq;

namespace QuanLySinhVien
{
    public partial class ThoiKhoaBieuSVFrm : Form
    {
        DataTable dt = new DataTable();
        int rows = 15;
        int cols = 9;
        public long maSo;
        public ThoiKhoaBieuSVFrm()
        {
            InitializeComponent();
            CreateMatrix(rows, cols); // Tạo ma trận 5x5
        }

        private void CreateMatrix(int rows, int cols)
        {
           
            dtgvThoiKhoaBieu.ColumnCount = cols;
            dtgvThoiKhoaBieu.RowCount = rows;
            string[] days = { " ", "Thứ 2", "Thứ 3", "Thứ 4", "Thứ 5", "Thứ 6", "Thứ 7", "Chủ nhật", " " };
            string[] time =
            {
                 "6:45", "7:45", "8:45", "9:45", "10:45", "12:30", "13:30", "14:30", "15:30", "16:30", "17:30",
                "18:30", "19:30"
            };
            int count = 0;

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (j == 0 || j == 14)
                    {
                        dtgvThoiKhoaBieu.Rows[j].Cells[i].Value = $"{days[i]}";
                    } else if (i == 8)
                    {
                        dtgvThoiKhoaBieu.Rows[j].Cells[i].Value = $"{time[count]}";
                        if (count <= time.Length - 1)
                            count++;
                    }
                    else
                    {
                        if (i == 0)
                        {
                            dtgvThoiKhoaBieu.Rows[j].Cells[i].Value = $"Tiết {j}";
                        }
                    }
                }
            }
        }

        private void ThoiKhoaBieuSVFrm_Load(object sender, EventArgs e)
        {
            DataProvider.LoadTKB(MaSoSV: maSo);
            Debug.WriteLine(maSo);
        }

        private void btnHienThiTKB_Click(object sender, EventArgs e)
        {
            //Debug.WriteLine(DataProvider.infoMonHoc);
            Dictionary<string, Dictionary<string, Dictionary<string, string>>> tkb = new Dictionary<string, Dictionary<string, Dictionary<string, string>>>();

            foreach (var day in DataProvider.infoMonHoc)
            {
                //Debug.WriteLine(day);

                var subDict = new Dictionary<string, Dictionary<string, string>>();
                //Debug.WriteLine($"----------------------------------------------------------------");
                //Debug.WriteLine(day.thoiGianHoc);
                //Debug.WriteLine($"Chia cắt lần 1: ");
                string[] split1 = day.thoiGianHoc.Split(';');
                foreach (string split2 in split1)
                {
                    string[] split3 = split2.Split('-');
                    var subSubDict = new Dictionary<string, string>();
                    subSubDict["Tiết bắt đầu"] = split3[1].Split(':')[1].Trim();
                    subSubDict["Tiết kết thúc"] = split3[2].Split(':')[1].Trim();
                    subDict[split3[0]] = subSubDict;
                }

                tkb[day.tenMH] = subDict;
            }

            // Xử lý điền dữ liệu vào gtgv

            //foreach (var outer in tkb)
            //{
            //    Debug.WriteLine($"Môn học: {outer.Key}");

            //    var subDict = (Dictionary<string, Dictionary<string, string>>)outer.Value;

            //    foreach (KeyValuePair<string, Dictionary<string, string>> inner in subDict)
            //    {
            //        Debug.WriteLine($"\tNgày: {inner.Key}");
            //        foreach (var info in inner.Value)
            //        {
            //            Debug.WriteLine($"\t\t{info.Key}: {info.Value}");
            //        }
            //    }
            //}

            for (int i = 0; i < cols; i++)
            {
                //Debug.WriteLine($"{dtgvThoiKhoaBieu.Rows[0].Cells[i].Value}");
                foreach (var outer in tkb)
                {
                    //Debug.WriteLine($"Môn học: {outer.Key}");

                    var subDict = (Dictionary<string, Dictionary<string, string>>)outer.Value;

                    foreach (KeyValuePair<string, Dictionary<string, string>> inner in subDict)
                    {
                        //Debug.WriteLine($"\tNgày: {inner.Key.Trim().Length}");
                        //Debug.WriteLine(dtgvThoiKhoaBieu.Rows[0].Cells[i].Value.ToString());
                        if (dtgvThoiKhoaBieu.Rows[0].Cells[i].Value.ToString() == inner.Key.Trim())
                        {
                            //Debug.WriteLine("inner.Key");
                            //Debug.WriteLine(inner.Value["Tiết bắt đầu"]);
                            for (int j = int.Parse(inner.Value["Tiết bắt đầu"]); j <= int.Parse(inner.Value["Tiết kết thúc"]) ; j++)
                            {
                                dtgvThoiKhoaBieu.Rows[j].Cells[i].Value = outer.Key;
                            }
                            //foreach (var info in inner.Value)
                            //{
                            //    Debug.WriteLine($"\t\t{info.Key}: {info.Value}");
                            //}
                        }
                        
                    }
                }
            }
        }
    }
}
