namespace QLBH
{
    partial class UCHDBan
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
            this.cmb_masp = new System.Windows.Forms.ComboBox();
            this.cmb_manv = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_maKH = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nud_soluong = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgv_hienthi = new System.Windows.Forms.DataGridView();
            this.MaHDBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgp_ngayban = new System.Windows.Forms.DateTimePicker();
            this.btn_timkiemmanv = new System.Windows.Forms.Button();
            this.btn_timkiemgiaban = new System.Windows.Forms.Button();
            this.btn_timkiemngayban = new System.Windows.Forms.Button();
            this.btn_timkiemmaKH = new System.Windows.Forms.Button();
            this.btn_timkiemmaSP = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_soluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hienthi)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_masp
            // 
            this.cmb_masp.FormattingEnabled = true;
            this.cmb_masp.Location = new System.Drawing.Point(221, 76);
            this.cmb_masp.Name = "cmb_masp";
            this.cmb_masp.Size = new System.Drawing.Size(142, 21);
            this.cmb_masp.TabIndex = 120;
            this.cmb_masp.Click += new System.EventHandler(this.cmb_masp_Click);
            // 
            // cmb_manv
            // 
            this.cmb_manv.FormattingEnabled = true;
            this.cmb_manv.Location = new System.Drawing.Point(221, 110);
            this.cmb_manv.Name = "cmb_manv";
            this.cmb_manv.Size = new System.Drawing.Size(142, 21);
            this.cmb_manv.TabIndex = 118;
            this.cmb_manv.Click += new System.EventHandler(this.cmb_manv_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(88, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 16);
            this.label9.TabIndex = 117;
            this.label9.Text = "Mã Nhân Viên :";
            // 
            // cmb_maKH
            // 
            this.cmb_maKH.FormattingEnabled = true;
            this.cmb_maKH.Location = new System.Drawing.Point(221, 145);
            this.cmb_maKH.Name = "cmb_maKH";
            this.cmb_maKH.Size = new System.Drawing.Size(141, 21);
            this.cmb_maKH.TabIndex = 116;
            this.cmb_maKH.Click += new System.EventHandler(this.cmb_maKH_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(699, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 16);
            this.label7.TabIndex = 115;
            this.label7.Text = "VNĐ";
            // 
            // nud_soluong
            // 
            this.nud_soluong.Location = new System.Drawing.Point(543, 98);
            this.nud_soluong.Name = "nud_soluong";
            this.nud_soluong.Size = new System.Drawing.Size(47, 20);
            this.nud_soluong.TabIndex = 114;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(444, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 113;
            this.label6.Text = "Giá Bán: ";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(221, 45);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(142, 20);
            this.txtMaHD.TabIndex = 100;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(444, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 106;
            this.label5.Text = "Ngày Bán :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 105;
            this.label4.Text = "Mã SP :";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(543, 131);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(150, 20);
            this.txtGiaBan.TabIndex = 101;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.SteelBlue;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(508, 177);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 38);
            this.btnXoa.TabIndex = 111;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(444, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 104;
            this.label3.Text = "Số Lượng : ";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(369, 176);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 38);
            this.btnSua.TabIndex = 110;
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
            this.btnThem.Location = new System.Drawing.Point(234, 177);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 38);
            this.btnThem.TabIndex = 109;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 103;
            this.label1.Text = "Mã Khách Hàng :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(86, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 102;
            this.label8.Text = "Mã Hóa Đơn: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 108;
            this.label2.Text = "Hóa Đơn Bán";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(221, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 1);
            this.panel1.TabIndex = 107;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dgv_hienthi
            // 
            this.dgv_hienthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hienthi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHDBan,
            this.MaSP,
            this.MaNV,
            this.MaKH,
            this.NgayBan,
            this.SoLuong,
            this.GiaBan});
            this.dgv_hienthi.Location = new System.Drawing.Point(38, 225);
            this.dgv_hienthi.Name = "dgv_hienthi";
            this.dgv_hienthi.Size = new System.Drawing.Size(801, 255);
            this.dgv_hienthi.TabIndex = 121;
            this.dgv_hienthi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hienthi_CellClick);
            // 
            // MaHDBan
            // 
            this.MaHDBan.DataPropertyName = "MaHDBan";
            this.MaHDBan.HeaderText = "Mã Hóa Đơn";
            this.MaHDBan.Name = "MaHDBan";
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã Sản Phẩm";
            this.MaSP.Name = "MaSP";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.Name = "MaNV";
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã Khách Hàng";
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 120;
            // 
            // NgayBan
            // 
            this.NgayBan.DataPropertyName = "NgayBan";
            this.NgayBan.HeaderText = "Ngày Bán";
            this.NgayBan.Name = "NgayBan";
            this.NgayBan.Width = 130;
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
            // 
            // dgp_ngayban
            // 
            this.dgp_ngayban.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dgp_ngayban.Location = new System.Drawing.Point(523, 56);
            this.dgp_ngayban.Name = "dgp_ngayban";
            this.dgp_ngayban.Size = new System.Drawing.Size(150, 20);
            this.dgp_ngayban.TabIndex = 119;
            // 
            // btn_timkiemmanv
            // 
            this.btn_timkiemmanv.BackColor = System.Drawing.Color.White;
            this.btn_timkiemmanv.FlatAppearance.BorderSize = 0;
            this.btn_timkiemmanv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timkiemmanv.ForeColor = System.Drawing.Color.Transparent;
            this.btn_timkiemmanv.Image = global::QLBH.Properties.Resources.icons8_search_20px;
            this.btn_timkiemmanv.Location = new System.Drawing.Point(369, 107);
            this.btn_timkiemmanv.Name = "btn_timkiemmanv";
            this.btn_timkiemmanv.Size = new System.Drawing.Size(34, 26);
            this.btn_timkiemmanv.TabIndex = 126;
            this.btn_timkiemmanv.UseVisualStyleBackColor = false;
            this.btn_timkiemmanv.Click += new System.EventHandler(this.btn_timkiemmanv_Click);
            // 
            // btn_timkiemgiaban
            // 
            this.btn_timkiemgiaban.BackColor = System.Drawing.Color.White;
            this.btn_timkiemgiaban.FlatAppearance.BorderSize = 0;
            this.btn_timkiemgiaban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timkiemgiaban.ForeColor = System.Drawing.Color.Transparent;
            this.btn_timkiemgiaban.Image = global::QLBH.Properties.Resources.icons8_search_20px;
            this.btn_timkiemgiaban.Location = new System.Drawing.Point(741, 130);
            this.btn_timkiemgiaban.Name = "btn_timkiemgiaban";
            this.btn_timkiemgiaban.Size = new System.Drawing.Size(34, 26);
            this.btn_timkiemgiaban.TabIndex = 125;
            this.btn_timkiemgiaban.UseVisualStyleBackColor = false;
            this.btn_timkiemgiaban.Click += new System.EventHandler(this.btn_timkiemgiaban_Click);
            // 
            // btn_timkiemngayban
            // 
            this.btn_timkiemngayban.BackColor = System.Drawing.Color.White;
            this.btn_timkiemngayban.FlatAppearance.BorderSize = 0;
            this.btn_timkiemngayban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timkiemngayban.ForeColor = System.Drawing.Color.Transparent;
            this.btn_timkiemngayban.Image = global::QLBH.Properties.Resources.icons8_search_20px;
            this.btn_timkiemngayban.Location = new System.Drawing.Point(679, 51);
            this.btn_timkiemngayban.Name = "btn_timkiemngayban";
            this.btn_timkiemngayban.Size = new System.Drawing.Size(34, 26);
            this.btn_timkiemngayban.TabIndex = 124;
            this.btn_timkiemngayban.UseVisualStyleBackColor = false;
            this.btn_timkiemngayban.Click += new System.EventHandler(this.btn_timkiemngayban_Click);
            // 
            // btn_timkiemmaKH
            // 
            this.btn_timkiemmaKH.BackColor = System.Drawing.Color.White;
            this.btn_timkiemmaKH.FlatAppearance.BorderSize = 0;
            this.btn_timkiemmaKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timkiemmaKH.ForeColor = System.Drawing.Color.Transparent;
            this.btn_timkiemmaKH.Image = global::QLBH.Properties.Resources.icons8_search_20px;
            this.btn_timkiemmaKH.Location = new System.Drawing.Point(368, 142);
            this.btn_timkiemmaKH.Name = "btn_timkiemmaKH";
            this.btn_timkiemmaKH.Size = new System.Drawing.Size(34, 26);
            this.btn_timkiemmaKH.TabIndex = 123;
            this.btn_timkiemmaKH.UseVisualStyleBackColor = false;
            this.btn_timkiemmaKH.Click += new System.EventHandler(this.btn_timkiemmaKH_Click);
            // 
            // btn_timkiemmaSP
            // 
            this.btn_timkiemmaSP.BackColor = System.Drawing.Color.White;
            this.btn_timkiemmaSP.FlatAppearance.BorderSize = 0;
            this.btn_timkiemmaSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timkiemmaSP.ForeColor = System.Drawing.Color.Transparent;
            this.btn_timkiemmaSP.Image = global::QLBH.Properties.Resources.icons8_search_20px;
            this.btn_timkiemmaSP.Location = new System.Drawing.Point(369, 73);
            this.btn_timkiemmaSP.Name = "btn_timkiemmaSP";
            this.btn_timkiemmaSP.Size = new System.Drawing.Size(34, 26);
            this.btn_timkiemmaSP.TabIndex = 122;
            this.btn_timkiemmaSP.UseVisualStyleBackColor = false;
            this.btn_timkiemmaSP.Click += new System.EventHandler(this.btn_timkiemmaSP_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.White;
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.ForeColor = System.Drawing.Color.Transparent;
            this.btn_reset.Image = global::QLBH.Properties.Resources.icons8_synchronize_40px;
            this.btn_reset.Location = new System.Drawing.Point(636, 179);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(37, 33);
            this.btn_reset.TabIndex = 112;
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // UCHDBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_timkiemmanv);
            this.Controls.Add(this.btn_timkiemgiaban);
            this.Controls.Add(this.btn_timkiemngayban);
            this.Controls.Add(this.btn_timkiemmaKH);
            this.Controls.Add(this.btn_timkiemmaSP);
            this.Controls.Add(this.dgv_hienthi);
            this.Controls.Add(this.cmb_masp);
            this.Controls.Add(this.dgp_ngayban);
            this.Controls.Add(this.cmb_manv);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmb_maKH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nud_soluong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label5);
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
            this.Name = "UCHDBan";
            this.Size = new System.Drawing.Size(883, 480);
            this.Load += new System.EventHandler(this.UCHDBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_soluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hienthi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_masp;
        private System.Windows.Forms.ComboBox cmb_manv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_maKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nud_soluong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgv_hienthi;
        private System.Windows.Forms.Button btn_timkiemmanv;
        private System.Windows.Forms.Button btn_timkiemgiaban;
        private System.Windows.Forms.Button btn_timkiemngayban;
        private System.Windows.Forms.Button btn_timkiemmaKH;
        private System.Windows.Forms.Button btn_timkiemmaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DateTimePicker dgp_ngayban;
    }
}
