using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SixQuestionsDandA.Classes
{
    public class Question2
    {
        public int InitialLength(int[] nums, int val)
        {
            int initalLen = nums.Length;
            return initalLen;
        }

        public int LINQLength(int[] nums, int val)
        {
            int initalLength = nums.Length;
            nums = nums.Where((source, value) => value != val).ToArray();
            int result = nums.Length;
            return result;
        }

        public int NewLength(int[] nums, int val)
        {
            for (int i = 0; i < nums.Length-1; i++)
            {
                if(nums[i] == val)
                {
                    nums[i] = nums[i + 1];
                }
            }
        }
    }
}
