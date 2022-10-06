using System;

namespace ConsoleApp1
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int bitcoinNum = int.Parse(Console.ReadLine());
            double yen = double.Parse(Console.ReadLine());
            double comision = double.Parse(Console.ReadLine());
            double lv = bitcoinNum * 1168;
            double dolar = yen * 0.15;
            double lvFromDolar = dolar * 1.76;
            double euro = (lv+lvFromDolar) / 1.95;
            double total = euro - euro * (comision / 100);
            Console.WriteLine($"{total:f2}");
            }
        }
    }
