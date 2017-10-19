using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzProject;

namespace FizzBuzzTests
{
    [TestClass]
    public class FizzBuzzShould
    {
        private FizzBuzzClass _fizzBuzzClass;
        private List<string> _testResult;

        [TestInitialize]
        public void SetUp()
        {
            _fizzBuzzClass = new FizzBuzzClass();
            _testResult = _fizzBuzzClass.FizzBuzz();
        }

        [TestMethod]
        public void ReturnListOf100Strings()
        {
            Assert.AreEqual(100, _testResult.Count, "The result should have 100 strings");
        }

        [TestMethod]
        public void IsNumberDivisibleByThree()
        {
            Assert.IsTrue(_testResult[2] == "Fizz");
            Assert.IsTrue(_testResult[5] == "Fizz");
            Assert.IsTrue(_testResult[8] == "Fizz");
        }

        [TestMethod]
        public void IsNumberDisivibleByFive()
        {
            Assert.IsTrue(_testResult[4] == "Buzz");
            Assert.IsTrue(_testResult[9] == "Buzz");
            Assert.IsTrue(_testResult[19] == "Buzz");
        }

        [TestMethod]
        public void IsNumberDivisiblebyFifteen()
        {
            Assert.IsTrue(_testResult[14] == "FizzBuzz");
        }
    }
}
