using System;
using SixQuestionsDandA.Classes;

namespace SixQuestionsDandA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello PTG world!");

            Question1 questionOne = new Question1();
            int[] testOne = new int[] { 2, 7, 11, 15 };
            int[] resultOne = questionOne.TwoSumIterative(testOne, 9);
            int[] resultOnePT2 = questionOne.TwoSumEfficient(testOne, 9);
            Console.WriteLine("[{0}]", string.Join(", ", resultOne));
            Console.WriteLine("[{0}]", string.Join(", ", resultOnePT2));

            QuestionTwo questionTwo = new QuestionTwo();
            int[] testTwo = new int[] { 3, 2, 2, 3 };
            Console.WriteLine($"Initial Lenght: {questionTwo.InitialLength(testTwo, 3)}");
            Console.WriteLine($"Final Lenght: {questionTwo.NewLength(testTwo, 3)}");

            Console.ReadLine();
        }
    }
}
