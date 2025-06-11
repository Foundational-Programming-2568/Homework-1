Console.Write("กรุณาใส่อายุของคุณ: ");
int age;
if (int.TryParse(Console.ReadLine(), out age))
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
        Console.WriteLine("กรุณาใส่อายุที่ถูกต้อง");
}
else
{
    Console.WriteLine("กรุณาใส่อายุที่ถูกต้อง");
}
