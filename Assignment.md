# แบบฝึกหัดที่ 1
## ข้อ 1 ให้ใช้ AI สร้างโปรแกรมที่มีความสามารถต่อไปนี้ ใน Polyglot notebook
- นับเลข 1 – 100
  -  แสดงเฉพาะเลขคี่
  -  แสดงเฉพาะเลขคู่
  -  แสดงเฉพาะเลขจำนวนเฉพาะ
onsole.WriteLine("เลขคี่ 1-100:");
for (int i = 1; i <= 100; i += 2)
{
    Console.Write($"{i} ");
}
Console.WriteLine("\n");

// 2. แสดงเลขคู่
Console.WriteLine("เลขคู่ 1-100:");
for (int i = 2; i <= 100; i += 2)
{
    Console.Write($"{i} ");
}
Console.WriteLine("\n");

// 3. แสดงจำนวนเฉพาะ
Console.WriteLine("จำนวนเฉพาะ 1-100:");
for (int i = 2; i <= 100; i++)
{
    bool isPrime = true;
    for (int j = 2; j <= Math.Sqrt(i); j++)
    {
        if (i % j == 0)
        {
            isPrime = false;
            break;
        }
    }
    if (isPrime)
    {
        Console.Write($"{i} ");
    }
}
Console.WriteLine();
## ข้อ 2 ให้ใช้ AI สร้างโปรแกรมที่มีความสามารถต่อไปนี้ ใน Polyglot notebook
- รับค่าอายุทางคีย์บอร์ด
  - 1 - 12 เด็ก
  - 13 – 19 วัยรุ่น
  - 20 – 50 วัยผู้ใหญ่
  - 51 -  วัยชรา 
