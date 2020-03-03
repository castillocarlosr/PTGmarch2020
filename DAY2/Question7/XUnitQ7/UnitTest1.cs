using System;
using Xunit;
using Question7.Classes;

namespace XUnitQ7
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            QuestionSeven questionSeven = new QuestionSeven();

            Assert.Equal("five", questionSeven.NumbersToWords(5));
        }
        [Fact]
        public void Test2()
        {
            QuestionSeven questionSeven = new QuestionSeven();

            Assert.Equal("ninehundred and forty-three", questionSeven.NumbersToWords(943));
        }
        [Fact]
        public void TestNegative()
        {
            QuestionSeven questionSeven = new QuestionSeven();

            Assert.Equal("negative seventy-two", questionSeven.NumbersToWords(-72));
        }
        [Fact]
        public void TestBig()
        {
            QuestionSeven questionSeven = new QuestionSeven();

            Assert.Equal("fivehundred and forty-threethousand ninehundred and eighty-seven", questionSeven.NumbersToWords(543987));
        }
    }
}
