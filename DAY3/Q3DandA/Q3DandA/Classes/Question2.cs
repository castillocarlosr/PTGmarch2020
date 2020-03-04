using System;
using System.Collections.Generic;
using System.Text;

namespace Q3DandA.Classes
{
    public class Question2
    {
        public static bool AreStringsAnagrams(string a, string b)
        {
            Dictionary<char, int> firstString = new Dictionary<char, int>();
            Dictionary<char, int> secondString = new Dictionary<char, int>();

            foreach (char character in a)
            {
                if (firstString.ContainsKey(character))
                {
                    firstString[character] += 1;
                }
                else
                {
                    firstString[character] = 1;
                }
            }

            foreach (char character2 in b)
            {
                if (secondString.ContainsKey(character2))
                {
                    secondString[character2] += 1;
                }
                else
                {
                    secondString[character2] = 1;
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
