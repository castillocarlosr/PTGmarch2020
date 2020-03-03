using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SixQuestionsDandA.Classes
{
    public class Question6
    {
        public bool HashMapCharacterValidation(string str)
        {
            if(str == "")
            {
                return true;
            }
            else
            {
                Dictionary<string, int> hashMapBracket = new Dictionary<string, int>{ { "{", 0 },{ "[", 0 },{ "(", 0 }};
                int zeroCount = 0;
                for (int i = 0; i < str.Length-1; i++)
                {
                    if(str[i] == '{')
                    {
                        int curlyValue = hashMapBracket.GetValueOrDefault("{");
                        hashMapBracket["{"] = curlyValue++;
                        /*
                        if(hashMapBracket.GetValueOrDefault("{") != 0)
                        {
                            zeroCount++;
                        }
                        */
                    }
                    if (str[i] == '}')
                    {
                        int curlyValue = hashMapBracket.GetValueOrDefault("{");
                        hashMapBracket["{"] = curlyValue--;
                        /*
                        if (hashMapBracket.GetValueOrDefault("{") != 0)
                        {
                            zeroCount++;
                        }
                        */
                    }
                    if (str[i] == '[')
                    {
                        int bracketValue = hashMapBracket.GetValueOrDefault("[");
                        hashMapBracket["["] = bracketValue++;
                        /*
                        if (hashMapBracket.GetValueOrDefault("[") != 0)
                        {
                            zeroCount++;
                        }
                        */
                    }
                    if (str[i] == ']')
                    {
                        int bracketValue = hashMapBracket.GetValueOrDefault("[");
                        hashMapBracket["["] = bracketValue--;
                        /*
                        if (hashMapBracket.GetValueOrDefault("[") != 0)
                        {
                            zeroCount++;
                        }
                        */
                    }
                    if (str[i] == '(')
                    {
                        int paranthesisValue = hashMapBracket.GetValueOrDefault("(");
                        hashMapBracket["("] = paranthesisValue++;
                        /*
                        if (hashMapBracket.GetValueOrDefault("(") != 0)
                        {
                            zeroCount++;
                        }
                        */
                    }
                    if (str[i] == ')')
                    {
                        int paranthesisValue = hashMapBracket.GetValueOrDefault("(");
                        hashMapBracket["("] = paranthesisValue--;
                        /*
                        if (hashMapBracket.GetValueOrDefault("(") != 0)
                        {
                            zeroCount++;
                        }*/
                    }
                }
                if (hashMapBracket.GetValueOrDefault("(") != 0 || hashMapBracket.GetValueOrDefault("[") != 0 || hashMapBracket.GetValueOrDefault("{") != 0)
                {
                    zeroCount++;
                }
                return zeroCount == 0 ? true : false;
            }
        }
        /***********************************************************************************************/
        public bool CharterValidation(string str)
        {
            if (str == "")
            {
                return true;
            }
            else
            {
                Stack<char> stack = new Stack<char>();
                char[] inputChar = str.ToCharArray();

                char[] eventCharacters = { '[', '{', '(', ']', '}', ')' };
                var bracket = (open: '[', close: ']');
                var curled = (open: '{', close: '}');
                var parenthesis = (open: '(', close: ')');

                for (int i = 0; i < inputChar.Length; i++)
                {
                    if (!eventCharacters.Contains(inputChar[i]))
                        continue;
                    else if (inputChar[i] == bracket.close)
                    {
                        char x = stack.Peek();
                        if (x == bracket.open)
                            stack.Pop();
                    }
                    else if (inputChar[i] == curled.close)
                    {
                        char x = stack.Peek();
                        if (x == curled.open)
                            stack.Pop();
                    }
                    else if (inputChar[i] == parenthesis.close)
                    {
                        char x = stack.Peek();
                        if (x == parenthesis.open)
                            stack.Pop();
                    }
                    else
                        stack.Push(inputChar[i]);
                }
                try
                {
                    stack.Pop();
                }
                catch (Exception)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
