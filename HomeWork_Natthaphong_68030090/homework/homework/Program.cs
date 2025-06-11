using System;

public class AgeCategorizer
{
    public static void Main(string[] args)
    {
        Console.WriteLine("กรุณาป้อนอายุของคุณ:");
        string input = Console.ReadLine();
        int age;

        // ตรวจสอบว่าค่าที่ป้อนเข้ามาเป็นตัวเลขที่ถูกต้องหรือไม่
        if (int.TryParse(input, out age))
        {
            if (age >= 1 && age <= 12)
            {
                Console.WriteLine("คุณอยู่ในกลุ่ม: เด็ก");
            }
            else if (age >= 13 && age <= 19)
            {
                Console.WriteLine("คุณอยู่ในกลุ่ม: วัยรุ่น");
            }
            else if (age >= 20 && age <= 50)
            {
                Console.WriteLine("คุณอยู่ในกลุ่ม: วัยผู้ใหญ่");
            }
            else if (age >= 51)
            {
                Console.WriteLine("คุณอยู่ในกลุ่ม: วัยชรา");
            }
            else
            {
                Console.WriteLine("อายุที่คุณป้อนไม่ถูกต้อง กรุณาป้อนตัวเลขที่เป็นบวก");
            }
        }
        else
        {
            Console.WriteLine("ข้อมูลที่ป้อนไม่ถูกต้อง กรุณาป้อนเป็นตัวเลขเท่านั้น");
        }

        Console.WriteLine("\nกดปุ่มใดๆ เพื่อออก...");
        Console.ReadKey();
    }
}