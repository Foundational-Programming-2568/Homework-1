// See https://aka.ms/new-console-template for more information
// 1. เลขคี่
Console.WriteLine("เลขคี่:");
for (int i = 1; i <= 100; i += 2)
{
    Console.Write(i + " ");
}
Console.WriteLine("\n");

// 2. เลขคู่
Console.WriteLine("เลขคู่:");
for (int i = 2; i <= 100; i += 2)
{
    Console.Write(i + " ");
}
Console.WriteLine("\n");

// 3. จำนวนเฉพาะ
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
    {
        Console.Write(i + " ");
    }
}
Console.WriteLine();

