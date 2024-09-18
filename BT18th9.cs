using System;
using System.Collections.Generic;

// Lop cha Product
class Product
{
    public string TenSanPham { get; set; }
    public decimal Gia { get; set; }
    public string MoTa { get; set; }
    public int SoLuong { get; set; }

    public Product(string tenSanPham, decimal gia, string moTa, int soLuong)
    {
        TenSanPham = tenSanPham;
        Gia = gia;
        MoTa = moTa;
        SoLuong = soLuong;
    }

    public virtual void HienThiThongTin()
    {
        Console.WriteLine($"Ten san pham: {TenSanPham}, Gia: {Gia}, Mo ta: {MoTa}, So luong: {SoLuong}");
    }
}

// Lop con Electronic ke thua Product
class Electronic : Product
{
    public int BaoHanh { get; set; } // So thang bao hanh

    public Electronic(string tenSanPham, decimal gia, string moTa, int soLuong, int baoHanh)
        : base(tenSanPham, gia, moTa, soLuong)
    {
        BaoHanh = baoHanh;
    }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine($"Bao hanh: {BaoHanh} thang");
    }
}

// Lop con Clothing ke thua Product
class Clothing : Product
{
    public string KichThuoc { get; set; }
    public string MauSac { get; set; }

    public Clothing(string tenSanPham, decimal gia, string moTa, int soLuong, string kichThuoc, string mauSac)
        : base(tenSanPham, gia, moTa, soLuong)
    {
        KichThuoc = kichThuoc;
        MauSac = mauSac;
    }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine($"Kich thuoc: {KichThuoc}, Mau sac: {MauSac}");
    }
}

// Lop con Food ke thua Product
class Food : Product
{
    public DateTime NgayHetHan { get; set; }

    public Food(string tenSanPham, decimal gia, string moTa, int soLuong, DateTime ngayHetHan)
        : base(tenSanPham, gia, moTa, soLuong)
    {
        NgayHetHan = ngayHetHan;
    }

    public override void HienThiThongTin()
    {
        base.HienThiThongTin();
        Console.WriteLine($"Ngay het han: {NgayHetHan.ToShortDateString()}");
    }
}

// Lop ShoppingCart de quan ly gio hang
class ShoppingCart
{
    public List<Product> DanhSachSanPham { get; set; } = new List<Product>();

    public void ThemSanPhamVaoGio(Product sanPham)
    {
        DanhSachSanPham.Add(sanPham);
        Console.WriteLine($"Da them {sanPham.TenSanPham} vao gio hang.");
    }

    public void XoaSanPhamKhoiGio(Product sanPham)
    {
        DanhSachSanPham.Remove(sanPham);
        Console.WriteLine($"Da xoa {sanPham.TenSanPham} khoi gio hang.");
    }

    public void HienThiSanPhamTrongGio()
    {
        Console.WriteLine("San pham trong gio hang:");
        foreach (var sanPham in DanhSachSanPham)
        {
            sanPham.HienThiThongTin();
            Console.WriteLine("----------------------");
        }
    }

    public decimal TinhTongGiaTriDonHang()
    {
        decimal tong = 0;
        foreach (var sanPham in DanhSachSanPham)
        {
            tong += sanPham.Gia * sanPham.SoLuong;
        }
        return tong;
    }
}

// Chuong trinh chinh
class Program
{
    static void Main(string[] args)
    {
        // Tao mot so san pham mau
        Electronic laptop = new Electronic("Laptop", 15000000, "Laptop Dell", 1, 24);
        Clothing ao = new Clothing("Ao thun", 200000, "Ao thun trang", 2, "L", "Trang");
        Food sua = new Food("Sua tuoi", 50000, "Sua tuoi Vinamilk", 5, new DateTime(2024, 12, 31));

        // Tao gio hang
        ShoppingCart gioHang = new ShoppingCart();

        // Them san pham vao gio
        gioHang.ThemSanPhamVaoGio(laptop);
        gioHang.ThemSanPhamVaoGio(ao);
        gioHang.ThemSanPhamVaoGio(sua);

        // Hien thi san pham trong gio
        gioHang.HienThiSanPhamTrongGio();

        // Tinh tong gia tri don hang
        decimal tongGiaTri = gioHang.TinhTongGiaTriDonHang();
        Console.WriteLine($"Tong gia tri don hang: {tongGiaTri} VND");
    }
}
