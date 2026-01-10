namespace QuanLyHocSinh
{
    partial class FrmPhonghoc
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
            this.gbTim = new System.Windows.Forms.GroupBox();
            this.cbTinh = new System.Windows.Forms.ComboBox();
            this.lbltinhtrang = new System.Windows.Forms.Label();
            this.cbLoai = new System.Windows.Forms.ComboBox();
            this.lblloai = new System.Windows.Forms.Label();
            this.lblTim = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbthongtin = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbTinht = new System.Windows.Forms.ComboBox();
            this.cbLoaip = new System.Windows.Forms.ComboBox();
            this.txtSC = new System.Windows.Forms.TextBox();
            this.lblchua = new System.Windows.Forms.Label();
            this.lbltt = new System.Windows.Forms.Label();
            this.lbllp = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lbltenphong = new System.Windows.Forms.Label();
            this.lblmaphong = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.gbTim.SuspendLayout();
            this.gbthongtin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // gbTim
            // 
            this.gbTim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTim.Controls.Add(this.cbTinh);
            this.gbTim.Controls.Add(this.lbltinhtrang);
            this.gbTim.Controls.Add(this.cbLoai);
            this.gbTim.Controls.Add(this.lblloai);
            this.gbTim.Controls.Add(this.lblTim);
            this.gbTim.Controls.Add(this.txtTim);
            this.gbTim.Controls.Add(this.btnTim);
            this.gbTim.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTim.Location = new System.Drawing.Point(9, 48);
            this.gbTim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbTim.Name = "gbTim";
            this.gbTim.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbTim.Size = new System.Drawing.Size(697, 88);
            this.gbTim.TabIndex = 1;
            this.gbTim.TabStop = false;
            this.gbTim.Text = "Tìm kiếm";
            // 
            // cbTinh
            // 
            this.cbTinh.FormattingEnabled = true;
            this.cbTinh.Items.AddRange(new object[] {
            "Trống ",
            "Đang Học"});
            this.cbTinh.Location = new System.Drawing.Point(549, 17);
            this.cbTinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTinh.Name = "cbTinh";
            this.cbTinh.Size = new System.Drawing.Size(101, 24);
            this.cbTinh.TabIndex = 3;
            this.cbTinh.Text = "Trống ";
            // 
            // lbltinhtrang
            // 
            this.lbltinhtrang.AutoSize = true;
            this.lbltinhtrang.Location = new System.Drawing.Point(475, 20);
            this.lbltinhtrang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltinhtrang.Name = "lbltinhtrang";
            this.lbltinhtrang.Size = new System.Drawing.Size(70, 16);
            this.lbltinhtrang.TabIndex = 0;
            this.lbltinhtrang.Text = "Tình trạng:";
            // 
            // cbLoai
            // 
            this.cbLoai.FormattingEnabled = true;
            this.cbLoai.Items.AddRange(new object[] {
            "Lý Thuyết",
            "Thực Hành"});
            this.cbLoai.Location = new System.Drawing.Point(338, 17);
            this.cbLoai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbLoai.Name = "cbLoai";
            this.cbLoai.Size = new System.Drawing.Size(101, 24);
            this.cbLoai.TabIndex = 2;
            this.cbLoai.Text = "Lý Thuyết";
            // 
            // lblloai
            // 
            this.lblloai.AutoSize = true;
            this.lblloai.Location = new System.Drawing.Point(260, 20);
            this.lblloai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblloai.Name = "lblloai";
            this.lblloai.Size = new System.Drawing.Size(73, 16);
            this.lblloai.TabIndex = 0;
            this.lblloai.Text = "Loại phòng:";
            // 
            // lblTim
            // 
            this.lblTim.AutoSize = true;
            this.lblTim.Location = new System.Drawing.Point(34, 20);
            this.lblTim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTim.Name = "lblTim";
            this.lblTim.Size = new System.Drawing.Size(97, 16);
            this.lblTim.TabIndex = 0;
            this.lblTim.Text = "Mã/Tên phòng: ";
            // 
            // txtTim
            // 
            this.txtTim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTim.Location = new System.Drawing.Point(125, 14);
            this.txtTim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTim.Multiline = true;
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(101, 26);
            this.txtTim.TabIndex = 1;
            // 
            // btnTim
            // 
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTim.Location = new System.Drawing.Point(279, 58);
            this.btnTim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(158, 24);
            this.btnTim.TabIndex = 4;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitle.Location = new System.Drawing.Point(234, 17);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(276, 26);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "QUẢN LÝ PHÒNG HỌC";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbthongtin
            // 
            this.gbthongtin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbthongtin.Controls.Add(this.btnSave);
            this.gbthongtin.Controls.Add(this.btnHuy);
            this.gbthongtin.Controls.Add(this.btnXoa);
            this.gbthongtin.Controls.Add(this.btnEdit);
            this.gbthongtin.Controls.Add(this.btnAdd);
            this.gbthongtin.Controls.Add(this.cbTinht);
            this.gbthongtin.Controls.Add(this.cbLoaip);
            this.gbthongtin.Controls.Add(this.txtSC);
            this.gbthongtin.Controls.Add(this.lblchua);
            this.gbthongtin.Controls.Add(this.lbltt);
            this.gbthongtin.Controls.Add(this.lbllp);
            this.gbthongtin.Controls.Add(this.txtTen);
            this.gbthongtin.Controls.Add(this.lbltenphong);
            this.gbthongtin.Controls.Add(this.lblmaphong);
            this.gbthongtin.Controls.Add(this.txtMa);
            this.gbthongtin.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbthongtin.Location = new System.Drawing.Point(9, 377);
            this.gbthongtin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbthongtin.Name = "gbthongtin";
            this.gbthongtin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbthongtin.Size = new System.Drawing.Size(697, 179);
            this.gbthongtin.TabIndex = 3;
            this.gbthongtin.TabStop = false;
            this.gbthongtin.Text = "Thông tin chi tiết";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(397, 145);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 28);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(470, 145);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(56, 28);
            this.btnHuy.TabIndex = 15;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(328, 145);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(56, 28);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(260, 145);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(56, 28);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(192, 145);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 28);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbTinht
            // 
            this.cbTinht.FormattingEnabled = true;
            this.cbTinht.Items.AddRange(new object[] {
            "Trống ",
            "Đang Học"});
            this.cbTinht.Location = new System.Drawing.Point(490, 69);
            this.cbTinht.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTinht.Name = "cbTinht";
            this.cbTinht.Size = new System.Drawing.Size(177, 24);
            this.cbTinht.TabIndex = 10;
            this.cbTinht.Text = "Trống ";
            // 
            // cbLoaip
            // 
            this.cbLoaip.FormattingEnabled = true;
            this.cbLoaip.Items.AddRange(new object[] {
            "Lý Thuyết ",
            "Thực Hành"});
            this.cbLoaip.Location = new System.Drawing.Point(490, 28);
            this.cbLoaip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbLoaip.Name = "cbLoaip";
            this.cbLoaip.Size = new System.Drawing.Size(177, 24);
            this.cbLoaip.TabIndex = 9;
            this.cbLoaip.Text = "Lý Thuyết ";
            // 
            // txtSC
            // 
            this.txtSC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSC.Location = new System.Drawing.Point(106, 104);
            this.txtSC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSC.Multiline = true;
            this.txtSC.Name = "txtSC";
            this.txtSC.Size = new System.Drawing.Size(296, 26);
            this.txtSC.TabIndex = 8;
            // 
            // lblchua
            // 
            this.lblchua.AutoSize = true;
            this.lblchua.Location = new System.Drawing.Point(22, 114);
            this.lblchua.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblchua.Name = "lblchua";
            this.lblchua.Size = new System.Drawing.Size(65, 16);
            this.lblchua.TabIndex = 0;
            this.lblchua.Text = "Sức chứa:";
            // 
            // lbltt
            // 
            this.lbltt.AutoSize = true;
            this.lbltt.Location = new System.Drawing.Point(418, 72);
            this.lbltt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltt.Name = "lbltt";
            this.lbltt.Size = new System.Drawing.Size(74, 16);
            this.lbltt.TabIndex = 0;
            this.lbltt.Text = " Tình trạng:";
            // 
            // lbllp
            // 
            this.lbllp.AutoSize = true;
            this.lbllp.Location = new System.Drawing.Point(418, 32);
            this.lbllp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbllp.Name = "lbllp";
            this.lbllp.Size = new System.Drawing.Size(73, 16);
            this.lbllp.TabIndex = 0;
            this.lbllp.Text = "Loại phòng:";
            // 
            // txtTen
            // 
            this.txtTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTen.Location = new System.Drawing.Point(106, 62);
            this.txtTen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTen.Multiline = true;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(296, 26);
            this.txtTen.TabIndex = 7;
            // 
            // lbltenphong
            // 
            this.lbltenphong.AutoSize = true;
            this.lbltenphong.Location = new System.Drawing.Point(22, 72);
            this.lbltenphong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltenphong.Name = "lbltenphong";
            this.lbltenphong.Size = new System.Drawing.Size(71, 16);
            this.lbltenphong.TabIndex = 0;
            this.lbltenphong.Text = "Tên phòng:";
            // 
            // lblmaphong
            // 
            this.lblmaphong.AutoSize = true;
            this.lblmaphong.Location = new System.Drawing.Point(22, 32);
            this.lblmaphong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmaphong.Name = "lblmaphong";
            this.lblmaphong.Size = new System.Drawing.Size(67, 16);
            this.lblmaphong.TabIndex = 0;
            this.lblmaphong.Text = "Mã phòng:";
            // 
            // txtMa
            // 
            this.txtMa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMa.Location = new System.Drawing.Point(106, 22);
            this.txtMa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMa.Multiline = true;
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(296, 26);
            this.txtMa.TabIndex = 6;
            // 
            // dgvPhong
            // 
            this.dgvPhong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhong.Location = new System.Drawing.Point(9, 141);
            this.dgvPhong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPhong.Name = "dgvPhong";
            this.dgvPhong.RowHeadersWidth = 51;
            this.dgvPhong.RowTemplate.Height = 24;
            this.dgvPhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhong.Size = new System.Drawing.Size(697, 221);
            this.dgvPhong.TabIndex = 0;
            this.dgvPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhong_CellClick);
            // 
            // FrmPhonghoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 566);
            this.Controls.Add(this.gbTim);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbthongtin);
            this.Controls.Add(this.dgvPhong);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmPhonghoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPhonghoc";
            this.gbTim.ResumeLayout(false);
            this.gbTim.PerformLayout();
            this.gbthongtin.ResumeLayout(false);
            this.gbthongtin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTim;
        private System.Windows.Forms.Label lblTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbthongtin;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lbltenphong;
        private System.Windows.Forms.Label lblmaphong;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.DataGridView dgvPhong;
        private System.Windows.Forms.Label lbltinhtrang;
        private System.Windows.Forms.ComboBox cbLoai;
        private System.Windows.Forms.Label lblloai;
        private System.Windows.Forms.ComboBox cbTinh;
        private System.Windows.Forms.Label lblchua;
        private System.Windows.Forms.Label lbltt;
        private System.Windows.Forms.Label lbllp;
        private System.Windows.Forms.TextBox txtSC;
        private System.Windows.Forms.ComboBox cbLoaip;
        private System.Windows.Forms.ComboBox cbTinht;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
    }
}