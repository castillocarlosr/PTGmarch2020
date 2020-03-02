using System;
using System.Collections.Generic;
using System.Text;

namespace SixQuestionsDandA.Classes
{
    public class Question5
    {
        public bool ValidPalindrome(string str)
        {
            if(str.Length <= 1)
            {
                return true;
            }
            else
            {
                str = str.Trim().ToLower();
                if (str[0] != str[str.Length - 1])
                {
                    return false;
                }
                else
                {
                    return ValidPalindrome(str.Substring(1, str.Length - 2));
                }
            }
        }
    }
}
