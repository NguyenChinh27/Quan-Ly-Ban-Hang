namespace QLBH
{
    partial class UCSanPham
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtLoaiSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_hienthi = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.nud_soluong = new System.Windows.Forms.NumericUpDown();
            this.btn_timkiemTenSP = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_timkiemLoaiSP = new System.Windows.Forms.Button();
            this.btn_timkiemmaNCC = new System.Windows.Forms.Button();
            this.btn_timkiemgiaban = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_mancc = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hienthi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_soluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtLoaiSP
            // 
            this.txtLoaiSP.Location = new System.Drawing.Point(248, 139);
            this.txtLoaiSP.Name = "txtLoaiSP";
            this.txtLoaiSP.Size = new System.Drawing.Size(214, 20);
            this.txtLoaiSP.TabIndex = 54;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(248, 72);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(214, 20);
            this.txtMaSP.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(116, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 16);
            this.label5.TabIndex = 60;
            this.label5.Text = "Mã Nhà Cung Cấp : ";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(248, 105);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(214, 20);
            this.txtTenSP.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 59;
            this.label4.Text = "Loại Sản Phẩm : ";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(248, 251);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(175, 20);
            this.txtGiaBan.TabIndex = 53;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.SteelBlue;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(655, 195);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 38);
            this.btnXoa.TabIndex = 65;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 58;
            this.label3.Text = "Số Lượng : ";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(655, 141);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 38);
            this.btnSua.TabIndex = 64;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.SteelBlue;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(655, 90);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 38);
            this.btnThem.TabIndex = 63;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(116, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 57;
            this.label1.Text = "Tên Sản Phẩm : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(116, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 16);
            this.label8.TabIndex = 56;
            this.label8.Text = "Mã Sản Phẩm : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(326, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 25);
            this.label2.TabIndex = 62;
            this.label2.Text = "Quản Lý Sản Phẩm";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(236, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 1);
            this.panel1.TabIndex = 61;
            // 
            // dgv_hienthi
            // 
            this.dgv_hienthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hienthi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.LoaiSP,
            this.MaNCC,
            this.SoLuong,
            this.GiaBan});
            this.dgv_hienthi.Location = new System.Drawing.Point(48, 291);
            this.dgv_hienthi.Name = "dgv_hienthi";
            this.dgv_hienthi.Size = new System.Drawing.Size(779, 249);
            this.dgv_hienthi.TabIndex = 67;
            this.dgv_hienthi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hienthi_CellClick);
            this.dgv_hienthi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hienthi_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(116, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 68;
            this.label6.Text = "Giá Bán : ";
            // 
            // nud_soluong
            // 
            this.nud_soluong.Location = new System.Drawing.Point(248, 213);
            this.nud_soluong.Name = "nud_soluong";
            this.nud_soluong.Size = new System.Drawing.Size(47, 20);
            this.nud_soluong.TabIndex = 69;
            // 
            // btn_timkiemTenSP
            // 
            this.btn_timkiemTenSP.BackColor = System.Drawing.Color.White;
            this.btn_timkiemTenSP.FlatAppearance.BorderSize = 0;
            this.btn_timkiemTenSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timkiemTenSP.ForeColor = System.Drawing.Color.Transparent;
            this.btn_timkiemTenSP.Image = global::QLBH.Properties.Resources.icons8_search_20px;
            this.btn_timkiemTenSP.Location = new System.Drawing.Point(468, 101);
            this.btn_timkiemTenSP.Name = "btn_timkiemTenSP";
            this.btn_timkiemTenSP.Size = new System.Drawing.Size(34, 26);
            this.btn_timkiemTenSP.TabIndex = 50;
            this.btn_timkiemTenSP.UseVisualStyleBackColor = false;
            this.btn_timkiemTenSP.Click += new System.EventHandler(this.btn_timkiemTenSP_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.White;
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.ForeColor = System.Drawing.Color.Transparent;
            this.btn_reset.Image = global::QLBH.Properties.Resources.icons8_synchronize_40px;
            this.btn_reset.Location = new System.Drawing.Point(559, 141);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(37, 33);
            this.btn_reset.TabIndex = 66;
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_timkiemLoaiSP
            // 
            this.btn_timkiemLoaiSP.BackColor = System.Drawing.Color.White;
            this.btn_timkiemLoaiSP.FlatAppearance.BorderSize = 0;
            this.btn_timkiemLoaiSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timkiemLoaiSP.ForeColor = System.Drawing.Color.Transparent;
            this.btn_timkiemLoaiSP.Image = global::QLBH.Properties.Resources.icons8_search_20px;
            this.btn_timkiemLoaiSP.Location = new System.Drawing.Point(468, 136);
            this.btn_timkiemLoaiSP.Name = "btn_timkiemLoaiSP";
            this.btn_timkiemLoaiSP.Size = new System.Drawing.Size(34, 26);
            this.btn_timkiemLoaiSP.TabIndex = 70;
            this.btn_timkiemLoaiSP.UseVisualStyleBackColor = false;
            this.btn_timkiemLoaiSP.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_timkiemmaNCC
            // 
            this.btn_timkiemmaNCC.BackColor = System.Drawing.Color.White;
            this.btn_timkiemmaNCC.FlatAppearance.BorderSize = 0;
            this.btn_timkiemmaNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timkiemmaNCC.ForeColor = System.Drawing.Color.Transparent;
            this.btn_timkiemmaNCC.Image = global::QLBH.Properties.Resources.icons8_search_20px;
            this.btn_timkiemmaNCC.Location = new System.Drawing.Point(468, 172);
            this.btn_timkiemmaNCC.Name = "btn_timkiemmaNCC";
            this.btn_timkiemmaNCC.Size = new System.Drawing.Size(34, 26);
            this.btn_timkiemmaNCC.TabIndex = 71;
            this.btn_timkiemmaNCC.UseVisualStyleBackColor = false;
            this.btn_timkiemmaNCC.Click += new System.EventHandler(this.btn_timkiemtenNCC_Click);
            // 
            // btn_timkiemgiaban
            // 
            this.btn_timkiemgiaban.BackColor = System.Drawing.Color.White;
            this.btn_timkiemgiaban.FlatAppearance.BorderSize = 0;
            this.btn_timkiemgiaban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timkiemgiaban.ForeColor = System.Drawing.Color.Transparent;
            this.btn_timkiemgiaban.Image = global::QLBH.Properties.Resources.icons8_search_20px;
            this.btn_timkiemgiaban.Location = new System.Drawing.Point(468, 247);
            this.btn_timkiemgiaban.Name = "btn_timkiemgiaban";
            this.btn_timkiemgiaban.Size = new System.Drawing.Size(34, 26);
            this.btn_timkiemgiaban.TabIndex = 72;
            this.btn_timkiemgiaban.UseVisualStyleBackColor = false;
            this.btn_timkiemgiaban.Click += new System.EventHandler(this.btn_timkiemgiaban_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(429, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 74;
            this.label7.Text = "VNĐ";
            // 
            // cmb_mancc
            // 
            this.cmb_mancc.FormattingEnabled = true;
            this.cmb_mancc.Location = new System.Drawing.Point(249, 177);
            this.cmb_mancc.Name = "cmb_mancc";
            this.cmb_mancc.Size = new System.Drawing.Size(213, 21);
            this.cmb_mancc.TabIndex = 75;
            this.cmb_mancc.Click += new System.EventHandler(this.cmb_tenncc_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã Sản Phẩm";
            this.MaSP.Name = "MaSP";
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên Sản Phẩm";
            this.TenSP.Name = "TenSP";
            this.TenSP.Width = 140;
            // 
            // LoaiSP
            // 
            this.LoaiSP.DataPropertyName = "LoaiSP";
            this.LoaiSP.HeaderText = "Loại Sản Phẩm";
            this.LoaiSP.Name = "LoaiSP";
            this.LoaiSP.Width = 130;
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã Nhà Cung Cấp";
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.Width = 130;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá Bán";
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.Width = 150;
            // 
            // UCSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cmb_mancc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_timkiemgiaban);
            this.Controls.Add(this.btn_timkiemmaNCC);
            this.Controls.Add(this.btn_timkiemLoaiSP);
            this.Controls.Add(this.nud_soluong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgv_hienthi);
            this.Controls.Add(this.txtLoaiSP);
            this.Controls.Add(this.btn_timkiemTenSP);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "UCSanPham";
            this.Size = new System.Drawing.Size(883, 543);
            this.Load += new System.EventHandler(this.UCSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hienthi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_soluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLoaiSP;
        private System.Windows.Forms.Button btn_timkiemTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_hienthi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nud_soluong;
        private System.Windows.Forms.Button btn_timkiemLoaiSP;
        private System.Windows.Forms.Button btn_timkiemmaNCC;
        private System.Windows.Forms.Button btn_timkiemgiaban;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_mancc;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
    }
}
