using System;

namespace TestHotels
{
    class Program
    {
        static void Main(string[] args)
        {
            // В C# для преобразования во float используется дополнительный метод Parse()
            // поэтому решил оставить тип double
            double numeric = Convert.ToDouble(Console.ReadLine());
            double num = numeric % 5;
            if (num < 2.5)
            {
                numeric = numeric - num;
                Console.WriteLine(numeric);
            }
            else
            {
                numeric = numeric - num + 5;
                Console.WriteLine(numeric);
            }
        }
    }
}

// Время выполнения: 20 минут