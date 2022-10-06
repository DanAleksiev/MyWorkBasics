using System;

namespace _11._Fruit_Shop
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            double totalPrice = 0;
            switch (day)
                {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                case "Saturday":
                case "Sunday":
                if (day == "Saturday" || day == "Sunday")
                    {
                    switch (fruit)
                        {
                        case "banana":
                        totalPrice = amount * 2.70;
                        Console.WriteLine($"{totalPrice:f2}");
                        break;
                        case "apple":
                        totalPrice = amount * 1.25;
                        Console.WriteLine($"{totalPrice:f2}");
                        break;
                        case "orange":
                        totalPrice = amount * 0.90;
                        Console.WriteLine($"{totalPrice:f2}");
                        break;
                        case "grapefruit":
                        totalPrice = amount * 1.60;
                        Console.WriteLine($"{totalPrice:f2}");
                        break;
                        case "kiwi":
                        totalPrice = amount * 3.00;
                        Console.WriteLine($"{totalPrice:f2}");
                        break;
                        case "pineapple":
                        totalPrice = amount * 5.60;
                        Console.WriteLine($"{totalPrice:f2}");
                        break;
                        case "grapes":
                        totalPrice = amount * 4.20;
                        Console.WriteLine($"{totalPrice:f2}");
                        break;
                        default:
                        Console.WriteLine("error");
                        break;
                        }
                    }
                else
                    {
                    switch (fruit)
                        {
                        case "banana":
                        totalPrice = amount * 2.50;
                        Console.WriteLine($"{totalPrice:f2}");
                        break;
                        case "apple":
                        totalPrice = amount * 1.20;
                        Console.WriteLine($"{totalPrice:f2}");
                        break;
                        case "orange":
                        totalPrice = amount * 0.85;
                        Console.WriteLine($"{totalPrice:f2}");
                        break;
                        case "grapefruit":
                        totalPrice = amount * 1.45;
                        Console.WriteLine($"{totalPrice:f2}");
                        break;
                        case "kiwi":
                        totalPrice = amount * 2.70;
                        Console.WriteLine($"{totalPrice:f2}");
                        break;
                        case "pineapple":
                        totalPrice = amount * 5.50;
                        Console.WriteLine($"{totalPrice:f2}");
                        break;
                        case "grapes":
                        totalPrice = amount * 3.85;
                        Console.WriteLine($"{totalPrice:f2}");
                        break;
                        default:
                        Console.WriteLine("error");
                        break;
                        }

                    }
                break;
                default:
                Console.WriteLine("error");
                break;
                }
            }
        }
    }
