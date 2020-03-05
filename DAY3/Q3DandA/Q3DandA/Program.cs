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

            Console.WriteLine("Question 1 !!!");
            int[] testQ1arr1 = new int[] { 1, 2, 3, 4 };
            int testQ1Len1 = 2;
            int[] testQ1arr2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8};
            int testQ1Len2 = 3;
            Question1Proper question1 = new Question1Proper();
            int[][] q1ResultTest1 = question1.subArrs(testQ1arr1, testQ1Len1);
            for (int i = 0; i < q1ResultTest1.Length; i++)
            {
                for (int j = 0; j < q1ResultTest1[i].Length; j++)
                {
                    Console.Write(q1ResultTest1[i][j]);
                }
                Console.WriteLine();
            }
            int[][] q1ResultTest2 = question1.subArrs(testQ1arr2, testQ1Len2);
            for (int i = 0; i < q1ResultTest2.Length; i++)
            {
                for (int j = 0; j < q1ResultTest2[i].Length; j++)
                {
                    Console.Write(q1ResultTest2[i][j]);
                }
                Console.WriteLine();
            }

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
            question3.BuildPyramid(-1);
            question3.BuildPyramid(1);
            question3.BuildPyramid(2);
            question3.BuildPyramid(3);
            question3.BuildPyramid(4);
            question3.BuildPyramid(7);

            Question5 question5 = new Question5();
            question5.PrintPascal(5);

            Console.ReadLine();
        }
    }
}
