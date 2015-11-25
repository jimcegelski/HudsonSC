using NUnit.Framework;
using PrimeNumbers;

namespace Test
{
    public class Tests
    {
        [Test]
        public void Two()
        {
            Assert.AreEqual(new [] { 2 }, PrimeNumberGenerator.GetPrimeFactors(2));
        }

        [Test]
        public void Three()
        {
            Assert.AreEqual(new[] { 3 }, PrimeNumberGenerator.GetPrimeFactors(3));
        }

        [Test]
        public void Four()
        {
            Assert.AreEqual(new[] { 2, 2 }, PrimeNumberGenerator.GetPrimeFactors(4));
        }

        [Test]
        public void Six()
        {
            Assert.AreEqual(new[] { 2, 3 }, PrimeNumberGenerator.GetPrimeFactors(6));
        }

        [Test]
        public void Nine()
        {
            Assert.AreEqual(new[] { 3, 3 }, PrimeNumberGenerator.GetPrimeFactors(9));
        }

        [Test]
        public void Twelve()
        {
            Assert.AreEqual(new[] { 2, 2, 3 }, PrimeNumberGenerator.GetPrimeFactors(12));
        }

        [Test]
        public void Fifteen()
        {
            Assert.AreEqual(new[] { 3, 5 }, PrimeNumberGenerator.GetPrimeFactors(15));
        }

        [Test]
        public void Eighty()
        {
            Assert.AreEqual(new[] { 2, 2, 2, 2, 5 }, PrimeNumberGenerator.GetPrimeFactors(80));
        }
    }
}
