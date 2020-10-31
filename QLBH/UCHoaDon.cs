using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class UCHoaDon : UserControl
    {
        public UCHoaDon()
        {
            InitializeComponent();
        }

        private void btn_hdnhap_Click(object sender, EventArgs e)
        {
            
            UCHDNhap fr1 = new UCHDNhap();
            MainControlClasses.showControl(fr1, pn_contentItem);
          
        }

        private void btn_hdban_Click(object sender, EventArgs e)
        {
            
            UCHDBan fr1 = new UCHDBan();
            MainControlClasses.showControl(fr1, pn_contentItem);
            
        }
    }
}
