using System;

namespace _03.DepositCalculator
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            double deposit = double.Parse(Console.ReadLine());
            int mounts  =   int.Parse(Console.ReadLine());
            double interest = double.Parse(Console.ReadLine()); //ne zabravqi da convertnesh v %
            double total = deposit + mounts * ((deposit * (interest/100)) / 12);
            Console.WriteLine(total);

            }
        }
    }
