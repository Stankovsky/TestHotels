using System;

namespace TestHotels
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = Convert.ToInt32(Console.ReadLine());
            bool state = true;

            if (value == 1 || value == 2 || value == 3 || value == 5)
            {
                Console.WriteLine("Число " + value + " - простое.");
            }
            else if ((value % 2) == 0 || (value % 5) == 0)
            {
                Console.WriteLine("Число " + value + " - не является простым.");
            }
            else
            {
                for (int i = 2; i <= ((value / 2) + 1); i++)
                {
                    if ((value % i) == 0)
                    {
                        state = true;
                        break;
                    }
                    else
                    {
                        state = false;
                    }
                }
                if (state) Console.WriteLine("Число " + value + " - не является простым.");
                else Console.WriteLine("Число " + value + " - простое.");
            }
        }
    }
}

// Время выполнения: 30 минут