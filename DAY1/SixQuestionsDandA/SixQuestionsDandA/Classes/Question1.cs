using System;
using System.Collections.Generic;
using System.Text;

namespace SixQuestionsDandA.Classes
{
    public class Question1
    {
        public int[] TwoSumIterative(int[] arr, int k)
        {
            int[] result = new int[2];
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = i+1; j < arr.Length-1; j++)
                {
                    if(arr[i] + arr[j] == k)
                    {
                        result[0] = arr[i];
                        result[1] = arr[j];
                    }
                }
            }
            return result;
        }

        public int[] TwoSumEfficient(int[] arr, int k)
        {
            int[] result = new int[2];
            HashSet<int> hSet = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                int temp = k - arr[i];
                if (hSet.Contains(temp))
                {
                    result[0] = arr[i];
                    result[1] = temp;
                    //return result;
                    break;
                }
                hSet.Add(arr[i]);
            }
            return result;
        }
    }
}
