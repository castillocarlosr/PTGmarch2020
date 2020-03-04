using System;
using System.Collections.Generic;
using System.Text;

namespace Q3DandA.Classes
{
    public class Question2
    {
        public bool AreStringsAnagrams(string strA, string strB)
        {
            Dictionary<char, int> firstString = new Dictionary<char, int>();
            Dictionary<char, int> secondString = new Dictionary<char, int>();
            strA = strA.ToLower().Trim();
            strB = strB.ToLower().Trim();

            for (int i = 0; i < strA.Length; i++)
            {
                if (Char.IsLetter(strA[i]))
                {
                    if (firstString.ContainsKey(strA[i]))
                    {
                        firstString[strA[i]] += 1;
                    }
                    else
                    {
                        firstString[strA[i]] = 1;
                    }
                }
            }

            for (int i = 0; i < strB.Length; i++)
            {
                if (Char.IsLetter(strB[i]))
                {
                    if (secondString.ContainsKey(strB[i]))
                    {
                        secondString[strB[i]] += 1;
                    }
                    else
                    {
                        secondString[strB[i]] = 1;
                    }
                }

            }
            //base case 
            if (firstString.Count != secondString.Count)
            {
                return false;
            }
            else
            {
                foreach (KeyValuePair<char, int> letterValue in secondString)
                {
                    if (firstString.ContainsKey(letterValue.Key))
                    {
                        if (firstString[letterValue.Key] != secondString[letterValue.Key])
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
