namespace BaiKTcuoiky
{
    partial class FrmQuanlyHocphi
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
            this.grbTimkiem = new System.Windows.Forms.GroupBox();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbDanhsachHP = new System.Windows.Forms.GroupBox();
            this.dgvHocphi = new System.Windows.Forms.DataGridView();
            this.grbThongtin = new System.Windows.Forms.GroupBox();
            this.txtMaHP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTrangthai = new System.Windows.Forms.ComboBox();
            this.txtPhaidong = new System.Windows.Forms.TextBox();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.txtMiengiam = new System.Windows.Forms.TextBox();
            this.txtMhs = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTieude = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.MaHP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MienGiam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhaiDong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbTimkiem.SuspendLayout();
            this.grbDanhsachHP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocphi)).BeginInit();
            this.grbThongtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTimkiem
            // 
            this.grbTimkiem.Controls.Add(this.txtTimkiem);
            this.grbTimkiem.Controls.Add(this.btnTimkiem);
            this.grbTimkiem.Controls.Add(this.label7);
            this.grbTimkiem.Location = new System.Drawing.Point(8, 44);
            this.grbTimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.grbTimkiem.Name = "grbTimkiem";
            this.grbTimkiem.Padding = new System.Windows.Forms.Padding(2);
            this.grbTimkiem.Size = new System.Drawing.Size(1051, 42);
            this.grbTimkiem.TabIndex = 0;
            this.grbTimkiem.TabStop = false;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(180, 14);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(299, 20);
            this.txtTimkiem.TabIndex = 0;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(511, 14);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(59, 22);
            this.btnTimkiem.TabIndex = 1;
            this.btnTimkiem.Text = "Tìm Kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tìm kiếm:";
            // 
            // grbDanhsachHP
            // 
            this.grbDanhsachHP.Controls.Add(this.dgvHocphi);
            this.grbDanhsachHP.Location = new System.Drawing.Point(8, 90);
            this.grbDanhsachHP.Margin = new System.Windows.Forms.Padding(2);
            this.grbDanhsachHP.Name = "grbDanhsachHP";
            this.grbDanhsachHP.Padding = new System.Windows.Forms.Padding(2);
            this.grbDanhsachHP.Size = new System.Drawing.Size(1065, 374);
            this.grbDanhsachHP.TabIndex = 1;
            this.grbDanhsachHP.TabStop = false;
            this.grbDanhsachHP.Text = "Danh sách Học Phí";
            // 
            // dgvHocphi
            // 
            this.dgvHocphi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHocphi.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHocphi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHocphi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHP,
            this.MaHS,
            this.TongTien,
            this.MienGiam,
            this.PhaiDong,
            this.TrangThai});
            this.dgvHocphi.Location = new System.Drawing.Point(0, 16);
            this.dgvHocphi.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHocphi.Name = "dgvHocphi";
            this.dgvHocphi.RowHeadersWidth = 62;
            this.dgvHocphi.RowTemplate.Height = 28;
            this.dgvHocphi.Size = new System.Drawing.Size(1051, 358);
            this.dgvHocphi.TabIndex = 0;
            this.dgvHocphi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocphi_CellClick);
            this.dgvHocphi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHocphi_CellClick);
            // 
            // grbThongtin
            // 
            this.grbThongtin.Controls.Add(this.txtMaHP);
            this.grbThongtin.Controls.Add(this.label1);
            this.grbThongtin.Controls.Add(this.cboTrangthai);
            this.grbThongtin.Controls.Add(this.txtPhaidong);
            this.grbThongtin.Controls.Add(this.txtTongtien);
            this.grbThongtin.Controls.Add(this.txtMiengiam);
            this.grbThongtin.Controls.Add(this.txtMhs);
            this.grbThongtin.Controls.Add(this.label6);
            this.grbThongtin.Controls.Add(this.label5);
            this.grbThongtin.Controls.Add(this.label4);
            this.grbThongtin.Controls.Add(this.label3);
            this.grbThongtin.Controls.Add(this.label2);
            this.grbThongtin.Location = new System.Drawing.Point(8, 484);
            this.grbThongtin.Margin = new System.Windows.Forms.Padding(2);
            this.grbThongtin.Name = "grbThongtin";
            this.grbThongtin.Padding = new System.Windows.Forms.Padding(2);
            this.grbThongtin.Size = new System.Drawing.Size(1065, 116);
            this.grbThongtin.TabIndex = 2;
            this.grbThongtin.TabStop = false;
            this.grbThongtin.Text = "Thông tin chi tiết";
            // 
            // txtMaHP
            // 
            this.txtMaHP.Location = new System.Drawing.Point(117, 21);
            this.txtMaHP.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaHP.Name = "txtMaHP";
            this.txtMaHP.Size = new System.Drawing.Size(68, 20);
            this.txtMaHP.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã Học phí:";
            // 
            // cboTrangthai
            // 
            this.cboTrangthai.FormattingEnabled = true;
            this.cboTrangthai.Items.AddRange(new object[] {
            "Đã Đóng",
            "Chưa Đóng"});
            this.cboTrangthai.Location = new System.Drawing.Point(303, 23);
            this.cboTrangthai.Margin = new System.Windows.Forms.Padding(2);
            this.cboTrangthai.Name = "cboTrangthai";
            this.cboTrangthai.Size = new System.Drawing.Size(68, 21);
            this.cboTrangthai.TabIndex = 6;
            // 
            // txtPhaidong
            // 
            this.txtPhaidong.Location = new System.Drawing.Point(491, 51);
            this.txtPhaidong.Margin = new System.Windows.Forms.Padding(2);
            this.txtPhaidong.Name = "txtPhaidong";
            this.txtPhaidong.Size = new System.Drawing.Size(68, 20);
            this.txtPhaidong.TabIndex = 4;
            // 
            // txtTongtien
            // 
            this.txtTongtien.Location = new System.Drawing.Point(491, 21);
            this.txtTongtien.Margin = new System.Windows.Forms.Padding(2);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.Size = new System.Drawing.Size(68, 20);
            this.txtTongtien.TabIndex = 5;
            this.txtTongtien.TextChanged += new System.EventHandler(this.txtCalculate_TextChanged);
            // 
            // txtMiengiam
            // 
            this.txtMiengiam.Location = new System.Drawing.Point(303, 51);
            this.txtMiengiam.Margin = new System.Windows.Forms.Padding(2);
            this.txtMiengiam.Name = "txtMiengiam";
            this.txtMiengiam.Size = new System.Drawing.Size(68, 20);
            this.txtMiengiam.TabIndex = 2;
            this.txtMiengiam.TextChanged += new System.EventHandler(this.txtCalculate_TextChanged);
            // 
            // txtMhs
            // 
            this.txtMhs.Location = new System.Drawing.Point(117, 51);
            this.txtMhs.Margin = new System.Windows.Forms.Padding(2);
            this.txtMhs.Name = "txtMhs";
            this.txtMhs.Size = new System.Drawing.Size(68, 20);
            this.txtMhs.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Phải đóng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tổng tiền:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Trạng thái:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Miễn giảm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã học sinh:";
            // 
            // labelTieude
            // 
            this.labelTieude.AutoSize = true;
            this.labelTieude.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTieude.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelTieude.Location = new System.Drawing.Point(373, 12);
            this.labelTieude.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTieude.Name = "labelTieude";
            this.labelTieude.Size = new System.Drawing.Size(289, 30);
            this.labelTieude.TabIndex = 3;
            this.labelTieude.Text = "Hệ Thống Quản Lý Học Phí";
            this.labelTieude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTieude.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(243, 612);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(59, 20);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(350, 612);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(58, 20);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(460, 612);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(61, 20);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(674, 612);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(59, 20);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Làm mới";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(570, 612);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(57, 20);
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // MaHP
            // 
            this.MaHP.DataPropertyName = "MaHP";
            this.MaHP.FillWeight = 50F;
            this.MaHP.HeaderText = "Mã HP";
            this.MaHP.MinimumWidth = 8;
            this.MaHP.Name = "MaHP";
            // 
            // MaHS
            // 
            this.MaHS.DataPropertyName = "MaHS";
            this.MaHS.HeaderText = "Mã HS";
            this.MaHS.MinimumWidth = 8;
            this.MaHS.Name = "MaHS";
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.MinimumWidth = 8;
            this.TongTien.Name = "TongTien";
            // 
            // MienGiam
            // 
            this.MienGiam.DataPropertyName = "MienGiam";
            this.MienGiam.HeaderText = "Miễn Giảm";
            this.MienGiam.MinimumWidth = 8;
            this.MienGiam.Name = "MienGiam";
            // 
            // PhaiDong
            // 
            this.PhaiDong.DataPropertyName = "PhaiDong";
            this.PhaiDong.HeaderText = "Phải Đóng";
            this.PhaiDong.MinimumWidth = 8;
            this.PhaiDong.Name = "PhaiDong";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 8;
            this.TrangThai.Name = "TrangThai";
            // 
            // FrmQuanlyHocphi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.labelTieude);
            this.Controls.Add(this.grbThongtin);
            this.Controls.Add(this.grbDanhsachHP);
            this.Controls.Add(this.grbTimkiem);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmQuanlyHocphi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Học Phí";
            this.Load += new System.EventHandler(this.FrmQuanlyHocphi_Load);
            this.grbTimkiem.ResumeLayout(false);
            this.grbTimkiem.PerformLayout();
            this.grbDanhsachHP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocphi)).EndInit();
            this.grbThongtin.ResumeLayout(false);
            this.grbThongtin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTimkiem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grbDanhsachHP;
        private System.Windows.Forms.GroupBox grbThongtin;
        private System.Windows.Forms.Label labelTieude;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dgvHocphi;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPhaidong;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.TextBox txtMiengiam;
        private System.Windows.Forms.TextBox txtMhs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtMaHP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTrangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn MienGiam;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhaiDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
    }
}

