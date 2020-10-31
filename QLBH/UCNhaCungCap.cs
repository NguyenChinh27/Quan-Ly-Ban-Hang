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
    public partial class UCNhaCungCap : UserControl
    {
        public UCNhaCungCap()
        {
            InitializeComponent();
        }
        DataSet ds = null;
        SqlDataAdapter da = null;
        void getdata()
        {
            string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(con);
            string query = "select * from NCC";
            da = new SqlDataAdapter(query, conn);
            ds = new DataSet();
            SqlCommandBuilder sd = new SqlCommandBuilder(da);
            da.Fill(ds, "NCC");
            dgv_hienthi.DataSource = ds.Tables["NCC"];
        }
        void reset()
        {
            txtTimKiemMa.Text = "Nhập mã nhà cung cấp";
            txtTimKiemMa.ForeColor = Color.Gray;
            txtTimKiemSDT.Text = "Nhập số điện thoại";
            txtTimKiemSDT.ForeColor = Color.Gray;
            txtMaNCC.Text = "Mời nhập mã nhà cung cấp";
            txtMaNCC.ForeColor = Color.Gray;
            txtTenNCC.Text = "Mời nhập tên nhà cung cấp";
            txtTenNCC.ForeColor = Color.Gray;
            txtSDT.Text = "Nhập số điện thoại";
            txtSDT.ForeColor = Color.Gray;
            txtEmail.Text = "Nhập email của bạn";
            txtEmail.ForeColor = Color.Gray;
            txtDChi.Text = "Nhập địa chỉ của bạn";
            txtDChi.ForeColor = Color.Gray;
        }
        private void UCNhaCungCap_Load(object sender, EventArgs e)
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
                string query = "insert into  NCC(MaNCC,TenNCC,DiaChi,SDT,Email)values('" + txtMaNCC.Text + "',N'" + txtTenNCC.Text + "',N'" + txtDChi.Text + "',N'" + txtSDT.Text + "',N'" + txtEmail.Text + "') ";
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
                errorProvider1.SetError(txtMaNCC, "Mã nhà cung cấp đã tồn tại !");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection conn = new SqlConnection(con);
                conn.Open();
                string query = "update  NCC set TenNCC=N'" + txtTenNCC.Text + "',DiaChi=N'" + txtDChi.Text + "',SDT='" + txtSDT.Text + "',Email='" + txtEmail.Text + "' where MaNCC='" + txtMaNCC.Text + "' ";
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
                    string query = "delete from NCC where MaNCC='" + txtMaNCC.Text + "' ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Xóa Thành công!!");
                    getdata();
                }
               
            }
            catch
            {
                MessageBox.Show("Xóa Không thành công!!");
            }
        }

        private void txtMaNCC_Leave(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "Mời nhập mã nhà cung cấp")
            {
                txtMaNCC.Text = "";
                txtMaNCC.ForeColor = Color.Black;
            }
        }

        private void txtMaNCC_Enter(object sender, EventArgs e)
        {
            if (txtMaNCC.Text == "Mời nhập mã nhà cung cấp")
            {
                txtMaNCC.Text = "";
                txtMaNCC.ForeColor = Color.Black;
            }
        }

        private void txtTenNCC_Enter(object sender, EventArgs e)
        {
            if (txtTenNCC.Text == "Mời nhập tên nhà cung cấp")
            {
                txtTenNCC.Text = "";
                txtTenNCC.ForeColor = Color.Black;
            }
        }

        private void txtTenNCC_Leave(object sender, EventArgs e)
        {
            if (txtTenNCC.Text == "Mời nhập tên nhà cung cấp")
            {
                txtTenNCC.Text = "";
                txtTenNCC.ForeColor = Color.Black;
            }
        }

        private void txtDChi_Enter(object sender, EventArgs e)
        {
            if (txtDChi.Text == "Nhập địa chỉ của bạn")
            {
                txtDChi.Text = "";
                txtDChi.ForeColor = Color.Black;
            }
        }

        private void txtDChi_Leave(object sender, EventArgs e)
        {
            if (txtDChi.Text == "Nhập địa chỉ của bạn")
            {
                txtDChi.Text = "";
                txtDChi.ForeColor = Color.Black;
            }
        }

        private void txtSDT_Enter(object sender, EventArgs e)
        {
            if (txtSDT.Text == "Nhập số điện thoại")
            {
                txtSDT.Text = "";
                txtSDT.ForeColor = Color.Black;
            }
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            if (txtSDT.Text == "Nhập số điện thoại")
            {
                txtSDT.Text = "";
                txtSDT.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Nhập email của bạn")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Nhập email của bạn")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
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

        private void txtTimKiemSDT_Leave(object sender, EventArgs e)
        {
            if (txtTimKiemSDT.Text == "Nhập số điện thoại")
            {
                txtTimKiemSDT.Text = "";
                txtTimKiemSDT.ForeColor = Color.Black;
            }
        }

        private void txtTimKiemMa_Enter(object sender, EventArgs e)
        {
            if (txtTimKiemMa.Text == "Nhập mã nhà cung cấp")
            {
                txtTimKiemMa.Text = "";
                txtTimKiemMa.ForeColor = Color.Black;
            }
        }

        private void txtTimKiemMa_Leave(object sender, EventArgs e)
        {
            if (txtTimKiemMa.Text == "Nhập mã nhà cung cấp")
            {
                txtTimKiemMa.Text = "";
                txtTimKiemMa.ForeColor = Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMaNCC.Enabled = true;

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
                string query = "select * from NCC where SDT='" + txtTimKiemSDT.Text + "' or MaNCC='" + txtTimKiemMa.Text + "' ";
                da = new SqlDataAdapter(query, conn);
                ds = new DataSet();
                SqlCommandBuilder sd = new SqlCommandBuilder(da);
                da.Fill(ds, "NCC");
                dgv_hienthi.DataSource = ds.Tables["NCC"];
              
            }
            catch
            {
                MessageBox.Show("Không Tìm Thấy!!");
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
                txtMaNCC.Text = dgv_hienthi.Rows[i].Cells["MaNCC"].Value.ToString();
                txtTenNCC.Text = dgv_hienthi.Rows[i].Cells["TenNCC"].Value.ToString();
                txtDChi.Text = dgv_hienthi.Rows[i].Cells["DiaChi"].Value.ToString();
                txtSDT.Text = dgv_hienthi.Rows[i].Cells["SDT"].Value.ToString();
                txtEmail.Text = dgv_hienthi.Rows[i].Cells["Email"].Value.ToString();
            }
            txtMaNCC.ForeColor = Color.Black;
            txtMaNCC.Enabled = false;
            txtTenNCC.ForeColor = Color.Black;
            txtTenNCC.ForeColor = Color.Black;
            txtSDT.ForeColor = Color.Black;
            txtEmail.ForeColor = Color.Black;
            txtDChi.ForeColor = Color.Black;
            btnThem.Enabled = false;
            btnThem.BackColor = Color.Gray;
        }
    }
}
