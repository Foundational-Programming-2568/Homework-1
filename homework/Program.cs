// See https://aka.ms/new-console-template for more information
Console.Write("กรุณาใส่อายุของคุณ: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int age))
        {
            if (age >= 1 && age <= 12)
            {
                Console.WriteLine("คุณเป็นเด็ก");
            }
            else if (age >= 13 && age <= 19)
            {
                Console.WriteLine("คุณเป็นวัยรุ่น");
            }
            else if (age >= 20 && age <= 50)
            {
                Console.WriteLine("คุณเป็นวัยผู้ใหญ่");
            }
            else if (age > 50)
            {
                Console.WriteLine("คุณเป็นวัยชรา");
            }
            else
            {
                Console.WriteLine("อายุต้องมากกว่า 0");
            }
        }
        else
        {
            Console.WriteLine("กรุณาใส่อายุเป็นตัวเลขที่ถูกต้อง");
        }
