using System;

namespace _06._Multiply_Table
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string input = Console.ReadLine();
           
            char num1 = input[2];
            char num2 = input[1];
            char num3 = input[0];
            int n1 = num1 - '0';
            int n2 = num2 - '0';
            int n3 = num3 - '0'; // конвертва char в int (0 е placeholder)

            //num1 = int.Parse(input[num1]ToString());  za prevrushtane nz koga no moje da se izpolzva      

            for (int i = 1; i <= n1; i++)
                    {

                    for (int j = 1; j <= n2; j++)
                        {

                        for (int k = 1; k <= n3; k++)
                            {
                            Console.WriteLine($"{i} * {j} * {k} = {i * j * k};");
                            }
                        }
                    }
                

            }
        }
    }
