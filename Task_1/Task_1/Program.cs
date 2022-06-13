using System;

namespace TestHotels
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] citiesArray = { "Москва", "Владивосток", "Красноярск", "Новосибирск", "Санкт-Петербург", "Сочи" };
            string citiesString = String.Join(", ", citiesArray);
            citiesString = citiesString + '.';
            Console.WriteLine(citiesString);
        }
    }
}

// Время выполнения: 15 минут