using System;

namespace TestHotels
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = Convert.ToInt32(Console.ReadLine());

            if (4 < value && value < 15)
            {
                Console.WriteLine(value + " компютеров");
            }
            else
            {
                string str = value.ToString();
                int ss = str.Length;
                char symbol = str[str.Length - 1];
                if (symbol == '1')
                {
                    Console.WriteLine(value + " компютер");
                }
                else if (symbol == '2' || symbol == '3' || symbol == '4')
                {
                    Console.WriteLine(value + " компютера");
                }
                else Console.WriteLine(value + " компютеров");

            }
        }
    }
}

// Время выполнения: 40 минут