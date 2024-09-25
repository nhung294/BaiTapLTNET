using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> danhSachHocSinh = new Dictionary<string, int>();

        Console.WriteLine("Nhap ten va diem cua hoc sinh (nhap 'exit' de ket thuc):");

        while (true)
        {
            
            Console.Write("Nhap ten hoc sinh: ");
            string ten = Console.ReadLine();

            if (ten.ToLower() == "exit")
            {
                break;
            }

            Console.Write("Nhap diem: ");
            int diem;
            if (int.TryParse(Console.ReadLine(), out diem))
            {
                
                danhSachHocSinh[ten] = diem;
            }
            else
            {
                Console.WriteLine("Vui long nhap mot so nguyen hop le cho diem.");
            }
        }

        Console.WriteLine("\nDanh sach hoc sinh va diem:");
        foreach (KeyValuePair<string, int> hocSinh in danhSachHocSinh)
        {
            Console.WriteLine("Ten: {0}, Diem: {1}", hocSinh.Key, hocSinh.Value);
        }
    }
}
