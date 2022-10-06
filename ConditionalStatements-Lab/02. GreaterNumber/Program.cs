using System;

namespace _02._GreaterNumber
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int numOne= int.Parse(Console.ReadLine());
            int numTwo= int.Parse(Console.ReadLine());
            //bool biggerNum = numOne > numTwo
           if(numOne>numTwo) //(biggerNum)
                {
                Console.WriteLine(numOne);
                }
           else
                {
                Console.WriteLine(numTwo);
                }
            }
        }
    }
