namespace QuanLyHocSinh
{
    partial class FrmTKB
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
            this.dgvTKB = new System.Windows.Forms.DataGridView();
            this.cbThu = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbthongtin = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbMMH = new System.Windows.Forms.ComboBox();
            this.cbTKT = new System.Windows.Forms.ComboBox();
            this.cbTBD = new System.Windows.Forms.ComboBox();
            this.lbltietkt = new System.Windows.Forms.Label();
            this.lbltietbd = new System.Windows.Forms.Label();
            this.cbMP = new System.Windows.Forms.ComboBox();
            this.lblmh = new System.Windows.Forms.Label();
            this.lblthu = new System.Windows.Forms.Label();
            this.lblphong = new System.Windows.Forms.Label();
            this.txtMGV = new System.Windows.Forms.TextBox();
            this.lblgv = new System.Windows.Forms.Label();
            this.lblmalop = new System.Windows.Forms.Label();
            this.txtMClass = new System.Windows.Forms.TextBox();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.gbTim = new System.Windows.Forms.GroupBox();
            this.lblTim = new System.Windows.Forms.Label();
            this.lbltkb = new System.Windows.Forms.Label();
            this.txtTKB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKB)).BeginInit();
            this.gbthongtin.SuspendLayout();
            this.gbTim.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTKB
            // 
            this.dgvTKB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTKB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTKB.Location = new System.Drawing.Point(12, 116);
            this.dgvTKB.Name = "dgvTKB";
            this.dgvTKB.RowHeadersWidth = 51;
            this.dgvTKB.RowTemplate.Height = 24;
            this.dgvTKB.Size = new System.Drawing.Size(971, 322);
            this.dgvTKB.TabIndex = 0;
            this.dgvTKB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTKB_CellClick);
            // 
            // cbThu
            // 
            this.cbThu.FormattingEnabled = true;
            this.cbThu.Items.AddRange(new object[] {
            "Thứ 2",
            "Thứ 3",
            "Thứ 4",
            "Thứ 5",
            "Thứ 6",
            "Thứ 7",
            "Chủ nhật"});
            this.cbThu.Location = new System.Drawing.Point(683, 85);
            this.cbThu.Name = "cbThu";
            this.cbThu.Size = new System.Drawing.Size(249, 27);
            this.cbThu.TabIndex = 8;
            this.cbThu.Text = "Thứ 2";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitle.Location = new System.Drawing.Point(279, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(421, 35);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "QUẢN LÝ THỜI KHOÁ BIỂU";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gbthongtin
            // 
            this.gbthongtin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbthongtin.Controls.Add(this.lbltkb);
            this.gbthongtin.Controls.Add(this.txtTKB);
            this.gbthongtin.Controls.Add(this.btnSave);
            this.gbthongtin.Controls.Add(this.btnHuy);
            this.gbthongtin.Controls.Add(this.btnXoa);
            this.gbthongtin.Controls.Add(this.btnEdit);
            this.gbthongtin.Controls.Add(this.btnAdd);
            this.gbthongtin.Controls.Add(this.cbMMH);
            this.gbthongtin.Controls.Add(this.cbTKT);
            this.gbthongtin.Controls.Add(this.cbTBD);
            this.gbthongtin.Controls.Add(this.lbltietkt);
            this.gbthongtin.Controls.Add(this.lbltietbd);
            this.gbthongtin.Controls.Add(this.cbMP);
            this.gbthongtin.Controls.Add(this.cbThu);
            this.gbthongtin.Controls.Add(this.lblmh);
            this.gbthongtin.Controls.Add(this.lblthu);
            this.gbthongtin.Controls.Add(this.lblphong);
            this.gbthongtin.Controls.Add(this.txtMGV);
            this.gbthongtin.Controls.Add(this.lblgv);
            this.gbthongtin.Controls.Add(this.lblmalop);
            this.gbthongtin.Controls.Add(this.txtMClass);
            this.gbthongtin.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbthongtin.Location = new System.Drawing.Point(12, 457);
            this.gbthongtin.Name = "gbthongtin";
            this.gbthongtin.Size = new System.Drawing.Size(971, 282);
            this.gbthongtin.TabIndex = 7;
            this.gbthongtin.TabStop = false;
            this.gbthongtin.Text = "Thông tin chi tiết";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(524, 230);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(621, 230);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 35);
            this.btnHuy.TabIndex = 15;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(432, 230);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 35);
            this.btnXoa.TabIndex = 13;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(341, 230);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 35);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(251, 230);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 35);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbMMH
            // 
            this.cbMMH.FormattingEnabled = true;
            this.cbMMH.Location = new System.Drawing.Point(132, 184);
            this.cbMMH.Name = "cbMMH";
            this.cbMMH.Size = new System.Drawing.Size(249, 27);
            this.cbMMH.TabIndex = 6;
            // 
            // cbTKT
            // 
            this.cbTKT.FormattingEnabled = true;
            this.cbTKT.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbTKT.Location = new System.Drawing.Point(683, 181);
            this.cbTKT.Name = "cbTKT";
            this.cbTKT.Size = new System.Drawing.Size(249, 27);
            this.cbTKT.TabIndex = 10;
            this.cbTKT.Text = "1";
            // 
            // cbTBD
            // 
            this.cbTBD.FormattingEnabled = true;
            this.cbTBD.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbTBD.Location = new System.Drawing.Point(683, 132);
            this.cbTBD.Name = "cbTBD";
            this.cbTBD.Size = new System.Drawing.Size(249, 27);
            this.cbTBD.TabIndex = 9;
            this.cbTBD.Text = "1";
            // 
            // lbltietkt
            // 
            this.lbltietkt.AutoSize = true;
            this.lbltietkt.Location = new System.Drawing.Point(545, 189);
            this.lbltietkt.Name = "lbltietkt";
            this.lbltietkt.Size = new System.Drawing.Size(64, 19);
            this.lbltietkt.TabIndex = 0;
            this.lbltietkt.Text = "Tiết KT:";
            // 
            // lbltietbd
            // 
            this.lbltietbd.AutoSize = true;
            this.lbltietbd.Location = new System.Drawing.Point(545, 140);
            this.lbltietbd.Name = "lbltietbd";
            this.lbltietbd.Size = new System.Drawing.Size(67, 19);
            this.lbltietbd.TabIndex = 0;
            this.lbltietbd.Text = "Tiết BD:";
            // 
            // cbMP
            // 
            this.cbMP.FormattingEnabled = true;
            this.cbMP.Location = new System.Drawing.Point(683, 31);
            this.cbMP.Name = "cbMP";
            this.cbMP.Size = new System.Drawing.Size(249, 27);
            this.cbMP.TabIndex = 7;
            // 
            // lblmh
            // 
            this.lblmh.AutoSize = true;
            this.lblmh.Location = new System.Drawing.Point(20, 192);
            this.lblmh.Name = "lblmh";
            this.lblmh.Size = new System.Drawing.Size(67, 19);
            this.lblmh.TabIndex = 0;
            this.lblmh.Text = "Mã MH:";
            // 
            // lblthu
            // 
            this.lblthu.AutoSize = true;
            this.lblthu.Location = new System.Drawing.Point(545, 93);
            this.lblthu.Name = "lblthu";
            this.lblthu.Size = new System.Drawing.Size(40, 19);
            this.lblthu.TabIndex = 0;
            this.lblthu.Text = "Thứ:";
            // 
            // lblphong
            // 
            this.lblphong.AutoSize = true;
            this.lblphong.Location = new System.Drawing.Point(545, 39);
            this.lblphong.Name = "lblphong";
            this.lblphong.Size = new System.Drawing.Size(81, 19);
            this.lblphong.TabIndex = 0;
            this.lblphong.Text = "Mã phòng:";
            // 
            // txtMGV
            // 
            this.txtMGV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMGV.Location = new System.Drawing.Point(132, 128);
            this.txtMGV.Multiline = true;
            this.txtMGV.Name = "txtMGV";
            this.txtMGV.Size = new System.Drawing.Size(249, 31);
            this.txtMGV.TabIndex = 5;
            // 
            // lblgv
            // 
            this.lblgv.AutoSize = true;
            this.lblgv.Location = new System.Drawing.Point(20, 140);
            this.lblgv.Name = "lblgv";
            this.lblgv.Size = new System.Drawing.Size(62, 19);
            this.lblgv.TabIndex = 0;
            this.lblgv.Text = "Mã GV:";
            // 
            // lblmalop
            // 
            this.lblmalop.AutoSize = true;
            this.lblmalop.Location = new System.Drawing.Point(20, 91);
            this.lblmalop.Name = "lblmalop";
            this.lblmalop.Size = new System.Drawing.Size(62, 19);
            this.lblmalop.TabIndex = 0;
            this.lblmalop.Text = "Mã lớp:";
            // 
            // txtMClass
            // 
            this.txtMClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMClass.Location = new System.Drawing.Point(132, 79);
            this.txtMClass.Multiline = true;
            this.txtMClass.Name = "txtMClass";
            this.txtMClass.Size = new System.Drawing.Size(249, 31);
            this.txtMClass.TabIndex = 4;
            // 
            // txtTim
            // 
            this.txtTim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTim.Location = new System.Drawing.Point(224, 18);
            this.txtTim.Multiline = true;
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(448, 31);
            this.txtTim.TabIndex = 1;
            // 
            // btnTim
            // 
            this.btnTim.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTim.Location = new System.Drawing.Point(710, 18);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(120, 30);
            this.btnTim.TabIndex = 2;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // gbTim
            // 
            this.gbTim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTim.Controls.Add(this.lblTim);
            this.gbTim.Controls.Add(this.txtTim);
            this.gbTim.Controls.Add(this.btnTim);
            this.gbTim.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTim.Location = new System.Drawing.Point(12, 52);
            this.gbTim.Name = "gbTim";
            this.gbTim.Size = new System.Drawing.Size(971, 58);
            this.gbTim.TabIndex = 5;
            this.gbTim.TabStop = false;
            this.gbTim.Text = "Tìm kiếm";
            // 
            // lblTim
            // 
            this.lblTim.AutoSize = true;
            this.lblTim.Location = new System.Drawing.Point(90, 24);
            this.lblTim.Name = "lblTim";
            this.lblTim.Size = new System.Drawing.Size(119, 19);
            this.lblTim.TabIndex = 0;
            this.lblTim.Text = "Mã lớp/Mã GV: ";
            // 
            // lbltkb
            // 
            this.lbltkb.AutoSize = true;
            this.lbltkb.Location = new System.Drawing.Point(20, 43);
            this.lbltkb.Name = "lbltkb";
            this.lbltkb.Size = new System.Drawing.Size(72, 19);
            this.lbltkb.TabIndex = 16;
            this.lbltkb.Text = "Mã TKB:";
            // 
            // txtTKB
            // 
            this.txtTKB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTKB.Location = new System.Drawing.Point(132, 31);
            this.txtTKB.Multiline = true;
            this.txtTKB.Name = "txtTKB";
            this.txtTKB.Size = new System.Drawing.Size(249, 31);
            this.txtTKB.TabIndex = 17;
            // 
            // FrmTKB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 751);
            this.Controls.Add(this.dgvTKB);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.gbthongtin);
            this.Controls.Add(this.gbTim);
            this.Name = "FrmTKB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTKB";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTKB)).EndInit();
            this.gbthongtin.ResumeLayout(false);
            this.gbthongtin.PerformLayout();
            this.gbTim.ResumeLayout(false);
            this.gbTim.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTKB;
        private System.Windows.Forms.ComboBox cbThu;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbthongtin;
        private System.Windows.Forms.Label lblmh;
        private System.Windows.Forms.Label lblthu;
        private System.Windows.Forms.Label lblphong;
        private System.Windows.Forms.TextBox txtMGV;
        private System.Windows.Forms.Label lblgv;
        private System.Windows.Forms.Label lblmalop;
        private System.Windows.Forms.TextBox txtMClass;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.GroupBox gbTim;
        private System.Windows.Forms.Label lblTim;
        private System.Windows.Forms.ComboBox cbMMH;
        private System.Windows.Forms.ComboBox cbTKT;
        private System.Windows.Forms.ComboBox cbTBD;
        private System.Windows.Forms.Label lbltietkt;
        private System.Windows.Forms.Label lbltietbd;
        private System.Windows.Forms.ComboBox cbMP;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbltkb;
        private System.Windows.Forms.TextBox txtTKB;
    }
}