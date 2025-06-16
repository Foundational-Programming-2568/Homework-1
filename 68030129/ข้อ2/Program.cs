using System;

class Program
{
    static void Main()
    {
        // รับค่าอายุจากผู้ใช้ทางคีย์บอร์ด
        Console.Write("กรุณากรอกอายุของคุณ: ");
        int age;
        if (int.TryParse(Console.ReadLine(), out age))
        {
            // ตรวจสอบช่วงอายุและแสดงผลลัพธ์
            if (age >= 1 && age <= 12)
            {
                // อายุ 1 - 12 ปี คือ "เด็ก"
                Console.WriteLine("เด็ก");
            }
            else if (age >= 13 && age <= 19)
            {
                // อายุ 13 - 19 ปี คือ "วัยรุ่น"
                Console.WriteLine("วัยรุ่น");
            }
            else if (age >= 20 && age <= 50)
            {
                // อายุ 20 - 50 ปี คือ "วัยผู้ใหญ่"
                Console.WriteLine("วัยผู้ใหญ่");
            }
            else if (age >= 51)
            {
                // อายุ 51 ปีขึ้นไป คือ "วัยชรา"
                Console.WriteLine("วัยชรา");
            }
            else
            {
                // กรณีอายุน้อยกว่า 1 ปี
                Console.WriteLine("กรุณากรอกอายุที่ถูกต้อง");
            }
        }
        else
        {
            // กรณีกรอกข้อมูลไม่ใช่ตัวเลข
            Console.WriteLine("กรุณากรอกตัวเลขเท่านั้น");
        }
    }
}