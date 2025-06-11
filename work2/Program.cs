// See https://aka.ms/new-console-template for more information
{
        System.Console.Write("กรุณาใส่อายุของคุณ: ");
        string input = System.Console.ReadLine();

        if (int.TryParse(input, out int age))
        {
            if (age >= 1 && age <= 12)
            {
                System.Console.WriteLine("กลุ่ม: เด็ก");
            }
            else if (age >= 13 && age <= 19)
            {
                System.Console.WriteLine("กลุ่ม: วัยรุ่น");
            }
            else if (age >= 20 && age <= 50)
            {
                System.Console.WriteLine("กลุ่ม: วัยผู้ใหญ่");
            }
            else if (age >= 51)
            {
                System.Console.WriteLine("กลุ่ม: วัยชรา");
            }
            else
            {
                System.Console.WriteLine("อายุต้องมากกว่า 0");
            }
        }
        else
        {
            System.Console.WriteLine("กรุณาใส่ตัวเลขเท่านั้น");
        }
    }
