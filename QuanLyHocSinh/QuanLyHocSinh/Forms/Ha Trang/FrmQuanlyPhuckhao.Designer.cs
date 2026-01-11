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
            this.cboMaMH = new System.Windows.Forms.ComboBox();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grbDanhsachPK = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbTimkiem = new System.Windows.Forms.GroupBox();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhuckhao)).BeginInit();
            this.grbThongtin.SuspendLayout();
            this.grbDanhsachPK.SuspendLayout();
            this.grbTimkiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(180, 14);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(243, 20);
            this.txtTimkiem.TabIndex = 2;
            // 
            // txtLydo
            // 
            this.txtLydo.Location = new System.Drawing.Point(534, 18);
            this.txtLydo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLydo.Multiline = true;
            this.txtLydo.Name = "txtLydo";
            this.txtLydo.Size = new System.Drawing.Size(292, 60);
            this.txtLydo.TabIndex = 8;
            // 
            // txtMhs
            // 
            this.txtMhs.Location = new System.Drawing.Point(180, 19);
            this.txtMhs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMhs.Name = "txtMhs";
            this.txtMhs.Size = new System.Drawing.Size(235, 20);
            this.txtMhs.TabIndex = 5;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(445, 12);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Trạng thái:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(476, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Lý do:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã môn học:";
            // 
            // dgvPhuckhao
            // 
            this.dgvPhuckhao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhuckhao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhuckhao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHS,
            this.MaMH,
            this.TrangThai,
            this.LyDo});
            this.dgvPhuckhao.Location = new System.Drawing.Point(0, 16);
            this.dgvPhuckhao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPhuckhao.Name = "dgvPhuckhao";
            this.dgvPhuckhao.RowHeadersWidth = 62;
            this.dgvPhuckhao.RowTemplate.Height = 28;
            this.dgvPhuckhao.Size = new System.Drawing.Size(1052, 348);
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
            // 
            // MaMH
            // 
            this.MaMH.DataPropertyName = "MaMH";
            this.MaMH.HeaderText = "Mã MH";
            this.MaMH.MinimumWidth = 8;
            this.MaMH.Name = "MaMH";
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 8;
            this.TrangThai.Name = "TrangThai";
            // 
            // LyDo
            // 
            this.LyDo.DataPropertyName = "LyDo";
            this.LyDo.HeaderText = "Lý Do";
            this.LyDo.MinimumWidth = 8;
            this.LyDo.Name = "LyDo";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(691, 611);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(59, 20);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Làm mới";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(477, 611);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(56, 20);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(374, 611);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(53, 20);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(270, 611);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(56, 20);
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
            this.labelTieude.Location = new System.Drawing.Point(352, 26);
            this.labelTieude.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTieude.Name = "labelTieude";
            this.labelTieude.Size = new System.Drawing.Size(318, 30);
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
            this.grbThongtin.Location = new System.Drawing.Point(12, 502);
            this.grbThongtin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbThongtin.Name = "grbThongtin";
            this.grbThongtin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbThongtin.Size = new System.Drawing.Size(1052, 93);
            this.grbThongtin.TabIndex = 10;
            this.grbThongtin.TabStop = false;
            this.grbThongtin.Text = "Thông tin chi tiết";
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
            this.cboMaMH.Location = new System.Drawing.Point(180, 40);
            this.cboMaMH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboMaMH.Name = "cboMaMH";
            this.cboMaMH.Size = new System.Drawing.Size(235, 21);
            this.cboMaMH.TabIndex = 10;
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Chờ xử lý",
            "Đã xử lý"});
            this.cboTrangThai.Location = new System.Drawing.Point(180, 62);
            this.cboTrangThai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(235, 21);
            this.cboTrangThai.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã học sinh:";
            // 
            // grbDanhsachPK
            // 
            this.grbDanhsachPK.Controls.Add(this.dgvPhuckhao);
            this.grbDanhsachPK.Location = new System.Drawing.Point(12, 107);
            this.grbDanhsachPK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbDanhsachPK.Name = "grbDanhsachPK";
            this.grbDanhsachPK.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbDanhsachPK.Size = new System.Drawing.Size(1052, 386);
            this.grbDanhsachPK.TabIndex = 9;
            this.grbDanhsachPK.TabStop = false;
            this.grbDanhsachPK.Text = "Danh sách phúc khảo";
            // 
            // grbTimkiem
            // 
            this.grbTimkiem.Controls.Add(this.txtTimkiem);
            this.grbTimkiem.Controls.Add(this.btnTimkiem);
            this.grbTimkiem.Controls.Add(this.label7);
            this.grbTimkiem.Location = new System.Drawing.Point(12, 58);
            this.grbTimkiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbTimkiem.Name = "grbTimkiem";
            this.grbTimkiem.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbTimkiem.Size = new System.Drawing.Size(1052, 43);
            this.grbTimkiem.TabIndex = 8;
            this.grbTimkiem.TabStop = false;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(583, 611);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(51, 20);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // FrmQuanlyPhuckhao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 661);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.labelTieude);
            this.Controls.Add(this.grbThongtin);
            this.Controls.Add(this.grbDanhsachPK);
            this.Controls.Add(this.grbTimkiem);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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