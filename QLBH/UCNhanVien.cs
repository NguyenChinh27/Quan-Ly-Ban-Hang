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
    public partial class UCNhanVien : UserControl
    {
        public UCNhanVien()
        {
            InitializeComponent();
        }
        DataSet ds = null;
        SqlDataAdapter da = null;
        void getdata()
        {
            string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(con);
            string query = "select * from NhanVien";
            da = new SqlDataAdapter(query, conn);
            ds = new DataSet();
            SqlCommandBuilder sd = new SqlCommandBuilder(da);
            da.Fill(ds, "NhanVien");
            dgv_hienthi.DataSource = ds.Tables["NhanVien"];
        }
        void reset()
        {
            txtTimKiemTen.Text = "Nhập tên nhân viên";
            txtTimKiemTen.ForeColor = Color.Gray;
            txtTimKiemSDT.Text = "Nhập số điện thoại";
            txtTimKiemSDT.ForeColor = Color.Gray;
            txtMaNV.Text = "Mời nhập mã nhân viên";
            txtMaNV.ForeColor = Color.Gray;
            txtTenNV.Text = "Mời nhập tên nhân viên";
            txtTenNV.ForeColor = Color.Gray;
            txtSDT.Text = "Mời nhập số điện thoại";
            txtSDT.ForeColor = Color.Gray;
            txtEmail.Text = "Mời nhập email của bạn";
            txtEmail.ForeColor = Color.Gray;
            txtDChi.Text = "Mời nhập địa chỉ của bạn";
            txtDChi.ForeColor = Color.Gray;
            cmb_gioitinh.Text = "";
        }
        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void UCNhanVien_Load(object sender, EventArgs e)
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
                string query = "insert into  NhanVien(MaNV,TenNV,GioiTinh,DiaChi,SDT,Email)values('" + txtMaNV.Text + "',N'" + txtTenNV.Text + "',N'"+cmb_gioitinh.Text+"',N'" + txtDChi.Text + "',N'" + txtSDT.Text + "',N'" + txtEmail.Text + "') ";
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
                errorProvider1.SetError(txtMaNV, "Mã nhân viên đã tồn tại !");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection conn = new SqlConnection(con);
                conn.Open();
                string query = "update  NhanVien set TenNV=N'" + txtTenNV.Text + "',GioiTinh=N'" + cmb_gioitinh.Text + "' ,DiaChi=N'" + txtDChi.Text + "',SDT='" + txtSDT.Text + "',Email='" + txtEmail.Text + "' where MaNV='" + txtMaNV.Text + "' ";
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
                    string query = "delete from NhanVien where MaNV='" + txtMaNV.Text + "' ";
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
            txtMaNV.Enabled = true;
            reset();
            btnThem.Enabled = true;
            btnThem.BackColor = Color.SteelBlue;
            getdata();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection conn = new SqlConnection(con);
                string query = "select * from NhanVien where SDT='" + txtTimKiemSDT.Text + "' or TenNV='" + txtTimKiemTen.Text + "' ";
                da = new SqlDataAdapter(query, conn);
                ds = new DataSet();
                SqlCommandBuilder sd = new SqlCommandBuilder(da);
                da.Fill(ds, "NhanVien");
                dgv_hienthi.DataSource = ds.Tables["NhanVien"];
               
            }
            catch
            {
                MessageBox.Show("Không Tìm Thấy!!");
            }
        }

        private void txtMaNV_Leave(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "Mời nhập mã nhân viên")
            {
                txtMaNV.Text = "";
                txtMaNV.ForeColor = Color.Black;
            }
        }

        private void txtMaNV_Enter(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "Mời nhập mã nhân viên")
            {
                txtMaNV.Text = "";
                txtMaNV.ForeColor = Color.Black;
            }
        }

        private void txtTenNV_Leave(object sender, EventArgs e)
        {
            if (txtTenNV.Text == "Mời nhập tên nhân viên")
            {
                txtTenNV.Text = "";
                txtTenNV.ForeColor = Color.Black;
            }
        }

        private void txtTenNV_Enter(object sender, EventArgs e)
        {
            if (txtTenNV.Text == "Mời nhập tên nhân viên")
            {
                txtTenNV.Text = "";
                txtTenNV.ForeColor = Color.Black;
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

        private void txtDChi_Leave(object sender, EventArgs e)
        {
            if (txtDChi.Text == "Mời nhập địa chỉ của bạn")
            {
                txtDChi.Text = "";
                txtDChi.ForeColor = Color.Black;
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

        private void txtTimKiemMa_Leave(object sender, EventArgs e)
        {
            if (txtTimKiemTen.Text == "Nhập mã nhân viên")
            {
                txtTimKiemTen.Text = "";
                txtTimKiemTen.ForeColor = Color.Black;
            }
        }

        private void txtTimKiemMa_Enter(object sender, EventArgs e)
        {
            if (txtTimKiemTen.Text == "Nhập mã nhân viên")
            {
                txtTimKiemTen.Text = "";
                txtTimKiemTen.ForeColor = Color.Black;
            }
        }

        private void dgv_hienthi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgv_hienthi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                txtMaNV.Text = dgv_hienthi.Rows[i].Cells["MaNV"].Value.ToString();
                txtTenNV.Text = dgv_hienthi.Rows[i].Cells["TenNV"].Value.ToString();
                cmb_gioitinh.Text = dgv_hienthi.Rows[i].Cells["GioiTinh"].Value.ToString();
                txtDChi.Text = dgv_hienthi.Rows[i].Cells["DiaChi"].Value.ToString();
                txtSDT.Text = dgv_hienthi.Rows[i].Cells["SDT"].Value.ToString();
                txtEmail.Text = dgv_hienthi.Rows[i].Cells["Email"].Value.ToString();
            }
            txtMaNV.ForeColor = Color.Black;
            txtMaNV.Enabled = false;
            txtTenNV.ForeColor = Color.Black;
            txtDChi.ForeColor = Color.Black;
            txtSDT.ForeColor = Color.Black;
            txtEmail.ForeColor = Color.Black;
            btnThem.Enabled = false;
            btnThem.BackColor = Color.Gray;
        }

        private void cmb_gioitinh_Click(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(con);
            string query = "select MaNV,GioiTinh from NhanVien ";
            da = new SqlDataAdapter(query, conn);
            ds = new DataSet();
            SqlCommandBuilder cm = new SqlCommandBuilder(da);
            da.Fill(ds, "NhanVien");
            cmb_gioitinh.DataSource = ds.Tables["NhanVien"];
            cmb_gioitinh.DisplayMember = "GioiTinh";
            cmb_gioitinh.ValueMember = "GioiTinh";
        }
    }
}
