namespace QuanLyHocSinh.Forms
{
    partial class FrmQuanLyHanhKiem
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
            this.dgvHanhKiem = new System.Windows.Forms.DataGridView();
            this.colMaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNamHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colXepLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhanXet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMaHS = new System.Windows.Forms.Label();
            this.txtMaHS = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtTenHS = new System.Windows.Forms.TextBox();
            this.lblHocKy = new System.Windows.Forms.Label();
            this.cboHocKy = new System.Windows.Forms.ComboBox();
            this.lblNamHoc = new System.Windows.Forms.Label();
            this.txtNamHoc = new System.Windows.Forms.TextBox();
            this.lblXepLoai = new System.Windows.Forms.Label();
            this.cboXepLoai = new System.Windows.Forms.ComboBox();
            this.lblNhanXet = new System.Windows.Forms.Label();
            this.txtNhanXet = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanhKiem)).BeginInit();
            this.SuspendLayout();

            // 
            // dgvHanhKiem
            // 
            this.dgvHanhKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHanhKiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHS,
            this.colHoTen,
            this.colHocKy,
            this.colNamHoc,
            this.colXepLoai,
            this.colNhanXet});
            this.dgvHanhKiem.Location = new System.Drawing.Point(12, 200);
            this.dgvHanhKiem.Name = "dgvHanhKiem";
            this.dgvHanhKiem.RowHeadersWidth = 51;
            this.dgvHanhKiem.Size = new System.Drawing.Size(776, 238);
            this.dgvHanhKiem.TabIndex = 10;
            this.dgvHanhKiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHanhKiem_CellClick);

            // colMaHS
            this.colMaHS.DataPropertyName = "MaHS";
            this.colMaHS.HeaderText = "Mã HS";
            this.colMaHS.Name = "MaHS";

            // colHoTen
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.HeaderText = "Họ Tên";
            this.colHoTen.Name = "HoTen";
            this.colHoTen.Width = 150;

            // colHocKy
            this.colHocKy.DataPropertyName = "HocKy";
            this.colHocKy.HeaderText = "Học Kỳ";
            this.colHocKy.Name = "HocKy";

            // colNamHoc
            this.colNamHoc.DataPropertyName = "NamHoc";
            this.colNamHoc.HeaderText = "Năm Học";
            this.colNamHoc.Name = "NamHoc";

            // colXepLoai (Đã sửa DataPropertyName thành XepLoai)
            this.colXepLoai.DataPropertyName = "XepLoai";
            this.colXepLoai.HeaderText = "Xếp Loại";
            this.colXepLoai.Name = "XepLoai";

            // colNhanXet (Đã sửa DataPropertyName thành NhanXet)
            this.colNhanXet.DataPropertyName = "NhanXet";
            this.colNhanXet.HeaderText = "Nhận Xét";
            this.colNhanXet.Name = "NhanXet";
            this.colNhanXet.Width = 200;

            // Control Layout
            this.lblMaHS.Location = new System.Drawing.Point(30, 30);
            this.lblMaHS.Text = "Mã HS:";
            this.txtMaHS.Location = new System.Drawing.Point(100, 27);
            this.txtMaHS.Name = "txtMaHS";
            this.txtMaHS.Size = new System.Drawing.Size(150, 22);

            this.lblHoTen.Location = new System.Drawing.Point(30, 70);
            this.lblHoTen.Text = "Họ Tên:";
            this.txtTenHS.Location = new System.Drawing.Point(100, 67);
            this.txtTenHS.Name = "txtTenHS";
            this.txtTenHS.Size = new System.Drawing.Size(150, 22);
            this.txtTenHS.ReadOnly = true;

            this.lblHocKy.Location = new System.Drawing.Point(300, 30);
            this.lblHocKy.Text = "Học Kỳ:";
            this.cboHocKy.Location = new System.Drawing.Point(370, 27);
            this.cboHocKy.Name = "cboHocKy";
            this.cboHocKy.Size = new System.Drawing.Size(120, 24);
            this.cboHocKy.Items.AddRange(new object[] { "1", "2", "Hè" });

            this.lblNamHoc.Location = new System.Drawing.Point(300, 70);
            this.lblNamHoc.Text = "Năm Học:";
            this.txtNamHoc.Location = new System.Drawing.Point(370, 67);
            this.txtNamHoc.Name = "txtNamHoc";
            this.txtNamHoc.Size = new System.Drawing.Size(120, 22);

            this.lblXepLoai.Location = new System.Drawing.Point(530, 30);
            this.lblXepLoai.Text = "Xếp Loại:"; // Đổi label cho khớp
            this.cboXepLoai.Location = new System.Drawing.Point(600, 27);
            this.cboXepLoai.Name = "cboXepLoai"; // Đổi tên biến control
            this.cboXepLoai.Size = new System.Drawing.Size(140, 24);

            this.lblNhanXet.Location = new System.Drawing.Point(530, 70);
            this.lblNhanXet.Text = "Nhận Xét:"; // Đổi label cho khớp
            this.txtNhanXet.Location = new System.Drawing.Point(600, 67);
            this.txtNhanXet.Name = "txtNhanXet"; // Đổi tên biến control
            this.txtNhanXet.Size = new System.Drawing.Size(140, 22);

            // Buttons
            this.btnThem.Location = new System.Drawing.Point(100, 150);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            this.btnThem.Size = new System.Drawing.Size(75, 30);

            this.btnSua.Location = new System.Drawing.Point(200, 150);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            this.btnSua.Size = new System.Drawing.Size(75, 30);

            this.btnXoa.Location = new System.Drawing.Point(300, 150);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            this.btnXoa.Size = new System.Drawing.Size(75, 30);

            this.btnLamMoi.Location = new System.Drawing.Point(400, 150);
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            this.btnLamMoi.Size = new System.Drawing.Size(75, 30);

            this.txtTimKiem.Location = new System.Drawing.Point(550, 155);
            this.txtTimKiem.Size = new System.Drawing.Size(150, 22);

            this.btnTimKiem.Location = new System.Drawing.Point(710, 150);
            this.btnTimKiem.Text = "Tìm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            this.btnTimKiem.Size = new System.Drawing.Size(75, 30);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvHanhKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtNhanXet);
            this.Controls.Add(this.lblNhanXet);
            this.Controls.Add(this.cboXepLoai);
            this.Controls.Add(this.lblXepLoai);
            this.Controls.Add(this.txtNamHoc);
            this.Controls.Add(this.lblNamHoc);
            this.Controls.Add(this.cboHocKy);
            this.Controls.Add(this.lblHocKy);
            this.Controls.Add(this.txtTenHS);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.txtMaHS);
            this.Controls.Add(this.lblMaHS);
            this.Name = "FrmQuanLyHanhKiem";
            this.Text = "Quản Lý Hạnh Kiểm";
            this.Load += new System.EventHandler(this.FrmQuanLyHanhKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHanhKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHanhKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNamHoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colXepLoai; // Đổi tên biến
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhanXet; // Đổi tên biến
        private System.Windows.Forms.Label lblMaHS;
        private System.Windows.Forms.TextBox txtMaHS;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtTenHS;
        private System.Windows.Forms.Label lblHocKy;
        private System.Windows.Forms.ComboBox cboHocKy;
        private System.Windows.Forms.Label lblNamHoc;
        private System.Windows.Forms.TextBox txtNamHoc;
        private System.Windows.Forms.Label lblXepLoai;
        private System.Windows.Forms.ComboBox cboXepLoai; // Đổi tên biến
        private System.Windows.Forms.Label lblNhanXet;
        private System.Windows.Forms.TextBox txtNhanXet; // Đổi tên biến
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
    }
}