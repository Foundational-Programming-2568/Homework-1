using System;

class Program
{
    static void Main()
    {
        Console.Write("กรุณาใส่อายุของคุณ: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int age))
        {
            if (age >= 1 && age <= 12)
            {
                Console.WriteLine("คุณอยู่ในช่วง: วัยเด็ก");
            }
            else if (age >= 13 && age <= 19)
            {
                Console.WriteLine("คุณอยู่ในช่วง: วัยรุ่น");
            }
            else if (age >= 20 && age <= 50)
            {
                Console.WriteLine("คุณอยู่ในช่วง: วัยผู้ใหญ่");
            }
            else if (age >= 51)
            {
                Console.WriteLine("คุณอยู่ในช่วง: วัยชรา");
            }
            else
            {
                Console.WriteLine("อายุไม่ถูกต้อง (ควรมากกว่า 0)");
            }
        }
        else
        {
            Console.WriteLine("กรุณากรอกตัวเลขที่ถูกต้อง");
        }
    }
}
