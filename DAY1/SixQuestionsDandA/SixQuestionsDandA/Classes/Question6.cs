using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SixQuestionsDandA.Classes
{
    public class Question6
    {
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

                for (int i = 0; i < inputChar.Length-1; i++)
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
