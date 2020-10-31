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
    public partial class UCHDNhap : UserControl
    {
      
        public UCHDNhap()
        {
            InitializeComponent();
        }
        DataSet ds = null;
        SqlDataAdapter da = null;
        void getdata()
        {
            string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(con);
            string query = "select * from PhieuNhap";
            da = new SqlDataAdapter(query, conn);
            ds = new DataSet();
            SqlCommandBuilder sd = new SqlCommandBuilder(da);
            da.Fill(ds, "PhieuNhap");
            dgv_hienthi.DataSource = ds.Tables["PhieuNhap"];
        }
        void reset()
        {
            txtMaPN.Text = "";
            cmb_mancc.Text = "";
            cmb_manv.Text = "";
            cmb_masp.Text = "";
            nud_soluong.Value = 0;
            txtGiaNhap.Text = "";
            dgp_ngaynhap.Value = DateTime.Now;
            
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection conn = new SqlConnection(con);
                conn.Open();
                string query = "insert into  PhieuNhap(MaPN,MaSP,MaNCC,MaNV,NgayNhap, GiaNhap, SLNhap)values('" + txtMaPN.Text + "',N'" + cmb_masp.Text + "',N'" + cmb_mancc.Text + "',N'" + cmb_manv.Text + "','"+dgp_ngaynhap.Value+ "','" + txtGiaNhap.Text + "'," + nud_soluong.Value + " ) ";
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
                errorProvider1.SetError(txtMaPN, "Mã sản phẩm đã tồn tại !");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection conn = new SqlConnection(con);
                conn.Open();
                string query = "update PhieuNhap   set MaSP=N'" + cmb_masp.Text + "' ,MaNCC=N'" + cmb_mancc.Text + "',MaNV='" + cmb_manv.Text + "',NgayNhap='" + dgp_ngaynhap.Value + "',GiaNhap='" + txtGiaNhap.Text + "',SLNhap='" + nud_soluong.Value + "' where MaPN='" + txtMaPN.Text + "' ";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Bạn có muốn sửa không?", "Câu Hỏi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
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
                DialogResult y = MessageBox.Show("Bạn có muốn xóa không?", "Câu hỏi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection conn = new SqlConnection(con);
                conn.Open();
                if (y == DialogResult.Yes)
                {
                    string query = "delete from PhieuNhap where MaPN='" + txtMaPN.Text + "' ";
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

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txtMaPN.Enabled = true;
            reset();
            btnThem.Enabled = true;
            btnThem.BackColor = Color.SteelBlue;
            getdata();
        }

        private void dgv_hienthi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i >= 0)
            {
                txtMaPN.Text = dgv_hienthi.Rows[i].Cells["MaPN"].Value.ToString();
                cmb_masp.Text = dgv_hienthi.Rows[i].Cells["MaSP"].Value.ToString();
                cmb_mancc.Text = dgv_hienthi.Rows[i].Cells["MaNCC"].Value.ToString();
                cmb_manv.Text = dgv_hienthi.Rows[i].Cells["MaNV"].Value.ToString();
                dgp_ngaynhap.Value = Convert.ToDateTime(dgv_hienthi.Rows[i].Cells["NgayNhap"].Value.ToString());
               
                txtGiaNhap.Text = dgv_hienthi.Rows[i].Cells["GiaNhap"].Value.ToString();
                nud_soluong.Value = Convert.ToInt32(dgv_hienthi.Rows[i].Cells["SLNhap"].Value.ToString());
            }

            txtMaPN.Enabled = false;
            btnThem.Enabled = false;
            btnThem.BackColor = Color.Gray;
        }

        private void cmb_masp_Click(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(con);
            string query = "select MaSP,TenSP from SanPham";
            da = new SqlDataAdapter(query, conn);
            ds = new DataSet();
            SqlCommandBuilder cm = new SqlCommandBuilder(da);
            da.Fill(ds, "SanPham");
            cmb_masp.DataSource = ds.Tables["SanPham"];
            cmb_masp.DisplayMember = "MaSP";
            cmb_masp.ValueMember = "MaSP";
        }

        private void cmb_mancc_Click(object sender, EventArgs e)
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

        private void cmb_manv_Click(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(con);
            string query = "select MaNV,TenNV from NhanVien";
            da = new SqlDataAdapter(query, conn);
            ds = new DataSet();
            SqlCommandBuilder cm = new SqlCommandBuilder(da);
            da.Fill(ds, "NhanVien");
            cmb_manv.DataSource = ds.Tables["NhanVien"];
            cmb_manv.DisplayMember = "MaNV";
            cmb_manv.ValueMember = "MaNV";
        }

        private void UCHDNhap_Load(object sender, EventArgs e)
        {
            getdata();
        }

        private void btn_quaylai_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_timkiemmaSP_Click(object sender, EventArgs e)
        {
            try
            {
                string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection conn = new SqlConnection(con);
                conn.Open();
                string query = "select * from PhieuNhap where MaSP=N'" + cmb_masp.Text + "'  ";
                da = new SqlDataAdapter(query, conn);
                ds = new DataSet();
                SqlCommandBuilder sd = new SqlCommandBuilder(da);
                da.Fill(ds, "PhieuNhap");
                dgv_hienthi.DataSource = ds.Tables["PhieuNhap"];
            }
            catch
            {
                MessageBox.Show("Không Tìm Thấy!!");
            }
        }

        private void btn_timkiemmancc_Click(object sender, EventArgs e)
        {
            try
            {
                string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection conn = new SqlConnection(con);
                conn.Open();
                string query = "select * from PhieuNhap where MaNCC=N'" + cmb_mancc.Text + "'  ";
                da = new SqlDataAdapter(query, conn);
                ds = new DataSet();
                SqlCommandBuilder sd = new SqlCommandBuilder(da);
                da.Fill(ds, "PhieuNhap");
                dgv_hienthi.DataSource = ds.Tables["PhieuNhap"];
            }
            catch
            {
                MessageBox.Show("Không Tìm Thấy!!");
            }
        }

        private void btn_timkiemmaNV_Click(object sender, EventArgs e)
        {
            try
            {
                string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection conn = new SqlConnection(con);
                conn.Open();
                string query = "select * from PhieuNhap where MaNV=N'" + cmb_manv.Text + "'  ";
                da = new SqlDataAdapter(query, conn);
                ds = new DataSet();
                SqlCommandBuilder sd = new SqlCommandBuilder(da);
                da.Fill(ds, "PhieuNhap");
                dgv_hienthi.DataSource = ds.Tables["PhieuNhap"];
            }
            catch
            {
                MessageBox.Show("Không Tìm Thấy!!");
            }
        }

        private void btn_timkiemngaynhap_Click(object sender, EventArgs e)
        {
            try
            {
                string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection conn = new SqlConnection(con);
                conn.Open();
                string query = "select * from PhieuNhap where NgayNhap=N'" + dgp_ngaynhap.Value + "'  ";
                da = new SqlDataAdapter(query, conn);
                ds = new DataSet();
                SqlCommandBuilder sd = new SqlCommandBuilder(da);
                da.Fill(ds, "PhieuNhap");
                dgv_hienthi.DataSource = ds.Tables["PhieuNhap"];
            }
            catch
            {
                MessageBox.Show("Không Tìm Thấy!!");
            }
        }

        private void btn_timkiemgianhap_Click(object sender, EventArgs e)
        {
            try
            {
                string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection conn = new SqlConnection(con);
                conn.Open();
                string query = "select * from PhieuNhap where GiaNhap=N'" + txtGiaNhap.Text + "'  ";
                da = new SqlDataAdapter(query, conn);
                ds = new DataSet();
                SqlCommandBuilder sd = new SqlCommandBuilder(da);
                da.Fill(ds, "PhieuNhap");
                dgv_hienthi.DataSource = ds.Tables["PhieuNhap"];
            }
            catch
            {
                MessageBox.Show("Không Tìm Thấy!!");
            }
        }
    }
}
