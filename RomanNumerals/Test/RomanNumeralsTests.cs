using NUnit.Framework;
using RomanNumerals;

namespace Test
{
    public class RomanNumeralsTests
    {
        [Test]
        public void One()
        {
            Assert.AreEqual("I", RomanNumeralConverter.Convert(1));
        }

        [Test]
        public void Two()
        {
            Assert.AreEqual("II", RomanNumeralConverter.Convert(2));
        }

        [Test]
        public void Three()
        {
            Assert.AreEqual("III", RomanNumeralConverter.Convert(3));
        }

        [Test]
        public void Four()
        {
            Assert.AreEqual("IV", RomanNumeralConverter.Convert(4));
        }

        [Test]
        public void Five()
        {
            Assert.AreEqual("V", RomanNumeralConverter.Convert(5));
        }

        [Test]
        public void Six()
        {
            Assert.AreEqual("VI", RomanNumeralConverter.Convert(6));
        }

        [Test]
        public void Seven()
        {
            Assert.AreEqual("VII", RomanNumeralConverter.Convert(7));
        }

        [Test]
        public void Eight()
        {
            Assert.AreEqual("VIII", RomanNumeralConverter.Convert(8));
        }

        [Test]
        public void Nine()
        {
            Assert.AreEqual("IX", RomanNumeralConverter.Convert(9));
        }

        [Test]
        public void Ten()
        {
            Assert.AreEqual("X", RomanNumeralConverter.Convert(10));
        }
    }
}
