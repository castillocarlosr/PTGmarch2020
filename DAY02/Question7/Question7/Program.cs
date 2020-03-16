using System;
using Question7.Classes;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Question 7!");

            QuestionSeven questionSeven = new QuestionSeven();
            Console.Write("Enter a whole Number:  ");
            string inputS7 = Console.ReadLine();
            int inputQ7 = Int32.Parse(inputS7);
            string result = questionSeven.NumbersToWords(inputQ7);
            Console.WriteLine($"{inputS7} is: {result}");

            Console.ReadLine();
        }
    }
}
