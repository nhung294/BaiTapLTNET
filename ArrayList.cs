using System;
using System.Collections;

class Program
{
    static void Main()
    {
        
        ArrayList numbers = new ArrayList();

        Console.WriteLine("Nhap vao cac so nguyen (nhap -1 de ket thuc):");

        
        while (true)
        {
            string inputStr = Console.ReadLine();
            int input;

            if (int.TryParse(inputStr, out input))
            {
                if (input == -1)
                {
                    break; 
                }
                numbers.Add(input); 
            }
            else
            {
                Console.WriteLine("Gia tri nhap vao khong hop le, vui long nhap lai.");
            }
        }
        
        numbers.Sort();

        Console.WriteLine("Danh sach cac so nguyen theo thu tu tang dan:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}
