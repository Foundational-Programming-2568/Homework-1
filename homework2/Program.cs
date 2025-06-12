// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        Console.Write("กรุณากรอกอายุของคุณ: ");
        int age = int.Parse(Console.ReadLine());

        if (age >= 1 && age <= 12)
        {
            Console.WriteLine("เด็ก");
        }
        else if (age >= 13 && age <= 19)
        {
            Console.WriteLine("วัยรุ่น");
        }
        else if (age >= 20 && age <= 50)
        {
            Console.WriteLine("วัยผู้ใหญ่");
        }
        else if (age >= 51)
        {
            Console.WriteLine("วัยชรา");
        }
        else
        {
            Console.WriteLine("กรุณากรอกอายุที่ถูกต้อง");
        }
    }
}