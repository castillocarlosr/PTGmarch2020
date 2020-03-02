using System;
using System.Collections.Generic;
using System.Text;

namespace SixQuestionsDandA.Classes
{
    public class Question3
    {
        public int[] MergeSort(int[] nums1, int[] nums2)
        {
            int j = 0; //index for nums2
            for (int i = 0; i < nums1.Length-1; i++)
            {
                if(nums2[j] >= nums1[i])
                {
                    for (int k = nums1.Length-1; k > i; k--)
                    {
                        nums1[k - 1] = nums1[k];
                    }
                    nums1[i] = nums2[j];
                    j++;
                }
            }
            return nums1;
        }
    }
}
