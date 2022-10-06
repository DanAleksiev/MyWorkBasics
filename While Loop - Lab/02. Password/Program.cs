using System;

namespace _02._Password
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string user = Console.ReadLine();
            string pass = Console.ReadLine();
            string inputPass = Console.ReadLine();

            while (inputPass != pass)
                {
                inputPass = Console.ReadLine();
                }
            Console.WriteLine($"Welcome {user}!");
            }
        }
    }
