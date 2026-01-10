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
            this.grbDanhsachTb.Location = new System.Drawing.Point(25, 144);
            this.grbDanhsachTb.Name = "grbDanhsachTb";
            this.grbDanhsachTb.Size = new System.Drawing.Size(861, 182);
            this.grbDanhsachTb.TabIndex = 17;
            this.grbDanhsachTb.TabStop = false;
            this.grbDanhsachTb.Text = "Danh sách thông báo";
            // 
            // dgvThongbao
            // 
            this.dgvThongbao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongbao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTB,
            this.TieuDe,
            this.NguoiGui,
            this.NoiDung});
            this.dgvThongbao.Location = new System.Drawing.Point(0, 25);
            this.dgvThongbao.Name = "dgvThongbao";
            this.dgvThongbao.RowHeadersWidth = 62;
            this.dgvThongbao.RowTemplate.Height = 28;
            this.dgvThongbao.Size = new System.Drawing.Size(861, 150);
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
            this.MaTB.Width = 150;
            // 
            // TieuDe
            // 
            this.TieuDe.DataPropertyName = "TieuDe";
            this.TieuDe.HeaderText = "Tiêu Đề";
            this.TieuDe.MinimumWidth = 8;
            this.TieuDe.Name = "TieuDe";
            this.TieuDe.Width = 150;
            // 
            // NguoiGui
            // 
            this.NguoiGui.DataPropertyName = "NguoiGui";
            this.NguoiGui.HeaderText = "Người Gửi";
            this.NguoiGui.MinimumWidth = 8;
            this.NguoiGui.Name = "NguoiGui";
            this.NguoiGui.Width = 150;
            // 
            // NoiDung
            // 
            this.NoiDung.DataPropertyName = "NoiDung";
            this.NoiDung.HeaderText = "Nội Dung";
            this.NoiDung.MinimumWidth = 8;
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.Width = 150;
            // 
            // grbTimkiem
            // 
            this.grbTimkiem.Controls.Add(this.txtTimkiem);
            this.grbTimkiem.Controls.Add(this.btnTimkiem);
            this.grbTimkiem.Controls.Add(this.label7);
            this.grbTimkiem.Location = new System.Drawing.Point(25, 72);
            this.grbTimkiem.Name = "grbTimkiem";
            this.grbTimkiem.Size = new System.Drawing.Size(861, 66);
            this.grbTimkiem.TabIndex = 16;
            this.grbTimkiem.TabStop = false;
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(249, 22);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(374, 26);
            this.txtTimkiem.TabIndex = 0;
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
            this.label7.Location = new System.Drawing.Point(149, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tìm kiếm:";
            // 
            // txtNoidung
            // 
            this.txtNoidung.Location = new System.Drawing.Point(537, 32);
            this.txtNoidung.Multiline = true;
            this.txtNoidung.Name = "txtNoidung";
            this.txtNoidung.Size = new System.Drawing.Size(250, 93);
            this.txtNoidung.TabIndex = 4;
            // 
            // txtNguoigui
            // 
            this.txtNguoigui.Location = new System.Drawing.Point(270, 99);
            this.txtNguoigui.Name = "txtNguoigui";
            this.txtNguoigui.Size = new System.Drawing.Size(144, 26);
            this.txtNguoigui.TabIndex = 3;
            // 
            // txtTieude
            // 
            this.txtTieude.Location = new System.Drawing.Point(270, 64);
            this.txtTieude.Name = "txtTieude";
            this.txtTieude.Size = new System.Drawing.Size(144, 26);
            this.txtTieude.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(89, 491);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(88, 31);
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
            this.labelTieude.Location = new System.Drawing.Point(229, 24);
            this.labelTieude.Name = "labelTieude";
            this.labelTieude.Size = new System.Drawing.Size(470, 45);
            this.labelTieude.TabIndex = 19;
            this.labelTieude.Text = "Hệ Thống Quản Lý Thông Báo";
            this.labelTieude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(442, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nội dung:";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(409, 491);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 31);
            this.btnXoa.TabIndex = 22;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(246, 491);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(87, 31);
            this.btnSua.TabIndex = 21;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Người gửi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tiêu đề:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(723, 491);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 31);
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
            this.grbThongtin.Location = new System.Drawing.Point(25, 332);
            this.grbThongtin.Name = "grbThongtin";
            this.grbThongtin.Size = new System.Drawing.Size(861, 139);
            this.grbThongtin.TabIndex = 18;
            this.grbThongtin.TabStop = false;
            this.grbThongtin.Text = "Thông tin chi tiết";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã TB:";
            // 
            // txtMaTB
            // 
            this.txtMaTB.Location = new System.Drawing.Point(270, 26);
            this.txtMaTB.Name = "txtMaTB";
            this.txtMaTB.Size = new System.Drawing.Size(144, 26);
            this.txtMaTB.TabIndex = 1;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(573, 491);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(83, 31);
            this.btnLuu.TabIndex = 24;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // FrmQuanlyThongbao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 551);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.grbDanhsachTb);
            this.Controls.Add(this.grbTimkiem);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.labelTieude);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grbThongtin);
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