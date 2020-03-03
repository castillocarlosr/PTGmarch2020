using System;
using System.Collections.Generic;
using System.Text;

namespace Question7.Classes
{
    public class QuestionSeven
    {
        public string NumbersToWords(int number)
        {
            if(number == 0)
            {
                return "zero";
            }

            if(number < 0)
            {
                return "negative " + NumbersToWords(Math.Abs(number));
            }

            string words = "";

            if(number / 1000000 > 0)
            {
                words += NumbersToWords(number / 1000000) + "million ";
                //number = number % 1000000;
                number %= 1000000;
            }

            if(number / 1000 > 0)
            {
                words += NumbersToWords(number / 1000) + "thousand ";
                number %= 1000;
            }

            if(number / 100 > 0)
            {
                words += NumbersToWords(number / 100) + "hundred ";
                number %= 100;
            }

            if(number > 0)
            {
                if (words != "")
                {
                    words += "and ";
                }

                var singlesMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
                if(number < 20)
                {
                    words += singlesMap[number];
                }
                else
                {
                    words += tensMap[number / 10];
                    if((number % 10) > 0)
                    {
                        words += "-" + singlesMap[number % 10];
                    }
                }
            }
            return words;
        }
    }
}
