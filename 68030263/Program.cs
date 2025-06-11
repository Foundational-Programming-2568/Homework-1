int[] ages = { 2, 80, 23, 19, 5, 40, 54, 13 };

// ฟังก์ชันแยกกลุ่มอายุ
string GetAgeGroup(int age)
{
    if (age >= 1 && age <= 12)
        return "เด็ก";
    else if (age >= 13 && age <= 19)
        return "วัยรุ่น";
    else if (age >= 20 && age <= 50)
        return "วัยผู้ใหญ่";
    else if (age >= 51)
        return "วัยชรา";
    else
        return "อายุไม่ถูกต้อง";
}

// แสดงผล
Console.WriteLine("อายุ\tกลุ่มอายุ");
foreach (var age in ages)
{
    Console.WriteLine($"{age}\t{GetAgeGroup(age)}");
}