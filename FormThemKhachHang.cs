using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt6th11
{
    public partial class FormThemKhachHang : Form
    {
        public string TenKhachHang { get; private set; }
        public string SoDienThoai { get; private set; }
        public string DiaChi { get; private set; }
        public FormThemKhachHang()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            TenKhachHang = txtTenKhachHang.Text;
            SoDienThoai = txtSoDienThoai.Text;
            DiaChi = txtDiaChi.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
