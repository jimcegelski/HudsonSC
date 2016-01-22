using System;
using NUnit.Framework;
using StringCalculator;

namespace Tests
{
    public class StringCalculatorTests
    {
        [TestCase("", 0)]
        [TestCase("1,2", 3)]
        [TestCase("1", 1)]
        [TestCase("1 \n 2, 3", 6)]
        [TestCase("//Jim\n 1 Jim 2 Jim 3", 6)]
        [TestCase("//Stephen\n 1 Stephen 2 Stephen 3", 6)]
        [TestCase("1001, 2", 2)]
        [TestCase("2, 1004", 2)]
        [TestCase("//[Dem1][Dem2]\n 1 Dem1 2 Dem2 3 Dem1 4", 10)]
        public void StringZero(string testString, int expectedResult)
        {
            int a = Calculator.Add(testString);

            Assert.AreEqual(expectedResult, a);
        }


        [Test]
        [ExpectedException(typeof(Exception), ExpectedMessage = "Negative numbers not allowed [-20]")]
        public void StringSumNegativeFive()
        {
            int answer = Calculator.Add("-20, 15");
        }

        [Test]
        [ExpectedException(typeof(Exception), ExpectedMessage = "Negative numbers not allowed [-20, -15]")]
        public void StringSumNegativeDouble()
        {
            int answer = Calculator.Add("-20, -15");
        }
    }
}
