using System;

namespace _03._Sum_Prime_Non_Prime
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int primeSum = 0;
            int noPrimeSum = 0;
            
            string input = Console.ReadLine();

            while (input != "stop")
                {
                int num = int.Parse (input);
                int prime = 0;
                if (num < 0)
                    {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                    }
                if (num == 0)
                    {
                    input = Console.ReadLine();
                    continue;
                    }
                for (int i = 1; i <= num; i++)
                    {
                    if (num % i == 0)
                        {
                        prime++; 
                        }
                    
                    }
                if (prime <= 2)
                    {
                    primeSum += num;
                    }
                else
                    {
                    noPrimeSum += num;
                    }
                input = Console.ReadLine();
                }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {noPrimeSum}");

            }
        }
    }
