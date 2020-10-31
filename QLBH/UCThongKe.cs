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
    public partial class UCThongKe : UserControl
    {
        public UCThongKe()
        {
            InitializeComponent();
        }
        DataSet ds = null;
        SqlDataAdapter da = null;
        DataSet ds1 = null;
        SqlDataAdapter da1 = null;
        void getdata()
        {
            string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
            SqlConnection conn = new SqlConnection(con);
            string query = "select * from PhieuNhap";
            string query1 = "select * from HDBan";
            da = new SqlDataAdapter(query, conn);
            ds = new DataSet();
            da1 = new SqlDataAdapter(query1, conn);
            ds1 = new DataSet();
            da.Fill(ds, "PhieuNhap");
            da1.Fill(ds1, "HDBan");
            dgv_hienthi.DataSource = ds.Tables["PhieuNhap"];
            dgv_hienthiban.DataSource = ds1.Tables["HDBan"];
        }
        void reset()
        {
           
            dgp_ngayBD.Value = DateTime.Now;
            dgp_ngayKT.Value = DateTime.Now;
            cb_slhangnhap.Checked = false;
            cb_tongtienthumoikhach.Checked = false;
            cb_TSLban.Checked = false;
            cb_TSLtungSPban.Checked = false;
            cb_TTbanTungSP.Checked = false;
            cb_tongtiennhaptungsp.Checked = false;
            cb_khachmuanhieu.Checked = false;
            cb_tongtienmoiNCC.Checked = false;
            cb_tongSLtungSP.Checked = false;
            cb_SLtheoTungNCC.Checked = false;
        }
        private void UCThongKe_Load(object sender, EventArgs e)
        {
            getdata();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            reset();
            getdata();
        }

        private void btnTKNhap_Click(object sender, EventArgs e)
        {
            try
            {
                string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection conn = new SqlConnection(con);
                string query = "select * from PhieuNhap where NgayNhap between'" + dgp_ngayBD.Value + "'AND '" + dgp_ngayKT.Value + "'";
                da = new SqlDataAdapter(query, conn);
                ds = new DataSet();
                da.Fill(ds, "PhieuNhap");
                dgv_hienthi.DataSource = ds.Tables["PhieuNhap"];
                
                if (cb_slhangnhap.Checked)
                {
                    string query1 = "select  SUM(SLNhap)  AS [Tổng SP nhập] from PhieuNhap  where NgayNhap between'" + dgp_ngayBD.Value + "'AND '" + dgp_ngayKT.Value + "' ";
                    da = new SqlDataAdapter(query1, conn);
                    ds = new DataSet();
                  
                    da.Fill(ds, "PhieuNhap");
                    dgv_hienthi.DataSource = ds.Tables["PhieuNhap"];
                    dgv_hienthi.Enabled = false;
                   
                }
                else if (cb_tongSLtungSP.Checked)
                {
                    string query1 = "select MaSP,sum(SLNhap) AS [Tổng số lượng từng SP] from PhieuNhap  where NgayNhap between'" + dgp_ngayBD.Value + "'AND '" + dgp_ngayKT.Value + "'  Group BY MaSP";
                    da = new SqlDataAdapter(query1, conn);
                    ds = new DataSet();

                    da.Fill(ds, "PhieuNhap");
                    dgv_hienthi.DataSource = ds.Tables["PhieuNhap"];
                    dgv_hienthi.Enabled = false;

                }
                else if (cb_tongtiennhaptungsp.Checked)
                {
                    string query1 = "select MaSP,sum(GiaNhap*SLNhap) AS [Tổng tiền nhập cho từng sản phẩm] from PhieuNhap  where NgayNhap between'" + dgp_ngayBD.Value + "'AND '" + dgp_ngayKT.Value + "' Group BY MaSP";
                    da = new SqlDataAdapter(query1, conn);
                    ds = new DataSet();

                    da.Fill(ds, "PhieuNhap");
                    dgv_hienthi.DataSource = ds.Tables["PhieuNhap"];
                    dgv_hienthi.Enabled = false;

                }
                else if (cb_SLtheoTungNCC.Checked)
                {
                    string query1 = "select MaNCC,sum(SLNhap) AS [Lượng hàng nhập từ từng NCC] from PhieuNhap  where NgayNhap between'" + dgp_ngayBD.Value + "'AND '" + dgp_ngayKT.Value + "' Group BY MaNCC";
                    da = new SqlDataAdapter(query1, conn);
                    ds = new DataSet();

                    da.Fill(ds, "PhieuNhap");
                    dgv_hienthi.DataSource = ds.Tables["PhieuNhap"];
                    dgv_hienthi.Enabled = false;

                }
                else if (cb_tongtienmoiNCC.Checked)
                {
                    string query1 = "select MaNCC,sum(SLNhap*GiaNhap) AS [Tổng tiền cho mỗi NCC] from PhieuNhap  where  NgayNhap between'" + dgp_ngayBD.Value + "'AND '" + dgp_ngayKT.Value + "' Group BY MaNCC";
                    da = new SqlDataAdapter(query1, conn);
                    ds = new DataSet();

                    da.Fill(ds, "PhieuNhap");
                    dgv_hienthi.DataSource = ds.Tables["PhieuNhap"];
                    dgv_hienthi.Enabled = false;

                }
                else if(cb_tongtienmoiNCC.Checked && cb_SLtheoTungNCC.Checked)
                {
                    string query1 = "select sum(SLNhap*GiaNhap) AS [Tổng tiền nhập] from PhieuNhap  where NgayNhap between'" + dgp_ngayBD.Value + "'AND '" + dgp_ngayKT.Value + "'";
                    da = new SqlDataAdapter(query1, conn);
                    ds = new DataSet();

                    da.Fill(ds, "PhieuNhap");
                    dgv_hienthi.DataSource = ds.Tables["PhieuNhap"];
                    dgv_hienthi.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Check không hợp lệ !");
            }
        }

        private void cb_slhangnhap_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTKBan_Click(object sender, EventArgs e)
        {
            try
            {
                string con = ConfigurationManager.ConnectionStrings["Myconnection"].ConnectionString;
                SqlConnection conn = new SqlConnection(con);
                string query = "select * from HDBan where NgayBan between'" + dgp_ngayBD.Value + "'AND '" + dgp_ngayKT.Value + "'";
                da1 = new SqlDataAdapter(query, conn);
                ds1 = new DataSet();
                da1.Fill(ds1, "HDBan");
                dgv_hienthiban.DataSource = ds1.Tables["HDBan"];

                if (cb_TSLban.Checked)
                {
                    string query1 = "select  SUM(SoLuong)  AS [Tổng SP Bán] from HDBan  where NgayBan between'" + dgp_ngayBD.Value + "'AND '" + dgp_ngayKT.Value + "' ";
                    da1 = new SqlDataAdapter(query1, conn);
                    ds1 = new DataSet();

                    da1.Fill(ds1, "HDBan");
                    dgv_hienthiban.DataSource = ds1.Tables["HDBan"];
                    dgv_hienthiban.Enabled = false;

                }
                else if (cb_TSLtungSPban.Checked)
                {
                    string query1 = "select MaSP,sum(SoLuong) AS [Tổng số lượng từng SP bán] from HDBan  where NgayBan between'" + dgp_ngayBD.Value + "'AND '" + dgp_ngayKT.Value + "'  Group BY MaSP";
                    da1 = new SqlDataAdapter(query1, conn);
                    ds1 = new DataSet();

                    da1.Fill(ds1, "HDBan");
                    dgv_hienthiban.DataSource = ds1.Tables["HDBan"];
                    dgv_hienthiban.Enabled = false;

                }
                else if (cb_TTbanTungSP.Checked)
                {
                    string query1 = "select MaSP,sum(GiaBan*SoLuong) AS [Tổng tiền bán  từng sản phẩm] from HDBan  where NgayBan between'" + dgp_ngayBD.Value + "'AND '" + dgp_ngayKT.Value + "' Group BY MaSP";
                    da1 = new SqlDataAdapter(query1, conn);
                    ds1 = new DataSet();

                    da1.Fill(ds1, "HDBan");
                    dgv_hienthiban.DataSource = ds1.Tables["HDBan"];
                    dgv_hienthiban.Enabled = false;

                }
                else if (cb_khachmuanhieu.Checked)
                {
                    string query1 = "select  TOP 2 b.MaKH,k.TenKH  from  HDBan b, KhachHang k  where  b.MaKH=k.MaKH and NgayBan between'" + dgp_ngayBD.Value + "'AND '" + dgp_ngayKT.Value + "'ORDER BY SoLuong DESC";
                    da1 = new SqlDataAdapter(query1, conn);
                    ds1 = new DataSet();

                    da1.Fill(ds1, "HDBan");
                    dgv_hienthiban.DataSource = ds1.Tables["HDBan"];
                    dgv_hienthiban.Enabled = false;

                }
                else if (cb_tongtienthumoikhach.Checked)
                {
                    string query1 = "select MaKH,sum(SoLuong*GiaBan) AS [Tổng tiền thu đươc] from HDBan  where  NgayBan between'" + dgp_ngayBD.Value + "'AND '" + dgp_ngayKT.Value + "' Group BY MaKH";
                    da1 = new SqlDataAdapter(query1, conn);
                    ds1 = new DataSet();

                    da1.Fill(ds1, "HDBan");
                    dgv_hienthiban.DataSource = ds1.Tables["HDBan"];
                    dgv_hienthiban.Enabled = false;

                }
               
            }
            catch
            {
                MessageBox.Show("Check không hợp lệ !");
            }
        }
    }
}
