// โปรแกรมรับค่าอายุทางคีย์บอร์ด และแสดงกลุ่มอายุ

Console.Write("กรุณาใส่อายุของคุณ: ");
string input = Console.ReadLine();
int age;

if (int.TryParse(input, out age))
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
        Console.WriteLine("กรุณาใส่อายุที่ถูกต้อง (มากกว่า 0)");
}
else
{
    Console.WriteLine("กรุณาใส่ตัวเลขเท่านั้น");
}