namespace BaiKTcuoiky
{
    partial class FrmQuanlyPhuckhao
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
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.txtLydo = new System.Windows.Forms.TextBox();
            this.txtMhs = new System.Windows.Forms.TextBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPhuckhao = new System.Windows.Forms.DataGridView();
            this.MaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.labelTieude = new System.Windows.Forms.Label();
            this.grbThongtin = new System.Windows.Forms.GroupBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grbDanhsachPK = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbTimkiem = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.cboMaMH = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuckhao)).BeginInit();
            this.grbThongtin.SuspendLayout();
            this.grbDanhsachPK.SuspendLayout();
            this.grbTimkiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(270, 22);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(362, 26);
            this.txtTimkiem.TabIndex = 2;
            // 
            // txtLydo
            // 
            this.txtLydo.Location = new System.Drawing.Point(539, 32);
            this.txtLydo.Multiline = true;
            this.txtLydo.Name = "txtLydo";
            this.txtLydo.Size = new System.Drawing.Size(250, 90);
            this.txtLydo.TabIndex = 8;
            // 
            // txtMhs
            // 
            this.txtMhs.Location = new System.Drawing.Point(270, 29);
            this.txtMhs.Name = "txtMhs";
            this.txtMhs.Size = new System.Drawing.Size(144, 26);
            this.txtMhs.TabIndex = 5;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(667, 18);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(89, 34);
            this.btnTimkiem.TabIndex = 1;
            this.btnTimkiem.Text = "Tìm Kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(172, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tìm kiếm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(149, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Trạng thái:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Lý do:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã môn học:";
            // 
            // dgvPhuckhao
            // 
            this.dgvPhuckhao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhuckhao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHS,
            this.MaMH,
            this.TrangThai,
            this.LyDo});
            this.dgvPhuckhao.Location = new System.Drawing.Point(0, 25);
            this.dgvPhuckhao.Name = "dgvPhuckhao";
            this.dgvPhuckhao.RowHeadersWidth = 62;
            this.dgvPhuckhao.RowTemplate.Height = 28;
            this.dgvPhuckhao.Size = new System.Drawing.Size(861, 138);
            this.dgvPhuckhao.TabIndex = 0;
            this.dgvPhuckhao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhuckhao_CellClick);
            this.dgvPhuckhao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhuckhao_CellClick);
            // 
            // MaHS
            // 
            this.MaHS.DataPropertyName = "MaHS";
            this.MaHS.HeaderText = "Mã HS";
            this.MaHS.MinimumWidth = 8;
            this.MaHS.Name = "MaHS";
            this.MaHS.Width = 150;
            // 
            // MaMH
            // 
            this.MaMH.DataPropertyName = "MaMH";
            this.MaMH.HeaderText = "Mã MH";
            this.MaMH.MinimumWidth = 8;
            this.MaMH.Name = "MaMH";
            this.MaMH.Width = 150;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 8;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Width = 150;
            // 
            // LyDo
            // 
            this.LyDo.DataPropertyName = "LyDo";
            this.LyDo.HeaderText = "Lý Do";
            this.LyDo.MinimumWidth = 8;
            this.LyDo.Name = "LyDo";
            this.LyDo.Width = 150;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(718, 465);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 31);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Làm mới";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(397, 465);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 31);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(243, 465);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(80, 31);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(87, 465);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 31);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // labelTieude
            // 
            this.labelTieude.AutoSize = true;
            this.labelTieude.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTieude.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelTieude.Location = new System.Drawing.Point(260, 23);
            this.labelTieude.Name = "labelTieude";
            this.labelTieude.Size = new System.Drawing.Size(465, 45);
            this.labelTieude.TabIndex = 11;
            this.labelTieude.Text = "Hệ Thống Quản Lý Phúc Khảo";
            this.labelTieude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbThongtin
            // 
            this.grbThongtin.Controls.Add(this.cboMaMH);
            this.grbThongtin.Controls.Add(this.cboTrangThai);
            this.grbThongtin.Controls.Add(this.txtLydo);
            this.grbThongtin.Controls.Add(this.txtMhs);
            this.grbThongtin.Controls.Add(this.label6);
            this.grbThongtin.Controls.Add(this.label5);
            this.grbThongtin.Controls.Add(this.label3);
            this.grbThongtin.Controls.Add(this.label2);
            this.grbThongtin.Location = new System.Drawing.Point(18, 316);
            this.grbThongtin.Name = "grbThongtin";
            this.grbThongtin.Size = new System.Drawing.Size(861, 143);
            this.grbThongtin.TabIndex = 10;
            this.grbThongtin.TabStop = false;
            this.grbThongtin.Text = "Thông tin chi tiết";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Chờ xử lý",
            "Đã xử lý"});
            this.cboTrangThai.Location = new System.Drawing.Point(270, 96);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(144, 28);
            this.cboTrangThai.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã học sinh:";
            // 
            // grbDanhsachPK
            // 
            this.grbDanhsachPK.Controls.Add(this.dgvPhuckhao);
            this.grbDanhsachPK.Location = new System.Drawing.Point(18, 143);
            this.grbDanhsachPK.Name = "grbDanhsachPK";
            this.grbDanhsachPK.Size = new System.Drawing.Size(861, 167);
            this.grbDanhsachPK.TabIndex = 9;
            this.grbDanhsachPK.TabStop = false;
            this.grbDanhsachPK.Text = "Danh sách phúc khảo";
            // 
            // grbTimkiem
            // 
            this.grbTimkiem.Controls.Add(this.txtTimkiem);
            this.grbTimkiem.Controls.Add(this.btnTimkiem);
            this.grbTimkiem.Controls.Add(this.label7);
            this.grbTimkiem.Location = new System.Drawing.Point(18, 71);
            this.grbTimkiem.Name = "grbTimkiem";
            this.grbTimkiem.Size = new System.Drawing.Size(861, 66);
            this.grbTimkiem.TabIndex = 8;
            this.grbTimkiem.TabStop = false;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(557, 465);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(76, 31);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // cboMaMH
            // 
            this.cboMaMH.FormattingEnabled = true;
            this.cboMaMH.Items.AddRange(new object[] {
            "TOAN",
            "LY",
            "HOA",
            "SINH",
            "VAN",
            "SU",
            "DIA",
            "ANH",
            "GDCD",
            "TIN",
            "THEDUC"});
            this.cboMaMH.Location = new System.Drawing.Point(270, 61);
            this.cboMaMH.Name = "cboMaMH";
            this.cboMaMH.Size = new System.Drawing.Size(144, 28);
            this.cboMaMH.TabIndex = 10;
            // 
            // FrmQuanlyPhuckhao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 523);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.labelTieude);
            this.Controls.Add(this.grbThongtin);
            this.Controls.Add(this.grbDanhsachPK);
            this.Controls.Add(this.grbTimkiem);
            this.Name = "FrmQuanlyPhuckhao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Phúc Khảo";
            this.Load += new System.EventHandler(this.FrmQuanlyPhuckhao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuckhao)).EndInit();
            this.grbThongtin.ResumeLayout(false);
            this.grbThongtin.PerformLayout();
            this.grbDanhsachPK.ResumeLayout(false);
            this.grbTimkiem.ResumeLayout(false);
            this.grbTimkiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.TextBox txtLydo;
        private System.Windows.Forms.TextBox txtMhs;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPhuckhao;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label labelTieude;
        private System.Windows.Forms.GroupBox grbThongtin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbDanhsachPK;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grbTimkiem;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.DataGridViewTextBoxColumn LyDo;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.ComboBox cboMaMH;
    }
}