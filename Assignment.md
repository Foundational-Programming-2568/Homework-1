# แบบฝึกหัดที่ 1
## ข้อ 1 ให้ใช้ AI สร้างโปรแกรมที่มีความสามารถต่อไปนี้ ใน Polyglot notebook
- นับเลข 1 – 100
  -  แสดงเฉพาะเลขคี่
  -  แสดงเฉพาะเลขคู่
  -  แสดงเฉพาะเลขจำนวนเฉพาะ

## ข้อ 2 ให้ใช้ AI สร้างโปรแกรมที่มีความสามารถต่อไปนี้ ใน Polyglot notebook
- รับค่าอายุทางคีย์บอร์ด
  - 1 - 12 เด็ก
  - 13 – 19 วัยรุ่น
  - 20 – 50 วัยผู้ใหญ่
  - 51 -  วัยชรา 

# แบบฝึกหัดที่ 1
## ข้อ 1 ให้ใช้ AI สร้างโปรแกรมที่มีความสามารถต่อไปนี้ ใน Polyglot notebook
// แสดงเลขคี่ 1-100
Console.WriteLine("เลขคี่ 1-100:");
for (int i = 1; i <= 100; i++)
{
    if (i % 2 != 0)
        Console.Write(i + " ");
}
Console.WriteLine("\n");

// แสดงเลขคู่ 1-100
Console.WriteLine("เลขคู่ 1-100:");
for (int i = 1; i <= 100; i++)
{
    if (i % 2 == 0)
        Console.Write(i + " ");
}
Console.WriteLine("\n");

// แสดงเลขจำนวนเฉพาะ 1-100
bool IsPrime(int number)
{
    if (number < 2) return false;
    for (int i = 2; i <= Math.Sqrt(number); i++)
        if (number % i == 0) return false;
    return true;
}

Console.WriteLine("เลขจำนวนเฉพาะ 1-100:");
for (int i = 2; i <= 100; i++)
{
    if (IsPrime(i))
        Console.Write(i + " ");
}
Console.WriteLine();

## ข้อ 2 ให้ใช้ AI สร้างโปรแกรมที่มีความสามารถต่อไปนี้ ใน Polyglot notebook
// รับค่าอายุทางคีย์บอร์ด และแสดงช่วงวัย

Console.Write("กรุณากรอกอายุ: ");
int age = int.Parse(Console.ReadLine());

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
else
{
    Console.WriteLine("กรุณากรอกอายุที่ถูกต้อง");
}