using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace QuanLySinhVien
{
    public static class DataProvider
    {
        //Chuỗi kết nối lây bên trong Server Explorer và ấn vào trong phần database kết nối copy phần connection
        const string connectionString =
            "Data Source=LAPTOP-13CR;Initial Catalog=BT_Demo_QuanLySinhVien;Integrated Security=True;TrustServerCertificate=True";

        private static SqlConnection connection;

        public static List<DangNhap> dsDangNhap = new List<DangNhap>();

        public static List<Student> infoStudentLogin = new List<Student>();
        public static List<GiangVien> infoGiangVienLogin = new List<GiangVien>();
        public static List<MonHoc> infoMonHoc = new List<MonHoc>();
        public static List<string> dsMaLop = new List<string>();
        public static List<string> dsTenSV = new List<string>();
        public static List<KetQua> dsTheoGV = new List<KetQua>();

        public static void OpenConnection()
        {
            //Khởi tạo database
            connection = new SqlConnection(connectionString);
            //Mở kết nối đến database
            connection.Open();
        }

        public static void CloseConnection()
        {
            //Đóng kến nối đến database
            connection.Close();
        }

        //Lấy dữ liệu từ cơ sở dữ liệu lên để so sánh với người dùng nhập

        public static void GetAllInfo()
        {
            try
            {
                OpenConnection();
                string query = "SELECT * FROM DangNhap";
                SqlCommand command = new SqlCommand(query, connection);

                //Đọc dữ liệu từ database
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    DangNhap dangNhap = new DangNhap();
                    //Lấy theo cột trong SQL Server
                    dangNhap.TaiKhoan = reader["TenDangNhap"].ToString();
                    dangNhap.MatKhau = reader["MatKhau"].ToString();
                    dangNhap.HoTen = reader["HoTen"].ToString();
                    dangNhap.Quyen = reader["Quyen"].ToString();
                    dangNhap.MaSo = long.Parse(reader["MaSo"].ToString());   

                    dsDangNhap.Add(dangNhap);
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public static DataTable LoadCSDL(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand(query, connection); //Tại lệnh SQL
                SqlDataAdapter adapter = new SqlDataAdapter(command); //Tạo cầu nối giữa command và datatable
                adapter.Fill(dt); //Đổ dữ liệu vào datatable
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return dt;
        }


        public static int ThaoTacCSDL(string query)
        {
            int result = 0;
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand(query, connection);
                //Trả về được số dòng thực hiện thành công
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }

            return result;
        }

        public static void GetAllInfoStudent(long MaSo)
        {
            try
            {
                OpenConnection();
                if (connection.State == ConnectionState.Open)
                {
                    Debug.WriteLine("Kết nối thành công!");
                }
                else
                {
                    Debug.WriteLine("Kết nối thất bại!");
                    return;
                }

                string query =
                    @"select top 1 * from SinhVien sv join Khoa k on sv.MaKhoa = k.MaKhoa join LopHoc lh on sv.MaLop = lh.MaLop where sv.MaSV = @MaSo";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaSo", MaSo);


                //Đọc dữ liệu từ database
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Student student = new Student();
                    //Lấy theo cột trong SQL Server

                    student.MaSo = long.Parse(reader["MaSV"].ToString());
                    student.HoTen = reader["HoTen"].ToString();
                    student.NgaySinh = reader["NgaySinh"].ToString();
                    student.GioiTinh = int.Parse(reader["GioiTinh"].ToString());
                    student.DiaChi = reader["DiaChi"].ToString();
                    student.SoDienThoai = reader["DienThoai"].ToString();
                    student.MaKhoa = reader["MaKhoa"].ToString();
                    student.TenKhoa = reader["TenKhoa"].ToString();
                    student.MaLop = reader["MaLop"].ToString();
                    student.TenLop = reader["TenLop"].ToString();
                    //Debug.WriteLine($"{student.MaSo} {student.HoTen} {student.NgaySinh} {student.MaKhoa}");
                    infoStudentLogin.Add(student);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public static void GetAllInfoTeacher(long MaSo)
        {
            try
            {
                OpenConnection();
                if (connection.State == ConnectionState.Open)
                {
                    Debug.WriteLine("Kết nối thành công!");
                }
                else
                {
                    Debug.WriteLine("Kết nối thất bại!");
                    return;
                }

                string query =
                    @"select top 1 * from GiangVien gv where gv.MaSoGiangVien = @MaSo";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaSo", MaSo);

                //Đọc dữ liệu từ database
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    GiangVien giangVien = new GiangVien();

                    giangVien.MaSo = int.Parse(reader["MaSoGiangVien"].ToString());
                    giangVien.HoTen = reader["HoTenGiangVien"].ToString();
                    giangVien.CapBac = reader["CapBac"].ToString();
                    giangVien.GioiTinh = int.Parse(reader["GioiTinh"].ToString());
                    giangVien.NgaySinh = reader["NgaySinh"].ToString();
                    giangVien.ThoiGianVao = reader["ThoiGianVao"].ToString();
                    giangVien.MoTa = reader["MoTa"].ToString();
                    giangVien.ChucVu = reader["ChucVu"].ToString();
                    giangVien.MonHocGiangDay = reader["MonHocGiangDay"].ToString();

                    infoGiangVienLogin.Add(giangVien);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public static void LoadTKB(long MaSoSV)
        {
            try
            {
                OpenConnection();
                if (connection.State == ConnectionState.Open)
                {
                    Debug.WriteLine("Kết nối thành công!");
                }
                else
                {
                    Debug.WriteLine("Kết nối thất bại!");
                    return;
                }

                string query = $@"SELECT 
                                    sv.MaSV,
                                    sv.HoTen AS TenSinhVien,
                                    mh.MaMH,
                                    mh.TenMH,
                                    mh.ThoiGianHoc,
                                    mh.Nhom,
                                    mh.SoTinChi,
                                    mh.SoTiet,
                                    gv.HoTenGiangVien
                                FROM 
                                    KetQua kq
                                JOIN 
                                    SinhVien sv ON kq.MaSV = sv.MaSV
                                JOIN 
                                    MonHoc mh ON kq.MaMH = mh.MaMH
                                LEFT JOIN 
                                    GiangVien gv ON mh.HoTenGiangVien = gv.HoTenGiangVien
                                where sv.MaSV = @MaSo
                                ORDER BY 
                                    sv.MaSV, mh.ThoiGianHoc;";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MaSo", MaSoSV);
                //Đọc dữ liệu từ database
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    MonHoc monHoc = new MonHoc();
                    monHoc.maMH = reader["MaMH"].ToString();
                    monHoc.tenMH = reader["TenMH"].ToString();
                    monHoc.soTinChi = int.Parse(reader["SoTinChi"].ToString());
                    monHoc.soTiet = int.Parse(reader["SoTiet"].ToString());
                    monHoc.hoTenGiangVien = reader["HoTenGiangVien"].ToString();
                    monHoc.thoiGianHoc = reader["ThoiGianHoc"].ToString();
                    //Debug.WriteLine($"{monHoc.maMH} {monHoc.tenMH} {monHoc.soTinChi} {monHoc.soTiet} {monHoc.hoTenGiangVien} {monHoc.thoiGianHoc}");
                    infoMonHoc.Add(monHoc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public static char randomChar()
        {
            Random r = new Random();
            int soNguyen = r.Next();
            char c = Convert.ToChar(Math.Abs(soNguyen) % 26 + 65);
            return c;
        }

        public static string makeId()
        {
            Random r = new Random();
            int soNguyen = r.Next(100, 998);
            string s = randomChar() + "" + randomChar() + soNguyen;
            return s;
        }

        public static void GetAllMaLop()
        {
            try
            {
                OpenConnection();
                string query = "SELECT MaLop FROM LopHoc";
                SqlCommand command = new SqlCommand(query, connection);

                //Đọc dữ liệu từ database
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string maLop = reader["MaLop"].ToString();
                    dsMaLop.Add(maLop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public static void GetAllNameStudent()
        {
            try
            {
                OpenConnection();
                string query = "SELECT HoTen FROM SinhVien";
                SqlCommand command = new SqlCommand(query, connection);

                //Đọc dữ liệu từ database
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string tenSV = reader["HoTen"].ToString();
                    dsTenSV.Add(tenSV);
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
             finally
            {
                CloseConnection();
            }   
        }

        public static void LayDiemTheoGV(string HoTenGV)
        {
            try
            {
                string query = "select * from KetQua kq join MonHoc mh on kq.Nhom = mh.Nhom join SinhVien sv on kq.MaSV = sv.MaSV where mh.HoTenGiangVien = @HoTenGV";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@HoTenGV", HoTenGV);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    KetQua kq = new KetQua();

                    kq.MaSoSV = long.Parse(reader["MaSV"].ToString());
                    kq.HoTenSV = reader["HoTen"].ToString();
                    kq.MaMonHoc = reader["MaMH"].ToString();
                    kq.TenMonHoc = reader["TenMH"].ToString();
                    kq.MaLop = reader["MaLop"].ToString();
                    kq.MaKhoa = reader["MaKhoa"].ToString();
                    kq.TenKhoa = reader["TenKhoa"].ToString();
                    kq.DiemA = reader["DiemA"].ToString();
                    kq.DiemB = reader["DiemB"].ToString();
                    kq.DiemC = reader["DiemC"].ToString();
                    kq.DiemTB = reader["DiemTB"].ToString();
                    kq.SoTinChi = int.Parse(reader["SoTinChi"].ToString());
                    
                    dsTheoGV.Add(kq);
                    Debug.WriteLine($"{kq.MaSoSV} {kq.HoTenSV} {kq.MaMonHoc} {kq.TenMonHoc} {kq.MaLop} {kq.MaKhoa} {kq.TenKhoa} {kq.DiemA} {kq.DiemB} {kq.DiemC} {kq.DiemTB}");
                }
            } catch( Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally            
            {
                CloseConnection();
            }
        }
    }
}
