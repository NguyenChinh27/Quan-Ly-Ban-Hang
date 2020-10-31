namespace QLBH
{
    partial class UCHoaDon
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
            this.btn_hdban = new System.Windows.Forms.Button();
            this.btn_hdnhap = new System.Windows.Forms.Button();
            this.pn_contentItem = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_hdban
            // 
            this.btn_hdban.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_hdban.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hdban.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hdban.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hdban.ForeColor = System.Drawing.Color.White;
            this.btn_hdban.Location = new System.Drawing.Point(506, 16);
            this.btn_hdban.Name = "btn_hdban";
            this.btn_hdban.Size = new System.Drawing.Size(225, 38);
            this.btn_hdban.TabIndex = 66;
            this.btn_hdban.Text = "Hóa Đơn Bán- Xem Chi Tiết";
            this.btn_hdban.UseVisualStyleBackColor = false;
            this.btn_hdban.Click += new System.EventHandler(this.btn_hdban_Click);
            // 
            // btn_hdnhap
            // 
            this.btn_hdnhap.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_hdnhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hdnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hdnhap.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hdnhap.ForeColor = System.Drawing.Color.White;
            this.btn_hdnhap.Location = new System.Drawing.Point(108, 16);
            this.btn_hdnhap.Name = "btn_hdnhap";
            this.btn_hdnhap.Size = new System.Drawing.Size(243, 38);
            this.btn_hdnhap.TabIndex = 65;
            this.btn_hdnhap.Text = "Hóa Đơn Nhập- Xem Chi Tiết";
            this.btn_hdnhap.UseVisualStyleBackColor = false;
            this.btn_hdnhap.Click += new System.EventHandler(this.btn_hdnhap_Click);
            // 
            // pn_contentItem
            // 
            this.pn_contentItem.Location = new System.Drawing.Point(0, 60);
            this.pn_contentItem.Name = "pn_contentItem";
            this.pn_contentItem.Size = new System.Drawing.Size(883, 480);
            this.pn_contentItem.TabIndex = 71;
            // 
            // UCHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_hdban);
            this.Controls.Add(this.btn_hdnhap);
            this.Controls.Add(this.pn_contentItem);
            this.Name = "UCHoaDon";
            this.Size = new System.Drawing.Size(883, 543);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_hdban;
        private System.Windows.Forms.Button btn_hdnhap;
        private System.Windows.Forms.Panel pn_contentItem;
    }
}
