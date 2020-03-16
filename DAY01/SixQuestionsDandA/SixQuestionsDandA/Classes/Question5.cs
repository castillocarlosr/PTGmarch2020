using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

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
                //Regex rgx = new Regex("[^a-zA-Z0-9]");
                //str = rgx.Replace(str, "");
                str = str.Trim().ToLower();
                int i = 0;
                int j = str.Length - 1;
                while(i < j)
                {
                    while(!Char.IsLetter(str[i]))
                    {
                        i++;
                    }
                    while (!Char.IsLetter(str[j]))
                    {
                        j--;
                    }

                    if (str[i] != str[j])
                    {
                        return false;
                    }
                    i++;
                    j--;
                }
                return true;
                
                /*
                if (str[0] != str[str.Length - 1])
                {
                    return false;
                }
                else
                {
                    return ValidPalindrome(str.Substring(1, str.Length - 2));
                }
                */
            }
        }
    }
}
