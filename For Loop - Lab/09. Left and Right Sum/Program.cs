using System;

namespace _09._Left_and_Right_Sum
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            int numOfRows= int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            for(int i=0; i<2 * numOfRows; i++)  //i zapochva da broi ot 0 sledovatelno 2 * 2 = 3 ( 0,1,2,3 )
                {
                int sum = int.Parse(Console.ReadLine());

                if (i < numOfRows) // 0,1 
                    {
                    leftSum += sum;
                    }
                else                 //2,3 
                    {
                    rightSum += sum;
                    }
                
                }
            if(leftSum == rightSum)
                {
                Console.WriteLine($"Yes, sum = {Math.Abs(leftSum)}");
                }
            else
                {
                Console.WriteLine($"No, diff = {Math.Abs(leftSum-rightSum)}");
                }
            }
        }
    }
