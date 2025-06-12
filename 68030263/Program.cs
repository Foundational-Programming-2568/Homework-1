

// - แสดงเฉพาะเลขคี่
Console.WriteLine("เลขคี่ 1 - 100:");
for (int i = 1; i <= 100; i++)
{
    if (i % 2 != 0)
        Console.Write($"{i} ");
}
Console.WriteLine("\n");

// - แสดงเฉพาะเลขคู่
Console.WriteLine("เลขคู่ 1 - 100:");
for (int i = 1; i <= 100; i++)
{
    if (i % 2 == 0)
        Console.Write($"{i} ");
}
Console.WriteLine("\n");

// - แสดงเฉพาะเลขจำนวนเฉพาะ
bool IsPrime(int n)
{
    if (n < 2) return false;
    for (int j = 2; j * j <= n; j++)
        if (n % j == 0)
            return false;
    return true;
}

Console.WriteLine("เลขจำนวนเฉพาะ 1 - 100:");
for (int i = 1; i <= 100; i++)
{
    if (IsPrime(i))
        Console.Write($"{i} ");
}
Console.WriteLine();