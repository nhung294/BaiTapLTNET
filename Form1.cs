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
    public partial class Form1 : Form
    {
        private List<DichVu> danhSachDichVu = new List<DichVu> { };
        public Form1()
        {
            InitializeComponent();


            // Khởi tạo danh sách dịch vụ mẫu
            danhSachDichVu.Add(new DichVu { MaDichVu = 1, TenDichVu = "Dịch vụ A", GiaTien = 100000 });
            danhSachDichVu.Add(new DichVu { MaDichVu = 2, TenDichVu = "Dịch vụ B", GiaTien = 200000 });
            danhSachDichVu.Add(new DichVu { MaDichVu = 3, TenDichVu = "Dịch vụ C", GiaTien = 150000 });
            danhSachDichVu.Add(new DichVu { MaDichVu = 4, TenDichVu = "Dịch vụ D", GiaTien = 300000 });

            // Thêm các dịch vụ vào CheckedListBox
            clbDichVu.DataSource = danhSachDichVu;
            clbDichVu.DisplayMember = "TenDichVu";
            clbDichVu.ValueMember = "MaDichVu";

            // Thêm khách hàng vào ComboBox
            cbKhachHang.DataSource = danhSachKhachHang;
            cbKhachHang.DisplayMember = "Ten";
            cbKhachHang.ValueMember = "MaKhachHang";
        }

        private void cbKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private List<KhachHang> danhSachKhachHang = new List<KhachHang>();
        private int maKhachHangCounter = 1; // Biến đếm mã khách hàng


        private void btnXoaKhachHang_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                var rowIndex = dgvKhachHang.SelectedRows[0].Index;
                danhSachKhachHang.RemoveAt(rowIndex);
                CapNhatDanhSachKhachHang();
            }
        }

        private void clbDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private int maKhachHangCount = 1; // Để tạo mã khách hàng tự động tăng
        private void btnThemKhachHang_Click(object sender, EventArgs e)
        {
            // Hiển thị form nhập thông tin khách hàng mới
    var formThemKhach = new FormThemKhachHang();
    if (formThemKhach.ShowDialog() == DialogResult.OK)
    {
        // Tạo mã khách hàng tự động tăng
        var khachHang = new KhachHang
        {
            MaKhachHang = maKhachHangCount++,
            Ten = formThemKhach.TenKhachHang,
            SoDienThoai = formThemKhach.SoDienThoai,
            DiaChi = formThemKhach.DiaChi
        };

        // Thêm khách hàng vào danh sách
        danhSachKhachHang.Add(khachHang);

        // Cập nhật lại DataGridView và ComboBox
        CapNhatDanhSachKhachHang();

        // Cập nhật lại ComboBox để chọn khách hàng mới
        cbKhachHang.DataSource = null;
        cbKhachHang.DataSource = danhSachKhachHang;
        cbKhachHang.DisplayMember = "Ten";
        cbKhachHang.ValueMember = "MaKhachHang";
        cbKhachHang.SelectedItem = khachHang;
    }
        }

        private void btnChinhSuaKhachHang_Click(object sender, EventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                var rowIndex = dgvKhachHang.SelectedRows[0].Index;
                var khachHang = danhSachKhachHang[rowIndex];

                var formChinhSua = new FormChinhSuaKhachHang(khachHang);
                if (formChinhSua.ShowDialog() == DialogResult.OK)
                {
                    // Cập nhật thông tin khách hàng
                    khachHang.Ten = formChinhSua.TenKhachHang;
                    khachHang.SoDienThoai = formChinhSua.SoDienThoai;
                    khachHang.DiaChi = formChinhSua.DiaChi;

                    // Cập nhật lại danh sách khách hàng
                    CapNhatDanhSachKhachHang();
                }
            }
        }      

        private void btnTaoHoaDon_Click(object sender, EventArgs e)
        {
            
            if (cbKhachHang.SelectedItem is KhachHang khachHang)
            {
                var hoaDon = new HoaDon
                {
                    MaHoaDon = DateTime.Now.Ticks.ToString(),
                    KhachHang = khachHang,
                    DịchVụ = clbDichVu.CheckedItems.OfType<DichVu>().ToList()
                };
                List<DichVu> danhSachDichVudachon = new List<DichVu> { };
                danhSachDichVudachon.AddRange(clbDichVu.CheckedItems.OfType<DichVu>().ToList());
                dgvDichVu.DataSource = danhSachDichVudachon;
                lblTongTien.Text = "Tổng tiền: " + hoaDon.TinhTongTien() + " VND";
            }
        }
        private void CapNhatDanhSachKhachHang()
        {
            dgvKhachHang.DataSource = null;
            dgvKhachHang.DataSource = danhSachKhachHang;
        }

        public class KhachHang
        {
            public int MaKhachHang { get; set; }
            public string Ten { get; set; }
            public string SoDienThoai { get; set; }
            public string DiaChi { get; set; }
        }
        public class DichVu
        {
            public int MaDichVu { get; set; }
            public string TenDichVu { get; set; }
            public int GiaTien { get; set; }
        }

        public class HoaDon
        {
            public string MaHoaDon { get; set; }  // Thay đổi kiểu từ int thành string
            public KhachHang KhachHang { get; set; }
            public List<DichVu> DịchVụ { get; set; } = new List<DichVu>();

            public decimal TongTien { get; set; } // Thêm thuộc tính này để lưu tổng tiền

            public HoaDon()
            {
                DịchVụ = new List<DichVu>();
            }

            public int TinhTongTien()
            {
                int TongTien = 0;
                foreach (var dichVu in DịchVụ)
                {
                    TongTien += Convert.ToInt32(dichVu.GiaTien);


                }

                return TongTien;

            }
        }


    }
}
