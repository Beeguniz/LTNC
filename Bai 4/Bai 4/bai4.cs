using System;
using System.Collections.Generic;

class BaseConverter
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        while (true)
        {
            Console.WriteLine("Chọn hệ cơ số đầu vào:");
            Console.WriteLine("1. Nhị phân (Base 2)");
            Console.WriteLine("2. Thập phân (Base 10)");
            Console.WriteLine("3. Thập lục phân (Base 16)");
            int inputBaseChoice = int.Parse(Console.ReadLine());

            if (inputBaseChoice < 1 || inputBaseChoice > 3)
            {
                Console.WriteLine("Lựa chọn không hợp lệ, vui lòng chọn lại!");
                continue;
            }

            Console.WriteLine("Chọn hệ cơ số đầu ra:");
            Console.WriteLine("1. Nhị phân (Base 2)");
            Console.WriteLine("2. Thập phân (Base 10)");
            Console.WriteLine("3. Thập lục phân (Base 16)");
            int outputBaseChoice = int.Parse(Console.ReadLine());

            if (outputBaseChoice < 1 || outputBaseChoice > 3)
            {
                Console.WriteLine("Lựa chọn không hợp lệ, vui lòng chọn lại!");
                continue;
            }

            Console.WriteLine("Nhập giá trị đầu vào:");

            string inputValue = Console.ReadLine();

            try
            {
                int decimalValue = 0;

                if (inputBaseChoice == 1)
                {
                    decimalValue = Convert.ToInt32(inputValue, 2);
                }
                else if (inputBaseChoice == 2) 
                {
                    decimalValue = int.Parse(inputValue); 
                }
                else if (inputBaseChoice == 3) 
                {
                    decimalValue = Convert.ToInt32(inputValue, 16);
                }

                if (outputBaseChoice == 1) 
                {
                    Console.WriteLine($"Giá trị sau khi chuyển đổi sang nhị phân: {Convert.ToString(decimalValue, 2)}");
                }
                else if (outputBaseChoice == 2) 
                {
                    Console.WriteLine($"Giá trị sau khi chuyển đổi sang thập phân: {decimalValue}");
                }
                else if (outputBaseChoice == 3) 
                {
                    Console.WriteLine($"Giá trị sau khi chuyển đổi sang thập lục phân: {Convert.ToString(decimalValue, 16).ToUpper()}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Giá trị đầu vào không hợp lệ, vui lòng nhập lại!");
            }


            Console.WriteLine("\nBạn có muốn tiếp tục (y/n)?");
            string continueChoice = Console.ReadLine();
            if (continueChoice.ToLower() != "y")
            {
                break;
            }
        }
    }
}
