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

            Question2 questionTwo = new Question2();
            int[] testTwo = new int[] { 3, 2, 2, 3 };
            Console.WriteLine($"Initial Lenght: {questionTwo.InitialLength(testTwo, 3)}");
            Console.WriteLine($"Final Lenght: {questionTwo.NewLength(testTwo, 3)}");

            Question3 question3 = new Question3();
            int[] test3Arr1 = new int[] { 1, 2, 3, 0, 0, 0 };
            int[] test3Arr2 = new int[] { 2, 5, 6 };
            //int[] question3Result = question3.MergeSort(test3Arr1, test3Arr2);
            Console.WriteLine("Question 3");
            //Console.WriteLine("[{0}]", string.Join(", ", question3Result));

            Question4 question4 = new Question4();

            Question5 question5 = new Question5();


            Question6 question6 = new Question6();
            string test6True = "(){}[]{{}}[[]]({()})";
            string test6False = "((()(){{{{}}{{[[]";
            Console.WriteLine($"True should be: {question6.CharterValidation(test6True)}");
            Console.WriteLine($"False should be: {question6.CharterValidation(test6False)}");

            Console.ReadLine();
        }
    }
}
