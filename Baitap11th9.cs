using System;
using System.Linq;

class BaiTap
{
    // Bai 1: Tao mang so nguyen va tinh tong
    public void Bai1()
    {
        Console.WriteLine("Bai 1: Tinh tong cac phan tu trong mang");
        Console.Write("Nhap so luong phan tu trong mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] mang = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            mang[i] = int.Parse(Console.ReadLine());
        }

        int tong = mang.Sum();
        Console.WriteLine($"Tong cac phan tu trong mang la: {tong}");
    }

    // Bai 2: Dem so luong ky tu trong chuoi
    public void Bai2()
    {
        Console.WriteLine("\nBai 2: Dem so luong ky tu trong chuoi");
        Console.Write("Nhap chuoi: ");
        string chuoi = Console.ReadLine();
        int dem = chuoi.Count(c => !char.IsWhiteSpace(c) && !char.IsPunctuation(c));
        Console.WriteLine($"So luong ky tu khong tinh khoang trang va dau cau la: {dem}");
    }

    // Bai 3: Tim phan tu lon nhat trong mang
    public void Bai3()
    {
        Console.WriteLine("\nBai 3: Tim phan tu lon nhat trong mang");
        Console.Write("Nhap so luong phan tu trong mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] mang = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            mang[i] = int.Parse(Console.ReadLine());
        }

        int max = mang.Max();
        Console.WriteLine($"Phan tu lon nhat trong mang la: {max}");
    }

    // Bai 4: Dao nguoc chuoi
    public void Bai4()
    {
        Console.WriteLine("\nBai 4: Dao nguoc chuoi");
        Console.Write("Nhap chuoi: ");
        string chuoi = Console.ReadLine();
        string daoNguoc = new string(chuoi.Reverse().ToArray());
        Console.WriteLine($"Chuoi sau khi dao nguoc: {daoNguoc}");
    }

    // Bai 5: Kiem tra mang doi xung
    public void Bai5()
    {
        Console.WriteLine("\nBai 5: Kiem tra mang doi xung");
        Console.Write("Nhap so luong phan tu trong mang: ");
        int n = int.Parse(Console.ReadLine());
        int[] mang = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Nhap phan tu thu {i + 1}: ");
            mang[i] = int.Parse(Console.ReadLine());
        }

        bool doiXung = true;
        for (int i = 0; i < n / 2; i++)
        {
            if (mang[i] != mang[n - 1 - i])
            {
                doiXung = false;
                break;
            }
        }

        if (doiXung)
            Console.WriteLine("Mang la doi xung.");
        else
            Console.WriteLine("Mang khong phai la doi xung.");
    }

    // Bai 6: Dem so lan xuat hien cua mot ky tu trong chuoi
    public void Bai6()
    {
        Console.WriteLine("\nBai 6: Dem so lan xuat hien cua mot ky tu trong chuoi");
        Console.Write("Nhap chuoi: ");
        string chuoi = Console.ReadLine();
        Console.Write("Nhap ky tu can dem: ");
char kyTu = char.Parse(Console.ReadLine());

int dem = chuoi.Count(c => c == kyTu);
Console.WriteLine($"So lan xuat hien cua ky tu '{kyTu}' trong chuoi la: {dem}");
    }

    // Phuong thuc Main de goi cac bai tap
    static void Main(string[] args)
{
    BaiTap baiTap = new BaiTap();

    // Goi cac phuong thuc de chay tung bai
    baiTap.Bai1();
    baiTap.Bai2();
    baiTap.Bai3();
    baiTap.Bai4();
    baiTap.Bai5();
    baiTap.Bai6();
}
}