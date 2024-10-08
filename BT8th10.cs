using System;
using System.Collections.Generic;

abstract class PhuongTien
{
    public string TenPhuongTien { get; set; }
    public string LoaiNhienLieu { get; set; }

    public PhuongTien(string ten, string loaiNhienLieu)
    {
        TenPhuongTien = ten;
        LoaiNhienLieu = loaiNhienLieu;
    }

    public abstract void DiChuyen();
}

interface IThongTinThem
{
    int TocDoToiDa();
    double MucTieuThuNhienLieu();
}

class XeHoi : PhuongTien, IThongTinThem
{
    public XeHoi(string ten, string loaiNhienLieu) : base(ten, loaiNhienLieu) { }

    public override void DiChuyen()
    {
        Console.WriteLine($"{TenPhuongTien} di chuyen bang cach chay tren duong cao toc.");
    }

    public int TocDoToiDa()
    {
        return 200;
    }

    public double MucTieuThuNhienLieu()
    {
        return 8.5;
    }
}

class XeDap : PhuongTien, IThongTinThem
{
    public XeDap(string ten) : base(ten, "Khong su dung nhien lieu") { }

    public override void DiChuyen()
    {
        Console.WriteLine($"{TenPhuongTien} di chuyen bang cach dap tren duong.");
    }

    public int TocDoToiDa()
    {
        return 25;
    }

    public double MucTieuThuNhienLieu()
    {
        return 0.0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<PhuongTien> danhSachPhuongTien = new List<PhuongTien>();

        XeHoi xeHoi = new XeHoi("Xe Hoi", "Xang");
        XeDap xeDap = new XeDap("Xe Dap");

        danhSachPhuongTien.Add(xeHoi);
        danhSachPhuongTien.Add(xeDap);

        foreach (var phuongTien in danhSachPhuongTien)
        {
            Console.WriteLine($"Phuong tien: {phuongTien.TenPhuongTien}");
            Console.WriteLine($"Loai nhien lieu: {phuongTien.LoaiNhienLieu}");
            phuongTien.DiChuyen();

            if (phuongTien is IThongTinThem thongTinThem)
            {
                Console.WriteLine($"Toc do toi da: {thongTinThem.TocDoToiDa()} km/h");

                if (phuongTien is XeHoi)
                {
                    Console.WriteLine($"Muc tieu thu nhien lieu: {thongTinThem.MucTieuThuNhienLieu()} lit/100km");
                }
            }

            Console.WriteLine();
        }
    }
}
