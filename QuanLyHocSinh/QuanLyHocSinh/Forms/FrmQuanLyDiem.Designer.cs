namespace QuanLyHocSinh.Forms
{
    partial class FrmQuanLyDiem
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
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cbHocKyFilter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMonFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLopFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.colMaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemMieng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiem15p = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiem1Tiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpUpdate = new System.Windows.Forms.GroupBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtDiemThi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDiem15p = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenHS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiem1Tiet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiemMieng = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.grpFilter.SuspendLayout();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.grpUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(984, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ ĐIỂM HỌC SINH";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.btnFilter);
            this.grpFilter.Controls.Add(this.cbHocKyFilter);
            this.grpFilter.Controls.Add(this.label3);
            this.grpFilter.Controls.Add(this.cbMonFilter);
            this.grpFilter.Controls.Add(this.label2);
            this.grpFilter.Controls.Add(this.txtLopFilter);
            this.grpFilter.Controls.Add(this.label1);
            this.grpFilter.Location = new System.Drawing.Point(12, 43);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(960, 60);
            this.grpFilter.TabIndex = 1;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Lọc theo lớp (Mặc định)";
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(733, 15);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 26);
            this.btnFilter.TabIndex = 6;
            this.btnFilter.Text = "Lọc";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cbHocKyFilter
            // 
            this.cbHocKyFilter.FormattingEnabled = true;
            this.cbHocKyFilter.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbHocKyFilter.Location = new System.Drawing.Point(630, 21);
            this.cbHocKyFilter.Name = "cbHocKyFilter";
            this.cbHocKyFilter.Size = new System.Drawing.Size(80, 24);
            this.cbHocKyFilter.TabIndex = 5;
            this.cbHocKyFilter.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(570, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Học Kỳ:";
            // 
            // cbMonFilter
            // 
            this.cbMonFilter.FormattingEnabled = true;
            this.cbMonFilter.Location = new System.Drawing.Point(400, 21);
            this.cbMonFilter.Name = "cbMonFilter";
            this.cbMonFilter.Size = new System.Drawing.Size(120, 24);
            this.cbMonFilter.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Môn:";
            // 
            // txtLopFilter
            // 
            this.txtLopFilter.Location = new System.Drawing.Point(200, 22);
            this.txtLopFilter.Name = "txtLopFilter";
            this.txtLopFilter.Size = new System.Drawing.Size(100, 22);
            this.txtLopFilter.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Lớp:";
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Controls.Add(this.label4);
            this.grpSearch.Location = new System.Drawing.Point(12, 109);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(960, 60);
            this.grpSearch.TabIndex = 2;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Tìm kiếm nhanh";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnSearch.Location = new System.Drawing.Point(610, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 26);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(350, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(250, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập Tên hoặc Mã HS:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dgvDiem
            // 
            this.dgvDiem.AllowUserToAddRows = false;
            this.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHS,
            this.colHoTen,
            this.colMaMH,
            this.colHocKy,
            this.colDiemMieng,
            this.colDiem15p,
            this.colDiem1Tiet,
            this.colDiemThi,
            this.colDiemTB});
            this.dgvDiem.Location = new System.Drawing.Point(12, 175);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.RowHeadersWidth = 51;
            this.dgvDiem.RowTemplate.Height = 24;
            this.dgvDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiem.Size = new System.Drawing.Size(960, 250);
            this.dgvDiem.TabIndex = 3;
            this.dgvDiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDiem_CellClick);
            // 
            // colMaHS
            // 
            this.colMaHS.DataPropertyName = "MaHS";
            this.colMaHS.HeaderText = "Mã HS";
            this.colMaHS.Name = "colMaHS";
            this.colMaHS.Width = 80;
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.HeaderText = "Họ Tên";
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Width = 150;
            // 
            // colMaMH
            // 
            this.colMaMH.DataPropertyName = "MaMH";
            this.colMaMH.HeaderText = "Môn";
            this.colMaMH.Name = "colMaMH";
            this.colMaMH.Width = 80;
            // 
            // colHocKy
            // 
            this.colHocKy.DataPropertyName = "HocKy";
            this.colHocKy.HeaderText = "HK";
            this.colHocKy.Name = "colHocKy";
            this.colHocKy.Width = 50;
            // 
            // colDiemMieng
            // 
            this.colDiemMieng.DataPropertyName = "DiemMieng";
            this.colDiemMieng.HeaderText = "Điểm Miệng";
            this.colDiemMieng.Name = "colDiemMieng";
            // 
            // colDiem15p
            // 
            this.colDiem15p.DataPropertyName = "Diem15p";
            this.colDiem15p.HeaderText = "15 Phút";
            this.colDiem15p.Name = "colDiem15p";
            // 
            // colDiem1Tiet
            // 
            this.colDiem1Tiet.DataPropertyName = "Diem1Tiet";
            this.colDiem1Tiet.HeaderText = "1 Tiết";
            this.colDiem1Tiet.Name = "colDiem1Tiet";
            // 
            // colDiemThi
            // 
            this.colDiemThi.DataPropertyName = "DiemThi";
            this.colDiemThi.HeaderText = "Điểm Thi";
            this.colDiemThi.Name = "colDiemThi";
            // 
            // colDiemTB
            // 
            this.colDiemTB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDiemTB.DataPropertyName = "DiemTB";
            this.colDiemTB.HeaderText = "Trung Bình";
            this.colDiemTB.Name = "colDiemTB";
            // 
            // grpUpdate
            // 
            this.grpUpdate.Controls.Add(this.btnExport);
            this.grpUpdate.Controls.Add(this.btnSave);
            this.grpUpdate.Controls.Add(this.txtDiemThi);
            this.grpUpdate.Controls.Add(this.label10);
            this.grpUpdate.Controls.Add(this.txtDiem15p);
            this.grpUpdate.Controls.Add(this.label9);
            this.grpUpdate.Controls.Add(this.txtTenHS);
            this.grpUpdate.Controls.Add(this.label8);
            this.grpUpdate.Controls.Add(this.txtDiem1Tiet);
            this.grpUpdate.Controls.Add(this.label7);
            this.grpUpdate.Controls.Add(this.txtDiemMieng);
            this.grpUpdate.Controls.Add(this.label6);
            this.grpUpdate.Controls.Add(this.txtMaHS);
            this.grpUpdate.Controls.Add(this.label5);
            this.grpUpdate.Location = new System.Drawing.Point(12, 440);
            this.grpUpdate.Name = "grpUpdate";
            this.grpUpdate.Size = new System.Drawing.Size(960, 110);
            this.grpUpdate.TabIndex = 4;
            this.grpUpdate.TabStop = false;
            this.grpUpdate.Text = "Cập nhật điểm";
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.Green;
            this.btnExport.Location = new System.Drawing.Point(550, 70);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(120, 30);
            this.btnExport.TabIndex = 13;
            this.btnExport.Text = "Xuất Excel";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(380, 70);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 30);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Lưu / Cập Nhật Điểm";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDiemThi
            // 
            this.txtDiemThi.Location = new System.Drawing.Point(600, 45);
            this.txtDiemThi.Name = "txtDiemThi";
            this.txtDiemThi.Size = new System.Drawing.Size(80, 22);
            this.txtDiemThi.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(530, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 16);
            this.label10.TabIndex = 10;
            this.label10.Text = "Điểm Thi:";
            // 
            // txtDiem15p
            // 
            this.txtDiem15p.Location = new System.Drawing.Point(600, 17);
            this.txtDiem15p.Name = "txtDiem15p";
            this.txtDiem15p.Size = new System.Drawing.Size(80, 22);
            this.txtDiem15p.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(530, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Điểm 15p:";
            // 
            // txtTenHS
            // 
            this.txtTenHS.Location = new System.Drawing.Point(67, 48);
            this.txtTenHS.Name = "txtTenHS";
            this.txtTenHS.ReadOnly = true;
            this.txtTenHS.Size = new System.Drawing.Size(284, 22);
            this.txtTenHS.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Họ Tên:";
            // 
            // txtDiem1Tiet
            // 
            this.txtDiem1Tiet.Location = new System.Drawing.Point(440, 42);
            this.txtDiem1Tiet.Name = "txtDiem1Tiet";
            this.txtDiem1Tiet.Size = new System.Drawing.Size(80, 22);
            this.txtDiem1Tiet.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(353, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Điểm 1 Tiết:";
            // 
            // txtDiemMieng
            // 
            this.txtDiemMieng.Location = new System.Drawing.Point(440, 17);
            this.txtDiemMieng.Name = "txtDiemMieng";
            this.txtDiemMieng.Size = new System.Drawing.Size(80, 22);
            this.txtDiemMieng.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Điểm Miệng:";
            // 
            // txtMaHS
            // 
            this.txtMaHS.Location = new System.Drawing.Point(63, 14);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.ReadOnly = true;
            this.txtMaHS.Size = new System.Drawing.Size(216, 22);
            this.txtMaHS.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã HS:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(820, 555);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 16);
            this.lblTotal.TabIndex = 5;
            // 
            // FrmQuanLyDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 570);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.grpUpdate);
            this.Controls.Add(this.dgvDiem);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmQuanLyDiem";
            this.Text = "Quản lý Điểm số";
            this.Load += new System.EventHandler(this.FrmQuanLyDiem_Load);
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.grpUpdate.ResumeLayout(false);
            this.grpUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cbHocKyFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMonFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLopFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDiem;
        private System.Windows.Forms.GroupBox grpUpdate;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtDiemThi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDiem15p;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenHS;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiem1Tiet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiemMieng;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemMieng;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiem15p;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiem1Tiet;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemTB;
    }
}