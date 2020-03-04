using System;
using System.Collections.Generic;
using System.Text;

namespace Q3DandA.Classes
{
    public class Question3
    {
        public void BuildPyramid(int inputN)
        {
            if(inputN < 1)
            {
                Console.WriteLine("No pyramids built here.");
            }
            else
            {
                int space;
                int number;
                for (int i = 1; i <= inputN; i++)
                {
                    for (space = 1; space <= (inputN - i); space++)
                    {
                        Console.Write(" ");
                    }
                    for (number = 1; number <= i; number++)
                    {
                        Console.Write("#");
                    }
                    for (number = (i-1); number >= 1; number--)
                    {
                        Console.Write("#");
                    }
                }
            }
        }
    }
}
