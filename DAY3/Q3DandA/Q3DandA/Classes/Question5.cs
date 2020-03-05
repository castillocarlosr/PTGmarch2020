using System;
using System.Collections.Generic;
using System.Text;

namespace Q3DandA.Classes
{
    public class Question5
    {
        public void PrintPascal(int k)
        {
            for (int i = 1; i <= k; i++)
            {
                int line = 1;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(line + " ");
                    line = line * (i - j) / j;
                }
                Console.Write("\n");
            }
        }

        public void SinglePascal(int k)
        {
            int[] resultArr = new int[k];
            int line = 1;
            for (int i = 1; i <= k; i++)
            {
                Console.Write(line + " ");
                line = line * (k - i) / i;
            }
        }
        /*  old way
         *  
        public int[,] TriangleArray(int k)
        {
            int[,] arr = new int[k, k];
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (i == j || j == 0)
                    {
                        arr[i, j] = 1;
                    }
                    else
                    {
                        arr[i, j] = arr[i - 1, j - 1] + arr[i - 1, j];
                    }
                }
            }
            return arr;
        }

        public void PrintPascal(int k)
        {
            int[,] arr = new int[k, k];
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (i == j || j == 0)
                    {
                        arr[i, j] = 1;
                    }
                    else
                    {
                        arr[i, j] = arr[i - 1, j - 1] + arr[i - 1, j];
                    }
                    Console.Write(arr[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
            }
        }
        */
    }
}
