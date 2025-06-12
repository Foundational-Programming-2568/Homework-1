
// แสดงเลข 1-100
Console.WriteLine("เลข 1-100:");
for (int i = 1; i <= 100; i++)
{
    Console.Write(i + " ");
}
Console.WriteLine("\n");

// แสดงเลขคี่
Console.WriteLine("เลขคี่:");
for (int i = 1; i <= 100; i += 2)
{
    Console.Write(i + " ");
}
Console.WriteLine("\n");

// แสดงเลขคู่
Console.WriteLine("เลขคู่:");
for (int i = 2; i <= 100; i += 2)
{
    Console.Write(i + " ");
}
Console.WriteLine("\n");

// แสดงจำนวนเฉพาะ
Console.WriteLine("จำนวนเฉพาะ:");
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
        Console.Write(i + " ");
}
Console.WriteLine();