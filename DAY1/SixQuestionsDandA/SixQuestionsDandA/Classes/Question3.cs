using System;
using System.Collections.Generic;
using System.Text;

namespace SixQuestionsDandA.Classes
{
    public class Question3
    {
        public int[] MergeArr(int[] nums1, int[] nums2)
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

        public int[] MergeSort(int[] nums1, int[] nums2)
        {
            int n1 = nums1.Length-1;
            int n2 = nums2.Length-1;
            for(int i=n2; i>0; i--)
            {
                int j, last = nums1[n1];
                for (j = n1-1; j >=0 && nums1[j]>nums2[i] ; j--)
                {
                    nums1[j + 1] = nums1[j];
                }
                if(j != n1-1 || last > nums2[i])
                {
                    nums1[j + 2] = nums2[i];
                    nums2[i] = last;
                }
            }
            return nums1;
        }
    }
}
