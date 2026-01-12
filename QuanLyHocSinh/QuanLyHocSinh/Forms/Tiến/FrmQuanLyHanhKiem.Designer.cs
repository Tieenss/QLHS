namespace QuanLyHocSinh.Forms
{
    partial class FrmQuanLyHanhKiem
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpLoc = new System.Windows.Forms.GroupBox();
            this.btnLoc = new System.Windows.Forms.Button();
            this.cboLocHocKy = new System.Windows.Forms.ComboBox();
            this.lblLocHocKy = new System.Windows.Forms.Label();
            this.txtLocNamHoc = new System.Windows.Forms.TextBox();
            this.lblLocNamHoc = new System.Windows.Forms.Label();
            this.txtLocMaLop = new System.Windows.Forms.TextBox();
            this.lblLocMaLop = new System.Windows.Forms.Label();
            this.grpTimKiem = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.dgvHanhKiem = new System.Windows.Forms.DataGridView();
            this.colMaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNamHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXepLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhanXet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpCapNhat = new System.Windows.Forms.GroupBox();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtNhanXet = new System.Windows.Forms.TextBox();
            this.lblNhanXet = new System.Windows.Forms.Label();
            this.cboXepLoai = new System.Windows.Forms.ComboBox();
            this.lblXepLoai = new System.Windows.Forms.Label();
            this.txtTenHS = new System.Windows.Forms.TextBox();
            this.lblTenHS = new System.Windows.Forms.Label();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.lblMaHS = new System.Windows.Forms.Label();
            this.grpLoc.SuspendLayout();
            this.grpTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanhKiem)).BeginInit();
            this.grpCapNhat.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(738, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ HẠNH KIỂM";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpLoc
            // 
            this.grpLoc.Controls.Add(this.btnLoc);
            this.grpLoc.Controls.Add(this.cboLocHocKy);
            this.grpLoc.Controls.Add(this.lblLocHocKy);
            this.grpLoc.Controls.Add(this.txtLocNamHoc);
            this.grpLoc.Controls.Add(this.lblLocNamHoc);
            this.grpLoc.Controls.Add(this.txtLocMaLop);
            this.grpLoc.Controls.Add(this.lblLocMaLop);
            this.grpLoc.Location = new System.Drawing.Point(9, 43);
            this.grpLoc.Margin = new System.Windows.Forms.Padding(2);
            this.grpLoc.Name = "grpLoc";
            this.grpLoc.Padding = new System.Windows.Forms.Padding(2);
            this.grpLoc.Size = new System.Drawing.Size(720, 57);
            this.grpLoc.TabIndex = 1;
            this.grpLoc.TabStop = false;
            this.grpLoc.Text = "Lọc theo lớp (Mặc định)";
            // 
            // btnLoc
            // 
            this.btnLoc.Location = new System.Drawing.Point(615, 20);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(90, 24);
            this.btnLoc.TabIndex = 6;
            this.btnLoc.Text = "Lọc Danh Sách";
            this.btnLoc.UseVisualStyleBackColor = true;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // cboLocHocKy
            // 
            this.cboLocHocKy.FormattingEnabled = true;
            this.cboLocHocKy.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cboLocHocKy.Location = new System.Drawing.Point(502, 24);
            this.cboLocHocKy.Margin = new System.Windows.Forms.Padding(2);
            this.cboLocHocKy.Name = "cboLocHocKy";
            this.cboLocHocKy.Size = new System.Drawing.Size(61, 21);
            this.cboLocHocKy.TabIndex = 5;
            // 
            // lblLocHocKy
            // 
            this.lblLocHocKy.AutoSize = true;
            this.lblLocHocKy.Location = new System.Drawing.Point(458, 26);
            this.lblLocHocKy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocHocKy.Name = "lblLocHocKy";
            this.lblLocHocKy.Size = new System.Drawing.Size(45, 13);
            this.lblLocHocKy.TabIndex = 4;
            this.lblLocHocKy.Text = "Học Kỳ:";
            // 
            // txtLocNamHoc
            // 
            this.txtLocNamHoc.Location = new System.Drawing.Point(338, 24);
            this.txtLocNamHoc.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocNamHoc.Name = "txtLocNamHoc";
            this.txtLocNamHoc.Size = new System.Drawing.Size(91, 20);
            this.txtLocNamHoc.TabIndex = 3;
            // 
            // lblLocNamHoc
            // 
            this.lblLocNamHoc.AutoSize = true;
            this.lblLocNamHoc.Location = new System.Drawing.Point(281, 26);
            this.lblLocNamHoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocNamHoc.Name = "lblLocNamHoc";
            this.lblLocNamHoc.Size = new System.Drawing.Size(55, 13);
            this.lblLocNamHoc.TabIndex = 2;
            this.lblLocNamHoc.Text = "Năm Học:";
            // 
            // txtLocMaLop
            // 
            this.txtLocMaLop.Location = new System.Drawing.Point(172, 24);
            this.txtLocMaLop.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocMaLop.Name = "txtLocMaLop";
            this.txtLocMaLop.Size = new System.Drawing.Size(91, 20);
            this.txtLocMaLop.TabIndex = 1;
            // 
            // lblLocMaLop
            // 
            this.lblLocMaLop.AutoSize = true;
            this.lblLocMaLop.Location = new System.Drawing.Point(124, 26);
            this.lblLocMaLop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocMaLop.Name = "lblLocMaLop";
            this.lblLocMaLop.Size = new System.Drawing.Size(46, 13);
            this.lblLocMaLop.TabIndex = 0;
            this.lblLocMaLop.Text = "Mã Lớp:";
            // 
            // grpTimKiem
            // 
            this.grpTimKiem.Controls.Add(this.btnTimKiem);
            this.grpTimKiem.Controls.Add(this.txtTimKiem);
            this.grpTimKiem.Controls.Add(this.lblTimKiem);
            this.grpTimKiem.Location = new System.Drawing.Point(9, 105);
            this.grpTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.grpTimKiem.Name = "grpTimKiem";
            this.grpTimKiem.Padding = new System.Windows.Forms.Padding(2);
            this.grpTimKiem.Size = new System.Drawing.Size(720, 49);
            this.grpTimKiem.TabIndex = 2;
            this.grpTimKiem.TabStop = false;
            this.grpTimKiem.Text = "Tìm kiếm nhanh";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnTimKiem.Location = new System.Drawing.Point(465, 16);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 24);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(232, 20);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(211, 20);
            this.txtTimKiem.TabIndex = 1;
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(112, 22);
            this.lblTimKiem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(121, 13);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = "Nhập Tên hoặc Mã HS:";
            // 
            // dgvHanhKiem
            // 
            this.dgvHanhKiem.AllowUserToAddRows = false;
            this.dgvHanhKiem.AllowUserToDeleteRows = false;
            this.dgvHanhKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHanhKiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHS,
            this.colHoTen,
            this.colNamHoc,
            this.colHocKy,
            this.colXepLoai,
            this.colNhanXet});
            this.dgvHanhKiem.Location = new System.Drawing.Point(9, 158);
            this.dgvHanhKiem.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHanhKiem.Name = "dgvHanhKiem";
            this.dgvHanhKiem.ReadOnly = true;
            this.dgvHanhKiem.RowHeadersWidth = 51;
            this.dgvHanhKiem.RowTemplate.Height = 24;
            this.dgvHanhKiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHanhKiem.Size = new System.Drawing.Size(720, 203);
            this.dgvHanhKiem.TabIndex = 3;
            this.dgvHanhKiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHanhKiem_CellClick);
            // 
            // colMaHS
            // 
            this.colMaHS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colMaHS.DataPropertyName = "MaHS";
            this.colMaHS.HeaderText = "Mã HS";
            this.colMaHS.Name = "colMaHS";
            this.colMaHS.ReadOnly = true;
            this.colMaHS.Width = 65;
            // 
            // colHoTen
            // 
            this.colHoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.HeaderText = "Tên HS";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.ReadOnly = true;
            // 
            // colNamHoc
            // 
            this.colNamHoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colNamHoc.DataPropertyName = "NamHoc";
            this.colNamHoc.HeaderText = "Năm Học";
            this.colNamHoc.Name = "colNamHoc";
            this.colNamHoc.ReadOnly = true;
            this.colNamHoc.Width = 77;
            // 
            // colHocKy
            // 
            this.colHocKy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colHocKy.DataPropertyName = "HocKy";
            this.colHocKy.HeaderText = "Học Kỳ";
            this.colHocKy.Name = "colHocKy";
            this.colHocKy.ReadOnly = true;
            this.colHocKy.Width = 67;
            // 
            // colXepLoai
            // 
            this.colXepLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colXepLoai.DataPropertyName = "XepLoai";
            this.colXepLoai.HeaderText = "Xếp Loại";
            this.colXepLoai.Name = "colXepLoai";
            this.colXepLoai.ReadOnly = true;
            this.colXepLoai.Width = 74;
            // 
            // colNhanXet
            // 
            this.colNhanXet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNhanXet.DataPropertyName = "NhanXet";
            this.colNhanXet.HeaderText = "Nhận Xét";
            this.colNhanXet.Name = "colNhanXet";
            this.colNhanXet.ReadOnly = true;
            // 
            // grpCapNhat
            // 
            this.grpCapNhat.Controls.Add(this.btnXuatExcel);
            this.grpCapNhat.Controls.Add(this.btnLamMoi);
            this.grpCapNhat.Controls.Add(this.btnXoa);
            this.grpCapNhat.Controls.Add(this.btnLuu);
            this.grpCapNhat.Controls.Add(this.txtNhanXet);
            this.grpCapNhat.Controls.Add(this.lblNhanXet);
            this.grpCapNhat.Controls.Add(this.cboXepLoai);
            this.grpCapNhat.Controls.Add(this.lblXepLoai);
            this.grpCapNhat.Controls.Add(this.txtTenHS);
            this.grpCapNhat.Controls.Add(this.lblTenHS);
            this.grpCapNhat.Controls.Add(this.txtMaHS);
            this.grpCapNhat.Controls.Add(this.lblMaHS);
            this.grpCapNhat.Location = new System.Drawing.Point(9, 366);
            this.grpCapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.grpCapNhat.Name = "grpCapNhat";
            this.grpCapNhat.Padding = new System.Windows.Forms.Padding(2);
            this.grpCapNhat.Size = new System.Drawing.Size(720, 114);
            this.grpCapNhat.TabIndex = 4;
            this.grpCapNhat.TabStop = false;
            this.grpCapNhat.Text = "Cập nhật Hạnh Kiểm";
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.ForeColor = System.Drawing.Color.Green;
            this.btnXuatExcel.Location = new System.Drawing.Point(202, 77);
            this.btnXuatExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(82, 28);
            this.btnXuatExcel.TabIndex = 11;
            this.btnXuatExcel.Text = "Xuất Excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(472, 77);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(82, 28);
            this.btnLamMoi.TabIndex = 10;
            this.btnLamMoi.Text = "Làm Mới Form";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(390, 77);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 28);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(292, 77);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(90, 28);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu / Cập Nhật";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtNhanXet
            // 
            this.txtNhanXet.Location = new System.Drawing.Point(390, 46);
            this.txtNhanXet.Margin = new System.Windows.Forms.Padding(2);
            this.txtNhanXet.Name = "txtNhanXet";
            this.txtNhanXet.Size = new System.Drawing.Size(188, 20);
            this.txtNhanXet.TabIndex = 7;
            // 
            // lblNhanXet
            // 
            this.lblNhanXet.AutoSize = true;
            this.lblNhanXet.Location = new System.Drawing.Point(330, 48);
            this.lblNhanXet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNhanXet.Name = "lblNhanXet";
            this.lblNhanXet.Size = new System.Drawing.Size(55, 13);
            this.lblNhanXet.TabIndex = 6;
            this.lblNhanXet.Text = "Nhận Xét:";
            // 
            // cboXepLoai
            // 
            this.cboXepLoai.FormattingEnabled = true;
            this.cboXepLoai.Items.AddRange(new object[] {
            "Tốt",
            "Khá",
            "Trung Bình",
            "Yếu",
            "Chưa xếp loại"});
            this.cboXepLoai.Location = new System.Drawing.Point(262, 46);
            this.cboXepLoai.Margin = new System.Windows.Forms.Padding(2);
            this.cboXepLoai.Name = "cboXepLoai";
            this.cboXepLoai.Size = new System.Drawing.Size(61, 21);
            this.cboXepLoai.TabIndex = 5;
            // 
            // lblXepLoai
            // 
            this.lblXepLoai.AutoSize = true;
            this.lblXepLoai.Location = new System.Drawing.Point(210, 48);
            this.lblXepLoai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblXepLoai.Name = "lblXepLoai";
            this.lblXepLoai.Size = new System.Drawing.Size(52, 13);
            this.lblXepLoai.TabIndex = 4;
            this.lblXepLoai.Text = "Xếp Loại:";
            // 
            // txtTenHS
            // 
            this.txtTenHS.Location = new System.Drawing.Point(390, 19);
            this.txtTenHS.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenHS.Name = "txtTenHS";
            this.txtTenHS.ReadOnly = true;
            this.txtTenHS.Size = new System.Drawing.Size(188, 20);
            this.txtTenHS.TabIndex = 3;
            // 
            // lblTenHS
            // 
            this.lblTenHS.AutoSize = true;
            this.lblTenHS.Location = new System.Drawing.Point(330, 21);
            this.lblTenHS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTenHS.Name = "lblTenHS";
            this.lblTenHS.Size = new System.Drawing.Size(47, 13);
            this.lblTenHS.TabIndex = 2;
            this.lblTenHS.Text = "Tên HS:";
            // 
            // txtMaHS
            // 
            this.txtMaHS.Location = new System.Drawing.Point(262, 19);
            this.txtMaHS.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.Size = new System.Drawing.Size(61, 20);
            this.txtMaHS.TabIndex = 1;
            // 
            // lblMaHS
            // 
            this.lblMaHS.AutoSize = true;
            this.lblMaHS.Location = new System.Drawing.Point(210, 21);
            this.lblMaHS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaHS.Name = "lblMaHS";
            this.lblMaHS.Size = new System.Drawing.Size(43, 13);
            this.lblMaHS.TabIndex = 0;
            this.lblMaHS.Text = "Mã HS:";
            // 
            // FrmQuanLyHanhKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 496);
            this.Controls.Add(this.grpCapNhat);
            this.Controls.Add(this.dgvHanhKiem);
            this.Controls.Add(this.grpTimKiem);
            this.Controls.Add(this.grpLoc);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmQuanLyHanhKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Hạnh Kiểm";
            this.Load += new System.EventHandler(this.FrmQuanLyHanhKiem_Load);
            this.grpLoc.ResumeLayout(false);
            this.grpLoc.PerformLayout();
            this.grpTimKiem.ResumeLayout(false);
            this.grpTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanhKiem)).EndInit();
            this.grpCapNhat.ResumeLayout(false);
            this.grpCapNhat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpLoc;
        private System.Windows.Forms.Label lblLocMaLop;
        private System.Windows.Forms.TextBox txtLocMaLop;
        private System.Windows.Forms.Label lblLocNamHoc;
        private System.Windows.Forms.TextBox txtLocNamHoc;
        private System.Windows.Forms.Label lblLocHocKy;
        private System.Windows.Forms.ComboBox cboLocHocKy;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.GroupBox grpTimKiem;
        private System.Windows.Forms.Label lblTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvHanhKiem;
        private System.Windows.Forms.GroupBox grpCapNhat;
        private System.Windows.Forms.Label lblMaHS;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.Label lblTenHS;
        private System.Windows.Forms.TextBox txtTenHS;
        private System.Windows.Forms.Label lblXepLoai;
        private System.Windows.Forms.ComboBox cboXepLoai;
        private System.Windows.Forms.Label lblNhanXet;
        private System.Windows.Forms.TextBox txtNhanXet;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNamHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXepLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhanXet;
    }
}