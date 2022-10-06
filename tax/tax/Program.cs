using System;

namespace tax
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            Console.Write("How much do you make an hour: ");
            double hourlyPay = double.Parse (Console.ReadLine());
            Console.Write("How many hours per week: ");
            double hours = double.Parse (Console.ReadLine());
            double mountlyPay = hourlyPay * hours * 4;
            double tax = mountlyPay * 0.2;
            double moneyAfterTax = mountlyPay - tax;
            Console.WriteLine($"You earn {mountlyPay:f2} per mount.");            
            Console.WriteLine($"You'll pay {tax:F2} tax.");
            Console.WriteLine($"You'll get {moneyAfterTax:f2} beore any further deductions.");

            Console.WriteLine($"You'll earn {mountlyPay * 12:f2} for the year");
            Console.WriteLine($"You'll pay {tax * 12:F2} tax for the year");
            Console.WriteLine($"You'll get {moneyAfterTax * 12:f2} beore any further deductions.");

            }
        }
    }
