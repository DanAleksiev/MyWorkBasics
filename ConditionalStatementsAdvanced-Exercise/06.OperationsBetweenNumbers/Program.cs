using System;

namespace _06.OperationsBetweenNumbers
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char simbal = char.Parse(Console.ReadLine());
            
            double result = 0;
            switch (simbal)
                {
                case '+':
                    result = n1 + n2;
                Console.Write($"{n1} + {n2} = {result}");
                break;

                case'-':
                    result = n1 - n2;
                Console.Write($"{n1} - {n2} = {result}");
                break;

                case'*':
                    result = n1 * n2;
                Console.Write($"{n1} * {n2} = {result}");
                break;

                case'/':
                if (n2 == 0)
                    {
                    Console.Write($"Cannot divide {n1} by zero");
                    }
                else
                    {
                    result = (double)n1 / n2;                       // easy convert from int to double !!!!
                    Console.Write($"{n1} / {n2} = {result:f2}");
                    }
                break;

                case '%':
                 if (n2 == 0)
                    {
                    Console.Write($"Cannot divide {n1} by zero");
                    }
                else
                    {
                    result = n1 % n2;
                    Console.Write($"{n1} % {n2} = {result}");
                    }
                break;
                
                }
            if (simbal == '+' || simbal == '-' || simbal == '*')
                {
                if (result % 2 == 0)
                    {
                    Console.WriteLine(" - even");
                    }
                else
                    {
                    Console.WriteLine(" - odd");

                    }
                }
            }
        }
    }
