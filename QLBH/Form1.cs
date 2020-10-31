using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace QLBH
{
   
    public partial class Form1 : Form
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
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }
        public static string username;
        private void Form1_Load(object sender, EventArgs e)
        {
            txt_taikhoan.Focus();
         
        }
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            username = txt_taikhoan.Text;

            string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(con);
            conn.Open();
            string query = "select count(*) from NguoiDung where TaiKhoan='" + txt_taikhoan.Text + "' and MatKhau='" + txt_matkhau.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            errorProvider1.Clear();
            int i = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            if (i == 0)
            {
                MessageBox.Show("Đăng nhập thất bại!");
                errorProvider1.SetError(txt_matkhau, "Mật khẩu chưa đúng !");
                errorProvider1.SetError(txt_taikhoan, "Tài khoản chưa đúng !");
            }

            else
            {
             
                    Home fr1 = new Home();
                    fr1.Show();
                    this.Hide();
               
               
            }
            if (txt_taikhoan.Text == "") errorProvider1.SetError(txt_taikhoan, "Chưa điền tên tài khoản !");
            else if (txt_matkhau.Text == "") errorProvider1.SetError(txt_matkhau, "Chưa điền mật khẩu !");
            

        }
        private void txt_matkhau_Enter(object sender, EventArgs e)
        {

            if (txt_matkhau.Text == "Password")
            {
                txt_matkhau.Text = "";
                txt_matkhau.ForeColor = Color.Black;
            }
        }

        private void txt_matkhau_Leave(object sender, EventArgs e)
        {
            if (txt_matkhau.Text == "")
            {
                txt_matkhau.Text = "Enter Password";
                txt_matkhau.ForeColor = Color.Gray;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkHienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHienThiMK.Checked == true)
            {
                txt_matkhau.UseSystemPasswordChar = false;
            }
            else
            {
                txt_matkhau.UseSystemPasswordChar = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp fr1 = new SignUp();
            fr1.Show();
            this.Hide();
        }
    }
}
