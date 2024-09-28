using System;
using System.Collections.Generic;
using System.Linq;

public class SinhVien
{
    public string HoTen { get; set; }
    public string MSSV { get; set; }
    public double DiemTrungBinh { get; set; }

    public void NhapThongTin()
    {
        Console.Write("Nhap ho ten sinh vien: ");
        HoTen = Console.ReadLine();
        Console.Write("Nhap ma so sinh vien: ");
        MSSV = Console.ReadLine();
        Console.Write("Nhap diem trung binh: ");
        DiemTrungBinh = double.Parse(Console.ReadLine());
    }

    public void HienThiThongTin()
    {
        Console.WriteLine($"Ho ten: {HoTen}, MSSV: {MSSV}, Diem trung binh: {DiemTrungBinh}");
    }
}

public class DanhSachSinhVien
{
    public List<SinhVien> SinhViens { get; set; }

    public DanhSachSinhVien()
    {
        SinhViens = new List<SinhVien>();
    }

    public void ThemSinhVien(SinhVien sv)
    {
        SinhViens.Add(sv);
    }

    public void HienThiDanhSach()
    {
        foreach (var sv in SinhViens)
        {
            sv.HienThiThongTin();
        }
    }

    public void TimSinhVienTheoMSSV(string mssv)
    {
        var sv = SinhViens.FirstOrDefault(s => s.MSSV == mssv);
        if (sv != null)
        {
            sv.HienThiThongTin();
        }
        else
        {
            Console.WriteLine($"Khong tim thay sinh vien voi MSSV: {mssv}");
        }
    }

    public SinhVien TinhDiemTrungBinhCaoNhat()
    {
        if (SinhViens.Count == 0)
            return null;

        return SinhViens.OrderByDescending(s => s.DiemTrungBinh).FirstOrDefault();
    }
}

class Program
{
    static void Main(string[] args)
    {
        DanhSachSinhVien dsSinhVien = new DanhSachSinhVien();
        int soSinhVien;

        do
        {
            Console.Write("Nhap so luong sinh vien (it nhat 3 sinh vien): ");
            soSinhVien = int.Parse(Console.ReadLine());

            if (soSinhVien < 3)
            {
                Console.WriteLine("Ban phai nhap it nhat 3 sinh vien.");
            }
        } while (soSinhVien < 3);

        for (int i = 0; i < soSinhVien; i++)
        {
            Console.WriteLine($"Nhap thong tin sinh vien thu {i + 1}:");
            SinhVien sv = new SinhVien();
            sv.NhapThongTin();
            dsSinhVien.ThemSinhVien(sv);
        }

        Console.WriteLine("\nDanh sach sinh vien:");
        dsSinhVien.HienThiDanhSach();

        Console.WriteLine("\nSinh vien co diem trung binh cao nhat:");
        SinhVien svMax = dsSinhVien.TinhDiemTrungBinhCaoNhat();
        if (svMax != null)
        {
            svMax.HienThiThongTin();
        }
        else
        {
            Console.WriteLine("Khong co sinh vien nao trong danh sach.");
        }

        Console.Write("\nNhap MSSV de tim kiem sinh vien: ");
        string mssv = Console.ReadLine();
        dsSinhVien.TimSinhVienTheoMSSV(mssv);
    }
}
