// See https://aka.ms/new-console-template for more information
Console.Write("กรุณากรอกอายุ: ");
string input = Console.ReadLine();
int age;

if (int.TryParse(input, out age) && age >= 0)
{
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
    else // age == 0
    {
        Console.WriteLine("ยังไม่เกิด");
    }
}
else
{
    Console.WriteLine("กรุณากรอกอายุที่ถูกต้อง");
}

