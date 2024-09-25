using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        
        Hashtable danhSachNguoi = new Hashtable();

        Console.WriteLine("Nhap ten va tuoi (nhap 'exit' de ket thuc):");

        while (true)
        {
         
            Console.Write("Nhap ten: ");
            string ten = Console.ReadLine();

            
            if (ten.ToLower() == "exit")
            {
                break;
            }

          
            Console.Write("Nhap tuoi: ");
            int tuoi;
            if (int.TryParse(Console.ReadLine(), out tuoi))
            {
             
                danhSachNguoi[ten] = tuoi;
            }
            else
            {
                Console.WriteLine("Vui long nhap mot so nguyen hop le cho tuoi.");
            }
        }

        Console.WriteLine("\nDanh sach ten va tuoi da nhap:");
        foreach (DictionaryEntry entry in danhSachNguoi)
        {
            Console.WriteLine("Ten: {0}, Tuoi: {1}", entry.Key, entry.Value);
        }
    }
}
