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
    public partial class UCSanPham : UserControl
    {
        public UCSanPham()
        {
            InitializeComponent();
        }
        DataSet ds = null;
        SqlDataAdapter da = null;
        void getdata()
        {
            string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(con);
            string query = "select * from SanPham";
            da = new SqlDataAdapter(query, conn);
            ds = new DataSet();
            SqlCommandBuilder sd = new SqlCommandBuilder(da);
            da.Fill(ds, "SanPham");
            dgv_hienthi.DataSource = ds.Tables["SanPham"];
        }
        void reset()
        {
            txtMaSP.Text = "";          
            txtTenSP.Text = "";           
            txtLoaiSP.Text = "";           
            cmb_mancc.Text = "";
            nud_soluong.Value = 0;
            txtGiaBan.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection conn = new SqlConnection(con);
                string query = "select * from SanPham where LoaiSP=N'" + txtLoaiSP.Text + "'  ";
                da = new SqlDataAdapter(query, conn);
                ds = new DataSet();
                SqlCommandBuilder sd = new SqlCommandBuilder(da);
                da.Fill(ds, "SanPham");
                dgv_hienthi.DataSource = ds.Tables["SanPham"];
               
            }
            catch
            {
                MessageBox.Show("Không Tìm Thấy!!");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection conn = new SqlConnection(con);
                conn.Open();
                string query = "insert into  SanPham(MaSP,TenSP,LoaiSP,MaNCC,SoLuong, GiaBan)values('" + txtMaSP.Text + "',N'" + txtTenSP.Text + "',N'" + txtLoaiSP.Text + "',N'" + cmb_mancc.Text + "'," + nud_soluong.Value + ",N'" + txtGiaBan.Text + "' ) ";
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
                errorProvider1.SetError(txtMaSP, "Mã sản phẩm đã tồn tại !");
            }
        }

        private void UCSanPham_Load(object sender, EventArgs e)
        {
            getdata();
            reset();
        }

        private void dgv_hienthi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection conn = new SqlConnection(con);
                conn.Open();
                string query = "update  SanPham set TenSP=N'" + txtTenSP.Text + "',LoaiSP=N'" + txtLoaiSP.Text + "',MaNCC=N'" + cmb_mancc.Text + "',SoLuong='" + nud_soluong.Value + "',GiaBan='" + txtGiaBan.Text + "' where MaSP='" + txtMaSP.Text + "' ";
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
                string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection conn = new SqlConnection(con);
                conn.Open();
                DialogResult y = MessageBox.Show("Bạn có muốn xóa không?", "Câu hỏi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (y == DialogResult.Yes)
                {
                    string query = "delete from SanPham where MaSP='" + txtMaSP.Text + "' ";
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
            txtMaSP.Enabled = true;
            reset();
            btnThem.Enabled = true;
            btnThem.BackColor = Color.SteelBlue;
            getdata();
        }

        private void btn_timkiemTenSP_Click(object sender, EventArgs e)
        {
            try
            {
                 string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection conn = new SqlConnection(con);
                conn.Open();
                string query = "select * from SanPham where TenSP=N'" + txtTenSP.Text + "'  ";
                da = new SqlDataAdapter(query, conn);
                ds = new DataSet();
                SqlCommandBuilder sd = new SqlCommandBuilder(da);              
                da.Fill(ds, "SanPham");               
                dgv_hienthi.DataSource = ds.Tables["SanPham"];  
            }
            catch
            {
                MessageBox.Show("Không Tìm Thấy!!");
            }
        }

        private void btn_timkiemtenNCC_Click(object sender, EventArgs e)
        {
            try
            {
                string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection conn = new SqlConnection(con);
                string query = "select * from SanPham where MaNCC=N'" + cmb_mancc.Text + "'  ";
                da = new SqlDataAdapter(query, conn);
                ds = new DataSet();
                SqlCommandBuilder sd = new SqlCommandBuilder(da);
                da.Fill(ds, "SanPham");
                dgv_hienthi.DataSource = ds.Tables["SanPham"];
            
            }
            catch
            {
                MessageBox.Show("Không Tìm Thấy!!");
            }
        }

        private void btn_timkiemgiaban_Click(object sender, EventArgs e)
        {
            try
            {
                string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection conn = new SqlConnection(con);
                string query = "select * from SanPham where GiaBan='" + txtGiaBan.Text + "'  ";
                da = new SqlDataAdapter(query, conn);
                ds = new DataSet();
                SqlCommandBuilder sd = new SqlCommandBuilder(da);
                da.Fill(ds, "SanPham");
                dgv_hienthi.DataSource = ds.Tables["SanPham"];
             
            }
            catch
            {
                MessageBox.Show("Không Tìm Thấy!!");
            }
        }

        

        private void dgv_hienthi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                txtMaSP.Text = dgv_hienthi.Rows[i].Cells["MaSP"].Value.ToString();
                txtTenSP.Text = dgv_hienthi.Rows[i].Cells["TenSP"].Value.ToString();
                txtLoaiSP.Text = dgv_hienthi.Rows[i].Cells["LoaiSP"].Value.ToString();
                cmb_mancc.Text = dgv_hienthi.Rows[i].Cells["MaNCC"].Value.ToString();
                nud_soluong.Value = Convert.ToInt32(dgv_hienthi.Rows[i].Cells["SoLuong"].Value.ToString());
                txtGiaBan.Text = dgv_hienthi.Rows[i].Cells["GiaBan"].Value.ToString();
            }
            txtMaSP.Enabled = false;
            btnThem.Enabled = false;
            btnThem.BackColor = Color.Gray;
        }

        private void cmb_tenncc_Click(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(con);
            string query = "select MaNCC,TenNCC from NCC";
            da = new SqlDataAdapter(query, conn);
            ds = new DataSet();
            SqlCommandBuilder cm = new SqlCommandBuilder(da);
            da.Fill(ds, "NCC");
            cmb_mancc.DataSource = ds.Tables["NCC"];
            cmb_mancc.DisplayMember = "MaNCC";
            cmb_mancc.ValueMember = "MaNCC";
        }
    }
}
