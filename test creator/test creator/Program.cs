using System;

namespace test_creator
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            //depart 
            Console.Write("Flyth: ");
            string  flyth = Console.ReadLine(); 
            Console.Write("Passangers: ");
            int passangers = int.Parse (Console.ReadLine());
            Console.Write("Permsion: ");
            string permision = Console.ReadLine();
            int avaibleSpots = 600;
            int totalVisitors=0;
            int hour = 0;
            int minutes = 0;
            int day = 0;
            int delay;
            int gatesAvaible = 6;
            int busyGates=0;
            string status = "";


            while (hour<24)
                {
                minutes += 10;

                while (permision == "granted" || permision == "yes" && gatesAvaible != 0 && status == "Clear")
                    {
                    totalVisitors += passangers;
                    if (avaibleSpots < totalVisitors) //avoid overwhelming the security and lugadge 
                        { 
                        Console.WriteLine("Overcrouded!");
                        status = "Overcrouded";
                        minutes += 10;
                        
                        }
                    else
                        {
                        Console.WriteLine($"Avaible spots [{avaibleSpots - totalVisitors}]");
                        status = "Clear";
                        }
                    busyGates++;
                    if (gatesAvaible == busyGates) // not avaible bays so delay till clear WIP
                        {
                        Console.WriteLine("No more gates. You have to wait!");
                        break;
                        }
                    Console.WriteLine($"{hour}:{minutes}");
                    Console.Write("Flyth: ");
                    flyth = Console.ReadLine();
                    if (flyth== "delay") //delay
                        {
                        Console.Write("How much time till the next flight: ");
                        delay = int.Parse(Console.ReadLine());
                        minutes += delay;
                        while (minutes >= 60) { hour++; minutes -= 60; }
                        break;
                        }
                    Console.Write("Passangers: ");
                    passangers = int.Parse (Console.ReadLine());
                    Console.Write("Permsion: ");
                    permision = Console.ReadLine();
                    minutes += 10;
                    totalVisitors -= 50;
                    while (minutes >= 60) { hour++; minutes -= 60; }
                    if (hour > 24) { day += 1; hour = 0; }
                    
                    }
                Console.WriteLine("Permision DENIED! Wait for permision!");
                Console.WriteLine($"{hour}:{minutes}");
                permision = Console.ReadLine();
                }
            }
        }
    }
