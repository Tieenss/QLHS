namespace QuanLyHocSinh.Forms
{
    partial class FrmLichThi
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
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.dgvLichThi = new System.Windows.Forms.DataGridView();
            this.colMaLT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenKyThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGiamThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpDetail = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbGiamThi = new System.Windows.Forms.ComboBox();
            this.cbTenLop = new System.Windows.Forms.ComboBox();
            this.cbMonHoc = new System.Windows.Forms.ComboBox();
            this.cbMaPhong = new System.Windows.Forms.ComboBox();
            this.dtpGioKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpGioBatDau = new System.Windows.Forms.DateTimePicker();
            this.txtMaLT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKyThi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayThi = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichThi)).BeginInit();
            this.grpDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(984, 50);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ LỊCH THI";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.labelSearch);
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.btnShowAll);
            this.grpSearch.Location = new System.Drawing.Point(12, 50);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(960, 60);
            this.grpSearch.TabIndex = 1;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Tìm kiếm";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(200, 25);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(139, 16);
            this.labelSearch.TabIndex = 0;
            this.labelSearch.Text = "Nhập Môn hoặc Kỳ thi:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(350, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 23);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(620, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 27);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm Kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(710, 20);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(100, 27);
            this.btnShowAll.TabIndex = 3;
            this.btnShowAll.Text = "Xem Tất Cả";
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // dgvLichThi
            // 
            this.dgvLichThi.AllowUserToAddRows = false;
            this.dgvLichThi.AllowUserToDeleteRows = false;
            this.dgvLichThi.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvLichThi.ColumnHeadersHeight = 30;
            this.dgvLichThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaLT,
            this.colTenKyThi,
            this.colMaMH,
            this.colNgayThi,
            this.colGioBatDau,
            this.colGioKetThuc,
            this.colMaPhong,
            this.colGiamThi,
            this.colTenLop});
            this.dgvLichThi.Location = new System.Drawing.Point(12, 120);
            this.dgvLichThi.Name = "dgvLichThi";
            this.dgvLichThi.ReadOnly = true;
            this.dgvLichThi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichThi.Size = new System.Drawing.Size(960, 280);
            this.dgvLichThi.TabIndex = 2;
            this.dgvLichThi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichThi_CellClick);
            this.dgvLichThi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichThi_CellClick);
            // 
            // colMaLT
            // 
            this.colMaLT.DataPropertyName = "MaLT";
            this.colMaLT.HeaderText = "Mã LT";
            this.colMaLT.Name = "colMaLT";
            this.colMaLT.ReadOnly = true;
            this.colMaLT.Width = 70;
            // 
            // colTenKyThi
            // 
            this.colTenKyThi.DataPropertyName = "TenKyThi";
            this.colTenKyThi.HeaderText = "Kỳ Thi";
            this.colTenKyThi.Name = "colTenKyThi";
            this.colTenKyThi.ReadOnly = true;
            // 
            // colMaMH
            // 
            this.colMaMH.DataPropertyName = "MaMH";
            this.colMaMH.HeaderText = "Mã Môn";
            this.colMaMH.Name = "colMaMH";
            this.colMaMH.ReadOnly = true;
            // 
            // colNgayThi
            // 
            this.colNgayThi.DataPropertyName = "NgayThi";
            this.colNgayThi.HeaderText = "Ngày Thi";
            this.colNgayThi.Name = "colNgayThi";
            this.colNgayThi.ReadOnly = true;
            this.colNgayThi.Width = 125;
            // 
            // colGioBatDau
            // 
            this.colGioBatDau.DataPropertyName = "GioBatDau";
            this.colGioBatDau.HeaderText = "Bắt Đầu";
            this.colGioBatDau.Name = "colGioBatDau";
            this.colGioBatDau.ReadOnly = true;
            // 
            // colGioKetThuc
            // 
            this.colGioKetThuc.DataPropertyName = "GioKetThuc";
            this.colGioKetThuc.HeaderText = "Kết Thúc";
            this.colGioKetThuc.Name = "colGioKetThuc";
            this.colGioKetThuc.ReadOnly = true;
            // 
            // colMaPhong
            // 
            this.colMaPhong.DataPropertyName = "MaPhong";
            this.colMaPhong.HeaderText = "Phòng";
            this.colMaPhong.Name = "colMaPhong";
            this.colMaPhong.ReadOnly = true;
            // 
            // colGiamThi
            // 
            this.colGiamThi.DataPropertyName = "TenGiamThi";
            this.colGiamThi.HeaderText = "Giám Thị";
            this.colGiamThi.Name = "colGiamThi";
            this.colGiamThi.ReadOnly = true;
            this.colGiamThi.Width = 120;
            // 
            // colTenLop
            // 
            this.colTenLop.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTenLop.DataPropertyName = "TenLop";
            this.colTenLop.HeaderText = "Lớp Thi";
            this.colTenLop.Name = "colTenLop";
            this.colTenLop.ReadOnly = true;
            // 
            // grpDetail
            // 
            this.grpDetail.Controls.Add(this.label9);
            this.grpDetail.Controls.Add(this.label8);
            this.grpDetail.Controls.Add(this.cbGiamThi);
            this.grpDetail.Controls.Add(this.cbTenLop);
            this.grpDetail.Controls.Add(this.cbMonHoc);
            this.grpDetail.Controls.Add(this.cbMaPhong);
            this.grpDetail.Controls.Add(this.dtpGioKetThuc);
            this.grpDetail.Controls.Add(this.label1);
            this.grpDetail.Controls.Add(this.dtpGioBatDau);
            this.grpDetail.Controls.Add(this.txtMaLT);
            this.grpDetail.Controls.Add(this.label3);
            this.grpDetail.Controls.Add(this.label5);
            this.grpDetail.Controls.Add(this.label7);
            this.grpDetail.Controls.Add(this.label2);
            this.grpDetail.Controls.Add(this.cbKyThi);
            this.grpDetail.Controls.Add(this.label4);
            this.grpDetail.Controls.Add(this.dtpNgayThi);
            this.grpDetail.Location = new System.Drawing.Point(12, 410);
            this.grpDetail.Name = "grpDetail";
            this.grpDetail.Size = new System.Drawing.Size(960, 147);
            this.grpDetail.TabIndex = 3;
            this.grpDetail.TabStop = false;
            this.grpDetail.Text = "Thông tin chi tiết";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(465, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Giám Thị:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(473, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Lớp Thi:";
            // 
            // cbGiamThi
            // 
            this.cbGiamThi.FormattingEnabled = true;
            this.cbGiamThi.Location = new System.Drawing.Point(534, 111);
            this.cbGiamThi.Name = "cbGiamThi";
            this.cbGiamThi.Size = new System.Drawing.Size(194, 23);
            this.cbGiamThi.TabIndex = 16;
            // 
            // cbTenLop
            // 
            this.cbTenLop.FormattingEnabled = true;
            this.cbTenLop.Location = new System.Drawing.Point(534, 85);
            this.cbTenLop.Name = "cbTenLop";
            this.cbTenLop.Size = new System.Drawing.Size(194, 23);
            this.cbTenLop.TabIndex = 15;
            // 
            // cbMonHoc
            // 
            this.cbMonHoc.FormattingEnabled = true;
            this.cbMonHoc.Location = new System.Drawing.Point(140, 54);
            this.cbMonHoc.Name = "cbMonHoc";
            this.cbMonHoc.Size = new System.Drawing.Size(199, 23);
            this.cbMonHoc.TabIndex = 14;
            // 
            // cbMaPhong
            // 
            this.cbMaPhong.FormattingEnabled = true;
            this.cbMaPhong.Location = new System.Drawing.Point(140, 111);
            this.cbMaPhong.Name = "cbMaPhong";
            this.cbMaPhong.Size = new System.Drawing.Size(194, 23);
            this.cbMaPhong.TabIndex = 13;
            // 
            // dtpGioKetThuc
            // 
            this.dtpGioKetThuc.CustomFormat = "HH:mm";
            this.dtpGioKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGioKetThuc.Location = new System.Drawing.Point(218, 83);
            this.dtpGioKetThuc.Name = "dtpGioKetThuc";
            this.dtpGioKetThuc.ShowUpDown = true;
            this.dtpGioKetThuc.Size = new System.Drawing.Size(57, 23);
            this.dtpGioKetThuc.TabIndex = 11;
            this.dtpGioKetThuc.Value = new System.DateTime(2026, 1, 11, 21, 50, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã LT:";
            // 
            // dtpGioBatDau
            // 
            this.dtpGioBatDau.CustomFormat = "HH:mm";
            this.dtpGioBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGioBatDau.Location = new System.Drawing.Point(140, 83);
            this.dtpGioBatDau.Name = "dtpGioBatDau";
            this.dtpGioBatDau.ShowUpDown = true;
            this.dtpGioBatDau.Size = new System.Drawing.Size(59, 23);
            this.dtpGioBatDau.TabIndex = 10;
            this.dtpGioBatDau.Value = new System.DateTime(2026, 1, 11, 21, 50, 0, 0);
            // 
            // txtMaLT
            // 
            this.txtMaLT.Location = new System.Drawing.Point(140, 22);
            this.txtMaLT.Name = "txtMaLT";
            this.txtMaLT.ReadOnly = true;
            this.txtMaLT.Size = new System.Drawing.Size(300, 23);
            this.txtMaLT.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Môn :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giờ Bắt Đầu :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mã Phòng (FK):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Kỳ Thi:";
            // 
            // cbKyThi
            // 
            this.cbKyThi.Items.AddRange(new object[] {
            "Giữa Kỳ 1",
            "Cuối Kỳ 1",
            "Giữa Kỳ 2",
            "Cuối Kỳ 2"});
            this.cbKyThi.Location = new System.Drawing.Point(534, 22);
            this.cbKyThi.Name = "cbKyThi";
            this.cbKyThi.Size = new System.Drawing.Size(340, 23);
            this.cbKyThi.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ngày Thi (yyyy-mm-dd):";
            // 
            // dtpNgayThi
            // 
            this.dtpNgayThi.CustomFormat = "dd-MM-yyyy";
            this.dtpNgayThi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayThi.Location = new System.Drawing.Point(534, 56);
            this.dtpNgayThi.Name = "dtpNgayThi";
            this.dtpNgayThi.Size = new System.Drawing.Size(340, 23);
            this.dtpNgayThi.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(251, 563);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm Mới";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(361, 563);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 30);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(471, 563);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(581, 563);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 30);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Làm Mới";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnExport
            // 
            this.btnExport.ForeColor = System.Drawing.Color.Green;
            this.btnExport.Location = new System.Drawing.Point(691, 563);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 30);
            this.btnExport.TabIndex = 8;
            this.btnExport.Text = "Xuất Excel";
            this.btnExport.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 560);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 16);
            this.lblTotal.TabIndex = 9;
            // 
            // FrmLichThi
            // 
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.dgvLichThi);
            this.Controls.Add(this.grpDetail);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.lblTotal);
            this.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.Name = "FrmLichThi";
            this.Text = "Quản Lý Lịch Thi";
            this.Load += new System.EventHandler(this.FrmLichThi_Load);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichThi)).EndInit();
            this.grpDetail.ResumeLayout(false);
            this.grpDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.DataGridView dgvLichThi;
        private System.Windows.Forms.GroupBox grpDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaLT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKyThi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayThi;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DateTimePicker dtpGioBatDau;
        private System.Windows.Forms.DateTimePicker dtpGioKetThuc;
        private System.Windows.Forms.ComboBox cbMaPhong;
        private System.Windows.Forms.ComboBox cbGiamThi;
        private System.Windows.Forms.ComboBox cbTenLop;
        private System.Windows.Forms.ComboBox cbMonHoc;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKyThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGiamThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLop;
    }
}