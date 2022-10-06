using System;

namespace _01._Old_Books
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string favBook = Console.ReadLine();
            string book = Console.ReadLine();
            int num = 0;

            while(book != "No More Books")
                {
                if (favBook == book)
                    {
                    Console.WriteLine($"You checked {num} books and found it.");
                    break;
                    }
                book = Console.ReadLine();
                num++;
                }
            if (book == "No More Books")
                {
                Console.WriteLine($"The book you search is not here!\r\nYou checked {num} books.");
                }
            }
        }
    }
