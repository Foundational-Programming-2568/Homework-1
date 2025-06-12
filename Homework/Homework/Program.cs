// รับค่าอายุและแสดงช่วงวัย

// แสดงข้อความเชิญให้ผู้ใช้กรอกอายุ
Console.Write("กรุณากรอกอายุ: ");

// อ่านค่าที่ผู้ใช้พิมพ์เข้ามา (อาจเป็น null ได้)
string? input = Console.ReadLine();

// ตรวจสอบว่า input ไม่เป็น null และสามารถแปลงเป็น int ได้
if (input != null && int.TryParse(input, out int age))
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
    // กรณีที่ input เป็น null หรือไม่ใช่ตัวเลข
    Console.WriteLine("กรุณากรอกตัวเลขอายุที่ถูกต้อง");
}
