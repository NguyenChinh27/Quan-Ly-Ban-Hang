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
    public partial class SignUp : Form
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
        public SignUp()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void checkHienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if (checkHienThiMK.Checked == true)
            {
                txtPasswordAgain.UseSystemPasswordChar = false;
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPasswordAgain.UseSystemPasswordChar = true;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            string maincon = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection sqlconn = new SqlConnection(maincon);
            if (txtPassword.Text == txtPasswordAgain.Text)
            {
                string sqlquery = "insert into NguoiDung values (@TaiKhoan,@MatKhau,@Email)";
                sqlconn.Open();
                SqlCommand sqlcon = new SqlCommand(sqlquery, sqlconn);
                sqlcon.Parameters.AddWithValue("@TaiKhoan", txt_user.Text);
                sqlcon.Parameters.AddWithValue("@MatKhau", txtPassword.Text);
                sqlcon.Parameters.AddWithValue("@Email", txtEmail.Text);
                sqlcon.ExecuteNonQuery();
                lbConnect.Text = txt_user.Text + " đã đăng kí thành công";
                lbConnect.ForeColor = Color.Blue;
                sqlconn.Close();
            }
            else
            {
                lbConnect.Text = "Mật Khẩu không khớp với mật khẩu nhập lại";
                lbConnect.ForeColor = Color.Red;
            }
        }

        private void txtPasswordAgain_Leave(object sender, EventArgs e)
        {
            if(txtPassword.Text != txtPasswordAgain.Text)
            {
                MessageBox.Show("Mật Khẩu không đúng");
                txtPasswordAgain.Focus();
                return;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            this.Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
