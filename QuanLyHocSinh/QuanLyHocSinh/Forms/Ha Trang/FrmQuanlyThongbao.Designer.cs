namespace BaiKTcuoiky
{
    partial class FrmQuanlyThongbao
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
            this.grbDanhsachTb = new System.Windows.Forms.GroupBox();
            this.dgvThongbao = new System.Windows.Forms.DataGridView();
            this.MaTB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TieuDe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NguoiGui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbTimkiem = new System.Windows.Forms.GroupBox();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNoidung = new System.Windows.Forms.TextBox();
            this.txtNguoigui = new System.Windows.Forms.TextBox();
            this.txtTieude = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.labelTieude = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grbThongtin = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaTB = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.grbDanhsachTb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongbao)).BeginInit();
            this.grbTimkiem.SuspendLayout();
            this.grbThongtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDanhsachTb
            // 
            this.grbDanhsachTb.Controls.Add(this.dgvThongbao);
            this.grbDanhsachTb.Location = new System.Drawing.Point(17, 94);
            this.grbDanhsachTb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbDanhsachTb.Name = "grbDanhsachTb";
            this.grbDanhsachTb.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbDanhsachTb.Size = new System.Drawing.Size(1026, 406);
            this.grbDanhsachTb.TabIndex = 17;
            this.grbDanhsachTb.TabStop = false;
            this.grbDanhsachTb.Text = "Danh sách thông báo";
            // 
            // dgvThongbao
            // 
            this.dgvThongbao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongbao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongbao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTB,
            this.TieuDe,
            this.NguoiGui,
            this.NoiDung});
            this.dgvThongbao.Location = new System.Drawing.Point(0, 16);
            this.dgvThongbao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvThongbao.Name = "dgvThongbao";
            this.dgvThongbao.RowHeadersWidth = 62;
            this.dgvThongbao.RowTemplate.Height = 28;
            this.dgvThongbao.Size = new System.Drawing.Size(1026, 386);
            this.dgvThongbao.TabIndex = 0;
            this.dgvThongbao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongbao_CellClick);
            this.dgvThongbao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongbao_CellClick);
            // 
            // MaTB
            // 
            this.MaTB.DataPropertyName = "MaTB";
            this.MaTB.HeaderText = "Mã TB";
            this.MaTB.MinimumWidth = 8;
            this.MaTB.Name = "MaTB";
            // 
            // TieuDe
            // 
            this.TieuDe.DataPropertyName = "TieuDe";
            this.TieuDe.HeaderText = "Tiêu Đề";
            this.TieuDe.MinimumWidth = 8;
            this.TieuDe.Name = "TieuDe";
            // 
            // NguoiGui
            // 
            this.NguoiGui.DataPropertyName = "NguoiGui";
            this.NguoiGui.HeaderText = "Người Gửi";
            this.NguoiGui.MinimumWidth = 8;
            this.NguoiGui.Name = "NguoiGui";
            // 
            // NoiDung
            // 
            this.NoiDung.DataPropertyName = "NoiDung";
            this.NoiDung.HeaderText = "Nội Dung";
            this.NoiDung.MinimumWidth = 8;
            this.NoiDung.Name = "NoiDung";
            // 
            // grbTimkiem
            // 
            this.grbTimkiem.Controls.Add(this.txtTimkiem);
            this.grbTimkiem.Controls.Add(this.btnTimkiem);
            this.grbTimkiem.Controls.Add(this.label7);
            this.grbTimkiem.Location = new System.Drawing.Point(17, 47);
            this.grbTimkiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbTimkiem.Name = "grbTimkiem";
            this.grbTimkiem.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbTimkiem.Size = new System.Drawing.Size(1026, 43);
            this.grbTimkiem.TabIndex = 16;
            this.grbTimkiem.TabStop = false;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(166, 14);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(396, 20);
            this.txtTimkiem.TabIndex = 0;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(578, 14);
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
            this.label7.Location = new System.Drawing.Point(99, 16);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tìm kiếm:";
            // 
            // txtNoidung
            // 
            this.txtNoidung.Location = new System.Drawing.Point(619, 17);
            this.txtNoidung.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNoidung.Multiline = true;
            this.txtNoidung.Name = "txtNoidung";
            this.txtNoidung.Size = new System.Drawing.Size(168, 62);
            this.txtNoidung.TabIndex = 4;
            // 
            // txtNguoigui
            // 
            this.txtNguoigui.Location = new System.Drawing.Point(180, 64);
            this.txtNguoigui.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNguoigui.Name = "txtNguoigui";
            this.txtNguoigui.Size = new System.Drawing.Size(276, 20);
            this.txtNguoigui.TabIndex = 3;
            // 
            // txtTieude
            // 
            this.txtTieude.Location = new System.Drawing.Point(180, 42);
            this.txtTieude.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTieude.Name = "txtTieude";
            this.txtTieude.Size = new System.Drawing.Size(276, 20);
            this.txtTieude.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(257, 611);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(59, 20);
            this.btnThem.TabIndex = 20;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // labelTieude
            // 
            this.labelTieude.AutoSize = true;
            this.labelTieude.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTieude.ForeColor = System.Drawing.Color.SteelBlue;
            this.labelTieude.Location = new System.Drawing.Point(357, 15);
            this.labelTieude.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTieude.Name = "labelTieude";
            this.labelTieude.Size = new System.Drawing.Size(320, 30);
            this.labelTieude.TabIndex = 19;
            this.labelTieude.Text = "Hệ Thống Quản Lý Thông Báo";
            this.labelTieude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(556, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nội dung:";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(471, 611);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(61, 20);
            this.btnXoa.TabIndex = 22;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(362, 611);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(58, 20);
            this.btnSua.TabIndex = 21;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Người gửi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tiêu đề:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(680, 611);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(59, 20);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Làm mới";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grbThongtin
            // 
            this.grbThongtin.Controls.Add(this.label1);
            this.grbThongtin.Controls.Add(this.txtMaTB);
            this.grbThongtin.Controls.Add(this.txtNoidung);
            this.grbThongtin.Controls.Add(this.txtNguoigui);
            this.grbThongtin.Controls.Add(this.txtTieude);
            this.grbThongtin.Controls.Add(this.label5);
            this.grbThongtin.Controls.Add(this.label3);
            this.grbThongtin.Controls.Add(this.label2);
            this.grbThongtin.Location = new System.Drawing.Point(17, 504);
            this.grbThongtin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbThongtin.Name = "grbThongtin";
            this.grbThongtin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbThongtin.Size = new System.Drawing.Size(1026, 103);
            this.grbThongtin.TabIndex = 18;
            this.grbThongtin.TabStop = false;
            this.grbThongtin.Text = "Thông tin chi tiết";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã TB:";
            // 
            // txtMaTB
            // 
            this.txtMaTB.Location = new System.Drawing.Point(180, 17);
            this.txtMaTB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaTB.Name = "txtMaTB";
            this.txtMaTB.Size = new System.Drawing.Size(276, 20);
            this.txtMaTB.TabIndex = 1;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(580, 611);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(55, 20);
            this.btnLuu.TabIndex = 24;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // FrmQuanlyThongbao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.grbDanhsachTb);
            this.Controls.Add(this.grbTimkiem);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.labelTieude);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grbThongtin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmQuanlyThongbao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thông Báo";
            this.Load += new System.EventHandler(this.FrmQuanlyThongbao_Load);
            this.grbDanhsachTb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongbao)).EndInit();
            this.grbTimkiem.ResumeLayout(false);
            this.grbTimkiem.PerformLayout();
            this.grbThongtin.ResumeLayout(false);
            this.grbThongtin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDanhsachTb;
        private System.Windows.Forms.DataGridView dgvThongbao;
        private System.Windows.Forms.GroupBox grbTimkiem;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNoidung;
        private System.Windows.Forms.TextBox txtNguoigui;
        private System.Windows.Forms.TextBox txtTieude;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label labelTieude;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grbThongtin;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TieuDe;
        private System.Windows.Forms.DataGridViewTextBoxColumn NguoiGui;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaTB;
    }
}