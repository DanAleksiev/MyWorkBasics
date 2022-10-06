using System;

namespace _04.VacationBooksList
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int NumberPages = int.Parse(Console.ReadLine());
            int PagesPerHour = int.Parse(Console.ReadLine());
            int Days = int.Parse(Console.ReadLine());
            int total = (NumberPages / PagesPerHour) / Days;
            Console.WriteLine(total);
            }
        }
    }
