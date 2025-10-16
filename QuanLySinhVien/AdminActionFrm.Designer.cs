namespace QuanLySinhVien
{
    partial class AdminActionFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminActionFrm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.txtMH = new System.Windows.Forms.TextBox();
            this.txtSoTinChi = new System.Windows.Forms.TextBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.comboMaMH = new System.Windows.Forms.ComboBox();
            this.btnTimMHTheoMa = new System.Windows.Forms.Button();
            this.btnTimMHTheoNoiDung = new System.Windows.Forms.Button();
            this.btnHienThiTatCa = new System.Windows.Forms.Button();
            this.dtgvMH = new System.Windows.Forms.DataGridView();
            this.btnXemDSSV = new System.Windows.Forms.Button();
            this.btnXemDSSVTheoKhoa = new System.Windows.Forms.Button();
            this.btnDiem = new System.Windows.Forms.Button();
            this.btnXemDiemTheoMon = new System.Windows.Forms.Button();
            this.btnThemMoi = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoTiet = new System.Windows.Forms.TextBox();
            this.btnThongTinDiem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboGiangVien = new System.Windows.Forms.ComboBox();
            this.btnThemGiaoVien = new System.Windows.Forms.Button();
            this.btnDangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.btnThemDuLieu = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Môn Học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên Môn Học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Tín Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(437, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Chọn tên môn học cần tìm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(552, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(570, 45);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tìm kiếm thông tin của môn học";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(674, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nhập từ khóa";
            // 
            // txtMaMH
            // 
            this.txtMaMH.Enabled = false;
            this.txtMaMH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMH.Location = new System.Drawing.Point(173, 44);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(214, 27);
            this.txtMaMH.TabIndex = 2;
            // 
            // txtMH
            // 
            this.txtMH.Enabled = false;
            this.txtMH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMH.Location = new System.Drawing.Point(173, 85);
            this.txtMH.Name = "txtMH";
            this.txtMH.Size = new System.Drawing.Size(214, 27);
            this.txtMH.TabIndex = 3;
            // 
            // txtSoTinChi
            // 
            this.txtSoTinChi.Enabled = false;
            this.txtSoTinChi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTinChi.Location = new System.Drawing.Point(173, 126);
            this.txtSoTinChi.Name = "txtSoTinChi";
            this.txtSoTinChi.Size = new System.Drawing.Size(214, 27);
            this.txtSoTinChi.TabIndex = 4;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDung.Location = new System.Drawing.Point(777, 101);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(305, 27);
            this.txtNoiDung.TabIndex = 7;
            // 
            // comboMaMH
            // 
            this.comboMaMH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMaMH.FormattingEnabled = true;
            this.comboMaMH.Location = new System.Drawing.Point(405, 129);
            this.comboMaMH.Name = "comboMaMH";
            this.comboMaMH.Size = new System.Drawing.Size(231, 27);
            this.comboMaMH.TabIndex = 6;
            this.comboMaMH.SelectedIndexChanged += new System.EventHandler(this.comboMaMH_SelectedIndexChanged);
            this.comboMaMH.Click += new System.EventHandler(this.comboMaMH_Click);
            // 
            // btnTimMHTheoMa
            // 
            this.btnTimMHTheoMa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimMHTheoMa.Location = new System.Drawing.Point(405, 177);
            this.btnTimMHTheoMa.Name = "btnTimMHTheoMa";
            this.btnTimMHTheoMa.Size = new System.Drawing.Size(231, 43);
            this.btnTimMHTheoMa.TabIndex = 15;
            this.btnTimMHTheoMa.Text = "Tìm kiếm";
            this.btnTimMHTheoMa.UseVisualStyleBackColor = true;
            this.btnTimMHTheoMa.Click += new System.EventHandler(this.btnTimMHTheoMa_Click);
            // 
            // btnTimMHTheoNoiDung
            // 
            this.btnTimMHTheoNoiDung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimMHTheoNoiDung.Location = new System.Drawing.Point(839, 142);
            this.btnTimMHTheoNoiDung.Name = "btnTimMHTheoNoiDung";
            this.btnTimMHTheoNoiDung.Size = new System.Drawing.Size(173, 36);
            this.btnTimMHTheoNoiDung.TabIndex = 16;
            this.btnTimMHTheoNoiDung.Text = "Tìm kiếm";
            this.btnTimMHTheoNoiDung.UseVisualStyleBackColor = true;
            this.btnTimMHTheoNoiDung.Click += new System.EventHandler(this.btnTimMHTheoNoiDung_Click);
            // 
            // btnHienThiTatCa
            // 
            this.btnHienThiTatCa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThiTatCa.Location = new System.Drawing.Point(35, 285);
            this.btnHienThiTatCa.Name = "btnHienThiTatCa";
            this.btnHienThiTatCa.Size = new System.Drawing.Size(229, 39);
            this.btnHienThiTatCa.TabIndex = 0;
            this.btnHienThiTatCa.Text = "Hiển thông tin tất cả môn học";
            this.btnHienThiTatCa.UseVisualStyleBackColor = true;
            this.btnHienThiTatCa.Click += new System.EventHandler(this.btnHienThiTatCa_Click);
            // 
            // dtgvMH
            // 
            this.dtgvMH.AllowUserToAddRows = false;
            this.dtgvMH.AllowUserToDeleteRows = false;
            this.dtgvMH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvMH.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvMH.Location = new System.Drawing.Point(35, 330);
            this.dtgvMH.Name = "dtgvMH";
            this.dtgvMH.ReadOnly = true;
            this.dtgvMH.RowHeadersWidth = 51;
            this.dtgvMH.RowTemplate.Height = 24;
            this.dtgvMH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvMH.Size = new System.Drawing.Size(1102, 174);
            this.dtgvMH.TabIndex = 7;
            this.dtgvMH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvMH_CellContentClick);
            // 
            // btnXemDSSV
            // 
            this.btnXemDSSV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDSSV.Location = new System.Drawing.Point(422, 525);
            this.btnXemDSSV.Name = "btnXemDSSV";
            this.btnXemDSSV.Size = new System.Drawing.Size(154, 34);
            this.btnXemDSSV.TabIndex = 11;
            this.btnXemDSSV.Text = "DS Sinh viên";
            this.btnXemDSSV.UseVisualStyleBackColor = true;
            this.btnXemDSSV.Click += new System.EventHandler(this.btnXemDSSV_Click);
            // 
            // btnXemDSSVTheoKhoa
            // 
            this.btnXemDSSVTheoKhoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDSSVTheoKhoa.Location = new System.Drawing.Point(582, 525);
            this.btnXemDSSVTheoKhoa.Name = "btnXemDSSVTheoKhoa";
            this.btnXemDSSVTheoKhoa.Size = new System.Drawing.Size(165, 34);
            this.btnXemDSSVTheoKhoa.TabIndex = 12;
            this.btnXemDSSVTheoKhoa.Text = "DSSV theo Khoa";
            this.btnXemDSSVTheoKhoa.UseVisualStyleBackColor = true;
            this.btnXemDSSVTheoKhoa.Click += new System.EventHandler(this.btnXemDSSVTheoKhoa_Click);
            // 
            // btnDiem
            // 
            this.btnDiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiem.Location = new System.Drawing.Point(764, 525);
            this.btnDiem.Name = "btnDiem";
            this.btnDiem.Size = new System.Drawing.Size(131, 34);
            this.btnDiem.TabIndex = 13;
            this.btnDiem.Text = "Xem điểm";
            this.btnDiem.UseVisualStyleBackColor = true;
            this.btnDiem.Click += new System.EventHandler(this.btnDiem_Click);
            // 
            // btnXemDiemTheoMon
            // 
            this.btnXemDiemTheoMon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemDiemTheoMon.Location = new System.Drawing.Point(912, 525);
            this.btnXemDiemTheoMon.Name = "btnXemDiemTheoMon";
            this.btnXemDiemTheoMon.Size = new System.Drawing.Size(210, 34);
            this.btnXemDiemTheoMon.TabIndex = 14;
            this.btnXemDiemTheoMon.Text = "Xem điểm theo môn";
            this.btnXemDiemTheoMon.UseVisualStyleBackColor = true;
            this.btnXemDiemTheoMon.Click += new System.EventHandler(this.btnXemDiemTheoMon_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Location = new System.Drawing.Point(47, 525);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(93, 34);
            this.btnThemMoi.TabIndex = 1;
            this.btnThemMoi.Text = "Thêm mới";
            this.btnThemMoi.UseVisualStyleBackColor = true;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Enabled = false;
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(157, 525);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 34);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(249, 525);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 34);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(341, 525);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 34);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 170);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Số Tiết";
            // 
            // txtSoTiet
            // 
            this.txtSoTiet.Enabled = false;
            this.txtSoTiet.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTiet.Location = new System.Drawing.Point(173, 168);
            this.txtSoTiet.Name = "txtSoTiet";
            this.txtSoTiet.Size = new System.Drawing.Size(214, 27);
            this.txtSoTiet.TabIndex = 5;
            this.txtSoTiet.TextChanged += new System.EventHandler(this.txtSoTiet_TextChanged);
            // 
            // btnThongTinDiem
            // 
            this.btnThongTinDiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongTinDiem.Location = new System.Drawing.Point(764, 258);
            this.btnThongTinDiem.Name = "btnThongTinDiem";
            this.btnThongTinDiem.Size = new System.Drawing.Size(312, 57);
            this.btnThongTinDiem.TabIndex = 17;
            this.btnThongTinDiem.Text = "Thông tin về điểm số";
            this.btnThongTinDiem.UseVisualStyleBackColor = true;
            this.btnThongTinDiem.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 19);
            this.label8.TabIndex = 3;
            this.label8.Text = "Người hướng dẫn";
            // 
            // comboGiangVien
            // 
            this.comboGiangVien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGiangVien.FormattingEnabled = true;
            this.comboGiangVien.Location = new System.Drawing.Point(173, 208);
            this.comboGiangVien.Name = "comboGiangVien";
            this.comboGiangVien.Size = new System.Drawing.Size(214, 27);
            this.comboGiangVien.TabIndex = 18;
            this.comboGiangVien.SelectedIndexChanged += new System.EventHandler(this.comboGiangVien_SelectedIndexChanged);
            this.comboGiangVien.Click += new System.EventHandler(this.comboGiangVien_Click);
            // 
            // btnThemGiaoVien
            // 
            this.btnThemGiaoVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemGiaoVien.Location = new System.Drawing.Point(35, 241);
            this.btnThemGiaoVien.Name = "btnThemGiaoVien";
            this.btnThemGiaoVien.Size = new System.Drawing.Size(352, 39);
            this.btnThemGiaoVien.TabIndex = 19;
            this.btnThemGiaoVien.Text = "Thêm giáo viên mới";
            this.btnThemGiaoVien.UseVisualStyleBackColor = true;
            this.btnThemGiaoVien.Click += new System.EventHandler(this.btnThemGiaoVien_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangXuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangXuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangXuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Location = new System.Drawing.Point(839, 190);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(180, 45);
            this.btnDangXuat.TabIndex = 20;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnThemDuLieu
            // 
            this.btnThemDuLieu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemDuLieu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemDuLieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemDuLieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemDuLieu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThemDuLieu.ForeColor = System.Drawing.Color.White;
            this.btnThemDuLieu.Location = new System.Drawing.Point(487, 258);
            this.btnThemDuLieu.Name = "btnThemDuLieu";
            this.btnThemDuLieu.Size = new System.Drawing.Size(180, 45);
            this.btnThemDuLieu.TabIndex = 21;
            this.btnThemDuLieu.Text = "Cập nhật dữ liệu";
            this.btnThemDuLieu.Click += new System.EventHandler(this.btnThemDuLieu_Click);
            // 
            // AdminActionFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 583);
            this.Controls.Add(this.btnThemDuLieu);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnThemGiaoVien);
            this.Controls.Add(this.comboGiangVien);
            this.Controls.Add(this.btnThongTinDiem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnXemDiemTheoMon);
            this.Controls.Add(this.btnDiem);
            this.Controls.Add(this.btnXemDSSVTheoKhoa);
            this.Controls.Add(this.btnXemDSSV);
            this.Controls.Add(this.dtgvMH);
            this.Controls.Add(this.btnHienThiTatCa);
            this.Controls.Add(this.btnTimMHTheoNoiDung);
            this.Controls.Add(this.btnTimMHTheoMa);
            this.Controls.Add(this.comboMaMH);
            this.Controls.Add(this.txtSoTiet);
            this.Controls.Add(this.txtSoTinChi);
            this.Controls.Add(this.txtMH);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.txtMaMH);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminActionFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang quản trị viên";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.TextBox txtMH;
        private System.Windows.Forms.TextBox txtSoTinChi;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.ComboBox comboMaMH;
        private System.Windows.Forms.Button btnTimMHTheoMa;
        private System.Windows.Forms.Button btnTimMHTheoNoiDung;
        private System.Windows.Forms.Button btnHienThiTatCa;
        private System.Windows.Forms.DataGridView dtgvMH;
        private System.Windows.Forms.Button btnXemDSSV;
        private System.Windows.Forms.Button btnXemDSSVTheoKhoa;
        private System.Windows.Forms.Button btnDiem;
        private System.Windows.Forms.Button btnXemDiemTheoMon;
        private System.Windows.Forms.Button btnThemMoi;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoTiet;
        private System.Windows.Forms.Button btnThongTinDiem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboGiangVien;
        private System.Windows.Forms.Button btnThemGiaoVien;
        private Guna.UI2.WinForms.Guna2Button btnDangXuat;
        private Guna.UI2.WinForms.Guna2Button btnThemDuLieu;
    }
}