using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace QLBH
{
    public partial class Home : Form
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

       

        public Home()
        {
            InitializeComponent();
           
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        static Home _obj;
        public static Home Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Home();

                }
                return _obj;
            }
        }
        public Panel pnlContainer
        {
            get
            {
                return pn_content;
            }
            set
            {
                pn_content = value;
            }
        }
    
        private void Home_Load(object sender, EventArgs e)
        {
            lbUser.Text = Form1.username;
           
            timer1.Start();
            lbTime.Text = DateTime.Now.ToLongTimeString();           

            _obj = this;
            UCMain uc = new UCMain();
            uc.Dock = DockStyle.Fill;
            pnlContainer.Controls.Add(uc);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            this.Hide();
        }

        private void btn_NhanVien_Click(object sender, EventArgs e)
        {
            UCNhanVien fr1 = new UCNhanVien();
            MainControlClasses.showControl(fr1,pn_content);
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            UCKhachHang fr1 = new UCKhachHang();
            MainControlClasses.showControl(fr1, pn_content);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UCNhaCungCap fr1 = new UCNhaCungCap();
            MainControlClasses.showControl(fr1, pn_content);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_doimatkhau_Click(object sender, EventArgs e)
        {
            ChangePassWord fr1 = new ChangePassWord();       
            fr1.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void btn_hoadon_Click(object sender, EventArgs e)
        {

            UCHoaDon fr1 = new UCHoaDon();
            MainControlClasses.showControl(fr1, pn_content);
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            UCMain fr1 = new UCMain();
            MainControlClasses.showControl(fr1, pn_content);
        }

        private void btn_sanpham_Click(object sender, EventArgs e)
        {
            UCSanPham fr1 = new UCSanPham();
            MainControlClasses.showControl(fr1, pn_content);
        }

        private void pn_content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            UCThongKe fr1 = new UCThongKe();
            MainControlClasses.showControl(fr1, pn_content);
        }
    }
}
