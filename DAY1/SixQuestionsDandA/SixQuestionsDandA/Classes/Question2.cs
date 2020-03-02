using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SixQuestionsDandA.Classes
{
    public class Question2
    {
        public int NewLength(int[] nums, int val)
        {
            int initalLength = nums.Length;
            nums = nums.Where((item, value) => value != val).ToArray();
            int result = nums.Length;
            return result;
        }

        public int InitialLength(int[] nums, int val)
        {
            int initalLen = nums.Length;
            nums = nums.Where((value) => value != val).ToArray();
            
            int result = nums.Length;
            return initalLen;
        }
    }
}
