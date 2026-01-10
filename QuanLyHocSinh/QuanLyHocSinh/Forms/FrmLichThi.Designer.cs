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
            this.grpDetail = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaLT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaMH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGioBatDau = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbKyThi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgayThi = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGioKetThuc = new System.Windows.Forms.TextBox();
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
            this.dgvLichThi.ColumnHeadersHeight = 30;
            this.dgvLichThi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaLT,
            this.colTenKyThi,
            this.colMaMH,
            this.colNgayThi,
            this.colGioBatDau,
            this.colGioKetThuc,
            this.colMaPhong});
            this.dgvLichThi.Location = new System.Drawing.Point(12, 120);
            this.dgvLichThi.Name = "dgvLichThi";
            this.dgvLichThi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLichThi.Size = new System.Drawing.Size(960, 280);
            this.dgvLichThi.TabIndex = 2;
            this.dgvLichThi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLichThi_CellClick);
            // 
            // colMaLT
            // 
            this.colMaLT.DataPropertyName = "MaLT";
            this.colMaLT.HeaderText = "Mã LT";
            this.colMaLT.Name = "colMaLT";
            this.colMaLT.Width = 70;
            // 
            // colTenKyThi
            // 
            this.colTenKyThi.DataPropertyName = "TenKyThi";
            this.colTenKyThi.HeaderText = "Kỳ Thi";
            this.colTenKyThi.Name = "colTenKyThi";
            this.colTenKyThi.Width = 150;
            // 
            // colMaMH
            // 
            this.colMaMH.DataPropertyName = "MaMH";
            this.colMaMH.HeaderText = "Mã Môn";
            this.colMaMH.Name = "colMaMH";
            // 
            // colNgayThi
            // 
            this.colNgayThi.DataPropertyName = "NgayThi";
            this.colNgayThi.HeaderText = "Ngày Thi";
            this.colNgayThi.Name = "colNgayThi";
            this.colNgayThi.Width = 150;
            // 
            // colGioBatDau
            // 
            this.colGioBatDau.DataPropertyName = "GioBatDau";
            this.colGioBatDau.HeaderText = "Bắt Đầu";
            this.colGioBatDau.Name = "colGioBatDau";
            // 
            // colGioKetThuc
            // 
            this.colGioKetThuc.DataPropertyName = "GioKetThuc";
            this.colGioKetThuc.HeaderText = "Kết Thúc";
            this.colGioKetThuc.Name = "colGioKetThuc";
            // 
            // colMaPhong
            // 
            this.colMaPhong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colMaPhong.DataPropertyName = "MaPhong";
            this.colMaPhong.HeaderText = "Phòng";
            this.colMaPhong.Name = "colMaPhong";
            // 
            // grpDetail
            // 
            this.grpDetail.Controls.Add(this.label1);
            this.grpDetail.Controls.Add(this.txtMaLT);
            this.grpDetail.Controls.Add(this.label3);
            this.grpDetail.Controls.Add(this.txtMaMH);
            this.grpDetail.Controls.Add(this.label5);
            this.grpDetail.Controls.Add(this.txtGioBatDau);
            this.grpDetail.Controls.Add(this.label7);
            this.grpDetail.Controls.Add(this.txtMaPhong);
            this.grpDetail.Controls.Add(this.label2);
            this.grpDetail.Controls.Add(this.cbKyThi);
            this.grpDetail.Controls.Add(this.label4);
            this.grpDetail.Controls.Add(this.dtpNgayThi);
            this.grpDetail.Controls.Add(this.label6);
            this.grpDetail.Controls.Add(this.txtGioKetThuc);
            this.grpDetail.Location = new System.Drawing.Point(12, 410);
            this.grpDetail.Name = "grpDetail";
            this.grpDetail.Size = new System.Drawing.Size(960, 147);
            this.grpDetail.TabIndex = 3;
            this.grpDetail.TabStop = false;
            this.grpDetail.Text = "Thông tin chi tiết";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã LT:";
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
            this.label3.Location = new System.Drawing.Point(20, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Môn (FK):";
            // 
            // txtMaMH
            // 
            this.txtMaMH.Location = new System.Drawing.Point(140, 52);
            this.txtMaMH.Name = "txtMaMH";
            this.txtMaMH.Size = new System.Drawing.Size(300, 23);
            this.txtMaMH.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giờ Bắt Đầu (HH:mm):";
            // 
            // txtGioBatDau
            // 
            this.txtGioBatDau.Location = new System.Drawing.Point(140, 82);
            this.txtGioBatDau.Name = "txtGioBatDau";
            this.txtGioBatDau.Size = new System.Drawing.Size(300, 23);
            this.txtGioBatDau.TabIndex = 5;
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
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(140, 112);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(300, 23);
            this.txtMaPhong.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 25);
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
            this.cbKyThi.Location = new System.Drawing.Point(600, 22);
            this.cbKyThi.Name = "cbKyThi";
            this.cbKyThi.Size = new System.Drawing.Size(340, 23);
            this.cbKyThi.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(446, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ngày Thi (yyyy-mm-dd):";
            // 
            // dtpNgayThi
            // 
            this.dtpNgayThi.CustomFormat = "yyyy-MM-dd";
            this.dtpNgayThi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayThi.Location = new System.Drawing.Point(600, 52);
            this.dtpNgayThi.Name = "dtpNgayThi";
            this.dtpNgayThi.Size = new System.Drawing.Size(340, 23);
            this.dtpNgayThi.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(446, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Giờ Kết Thúc (HH:mm):";
            // 
            // txtGioKetThuc
            // 
            this.txtGioKetThuc.Location = new System.Drawing.Point(600, 82);
            this.txtGioKetThuc.Name = "txtGioKetThuc";
            this.txtGioKetThuc.Size = new System.Drawing.Size(340, 23);
            this.txtGioKetThuc.TabIndex = 13;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenKyThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhong;
        private System.Windows.Forms.GroupBox grpDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaLT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaMH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGioBatDau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbKyThi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgayThi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGioKetThuc;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblTotal;
    }
}