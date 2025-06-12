﻿Console.Write("กรุณากรอกอายุ:  ");
if (int.TryParse(Console.ReadLine(), out int age))
{
    if (age >= 1 && age <= 12)
        Console.WriteLine("เด็ก");
    else if (age >= 13 && age <= 19)
        Console.WriteLine("วัยรุ่น");
    else if (age >= 20 && age <= 50)
        Console.WriteLine("วัยผู้ใหญ่");
    else if (age >= 51)
        Console.WriteLine("วัยชรา");
    else
        Console.WriteLine("กรุณากรอกอายุที่ถูกต้อง");
}
else
{
    Console.WriteLine("กรุณากรอกตัวเลขที่ถูกต้อง");
}