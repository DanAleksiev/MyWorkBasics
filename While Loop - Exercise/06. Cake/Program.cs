using System;

namespace _06._Cake
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int hight = int.Parse(Console.ReadLine());
            int widh = int.Parse(Console.ReadLine());
            string guests = Console.ReadLine(); 
            int size = hight * widh;
    
                while (guests != "STOP")
                {
                int num = int.Parse(guests);
                size -= num;
                
                if (size <= 0)
                    {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(size)} pieces more.");
                    break;
                    }
                guests = Console.ReadLine();
                }
            if (guests == "STOP")
                {
                Console.WriteLine($"{size} pieces are left.");            
                }
            }
        }
    }
