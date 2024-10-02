using System;

abstract class SanPham
{
    public string TenSanPham { get; set; }
    public decimal Gia { get; set; }
    public int TonKho { get; set; }

    public SanPham(string tenSanPham, decimal gia, int tonKho)
    {
        TenSanPham = tenSanPham;
        Gia = gia;
        TonKho = tonKho;
    }

    public abstract void HienThiThongTinSanPham();
    public abstract void ApDungGiamGia(decimal phanTram);
}

interface IBanDuoc
{
    void Ban(int soLuong);
    bool KiemTraTonKho();
}

class DienThoaiDiDong : SanPham, IBanDuoc
{
    public string ThuongHieu { get; set; }
    public string MauSac { get; set; }

    public DienThoaiDiDong(string tenSanPham, decimal gia, int tonKho, string thuongHieu, string mauSac)
        : base(tenSanPham, gia, tonKho)
    {
        ThuongHieu = thuongHieu;
        MauSac = mauSac;
    }

    public override void HienThiThongTinSanPham()
    {
        Console.WriteLine($"[Dien thoai] Ten: {TenSanPham}, Thuong hieu: {ThuongHieu}, Mau sac: {MauSac}, Gia: {Gia:C}, Ton kho: {TonKho}");
    }

    public override void ApDungGiamGia(decimal phanTram)
    {
        Gia -= Gia * phanTram / 100;
    }

    public void Ban(int soLuong)
    {
        if (soLuong <= TonKho)
        {
            TonKho -= soLuong;
            Console.WriteLine($"Da ban {soLuong} san pham {TenSanPham}.");
        }
        else
        {
            Console.WriteLine("Khong du hang ton kho.");
        }
    }

    public bool KiemTraTonKho()
    {
        return TonKho > 0;
    }
}

class MayTinhXachTay : SanPham, IBanDuoc
{
    public string ThuongHieu { get; set; }
    public string CPU { get; set; }

    public MayTinhXachTay(string tenSanPham, decimal gia, int tonKho, string thuongHieu, string cpu)
        : base(tenSanPham, gia, tonKho)
    {
        ThuongHieu = thuongHieu;
        CPU = cpu;
    }

    public override void HienThiThongTinSanPham()
    {
        Console.WriteLine($"[May tinh] Ten: {TenSanPham}, Thuong hieu: {ThuongHieu}, CPU: {CPU}, Gia: {Gia:C}, Ton kho: {TonKho}");
    }

    public override void ApDungGiamGia(decimal phanTram)
    {
        Gia -= Gia * phanTram / 100;
    }

    public void Ban(int soLuong)
    {
        if (soLuong <= TonKho)
        {
            TonKho -= soLuong;
            Console.WriteLine($"Da ban {soLuong} san pham {TenSanPham}.");
        }
        else
        {
            Console.WriteLine("Khong du hang ton kho.");
        }
    }

    public bool KiemTraTonKho()
    {
        return TonKho > 0;
    }
}

class PhuKien : SanPham, IBanDuoc
{
    public string TuongThich { get; set; }

    public PhuKien(string tenSanPham, decimal gia, int tonKho, string tuongThich)
        : base(tenSanPham, gia, tonKho)
    {
        TuongThich = tuongThich;
    }

    public override void HienThiThongTinSanPham()
    {
        Console.WriteLine($"[Phu kien] Ten: {TenSanPham}, Tuong thich: {TuongThich}, Gia: {Gia:C}, Ton kho: {TonKho}");
    }

    public override void ApDungGiamGia(decimal phanTram)
    {
        Gia -= Gia * phanTram / 100;
    }

    public void Ban(int soLuong)
    {
        if (soLuong <= TonKho)
        {
            TonKho -= soLuong;
            Console.WriteLine($"Da ban {soLuong} san pham {TenSanPham}.");
        }
        else
        {
            Console.WriteLine("Khong du hang ton kho.");
        }
    }

    public bool KiemTraTonKho()
    {
        return TonKho > 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        DienThoaiDiDong dienThoai = new DienThoaiDiDong("Samsung Galaxy S23", 15000000m, 30, "Samsung", "Den");
        MayTinhXachTay laptop = new MayTinhXachTay("MacBook Air", 30000000m, 15, "Apple", "M1");
        PhuKien phuKien = new PhuKien("Tai nghe Bluetooth", 1000000m, 50, "Tat ca dien thoai");

        dienThoai.HienThiThongTinSanPham();
        laptop.HienThiThongTinSanPham();
        phuKien.HienThiThongTinSanPham();

        dienThoai.Ban(5);
        laptop.Ban(2);
        phuKien.Ban(10);

        Console.WriteLine(dienThoai.KiemTraTonKho() ? "Dien thoai con hang." : "Dien thoai het hang.");
        Console.WriteLine(laptop.KiemTraTonKho() ? "Laptop con hang." : "Laptop het hang.");
        Console.WriteLine(phuKien.KiemTraTonKho() ? "Phu kien con hang." : "Phu kien het hang.");

        dienThoai.ApDungGiamGia(10);
        laptop.ApDungGiamGia(5);
        phuKien.ApDungGiamGia(20);

        Console.WriteLine("\nSau khi giam gia:");
        dienThoai.HienThiThongTinSanPham();
        laptop.HienThiThongTinSanPham();
        phuKien.HienThiThongTinSanPham();
    }
}
