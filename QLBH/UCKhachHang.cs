using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace QLBH
{
    public partial class UCKhachHang : UserControl
    {
        public UCKhachHang()
        {
            InitializeComponent();
        }
        DataSet ds = null;
        SqlDataAdapter da = null;
        void getdata()
        {
            string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(con);
            string query = "select * from KhachHang";
            da = new SqlDataAdapter(query, conn);
            ds = new DataSet();
            SqlCommandBuilder sd = new SqlCommandBuilder(da);
            da.Fill(ds, "KhachHang");
            dgv_hienthi.DataSource = ds.Tables["KhachHang"];
        }
        void reset()
        {
            txtTimKiemSDT.Text = "Nhập số điện thoại";
            txtTimKiemSDT.ForeColor = Color.Gray;
            txtMaKH.Text = "Mời nhập mã khách hàng";
            txtMaKH.ForeColor = Color.Gray;
            txtTenKH.Text = "Mời nhập tên khách hàng";
            txtTenKH.ForeColor = Color.Gray;
            txtSDT.Text = "Mời nhập số điện thoại";
            txtSDT.ForeColor = Color.Gray;
            txtEmail.Text = "Mời nhập email của bạn";
            txtEmail.ForeColor = Color.Gray;
            txtDChi.Text = "Mời nhập địa chỉ của bạn";
            txtDChi.ForeColor = Color.Gray;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection conn = new SqlConnection(con);
                string query = "select * from KhachHang where SDT='" + txtTimKiemSDT.Text + "'";
                da = new SqlDataAdapter(query, conn);
                ds = new DataSet();
                SqlCommandBuilder sd = new SqlCommandBuilder(da);
                da.Fill(ds, "KhachHang");
                dgv_hienthi.DataSource = ds.Tables["KhachHang"];
               
            }
            catch
            {
                MessageBox.Show("Không Tìm Thấy!!");
            }
        }


        private void UCKhachHang_Load(object sender, EventArgs e)
        {
            getdata();
            reset();
        }

       

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection conn = new SqlConnection(con);
                conn.Open();
                string query = "insert into  KhachHang(MaKH,TenKH,SDT,Email,DiaChi)values('" + txtMaKH.Text + "',N'" + txtTenKH.Text + "','" + txtSDT.Text + "',N'" + txtEmail.Text + "',N'" + txtDChi.Text + "') ";
                SqlCommand cmd = new SqlCommand(query, conn);
                errorProvider1.Clear();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thêm Thành công!!");
                getdata();
            }

            catch
            {
                MessageBox.Show("Thêm Không thành công!!");
                errorProvider1.SetError(txtMaKH, "Mã sản phẩm đã tồn tại !");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection conn = new SqlConnection(con);
                conn.Open();
                string query = "update  KhachHang set TenKH=N'" + txtTenKH.Text + "',SDT=N'" + txtSDT.Text + "',Email='" + txtEmail.Text + "',DiaChi=N'" + txtDChi.Text + "' where MaKH='" + txtMaKH.Text + "' ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
              
                getdata();
                MessageBox.Show("Sửa thành công!!");
            }
            catch
            {
                MessageBox.Show("Sửa Không thành công!!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult y = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection conn = new SqlConnection(con);
                conn.Open();
                if (y == DialogResult.Yes)
                {
                    string query = "delete from KhachHang where MaKH='" + txtMaKH.Text + "' ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Xóa Thành công!!");
                    getdata();
                }
                else
                {

                }

            }
            catch
            {
                MessageBox.Show("Xóa Không thành công!!");
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txtMaKH.Enabled = true;
            reset();
            btnThem.Enabled = true;
            btnThem.BackColor = Color.SteelBlue;

            getdata();
        }

        private void dgv_hienthi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void txtMaKH_Enter(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "Mời nhập mã khách hàng")
            {
                txtMaKH.Text = "";
                txtMaKH.ForeColor = Color.Black;
            }
        }

        private void txtMaKH_Leave(object sender, EventArgs e)
        {
            if (txtMaKH.Text == "Mời nhập mã khách hàng")
            {
                txtMaKH.Text = "";
                txtMaKH.ForeColor = Color.Black;
            }
        }

        private void txtTenKH_Leave(object sender, EventArgs e)
        {
            if (txtTenKH.Text == "Mời nhập tên khách hàng")
            {
                txtTenKH.Text = "";
                txtTenKH.ForeColor = Color.Black;
            }
        }

        private void txtTenKH_Enter(object sender, EventArgs e)
        {
            if (txtTenKH.Text == "Mời nhập tên khách hàng")
            {
                txtTenKH.Text = "";
                txtTenKH.ForeColor = Color.Black;
            }
        }

        private void txtSDT_Enter(object sender, EventArgs e)
        {
            if (txtSDT.Text == "Mời nhập số điện thoại")
            {
                txtSDT.Text = "";
                txtSDT.ForeColor = Color.Black;
            }
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if (txtSDT.Text == "Mời nhập số điện thoại")
            {
                txtSDT.Text = "";
                txtSDT.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Mời nhập email của bạn")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Mời nhập email của bạn")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtDChi_Leave(object sender, EventArgs e)
        {
            if (txtDChi.Text == "Mời nhập địa chỉ của bạn")
            {
                txtDChi.Text = "";
                txtDChi.ForeColor = Color.Black;
            }
        }

        private void txtDChi_Enter(object sender, EventArgs e)
        {
            if (txtDChi.Text == "Mời nhập địa chỉ của bạn")
            {
                txtDChi.Text = "";
                txtDChi.ForeColor = Color.Black;
            }
        }

        private void txtTimKiemSDT_Leave(object sender, EventArgs e)
        {
            if (txtTimKiemSDT.Text == "Nhập số điện thoại")
            {
                txtTimKiemSDT.Text = "";
                txtTimKiemSDT.ForeColor = Color.Black;
            }
        }

        private void txtTimKiemSDT_Enter(object sender, EventArgs e)
        {
            if (txtTimKiemSDT.Text == "Nhập số điện thoại")
            {
                txtTimKiemSDT.Text = "";
                txtTimKiemSDT.ForeColor = Color.Black;
            }
        }

        private void dgv_hienthi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                txtMaKH.Text = dgv_hienthi.Rows[i].Cells["MaKH"].Value.ToString();
                txtTenKH.Text = dgv_hienthi.Rows[i].Cells["TenKH"].Value.ToString();
                txtSDT.Text = dgv_hienthi.Rows[i].Cells["SDT"].Value.ToString();
                txtEmail.Text = dgv_hienthi.Rows[i].Cells["Email"].Value.ToString();
                txtDChi.Text = dgv_hienthi.Rows[i].Cells["DiaChi"].Value.ToString();
            }
            txtMaKH.ForeColor = Color.Black;
            txtMaKH.Enabled = false;
            txtTenKH.ForeColor = Color.Black;
            txtDChi.ForeColor = Color.Black;
            txtSDT.ForeColor = Color.Black;
            txtEmail.ForeColor = Color.Black;
            btnThem.Enabled = false;
            btnThem.BackColor = Color.Gray;
        }
    }
}
