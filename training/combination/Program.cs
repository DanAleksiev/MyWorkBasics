using System;

namespace combination
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            char startLetter = char.Parse(Console.ReadLine());
            char finishLetter = char.Parse(Console.ReadLine());
            char skipLetter = char.Parse(Console.ReadLine());
            int counter = 0;
            
            for (char alphabet = startLetter; alphabet <= finishLetter; alphabet++)
                {
                for (char alphabet2 = startLetter; alphabet2 <= finishLetter; alphabet2++)
                    {
                    for (char alphabet3 = startLetter; alphabet3 <= finishLetter; alphabet3++)
                        {
                        if (alphabet!= skipLetter && alphabet2 != skipLetter && alphabet3 != skipLetter)
                            {
                            Console.Write($"{alphabet}{alphabet2}{alphabet3} ");
                            counter++;
                            
                            }
                        }
                    }                
                }
            Console.Write(counter);
            }
        }
    }
