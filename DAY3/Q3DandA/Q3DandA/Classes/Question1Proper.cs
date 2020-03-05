using System;
using System.Collections.Generic;
using System.Text;

namespace Q3DandA.Classes
{
    public class Question1Proper
    {
        
        public int[][] subArrs(int[] arr, int len)
        {
            int arrLength = arr.Length;
            int numOfSubs;
            if(arrLength % len == 0)
            {
                numOfSubs = arrLength / len;
            }
            else
            {
                numOfSubs = (arrLength / len) + 1;
            }
            int[][] result = new int[numOfSubs][];
            for (int i = 0; i < numOfSubs-1; i++)
            {
                result[i] = new int[len];
            }
            int remainder = arrLength % len;
            result[numOfSubs - 1] = new int[remainder];
            int count = 0;
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 0; j < result[i].Length; j++)
                {
                    result[i][j] = arr[count];
                    count++;
                }
            }
            return result;
        }
    }
}
