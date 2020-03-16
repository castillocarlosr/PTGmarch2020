using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q3DandA.Classes
{
    public class Question4
    {
        public int simpleRect(int[] arr)
        {
            /*
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = +arr[i];
            }
            */
            int sumArr = arr.Sum();
            //Area = Length * Width
            return sumArr;
        }

        public int LargestRectangular(int[] arr)
        {
            {
                int n = arr.Length;
                Stack<int> s = new Stack<int>();

                int max_area = 0; // Initialize max area 
                int tp; // To store top of stack 
                int area_with_top; // To store area with top  
                                   // bar as the smallest bar 

                int i = 0;
                while (i < n)
                {
                    // If this bar is higher than the  
                    // bar on top stack, push it to stack  
                    if (s.Count == 0 || arr[s.Peek()] <= arr[i])
                    {
                        s.Push(i++);
                    }

                    // If this bar is lower than top of stack, 
                    // then calculate area of rectangle with  
                    // stack top as the smallest (or minimum   
                    // height) bar. 'i' is 'right index' for  
                    // the top and element before top in stack 
                    // is 'left index'  
                    else
                    {
                        tp = s.Peek(); // store the top index 
                        s.Pop(); // pop the top 

                        // Calculate the area with hist[tp] 
                        // stack as smallest bar  
                        area_with_top = arr[tp] *
                                       (s.Count == 0 ? i : i - s.Peek() - 1);

                        // update max area, if needed  
                        if (max_area < area_with_top)
                        {
                            max_area = area_with_top;
                        }
                    }
                }

                // Now pop the remaining bars from  
                // stack and calculate area with every  
                // popped bar as the smallest bar  
                while (s.Count > 0)
                {
                    tp = s.Peek();
                    s.Pop();
                    area_with_top = arr[tp] *
                                   (s.Count == 0 ? i : i - s.Peek() - 1);

                    if (max_area < area_with_top)
                    {
                        max_area = area_with_top;
                    }
                }

                return max_area;
            }
    }
}
