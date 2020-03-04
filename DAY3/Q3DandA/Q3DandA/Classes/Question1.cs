using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q3DandA.Classes
{
    public static class Question1
    {
        public static IEnumerable<IEnumerable<T>> Split<T>(this T[] arr, int length)
        {
            for (int i = 0; i < (float)arr.Length / length; i++)
            {
                yield return arr.Skip(i * length).Take(length);
            }
        }
        public static IEnumerable<IEnumerable<int>> divideSubs(int[] arr, int length)
        {
            int arrLength = arr.Length;
            int numOfSubs = arrLength / length;
            var splitArray = arr.Split(length);
            //int[,] = splitArray.ToArray();
            IEnumerable<IEnumerable<int>> numbers = splitArray;
            return numbers;
        }
    }
}
