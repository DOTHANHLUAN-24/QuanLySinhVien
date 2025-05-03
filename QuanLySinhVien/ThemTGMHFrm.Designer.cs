namespace QuanLySinhVien
{
    partial class ThemTGMHFrm
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
            this.dtgvMH = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnHienThiDTGV = new System.Windows.Forms.Button();
            this.txtMH = new System.Windows.Forms.TextBox();
            this.txtHoTenGV = new System.Windows.Forms.TextBox();
            this.txtSoTinChi = new System.Windows.Forms.TextBox();
            this.txtSoTiet = new System.Windows.Forms.TextBox();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRandomMaNhom = new System.Windows.Forms.Button();
            this.txtMaNhom = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboB1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboB2 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboB3 = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvMH
            // 
            this.dtgvMH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvMH.Location = new System.Drawing.Point(0, 390);
            this.dtgvMH.Name = "dtgvMH";
            this.dtgvMH.ReadOnly = true;
            this.dtgvMH.RowHeadersWidth = 51;
            this.dtgvMH.RowTemplate.Height = 24;
            this.dtgvMH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvMH.Size = new System.Drawing.Size(1106, 285);
            this.dtgvMH.TabIndex = 0;
            this.dtgvMH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Môn Học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Môn Học:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số Tín Chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số Tiết:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Họ Tên Giảng Viên:";
            // 
            // btnHienThiDTGV
            // 
            this.btnHienThiDTGV.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThiDTGV.Location = new System.Drawing.Point(25, 312);
            this.btnHienThiDTGV.Name = "btnHienThiDTGV";
            this.btnHienThiDTGV.Size = new System.Drawing.Size(217, 59);
            this.btnHienThiDTGV.TabIndex = 2;
            this.btnHienThiDTGV.Text = "Hiển thị dữ liệu";
            this.btnHienThiDTGV.UseVisualStyleBackColor = true;
            this.btnHienThiDTGV.Click += new System.EventHandler(this.btnHienThiDTGV_Click);
            // 
            // txtMH
            // 
            this.txtMH.BackColor = System.Drawing.SystemColors.Control;
            this.txtMH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMH.Location = new System.Drawing.Point(208, 97);
            this.txtMH.Name = "txtMH";
            this.txtMH.ReadOnly = true;
            this.txtMH.Size = new System.Drawing.Size(271, 27);
            this.txtMH.TabIndex = 3;
            // 
            // txtHoTenGV
            // 
            this.txtHoTenGV.BackColor = System.Drawing.SystemColors.Control;
            this.txtHoTenGV.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTenGV.Location = new System.Drawing.Point(208, 217);
            this.txtHoTenGV.Name = "txtHoTenGV";
            this.txtHoTenGV.ReadOnly = true;
            this.txtHoTenGV.Size = new System.Drawing.Size(271, 27);
            this.txtHoTenGV.TabIndex = 3;
            // 
            // txtSoTinChi
            // 
            this.txtSoTinChi.BackColor = System.Drawing.SystemColors.Control;
            this.txtSoTinChi.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTinChi.Location = new System.Drawing.Point(208, 137);
            this.txtSoTinChi.Name = "txtSoTinChi";
            this.txtSoTinChi.ReadOnly = true;
            this.txtSoTinChi.Size = new System.Drawing.Size(271, 27);
            this.txtSoTinChi.TabIndex = 3;
            // 
            // txtSoTiet
            // 
            this.txtSoTiet.BackColor = System.Drawing.SystemColors.Control;
            this.txtSoTiet.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTiet.Location = new System.Drawing.Point(208, 177);
            this.txtSoTiet.Name = "txtSoTiet";
            this.txtSoTiet.ReadOnly = true;
            this.txtSoTiet.Size = new System.Drawing.Size(271, 27);
            this.txtSoTiet.TabIndex = 3;
            // 
            // txtMaMH
            // 
            this.txtMaMH.BackColor = System.Drawing.SystemColors.Control;
            this.txtMaMH.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaMH.Location = new System.Drawing.Point(208, 57);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.ReadOnly = true;
            this.txtMaMH.Size = new System.Drawing.Size(271, 27);
            this.txtMaMH.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(621, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Mã Nhóm:";
            // 
            // btnRandomMaNhom
            // 
            this.btnRandomMaNhom.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandomMaNhom.Location = new System.Drawing.Point(831, 278);
            this.btnRandomMaNhom.Name = "btnRandomMaNhom";
            this.btnRandomMaNhom.Size = new System.Drawing.Size(208, 45);
            this.btnRandomMaNhom.TabIndex = 5;
            this.btnRandomMaNhom.Text = "Ngẫu nhiên mã nhóm";
            this.btnRandomMaNhom.UseVisualStyleBackColor = true;
            this.btnRandomMaNhom.Click += new System.EventHandler(this.btnRandomMaNhom_Click);
            // 
            // txtMaNhom
            // 
            this.txtMaNhom.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNhom.Location = new System.Drawing.Point(697, 341);
            this.txtMaNhom.Name = "txtMaNhom";
            this.txtMaNhom.ReadOnly = true;
            this.txtMaNhom.Size = new System.Drawing.Size(208, 22);
            this.txtMaNhom.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboB1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(545, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(267, 60);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buổi 1";
            // 
            // comboB1
            // 
            this.comboB1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboB1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboB1.FormattingEnabled = true;
            this.comboB1.Location = new System.Drawing.Point(7, 23);
            this.comboB1.Name = "comboB1";
            this.comboB1.Size = new System.Drawing.Size(254, 23);
            this.comboB1.TabIndex = 0;
            this.comboB1.SelectedIndexChanged += new System.EventHandler(this.comboB1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboB2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(818, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 60);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buổi 2";
            // 
            // comboB2
            // 
            this.comboB2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboB2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboB2.FormattingEnabled = true;
            this.comboB2.Location = new System.Drawing.Point(7, 23);
            this.comboB2.Name = "comboB2";
            this.comboB2.Size = new System.Drawing.Size(254, 23);
            this.comboB2.TabIndex = 0;
            this.comboB2.SelectedIndexChanged += new System.EventHandler(this.comboB2_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboB3);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(675, 198);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(267, 60);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buổi 3";
            // 
            // comboB3
            // 
            this.comboB3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboB3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboB3.FormattingEnabled = true;
            this.comboB3.Location = new System.Drawing.Point(7, 23);
            this.comboB3.Name = "comboB3";
            this.comboB3.Size = new System.Drawing.Size(254, 23);
            this.comboB3.TabIndex = 0;
            this.comboB3.SelectedIndexChanged += new System.EventHandler(this.comboB3_SelectedIndexChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(39, 23);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(39, 23);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 67);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(39, 23);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButton1);
            this.groupBox4.Controls.Add(this.radioButton3);
            this.groupBox4.Controls.Add(this.radioButton2);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(697, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(134, 100);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Số buổi / Tuần";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(578, 278);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(208, 45);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.button1_Click);
            // 
            // ThemTGMHFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 675);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMaNhom);
            this.Controls.Add(this.btnRandomMaNhom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaMH);
            this.Controls.Add(this.txtSoTiet);
            this.Controls.Add(this.txtSoTinChi);
            this.Controls.Add(this.txtHoTenGV);
            this.Controls.Add(this.txtMH);
            this.Controls.Add(this.btnHienThiDTGV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvMH);
            this.Name = "ThemTGMHFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemTGMHFrm";
            this.Load += new System.EventHandler(this.ThemTGMHFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvMH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHienThiDTGV;
        private System.Windows.Forms.TextBox txtMH;
        private System.Windows.Forms.TextBox txtHoTenGV;
        private System.Windows.Forms.TextBox txtSoTinChi;
        private System.Windows.Forms.TextBox txtSoTiet;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRandomMaNhom;
        private System.Windows.Forms.TextBox txtMaNhom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboB1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboB2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboB3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnLuu;
    }
}