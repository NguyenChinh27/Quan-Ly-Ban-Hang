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
    public partial class UCHDBan : UserControl
    {
        public UCHDBan()
        {
            InitializeComponent();
        }
        DataSet ds = null;
        SqlDataAdapter da = null;
        void getdata()
        {
            string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(con);
            string query = "select * from HDBan";
            da = new SqlDataAdapter(query, conn);
            ds = new DataSet();
            SqlCommandBuilder sd = new SqlCommandBuilder(da);
            da.Fill(ds, "HDBan");
            dgv_hienthi.DataSource = ds.Tables["HDBan"];
        }
        void reset()
        {
            txtMaHD.Text = "";
            cmb_maKH.Text = "";
            cmb_manv.Text = "";
            cmb_masp.Text = "";
            nud_soluong.Value = 0;
            txtGiaBan.Text = "";
           
            dgp_ngayban.Value = DateTime.Now;
          

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection conn = new SqlConnection(con);
                conn.Open();
                string query = "insert into  HDBan(MaHDBan,MaSP,MaNV,MaKH,NgayBan,SoLuong, GiaBan)values('" + txtMaHD.Text + "',N'" + cmb_masp.Text + "',N'" + cmb_manv.Text + "',N'" + cmb_maKH.Text + "','" + dgp_ngayban.Value + "'," + nud_soluong.Value + ",'" + txtGiaBan.Text + "' ) ";
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
                errorProvider1.SetError(txtMaHD, "Mã sản phẩm đã tồn tại !");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection conn = new SqlConnection(con);
                conn.Open();
                string query = "update HDBan   set MaSP=N'" + cmb_masp.Text + "' ,MaNV=N'" + cmb_manv.Text + "',MaKH='" + cmb_maKH.Text + "',NgayBan='" + dgp_ngayban.Value + "',SoLuong='" + nud_soluong.Value + "',GiaBan='" + txtGiaBan.Text + "' where MaHDBan='" + txtMaHD.Text + "' ";
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
                    string query = "delete from HDBan where MaHDBan='" + txtMaHD.Text + "' ";
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
            txtMaHD.Enabled = true;
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
                txtMaHD.Text = dgv_hienthi.Rows[i].Cells["MaHDBan"].Value.ToString();
                cmb_masp.Text = dgv_hienthi.Rows[i].Cells["MaSP"].Value.ToString();      
                cmb_manv.Text = dgv_hienthi.Rows[i].Cells["MaNV"].Value.ToString();
                cmb_maKH.Text = dgv_hienthi.Rows[i].Cells["MaKH"].Value.ToString();
              
                dgp_ngayban.Value = Convert.ToDateTime(dgv_hienthi.Rows[i].Cells["NgayBan"].Value.ToString());
                nud_soluong.Value = Convert.ToInt32(dgv_hienthi.Rows[i].Cells["SoLuong"].Value.ToString());
                txtGiaBan.Text = dgv_hienthi.Rows[i].Cells["GiaBan"].Value.ToString();
            }

            txtMaHD.Enabled = false;
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

        private void cmb_maKH_Click(object sender, EventArgs e)
        {
            string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(con);
            string query = "select MaKH,TenKH from KhachHang";
            da = new SqlDataAdapter(query, conn);
            ds = new DataSet();
            SqlCommandBuilder cm = new SqlCommandBuilder(da);
            da.Fill(ds, "KhachHang");
            cmb_maKH.DataSource = ds.Tables["KhachHang"];
            cmb_maKH.DisplayMember = "MaKH";
            cmb_maKH.ValueMember = "MaKH";
        }

        private void UCHDBan_Load(object sender, EventArgs e)
        {
            getdata();
        }

        private void btn_timkiemmaSP_Click(object sender, EventArgs e)
        {
            try
            {
                string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection conn = new SqlConnection(con);
                conn.Open();
                string query = "select * from HDBan where MaSP=N'" + cmb_masp.Text + "'  ";
                da = new SqlDataAdapter(query, conn);
                ds = new DataSet();
                SqlCommandBuilder sd = new SqlCommandBuilder(da);
                da.Fill(ds, "HDBan");
                dgv_hienthi.DataSource = ds.Tables["HDBan"];
            }
            catch
            {
                MessageBox.Show("Không Tìm Thấy!!");
            }
        }

        private void btn_timkiemmanv_Click(object sender, EventArgs e)
        {
            try
            {
                string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection conn = new SqlConnection(con);
                conn.Open();
                string query = "select * from HDBan where MaNV=N'" + cmb_manv.Text + "'  ";
                da = new SqlDataAdapter(query, conn);
                ds = new DataSet();
                SqlCommandBuilder sd = new SqlCommandBuilder(da);
                da.Fill(ds, "HDBan");
                dgv_hienthi.DataSource = ds.Tables["HDBan"];
            }
            catch
            {
                MessageBox.Show("Không Tìm Thấy!!");
            }
        }

        private void btn_timkiemmaKH_Click(object sender, EventArgs e)
        {
            try
            {
                string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection conn = new SqlConnection(con);
                conn.Open();
                string query = "select * from HDBan where MaKH=N'" + cmb_maKH.Text + "'  ";
                da = new SqlDataAdapter(query, conn);
                ds = new DataSet();
                SqlCommandBuilder sd = new SqlCommandBuilder(da);
                da.Fill(ds, "HDBan");
                dgv_hienthi.DataSource = ds.Tables["HDBan"];
            }
            catch
            {
                MessageBox.Show("Không Tìm Thấy!!");
            }
        }

        private void btn_timkiemngayban_Click(object sender, EventArgs e)
        {
            try
            {
                string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection conn = new SqlConnection(con);
                conn.Open();
                string query = "select * from HDBan where NgayBan=N'" + dgp_ngayban.Text + "'  ";
                da = new SqlDataAdapter(query, conn);
                ds = new DataSet();
                SqlCommandBuilder sd = new SqlCommandBuilder(da);
                da.Fill(ds, "HDBan");
                dgv_hienthi.DataSource = ds.Tables["HDBan"];
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
                conn.Open();
                string query = "select * from HDBan where GiaBan=N'" + txtGiaBan.Text + "'  ";
                da = new SqlDataAdapter(query, conn);
                ds = new DataSet();
                SqlCommandBuilder sd = new SqlCommandBuilder(da);
                da.Fill(ds, "HDBan");
                dgv_hienthi.DataSource = ds.Tables["HDBan"];
            }
            catch
            {
                MessageBox.Show("Không Tìm Thấy!!");
            }
        }
    }
}
