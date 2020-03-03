using System;
using Xunit;
using SixQuestionsDandA.Classes;

namespace XUnitDay1
{
    public class UnitTest1
    {
        [Fact]
        public void Q1Test1()
        {
            Question1 question1 = new Question1();
            int[] testOne = new int[] { 2, 7, 11, 15 };
            int[] resultOne = question1.TwoSumIterative(testOne, 9);
            int[] resultOnePT2 = question1.TwoSumEfficient(testOne, 9);
            int[] xResultX = new int[] { 2, 7 };

            Assert.Equal(xResultX, resultOne);
            Assert.Equal(xResultX, resultOnePT2);
        }

        //[Theory]
        //[InlineData({3, 2, 2, 3})]
        [Fact]
        public void Q2Test2()
        {
            Question2 question2 = new Question2();
            int[] testTwo = new int[] { 3, 2, 2, 3 };

            Assert.Equal(4, question2.InitialLength(testTwo, 3));
            Assert.Equal(2, question2.NewLength(testTwo, 3));
        }
    }
}
