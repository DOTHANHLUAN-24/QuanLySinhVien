namespace QuanLySinhVien
{
    partial class Controller_AdminFrm
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnThemGVMoi = new System.Windows.Forms.Button();
            this.btnThemSVMoi = new System.Windows.Forms.Button();
            this.btnThemTGMH = new System.Windows.Forms.Button();
            this.btnSuaSinhVien = new System.Windows.Forms.Button();
            this.btnSuaGV = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(0, 0);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(1054, 95);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Trang điều hướng";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThemGVMoi
            // 
            this.btnThemGVMoi.Location = new System.Drawing.Point(22, 139);
            this.btnThemGVMoi.Name = "btnThemGVMoi";
            this.btnThemGVMoi.Size = new System.Drawing.Size(181, 67);
            this.btnThemGVMoi.TabIndex = 1;
            this.btnThemGVMoi.Text = "Thêm giảng viên mới";
            this.btnThemGVMoi.UseVisualStyleBackColor = true;
            this.btnThemGVMoi.Click += new System.EventHandler(this.btnThemGVMoi_Click);
            // 
            // btnThemSVMoi
            // 
            this.btnThemSVMoi.Location = new System.Drawing.Point(209, 139);
            this.btnThemSVMoi.Name = "btnThemSVMoi";
            this.btnThemSVMoi.Size = new System.Drawing.Size(162, 67);
            this.btnThemSVMoi.TabIndex = 1;
            this.btnThemSVMoi.Text = "Thêm sinh viên mới";
            this.btnThemSVMoi.UseVisualStyleBackColor = true;
            this.btnThemSVMoi.Click += new System.EventHandler(this.btnThemSVMoi_Click);
            // 
            // btnThemTGMH
            // 
            this.btnThemTGMH.Location = new System.Drawing.Point(377, 139);
            this.btnThemTGMH.Name = "btnThemTGMH";
            this.btnThemTGMH.Size = new System.Drawing.Size(202, 67);
            this.btnThemTGMH.TabIndex = 1;
            this.btnThemTGMH.Text = "Thêm thời gian cho môn học";
            this.btnThemTGMH.UseVisualStyleBackColor = true;
            this.btnThemTGMH.Click += new System.EventHandler(this.btnThemTGMH_Click);
            // 
            // btnSuaSinhVien
            // 
            this.btnSuaSinhVien.Location = new System.Drawing.Point(585, 139);
            this.btnSuaSinhVien.Name = "btnSuaSinhVien";
            this.btnSuaSinhVien.Size = new System.Drawing.Size(214, 67);
            this.btnSuaSinhVien.TabIndex = 2;
            this.btnSuaSinhVien.Text = "Sửa thông tin về sinh viên";
            this.btnSuaSinhVien.UseVisualStyleBackColor = true;
            this.btnSuaSinhVien.Click += new System.EventHandler(this.btnSuaSinhVien_Click);
            // 
            // btnSuaGV
            // 
            this.btnSuaGV.Location = new System.Drawing.Point(805, 139);
            this.btnSuaGV.Name = "btnSuaGV";
            this.btnSuaGV.Size = new System.Drawing.Size(228, 67);
            this.btnSuaGV.TabIndex = 2;
            this.btnSuaGV.Text = "Sửa thông tin về giảng viên";
            this.btnSuaGV.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(349, 67);
            this.button1.TabIndex = 3;
            this.button1.Text = "Thêm thông tin về môn học";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Controller_AdminFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 395);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSuaGV);
            this.Controls.Add(this.btnSuaSinhVien);
            this.Controls.Add(this.btnThemTGMH);
            this.Controls.Add(this.btnThemSVMoi);
            this.Controls.Add(this.btnThemGVMoi);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Name = "Controller_AdminFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controller_Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.Button btnThemGVMoi;
        private System.Windows.Forms.Button btnThemSVMoi;
        private System.Windows.Forms.Button btnThemTGMH;
        private System.Windows.Forms.Button btnSuaSinhVien;
        private System.Windows.Forms.Button btnSuaGV;
        private System.Windows.Forms.Button button1;
    }
}