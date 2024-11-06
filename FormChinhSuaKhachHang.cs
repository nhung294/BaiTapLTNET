using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static bt6th11.Form1;

namespace bt6th11
{
    public partial class FormChinhSuaKhachHang : Form
    {
        public string TenKhachHang { get; private set; }
        public string SoDienThoai { get; private set; }
        public string DiaChi { get; private set; }

        public FormChinhSuaKhachHang(KhachHang khachHang)
        {
            InitializeComponent();
            txtTenKhachHang.Text = khachHang.Ten;
            txtSoDienThoai.Text = khachHang.SoDienThoai;
            txtDiaChi.Text = khachHang.DiaChi;
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
