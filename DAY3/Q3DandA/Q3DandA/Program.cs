using System;
using Q3DandA.Classes;

namespace Q3DandA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Third Day");
            Console.WriteLine("");

            Question2 question2 = new Question2();
            Console.WriteLine("Question 2 !!!!");
            string testQ2str1 = "?rail? !SafeTy!";
            string testQ2str2 = "fairy tales";
            string testQ2str3 = "rail safeee";
            Console.WriteLine($"Question 2:?rail? !SafeTy!: rail safety: {question2.AreStringsAnagrams(testQ2str1, testQ2str2)} ");
            Console.WriteLine($"Question 2:rail? SafeTy!: rail safeee: {question2.AreStringsAnagrams(testQ2str1, testQ2str3)} ");

            Console.WriteLine("");

            Question3 question3 = new Question3();
            Console.WriteLine("Question 3 !!!!");
            Console.WriteLine("Q3 Input: -1");
            question3.BuildPyramid(-1);
            Console.WriteLine("Q3 Input: 1");
            question3.BuildPyramid(1);
            Console.WriteLine("Q3 Input: 4");
            question3.BuildPyramid(4);

            Console.ReadLine();
        }
    }
}
