// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.Write("กรุณากรอกอายุ: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int age))
        {
            string category;

            if (age >= 1 && age <= 12)
                category = "เด็ก";
            else if (age >= 13 && age <= 19)
                category = "วัยรุ่น";
            else if (age >= 20 && age <= 50)
                category = "วัยผู้ใหญ่";
            else if (age >= 51)
                category = "วัยชรา";
            else
                category = "อายุไม่ถูกต้อง";

            Console.WriteLine($"คุณอยู่ในช่วง: {category}");
        }
        else
        {
            Console.WriteLine("กรุณากรอกตัวเลขที่ถูกต้อง");
        }
    }
}

