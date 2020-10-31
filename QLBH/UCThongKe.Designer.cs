namespace QLBH
{
    partial class UCThongKe
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
            this.btnTKNhap = new System.Windows.Forms.Button();
            this.btnTKBan = new System.Windows.Forms.Button();
            this.dgv_hienthi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgp_ngayBD = new System.Windows.Forms.DateTimePicker();
            this.dgp_ngayKT = new System.Windows.Forms.DateTimePicker();
            this.cb_tongtiennhaptungsp = new System.Windows.Forms.CheckBox();
            this.cb_slhangnhap = new System.Windows.Forms.CheckBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.cb_tongSLtungSP = new System.Windows.Forms.CheckBox();
            this.cb_SLtheoTungNCC = new System.Windows.Forms.CheckBox();
            this.cb_tongtienmoiNCC = new System.Windows.Forms.CheckBox();
            this.cb_tongtienthumoikhach = new System.Windows.Forms.CheckBox();
            this.cb_khachmuanhieu = new System.Windows.Forms.CheckBox();
            this.cb_TSLtungSPban = new System.Windows.Forms.CheckBox();
            this.cb_TTbanTungSP = new System.Windows.Forms.CheckBox();
            this.cb_TSLban = new System.Windows.Forms.CheckBox();
            this.dgv_hienthiban = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hienthi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hienthiban)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTKNhap
            // 
            this.btnTKNhap.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTKNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTKNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTKNhap.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKNhap.ForeColor = System.Drawing.Color.White;
            this.btnTKNhap.Location = new System.Drawing.Point(19, 203);
            this.btnTKNhap.Name = "btnTKNhap";
            this.btnTKNhap.Size = new System.Drawing.Size(171, 38);
            this.btnTKNhap.TabIndex = 111;
            this.btnTKNhap.Text = "Thống Kê Nhập Hàng";
            this.btnTKNhap.UseVisualStyleBackColor = false;
            this.btnTKNhap.Click += new System.EventHandler(this.btnTKNhap_Click);
            // 
            // btnTKBan
            // 
            this.btnTKBan.BackColor = System.Drawing.Color.SteelBlue;
            this.btnTKBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTKBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTKBan.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKBan.ForeColor = System.Drawing.Color.White;
            this.btnTKBan.Location = new System.Drawing.Point(16, 502);
            this.btnTKBan.Name = "btnTKBan";
            this.btnTKBan.Size = new System.Drawing.Size(171, 38);
            this.btnTKBan.TabIndex = 112;
            this.btnTKBan.Text = "Thống Kê Bán Hàng";
            this.btnTKBan.UseVisualStyleBackColor = false;
            this.btnTKBan.Click += new System.EventHandler(this.btnTKBan_Click);
            // 
            // dgv_hienthi
            // 
            this.dgv_hienthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hienthi.Location = new System.Drawing.Point(276, 12);
            this.dgv_hienthi.Name = "dgv_hienthi";
            this.dgv_hienthi.Size = new System.Drawing.Size(604, 229);
            this.dgv_hienthi.TabIndex = 113;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 120;
            this.label1.Text = "Đến ngày :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(344, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 121;
            this.label2.Text = "Từ ngày :";
            // 
            // dgp_ngayBD
            // 
            this.dgp_ngayBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dgp_ngayBD.Location = new System.Drawing.Point(402, 266);
            this.dgp_ngayBD.Name = "dgp_ngayBD";
            this.dgp_ngayBD.Size = new System.Drawing.Size(96, 20);
            this.dgp_ngayBD.TabIndex = 123;
            // 
            // dgp_ngayKT
            // 
            this.dgp_ngayKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dgp_ngayKT.Location = new System.Drawing.Point(582, 266);
            this.dgp_ngayKT.Name = "dgp_ngayKT";
            this.dgp_ngayKT.Size = new System.Drawing.Size(96, 20);
            this.dgp_ngayKT.TabIndex = 124;
            // 
            // cb_tongtiennhaptungsp
            // 
            this.cb_tongtiennhaptungsp.AutoSize = true;
            this.cb_tongtiennhaptungsp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tongtiennhaptungsp.Location = new System.Drawing.Point(23, 103);
            this.cb_tongtiennhaptungsp.Name = "cb_tongtiennhaptungsp";
            this.cb_tongtiennhaptungsp.Size = new System.Drawing.Size(202, 21);
            this.cb_tongtiennhaptungsp.TabIndex = 132;
            this.cb_tongtiennhaptungsp.Text = "Tổng tiền nhập cho từng SP";
            this.cb_tongtiennhaptungsp.UseVisualStyleBackColor = true;
            // 
            // cb_slhangnhap
            // 
            this.cb_slhangnhap.AutoSize = true;
            this.cb_slhangnhap.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_slhangnhap.Location = new System.Drawing.Point(25, 29);
            this.cb_slhangnhap.Name = "cb_slhangnhap";
            this.cb_slhangnhap.Size = new System.Drawing.Size(188, 21);
            this.cb_slhangnhap.TabIndex = 127;
            this.cb_slhangnhap.Text = "Tổng số lượng hàng nhập";
            this.cb_slhangnhap.UseVisualStyleBackColor = true;
            this.cb_slhangnhap.CheckedChanged += new System.EventHandler(this.cb_slhangnhap_CheckedChanged);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.White;
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.ForeColor = System.Drawing.Color.Transparent;
            this.btn_reset.Image = global::QLBH.Properties.Resources.icons8_synchronize_40px;
            this.btn_reset.Location = new System.Drawing.Point(84, 252);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(37, 33);
            this.btn_reset.TabIndex = 133;
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // cb_tongSLtungSP
            // 
            this.cb_tongSLtungSP.AutoSize = true;
            this.cb_tongSLtungSP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tongSLtungSP.Location = new System.Drawing.Point(25, 64);
            this.cb_tongSLtungSP.Name = "cb_tongSLtungSP";
            this.cb_tongSLtungSP.Size = new System.Drawing.Size(193, 21);
            this.cb_tongSLtungSP.TabIndex = 134;
            this.cb_tongSLtungSP.Text = "Tổng số lượng cho từng SP";
            this.cb_tongSLtungSP.UseVisualStyleBackColor = true;
            // 
            // cb_SLtheoTungNCC
            // 
            this.cb_SLtheoTungNCC.AutoSize = true;
            this.cb_SLtheoTungNCC.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_SLtheoTungNCC.Location = new System.Drawing.Point(23, 139);
            this.cb_SLtheoTungNCC.Name = "cb_SLtheoTungNCC";
            this.cb_SLtheoTungNCC.Size = new System.Drawing.Size(209, 21);
            this.cb_SLtheoTungNCC.TabIndex = 135;
            this.cb_SLtheoTungNCC.Text = "Lượng hàng nhập từng NCC";
            this.cb_SLtheoTungNCC.UseVisualStyleBackColor = true;
            // 
            // cb_tongtienmoiNCC
            // 
            this.cb_tongtienmoiNCC.AutoSize = true;
            this.cb_tongtienmoiNCC.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tongtienmoiNCC.Location = new System.Drawing.Point(23, 176);
            this.cb_tongtienmoiNCC.Name = "cb_tongtienmoiNCC";
            this.cb_tongtienmoiNCC.Size = new System.Drawing.Size(179, 21);
            this.cb_tongtienmoiNCC.TabIndex = 136;
            this.cb_tongtienmoiNCC.Text = "Tông tiền cho mỗi NCC";
            this.cb_tongtienmoiNCC.UseVisualStyleBackColor = true;
            // 
            // cb_tongtienthumoikhach
            // 
            this.cb_tongtienthumoikhach.AutoSize = true;
            this.cb_tongtienthumoikhach.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tongtienthumoikhach.Location = new System.Drawing.Point(25, 461);
            this.cb_tongtienthumoikhach.Name = "cb_tongtienthumoikhach";
            this.cb_tongtienthumoikhach.Size = new System.Drawing.Size(230, 21);
            this.cb_tongtienthumoikhach.TabIndex = 141;
            this.cb_tongtienthumoikhach.Text = "Tông tiền bán được cho mỗi KH";
            this.cb_tongtienthumoikhach.UseVisualStyleBackColor = true;
            // 
            // cb_khachmuanhieu
            // 
            this.cb_khachmuanhieu.AutoSize = true;
            this.cb_khachmuanhieu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_khachmuanhieu.Location = new System.Drawing.Point(25, 428);
            this.cb_khachmuanhieu.Name = "cb_khachmuanhieu";
            this.cb_khachmuanhieu.Size = new System.Drawing.Size(222, 21);
            this.cb_khachmuanhieu.TabIndex = 140;
            this.cb_khachmuanhieu.Text = "2 khách mua hàng nhiều nhất";
            this.cb_khachmuanhieu.UseVisualStyleBackColor = true;
            // 
            // cb_TSLtungSPban
            // 
            this.cb_TSLtungSPban.AutoSize = true;
            this.cb_TSLtungSPban.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TSLtungSPban.Location = new System.Drawing.Point(25, 357);
            this.cb_TSLtungSPban.Name = "cb_TSLtungSPban";
            this.cb_TSLtungSPban.Size = new System.Drawing.Size(176, 21);
            this.cb_TSLtungSPban.TabIndex = 139;
            this.cb_TSLtungSPban.Text = "Tổng lượng cho từng SP";
            this.cb_TSLtungSPban.UseVisualStyleBackColor = true;
            // 
            // cb_TTbanTungSP
            // 
            this.cb_TTbanTungSP.AutoSize = true;
            this.cb_TTbanTungSP.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TTbanTungSP.Location = new System.Drawing.Point(25, 394);
            this.cb_TTbanTungSP.Name = "cb_TTbanTungSP";
            this.cb_TTbanTungSP.Size = new System.Drawing.Size(195, 21);
            this.cb_TTbanTungSP.TabIndex = 138;
            this.cb_TTbanTungSP.Text = "Tổng tiền bán cho từng SP";
            this.cb_TTbanTungSP.UseVisualStyleBackColor = true;
            // 
            // cb_TSLban
            // 
            this.cb_TSLban.AutoSize = true;
            this.cb_TSLban.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TSLban.Location = new System.Drawing.Point(25, 324);
            this.cb_TSLban.Name = "cb_TSLban";
            this.cb_TSLban.Size = new System.Drawing.Size(200, 21);
            this.cb_TSLban.TabIndex = 137;
            this.cb_TSLban.Text = "Tổng lượng hàng bán được";
            this.cb_TSLban.UseVisualStyleBackColor = true;
            // 
            // dgv_hienthiban
            // 
            this.dgv_hienthiban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hienthiban.Location = new System.Drawing.Point(287, 310);
            this.dgv_hienthiban.Name = "dgv_hienthiban";
            this.dgv_hienthiban.Size = new System.Drawing.Size(593, 230);
            this.dgv_hienthiban.TabIndex = 122;
            // 
            // UCThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cb_tongtienthumoikhach);
            this.Controls.Add(this.cb_khachmuanhieu);
            this.Controls.Add(this.cb_TSLtungSPban);
            this.Controls.Add(this.cb_TTbanTungSP);
            this.Controls.Add(this.cb_TSLban);
            this.Controls.Add(this.cb_tongtienmoiNCC);
            this.Controls.Add(this.cb_SLtheoTungNCC);
            this.Controls.Add(this.cb_tongSLtungSP);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.cb_tongtiennhaptungsp);
            this.Controls.Add(this.cb_slhangnhap);
            this.Controls.Add(this.dgp_ngayKT);
            this.Controls.Add(this.dgp_ngayBD);
            this.Controls.Add(this.dgv_hienthiban);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_hienthi);
            this.Controls.Add(this.btnTKBan);
            this.Controls.Add(this.btnTKNhap);
            this.Name = "UCThongKe";
            this.Size = new System.Drawing.Size(883, 543);
            this.Load += new System.EventHandler(this.UCThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hienthi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hienthiban)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTKNhap;
        private System.Windows.Forms.Button btnTKBan;
        private System.Windows.Forms.DataGridView dgv_hienthi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dgp_ngayBD;
        private System.Windows.Forms.DateTimePicker dgp_ngayKT;
        private System.Windows.Forms.CheckBox cb_tongtiennhaptungsp;
        private System.Windows.Forms.CheckBox cb_slhangnhap;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.CheckBox cb_tongSLtungSP;
        private System.Windows.Forms.CheckBox cb_SLtheoTungNCC;
        private System.Windows.Forms.CheckBox cb_tongtienmoiNCC;
        private System.Windows.Forms.CheckBox cb_tongtienthumoikhach;
        private System.Windows.Forms.CheckBox cb_khachmuanhieu;
        private System.Windows.Forms.CheckBox cb_TSLtungSPban;
        private System.Windows.Forms.CheckBox cb_TTbanTungSP;
        private System.Windows.Forms.CheckBox cb_TSLban;
        private System.Windows.Forms.DataGridView dgv_hienthiban;
    }
}
