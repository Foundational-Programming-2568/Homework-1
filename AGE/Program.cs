Console.Write("กรุณากรอกอายุของคุณ: ");
string? input = Console.ReadLine();
if (int.TryParse(input, out int age))
{
    if (age >= 1 && age <= 12)
    {
        Console.WriteLine("คุณอยู่ในช่วงวัย: เด็ก");
    }
    else if (age >= 13 && age <= 19)
    {
        Console.WriteLine("คุณอยู่ในช่วงวัย: วัยรุ่น");
    }
    else if (age >= 20 && age <= 50)
    {
        Console.WriteLine("คุณอยู่ในช่วงวัย: วัยผู้ใหญ่");
    }
    else if (age >= 51)
    {
        Console.WriteLine("คุณอยู่ในช่วงวัย: วัยชรา");
    }
    else
    {
        Console.WriteLine("อายุที่กรอกไม่ถูกต้อง (ควรมากกว่า 0)");
    }
}
else
{
    Console.WriteLine("กรุณากรอกตัวเลขที่ถูกต้อง");
}