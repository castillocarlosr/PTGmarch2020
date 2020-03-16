using System;
using System.Collections.Generic;
using System.Text;

namespace Q3DandA.Classes
{
    public class Question3
    {
        public void TestPyramid(int inputN)
        {
            int space, number;
            Console.WriteLine($"Input of {inputN} levels.");
            for (int i = 1; i <= inputN; i++) // Total number of levbels for pramid  
            {
                for (space = 1; space <= (inputN - i); space++) // Loop For Space  
                    Console.Write(" ");
                for (number = 1; number <= i; number++) //increase the value  
                    Console.Write("#");
                for (number = (i - 1); number >= 1; number--) //decrease the value  
                    Console.Write("#");
                Console.WriteLine();
            }
        }
        
        public void BuildPyramid(int N)
        {
            if(N < 1)
            {
                Console.WriteLine("No pyramids built here.");
            }
            else
            {
                int space, number;
                Console.WriteLine($"Input of {N} levels.");
                for (int i = 1; i <= N; i++) // Total number of levbels for pramid  
                {
                    for (space = 1; space <= (N - i); space++) // Loop For Space  
                        Console.Write(" ");
                    for (number = 1; number <= (i*2)-1; number++) //increase the value  
                        Console.Write("#");
                    //for (number = (i - 1); number >= 1; number--) //decrease the value  
                      //  Console.Write("#");
                    Console.WriteLine();
                }
            }
        }
    }
}
