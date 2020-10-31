using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.InteropServices;

namespace QLBH
{
    public partial class ChangePassWord : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
  (
      int nLeftRect,     // x-coordinate of upper-left corner
      int nTopRect,      // y-coordinate of upper-left corner
      int nRightRect,    // x-coordinate of lower-right corner
      int nBottomRect,   // y-coordinate of lower-right corner
      int nWidthEllipse, // height of ellipse
      int nHeightEllipse // width of ellipse
  );
        public ChangePassWord()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void checkHienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHienThiMK.Checked == true)
            {
                txt_matkhau.UseSystemPasswordChar = false;
                txt_matkhaumoi.UseSystemPasswordChar = false;
                txt_matkhaumoiAgain.UseSystemPasswordChar = false;
            }
            else
            {
                txt_matkhau.UseSystemPasswordChar = true;
                txt_matkhaumoi.UseSystemPasswordChar = true;
                txt_matkhaumoiAgain.UseSystemPasswordChar = true;
            }
        }

        private void btn_Dongy_Click(object sender, EventArgs e)
        {
           
                string maincon = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection sqlconn = new SqlConnection(maincon);
                SqlDataAdapter da = new SqlDataAdapter("Select count (*) from NguoiDung where TaiKhoan=N'"+txt_taikhoan.Text+"' and MatKhau=N'"+txt_matkhau.Text+"'",sqlconn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            errorProvider1.Clear();
            if(dt.Rows[0][0].ToString()=="1")
            {
                if (txt_matkhaumoi.Text == txt_matkhaumoiAgain.Text)
                {
                    SqlDataAdapter da1 = new SqlDataAdapter("update NguoiDung set MatKhau=N'" + txt_matkhaumoi.Text + "'  where TaiKhoan=N'" + txt_taikhoan.Text + "' and MatKhau=N'" + txt_matkhau.Text + "' ", sqlconn);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                    MessageBox.Show("Đổi mật khẩu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 fr1 = new Form1();
                    fr1.Show();
                    this.Hide();
                }
                else
                {
                   
                    errorProvider1.SetError(txt_matkhaumoiAgain, "Mật khẩu nhập lại chưa đúng !");
                }
            }
            else
            {
                errorProvider1.SetError(txt_taikhoan, "Tên người dùng không đúng !");
                errorProvider1.SetError(txt_matkhau, "Mật khẩu cũ không đúng không đúng !");
            }
            if(txt_taikhoan.Text=="") errorProvider1.SetError(txt_taikhoan, "Chưa điền tên tài khoản !");
            else if (txt_matkhau.Text == "") errorProvider1.SetError(txt_matkhau, "Chưa điền mật khẩu cũ !");
            else if (txt_matkhaumoi.Text == "") errorProvider1.SetError(txt_matkhaumoi, "Chưa điền mật khẩu mới !");
            else if (txt_matkhaumoiAgain.Text == "") errorProvider1.SetError(txt_matkhaumoiAgain, "Chưa nhập lại mật khẩu mới !");
        }

        private void ChangePassWord_Load(object sender, EventArgs e)
        {

        }
    }
}
