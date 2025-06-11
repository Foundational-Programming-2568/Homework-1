// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

for (int i = 1; i <= 12; i++)
{
    Console.WriteLine($"2 x {i} = {2 * i}");
}


for (int month = 1; month <= 12; month++)
{
    var firstDay = new DateTime(2025, month, 1);
    var daysInMonth = DateTime.DaysInMonth(2025, month);
    Console.WriteLine($"เดือน {firstDay.ToString("MMMM yyyy", new System.Globalization.CultureInfo("th-TH"))}");
    Console.WriteLine("อา จ อ พ พฤ ศ ส");
    int currentDayOfWeek = (int)firstDay.DayOfWeek;
    for (int i = 0; i < currentDayOfWeek; i++)
    {
        Console.Write("   ");
    }
    for (int day = 1; day <= daysInMonth; day++)
    {
        Console.Write($"{day,2} ");
        currentDayOfWeek++;
        if (currentDayOfWeek > 6)
        {
            Console.WriteLine();
            currentDayOfWeek = 0;
        }
    }
    Console.WriteLine("\n");
}