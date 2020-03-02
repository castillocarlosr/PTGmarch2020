using System;
using System.Collections.Generic;
using System.Text;

namespace SixQuestionsDandA.Classes
{
    public class Question4
    {
        public int LengthLastWord(string str)
        {
            int len = 0;
            bool charFlag = false;
            for(int i = str.Length-1; i >= 0; i--)
            {
                if (char.IsLetter(str[i]))
                {
                    len++;
                }
                else
                {
                    if(charFlag == true)
                    {
                        return 0;
                    }
                }
            }
            return len;
        }
    }
}
