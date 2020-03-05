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
    }
}
