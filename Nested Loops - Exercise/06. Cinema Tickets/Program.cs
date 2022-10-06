using System;

namespace _06._Cinema_Tickets
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            string film = Console.ReadLine();
            int freeSeats = 0;
            string tipe = "";
            int takenSeats = 0;
            int counter = 0;
            int standard = 0;
            int student = 0;
            int kids = 0;


            while (film != "Finish")
                {
                freeSeats = int.Parse(Console.ReadLine());
               
                while (takenSeats<freeSeats)
                    {
                    tipe = Console.ReadLine();

                    if (tipe == "End")
                        {
                        break;
                        }

                    counter++;
                    takenSeats++;

                    if (tipe == "standard")
                        {
                        standard++;
                        }
                    else if (tipe == "student")
                        {
                        student++;
                        }
                    else if (tipe == "kid")
                        {
                        kids++;
                        }                                    
                    }
                Console.WriteLine($"{film} - {takenSeats*100.00 / freeSeats:f2}% full.");
                film = Console.ReadLine();
                takenSeats = 0;
                              
                }
            Console.WriteLine($"Total tickets: {counter}");
            Console.WriteLine($"{student * 100.00 / counter:f2}% student tickets.");
            Console.WriteLine($"{standard * 100.00 / counter:f2}% standard tickets.");
            Console.WriteLine($"{kids * 100.00 / counter:f2}% kids tickets.");


            }
        }
    }
