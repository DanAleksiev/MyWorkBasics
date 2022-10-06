using System;

namespace _12._Trade_Commissions
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());
            double comision = 0;
            double total = 0;

            switch (city)
                {
                case "Sofia":
                if (0 <= sales && sales <= 500)
                    {
                    comision = 0.05;
                    total = sales * comision;
                    Console.WriteLine($"{total:f2}");
                    }
                else if (sales > 500 && sales <= 1000)
                    {
                    comision = 0.07;
                    total = sales * comision;
                    Console.WriteLine($"{total:f2}");
                    }
                else if (sales > 1000 && sales <= 10000)
                    {
                    comision = 0.08;
                    total = sales * comision;
                    Console.WriteLine($"{total:f2}");
                    }
                else if (sales > 10000)
                    {
                    comision = 0.12;
                    total = sales * comision;
                    Console.WriteLine($"{total:f2}");
                    }
                else if (sales < 0)
                    {
                    Console.WriteLine("error");
                    }
                break;

                case "Varna":
                if (0 <= sales && sales <= 500)
                    {
                    comision = 0.045;
                    total = sales * comision;
                    Console.WriteLine($"{total:f2}");
                    }
                else if (sales > 500 && sales <= 1000)
                    {
                    comision = 0.075;
                    total = sales * comision;
                    Console.WriteLine($"{total:f2}");
                    }
                else if (sales > 1000 && sales <= 10000)
                    {
                    comision = 0.10;
                    total = sales * comision;
                    Console.WriteLine($"{total:f2}");
                    }
                else if (sales > 10000)
                    {
                    comision = 0.13;
                    total = sales * comision;
                    Console.WriteLine($"{total:f2}");
                    }
                else if (sales < 0)
                    {
                    Console.WriteLine("error");
                    }
                break;

                case "Plovdiv":
                if (0 <= sales && sales <= 500)
                    {
                    comision = 0.055;
                    total = sales * comision;
                    Console.WriteLine($"{total:f2}");
                    }
                else if (sales > 500 && sales <= 1000)
                    {
                    comision = 0.08;
                    total = sales * comision;
                    Console.WriteLine($"{total:f2}");
                    }
                else if (sales > 1000 && sales <= 10000)
                    {
                    comision = 0.12;
                    total = sales * comision;
                    Console.WriteLine($"{total:f2}");
                    }
                else if (sales > 10000)
                    {
                    comision = 0.145;
                    total = sales * comision;
                    Console.WriteLine($"{total:f2}");
                    }
                else if (sales < 0)
                    {
                    Console.WriteLine("error");
                    }
                break;

                default:
                Console.WriteLine("error");
                break;


                }
            }
        }
    }
